using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace LineCounter {
    public class Solution : Item {
        public List<Project> Projects { get; set; }

        public Solution(string path) : base(path) {
            Projects = new List<Project>();
            
            string[] projects = Directory.GetDirectories(path);
            foreach (var project in projects) {
                if (Project.IsProject(project)) Projects.Add(new Project(project) { _parent = this });
            }
        }

        public override int GetLineCount() {
            int count = 0;
            Projects.ForEach(x => count += x.GetLineCount());

            return count;
        }

        public static bool IsSolution(string path) {
            return Directory.GetFiles(path, "*.sln").Length > 0;
        }
        public static List<Solution> GetSolutions(string path, SearchOption searchOptions){
            List<Solution> solutions = new List<Solution>();

            if (searchOptions == SearchOption.TopDirectoryOnly) {

                string[] directories = Directory.GetDirectories(path);
                foreach (var directory in directories) {
                    if (IsSolution(directory)) solutions.Add(new Solution(directory));
                }
            } else {

                string[] slns = Directory.GetFiles(path, "*.sln", SearchOption.AllDirectories);
                foreach (var sln in slns) {
                    string directory = System.IO.Path.GetDirectoryName(sln);
                    if (IsSolution(directory)) solutions.Add(new Solution(directory));
                }
            }

            return solutions.OrderBy(t => new DirectoryInfo(t.Path).CreationTime).Reverse().ToList();
        }

        public override string GetItemType(){
            return "Solution";
        }

        public override void Refresh(){
            Projects.ForEach(x => x.Refresh());
        }
    }
}
