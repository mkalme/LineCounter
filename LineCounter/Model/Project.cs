using System;
using System.Xml;
using System.IO;

namespace LineCounter
{
    public class Project : Item {
        public ProjectType Type { get; set; }
        public SourceDirectory SourceDirectory { get; set; }

        public Project(string path) : base(path) {
            string[] csproj = Directory.GetFiles(path, "*.csproj");
            if (csproj.Length < 1) throw new FileNotFoundException("The dictionary doesn't contain the project source file.");

            Type = GetProjectType(csproj[0]);
            SourceDirectory = ProjectHelper.GetDirectory(this);
            SourceDirectory._parent = this;
        }

        public override int GetLineCount() => SourceDirectory.GetLineCount();

        public static bool IsProject(string path){
            if (System.IO.Path.GetFileName(path) == ".vs") return false;

            return Directory.GetFiles(path, "*.csproj").Length > 0;
        }
        public static ProjectType GetProjectType(string projectSourceFile) {
            XmlTextReader xmlReader = new XmlTextReader(projectSourceFile);
            xmlReader.Namespaces = false;
            
            XmlDocument document = new XmlDocument();
            document.Load(xmlReader);

            XmlNode outputNode = document.SelectSingleNode("//Project/PropertyGroup/OutputType");
            if (outputNode != null) {
                switch (outputNode.InnerText) {
                    case "Exe":
                        return ProjectType.ConsoleApp;
                    case "WinExe":
                        return ProjectType.WinFormsApp;
                    case "Library":
                        return ProjectType.ClassLibrary;
                    default:
                        return ProjectType.None;
                }
            }

            return ProjectType.None;
        }

        public override string GetItemType(){
            switch (Type) {
                case ProjectType.ClassLibrary:
                    return "Library project";
                case ProjectType.ConsoleApp:
                    return "Console project";
                case ProjectType.WinFormsApp:
                    return "WinForms project";
                default:
                    return "Unrecognized";
            }
        }

        public override void Refresh(){
            SourceDirectory.Refresh();
        }
    }

    public enum ProjectType { 
        ConsoleApp,
        ClassLibrary,
        WinFormsApp,
        None
    }
}
