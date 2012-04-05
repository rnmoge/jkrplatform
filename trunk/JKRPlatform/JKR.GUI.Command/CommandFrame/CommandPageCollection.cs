using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace JKR.GUI.Command
{
    public class CommandPageCollection : CollectionWithEvents
    {
        public CommandPage Add(TabPage value)
        {
            // Create a CommandPage from the TabPage
            CommandPage wp = new CommandPage();
            wp.Title = value.Title;
            wp.Control = value.Control;
            wp.ImageIndex = value.ImageIndex;
            wp.ImageList = value.ImageList;
            wp.Icon = value.Icon;
            wp.Selected = value.Selected;
            wp.StartFocus = value.StartFocus;

            return Add(wp);
        }

        public CommandPage Add(CommandPage value)
        {
            // Use base class to process actual collection operation
            base.List.Add(value as object);

            return value;
        }

        public void AddRange(CommandPage[] values)
        {
            // Use existing method to add each array entry
            foreach (CommandPage page in values)
                Add(page);
        }

        public void Remove(CommandPage value)
        {
            // Use base class to process actual collection operation
            base.List.Remove(value as object);
        }

        public void Insert(int index, CommandPage value)
        {
            // Use base class to process actual collection operation
            base.List.Insert(index, value as object);
        }
        public bool Contains(CommandPage value)
        {
            // Use base class to process actual collection operation
            return base.List.Contains(value as object);
        }

        public CommandPage this[int index]
        {
            // Use base class to process actual collection operation
            get { return (base.List[index] as CommandPage); }
        }

        public CommandPage this[string title]
        {
            get
            {
                // Search for a Page with a matching title
                foreach (CommandPage page in base.List)
                    if (page.Title == title)
                        return page;

                return null;
            }
        }

        public int IndexOf(CommandPage value)
        {
            // Find the 0 based index of the requested entry
            return base.List.IndexOf(value);
        }
    }
}
