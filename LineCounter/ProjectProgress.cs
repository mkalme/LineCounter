using System;

namespace LineCounter {
    public class ProjectProgress {
        public int Max { get; set; }
        public int Current { get; set; } = 0;
        private ProgressType _type = ProgressType.Unfinished;
        public ProgressType Type { get => _type; set {
                _type = value;

                if (value == ProgressType.Finished)
                    CallOnFinished();
            } }

        public event EventHandler OnFinished;
        private void CallOnFinished() {
            if (OnFinished != null)
                OnFinished.Invoke(this, EventArgs.Empty);
        }

        public Item RecentItem { get; set; }

        public ProjectProgress() { 
        }
        public ProjectProgress(int max) {
            Max = max;
        }
    }

    public enum ProgressType { 
        Finished,
        Unfinished
    }
}
