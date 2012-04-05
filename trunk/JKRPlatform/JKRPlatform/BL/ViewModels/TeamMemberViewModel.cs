using System;
using System.Collections.Generic;
using System.Linq;

namespace BugTrackerDemo.ViewModels
{
    public class TeamMemberViewModel : TeamObjectViewModel, IInfoProvider
	{
		private TeamViewModel team;
		private IEnumerable<BugViewModel> assignedBugs;
		private string name;
		private bool isCompared;

		/// <summary>
		/// Gets or sets the team of the person.
		/// </summary>
		public TeamViewModel Team
		{
			get
			{
				return this.team;
			}
			set
			{
				if (this.team != value)
				{
					this.team = value;
					OnPropertyChanged("Team");
				}
			}
		}

		/// <summary>
		/// Gets or sets true.
		/// </summary>
		public IEnumerable<BugViewModel> AssignedBugs
		{
			get
			{
				// #Lazy: Notice how all property getters are initialized in a lazy way.
				return this.assignedBugs ?? (this.assignedBugs = 
					BugTrackerViewModel.Instance.AllBugs.Where(bug => bug.Owner == this));
			}
		}

		/// <summary>
		/// Gets or sets the name of the team member.
		/// </summary>
		public string FullName
		{
			get
			{
				return this.name;
			}
			set
			{
				if (this.name != value)
				{
					this.name = value;
					OnPropertyChanged("FullName");
				}
			}
		}

        /// <summary>
        ///     Gets or sets whether the item is actively compared.
        /// </summary>
        public bool IsCompared
        {
            get
            {
                return this.isCompared;
            }
            set
            {
                if (this.isCompared != value)
                {
                    this.isCompared = value;
                    OnPropertyChanged("IsCompared");
                }
            }
        }

        public override string ToString()
        {
			return this.name;
        }
	}
}
