using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Resources;

namespace JKR.Cargo.Common
{
    public class CommonMessageInfo
    {
     static ResourceManager Resource = new ResourceManager("JKR.Cargo.Common.Message", System.Reflection.Assembly.GetExecutingAssembly());
    //public static readonly string ACCOUNTNOTFOUND   = Resource.GetString("ACCOUNTNOTFOUND"); //"结算单位不存在!"
    public static readonly string BTNCHECKTEXT   = Resource.GetString("BTNCHECKTEXT"); // 费用审核按钮的审核状态显示
    public static readonly string BTNUNCHECKTEXT   = Resource.GetString("BTNUNCHECKTEXT"); // 费用审核按钮的取消审核状态显示
    public static readonly string RELATEDCHARGESDELETEDSURE   = Resource.GetString("RELATEDCHARGESDELETEDSURE"); //相关的费用将被删除，确定？
    public static readonly string FIELDBINDERROR   = Resource.GetString("FIELDBINDERROR"); //字段绑定错误！
    public static readonly string SURETOINVOICE   = Resource.GetString("SURETOINVOICE"); //确定{0}帐单？
    public static readonly string REMOVECHARGESURE   = Resource.GetString("REMOVECHARGESURE"); //费用将被移除，确定？
    public static readonly string DELETECHARGESURE   = Resource.GetString("DELETECHARGESURE"); //费用将被删除，确定？
    public static readonly string REVOKESUREINVOICE   = Resource.GetString("REVOKESUREINVOICE"); //确定作废帐单？
    public static readonly string DIFFRENTACCOUNTSNOTINVOICESAME   = Resource.GetString("DIFFRENTACCOUNTSNOTINVOICESAME"); //不同的客户不能同时开帐单！
    public static readonly string DIFFRENTINVOICECLASSNOTINVOICESAME   = Resource.GetString("DIFFRENTINVOICECLASSNOTINVOICESAME"); //不同的帐单分类不能同时开帐单！
    public static readonly string LOCALOPERATIONNOCHARGESGENERATE   = Resource.GetString("LOCALOPERATIONNOCHARGESGENERATE"); //不产生本地费用！
    public static readonly string DIFFCURRTYPENOTINVOICESAME   = Resource.GetString("DIFFCURRTYPENOTINVOICESAME"); // 不同币种不能同时开帐单！
    public static readonly string CANNOTFINDCORRECTEXCHANGERATE   = Resource.GetString("CANNOTFINDCORRECTEXCHANGERATE"); // 不能找到正确的汇率！
    public static readonly string INPUTLINESCANNOTMORETHAN   = Resource.GetString("INPUTLINESCANNOTMORETHAN"); // 录入的行数不能超过
    public static readonly string CHARACTERSCANNOTOVERTHAN   = Resource.GetString("CHARACTERSCANNOTOVERTHAN"); // 单行录入的字数不能超过
    public static readonly string NOTCHARGEINGRD   = Resource.GetString("NOTCHARGEINGRD"); // 列表中没有费用！
    public static readonly string ISNOTFIND   = Resource.GetString("ISNOTFIND"); //** 没有找到！
    public static readonly string CANNOTBEREVOKEHADBEENPRINT   = Resource.GetString("CANNOTBEREVOKEHADBEENPRINT"); //帐单被打印不能作废！
    public static readonly string CANNOTCONTINNUEREVOKEOPERATIOIN   = Resource.GetString("CANNOTCONTINNUEREVOKEOPERATIOIN"); // 作废动作不能继续进行！
    public static readonly string REVOKESUCCESS   = Resource.GetString("REVOKESUCCESS"); // 作废成功！
    public static readonly string REVOKEFAILTURE   = Resource.GetString("REVOKEFAILTURE"); // 作废失败！
    public static readonly string ITHASBEENDELETEDALREADY   = Resource.GetString("ITHASBEENDELETEDALREADY"); // 已经被删除！
    public static readonly string SENDPREALERTSUCCESS   = Resource.GetString("SENDPREALERTSUCCESS"); // 预报发送成功！
    public static readonly string SENDPREALERTFAILTURE   = Resource.GetString("SENDPREALERTFAILTURE"); // 预报发送失败！
    public static readonly string DEBITCREDITCANBEPRINTSAME   = Resource.GetString("DEBITCREDITCANBEPRINTSAME"); // 应收帐单和应付帐单不能同时打印！
    public static readonly string DEBITCREDITCANBEPRINTOVEASEA   = Resource.GetString("DEBITCREDITCANBEPRINTOVEASEA"); // 代理帐单和普通帐单不能同时打印！
    public static readonly string INVOICECHECKEDPAIDCANNOTBEDELETE   = Resource.GetString("INVOICECHECKEDPAIDCANNOTBEDELETE"); // 帐单被审核或核销不能删除！
    public static readonly string INVOICEPRINTCANNOTDELETE   = Resource.GetString("INVOICEPRINTCANNOTDELETE"); //帐单被打印不能删除！
    public static readonly string INVOICERECONCILIATIONCANNOTDELETE   = Resource.GetString("INVOICERECONCILIATIONCANNOTDELETE"); //帐单已加入对帐清单不能删除！
    public static readonly string ACCOUNTINBLACKLISTCANNOTSELECTED   = Resource.GetString("ACCOUNTINBLACKLISTCANNOTSELECTED"); // 客户在黒名单里面不能选择！
    public static readonly string ACCOUNTCENTERSAMEASOFFICE   = Resource.GetString("ACCOUNTCENTERSAMEASOFFICE"); // 结算中心与帐单原分公司相同，请重新选择！
    public static readonly string NORECORDSBESELECTED   = Resource.GetString("NORECORDSBESELECTED"); // 没有选中任何数据！
    public static readonly string TAXINVOICENOISCREATEPRINT   = Resource.GetString("TAXINVOICENOISCREATEPRINT"); // 发票号已经产生，确定还要打印？
    public static readonly string DATANOSELECTED   = Resource.GetString("DATANOSELECTED"); // 没有选中的数据
    public static readonly string SUPPLIERINVOICECANNOTREVOKE   = Resource.GetString("SUPPLIERINVOICECANNOTREVOKE"); // 供应商发票不能被作废！
    public static readonly string MUTILCREATEINVOICESUCCESS   = Resource.GetString("MUTILCREATEINVOICESUCCESS"); // 批量生成帐单成功！
    public static readonly string MUTILCREATEINVOICEFAILED   = Resource.GetString("MUTILCREATEINVOICEFAILED"); // 批量生成帐单失败！
    public static readonly string SURECOMBINEINVOICE   = Resource.GetString("SURECOMBINEINVOICE"); // 确定开帐单？
    public static readonly string SURECOMBINETAXINVOICE   = Resource.GetString("SURECOMBINETAXINVOICE"); // 确定合开发票？
    public static readonly string SUREBATCHINVOICE   = Resource.GetString("SUREBATCHINVOICE"); // 确定批量开帐单？
    public static readonly string SUREBATCHTAXINVOICE   = Resource.GetString("SUREBATCHTAXINVOICE"); // 确定批量开发票？
    public static readonly string NOAGENTCANNOTINVOICE   = Resource.GetString("NOAGENTCANNOTINVOICE"); // 没有海外代理不能开代理帐单！
    public static readonly string CHARGEISVOCHERCANNOTUNDOSETTLEMENT   = Resource.GetString("CHARGEISVOCHERCANNOTUNDOSETTLEMENT"); // 选中的费用已经入帐不能撤销核销！
    public static readonly string CHARGESELECTEDWILLCHANGEARAP   = Resource.GetString("CHARGESELECTEDWILLCHANGEARAP"); //选中的费用将改变收付方向，不能撤销核销！
    public static readonly string SUREUNDOSETTLEMENT   = Resource.GetString("SUREUNDOSETTLEMENT"); //确认撤销核销！
    public static readonly string UNDOSETTLEMNETSUCCESS   = Resource.GetString("UNDOSETTLEMNETSUCCESS"); // 撤销核销成功！
    public static readonly string UNDOSETTLEMENTFAILED   = Resource.GetString("UNDOSETTLEMENTFAILED"); // 撤销核销失败！
    public static readonly string MSG_CANNOT_CHANGE_TO_INVOICE_ACCOUNTS   = Resource.GetString("MSG_CANNOT_CHANGE_TO_INVOICE_ACCOUNTS"); // 不能改为结算单位
    public static readonly string MSG_CHARGE_ERROR   = Resource.GetString("MSG_CHARGE_ERROR"); // 费用有误，请检查！
    public static readonly string MSG_BACK_SUCCESS   = Resource.GetString("MSG_BACK_SUCCESS"); // 回退成功！
    public static readonly string MSG_BACK_FAILTURE   = Resource.GetString("MSG_BACK_FAILTURE"); // 回退失败！
    public static readonly string BACK   = Resource.GetString("BACK"); // 回退
    public static readonly string TURNACCOUNTINGCENTER   = Resource.GetString("TURNACCOUNTINGCENTER"); // 转结算中心
    public static readonly string MSG_AMOUNT_ERROR   = Resource.GetString("MSG_AMOUNT_ERROR"); // 收支金额打于汇总金额
    public static readonly string MSG_JOBNO_HAVENOT_CHARGE_FOR_INVOICE   = Resource.GetString("MSG_JOBNO_HAVENOT_CHARGE_FOR_INVOICE"); // 工作号没有可以开帐单的费用
    public static readonly string MSG_SELECTED_ONE_PLS_USE_COMBINE_INVOICE   = Resource.GetString("MSG_SELECTED_ONE_PLS_USE_COMBINE_INVOICE"); // 只是选择一条记录，请合开帐单！
    public static readonly string MSG_NOT_SAME_ACCOUNTS_CANNOT_INVOICE   = Resource.GetString("MSG_NOT_SAME_ACCOUNTS_CANNOT_INVOICE"); //结算单位不同，不能开帐单！
    public static readonly string CHECKEDCANOTREPEAT   = Resource.GetString("CHECKEDCANOTREPEAT"); //
    public static readonly string MSG_NOT_SAME_ACCOUNTS_CANNOT_CONFIRM   = Resource.GetString("MSG_NOT_SAME_ACCOUNTS_CANNOT_CONFIRM"); // 结算单位不同不能同时确认！
    public static readonly string MSG_NOT_HAVE_RIGHT   = Resource.GetString("MSG_NOT_HAVE_RIGHT"); // 没有权限
    public static readonly string MSG_CANNOT_EMPTY   = Resource.GetString("MSG_CANNOT_EMPTY"); // 不能为空！
    public static readonly string MSG_CANNOT_ZERO   = Resource.GetString("MSG_CANNOT_ZERO"); // 不能为0
    public static readonly string MSG_HAVE_NOT_ACCOUNTS   = Resource.GetString("MSG_HAVE_NOT_ACCOUNTS"); // 没有结算单位！
    public static readonly string MSG_OUT_AMOUNT_TOTAL   = Resource.GetString("MSG_OUT_AMOUNT_TOTAL"); // 超出金额总额！
    public static readonly string MSG_LINE_COUNT_MORE   = Resource.GetString("MSG_LINE_COUNT_MORE"); // 行数太多！
    public static readonly string CONTAINER_NO_FORMAT_ERROR   = Resource.GetString("CONTAINER_NO_FORMAT_ERROR"); //集装箱号初始化错误

    //操作完成
    //空运出口
    public static readonly string BELOCK_STATUS   = Resource.GetString("BELOCK_STATUS");  //运单锁定状态
    public static readonly string CUSTOMER_CHARGE_STATUS   = Resource.GetString("CUSTOMER_CHARGE_STATUS"); //报关费用提交
    public static readonly string LAND_CHARGE_STATUS   = Resource.GetString("LAND_CHARGE_STATUS"); //陆运费用提交
    public static readonly string UNION_CHARGE_STATUS   = Resource.GetString("UNION_CHARGE_STATUS"); //联运费用提交
    public static readonly string BATCH_CHARGE_STATUS   = Resource.GetString("BATCH_CHARGE_STATUS"); //批量费用提交
    public static readonly string LOSS_INFO_STATUS   = Resource.GetString("LOSS_INFO_STATUS"); //业务亏损情况
    public static readonly string WAREHOUSE_STATUS   = Resource.GetString("WAREHOUSE_STATUS"); //仓储状态
    public static readonly string RELATED_CHARGE_STATUS   = Resource.GetString("RELATED_CHARGE_STATUS"); //内结费用

    //空运进口
    //public static readonly string WAREHOUSE_STATUS   = Resource.GetString("WAREHOUSE_STATUS"); //仓储状态
    public static readonly string ISEXISTJOBNO   = Resource.GetString("ISEXISTJOBNO"); //工作号生成情况
    //海运出口
    public static readonly string CHARGESDOINVOICE   = Resource.GetString("CHARGESDOINVOICE"); //费用全部开帐单
    public static readonly string SPECIALREQUIREISFINISHED   = Resource.GetString("SPECIALREQUIREISFINISHED"); //操作要求是否完成
    public static readonly string SPACECONFIRM   = Resource.GetString("SPACECONFIRM");  //舱位确认

    public static readonly string INVOICE_JOBNO   = Resource.GetString("INVOICE_JOBNO"); //工作号未生成，不能生成帐单　yuhuaru 20080714
    public static readonly string CURRENCY_PROFITSMIN   = Resource.GetString("CURRENCY_PROFITSMIN"); //本位币利润大于0　fch 20100412
    public static readonly string CURRENCY_PROFITSMAX   = Resource.GetString("CURRENCY_PROFITSMAX"); //本位币利润小等于20000　fch 20100412
    public static readonly string DEBITPAYCHECK   = Resource.GetString("DEBITPAYCHECK");; //应付合计不为0　fch 20100412

    }

    public class CommonAEMessageInfo
    {
      static ResourceManager Resource = new ResourceManager("JKR.Cargo.AECommon.Message", System.Reflection.Assembly.GetExecutingAssembly());
    //public static readonly string APPROVE_SURE   = Resource.GetString("APPROVE_SURE");   //审批
    //public static readonly string APPROVE_SUCCESS   = Resource.GetString("APPROVE_SUCCESS");   //审批
    //public static readonly string PROMPT_TITLE   = Resource.GetString("PROMPT_TITLE");   //审批标题
    //public static readonly string APPROVE_FAILURE   = Resource.GetString("APPROVE_FAILURE");   //"Approve failure!"
    //public static readonly string HAVEERROR   = Resource.GetString("HAVEERROR");
    //public static readonly string ROLESEMPTY   = Resource.GetString("ROLESEMPTY");	//用户必须属于一个或者多个角色
    //public static readonly string GROUPEMPTY   = Resource.GetString("GROUPEMPTY");	//用户必须属于一个或者多个组
    //public static readonly string OFFICECODEGEMPTY   = Resource.GetString("OFFICECODEGEMPTY");	 //
    //public static readonly string MUSTCHOOSEROLES   = Resource.GetString("MUSTCHOOSEROLES");	//"Please choose one or serval roles"
    //public static readonly string ACCOUNTNOTFOUND   = Resource.GetString("ACCOUNTNOTFOUND");	//"结算单位不存在!"


    public static readonly string HAWBHAVENOTMAWB   = Resource.GetString("HAWBHAVENOTMAWB");      //"The HAWB havn//t a MAWB!"
    public static readonly string JOBMODECANNOTDEATTACHHAWB   = Resource.GetString("JOBMODECANNOTDEATTACHHAWB");    //"The Job Mode can//t to Deattach a HAWB!"

    //public static readonly string a   = Resource.GetString("a");	//Are you sure to Deattach the HAWB
    public static readonly string REUSESUCCESS   = Resource.GetString("REUSESUCCESS");    //"Reuse MAWB No failure"
    public static readonly string REUSEFAILURE   = Resource.GetString("REUSEFAILURE");    //"Reuse MAWB No failure"

    public static readonly string DEATTACHSUCCESS   = Resource.GetString("DEATTACHSUCCESS");      //Deattach success
    public static readonly string DEATTACHFAILURE   = Resource.GetString("DEATTACHFAILURE");
    public static readonly string ATTACHSUCCESS   = Resource.GetString("ATTACHSUCCESS");
    public static readonly string ATTACHFAILURE   = Resource.GetString("ATTACHFAILURE");

    public static readonly string SELECTMAWBNOFIRST   = Resource.GetString("SELECTMAWBNOFIRST");    //"Please select a MAWB no first!"

    public static readonly string LOCKSURE   = Resource.GetString("LOCKSURE");  //""Are you sure to lock the MAWB No?"
    public static readonly string LOCKSUCCESS   = Resource.GetString("LOCKSUCCESS");     // Lock success
    public static readonly string LOCKFAILURE   = Resource.GetString("LOCKFAILURE");      //Lock failure

    public static readonly string MODECHANGE   = Resource.GetString("MODECHANGE");    //"操作模式已经改变,请手工调整业务数据"

    public static readonly string NEWCONSOLESUCCESS   = Resource.GetString("NEWCONSOLESUCCESS");
    public static readonly string NEWCONSOLEFAILURE   = Resource.GetString("NEWCONSOLEFAILURE");

    public static readonly string CONVERTSURE   = Resource.GetString("CONVERTSURE");
    public static readonly string CONVERTSUCCESS   = Resource.GetString("CONVERTSUCCESS");
    public static readonly string CONVERTFAILURE   = Resource.GetString("CONVERTFAILURE");

    public static readonly string CONFIRMSURE   = Resource.GetString("CONFIRMSURE");    //ARE YOU SURE TO CONFIRM
    public static readonly string CONFIRMSUCCESS   = Resource.GetString("CONFIRMSUCCESS");
    public static readonly string CONFIRMFAILURE   = Resource.GetString("CONFIRMFAILURE");  //ARE YOU SURE TO CONFIRM
    public static readonly string UNCONFIRMSURE   = Resource.GetString("UNCONFIRMSURE");    //ARE YOU SURE TO CONFIRM
    public static readonly string UNCONFIRMSUCCESS   = Resource.GetString("UNCONFIRMSUCCESS");  //ARE YOU SURE TO CONFIRM
    public static readonly string UNCONFIRMFAILURE   = Resource.GetString("UNCONFIRMFAILURE"); //Are you sure to confirm

    public static readonly string CONFIRMSPACETEXT   = Resource.GetString("CONFIRMSPACETEXT");  //Are you sure confirm space
    public static readonly string UNCONFIRMSPACETEXT   = Resource.GetString("UNCONFIRMSPACETEXT");  // Are you sure cancel confirm space 

    public static readonly string FINISHTEXT   = Resource.GetString("FINISHTEXT"); //Are you sure to finish ?

    public static readonly string FINISH_SUCCESS   = Resource.GetString("FINISH_SUCCESS"); //Finish Success

    public static readonly string FINISH_FAILURE   = Resource.GetString("FINISH_FAILURE"); //Finish Failure

    public static readonly string CANNOTEMPTYFIELD   = Resource.GetString("CANNOTEMPTYFIELD"); // "MAWB No can//t be empty"

    public static readonly string MUSTBEEMPTYFIELD   = Resource.GetString("MUSTBEEMPTYFIELD");  // "MAWB No can//t be empty"

    public static readonly string DUPLICATEDFIELD   = Resource.GetString("DUPLICATEDFIELD");      //DUPLICATED

    public static readonly string INPUTSWRONGFIELD   = Resource.GetString("INPUTSWRONGFIELD");    //INPUTSWRONG
    public static readonly string CANNOTPRINT   = Resource.GetString("CANNOTPRINT");      //Cann//t print

    public static readonly string DATAINVALIDFIELD   = Resource.GetString("DATAINVALIDFIELD");    //This MAWB No is invalid"
    public static readonly string ALREADYDELETED   = Resource.GetString("ALREADYDELETED");  //"Already deleted"
    public static readonly string INUSE   = Resource.GetString("INUSE");      // Already in use the MAWB No is in use
    public static readonly string CHECKAGENT   = Resource.GetString("CHECKAGENT");    //check MAWB no/Carrier/Booking Agent data
    public static readonly string CONSISTENTFIELD   = Resource.GetString("CONSISTENTFIELD");      // The port code {0} is not consistent with port name {1}! "

    public static readonly string CANCELCANNOT   = Resource.GetString("CANCELCANNOT");    //Can//t to cancel
    public static readonly string CONVERTCANNOT   = Resource.GetString("CONVERTCANNOT");      //"Can//t to convert!"

    public static readonly string NOTEXISTFIELD   = Resource.GetString("NOTEXISTFIELD");      //The Customer{0} doesn//t exist!
    public static readonly string JOBMODEFIELD   = Resource.GetString("JOBMODEFIELD");    //The job mode is (co-loader);

    public static readonly string COMBINEFAILURE   = Resource.GetString("COMBINEFAILURE");
    public static readonly string COMBINESUCCESS   = Resource.GetString("COMBINESUCCESS");

    public static readonly string SYNCHBERTHFAILURE   = Resource.GetString("SYNCHBERTHFAILURE");   // "同步订舱品名出错!");

    public static readonly string ALREADYFIELD   = Resource.GetString("ALREADYFIELD");    //The (MAWB status); is //New// already"

    public static readonly string RETRIEVESUCCESS   = Resource.GetString("RETRIEVESUCCESS");
    public static readonly string RETRIEVEFAILURE   = Resource.GetString("RETRIEVEFAILURE");

    public static readonly string FORMATERRORFIELD   = Resource.GetString("FORMATERRORFIELD");    //(Container Number); format error!

    public static readonly string STATUSISNOTNEWORLENDOUT   = Resource.GetString("STATUSISNOTNEWORLENDOUT");      //"The status is not //New// or //lend out//!"
    public static readonly string ALLSPECIALREQUIREMENTMUSTBEFINISHEDFIRST   = Resource.GetString("ALLSPECIALREQUIREMENTMUSTBEFINISHEDFIRST");    //All Special Requirement must be finished first

    public static readonly string CANCELLED   = Resource.GetString("CANCELLED");   //The shipment had been cancelled

    public static readonly string HASNOTBEPRINT   = Resource.GetString("HASNOTBEPRINT");    //The AWB hasn//t be print
    public static readonly string HASNOTBECONFIRM   = Resource.GetString("HASNOTBECONFIRM"); //The space hasn//t be confirm"
    public static readonly string HASNOTBEAPPLYBATCHCHARGES   = Resource.GetString("HASNOTBEAPPLYBATCHCHARGES"); //批量录入的操作费用没有提交

    public static readonly string MAWBNOEMPTYCANOTTOBELOCKED   = Resource.GetString("MAWBNoemptycanottobelocked");  //MAWB No is empty, can't to be locked

    public static readonly string NOTIFYCDS_BOOKINGSURE   = Resource.GetString("NOTIFYCDS_BOOKINGSURE");      //Are you sure to notify Cds_Booking
    public static readonly string NOTIFYWAREHOUSESURE   = Resource.GetString("NOTIFYWAREHOUSESURE");      //Are you sure to notify warehouse
    public static readonly string CANCELMAWBSURE   = Resource.GetString("CANCELMAWB");    //Are you sure to cancel this MAWB
    public static readonly string CANCELBOOKINGSURE   = Resource.GetString("CANCELBOOKINGSURE");   //The Booking will be CANCEL, are you sure
    public static readonly string NEWMAWBSURE   = Resource.GetString("NEWMAWBSURE");      //Are you sure to New this MAWB
    public static readonly string CONVERTBOOKINGTOSHIPMENTSURE   = Resource.GetString("CONVERTBOOKINGTOSHIPMENTSURE");    //The Booking will convert to Shipment, Are you sure
    public static readonly string FINISHREADYGOODSURE   = Resource.GetString("FINISHREADYGOODSURE");      //Goods is ready,Do you want to finish
    public static readonly string FINISHHAWBSURE   = Resource.GetString("FINISHHAWBSURE");    //Are you sure to Finish the HAWB
    public static readonly string FINISHMAWBSURE   = Resource.GetString("FINISHMAWBSURE");    //Are you sure to Finish the MAWB
    public static readonly string FLIGHTHASMAWB   = Resource.GetString("FLIGHTHASMAWB");      //The Flight has MAWB, can't to delete it
    public static readonly string MAWBHASHAWB   = Resource.GetString("MAWBHASHAWB");   //The MAWB has HAWB, can//t to delete it!
    public static readonly string REFRESHSURE   = Resource.GetString("REFRESHSURE");      //Are you sure to Refresh

    public static readonly string SENDMESSAGETOCUSTOMER   = Resource.GetString("SENDMESSAGETOCUSTOMER");      //给对应的客户服务发送信息

    public static readonly string DEATTACHSURE   = Resource.GetString("DEATTACHSURE");    //Are you sure to Deattach the HAWB
    public static readonly string CANCELSHIPMENTSURE   = Resource.GetString("CANCELSHIPMENTSURE");    //Are you sure to cancel the shipment
    public static readonly string DEATTACHHAWBSURE   = Resource.GetString("DEATTACHHAWBSURE");    //Are you sure to Deattach the HAWB
    //public static readonly string NEWMAWBSURE   = Resource.GetString("NEWMAWBSURE");   //Do you want to create a new MAWB
    public static readonly string JOBMODECANNOTCREATEAMAWB   = Resource.GetString("JOBMODECANNOTCREATEAMAWB");    //The Job Mode cannot create a MAWB
    public static readonly string HAWBHAVEMAWB   = Resource.GetString("HAWBHAVEMAWB");    //The HAWB has a MAWB NO
    public static readonly string CLOSESHIPMENTSURE   = Resource.GetString("CLOSESHIPMENTSURE");
    public static readonly string SENDTOSUREFIELD   = Resource.GetString("SENDTOSUREFIELD");   //Send (Confirmation);{0} To (DTTN);{1}

    public static readonly string MAWBISNOTUNIQUE   = Resource.GetString("MAWBISNOTUNIQUE");    //主单号重复

    public static readonly string NOSEARCHCONDITION   = Resource.GetString("NOSEARCHCONDITION");    //主单号重复
    public static readonly string HASNOTBELOCK   = Resource.GetString("HASNOTBELOCK");    //The AWB hasn//t be locked


    public static readonly string FLIGHT_IS_LOCLED   = Resource.GetString("FLIGHT_IS_LOCLED");    //"The flight is locked , please contact flight handler!"
    public static readonly string HAVE_NO_REIGHT   = Resource.GetString("HAVE_NO_REIGHT");    //"You have no right!"
    public static readonly string CHECK_MAWB_CARRIER_BOOKINGAGENT   = Resource.GetString("CHECK_MAWB_CARRIER_BOOKINGAGENT"); //"Please check MAWB no/Carrier/Booking Agent data"
    public static readonly string STRING_HAVE_NOT_BEEN_COMMITED   = Resource.GetString("STRING_HAVE_NOT_BEEN_COMMITED"); //"{0}没有提交操作不能完成！"
    public static readonly string GET_BACK_FROM_CIQ_FAILURE   = Resource.GetString("GET_BACK_FROM_CIQ_FAILURE"); //"Get back from CIQ failure"
    public static readonly string GET_BACK_FROM_CIQ_SUCCESS   = Resource.GetString("GET_BACK_FROM_CIQ_SUCCESS"); //"Get back from CIQ success"
    public static readonly string STRING_CANT_BE_EMPTY   = Resource.GetString("STRING_CANT_BE_EMPTY"); //"{0} can//t be empty"
    public static readonly string UNLOCK_MAWB_NO_TEXT   = Resource.GetString("UNLOCK_MAWB_NO_TEXT"); //"Are you sure to unlock the MAWB No?"
    public static readonly string GET_BACK_TEXT   = Resource.GetString("GET_BACK_TEXT"); //"Are sure to get back from CIQ ?"

    public static readonly string DIFF_2_BOOKING_PGM_ASSIGN   = Resource.GetString("DIFF_2_BOOKING_PGM_ASSIGN"); //"与委托件重尺有差异,是否确认配货完成 ?"
    public static readonly string CW_SPANS_WEIGHT_CLASS   = Resource.GetString("CW_SPANS_WEIGHT_CLASS"); //"计费重量跨靠级点,是否确认配货完成 ?"

    public static readonly string STRING_LOAD_ON_PALLET   = Resource.GetString("STRING_LOAD_ON_PALLET"); //"装在板{0}上"
    public static readonly string CREATE_NEW_PALLET   = Resource.GetString("CREATE_NEW_PALLET"); //"创建新的板号"
    public static readonly string ONLY_CHARGE_NOT_REMOVE   = Resource.GetString("ONLY_CHARGE_NOT_REMOVE"); //"主单有费用，请先手工删除费用记录
    public static readonly string MUST_FIRST_DEATTACH   = Resource.GetString("MUST_FIRST_DEATTACH"); //"请先Deatach，然后进行模式更改！
    public static readonly string NOT_EXIST_SPACE   = Resource.GetString("NOT_EXIST_SPACE"); //"舱位不存在，请重新确认！
    public static readonly string HBLHADSHAREDCHARGE   = Resource.GetString("HBLHADSHAREDCHARGE");  // 工作号有主工作号的手工分摊费用，不能移除！
    public static readonly string MUST_FIRST_DEATTACH_CANCEL   = Resource.GetString("MUST_FIRST_DEATTACH_CANCEL"); //"请先Deatach，然后进行退关操作！
    public static readonly string MUST_CANCEL_MATCH   = Resource.GetString("MUST_CANCEL_MATCH"); //请先取消配货，然后进行退关操作！
    public static readonly string WAREHOUSE_NO_DUPLICATEDFIELD   = Resource.GetString("WAREHOUSE_NO_DUPLICATEDFIELD"); // 委托进仓编号与工作号中的重复！
    public static readonly string NOT_WAREHOUSE_OUT   = Resource.GetString("NOT_WAREHOUSE_OUT"); //本仓货未出库，不能操作完成！
    public static readonly string BELOCK_STATUS   = Resource.GetString("BELOCK_STATUS");  //运单锁定状态
    public static readonly string CUSTOMER_CHARGE_STATUS   = Resource.GetString("CUSTOMER_CHARGE_STATUS"); //报关费用提交
    public static readonly string LAND_CHARGE_STATUS   = Resource.GetString("LAND_CHARGE_STATUS"); //陆运费用提交
    public static readonly string UNION_CHARGE_STATUS   = Resource.GetString("UNION_CHARGE_STATUS"); //联运费用提交
    public static readonly string BATCH_CHARGE_STATUS   = Resource.GetString("BATCH_CHARGE_STATUS"); //批量费用提交
    public static readonly string LOSS_INFO_STATUS   = Resource.GetString("LOSS_INFO_STATUS"); //业务亏损情况
    public static readonly string WAREHOUSE_STATUS   = Resource.GetString("WAREHOUSE_STATUS"); //仓储状态

    }
}
