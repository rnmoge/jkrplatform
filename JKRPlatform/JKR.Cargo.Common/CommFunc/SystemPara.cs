using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JKR.GUI.LogixConnector;
using System.Data;

namespace JKR.Cargo.Common.CommFunc
{
    public enum ParaType
    {
        PARA_ACC_ACCOUNTS_CAN_CHARGES = 0x17d6,
        PARA_ACC_ALERT_BILL_EXPIRE = 0x1774,
        PARA_ACC_ALERT_BILL_NOT_APPLY = 0x1773,
        PARA_ACC_ALERT_BILL_NOT_CLEAR = 0x1772,
        PARA_ACC_ALERT_NO_DEBIT = 0x1771,
        PARA_ACC_AUTOGEN_INTERNAL_CHARGES = 0x1b09,
        PARA_ACC_BANK_AMOUNT_LIMIT = 0x1966,
        PARA_ACC_BANK_SLIP_CHECK_DEBITCODE = 0x17c1,
        PARA_ACC_CHARGE_AI_ROUND = 0x17d7,
        PARA_ACC_CHARGES_CLASS_MODE = 0x17d9,
        PARA_ACC_CHARGES_MODIFIABLE_BEFOREINTERNAL = 0x1afd,
        PARA_ACC_CHARGES_RETURN_MODE = 0x17da,
        PARA_ACC_CLOSE_GENERATE_PROFIT_JOB = 0x1b00,
        PARA_ACC_CLOSE_INTERNAL_CHECK = 0x1af5,
        PARA_ACC_DEBIT_CAN_MODIFY_AFTER_PRINT = 0x1aff,
        PARA_ACC_DEBIT_MUST_SAME_CURR = 0x1afe,
        PARA_ACC_DECIMAL_INVOICE = 0x1965,
        PARA_ACC_DEFAULT_VOUCHER_TYPE = 0x1b07,
        PARA_ACC_GEN_BILLING = 0x1af7,
        PARA_ACC_INVOICE_EDITABLE = 0x1b03,
        PARA_ACC_INVOICE_REMARK = 0x17dc,
        PARA_ACC_INVOICE_SELECTAGENTCODE = 0x1bc6,
        PARA_ACC_INVOICE_TYPE_HANWE_CUSTOMER = 0x1b01,
        PARA_ACC_MANUAL_UPDATE_JOBNO = 0x17db,
        PARA_ACC_MULTI_ACCOUNT_TAX = 0x1b12,
        PARA_ACC_MULTI_ACCOUNTS_SETTLEMENT = 0x1b16,
        PARA_ACC_NEED_APPLYTOBILLING = 0x1afc,
        PARA_ACC_NEED_CHECKED = 0x1b15,
        PARA_ACC_NOVIP_CUSTOMER_FEE_DATE = 0x1afa,
        PARA_ACC_PAYER_CONTROL = 0x1b13,
        PARA_ACC_RATE_DEFULTE = 0x1b06,
        PARA_ACC_RATE_JOB = 0x1b05,
        PARA_ACC_SEND_INFORMATION = 0x1b14,
        PARA_ACC_SETTLE_FLOW = 0x1afb,
        PARA_ACC_SETTLE_INTERNAL_CHECK = 0x1af6,
        PARA_ACC_SETTLE_ONEORMORE = 0x1b0a,
        PARA_ACC_SIMPLE_EXCHANGE = 0x17d5,
        PARA_ACC_TAX_INVOICE_ALLOT_CHECKED = 0x1b0c,
        PARA_ACC_TAX_INVOICE_FEE_BILLED = 0x1b04,
        PARA_ACC_TAX_INVOICE_FEE_CHECKED = 0x1af8,
        PARA_ACC_TAXINVOICE_MUST_SAME_CURR = 0x1b02,
        PARA_ACC_TAXINVOICE_NO_EXIST = 0x17d8,
        PARA_ACC_VIEWSUBCOMPANYCHARGES = 0x1b0f,
        PARA_ACC_ZERO_AMOUNT = 0x1af9,
        PARA_ADMIN_DEBIT_CREADIT_NO_CONTROL = 0x1b59,
        PARA_AE_ALERT_BL_CONFIRM = 0x3ec,
        PARA_AE_ALERT_DOCS_READY = 0x3ea,
        PARA_AE_ALERT_GOODS_READY = 0x3eb,
        PARA_AE_ALERT_MAWB_EXPIRED = 0x3f0,
        PARA_AE_ALERT_PREBOOKING_EXPIRE = 0x3e9,
        PARA_AE_ALERT_SPACE_CONFIRM = 0x3ef,
        PARA_AE_ALERT_TO_ACCOUNT = 0x3ee,
        PARA_AE_ALERT_TRANS = 0x3ed,
        PARA_AE_BOOKING_NECESSARY = 0x76e,
        PARA_AE_CUSTOMS = 0x452,
        PARA_AE_DECIMAL_DIFFPERCENT = 0x5e0,
        PARA_AE_DECIMAL_MEASUREMENT = 0x5dd,
        PARA_AE_DECIMAL_TRUNCVOLWEIGHT = 0x5e1,
        PARA_AE_DECIMAL_VOLWEIGHT = 0x5df,
        PARA_AE_DECIMAL_WEIGHT = 0x5de,
        PARA_AE_FINISH_CHECK = 0x779,
        PARA_AE_GENERATE_JOBNO = 0x76f,
        PARA_AE_GOODS_DIMENSTION_FORMAT = 0x771,
        PARA_AE_HOUSE_EQUALS_JOBNO = 0x772,
        PARA_AE_HOUSENO_AUTO_GENERATE = 0x773,
        PARA_AE_INTER_TYPE_NECESSARY = 0x44d,
        PARA_AE_OP_CHANGEABLE = 0x450,
        PARA_AE_OP_OFFICE = 0x44e,
        PARA_AE_SALES_CHANGEABLE = 0x44f,
        PARA_AE_WAREHOUSE = 0x451,
        PARA_AI_ALERT_GOODS_NOT_RETURN = 0x7d2,
        PARA_AI_ALERT_PREALERT = 0x7d1,
        PARA_AI_ATA_DEFAULT = 0x7d3,
        PARA_AI_BOOKING_NO_MODE = 0xb59,
        PARA_AI_CW_DIFFENCE = 0x9c5,
        PARA_AI_FINISH_CHECK = 0xb61,
        PARA_AI_GENERATE_JOBNO = 0xb57,
        PARA_AI_HOUSENO_PAD = 0x9c6,
        PARA_AI_INTER_TYPE_NECESSARY = 0x834,
        PARA_AI_REFNO_AUTOGEN = 0x837,
        PARA_AI_RELEASE_CUSTOMS = 0x835,
        PARA_AI_RELEASE_TWICE = 0x836,
        PARA_AI_WAREHOUSE_NECESSARY = 0xb58,
        PARA_ALTER_CLEAR_DATE = 0x1bc0,
        PARA_ALTER_INVOICE_DATE = 0x1bc1,
        PARA_AUTO_CACULATE_OVERAGENT_INVOICE = 0x1b0d,
        PARA_CHARGE_ADVANCED_AP_EDIT = 0x1b0e,
        PARA_CHECK_ACCOUNT_INFORMATION = 0x1bc7,
        PARA_CHECK_BY_OPOFFICE = 0x1b10,
        PARA_CLOSINGDATE_CHANGEBY_ETD = 0x1bc4,
        PARA_CUSTOMER_SERVICE = 0x1bbe,
        PARA_DOCUMENT_GEN_TIME = 0x1b08,
        PARA_HAWB_OPERATION_FINISH = 0x1bc8,
        PARA_INTER_TYPE_INPUT = 0x1bc3,
        PARA_INVOICE_BY_JOBNO = 0x1b11,
        PARA_LOCAL_CUSTOMS = 0x13ed,
        PARA_LOCAL_CUSTOMS_CHARGES_APPLAY_STATUS = 0x13ef,
        PARA_LOCAL_DOMESTIC = 0x13ee,
        PARA_LOCAL_GENERATE_WAREHOUSE_IN_NO = 0x1451,
        PARA_LOCAL_GENERATE_WAREHOUSE_OUT_NO = 0x14b5,
        PARA_MAWB_CHECK_BL_BEFORE_FINISH = 0x1bc9,
        PARA_OPERATION_FINISH_MUSTINPUT_AE = 0x777,
        PARA_OPERATION_FINISH_MUSTINPUT_AI = 0xb5f,
        PARA_OPERATION_FINISH_MUSTINPUT_SE = 0xf47,
        PARA_OPERATION_FINISH_MUSTINPUT_SI = 0x132f,
        PARA_SD_FINISH_JOB = 0x1331,
        PARA_SE_BILL_CHECK = 0xc82,
        PARA_SE_BOOKINGAGENT_NECESSARY = 0xf45,
        PARA_SE_CONTAINER_NO_EXPRESS = 0xc1e,
        PARA_SE_CONTAINER_NUM_EXPRESS = 0xc1d,
        PARA_SE_CONTAINER_SUM_EXPRESS = 0xc20,
        PARA_SE_DEFAULT_ISSUE_NUM = 0xc23,
        PARA_SE_DEFAULT_ISSUE_PLACE = 0xc22,
        PARA_SE_EDIT_SHIPMENT_TRACING_BY = 0xc85,
        PARA_SE_FCL_HBL = 0xc83,
        PARA_SE_FINISH_CHECK = 0xf49,
        PARA_SE_GENERATE_JOBNO = 0xc7e,
        PARA_SE_HBLNO_EQUALS_MBLNO = 0xf4a,
        PARA_SE_HOUSE_EQUALS_JOBNO = 0xf42,
        PARA_SE_HOUSENO_AUTO_GENERATE = 0xf46,
        PARA_SE_INTER_TYPE_NECESSARY = 0xc24,
        PARA_SE_INVOICE_NEEDED = 0xf43,
        PARA_SE_MBL_EQUALS_SO = 0xc21,
        PARA_SE_OP_CHANGEABLE = 0xc27,
        PARA_SE_OP_OFFICE = 0xc25,
        PARA_SE_RELEASE_BILL_MODE = 0xc84,
        PARA_SE_SALES_CHANGEABLE = 0xc26,
        PARA_SE_SO_NO_ENABLE = 0xc28,
        PARA_SE_SYNC_CONTAINER = 0xc81,
        PARA_SE_TOTAL_GOODS_EXPRESS = 0xc1f,
        PARA_SE_VESSEL_MODIFYABLE = 0xf44,
        PARA_SE_WAREHOUSE_IN_NO = 0xf48,
        PARA_SET_CHARGES_OFFICE = 0x1bc2,
        PARA_SI_CONTAINER_NUM_INPUT = 0x1330,
        PARA_SI_FINISH_CHECK = 0x1332,
        PARA_SI_GENERATE_JOBNO = 0x1327,
        PARA_USE_INTERFINISH = 0x1bbf,
        PARA_VIEW_CHARGE_VALIDATION_UI = 0x10e6f
    }

    public class SystemPara
    {
        public static object GetSysPara(UIProxy uip, ParaType para_type)
        {
            DataTable dt = UIProxy.m_LocalDataSet.Tables["D_SYS_PARA"];
            string para_code = string.Empty;
            para_code = para_type.GetHashCode().ToString();
            string sResult, sDataType;
            DataRow[] dr = dt.Select("COMPANY_CODE='" + UIProxy.m_CurrentUserInformation.OfficeCode + "' AND PARA_CODE='" + para_code + "'");

            if (dr == null)
            {
                dr = dt.Select(" PARA_CODE='" + para_code + "'");
                if (dr.Length != 0)
                {
                    sDataType = dr[0]["DATA_TYPE"].ToString();
                    if (dr[0]["PARA_VALUE"].ToString() == "*")
                    {
                        sResult = dr[0]["DEFAULT_VALUE"].ToString();
                    }
                    else
                    {
                        sResult = dr[0]["PARA_VALUE"].ToString();
                    }

                }
                else
                {
                    sDataType = "C";
                    sResult = "";
                }
            }
            else
            {
                if (dr.Length != 0)
                {
                    sDataType = dr[0]["DATA_TYPE"].ToString();
                    if (dr[0]["PARA_VALUE"].ToString() == "*")
                    {
                        sResult = dr[0]["DEFAULT_VALUE"].ToString();
                    }
                    else
                    {
                        sResult = dr[0]["PARA_VALUE"].ToString();
                    }
                }
                else
                {
                    dr = dt.Select(" PARA_CODE='" + para_code + "'");
                    if (dr.Length != 0)
                    {
                        sDataType=dr[0]["DATA_TYPE"].ToString();
                        if(dr[0]["PARA_VALUE"].ToString()=="*")
                        {
                            sResult=dr[0]["DEFAULT_VALUE"].ToString();
                        }
                        else
                        {
                            sResult = dr[0]["PARA_VALUE"].ToString();
                        }
                    }
                    else
                    {
                        sDataType = "C";
                        sResult = "";
                    }
                }
            }

            switch (sDataType)
            {
                case"B":
                    if (sResult == "TRUE")
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case "I":
                    try
                    {
                        return Convert.ToInt32(sResult);
                    }
                    catch (Exception ex)
                    {
                        return 0;
                    }
                case"N":
                    try
                    {
                        return Convert.ToDouble(sResult);
                    }
                    catch (Exception ex)
                    {
                        return 0;
                    }
                default:
                    return sResult;
            }

        }


    }
}
