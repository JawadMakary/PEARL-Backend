using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Configuration;
using DALC;
//using System.Data.Linq;
using System.Text.RegularExpressions;
using System.Transactions;
using System.Reflection;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Threading;







namespace BLC
{
public partial class BLC
{
#region Reset_Client_By_Bloodtype
public void Reset_Client_By_Bloodtype(Bloodtype i_Bloodtype, List<Client> i_Client_List)
{
#region Declaration And Initialization Section.
Params_Delete_Client_By_BLOODTYPE_ID oParams_Delete_Client_By_BLOODTYPE_ID = new Params_Delete_Client_By_BLOODTYPE_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Client_By_Bloodtype");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Client
//---------------------------------
oParams_Delete_Client_By_BLOODTYPE_ID.BLOODTYPE_ID = i_Bloodtype.BLOODTYPE_ID;
Delete_Client_By_BLOODTYPE_ID(oParams_Delete_Client_By_BLOODTYPE_ID);
//---------------------------------
// Edit Client
//---------------------------------
Edit_Bloodtype_WithClient(i_Bloodtype, i_Client_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Client_By_Bloodtype");}
}
#endregion
#region Reset_Client_By_Bloodtype
public void Reset_Client_By_Bloodtype(Bloodtype i_Bloodtype, List<Client> i_Client_List_To_Delete,List<Client> i_Client_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Client oParams_Delete_Client = new Params_Delete_Client();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Client_By_Bloodtype");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Client_List_To_Delete != null)
{
foreach (var oRow in i_Client_List_To_Delete)
{
oParams_Delete_Client.CLIENT_ID = oRow.CLIENT_ID;
Delete_Client(oParams_Delete_Client);
}
}
//---------------------------------
// Edit Client
//---------------------------------
Edit_Bloodtype_WithClient(i_Bloodtype, i_Client_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Client_By_Bloodtype");}
}
#endregion
#region Edit_Bloodtype_With_Client(Bloodtype i_Bloodtype,List<Client> i_ClientList)
public void Edit_Bloodtype_WithClient(Bloodtype i_Bloodtype,List<Client> i_List_Client)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Bloodtype_WithClient");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Bloodtype(i_Bloodtype);
if (i_List_Client != null)
{
foreach(Client oClient in i_List_Client)
{
oClient.BLOODTYPE_ID = i_Bloodtype.BLOODTYPE_ID;
Edit_Client(oClient);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Bloodtype_WithClient");}
}
#endregion
#region Reset_Staff_By_Bloodtype
public void Reset_Staff_By_Bloodtype(Bloodtype i_Bloodtype, List<Staff> i_Staff_List)
{
#region Declaration And Initialization Section.
Params_Delete_Staff_By_BLOODTYPE_ID oParams_Delete_Staff_By_BLOODTYPE_ID = new Params_Delete_Staff_By_BLOODTYPE_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Staff_By_Bloodtype");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Staff
//---------------------------------
oParams_Delete_Staff_By_BLOODTYPE_ID.BLOODTYPE_ID = i_Bloodtype.BLOODTYPE_ID;
Delete_Staff_By_BLOODTYPE_ID(oParams_Delete_Staff_By_BLOODTYPE_ID);
//---------------------------------
// Edit Staff
//---------------------------------
Edit_Bloodtype_WithStaff(i_Bloodtype, i_Staff_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Staff_By_Bloodtype");}
}
#endregion
#region Reset_Staff_By_Bloodtype
public void Reset_Staff_By_Bloodtype(Bloodtype i_Bloodtype, List<Staff> i_Staff_List_To_Delete,List<Staff> i_Staff_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Staff oParams_Delete_Staff = new Params_Delete_Staff();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Staff_By_Bloodtype");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Staff_List_To_Delete != null)
{
foreach (var oRow in i_Staff_List_To_Delete)
{
oParams_Delete_Staff.STAFF_ID = oRow.STAFF_ID;
Delete_Staff(oParams_Delete_Staff);
}
}
//---------------------------------
// Edit Staff
//---------------------------------
Edit_Bloodtype_WithStaff(i_Bloodtype, i_Staff_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Staff_By_Bloodtype");}
}
#endregion
#region Edit_Bloodtype_With_Staff(Bloodtype i_Bloodtype,List<Staff> i_StaffList)
public void Edit_Bloodtype_WithStaff(Bloodtype i_Bloodtype,List<Staff> i_List_Staff)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Bloodtype_WithStaff");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Bloodtype(i_Bloodtype);
if (i_List_Staff != null)
{
foreach(Staff oStaff in i_List_Staff)
{
oStaff.BLOODTYPE_ID = i_Bloodtype.BLOODTYPE_ID;
Edit_Staff(oStaff);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Bloodtype_WithStaff");}
}
#endregion
#region Reset_Supplier_By_Bloodtype
public void Reset_Supplier_By_Bloodtype(Bloodtype i_Bloodtype, List<Supplier> i_Supplier_List)
{
#region Declaration And Initialization Section.
Params_Delete_Supplier_By_BLOODTYPE_ID oParams_Delete_Supplier_By_BLOODTYPE_ID = new Params_Delete_Supplier_By_BLOODTYPE_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Supplier_By_Bloodtype");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Supplier
//---------------------------------
oParams_Delete_Supplier_By_BLOODTYPE_ID.BLOODTYPE_ID = i_Bloodtype.BLOODTYPE_ID;
Delete_Supplier_By_BLOODTYPE_ID(oParams_Delete_Supplier_By_BLOODTYPE_ID);
//---------------------------------
// Edit Supplier
//---------------------------------
Edit_Bloodtype_WithSupplier(i_Bloodtype, i_Supplier_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Supplier_By_Bloodtype");}
}
#endregion
#region Reset_Supplier_By_Bloodtype
public void Reset_Supplier_By_Bloodtype(Bloodtype i_Bloodtype, List<Supplier> i_Supplier_List_To_Delete,List<Supplier> i_Supplier_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Supplier oParams_Delete_Supplier = new Params_Delete_Supplier();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Supplier_By_Bloodtype");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Supplier_List_To_Delete != null)
{
foreach (var oRow in i_Supplier_List_To_Delete)
{
oParams_Delete_Supplier.SUPPLIER_ID = oRow.SUPPLIER_ID;
Delete_Supplier(oParams_Delete_Supplier);
}
}
//---------------------------------
// Edit Supplier
//---------------------------------
Edit_Bloodtype_WithSupplier(i_Bloodtype, i_Supplier_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Supplier_By_Bloodtype");}
}
#endregion
#region Edit_Bloodtype_With_Supplier(Bloodtype i_Bloodtype,List<Supplier> i_SupplierList)
public void Edit_Bloodtype_WithSupplier(Bloodtype i_Bloodtype,List<Supplier> i_List_Supplier)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Bloodtype_WithSupplier");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Bloodtype(i_Bloodtype);
if (i_List_Supplier != null)
{
foreach(Supplier oSupplier in i_List_Supplier)
{
oSupplier.BLOODTYPE_ID = i_Bloodtype.BLOODTYPE_ID;
Edit_Supplier(oSupplier);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Bloodtype_WithSupplier");}
}
#endregion
#region Edit_Bloodtype_WithRelatedData(Bloodtype i_Bloodtype,List<Client> i_List_Client,List<Staff> i_List_Staff,List<Supplier> i_List_Supplier)
public void Edit_Bloodtype_WithRelatedData(Bloodtype i_Bloodtype,List<Client> i_List_Client,List<Staff> i_List_Staff,List<Supplier> i_List_Supplier)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Bloodtype_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Bloodtype(i_Bloodtype);
if (i_List_Client != null)
{
foreach(Client oClient in i_List_Client)
{
oClient.BLOODTYPE_ID = i_Bloodtype.BLOODTYPE_ID;
Edit_Client(oClient);
}
}
if (i_List_Staff != null)
{
foreach(Staff oStaff in i_List_Staff)
{
oStaff.BLOODTYPE_ID = i_Bloodtype.BLOODTYPE_ID;
Edit_Staff(oStaff);
}
}
if (i_List_Supplier != null)
{
foreach(Supplier oSupplier in i_List_Supplier)
{
oSupplier.BLOODTYPE_ID = i_Bloodtype.BLOODTYPE_ID;
Edit_Supplier(oSupplier);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Bloodtype_WithRelatedData");}
}
#endregion
#region Delete_Bloodtype_With_Children(Bloodtype i_Bloodtype)
public void Delete_Bloodtype_With_Children(Bloodtype i_Bloodtype)
{
 #region Declaration And Initialization Section.
Params_Delete_Bloodtype oParams_Delete_Bloodtype = new Params_Delete_Bloodtype();
Params_Delete_Client_By_BLOODTYPE_ID oParams_Delete_Client_By_BLOODTYPE_ID = new Params_Delete_Client_By_BLOODTYPE_ID();
Params_Delete_Staff_By_BLOODTYPE_ID oParams_Delete_Staff_By_BLOODTYPE_ID = new Params_Delete_Staff_By_BLOODTYPE_ID();
Params_Delete_Supplier_By_BLOODTYPE_ID oParams_Delete_Supplier_By_BLOODTYPE_ID = new Params_Delete_Supplier_By_BLOODTYPE_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Bloodtype_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Client_By_BLOODTYPE_ID.BLOODTYPE_ID = i_Bloodtype.BLOODTYPE_ID;
Delete_Client_By_BLOODTYPE_ID(oParams_Delete_Client_By_BLOODTYPE_ID);
oParams_Delete_Staff_By_BLOODTYPE_ID.BLOODTYPE_ID = i_Bloodtype.BLOODTYPE_ID;
Delete_Staff_By_BLOODTYPE_ID(oParams_Delete_Staff_By_BLOODTYPE_ID);
oParams_Delete_Supplier_By_BLOODTYPE_ID.BLOODTYPE_ID = i_Bloodtype.BLOODTYPE_ID;
Delete_Supplier_By_BLOODTYPE_ID(oParams_Delete_Supplier_By_BLOODTYPE_ID);
//-------------------------

//-------------------------
oParams_Delete_Bloodtype.BLOODTYPE_ID = i_Bloodtype.BLOODTYPE_ID;
Delete_Bloodtype(oParams_Delete_Bloodtype);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Bloodtype_With_Children");}
}
#endregion
#region Reset_Client_fees_By_Client
public void Reset_Client_fees_By_Client(Client i_Client, List<Client_fees> i_Client_fees_List)
{
#region Declaration And Initialization Section.
Params_Delete_Client_fees_By_CLIENT_ID oParams_Delete_Client_fees_By_CLIENT_ID = new Params_Delete_Client_fees_By_CLIENT_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Client_fees_By_Client");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Client_fees
//---------------------------------
oParams_Delete_Client_fees_By_CLIENT_ID.CLIENT_ID = i_Client.CLIENT_ID;
Delete_Client_fees_By_CLIENT_ID(oParams_Delete_Client_fees_By_CLIENT_ID);
//---------------------------------
// Edit Client_fees
//---------------------------------
Edit_Client_WithClient_fees(i_Client, i_Client_fees_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Client_fees_By_Client");}
}
#endregion
#region Reset_Client_fees_By_Client
public void Reset_Client_fees_By_Client(Client i_Client, List<Client_fees> i_Client_fees_List_To_Delete,List<Client_fees> i_Client_fees_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Client_fees oParams_Delete_Client_fees = new Params_Delete_Client_fees();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Client_fees_By_Client");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Client_fees_List_To_Delete != null)
{
foreach (var oRow in i_Client_fees_List_To_Delete)
{
oParams_Delete_Client_fees.CLIENT_FEES_ID = oRow.CLIENT_FEES_ID;
Delete_Client_fees(oParams_Delete_Client_fees);
}
}
//---------------------------------
// Edit Client_fees
//---------------------------------
Edit_Client_WithClient_fees(i_Client, i_Client_fees_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Client_fees_By_Client");}
}
#endregion
#region Edit_Client_With_Client_fees(Client i_Client,List<Client_fees> i_Client_feesList)
public void Edit_Client_WithClient_fees(Client i_Client,List<Client_fees> i_List_Client_fees)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Client_WithClient_fees");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Client(i_Client);
if (i_List_Client_fees != null)
{
foreach(Client_fees oClient_fees in i_List_Client_fees)
{
oClient_fees.CLIENT_ID = i_Client.CLIENT_ID;
Edit_Client_fees(oClient_fees);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Client_WithClient_fees");}
}
#endregion
#region Edit_Client_WithRelatedData(Client i_Client,List<Client_fees> i_List_Client_fees)
public void Edit_Client_WithRelatedData(Client i_Client,List<Client_fees> i_List_Client_fees)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Client_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Client(i_Client);
if (i_List_Client_fees != null)
{
foreach(Client_fees oClient_fees in i_List_Client_fees)
{
oClient_fees.CLIENT_ID = i_Client.CLIENT_ID;
Edit_Client_fees(oClient_fees);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Client_WithRelatedData");}
}
#endregion
#region Delete_Client_With_Children(Client i_Client)
public void Delete_Client_With_Children(Client i_Client)
{
 #region Declaration And Initialization Section.
Params_Delete_Client oParams_Delete_Client = new Params_Delete_Client();
Params_Delete_Client_fees_By_CLIENT_ID oParams_Delete_Client_fees_By_CLIENT_ID = new Params_Delete_Client_fees_By_CLIENT_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Client_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Client_fees_By_CLIENT_ID.CLIENT_ID = i_Client.CLIENT_ID;
Delete_Client_fees_By_CLIENT_ID(oParams_Delete_Client_fees_By_CLIENT_ID);
//-------------------------

//-------------------------
oParams_Delete_Client.CLIENT_ID = i_Client.CLIENT_ID;
Delete_Client(oParams_Delete_Client);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Client_With_Children");}
}
#endregion
#region Reset_Session_By_Client_fees
public void Reset_Session_By_Client_fees(Client_fees i_Client_fees, List<Session> i_Session_List)
{
#region Declaration And Initialization Section.
Params_Delete_Session_By_CLIENT_FEES_ID oParams_Delete_Session_By_CLIENT_FEES_ID = new Params_Delete_Session_By_CLIENT_FEES_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Session_By_Client_fees");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Session
//---------------------------------
oParams_Delete_Session_By_CLIENT_FEES_ID.CLIENT_FEES_ID = i_Client_fees.CLIENT_FEES_ID;
Delete_Session_By_CLIENT_FEES_ID(oParams_Delete_Session_By_CLIENT_FEES_ID);
//---------------------------------
// Edit Session
//---------------------------------
Edit_Client_fees_WithSession(i_Client_fees, i_Session_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Session_By_Client_fees");}
}
#endregion
#region Reset_Session_By_Client_fees
public void Reset_Session_By_Client_fees(Client_fees i_Client_fees, List<Session> i_Session_List_To_Delete,List<Session> i_Session_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Session oParams_Delete_Session = new Params_Delete_Session();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Session_By_Client_fees");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Session_List_To_Delete != null)
{
foreach (var oRow in i_Session_List_To_Delete)
{
oParams_Delete_Session.SESSION_ID = oRow.SESSION_ID;
Delete_Session(oParams_Delete_Session);
}
}
//---------------------------------
// Edit Session
//---------------------------------
Edit_Client_fees_WithSession(i_Client_fees, i_Session_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Session_By_Client_fees");}
}
#endregion
#region Edit_Client_fees_With_Session(Client_fees i_Client_fees,List<Session> i_SessionList)
public void Edit_Client_fees_WithSession(Client_fees i_Client_fees,List<Session> i_List_Session)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Client_fees_WithSession");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Client_fees(i_Client_fees);
if (i_List_Session != null)
{
foreach(Session oSession in i_List_Session)
{
oSession.CLIENT_FEES_ID = i_Client_fees.CLIENT_FEES_ID;
Edit_Session(oSession);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Client_fees_WithSession");}
}
#endregion
#region Edit_Client_fees_WithRelatedData(Client_fees i_Client_fees,List<Session> i_List_Session)
public void Edit_Client_fees_WithRelatedData(Client_fees i_Client_fees,List<Session> i_List_Session)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Client_fees_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Client_fees(i_Client_fees);
if (i_List_Session != null)
{
foreach(Session oSession in i_List_Session)
{
oSession.CLIENT_FEES_ID = i_Client_fees.CLIENT_FEES_ID;
Edit_Session(oSession);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Client_fees_WithRelatedData");}
}
#endregion
#region Delete_Client_fees_With_Children(Client_fees i_Client_fees)
public void Delete_Client_fees_With_Children(Client_fees i_Client_fees)
{
 #region Declaration And Initialization Section.
Params_Delete_Client_fees oParams_Delete_Client_fees = new Params_Delete_Client_fees();
Params_Delete_Session_By_CLIENT_FEES_ID oParams_Delete_Session_By_CLIENT_FEES_ID = new Params_Delete_Session_By_CLIENT_FEES_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Client_fees_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Session_By_CLIENT_FEES_ID.CLIENT_FEES_ID = i_Client_fees.CLIENT_FEES_ID;
Delete_Session_By_CLIENT_FEES_ID(oParams_Delete_Session_By_CLIENT_FEES_ID);
//-------------------------

//-------------------------
oParams_Delete_Client_fees.CLIENT_FEES_ID = i_Client_fees.CLIENT_FEES_ID;
Delete_Client_fees(oParams_Delete_Client_fees);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Client_fees_With_Children");}
}
#endregion
#region Reset_Client_fees_By_Currency
public void Reset_Client_fees_By_Currency(Currency i_Currency, List<Client_fees> i_Client_fees_List)
{
#region Declaration And Initialization Section.
Params_Delete_Client_fees_By_CURRENCY_ID oParams_Delete_Client_fees_By_CURRENCY_ID = new Params_Delete_Client_fees_By_CURRENCY_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Client_fees_By_Currency");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Client_fees
//---------------------------------
oParams_Delete_Client_fees_By_CURRENCY_ID.CURRENCY_ID = i_Currency.CURRENCY_ID;
Delete_Client_fees_By_CURRENCY_ID(oParams_Delete_Client_fees_By_CURRENCY_ID);
//---------------------------------
// Edit Client_fees
//---------------------------------
Edit_Currency_WithClient_fees(i_Currency, i_Client_fees_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Client_fees_By_Currency");}
}
#endregion
#region Reset_Client_fees_By_Currency
public void Reset_Client_fees_By_Currency(Currency i_Currency, List<Client_fees> i_Client_fees_List_To_Delete,List<Client_fees> i_Client_fees_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Client_fees oParams_Delete_Client_fees = new Params_Delete_Client_fees();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Client_fees_By_Currency");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Client_fees_List_To_Delete != null)
{
foreach (var oRow in i_Client_fees_List_To_Delete)
{
oParams_Delete_Client_fees.CLIENT_FEES_ID = oRow.CLIENT_FEES_ID;
Delete_Client_fees(oParams_Delete_Client_fees);
}
}
//---------------------------------
// Edit Client_fees
//---------------------------------
Edit_Currency_WithClient_fees(i_Currency, i_Client_fees_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Client_fees_By_Currency");}
}
#endregion
#region Edit_Currency_With_Client_fees(Currency i_Currency,List<Client_fees> i_Client_feesList)
public void Edit_Currency_WithClient_fees(Currency i_Currency,List<Client_fees> i_List_Client_fees)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Currency_WithClient_fees");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Currency(i_Currency);
if (i_List_Client_fees != null)
{
foreach(Client_fees oClient_fees in i_List_Client_fees)
{
oClient_fees.CURRENCY_ID = i_Currency.CURRENCY_ID;
Edit_Client_fees(oClient_fees);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Currency_WithClient_fees");}
}
#endregion
#region Reset_Fees_By_Currency
public void Reset_Fees_By_Currency(Currency i_Currency, List<Fees> i_Fees_List)
{
#region Declaration And Initialization Section.
Params_Delete_Fees_By_CURRENCY_ID oParams_Delete_Fees_By_CURRENCY_ID = new Params_Delete_Fees_By_CURRENCY_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Fees_By_Currency");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Fees
//---------------------------------
oParams_Delete_Fees_By_CURRENCY_ID.CURRENCY_ID = i_Currency.CURRENCY_ID;
Delete_Fees_By_CURRENCY_ID(oParams_Delete_Fees_By_CURRENCY_ID);
//---------------------------------
// Edit Fees
//---------------------------------
Edit_Currency_WithFees(i_Currency, i_Fees_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Fees_By_Currency");}
}
#endregion
#region Reset_Fees_By_Currency
public void Reset_Fees_By_Currency(Currency i_Currency, List<Fees> i_Fees_List_To_Delete,List<Fees> i_Fees_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Fees oParams_Delete_Fees = new Params_Delete_Fees();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Fees_By_Currency");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Fees_List_To_Delete != null)
{
foreach (var oRow in i_Fees_List_To_Delete)
{
oParams_Delete_Fees.FEES_ID = oRow.FEES_ID;
Delete_Fees(oParams_Delete_Fees);
}
}
//---------------------------------
// Edit Fees
//---------------------------------
Edit_Currency_WithFees(i_Currency, i_Fees_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Fees_By_Currency");}
}
#endregion
#region Edit_Currency_With_Fees(Currency i_Currency,List<Fees> i_FeesList)
public void Edit_Currency_WithFees(Currency i_Currency,List<Fees> i_List_Fees)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Currency_WithFees");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Currency(i_Currency);
if (i_List_Fees != null)
{
foreach(Fees oFees in i_List_Fees)
{
oFees.CURRENCY_ID = i_Currency.CURRENCY_ID;
Edit_Fees(oFees);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Currency_WithFees");}
}
#endregion
#region Reset_Package_By_Currency
public void Reset_Package_By_Currency(Currency i_Currency, List<Package> i_Package_List)
{
#region Declaration And Initialization Section.
Params_Delete_Package_By_CURRENCY_ID oParams_Delete_Package_By_CURRENCY_ID = new Params_Delete_Package_By_CURRENCY_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Package_By_Currency");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Package
//---------------------------------
oParams_Delete_Package_By_CURRENCY_ID.CURRENCY_ID = i_Currency.CURRENCY_ID;
Delete_Package_By_CURRENCY_ID(oParams_Delete_Package_By_CURRENCY_ID);
//---------------------------------
// Edit Package
//---------------------------------
Edit_Currency_WithPackage(i_Currency, i_Package_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Package_By_Currency");}
}
#endregion
#region Reset_Package_By_Currency
public void Reset_Package_By_Currency(Currency i_Currency, List<Package> i_Package_List_To_Delete,List<Package> i_Package_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Package oParams_Delete_Package = new Params_Delete_Package();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Package_By_Currency");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Package_List_To_Delete != null)
{
foreach (var oRow in i_Package_List_To_Delete)
{
oParams_Delete_Package.PACKAGE_ID = oRow.PACKAGE_ID;
Delete_Package(oParams_Delete_Package);
}
}
//---------------------------------
// Edit Package
//---------------------------------
Edit_Currency_WithPackage(i_Currency, i_Package_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Package_By_Currency");}
}
#endregion
#region Edit_Currency_With_Package(Currency i_Currency,List<Package> i_PackageList)
public void Edit_Currency_WithPackage(Currency i_Currency,List<Package> i_List_Package)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Currency_WithPackage");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Currency(i_Currency);
if (i_List_Package != null)
{
foreach(Package oPackage in i_List_Package)
{
oPackage.CURRENCY_ID = i_Currency.CURRENCY_ID;
Edit_Package(oPackage);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Currency_WithPackage");}
}
#endregion
#region Reset_Staff_fees_By_Currency
public void Reset_Staff_fees_By_Currency(Currency i_Currency, List<Staff_fees> i_Staff_fees_List)
{
#region Declaration And Initialization Section.
Params_Delete_Staff_fees_By_CURRENCY_ID oParams_Delete_Staff_fees_By_CURRENCY_ID = new Params_Delete_Staff_fees_By_CURRENCY_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Staff_fees_By_Currency");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Staff_fees
//---------------------------------
oParams_Delete_Staff_fees_By_CURRENCY_ID.CURRENCY_ID = i_Currency.CURRENCY_ID;
Delete_Staff_fees_By_CURRENCY_ID(oParams_Delete_Staff_fees_By_CURRENCY_ID);
//---------------------------------
// Edit Staff_fees
//---------------------------------
Edit_Currency_WithStaff_fees(i_Currency, i_Staff_fees_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Staff_fees_By_Currency");}
}
#endregion
#region Reset_Staff_fees_By_Currency
public void Reset_Staff_fees_By_Currency(Currency i_Currency, List<Staff_fees> i_Staff_fees_List_To_Delete,List<Staff_fees> i_Staff_fees_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Staff_fees oParams_Delete_Staff_fees = new Params_Delete_Staff_fees();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Staff_fees_By_Currency");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Staff_fees_List_To_Delete != null)
{
foreach (var oRow in i_Staff_fees_List_To_Delete)
{
oParams_Delete_Staff_fees.STAFF_FEES_ID = oRow.STAFF_FEES_ID;
Delete_Staff_fees(oParams_Delete_Staff_fees);
}
}
//---------------------------------
// Edit Staff_fees
//---------------------------------
Edit_Currency_WithStaff_fees(i_Currency, i_Staff_fees_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Staff_fees_By_Currency");}
}
#endregion
#region Edit_Currency_With_Staff_fees(Currency i_Currency,List<Staff_fees> i_Staff_feesList)
public void Edit_Currency_WithStaff_fees(Currency i_Currency,List<Staff_fees> i_List_Staff_fees)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Currency_WithStaff_fees");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Currency(i_Currency);
if (i_List_Staff_fees != null)
{
foreach(Staff_fees oStaff_fees in i_List_Staff_fees)
{
oStaff_fees.CURRENCY_ID = i_Currency.CURRENCY_ID;
Edit_Staff_fees(oStaff_fees);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Currency_WithStaff_fees");}
}
#endregion
#region Reset_Supplier_fees_By_Currency
public void Reset_Supplier_fees_By_Currency(Currency i_Currency, List<Supplier_fees> i_Supplier_fees_List)
{
#region Declaration And Initialization Section.
Params_Delete_Supplier_fees_By_CURRENCY_ID oParams_Delete_Supplier_fees_By_CURRENCY_ID = new Params_Delete_Supplier_fees_By_CURRENCY_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Supplier_fees_By_Currency");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Supplier_fees
//---------------------------------
oParams_Delete_Supplier_fees_By_CURRENCY_ID.CURRENCY_ID = i_Currency.CURRENCY_ID;
Delete_Supplier_fees_By_CURRENCY_ID(oParams_Delete_Supplier_fees_By_CURRENCY_ID);
//---------------------------------
// Edit Supplier_fees
//---------------------------------
Edit_Currency_WithSupplier_fees(i_Currency, i_Supplier_fees_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Supplier_fees_By_Currency");}
}
#endregion
#region Reset_Supplier_fees_By_Currency
public void Reset_Supplier_fees_By_Currency(Currency i_Currency, List<Supplier_fees> i_Supplier_fees_List_To_Delete,List<Supplier_fees> i_Supplier_fees_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Supplier_fees oParams_Delete_Supplier_fees = new Params_Delete_Supplier_fees();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Supplier_fees_By_Currency");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Supplier_fees_List_To_Delete != null)
{
foreach (var oRow in i_Supplier_fees_List_To_Delete)
{
oParams_Delete_Supplier_fees.SUPPLIER_FEES_ID = oRow.SUPPLIER_FEES_ID;
Delete_Supplier_fees(oParams_Delete_Supplier_fees);
}
}
//---------------------------------
// Edit Supplier_fees
//---------------------------------
Edit_Currency_WithSupplier_fees(i_Currency, i_Supplier_fees_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Supplier_fees_By_Currency");}
}
#endregion
#region Edit_Currency_With_Supplier_fees(Currency i_Currency,List<Supplier_fees> i_Supplier_feesList)
public void Edit_Currency_WithSupplier_fees(Currency i_Currency,List<Supplier_fees> i_List_Supplier_fees)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Currency_WithSupplier_fees");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Currency(i_Currency);
if (i_List_Supplier_fees != null)
{
foreach(Supplier_fees oSupplier_fees in i_List_Supplier_fees)
{
oSupplier_fees.CURRENCY_ID = i_Currency.CURRENCY_ID;
Edit_Supplier_fees(oSupplier_fees);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Currency_WithSupplier_fees");}
}
#endregion
#region Edit_Currency_WithRelatedData(Currency i_Currency,List<Client_fees> i_List_Client_fees,List<Fees> i_List_Fees,List<Package> i_List_Package,List<Staff_fees> i_List_Staff_fees,List<Supplier_fees> i_List_Supplier_fees)
public void Edit_Currency_WithRelatedData(Currency i_Currency,List<Client_fees> i_List_Client_fees,List<Fees> i_List_Fees,List<Package> i_List_Package,List<Staff_fees> i_List_Staff_fees,List<Supplier_fees> i_List_Supplier_fees)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Currency_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Currency(i_Currency);
if (i_List_Client_fees != null)
{
foreach(Client_fees oClient_fees in i_List_Client_fees)
{
oClient_fees.CURRENCY_ID = i_Currency.CURRENCY_ID;
Edit_Client_fees(oClient_fees);
}
}
if (i_List_Fees != null)
{
foreach(Fees oFees in i_List_Fees)
{
oFees.CURRENCY_ID = i_Currency.CURRENCY_ID;
Edit_Fees(oFees);
}
}
if (i_List_Package != null)
{
foreach(Package oPackage in i_List_Package)
{
oPackage.CURRENCY_ID = i_Currency.CURRENCY_ID;
Edit_Package(oPackage);
}
}
if (i_List_Staff_fees != null)
{
foreach(Staff_fees oStaff_fees in i_List_Staff_fees)
{
oStaff_fees.CURRENCY_ID = i_Currency.CURRENCY_ID;
Edit_Staff_fees(oStaff_fees);
}
}
if (i_List_Supplier_fees != null)
{
foreach(Supplier_fees oSupplier_fees in i_List_Supplier_fees)
{
oSupplier_fees.CURRENCY_ID = i_Currency.CURRENCY_ID;
Edit_Supplier_fees(oSupplier_fees);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Currency_WithRelatedData");}
}
#endregion
#region Delete_Currency_With_Children(Currency i_Currency)
public void Delete_Currency_With_Children(Currency i_Currency)
{
 #region Declaration And Initialization Section.
Params_Delete_Currency oParams_Delete_Currency = new Params_Delete_Currency();
Params_Delete_Client_fees_By_CURRENCY_ID oParams_Delete_Client_fees_By_CURRENCY_ID = new Params_Delete_Client_fees_By_CURRENCY_ID();
Params_Delete_Fees_By_CURRENCY_ID oParams_Delete_Fees_By_CURRENCY_ID = new Params_Delete_Fees_By_CURRENCY_ID();
Params_Delete_Package_By_CURRENCY_ID oParams_Delete_Package_By_CURRENCY_ID = new Params_Delete_Package_By_CURRENCY_ID();
Params_Delete_Staff_fees_By_CURRENCY_ID oParams_Delete_Staff_fees_By_CURRENCY_ID = new Params_Delete_Staff_fees_By_CURRENCY_ID();
Params_Delete_Supplier_fees_By_CURRENCY_ID oParams_Delete_Supplier_fees_By_CURRENCY_ID = new Params_Delete_Supplier_fees_By_CURRENCY_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Currency_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Client_fees_By_CURRENCY_ID.CURRENCY_ID = i_Currency.CURRENCY_ID;
Delete_Client_fees_By_CURRENCY_ID(oParams_Delete_Client_fees_By_CURRENCY_ID);
oParams_Delete_Fees_By_CURRENCY_ID.CURRENCY_ID = i_Currency.CURRENCY_ID;
Delete_Fees_By_CURRENCY_ID(oParams_Delete_Fees_By_CURRENCY_ID);
oParams_Delete_Package_By_CURRENCY_ID.CURRENCY_ID = i_Currency.CURRENCY_ID;
Delete_Package_By_CURRENCY_ID(oParams_Delete_Package_By_CURRENCY_ID);
oParams_Delete_Staff_fees_By_CURRENCY_ID.CURRENCY_ID = i_Currency.CURRENCY_ID;
Delete_Staff_fees_By_CURRENCY_ID(oParams_Delete_Staff_fees_By_CURRENCY_ID);
oParams_Delete_Supplier_fees_By_CURRENCY_ID.CURRENCY_ID = i_Currency.CURRENCY_ID;
Delete_Supplier_fees_By_CURRENCY_ID(oParams_Delete_Supplier_fees_By_CURRENCY_ID);
//-------------------------

//-------------------------
oParams_Delete_Currency.CURRENCY_ID = i_Currency.CURRENCY_ID;
Delete_Currency(oParams_Delete_Currency);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Currency_With_Children");}
}
#endregion
#region Reset_Address_By_Loc_l1
public void Reset_Address_By_Loc_l1(Loc_l1 i_Loc_l1, List<Address> i_Address_List)
{
#region Declaration And Initialization Section.
Params_Delete_Address_By_LOC_L1_ID oParams_Delete_Address_By_LOC_L1_ID = new Params_Delete_Address_By_LOC_L1_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Address_By_Loc_l1");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Address
//---------------------------------
oParams_Delete_Address_By_LOC_L1_ID.LOC_L1_ID = i_Loc_l1.LOC_L1_ID;
Delete_Address_By_LOC_L1_ID(oParams_Delete_Address_By_LOC_L1_ID);
//---------------------------------
// Edit Address
//---------------------------------
Edit_Loc_l1_WithAddress(i_Loc_l1, i_Address_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Address_By_Loc_l1");}
}
#endregion
#region Reset_Address_By_Loc_l1
public void Reset_Address_By_Loc_l1(Loc_l1 i_Loc_l1, List<Address> i_Address_List_To_Delete,List<Address> i_Address_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Address oParams_Delete_Address = new Params_Delete_Address();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Address_By_Loc_l1");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Address_List_To_Delete != null)
{
foreach (var oRow in i_Address_List_To_Delete)
{
oParams_Delete_Address.ADDRESS_ID = oRow.ADDRESS_ID;
Delete_Address(oParams_Delete_Address);
}
}
//---------------------------------
// Edit Address
//---------------------------------
Edit_Loc_l1_WithAddress(i_Loc_l1, i_Address_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Address_By_Loc_l1");}
}
#endregion
#region Edit_Loc_l1_With_Address(Loc_l1 i_Loc_l1,List<Address> i_AddressList)
public void Edit_Loc_l1_WithAddress(Loc_l1 i_Loc_l1,List<Address> i_List_Address)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l1_WithAddress");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Loc_l1(i_Loc_l1);
if (i_List_Address != null)
{
foreach(Address oAddress in i_List_Address)
{
oAddress.LOC_L1_ID = i_Loc_l1.LOC_L1_ID;
Edit_Address(oAddress);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l1_WithAddress");}
}
#endregion
#region Reset_Loc_l2_By_Loc_l1
public void Reset_Loc_l2_By_Loc_l1(Loc_l1 i_Loc_l1, List<Loc_l2> i_Loc_l2_List)
{
#region Declaration And Initialization Section.
Params_Delete_Loc_l2_By_LOC_L1_ID oParams_Delete_Loc_l2_By_LOC_L1_ID = new Params_Delete_Loc_l2_By_LOC_L1_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Loc_l2_By_Loc_l1");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Loc_l2
//---------------------------------
oParams_Delete_Loc_l2_By_LOC_L1_ID.LOC_L1_ID = i_Loc_l1.LOC_L1_ID;
Delete_Loc_l2_By_LOC_L1_ID(oParams_Delete_Loc_l2_By_LOC_L1_ID);
//---------------------------------
// Edit Loc_l2
//---------------------------------
Edit_Loc_l1_WithLoc_l2(i_Loc_l1, i_Loc_l2_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Loc_l2_By_Loc_l1");}
}
#endregion
#region Reset_Loc_l2_By_Loc_l1
public void Reset_Loc_l2_By_Loc_l1(Loc_l1 i_Loc_l1, List<Loc_l2> i_Loc_l2_List_To_Delete,List<Loc_l2> i_Loc_l2_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Loc_l2 oParams_Delete_Loc_l2 = new Params_Delete_Loc_l2();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Loc_l2_By_Loc_l1");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Loc_l2_List_To_Delete != null)
{
foreach (var oRow in i_Loc_l2_List_To_Delete)
{
oParams_Delete_Loc_l2.LOC_L2_ID = oRow.LOC_L2_ID;
Delete_Loc_l2(oParams_Delete_Loc_l2);
}
}
//---------------------------------
// Edit Loc_l2
//---------------------------------
Edit_Loc_l1_WithLoc_l2(i_Loc_l1, i_Loc_l2_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Loc_l2_By_Loc_l1");}
}
#endregion
#region Edit_Loc_l1_With_Loc_l2(Loc_l1 i_Loc_l1,List<Loc_l2> i_Loc_l2List)
public void Edit_Loc_l1_WithLoc_l2(Loc_l1 i_Loc_l1,List<Loc_l2> i_List_Loc_l2)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l1_WithLoc_l2");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Loc_l1(i_Loc_l1);
if (i_List_Loc_l2 != null)
{
foreach(Loc_l2 oLoc_l2 in i_List_Loc_l2)
{
oLoc_l2.LOC_L1_ID = i_Loc_l1.LOC_L1_ID;
Edit_Loc_l2(oLoc_l2);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l1_WithLoc_l2");}
}
#endregion
#region Edit_Loc_l1_WithRelatedData(Loc_l1 i_Loc_l1,List<Address> i_List_Address,List<Loc_l2> i_List_Loc_l2)
public void Edit_Loc_l1_WithRelatedData(Loc_l1 i_Loc_l1,List<Address> i_List_Address,List<Loc_l2> i_List_Loc_l2)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l1_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Loc_l1(i_Loc_l1);
if (i_List_Address != null)
{
foreach(Address oAddress in i_List_Address)
{
oAddress.LOC_L1_ID = i_Loc_l1.LOC_L1_ID;
Edit_Address(oAddress);
}
}
if (i_List_Loc_l2 != null)
{
foreach(Loc_l2 oLoc_l2 in i_List_Loc_l2)
{
oLoc_l2.LOC_L1_ID = i_Loc_l1.LOC_L1_ID;
Edit_Loc_l2(oLoc_l2);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l1_WithRelatedData");}
}
#endregion
#region Delete_Loc_l1_With_Children(Loc_l1 i_Loc_l1)
public void Delete_Loc_l1_With_Children(Loc_l1 i_Loc_l1)
{
 #region Declaration And Initialization Section.
Params_Delete_Loc_l1 oParams_Delete_Loc_l1 = new Params_Delete_Loc_l1();
Params_Delete_Address_By_LOC_L1_ID oParams_Delete_Address_By_LOC_L1_ID = new Params_Delete_Address_By_LOC_L1_ID();
Params_Delete_Loc_l2_By_LOC_L1_ID oParams_Delete_Loc_l2_By_LOC_L1_ID = new Params_Delete_Loc_l2_By_LOC_L1_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l1_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Address_By_LOC_L1_ID.LOC_L1_ID = i_Loc_l1.LOC_L1_ID;
Delete_Address_By_LOC_L1_ID(oParams_Delete_Address_By_LOC_L1_ID);
oParams_Delete_Loc_l2_By_LOC_L1_ID.LOC_L1_ID = i_Loc_l1.LOC_L1_ID;
Delete_Loc_l2_By_LOC_L1_ID(oParams_Delete_Loc_l2_By_LOC_L1_ID);
//-------------------------

//-------------------------
oParams_Delete_Loc_l1.LOC_L1_ID = i_Loc_l1.LOC_L1_ID;
Delete_Loc_l1(oParams_Delete_Loc_l1);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l1_With_Children");}
}
#endregion
#region Reset_Address_By_Loc_l2
public void Reset_Address_By_Loc_l2(Loc_l2 i_Loc_l2, List<Address> i_Address_List)
{
#region Declaration And Initialization Section.
Params_Delete_Address_By_LOC_L2_ID oParams_Delete_Address_By_LOC_L2_ID = new Params_Delete_Address_By_LOC_L2_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Address_By_Loc_l2");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Address
//---------------------------------
oParams_Delete_Address_By_LOC_L2_ID.LOC_L2_ID = i_Loc_l2.LOC_L2_ID;
Delete_Address_By_LOC_L2_ID(oParams_Delete_Address_By_LOC_L2_ID);
//---------------------------------
// Edit Address
//---------------------------------
Edit_Loc_l2_WithAddress(i_Loc_l2, i_Address_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Address_By_Loc_l2");}
}
#endregion
#region Reset_Address_By_Loc_l2
public void Reset_Address_By_Loc_l2(Loc_l2 i_Loc_l2, List<Address> i_Address_List_To_Delete,List<Address> i_Address_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Address oParams_Delete_Address = new Params_Delete_Address();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Address_By_Loc_l2");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Address_List_To_Delete != null)
{
foreach (var oRow in i_Address_List_To_Delete)
{
oParams_Delete_Address.ADDRESS_ID = oRow.ADDRESS_ID;
Delete_Address(oParams_Delete_Address);
}
}
//---------------------------------
// Edit Address
//---------------------------------
Edit_Loc_l2_WithAddress(i_Loc_l2, i_Address_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Address_By_Loc_l2");}
}
#endregion
#region Edit_Loc_l2_With_Address(Loc_l2 i_Loc_l2,List<Address> i_AddressList)
public void Edit_Loc_l2_WithAddress(Loc_l2 i_Loc_l2,List<Address> i_List_Address)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l2_WithAddress");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Loc_l2(i_Loc_l2);
if (i_List_Address != null)
{
foreach(Address oAddress in i_List_Address)
{
oAddress.LOC_L2_ID = i_Loc_l2.LOC_L2_ID;
Edit_Address(oAddress);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l2_WithAddress");}
}
#endregion
#region Reset_Loc_l3_By_Loc_l2
public void Reset_Loc_l3_By_Loc_l2(Loc_l2 i_Loc_l2, List<Loc_l3> i_Loc_l3_List)
{
#region Declaration And Initialization Section.
Params_Delete_Loc_l3_By_LOC_L2_ID oParams_Delete_Loc_l3_By_LOC_L2_ID = new Params_Delete_Loc_l3_By_LOC_L2_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Loc_l3_By_Loc_l2");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Loc_l3
//---------------------------------
oParams_Delete_Loc_l3_By_LOC_L2_ID.LOC_L2_ID = i_Loc_l2.LOC_L2_ID;
Delete_Loc_l3_By_LOC_L2_ID(oParams_Delete_Loc_l3_By_LOC_L2_ID);
//---------------------------------
// Edit Loc_l3
//---------------------------------
Edit_Loc_l2_WithLoc_l3(i_Loc_l2, i_Loc_l3_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Loc_l3_By_Loc_l2");}
}
#endregion
#region Reset_Loc_l3_By_Loc_l2
public void Reset_Loc_l3_By_Loc_l2(Loc_l2 i_Loc_l2, List<Loc_l3> i_Loc_l3_List_To_Delete,List<Loc_l3> i_Loc_l3_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Loc_l3 oParams_Delete_Loc_l3 = new Params_Delete_Loc_l3();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Loc_l3_By_Loc_l2");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Loc_l3_List_To_Delete != null)
{
foreach (var oRow in i_Loc_l3_List_To_Delete)
{
oParams_Delete_Loc_l3.LOC_L3_ID = oRow.LOC_L3_ID;
Delete_Loc_l3(oParams_Delete_Loc_l3);
}
}
//---------------------------------
// Edit Loc_l3
//---------------------------------
Edit_Loc_l2_WithLoc_l3(i_Loc_l2, i_Loc_l3_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Loc_l3_By_Loc_l2");}
}
#endregion
#region Edit_Loc_l2_With_Loc_l3(Loc_l2 i_Loc_l2,List<Loc_l3> i_Loc_l3List)
public void Edit_Loc_l2_WithLoc_l3(Loc_l2 i_Loc_l2,List<Loc_l3> i_List_Loc_l3)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l2_WithLoc_l3");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Loc_l2(i_Loc_l2);
if (i_List_Loc_l3 != null)
{
foreach(Loc_l3 oLoc_l3 in i_List_Loc_l3)
{
oLoc_l3.LOC_L2_ID = i_Loc_l2.LOC_L2_ID;
Edit_Loc_l3(oLoc_l3);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l2_WithLoc_l3");}
}
#endregion
#region Edit_Loc_l2_WithRelatedData(Loc_l2 i_Loc_l2,List<Address> i_List_Address,List<Loc_l3> i_List_Loc_l3)
public void Edit_Loc_l2_WithRelatedData(Loc_l2 i_Loc_l2,List<Address> i_List_Address,List<Loc_l3> i_List_Loc_l3)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l2_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Loc_l2(i_Loc_l2);
if (i_List_Address != null)
{
foreach(Address oAddress in i_List_Address)
{
oAddress.LOC_L2_ID = i_Loc_l2.LOC_L2_ID;
Edit_Address(oAddress);
}
}
if (i_List_Loc_l3 != null)
{
foreach(Loc_l3 oLoc_l3 in i_List_Loc_l3)
{
oLoc_l3.LOC_L2_ID = i_Loc_l2.LOC_L2_ID;
Edit_Loc_l3(oLoc_l3);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l2_WithRelatedData");}
}
#endregion
#region Delete_Loc_l2_With_Children(Loc_l2 i_Loc_l2)
public void Delete_Loc_l2_With_Children(Loc_l2 i_Loc_l2)
{
 #region Declaration And Initialization Section.
Params_Delete_Loc_l2 oParams_Delete_Loc_l2 = new Params_Delete_Loc_l2();
Params_Delete_Address_By_LOC_L2_ID oParams_Delete_Address_By_LOC_L2_ID = new Params_Delete_Address_By_LOC_L2_ID();
Params_Delete_Loc_l3_By_LOC_L2_ID oParams_Delete_Loc_l3_By_LOC_L2_ID = new Params_Delete_Loc_l3_By_LOC_L2_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l2_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Address_By_LOC_L2_ID.LOC_L2_ID = i_Loc_l2.LOC_L2_ID;
Delete_Address_By_LOC_L2_ID(oParams_Delete_Address_By_LOC_L2_ID);
oParams_Delete_Loc_l3_By_LOC_L2_ID.LOC_L2_ID = i_Loc_l2.LOC_L2_ID;
Delete_Loc_l3_By_LOC_L2_ID(oParams_Delete_Loc_l3_By_LOC_L2_ID);
//-------------------------

//-------------------------
oParams_Delete_Loc_l2.LOC_L2_ID = i_Loc_l2.LOC_L2_ID;
Delete_Loc_l2(oParams_Delete_Loc_l2);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l2_With_Children");}
}
#endregion
#region Reset_Address_By_Loc_l3
public void Reset_Address_By_Loc_l3(Loc_l3 i_Loc_l3, List<Address> i_Address_List)
{
#region Declaration And Initialization Section.
Params_Delete_Address_By_LOC_L3_ID oParams_Delete_Address_By_LOC_L3_ID = new Params_Delete_Address_By_LOC_L3_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Address_By_Loc_l3");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Address
//---------------------------------
oParams_Delete_Address_By_LOC_L3_ID.LOC_L3_ID = i_Loc_l3.LOC_L3_ID;
Delete_Address_By_LOC_L3_ID(oParams_Delete_Address_By_LOC_L3_ID);
//---------------------------------
// Edit Address
//---------------------------------
Edit_Loc_l3_WithAddress(i_Loc_l3, i_Address_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Address_By_Loc_l3");}
}
#endregion
#region Reset_Address_By_Loc_l3
public void Reset_Address_By_Loc_l3(Loc_l3 i_Loc_l3, List<Address> i_Address_List_To_Delete,List<Address> i_Address_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Address oParams_Delete_Address = new Params_Delete_Address();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Address_By_Loc_l3");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Address_List_To_Delete != null)
{
foreach (var oRow in i_Address_List_To_Delete)
{
oParams_Delete_Address.ADDRESS_ID = oRow.ADDRESS_ID;
Delete_Address(oParams_Delete_Address);
}
}
//---------------------------------
// Edit Address
//---------------------------------
Edit_Loc_l3_WithAddress(i_Loc_l3, i_Address_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Address_By_Loc_l3");}
}
#endregion
#region Edit_Loc_l3_With_Address(Loc_l3 i_Loc_l3,List<Address> i_AddressList)
public void Edit_Loc_l3_WithAddress(Loc_l3 i_Loc_l3,List<Address> i_List_Address)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l3_WithAddress");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Loc_l3(i_Loc_l3);
if (i_List_Address != null)
{
foreach(Address oAddress in i_List_Address)
{
oAddress.LOC_L3_ID = i_Loc_l3.LOC_L3_ID;
Edit_Address(oAddress);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l3_WithAddress");}
}
#endregion
#region Reset_Loc_l4_By_Loc_l3
public void Reset_Loc_l4_By_Loc_l3(Loc_l3 i_Loc_l3, List<Loc_l4> i_Loc_l4_List)
{
#region Declaration And Initialization Section.
Params_Delete_Loc_l4_By_LOC_L3_ID oParams_Delete_Loc_l4_By_LOC_L3_ID = new Params_Delete_Loc_l4_By_LOC_L3_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Loc_l4_By_Loc_l3");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Loc_l4
//---------------------------------
oParams_Delete_Loc_l4_By_LOC_L3_ID.LOC_L3_ID = i_Loc_l3.LOC_L3_ID;
Delete_Loc_l4_By_LOC_L3_ID(oParams_Delete_Loc_l4_By_LOC_L3_ID);
//---------------------------------
// Edit Loc_l4
//---------------------------------
Edit_Loc_l3_WithLoc_l4(i_Loc_l3, i_Loc_l4_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Loc_l4_By_Loc_l3");}
}
#endregion
#region Reset_Loc_l4_By_Loc_l3
public void Reset_Loc_l4_By_Loc_l3(Loc_l3 i_Loc_l3, List<Loc_l4> i_Loc_l4_List_To_Delete,List<Loc_l4> i_Loc_l4_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Loc_l4 oParams_Delete_Loc_l4 = new Params_Delete_Loc_l4();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Loc_l4_By_Loc_l3");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Loc_l4_List_To_Delete != null)
{
foreach (var oRow in i_Loc_l4_List_To_Delete)
{
oParams_Delete_Loc_l4.LOC_L4_ID = oRow.LOC_L4_ID;
Delete_Loc_l4(oParams_Delete_Loc_l4);
}
}
//---------------------------------
// Edit Loc_l4
//---------------------------------
Edit_Loc_l3_WithLoc_l4(i_Loc_l3, i_Loc_l4_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Loc_l4_By_Loc_l3");}
}
#endregion
#region Edit_Loc_l3_With_Loc_l4(Loc_l3 i_Loc_l3,List<Loc_l4> i_Loc_l4List)
public void Edit_Loc_l3_WithLoc_l4(Loc_l3 i_Loc_l3,List<Loc_l4> i_List_Loc_l4)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l3_WithLoc_l4");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Loc_l3(i_Loc_l3);
if (i_List_Loc_l4 != null)
{
foreach(Loc_l4 oLoc_l4 in i_List_Loc_l4)
{
oLoc_l4.LOC_L3_ID = i_Loc_l3.LOC_L3_ID;
Edit_Loc_l4(oLoc_l4);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l3_WithLoc_l4");}
}
#endregion
#region Edit_Loc_l3_WithRelatedData(Loc_l3 i_Loc_l3,List<Address> i_List_Address,List<Loc_l4> i_List_Loc_l4)
public void Edit_Loc_l3_WithRelatedData(Loc_l3 i_Loc_l3,List<Address> i_List_Address,List<Loc_l4> i_List_Loc_l4)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l3_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Loc_l3(i_Loc_l3);
if (i_List_Address != null)
{
foreach(Address oAddress in i_List_Address)
{
oAddress.LOC_L3_ID = i_Loc_l3.LOC_L3_ID;
Edit_Address(oAddress);
}
}
if (i_List_Loc_l4 != null)
{
foreach(Loc_l4 oLoc_l4 in i_List_Loc_l4)
{
oLoc_l4.LOC_L3_ID = i_Loc_l3.LOC_L3_ID;
Edit_Loc_l4(oLoc_l4);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l3_WithRelatedData");}
}
#endregion
#region Delete_Loc_l3_With_Children(Loc_l3 i_Loc_l3)
public void Delete_Loc_l3_With_Children(Loc_l3 i_Loc_l3)
{
 #region Declaration And Initialization Section.
Params_Delete_Loc_l3 oParams_Delete_Loc_l3 = new Params_Delete_Loc_l3();
Params_Delete_Address_By_LOC_L3_ID oParams_Delete_Address_By_LOC_L3_ID = new Params_Delete_Address_By_LOC_L3_ID();
Params_Delete_Loc_l4_By_LOC_L3_ID oParams_Delete_Loc_l4_By_LOC_L3_ID = new Params_Delete_Loc_l4_By_LOC_L3_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l3_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Address_By_LOC_L3_ID.LOC_L3_ID = i_Loc_l3.LOC_L3_ID;
Delete_Address_By_LOC_L3_ID(oParams_Delete_Address_By_LOC_L3_ID);
oParams_Delete_Loc_l4_By_LOC_L3_ID.LOC_L3_ID = i_Loc_l3.LOC_L3_ID;
Delete_Loc_l4_By_LOC_L3_ID(oParams_Delete_Loc_l4_By_LOC_L3_ID);
//-------------------------

//-------------------------
oParams_Delete_Loc_l3.LOC_L3_ID = i_Loc_l3.LOC_L3_ID;
Delete_Loc_l3(oParams_Delete_Loc_l3);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l3_With_Children");}
}
#endregion
#region Reset_Address_By_Loc_l4
public void Reset_Address_By_Loc_l4(Loc_l4 i_Loc_l4, List<Address> i_Address_List)
{
#region Declaration And Initialization Section.
Params_Delete_Address_By_LOC_L4_ID oParams_Delete_Address_By_LOC_L4_ID = new Params_Delete_Address_By_LOC_L4_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Address_By_Loc_l4");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Address
//---------------------------------
oParams_Delete_Address_By_LOC_L4_ID.LOC_L4_ID = i_Loc_l4.LOC_L4_ID;
Delete_Address_By_LOC_L4_ID(oParams_Delete_Address_By_LOC_L4_ID);
//---------------------------------
// Edit Address
//---------------------------------
Edit_Loc_l4_WithAddress(i_Loc_l4, i_Address_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Address_By_Loc_l4");}
}
#endregion
#region Reset_Address_By_Loc_l4
public void Reset_Address_By_Loc_l4(Loc_l4 i_Loc_l4, List<Address> i_Address_List_To_Delete,List<Address> i_Address_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Address oParams_Delete_Address = new Params_Delete_Address();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Address_By_Loc_l4");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Address_List_To_Delete != null)
{
foreach (var oRow in i_Address_List_To_Delete)
{
oParams_Delete_Address.ADDRESS_ID = oRow.ADDRESS_ID;
Delete_Address(oParams_Delete_Address);
}
}
//---------------------------------
// Edit Address
//---------------------------------
Edit_Loc_l4_WithAddress(i_Loc_l4, i_Address_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Address_By_Loc_l4");}
}
#endregion
#region Edit_Loc_l4_With_Address(Loc_l4 i_Loc_l4,List<Address> i_AddressList)
public void Edit_Loc_l4_WithAddress(Loc_l4 i_Loc_l4,List<Address> i_List_Address)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l4_WithAddress");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Loc_l4(i_Loc_l4);
if (i_List_Address != null)
{
foreach(Address oAddress in i_List_Address)
{
oAddress.LOC_L4_ID = i_Loc_l4.LOC_L4_ID;
Edit_Address(oAddress);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l4_WithAddress");}
}
#endregion
#region Edit_Loc_l4_WithRelatedData(Loc_l4 i_Loc_l4,List<Address> i_List_Address)
public void Edit_Loc_l4_WithRelatedData(Loc_l4 i_Loc_l4,List<Address> i_List_Address)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l4_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Loc_l4(i_Loc_l4);
if (i_List_Address != null)
{
foreach(Address oAddress in i_List_Address)
{
oAddress.LOC_L4_ID = i_Loc_l4.LOC_L4_ID;
Edit_Address(oAddress);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l4_WithRelatedData");}
}
#endregion
#region Delete_Loc_l4_With_Children(Loc_l4 i_Loc_l4)
public void Delete_Loc_l4_With_Children(Loc_l4 i_Loc_l4)
{
 #region Declaration And Initialization Section.
Params_Delete_Loc_l4 oParams_Delete_Loc_l4 = new Params_Delete_Loc_l4();
Params_Delete_Address_By_LOC_L4_ID oParams_Delete_Address_By_LOC_L4_ID = new Params_Delete_Address_By_LOC_L4_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l4_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Address_By_LOC_L4_ID.LOC_L4_ID = i_Loc_l4.LOC_L4_ID;
Delete_Address_By_LOC_L4_ID(oParams_Delete_Address_By_LOC_L4_ID);
//-------------------------

//-------------------------
oParams_Delete_Loc_l4.LOC_L4_ID = i_Loc_l4.LOC_L4_ID;
Delete_Loc_l4(oParams_Delete_Loc_l4);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l4_With_Children");}
}
#endregion
#region Reset_Client_fees_By_Package
public void Reset_Client_fees_By_Package(Package i_Package, List<Client_fees> i_Client_fees_List)
{
#region Declaration And Initialization Section.
Params_Delete_Client_fees_By_PACKAGE_ID oParams_Delete_Client_fees_By_PACKAGE_ID = new Params_Delete_Client_fees_By_PACKAGE_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Client_fees_By_Package");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Client_fees
//---------------------------------
oParams_Delete_Client_fees_By_PACKAGE_ID.PACKAGE_ID = i_Package.PACKAGE_ID;
Delete_Client_fees_By_PACKAGE_ID(oParams_Delete_Client_fees_By_PACKAGE_ID);
//---------------------------------
// Edit Client_fees
//---------------------------------
Edit_Package_WithClient_fees(i_Package, i_Client_fees_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Client_fees_By_Package");}
}
#endregion
#region Reset_Client_fees_By_Package
public void Reset_Client_fees_By_Package(Package i_Package, List<Client_fees> i_Client_fees_List_To_Delete,List<Client_fees> i_Client_fees_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Client_fees oParams_Delete_Client_fees = new Params_Delete_Client_fees();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Client_fees_By_Package");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Client_fees_List_To_Delete != null)
{
foreach (var oRow in i_Client_fees_List_To_Delete)
{
oParams_Delete_Client_fees.CLIENT_FEES_ID = oRow.CLIENT_FEES_ID;
Delete_Client_fees(oParams_Delete_Client_fees);
}
}
//---------------------------------
// Edit Client_fees
//---------------------------------
Edit_Package_WithClient_fees(i_Package, i_Client_fees_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Client_fees_By_Package");}
}
#endregion
#region Edit_Package_With_Client_fees(Package i_Package,List<Client_fees> i_Client_feesList)
public void Edit_Package_WithClient_fees(Package i_Package,List<Client_fees> i_List_Client_fees)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Package_WithClient_fees");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Package(i_Package);
if (i_List_Client_fees != null)
{
foreach(Client_fees oClient_fees in i_List_Client_fees)
{
oClient_fees.PACKAGE_ID = i_Package.PACKAGE_ID;
Edit_Client_fees(oClient_fees);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Package_WithClient_fees");}
}
#endregion
#region Reset_Session_By_Package
public void Reset_Session_By_Package(Package i_Package, List<Session> i_Session_List)
{
#region Declaration And Initialization Section.
Params_Delete_Session_By_PACKAGE_ID oParams_Delete_Session_By_PACKAGE_ID = new Params_Delete_Session_By_PACKAGE_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Session_By_Package");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Session
//---------------------------------
oParams_Delete_Session_By_PACKAGE_ID.PACKAGE_ID = i_Package.PACKAGE_ID;
Delete_Session_By_PACKAGE_ID(oParams_Delete_Session_By_PACKAGE_ID);
//---------------------------------
// Edit Session
//---------------------------------
Edit_Package_WithSession(i_Package, i_Session_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Session_By_Package");}
}
#endregion
#region Reset_Session_By_Package
public void Reset_Session_By_Package(Package i_Package, List<Session> i_Session_List_To_Delete,List<Session> i_Session_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Session oParams_Delete_Session = new Params_Delete_Session();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Session_By_Package");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Session_List_To_Delete != null)
{
foreach (var oRow in i_Session_List_To_Delete)
{
oParams_Delete_Session.SESSION_ID = oRow.SESSION_ID;
Delete_Session(oParams_Delete_Session);
}
}
//---------------------------------
// Edit Session
//---------------------------------
Edit_Package_WithSession(i_Package, i_Session_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Session_By_Package");}
}
#endregion
#region Edit_Package_With_Session(Package i_Package,List<Session> i_SessionList)
public void Edit_Package_WithSession(Package i_Package,List<Session> i_List_Session)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Package_WithSession");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Package(i_Package);
if (i_List_Session != null)
{
foreach(Session oSession in i_List_Session)
{
oSession.PACKAGE_ID = i_Package.PACKAGE_ID;
Edit_Session(oSession);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Package_WithSession");}
}
#endregion
#region Edit_Package_WithRelatedData(Package i_Package,List<Client_fees> i_List_Client_fees,List<Session> i_List_Session)
public void Edit_Package_WithRelatedData(Package i_Package,List<Client_fees> i_List_Client_fees,List<Session> i_List_Session)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Package_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Package(i_Package);
if (i_List_Client_fees != null)
{
foreach(Client_fees oClient_fees in i_List_Client_fees)
{
oClient_fees.PACKAGE_ID = i_Package.PACKAGE_ID;
Edit_Client_fees(oClient_fees);
}
}
if (i_List_Session != null)
{
foreach(Session oSession in i_List_Session)
{
oSession.PACKAGE_ID = i_Package.PACKAGE_ID;
Edit_Session(oSession);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Package_WithRelatedData");}
}
#endregion
#region Delete_Package_With_Children(Package i_Package)
public void Delete_Package_With_Children(Package i_Package)
{
 #region Declaration And Initialization Section.
Params_Delete_Package oParams_Delete_Package = new Params_Delete_Package();
Params_Delete_Client_fees_By_PACKAGE_ID oParams_Delete_Client_fees_By_PACKAGE_ID = new Params_Delete_Client_fees_By_PACKAGE_ID();
Params_Delete_Session_By_PACKAGE_ID oParams_Delete_Session_By_PACKAGE_ID = new Params_Delete_Session_By_PACKAGE_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Package_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Client_fees_By_PACKAGE_ID.PACKAGE_ID = i_Package.PACKAGE_ID;
Delete_Client_fees_By_PACKAGE_ID(oParams_Delete_Client_fees_By_PACKAGE_ID);
oParams_Delete_Session_By_PACKAGE_ID.PACKAGE_ID = i_Package.PACKAGE_ID;
Delete_Session_By_PACKAGE_ID(oParams_Delete_Session_By_PACKAGE_ID);
//-------------------------

//-------------------------
oParams_Delete_Package.PACKAGE_ID = i_Package.PACKAGE_ID;
Delete_Package(oParams_Delete_Package);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Package_With_Children");}
}
#endregion
#region Reset_Address_By_Person
public void Reset_Address_By_Person(Person i_Person, List<Address> i_Address_List)
{
#region Declaration And Initialization Section.
Params_Delete_Address_By_PERSON_ID oParams_Delete_Address_By_PERSON_ID = new Params_Delete_Address_By_PERSON_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Address_By_Person");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Address
//---------------------------------
oParams_Delete_Address_By_PERSON_ID.PERSON_ID = i_Person.PERSON_ID;
Delete_Address_By_PERSON_ID(oParams_Delete_Address_By_PERSON_ID);
//---------------------------------
// Edit Address
//---------------------------------
Edit_Person_WithAddress(i_Person, i_Address_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Address_By_Person");}
}
#endregion
#region Reset_Address_By_Person
public void Reset_Address_By_Person(Person i_Person, List<Address> i_Address_List_To_Delete,List<Address> i_Address_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Address oParams_Delete_Address = new Params_Delete_Address();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Address_By_Person");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Address_List_To_Delete != null)
{
foreach (var oRow in i_Address_List_To_Delete)
{
oParams_Delete_Address.ADDRESS_ID = oRow.ADDRESS_ID;
Delete_Address(oParams_Delete_Address);
}
}
//---------------------------------
// Edit Address
//---------------------------------
Edit_Person_WithAddress(i_Person, i_Address_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Address_By_Person");}
}
#endregion
#region Edit_Person_With_Address(Person i_Person,List<Address> i_AddressList)
public void Edit_Person_WithAddress(Person i_Person,List<Address> i_List_Address)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Person_WithAddress");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Person(i_Person);
if (i_List_Address != null)
{
foreach(Address oAddress in i_List_Address)
{
oAddress.PERSON_ID = i_Person.PERSON_ID;
Edit_Address(oAddress);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Person_WithAddress");}
}
#endregion
#region Reset_Contact_By_Person
public void Reset_Contact_By_Person(Person i_Person, List<Contact> i_Contact_List)
{
#region Declaration And Initialization Section.
Params_Delete_Contact_By_PERSON_ID oParams_Delete_Contact_By_PERSON_ID = new Params_Delete_Contact_By_PERSON_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Contact_By_Person");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Contact
//---------------------------------
oParams_Delete_Contact_By_PERSON_ID.PERSON_ID = i_Person.PERSON_ID;
Delete_Contact_By_PERSON_ID(oParams_Delete_Contact_By_PERSON_ID);
//---------------------------------
// Edit Contact
//---------------------------------
Edit_Person_WithContact(i_Person, i_Contact_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Contact_By_Person");}
}
#endregion
#region Reset_Contact_By_Person
public void Reset_Contact_By_Person(Person i_Person, List<Contact> i_Contact_List_To_Delete,List<Contact> i_Contact_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Contact oParams_Delete_Contact = new Params_Delete_Contact();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Contact_By_Person");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Contact_List_To_Delete != null)
{
foreach (var oRow in i_Contact_List_To_Delete)
{
oParams_Delete_Contact.CONTACT_ID = oRow.CONTACT_ID;
Delete_Contact(oParams_Delete_Contact);
}
}
//---------------------------------
// Edit Contact
//---------------------------------
Edit_Person_WithContact(i_Person, i_Contact_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Contact_By_Person");}
}
#endregion
#region Edit_Person_With_Contact(Person i_Person,List<Contact> i_ContactList)
public void Edit_Person_WithContact(Person i_Person,List<Contact> i_List_Contact)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Person_WithContact");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Person(i_Person);
if (i_List_Contact != null)
{
foreach(Contact oContact in i_List_Contact)
{
oContact.PERSON_ID = i_Person.PERSON_ID;
Edit_Contact(oContact);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Person_WithContact");}
}
#endregion
#region Edit_Person_WithRelatedData(Person i_Person,List<Address> i_List_Address,List<Contact> i_List_Contact)
public void Edit_Person_WithRelatedData(Person i_Person,List<Address> i_List_Address,List<Contact> i_List_Contact)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Person_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Person(i_Person);
if (i_List_Address != null)
{
foreach(Address oAddress in i_List_Address)
{
oAddress.PERSON_ID = i_Person.PERSON_ID;
Edit_Address(oAddress);
}
}
if (i_List_Contact != null)
{
foreach(Contact oContact in i_List_Contact)
{
oContact.PERSON_ID = i_Person.PERSON_ID;
Edit_Contact(oContact);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Person_WithRelatedData");}
}
#endregion
#region Delete_Person_With_Children(Person i_Person)
public void Delete_Person_With_Children(Person i_Person)
{
 #region Declaration And Initialization Section.
Params_Delete_Person oParams_Delete_Person = new Params_Delete_Person();
Params_Delete_Address_By_PERSON_ID oParams_Delete_Address_By_PERSON_ID = new Params_Delete_Address_By_PERSON_ID();
Params_Delete_Contact_By_PERSON_ID oParams_Delete_Contact_By_PERSON_ID = new Params_Delete_Contact_By_PERSON_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Person_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Address_By_PERSON_ID.PERSON_ID = i_Person.PERSON_ID;
Delete_Address_By_PERSON_ID(oParams_Delete_Address_By_PERSON_ID);
oParams_Delete_Contact_By_PERSON_ID.PERSON_ID = i_Person.PERSON_ID;
Delete_Contact_By_PERSON_ID(oParams_Delete_Contact_By_PERSON_ID);
//-------------------------

//-------------------------
oParams_Delete_Person.PERSON_ID = i_Person.PERSON_ID;
Delete_Person(oParams_Delete_Person);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Person_With_Children");}
}
#endregion
#region Reset_Staff_fees_By_Staff
public void Reset_Staff_fees_By_Staff(Staff i_Staff, List<Staff_fees> i_Staff_fees_List)
{
#region Declaration And Initialization Section.
Params_Delete_Staff_fees_By_STAFF_ID oParams_Delete_Staff_fees_By_STAFF_ID = new Params_Delete_Staff_fees_By_STAFF_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Staff_fees_By_Staff");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Staff_fees
//---------------------------------
oParams_Delete_Staff_fees_By_STAFF_ID.STAFF_ID = i_Staff.STAFF_ID;
Delete_Staff_fees_By_STAFF_ID(oParams_Delete_Staff_fees_By_STAFF_ID);
//---------------------------------
// Edit Staff_fees
//---------------------------------
Edit_Staff_WithStaff_fees(i_Staff, i_Staff_fees_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Staff_fees_By_Staff");}
}
#endregion
#region Reset_Staff_fees_By_Staff
public void Reset_Staff_fees_By_Staff(Staff i_Staff, List<Staff_fees> i_Staff_fees_List_To_Delete,List<Staff_fees> i_Staff_fees_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Staff_fees oParams_Delete_Staff_fees = new Params_Delete_Staff_fees();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Staff_fees_By_Staff");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Staff_fees_List_To_Delete != null)
{
foreach (var oRow in i_Staff_fees_List_To_Delete)
{
oParams_Delete_Staff_fees.STAFF_FEES_ID = oRow.STAFF_FEES_ID;
Delete_Staff_fees(oParams_Delete_Staff_fees);
}
}
//---------------------------------
// Edit Staff_fees
//---------------------------------
Edit_Staff_WithStaff_fees(i_Staff, i_Staff_fees_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Staff_fees_By_Staff");}
}
#endregion
#region Edit_Staff_With_Staff_fees(Staff i_Staff,List<Staff_fees> i_Staff_feesList)
public void Edit_Staff_WithStaff_fees(Staff i_Staff,List<Staff_fees> i_List_Staff_fees)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Staff_WithStaff_fees");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Staff(i_Staff);
if (i_List_Staff_fees != null)
{
foreach(Staff_fees oStaff_fees in i_List_Staff_fees)
{
oStaff_fees.STAFF_ID = i_Staff.STAFF_ID;
Edit_Staff_fees(oStaff_fees);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Staff_WithStaff_fees");}
}
#endregion
#region Edit_Staff_WithRelatedData(Staff i_Staff,List<Staff_fees> i_List_Staff_fees)
public void Edit_Staff_WithRelatedData(Staff i_Staff,List<Staff_fees> i_List_Staff_fees)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Staff_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Staff(i_Staff);
if (i_List_Staff_fees != null)
{
foreach(Staff_fees oStaff_fees in i_List_Staff_fees)
{
oStaff_fees.STAFF_ID = i_Staff.STAFF_ID;
Edit_Staff_fees(oStaff_fees);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Staff_WithRelatedData");}
}
#endregion
#region Delete_Staff_With_Children(Staff i_Staff)
public void Delete_Staff_With_Children(Staff i_Staff)
{
 #region Declaration And Initialization Section.
Params_Delete_Staff oParams_Delete_Staff = new Params_Delete_Staff();
Params_Delete_Staff_fees_By_STAFF_ID oParams_Delete_Staff_fees_By_STAFF_ID = new Params_Delete_Staff_fees_By_STAFF_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Staff_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Staff_fees_By_STAFF_ID.STAFF_ID = i_Staff.STAFF_ID;
Delete_Staff_fees_By_STAFF_ID(oParams_Delete_Staff_fees_By_STAFF_ID);
//-------------------------

//-------------------------
oParams_Delete_Staff.STAFF_ID = i_Staff.STAFF_ID;
Delete_Staff(oParams_Delete_Staff);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Staff_With_Children");}
}
#endregion
#region Reset_Supplier_fees_By_Supplier
public void Reset_Supplier_fees_By_Supplier(Supplier i_Supplier, List<Supplier_fees> i_Supplier_fees_List)
{
#region Declaration And Initialization Section.
Params_Delete_Supplier_fees_By_SUPPLIER_ID oParams_Delete_Supplier_fees_By_SUPPLIER_ID = new Params_Delete_Supplier_fees_By_SUPPLIER_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Supplier_fees_By_Supplier");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Existing Supplier_fees
//---------------------------------
oParams_Delete_Supplier_fees_By_SUPPLIER_ID.SUPPLIER_ID = i_Supplier.SUPPLIER_ID;
Delete_Supplier_fees_By_SUPPLIER_ID(oParams_Delete_Supplier_fees_By_SUPPLIER_ID);
//---------------------------------
// Edit Supplier_fees
//---------------------------------
Edit_Supplier_WithSupplier_fees(i_Supplier, i_Supplier_fees_List);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Supplier_fees_By_Supplier");}
}
#endregion
#region Reset_Supplier_fees_By_Supplier
public void Reset_Supplier_fees_By_Supplier(Supplier i_Supplier, List<Supplier_fees> i_Supplier_fees_List_To_Delete,List<Supplier_fees> i_Supplier_fees_List_To_Create)
{
#region Declaration And Initialization Section.
Params_Delete_Supplier_fees oParams_Delete_Supplier_fees = new Params_Delete_Supplier_fees();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Reset_Supplier_fees_By_Supplier");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Delete Specified Items 
//---------------------------------
 if (i_Supplier_fees_List_To_Delete != null)
{
foreach (var oRow in i_Supplier_fees_List_To_Delete)
{
oParams_Delete_Supplier_fees.SUPPLIER_FEES_ID = oRow.SUPPLIER_FEES_ID;
Delete_Supplier_fees(oParams_Delete_Supplier_fees);
}
}
//---------------------------------
// Edit Supplier_fees
//---------------------------------
Edit_Supplier_WithSupplier_fees(i_Supplier, i_Supplier_fees_List_To_Create);
//---------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Reset_Supplier_fees_By_Supplier");}
}
#endregion
#region Edit_Supplier_With_Supplier_fees(Supplier i_Supplier,List<Supplier_fees> i_Supplier_feesList)
public void Edit_Supplier_WithSupplier_fees(Supplier i_Supplier,List<Supplier_fees> i_List_Supplier_fees)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Supplier_WithSupplier_fees");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Supplier(i_Supplier);
if (i_List_Supplier_fees != null)
{
foreach(Supplier_fees oSupplier_fees in i_List_Supplier_fees)
{
oSupplier_fees.SUPPLIER_ID = i_Supplier.SUPPLIER_ID;
Edit_Supplier_fees(oSupplier_fees);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Supplier_WithSupplier_fees");}
}
#endregion
#region Edit_Supplier_WithRelatedData(Supplier i_Supplier,List<Supplier_fees> i_List_Supplier_fees)
public void Edit_Supplier_WithRelatedData(Supplier i_Supplier,List<Supplier_fees> i_List_Supplier_fees)
{
#region Declaration And Initialization Section.
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Supplier_WithRelatedData");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
// Business Operation.
//-------------------------------
Edit_Supplier(i_Supplier);
if (i_List_Supplier_fees != null)
{
foreach(Supplier_fees oSupplier_fees in i_List_Supplier_fees)
{
oSupplier_fees.SUPPLIER_ID = i_Supplier.SUPPLIER_ID;
Edit_Supplier_fees(oSupplier_fees);
}
}
//-------------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Supplier_WithRelatedData");}
}
#endregion
#region Delete_Supplier_With_Children(Supplier i_Supplier)
public void Delete_Supplier_With_Children(Supplier i_Supplier)
{
 #region Declaration And Initialization Section.
Params_Delete_Supplier oParams_Delete_Supplier = new Params_Delete_Supplier();
Params_Delete_Supplier_fees_By_SUPPLIER_ID oParams_Delete_Supplier_fees_By_SUPPLIER_ID = new Params_Delete_Supplier_fees_By_SUPPLIER_ID();
#endregion
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Supplier_With_Children");}
 #region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
//-------------------------
oParams_Delete_Supplier_fees_By_SUPPLIER_ID.SUPPLIER_ID = i_Supplier.SUPPLIER_ID;
Delete_Supplier_fees_By_SUPPLIER_ID(oParams_Delete_Supplier_fees_By_SUPPLIER_ID);
//-------------------------

//-------------------------
oParams_Delete_Supplier.SUPPLIER_ID = i_Supplier.SUPPLIER_ID;
Delete_Supplier(oParams_Delete_Supplier);
//-------------------------
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Supplier_With_Children");}
}
#endregion
}
}
