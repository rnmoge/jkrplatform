using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;

namespace BugTrackerDemo.ViewModels
{
    public class TeamViewModel : TeamObjectViewModel, IInfoProvider
	{
		private TeamViewModel parentTeam;
		private IEnumerable<TeamObjectViewModel> children;
		private IEnumerable<TeamViewModel> teams;
        private BindingList<TeamMemberViewModel> members;
		private string name;
		private bool isCompared;

		/// <summary>
		/// Gets or sets the parent team of this team.
		/// </summary>
		public TeamViewModel ParentTeam
		{
			get
			{
				return this.parentTeam;
			}
			set
			{
				if (this.parentTeam != value)
				{
					this.parentTeam = value;
					OnPropertyChanged("ParentTeam");
				}
			}
		}

        /// <summary>
        /// Gets or sets the children (teams and people) of this team.
        /// </summary>
        public IEnumerable<TeamObjectViewModel> Children
        {
            get
            {
                return this.children ?? (this.children =
                    this.Teams.Cast<TeamObjectViewModel>().Concat(this.Members.Cast<TeamObjectViewModel>()));
            }
        }

		/// <summary>
		/// Gets or sets the teams part of this team.
		/// </summary>
		public IEnumerable<TeamViewModel> Teams
		{
			get
			{
				return this.teams ?? (this.teams = 
                    BugTrackerViewModel.Instance.AllTeams.Where(team => team.ParentTeam == this));
				
				// .OrderByDescending(team => team.TeamName));
			}
		}

		/// <summary>
		/// Gets or sets the people in this team.
		/// </summary>
        public BindingList<TeamMemberViewModel> Members
		{
			get
			{
                return this.members ?? (this.members = new BindingList<TeamMemberViewModel>(
					BugTrackerViewModel.Instance.AllTeamMembers.Where(member => member.Team == this).ToList()));
				
				// .OrderByDescending(member => member.FullName));
			}
		}

		/// <summary>
		/// Gets or sets name of the team.
		/// </summary>
		public string TeamName
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
					OnPropertyChanged("TeamName");
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

        /// <summary>
        /// Get flattened list of all bugs in the hierarchy of members and teams
        /// </summary>
        public IEnumerable<BugViewModel> AllBugs
        {
            get
            {
                foreach (var member in this.Members)
                {
                    foreach (var bug in member.AssignedBugs)
                    {
                        yield return bug;
                    }
                }

                foreach(var team in this.Teams)
                {
                    foreach(var bug in team.AllBugs)
                    {
                        yield return bug;
                    }
                }
            }
        }
	}
}
