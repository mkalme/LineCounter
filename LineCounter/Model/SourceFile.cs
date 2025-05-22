using System;
using System.IO;

namespace LineCounter {
    public class SourceFile : Item {
        private int _lineCount;

        public SourceFile(string path) : base(path) {
            _lineCount = File.ReadAllLines(path).Length;
        }

        public override string GetItemType()
        {
            return "Source file";
        }
        public override int GetLineCount(){
            return _lineCount;
        }
        public override void Refresh(){
            _lineCount = File.ReadAllLines(Path).Length;
        }
        public SourceDirectory GetRootDirectory(){
            return ((SourceDirectory)_parent).GetRootDirectory();
        }
    }
}
