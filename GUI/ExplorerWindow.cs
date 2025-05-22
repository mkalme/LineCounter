using System;
using System.Windows.Forms;
using LineCounter;

namespace GUI {
    public partial class ExplorerWindow : Form {
        public ExplorerWindow(ItemCollection collection)
        {
            InitializeComponent();

            ProjectExplorer explorer = new ProjectExplorer(new ExplorerProfile(collection));
            explorer.Dock = DockStyle.Fill;

            ExplorerContainer.Controls.Add(explorer);
        }
    }
}
