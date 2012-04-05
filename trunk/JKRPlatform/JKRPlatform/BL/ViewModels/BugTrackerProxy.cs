namespace BugTrackerDemo.ViewModels
{
	/// <summary>
	/// #Singleton: Used when we need to get the instance of the BugTracker without
	/// creating a new one. This may be needed in xaml. This is how we can
	/// bind to singletons in xaml. I we need to bind to a static property, we
	/// can always create a proxy that exposes the static property as an
	/// instance property.
	/// </summary>
	public class BugTrackerProxy
	{
		public BugTrackerViewModel Instance
		{
			get
			{
				return BugTrackerViewModel.Instance;
			}
		}
	}
}
