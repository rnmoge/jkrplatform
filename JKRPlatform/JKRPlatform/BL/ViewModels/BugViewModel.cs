using System;

namespace BugTrackerDemo.ViewModels
{
	public class BugViewModel : ViewModelBase
	{
		private bool isSelected;
		private DateTime resolvedDate;
		private BugStatusViewModel status;
		private string description;
		private DateTime dateCreated;
		private TeamMemberViewModel owner;
		private string title;

	    public static TeamMemberViewModel UnassignedBugsOwner;

        static BugViewModel()
        {
            UnassignedBugsOwner = new TeamMemberViewModel();
            UnassignedBugsOwner.FullName = "- unassigned -";
        }

	    /// <summary>
		/// Gets or sets whether the bug is currently opened by the user.
		/// </summary>
		public bool IsSelected
		{
			get
			{
				return this.isSelected;
			}
			set
			{
				if (this.isSelected != value)
				{
					this.isSelected = value;
					OnPropertyChanged("IsSelected");
				}
			}
		}

		/// <summary>
		/// Gets or sets the date that this bug has been resolved.
		/// </summary>
		public DateTime ResolvedDate
		{
			get
			{
				return this.resolvedDate;
			}
			set
			{
				if (this.resolvedDate != value)
				{
					this.resolvedDate = value;
					OnPropertyChanged("ResolvedDate");
				}
			}
		}

		/// <summary>
		/// Gets or sets whether the bug is still open or has been resolved.
		/// </summary>
		public BugStatusViewModel Status
		{
			get
			{
				return this.status;
			}
			set
			{
				if (this.status != value)
				{
					this.status = value;
					OnPropertyChanged("Status");
				}
			}
		}

		/// <summary>
		/// Gets or sets the description of the bug.
		/// </summary>
		public string Description
		{
			get
			{
				return this.description;
			}
			set
			{
				if (this.description != value)
				{
					this.description = value;
					OnPropertyChanged("Description");
				}
			}
		}

		/// <summary>
		/// Gets or sets the date on which the bug was added to the tracker.
		/// </summary>
		public DateTime DateCreated
		{
			get
			{
				return this.dateCreated;
			}
			set
			{
				if (this.dateCreated != value)
				{
					this.dateCreated = value;
					OnPropertyChanged("DateCreated");
				}
			}
		}

		/// <summary>
        /// Gets or sets owner. If owner is not assigned explicitly owner of UnassignedBugsOwner
		/// </summary>
		public TeamMemberViewModel Owner
		{
			get
			{
                if (this.owner == null)
                {
                    return UnassignedBugsOwner;
                }
			    return this.owner;
			}
			set
			{
				if (this.owner != value)
				{
                    if (value == UnassignedBugsOwner)
                    {
                        this.owner = null;
                    }
                    else
                    {
                        this.owner = value;
                    }
				    OnPropertyChanged("Owner");
				}
			}
		}

		/// <summary>
		/// Gets or sets the title of the item.
		/// </summary>
		public string Title
		{
			get
			{
				return this.title;
			}
			set
			{
				if (this.title != value)
				{
					this.title = value;
					OnPropertyChanged("Title");
				}
			}
		}
	}
}
