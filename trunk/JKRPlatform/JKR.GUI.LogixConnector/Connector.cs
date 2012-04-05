using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Collections;

namespace JKR.GUI.LogixConnector
{
    public class Connector : SoapHttpClientProtocol
    {
        // Fields
        private static ArrayList __ENCList;
        private AboutCompletedEventHandler AboutCompletedEvent;
        private SendOrPostCallback AboutOperationCompleted;
        private ChangePasswordCompletedEventHandler ChangePasswordCompletedEvent;
        private SendOrPostCallback ChangePasswordOperationCompleted;
        private DeleteLogsCompletedEventHandler DeleteLogsCompletedEvent;
        private SendOrPostCallback DeleteLogsOperationCompleted;
        private DeleteUpdateFileByIDCompletedEventHandler DeleteUpdateFileByIDCompletedEvent;
        private SendOrPostCallback DeleteUpdateFileByIDOperationCompleted;
        private ExecFunctionByDataSetCompletedEventHandler ExecFunctionByDataSetCompletedEvent;
        private SendOrPostCallback ExecFunctionByDataSetOperationCompleted;
        private ExecFunctionCompletedEventHandler ExecFunctionCompletedEvent;
        private SendOrPostCallback ExecFunctionOperationCompleted;
        private GetAuthorizationTicketCompletedEventHandler GetAuthorizationTicketCompletedEvent;
        private SendOrPostCallback GetAuthorizationTicketOperationCompleted;
        private GetCommandCodesCompletedEventHandler GetCommandCodesCompletedEvent;
        private SendOrPostCallback GetCommandCodesOperationCompleted;
        private GetConnectionStringCompletedEventHandler GetConnectionStringCompletedEvent;
        private SendOrPostCallback GetConnectionStringOperationCompleted;
        private GetCurrentVersionCompletedEventHandler GetCurrentVersionCompletedEvent;
        private SendOrPostCallback GetCurrentVersionOperationCompleted;
        private GetDataSetFunctionByDataSetCompletedEventHandler GetDataSetFunctionByDataSetCompletedEvent;
        private SendOrPostCallback GetDataSetFunctionByDataSetOperationCompleted;
        private GetDataSetFunctionCompletedEventHandler GetDataSetFunctionCompletedEvent;
        private SendOrPostCallback GetDataSetFunctionOperationCompleted;
        private GetDescByCommandCodeCompletedEventHandler GetDescByCommandCodeCompletedEvent;
        private SendOrPostCallback GetDescByCommandCodeOperationCompleted;
        private GetUpdateFileListCompletedEventHandler GetUpdateFileListCompletedEvent;
        private SendOrPostCallback GetUpdateFileListOperationCompleted;
        private GetUpdateSingleFileCompletedEventHandler GetUpdateSingleFileCompletedEvent;
        private SendOrPostCallback GetUpdateSingleFileOperationCompleted;
        private GetUserInfoCompletedEventHandler GetUserInfoCompletedEvent;
        private SendOrPostCallback GetUserInfoOperationCompleted;
        private HelloCompletedEventHandler HelloCompletedEvent;
        private SendOrPostCallback HelloOperationCompleted;
        private LoadLogsCompletedEventHandler LoadLogsCompletedEvent;
        private SendOrPostCallback LoadLogsOperationCompleted;
        private LoadPrivilegesCompletedEventHandler LoadPrivilegesCompletedEvent;
        private SendOrPostCallback LoadPrivilegesOperationCompleted;
        private LoginCompletedEventHandler LoginCompletedEvent;
        private SendOrPostCallback LoginOperationCompleted;
        private LogoutCompletedEventHandler LogoutCompletedEvent;
        private SendOrPostCallback LogoutOperationCompleted;
        private NewUpdateFileCompletedEventHandler NewUpdateFileCompletedEvent;
        private SendOrPostCallback NewUpdateFileOperationCompleted;
        private TestConnectionCompletedEventHandler TestConnectionCompletedEvent;
        private SendOrPostCallback TestConnectionOperationCompleted;
        private TestLogCompletedEventHandler TestLogCompletedEvent;
        private SendOrPostCallback TestLogOperationCompleted;
        private UpdateCurrentVersionCompletedEventHandler UpdateCurrentVersionCompletedEvent;
        private SendOrPostCallback UpdateCurrentVersionOperationCompleted;
        private UploadUpdateFileCompletedEventHandler UploadUpdateFileCompletedEvent;
        private SendOrPostCallback UploadUpdateFileOperationCompleted;
        private bool useDefaultCredentialsSetExplicitly;
        private VerifyActiveUserCompletedEventHandler VerifyActiveUserCompletedEvent;
        private SendOrPostCallback VerifyActiveUserOperationCompleted;
        private VerifyLoginCompletedEventHandler VerifyLoginCompletedEvent;
        private SendOrPostCallback VerifyLoginOperationCompleted;
        private VerifyModifyCompletedEventHandler VerifyModifyCompletedEvent;
        private SendOrPostCallback VerifyModifyOperationCompleted;
        private VerifyRegisterCompletedEventHandler VerifyRegisterCompletedEvent;
        private SendOrPostCallback VerifyRegisterOperationCompleted;
        private WriteLogCompletedEventHandler WriteLogCompletedEvent;
        private SendOrPostCallback WriteLogOperationCompleted;

        // Events
        public event AboutCompletedEventHandler AboutCompleted;
        public event ChangePasswordCompletedEventHandler ChangePasswordCompleted;
        public event DeleteLogsCompletedEventHandler DeleteLogsCompleted;
        public event DeleteUpdateFileByIDCompletedEventHandler DeleteUpdateFileByIDCompleted;
        public event ExecFunctionByDataSetCompletedEventHandler ExecFunctionByDataSetCompleted;
        public event ExecFunctionCompletedEventHandler ExecFunctionCompleted;
        public event GetAuthorizationTicketCompletedEventHandler GetAuthorizationTicketCompleted;
        public event GetCommandCodesCompletedEventHandler GetCommandCodesCompleted;
        public event GetConnectionStringCompletedEventHandler GetConnectionStringCompleted;
        public event GetCurrentVersionCompletedEventHandler GetCurrentVersionCompleted;
        public event GetDataSetFunctionByDataSetCompletedEventHandler GetDataSetFunctionByDataSetCompleted;
        public event GetDataSetFunctionCompletedEventHandler GetDataSetFunctionCompleted;
        public event GetDescByCommandCodeCompletedEventHandler GetDescByCommandCodeCompleted;
        public event GetUpdateFileListCompletedEventHandler GetUpdateFileListCompleted;
        public event GetUpdateSingleFileCompletedEventHandler GetUpdateSingleFileCompleted;
        public event GetUserInfoCompletedEventHandler GetUserInfoCompleted;
        public event HelloCompletedEventHandler HelloCompleted;
        public event LoadLogsCompletedEventHandler LoadLogsCompleted;
        public event LoadPrivilegesCompletedEventHandler LoadPrivilegesCompleted;
        public event LoginCompletedEventHandler LoginCompleted;
        public event LogoutCompletedEventHandler LogoutCompleted;
        public event NewUpdateFileCompletedEventHandler NewUpdateFileCompleted;
        public event TestConnectionCompletedEventHandler TestConnectionCompleted;
        public event TestLogCompletedEventHandler TestLogCompleted;
        public event UpdateCurrentVersionCompletedEventHandler UpdateCurrentVersionCompleted;
        public event UploadUpdateFileCompletedEventHandler UploadUpdateFileCompleted;
        public event VerifyActiveUserCompletedEventHandler VerifyActiveUserCompleted;
        public event VerifyLoginCompletedEventHandler VerifyLoginCompleted;
        public event VerifyModifyCompletedEventHandler VerifyModifyCompleted;
        public event VerifyRegisterCompletedEventHandler VerifyRegisterCompleted;
        public event WriteLogCompletedEventHandler WriteLogCompleted;

        // Methods

        static Connector();
        public Connector();
     
        public string About();
        public void AboutAsync();
        public void AboutAsync(object userState);
        public IAsyncResult BeginAbout(AsyncCallback callback, object asyncState);
        public IAsyncResult BeginChangePassword(string sUserCode, string sOldPassword, string sNewPassword, AsyncCallback callback, object asyncState);
        public IAsyncResult BeginDeleteLogs(string id, AsyncCallback callback, object asyncState);
        public IAsyncResult BeginDeleteUpdateFileByID(string FileID, AsyncCallback callback, object asyncState);
        public IAsyncResult BeginExecFunction(string dll_name, string class_name, string function_name, object[] args, AsyncCallback callback, object asyncState);
        public IAsyncResult BeginExecFunctionByDataSet(string dll_name, string class_name, string function_name, object[] args, AsyncCallback callback, object asyncState);
        public IAsyncResult BeginGetAuthorizationTicket(string sUserCode, string sPassword, AsyncCallback callback, object asyncState);
        public IAsyncResult BeginGetCommandCodes(AsyncCallback callback, object asyncState);
        public IAsyncResult BeginGetConnectionString(AsyncCallback callback, object asyncState);
        public IAsyncResult BeginGetCurrentVersion(AsyncCallback callback, object asyncState);
        public IAsyncResult BeginGetDataSetFunction(string dll_name, string class_name, string function_name, object[] args, AsyncCallback callback, object asyncState);
        public IAsyncResult BeginGetDataSetFunctionByDataSet(string dll_name, string class_name, string function_name, object[] args, AsyncCallback callback, object asyncState);
        public IAsyncResult BeginGetDescByCommandCode(string commandCode, AsyncCallback callback, object asyncState);
        public IAsyncResult BeginGetUpdateFileList(string versionNo, AsyncCallback callback, object asyncState);
        public IAsyncResult BeginGetUpdateSingleFile(string FileName, AsyncCallback callback, object asyncState);
        public IAsyncResult BeginGetUserInfo(string sTicket, AsyncCallback callback, object asyncState);
        public IAsyncResult BeginHello(AsyncCallback callback, object asyncState);
        public IAsyncResult BeginLoadLogs(string sLimit, AsyncCallback callback, object asyncState);
        public IAsyncResult BeginLoadPrivileges(string UserCode, AsyncCallback callback, object asyncState);
        public IAsyncResult BeginLogin(string userCode, string pwd, AsyncCallback callback, object asyncState);
        public IAsyncResult BeginLogout(AsyncCallback callback, object asyncState);
        public IAsyncResult BeginNewUpdateFile(AsyncCallback callback, object asyncState);
        public IAsyncResult BeginTestConnection(AsyncCallback callback, object asyncState);
        public IAsyncResult BeginTestLog(string logItem, AsyncCallback callback, object asyncState);
        public IAsyncResult BeginUpdateCurrentVersion(string version, AsyncCallback callback, object asyncState);
        public IAsyncResult BeginUploadUpdateFile(DataSet ds, AsyncCallback callback, object asyncState);
        public IAsyncResult BeginVerifyActiveUser(AsyncCallback callback, object asyncState);
        public IAsyncResult BeginVerifyLogin(AsyncCallback callback, object asyncState);
        public IAsyncResult BeginVerifyModify(AsyncCallback callback, object asyncState);
        public IAsyncResult BeginVerifyRegister(string licenseContent, string MAC, AsyncCallback callback, object asyncState);
        //public IAsyncResult BeginWriteLog(LogInformation Log, AsyncCallback callback, object asyncState);
        public void CancelAsync(object userState);
        //[SoapDocumentMethod("http://tempuri.org/ChangePassword", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public bool ChangePassword(string sUserCode, string sOldPassword, string sNewPassword);
        public void ChangePasswordAsync(string sUserCode, string sOldPassword, string sNewPassword);
        public void ChangePasswordAsync(string sUserCode, string sOldPassword, string sNewPassword, object userState);
        //[SoapDocumentMethod("http://tempuri.org/DeleteLogs", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public bool DeleteLogs(string id);
        public void DeleteLogsAsync(string id);
        public void DeleteLogsAsync(string id, object userState);
        //[SoapDocumentMethod("http://tempuri.org/DeleteUpdateFileByID", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public bool DeleteUpdateFileByID(string FileID);
        public void DeleteUpdateFileByIDAsync(string FileID);
        public void DeleteUpdateFileByIDAsync(string FileID, object userState);
        public string EndAbout(IAsyncResult asyncResult);
        public bool EndChangePassword(IAsyncResult asyncResult);
        public bool EndDeleteLogs(IAsyncResult asyncResult);
        public bool EndDeleteUpdateFileByID(IAsyncResult asyncResult);
        public object EndExecFunction(IAsyncResult asyncResult);
        public object EndExecFunctionByDataSet(IAsyncResult asyncResult);
        public string EndGetAuthorizationTicket(IAsyncResult asyncResult);
        public string EndGetCommandCodes(IAsyncResult asyncResult);
        public string EndGetConnectionString(IAsyncResult asyncResult);
        public string EndGetCurrentVersion(IAsyncResult asyncResult);
        public byte[] EndGetDataSetFunction(IAsyncResult asyncResult);
        public byte[] EndGetDataSetFunctionByDataSet(IAsyncResult asyncResult);
        public DataSet EndGetDescByCommandCode(IAsyncResult asyncResult);
        public DataSet EndGetUpdateFileList(IAsyncResult asyncResult);
        public byte[] EndGetUpdateSingleFile(IAsyncResult asyncResult);
        public UserInformation EndGetUserInfo(IAsyncResult asyncResult);
        public string EndHello(IAsyncResult asyncResult);
        public DataSet EndLoadLogs(IAsyncResult asyncResult);
        public DataSet EndLoadPrivileges(IAsyncResult asyncResult);
        public UserInformation EndLogin(IAsyncResult asyncResult);
        public void EndLogout(IAsyncResult asyncResult);
        public DataSet EndNewUpdateFile(IAsyncResult asyncResult);
        public bool EndTestConnection(IAsyncResult asyncResult);
        public void EndTestLog(IAsyncResult asyncResult);
        public bool EndUpdateCurrentVersion(IAsyncResult asyncResult);
        public bool EndUploadUpdateFile(IAsyncResult asyncResult);
        public bool EndVerifyActiveUser(IAsyncResult asyncResult);
        public bool EndVerifyLogin(IAsyncResult asyncResult);
        public bool EndVerifyModify(IAsyncResult asyncResult);
        public bool EndVerifyRegister(IAsyncResult asyncResult);
        public bool EndWriteLog(IAsyncResult asyncResult);
        //[SoapDocumentMethod("http://tempuri.org/ExecFunction", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public object ExecFunction(string dll_name, string class_name, string function_name, object[] args);
        public void ExecFunctionAsync(string dll_name, string class_name, string function_name, object[] args);
        public void ExecFunctionAsync(string dll_name, string class_name, string function_name, object[] args, object userState);
        //[SoapDocumentMethod("http://tempuri.org/ExecFunctionByDataSet", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public object ExecFunctionByDataSet(string dll_name, string class_name, string function_name, object[] args);
        public void ExecFunctionByDataSetAsync(string dll_name, string class_name, string function_name, object[] args);
        public void ExecFunctionByDataSetAsync(string dll_name, string class_name, string function_name, object[] args, object userState);
        //[SoapDocumentMethod("http://tempuri.org/GetAuthorizationTicket", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public string GetAuthorizationTicket(string sUserCode, string sPassword);
        public void GetAuthorizationTicketAsync(string sUserCode, string sPassword);
        public void GetAuthorizationTicketAsync(string sUserCode, string sPassword, object userState);
        //[SoapDocumentMethod("http://tempuri.org/GetCommandCodes", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public string GetCommandCodes();
        public void GetCommandCodesAsync();
        public void GetCommandCodesAsync(object userState);
        //[SoapDocumentMethod("http://tempuri.org/GetConnectionString", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public string GetConnectionString();
        public void GetConnectionStringAsync();
        public void GetConnectionStringAsync(object userState);
        //[SoapDocumentMethod("http://tempuri.org/GetCurrentVersion", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public string GetCurrentVersion();
        public void GetCurrentVersionAsync();
        public void GetCurrentVersionAsync(object userState);
        //[return: XmlElement(DataType = "base64Binary")]
        //[SoapDocumentMethod("http://tempuri.org/GetDataSetFunction", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public byte[] GetDataSetFunction(string dll_name, string class_name, string function_name, object[] args);
        public void GetDataSetFunctionAsync(string dll_name, string class_name, string function_name, object[] args);
        public void GetDataSetFunctionAsync(string dll_name, string class_name, string function_name, object[] args, object userState);
        //[return: XmlElement(DataType = "base64Binary")]
        //[SoapDocumentMethod("http://tempuri.org/GetDataSetFunctionByDataSet", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public byte[] GetDataSetFunctionByDataSet(string dll_name, string class_name, string function_name, object[] args);
        public void GetDataSetFunctionByDataSetAsync(string dll_name, string class_name, string function_name, object[] args);
        public void GetDataSetFunctionByDataSetAsync(string dll_name, string class_name, string function_name, object[] args, object userState);
        //[SoapDocumentMethod("http://tempuri.org/GetDescByCommandCode", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public DataSet GetDescByCommandCode(string commandCode);
        public void GetDescByCommandCodeAsync(string commandCode);
        public void GetDescByCommandCodeAsync(string commandCode, object userState);
        //[SoapDocumentMethod("http://tempuri.org/GetUpdateFileList", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public DataSet GetUpdateFileList(string versionNo);
        public void GetUpdateFileListAsync(string versionNo);
        public void GetUpdateFileListAsync(string versionNo, object userState);
       
      
        public byte[] GetUpdateSingleFile(string FileName);
        public void GetUpdateSingleFileAsync(string FileName);
        public void GetUpdateSingleFileAsync(string FileName, object userState);
        [SoapDocumentMethod("http://tempuri.org/GetUserInfo", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public UserInformation GetUserInfo(string sTicket);
        public void GetUserInfoAsync(string sTicket);
        public void GetUserInfoAsync(string sTicket, object userState);
        [SoapDocumentMethod("http://tempuri.org/Hello", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public string Hello();
        public void HelloAsync();
        public void HelloAsync(object userState);
        private bool IsLocalFileSystemWebService(string url);
        [SoapDocumentMethod("http://tempuri.org/LoadLogs", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public DataSet LoadLogs(string sLimit);
        public void LoadLogsAsync(string sLimit);
        public void LoadLogsAsync(string sLimit, object userState);
        [SoapDocumentMethod("http://tempuri.org/LoadPrivileges", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public DataSet LoadPrivileges(string UserCode);
        public void LoadPrivilegesAsync(string UserCode);
        public void LoadPrivilegesAsync(string UserCode, object userState);
        [SoapDocumentMethod("http://tempuri.org/Login", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public UserInformation Login(string userCode, string pwd);
        public void LoginAsync(string userCode, string pwd);
        public void LoginAsync(string userCode, string pwd, object userState);
        [SoapDocumentMethod("http://tempuri.org/Logout", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public void Logout();
        public void LogoutAsync();
        public void LogoutAsync(object userState);
        [SoapDocumentMethod("http://tempuri.org/NewUpdateFile", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public DataSet NewUpdateFile();
        public void NewUpdateFileAsync();
        public void NewUpdateFileAsync(object userState);
        private void OnAboutOperationCompleted(object arg);
        private void OnChangePasswordOperationCompleted(object arg);
        private void OnDeleteLogsOperationCompleted(object arg);
        private void OnDeleteUpdateFileByIDOperationCompleted(object arg);
        private void OnExecFunctionByDataSetOperationCompleted(object arg);
        private void OnExecFunctionOperationCompleted(object arg);
        private void OnGetAuthorizationTicketOperationCompleted(object arg);
        private void OnGetCommandCodesOperationCompleted(object arg);
        private void OnGetConnectionStringOperationCompleted(object arg);
        private void OnGetCurrentVersionOperationCompleted(object arg);
        private void OnGetDataSetFunctionByDataSetOperationCompleted(object arg);
        private void OnGetDataSetFunctionOperationCompleted(object arg);
        private void OnGetDescByCommandCodeOperationCompleted(object arg);
        private void OnGetUpdateFileListOperationCompleted(object arg);
        private void OnGetUpdateSingleFileOperationCompleted(object arg);
        private void OnGetUserInfoOperationCompleted(object arg);
        private void OnHelloOperationCompleted(object arg);
        private void OnLoadLogsOperationCompleted(object arg);
        private void OnLoadPrivilegesOperationCompleted(object arg);
        private void OnLoginOperationCompleted(object arg);
        private void OnLogoutOperationCompleted(object arg);
        private void OnNewUpdateFileOperationCompleted(object arg);
        private void OnTestConnectionOperationCompleted(object arg);
        private void OnTestLogOperationCompleted(object arg);
        private void OnUpdateCurrentVersionOperationCompleted(object arg);
        private void OnUploadUpdateFileOperationCompleted(object arg);
        private void OnVerifyActiveUserOperationCompleted(object arg);
        private void OnVerifyLoginOperationCompleted(object arg);
        private void OnVerifyModifyOperationCompleted(object arg);
        private void OnVerifyRegisterOperationCompleted(object arg);
        private void OnWriteLogOperationCompleted(object arg);
        [SoapDocumentMethod("http://tempuri.org/TestConnection", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public bool TestConnection();
        public void TestConnectionAsync();
        public void TestConnectionAsync(object userState);
        [SoapDocumentMethod("http://tempuri.org/TestLog", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public void TestLog(string logItem);
        public void TestLogAsync(string logItem);
        public void TestLogAsync(string logItem, object userState);
        [SoapDocumentMethod("http://tempuri.org/UpdateCurrentVersion", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public bool UpdateCurrentVersion(string version);
        public void UpdateCurrentVersionAsync(string version);
        public void UpdateCurrentVersionAsync(string version, object userState);
        [SoapDocumentMethod("http://tempuri.org/UploadUpdateFile", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public bool UploadUpdateFile(DataSet ds);
        public void UploadUpdateFileAsync(DataSet ds);
        public void UploadUpdateFileAsync(DataSet ds, object userState);
        [SoapDocumentMethod("http://tempuri.org/VerifyActiveUser", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public bool VerifyActiveUser();
        public void VerifyActiveUserAsync();
        public void VerifyActiveUserAsync(object userState);
        [SoapDocumentMethod("http://tempuri.org/VerifyLogin", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public bool VerifyLogin();
        public void VerifyLoginAsync();
        public void VerifyLoginAsync(object userState);
        [SoapDocumentMethod("http://tempuri.org/VerifyModify", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public bool VerifyModify();
        public void VerifyModifyAsync();
        public void VerifyModifyAsync(object userState);
        [SoapDocumentMethod("http://tempuri.org/VerifyRegister", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public bool VerifyRegister(string licenseContent, string MAC);
        public void VerifyRegisterAsync(string licenseContent, string MAC);
        public void VerifyRegisterAsync(string licenseContent, string MAC, object userState);
        [SoapDocumentMethod("http://tempuri.org/WriteLog", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped)]
        public bool WriteLog(LogInformation Log);
        public void WriteLogAsync(LogInformation Log);
        public void WriteLogAsync(LogInformation Log, object userState);

        // Properties
        public string Url { get; set; }
        public bool UseDefaultCredentials { get; set; }

    }
}
