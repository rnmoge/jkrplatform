using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using BugTrackerDemo.Models;
//using BugTrackerDragDrop.Utils;

namespace BugTrackerDemo.ViewModels
{
	/// <summary>
	/// The BugTracker application view model.
	/// </summary>
	public class BugTrackerViewModel : ViewModelBase /*, ISingleInstance*/
	{
		private static BugTrackerViewModel instance;

		private IEnumerable<BugViewModel> selectedBugs;
		private BugViewModel selectedBug;
		private IEnumerable<TeamViewModel> allTeams;
        private IList<BugViewModel> unassignedBugs;
		private IEnumerable<object> comparedItems;
        private IEnumerable<TeamObjectViewModel> teamsAndMembers;
		private IList<BugViewModel> allBugs;
		private IEnumerable<TeamMemberViewModel> allTeamMembers;
		private IEnumerable<BugStatusViewModel> allStatuses;

		public BugTrackerViewModel()
		{
			if (instance == null)
			{
				instance = this;
			}

			//TODO: Use a real data source if not in design-time.
			this.DataSource = new DemoDataSource();
		}

	
		public static BugTrackerViewModel Instance
		{
			get
			{
				return instance;
			}
		}

		/// <summary>
		/// Gets or sets the bugs that have been opened by the user.
		/// </summary>
		public IEnumerable<BugViewModel> SelectedBugs
		{
			get
			{
				// #BindsbleSelectedItems: Notice how the collection of selected
				// items is set declaratively, we only need to flip item's
				// IsSelected property to add it to the SelectedBugs collection, the
				// BindableLinq will do the rest.
				return this.selectedBugs ?? (this.selectedBugs = 
					this.AllBugs.Where(bug => bug.IsSelected));
			}
		}

		/// <summary>
		/// Gets or sets the bug that is vurrently visible and selected..
		/// </summary>
		public BugViewModel SelectedBug
		{
			get
			{
				return this.selectedBug;
			}
			set
			{
				if (this.selectedBug != value)
				{
					this.selectedBug = value;
					OnPropertyChanged("SelectedBug");
				}
			}
		}

		/// <summary>
		/// Gets or sets the bugs that do not have an owner.
		/// </summary>
		public IList<BugViewModel> UnassignedBugs
		{
			get
			{
                // #BindableConcat: If we need to bind to the concatenation of
                // two collections, we simply need to set them as bindable and
                // bind to their concatenation. Adding and removing items fro
                // mthe source collection will be synced with the resulting
                // collections.
				return this.unassignedBugs ?? (this.unassignedBugs = 
					this.AllBugs.Where(bug => bug.Owner == BugViewModel.UnassignedBugsOwner).ToList());
			}
		}

        /// <summary>
        /// Gets or sets the bugs that do not have an owner.
        /// </summary>
        public IEnumerable<object> ComparedItems
        {
            get
            {
				return this.comparedItems ?? (this.comparedItems =
					this.AllTeams.Where(team => team.IsCompared).Cast<object>()
					.Concat(this.AllTeamMembers.Where(member => member.IsCompared).Cast<object>()));
            }
        }

		/// <summary>
		/// Gets or sets the teams and memebers.
		/// </summary>
        public IEnumerable<TeamObjectViewModel> TeamsAndMembers
		{
			get
			{
				return this.teamsAndMembers ?? (this.teamsAndMembers =
                    this.AllTeams.Where(team => team.ParentTeam == null).Cast<TeamObjectViewModel>().Concat(this.AllTeamMembers.Where(member => member.Team == null).Cast<TeamObjectViewModel>()));
			}
		}

		/// <summary>
		/// Gets or sets all the available bugs.
		/// </summary>
		public IList<BugViewModel> AllBugs
		{
			get
			{
				return this.allBugs ?? (this.allBugs = this.DataSource.Bugs);
			}
		}

		/// <summary>
		/// Gets or sets all the team members currently visible.
		/// </summary>
        public IEnumerable<TeamMemberViewModel> AllTeamMembers
		{
			get
			{
				return this.allTeamMembers ?? (this.allTeamMembers = this.DataSource.TeamMembers);
			}
		}

        /// <summary>
        /// Gets or sets all the team members currently visible.
        /// </summary>
        public IEnumerable<BugStatusViewModel> AllStatuses
        {
            get
            {
				return this.allStatuses ?? (this.allStatuses = this.DataSource.Statuses);
            }
        }

		/// <summary>
		/// Gets or sets all the available teams.
		/// </summary>
        public IEnumerable<TeamViewModel> AllTeams
		{
			get
			{
				return this.allTeams ?? (this.allTeams = new BindingList<TeamViewModel>(this.DataSource.Teams));
			}
		}

		protected IBugTrackerDataSource DataSource
		{
			get;
			private set;
		}

        //object ISingleInstance.SingleInstance
        //{
        //    get { return Instance; }
        //}
	}
}
