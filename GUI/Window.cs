using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using LineCounter;
using System.Globalization;

namespace GUI {
    public partial class Window : Form {
        private readonly string SourcePath = $"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\\source";
        private List<Solution> Solutions { get; set; }

        public Window()
        {
            InitializeComponent();

            FolderBrowserDialog.SelectedPath = SourcePath;
            PathTextBox.Text = SourcePath;

            Solutions = new List<Solution>();
        }

        private void Window_Load(object sender, EventArgs e){
            GridView.ClearSelection();
        }

        //Action
        private void BrowseButton_Click(object sender, EventArgs e){
            FolderBrowserDialog.ShowDialog();

            PathTextBox.Text = FolderBrowserDialog.SelectedPath;
        }
        private void CountLinesButton_Click(object sender, EventArgs e){
            //Solutions = Solution.GetSolutions(PathTextBox.Text, SearchOption.AllDirectories);

            //DisplayGridView();

            //new ExplorerWindow(new ItemCollection(PathTextBox.Text)).ShowDialog();
        }

        private void CopyToClipboardLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e){
            if (Solutions.Count < 1) { 
                Clipboard.SetText(" ");
                return;
            }

            string[] lines = new string[Solutions.Count];
            for (int i = 0; i < lines.Length; i++) {
                Solution solution = Solutions[i];

                string name = Path.GetFileName(solution.Path);
                int lineCount = solution.GetLineCount();
                string creationDate = Directory.GetCreationTime(solution.Path).ToString(FormatHelper.DateFormat);

                lines[i] = $"{name}\t{lineCount}\t{creationDate}";
            }

            Clipboard.SetText(String.Join("\n", lines));
        }

        //GridView
        private void DisplayGridView() {
            GridView.Rows.Clear();

            foreach (var solution in Solutions) {
                GridView.Rows.Add(
                    Path.GetFileName(solution.Path),
                    solution.GetLineCount(),
                    Directory.GetCreationTime(solution.Path).ToString("MMM dd, yyyy", CultureInfo.InvariantCulture) 
                );
            }

            GridView.ClearSelection();
        }

        private void GridView_MouseDown(object sender, MouseEventArgs e){
            if (GridView.HitTest(e.X, e.Y).Type == DataGridViewHitTestType.None) {
                GridView.ClearSelection();
            }
        }
    }
}
