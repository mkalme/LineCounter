using System;

namespace LineCounter {
    public abstract class Item {
        public string Path { get; set; }

        internal Item _parent;
        public Item Parent => _parent;

        public Item(string path) {
            Path = path;
        }

        public abstract int GetLineCount();
        public abstract string GetItemType();
        public abstract void Refresh();

        public bool Equals(Item item) {
            return Path.Equals(item.Path);
        }
    }
}
