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
    public partial class BugListView : UserControl
    {
        private BugTrackerMain.CreateBugDelegate createBugDelegate;
        public BugListView(BugTrackerMain.CreateBugDelegate createBugDelegate)
        {
            this.createBugDelegate = createBugDelegate;
            InitializeComponent();
        }

        public IList<BugViewModel> DataSource
        {
            get
            {
                return (IList<BugViewModel>)this.radGridView1.DataSource;
            }
            set
            {
                this.radGridView1.DataSource = value;
            }
        }

        private void AllBugsView_Load(object sender, EventArgs e)
        {
        }

        private void radGridView1_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {         
            GridDataCellElement cell = sender as GridDataCellElement;

            if (cell != null && this.createBugDelegate != null)
            {
                createBugDelegate((BugViewModel)cell.RowInfo.DataBoundItem);
            }
        }
    }
}
