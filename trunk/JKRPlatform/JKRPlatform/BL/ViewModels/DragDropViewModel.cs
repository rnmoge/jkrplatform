using System;
using System.Collections.Generic;
using BugTrackerDragDrop;

//using Telerik.Windows.Controls.DragDrop;

namespace BugTrackerDemo.ViewModels
{
    /// <summary>
    ///     The ViewModel of the DragCue.
    /// </summary>
    /// <remarks>
    ///     #DragCueViewModel: Since we want to drag multiple items at once and
    ///     give the user rich feedback on what is happening we can bind the
    ///     drag cue as well. This means that we will be albe to change its
    ///     contents easily and give the user feedbackn on item-by item basis.
    /// </remarks>
	public class DragDropViewModel : ViewModelBase
	{
        private IList<object> draggedItems;
		private string iconPath;
		private IEnumerable<bool> approvedDrops;
		private BugTrackerDragDrop.DragStatus dragStatus;
		private string message;

		/// <summary>
		/// Gets or sets the items that are being dragged.
		/// </summary>
		public IList<object> DraggedItems
		{
			get
			{
				return this.draggedItems;
			}
			set
			{
				if (this.draggedItems != value)
				{
					this.draggedItems = value;
					OnPropertyChanged("DraggedItems");
				}
			}
		}

		public IEnumerable<bool> ApprovedDrops
		{
			get
			{
				return this.approvedDrops;
			}
			set
			{
				if (this.approvedDrops != value)
				{
					this.approvedDrops = value;
					OnPropertyChanged("ApprovedDrops");
				}
			}
		}

		/// <summary>
		/// Gets or sets the message that will be displayed.
		/// </summary>
		public string Message
		{
			get
			{
				return this.message;
			}
			set
			{
				if (this.message != value)
				{
					this.message = value;
					OnPropertyChanged("Message");
				}
			}
		}

		/// <summary>
		/// Gets or sets the status of the current drag/drop. We may use it to change 
		/// the looks of the drag cue.
		/// </summary>
		/// <remarks>
		///     Currently this property is not in use.
		/// </remarks>
		public DragStatus DragStatus
		{
			get
			{
				return this.dragStatus;
			}
			set
			{
				if (this.dragStatus != value)
				{
					this.dragStatus = value;
					OnPropertyChanged("DragStatus");
				}
			}
		}

		/// <summary>
		/// Gets or sets the path to the icon that will represent the current action.
		/// </summary>
		public string IconPath
		{
			get
			{
				return this.iconPath;
			}
			set
			{
				if (this.iconPath != value)
				{
					this.iconPath = value;
					OnPropertyChanged("IconPath");
				}
			}
		}
	}
}
