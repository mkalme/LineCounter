using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace LineCounter {
    public class ItemCollection : Item {
        public List<Item> Items { get; set; }

        public ItemCollection(string path, ProjectProgress progress) : base(path) {
            Items = new List<Item>();

            LoadItems(progress);
        }
        private void LoadItemsNew() {
            Items = new List<Item>();

            string[] solutions = Directory.GetFiles(Path, "*.sln", SearchOption.AllDirectories);
            string[] projects = Directory.GetFiles(Path, "*.csproj", SearchOption.AllDirectories);
            string[] files = Directory.GetFiles(Path, "*.cs", SearchOption.AllDirectories);
        
            
        }
        private void LoadItems(ProjectProgress progress) {
            string[] projects = Directory.GetFiles(Path, "*.csproj", SearchOption.AllDirectories);

            progress.Max = projects.Length;

            List<string> solutions = new List<string>();
            foreach (var proj in projects) {
                string project = System.IO.Path.GetDirectoryName(proj);
                string solDir = System.IO.Path.GetDirectoryName(project);

                if (!solutions.Contains(solDir)) {
                    if (Solution.IsSolution(solDir)) {
                        Items.Add(new Solution(solDir) { _parent = this });

                        solutions.Add(solDir);
                    } else {
                        Items.Add(new Project(project) { _parent = this });
                    }

                    progress.RecentItem = Items[Items.Count - 1];
                }

                progress.Current++;
            }

            Items = Items.OrderBy(t => new DirectoryInfo(t.Path).CreationTime).Reverse().ToList();

            progress.Type = ProgressType.Finished;
        }

        public override string GetItemType(){
            return "Collection";
        }
        public override int GetLineCount(){
            int count = 0;
            Items.ForEach(x => count += x.GetLineCount());
            return count;
        }
        public override void Refresh(){
            
        }
    }
}
