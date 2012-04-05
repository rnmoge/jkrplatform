using System.Collections.Generic;
using BugTrackerDemo.ViewModels;

namespace BugTrackerDemo.Models
{
	/// <summary>
	/// Abstracts the data source of the bug tracker application. 
	/// </summary>
	/// <remarks>
	///     #Abstraction
	///      
	///     Abstracting the Data Source is useful for design-time and testing.
	///     In reality the source collections may be IQueryable.
	/// </remarks>
	public interface IBugTrackerDataSource
	{
		IList<TeamViewModel> Teams
		{
			get;
		}

		IList<BugViewModel> Bugs
		{
			get;
		}

		IList<TeamMemberViewModel> TeamMembers
		{
			get;
		}

        IList<BugStatusViewModel> Statuses
        {
            get;
        }
	}
}
