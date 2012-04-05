using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BugTrackerDemo.Models;
using BugTrackerDemo.ViewModels;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Telerik.WinControls.UI.Docking;

using Telerik.WinControls.Themes;
using Telerik.WinControls.Themes.Design;
using Telerik.WinControls.UI;
using JKRPlatform.SystemManage;
using JKRPlatform.Cargo;
using JKRPlatform.BizSeaExport;
using JKRPlatform.CwCount;
using JKRPlatform.Customer;

namespace BugTrackerDemo
{
    public partial class BugTrackerMain : RadRibbonForm
    {
        private BugTrackerViewModel viewModel;
        private bool allBugsVisible = false;
        private bool openBugsVisible = false;
        //private bool hidenFromSpy;

        public delegate void CreateBugDelegate(BugViewModel bug);

        public BugTrackerMain()
        {
            //Load demo theme
            ThemeResolutionService.RegisterThemeFromStorage(
                ThemeStorageType.Resource,
                "BugTrackerDemo.Themes.Sapphire.DocumentTabStrip.xml"
                );

            ThemeResolutionService.RegisterThemeFromStorage(
                ThemeStorageType.Resource,
                "BugTrackerDemo.Themes.Sapphire.ToolTabStrip.xml"
                );

            ThemeResolutionService.RegisterThemeFromStorage(
                ThemeStorageType.Resource,
                "BugTrackerDemo.Themes.Sapphire.AutoHideTabStrip.xml"
                );

            ThemeResolutionService.RegisterThemeFromStorage(
                ThemeStorageType.Resource,
                "BugTrackerDemo.Themes.Sapphire.SplitContainer.xml"
                );

            ThemeResolutionService.RegisterThemeFromStorage(
                ThemeStorageType.Resource,
                "BugTrackerDemo.Themes.Sapphire.QuickNavigator.xml"
                );
            ThemeResolutionService.RegisterThemeFromStorage(
                ThemeStorageType.Resource,
                "BugTrackerDemo.Themes.Sapphire.RibbonBar.xml"
                );
            ThemeResolutionService.RegisterThemeFromStorage(
              ThemeStorageType.Resource,
              "BugTrackerDemo.Themes.Sapphire.DocumentContainer.xml"
              );

            InitializeComponent();

            this.radDock1.ThemeName = "Sapphire";
            this.radRibbonBar1.ThemeName = "Sapphire";


            this.radButtonElement1.StretchVertically = true;
           // this.radButtonElement2.StretchVertically = true;
            this.radButtonElement3.StretchVertically = true;
            this.radButtonElement4.StretchVertically = true;
            this.radButtonElement5.StretchVertically = true;
            this.radButtonElement6.StretchVertically = true;
            this.radButtonElement7.StretchVertically = true;
            this.radButtonElement8.StretchVertically = true;
            this.radButtonElement9.StretchVertically = true;

            this.radDock1.BorderStyle = BorderStyle.None;
           // this.radSplitContainer1.BorderStyle = BorderStyle.None;
            this.radRibbonBar1.RibbonBarElement.Margin = new Padding(
                this.radRibbonBar1.RibbonBarElement.Margin.Left,
                this.radRibbonBar1.RibbonBarElement.Margin.Top,
                this.radRibbonBar1.RibbonBarElement.Margin.Right,
                -3);

          // this.toolWindow2.AllowedDockState &= ~(AllowedDockState.Hidden | AllowedDockState.AutoHide);
        }

        private void BugTrackerMain_Load(object sender, EventArgs e)
        {
            viewModel = new BugTrackerViewModel();

            //set treeview hierarchical binding properties
            this.radTreeView1.RelationBindings.Add(new RelationBinding(
                                                       "Members",
                                                       this.viewModel.AllTeams,
                                                       "Members", "FullName", null
                                                       ));

            //set treeview images according to databound item type
            this.radTreeView1.Nodes.CollectionChanged +=
                (s, args) =>
                    {
                        if (args.Action == NotifyCollectionChangedAction.Add)
                        {
                            RadTreeNode node = ((RadTreeNode) args.NewItems[0]);
                            var dataBoundItem = node.DataBoundItem;
                            if (dataBoundItem is TeamMemberViewModel)
                            {
                                node.ImageIndex = 1;
                            }
                            else if (dataBoundItem is TeamViewModel)
                            {
                                node.ImageIndex = 0;
                            }
                        }
                    };

            this.radTreeView1.DataSource = this.viewModel.AllTeams;
            this.radTreeView1.RootRelationDisplayName = "Teams";            
            this.radTreeView1.DisplayMember = "TeamName";
            this.radTreeView1.Nodes[0].Expanded = true;
            this.radTreeView1.Nodes[0].Selected = true;
            this.radTreeView1.SetImagesInFill(false);

            //load other themes in background
            BackgroundWorker bw = new BackgroundWorker();

            bw.DoWork += delegate
                             {
                                 new Office2007BlackTheme();
                                 new Office2007SilverTheme();
                             };

            bw.RunWorkerAsync();

            //Load nicer grid layout
            //this.radGridView1.LoadLayout(Path.GetDirectoryName(Application.ExecutablePath) + "\\BugListGridLayout.xml");

            //preload 2 bug docuemtn items
            //if (this.radGridView1.RowCount > 1)
            //{
            //    //this.CreateBugDetailsView((BugViewModel) this.radGridView1.Rows[0].DataBoundItem);
            //    //this.CreateBugDetailsView((BugViewModel)this.radGridView1.Rows[1].DataBoundItem);
            //    //this.CreateBugDetailsView((BugViewModel)this.radGridView1.Rows[2].DataBoundItem);
            //    //this.CreateBugDetailsView((BugViewModel)this.radGridView1.Rows[3].DataBoundItem);
            //}

            //this.toolTabStrip1.SizeInfo.SizeMode = SplitPanelSizeMode.Absolute;
            //this.toolTabStrip1.SizeInfo.AbsoluteSize = new Size(250, 0);
            //this.toolTabStrip2.SizeInfo.SizeMode = SplitPanelSizeMode.Absolute;
            //this.toolTabStrip2.SizeInfo.AbsoluteSize = new Size(0, 250);

            //foreach (GridViewColumn column in this.radGridView1.Columns)
            //{
            //    GridViewDateTimeColumn dateTimeColumn = column as GridViewDateTimeColumn;
            //    if (dateTimeColumn != null)
            //    {
            //        dateTimeColumn.FormatString = "{0:d}";
            //    }
            //}

            this.documentTabStrip1 = this.radDock1.GetDefaultDocumentTabStrip(false);
        }

        private void radTreeView1_Selected(object sender, RadTreeViewEventArgs e)
        {
            TeamObjectViewModel item = (TeamObjectViewModel) e.Node.DataBoundItem;

            //this.radGridView1.MasterGridViewTemplate.AutoGenerateColumns = (this.radGridView1.ColumnCount == 0);
           
            //if (item is TeamViewModel)
            //{
            //    this.radGridView1.DataSource =
            //        new BindingList<BugViewModel>(new List<BugViewModel>((item as TeamViewModel).AllBugs));
            //}
            //else if (item is TeamMemberViewModel)
            //{
            //    this.radGridView1.DataSource =
            //        new BindingList<BugViewModel>(new List<BugViewModel>((item as TeamMemberViewModel).AssignedBugs));
            //}
            //else
            //{
            //    this.radGridView1.DataSource =
            //        new BindingList<BugViewModel>(this.viewModel.AllBugs);
            //}
            //foreach (GridViewColumn column in this.radGridView1.Columns)
            //{
            //    GridViewDateTimeColumn dateTimeColumn = column as GridViewDateTimeColumn;
            //    if (dateTimeColumn != null)
            //    {
            //        dateTimeColumn.FormatString = "{0:d}";
            //    }
            //}
        }

        private void radGridView1_CellDoubleClick(object sender, GridViewCellEventArgs e)
        {
            GridDataCellElement cell = sender as GridDataCellElement;

            if (cell != null && cell.RowInfo.DataBoundItem != null)
            {
                CreateBugDetailsView((BugViewModel)cell.RowInfo.DataBoundItem);
            }
        }

        public void CreateBugDetailsView(BugViewModel bug)
        {
            if (bug == null)
            {
                return;
            }

            foreach (DocumentWindow existingDocument in this.radDock1.DockWindows.DocumentWindows)
            {
                //Avoid adding the same bug as a documetn twice. Instead, active its window
                if (existingDocument != null)
                {                 
                    if (((BugDetailsView)existingDocument.Controls[0]).Bug == bug )
                    {
                        if (existingDocument.DockState == DockState.TabbedDocument)
                        {
                            this.documentTabStrip1.SelectedTab = existingDocument;
                        }
                        return;
                    }
                }
            }

            BugDetailsView bugDetails = new BugDetailsView();
            bugDetails.Bug = bug;

            DocumentWindow document = new DocumentWindow(bugDetails.Bug.Title);

            document.Controls.Add(bugDetails);
            bugDetails.Dock = DockStyle.Fill;
            document.DataBindings.Add("Text", bugDetails.Bug, "Title", false, DataSourceUpdateMode.OnPropertyChanged);

            this.radDock1.AddDocument(document);
        }        

        private void radDock1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 客户资料
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radButtonElement3_Click(object sender, EventArgs e)
        {
            DocumentWindow document = new DocumentWindow();
            
            ucCustomerDetails a = new ucCustomerDetails();
            document.Controls.Add(a);
            a.Dock = DockStyle.Fill;
            DataTable dt = new DataTable();
            dt.Columns.Add("Title");
            DataRow dr = dt.NewRow();
            dr["Title"] = "客户资料";
            dt.Rows.Add(dr);
            document.DataBindings.Add("Text", dt, "Title", false, DataSourceUpdateMode.OnPropertyChanged);
            
            this.radDock1.AddDocument(document);
        }

        private void radButtonElement4_Click(object sender, EventArgs e)
        {
           // this.radDock1.DisplayWindow(this.toolWindow2);
        }

        private void radButtonElement5_Click(object sender, EventArgs e)
        {
            if (allBugsVisible)
            {
                return;
            }

            allBugsVisible = true;

            ToolWindow toolWindow = new ToolWindow("All Bugs");

            BugListView bugListView = new BugListView(this.CreateBugDetailsView);
            bugListView.DataSource = BugTrackerViewModel.Instance.AllBugs;
            bugListView.Dock = DockStyle.Fill;

            toolWindow.Controls.Add(bugListView);
            toolWindow.CloseAction = DockWindowCloseAction.CloseAndDispose;

            //by default the close action for tool windows is Close, no t Dispose,
            //but we whant the instance of this pane to be disposed
            //radDock1.DockWindow(toolWindow, this.toolWindow2, DockPosition.Fill);

            toolWindow.Disposed +=
                delegate
                    {
                        allBugsVisible = false;
                    };
        }

        private void radButtonElement2_Click(object sender, EventArgs e)
        {
           //// var spy = new RadControlSpyForm();

           // radDock1.DockControl(spy, DockPosition.Right);

           // var dockPane = ((DockWindow) spy.Parent);
           // dockPane.DockState = DockState.Floating; 

           // ((HostWindow) dockPane).ParentForm.Size = new Size(400, 600);
           // spy.Visible = true;
        }

        private void radButtonElement1_Click(object sender, EventArgs e)
        {
            if (openBugsVisible)
            {
                return;
            }

            openBugsVisible = true;

            ToolWindow toolWindow = new ToolWindow("Unassigned Bugs");

            BugListView bugListView = new BugListView(this.CreateBugDetailsView);
            bugListView.DataSource = BugTrackerViewModel.Instance.UnassignedBugs;
            bugListView.Dock = DockStyle.Fill;

            toolWindow.Controls.Add(bugListView);
            toolWindow.CloseAction = DockWindowCloseAction.CloseAndDispose;

            //by default the close action for tool windows is Hide
            //but we whant the instance of this pane to be disposed, so set the action to Close
           // radDock1.DockWindow(toolWindow, this.toolWindow2, DockPosition.Fill);

            toolWindow.Disposed +=
                delegate
                    {
                        openBugsVisible = false;
                    };
        }

        private void radButtonElement6_Click(object sender, EventArgs e)
        {
            var themeName = (string) ((RadButtonElement) sender).Tag;
            //this.radDock1.ThemeName = themeName;
            //this.radRibbonBar1.ThemeName = themeName;
            //this.ThemeName = themeName;
            ThemeResolutionService.ApplyThemeToControlTree(this, themeName);
        }

        private void radButtonElement10_Click(object sender, EventArgs e)
        {
            IThemeBuilder themeBuilder = ThemeDesignerService.CreateDesignerInstance();

            themeBuilder.InitializeThemeDesignerForDesignerData(new RadDockThemeDesignerData(), null);
            themeBuilder.ShowDialog();
        }

        private void radButtonElement12_Click(object sender, EventArgs e)
        {
            this.radDock1.SaveToXml(Path.GetDirectoryName(Application.ExecutablePath) + "\\BugTrackerDemoLayout.xml");
        }

        private void radButtonElement13_Click(object sender, EventArgs e)
        {
            //var path = Path.GetDirectoryName(Application.ExecutablePath) + "\\BugTrackerDemoLayout.xml";
            //if (!File.Exists(path))
            //{
            //    return;
            //}

            //this.radDock1.LoadFromXml(path);
        }

        /// <summary>
        /// 区域及港口管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radButtonElement20_Click(object sender, EventArgs e)
        {
            #region
            //this.radDock1.DisplayWindow(this.toolWindow1);

            //DocumentWindow document = new DocumentWindow();
            //ucA011 a = new ucA011();
            //document.Controls.Add(a);
            //a.Dock = DockStyle.Fill;
            //DataTable dt = new DataTable();
            //dt.Columns.Add("Title");
            //DataRow dr = dt.NewRow();
            //dr["Title"] = "系统管理";
            //dt.Rows.Add(dr);
            //document.DataBindings.Add("Text", dt, "Title", false, DataSourceUpdateMode.OnPropertyChanged);

            //this.radDock1.AddDocument(document);
            #endregion
            DocumentWindow document = new DocumentWindow();
            ucMasterData a = new ucMasterData();
            document.Controls.Add(a);
            a.Dock = DockStyle.Fill;
            DataTable dt = new DataTable();
            dt.Columns.Add("Title");
            DataRow dr = dt.NewRow();
            dr["Title"] = "区域及港口管理";
            dt.Rows.Add(dr);
            document.DataBindings.Add("Text", dt, "Title", false, DataSourceUpdateMode.OnPropertyChanged);

            this.radDock1.AddDocument(document);
        }

        /// <summary>
        /// 接单审单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radButtonElement1_Click_1(object sender, EventArgs e)
        {
            DocumentWindow document = new DocumentWindow();          
            ucSEConsign a = new ucSEConsign();
            document.Controls.Add(a);
            a.Dock = DockStyle.Fill;
            DataTable dt = new DataTable();
            dt.Columns.Add("Title");
            DataRow dr = dt.NewRow();
            dr["Title"] = "接单审单";
            dt.Rows.Add(dr);
            document.DataBindings.Add("Text", dt, "Title", false, DataSourceUpdateMode.OnPropertyChanged);

            this.radDock1.AddDocument(document);
        }

        /// <summary>
        /// 客户服务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radButtonElement4_Click_1(object sender, EventArgs e)
        {
            DocumentWindow document = new DocumentWindow();
            ucSEShipmentForm a = new ucSEShipmentForm();
            document.Controls.Add(a);
            a.Dock = DockStyle.Fill;
            DataTable dt = new DataTable();
            dt.Columns.Add("Title");
            DataRow dr = dt.NewRow();
            dr["Title"] = "客户服务";
            dt.Rows.Add(dr);
            document.DataBindings.Add("Text", dt, "Title", false, DataSourceUpdateMode.OnPropertyChanged);

            this.radDock1.AddDocument(document);
        }

        /// <summary>
        /// 出口船期维护
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radButtonElement5_Click_1(object sender, EventArgs e)
        {

            DocumentWindow document = new DocumentWindow();
            ucSEVesselSchedule a = new ucSEVesselSchedule();
            document.Controls.Add(a);
            a.Dock = DockStyle.Fill;
            DataTable dt = new DataTable();
            dt.Columns.Add("Title");
            DataRow dr = dt.NewRow();
            dr["Title"] = "出口船期维护";
            dt.Rows.Add(dr);
            document.DataBindings.Add("Text", dt, "Title", false, DataSourceUpdateMode.OnPropertyChanged);

            this.radDock1.AddDocument(document);
          
        }

        /// <summary>
        /// 船名维护
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radButtonElement13_Click_1(object sender, EventArgs e)
        {
            DocumentWindow document = new DocumentWindow();
            ucSEVessel a = new ucSEVessel();
            document.Controls.Add(a);
            a.Dock = DockStyle.Fill;
            DataTable dt = new DataTable();
            dt.Columns.Add("Title");
            DataRow dr = dt.NewRow();
            dr["Title"] = "船名维护";
            dt.Rows.Add(dr);
            document.DataBindings.Add("Text", dt, "Title", false, DataSourceUpdateMode.OnPropertyChanged);

            this.radDock1.AddDocument(document);
        }

        /// <summary>
        /// 整船配舱
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radButtonElement18_Click(object sender, EventArgs e)
        {
            DocumentWindow document = new DocumentWindow();
            ucConfigShip a = new ucConfigShip();
            document.Controls.Add(a);
            a.Dock = DockStyle.Fill;
            DataTable dt = new DataTable();
            dt.Columns.Add("Title");
            DataRow dr = dt.NewRow();
            dr["Title"] = "整船配舱";
            dt.Rows.Add(dr);
            document.DataBindings.Add("Text", dt, "Title", false, DataSourceUpdateMode.OnPropertyChanged);

            this.radDock1.AddDocument(document);
        }

        /// <summary>
        /// 提单制作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radButtonElement19_Click(object sender, EventArgs e)
        {
            DocumentWindow document = new DocumentWindow();
            ucSEDocumentation a = new ucSEDocumentation();
            document.Controls.Add(a);
            a.Dock = DockStyle.Fill;
            DataTable dt = new DataTable();
            dt.Columns.Add("Title");
            DataRow dr = dt.NewRow();
            dr["Title"] = "提单制作";
            dt.Rows.Add(dr);
            document.DataBindings.Add("Text", dt, "Title", false, DataSourceUpdateMode.OnPropertyChanged);

            this.radDock1.AddDocument(document);
        }

        /// <summary>
        /// 费用方案
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radButtonElement35_Click(object sender, EventArgs e)
        {
            DocumentWindow document = new DocumentWindow();
            ucFreightSchedule a = new ucFreightSchedule();
            document.Controls.Add(a);
            a.Dock = DockStyle.Fill;
            DataTable dt = new DataTable();
            dt.Columns.Add("Title");
            DataRow dr = dt.NewRow();
            dr["Title"] = "费用方案";
            dt.Rows.Add(dr);
            document.DataBindings.Add("Text", dt, "Title", false, DataSourceUpdateMode.OnPropertyChanged);

            this.radDock1.AddDocument(document);
        }

        /// <summary>
        /// 单票审核
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radButtonElement36_Click(object sender, EventArgs e)
        {
            DocumentWindow document = new DocumentWindow();
            ucBillingApprove a = new ucBillingApprove();
            document.Controls.Add(a);
            a.Dock = DockStyle.Fill;
            DataTable dt = new DataTable();
            dt.Columns.Add("Title");
            DataRow dr = dt.NewRow();
            dr["Title"] = "单票审核";
            dt.Rows.Add(dr);
            document.DataBindings.Add("Text", dt, "Title", false, DataSourceUpdateMode.OnPropertyChanged);

            this.radDock1.AddDocument(document);
        }

        /// <summary>
        /// 销售佣金
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radButtonElement37_Click(object sender, EventArgs e)
        {
            DocumentWindow document = new DocumentWindow();
            ucSaleCommission a = new ucSaleCommission();
            document.Controls.Add(a);
            a.Dock = DockStyle.Fill;
            DataTable dt = new DataTable();
            dt.Columns.Add("Title");
            DataRow dr = dt.NewRow();
            dr["Title"] = "销售佣金";
            dt.Rows.Add(dr);
            document.DataBindings.Add("Text", dt, "Title", false, DataSourceUpdateMode.OnPropertyChanged);

            this.radDock1.AddDocument(document);
        }

        /// <summary>
        /// 账单管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radButtonElement38_Click(object sender, EventArgs e)
        {
            DocumentWindow document = new DocumentWindow();
            ucBillingInvoice a = new ucBillingInvoice();
            document.Controls.Add(a);
            a.Dock = DockStyle.Fill;
            DataTable dt = new DataTable();
            dt.Columns.Add("Title");
            DataRow dr = dt.NewRow();
            dr["Title"] = "账单管理";
            dt.Rows.Add(dr);
            document.DataBindings.Add("Text", dt, "Title", false, DataSourceUpdateMode.OnPropertyChanged);

            this.radDock1.AddDocument(document);
        }

        /// <summary>
        /// 催帐管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radButtonElement39_Click(object sender, EventArgs e)
        {
            DocumentWindow document = new DocumentWindow();
            ucBillingChase a = new ucBillingChase();
            document.Controls.Add(a);
            a.Dock = DockStyle.Fill;
            DataTable dt = new DataTable();
            dt.Columns.Add("Title");
            DataRow dr = dt.NewRow();
            dr["Title"] = "催帐管理";
            dt.Rows.Add(dr);
            document.DataBindings.Add("Text", dt, "Title", false, DataSourceUpdateMode.OnPropertyChanged);

            this.radDock1.AddDocument(document);
        }

        /// <summary>
        /// 税务发票
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radButtonElement40_Click(object sender, EventArgs e)
        {
            DocumentWindow document = new DocumentWindow();
            ucBillingTaxInvoice a = new ucBillingTaxInvoice();
            document.Controls.Add(a);
            a.Dock = DockStyle.Fill;
            DataTable dt = new DataTable();
            dt.Columns.Add("Title");
            DataRow dr = dt.NewRow();
            dr["Title"] = "开发票";
            dt.Rows.Add(dr);
            document.DataBindings.Add("Text", dt, "Title", false, DataSourceUpdateMode.OnPropertyChanged);

            this.radDock1.AddDocument(document);
        }

        /// <summary>
        /// 实际收付
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radButtonElement41_Click(object sender, EventArgs e)
        {
            DocumentWindow document = new DocumentWindow();
            ucBillingCashier a = new ucBillingCashier();
            document.Controls.Add(a);
            a.Dock = DockStyle.Fill;
            DataTable dt = new DataTable();
            dt.Columns.Add("Title");
            DataRow dr = dt.NewRow();
            dr["Title"] = "实际收付";
            dt.Rows.Add(dr);
            document.DataBindings.Add("Text", dt, "Title", false, DataSourceUpdateMode.OnPropertyChanged);

            this.radDock1.AddDocument(document);
        }

        /// <summary>
        /// 调帐工作号管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radButtonElement42_Click(object sender, EventArgs e)
        {
            DocumentWindow document = new DocumentWindow();
            ucBillingAdjustment a = new ucBillingAdjustment();
            document.Controls.Add(a);
            a.Dock = DockStyle.Fill;
            DataTable dt = new DataTable();
            dt.Columns.Add("Title");
            DataRow dr = dt.NewRow();
            dr["Title"] = "调帐管理";
            dt.Rows.Add(dr);
            document.DataBindings.Add("Text", dt, "Title", false, DataSourceUpdateMode.OnPropertyChanged);

            this.radDock1.AddDocument(document);
        }

        /// <summary>
        /// 核销管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radButtonElement43_Click(object sender, EventArgs e)
        {
            DocumentWindow document = new DocumentWindow();
            ucBillingSettlement a = new ucBillingSettlement();
            document.Controls.Add(a);
            a.Dock = DockStyle.Fill;
            DataTable dt = new DataTable();
            dt.Columns.Add("Title");
            DataRow dr = dt.NewRow();
            dr["Title"] = "核销管理";
            dt.Rows.Add(dr);
            document.DataBindings.Add("Text", dt, "Title", false, DataSourceUpdateMode.OnPropertyChanged);

            this.radDock1.AddDocument(document);
        }

        /// <summary>
        /// 计费管理报表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radButtonElement44_Click(object sender, EventArgs e)
        {
            DocumentWindow document = new DocumentWindow();
            ucBillingReports a = new ucBillingReports();
            document.Controls.Add(a);
            a.Dock = DockStyle.Fill;
            DataTable dt = new DataTable();
            dt.Columns.Add("Title");
            DataRow dr = dt.NewRow();
            dr["Title"] = "计费管理报表";
            dt.Rows.Add(dr);
            document.DataBindings.Add("Text", dt, "Title", false, DataSourceUpdateMode.OnPropertyChanged);

            this.radDock1.AddDocument(document);
        }

        /// <summary>
        /// 企业报表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radButtonElement45_Click(object sender, EventArgs e)
        {
            DocumentWindow document = new DocumentWindow();
            ucEnterpriseReport a = new ucEnterpriseReport();
            document.Controls.Add(a);
            a.Dock = DockStyle.Fill;
            DataTable dt = new DataTable();
            dt.Columns.Add("Title");
            DataRow dr = dt.NewRow();
            dr["Title"] = "企业报表";
            dt.Rows.Add(dr);
            document.DataBindings.Add("Text", dt, "Title", false, DataSourceUpdateMode.OnPropertyChanged);

            this.radDock1.AddDocument(document);
        }

        /// <summary>
        /// 财务凭证
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radButtonElement46_Click(object sender, EventArgs e)
        {
            DocumentWindow document = new DocumentWindow();
            ucBillingVoucher a = new ucBillingVoucher();
            document.Controls.Add(a);
            a.Dock = DockStyle.Fill;
            DataTable dt = new DataTable();
            dt.Columns.Add("Title");
            DataRow dr = dt.NewRow();
            dr["Title"] = "财务凭证";
            dt.Rows.Add(dr);
            document.DataBindings.Add("Text", dt, "Title", false, DataSourceUpdateMode.OnPropertyChanged);

            this.radDock1.AddDocument(document);
        }

        private void radButtonElement21_Click(object sender, EventArgs e)
        {
            DocumentWindow document = new DocumentWindow();
            ucBusinessMaterial a = new ucBusinessMaterial();
            document.Controls.Add(a);
            a.Dock = DockStyle.Fill;
            DataTable dt = new DataTable();
            dt.Columns.Add("Title");
            DataRow dr = dt.NewRow();
            dr["Title"] = "业务基础资料";
            dt.Rows.Add(dr);
            document.DataBindings.Add("Text", dt, "Title", false, DataSourceUpdateMode.OnPropertyChanged);
            this.radDock1.AddDocument(document);
        }

        private void radButtonElement22_Click(object sender, EventArgs e)
        {
            DocumentWindow document = new DocumentWindow();
            ucCubeType a = new ucCubeType();
            document.Controls.Add(a);
            a.Dock = DockStyle.Fill;
            DataTable dt = new DataTable();
            dt.Columns.Add("Title");
            DataRow dr = dt.NewRow();
            dr["Title"] = "设备——箱型";
            dt.Rows.Add(dr);
            document.DataBindings.Add("Text", dt, "Title", false, DataSourceUpdateMode.OnPropertyChanged);
            this.radDock1.AddDocument(document);
        }

        private void radButtonElement23_Click(object sender, EventArgs e)
        {
            DocumentWindow document = new DocumentWindow();
            ucBalance a = new ucBalance();
            document.Controls.Add(a);
            a.Dock = DockStyle.Fill;
            DataTable dt = new DataTable();
            dt.Columns.Add("Title");
            DataRow dr = dt.NewRow();
            dr["Title"] = "结算";
            dt.Rows.Add(dr);
            document.DataBindings.Add("Text", dt, "Title", false, DataSourceUpdateMode.OnPropertyChanged);
            this.radDock1.AddDocument(document);
        }

        private void radButtonElement24_Click(object sender, EventArgs e)
        {
            DocumentWindow document = new DocumentWindow();
            ucAccountMaterial a = new ucAccountMaterial();
            document.Controls.Add(a);
            a.Dock = DockStyle.Fill;
            DataTable dt = new DataTable();
            dt.Columns.Add("Title");
            DataRow dr = dt.NewRow();
            dr["Title"] = "账户资料管理";
            dt.Rows.Add(dr);
            document.DataBindings.Add("Text", dt, "Title", false, DataSourceUpdateMode.OnPropertyChanged);
            this.radDock1.AddDocument(document);
        }

        private void radButtonElement25_Click(object sender, EventArgs e)
        {
            DocumentWindow document = new DocumentWindow();
            ucStructGroupMainten a = new ucStructGroupMainten();
            document.Controls.Add(a);
            a.Dock = DockStyle.Fill;
            DataTable dt = new DataTable();
            dt.Columns.Add("Title");
            DataRow dr = dt.NewRow();
            dr["Title"] = "集团架构维护";
            dt.Rows.Add(dr);
            document.DataBindings.Add("Text", dt, "Title", false, DataSourceUpdateMode.OnPropertyChanged);
            this.radDock1.AddDocument(document);
        }

        private void radButtonElement26_Click(object sender, EventArgs e)
        {
            DocumentWindow document = new DocumentWindow();
            ucTranAddMaintenance a = new ucTranAddMaintenance();
            document.Controls.Add(a);
            a.Dock = DockStyle.Fill;
            DataTable dt = new DataTable();
            dt.Columns.Add("Title");
            DataRow dr = dt.NewRow();
            dr["Title"] = "收发通地址维护";
            dt.Rows.Add(dr);
            document.DataBindings.Add("Text", dt, "Title", false, DataSourceUpdateMode.OnPropertyChanged);
            this.radDock1.AddDocument(document);
        }

        private void radButtonElement30_Click(object sender, EventArgs e)
        {
            DocumentWindow document = new DocumentWindow();
            ucSysParams a = new ucSysParams();
            document.Controls.Add(a);
            a.Dock = DockStyle.Fill;
            DataTable dt = new DataTable();
            dt.Columns.Add("Title");
            DataRow dr = dt.NewRow();
            dr["Title"] = "系统运行参数";
            dt.Rows.Add(dr);
            document.DataBindings.Add("Text", dt, "Title", false, DataSourceUpdateMode.OnPropertyChanged);
            this.radDock1.AddDocument(document);
        }

        private void radButtonElement31_Click(object sender, EventArgs e)
        {
            DocumentWindow document = new DocumentWindow();
            ucSysCodeLib a = new ucSysCodeLib();
            document.Controls.Add(a);
            a.Dock = DockStyle.Fill;
            DataTable dt = new DataTable();
            dt.Columns.Add("Title");
            DataRow dr = dt.NewRow();
            dr["Title"] = "系统代码管理";
            dt.Rows.Add(dr);
            document.DataBindings.Add("Text", dt, "Title", false, DataSourceUpdateMode.OnPropertyChanged);
            this.radDock1.AddDocument(document);
        }

        private void radButtonElement32_Click(object sender, EventArgs e)
        {
            DocumentWindow document = new DocumentWindow();
            ucAutoCodeRules a = new ucAutoCodeRules();
            document.Controls.Add(a);
            a.Dock = DockStyle.Fill;
            DataTable dt = new DataTable();
            dt.Columns.Add("Title");
            DataRow dr = dt.NewRow();
            dr["Title"] = "自动编码规则";
            dt.Rows.Add(dr);
            document.DataBindings.Add("Text", dt, "Title", false, DataSourceUpdateMode.OnPropertyChanged);
            this.radDock1.AddDocument(document);
        }

        private void radButtonElement33_Click(object sender, EventArgs e)
        {
            DocumentWindow document = new DocumentWindow();
            ucJobNumRules a = new ucJobNumRules();
            document.Controls.Add(a);
            a.Dock = DockStyle.Fill;
            DataTable dt = new DataTable();
            dt.Columns.Add("Title");
            DataRow dr = dt.NewRow();
            dr["Title"] = "工作号编码规则";
            dt.Rows.Add(dr);
            document.DataBindings.Add("Text", dt, "Title", false, DataSourceUpdateMode.OnPropertyChanged);
            this.radDock1.AddDocument(document);
        }

        private void radButtonElement29_Click(object sender, EventArgs e)
        {
            DocumentWindow document = new DocumentWindow();
            ucOperationsLog a = new ucOperationsLog();
            document.Controls.Add(a);
            a.Dock = DockStyle.Fill;
            DataTable dt = new DataTable();
            dt.Columns.Add("Title");
            DataRow dr = dt.NewRow();
            dr["Title"] = "操作日志";
            dt.Rows.Add(dr);
            document.DataBindings.Add("Text", dt, "Title", false, DataSourceUpdateMode.OnPropertyChanged);
            this.radDock1.AddDocument(document);
        }

        private void radButtonElement28_Click(object sender, EventArgs e)
        {
            DocumentWindow document = new DocumentWindow();
            ucPermAndGroupManage a = new ucPermAndGroupManage();
            document.Controls.Add(a);
            a.Dock = DockStyle.Fill;
            DataTable dt = new DataTable();
            dt.Columns.Add("Title");
            DataRow dr = dt.NewRow();
            dr["Title"] = "权限及用户组管理";
            dt.Rows.Add(dr);
            document.DataBindings.Add("Text", dt, "Title", false, DataSourceUpdateMode.OnPropertyChanged);
            this.radDock1.AddDocument(document);
        }

        private void radButtonElement27_Click(object sender, EventArgs e)
        {
            DocumentWindow document = new DocumentWindow();
            ucUserManage a = new ucUserManage();
            document.Controls.Add(a);
            a.Dock = DockStyle.Fill;
            DataTable dt = new DataTable();
            dt.Columns.Add("Title");
            DataRow dr = dt.NewRow();
            dr["Title"] = "用户管理";
            dt.Rows.Add(dr);
            document.DataBindings.Add("Text", dt, "Title", false, DataSourceUpdateMode.OnPropertyChanged);
            this.radDock1.AddDocument(document);
        }
    }
}
