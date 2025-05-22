using System;
using System.Windows.Forms;
using LineCounter;

namespace GUI {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ProjectLoadingDialog dialog = new ProjectLoadingDialog();
            dialog.Path = $"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}\\source";
            dialog.ShowDialog();

            if(dialog.Collection != null)
                Application.Run(new ExplorerWindow(dialog.Collection));
        }
    }
}
