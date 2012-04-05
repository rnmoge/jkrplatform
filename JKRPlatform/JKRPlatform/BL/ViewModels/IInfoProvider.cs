namespace BugTrackerDemo.ViewModels
{
	/// <summary>
	/// This interface will be implemented by items that can be compared. They
	/// will automatically appear in the TeamCompare window.
	/// </summary>
    public interface IInfoProvider
    {
        bool IsCompared
        {
            get;
            set;
        }
    }
}
