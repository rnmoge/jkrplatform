using System;
namespace BugTrackerDemo.ViewModels
{
	public class BugStatusViewModel : IComparable
	{
        private static BugStatusViewModel open;
		private static BugStatusViewModel closed;
		private string statusName;

		public BugStatusViewModel()
		{
			this.statusName = "Unknown";
		}

		public BugStatusViewModel(string statusName)
		{
			this.statusName = statusName;
		}

        public static BugStatusViewModel Open
        {
            get
            {
                return open ?? (open = new BugStatusViewModel("Open"));
            }
        }

        public static BugStatusViewModel Closed
        {
            get
            {
                return closed ?? (closed = new BugStatusViewModel("Closed"));
            }
        }

		public string StatusName
		{
			get
			{
				return this.statusName;
			}
		}

        public override bool Equals(object obj)
        {
            return obj != null && obj.GetType() == typeof(BugStatusViewModel) && (obj as BugStatusViewModel).StatusName == this.statusName;
        }

        public override int GetHashCode()
        {
            return this.statusName.GetHashCode();
        }

        public override string ToString()
        {
			return this.statusName;
        }

        #region IComparable Members

        public int CompareTo(object obj)
        {
            BugStatusViewModel model = obj as BugStatusViewModel;
            if (model == null)
            {
                throw new InvalidOperationException("BugStatusViewModel instance may compare to other BugStatusViewModel instances only");
            }

            return this.statusName.CompareTo(model.statusName);
        }

        #endregion
    }
}
