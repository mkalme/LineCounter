using System;
using System.IO;
using System.Linq;
using System.ComponentModel;
using System.Windows.Forms;
using System.Collections.Generic;
using LineCounter;

namespace GUI {
    public class ExplorerProfile {
        public List<ItemView> Views { get; set; }
        private int CurrentIndex { get; set; } = 0;
        public ItemView CurrentView => Views[CurrentIndex];

        //EventHandler
        public event EventHandler OnUpdate;
        private void CallOnUpdate(){
            if (OnUpdate != null)
                OnUpdate.Invoke(CurrentView, EventArgs.Empty);
        }

        public ExplorerProfile(ItemCollection collection) {
            Views = new List<ItemView>() { new ItemView(collection) };
        }

        public void Open(Item item) {
            ItemView view = ItemView.FromItem(item);

            if (CurrentIndex >= Views.Count - 1) {  //If current view is the last view
                Views.Add(view);
                CurrentIndex++;

                CallOnUpdate();
                return;
            }

            if (Views[CurrentIndex + 1].Equals(item)) { //If next view already contains the item 
                CurrentIndex++;

                CallOnUpdate();
                return;
            } else {
                Views.RemoveRange(CurrentIndex + 1, Views.Count - CurrentIndex - 1);
                Views.Add(view);
                CurrentIndex++;

                CallOnUpdate();
                return;
            }
        }

        public void Next() {
            if (CurrentIndex >= Views.Count - 1) return;
            
            CurrentIndex++;
            CallOnUpdate();
        }
        public void Prev() {
            if (CurrentIndex < 1) return;
            
            CurrentIndex--;
            CallOnUpdate();
        }
    }

    public class ItemView { 
        public Item BaseItem { get; set; }
        public List<Item> Items { get; set; }
        public ViewType Type { get; set; }

        public Selection Selection { get; set; }
        public Sort Sort { get; set; } = new Sort();

        public ItemView(ItemCollection collection) {
            BaseItem = collection;
            Items = collection.Items;
            Type = ViewType.Item;
        }
        public ItemView(Solution solution){
            BaseItem = solution;

            Items = new List<Item>();
            Items.AddRange(solution.Projects);

            Type = ViewType.Directory;
        }
        public ItemView(Project project) : this(project.SourceDirectory){
            BaseItem = project;
            Type = ViewType.Directory;
        }
        public ItemView(SourceDirectory directory) {
            BaseItem = directory;

            Items = new List<Item>();
            Items.AddRange(directory.Directories);
            Items.AddRange(directory.Files);

            Type = ViewType.Directory;
        }

        public static ItemView FromItem(Item item) {
            Type type = item.GetType();

            if (type == typeof(Solution)) return new ItemView((Solution)item);
            if (type == typeof(Project)) return new ItemView((Project)item);
            if (type == typeof(SourceDirectory)) return new ItemView((SourceDirectory)item);

            return null;
        }

        public int GetSelectedIndex() {
            if (Selection == null) return -1;

            for (int i = 0; i < Items.Count; i++) {
                if (Selection.IsItem(Items[i])) return i;
            }

            return -1;
        }
        public bool Equals(Item item) {
            if (Type == ViewType.Item) return false;

            return BaseItem.Equals(item);
        }
        public List<Item> SortItems() {
            if (Sort.ColumnIndex < 0) return Items;

            IEnumerable<Item> items = Items;
            switch (Sort.ColumnIndex) {
                case 1:
                    items = Items.OrderBy(o => Path.GetFileName(o.Path));
                    break;
                case 2:
                    items = Items.OrderBy(o => o.Path);
                    break;
                case 3:
                    items = Items.OrderBy(o => o.GetLineCount());
                    break;
                case 4:
                    items = Items.OrderBy(o => o.GetItemType());
                    break;
                case 5:
                    items = Items.OrderBy(o => o.GetCreationDate());
                    break;
            }

            if (Sort.Order == ListSortDirection.Descending) items = items.Reverse();

            return items.ToList();
        }
    }

    public class Selection { 
        public string Path { get; set; }
        public ItemType Type { get; set; }

        public Selection(string path, ItemType type) {
            Path = path;
            Type = type;
        }
        public Selection(Item item) {
            Path = item.Path;

            if (item.GetType() == typeof(SourceFile)) Type = ItemType.File;
            else Type = ItemType.Directory;
        }

        public bool IsItem(Item item) {
            if (Path != item.Path) return false;

            ItemType type = item.GetType() == typeof(SourceFile) ? ItemType.File : ItemType.Directory;

            return type == Type;
        }

        public static implicit operator Selection(Item item) {
            if (item == null) return null;
            return new Selection(item);
        }
    }
    public enum ItemType { 
        File,
        Directory
    }

    public enum ViewType { 
        Item,
        Directory
    }

    public class Sort {
        public int ColumnIndex { get; set; }
        public ListSortDirection Order { get; set; }

        public Sort() {
            ColumnIndex = -1;
            Order = ListSortDirection.Descending;
        }
        public Sort(int columnIndex, ListSortDirection order) {
            ColumnIndex = columnIndex;
            Order = order;
        }

        public static implicit operator Sort(DataGridView dataGridView){
            Sort sort = new Sort();

            sort.ColumnIndex = dataGridView.SortedColumn == null ? -1 : dataGridView.SortedColumn.Index;

            if (dataGridView.SortOrder == SortOrder.Descending) sort.Order = ListSortDirection.Descending;
            else sort.Order = ListSortDirection.Ascending;

            return sort;
        }
    }
}
