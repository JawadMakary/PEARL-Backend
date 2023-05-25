using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Configuration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ConfigurationManager = System.Configuration.ConfigurationManager;
using BLC;
[Route("api/[controller]")]
[ApiController]
public partial class DataController : ControllerBase
{
#region Members
#endregion
#region Extract_Ticket
private string Extract_Ticket()
{
#region Declaration And Initialization Section.
string str_Ticket = string.Empty;
#endregion
if(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null)
{
str_Ticket = HttpContext.Request.Query["Ticket"].ToString();
}
#region Return Section.
return str_Ticket;
#endregion
}
#endregion
#region IsValidWebTicket
private bool IsValidWebTicket(string i_Input)
{
#region Declaration And Initialization Section.
bool Is_Valid = false;
BLCInitializer oBLCInitializer = new BLCInitializer();
#endregion
#region Body Section.
BLC.BLC oBLC_Default = new BLC.BLC();
oBLCInitializer.ConnectionString = ConfigurationManager.AppSettings["CONN_STR"];
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
Is_Valid = oBLC.IsValidTicket(i_Input);
}
#endregion
#region Return Section.
return Is_Valid;
#endregion
}
#endregion
#region Edit_Fees
[HttpPost]
[Route("Edit_Fees")]
public Result_Edit_Fees Edit_Fees(Fees i_Fees)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Edit_Fees oResult_Edit_Fees = new Result_Edit_Fees();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
||
(
(HttpContext.Request.Headers["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Headers["Ticket"].ToString() != "")
)
)
{
i_Ticket = string.IsNullOrEmpty(HttpContext.Request.Query["Ticket"])  ? "": HttpContext.Request.Query["Ticket"].ToString();
if (string.IsNullOrEmpty(i_Ticket))
{
i_Ticket = HttpContext.Request.Headers["Ticket"].ToString();
if (string.IsNullOrEmpty(i_Ticket))
{
throw new Exception("Missing Ticket");
}
}
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Edit_Fees);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Monitor_API_Calls();
oBLC.Edit_Fees(i_Fees);
oResult_Edit_Fees.My_Fees = i_Fees;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Edit_Fees.ExceptionMsg = string.Format("Edit_Fees : {0}", ex.Message);
}
else
{
oResult_Edit_Fees.ExceptionMsg = ex.Message;
oResult_Edit_Fees.ExceptionCode = ((BLCException)ex).Code;
}
}
#endregion
#region Return Section
return oResult_Edit_Fees;
#endregion
}
#endregion
#region Edit_Package
[HttpPost]
[Route("Edit_Package")]
public Result_Edit_Package Edit_Package(Package i_Package)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Edit_Package oResult_Edit_Package = new Result_Edit_Package();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
||
(
(HttpContext.Request.Headers["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Headers["Ticket"].ToString() != "")
)
)
{
i_Ticket = string.IsNullOrEmpty(HttpContext.Request.Query["Ticket"])  ? "": HttpContext.Request.Query["Ticket"].ToString();
if (string.IsNullOrEmpty(i_Ticket))
{
i_Ticket = HttpContext.Request.Headers["Ticket"].ToString();
if (string.IsNullOrEmpty(i_Ticket))
{
throw new Exception("Missing Ticket");
}
}
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Edit_Package);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Monitor_API_Calls();
oBLC.Edit_Package(i_Package);
oResult_Edit_Package.My_Package = i_Package;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Edit_Package.ExceptionMsg = string.Format("Edit_Package : {0}", ex.Message);
}
else
{
oResult_Edit_Package.ExceptionMsg = ex.Message;
oResult_Edit_Package.ExceptionCode = ((BLCException)ex).Code;
}
}
#endregion
#region Return Section
return oResult_Edit_Package;
#endregion
}
#endregion
#region Expenses_Sum
[HttpPost]
[Route("Expenses_Sum")]
public Result_Expenses_Sum Expenses_Sum(Params_Expenses_Sum i_Params_Expenses_Sum)
{
#region Declaration And Initialization Section.
Int32 oReturnValue = 0;
string i_Ticket = string.Empty;
Result_Expenses_Sum oResult_Expenses_Sum = new Result_Expenses_Sum();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
||
(
(HttpContext.Request.Headers["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Headers["Ticket"].ToString() != "")
)
)
{
i_Ticket = string.IsNullOrEmpty(HttpContext.Request.Query["Ticket"])  ? "": HttpContext.Request.Query["Ticket"].ToString();
if (string.IsNullOrEmpty(i_Ticket))
{
i_Ticket = HttpContext.Request.Headers["Ticket"].ToString();
if (string.IsNullOrEmpty(i_Ticket))
{
throw new Exception("Missing Ticket");
}
}
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Expenses_Sum);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Monitor_API_Calls();
oReturnValue = oBLC.Expenses_Sum(i_Params_Expenses_Sum);
oResult_Expenses_Sum.My_Result = oReturnValue;
oResult_Expenses_Sum.My_Params_Expenses_Sum = i_Params_Expenses_Sum;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Expenses_Sum.ExceptionMsg = string.Format("Expenses_Sum : {0}", ex.Message);
}
else
{
oResult_Expenses_Sum.ExceptionMsg = ex.Message;
oResult_Expenses_Sum.ExceptionCode = ((BLCException)ex).Code;
}
}
#endregion
#region Return Section
return oResult_Expenses_Sum;
#endregion
}
#endregion
#region Get_Client_By_CLIENT_ID
[HttpPost]
[Route("Get_Client_By_CLIENT_ID")]
public Result_Get_Client_By_CLIENT_ID Get_Client_By_CLIENT_ID(Params_Get_Client_By_CLIENT_ID i_Params_Get_Client_By_CLIENT_ID)
{
#region Declaration And Initialization Section.
Client oReturnValue = new Client();
string i_Ticket = string.Empty;
Result_Get_Client_By_CLIENT_ID oResult_Get_Client_By_CLIENT_ID = new Result_Get_Client_By_CLIENT_ID();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
||
(
(HttpContext.Request.Headers["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Headers["Ticket"].ToString() != "")
)
)
{
i_Ticket = string.IsNullOrEmpty(HttpContext.Request.Query["Ticket"])  ? "": HttpContext.Request.Query["Ticket"].ToString();
if (string.IsNullOrEmpty(i_Ticket))
{
i_Ticket = HttpContext.Request.Headers["Ticket"].ToString();
if (string.IsNullOrEmpty(i_Ticket))
{
throw new Exception("Missing Ticket");
}
}
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Client_By_CLIENT_ID);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Monitor_API_Calls();
oReturnValue = oBLC.Get_Client_By_CLIENT_ID(i_Params_Get_Client_By_CLIENT_ID);
oResult_Get_Client_By_CLIENT_ID.My_Result = oReturnValue;
oResult_Get_Client_By_CLIENT_ID.My_Params_Get_Client_By_CLIENT_ID = i_Params_Get_Client_By_CLIENT_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Client_By_CLIENT_ID.ExceptionMsg = string.Format("Get_Client_By_CLIENT_ID : {0}", ex.Message);
}
else
{
oResult_Get_Client_By_CLIENT_ID.ExceptionMsg = ex.Message;
oResult_Get_Client_By_CLIENT_ID.ExceptionCode = ((BLCException)ex).Code;
}
}
#endregion
#region Return Section
return oResult_Get_Client_By_CLIENT_ID;
#endregion
}
#endregion
#region Get_Client_fees_By_OWNER_ID_Adv
[HttpPost]
[Route("Get_Client_fees_By_OWNER_ID_Adv")]
public Result_Get_Client_fees_By_OWNER_ID_Adv Get_Client_fees_By_OWNER_ID_Adv(Params_Get_Client_fees_By_OWNER_ID i_Params_Get_Client_fees_By_OWNER_ID)
{
#region Declaration And Initialization Section.
List<Client_fees>  oReturnValue = new List<Client_fees> ();
string i_Ticket = string.Empty;
Result_Get_Client_fees_By_OWNER_ID_Adv oResult_Get_Client_fees_By_OWNER_ID_Adv = new Result_Get_Client_fees_By_OWNER_ID_Adv();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
||
(
(HttpContext.Request.Headers["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Headers["Ticket"].ToString() != "")
)
)
{
i_Ticket = string.IsNullOrEmpty(HttpContext.Request.Query["Ticket"])  ? "": HttpContext.Request.Query["Ticket"].ToString();
if (string.IsNullOrEmpty(i_Ticket))
{
i_Ticket = HttpContext.Request.Headers["Ticket"].ToString();
if (string.IsNullOrEmpty(i_Ticket))
{
throw new Exception("Missing Ticket");
}
}
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Client_fees_By_OWNER_ID_Adv);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Monitor_API_Calls();
oReturnValue = oBLC.Get_Client_fees_By_OWNER_ID_Adv(i_Params_Get_Client_fees_By_OWNER_ID);
oResult_Get_Client_fees_By_OWNER_ID_Adv.My_Result = oReturnValue;
oResult_Get_Client_fees_By_OWNER_ID_Adv.My_Params_Get_Client_fees_By_OWNER_ID = i_Params_Get_Client_fees_By_OWNER_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Client_fees_By_OWNER_ID_Adv.ExceptionMsg = string.Format("Get_Client_fees_By_OWNER_ID_Adv : {0}", ex.Message);
}
else
{
oResult_Get_Client_fees_By_OWNER_ID_Adv.ExceptionMsg = ex.Message;
oResult_Get_Client_fees_By_OWNER_ID_Adv.ExceptionCode = ((BLCException)ex).Code;
}
}
#endregion
#region Return Section
return oResult_Get_Client_fees_By_OWNER_ID_Adv;
#endregion
}
#endregion
#region Get_Currency_By_CURRENCY_ID
[HttpPost]
[Route("Get_Currency_By_CURRENCY_ID")]
public Result_Get_Currency_By_CURRENCY_ID Get_Currency_By_CURRENCY_ID(Params_Get_Currency_By_CURRENCY_ID i_Params_Get_Currency_By_CURRENCY_ID)
{
#region Declaration And Initialization Section.
Currency oReturnValue = new Currency();
string i_Ticket = string.Empty;
Result_Get_Currency_By_CURRENCY_ID oResult_Get_Currency_By_CURRENCY_ID = new Result_Get_Currency_By_CURRENCY_ID();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
||
(
(HttpContext.Request.Headers["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Headers["Ticket"].ToString() != "")
)
)
{
i_Ticket = string.IsNullOrEmpty(HttpContext.Request.Query["Ticket"])  ? "": HttpContext.Request.Query["Ticket"].ToString();
if (string.IsNullOrEmpty(i_Ticket))
{
i_Ticket = HttpContext.Request.Headers["Ticket"].ToString();
if (string.IsNullOrEmpty(i_Ticket))
{
throw new Exception("Missing Ticket");
}
}
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Currency_By_CURRENCY_ID);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Monitor_API_Calls();
oReturnValue = oBLC.Get_Currency_By_CURRENCY_ID(i_Params_Get_Currency_By_CURRENCY_ID);
oResult_Get_Currency_By_CURRENCY_ID.My_Result = oReturnValue;
oResult_Get_Currency_By_CURRENCY_ID.My_Params_Get_Currency_By_CURRENCY_ID = i_Params_Get_Currency_By_CURRENCY_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Currency_By_CURRENCY_ID.ExceptionMsg = string.Format("Get_Currency_By_CURRENCY_ID : {0}", ex.Message);
}
else
{
oResult_Get_Currency_By_CURRENCY_ID.ExceptionMsg = ex.Message;
oResult_Get_Currency_By_CURRENCY_ID.ExceptionCode = ((BLCException)ex).Code;
}
}
#endregion
#region Return Section
return oResult_Get_Currency_By_CURRENCY_ID;
#endregion
}
#endregion
#region Get_Fees_By_OWNER_ID
[HttpPost]
[Route("Get_Fees_By_OWNER_ID")]
public Result_Get_Fees_By_OWNER_ID Get_Fees_By_OWNER_ID(Params_Get_Fees_By_OWNER_ID i_Params_Get_Fees_By_OWNER_ID)
{
#region Declaration And Initialization Section.
List<Fees>  oReturnValue = new List<Fees> ();
string i_Ticket = string.Empty;
Result_Get_Fees_By_OWNER_ID oResult_Get_Fees_By_OWNER_ID = new Result_Get_Fees_By_OWNER_ID();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
||
(
(HttpContext.Request.Headers["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Headers["Ticket"].ToString() != "")
)
)
{
i_Ticket = string.IsNullOrEmpty(HttpContext.Request.Query["Ticket"])  ? "": HttpContext.Request.Query["Ticket"].ToString();
if (string.IsNullOrEmpty(i_Ticket))
{
i_Ticket = HttpContext.Request.Headers["Ticket"].ToString();
if (string.IsNullOrEmpty(i_Ticket))
{
throw new Exception("Missing Ticket");
}
}
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Fees_By_OWNER_ID);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Monitor_API_Calls();
oReturnValue = oBLC.Get_Fees_By_OWNER_ID(i_Params_Get_Fees_By_OWNER_ID);
oResult_Get_Fees_By_OWNER_ID.My_Result = oReturnValue;
oResult_Get_Fees_By_OWNER_ID.My_Params_Get_Fees_By_OWNER_ID = i_Params_Get_Fees_By_OWNER_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Fees_By_OWNER_ID.ExceptionMsg = string.Format("Get_Fees_By_OWNER_ID : {0}", ex.Message);
}
else
{
oResult_Get_Fees_By_OWNER_ID.ExceptionMsg = ex.Message;
oResult_Get_Fees_By_OWNER_ID.ExceptionCode = ((BLCException)ex).Code;
}
}
#endregion
#region Return Section
return oResult_Get_Fees_By_OWNER_ID;
#endregion
}
#endregion
#region Get_Package_By_OWNER_ID
[HttpPost]
[Route("Get_Package_By_OWNER_ID")]
public Result_Get_Package_By_OWNER_ID Get_Package_By_OWNER_ID(Params_Get_Package_By_OWNER_ID i_Params_Get_Package_By_OWNER_ID)
{
#region Declaration And Initialization Section.
List<Package>  oReturnValue = new List<Package> ();
string i_Ticket = string.Empty;
Result_Get_Package_By_OWNER_ID oResult_Get_Package_By_OWNER_ID = new Result_Get_Package_By_OWNER_ID();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
||
(
(HttpContext.Request.Headers["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Headers["Ticket"].ToString() != "")
)
)
{
i_Ticket = string.IsNullOrEmpty(HttpContext.Request.Query["Ticket"])  ? "": HttpContext.Request.Query["Ticket"].ToString();
if (string.IsNullOrEmpty(i_Ticket))
{
i_Ticket = HttpContext.Request.Headers["Ticket"].ToString();
if (string.IsNullOrEmpty(i_Ticket))
{
throw new Exception("Missing Ticket");
}
}
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = new BLCInitializer();
oBLCInitializer.UserID           = Convert.ToInt64(oBLC_Default.ResolveTicket(i_Ticket)["USER_ID"]);
oBLCInitializer.OwnerID          = Convert.ToInt32(oBLC_Default.ResolveTicket(i_Ticket)["OWNER_ID"]);
oBLCInitializer.ConnectionString = ConfigurationManager.AppSettings["CONN_STR"];
oBLCInitializer.Messages_FilePath = ConfigurationManager.AppSettings["BLC_MESSAGES"];
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Monitor_API_Calls();
oReturnValue = oBLC.Get_Package_By_OWNER_ID(i_Params_Get_Package_By_OWNER_ID);
oResult_Get_Package_By_OWNER_ID.My_Result = oReturnValue;
oResult_Get_Package_By_OWNER_ID.My_Params_Get_Package_By_OWNER_ID = i_Params_Get_Package_By_OWNER_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Package_By_OWNER_ID.ExceptionMsg = string.Format("Get_Package_By_OWNER_ID : {0}", ex.Message);
}
else
{
oResult_Get_Package_By_OWNER_ID.ExceptionMsg = ex.Message;
oResult_Get_Package_By_OWNER_ID.ExceptionCode = ((BLCException)ex).Code;
}
}
#endregion
#region Return Section
return oResult_Get_Package_By_OWNER_ID;
#endregion
}
#endregion
#region Get_Staff_fees_By_OWNER_ID_Adv
[HttpPost]
[Route("Get_Staff_fees_By_OWNER_ID_Adv")]
public Result_Get_Staff_fees_By_OWNER_ID_Adv Get_Staff_fees_By_OWNER_ID_Adv(Params_Get_Staff_fees_By_OWNER_ID i_Params_Get_Staff_fees_By_OWNER_ID)
{
#region Declaration And Initialization Section.
List<Staff_fees>  oReturnValue = new List<Staff_fees> ();
string i_Ticket = string.Empty;
Result_Get_Staff_fees_By_OWNER_ID_Adv oResult_Get_Staff_fees_By_OWNER_ID_Adv = new Result_Get_Staff_fees_By_OWNER_ID_Adv();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
||
(
(HttpContext.Request.Headers["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Headers["Ticket"].ToString() != "")
)
)
{
i_Ticket = string.IsNullOrEmpty(HttpContext.Request.Query["Ticket"])  ? "": HttpContext.Request.Query["Ticket"].ToString();
if (string.IsNullOrEmpty(i_Ticket))
{
i_Ticket = HttpContext.Request.Headers["Ticket"].ToString();
if (string.IsNullOrEmpty(i_Ticket))
{
throw new Exception("Missing Ticket");
}
}
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Staff_fees_By_OWNER_ID_Adv);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Monitor_API_Calls();
oReturnValue = oBLC.Get_Staff_fees_By_OWNER_ID_Adv(i_Params_Get_Staff_fees_By_OWNER_ID);
oResult_Get_Staff_fees_By_OWNER_ID_Adv.My_Result = oReturnValue;
oResult_Get_Staff_fees_By_OWNER_ID_Adv.My_Params_Get_Staff_fees_By_OWNER_ID = i_Params_Get_Staff_fees_By_OWNER_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Staff_fees_By_OWNER_ID_Adv.ExceptionMsg = string.Format("Get_Staff_fees_By_OWNER_ID_Adv : {0}", ex.Message);
}
else
{
oResult_Get_Staff_fees_By_OWNER_ID_Adv.ExceptionMsg = ex.Message;
oResult_Get_Staff_fees_By_OWNER_ID_Adv.ExceptionCode = ((BLCException)ex).Code;
}
}
#endregion
#region Return Section
return oResult_Get_Staff_fees_By_OWNER_ID_Adv;
#endregion
}
#endregion
#region Get_Supplier_fees_By_OWNER_ID_Adv
[HttpPost]
[Route("Get_Supplier_fees_By_OWNER_ID_Adv")]
public Result_Get_Supplier_fees_By_OWNER_ID_Adv Get_Supplier_fees_By_OWNER_ID_Adv(Params_Get_Supplier_fees_By_OWNER_ID i_Params_Get_Supplier_fees_By_OWNER_ID)
{
#region Declaration And Initialization Section.
List<Supplier_fees>  oReturnValue = new List<Supplier_fees> ();
string i_Ticket = string.Empty;
Result_Get_Supplier_fees_By_OWNER_ID_Adv oResult_Get_Supplier_fees_By_OWNER_ID_Adv = new Result_Get_Supplier_fees_By_OWNER_ID_Adv();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
||
(
(HttpContext.Request.Headers["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Headers["Ticket"].ToString() != "")
)
)
{
i_Ticket = string.IsNullOrEmpty(HttpContext.Request.Query["Ticket"])  ? "": HttpContext.Request.Query["Ticket"].ToString();
if (string.IsNullOrEmpty(i_Ticket))
{
i_Ticket = HttpContext.Request.Headers["Ticket"].ToString();
if (string.IsNullOrEmpty(i_Ticket))
{
throw new Exception("Missing Ticket");
}
}
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Supplier_fees_By_OWNER_ID_Adv);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Monitor_API_Calls();
oReturnValue = oBLC.Get_Supplier_fees_By_OWNER_ID_Adv(i_Params_Get_Supplier_fees_By_OWNER_ID);
oResult_Get_Supplier_fees_By_OWNER_ID_Adv.My_Result = oReturnValue;
oResult_Get_Supplier_fees_By_OWNER_ID_Adv.My_Params_Get_Supplier_fees_By_OWNER_ID = i_Params_Get_Supplier_fees_By_OWNER_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Supplier_fees_By_OWNER_ID_Adv.ExceptionMsg = string.Format("Get_Supplier_fees_By_OWNER_ID_Adv : {0}", ex.Message);
}
else
{
oResult_Get_Supplier_fees_By_OWNER_ID_Adv.ExceptionMsg = ex.Message;
oResult_Get_Supplier_fees_By_OWNER_ID_Adv.ExceptionCode = ((BLCException)ex).Code;
}
}
#endregion
#region Return Section
return oResult_Get_Supplier_fees_By_OWNER_ID_Adv;
#endregion
}
#endregion
#region Get_User_By_Where
[HttpPost]
[Route("Get_User_By_Where")]
public Result_Get_User_By_Where Get_User_By_Where(Params_Get_User_By_Where i_Params_Get_User_By_Where)
{
#region Declaration And Initialization Section.
List<User>  oReturnValue = new List<User> ();
string i_Ticket = string.Empty;
Result_Get_User_By_Where oResult_Get_User_By_Where = new Result_Get_User_By_Where();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
||
(
(HttpContext.Request.Headers["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Headers["Ticket"].ToString() != "")
)
)
{
i_Ticket = string.IsNullOrEmpty(HttpContext.Request.Query["Ticket"])  ? "": HttpContext.Request.Query["Ticket"].ToString();
if (string.IsNullOrEmpty(i_Ticket))
{
i_Ticket = HttpContext.Request.Headers["Ticket"].ToString();
if (string.IsNullOrEmpty(i_Ticket))
{
throw new Exception("Missing Ticket");
}
}
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_User_By_Where);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Monitor_API_Calls();
oReturnValue = oBLC.Get_User_By_Where(i_Params_Get_User_By_Where);
oResult_Get_User_By_Where.My_Result = oReturnValue;
oResult_Get_User_By_Where.My_Params_Get_User_By_Where = i_Params_Get_User_By_Where;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_User_By_Where.ExceptionMsg = string.Format("Get_User_By_Where : {0}", ex.Message);
}
else
{
oResult_Get_User_By_Where.ExceptionMsg = ex.Message;
oResult_Get_User_By_Where.ExceptionCode = ((BLCException)ex).Code;
}
}
#endregion
#region Return Section
return oResult_Get_User_By_Where;
#endregion
}
#endregion
#region GetGrandProfit
[HttpPost]
[Route("GetGrandProfit")]
public Result_GetGrandProfit GetGrandProfit(Params_GetGrandProfit i_Params_GetGrandProfit)
{
#region Declaration And Initialization Section.
Int32 oReturnValue = 0;
string i_Ticket = string.Empty;
Result_GetGrandProfit oResult_GetGrandProfit = new Result_GetGrandProfit();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
||
(
(HttpContext.Request.Headers["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Headers["Ticket"].ToString() != "")
)
)
{
i_Ticket = string.IsNullOrEmpty(HttpContext.Request.Query["Ticket"])  ? "": HttpContext.Request.Query["Ticket"].ToString();
if (string.IsNullOrEmpty(i_Ticket))
{
i_Ticket = HttpContext.Request.Headers["Ticket"].ToString();
if (string.IsNullOrEmpty(i_Ticket))
{
throw new Exception("Missing Ticket");
}
}
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.GetGrandProfit);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Monitor_API_Calls();
oReturnValue = oBLC.GetGrandProfit(i_Params_GetGrandProfit);
oResult_GetGrandProfit.My_Result = oReturnValue;
oResult_GetGrandProfit.My_Params_GetGrandProfit = i_Params_GetGrandProfit;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_GetGrandProfit.ExceptionMsg = string.Format("GetGrandProfit : {0}", ex.Message);
}
else
{
oResult_GetGrandProfit.ExceptionMsg = ex.Message;
oResult_GetGrandProfit.ExceptionCode = ((BLCException)ex).Code;
}
}
#endregion
#region Return Section
return oResult_GetGrandProfit;
#endregion
}
#endregion
#region Sales_Sum
[HttpPost]
[Route("Sales_Sum")]
public Result_Sales_Sum Sales_Sum(Params_Sales_Sum i_Params_Sales_Sum)
{
#region Declaration And Initialization Section.
Int32 oReturnValue = 0;
string i_Ticket = string.Empty;
Result_Sales_Sum oResult_Sales_Sum = new Result_Sales_Sum();
#endregion
#region Body Section.
try
{

// Ticket Checking
//-------------------
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] != null)
{
if (ConfigurationManager.AppSettings["ENABLE_TICKET"] == "1")
{
if
(
(
(HttpContext.Request.Query["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Query["Ticket"].ToString() != "")
)
||
(
(HttpContext.Request.Headers["Ticket"].FirstOrDefault() != null) &&
(HttpContext.Request.Headers["Ticket"].ToString() != "")
)
)
{
i_Ticket = string.IsNullOrEmpty(HttpContext.Request.Query["Ticket"])  ? "": HttpContext.Request.Query["Ticket"].ToString();
if (string.IsNullOrEmpty(i_Ticket))
{
i_Ticket = HttpContext.Request.Headers["Ticket"].ToString();
if (string.IsNullOrEmpty(i_Ticket))
{
throw new Exception("Missing Ticket");
}
}
}
else
{
throw new Exception("Invalid Ticket");
}
}
}
//-------------------

BLC.BLC oBLC_Default = new BLC.BLC();
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Sales_Sum);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Monitor_API_Calls();
oReturnValue = oBLC.Sales_Sum(i_Params_Sales_Sum);
oResult_Sales_Sum.My_Result = oReturnValue;
oResult_Sales_Sum.My_Params_Sales_Sum = i_Params_Sales_Sum;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Sales_Sum.ExceptionMsg = string.Format("Sales_Sum : {0}", ex.Message);
}
else
{
oResult_Sales_Sum.ExceptionMsg = ex.Message;
oResult_Sales_Sum.ExceptionCode = ((BLCException)ex).Code;
}
}
#endregion
#region Return Section
return oResult_Sales_Sum;
#endregion
}
#endregion
}

#region Action_Result
public partial class Action_Result
{
#region Properties.
public string ExceptionCode { get; set; }
public string ExceptionMsg { get; set; }
#endregion
#region Constructor
public Action_Result()
{
#region Declaration And Initialization Section.
#endregion
#region Body Section.
this.ExceptionMsg = string.Empty;
#endregion
}
#endregion
}
#endregion
#region Result_Edit_Fees
public partial class Result_Edit_Fees : Action_Result
{
#region Properties.
public Fees My_Fees { get; set; }
#endregion
}
#endregion
#region Result_Edit_Package
public partial class Result_Edit_Package : Action_Result
{
#region Properties.
public Package My_Package { get; set; }
#endregion
}
#endregion
#region Result_Expenses_Sum
public partial class Result_Expenses_Sum : Action_Result
{
#region Properties.
public Int32 My_Result { get; set; }
public Params_Expenses_Sum My_Params_Expenses_Sum { get; set; }
#endregion
}
#endregion
#region Result_Get_Client_By_CLIENT_ID
public partial class Result_Get_Client_By_CLIENT_ID : Action_Result
{
#region Properties.
public Client My_Result { get; set; }
public Params_Get_Client_By_CLIENT_ID My_Params_Get_Client_By_CLIENT_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Client_fees_By_OWNER_ID_Adv
public partial class Result_Get_Client_fees_By_OWNER_ID_Adv : Action_Result
{
#region Properties.
public List<Client_fees>  My_Result { get; set; }
public Params_Get_Client_fees_By_OWNER_ID My_Params_Get_Client_fees_By_OWNER_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Currency_By_CURRENCY_ID
public partial class Result_Get_Currency_By_CURRENCY_ID : Action_Result
{
#region Properties.
public Currency My_Result { get; set; }
public Params_Get_Currency_By_CURRENCY_ID My_Params_Get_Currency_By_CURRENCY_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Fees_By_OWNER_ID
public partial class Result_Get_Fees_By_OWNER_ID : Action_Result
{
#region Properties.
public List<Fees>  My_Result { get; set; }
public Params_Get_Fees_By_OWNER_ID My_Params_Get_Fees_By_OWNER_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Package_By_OWNER_ID
public partial class Result_Get_Package_By_OWNER_ID : Action_Result
{
#region Properties.
public List<Package>  My_Result { get; set; }
public Params_Get_Package_By_OWNER_ID My_Params_Get_Package_By_OWNER_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Staff_fees_By_OWNER_ID_Adv
public partial class Result_Get_Staff_fees_By_OWNER_ID_Adv : Action_Result
{
#region Properties.
public List<Staff_fees>  My_Result { get; set; }
public Params_Get_Staff_fees_By_OWNER_ID My_Params_Get_Staff_fees_By_OWNER_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Supplier_fees_By_OWNER_ID_Adv
public partial class Result_Get_Supplier_fees_By_OWNER_ID_Adv : Action_Result
{
#region Properties.
public List<Supplier_fees>  My_Result { get; set; }
public Params_Get_Supplier_fees_By_OWNER_ID My_Params_Get_Supplier_fees_By_OWNER_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_User_By_Where
public partial class Result_Get_User_By_Where : Action_Result
{
#region Properties.
public List<User>  My_Result { get; set; }
public Params_Get_User_By_Where My_Params_Get_User_By_Where { get; set; }
#endregion
}
#endregion
#region Result_GetGrandProfit
public partial class Result_GetGrandProfit : Action_Result
{
#region Properties.
public Int32 My_Result { get; set; }
public Params_GetGrandProfit My_Params_GetGrandProfit { get; set; }
#endregion
}
#endregion
#region Result_Sales_Sum
public partial class Result_Sales_Sum : Action_Result
{
#region Properties.
public Int32 My_Result { get; set; }
public Params_Sales_Sum My_Params_Sales_Sum { get; set; }
#endregion
}
#endregion
