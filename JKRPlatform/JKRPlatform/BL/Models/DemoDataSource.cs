using System;
using System.Collections.ObjectModel;
using BugTrackerDemo.ViewModels;
using Telerik.WinControls.Data;
using System.Collections.Generic;

namespace BugTrackerDemo.Models
{
	/// <summary>
	/// Dummy Data Source for the BugTracker application.
	/// </summary>
	/// <remarks>
	///     The fact that we do not need to connect to a service or read
	///     external data means that we can use this source during design-time.
	/// </remarks>
	public class DemoDataSource : IBugTrackerDataSource
	{
		private static bool isInitialized;
		private static IList<BugViewModel> bugs;
		private static IList<TeamViewModel> teams;
		private static IList<TeamMemberViewModel> members;
		private static IList<BugStatusViewModel> statuses;

		private static void Initialize()
		{
			if (!isInitialized)
			{
				isInitialized = true;

				bugs = new Telerik.WinControls.Data.ObservableCollection<BugViewModel>()
				{
				new BugViewModel()
				{ 
					DateCreated = DateTime.Today,
					Description = "The Monday bug of a Broken TemplateBinding in the TreeView",
					Title = "Missing template Binding in the TreeView",
                    Status = BugStatusViewModel.Open,
				},
				new BugViewModel()
				{ 
					DateCreated = DateTime.Today.AddDays(-1),
					Description = "Setting a null value to the DatePicker does not clear the input.",
					Title = "DatePicker: NullValue not working!",
					Status = BugStatusViewModel.Closed,
					IsSelected = true,
					ResolvedDate = DateTime.Today
				},
				new BugViewModel()
				{ 
					DateCreated = DateTime.Today.AddDays(-1),
					Description = "TabControl DataContext cannot be a DependencyObject because it throws an error on startup.",
					Title = "DependencyObject DataContext",
                    Status = BugStatusViewModel.Open,
				},
				new BugViewModel()
				{ 
					DateCreated = DateTime.Today.AddDays(-2),
					Description = "When you use a Canvas panel sometimes it will mess up the layout of seemingly unrelated elements.",
					Title = "Canvas Panel Layour Bug",
                    Status = BugStatusViewModel.Open,
				},
				new BugViewModel()
				{ 
					IsSelected = true,
					DateCreated = DateTime.Today.AddDays(-3),
					Description = "TransformToVisual in Popus throws an unexpected ecveption (as opposed to an expected exception maybe :))",
					Title = "TransfromToVisual in Panels Bug ",
                    Status = BugStatusViewModel.Open,
				},
				new BugViewModel()
				{ 
					DateCreated = DateTime.Today.AddDays(-3),
					Description = "The calendar examples do not show how to do proper date valdiation using Calendar's static methods.",
					Title = "Input not Validated Bug",
					Status = BugStatusViewModel.Closed,
					ResolvedDate = DateTime.Today
				},
                new BugViewModel()
				{ 
					DateCreated = DateTime.Today.AddDays(-100),
					Description = "The sun is too bright for the sleek Office_Black theme.",
					Title = "Sun: Too Bright",
					Status = BugStatusViewModel.Closed,
					ResolvedDate = DateTime.Today.AddDays(-50)
				},
                new BugViewModel()
				{ 
					DateCreated = DateTime.Today.AddDays(-8),
					Description = "It seems that the HeaderTemplate property of the TabItem is not bound.",
					Title = "TabControl: HeaderTemplate not Bound",
					Status = BugStatusViewModel.Open,
				},
                new BugViewModel()
				{ 
					DateCreated = DateTime.Today.AddDays(-1),
					Description = "The Nose of the sphynx has been broken for at least the last 3000 releases. Please fix.",
					Title = "Sphynx: Nose Broken",
					Status = BugStatusViewModel.Open,
				},
			};

				teams = new Telerik.WinControls.Data.ObservableCollection<TeamViewModel>()
			{
				new TeamViewModel()
				{
					TeamName = "Controls Team"
				},
				new TeamViewModel()
				{
					TeamName = "Navigation Controls Team"
				},
				new TeamViewModel()
				{
					TeamName = "Input Controls Team"
				},
				new TeamViewModel()
				{
					TeamName = "Web & Examples Team"
				},
			};

				members = new Telerik.WinControls.Data.ObservableCollection<TeamMemberViewModel>()
			{
				new TeamMemberViewModel()
				{
					FullName = "Leopold Bloom",
                    IsCompared = true
				},
				new TeamMemberViewModel()
				{
					FullName = "Stephen Dedalus",
                    IsCompared = true
				},
				new TeamMemberViewModel()
				{
					FullName = "Malachi Mulligan",
                    IsCompared = true
				},
				new TeamMemberViewModel()
				{
					FullName = "Edy Boardman"
				},
				new TeamMemberViewModel()
				{
					FullName = "Richard Best"
				},
				new TeamMemberViewModel()
				{
					FullName = "Martha Clifford"
				},
			};

				statuses = new Telerik.WinControls.Data.ObservableCollection<BugStatusViewModel>()
            {
                BugStatusViewModel.Closed,
                BugStatusViewModel.Open
            };

				// Create relationships:

				// Team hierarchy:
				teams[1].ParentTeam = teams[0];
				teams[2].ParentTeam = teams[0];

				// Team members:
				members[0].Team = teams[1];
				members[1].Team = teams[1];
				members[2].Team = teams[2];
				members[3].Team = teams[2];
				members[4].Team = teams[3];

				// Bugs:
				bugs[1].Owner = members[0];
				bugs[5].Owner = members[1];
				bugs[3].Owner = members[1];
				bugs[4].Owner = members[3];
				bugs[6].Owner = members[0];
				bugs[7].Owner = members[1];

			}
		}

		public DemoDataSource()
		{
			Initialize();
		}

		public IList<TeamViewModel> Teams
		{
			get
			{
				return teams;
			}
		}

		public IList<BugViewModel> Bugs
		{
			get
			{
				return bugs;
			}
		}

		public IList<TeamMemberViewModel> TeamMembers
		{
			get
			{
				return members;
			}
		}

		public IList<BugStatusViewModel> Statuses
		{
			get
			{
				return statuses;
			}
		}
	}
}
