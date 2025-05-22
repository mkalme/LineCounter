using System;
using System.IO;

namespace LineCounter {
    class ProjectHelper {
        public static SourceDirectory GetDirectory(Project project) {
            switch (project.Type) {
                case ProjectType.ConsoleApp:
                    return ConsoleProject.GetDirectory(project.Path);
                case ProjectType.WinFormsApp:
                    return WinFormsProject.GetDirectory(project.Path);
                case ProjectType.ClassLibrary:
                    return LibraryProject.GetDirectory(project.Path);
                default:
                    return WinFormsProject.GetDirectory(project.Path);
            }
        }
        public static int GetLineCount(Project project) {
            switch (project.Type) {
                case ProjectType.ConsoleApp:
                    return ConsoleProject.CountLines(project);
                case ProjectType.WinFormsApp:
                    return WinFormsProject.CountLines(project);
                case ProjectType.ClassLibrary:
                    return LibraryProject.CountLines(project);
                default:
                    return WinFormsProject.CountLines(project);
            }
        }
        public static bool IsDesignerFile(string path) {
            return Path.GetExtension(Path.GetFileNameWithoutExtension(path)) == ".Designer";
        }
    }
}
