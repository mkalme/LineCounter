using System;
using System.Threading;
using System.ComponentModel;
using System.Windows.Forms;
using LineCounter;

namespace GUI {
    public partial class ProjectLoadingDialog : Form {
        private BackgroundWorker BackgroundWorker { get; set; }

        public string Path {
            get => PathTextBox.Text;
            set {
                PathTextBox.Text = value;
                FolderBrowserDialog.SelectedPath = value;
            }
        }
        public ItemCollection Collection { get; set; }

        public ProjectLoadingDialog(string path = "")
        {
            InitializeComponent();

            BackgroundWorker = new BackgroundWorker();
            
            BackgroundWorker.DoWork += BackgroundWorker_DoWork;
            BackgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged;
            BackgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
            
            BackgroundWorker.WorkerReportsProgress = true;
            BackgroundWorker.WorkerSupportsCancellation = true;

            Path = path;
        }

        private void ProjectLoadingDialog_Shown(object sender, EventArgs e){
            SelectButton.Focus();
        }

        private void BrowseButton_Click(object sender, EventArgs e){
            FolderBrowserDialog.ShowDialog();
            PathTextBox.Text = FolderBrowserDialog.SelectedPath;
        }
        private void SelectButton_Click(object sender, EventArgs e){
            if (BackgroundWorker.IsBusy) return;
            
            Height += ProgressPanel.Height;

            StartLoading();
        }

        //Loading
        private void StartLoading(){
            _progress = new ProjectProgress();
            _progress.OnFinished += new EventHandler(Progress_OnFinished);

            Thread thread = new Thread(() => {
                Collection = new ItemCollection(Path, _progress);
            });
            thread.Start();

            BackgroundWorker.RunWorkerAsync();
        }

        private ProjectProgress _progress;
        private void Progress_OnFinished(object sender, EventArgs e){
            BackgroundWorker.CancelAsync();
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e){
            while (!BackgroundWorker.CancellationPending) {
                Thread.Sleep(10);

                BackgroundWorker.ReportProgress(0, _progress);
            }
        }
        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e){
            ProgressBar.Width = (int)(_progress.Current / (float)_progress.Max * ProgressPanel.Width);
        }
        private void BackgroundWorker_RunWorkerCompleted(object semder, AsyncCompletedEventArgs e) {
            Close();
        }
    }
}
