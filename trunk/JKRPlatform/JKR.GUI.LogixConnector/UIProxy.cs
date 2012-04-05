using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Net;
using System.Data;
using System.IO;
using System.Resources;
using System.Threading;
using System.Reflection;
using System.Configuration;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Security.Cryptography;
using JKR.GUI.LogixConnector.Alarm;
using Telerik.WinControls.UI;
using JKR.Util;
using JKR.Common.Zipper;
using JKR.GUI.Controls;
using JKR.GUI.LogixConnector.Report.Forms;
using JKR.GUI.LogixConnector.CommonForm;
using System.Diagnostics;

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
        public RadProgressBarElement ProgressBarControl
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
                this.m_AlarmItem.Font = RadProgressBar.DefaultFont;
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
                this.m_AlarmItem.Text = (Language == LanguageType.Chinese ? "无预警" : "No alarm");
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
            if (File.Exists(UIProxy.GetCurrentUserFolder() + @"\masterdata.xml"))
            {
                m_LocalDataSet.Clear();
                m_LocalDataSet.ReadXml(UIProxy.GetCurrentUserFolder() + @"\masterdata.xml");

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
            DataSet GetDataSet;
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
        public void ShowErrorMsg(string msgOfZH, string msgOfEn, string msgOfOther)
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

        /// <summary>
        /// 显示警告信息,并且发出警告声
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

        private static MessageForm MessageForm;

        private static DialogResult ShowPopupMessage(HintMessageType hmt)
        {
            ResourceManager Resource = new ResourceManager("JKR.GUI.LogixConnector.Message", Assembly.GetExecutingAssembly());
            return MessageForm.ShowMessage(Resource.GetString(hmt.ToString()));

        }

        public static DialogResult ShowPopupMessage(HintMessageType hmt, string messageDemo, params string[] value)
        {
            ResourceManager Resource = new ResourceManager("JKR.GUI.LogixConnector.Message", Assembly.GetExecutingAssembly());
            MessageForm.MessageDemo = messageDemo;
            return MessageForm.ShowMessage(string.Format(Resource.GetString(hmt.ToString()), (object[])value));
        }

        public static DialogResult ShowPopupMessage(string text)
        {
            return MessageForm.ShowMessage(text);
        }

        public static DialogResult ShowPopupMessage(string text, MessageBoxButtons button)
        {
            return MessageForm.ShowMessage(text, string.Empty, button);
        }

        public static DialogResult ShowPopupMessage(string text, string messageDemo)
        {
            MessageForm.MessageDemo = messageDemo;
            return MessageForm.ShowMessage(text);
        }

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
                return MessageForm.ShowMessage(Resource.GetString(hmt.ToString()));
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

        public string GetMessageByHintMessageType(HintMessageType hmt)
        {
            ResourceManager resource = new ResourceManager("JKR.GUI.LogixConnector.Message", Assembly.GetExecutingAssembly());
            return resource.GetString(hmt.ToString());
        }

        public void ClearMessage()
        {
            this.m_StatusBar.BackColor = SystemColors.Control;
            this.m_StaticItemHint.Tag = string.Empty;
        }

        #endregion

        #region 计算性能时间

        public static void TicksStart()
        {
            clsTicks.Start();
        }

        public static long GetTicksSecond(string Remark, bool Append)
        {
            return clsTicks.ReturnCountAfterStop(Remark, Append);

        }

        #endregion

        #region 访问业务逻辑的通道

        public void SetServerAddress(string server_address)
        {
            if (server_address.Trim() != "")
            {
                this.m_wsConnector.Url = "http://" + server_address + "/wsproxy2/Connector.asmx ";
                string[] address = server_address.Split(new char[] { ':' });
                _m_ExtensionCustomWSUrl = "http://" + address[0] + "/ExtensionCustom/WS/ExtensionCustom.asmx";
            }
            else
            {
                this.m_wsConnector.Url = "http://LocalHost/wsproxy2/Connector.asmx ";
                _m_ExtensionCustomWSUrl = "http://LocalHost/ExtensionCustom/WS/ExtensionCustom.asmx";
            }
        }

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
                    case "LAN":
                        return CallLocalMethod(sDllName, sClassName, sFuncName, args);

                    case "WS":
                        object obj = new object();
                        if (args == null)
                        {
                            obj = _m_wsConnector.ExecFunction(sDllName, sClassName, sFuncName, args);
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
                string sClassName = string.Empty;
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
                        return (DataSet)this.CallLocalMethod(sDLLName, sClassName, sFuncName, args);

                    case "WS":
                        Byte[] bytes;

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

        public object ExecFunctionByName(string func_code, string business_function_name, object[] args)
        {

            try
            {
                string sClassName = string.Empty;
                string sDllName = string.Empty;
                DataRow[] rows = m_FunctionList.Tables[0].Select(" FUNCTION_CODE='" + func_code + "'");
                if (rows.Length > 0)
                {
                    sDllName = rows[0]["DLL_NAME"].ToString();
                    sClassName = rows[0]["CLASS_NAME"].ToString();
                }

                switch (m_TypeOfConnection)
                {
                    case "LAN":
                        return this.CallLocalMethod(sDllName, sClassName, business_function_name, args);
                    case "WS":
                        object obj = new object();
                        if (args == null)
                        {
                            obj = m_wsConnector.ExecFunction(sDllName, sClassName, business_function_name, args);
                        }
                        else
                        {
                            object args0 = args[0];
                            if (!args0.GetType().Name.ToUpper().Equals("DATASET"))
                            {
                                obj = m_wsConnector.ExecFunction(sDllName, sClassName, business_function_name, args);
                            }
                            else
                            {
                                object[] dsArgs = new object[(args.Length - 1) + 1];
                                for (int i = 0; i <= args.Length - 1; i++)
                                {
                                    dsArgs[i] = Compression.CompressionDataSet((DataSet)args[i]);
                                }
                                obj = m_wsConnector.ExecFunctionByDataSet(sDllName, sClassName, business_function_name, dsArgs);
                            }
                        }
                        return obj;
                }
            }
            catch (Exception ex)
            {
                ShowException(ex);

            }
            return null;
        }

        public DataSet GetDataSetByFunctionName(string func_code, string business_function_name, object[] args)
        {
            try
            {
                string sDLLName = string.Empty;
                string sClassName = string.Empty;

                DataRow[] rows = m_FunctionList.Tables[0].Select("FUNCTION_CODE='" + func_code + "'");

                if (rows.Length > 0)
                {
                    sDLLName = rows[0]["DLL_NAME"].ToString();
                    sClassName = rows[0]["CLASS_NAME"].ToString();
                }

                switch (m_TypeOfConnection)
                {
                    case "LAN":
                        return (DataSet)CallLocalMethod(sDLLName, sClassName, business_function_name, args);
                    case "WS":
                        byte[] bytes;
                        if (args == null)
                        {
                            bytes = m_wsConnector.GetDataSetFunction(sDLLName, sClassName, business_function_name, args);
                            return Compression.DecompressionDataSet(bytes);
                        }
                        else
                        {
                            if (args.Length == 0)
                            {
                                bytes = m_wsConnector.GetDataSetFunction(sDLLName, sClassName, business_function_name, args);
                                return Compression.DecompressionDataSet(bytes);
                            }
                            else
                            {
                                object[] dsArgs = new object[(args.Length - 1) + 1];
                                for (int i = 0; i < args.Length - 1; i++)
                                {
                                    dsArgs[i] = Compression.CompressionDataSet((DataSet)args[i]);
                                }
                                bytes = m_wsConnector.GetDataSetFunctionByDataSet(sDLLName, sClassName, business_function_name, dsArgs);
                                return Compression.DecompressionDataSet(bytes);
                            }
                        }
                }
            }
            catch (Exception ex)
            {
                ShowException(ex);
            }
            return null;
        }

        public void ShowException(Exception e)
        {
            LogError.Write(e.Message + "\r\n" + e.StackTrace);
        }

        public string GetSingleValBySQL(string sql)
        {
            try
            {
                string sResult = this.ExecFunction("COM_GETSINGLEVALUEBYSQL", new object[] { sql }).ToString();
                return sResult;
            }
            catch (Exception ex)
            {
                ShowException(ex);
                return null;
            }
        }

        public string GetMasterSeqId()
        {
            try
            {
                string sSeqNo = this.ExecFunction("COM_GETMASTERSEQID", new object[] { "SEQ_MASTER" }).ToString();
                return sSeqNo;
            }
            catch (Exception ex)
            {
                ShowException(ex);
                return null;
            }
        }

        public bool UpdateSynchDataSet(DataSet ds)
        {
            return Convert.ToBoolean(this.ExecFunction("COM_UPDATESYNCHDATASET", new object[] { ds }));
        }

        public DataSet GetSynchDataSet(string TableName, string KeyFieldName, string[] ignoreFields, string sLimit)
        {
            return this.GetDataSetFunction("COM_GETSYNCHDATASET", new object[] { TableName, sLimit });
        }

        #endregion

        #region 平台直接支持的函数: Login

        public LogixResult Login(string user_code, string password)
        {
            UserInformation newUserInfo;

            m_CurrentUserInformation.UserCode = user_code;
            m_CurrentUserInformation.UserPassword = password;

            try
            {
                try
                {
                    if (!m_wsConnector.TestConnection())
                    {
                        return LogixResult.ConnectionFailure;
                    }
                }
                catch (Exception ex)
                {
                    return LogixResult.ConnectionFailure;
                }

                try
                {
                    newUserInfo = this.m_wsConnector.Login(user_code, password);
                    if (newUserInfo == null)
                    {
                        return LogixResult.AuthenticationFailure;
                    }
                }
                catch (Exception ex)
                {
                    return LogixResult.AuthenticationFailure;
                }
            }
            catch (Exception ex)
            {
                return HandleException(ex);
            }

            //更新当前的用户信息
            UpdateUserInfo(newUserInfo);

            // 记录登陆日志
            WriteLog(m_CurrentUserInformation.AppName, "LOGIN", "", "", "");

            return LogixResult.Success;

        }

        private void UpdateUserInfo(UserInformation newUserInfo)
        {
            m_CurrentUserInformation.UserCode = newUserInfo.UserCode;
            m_CurrentUserInformation.UserFullName = newUserInfo.UserFullName;
            m_CurrentUserInformation.OfficeCode = newUserInfo.OfficeCode;
            m_CurrentUserInformation.UserEmail = newUserInfo.UserEmail;
            m_CurrentUserInformation.SubOfficeCode = newUserInfo.SubOfficeCode;
            m_CurrentUserInformation.OfficeAndSubOffice = newUserInfo.OfficeAndSubOffice;
            m_CurrentUserInformation.LocalCurrency = newUserInfo.LocalCurrency;
            m_CurrentUserInformation.OfficeName = newUserInfo.OfficeName;
            m_CurrentUserInformation.AppName = newUserInfo.AppName;
            m_CurrentUserInformation.BuildNo = newUserInfo.BuildNo;
            m_CurrentUserInformation.LicenseTo = newUserInfo.LicenseTo;
            m_CurrentUserInformation.SupportURL = newUserInfo.SupportURL;
            m_CurrentUserInformation.VersionNo = newUserInfo.VersionNo;
            m_CurrentUserInformation.LicenseDate = newUserInfo.LicenseDate;
            m_CurrentUserInformation.OriginalName = newUserInfo.OriginalName;
        }

        private LogixResult GetAuthorizationTicket()
        {
            try
            {
                this.m_Ticket = this.m_wsConnector.GetAuthorizationTicket(m_CurrentUserInformation.UserCode, m_CurrentUserInformation.UserPassword);
            }
            catch (Exception ex)
            {
                LogixResult GetAuthorizationTicket = this.HandleException(ex);
                return GetAuthorizationTicket;
            }
            if (this.m_Ticket == null)
            {
                return LogixResult.AuthenticationFailure;
            }
            return LogixResult.Success;
        }

        public bool ChangePassword(string sUserCode, string sOldPassword, string sNewPassword)
        {
            bool bResult = this.m_wsConnector.ChangePassword(sUserCode, sOldPassword, sNewPassword);
            if (bResult)
            {
                this.WriteLog(m_CurrentUserInformation.AppName, "CHG_PWD", "User", sUserCode, "");
            }
            return bResult;
        }

        public void GetConnectionString()
        {
            m_ConnectionString = this.m_wsConnector.GetConnectionString();
        }

        #endregion

        #region GetReportTemplate

        public DataSet GetReportTemplate()
        {

            ReportLoadForm rlForm = ReportLoadForm.GetInstance();
            rlForm.StartPosition = FormStartPosition.CenterScreen;
            rlForm.LoadReport();
            rlForm.ShowDialog();
            return null;
        }

        #endregion

        #region Office功能

        #region Intranet Message

        public DataSet NewMessage(string RefType, string RefNo)
        {
            return this.GetDataSet("PlatformLogix", "Message", "NewData", new object[] { m_CurrentUserInformation.UserCode, 0, RefType, RefNo, "" });
        }

        public void NewMessageAndPopup(string MessageReceiver, string RefType, string RefNo, string MessageType, string MessageContent)
        {
            //MessageEditForm frm = new MessageEditForm("");
            MessageEditForm frm = new MessageEditForm();
            frm.MessageReceiver = MessageReceiver;
            frm.RefNo = RefNo;
            frm.RefType = RefType;
            if (MessageType.ToString() != "")
            {
                frm.MessageType = MessageType;
            }
            frm.MessageText = MessageContent;
            frm.ShowDialog();
            frm.Dispose();
        }

        public bool AutoMessage(string RefType, string RefNo, string Receiver, string message_text)
        {
            return Convert.ToBoolean(this.m_wsConnector.ExecFunction(PLATFORM_LOGIX, "Message", "AutoMessage", new object[] { m_CurrentUserInformation.UserCode, RefType, RefNo, Receiver, message_text }));
        }

        public bool SaveMessage(DataSet ds)
        {
            object[] args = new object[] { Compression.CompressionDataSet(ds) };
            return Convert.ToBoolean(this.m_wsConnector.ExecFunctionByDataSet(PLATFORM_LOGIX, "Message", "SaveData", args));
        }

        public int GetMyMessageCount()
        {
            return Convert.ToInt32(this.m_wsConnector.ExecFunction(PLATFORM_LOGIX, "Message", "GetRcvMessageCount", new object[] { m_CurrentUserInformation.UserCode }));
        }

        public DataSet GetMessage(string MessageID)
        {
            return this.GetDataSet(PLATFORM_LOGIX, "Message", "GetMessage", new object[] { MessageID });
        }

        public DataSet ShowMyMessageList(int bStatus)
        {
            return this.GetDataSet(PLATFORM_LOGIX, "Message", "GetRcvMessageList", new object[] { m_CurrentUserInformation.UserCode, bStatus });
        }

        public bool DeleteMessage(string UserCode, string MessageID, bool bSender)
        {
            return Convert.ToBoolean(this.m_wsConnector.ExecFunction(PLATFORM_LOGIX, "Message", "DeleteMessage", new object[] { UserCode, MessageID, bSender }));
        }

        public bool MarkMessageRead(string UserCode, string MessageID)
        {
            return Convert.ToBoolean(this.m_wsConnector.ExecFunction(PLATFORM_LOGIX, "Message", "MarkMessageRead", new object[] { UserCode, MessageID }));
        }

        #endregion

        #region Calendar and Task List

        public DataSet NewEventData(string UserCode)
        {
            return this.GetDataSet(PLATFORM_LOGIX, "Calendar", "NewData", new object[] { UserCode });
        }

        public DataSet GetEventList(DateTime DateFrom, DateTime DateTo, string UserCode)
        {
            return this.GetDataSet(PLATFORM_LOGIX, "Calendar", "GetEventList", new object[] { DateFrom, DateTo, UserCode });
        }

        public DataSet GetEventData(string EventID)
        {
            return this.GetDataSet(PLATFORM_LOGIX, "Calendar", "GetData", new object[] { EventID });
        }

        public bool SaveEventData(DataSet ds)
        {
            object[] args = new object[] { Compression.CompressionDataSet(ds) };
            return Convert.ToBoolean(this.m_wsConnector.ExecFunctionByDataSet(PLATFORM_LOGIX, "Calendar", "SaveData", args));
        }

        public bool DeleteEvent(string EventID)
        {
            return Convert.ToBoolean(this.m_wsConnector.ExecFunction(PLATFORM_LOGIX, "Calendar", "DeleteEvent", new object[] { EventID }));
        }

        public DataSet GetTaskList(string UserCode, string Status)
        {
            return this.GetDataSet(PLATFORM_LOGIX, "Calendar", "GetTaskList", new object[] { UserCode, Status });
        }

        public DataSet NewTaskData(string UserCode)
        {
            return this.GetDataSet(PLATFORM_LOGIX, "Calendar", "NewTask", new object[] { UserCode });
        }

        public DataSet GetTaskData(string TaskID)
        {
            return this.GetDataSet(PLATFORM_LOGIX, "Calendar", "GetTask", new object[] { TaskID });
        }

        public bool SaveTaskData(DataSet ds)
        {
            object[] args = new object[] { Compression.CompressionDataSet(ds) };
            return Convert.ToBoolean(this.m_wsConnector.ExecFunctionByDataSet(PLATFORM_LOGIX, "Calendar", "SaveTask", args));
        }

        public bool DeleteTask(string TaskID)
        {
            return Convert.ToBoolean(this.m_wsConnector.ExecFunction(PLATFORM_LOGIX, "Calendar", "DeleteTask", new object[] { TaskID }));
        }

        #endregion

        #region e-Learning

        public DataSet GetDocumentList(string TreeID)
        {
            return this.GetDataSet(PLATFORM_LOGIX, "eLearning", "GetDocumentList", new object[] { TreeID });
        }

        public DataSet GetDocumentHead(string DocID)
        {
            return this.GetDataSet(PLATFORM_LOGIX, "eLearning", "GetDocumentHead", new object[] { DocID });
        }

        public DataSet GetDocumentBody(string DocID)
        {
            return this.GetDataSet(PLATFORM_LOGIX, "eLearning", "GetDocumentBody", new object[] { DocID });
        }


        public DataSet NewDocumentData(string UserCode, string TreeID)
        {
            return this.GetDataSet(PLATFORM_LOGIX, "eLearning", "NewDocumentData", new object[] { UserCode, TreeID });
        }

        public bool SaveDocumentData(DataSet ds)
        {
            object[] args = new object[] { Compression.CompressionDataSet(ds) };
            return Convert.ToBoolean(this.m_wsConnector.ExecFunctionByDataSet(PLATFORM_LOGIX, "eLearning", "SaveDocumentData", args));
        }

        public bool DeleteDocumentData(string DocID)
        {
            return true;
        }

        public DataSet GetDocTypeList(string UserCode)
        {
            return this.GetDataSet(PLATFORM_LOGIX, "eLearning", "GetDocTypeList", new object[] { UserCode });
        }

        public DataSet NewDocTypeData(string UserCode, string ParentTreeID)
        {
            return this.GetDataSet(PLATFORM_LOGIX, "eLearning", "NewDocTypeData", new object[] { UserCode, ParentTreeID });
        }

        public DataSet GetRocTypeData(string TreeID)
        {
            return this.GetDataSet(PLATFORM_LOGIX, "eLearning", "GetRocTypeData", new object[] { TreeID });
        }

        public bool SaveDocTypeData(DataSet ds)
        {
            object[] args = new object[] { Compression.CompressionDataSet(ds) };
            return Convert.ToBoolean(this.m_wsConnector.ExecFunctionByDataSet(PLATFORM_LOGIX, "eLearning", "SaveDocTypeData", args));
        }

        public bool DeleteDocTypeData(string TreeID)
        {
            return Convert.ToBoolean(this.m_wsConnector.ExecFunction(PLATFORM_LOGIX, "eLearning", "DeleteDocTypeData", new object[] { TreeID }));
        }

        #endregion

        #endregion

        #region Common Forms

        public string GetMultiNumber()
        {
            string sMultiNumber = "";
            MultiNumberForm frm = new MultiNumberForm();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                sMultiNumber = frm.MultiNumberString;
            }
            return sMultiNumber;
        }

        public string GetGoToNumber(string LabelCaption)
        {
            string sNo = "";
            GoToForm frm = new GoToForm();
            frm.ShipmentType = LabelCaption;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                sNo = frm.ShipmentNo;
            }
            return sNo;
        }

        #endregion

        #region 用户和公司架构信息

        public DataSet GetUserList(string keyword)
        {
            string strLimit = "USER_CODE LIKE '%" + keyword.Replace("'", "''") + "%' OR USER_FULLNAME LIKE '%" + keyword.Replace("'", "''") + "%'";
            return this.GetDataSet(PLATFORM_LOGIX, "User", "GetUserList", new object[] { strLimit });
        }

        public DataSet GetUserList(string OfficeCode, string DeptCode)
        {
            string strLimit;
            if ((OfficeCode.ToString() == "") & (DeptCode.ToString() == ""))
            {
                strLimit = " 1 = 1 ";
            }
            else if (DeptCode.ToString() != "")
            {
                strLimit = " COMPANY_CODE = '" + OfficeCode.ToString().Replace("'", "''") + "' and DEPARTMENT_CODE = '" + DeptCode.ToString().Replace("'", "''") + "'";
            }
            else
            {
                strLimit = " COMPANY_CODE = '" + OfficeCode.ToString().Replace("'", "''") + "' ";
            }
            return this.GetDataSet(PLATFORM_LOGIX, "User", "GetUserList", new object[] { strLimit });
        }

        public string GetMyTeamLeader(string UserCode)
        {
            return Convert.ToString(this.m_wsConnector.ExecFunction(PLATFORM_LOGIX, "User", "GetMyTeamLeader", new object[Conversions.ToInteger(UserCode) + 1]));
        }

        public string GetMyDeptManager(string UserCode)
        {
            return Convert.ToString(this.m_wsConnector.ExecFunction(PLATFORM_LOGIX, "User", "GetMyDeptManager", new object[Conversions.ToInteger(UserCode) + 1]));
        }

        #endregion

        #region 发邮件功能

        public bool OpenEmail(string EmailAddress, string Subject, string[] Body, string cc, string att)
        {
            string bodyText=string.Empty;
            bool bAns = true;
            string sParams = EmailAddress;
            if (sParams.Trim() != "")
            {
                if ((sParams.Substring(1, 7)).ToLower() != "mailto:")
                {
                    sParams = "mailto:" + sParams;
                }
            }
            else
            {
                sParams = "mailto:";
            }
            if (Subject != "")
            {
                sParams = sParams + "?subject=" + Subject;
            }
            if (Body.Length != 0)
            {
                for (int index = 0; index <= Body.Length - 1; index++)
                {
                    bodyText = bodyText + Body[index] + "%0a%0d";
                }
            }
            else
            {
                bodyText = string.Empty;
            }
            if (bodyText != "")
            {
                sParams = sParams + Subject == "" ? "?" : "&";
                sParams = sParams + "body=" + bodyText;
            }
            if (cc != "")
            {
                sParams = sParams + "&cc=" + cc;
            }
            if (att != "")
            {
                sParams = sParams + "&attach=@" + att;
            }
            Process myProcess = new Process();
            myProcess.StartInfo.FileName = sParams;
            myProcess.StartInfo.UseShellExecute = true;
            myProcess.StartInfo.RedirectStandardOutput = false;
            try
            {
                myProcess.Start();
            }
            catch (Exception)
            {

                bAns = false;

            }
            return bAns;
        }

        #endregion

        #region AutoUpdate

        public string GetCurrentVersion()
        {
            return this.m_wsConnector.GetCurrentVersion();
        }

        public DataSet GetUpdateFileList(string VersionNo)
        {
            return this.m_wsConnector.GetUpdateFileList(VersionNo);
        }

        public object GetUpdateSinigleFile(string FileID)
        {
            return this.m_wsConnector.GetUpdateSingleFile(FileID);
        }
 
        #endregion

        #region Privilege

        public string GetGroupUsersByUserCode(string user_code)
        {
            string command = UIProxy.m_CurrentCommandCode;
            string strsql = string.Empty;
            strsql = "SELECT ROLE2P.USER_GROUP_CODES                   ";
            strsql += "  FROM                                           ";
            strsql += "  D_ROLE2PRIVILEGE ROLE2P,                       ";
            strsql += "  D_USER2GROUP USER2G,                           ";
            strsql += "  D_USER2ROLE USER2ROLE                          ";
            strsql += " WHERE ROLE2P.ROLE_CODE = USER2ROLE.ROLE_CODE    ";
            strsql += "   AND USER2G.USER_CODE = USER2ROLE.USER_CODE    ";
            strsql += "   AND USER2ROLE.USER_CODE = '" + user_code + "'";
            strsql += "   AND SUBSTR(ROLE2P.PRIVILEGE_ID, 0, 4) = '" + command + "'";
            strsql += "   AND ROLE2P.USER_GROUP_CODES IS NOT NULL       ";
            strsql += "   AND ROLE2P.DATA_OWNER_LEVEL=1                 ";
            strsql += "   AND ROWNUM = 1                                ";

            string groups = this.GetSingleValBySQL(strsql);
            if (groups == "")
            {
                strsql = "SELECT DISTINCT USER_CODE  " +
                    "  FROM D_USER2GROUP " +
                    " WHERE USER_GROUP_CODE  " +
                    "    IN (SELECT USER_GROUP_CODE FROM D_USER2GROUP WHERE USER_CODE = '" + user_code + "') ";
            }
            else
            {
                string[] group_array = groups.Split(new char[] { ',' });
                string user_group_code = string.Empty;
                foreach (string user in group_array)
                {
                    user_group_code = user_group_code + "'" + user + "',";
                }
                strsql = "SELECT DISTINCT USER_CODE  " +
                             "  FROM D_USER2GROUP " +
                             " WHERE USER_GROUP_CODE  " +
                             "    IN (" + user_group_code.TrimEnd(',') + ") ";
            }

            return strsql;

        }

        public void LoadPrivileges()
        {

            DataSet ds = this.m_wsConnector.LoadPrivileges(m_CurrentUserInformation.UserCode);

            if (m_Privileges == null)
            {
                m_Privileges = new ArrayList();
            }

            m_Privileges.Clear();

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                if (dr["PRIVI_SELF"].ToString().Equals("1"))
                {
                    m_Privileges.Add(dr["PRIVILEGE_ID"].ToString());
                }
                if (dr["PRIVI_GROUP"].ToString() == "1")
                {
                    m_Privileges.Add(dr["PRIVILEGE_ID"].ToString() + ".G");
                }
            }

            m_GroupUsers = this.GetGroupUsersByUserCode(m_CurrentUserInformation.UserCode);
            userList.Remove(0, userList.Length);
            if (ds.Tables[1].Rows.Count >= 800)
            {
                int j = 0;
                int i = 0;
                foreach (DataRow drUser in ds.Tables[1].Rows)
                {
                    if ((j == 800) & ((i * 800) != ds.Tables[1].Rows.Count))
                    {
                        userList.Append(") or {0} in ('" + drUser["USER_CODE"].ToString().Replace("'", "''") + "',");
                        i++;
                        j = 0;
                    }
                    else
                    {
                        if (j == 0x31f)
                        {
                            userList.Append("'" + drUser["USER_CODE"].ToString().Replace("'", "''") + "'");
                        }
                        else
                        {
                            userList.Append("'" + drUser["USER_CODE"].ToString().Replace("'", "''") + "',");
                        }
                    }
                    j++;
                }
            }
            else
            {

                foreach (DataRow drUser in ds.Tables[1].Rows)
                {

                    if (userList.Length == 0)
                    {
                        userList.Append("'" + drUser["USER_CODE"].ToString().Replace("'", "''") + "'");
                    }
                    else
                    {
                        userList.Append(",'" + drUser["USER_CODE"].ToString().Replace("'", "''") + "'");
                    }
                }

            }

            foreach (DataRow drUser in ds.Tables[1].Rows)
            {

                if (m_UserList.Trim() == "")
                {
                    m_UserList = "'" + drUser["USER_CODE"].ToString().Replace("'", "''") + "'";
                }
                else
                {
                    m_UserList = m_UserList + ",'" + drUser["USER_CODE"].ToString().Replace("'", "''") + "'";
                }
            }

            ds.Dispose();
        }

        public void SetPriviledgeByCommand(string user_code)
        {
            string command = UIProxy.m_CurrentCommandCode;
            string strsql = string.Empty;
            strsql = "SELECT ROLE2P.USER_GROUP_CODES                   ";
            strsql += "  FROM                                           ";
            strsql += "  D_ROLE2PRIVILEGE ROLE2P,                       ";
            strsql += "  D_USER2GROUP USER2G,                           ";
            strsql += "  D_USER2ROLE USER2ROLE                          ";
            strsql += " WHERE ROLE2P.ROLE_CODE = USER2ROLE.ROLE_CODE    ";
            strsql += "   AND USER2G.USER_CODE = USER2ROLE.USER_CODE    ";
            strsql += "   AND USER2ROLE.USER_CODE = '" + user_code + "'";
            strsql += "   AND SUBSTR(ROLE2P.PRIVILEGE_ID, 0, 4) = '" + command + "'";
            strsql += "   AND ROLE2P.USER_GROUP_CODES IS NOT NULL       ";
            strsql += "   AND ROLE2P.DATA_OWNER_LEVEL=1                 ";
            strsql += "   AND ROWNUM = 1                                ";

            string groups = this.GetSingleValBySQL(strsql);

            if (!string.IsNullOrEmpty(groups))
            {
                string[] group_array = groups.Split(new char[] { ',' });
                string user_group_code = string.Empty;

                foreach (string user in group_array)
                {
                    user_group_code = user_group_code + "'" + user + "',";
                }

                strsql = "SELECT DISTINCT USER_CODE  " +
                       "  FROM D_USER2GROUP " +
                       " WHERE USER_GROUP_CODE  " +
                       "    IN (" + user_group_code.TrimEnd(',') + ") ";

                DataSet ds = this.GetDataSetByFunctionName("COM_ROLE_SAVEDATA", "GetUserCodeByGroup", new object[] { strsql });
                userList.Remove(0, userList.Length);
                if (ds.Tables[0].Rows.Count >= 800)
                {
                    int j = 0;
                    int i = 0;

                    foreach (DataRow drUser in ds.Tables[0].Rows)
                    {
                        if (j == 800 && i * 800 != ds.Tables[0].Rows.Count)
                        {
                            userList.Append(") or {0} in ('" + drUser["USER_CODE"].ToString().Replace("'", "''") + "',");
                            i++;
                            j = 0;
                        }
                        else
                        {
                            if (j == 0x31f)
                            {
                                userList.Append("'" + drUser["USER_CODE"].ToString().Replace("'", "''") + "'");
                            }
                            else
                            {
                                userList.Append("'" + drUser["USER_CODE"].ToString().Replace("'", "''") + "',");
                            }
                            j++;
                        }
                    }
                }
                else
                {
                    foreach (DataRow drUser in ds.Tables[0].Rows)
                    {
                        if (userList.Length == 0)
                        {
                            userList.Append("'" + drUser["USER_CODE"].ToString().Replace("'", "''"));
                        }
                        else
                        {
                            userList.Append(",'" + drUser["USER_CODE"].ToString().Replace("'", "''") + "'");
                        }
                    }
                }

                foreach (DataRow drUser in ds.Tables[1].Rows)
                {
                    if (m_UserList.Trim() == "")
                    {
                        m_UserList = "'" + drUser["USER_CODE"].ToString().Replace("'", "''") + "'";
                    }
                    else
                    {
                        m_UserList = m_UserList + ",'" + drUser["USER_CODE"].ToString().Replace("'", "''") + "'";
                    }
                }

            }
            else
            {
                this.LoadPrivileges();
            }
        }

        public bool CheckPrivilege(string PrivilegeID)
        {
            if (m_Privileges.IndexOf(PrivilegeID) == -1)
            {
                return false;
            }
            return true;
        }

        public string GenPrivilegeClause(string PrivilegeID, string sField)
        {
            string s = "";
            if (PrivilegeID == "")
            {
                return "";
            }
            if (this.CheckPrivilege(PrivilegeID))
            {
                s = sField + " = '" + m_CurrentUserInformation.UserCode + "'";
            }
            if (this.CheckPrivilege(PrivilegeID + ".G") & (userList.Length != 0))
            {
                s = sField + " IN ( " + string.Format(userList.ToString().TrimEnd(new char[] { ',' }), sField) + " )";
            }
            if (s != "")
            {
                s = " AND  ( " + s + " OR " + sField + "='' OR " + sField + " IS NULL) ";
            }
            else
            {
                s = " AND  ( 1 = 0 ) ";
            }
            return s;
        }

        public string GenPrivilegeClause(string PrivilegeID, string sField, bool isSql)
        {
            string s = "";
            if (PrivilegeID == "")
            {
                return "";
            }
            if (this.CheckPrivilege(PrivilegeID))
            {
                s = sField + " = '" + m_CurrentUserInformation.UserCode + "'";
            }
            if (this.CheckPrivilege(PrivilegeID + ".G") & (userList.Length != 0))
            {
                s = sField + " IN ( " + m_GroupUsers + " )";
            }
            if (s != "")
            {
                s = " AND  ( " + s + " OR " + sField + "='' OR " + sField + " IS NULL) ";
            }
            else
            {
                s = " AND  ( 1 = 0 ) ";
            }
            return s;
        }

        public string GenPrivilegeClause(string PrivilegeID, string[] sField)
        {
            string s = "";
            string sResult = "";
            if (PrivilegeID == "")
            {
                return "";
            }
            for (int i = 0; i <= sField.Length; i++)
            {
                if (this.CheckPrivilege(PrivilegeID))
                {
                    s = sField[i] + " = '" + m_CurrentUserInformation.UserCode + "'";
                }
                if (this.CheckPrivilege(PrivilegeID + ".G") & (userList.Length != 0))
                {
                    s = sField[i] + " IN ( " + string.Format(userList.ToString().TrimEnd(new char[] { ',' }), sField[i]) + " )";
                }
                if (s != "")
                {
                    s = " ( " + s + " OR " + sField[i] + "='' OR " + sField[i] + " IS NULL) ";
                }
                else
                {
                    s = " ( 1 = 0 ) ";
                }
                if (sResult != "")
                {
                    sResult = sResult + " OR " + s;
                }
                else
                {
                    sResult = s;
                }
            }
            return (" AND (" + sResult + ")");
        }

        public string GenPrivilegeClause(string PrivilegeID, string[] sField, bool isSQL)
        {
            string s = "";
            string sResult = "";
            if (PrivilegeID == "")
            {
                return "";
            }
            for (int i = 0; i <= sField.Length; i++)
            {
                if (this.CheckPrivilege(PrivilegeID))
                {
                    s = sField[i] + " = '" + m_CurrentUserInformation.UserCode + "'";
                }
                if (this.CheckPrivilege(PrivilegeID + ".G") & (userList.Length != 0))
                {
                    s = sField[i] + " IN ( " + m_GroupUsers + " )";
                }
                if (s != "")
                {
                    s = " ( " + s + " OR " + sField[i] + "='' OR " + sField[i] + " IS NULL) ";
                }
                else
                {
                    s = " ( 1 = 0 ) ";
                }
                if (sResult != "")
                {
                    sResult = sResult + " OR " + s;
                }
                else
                {
                    sResult = s;
                }
            }
            return (" AND (" + sResult + ")");
        }

        public bool HavePrivilegeByDataOwner(string PrivilegeID, string sDataOwner)
        {
            if (CheckPrivilege(PrivilegeID + ALL_PRIVILEGE_SUFFIX))
            {
                return true;
            }

            if (CheckPrivilege(PrivilegeID + GROUP_PRIVILEGE_SUFFIX) && (m_UserList.ToUpper().IndexOf(sDataOwner.ToUpper().Replace("'", "''")) >= 0))
            {
                return true;
            }

            if (sDataOwner == null)
            {
                return true;
            }

            if (CheckPrivilege(PrivilegeID))
            {
                if ((m_CurrentUserInformation.UserCode.ToUpper() == sDataOwner) || (sDataOwner.ToString() == ""))
                {
                    return true;
                }
            }
            return false;
        }

        public bool HavePrivilegeByDataOwner(string PrivilegeID, string[] sDataOwner)
        {

            if (CheckPrivilege(PrivilegeID + ALL_PRIVILEGE_SUFFIX))
            {
                return true;
            }

            if (sDataOwner == null)
            {
                return true;
            }

            for (int i = 0; i < sDataOwner.Length; i++)
            {
                if ((CheckPrivilege(PrivilegeID + GROUP_PRIVILEGE_SUFFIX) && m_UserList.ToUpper().IndexOf(sDataOwner[i].ToUpper().Replace("'", "''")) >= 0))
                {
                    return true;
                }

                if (CheckPrivilege(PrivilegeID))
                {
                    if ((m_CurrentUserInformation.UserCode.ToUpper() == sDataOwner[i]) || (sDataOwner.ToString() == ""))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        #endregion

        #region Logs

        public DataSet LoadLogs(string sLimit)
        {
            return this.m_wsConnector.LoadLogs(sLimit);
        }

        public bool DeleteLogs(string id)
        {
            return this.m_wsConnector.DeleteLogs(id);
        }

        public bool WriteLog(string ModuleCode, string EventCode, string DataType, string RefNo, string Remark)
        {
            LogInformation log = new LogInformation();
            log.ModuleCode = ModuleCode;
            log.EventCode = EventCode;
            log.UserCode = m_CurrentUserInformation.UserCode;
            log.CompanyCode = m_CurrentUserInformation.OfficeCode;
            log.DataType = DataType;
            log.RefNo = RefNo;
            log.Remark = Remark;
            return this.WriteLogInternal(log);
        }

        private bool WriteLogInternal(LogInformation Log)
        {
            return this.m_wsConnector.WriteLog(Log);
        }

        #endregion

        #region License
        #endregion

        #region Command Desc

        public DataSet GetDescByCommandCode(string commandCode)
        {
            return this.m_wsConnector.GetDescByCommandCode(commandCode);
        }

        #endregion

        #region GetSqlFromTo

        public static string GetSqlFromTo(string fieldName, DateTime dateFrom, DateTime dateTo)
        {
            return OracleSqlHelper.GetSqlFromTo(fieldName, dateFrom, dateTo);
        }

        public static string GetSqlFromTo(string fieldName, DateTime dateFrom)
        {
            return OracleSqlHelper.GetSqlFromTo(fieldName, dateFrom);
        }

        public static string GetSqlFromTo(string fieldName, RadDateTimePicker dateFrom, RadDateTimePicker dateTo)
        {
            return OracleSqlHelper.GetSqlFromTo(fieldName, dateFrom, dateTo);
        }

        public static string GetSqlFromTo(string fieldName, RadDateTimePicker dateFrom)
        {
            return OracleSqlHelper.GetSqlFromTo(fieldName, dateFrom);
        }

        public static string GetSqlFromTo(string fieldName, string valueFrom, string valueTo, bool isBlurry)
        {
            return OracleSqlHelper.GetSqlFromTo(fieldName, valueFrom, valueTo, isBlurry);
        }

        public static string GetSqlFromTo(string fieldName, string valueFrom, string valueTo)
        {
            return OracleSqlHelper.GetSqlFromTo(fieldName, valueFrom, valueTo, true);
        }

        public static string GetSqlFromTo(string fieldName, string valueFrom)
        {
            return OracleSqlHelper.GetSqlFromTo(fieldName, valueFrom, "", true);
        }

        #endregion

        #region ServicePortal

        private static readonly EnvironmentSetting localSet = new EnvironmentSetting(GetCurrentUserFolder() + @"\LocalSetting.Xml");
        private static string url;

        public static void SetServicePortalAddress(string bCode)
        {
            url = GetLSCUrl(bCode);
            if (url.Trim() != "")
            {
                CurrentCAService.Url = url + "ws/CertificateService.asmx";
            }
            else
            {
                CurrentCAService.Url = "http://www.cargob2b.com/ServicePortal/ws/CertificateService.asmx";
            }
            if (url.Trim() != "")
            {
                CurrentBSService.Url = url + "ws/BusinessService.asmx";
            }
            else
            {
                CurrentBSService.Url = "http://www.cargob2b.com/ServicePortal/ws/BusinessService.asmx";
            }
        }

        public static ServicePortalInfo CurrentServiceProtalPara;

        public struct ServicePortalInfo
        {
            public string LSCUrl;
            public string BCode;
            public string UserCode;
        }

        public class ServicePortalEventArgs : EventArgs
        {
            // Fields
            public UIProxy.ServicePortalInfo ServicePortalInfo;

            // Methods
            public ServicePortalEventArgs();
        }

        public enum ServicePortalStatus
        {
            UnLogin = 0,
            Login = 1
        }

        public static event ServicePortalHandler ServicePortalLogin;
        public delegate void ServicePortalHandler(object sender, UIProxy.ServicePortalEventArgs value);
        public static object CurrentServicePortalStatus = ServicePortalStatus.UnLogin;
        public static string CurrentServiceQSKey;
        private static ServicePortalHandler ServicePortalLoginEvent;


        public static void LoginServicePortal(string bCode, string userCode, string pwd)
        {
            if (bCode.ToUpper().Equals("GM"))
            {
                CurrentCAServiceGM.Login(bCode, userCode, pwd);
                CurrentServiceQSKey = "0077";
            }
            else
            {
                CurrentCAService.Login(bCode, userCode, pwd);
                CurrentServiceQSKey = _BusinessService.GetQueryStringKey();
            }
            CurrentServiceProtalPara.LSCUrl = url;
            CurrentServiceProtalPara.BCode = bCode;
            CurrentServiceProtalPara.UserCode = userCode;
            ServicePortalEventArgs arg = new ServicePortalEventArgs();
            arg.ServicePortalInfo = CurrentServiceProtalPara;
            CurrentServicePortalStatus = ServicePortalStatus.Login;
            ServicePortalHandler ServicePortalLogin = ServicePortalLoginEvent;
            if (ServicePortalLogin != null)
            {
                ServicePortalLogin("Login", arg);
            }
        }


        private static JKR.GUI.LogixConnector.BusinessService.BusinessService _BusinessService;
        private static JKR.GUI.LogixConnector.CertificateService.CertificateService _CertificateService;
        private static CookieContainer _CookieContainer;
        private static BusinessService _BusinessServiceGM;
        private static CertificateService _CertificateServiceGM;

        public static CertificateService.CertificateService CurrentCAService
        {
            get
            {
                if (_CertificateService == null)
                {
                    _CertificateService = new CertificateService.CertificateService();
                    _CertificateService.CookieContainer = _CookieContainer;
                }
                return _CertificateService;
            }
        }


        public static CertificateService CurrentCAServiceGM
        {
            get
            {
                if (_CertificateServiceGM == null)
                {
                    _CertificateServiceGM = new CertificateService();
                    _CertificateServiceGM.CookieContainer = _CookieContainer;
                }
                return _CertificateServiceGM;
            }
        }

        public static BusinessService.BusinessService CurrentBSService
        {
            get
            {
                if (_BusinessService == null)
                {
                    _BusinessService = new BusinessService.BusinessService();
                    _BusinessService.CookieContainer = _CookieContainer;
                }
                return _BusinessService;
            }
        }

        public static BusinessService CurrentBSServiceGM
        {
            get
            {
                if (_BusinessServiceGM == null)
                {
                    _BusinessServiceGM = new BusinessService();
                    _BusinessServiceGM.CookieContainer = _CookieContainer;
                }
                return _BusinessServiceGM;
            }
        }

        private static string GetLSCUrl(string bCode)
        {
            string GetLSCUrl;
            CertificateService b2bCA = new CertificateService();
            string url = localSet.Read("ServicePortal", "Url", "");
            if (url == string.Empty)
            {
                b2bCA.Url = "http://www.cargob2b.com/cargob2b/ws/CertificateService.asmx";
            }
            else
            {
                b2bCA.Url = url + "/ws/CertificateService.asmx";
                if (bCode.ToUpper().Equals("GM"))
                {
                    CurrentCAServiceGM.Url = url + "/ws/CertificateService.asmx";
                    CurrentBSServiceGM.Url = url + "/ws/BusinessService.asmx";
                    return url;
                }
            }
            try
            {
                GetLSCUrl = b2bCA.GetServicePortalURL(bCode);
            }
            catch (System.Web.Services.Protocols.SoapException ex)
            {
                return string.Empty;
            }
            return GetLSCUrl;
        }

        public static string getExtensionCustomUrl()
        {
            return _m_ExtensionCustomWSUrl;
        }

        public static string Encrypt3DES(string a_strString)
        {
            string a_strKey = CurrentBSService.GetQueryStringKey();
            Encoding encoding = Encoding.Unicode;
            TripleDESCryptoServiceProvider provider1 = new TripleDESCryptoServiceProvider();
            provider1.Key = new MD5CryptoServiceProvider().ComputeHash(encoding.GetBytes(a_strKey));
            provider1.Mode = CipherMode.ECB;
            ICryptoTransform transform1 = provider1.CreateEncryptor();
            byte[] buffer1 = encoding.GetBytes(a_strString);
            return Convert.ToBase64String(transform1.TransformFinalBlock(buffer1, 0, buffer1.Length));
        }

        #endregion

        #region 得到检索数据条数

        public string GetRecordCountByDataSet(DataTable dt)
        {
            if (dt == null)
            {
                return string.Empty;
            }
            string str = string.Empty;
            if (Language == LanguageType.Chinese)
            {
                str = "共检索到数据 " + Convert.ToString(dt.Rows.Count) + " 条";
            }
            else
            {
                str = "Search Data " + Convert.ToString(dt.Rows.Count) + " rows";
            }
            return str;
        }

        #endregion

        #region getRowNum

        public string GetInitRowNum(RadTextBox ctr, bool isSearch)
        {
            if (ctr == null)
            {
                return localSet.Read("RowNum", "R" + m_CurrentCommandCode, "500");
            }
            if (isSearch)
            {
                if (ctr.Text == string.Empty)
                {
                    ctr.Text = localSet.Read("RowNum", "R" + m_CurrentCommandCode, "500");
                    return ctr.Text;
                }

                if (IsNum(ctr.Text))
                {
                    ctr.Text = localSet.Read("RowNum", "R" + m_CurrentCommandCode, "500");
                }
                return ctr.Text;
            }
            ctr.Text = localSet.Read("RowNum", "R" + m_CurrentCommandCode, "500");
            return ctr.Text;
        }

        /// <summary>
        /// 新增代替VB中IsNumeric方法     
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsNum(String str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (!Char.IsNumber(str, i))
                    return false;
            }
            return true;
        }

        #endregion

        #region eFile

        //private static FileService _eFileService;

        //private static string m_eFileUrl = "";

        //public static FileService CurrentEFileService
        //{
        //    get
        //    {
        //        if (_eFileService == null)
        //        {
        //            _eFileService = new FileService();
        //            _eFileService.Url = m_eFileUrl + "/FileService.asmx";
        //            _eFileService.CookieContainer = _CookieContainer;
        //        }
        //        return _eFileService;
        //    }
        //}


        //public static void SetEFileParams()
        //{
        //    m_eFileUrl = localSet.Read("eFile", "Url", "");
        //}

        //public static DataSet GetEFileType()
        //{
        //    return CurrentEFileService.GetAllFileType();
        //}

        //public static DataSet GetEFileAttribute(string typeId)
        //{
        //    return CurrentEFileService.GetAttributeByFileType(typeId);
        //}

        //public static bool UploadEFile(E_FILE_HEADEntity eFileEntity)
        //{
        //    bool UploadEFile;
        //    try
        //    {
        //        string a = StringUtil.ObjectToString(eFileEntity);
        //        CurrentEFileService.UploadFile(a);
        //        UploadEFile = true;
        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //    }
        //}

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
