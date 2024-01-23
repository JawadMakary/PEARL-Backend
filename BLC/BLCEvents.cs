using System;
using System.Linq;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.IO;
using BLC;
namespace BLC
{
public partial class BLC
{

#region Enum_API_Method
public enum Enum_API_Method
{
Get_Client_By_CLIENT_ID,
Get_User_By_Where,
Get_Fees_By_OWNER_ID,
Get_Currency_By_CURRENCY_ID,
Get_Currency_By_OWNER_ID,
Edit_Fees,
Get_Staff_fees_By_OWNER_ID_Adv,
Get_Supplier_fees_By_OWNER_ID_Adv,
Get_Client_fees_By_OWNER_ID_Adv,
Sales_Sum,
Expenses_Sum,
GetGrandProfit,
Edit_Package,
Get_Package_By_OWNER_ID_Adv,
Get_Session_By_OWNER_ID_Adv,
Edit_Session,
Delete_Session,
Get_Fees_By_OWNER_ID_Adv,
Get_Fees_By_CURRENCY_ID,
CheckClientPaymentStatus,
CalculateStaffBalance,
Get_Client_By_OWNER_ID_Adv,
Get_Staff_By_OWNER_ID_Adv,
UP_CHECK_USER_EXISTENCE,
UpdatePassword,
LoginFct,
Edit_Staff,
Edit_Supplier,
Edit_Client,
Get_Bloodtype_By_OWNER_ID,
Get_Supplier_By_OWNER_ID,
Edit_Client_fees,
Edit_Supplier_fees,
Edit_Staff_fees,
Get_Client_fees_By_CLIENT_ID,
Get_Staff_fees_By_STAFF_ID,
Get_Supplier_fees_By_SUPPLIER_ID,
Get_Staff_By_STAFF_ID,
Get_Supplier_By_SUPPLIER_ID,
Edit_Registration,
Get_Registration_By_OWNER_ID,
Get_Registration_By_REGISTRATION_ID
}
#endregion

#region Prepare_BLCInitializer
public BLCInitializer Prepare_BLCInitializer(string i_Ticket, Enum_API_Method i_Enum_API_Method)
{
#region Declaration And Initialization Section.
BLCInitializer oBLCInitializer = new BLCInitializer();
BLC oBLC_Default = new BLC();
string str_CUSTOM_BLC_INIT = string.Empty;
#endregion
#region Body Section.
if (this.OnPreEvent_BLC_Init != null)
{
oBLCInitializer = this.OnPreEvent_BLC_Init(i_Ticket, i_Enum_API_Method);
return oBLCInitializer;
}
else
{
oBLCInitializer.UserID = Convert.ToInt64(oBLC_Default.ResolveTicket(i_Ticket)["USER_ID"]);
oBLCInitializer.OwnerID = Convert.ToInt32(oBLC_Default.ResolveTicket(i_Ticket)["OWNER_ID"]);
oBLCInitializer.ConnectionString = ConfigurationManager.AppSettings["CONN_STR"];
oBLCInitializer.Messages_FilePath = ConfigurationManager.AppSettings["BLC_MESSAGES"];
}
#endregion
#region Return Section.
return oBLCInitializer;
#endregion
}
#endregion

#region General Pre/Post events
public delegate void PreEvent_Handler_General(string i_MethodName);
public delegate void PostEvent_Handler_General(string i_MethodName);
public delegate void PreEvent_Handler_General_Adv(string i_MethodName, string param_stringified);
public event PreEvent_Handler_General OnPreEvent_General;
public event PostEvent_Handler_General OnPostEvent_General;
public event PreEvent_Handler_General_Adv OnPreEvent_General_Adv;
#endregion
#region General Pre/Post BLC_Init
public delegate BLCInitializer PreEvent_Handler_BLC_Init(string i_Ticket, Enum_API_Method i_Enum_API_Method);
public delegate BLCInitializer PostEvent_Handler_BLC_Init(string i_Ticket, Enum_API_Method i_Enum_API_Method);
public event PreEvent_Handler_BLC_Init OnPreEvent_BLC_Init;
public event PostEvent_Handler_BLC_Init OnPostEvent_BLC_Init;
#endregion
public  delegate void PreEvent_Handler_Edit_Method_run(Method_run i_Method_run,Enum_EditMode i_Enum_EditMode);
public  delegate void  PostEvent_Handler_Edit_Method_run(Method_run i_Method_run,Enum_EditMode i_Enum_EditMode);
public event PreEvent_Handler_Edit_Method_run OnPreEvent_Edit_Method_run;
public event PostEvent_Handler_Edit_Method_run OnPostEvent_Edit_Method_run;
}
}
