using System;
using System.IO;

namespace LineCounter {
    static class WinFormsProject {
        public static SourceDirectory GetDirectory(string path){
            SourceDirectory directory = new SourceDirectory(path);

            string[] directories = Directory.GetDirectories(path);
            string[] files = Directory.GetFiles(path, "*.cs");

            foreach (var dir in directories) {
                SourceDirectory srcDir = GetDirectory(dir);
                if (srcDir.Files.Count > 0) {
                    srcDir._parent = directory;
                    directory.Directories.Add(srcDir);
                }
            }

            foreach (var file in files) {
                if (!File.Exists(file)) continue;
                if (IsFileValid(file)) directory.Files.Add(new SourceFile(file) { _parent = directory });
            }

            return directory;
        }
        public static int CountLines(Project project){
            string[] files = Directory.GetFiles(project.Path, "*.cs", SearchOption.AllDirectories);

            int count = 0;
            foreach (var file in files) {
                if (IsFileValid(file)) {
                    count += File.ReadAllLines(file).Length;
                }
            }

            return count;
        }

        private static bool IsFileValid(string file){
            string noExt = Path.GetFileNameWithoutExtension(file);

            switch (noExt) {
                case "AssemblyInfo":
                    return false;
                case "Program":
                    return false;
                default:
                    return !ProjectHelper.IsDesignerFile(file);
            }
        }
    }
}
