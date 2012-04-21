using System;
using System.Data.Common;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;
using System.Data;
using System.Collections;
using PoliceMobile.CLS;


    public class ClsSqliteExecute
    {
        private SQLiteCommand dbObj = null;
        private string[] sColumnArray;
        private string sDataBaseName = "";

        /// <summary>
        /// 是否执行DREAM函数
        /// </summary>
        public Boolean isDreamStart = true;

        public ClsSqliteExecute()
        {
            SQLiteConnection conn = new SQLiteConnection(@"Data Source=" + ToolsHelper.sPath + "/DB/Address.db");
            dbObj = new SQLiteCommand(conn);
        }

        #region 执行语句
        /// <summary>
        /// 执行语句
        /// </summary>
        /// <param name="sSql"></param>
        public void DatExecuteQuery(string sSql)
        {
            try
            {
                dbObj.CommandText = sSql;
                dbObj.ExecuteNonQuery();
                dbObj.Parameters.Clear();
            }
            catch
            {

            }
        }
        #endregion

        #region 执行语句
        /// <summary>
        /// 执行语句
        /// </summary>
        /// <param name="sSql"></param>
        public void DatExecuteQueryEx(string sSql)
        {
            dbObj.CommandText = sSql;
            dbObj.ExecuteNonQuery();
        }
        #endregion

        #region 执行语句
        /// <summary>
        /// 执行语句
        /// </summary>
        /// <param name="sSql"></param>
        public DbDataReader DatExecuteReader(string sSql)
        {
            DbCommand dc = dbObj.Connection.CreateCommand();
            dc.CommandText = sSql;
            DbDataReader dTdr = dc.ExecuteReader();
            dc.Parameters.Clear();
            return dTdr;
        }
        #endregion

        #region 返回结果集数
        /// <summary>
        /// 返回结果集数
        /// </summary>
        /// <param name="sSql"></param>
        /// <returns></returns>
        public int getDataCount(string sSql)
        {
            DbDataReader dbdr = DatExecuteReader(sSql);
            int iCount = Convert.ToInt32(dbdr.GetValue(0));
            dbdr.Close();
            return iCount;
        }
        #endregion

        #region 创建数据库文件
        /// <summary>
        /// 创建数据库文件
        /// </summary>
        /// <param name="sTableName"></param>
        public void CreateDataTable(string sTableName)
        {
            string sSql = "create table [" + sTableName + "] ";
            string sColumns = "[ID] TEXT COLLATE NOCASE";

            for (int j = 0; j < sColumnArray.Length; j++)
            {
                sColumns += ",[" + sColumnArray[j] + "] TEXT COLLATE NOCASE ";
            }

            sColumns += ",[UpdateTime] TEXT COLLATE NOCASE,[State] TEXT COLLATE NOCASE";
            DatExecuteQuery(sSql + "(" + sColumns + ")");
        }
        #endregion

        #region 创建任务表
        /// <summary>
        /// 创建任务表
        /// </summary>
        protected void CreateTaskTable()
        {
            int iTableCount = getDataCount("select count(*) from sqlite_master where type='table' and name='ScanTable'");

            if (iTableCount == 1)
            {
                isDreamStart = false;
                return;
            }
            string sSql = "create table ScanTable ([id] TEXT COLLATE NOCASE, [Url] TEXT COLLATE NOCASE,[Parameter] TEXT COLLATE NOCASE,[Discription]  TEXT COLLATE NOCASE,[UpdateTime]  TEXT COLLATE NOCASE,[State]  TEXT COLLATE NOCASE);";
            DatExecuteQuery(sSql);
            isDreamStart = true;
        }
        #endregion

        /// <summary>
        /// 数据库关闭
        /// </summary>
        public void dbClose()
        {
            DbConnection dc = dbObj.Connection;
            dbObj.Dispose();
            dc.Close();
        }

        #region 返回DATATABLE
        /// <summary>   
        /// 执行一个查询语句，返回一个包含查询结果的DataTable   
        /// </summary>   
        /// <param name="sql">要执行的查询语句</param>   
        /// <param name="parameters">执行SQL查询语句所需要的参数，参数必须以它们在SQL语句中的顺序为准</param>   
        /// <returns></returns>   
        public DataTable ExecuteDataTable(string sql)
        {
            SQLiteCommand dc = dbObj.Connection.CreateCommand();
            dc.CommandText = sql;
            

            SQLiteDataAdapter adapter = new SQLiteDataAdapter(dc);
            DataTable data = new DataTable();
            adapter.Fill(data);
            dc.Parameters.Clear();
            return data;
        }
        #endregion
    }

