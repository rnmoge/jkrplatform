using System;
using System.ComponentModel;

namespace BugTrackerDemo.ViewModels
{
    /// <summary>
    /// This is a base class for all ViewModels. By always
    /// inheriting from it, we can avoid the constant definition of
    /// INotifyPropertyChanged we can add functionality to all ViewModels at
    /// once.
    /// </summary>
    /// <remarks>
	///     #CommonViewModel
    /// </remarks>
	public class ViewModelBase : INotifyPropertyChanged
	{
		/// <summary>
		///     Raised when the value of one of the properties changes.
		/// </summary>
		public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        ///     Called when the value of a property changes.
        /// </summary>
        /// <param name="propertyName">
        ///     The name of the property that has changed.
        /// </param>
        /// <remarks>
        ///     #INotifyDefinition Here the OnPropertyChnaged method is both
        ///     protected and virtual so extending classes can both access it
        ///     and modify the behavior if needed
        /// </remarks>
		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (string.IsNullOrEmpty(propertyName))
			{
				return;
			}
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
