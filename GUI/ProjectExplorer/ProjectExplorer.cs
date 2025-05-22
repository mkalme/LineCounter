using System;
using System.Collections.Generic;
using System.Globalization;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using LineCounter;

namespace GUI {
    public partial class ProjectExplorer : UserControl {
        private ExplorerProfile Profile { get; set; }
        private Item SelectedItem { get {
                if (ExplorerGrid.SelectedRows.Count < 1) return null;

                int index = (int)ExplorerGrid.SelectedRows[0].Cells[0].Value;
                return Profile.CurrentView.Items[index];
            } }

        public ProjectExplorer(ExplorerProfile profile)
        {
            InitializeComponent();
            InitializeUserComponent();

            InstantiateExplorer(profile);
        }
        private void InitializeUserComponent() {
            //ExplorerGrid
            ExplorerGrid.DoubleBuffered(true);

            var creationDateCol = ExplorerGrid.Columns["CreationDateCol"];
            creationDateCol.DefaultCellStyle.Format = "MMM dd, yyyy";
            creationDateCol.DefaultCellStyle.FormatProvider = CultureInfo.InvariantCulture;

            ExplorerGrid.Columns["LinesCol"].DefaultCellStyle.Format = "N0";

            ExplorerGridMenuStrip.Renderer = new MyToolStripRenderer();
        }

        private void InstantiateExplorer(ExplorerProfile profile) {
            Profile = profile;
            Profile.OnUpdate += new EventHandler(Profile_OnUpdate);

            DisplayExplorer(Profile.CurrentView);
        }

        private void ProjectExplorer_Load(object sender, EventArgs e){
            ExplorerGrid.ClearSelection();
        }

        //ProjectExplorer
        public void DisplayExplorer(ItemView view){
            DisplayGrid(view);

            PathTextBox.Text = view.BaseItem.Path;
            InformationLabel.Text = $"Total lines of code: {ViewHelper.ParseInteger(view.BaseItem.GetLineCount())}";
        }

        public void Profile_OnUpdate(object sender, EventArgs e) {
            DisplayExplorer((ItemView)sender);
        }

        //ExplorerGrid
        public void DisplayGrid(ItemView view) {
            _canUpdate = false;

            ExplorerGrid.Rows.Clear();
            for (int i = 0; i < view.Items.Count; i++) {
                Item item = view.Items[i];

                ExplorerGrid.Rows.Add(
                    i,
                    Path.GetFileName(item.Path),
                    ViewHelper.TrimPath(Profile.CurrentView.BaseItem, item.Path),
                    item.GetLineCount(),
                    item.GetItemType(),
                    item.GetCreationDate()
                );

                ((TextAndImageCell)ExplorerGrid.Rows[i].Cells[1]).Image = item.GetIcon();
            }

            //Sort
            if (view.Sort.ColumnIndex > -1) {
                ExplorerGrid.Sort(ExplorerGrid.Columns[view.Sort.ColumnIndex], view.Sort.Order);
            }

            //Select
            ExplorerGrid.ClearSelection();
            SelectRow(view.GetSelectedIndex());

            //Show
            if (ExplorerGrid.SelectedRows.Count > 0) {
                ExplorerGrid.FirstDisplayedScrollingRowIndex = ExplorerGrid.SelectedRows[0].Index;
            }

            ActiveteHover();

            _canUpdate = true;
        }
        private void SelectRow(int index) {
            foreach (DataGridViewRow row in ExplorerGrid.Rows) {
                if ((int)row.Cells[0].Value == index) {
                    row.Selected = true;

                    return;
                }
            }
        }
        private void ActiveteHover() {
            Point cursor = ExplorerGrid.PointToClient(Cursor.Position);
            var hitTest = ExplorerGrid.HitTest(cursor.X, cursor.Y);

            if (hitTest.RowIndex < 0) return;

            ExplorerGrid_CellMouseEnter(ExplorerGrid, new DataGridViewCellEventArgs(hitTest.ColumnIndex, hitTest.RowIndex));
        }

        private bool _canUpdate = true;
        private void ExplorerGrid_SelectionChanged(object sender, EventArgs e){
            if (!_canUpdate) return;
            
            Profile.CurrentView.Selection = SelectedItem;
        }

        private void ExplorerGrid_MouseDown(object sender, MouseEventArgs e){
            var hitTest = ExplorerGrid.HitTest(e.X, e.Y);

            if (hitTest.Type != DataGridViewHitTestType.Cell &&
                hitTest.Type != DataGridViewHitTestType.ColumnHeader) {
                ExplorerGrid.ClearSelection();
                return;
            }
            
            if(e.Button == MouseButtons.Right){
                if (hitTest.Type == DataGridViewHitTestType.ColumnHeader) return;

                ExplorerGrid.ClearSelection();
                ExplorerGrid.Rows[hitTest.RowIndex].Selected = true;
            }
        }
        private void ExplorerGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e){
            Item selectedItem = SelectedItem;
            if (selectedItem == null || e.RowIndex < 0) return;

            if (selectedItem.GetType() == typeof(SourceFile)) {
                OpenItem(selectedItem);
                return;
            }

            Profile.Open(selectedItem);
        }

        private void ExplorerGrid_Sorted(object sender, EventArgs e){
            if (!_canUpdate) return;

            Profile.CurrentView.Sort = ExplorerGrid;
        }

        //Hover
        private void ExplorerGrid_CellMouseEnter(object sender, DataGridViewCellEventArgs e){
            if (e.RowIndex < 0) return;

            ExplorerGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(60, 60, 60);
        }
        private void ExplorerGrid_CellMouseLeave(object sender, DataGridViewCellEventArgs e){
            if (e.RowIndex < 0) return;

            ExplorerGrid.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(45, 45, 45);
        }

        //Left-Right & Misc buttons
        private void BackButton_Click(object sender, EventArgs e){
            Profile.Prev();
        }
        private void ForwardButton_Click(object sender, EventArgs e){
            Profile.Next();
        }

        private void RefreshButton_Click(object sender, EventArgs e){

        }

        private void CopyClipboardButton_Click(object sender, EventArgs e){
            List<Item> items = Profile.CurrentView.SortItems();

            CopyItemsToClipboard(items);
        }
        private void BrowseButton_Click(object sender, EventArgs e){
            ProjectLoadingDialog dialog = new ProjectLoadingDialog(Profile.CurrentView.BaseItem.Path);
            dialog.ShowDialog();

            if (dialog.Collection == null) return;

            InstantiateExplorer(new ExplorerProfile(dialog.Collection));
        }

        //Open File/Directory
        private void OpenInFileExplorer(Item item) {
            if (item == null) return;

            if (item.GetType() == typeof(SourceFile)) {
                string argument = $"/select, \"{item.Path}\"";
                Process.Start("explorer.exe", argument);
                
                return;
            }

            Process.Start(item.Path);
        }
        private void OpenItem(Item item) {
            if (item == null) return;

            Process.Start(item.Path);
        }

        private void CopyItemsToClipboard(List<Item> items) {
            if (items.Count < 1) {
                Clipboard.SetText(" ");
                return;
            }

            string[] lines = new string[items.Count];
            for (int i = 0; i < lines.Length; i++) {
                Item item = items[i];

                string name = Path.GetFileName(item.Path);
                int lineCount = item.GetLineCount();
                string creationDate = item.GetCreationDate().ToString(FormatHelper.DateFormat);

                lines[i] = $"{name}\t{lineCount}\t{creationDate}";
            }

            Clipboard.SetText(String.Join("\n", lines));
        }

        //ExplorerMenuStrip
        private void ExplorerGridMenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Item item = SelectedItem;
            if (item == null) item = Profile.CurrentView.BaseItem;

            OpenProgramStripItem.Enabled = item.GetType() == typeof(SourceFile);
        }

        private void OpenFileStripItem_Click(object sender, EventArgs e){
            Item item = SelectedItem;
            if (item == null) item = Profile.CurrentView.BaseItem;

            OpenInFileExplorer(item);

        }
        private void OpenProgramStripItem_Click(object sender, EventArgs e){
            Item item = SelectedItem;
            if (item == null) item = Profile.CurrentView.BaseItem;

            OpenItem(item);
        }
    }
}
