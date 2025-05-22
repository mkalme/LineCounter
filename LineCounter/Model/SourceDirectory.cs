using System;
using System.Collections.Generic;

namespace LineCounter {
    public class SourceDirectory : Item {
        public List<SourceDirectory> Directories { get; set; }
        public List<SourceFile> Files { get; set; }

        public SourceDirectory(string path) : base(path) {
            Directories = new List<SourceDirectory>();
            Files = new List<SourceFile>();
        }

        public override int GetLineCount(){
            int count = 0;

            Directories.ForEach(x => count += x.GetLineCount());
            Files.ForEach(x => count += x.GetLineCount());

            return count;
        }
        public override string GetItemType(){
            return "Directory";
        }
        public override void Refresh(){
            Directories.ForEach(x => x.Refresh());
            Files.ForEach(x => x.Refresh());
        }
        public SourceDirectory GetRootDirectory() {
            if (_parent.GetType() != typeof(SourceDirectory)) return this;

            return ((SourceDirectory)_parent).GetRootDirectory();
        }
    }
}
