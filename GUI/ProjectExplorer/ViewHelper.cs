using System;
using System.Drawing;
using System.IO;
using LineCounter;

namespace GUI {
    public static class ViewHelper {
        public static string ParseInteger(int value) {
            return string.Format("{0:n0}", value);
        }
        public static string TrimPath(Item baseItem, string path) {
            Type type = baseItem.GetType();

            if (type == typeof(ItemCollection)) {
                return baseItem.Path.SubstringPath(path);
            } else if (type == typeof(Solution) || type == typeof(Project)) {
                return Path.GetDirectoryName(baseItem.Path).SubstringPath(path);
            } else if (type == typeof(SourceDirectory)) {
                SourceDirectory dir = baseItem as SourceDirectory;

                return dir.GetRootDirectory().Path.SubstringPath(path);
            }

            return path;
        }
        private static string SubstringPath(this string path1, string path2) {
            if (path1.Length >= path2.Length) return path2;

            return path2.Substring(path1.Length + 1, path2.Length - path1.Length - 1);
        }
    }

    public static class ItemExtension {
        public static DateTime GetCreationDate(this Item item) {
            DateTime time;

            Type type = item.GetType();

            if (type == typeof(SourceFile)) time = File.GetCreationTime(item.Path);
            else time = Directory.GetCreationTime(item.Path);

            return time;
        }
        public static Image GetIcon(this Item item) {
            Type type = item.GetType();

            if (type == typeof(Solution)) return Properties.Resources.SolutionIcon;
            if (type == typeof(SourceFile)) return Properties.Resources.SourceFileIcon;
            if (type == typeof(SourceDirectory)) return Properties.Resources.FolderIcon;

            if (type == typeof(Project)) {
                ProjectType projType = ((Project)item).Type;

                switch (projType) {
                    case ProjectType.ConsoleApp:
                        return Properties.Resources.ConsoleProjectIcon;
                    case ProjectType.ClassLibrary:
                        return Properties.Resources.LibraryProjectIcon;
                    case ProjectType.WinFormsApp:
                        return Properties.Resources.WindowsFormsProjectIcon;
                    default:
                        return Properties.Resources.WindowsFormsProjectIcon;
                }
            }


            return Properties.Resources.FolderIcon;
        }
    }
}
