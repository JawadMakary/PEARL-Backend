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
#region CalculateStaffBalance
[HttpPost]
[Route("CalculateStaffBalance")]
public Result_CalculateStaffBalance CalculateStaffBalance(Params_CalculateStaffBalance i_Params_CalculateStaffBalance)
{
#region Declaration And Initialization Section.
Int32 oReturnValue = 0;
string i_Ticket = string.Empty;
Result_CalculateStaffBalance oResult_CalculateStaffBalance = new Result_CalculateStaffBalance();
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
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.CalculateStaffBalance);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Monitor_API_Calls();
oReturnValue = oBLC.CalculateStaffBalance(i_Params_CalculateStaffBalance);
oResult_CalculateStaffBalance.My_Result = oReturnValue;
oResult_CalculateStaffBalance.My_Params_CalculateStaffBalance = i_Params_CalculateStaffBalance;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_CalculateStaffBalance.ExceptionMsg = string.Format("CalculateStaffBalance : {0}", ex.Message);
}
else
{
oResult_CalculateStaffBalance.ExceptionMsg = ex.Message;
oResult_CalculateStaffBalance.ExceptionCode = ((BLCException)ex).Code;
}
}
#endregion
#region Return Section
return oResult_CalculateStaffBalance;
#endregion
}
#endregion
#region CheckClientPaymentStatus
[HttpPost]
[Route("CheckClientPaymentStatus")]
public Result_CheckClientPaymentStatus CheckClientPaymentStatus(Params_CheckClientPaymentStatus i_Params_CheckClientPaymentStatus)
{
#region Declaration And Initialization Section.
Int32 oReturnValue = 0;
string i_Ticket = string.Empty;
Result_CheckClientPaymentStatus oResult_CheckClientPaymentStatus = new Result_CheckClientPaymentStatus();
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
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.CheckClientPaymentStatus);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Monitor_API_Calls();
oReturnValue = oBLC.CheckClientPaymentStatus(i_Params_CheckClientPaymentStatus);
oResult_CheckClientPaymentStatus.My_Result = oReturnValue;
oResult_CheckClientPaymentStatus.My_Params_CheckClientPaymentStatus = i_Params_CheckClientPaymentStatus;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_CheckClientPaymentStatus.ExceptionMsg = string.Format("CheckClientPaymentStatus : {0}", ex.Message);
}
else
{
oResult_CheckClientPaymentStatus.ExceptionMsg = ex.Message;
oResult_CheckClientPaymentStatus.ExceptionCode = ((BLCException)ex).Code;
}
}
#endregion
#region Return Section
return oResult_CheckClientPaymentStatus;
#endregion
}
#endregion
#region Delete_Session
[HttpPost]
[Route("Delete_Session")]
public Result_Delete_Session Delete_Session(Params_Delete_Session i_Params_Delete_Session)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Delete_Session oResult_Delete_Session = new Result_Delete_Session();
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
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Delete_Session);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Monitor_API_Calls();
oBLC.Delete_Session(i_Params_Delete_Session);
oResult_Delete_Session.My_Params_Delete_Session = i_Params_Delete_Session;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Delete_Session.ExceptionMsg = string.Format("Delete_Session : {0}", ex.Message);
}
else
{
oResult_Delete_Session.ExceptionMsg = ex.Message;
oResult_Delete_Session.ExceptionCode = ((BLCException)ex).Code;
}
}
#endregion
#region Return Section
return oResult_Delete_Session;
#endregion
}
#endregion
#region Edit_Client
[HttpPost]
[Route("Edit_Client")]
public Result_Edit_Client Edit_Client(Client i_Client)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Edit_Client oResult_Edit_Client = new Result_Edit_Client();
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
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Edit_Client);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Monitor_API_Calls();
oBLC.Edit_Client(i_Client);
oResult_Edit_Client.My_Client = i_Client;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Edit_Client.ExceptionMsg = string.Format("Edit_Client : {0}", ex.Message);
}
else
{
oResult_Edit_Client.ExceptionMsg = ex.Message;
oResult_Edit_Client.ExceptionCode = ((BLCException)ex).Code;
}
}
#endregion
#region Return Section
return oResult_Edit_Client;
#endregion
}
#endregion
#region Edit_Client_fees
[HttpPost]
[Route("Edit_Client_fees")]
public Result_Edit_Client_fees Edit_Client_fees(Client_fees i_Client_fees)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Edit_Client_fees oResult_Edit_Client_fees = new Result_Edit_Client_fees();
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
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Edit_Client_fees);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Monitor_API_Calls();
oBLC.Edit_Client_fees(i_Client_fees);
oResult_Edit_Client_fees.My_Client_fees = i_Client_fees;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Edit_Client_fees.ExceptionMsg = string.Format("Edit_Client_fees : {0}", ex.Message);
}
else
{
oResult_Edit_Client_fees.ExceptionMsg = ex.Message;
oResult_Edit_Client_fees.ExceptionCode = ((BLCException)ex).Code;
}
}
#endregion
#region Return Section
return oResult_Edit_Client_fees;
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
#region Edit_Session
[HttpPost]
[Route("Edit_Session")]
public Result_Edit_Session Edit_Session(Session i_Session)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Edit_Session oResult_Edit_Session = new Result_Edit_Session();
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
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Edit_Session);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Monitor_API_Calls();
oBLC.Edit_Session(i_Session);
oResult_Edit_Session.My_Session = i_Session;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Edit_Session.ExceptionMsg = string.Format("Edit_Session : {0}", ex.Message);
}
else
{
oResult_Edit_Session.ExceptionMsg = ex.Message;
oResult_Edit_Session.ExceptionCode = ((BLCException)ex).Code;
}
}
#endregion
#region Return Section
return oResult_Edit_Session;
#endregion
}
#endregion
#region Edit_Staff
[HttpPost]
[Route("Edit_Staff")]
public Result_Edit_Staff Edit_Staff(Staff i_Staff)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Edit_Staff oResult_Edit_Staff = new Result_Edit_Staff();
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
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Edit_Staff);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Monitor_API_Calls();
oBLC.Edit_Staff(i_Staff);
oResult_Edit_Staff.My_Staff = i_Staff;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Edit_Staff.ExceptionMsg = string.Format("Edit_Staff : {0}", ex.Message);
}
else
{
oResult_Edit_Staff.ExceptionMsg = ex.Message;
oResult_Edit_Staff.ExceptionCode = ((BLCException)ex).Code;
}
}
#endregion
#region Return Section
return oResult_Edit_Staff;
#endregion
}
#endregion
#region Edit_Staff_fees
[HttpPost]
[Route("Edit_Staff_fees")]
public Result_Edit_Staff_fees Edit_Staff_fees(Staff_fees i_Staff_fees)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Edit_Staff_fees oResult_Edit_Staff_fees = new Result_Edit_Staff_fees();
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
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Edit_Staff_fees);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Monitor_API_Calls();
oBLC.Edit_Staff_fees(i_Staff_fees);
oResult_Edit_Staff_fees.My_Staff_fees = i_Staff_fees;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Edit_Staff_fees.ExceptionMsg = string.Format("Edit_Staff_fees : {0}", ex.Message);
}
else
{
oResult_Edit_Staff_fees.ExceptionMsg = ex.Message;
oResult_Edit_Staff_fees.ExceptionCode = ((BLCException)ex).Code;
}
}
#endregion
#region Return Section
return oResult_Edit_Staff_fees;
#endregion
}
#endregion
#region Edit_Supplier
[HttpPost]
[Route("Edit_Supplier")]
public Result_Edit_Supplier Edit_Supplier(Supplier i_Supplier)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Edit_Supplier oResult_Edit_Supplier = new Result_Edit_Supplier();
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
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Edit_Supplier);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Monitor_API_Calls();
oBLC.Edit_Supplier(i_Supplier);
oResult_Edit_Supplier.My_Supplier = i_Supplier;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Edit_Supplier.ExceptionMsg = string.Format("Edit_Supplier : {0}", ex.Message);
}
else
{
oResult_Edit_Supplier.ExceptionMsg = ex.Message;
oResult_Edit_Supplier.ExceptionCode = ((BLCException)ex).Code;
}
}
#endregion
#region Return Section
return oResult_Edit_Supplier;
#endregion
}
#endregion
#region Edit_Supplier_fees
[HttpPost]
[Route("Edit_Supplier_fees")]
public Result_Edit_Supplier_fees Edit_Supplier_fees(Supplier_fees i_Supplier_fees)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_Edit_Supplier_fees oResult_Edit_Supplier_fees = new Result_Edit_Supplier_fees();
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
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Edit_Supplier_fees);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Monitor_API_Calls();
oBLC.Edit_Supplier_fees(i_Supplier_fees);
oResult_Edit_Supplier_fees.My_Supplier_fees = i_Supplier_fees;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Edit_Supplier_fees.ExceptionMsg = string.Format("Edit_Supplier_fees : {0}", ex.Message);
}
else
{
oResult_Edit_Supplier_fees.ExceptionMsg = ex.Message;
oResult_Edit_Supplier_fees.ExceptionCode = ((BLCException)ex).Code;
}
}
#endregion
#region Return Section
return oResult_Edit_Supplier_fees;
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
#region Get_Bloodtype_By_OWNER_ID
[HttpPost]
[Route("Get_Bloodtype_By_OWNER_ID")]
public Result_Get_Bloodtype_By_OWNER_ID Get_Bloodtype_By_OWNER_ID(Params_Get_Bloodtype_By_OWNER_ID i_Params_Get_Bloodtype_By_OWNER_ID)
{
#region Declaration And Initialization Section.
List<Bloodtype>  oReturnValue = new List<Bloodtype> ();
string i_Ticket = string.Empty;
Result_Get_Bloodtype_By_OWNER_ID oResult_Get_Bloodtype_By_OWNER_ID = new Result_Get_Bloodtype_By_OWNER_ID();
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
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Bloodtype_By_OWNER_ID);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Monitor_API_Calls();
oReturnValue = oBLC.Get_Bloodtype_By_OWNER_ID(i_Params_Get_Bloodtype_By_OWNER_ID);
oResult_Get_Bloodtype_By_OWNER_ID.My_Result = oReturnValue;
oResult_Get_Bloodtype_By_OWNER_ID.My_Params_Get_Bloodtype_By_OWNER_ID = i_Params_Get_Bloodtype_By_OWNER_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Bloodtype_By_OWNER_ID.ExceptionMsg = string.Format("Get_Bloodtype_By_OWNER_ID : {0}", ex.Message);
}
else
{
oResult_Get_Bloodtype_By_OWNER_ID.ExceptionMsg = ex.Message;
oResult_Get_Bloodtype_By_OWNER_ID.ExceptionCode = ((BLCException)ex).Code;
}
}
#endregion
#region Return Section
return oResult_Get_Bloodtype_By_OWNER_ID;
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
#region Get_Client_By_OWNER_ID_Adv
[HttpPost]
[Route("Get_Client_By_OWNER_ID_Adv")]
public Result_Get_Client_By_OWNER_ID_Adv Get_Client_By_OWNER_ID_Adv(Params_Get_Client_By_OWNER_ID i_Params_Get_Client_By_OWNER_ID)
{
#region Declaration And Initialization Section.
List<Client>  oReturnValue = new List<Client> ();
string i_Ticket = string.Empty;
Result_Get_Client_By_OWNER_ID_Adv oResult_Get_Client_By_OWNER_ID_Adv = new Result_Get_Client_By_OWNER_ID_Adv();
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
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Client_By_OWNER_ID_Adv);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Monitor_API_Calls();
oReturnValue = oBLC.Get_Client_By_OWNER_ID_Adv(i_Params_Get_Client_By_OWNER_ID);
oResult_Get_Client_By_OWNER_ID_Adv.My_Result = oReturnValue;
oResult_Get_Client_By_OWNER_ID_Adv.My_Params_Get_Client_By_OWNER_ID = i_Params_Get_Client_By_OWNER_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Client_By_OWNER_ID_Adv.ExceptionMsg = string.Format("Get_Client_By_OWNER_ID_Adv : {0}", ex.Message);
}
else
{
oResult_Get_Client_By_OWNER_ID_Adv.ExceptionMsg = ex.Message;
oResult_Get_Client_By_OWNER_ID_Adv.ExceptionCode = ((BLCException)ex).Code;
}
}
#endregion
#region Return Section
return oResult_Get_Client_By_OWNER_ID_Adv;
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
#region Get_Currency_By_OWNER_ID
[HttpPost]
[Route("Get_Currency_By_OWNER_ID")]
public Result_Get_Currency_By_OWNER_ID Get_Currency_By_OWNER_ID(Params_Get_Currency_By_OWNER_ID i_Params_Get_Currency_By_OWNER_ID)
{
#region Declaration And Initialization Section.
List<Currency>  oReturnValue = new List<Currency> ();
string i_Ticket = string.Empty;
Result_Get_Currency_By_OWNER_ID oResult_Get_Currency_By_OWNER_ID = new Result_Get_Currency_By_OWNER_ID();
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
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Currency_By_OWNER_ID);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Monitor_API_Calls();
oReturnValue = oBLC.Get_Currency_By_OWNER_ID(i_Params_Get_Currency_By_OWNER_ID);
oResult_Get_Currency_By_OWNER_ID.My_Result = oReturnValue;
oResult_Get_Currency_By_OWNER_ID.My_Params_Get_Currency_By_OWNER_ID = i_Params_Get_Currency_By_OWNER_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Currency_By_OWNER_ID.ExceptionMsg = string.Format("Get_Currency_By_OWNER_ID : {0}", ex.Message);
}
else
{
oResult_Get_Currency_By_OWNER_ID.ExceptionMsg = ex.Message;
oResult_Get_Currency_By_OWNER_ID.ExceptionCode = ((BLCException)ex).Code;
}
}
#endregion
#region Return Section
return oResult_Get_Currency_By_OWNER_ID;
#endregion
}
#endregion
#region Get_Fees_By_CURRENCY_ID
[HttpPost]
[Route("Get_Fees_By_CURRENCY_ID")]
public Result_Get_Fees_By_CURRENCY_ID Get_Fees_By_CURRENCY_ID(Params_Get_Fees_By_CURRENCY_ID i_Params_Get_Fees_By_CURRENCY_ID)
{
#region Declaration And Initialization Section.
List<Fees>  oReturnValue = new List<Fees> ();
string i_Ticket = string.Empty;
Result_Get_Fees_By_CURRENCY_ID oResult_Get_Fees_By_CURRENCY_ID = new Result_Get_Fees_By_CURRENCY_ID();
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
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Fees_By_CURRENCY_ID);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Monitor_API_Calls();
oReturnValue = oBLC.Get_Fees_By_CURRENCY_ID(i_Params_Get_Fees_By_CURRENCY_ID);
oResult_Get_Fees_By_CURRENCY_ID.My_Result = oReturnValue;
oResult_Get_Fees_By_CURRENCY_ID.My_Params_Get_Fees_By_CURRENCY_ID = i_Params_Get_Fees_By_CURRENCY_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Fees_By_CURRENCY_ID.ExceptionMsg = string.Format("Get_Fees_By_CURRENCY_ID : {0}", ex.Message);
}
else
{
oResult_Get_Fees_By_CURRENCY_ID.ExceptionMsg = ex.Message;
oResult_Get_Fees_By_CURRENCY_ID.ExceptionCode = ((BLCException)ex).Code;
}
}
#endregion
#region Return Section
return oResult_Get_Fees_By_CURRENCY_ID;
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
#region Get_Fees_By_OWNER_ID_Adv
[HttpPost]
[Route("Get_Fees_By_OWNER_ID_Adv")]
public Result_Get_Fees_By_OWNER_ID_Adv Get_Fees_By_OWNER_ID_Adv(Params_Get_Fees_By_OWNER_ID i_Params_Get_Fees_By_OWNER_ID)
{
#region Declaration And Initialization Section.
List<Fees>  oReturnValue = new List<Fees> ();
string i_Ticket = string.Empty;
Result_Get_Fees_By_OWNER_ID_Adv oResult_Get_Fees_By_OWNER_ID_Adv = new Result_Get_Fees_By_OWNER_ID_Adv();
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
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Fees_By_OWNER_ID_Adv);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Monitor_API_Calls();
oReturnValue = oBLC.Get_Fees_By_OWNER_ID_Adv(i_Params_Get_Fees_By_OWNER_ID);
oResult_Get_Fees_By_OWNER_ID_Adv.My_Result = oReturnValue;
oResult_Get_Fees_By_OWNER_ID_Adv.My_Params_Get_Fees_By_OWNER_ID = i_Params_Get_Fees_By_OWNER_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Fees_By_OWNER_ID_Adv.ExceptionMsg = string.Format("Get_Fees_By_OWNER_ID_Adv : {0}", ex.Message);
}
else
{
oResult_Get_Fees_By_OWNER_ID_Adv.ExceptionMsg = ex.Message;
oResult_Get_Fees_By_OWNER_ID_Adv.ExceptionCode = ((BLCException)ex).Code;
}
}
#endregion
#region Return Section
return oResult_Get_Fees_By_OWNER_ID_Adv;
#endregion
}
#endregion
#region Get_Package_By_OWNER_ID_Adv
[HttpPost]
[Route("Get_Package_By_OWNER_ID_Adv")]
public Result_Get_Package_By_OWNER_ID_Adv Get_Package_By_OWNER_ID_Adv(Params_Get_Package_By_OWNER_ID i_Params_Get_Package_By_OWNER_ID)
{
#region Declaration And Initialization Section.
List<Package>  oReturnValue = new List<Package> ();
string i_Ticket = string.Empty;
Result_Get_Package_By_OWNER_ID_Adv oResult_Get_Package_By_OWNER_ID_Adv = new Result_Get_Package_By_OWNER_ID_Adv();
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
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Package_By_OWNER_ID_Adv);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Monitor_API_Calls();
oReturnValue = oBLC.Get_Package_By_OWNER_ID_Adv(i_Params_Get_Package_By_OWNER_ID);
oResult_Get_Package_By_OWNER_ID_Adv.My_Result = oReturnValue;
oResult_Get_Package_By_OWNER_ID_Adv.My_Params_Get_Package_By_OWNER_ID = i_Params_Get_Package_By_OWNER_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Package_By_OWNER_ID_Adv.ExceptionMsg = string.Format("Get_Package_By_OWNER_ID_Adv : {0}", ex.Message);
}
else
{
oResult_Get_Package_By_OWNER_ID_Adv.ExceptionMsg = ex.Message;
oResult_Get_Package_By_OWNER_ID_Adv.ExceptionCode = ((BLCException)ex).Code;
}
}
#endregion
#region Return Section
return oResult_Get_Package_By_OWNER_ID_Adv;
#endregion
}
#endregion
#region Get_Session_By_OWNER_ID_Adv
[HttpPost]
[Route("Get_Session_By_OWNER_ID_Adv")]
public Result_Get_Session_By_OWNER_ID_Adv Get_Session_By_OWNER_ID_Adv(Params_Get_Session_By_OWNER_ID i_Params_Get_Session_By_OWNER_ID)
{
#region Declaration And Initialization Section.
List<Session>  oReturnValue = new List<Session> ();
string i_Ticket = string.Empty;
Result_Get_Session_By_OWNER_ID_Adv oResult_Get_Session_By_OWNER_ID_Adv = new Result_Get_Session_By_OWNER_ID_Adv();
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
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Session_By_OWNER_ID_Adv);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Monitor_API_Calls();
oReturnValue = oBLC.Get_Session_By_OWNER_ID_Adv(i_Params_Get_Session_By_OWNER_ID);
oResult_Get_Session_By_OWNER_ID_Adv.My_Result = oReturnValue;
oResult_Get_Session_By_OWNER_ID_Adv.My_Params_Get_Session_By_OWNER_ID = i_Params_Get_Session_By_OWNER_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Session_By_OWNER_ID_Adv.ExceptionMsg = string.Format("Get_Session_By_OWNER_ID_Adv : {0}", ex.Message);
}
else
{
oResult_Get_Session_By_OWNER_ID_Adv.ExceptionMsg = ex.Message;
oResult_Get_Session_By_OWNER_ID_Adv.ExceptionCode = ((BLCException)ex).Code;
}
}
#endregion
#region Return Section
return oResult_Get_Session_By_OWNER_ID_Adv;
#endregion
}
#endregion
#region Get_Staff_By_OWNER_ID_Adv
[HttpPost]
[Route("Get_Staff_By_OWNER_ID_Adv")]
public Result_Get_Staff_By_OWNER_ID_Adv Get_Staff_By_OWNER_ID_Adv(Params_Get_Staff_By_OWNER_ID i_Params_Get_Staff_By_OWNER_ID)
{
#region Declaration And Initialization Section.
List<Staff>  oReturnValue = new List<Staff> ();
string i_Ticket = string.Empty;
Result_Get_Staff_By_OWNER_ID_Adv oResult_Get_Staff_By_OWNER_ID_Adv = new Result_Get_Staff_By_OWNER_ID_Adv();
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
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Staff_By_OWNER_ID_Adv);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Monitor_API_Calls();
oReturnValue = oBLC.Get_Staff_By_OWNER_ID_Adv(i_Params_Get_Staff_By_OWNER_ID);
oResult_Get_Staff_By_OWNER_ID_Adv.My_Result = oReturnValue;
oResult_Get_Staff_By_OWNER_ID_Adv.My_Params_Get_Staff_By_OWNER_ID = i_Params_Get_Staff_By_OWNER_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Staff_By_OWNER_ID_Adv.ExceptionMsg = string.Format("Get_Staff_By_OWNER_ID_Adv : {0}", ex.Message);
}
else
{
oResult_Get_Staff_By_OWNER_ID_Adv.ExceptionMsg = ex.Message;
oResult_Get_Staff_By_OWNER_ID_Adv.ExceptionCode = ((BLCException)ex).Code;
}
}
#endregion
#region Return Section
return oResult_Get_Staff_By_OWNER_ID_Adv;
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
#region Get_Supplier_By_OWNER_ID
[HttpPost]
[Route("Get_Supplier_By_OWNER_ID")]
public Result_Get_Supplier_By_OWNER_ID Get_Supplier_By_OWNER_ID(Params_Get_Supplier_By_OWNER_ID i_Params_Get_Supplier_By_OWNER_ID)
{
#region Declaration And Initialization Section.
List<Supplier>  oReturnValue = new List<Supplier> ();
string i_Ticket = string.Empty;
Result_Get_Supplier_By_OWNER_ID oResult_Get_Supplier_By_OWNER_ID = new Result_Get_Supplier_By_OWNER_ID();
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
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.Get_Supplier_By_OWNER_ID);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Monitor_API_Calls();
oReturnValue = oBLC.Get_Supplier_By_OWNER_ID(i_Params_Get_Supplier_By_OWNER_ID);
oResult_Get_Supplier_By_OWNER_ID.My_Result = oReturnValue;
oResult_Get_Supplier_By_OWNER_ID.My_Params_Get_Supplier_By_OWNER_ID = i_Params_Get_Supplier_By_OWNER_ID;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_Get_Supplier_By_OWNER_ID.ExceptionMsg = string.Format("Get_Supplier_By_OWNER_ID : {0}", ex.Message);
}
else
{
oResult_Get_Supplier_By_OWNER_ID.ExceptionMsg = ex.Message;
oResult_Get_Supplier_By_OWNER_ID.ExceptionCode = ((BLCException)ex).Code;
}
}
#endregion
#region Return Section
return oResult_Get_Supplier_By_OWNER_ID;
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
#region LoginFct
[HttpPost]
[Route("LoginFct")]
public Result_LoginFct LoginFct(Params_LoginFct i_Params_LoginFct)
{
#region Declaration And Initialization Section.
Int32 oReturnValue = 0;
string i_Ticket = string.Empty;
Result_LoginFct oResult_LoginFct = new Result_LoginFct();
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
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.LoginFct);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Monitor_API_Calls();
oReturnValue = oBLC.LoginFct(i_Params_LoginFct);
oResult_LoginFct.My_Result = oReturnValue;
oResult_LoginFct.My_Params_LoginFct = i_Params_LoginFct;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_LoginFct.ExceptionMsg = string.Format("LoginFct : {0}", ex.Message);
}
else
{
oResult_LoginFct.ExceptionMsg = ex.Message;
oResult_LoginFct.ExceptionCode = ((BLCException)ex).Code;
}
}
#endregion
#region Return Section
return oResult_LoginFct;
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
#region UP_CHECK_USER_EXISTENCE
[HttpPost]
[Route("UP_CHECK_USER_EXISTENCE")]
public Result_UP_CHECK_USER_EXISTENCE UP_CHECK_USER_EXISTENCE(Params_UP_CHECK_USER_EXISTENCE i_Params_UP_CHECK_USER_EXISTENCE)
{
#region Declaration And Initialization Section.
Boolean oReturnValue = false;
string i_Ticket = string.Empty;
Result_UP_CHECK_USER_EXISTENCE oResult_UP_CHECK_USER_EXISTENCE = new Result_UP_CHECK_USER_EXISTENCE();
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
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.UP_CHECK_USER_EXISTENCE);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Monitor_API_Calls();
oReturnValue = oBLC.UP_CHECK_USER_EXISTENCE(i_Params_UP_CHECK_USER_EXISTENCE);
oResult_UP_CHECK_USER_EXISTENCE.My_Result = oReturnValue;
oResult_UP_CHECK_USER_EXISTENCE.My_Params_UP_CHECK_USER_EXISTENCE = i_Params_UP_CHECK_USER_EXISTENCE;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_UP_CHECK_USER_EXISTENCE.ExceptionMsg = string.Format("UP_CHECK_USER_EXISTENCE : {0}", ex.Message);
}
else
{
oResult_UP_CHECK_USER_EXISTENCE.ExceptionMsg = ex.Message;
oResult_UP_CHECK_USER_EXISTENCE.ExceptionCode = ((BLCException)ex).Code;
}
}
#endregion
#region Return Section
return oResult_UP_CHECK_USER_EXISTENCE;
#endregion
}
#endregion
#region UpdatePassword
[HttpPost]
[Route("UpdatePassword")]
public Result_UpdatePassword UpdatePassword(Params_UpdatePassword i_Params_UpdatePassword)
{
#region Declaration And Initialization Section.
string i_Ticket = string.Empty;
Result_UpdatePassword oResult_UpdatePassword = new Result_UpdatePassword();
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
BLCInitializer oBLCInitializer = oBLC_Default.Prepare_BLCInitializer(i_Ticket,BLC.BLC.Enum_API_Method.UpdatePassword);
using (BLC.BLC oBLC = new BLC.BLC(oBLCInitializer))
{
oBLC.Monitor_API_Calls();
oBLC.UpdatePassword(i_Params_UpdatePassword);
oResult_UpdatePassword.My_Params_UpdatePassword = i_Params_UpdatePassword;
}
}
catch(Exception ex)
{
if (ex.GetType().FullName != "BLC.BLCException")
{
oResult_UpdatePassword.ExceptionMsg = string.Format("UpdatePassword : {0}", ex.Message);
}
else
{
oResult_UpdatePassword.ExceptionMsg = ex.Message;
oResult_UpdatePassword.ExceptionCode = ((BLCException)ex).Code;
}
}
#endregion
#region Return Section
return oResult_UpdatePassword;
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
#region Result_CalculateStaffBalance
public partial class Result_CalculateStaffBalance : Action_Result
{
#region Properties.
public Int32 My_Result { get; set; }
public Params_CalculateStaffBalance My_Params_CalculateStaffBalance { get; set; }
#endregion
}
#endregion
#region Result_CheckClientPaymentStatus
public partial class Result_CheckClientPaymentStatus : Action_Result
{
#region Properties.
public Int32 My_Result { get; set; }
public Params_CheckClientPaymentStatus My_Params_CheckClientPaymentStatus { get; set; }
#endregion
}
#endregion
#region Result_Delete_Session
public partial class Result_Delete_Session : Action_Result
{
#region Properties.
public Params_Delete_Session My_Params_Delete_Session { get; set; }
#endregion
}
#endregion
#region Result_Edit_Client
public partial class Result_Edit_Client : Action_Result
{
#region Properties.
public Client My_Client { get; set; }
#endregion
}
#endregion
#region Result_Edit_Client_fees
public partial class Result_Edit_Client_fees : Action_Result
{
#region Properties.
public Client_fees My_Client_fees { get; set; }
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
#region Result_Edit_Session
public partial class Result_Edit_Session : Action_Result
{
#region Properties.
public Session My_Session { get; set; }
#endregion
}
#endregion
#region Result_Edit_Staff
public partial class Result_Edit_Staff : Action_Result
{
#region Properties.
public Staff My_Staff { get; set; }
#endregion
}
#endregion
#region Result_Edit_Staff_fees
public partial class Result_Edit_Staff_fees : Action_Result
{
#region Properties.
public Staff_fees My_Staff_fees { get; set; }
#endregion
}
#endregion
#region Result_Edit_Supplier
public partial class Result_Edit_Supplier : Action_Result
{
#region Properties.
public Supplier My_Supplier { get; set; }
#endregion
}
#endregion
#region Result_Edit_Supplier_fees
public partial class Result_Edit_Supplier_fees : Action_Result
{
#region Properties.
public Supplier_fees My_Supplier_fees { get; set; }
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
#region Result_Get_Bloodtype_By_OWNER_ID
public partial class Result_Get_Bloodtype_By_OWNER_ID : Action_Result
{
#region Properties.
public List<Bloodtype>  My_Result { get; set; }
public Params_Get_Bloodtype_By_OWNER_ID My_Params_Get_Bloodtype_By_OWNER_ID { get; set; }
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
#region Result_Get_Client_By_OWNER_ID_Adv
public partial class Result_Get_Client_By_OWNER_ID_Adv : Action_Result
{
#region Properties.
public List<Client>  My_Result { get; set; }
public Params_Get_Client_By_OWNER_ID My_Params_Get_Client_By_OWNER_ID { get; set; }
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
#region Result_Get_Currency_By_OWNER_ID
public partial class Result_Get_Currency_By_OWNER_ID : Action_Result
{
#region Properties.
public List<Currency>  My_Result { get; set; }
public Params_Get_Currency_By_OWNER_ID My_Params_Get_Currency_By_OWNER_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Fees_By_CURRENCY_ID
public partial class Result_Get_Fees_By_CURRENCY_ID : Action_Result
{
#region Properties.
public List<Fees>  My_Result { get; set; }
public Params_Get_Fees_By_CURRENCY_ID My_Params_Get_Fees_By_CURRENCY_ID { get; set; }
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
#region Result_Get_Fees_By_OWNER_ID_Adv
public partial class Result_Get_Fees_By_OWNER_ID_Adv : Action_Result
{
#region Properties.
public List<Fees>  My_Result { get; set; }
public Params_Get_Fees_By_OWNER_ID My_Params_Get_Fees_By_OWNER_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Package_By_OWNER_ID_Adv
public partial class Result_Get_Package_By_OWNER_ID_Adv : Action_Result
{
#region Properties.
public List<Package>  My_Result { get; set; }
public Params_Get_Package_By_OWNER_ID My_Params_Get_Package_By_OWNER_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Session_By_OWNER_ID_Adv
public partial class Result_Get_Session_By_OWNER_ID_Adv : Action_Result
{
#region Properties.
public List<Session>  My_Result { get; set; }
public Params_Get_Session_By_OWNER_ID My_Params_Get_Session_By_OWNER_ID { get; set; }
#endregion
}
#endregion
#region Result_Get_Staff_By_OWNER_ID_Adv
public partial class Result_Get_Staff_By_OWNER_ID_Adv : Action_Result
{
#region Properties.
public List<Staff>  My_Result { get; set; }
public Params_Get_Staff_By_OWNER_ID My_Params_Get_Staff_By_OWNER_ID { get; set; }
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
#region Result_Get_Supplier_By_OWNER_ID
public partial class Result_Get_Supplier_By_OWNER_ID : Action_Result
{
#region Properties.
public List<Supplier>  My_Result { get; set; }
public Params_Get_Supplier_By_OWNER_ID My_Params_Get_Supplier_By_OWNER_ID { get; set; }
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
#region Result_LoginFct
public partial class Result_LoginFct : Action_Result
{
#region Properties.
public Int32 My_Result { get; set; }
public Params_LoginFct My_Params_LoginFct { get; set; }
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
#region Result_UP_CHECK_USER_EXISTENCE
public partial class Result_UP_CHECK_USER_EXISTENCE : Action_Result
{
#region Properties.
public Boolean My_Result { get; set; }
public Params_UP_CHECK_USER_EXISTENCE My_Params_UP_CHECK_USER_EXISTENCE { get; set; }
#endregion
}
#endregion
#region Result_UpdatePassword
public partial class Result_UpdatePassword : Action_Result
{
#region Properties.
public Params_UpdatePassword My_Params_UpdatePassword { get; set; }
#endregion
}
#endregion
