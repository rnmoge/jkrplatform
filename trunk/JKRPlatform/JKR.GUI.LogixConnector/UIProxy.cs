using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Windows.Forms;
using JKR.Common.Zipper;
using JKR.GUI.LogixConnector.Alarm;
using JKR.Util;
using Telerik.WinControls.UI;

namespace JKR.GUI.LogixConnector
{
    #region  enum

    public enum HintMessageType
    {

        /// <summary>
        /// 审核失败
        /// </summary>
        MSG_APPROVE_FAILURE = 620,

        /// <summary>
        /// 审核成功
        /// </summary>
        MSG_APPROVE_SUCCESS = 610,

        /// <summary>
        /// 是否审核
        /// </summary>
        MSG_APPROVE_SURE = 600,

        /// <summary>
        /// 是否审核 确认审核{0}
        /// </summary>
        MSG_APPROVE_SURE_FIELD = 0x259,


        MSG_CANCEL_FAILURE = 0x460,
        MSG_CANCEL_SUCCESS = 0x456,
        MSG_CANCEL_SURE = 0x44c,
        MSG_CANCEL_SURE_FIELD = 0x44d,
        MSG_CHECK_DATA_HAD_EXIST = 0x2cd,
        MSG_CHECK_DATA_HAD_EXIST_FIELD = 0x2ce,

        /// <summary>
        /// 列表中数据有误,不能保存,请检查
        /// </summary>
        MSG_CHECK_DATAINVALID = 0x2c7,

        /// <summary>
        /// 
        /// </summary>
        MSG_CHECK_DATALENGTH = 0x2cb,

        /// <summary>
        /// THE VAULE OF DATA_TYPE IS EMPTY !
        /// </summary>
        MSG_CHECK_DATATYPE = 0x2ca,

        /// <summary>
        /// 检查出错
        /// </summary>
        MSG_CHECK_ERROR = 0x2bd,

        /// <summary>
        /// 检查字段出错
        /// </summary>
        MSG_CHECK_ERROR_FIELD = 0x2be,


        MSG_CHECK_MUST_FILL_IN = 0x2cc,

        /// <summary>
        /// the value of parameter cannot be empty THE VAULE OF DATA_TYPE IS EMPTY !
        /// </summary>
        MSG_CHECK_NOTEMPTY = 0x2c9,

        /// <summary>
        /// 
        /// </summary>
        MSG_CHECK_NOTFOUND_XTRAPRINTINGLIBRARY = 0x2cf,

        /// <summary>
        /// 
        /// </summary>
        MSG_COMMAND_FAILURE = 0x322,
        MSG_COMMAND_LOADED = 0x321,

        /// <summary>
        /// 删除失败
        /// </summary>
        MSG_DELETE_FAILURE = 420,

        /// <summary>
        /// 此条记录被引用，不能被删除
        /// </summary>
        MSG_DELETE_REFERENCEBY = 430,

        /// <summary>
        /// 删除成功
        /// </summary>
        MSG_DELETE_SUCCESS = 410,

        /// <summary>
        /// 是否删除
        /// </summary>
        MSG_DELETE_SURE = 400,

        /// <summary>
        /// Are you sure delete the {0}  selected {0}st{1}ring.format(str,field)
        /// </summary>
        MSG_DELETE_SURE_FIELD = 0x191,

        /// <summary>
        /// 
        /// </summary>
        MSG_DISPLAY_RESULT_SURE = 0x13ed,

        /// <summary>
        /// Export to Excel Format File!
        /// </summary>
        MSG_EXPORT_NOTFORMATFILE = 0x44d,

        /// <summary>
        /// 操作完成失败
        /// </summary>
        MSG_FINISH_FAILURE = 0x58c,

        /// <summary>
        /// 操作完成成功
        /// </summary>
        MSG_FINISH_SUCCESS = 0x582,

        /// <summary>
        /// 是否操作完成
        /// </summary>
        MSG_FINISH_SURE = 0x578,

        /// <summary>
        /// 是否操作完成{0}
        /// </summary>
        MSG_FINISH_SURE_FIELD = 0x579,

        /// <summary>
        /// 载入失败
        /// </summary>
        MSG_LOAD_FAILURE = 0x1f6,

        /// <summary>
        /// 载入成功
        /// </summary>
        MSG_LOAD_SUCCESS = 0x1f5,

        /// <summary>
        /// 锁定失败
        /// </summary>
        MSG_LOCK_FAILURE = 0x5f0,

        /// <summary>
        /// 锁定成功
        /// </summary>
        MSG_LOCK_SUCCESS = 0x5e6,
        
        /// <summary>
        /// 是否锁定
        /// </summary>
        MSG_LOCK_SURE = 0x5dc,

        /// <summary>
        /// 是否锁定{0}
        /// </summary>
        MSG_LOCK_SURE_FIELD = 0x5dd,

        /// <summary>
        /// 系统以前，现在不用
        /// </summary>
        MSG_MUST_FILL_IN = 0x2cc,

        /// <summary>
        /// 新增失败
        /// </summary>
        MSG_NEW_FAILURE = 0x66,

        /// <summary>
        /// 新增成功
        /// </summary>
        MSG_NEW_SUCCESS = 0x65,

        /// <summary>
        /// 缺少权限
        /// </summary>
        MSG_NO_PRIVILEGE = 0x1450,

        /// <summary>
        /// 数据没有找到
        /// </summary>
        MSG_NOT_FOUNDED = 0x4b1,

        /// <summary>
        /// 
        /// </summary>
        MSG_NOTIFY_FAILURE = 0x4c4,
        MSG_NOTIFY_SUCCESS = 0x4ba,
        MSG_NOTIFY_SURE = 0x4b0,
        MSG_NOTIFY_SURE_FIELD = 0x4b1,

        /// <summary>
        /// 打印失败
        /// </summary>
        MSG_PRINT_FAILURE = 0x528,

        /// <summary>
        /// 打印成功
        /// </summary>
        MSG_PRINT_SUCCESS = 0x51e,

        /// <summary>
        /// 是否打印
        /// </summary>
        MSG_PRINT_SURE = 0x514,

        /// <summary>
        /// 是否打印{0}
        /// </summary>
        MSG_PRINT_SURE_FIELD = 0x515,

        /// <summary>
        /// 
        /// </summary>
        MSG_RESULT_DATA_NOT_CHANGED = 0x13ed,

        /// <summary>
        /// {0}Records have been found
        /// </summary>
        MSG_RESULT_FOUNDED_FIELD = 0x13ec,

        /// <summary>
        /// 数据改变,是否保存
        /// </summary>
        MSG_SAVE_CHANGED_SURE = 200,

        /// <summary>
        /// 保存失败 
        /// </summary>
        MSG_SAVE_FAILURE = 0xca,

        /// <summary>
        /// 数据已经改变,请先保存
        /// </summary>
        MSG_SAVE_MUST = 0xcb,

        /// <summary>
        /// 保存成功
        /// </summary>
        MSG_SAVE_SUCCESS = 0xc9,

        /// <summary>
        /// 系统以前，现在不用
        /// </summary>
        MSG_SURE_DELETE = 400,
        
        /// <summary>
        /// 系统以前，现在不用
        /// </summary>
        MSG_SURE_DISPLAY_RESULT = 0x13ed,

        /// <summary>
        /// 系统以前，现在不用
        /// </summary>
        MSG_SURE_SAVE_CHANGED = 200,

        /// <summary>
        /// 审核取消失败
        /// </summary>
        MSG_UNAPPROVE_FAILURE = 670,

        /// <summary>
        /// 审核取消成功
        /// </summary>
        MSG_UNAPPROVE_SUCCESS = 660,

        /// <summary>
        /// 是否取消审核
        /// </summary>
        MSG_UNAPPROVE_SURE = 650,

        /// <summary>
        ///  是否取消审核    确认取消审核{0}
        /// </summary>
        MSG_UNAPPROVE_SURE_FIELD = 0x28b,

        /// <summary>
        /// 未知的错误
        /// </summary>
        MSG_UNEXPECTED_ERROR = 0x238c,

        /// <summary>
        /// 数据有改变，是否更新
        /// </summary>
        MSG_UPDATE_CHANGED_SURE = 300,

        /// <summary>
        /// 更新失败
        /// </summary>
        MSG_UPDATE_FAILURE = 0x12e,

        /// <summary>
        /// 更新成功
        /// </summary>
        MSG_UPDATE_SUCCESS = 0x12d
    }

    public enum LogixResult
    {
        None = 0,
        Success = 1,
        ServiceFailure = 2,
        UnknownFailure = 3,
        ConnectionFailure = 4,
        AuthenticationFailure = 5
    }

    #endregion

    public class UIProxy
    {

        #region CurrentCookieConnector
        private static CookieContainer cookieConnector;

        public static CookieContainer CurrentCookieConnector
        {
            get
            {
                if (cookieConnector == null)
                {
                    cookieConnector = new CookieContainer();
                }
                return cookieConnector;
            }
        }

        #endregion

        #region 常量

        //* 组权限后缀
        private const string GROUP_PRIVILEGE_SUFFIX = ".G";
        private const string ALL_PRIVILEGE_SUFFIX = ".A";

        private const string Null_Date = "1899-12-30";
        private const string xmlName = "MasterData.XML";
        private const string xmlSchemaName = "MasterDataSchema.XML";

        //平台逻辑DLL名
        private const string PLATFORM_LOGIX = "PlatformLogix";
       
        public enum LanguageType
        {
            English,
            Chinese
        }

        #endregion

        #region Public & Private

        //权限相关的变量
        public static ArrayList m_Privileges;
        public static string m_UserList;
        public static StringBuilder userList;

        public static string m_GroupUsers;
        public static string m_CurrentCommandCode;
        private static UIProxy m_instance;
        private static string m_ConnectionString;

        //原理：将界面中某些区域直接交给UIPRoxy进行管理
        private RadWaitingBar m_StatusBar;                      //用于保存主窗体的StatusBar
        private RadProgressBar m_ProgressBarControl;      //进度条
        private RadProgressBarItem m_StaticItemHint;             //状态栏中显示消息的区域 


        private string m_TypeOfConnection;
        private Connector _m_wsConnector;
        private Connector m_wsConnector
        {
            get
            {
                //this._m_wsConnector.CookieContainer = CurrentCookieConnector;
                //this._m_wsConnector.Timeout = 0x1b7740;
                return this._m_wsConnector;
            }
        }

        /// <summary>
        /// 加密票
        /// </summary>
        internal string m_Ticket;
        //当前用户信息，在WS的UserInformation.VB中定义
        public static UserInformation m_CurrentUserInformation;
        //当前的日期，取自WS服务器,本地自己增加
        public static DateTime m_CurrDateTime;
        
        private DataSet m_dsLocalMasterData;
        public static DataSet m_LocalDataSet;

        private string Last_Update_Date;

        private static DataSet m_FunctionList;

        internal const int c_wsTimeout = 0x7530;

        private static LanguageType m_language;

        private static string _m_ExtensionCustomWSUrl;

        private IAlarm m_Alarm;

        private RadProgressBarElement m_AlarmItem;

        #endregion

        #region 公布的属性

        //主窗体传递的UI区域，由UIProxy进行控制
         //主窗体传递进来的主界面状态行区域
        public RadWaitingBar StatusBar
        {
            get
            {
                return this.m_StatusBar;
            }
            set
            {
                this.m_StatusBar = value;
            }
        }

        //主窗体传递进来的进度条区域
        public RadProgressBar ProgressBarControl
        {
            get
            {
                return this.m_ProgressBarControl;
            }
            set
            {
                this.m_ProgressBarControl = value;
            }
        }

        //状态栏中显示消息的区域
        public RadProgressBarItem StaticItemHint
        {
            get
            {
                return this.m_StaticItemHint;
            }
            set
            {
                this.m_StaticItemHint = value;
            }
        }

        public void SendAlarm(IAlarm alarm)
        {
            if (alarm != null)
            {
                this.m_Alarm = alarm;
                this.m_AlarmItem.Text = alarm.AlarmTitle;
                this.m_AlarmItem.Font =RadProgressBar.DefaultFont;
                Point p = new Point();
                p.X = this.m_Lable.Location.X;
                p.Y = this.m_Lable.Location.Y + 120;
                this._toolTip.AutoSize = true;
                //this._toolTip.Rounded = true;
                //this._toolTip.se = 0x7d0;
                //this._toolTip.ShowBeak = true;
                //this._toolTip.hShowHint(alarm.AlarmTitle, alarm.AlarmContent, ToolTipLocation.RightTop, p);
            }
            else
            {
                this.m_Alarm = null;              
                this.m_AlarmItem.Text=(Language==LanguageType.Chinese?"无预警":"No alarm");
                this.m_AlarmItem.Font = RadProgressBar.DefaultFont;
            }
        }

        private RadToolStrip _toolTip;
        public RadToolStrip ToolTip
        {
            get
            {
                return this._toolTip;
            }
            set
            {
                this._toolTip = value;
            }
        }

        private Label m_Lable;
        public Label Lable
        {
            get
            {
                return this.m_Lable;
            }
            set
            {
                this.m_Lable = value;
            }
        }

        public IAlarm Alarm
        {
            get
            {
                return this.m_Alarm;
            }
            set
            {
                this.m_Alarm = value;
            }
        }

        public RadProgressBarElement AlarmItem
        {
            get
            {
                return this.m_AlarmItem;
            }
            set
            {
                this.m_AlarmItem = value;
            }
        }

        public string TypeOfConnection
        {
            get
            {
                return this.m_TypeOfConnection;
            }
            set
            {
                this.m_TypeOfConnection = value;
            }
        }

        public static LanguageType Language
        {
            get
            {
                return m_language;
            }
            set
            {
                m_language = value;
            }
        }

        #endregion

        #region Init UIProxy

        public bool InitUIProxy()
        {
            bool InitUIProxy;
            try
            {
                m_FunctionList = this.GetDataSet("Evin.BizCommon", "BaseData", "GetFunctionList", null);
                //取得数据库时间  --一定是最后取时间，减少误差
                m_CurrDateTime = Convert.ToDateTime(this.ExecFunction("COM_GETDATE", new object[0]));
                InitUIProxy = true;
            }
            catch (Exception ex)
            {

                m_FunctionList = this.GetDataSet("BusinessLogix_C6", "BaseData", "GetFunctionList", null);
                //Interaction.Beep(); //错误声音
                this.ShowMessage(HintMessageType.MSG_UNEXPECTED_ERROR);
                throw ex;
              
            }
            return InitUIProxy;
        }

        //取得最新的基础数据，返回更新的表数量
        public int RetrieveMasterData()
        {
            DataTable dtLocalIndex = new DataTable();

            //判断文件是否存在
            if(File.Exists(UIProxy.GetCurrentUserFolder()+@"\masterdata.xml"))
            {
                m_LocalDataSet.Clear();
                m_LocalDataSet.ReadXml(UIProxy.GetCurrentUserFolder()+@"\masterdata.xml");

            }

            //切换分公司是重新加载D_ACCOUNTS表
            if (m_LocalDataSet != null && m_LocalDataSet.Tables.Contains("D_ACCOOUNTS") && m_LocalDataSet.Tables["D_ACCOUNTS"].Rows.Count > 0)
            {
                if (m_LocalDataSet.Tables["D_ACCOUNTS"].Rows[0]["OFFICE_CODE"].ToString().Equals(UIProxy.m_CurrentUserInformation.OfficeCode))
                {
                    m_LocalDataSet.Tables.Remove("D_ACCOUNTS");

                    foreach (DataRow drtable in m_LocalDataSet.Tables["INDEX_TABLE"].Rows)
                    {
                        if (drtable["DATA_TYPE"].ToString().ToUpper() == "D_ACCOUNTS")
                        {
                            drtable.Delete();
                        }
                    }
                    m_LocalDataSet.AcceptChanges();
                }
            }

            if (m_LocalDataSet.Tables.IndexOf("INDEX_TABLE") >= 0)
            {
                dtLocalIndex = m_LocalDataSet.Tables["INDEX_TABLE"].Copy(); //删除旧的索引表
            }
            else
            {
                dtLocalIndex = GenEmptyIndexTableTable();   //取得一个空表
            }

            DataTable dt = new DataTable();
            dt.TableName = "D_OFFICE";
            DataColumn dc = new DataColumn();
            dc.ColumnName = "CURRENT_OFFICE";
            dt.Columns.Add(dc);
            DataRow dr = dt.NewRow();
            dr["CURRENT_OFFICE"] = m_CurrentUserInformation.OfficeAndSubOffice;
            dt.Rows.Add(dr);
            DataSet dsLocalIndex = new DataSet();
            dsLocalIndex.Clear();
            dsLocalIndex.Merge(dtLocalIndex);
            dsLocalIndex.Merge(dt);
            this.GenLocalMasterData(this.GetDataSetFunction("COM_GETLOCALDATASET", new object[] { dsLocalIndex }));     //产生结果应该生成一个表
            return RetrieveMasterData();

        }

        //生成空的index表 
        private DataTable GenEmptyIndexTableTable()
        {
            DataTable dt = new DataTable();
            DataColumn dcDataType = new DataColumn();
            DataColumn dcLastUpdateDate = new DataColumn();
            DataColumn dcB_Update = new DataColumn();
            dcDataType.ColumnName = "DATA_TYPE";
            dt.Columns.Add(dcDataType);
            dcLastUpdateDate.ColumnName = "LAST_UPDATE_DATE";
            dt.Columns.Add(dcLastUpdateDate);
            dcB_Update.ColumnName = "B_UPDATE";
            dt.Columns.Add(dcB_Update);
            dt.TableName = "INDEX_TABLE";
            return dt;
        }

        //根据服务器端返回的Dataset，结合本地已经有的文件，生成本地的最新的MasterData.XML和masterdata.index.xml
        //原则：后台给什么，前面就接收什么，新的东西全部收下
        private int GenLocalMasterData(DataSet dsRemote)
        {

            // 合并后新生成的Index TABLE
            DataTable dtNewLocalIndex = new DataTable();       
            int iCount = 0;         //默认更新的表

            try
            {
                if (m_LocalDataSet.Tables.IndexOf("INDEX_TABLE") >= 0)
                {
                    m_LocalDataSet.Tables.Remove(m_LocalDataSet.Tables["INDEX_TABLE"]);
                }

                if (dsRemote == null)
                {
                    iCount = dsRemote.Tables.Count;

                    foreach (DataTable dt in dsRemote.Tables)
                    {
                        if (dt.TableName.ToUpper().Equals("INDEX_TABLE"))
                        {
                            if (m_LocalDataSet.Tables.IndexOf(dt.TableName) >= 0)
                            {
                                m_LocalDataSet.Tables.Remove(m_LocalDataSet.Tables[dt.TableName]);
                            }
                            m_LocalDataSet.Merge(dt);
                        }
                    }
                }

                dtNewLocalIndex = GenEmptyIndexTableTable();
                foreach (DataTable dt in m_LocalDataSet.Tables)
                {
                    DataRow dr = new DataRow();
                    dr = dtNewLocalIndex.NewRow();
                    dr.BeginEdit();
                    dr["DATA_TYPE"] = dt.TableName;
                    dr["LAST_UPDATE_DATE"] = string.Format("yyyy-MM-dd", m_CurrDateTime).ToString();
                    dr.EndEdit();
                    dtNewLocalIndex.Rows.Add(dr);
                }

                m_LocalDataSet.Merge(dtNewLocalIndex);

                if (File.Exists(UIProxy.GetCurrentUserFolder() + @"\masterdata.xml"))
                {
                    File.Delete(UIProxy.GetCurrentUserFolder() + @"\masterdata.xml");
                }

                m_LocalDataSet.WriteXml(UIProxy.GetCurrentUserFolder() + @"masterdata.xml");

                return iCount;

            }
            catch (Exception ex)
            {
                throw ex;
                return 0;
            }
            finally
            {
                dtNewLocalIndex.Dispose();
            }

        }

        #endregion

        #region 内部调用方法

        private DataSet GetDataSet(string sDllName, string sClassName, string sFuncName, object[] args)
        {
            DataSet GetDataSet = new DataSet() ;
            try
            {
                GetDataSet = Compression.DecompressionDataSet(this.m_wsConnector.GetDataSetFunction(sDllName, sClassName, sFuncName, args));
            }
            catch (Exception ex)
            {
                throw ex;
             
            }
            return GetDataSet;
        }

        #endregion

        #region GetInstance  (singleton pattern)

        public static UIProxy GetInstance()
        {
            if (m_instance == null)
            {
                m_instance = new UIProxy();
            }
            return m_instance;
        }

        #endregion

        #region Helper Functions

        private LogixResult HandleException(Exception ex)
        {
            LogError.Write(ex.Message + "\r\n" + ex.StackTrace);
            if (ex.GetType() == typeof(WebException))
            {
                return LogixResult.ConnectionFailure;
            }
            //if (ex.GetType() == typeof(SoapException))
            //{
            //    return LogixResult.ServiceFailure;
            //}
            return LogixResult.UnknownFailure;
        }

        #endregion

        #region Progress Bar

        public void ShowProgress(int iPosition)
        {
            if (m_ProgressBarControl != null)
            {
                if (iPosition > 0)
                {
                    m_ProgressBarControl.Visible = true;
                    m_ProgressBarControl.Maximum = iPosition;
                    m_ProgressBarControl.Update();
                }
                if (iPosition >= 100)
                {
                    this.m_ProgressBarControl.Visible = false;
                }
            }
        }

        #endregion

        #region Show Message

        /// <summary>
        /// 显示错误信息，并且发出警告声
        /// </summary>
        /// <param name="msgOfZH">中文信息</param>
        /// <param name="msgOfEn">英文信息</param>
        /// <param name="msgOfOther">其他语言信息</param>
        public void ShowErrorMsg(string msgOfZH, string msgOfEn,  string msgOfOther)
        {
            if (!((this.m_StatusBar == null) | (this.m_StaticItemHint == null)))
            {
                this.m_StatusBar.BackColor = Color.Red;
                if (Language == LanguageType.Chinese)
                {
                    this.m_StaticItemHint.Tag = msgOfZH;
                }
                else if (Language == LanguageType.English)
                {
                    this.m_StaticItemHint.Tag = msgOfEn;
                }
                else
                {
                    this.m_StaticItemHint.Tag = msgOfOther;
                }
                //Interaction.Beep();
            }
        }

        /// <summary>
        /// 显示错误消息，并且发出警告声
        /// </summary>
        /// <param name="msg">自定义错误信息</param>
        public void ShowErrorMsg(string msg)
        {
            if (!((this.m_StatusBar == null) | (this.m_StaticItemHint == null)))
            {
                this.m_StatusBar.BackColor = Color.Red;
                this.m_StaticItemHint.Tag = msg;
                //Interaction.Beep();
            }
        }
        
        /// <summary>
        /// 显示错误消息，并且发出警告声
        /// </summary>
        /// <param name="hmt"></param>
        public void ShowErrorMsg(HintMessageType hmt)
        {
            ResourceManager Resource = new ResourceManager("JKR.GUI.LogixConnector.Message", Assembly.GetExecutingAssembly());
            if (!((this.m_StatusBar == null) | (this.m_StaticItemHint == null)))
            {
                this.m_StatusBar.BackColor = Color.Red;
                this.m_StaticItemHint.Tag = Resource.GetString(hmt.ToString());
                //Interaction.Beep();
            }
        }

        /// <summary>
        /// 显示错误消息，并且发出警告声
        /// </summary>
        /// <param name="hmt"></param>
        /// <param name="value"></param>
        public void ShowErrorMsg(HintMessageType hmt, params string[] value)
        {
            ResourceManager Resource = new ResourceManager("JKR.GUI.LogixConnector.Message", Assembly.GetExecutingAssembly());
            if (!((this.m_StatusBar == null) | (this.m_StaticItemHint == null)))
            {
                this.m_StatusBar.BackColor = Color.Red;
                this.m_StaticItemHint.Tag = string.Format(Resource.GetString(hmt.ToString()), (object[])value);
                //Interaction.Beep();
            }
        }

        /// <summary>
        /// 显示警告信息，并且发出警告声
        /// </summary>
        /// <param name="msgOfZH">中文信息</param>
        /// <param name="msgOfEn">英文信息</param>
        /// <param name="msgOfOther">其他语言信息</param>
        public void ShowAlarmMsg(string msgOfZH, string msgOfEn, string msgOfOther)
        {
            if (!((this.m_StatusBar == null) | (this.m_StaticItemHint == null)))
            {
                this.m_StatusBar.BackColor = Color.Yellow;
                if (Language == LanguageType.Chinese)
                {
                    this.m_StaticItemHint.Tag = msgOfZH;
                }
                else if (Language == LanguageType.English)
                {
                    this.m_StaticItemHint.Tag = msgOfEn;
                }
                else
                {
                    this.m_StaticItemHint.Tag = msgOfOther;
                }
                //Interaction.Beep();
            }
        }

        /// <summary>
        ///  显示警告信息,并且发出警告声
        /// </summary>
        /// <param name="msg">自定义警告信息</param>
        public void ShowAlarmMsg(string msg)
        {
            if (!((this.m_StatusBar == null) | (this.m_StaticItemHint == null)))
            {
                this.m_StatusBar.BackColor = Color.Yellow;
                this.m_StaticItemHint.Tag = msg;
                //Interaction.Beep();
            }
        }

        ///// <summary>
        ///// 显示警告信息,并且发出警告声
        ///// </summary>
        ///// <param name="hmt"></param>
        //public void ShowErrorMsg(HintMessageType hmt)
        //{
        //    ResourceManager Resource = new ResourceManager("JKR.GUI.LogixConnector.Message", Assembly.GetExecutingAssembly());
        //    if (!((this.m_StatusBar == null) | (this.m_StaticItemHint == null)))
        //    {
        //        this.m_StatusBar.BackColor = Color.Red;
        //        this.m_StaticItemHint.Tag = Resource.GetString(hmt.ToString());
        //        //Interaction.Beep();
        //    }
        //}

        /// <summary>
        /// 显示警告信息,并且发出警告声
        /// </summary>
        /// <param name="hmt"></param>
        /// <param name="value"></param>
        public void ShowAlarmMsg(HintMessageType hmt, params string[] value)
        {
            ResourceManager Resource = new ResourceManager("Evin.GUI.LogixConnector.Message", Assembly.GetExecutingAssembly());
            if (!((this.m_StatusBar == null) | (this.m_StaticItemHint == null)))
            {
                this.m_StatusBar.BackColor = Color.Yellow;
                this.m_StaticItemHint.Tag = string.Format(Resource.GetString(hmt.ToString()), (object[])value);
                //Interaction.Beep();
            }
        }

        /// <summary>
        /// 显示正常信息
        /// </summary>
        /// <param name="msgOfZH">中文信息</param>
        /// <param name="msgOfEn">英文信息</param>
        /// <param name="msgOfOther">其他语言信息</param>
        public void ShowNormalMsg(string msgOfZH, string msgOfEn, string msgOfOther)
        {
            if (!((this.m_StatusBar == null) | (this.m_StaticItemHint == null)))
            {
                this.m_StatusBar.BackColor = SystemColors.Control;
                if (Language == LanguageType.Chinese)
                {
                    this.m_StaticItemHint.Tag = msgOfZH;
                }
                else if (Language == LanguageType.English)
                {
                    this.m_StaticItemHint.Tag = msgOfEn;
                }
                else
                {
                    this.m_StaticItemHint.Tag = msgOfOther;
                }
            }
        }

        public void ShowNormalMsg(string msg)
        {
            if (!((this.m_StatusBar == null) | (this.m_StaticItemHint == null)))
            {
                this.m_StatusBar.BackColor = SystemColors.Control;
                this.m_StaticItemHint.Tag = msg;
            }
        }

        public void ShowNormalMsg(HintMessageType hmt)
        {
            ResourceManager Resource = new ResourceManager("JKR.GUI.LogixConnector.Message", Assembly.GetExecutingAssembly());
            if (!((this.m_StatusBar == null) | (this.m_StaticItemHint == null)))
            {
                this.m_StatusBar.BackColor = SystemColors.Control;
                this.m_StaticItemHint.Tag = Resource.GetString(hmt.ToString());
            }
        }

        public void ShowNormalMsg(HintMessageType hmt, params string[] value)
        {
            ResourceManager Resource = new ResourceManager("JKR.GUI.LogixConnector.Message", Assembly.GetExecutingAssembly());
            if (!((this.m_StatusBar == null) | (this.m_StaticItemHint == null)))
            {
                this.m_StatusBar.BackColor = SystemColors.Control;
                this.m_StaticItemHint.Tag = string.Format(Resource.GetString(hmt.ToString()), (object[])value);
            }
        }

        public void ShowNormalMsg(HintMessageType hmt, int value)
        {
            ResourceManager Resource = new ResourceManager("JKR.GUI.LogixConnector.Message", Assembly.GetExecutingAssembly());
            if (!((this.m_StatusBar == null) | (this.m_StaticItemHint == null)))
            {
                this.m_StatusBar.BackColor = SystemColors.Control;
                this.m_StaticItemHint.Tag = string.Format(Resource.GetString(hmt.ToString()), value);
            }
        }

       // private static MessageForm MessageForm;
 
        public void ShowMessage(string text)
        {

            this.ShowAlarmMsg(text);

        }

        public void ShowMessage(HintMessageType hmt, params string[] value)
        {

            ResourceManager Resource = new ResourceManager("JKR.GUI.LogixConnector.Message", Assembly.GetExecutingAssembly());
            this.ShowMessage(string.Format(Resource.GetString(hmt.ToString()), (object[])value));

        }

        public DialogResult ShowMessage(HintMessageType hmt)
        {
            ResourceManager Resource = new ResourceManager("JKR.GUI.LogixConnector.Message", Assembly.GetExecutingAssembly());
            if (hmt.ToString().Trim().ToUpper().IndexOf("SUCCESS") > -1)
            {
                this.ShowNormalMsg(Resource.GetString(hmt.ToString()));
                return DialogResult.None;
            }
            if (hmt.ToString().Trim().ToUpper().IndexOf("FAILURE") > -1)
            {
                this.ShowErrorMsg(Resource.GetString(hmt.ToString()));
                return DialogResult.None;
            }
            if (hmt.ToString().Trim().ToUpper().IndexOf("SURE") > -1)
            {
                //return MessageForm.ShowMessage(Resource.GetString(hmt.ToString()));
            }
            switch (hmt)
            {
                case HintMessageType.MSG_DELETE_REFERENCEBY:
                    this.ShowErrorMsg(Resource.GetString(hmt.ToString()));
                    return DialogResult.None;

                case HintMessageType.MSG_CHECK_DATAINVALID:
                case HintMessageType.MSG_NOTIFY_SURE_FIELD:
                    this.ShowAlarmMsg(Resource.GetString(hmt.ToString()));
                    return DialogResult.None;
            }
            this.ShowNormalMsg(Resource.GetString(hmt.ToString()));
            return DialogResult.None;
        }

        #endregion

        #region

        #endregion
        #region 访问业务逻辑的通道


        private object CallLocalMethod(string sDllName, string sClassName, string sFuncName, object[] args)
        {
            object NewInstance = Activator.CreateInstance(Assembly.LoadFrom(Application.StartupPath + @"\" + sDllName + ".DLL").GetType(sDllName + "." + sClassName));
            return NewInstance.GetType().GetMethod(sFuncName).Invoke(NewInstance, args);
        }

        public object ExecFunction(string func_code, object[] args)
        {
            try
            {
                string sClassName = string.Empty;
                string sDllName = string.Empty;
                string sFuncName = string.Empty;

                DataRow[] rows = m_FunctionList.Tables[0].Select(" FUNCTION_CODE='" + func_code + "'");

                if (rows.Length > 0)
                {
                    sDllName = rows[0]["DLL_NAME"].ToString();
                    sClassName = rows[0]["CLASS_NAME"].ToString();
                    sFuncName = rows[0]["FUNCTION_NAME"].ToString();
                }

                switch (m_TypeOfConnection)
                {                    
                    case"LAN":
                        return CallLocalMethod(sDllName, sClassName, sFuncName, args);
                        break;
                    case"WS":
                        object obj=new object();
                        if (args == null)
                        {
                            obj= _m_wsConnector.ExecFunction(sDllName, sClassName, sFuncName, args);
                        }
                        else
                        {
                            object args0 = args[0];
                            if (!args0.GetType().Name.ToUpper().Equals("DATASET"))
                            {
                                obj = _m_wsConnector.ExecFunction(sDllName, sClassName, sFuncName, args);
                            }
                            else
                            {
                                object[] dsArgs = new object[(args.Length - 1) + 1];
                                for (int i = 0; i < dsArgs.Length; i++)
                                {
                                    dsArgs[i] = Compression.CompressionDataSet((DataSet)args[i]);

                                }
                            }
                        }
                        return obj;
                        break;
                }

                return null;

            }
            catch (Exception ex)
            {
                ShowException(ex);
                return null;
            }
        }

        public DataSet GetDataSetFunction(string func_code, object[] args)
        {
            try
            {
                string sClassName=string.Empty;
                string sDLLName = string.Empty;
                string sFuncName = string.Empty;
                DataRow[] rows = m_FunctionList.Tables[0].Select(" FUNCTION_CODE='" + func_code + "'");

                if (rows.Length > 0)
                {
                    sDLLName = rows[0]["DLL_NAME"].ToString();
                    sClassName = rows[0]["CLASS_NAME"].ToString();
                    sFuncName = rows[0]["FUNCTION_NAME"].ToString();
                }

                switch (m_TypeOfConnection)
                {
                    case "LAN":
                        return (DataSet) this.CallLocalMethod(sDLLName, sClassName, sFuncName, args);
                        
                    case "WS":
                        Byte[] bytes={};

                        if (args == null)
                        {
                            bytes = m_wsConnector.GetDataSetFunction(sDLLName, sClassName, sFuncName, args);
                            return Compression.DecompressionDataSet(bytes);
                        }
                        else
                        {
                            if (args.Length == 0)
                            {
                                bytes = m_wsConnector.GetDataSetFunction(sDLLName, sClassName, sFuncName, args);
                                return Compression.DecompressionDataSet(bytes);
                            }
                            else
                            {
                                Object args0 = args[0];

                                if (!args0.GetType().Name.ToUpper().Equals("DATASET"))
                                {
                                    bytes = m_wsConnector.GetDataSetFunction(sDLLName, sClassName, sFuncName, args);
                                    return Compression.DecompressionDataSet(bytes);
                                }
                                else
                                {
                                    object[] dsArgs = new object[(args.Length - 1) + 1];

                                    for (int i = 0; i < args.Length; i++)
                                    {
                                        dsArgs[i] = Compression.CompressionDataSet((DataSet)args[i]);
                                    }
                                    bytes = bytes = m_wsConnector.GetDataSetFunctionByDataSet(sDLLName, sClassName, sFuncName, dsArgs);

                                    return Compression.DecompressionDataSet(bytes);
                                }
                            }
                            //return Compression.DecompressionDataSet(bytes);
                        }

                }
                return null;

            }
            catch (Exception ex)
            {
                ShowException(ex);
                return null;
            }
        }

        public void ShowException(Exception e)
        {
            LogError.Write(e.Message + "\r\n" + e.StackTrace);
        }

        #endregion



        #region  [CAC]

        public static string GetCurrentUserFolder()
        {
            string GetCurrentUserFolder;
            try
            {
                string UserCode = m_CurrentUserInformation.UserCode;
                string filePath = AppDomain.CurrentDomain.BaseDirectory + @"\SystemUser\" + UserCode + @"\LocalSetting.Xml";
                //string filePath = MyProject.Application.Info.DirectoryPath + @"\SystemUser\" + UserCode + @"\LocalSetting.Xml";
                FileInfo fi = new FileInfo(filePath);
                if (!fi.Directory.Exists)
                {
                    fi.Directory.Create();
                }
                if (!fi.Exists)
                {
                    new FileInfo(AppDomain.CurrentDomain.BaseDirectory + @"\LocalSetting.Xml").CopyTo(filePath);
                }
                GetCurrentUserFolder = fi.Directory.FullName;
            }
            catch (Exception ex)
            {

                GetCurrentUserFolder = AppDomain.CurrentDomain.BaseDirectory;

                return GetCurrentUserFolder;

            }
            return GetCurrentUserFolder;
        }

        #endregion

    }
}
