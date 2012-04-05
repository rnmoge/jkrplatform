using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BugTrackerDemo.ViewModels;
using Telerik.WinControls.UI;

namespace BugTrackerDemo
{
    public partial class BugDetailsView : UserControl
    {
        private BugViewModel bug;
        bool viewInitialized;

        public BugDetailsView()
        {
            InitializeComponent();
        }

        
        private void BugDetailsView_Load(object sender, EventArgs e)
        {
            EnsureViewInitialized();
        }

        private void EnsureViewInitialized()
        {
            if (viewInitialized)
            {
                return;
            }

            //add unassigned bugs owner items
            var unnassignedBugsOwnerItem = new RadComboBoxItem(BugViewModel.UnassignedBugsOwner.FullName);
            unnassignedBugsOwnerItem.Value = BugViewModel.UnassignedBugsOwner;
            this.cbOwner.Items.Add( unnassignedBugsOwnerItem);
            
            this.cbOwner.DisplayMember = "FullName";
            this.cbOwner.DataSource = BugTrackerViewModel.Instance.AllTeamMembers;

            this.cbStatus.DisplayMember = "StatusName";            
            this.cbStatus.DataSource = BugTrackerViewModel.Instance.AllStatuses;            

            viewInitialized = true;
        }
        
        public BugViewModel Bug
        {
            get { return this.bug; }
            set
            {
                if (this.bug != value)
                {
                    EnsureViewInitialized();
                    this.bug = value;

                    this.DataBindings.Clear();

                    if (bug == null)
                    {
                        return;
                    }

                    this.tbTitle.DataBindings.Add("Text", bug, "Title", false, DataSourceUpdateMode.OnPropertyChanged);

                    this.cbOwner.DataBindings.Add("SelectedValue", bug, "Owner", false, DataSourceUpdateMode.OnPropertyChanged);
                    this.cbStatus.DataBindings.Add("SelectedValue", bug, "Status", false, DataSourceUpdateMode.OnPropertyChanged);

                    this.tbDescription.DataBindings.Add("Text", bug, "Description", false, DataSourceUpdateMode.OnPropertyChanged);
                }
            }
        }
    }
}
