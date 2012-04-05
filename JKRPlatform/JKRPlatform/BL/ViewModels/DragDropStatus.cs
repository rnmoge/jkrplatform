using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BugTrackerDragDrop
{
    public enum DragStatus
    {
        /// <summary>
        /// No drag or drop operations underway.
        /// </summary>
        None,
        /// <summary>
        /// A mouse down mouse has moved over a registered element, it is being queried now.
        /// </summary>
        DragQuery,
        /// <summary>
        /// Dragging has started, no drop zones have been found.
        /// </summary>
        DragInProgress,
        /// <summary>
        /// The drag/drop process is successful, notifying the source.
        /// </summary>
        DragComplete,
        /// <summary>
        /// The drag/drop has been cancelled.
        /// </summary>
        DragCancel,
        /// <summary>
        /// The destination is asked whether the element can be dropped.
        /// </summary>
        DropDestinationQuery,
        /// <summary>
        /// The source is asked whether the element canb e dropped.
        /// </summary>
        DropSourceQuery,
        /// <summary>
        /// The drop is acknowledged by both parties.
        /// </summary>
        DropPossible,
        /// <summary>
        /// The drop is not possible due to refusal of one of the partied.
        /// </summary>
        DropImpossible,
        /// <summary>
        /// The drop operation has completed successfully.
        /// </summary>
        DropComplete,
        /// <summary>
        /// The drop operation has been cancelled. 
        /// </summary>
        DropCancel
    }
}
