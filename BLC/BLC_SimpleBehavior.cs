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
#region Members
#region Used For Delete Operations
private Address _Address;
private Bloodtype _Bloodtype;
private Client _Client;
private Client_fees _Client_fees;
private Contact _Contact;
private Currency _Currency;
private Fees _Fees;
private Loc_l1 _Loc_l1;
private Loc_l2 _Loc_l2;
private Loc_l3 _Loc_l3;
private Loc_l4 _Loc_l4;
private Method_run _Method_run;
private Owner _Owner;
private Package _Package;
private Person _Person;
private Registration _Registration;
private Session _Session;
private Staff _Staff;
private Staff_fees _Staff_fees;
private Supplier _Supplier;
private Supplier_fees _Supplier_fees;
private User _User;
#endregion
#region Stop Executing Flags For Edit and Delete Operations
private bool _Stop_Edit_Address_Execution;
private bool _Stop_Delete_Address_Execution;
private bool _Stop_Edit_Bloodtype_Execution;
private bool _Stop_Delete_Bloodtype_Execution;
private bool _Stop_Edit_Client_Execution;
private bool _Stop_Delete_Client_Execution;
private bool _Stop_Edit_Client_fees_Execution;
private bool _Stop_Delete_Client_fees_Execution;
private bool _Stop_Edit_Contact_Execution;
private bool _Stop_Delete_Contact_Execution;
private bool _Stop_Edit_Currency_Execution;
private bool _Stop_Delete_Currency_Execution;
private bool _Stop_Edit_Fees_Execution;
private bool _Stop_Delete_Fees_Execution;
private bool _Stop_Edit_Loc_l1_Execution;
private bool _Stop_Delete_Loc_l1_Execution;
private bool _Stop_Edit_Loc_l2_Execution;
private bool _Stop_Delete_Loc_l2_Execution;
private bool _Stop_Edit_Loc_l3_Execution;
private bool _Stop_Delete_Loc_l3_Execution;
private bool _Stop_Edit_Loc_l4_Execution;
private bool _Stop_Delete_Loc_l4_Execution;
private bool _Stop_Edit_Method_run_Execution;
private bool _Stop_Delete_Method_run_Execution;
private bool _Stop_Edit_Owner_Execution;
private bool _Stop_Delete_Owner_Execution;
private bool _Stop_Edit_Package_Execution;
private bool _Stop_Delete_Package_Execution;
private bool _Stop_Edit_Person_Execution;
private bool _Stop_Delete_Person_Execution;
private bool _Stop_Edit_Registration_Execution;
private bool _Stop_Delete_Registration_Execution;
private bool _Stop_Edit_Session_Execution;
private bool _Stop_Delete_Session_Execution;
private bool _Stop_Edit_Staff_Execution;
private bool _Stop_Delete_Staff_Execution;
private bool _Stop_Edit_Staff_fees_Execution;
private bool _Stop_Delete_Staff_fees_Execution;
private bool _Stop_Edit_Supplier_Execution;
private bool _Stop_Delete_Supplier_Execution;
private bool _Stop_Edit_Supplier_fees_Execution;
private bool _Stop_Delete_Supplier_fees_Execution;
private bool _Stop_Edit_User_Execution;
private bool _Stop_Delete_User_Execution;
#endregion
#endregion
public Address Get_Address_By_ADDRESS_ID(Params_Get_Address_By_ADDRESS_ID i_Params_Get_Address_By_ADDRESS_ID)
{
Address oAddress = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_ADDRESS_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_ADDRESS_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_ADDRESS_ID));}
#region Body Section.
DALC.Address oDBEntry = _AppContext.Get_Address_By_ADDRESS_ID(i_Params_Get_Address_By_ADDRESS_ID.ADDRESS_ID);
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_ADDRESS_ID");}
return oAddress;
}
public Bloodtype Get_Bloodtype_By_BLOODTYPE_ID(Params_Get_Bloodtype_By_BLOODTYPE_ID i_Params_Get_Bloodtype_By_BLOODTYPE_ID)
{
Bloodtype oBloodtype = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Bloodtype_By_BLOODTYPE_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Bloodtype_By_BLOODTYPE_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Bloodtype_By_BLOODTYPE_ID));}
#region Body Section.
DALC.Bloodtype oDBEntry = _AppContext.Get_Bloodtype_By_BLOODTYPE_ID(i_Params_Get_Bloodtype_By_BLOODTYPE_ID.BLOODTYPE_ID);
oBloodtype = new Bloodtype();
oTools.CopyPropValues(oDBEntry, oBloodtype);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Bloodtype_By_BLOODTYPE_ID");}
return oBloodtype;
}
public Client Get_Client_By_CLIENT_ID(Params_Get_Client_By_CLIENT_ID i_Params_Get_Client_By_CLIENT_ID)
{
Client oClient = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_By_CLIENT_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Client_By_CLIENT_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Client_By_CLIENT_ID));}
#region Body Section.
DALC.Client oDBEntry = _AppContext.Get_Client_By_CLIENT_ID(i_Params_Get_Client_By_CLIENT_ID.CLIENT_ID);
oClient = new Client();
oTools.CopyPropValues(oDBEntry, oClient);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_By_CLIENT_ID");}
return oClient;
}
public Client_fees Get_Client_fees_By_CLIENT_FEES_ID(Params_Get_Client_fees_By_CLIENT_FEES_ID i_Params_Get_Client_fees_By_CLIENT_FEES_ID)
{
Client_fees oClient_fees = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_fees_By_CLIENT_FEES_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Client_fees_By_CLIENT_FEES_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Client_fees_By_CLIENT_FEES_ID));}
#region Body Section.
DALC.Client_fees oDBEntry = _AppContext.Get_Client_fees_By_CLIENT_FEES_ID(i_Params_Get_Client_fees_By_CLIENT_FEES_ID.CLIENT_FEES_ID);
oClient_fees = new Client_fees();
oTools.CopyPropValues(oDBEntry, oClient_fees);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_fees_By_CLIENT_FEES_ID");}
return oClient_fees;
}
public Contact Get_Contact_By_CONTACT_ID(Params_Get_Contact_By_CONTACT_ID i_Params_Get_Contact_By_CONTACT_ID)
{
Contact oContact = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_CONTACT_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Contact_By_CONTACT_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Contact_By_CONTACT_ID));}
#region Body Section.
DALC.Contact oDBEntry = _AppContext.Get_Contact_By_CONTACT_ID(i_Params_Get_Contact_By_CONTACT_ID.CONTACT_ID);
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_CONTACT_ID");}
return oContact;
}
public Currency Get_Currency_By_CURRENCY_ID(Params_Get_Currency_By_CURRENCY_ID i_Params_Get_Currency_By_CURRENCY_ID)
{
Currency oCurrency = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Currency_By_CURRENCY_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Currency_By_CURRENCY_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Currency_By_CURRENCY_ID));}
#region Body Section.
DALC.Currency oDBEntry = _AppContext.Get_Currency_By_CURRENCY_ID(i_Params_Get_Currency_By_CURRENCY_ID.CURRENCY_ID);
oCurrency = new Currency();
oTools.CopyPropValues(oDBEntry, oCurrency);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Currency_By_CURRENCY_ID");}
return oCurrency;
}
public Fees Get_Fees_By_FEES_ID(Params_Get_Fees_By_FEES_ID i_Params_Get_Fees_By_FEES_ID)
{
Fees oFees = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Fees_By_FEES_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Fees_By_FEES_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Fees_By_FEES_ID));}
#region Body Section.
DALC.Fees oDBEntry = _AppContext.Get_Fees_By_FEES_ID(i_Params_Get_Fees_By_FEES_ID.FEES_ID);
oFees = new Fees();
oTools.CopyPropValues(oDBEntry, oFees);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Fees_By_FEES_ID");}
return oFees;
}
public Loc_l1 Get_Loc_l1_By_LOC_L1_ID(Params_Get_Loc_l1_By_LOC_L1_ID i_Params_Get_Loc_l1_By_LOC_L1_ID)
{
Loc_l1 oLoc_l1 = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l1_By_LOC_L1_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l1_By_LOC_L1_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l1_By_LOC_L1_ID));}
#region Body Section.
DALC.Loc_l1 oDBEntry = _AppContext.Get_Loc_l1_By_LOC_L1_ID(i_Params_Get_Loc_l1_By_LOC_L1_ID.LOC_L1_ID);
oLoc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry, oLoc_l1);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l1_By_LOC_L1_ID");}
return oLoc_l1;
}
public Loc_l2 Get_Loc_l2_By_LOC_L2_ID(Params_Get_Loc_l2_By_LOC_L2_ID i_Params_Get_Loc_l2_By_LOC_L2_ID)
{
Loc_l2 oLoc_l2 = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_LOC_L2_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l2_By_LOC_L2_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l2_By_LOC_L2_ID));}
#region Body Section.
DALC.Loc_l2 oDBEntry = _AppContext.Get_Loc_l2_By_LOC_L2_ID(i_Params_Get_Loc_l2_By_LOC_L2_ID.LOC_L2_ID);
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_LOC_L2_ID");}
return oLoc_l2;
}
public Loc_l3 Get_Loc_l3_By_LOC_L3_ID(Params_Get_Loc_l3_By_LOC_L3_ID i_Params_Get_Loc_l3_By_LOC_L3_ID)
{
Loc_l3 oLoc_l3 = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_LOC_L3_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l3_By_LOC_L3_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l3_By_LOC_L3_ID));}
#region Body Section.
DALC.Loc_l3 oDBEntry = _AppContext.Get_Loc_l3_By_LOC_L3_ID(i_Params_Get_Loc_l3_By_LOC_L3_ID.LOC_L3_ID);
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_LOC_L3_ID");}
return oLoc_l3;
}
public Loc_l4 Get_Loc_l4_By_LOC_L4_ID(Params_Get_Loc_l4_By_LOC_L4_ID i_Params_Get_Loc_l4_By_LOC_L4_ID)
{
Loc_l4 oLoc_l4 = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_LOC_L4_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l4_By_LOC_L4_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l4_By_LOC_L4_ID));}
#region Body Section.
DALC.Loc_l4 oDBEntry = _AppContext.Get_Loc_l4_By_LOC_L4_ID(i_Params_Get_Loc_l4_By_LOC_L4_ID.LOC_L4_ID);
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_LOC_L4_ID");}
return oLoc_l4;
}
public Method_run Get_Method_run_By_METHOD_RUN_ID(Params_Get_Method_run_By_METHOD_RUN_ID i_Params_Get_Method_run_By_METHOD_RUN_ID)
{
Method_run oMethod_run = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Method_run_By_METHOD_RUN_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Method_run_By_METHOD_RUN_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Method_run_By_METHOD_RUN_ID));}
#region Body Section.
DALC.Method_run oDBEntry = _AppContext.Get_Method_run_By_METHOD_RUN_ID(i_Params_Get_Method_run_By_METHOD_RUN_ID.METHOD_RUN_ID);
oMethod_run = new Method_run();
oTools.CopyPropValues(oDBEntry, oMethod_run);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Method_run_By_METHOD_RUN_ID");}
return oMethod_run;
}
public Owner Get_Owner_By_OWNER_ID(Params_Get_Owner_By_OWNER_ID i_Params_Get_Owner_By_OWNER_ID)
{
Owner oOwner = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Owner_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Owner_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Owner_By_OWNER_ID));}
#region Body Section.
DALC.Owner oDBEntry = _AppContext.Get_Owner_By_OWNER_ID(i_Params_Get_Owner_By_OWNER_ID.OWNER_ID);
oOwner = new Owner();
oTools.CopyPropValues(oDBEntry, oOwner);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Owner_By_OWNER_ID");}
return oOwner;
}
public Package Get_Package_By_PACKAGE_ID(Params_Get_Package_By_PACKAGE_ID i_Params_Get_Package_By_PACKAGE_ID)
{
Package oPackage = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Package_By_PACKAGE_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Package_By_PACKAGE_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Package_By_PACKAGE_ID));}
#region Body Section.
DALC.Package oDBEntry = _AppContext.Get_Package_By_PACKAGE_ID(i_Params_Get_Package_By_PACKAGE_ID.PACKAGE_ID);
oPackage = new Package();
oTools.CopyPropValues(oDBEntry, oPackage);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Package_By_PACKAGE_ID");}
return oPackage;
}
public Person Get_Person_By_PERSON_ID(Params_Get_Person_By_PERSON_ID i_Params_Get_Person_By_PERSON_ID)
{
Person oPerson = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Person_By_PERSON_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Person_By_PERSON_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Person_By_PERSON_ID));}
#region Body Section.
DALC.Person oDBEntry = _AppContext.Get_Person_By_PERSON_ID(i_Params_Get_Person_By_PERSON_ID.PERSON_ID);
oPerson = new Person();
oTools.CopyPropValues(oDBEntry, oPerson);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Person_By_PERSON_ID");}
return oPerson;
}
public Registration Get_Registration_By_REGISTRATION_ID(Params_Get_Registration_By_REGISTRATION_ID i_Params_Get_Registration_By_REGISTRATION_ID)
{
Registration oRegistration = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Registration_By_REGISTRATION_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Registration_By_REGISTRATION_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Registration_By_REGISTRATION_ID));}
#region Body Section.
DALC.Registration oDBEntry = _AppContext.Get_Registration_By_REGISTRATION_ID(i_Params_Get_Registration_By_REGISTRATION_ID.REGISTRATION_ID);
oRegistration = new Registration();
oTools.CopyPropValues(oDBEntry, oRegistration);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Registration_By_REGISTRATION_ID");}
return oRegistration;
}
public Session Get_Session_By_SESSION_ID(Params_Get_Session_By_SESSION_ID i_Params_Get_Session_By_SESSION_ID)
{
Session oSession = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Session_By_SESSION_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Session_By_SESSION_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Session_By_SESSION_ID));}
#region Body Section.
DALC.Session oDBEntry = _AppContext.Get_Session_By_SESSION_ID(i_Params_Get_Session_By_SESSION_ID.SESSION_ID);
oSession = new Session();
oTools.CopyPropValues(oDBEntry, oSession);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Session_By_SESSION_ID");}
return oSession;
}
public Staff Get_Staff_By_STAFF_ID(Params_Get_Staff_By_STAFF_ID i_Params_Get_Staff_By_STAFF_ID)
{
Staff oStaff = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_By_STAFF_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_By_STAFF_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_By_STAFF_ID));}
#region Body Section.
DALC.Staff oDBEntry = _AppContext.Get_Staff_By_STAFF_ID(i_Params_Get_Staff_By_STAFF_ID.STAFF_ID);
oStaff = new Staff();
oTools.CopyPropValues(oDBEntry, oStaff);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_By_STAFF_ID");}
return oStaff;
}
public Staff_fees Get_Staff_fees_By_STAFF_FEES_ID(Params_Get_Staff_fees_By_STAFF_FEES_ID i_Params_Get_Staff_fees_By_STAFF_FEES_ID)
{
Staff_fees oStaff_fees = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_fees_By_STAFF_FEES_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_fees_By_STAFF_FEES_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_fees_By_STAFF_FEES_ID));}
#region Body Section.
DALC.Staff_fees oDBEntry = _AppContext.Get_Staff_fees_By_STAFF_FEES_ID(i_Params_Get_Staff_fees_By_STAFF_FEES_ID.STAFF_FEES_ID);
oStaff_fees = new Staff_fees();
oTools.CopyPropValues(oDBEntry, oStaff_fees);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_fees_By_STAFF_FEES_ID");}
return oStaff_fees;
}
public Supplier Get_Supplier_By_SUPPLIER_ID(Params_Get_Supplier_By_SUPPLIER_ID i_Params_Get_Supplier_By_SUPPLIER_ID)
{
Supplier oSupplier = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_By_SUPPLIER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_By_SUPPLIER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_By_SUPPLIER_ID));}
#region Body Section.
DALC.Supplier oDBEntry = _AppContext.Get_Supplier_By_SUPPLIER_ID(i_Params_Get_Supplier_By_SUPPLIER_ID.SUPPLIER_ID);
oSupplier = new Supplier();
oTools.CopyPropValues(oDBEntry, oSupplier);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_By_SUPPLIER_ID");}
return oSupplier;
}
public Supplier_fees Get_Supplier_fees_By_SUPPLIER_FEES_ID(Params_Get_Supplier_fees_By_SUPPLIER_FEES_ID i_Params_Get_Supplier_fees_By_SUPPLIER_FEES_ID)
{
Supplier_fees oSupplier_fees = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_fees_By_SUPPLIER_FEES_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_fees_By_SUPPLIER_FEES_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_fees_By_SUPPLIER_FEES_ID));}
#region Body Section.
DALC.Supplier_fees oDBEntry = _AppContext.Get_Supplier_fees_By_SUPPLIER_FEES_ID(i_Params_Get_Supplier_fees_By_SUPPLIER_FEES_ID.SUPPLIER_FEES_ID);
oSupplier_fees = new Supplier_fees();
oTools.CopyPropValues(oDBEntry, oSupplier_fees);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_fees_By_SUPPLIER_FEES_ID");}
return oSupplier_fees;
}
public User Get_User_By_USER_ID(Params_Get_User_By_USER_ID i_Params_Get_User_By_USER_ID)
{
User oUser = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_USER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_User_By_USER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_User_By_USER_ID));}
#region Body Section.
DALC.User oDBEntry = _AppContext.Get_User_By_USER_ID(i_Params_Get_User_By_USER_ID.USER_ID);
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_USER_ID");}
return oUser;
}
public List<Address> Get_Address_By_ADDRESS_ID_List(Params_Get_Address_By_ADDRESS_ID_List i_Params_Get_Address_By_ADDRESS_ID_List)
{
Address oAddress = null;
List<Address> oList = new List<Address>();
Params_Get_Address_By_ADDRESS_ID_List_SP oParams_Get_Address_By_ADDRESS_ID_List_SP = new Params_Get_Address_By_ADDRESS_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_ADDRESS_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_ADDRESS_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_ADDRESS_ID_List));}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_ADDRESS_ID_List(i_Params_Get_Address_By_ADDRESS_ID_List.ADDRESS_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_ADDRESS_ID_List");}
return oList;
}
public List<Bloodtype> Get_Bloodtype_By_BLOODTYPE_ID_List(Params_Get_Bloodtype_By_BLOODTYPE_ID_List i_Params_Get_Bloodtype_By_BLOODTYPE_ID_List)
{
Bloodtype oBloodtype = null;
List<Bloodtype> oList = new List<Bloodtype>();
Params_Get_Bloodtype_By_BLOODTYPE_ID_List_SP oParams_Get_Bloodtype_By_BLOODTYPE_ID_List_SP = new Params_Get_Bloodtype_By_BLOODTYPE_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Bloodtype_By_BLOODTYPE_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Bloodtype_By_BLOODTYPE_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Bloodtype_By_BLOODTYPE_ID_List));}
#region Body Section.
List<DALC.Bloodtype> oList_DBEntries = _AppContext.Get_Bloodtype_By_BLOODTYPE_ID_List(i_Params_Get_Bloodtype_By_BLOODTYPE_ID_List.BLOODTYPE_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBloodtype = new Bloodtype();
oTools.CopyPropValues(oDBEntry, oBloodtype);
oList.Add(oBloodtype);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Bloodtype_By_BLOODTYPE_ID_List");}
return oList;
}
public List<Client> Get_Client_By_CLIENT_ID_List(Params_Get_Client_By_CLIENT_ID_List i_Params_Get_Client_By_CLIENT_ID_List)
{
Client oClient = null;
List<Client> oList = new List<Client>();
Params_Get_Client_By_CLIENT_ID_List_SP oParams_Get_Client_By_CLIENT_ID_List_SP = new Params_Get_Client_By_CLIENT_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_By_CLIENT_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Client_By_CLIENT_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Client_By_CLIENT_ID_List));}
#region Body Section.
List<DALC.Client> oList_DBEntries = _AppContext.Get_Client_By_CLIENT_ID_List(i_Params_Get_Client_By_CLIENT_ID_List.CLIENT_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oClient = new Client();
oTools.CopyPropValues(oDBEntry, oClient);
oList.Add(oClient);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_By_CLIENT_ID_List");}
return oList;
}
public List<Client_fees> Get_Client_fees_By_CLIENT_FEES_ID_List(Params_Get_Client_fees_By_CLIENT_FEES_ID_List i_Params_Get_Client_fees_By_CLIENT_FEES_ID_List)
{
Client_fees oClient_fees = null;
List<Client_fees> oList = new List<Client_fees>();
Params_Get_Client_fees_By_CLIENT_FEES_ID_List_SP oParams_Get_Client_fees_By_CLIENT_FEES_ID_List_SP = new Params_Get_Client_fees_By_CLIENT_FEES_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_fees_By_CLIENT_FEES_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Client_fees_By_CLIENT_FEES_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Client_fees_By_CLIENT_FEES_ID_List));}
#region Body Section.
List<DALC.Client_fees> oList_DBEntries = _AppContext.Get_Client_fees_By_CLIENT_FEES_ID_List(i_Params_Get_Client_fees_By_CLIENT_FEES_ID_List.CLIENT_FEES_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oClient_fees = new Client_fees();
oTools.CopyPropValues(oDBEntry, oClient_fees);
oList.Add(oClient_fees);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_fees_By_CLIENT_FEES_ID_List");}
return oList;
}
public List<Contact> Get_Contact_By_CONTACT_ID_List(Params_Get_Contact_By_CONTACT_ID_List i_Params_Get_Contact_By_CONTACT_ID_List)
{
Contact oContact = null;
List<Contact> oList = new List<Contact>();
Params_Get_Contact_By_CONTACT_ID_List_SP oParams_Get_Contact_By_CONTACT_ID_List_SP = new Params_Get_Contact_By_CONTACT_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_CONTACT_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Contact_By_CONTACT_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Contact_By_CONTACT_ID_List));}
#region Body Section.
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_CONTACT_ID_List(i_Params_Get_Contact_By_CONTACT_ID_List.CONTACT_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oList.Add(oContact);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_CONTACT_ID_List");}
return oList;
}
public List<Currency> Get_Currency_By_CURRENCY_ID_List(Params_Get_Currency_By_CURRENCY_ID_List i_Params_Get_Currency_By_CURRENCY_ID_List)
{
Currency oCurrency = null;
List<Currency> oList = new List<Currency>();
Params_Get_Currency_By_CURRENCY_ID_List_SP oParams_Get_Currency_By_CURRENCY_ID_List_SP = new Params_Get_Currency_By_CURRENCY_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Currency_By_CURRENCY_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Currency_By_CURRENCY_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Currency_By_CURRENCY_ID_List));}
#region Body Section.
List<DALC.Currency> oList_DBEntries = _AppContext.Get_Currency_By_CURRENCY_ID_List(i_Params_Get_Currency_By_CURRENCY_ID_List.CURRENCY_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCurrency = new Currency();
oTools.CopyPropValues(oDBEntry, oCurrency);
oList.Add(oCurrency);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Currency_By_CURRENCY_ID_List");}
return oList;
}
public List<Fees> Get_Fees_By_FEES_ID_List(Params_Get_Fees_By_FEES_ID_List i_Params_Get_Fees_By_FEES_ID_List)
{
Fees oFees = null;
List<Fees> oList = new List<Fees>();
Params_Get_Fees_By_FEES_ID_List_SP oParams_Get_Fees_By_FEES_ID_List_SP = new Params_Get_Fees_By_FEES_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Fees_By_FEES_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Fees_By_FEES_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Fees_By_FEES_ID_List));}
#region Body Section.
List<DALC.Fees> oList_DBEntries = _AppContext.Get_Fees_By_FEES_ID_List(i_Params_Get_Fees_By_FEES_ID_List.FEES_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFees = new Fees();
oTools.CopyPropValues(oDBEntry, oFees);
oList.Add(oFees);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Fees_By_FEES_ID_List");}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_LOC_L1_ID_List(Params_Get_Loc_l1_By_LOC_L1_ID_List i_Params_Get_Loc_l1_By_LOC_L1_ID_List)
{
Loc_l1 oLoc_l1 = null;
List<Loc_l1> oList = new List<Loc_l1>();
Params_Get_Loc_l1_By_LOC_L1_ID_List_SP oParams_Get_Loc_l1_By_LOC_L1_ID_List_SP = new Params_Get_Loc_l1_By_LOC_L1_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l1_By_LOC_L1_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l1_By_LOC_L1_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l1_By_LOC_L1_ID_List));}
#region Body Section.
List<DALC.Loc_l1> oList_DBEntries = _AppContext.Get_Loc_l1_By_LOC_L1_ID_List(i_Params_Get_Loc_l1_By_LOC_L1_ID_List.LOC_L1_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry, oLoc_l1);
oList.Add(oLoc_l1);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l1_By_LOC_L1_ID_List");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L2_ID_List(Params_Get_Loc_l2_By_LOC_L2_ID_List i_Params_Get_Loc_l2_By_LOC_L2_ID_List)
{
Loc_l2 oLoc_l2 = null;
List<Loc_l2> oList = new List<Loc_l2>();
Params_Get_Loc_l2_By_LOC_L2_ID_List_SP oParams_Get_Loc_l2_By_LOC_L2_ID_List_SP = new Params_Get_Loc_l2_By_LOC_L2_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_LOC_L2_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l2_By_LOC_L2_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l2_By_LOC_L2_ID_List));}
#region Body Section.
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_LOC_L2_ID_List(i_Params_Get_Loc_l2_By_LOC_L2_ID_List.LOC_L2_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oList.Add(oLoc_l2);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_LOC_L2_ID_List");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L3_ID_List(Params_Get_Loc_l3_By_LOC_L3_ID_List i_Params_Get_Loc_l3_By_LOC_L3_ID_List)
{
Loc_l3 oLoc_l3 = null;
List<Loc_l3> oList = new List<Loc_l3>();
Params_Get_Loc_l3_By_LOC_L3_ID_List_SP oParams_Get_Loc_l3_By_LOC_L3_ID_List_SP = new Params_Get_Loc_l3_By_LOC_L3_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_LOC_L3_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l3_By_LOC_L3_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l3_By_LOC_L3_ID_List));}
#region Body Section.
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_LOC_L3_ID_List(i_Params_Get_Loc_l3_By_LOC_L3_ID_List.LOC_L3_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oList.Add(oLoc_l3);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_LOC_L3_ID_List");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L4_ID_List(Params_Get_Loc_l4_By_LOC_L4_ID_List i_Params_Get_Loc_l4_By_LOC_L4_ID_List)
{
Loc_l4 oLoc_l4 = null;
List<Loc_l4> oList = new List<Loc_l4>();
Params_Get_Loc_l4_By_LOC_L4_ID_List_SP oParams_Get_Loc_l4_By_LOC_L4_ID_List_SP = new Params_Get_Loc_l4_By_LOC_L4_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_LOC_L4_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l4_By_LOC_L4_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l4_By_LOC_L4_ID_List));}
#region Body Section.
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_LOC_L4_ID_List(i_Params_Get_Loc_l4_By_LOC_L4_ID_List.LOC_L4_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oList.Add(oLoc_l4);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_LOC_L4_ID_List");}
return oList;
}
public List<Method_run> Get_Method_run_By_METHOD_RUN_ID_List(Params_Get_Method_run_By_METHOD_RUN_ID_List i_Params_Get_Method_run_By_METHOD_RUN_ID_List)
{
Method_run oMethod_run = null;
List<Method_run> oList = new List<Method_run>();
Params_Get_Method_run_By_METHOD_RUN_ID_List_SP oParams_Get_Method_run_By_METHOD_RUN_ID_List_SP = new Params_Get_Method_run_By_METHOD_RUN_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Method_run_By_METHOD_RUN_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Method_run_By_METHOD_RUN_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Method_run_By_METHOD_RUN_ID_List));}
#region Body Section.
List<DALC.Method_run> oList_DBEntries = _AppContext.Get_Method_run_By_METHOD_RUN_ID_List(i_Params_Get_Method_run_By_METHOD_RUN_ID_List.METHOD_RUN_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oMethod_run = new Method_run();
oTools.CopyPropValues(oDBEntry, oMethod_run);
oList.Add(oMethod_run);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Method_run_By_METHOD_RUN_ID_List");}
return oList;
}
public List<Owner> Get_Owner_By_OWNER_ID_List(Params_Get_Owner_By_OWNER_ID_List i_Params_Get_Owner_By_OWNER_ID_List)
{
Owner oOwner = null;
List<Owner> oList = new List<Owner>();
Params_Get_Owner_By_OWNER_ID_List_SP oParams_Get_Owner_By_OWNER_ID_List_SP = new Params_Get_Owner_By_OWNER_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Owner_By_OWNER_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Owner_By_OWNER_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Owner_By_OWNER_ID_List));}
#region Body Section.
List<DALC.Owner> oList_DBEntries = _AppContext.Get_Owner_By_OWNER_ID_List(i_Params_Get_Owner_By_OWNER_ID_List.OWNER_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOwner = new Owner();
oTools.CopyPropValues(oDBEntry, oOwner);
oList.Add(oOwner);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Owner_By_OWNER_ID_List");}
return oList;
}
public List<Package> Get_Package_By_PACKAGE_ID_List(Params_Get_Package_By_PACKAGE_ID_List i_Params_Get_Package_By_PACKAGE_ID_List)
{
Package oPackage = null;
List<Package> oList = new List<Package>();
Params_Get_Package_By_PACKAGE_ID_List_SP oParams_Get_Package_By_PACKAGE_ID_List_SP = new Params_Get_Package_By_PACKAGE_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Package_By_PACKAGE_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Package_By_PACKAGE_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Package_By_PACKAGE_ID_List));}
#region Body Section.
List<DALC.Package> oList_DBEntries = _AppContext.Get_Package_By_PACKAGE_ID_List(i_Params_Get_Package_By_PACKAGE_ID_List.PACKAGE_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oPackage = new Package();
oTools.CopyPropValues(oDBEntry, oPackage);
oList.Add(oPackage);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Package_By_PACKAGE_ID_List");}
return oList;
}
public List<Person> Get_Person_By_PERSON_ID_List(Params_Get_Person_By_PERSON_ID_List i_Params_Get_Person_By_PERSON_ID_List)
{
Person oPerson = null;
List<Person> oList = new List<Person>();
Params_Get_Person_By_PERSON_ID_List_SP oParams_Get_Person_By_PERSON_ID_List_SP = new Params_Get_Person_By_PERSON_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Person_By_PERSON_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Person_By_PERSON_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Person_By_PERSON_ID_List));}
#region Body Section.
List<DALC.Person> oList_DBEntries = _AppContext.Get_Person_By_PERSON_ID_List(i_Params_Get_Person_By_PERSON_ID_List.PERSON_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oPerson = new Person();
oTools.CopyPropValues(oDBEntry, oPerson);
oList.Add(oPerson);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Person_By_PERSON_ID_List");}
return oList;
}
public List<Registration> Get_Registration_By_REGISTRATION_ID_List(Params_Get_Registration_By_REGISTRATION_ID_List i_Params_Get_Registration_By_REGISTRATION_ID_List)
{
Registration oRegistration = null;
List<Registration> oList = new List<Registration>();
Params_Get_Registration_By_REGISTRATION_ID_List_SP oParams_Get_Registration_By_REGISTRATION_ID_List_SP = new Params_Get_Registration_By_REGISTRATION_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Registration_By_REGISTRATION_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Registration_By_REGISTRATION_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Registration_By_REGISTRATION_ID_List));}
#region Body Section.
List<DALC.Registration> oList_DBEntries = _AppContext.Get_Registration_By_REGISTRATION_ID_List(i_Params_Get_Registration_By_REGISTRATION_ID_List.REGISTRATION_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oRegistration = new Registration();
oTools.CopyPropValues(oDBEntry, oRegistration);
oList.Add(oRegistration);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Registration_By_REGISTRATION_ID_List");}
return oList;
}
public List<Session> Get_Session_By_SESSION_ID_List(Params_Get_Session_By_SESSION_ID_List i_Params_Get_Session_By_SESSION_ID_List)
{
Session oSession = null;
List<Session> oList = new List<Session>();
Params_Get_Session_By_SESSION_ID_List_SP oParams_Get_Session_By_SESSION_ID_List_SP = new Params_Get_Session_By_SESSION_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Session_By_SESSION_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Session_By_SESSION_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Session_By_SESSION_ID_List));}
#region Body Section.
List<DALC.Session> oList_DBEntries = _AppContext.Get_Session_By_SESSION_ID_List(i_Params_Get_Session_By_SESSION_ID_List.SESSION_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSession = new Session();
oTools.CopyPropValues(oDBEntry, oSession);
oList.Add(oSession);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Session_By_SESSION_ID_List");}
return oList;
}
public List<Staff> Get_Staff_By_STAFF_ID_List(Params_Get_Staff_By_STAFF_ID_List i_Params_Get_Staff_By_STAFF_ID_List)
{
Staff oStaff = null;
List<Staff> oList = new List<Staff>();
Params_Get_Staff_By_STAFF_ID_List_SP oParams_Get_Staff_By_STAFF_ID_List_SP = new Params_Get_Staff_By_STAFF_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_By_STAFF_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_By_STAFF_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_By_STAFF_ID_List));}
#region Body Section.
List<DALC.Staff> oList_DBEntries = _AppContext.Get_Staff_By_STAFF_ID_List(i_Params_Get_Staff_By_STAFF_ID_List.STAFF_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStaff = new Staff();
oTools.CopyPropValues(oDBEntry, oStaff);
oList.Add(oStaff);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_By_STAFF_ID_List");}
return oList;
}
public List<Staff_fees> Get_Staff_fees_By_STAFF_FEES_ID_List(Params_Get_Staff_fees_By_STAFF_FEES_ID_List i_Params_Get_Staff_fees_By_STAFF_FEES_ID_List)
{
Staff_fees oStaff_fees = null;
List<Staff_fees> oList = new List<Staff_fees>();
Params_Get_Staff_fees_By_STAFF_FEES_ID_List_SP oParams_Get_Staff_fees_By_STAFF_FEES_ID_List_SP = new Params_Get_Staff_fees_By_STAFF_FEES_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_fees_By_STAFF_FEES_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_fees_By_STAFF_FEES_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_fees_By_STAFF_FEES_ID_List));}
#region Body Section.
List<DALC.Staff_fees> oList_DBEntries = _AppContext.Get_Staff_fees_By_STAFF_FEES_ID_List(i_Params_Get_Staff_fees_By_STAFF_FEES_ID_List.STAFF_FEES_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStaff_fees = new Staff_fees();
oTools.CopyPropValues(oDBEntry, oStaff_fees);
oList.Add(oStaff_fees);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_fees_By_STAFF_FEES_ID_List");}
return oList;
}
public List<Supplier> Get_Supplier_By_SUPPLIER_ID_List(Params_Get_Supplier_By_SUPPLIER_ID_List i_Params_Get_Supplier_By_SUPPLIER_ID_List)
{
Supplier oSupplier = null;
List<Supplier> oList = new List<Supplier>();
Params_Get_Supplier_By_SUPPLIER_ID_List_SP oParams_Get_Supplier_By_SUPPLIER_ID_List_SP = new Params_Get_Supplier_By_SUPPLIER_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_By_SUPPLIER_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_By_SUPPLIER_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_By_SUPPLIER_ID_List));}
#region Body Section.
List<DALC.Supplier> oList_DBEntries = _AppContext.Get_Supplier_By_SUPPLIER_ID_List(i_Params_Get_Supplier_By_SUPPLIER_ID_List.SUPPLIER_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier = new Supplier();
oTools.CopyPropValues(oDBEntry, oSupplier);
oList.Add(oSupplier);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_By_SUPPLIER_ID_List");}
return oList;
}
public List<Supplier_fees> Get_Supplier_fees_By_SUPPLIER_FEES_ID_List(Params_Get_Supplier_fees_By_SUPPLIER_FEES_ID_List i_Params_Get_Supplier_fees_By_SUPPLIER_FEES_ID_List)
{
Supplier_fees oSupplier_fees = null;
List<Supplier_fees> oList = new List<Supplier_fees>();
Params_Get_Supplier_fees_By_SUPPLIER_FEES_ID_List_SP oParams_Get_Supplier_fees_By_SUPPLIER_FEES_ID_List_SP = new Params_Get_Supplier_fees_By_SUPPLIER_FEES_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_fees_By_SUPPLIER_FEES_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_fees_By_SUPPLIER_FEES_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_fees_By_SUPPLIER_FEES_ID_List));}
#region Body Section.
List<DALC.Supplier_fees> oList_DBEntries = _AppContext.Get_Supplier_fees_By_SUPPLIER_FEES_ID_List(i_Params_Get_Supplier_fees_By_SUPPLIER_FEES_ID_List.SUPPLIER_FEES_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier_fees = new Supplier_fees();
oTools.CopyPropValues(oDBEntry, oSupplier_fees);
oList.Add(oSupplier_fees);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_fees_By_SUPPLIER_FEES_ID_List");}
return oList;
}
public List<User> Get_User_By_USER_ID_List(Params_Get_User_By_USER_ID_List i_Params_Get_User_By_USER_ID_List)
{
User oUser = null;
List<User> oList = new List<User>();
Params_Get_User_By_USER_ID_List_SP oParams_Get_User_By_USER_ID_List_SP = new Params_Get_User_By_USER_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_USER_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_User_By_USER_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_User_By_USER_ID_List));}
#region Body Section.
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_USER_ID_List(i_Params_Get_User_By_USER_ID_List.USER_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
oList.Add(oUser);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_USER_ID_List");}
return oList;
}
public List<Address> Get_Address_By_PERSON_ID(Params_Get_Address_By_PERSON_ID i_Params_Get_Address_By_PERSON_ID)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_PERSON_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_PERSON_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_PERSON_ID));}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_PERSON_ID(i_Params_Get_Address_By_PERSON_ID.PERSON_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_PERSON_ID");}
return oList;
}
public List<Address> Get_Address_By_LOC_L1_ID(Params_Get_Address_By_LOC_L1_ID i_Params_Get_Address_By_LOC_L1_ID)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L1_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_LOC_L1_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_LOC_L1_ID));}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L1_ID(i_Params_Get_Address_By_LOC_L1_ID.LOC_L1_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L1_ID");}
return oList;
}
public List<Address> Get_Address_By_LOC_L2_ID(Params_Get_Address_By_LOC_L2_ID i_Params_Get_Address_By_LOC_L2_ID)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L2_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_LOC_L2_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_LOC_L2_ID));}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L2_ID(i_Params_Get_Address_By_LOC_L2_ID.LOC_L2_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L2_ID");}
return oList;
}
public List<Address> Get_Address_By_LOC_L3_ID(Params_Get_Address_By_LOC_L3_ID i_Params_Get_Address_By_LOC_L3_ID)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L3_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_LOC_L3_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_LOC_L3_ID));}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L3_ID(i_Params_Get_Address_By_LOC_L3_ID.LOC_L3_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L3_ID");}
return oList;
}
public List<Address> Get_Address_By_OWNER_ID(Params_Get_Address_By_OWNER_ID i_Params_Get_Address_By_OWNER_ID)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_OWNER_ID));}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_OWNER_ID(i_Params_Get_Address_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_OWNER_ID");}
return oList;
}
public List<Address> Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE(Params_Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE i_Params_Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE));}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE(i_Params_Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE.PERSON_ID,i_Params_Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE.ADDRESS_TYPE_CODE);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE");}
return oList;
}
public List<Address> Get_Address_By_LOC_L4_ID(Params_Get_Address_By_LOC_L4_ID i_Params_Get_Address_By_LOC_L4_ID)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L4_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_LOC_L4_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_LOC_L4_ID));}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L4_ID(i_Params_Get_Address_By_LOC_L4_ID.LOC_L4_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L4_ID");}
return oList;
}
public List<Bloodtype> Get_Bloodtype_By_OWNER_ID(Params_Get_Bloodtype_By_OWNER_ID i_Params_Get_Bloodtype_By_OWNER_ID)
{
List<Bloodtype> oList = new List<Bloodtype>();
Bloodtype oBloodtype = new Bloodtype();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Bloodtype_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Bloodtype_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Bloodtype_By_OWNER_ID));}
#region Body Section.
List<DALC.Bloodtype> oList_DBEntries = _AppContext.Get_Bloodtype_By_OWNER_ID(i_Params_Get_Bloodtype_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBloodtype = new Bloodtype();
oTools.CopyPropValues(oDBEntry, oBloodtype);
oList.Add(oBloodtype);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Bloodtype_By_OWNER_ID");}
return oList;
}
public List<Client> Get_Client_By_OWNER_ID(Params_Get_Client_By_OWNER_ID i_Params_Get_Client_By_OWNER_ID)
{
List<Client> oList = new List<Client>();
Client oClient = new Client();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Client_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Client_By_OWNER_ID));}
#region Body Section.
List<DALC.Client> oList_DBEntries = _AppContext.Get_Client_By_OWNER_ID(i_Params_Get_Client_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oClient = new Client();
oTools.CopyPropValues(oDBEntry, oClient);
oList.Add(oClient);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_By_OWNER_ID");}
return oList;
}
public List<Client> Get_Client_By_BLOODTYPE_ID(Params_Get_Client_By_BLOODTYPE_ID i_Params_Get_Client_By_BLOODTYPE_ID)
{
List<Client> oList = new List<Client>();
Client oClient = new Client();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_By_BLOODTYPE_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Client_By_BLOODTYPE_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Client_By_BLOODTYPE_ID));}
#region Body Section.
List<DALC.Client> oList_DBEntries = _AppContext.Get_Client_By_BLOODTYPE_ID(i_Params_Get_Client_By_BLOODTYPE_ID.BLOODTYPE_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oClient = new Client();
oTools.CopyPropValues(oDBEntry, oClient);
oList.Add(oClient);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_By_BLOODTYPE_ID");}
return oList;
}
public List<Client_fees> Get_Client_fees_By_OWNER_ID(Params_Get_Client_fees_By_OWNER_ID i_Params_Get_Client_fees_By_OWNER_ID)
{
List<Client_fees> oList = new List<Client_fees>();
Client_fees oClient_fees = new Client_fees();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_fees_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Client_fees_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Client_fees_By_OWNER_ID));}
#region Body Section.
List<DALC.Client_fees> oList_DBEntries = _AppContext.Get_Client_fees_By_OWNER_ID(i_Params_Get_Client_fees_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oClient_fees = new Client_fees();
oTools.CopyPropValues(oDBEntry, oClient_fees);
oList.Add(oClient_fees);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_fees_By_OWNER_ID");}
return oList;
}
public List<Client_fees> Get_Client_fees_By_CLIENT_ID(Params_Get_Client_fees_By_CLIENT_ID i_Params_Get_Client_fees_By_CLIENT_ID)
{
List<Client_fees> oList = new List<Client_fees>();
Client_fees oClient_fees = new Client_fees();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_fees_By_CLIENT_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Client_fees_By_CLIENT_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Client_fees_By_CLIENT_ID));}
#region Body Section.
List<DALC.Client_fees> oList_DBEntries = _AppContext.Get_Client_fees_By_CLIENT_ID(i_Params_Get_Client_fees_By_CLIENT_ID.CLIENT_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oClient_fees = new Client_fees();
oTools.CopyPropValues(oDBEntry, oClient_fees);
oList.Add(oClient_fees);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_fees_By_CLIENT_ID");}
return oList;
}
public List<Client_fees> Get_Client_fees_By_CURRENCY_ID(Params_Get_Client_fees_By_CURRENCY_ID i_Params_Get_Client_fees_By_CURRENCY_ID)
{
List<Client_fees> oList = new List<Client_fees>();
Client_fees oClient_fees = new Client_fees();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_fees_By_CURRENCY_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Client_fees_By_CURRENCY_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Client_fees_By_CURRENCY_ID));}
#region Body Section.
List<DALC.Client_fees> oList_DBEntries = _AppContext.Get_Client_fees_By_CURRENCY_ID(i_Params_Get_Client_fees_By_CURRENCY_ID.CURRENCY_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oClient_fees = new Client_fees();
oTools.CopyPropValues(oDBEntry, oClient_fees);
oList.Add(oClient_fees);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_fees_By_CURRENCY_ID");}
return oList;
}
public List<Client_fees> Get_Client_fees_By_PACKAGE_ID(Params_Get_Client_fees_By_PACKAGE_ID i_Params_Get_Client_fees_By_PACKAGE_ID)
{
List<Client_fees> oList = new List<Client_fees>();
Client_fees oClient_fees = new Client_fees();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_fees_By_PACKAGE_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Client_fees_By_PACKAGE_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Client_fees_By_PACKAGE_ID));}
#region Body Section.
List<DALC.Client_fees> oList_DBEntries = _AppContext.Get_Client_fees_By_PACKAGE_ID(i_Params_Get_Client_fees_By_PACKAGE_ID.PACKAGE_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oClient_fees = new Client_fees();
oTools.CopyPropValues(oDBEntry, oClient_fees);
oList.Add(oClient_fees);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_fees_By_PACKAGE_ID");}
return oList;
}
public List<Client_fees> Get_Client_fees_By_REGISTRATION_ID(Params_Get_Client_fees_By_REGISTRATION_ID i_Params_Get_Client_fees_By_REGISTRATION_ID)
{
List<Client_fees> oList = new List<Client_fees>();
Client_fees oClient_fees = new Client_fees();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_fees_By_REGISTRATION_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Client_fees_By_REGISTRATION_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Client_fees_By_REGISTRATION_ID));}
#region Body Section.
List<DALC.Client_fees> oList_DBEntries = _AppContext.Get_Client_fees_By_REGISTRATION_ID(i_Params_Get_Client_fees_By_REGISTRATION_ID.REGISTRATION_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oClient_fees = new Client_fees();
oTools.CopyPropValues(oDBEntry, oClient_fees);
oList.Add(oClient_fees);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_fees_By_REGISTRATION_ID");}
return oList;
}
public List<Contact> Get_Contact_By_PERSON_ID(Params_Get_Contact_By_PERSON_ID i_Params_Get_Contact_By_PERSON_ID)
{
List<Contact> oList = new List<Contact>();
Contact oContact = new Contact();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_PERSON_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Contact_By_PERSON_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Contact_By_PERSON_ID));}
#region Body Section.
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_PERSON_ID(i_Params_Get_Contact_By_PERSON_ID.PERSON_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oList.Add(oContact);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_PERSON_ID");}
return oList;
}
public List<Contact> Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT(Params_Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT i_Params_Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT)
{
List<Contact> oList = new List<Contact>();
Contact oContact = new Contact();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT));}
#region Body Section.
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT(i_Params_Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT.PERSON_ID,i_Params_Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT.CONTACT_TYPE_CODE,i_Params_Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT.CONTACT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oList.Add(oContact);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT");}
return oList;
}
public List<Contact> Get_Contact_By_OWNER_ID(Params_Get_Contact_By_OWNER_ID i_Params_Get_Contact_By_OWNER_ID)
{
List<Contact> oList = new List<Contact>();
Contact oContact = new Contact();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Contact_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Contact_By_OWNER_ID));}
#region Body Section.
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_OWNER_ID(i_Params_Get_Contact_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oList.Add(oContact);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_OWNER_ID");}
return oList;
}
public List<Currency> Get_Currency_By_OWNER_ID(Params_Get_Currency_By_OWNER_ID i_Params_Get_Currency_By_OWNER_ID)
{
List<Currency> oList = new List<Currency>();
Currency oCurrency = new Currency();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Currency_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Currency_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Currency_By_OWNER_ID));}
#region Body Section.
List<DALC.Currency> oList_DBEntries = _AppContext.Get_Currency_By_OWNER_ID(i_Params_Get_Currency_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCurrency = new Currency();
oTools.CopyPropValues(oDBEntry, oCurrency);
oList.Add(oCurrency);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Currency_By_OWNER_ID");}
return oList;
}
public List<Fees> Get_Fees_By_OWNER_ID(Params_Get_Fees_By_OWNER_ID i_Params_Get_Fees_By_OWNER_ID)
{
List<Fees> oList = new List<Fees>();
Fees oFees = new Fees();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Fees_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Fees_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Fees_By_OWNER_ID));}
#region Body Section.
List<DALC.Fees> oList_DBEntries = _AppContext.Get_Fees_By_OWNER_ID(i_Params_Get_Fees_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFees = new Fees();
oTools.CopyPropValues(oDBEntry, oFees);
oList.Add(oFees);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Fees_By_OWNER_ID");}
return oList;
}
public List<Fees> Get_Fees_By_CURRENCY_ID(Params_Get_Fees_By_CURRENCY_ID i_Params_Get_Fees_By_CURRENCY_ID)
{
List<Fees> oList = new List<Fees>();
Fees oFees = new Fees();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Fees_By_CURRENCY_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Fees_By_CURRENCY_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Fees_By_CURRENCY_ID));}
#region Body Section.
List<DALC.Fees> oList_DBEntries = _AppContext.Get_Fees_By_CURRENCY_ID(i_Params_Get_Fees_By_CURRENCY_ID.CURRENCY_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFees = new Fees();
oTools.CopyPropValues(oDBEntry, oFees);
oList.Add(oFees);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Fees_By_CURRENCY_ID");}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_CODE(Params_Get_Loc_l1_By_CODE i_Params_Get_Loc_l1_By_CODE)
{
List<Loc_l1> oList = new List<Loc_l1>();
Loc_l1 oLoc_l1 = new Loc_l1();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l1_By_CODE");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l1_By_CODE",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l1_By_CODE));}
#region Body Section.
List<DALC.Loc_l1> oList_DBEntries = _AppContext.Get_Loc_l1_By_CODE(i_Params_Get_Loc_l1_By_CODE.CODE);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry, oLoc_l1);
oList.Add(oLoc_l1);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l1_By_CODE");}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_OWNER_ID(Params_Get_Loc_l1_By_OWNER_ID i_Params_Get_Loc_l1_By_OWNER_ID)
{
List<Loc_l1> oList = new List<Loc_l1>();
Loc_l1 oLoc_l1 = new Loc_l1();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l1_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l1_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l1_By_OWNER_ID));}
#region Body Section.
List<DALC.Loc_l1> oList_DBEntries = _AppContext.Get_Loc_l1_By_OWNER_ID(i_Params_Get_Loc_l1_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry, oLoc_l1);
oList.Add(oLoc_l1);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l1_By_OWNER_ID");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_CODE(Params_Get_Loc_l2_By_LOC_L1_ID_CODE i_Params_Get_Loc_l2_By_LOC_L1_ID_CODE)
{
List<Loc_l2> oList = new List<Loc_l2>();
Loc_l2 oLoc_l2 = new Loc_l2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_LOC_L1_ID_CODE");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l2_By_LOC_L1_ID_CODE",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l2_By_LOC_L1_ID_CODE));}
#region Body Section.
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_LOC_L1_ID_CODE(i_Params_Get_Loc_l2_By_LOC_L1_ID_CODE.LOC_L1_ID,i_Params_Get_Loc_l2_By_LOC_L1_ID_CODE.CODE);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oList.Add(oLoc_l2);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_LOC_L1_ID_CODE");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID(Params_Get_Loc_l2_By_LOC_L1_ID i_Params_Get_Loc_l2_By_LOC_L1_ID)
{
List<Loc_l2> oList = new List<Loc_l2>();
Loc_l2 oLoc_l2 = new Loc_l2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_LOC_L1_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l2_By_LOC_L1_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l2_By_LOC_L1_ID));}
#region Body Section.
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_LOC_L1_ID(i_Params_Get_Loc_l2_By_LOC_L1_ID.LOC_L1_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oList.Add(oLoc_l2);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_LOC_L1_ID");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_OWNER_ID(Params_Get_Loc_l2_By_OWNER_ID i_Params_Get_Loc_l2_By_OWNER_ID)
{
List<Loc_l2> oList = new List<Loc_l2>();
Loc_l2 oLoc_l2 = new Loc_l2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l2_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l2_By_OWNER_ID));}
#region Body Section.
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_OWNER_ID(i_Params_Get_Loc_l2_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oList.Add(oLoc_l2);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_OWNER_ID");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_CODE(Params_Get_Loc_l3_By_LOC_L2_ID_CODE i_Params_Get_Loc_l3_By_LOC_L2_ID_CODE)
{
List<Loc_l3> oList = new List<Loc_l3>();
Loc_l3 oLoc_l3 = new Loc_l3();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_LOC_L2_ID_CODE");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l3_By_LOC_L2_ID_CODE",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l3_By_LOC_L2_ID_CODE));}
#region Body Section.
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_LOC_L2_ID_CODE(i_Params_Get_Loc_l3_By_LOC_L2_ID_CODE.LOC_L2_ID,i_Params_Get_Loc_l3_By_LOC_L2_ID_CODE.CODE);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oList.Add(oLoc_l3);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_LOC_L2_ID_CODE");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID(Params_Get_Loc_l3_By_LOC_L2_ID i_Params_Get_Loc_l3_By_LOC_L2_ID)
{
List<Loc_l3> oList = new List<Loc_l3>();
Loc_l3 oLoc_l3 = new Loc_l3();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_LOC_L2_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l3_By_LOC_L2_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l3_By_LOC_L2_ID));}
#region Body Section.
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_LOC_L2_ID(i_Params_Get_Loc_l3_By_LOC_L2_ID.LOC_L2_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oList.Add(oLoc_l3);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_LOC_L2_ID");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_OWNER_ID(Params_Get_Loc_l3_By_OWNER_ID i_Params_Get_Loc_l3_By_OWNER_ID)
{
List<Loc_l3> oList = new List<Loc_l3>();
Loc_l3 oLoc_l3 = new Loc_l3();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l3_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l3_By_OWNER_ID));}
#region Body Section.
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_OWNER_ID(i_Params_Get_Loc_l3_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oList.Add(oLoc_l3);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_OWNER_ID");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_CODE(Params_Get_Loc_l4_By_LOC_L3_ID_CODE i_Params_Get_Loc_l4_By_LOC_L3_ID_CODE)
{
List<Loc_l4> oList = new List<Loc_l4>();
Loc_l4 oLoc_l4 = new Loc_l4();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_LOC_L3_ID_CODE");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l4_By_LOC_L3_ID_CODE",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l4_By_LOC_L3_ID_CODE));}
#region Body Section.
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_LOC_L3_ID_CODE(i_Params_Get_Loc_l4_By_LOC_L3_ID_CODE.LOC_L3_ID,i_Params_Get_Loc_l4_By_LOC_L3_ID_CODE.CODE);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oList.Add(oLoc_l4);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_LOC_L3_ID_CODE");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID(Params_Get_Loc_l4_By_LOC_L3_ID i_Params_Get_Loc_l4_By_LOC_L3_ID)
{
List<Loc_l4> oList = new List<Loc_l4>();
Loc_l4 oLoc_l4 = new Loc_l4();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_LOC_L3_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l4_By_LOC_L3_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l4_By_LOC_L3_ID));}
#region Body Section.
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_LOC_L3_ID(i_Params_Get_Loc_l4_By_LOC_L3_ID.LOC_L3_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oList.Add(oLoc_l4);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_LOC_L3_ID");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_OWNER_ID(Params_Get_Loc_l4_By_OWNER_ID i_Params_Get_Loc_l4_By_OWNER_ID)
{
List<Loc_l4> oList = new List<Loc_l4>();
Loc_l4 oLoc_l4 = new Loc_l4();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l4_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l4_By_OWNER_ID));}
#region Body Section.
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_OWNER_ID(i_Params_Get_Loc_l4_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oList.Add(oLoc_l4);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_OWNER_ID");}
return oList;
}
public List<Method_run> Get_Method_run_By_OWNER_ID(Params_Get_Method_run_By_OWNER_ID i_Params_Get_Method_run_By_OWNER_ID)
{
List<Method_run> oList = new List<Method_run>();
Method_run oMethod_run = new Method_run();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Method_run_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Method_run_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Method_run_By_OWNER_ID));}
#region Body Section.
List<DALC.Method_run> oList_DBEntries = _AppContext.Get_Method_run_By_OWNER_ID(i_Params_Get_Method_run_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oMethod_run = new Method_run();
oTools.CopyPropValues(oDBEntry, oMethod_run);
oList.Add(oMethod_run);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Method_run_By_OWNER_ID");}
return oList;
}
public List<Package> Get_Package_By_OWNER_ID(Params_Get_Package_By_OWNER_ID i_Params_Get_Package_By_OWNER_ID)
{
List<Package> oList = new List<Package>();
Package oPackage = new Package();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Package_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Package_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Package_By_OWNER_ID));}
#region Body Section.
List<DALC.Package> oList_DBEntries = _AppContext.Get_Package_By_OWNER_ID(i_Params_Get_Package_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oPackage = new Package();
oTools.CopyPropValues(oDBEntry, oPackage);
oList.Add(oPackage);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Package_By_OWNER_ID");}
return oList;
}
public List<Package> Get_Package_By_CURRENCY_ID(Params_Get_Package_By_CURRENCY_ID i_Params_Get_Package_By_CURRENCY_ID)
{
List<Package> oList = new List<Package>();
Package oPackage = new Package();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Package_By_CURRENCY_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Package_By_CURRENCY_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Package_By_CURRENCY_ID));}
#region Body Section.
List<DALC.Package> oList_DBEntries = _AppContext.Get_Package_By_CURRENCY_ID(i_Params_Get_Package_By_CURRENCY_ID.CURRENCY_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oPackage = new Package();
oTools.CopyPropValues(oDBEntry, oPackage);
oList.Add(oPackage);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Package_By_CURRENCY_ID");}
return oList;
}
public List<Person> Get_Person_By_OWNER_ID(Params_Get_Person_By_OWNER_ID i_Params_Get_Person_By_OWNER_ID)
{
List<Person> oList = new List<Person>();
Person oPerson = new Person();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Person_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Person_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Person_By_OWNER_ID));}
#region Body Section.
List<DALC.Person> oList_DBEntries = _AppContext.Get_Person_By_OWNER_ID(i_Params_Get_Person_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oPerson = new Person();
oTools.CopyPropValues(oDBEntry, oPerson);
oList.Add(oPerson);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Person_By_OWNER_ID");}
return oList;
}
public List<Registration> Get_Registration_By_OWNER_ID(Params_Get_Registration_By_OWNER_ID i_Params_Get_Registration_By_OWNER_ID)
{
List<Registration> oList = new List<Registration>();
Registration oRegistration = new Registration();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Registration_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Registration_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Registration_By_OWNER_ID));}
#region Body Section.
List<DALC.Registration> oList_DBEntries = _AppContext.Get_Registration_By_OWNER_ID(i_Params_Get_Registration_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oRegistration = new Registration();
oTools.CopyPropValues(oDBEntry, oRegistration);
oList.Add(oRegistration);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Registration_By_OWNER_ID");}
return oList;
}
public List<Registration> Get_Registration_By_CLIENT_ID(Params_Get_Registration_By_CLIENT_ID i_Params_Get_Registration_By_CLIENT_ID)
{
List<Registration> oList = new List<Registration>();
Registration oRegistration = new Registration();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Registration_By_CLIENT_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Registration_By_CLIENT_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Registration_By_CLIENT_ID));}
#region Body Section.
List<DALC.Registration> oList_DBEntries = _AppContext.Get_Registration_By_CLIENT_ID(i_Params_Get_Registration_By_CLIENT_ID.CLIENT_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oRegistration = new Registration();
oTools.CopyPropValues(oDBEntry, oRegistration);
oList.Add(oRegistration);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Registration_By_CLIENT_ID");}
return oList;
}
public List<Registration> Get_Registration_By_PACKAGE_ID(Params_Get_Registration_By_PACKAGE_ID i_Params_Get_Registration_By_PACKAGE_ID)
{
List<Registration> oList = new List<Registration>();
Registration oRegistration = new Registration();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Registration_By_PACKAGE_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Registration_By_PACKAGE_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Registration_By_PACKAGE_ID));}
#region Body Section.
List<DALC.Registration> oList_DBEntries = _AppContext.Get_Registration_By_PACKAGE_ID(i_Params_Get_Registration_By_PACKAGE_ID.PACKAGE_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oRegistration = new Registration();
oTools.CopyPropValues(oDBEntry, oRegistration);
oList.Add(oRegistration);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Registration_By_PACKAGE_ID");}
return oList;
}
public List<Registration> Get_Registration_By_CURRENCY_ID(Params_Get_Registration_By_CURRENCY_ID i_Params_Get_Registration_By_CURRENCY_ID)
{
List<Registration> oList = new List<Registration>();
Registration oRegistration = new Registration();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Registration_By_CURRENCY_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Registration_By_CURRENCY_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Registration_By_CURRENCY_ID));}
#region Body Section.
List<DALC.Registration> oList_DBEntries = _AppContext.Get_Registration_By_CURRENCY_ID(i_Params_Get_Registration_By_CURRENCY_ID.CURRENCY_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oRegistration = new Registration();
oTools.CopyPropValues(oDBEntry, oRegistration);
oList.Add(oRegistration);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Registration_By_CURRENCY_ID");}
return oList;
}
public List<Session> Get_Session_By_OWNER_ID(Params_Get_Session_By_OWNER_ID i_Params_Get_Session_By_OWNER_ID)
{
List<Session> oList = new List<Session>();
Session oSession = new Session();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Session_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Session_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Session_By_OWNER_ID));}
#region Body Section.
List<DALC.Session> oList_DBEntries = _AppContext.Get_Session_By_OWNER_ID(i_Params_Get_Session_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSession = new Session();
oTools.CopyPropValues(oDBEntry, oSession);
oList.Add(oSession);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Session_By_OWNER_ID");}
return oList;
}
public List<Session> Get_Session_By_PACKAGE_ID(Params_Get_Session_By_PACKAGE_ID i_Params_Get_Session_By_PACKAGE_ID)
{
List<Session> oList = new List<Session>();
Session oSession = new Session();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Session_By_PACKAGE_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Session_By_PACKAGE_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Session_By_PACKAGE_ID));}
#region Body Section.
List<DALC.Session> oList_DBEntries = _AppContext.Get_Session_By_PACKAGE_ID(i_Params_Get_Session_By_PACKAGE_ID.PACKAGE_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSession = new Session();
oTools.CopyPropValues(oDBEntry, oSession);
oList.Add(oSession);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Session_By_PACKAGE_ID");}
return oList;
}
public List<Session> Get_Session_By_CLIENT_FEES_ID(Params_Get_Session_By_CLIENT_FEES_ID i_Params_Get_Session_By_CLIENT_FEES_ID)
{
List<Session> oList = new List<Session>();
Session oSession = new Session();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Session_By_CLIENT_FEES_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Session_By_CLIENT_FEES_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Session_By_CLIENT_FEES_ID));}
#region Body Section.
List<DALC.Session> oList_DBEntries = _AppContext.Get_Session_By_CLIENT_FEES_ID(i_Params_Get_Session_By_CLIENT_FEES_ID.CLIENT_FEES_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSession = new Session();
oTools.CopyPropValues(oDBEntry, oSession);
oList.Add(oSession);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Session_By_CLIENT_FEES_ID");}
return oList;
}
public List<Staff> Get_Staff_By_OWNER_ID(Params_Get_Staff_By_OWNER_ID i_Params_Get_Staff_By_OWNER_ID)
{
List<Staff> oList = new List<Staff>();
Staff oStaff = new Staff();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_By_OWNER_ID));}
#region Body Section.
List<DALC.Staff> oList_DBEntries = _AppContext.Get_Staff_By_OWNER_ID(i_Params_Get_Staff_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStaff = new Staff();
oTools.CopyPropValues(oDBEntry, oStaff);
oList.Add(oStaff);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_By_OWNER_ID");}
return oList;
}
public List<Staff> Get_Staff_By_BLOODTYPE_ID(Params_Get_Staff_By_BLOODTYPE_ID i_Params_Get_Staff_By_BLOODTYPE_ID)
{
List<Staff> oList = new List<Staff>();
Staff oStaff = new Staff();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_By_BLOODTYPE_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_By_BLOODTYPE_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_By_BLOODTYPE_ID));}
#region Body Section.
List<DALC.Staff> oList_DBEntries = _AppContext.Get_Staff_By_BLOODTYPE_ID(i_Params_Get_Staff_By_BLOODTYPE_ID.BLOODTYPE_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStaff = new Staff();
oTools.CopyPropValues(oDBEntry, oStaff);
oList.Add(oStaff);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_By_BLOODTYPE_ID");}
return oList;
}
public List<Staff_fees> Get_Staff_fees_By_OWNER_ID(Params_Get_Staff_fees_By_OWNER_ID i_Params_Get_Staff_fees_By_OWNER_ID)
{
List<Staff_fees> oList = new List<Staff_fees>();
Staff_fees oStaff_fees = new Staff_fees();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_fees_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_fees_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_fees_By_OWNER_ID));}
#region Body Section.
List<DALC.Staff_fees> oList_DBEntries = _AppContext.Get_Staff_fees_By_OWNER_ID(i_Params_Get_Staff_fees_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStaff_fees = new Staff_fees();
oTools.CopyPropValues(oDBEntry, oStaff_fees);
oList.Add(oStaff_fees);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_fees_By_OWNER_ID");}
return oList;
}
public List<Staff_fees> Get_Staff_fees_By_STAFF_ID(Params_Get_Staff_fees_By_STAFF_ID i_Params_Get_Staff_fees_By_STAFF_ID)
{
List<Staff_fees> oList = new List<Staff_fees>();
Staff_fees oStaff_fees = new Staff_fees();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_fees_By_STAFF_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_fees_By_STAFF_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_fees_By_STAFF_ID));}
#region Body Section.
List<DALC.Staff_fees> oList_DBEntries = _AppContext.Get_Staff_fees_By_STAFF_ID(i_Params_Get_Staff_fees_By_STAFF_ID.STAFF_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStaff_fees = new Staff_fees();
oTools.CopyPropValues(oDBEntry, oStaff_fees);
oList.Add(oStaff_fees);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_fees_By_STAFF_ID");}
return oList;
}
public List<Staff_fees> Get_Staff_fees_By_CURRENCY_ID(Params_Get_Staff_fees_By_CURRENCY_ID i_Params_Get_Staff_fees_By_CURRENCY_ID)
{
List<Staff_fees> oList = new List<Staff_fees>();
Staff_fees oStaff_fees = new Staff_fees();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_fees_By_CURRENCY_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_fees_By_CURRENCY_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_fees_By_CURRENCY_ID));}
#region Body Section.
List<DALC.Staff_fees> oList_DBEntries = _AppContext.Get_Staff_fees_By_CURRENCY_ID(i_Params_Get_Staff_fees_By_CURRENCY_ID.CURRENCY_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStaff_fees = new Staff_fees();
oTools.CopyPropValues(oDBEntry, oStaff_fees);
oList.Add(oStaff_fees);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_fees_By_CURRENCY_ID");}
return oList;
}
public List<Supplier> Get_Supplier_By_OWNER_ID(Params_Get_Supplier_By_OWNER_ID i_Params_Get_Supplier_By_OWNER_ID)
{
List<Supplier> oList = new List<Supplier>();
Supplier oSupplier = new Supplier();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_By_OWNER_ID));}
#region Body Section.
List<DALC.Supplier> oList_DBEntries = _AppContext.Get_Supplier_By_OWNER_ID(i_Params_Get_Supplier_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier = new Supplier();
oTools.CopyPropValues(oDBEntry, oSupplier);
oList.Add(oSupplier);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_By_OWNER_ID");}
return oList;
}
public List<Supplier> Get_Supplier_By_BLOODTYPE_ID(Params_Get_Supplier_By_BLOODTYPE_ID i_Params_Get_Supplier_By_BLOODTYPE_ID)
{
List<Supplier> oList = new List<Supplier>();
Supplier oSupplier = new Supplier();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_By_BLOODTYPE_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_By_BLOODTYPE_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_By_BLOODTYPE_ID));}
#region Body Section.
List<DALC.Supplier> oList_DBEntries = _AppContext.Get_Supplier_By_BLOODTYPE_ID(i_Params_Get_Supplier_By_BLOODTYPE_ID.BLOODTYPE_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier = new Supplier();
oTools.CopyPropValues(oDBEntry, oSupplier);
oList.Add(oSupplier);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_By_BLOODTYPE_ID");}
return oList;
}
public List<Supplier_fees> Get_Supplier_fees_By_OWNER_ID(Params_Get_Supplier_fees_By_OWNER_ID i_Params_Get_Supplier_fees_By_OWNER_ID)
{
List<Supplier_fees> oList = new List<Supplier_fees>();
Supplier_fees oSupplier_fees = new Supplier_fees();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_fees_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_fees_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_fees_By_OWNER_ID));}
#region Body Section.
List<DALC.Supplier_fees> oList_DBEntries = _AppContext.Get_Supplier_fees_By_OWNER_ID(i_Params_Get_Supplier_fees_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier_fees = new Supplier_fees();
oTools.CopyPropValues(oDBEntry, oSupplier_fees);
oList.Add(oSupplier_fees);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_fees_By_OWNER_ID");}
return oList;
}
public List<Supplier_fees> Get_Supplier_fees_By_SUPPLIER_ID(Params_Get_Supplier_fees_By_SUPPLIER_ID i_Params_Get_Supplier_fees_By_SUPPLIER_ID)
{
List<Supplier_fees> oList = new List<Supplier_fees>();
Supplier_fees oSupplier_fees = new Supplier_fees();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_fees_By_SUPPLIER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_fees_By_SUPPLIER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_fees_By_SUPPLIER_ID));}
#region Body Section.
List<DALC.Supplier_fees> oList_DBEntries = _AppContext.Get_Supplier_fees_By_SUPPLIER_ID(i_Params_Get_Supplier_fees_By_SUPPLIER_ID.SUPPLIER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier_fees = new Supplier_fees();
oTools.CopyPropValues(oDBEntry, oSupplier_fees);
oList.Add(oSupplier_fees);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_fees_By_SUPPLIER_ID");}
return oList;
}
public List<Supplier_fees> Get_Supplier_fees_By_CURRENCY_ID(Params_Get_Supplier_fees_By_CURRENCY_ID i_Params_Get_Supplier_fees_By_CURRENCY_ID)
{
List<Supplier_fees> oList = new List<Supplier_fees>();
Supplier_fees oSupplier_fees = new Supplier_fees();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_fees_By_CURRENCY_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_fees_By_CURRENCY_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_fees_By_CURRENCY_ID));}
#region Body Section.
List<DALC.Supplier_fees> oList_DBEntries = _AppContext.Get_Supplier_fees_By_CURRENCY_ID(i_Params_Get_Supplier_fees_By_CURRENCY_ID.CURRENCY_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier_fees = new Supplier_fees();
oTools.CopyPropValues(oDBEntry, oSupplier_fees);
oList.Add(oSupplier_fees);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_fees_By_CURRENCY_ID");}
return oList;
}
public List<User> Get_User_By_OWNER_ID(Params_Get_User_By_OWNER_ID i_Params_Get_User_By_OWNER_ID)
{
List<User> oList = new List<User>();
User oUser = new User();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_User_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_User_By_OWNER_ID));}
#region Body Section.
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_OWNER_ID(i_Params_Get_User_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
oList.Add(oUser);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_OWNER_ID");}
return oList;
}
public List<User> Get_User_By_USERNAME(Params_Get_User_By_USERNAME i_Params_Get_User_By_USERNAME)
{
List<User> oList = new List<User>();
User oUser = new User();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_USERNAME");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_User_By_USERNAME",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_User_By_USERNAME));}
#region Body Section.
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_USERNAME(i_Params_Get_User_By_USERNAME.USERNAME);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
oList.Add(oUser);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_USERNAME");}
return oList;
}
public List<Address> Get_Address_By_PERSON_ID_List(Params_Get_Address_By_PERSON_ID_List i_Params_Get_Address_By_PERSON_ID_List)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_PERSON_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_PERSON_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_PERSON_ID_List));}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_PERSON_ID_List(i_Params_Get_Address_By_PERSON_ID_List.PERSON_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_PERSON_ID_List");}
return oList;
}
public List<Address> Get_Address_By_LOC_L1_ID_List(Params_Get_Address_By_LOC_L1_ID_List i_Params_Get_Address_By_LOC_L1_ID_List)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L1_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_LOC_L1_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_LOC_L1_ID_List));}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L1_ID_List(i_Params_Get_Address_By_LOC_L1_ID_List.LOC_L1_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L1_ID_List");}
return oList;
}
public List<Address> Get_Address_By_LOC_L2_ID_List(Params_Get_Address_By_LOC_L2_ID_List i_Params_Get_Address_By_LOC_L2_ID_List)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L2_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_LOC_L2_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_LOC_L2_ID_List));}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L2_ID_List(i_Params_Get_Address_By_LOC_L2_ID_List.LOC_L2_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L2_ID_List");}
return oList;
}
public List<Address> Get_Address_By_LOC_L3_ID_List(Params_Get_Address_By_LOC_L3_ID_List i_Params_Get_Address_By_LOC_L3_ID_List)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L3_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_LOC_L3_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_LOC_L3_ID_List));}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L3_ID_List(i_Params_Get_Address_By_LOC_L3_ID_List.LOC_L3_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L3_ID_List");}
return oList;
}
public List<Address> Get_Address_By_LOC_L4_ID_List(Params_Get_Address_By_LOC_L4_ID_List i_Params_Get_Address_By_LOC_L4_ID_List)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L4_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_LOC_L4_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_LOC_L4_ID_List));}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L4_ID_List(i_Params_Get_Address_By_LOC_L4_ID_List.LOC_L4_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L4_ID_List");}
return oList;
}
public List<Client> Get_Client_By_BLOODTYPE_ID_List(Params_Get_Client_By_BLOODTYPE_ID_List i_Params_Get_Client_By_BLOODTYPE_ID_List)
{
List<Client> oList = new List<Client>();
Client oClient = new Client();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_By_BLOODTYPE_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Client_By_BLOODTYPE_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Client_By_BLOODTYPE_ID_List));}
#region Body Section.
List<DALC.Client> oList_DBEntries = _AppContext.Get_Client_By_BLOODTYPE_ID_List(i_Params_Get_Client_By_BLOODTYPE_ID_List.BLOODTYPE_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oClient = new Client();
oTools.CopyPropValues(oDBEntry, oClient);
oList.Add(oClient);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_By_BLOODTYPE_ID_List");}
return oList;
}
public List<Client_fees> Get_Client_fees_By_CLIENT_ID_List(Params_Get_Client_fees_By_CLIENT_ID_List i_Params_Get_Client_fees_By_CLIENT_ID_List)
{
List<Client_fees> oList = new List<Client_fees>();
Client_fees oClient_fees = new Client_fees();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_fees_By_CLIENT_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Client_fees_By_CLIENT_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Client_fees_By_CLIENT_ID_List));}
#region Body Section.
List<DALC.Client_fees> oList_DBEntries = _AppContext.Get_Client_fees_By_CLIENT_ID_List(i_Params_Get_Client_fees_By_CLIENT_ID_List.CLIENT_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oClient_fees = new Client_fees();
oTools.CopyPropValues(oDBEntry, oClient_fees);
oList.Add(oClient_fees);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_fees_By_CLIENT_ID_List");}
return oList;
}
public List<Client_fees> Get_Client_fees_By_CURRENCY_ID_List(Params_Get_Client_fees_By_CURRENCY_ID_List i_Params_Get_Client_fees_By_CURRENCY_ID_List)
{
List<Client_fees> oList = new List<Client_fees>();
Client_fees oClient_fees = new Client_fees();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_fees_By_CURRENCY_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Client_fees_By_CURRENCY_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Client_fees_By_CURRENCY_ID_List));}
#region Body Section.
List<DALC.Client_fees> oList_DBEntries = _AppContext.Get_Client_fees_By_CURRENCY_ID_List(i_Params_Get_Client_fees_By_CURRENCY_ID_List.CURRENCY_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oClient_fees = new Client_fees();
oTools.CopyPropValues(oDBEntry, oClient_fees);
oList.Add(oClient_fees);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_fees_By_CURRENCY_ID_List");}
return oList;
}
public List<Client_fees> Get_Client_fees_By_PACKAGE_ID_List(Params_Get_Client_fees_By_PACKAGE_ID_List i_Params_Get_Client_fees_By_PACKAGE_ID_List)
{
List<Client_fees> oList = new List<Client_fees>();
Client_fees oClient_fees = new Client_fees();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_fees_By_PACKAGE_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Client_fees_By_PACKAGE_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Client_fees_By_PACKAGE_ID_List));}
#region Body Section.
List<DALC.Client_fees> oList_DBEntries = _AppContext.Get_Client_fees_By_PACKAGE_ID_List(i_Params_Get_Client_fees_By_PACKAGE_ID_List.PACKAGE_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oClient_fees = new Client_fees();
oTools.CopyPropValues(oDBEntry, oClient_fees);
oList.Add(oClient_fees);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_fees_By_PACKAGE_ID_List");}
return oList;
}
public List<Client_fees> Get_Client_fees_By_REGISTRATION_ID_List(Params_Get_Client_fees_By_REGISTRATION_ID_List i_Params_Get_Client_fees_By_REGISTRATION_ID_List)
{
List<Client_fees> oList = new List<Client_fees>();
Client_fees oClient_fees = new Client_fees();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_fees_By_REGISTRATION_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Client_fees_By_REGISTRATION_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Client_fees_By_REGISTRATION_ID_List));}
#region Body Section.
List<DALC.Client_fees> oList_DBEntries = _AppContext.Get_Client_fees_By_REGISTRATION_ID_List(i_Params_Get_Client_fees_By_REGISTRATION_ID_List.REGISTRATION_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oClient_fees = new Client_fees();
oTools.CopyPropValues(oDBEntry, oClient_fees);
oList.Add(oClient_fees);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_fees_By_REGISTRATION_ID_List");}
return oList;
}
public List<Contact> Get_Contact_By_PERSON_ID_List(Params_Get_Contact_By_PERSON_ID_List i_Params_Get_Contact_By_PERSON_ID_List)
{
List<Contact> oList = new List<Contact>();
Contact oContact = new Contact();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_PERSON_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Contact_By_PERSON_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Contact_By_PERSON_ID_List));}
#region Body Section.
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_PERSON_ID_List(i_Params_Get_Contact_By_PERSON_ID_List.PERSON_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oList.Add(oContact);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_PERSON_ID_List");}
return oList;
}
public List<Fees> Get_Fees_By_CURRENCY_ID_List(Params_Get_Fees_By_CURRENCY_ID_List i_Params_Get_Fees_By_CURRENCY_ID_List)
{
List<Fees> oList = new List<Fees>();
Fees oFees = new Fees();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Fees_By_CURRENCY_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Fees_By_CURRENCY_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Fees_By_CURRENCY_ID_List));}
#region Body Section.
List<DALC.Fees> oList_DBEntries = _AppContext.Get_Fees_By_CURRENCY_ID_List(i_Params_Get_Fees_By_CURRENCY_ID_List.CURRENCY_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFees = new Fees();
oTools.CopyPropValues(oDBEntry, oFees);
oList.Add(oFees);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Fees_By_CURRENCY_ID_List");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_List(Params_Get_Loc_l2_By_LOC_L1_ID_List i_Params_Get_Loc_l2_By_LOC_L1_ID_List)
{
List<Loc_l2> oList = new List<Loc_l2>();
Loc_l2 oLoc_l2 = new Loc_l2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_LOC_L1_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l2_By_LOC_L1_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l2_By_LOC_L1_ID_List));}
#region Body Section.
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_LOC_L1_ID_List(i_Params_Get_Loc_l2_By_LOC_L1_ID_List.LOC_L1_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oList.Add(oLoc_l2);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_LOC_L1_ID_List");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_List(Params_Get_Loc_l3_By_LOC_L2_ID_List i_Params_Get_Loc_l3_By_LOC_L2_ID_List)
{
List<Loc_l3> oList = new List<Loc_l3>();
Loc_l3 oLoc_l3 = new Loc_l3();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_LOC_L2_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l3_By_LOC_L2_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l3_By_LOC_L2_ID_List));}
#region Body Section.
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_LOC_L2_ID_List(i_Params_Get_Loc_l3_By_LOC_L2_ID_List.LOC_L2_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oList.Add(oLoc_l3);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_LOC_L2_ID_List");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_List(Params_Get_Loc_l4_By_LOC_L3_ID_List i_Params_Get_Loc_l4_By_LOC_L3_ID_List)
{
List<Loc_l4> oList = new List<Loc_l4>();
Loc_l4 oLoc_l4 = new Loc_l4();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_LOC_L3_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l4_By_LOC_L3_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l4_By_LOC_L3_ID_List));}
#region Body Section.
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_LOC_L3_ID_List(i_Params_Get_Loc_l4_By_LOC_L3_ID_List.LOC_L3_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oList.Add(oLoc_l4);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_LOC_L3_ID_List");}
return oList;
}
public List<Package> Get_Package_By_CURRENCY_ID_List(Params_Get_Package_By_CURRENCY_ID_List i_Params_Get_Package_By_CURRENCY_ID_List)
{
List<Package> oList = new List<Package>();
Package oPackage = new Package();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Package_By_CURRENCY_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Package_By_CURRENCY_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Package_By_CURRENCY_ID_List));}
#region Body Section.
List<DALC.Package> oList_DBEntries = _AppContext.Get_Package_By_CURRENCY_ID_List(i_Params_Get_Package_By_CURRENCY_ID_List.CURRENCY_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oPackage = new Package();
oTools.CopyPropValues(oDBEntry, oPackage);
oList.Add(oPackage);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Package_By_CURRENCY_ID_List");}
return oList;
}
public List<Registration> Get_Registration_By_CLIENT_ID_List(Params_Get_Registration_By_CLIENT_ID_List i_Params_Get_Registration_By_CLIENT_ID_List)
{
List<Registration> oList = new List<Registration>();
Registration oRegistration = new Registration();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Registration_By_CLIENT_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Registration_By_CLIENT_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Registration_By_CLIENT_ID_List));}
#region Body Section.
List<DALC.Registration> oList_DBEntries = _AppContext.Get_Registration_By_CLIENT_ID_List(i_Params_Get_Registration_By_CLIENT_ID_List.CLIENT_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oRegistration = new Registration();
oTools.CopyPropValues(oDBEntry, oRegistration);
oList.Add(oRegistration);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Registration_By_CLIENT_ID_List");}
return oList;
}
public List<Registration> Get_Registration_By_PACKAGE_ID_List(Params_Get_Registration_By_PACKAGE_ID_List i_Params_Get_Registration_By_PACKAGE_ID_List)
{
List<Registration> oList = new List<Registration>();
Registration oRegistration = new Registration();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Registration_By_PACKAGE_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Registration_By_PACKAGE_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Registration_By_PACKAGE_ID_List));}
#region Body Section.
List<DALC.Registration> oList_DBEntries = _AppContext.Get_Registration_By_PACKAGE_ID_List(i_Params_Get_Registration_By_PACKAGE_ID_List.PACKAGE_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oRegistration = new Registration();
oTools.CopyPropValues(oDBEntry, oRegistration);
oList.Add(oRegistration);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Registration_By_PACKAGE_ID_List");}
return oList;
}
public List<Registration> Get_Registration_By_CURRENCY_ID_List(Params_Get_Registration_By_CURRENCY_ID_List i_Params_Get_Registration_By_CURRENCY_ID_List)
{
List<Registration> oList = new List<Registration>();
Registration oRegistration = new Registration();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Registration_By_CURRENCY_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Registration_By_CURRENCY_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Registration_By_CURRENCY_ID_List));}
#region Body Section.
List<DALC.Registration> oList_DBEntries = _AppContext.Get_Registration_By_CURRENCY_ID_List(i_Params_Get_Registration_By_CURRENCY_ID_List.CURRENCY_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oRegistration = new Registration();
oTools.CopyPropValues(oDBEntry, oRegistration);
oList.Add(oRegistration);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Registration_By_CURRENCY_ID_List");}
return oList;
}
public List<Session> Get_Session_By_PACKAGE_ID_List(Params_Get_Session_By_PACKAGE_ID_List i_Params_Get_Session_By_PACKAGE_ID_List)
{
List<Session> oList = new List<Session>();
Session oSession = new Session();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Session_By_PACKAGE_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Session_By_PACKAGE_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Session_By_PACKAGE_ID_List));}
#region Body Section.
List<DALC.Session> oList_DBEntries = _AppContext.Get_Session_By_PACKAGE_ID_List(i_Params_Get_Session_By_PACKAGE_ID_List.PACKAGE_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSession = new Session();
oTools.CopyPropValues(oDBEntry, oSession);
oList.Add(oSession);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Session_By_PACKAGE_ID_List");}
return oList;
}
public List<Session> Get_Session_By_CLIENT_FEES_ID_List(Params_Get_Session_By_CLIENT_FEES_ID_List i_Params_Get_Session_By_CLIENT_FEES_ID_List)
{
List<Session> oList = new List<Session>();
Session oSession = new Session();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Session_By_CLIENT_FEES_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Session_By_CLIENT_FEES_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Session_By_CLIENT_FEES_ID_List));}
#region Body Section.
List<DALC.Session> oList_DBEntries = _AppContext.Get_Session_By_CLIENT_FEES_ID_List(i_Params_Get_Session_By_CLIENT_FEES_ID_List.CLIENT_FEES_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSession = new Session();
oTools.CopyPropValues(oDBEntry, oSession);
oList.Add(oSession);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Session_By_CLIENT_FEES_ID_List");}
return oList;
}
public List<Staff> Get_Staff_By_BLOODTYPE_ID_List(Params_Get_Staff_By_BLOODTYPE_ID_List i_Params_Get_Staff_By_BLOODTYPE_ID_List)
{
List<Staff> oList = new List<Staff>();
Staff oStaff = new Staff();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_By_BLOODTYPE_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_By_BLOODTYPE_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_By_BLOODTYPE_ID_List));}
#region Body Section.
List<DALC.Staff> oList_DBEntries = _AppContext.Get_Staff_By_BLOODTYPE_ID_List(i_Params_Get_Staff_By_BLOODTYPE_ID_List.BLOODTYPE_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStaff = new Staff();
oTools.CopyPropValues(oDBEntry, oStaff);
oList.Add(oStaff);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_By_BLOODTYPE_ID_List");}
return oList;
}
public List<Staff_fees> Get_Staff_fees_By_STAFF_ID_List(Params_Get_Staff_fees_By_STAFF_ID_List i_Params_Get_Staff_fees_By_STAFF_ID_List)
{
List<Staff_fees> oList = new List<Staff_fees>();
Staff_fees oStaff_fees = new Staff_fees();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_fees_By_STAFF_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_fees_By_STAFF_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_fees_By_STAFF_ID_List));}
#region Body Section.
List<DALC.Staff_fees> oList_DBEntries = _AppContext.Get_Staff_fees_By_STAFF_ID_List(i_Params_Get_Staff_fees_By_STAFF_ID_List.STAFF_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStaff_fees = new Staff_fees();
oTools.CopyPropValues(oDBEntry, oStaff_fees);
oList.Add(oStaff_fees);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_fees_By_STAFF_ID_List");}
return oList;
}
public List<Staff_fees> Get_Staff_fees_By_CURRENCY_ID_List(Params_Get_Staff_fees_By_CURRENCY_ID_List i_Params_Get_Staff_fees_By_CURRENCY_ID_List)
{
List<Staff_fees> oList = new List<Staff_fees>();
Staff_fees oStaff_fees = new Staff_fees();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_fees_By_CURRENCY_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_fees_By_CURRENCY_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_fees_By_CURRENCY_ID_List));}
#region Body Section.
List<DALC.Staff_fees> oList_DBEntries = _AppContext.Get_Staff_fees_By_CURRENCY_ID_List(i_Params_Get_Staff_fees_By_CURRENCY_ID_List.CURRENCY_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStaff_fees = new Staff_fees();
oTools.CopyPropValues(oDBEntry, oStaff_fees);
oList.Add(oStaff_fees);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_fees_By_CURRENCY_ID_List");}
return oList;
}
public List<Supplier> Get_Supplier_By_BLOODTYPE_ID_List(Params_Get_Supplier_By_BLOODTYPE_ID_List i_Params_Get_Supplier_By_BLOODTYPE_ID_List)
{
List<Supplier> oList = new List<Supplier>();
Supplier oSupplier = new Supplier();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_By_BLOODTYPE_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_By_BLOODTYPE_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_By_BLOODTYPE_ID_List));}
#region Body Section.
List<DALC.Supplier> oList_DBEntries = _AppContext.Get_Supplier_By_BLOODTYPE_ID_List(i_Params_Get_Supplier_By_BLOODTYPE_ID_List.BLOODTYPE_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier = new Supplier();
oTools.CopyPropValues(oDBEntry, oSupplier);
oList.Add(oSupplier);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_By_BLOODTYPE_ID_List");}
return oList;
}
public List<Supplier_fees> Get_Supplier_fees_By_SUPPLIER_ID_List(Params_Get_Supplier_fees_By_SUPPLIER_ID_List i_Params_Get_Supplier_fees_By_SUPPLIER_ID_List)
{
List<Supplier_fees> oList = new List<Supplier_fees>();
Supplier_fees oSupplier_fees = new Supplier_fees();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_fees_By_SUPPLIER_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_fees_By_SUPPLIER_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_fees_By_SUPPLIER_ID_List));}
#region Body Section.
List<DALC.Supplier_fees> oList_DBEntries = _AppContext.Get_Supplier_fees_By_SUPPLIER_ID_List(i_Params_Get_Supplier_fees_By_SUPPLIER_ID_List.SUPPLIER_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier_fees = new Supplier_fees();
oTools.CopyPropValues(oDBEntry, oSupplier_fees);
oList.Add(oSupplier_fees);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_fees_By_SUPPLIER_ID_List");}
return oList;
}
public List<Supplier_fees> Get_Supplier_fees_By_CURRENCY_ID_List(Params_Get_Supplier_fees_By_CURRENCY_ID_List i_Params_Get_Supplier_fees_By_CURRENCY_ID_List)
{
List<Supplier_fees> oList = new List<Supplier_fees>();
Supplier_fees oSupplier_fees = new Supplier_fees();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_fees_By_CURRENCY_ID_List");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_fees_By_CURRENCY_ID_List",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_fees_By_CURRENCY_ID_List));}
#region Body Section.
List<DALC.Supplier_fees> oList_DBEntries = _AppContext.Get_Supplier_fees_By_CURRENCY_ID_List(i_Params_Get_Supplier_fees_By_CURRENCY_ID_List.CURRENCY_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier_fees = new Supplier_fees();
oTools.CopyPropValues(oDBEntry, oSupplier_fees);
oList.Add(oSupplier_fees);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_fees_By_CURRENCY_ID_List");}
return oList;
}
public List<Address> Get_Address_By_Criteria(Params_Get_Address_By_Criteria i_Params_Get_Address_By_Criteria)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Criteria");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_Criteria",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Address_By_Criteria.OWNER_ID == null) || (i_Params_Get_Address_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Address_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Address_By_Criteria.START_ROW == null) { i_Params_Get_Address_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Address_By_Criteria.END_ROW == null) || (i_Params_Get_Address_By_Criteria.END_ROW == 0)) { i_Params_Get_Address_By_Criteria.END_ROW = 1000000; }
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Criteria(i_Params_Get_Address_By_Criteria.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Criteria.STREET,i_Params_Get_Address_By_Criteria.BUILDING,i_Params_Get_Address_By_Criteria.FLOOR,i_Params_Get_Address_By_Criteria.POBOX,i_Params_Get_Address_By_Criteria.OWNER_ID,i_Params_Get_Address_By_Criteria.START_ROW,i_Params_Get_Address_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Criteria");}
return oList;
}
public List<Address> Get_Address_By_Where(Params_Get_Address_By_Where i_Params_Get_Address_By_Where)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Where");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_Where",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_Where));}
#region Body Section.
if ((i_Params_Get_Address_By_Where.OWNER_ID == null) || (i_Params_Get_Address_By_Where.OWNER_ID == 0)) { i_Params_Get_Address_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Address_By_Where.START_ROW == null) { i_Params_Get_Address_By_Where.START_ROW = 0; }
if ((i_Params_Get_Address_By_Where.END_ROW == null) || (i_Params_Get_Address_By_Where.END_ROW == 0)) { i_Params_Get_Address_By_Where.END_ROW = 1000000; }
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Where(i_Params_Get_Address_By_Where.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Where.STREET,i_Params_Get_Address_By_Where.BUILDING,i_Params_Get_Address_By_Where.FLOOR,i_Params_Get_Address_By_Where.POBOX,i_Params_Get_Address_By_Where.OWNER_ID,i_Params_Get_Address_By_Where.START_ROW,i_Params_Get_Address_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Where");}
return oList;
}
public List<Address> Get_Address_By_Criteria_V2(Params_Get_Address_By_Criteria_V2 i_Params_Get_Address_By_Criteria_V2)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Criteria_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_Criteria_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_Criteria_V2));}
#region Body Section.
if ((i_Params_Get_Address_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_Address_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_Address_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Address_By_Criteria_V2.START_ROW == null) { i_Params_Get_Address_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_Address_By_Criteria_V2.END_ROW == null) || (i_Params_Get_Address_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_Address_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Criteria_V2(i_Params_Get_Address_By_Criteria_V2.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Criteria_V2.STREET,i_Params_Get_Address_By_Criteria_V2.BUILDING,i_Params_Get_Address_By_Criteria_V2.FLOOR,i_Params_Get_Address_By_Criteria_V2.POBOX,i_Params_Get_Address_By_Criteria_V2.VALID_DATE_START,i_Params_Get_Address_By_Criteria_V2.VALID_DATE_END,i_Params_Get_Address_By_Criteria_V2.OWNER_ID,i_Params_Get_Address_By_Criteria_V2.START_ROW,i_Params_Get_Address_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Criteria_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Criteria_V2");}
return oList;
}
public List<Address> Get_Address_By_Where_V2(Params_Get_Address_By_Where_V2 i_Params_Get_Address_By_Where_V2)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Where_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_Where_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_Where_V2));}
#region Body Section.
if ((i_Params_Get_Address_By_Where_V2.OWNER_ID == null) || (i_Params_Get_Address_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_Address_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Address_By_Where_V2.START_ROW == null) { i_Params_Get_Address_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_Address_By_Where_V2.END_ROW == null) || (i_Params_Get_Address_By_Where_V2.END_ROW == 0)) { i_Params_Get_Address_By_Where_V2.END_ROW = 1000000; }
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Where_V2(i_Params_Get_Address_By_Where_V2.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Where_V2.STREET,i_Params_Get_Address_By_Where_V2.BUILDING,i_Params_Get_Address_By_Where_V2.FLOOR,i_Params_Get_Address_By_Where_V2.POBOX,i_Params_Get_Address_By_Where_V2.VALID_DATE_START,i_Params_Get_Address_By_Where_V2.VALID_DATE_END,i_Params_Get_Address_By_Where_V2.OWNER_ID,i_Params_Get_Address_By_Where_V2.START_ROW,i_Params_Get_Address_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Where_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Where_V2");}
return oList;
}
public List<Bloodtype> Get_Bloodtype_By_Criteria(Params_Get_Bloodtype_By_Criteria i_Params_Get_Bloodtype_By_Criteria)
{
List<Bloodtype> oList = new List<Bloodtype>();
Bloodtype oBloodtype = new Bloodtype();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Bloodtype_By_Criteria");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Bloodtype_By_Criteria",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Bloodtype_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Bloodtype_By_Criteria.OWNER_ID == null) || (i_Params_Get_Bloodtype_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Bloodtype_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Bloodtype_By_Criteria.START_ROW == null) { i_Params_Get_Bloodtype_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Bloodtype_By_Criteria.END_ROW == null) || (i_Params_Get_Bloodtype_By_Criteria.END_ROW == 0)) { i_Params_Get_Bloodtype_By_Criteria.END_ROW = 1000000; }
List<DALC.Bloodtype> oList_DBEntries = _AppContext.Get_Bloodtype_By_Criteria(i_Params_Get_Bloodtype_By_Criteria.BLOODTYPE_SYMBOL,i_Params_Get_Bloodtype_By_Criteria.OWNER_ID,i_Params_Get_Bloodtype_By_Criteria.START_ROW,i_Params_Get_Bloodtype_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBloodtype = new Bloodtype();
oTools.CopyPropValues(oDBEntry, oBloodtype);
oList.Add(oBloodtype);
}
}
i_Params_Get_Bloodtype_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Bloodtype_By_Criteria");}
return oList;
}
public List<Bloodtype> Get_Bloodtype_By_Where(Params_Get_Bloodtype_By_Where i_Params_Get_Bloodtype_By_Where)
{
List<Bloodtype> oList = new List<Bloodtype>();
Bloodtype oBloodtype = new Bloodtype();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Bloodtype_By_Where");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Bloodtype_By_Where",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Bloodtype_By_Where));}
#region Body Section.
if ((i_Params_Get_Bloodtype_By_Where.OWNER_ID == null) || (i_Params_Get_Bloodtype_By_Where.OWNER_ID == 0)) { i_Params_Get_Bloodtype_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Bloodtype_By_Where.START_ROW == null) { i_Params_Get_Bloodtype_By_Where.START_ROW = 0; }
if ((i_Params_Get_Bloodtype_By_Where.END_ROW == null) || (i_Params_Get_Bloodtype_By_Where.END_ROW == 0)) { i_Params_Get_Bloodtype_By_Where.END_ROW = 1000000; }
List<DALC.Bloodtype> oList_DBEntries = _AppContext.Get_Bloodtype_By_Where(i_Params_Get_Bloodtype_By_Where.BLOODTYPE_SYMBOL,i_Params_Get_Bloodtype_By_Where.OWNER_ID,i_Params_Get_Bloodtype_By_Where.START_ROW,i_Params_Get_Bloodtype_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oBloodtype = new Bloodtype();
oTools.CopyPropValues(oDBEntry, oBloodtype);
oList.Add(oBloodtype);
}
}
i_Params_Get_Bloodtype_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Bloodtype_By_Where");}
return oList;
}
public List<Client> Get_Client_By_Criteria(Params_Get_Client_By_Criteria i_Params_Get_Client_By_Criteria)
{
List<Client> oList = new List<Client>();
Client oClient = new Client();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_By_Criteria");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Client_By_Criteria",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Client_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Client_By_Criteria.OWNER_ID == null) || (i_Params_Get_Client_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Client_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Client_By_Criteria.START_ROW == null) { i_Params_Get_Client_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Client_By_Criteria.END_ROW == null) || (i_Params_Get_Client_By_Criteria.END_ROW == 0)) { i_Params_Get_Client_By_Criteria.END_ROW = 1000000; }
List<DALC.Client> oList_DBEntries = _AppContext.Get_Client_By_Criteria(i_Params_Get_Client_By_Criteria.CLIENT_NAME,i_Params_Get_Client_By_Criteria.CLIENT_PH_NB,i_Params_Get_Client_By_Criteria.CLIENT_MAIL,i_Params_Get_Client_By_Criteria.CLIENT_GENDER,i_Params_Get_Client_By_Criteria.OWNER_ID,i_Params_Get_Client_By_Criteria.START_ROW,i_Params_Get_Client_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oClient = new Client();
oTools.CopyPropValues(oDBEntry, oClient);
oList.Add(oClient);
}
}
i_Params_Get_Client_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_By_Criteria");}
return oList;
}
public List<Client> Get_Client_By_Where(Params_Get_Client_By_Where i_Params_Get_Client_By_Where)
{
List<Client> oList = new List<Client>();
Client oClient = new Client();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_By_Where");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Client_By_Where",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Client_By_Where));}
#region Body Section.
if ((i_Params_Get_Client_By_Where.OWNER_ID == null) || (i_Params_Get_Client_By_Where.OWNER_ID == 0)) { i_Params_Get_Client_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Client_By_Where.START_ROW == null) { i_Params_Get_Client_By_Where.START_ROW = 0; }
if ((i_Params_Get_Client_By_Where.END_ROW == null) || (i_Params_Get_Client_By_Where.END_ROW == 0)) { i_Params_Get_Client_By_Where.END_ROW = 1000000; }
List<DALC.Client> oList_DBEntries = _AppContext.Get_Client_By_Where(i_Params_Get_Client_By_Where.CLIENT_NAME,i_Params_Get_Client_By_Where.CLIENT_PH_NB,i_Params_Get_Client_By_Where.CLIENT_MAIL,i_Params_Get_Client_By_Where.CLIENT_GENDER,i_Params_Get_Client_By_Where.OWNER_ID,i_Params_Get_Client_By_Where.START_ROW,i_Params_Get_Client_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oClient = new Client();
oTools.CopyPropValues(oDBEntry, oClient);
oList.Add(oClient);
}
}
i_Params_Get_Client_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_By_Where");}
return oList;
}
public List<Client> Get_Client_By_Criteria_V2(Params_Get_Client_By_Criteria_V2 i_Params_Get_Client_By_Criteria_V2)
{
List<Client> oList = new List<Client>();
Client oClient = new Client();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_By_Criteria_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Client_By_Criteria_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Client_By_Criteria_V2));}
#region Body Section.
if ((i_Params_Get_Client_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_Client_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_Client_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Client_By_Criteria_V2.START_ROW == null) { i_Params_Get_Client_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_Client_By_Criteria_V2.END_ROW == null) || (i_Params_Get_Client_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_Client_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.Client> oList_DBEntries = _AppContext.Get_Client_By_Criteria_V2(i_Params_Get_Client_By_Criteria_V2.CLIENT_NAME,i_Params_Get_Client_By_Criteria_V2.CLIENT_PH_NB,i_Params_Get_Client_By_Criteria_V2.CLIENT_MAIL,i_Params_Get_Client_By_Criteria_V2.CLIENT_DOB,i_Params_Get_Client_By_Criteria_V2.CLIENT_GENDER,i_Params_Get_Client_By_Criteria_V2.OWNER_ID,i_Params_Get_Client_By_Criteria_V2.START_ROW,i_Params_Get_Client_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oClient = new Client();
oTools.CopyPropValues(oDBEntry, oClient);
oList.Add(oClient);
}
}
i_Params_Get_Client_By_Criteria_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_By_Criteria_V2");}
return oList;
}
public List<Client> Get_Client_By_Where_V2(Params_Get_Client_By_Where_V2 i_Params_Get_Client_By_Where_V2)
{
List<Client> oList = new List<Client>();
Client oClient = new Client();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_By_Where_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Client_By_Where_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Client_By_Where_V2));}
#region Body Section.
if ((i_Params_Get_Client_By_Where_V2.OWNER_ID == null) || (i_Params_Get_Client_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_Client_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Client_By_Where_V2.START_ROW == null) { i_Params_Get_Client_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_Client_By_Where_V2.END_ROW == null) || (i_Params_Get_Client_By_Where_V2.END_ROW == 0)) { i_Params_Get_Client_By_Where_V2.END_ROW = 1000000; }
List<DALC.Client> oList_DBEntries = _AppContext.Get_Client_By_Where_V2(i_Params_Get_Client_By_Where_V2.CLIENT_NAME,i_Params_Get_Client_By_Where_V2.CLIENT_PH_NB,i_Params_Get_Client_By_Where_V2.CLIENT_MAIL,i_Params_Get_Client_By_Where_V2.CLIENT_DOB,i_Params_Get_Client_By_Where_V2.CLIENT_GENDER,i_Params_Get_Client_By_Where_V2.OWNER_ID,i_Params_Get_Client_By_Where_V2.START_ROW,i_Params_Get_Client_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oClient = new Client();
oTools.CopyPropValues(oDBEntry, oClient);
oList.Add(oClient);
}
}
i_Params_Get_Client_By_Where_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_By_Where_V2");}
return oList;
}
public List<Client_fees> Get_Client_fees_By_Criteria(Params_Get_Client_fees_By_Criteria i_Params_Get_Client_fees_By_Criteria)
{
List<Client_fees> oList = new List<Client_fees>();
Client_fees oClient_fees = new Client_fees();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_fees_By_Criteria");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Client_fees_By_Criteria",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Client_fees_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Client_fees_By_Criteria.OWNER_ID == null) || (i_Params_Get_Client_fees_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Client_fees_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Client_fees_By_Criteria.START_ROW == null) { i_Params_Get_Client_fees_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Client_fees_By_Criteria.END_ROW == null) || (i_Params_Get_Client_fees_By_Criteria.END_ROW == 0)) { i_Params_Get_Client_fees_By_Criteria.END_ROW = 1000000; }
List<DALC.Client_fees> oList_DBEntries = _AppContext.Get_Client_fees_By_Criteria(i_Params_Get_Client_fees_By_Criteria.CLIENT_FEES_DESCRIPTION,i_Params_Get_Client_fees_By_Criteria.OWNER_ID,i_Params_Get_Client_fees_By_Criteria.START_ROW,i_Params_Get_Client_fees_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oClient_fees = new Client_fees();
oTools.CopyPropValues(oDBEntry, oClient_fees);
oList.Add(oClient_fees);
}
}
i_Params_Get_Client_fees_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_fees_By_Criteria");}
return oList;
}
public List<Client_fees> Get_Client_fees_By_Where(Params_Get_Client_fees_By_Where i_Params_Get_Client_fees_By_Where)
{
List<Client_fees> oList = new List<Client_fees>();
Client_fees oClient_fees = new Client_fees();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_fees_By_Where");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Client_fees_By_Where",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Client_fees_By_Where));}
#region Body Section.
if ((i_Params_Get_Client_fees_By_Where.OWNER_ID == null) || (i_Params_Get_Client_fees_By_Where.OWNER_ID == 0)) { i_Params_Get_Client_fees_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Client_fees_By_Where.START_ROW == null) { i_Params_Get_Client_fees_By_Where.START_ROW = 0; }
if ((i_Params_Get_Client_fees_By_Where.END_ROW == null) || (i_Params_Get_Client_fees_By_Where.END_ROW == 0)) { i_Params_Get_Client_fees_By_Where.END_ROW = 1000000; }
List<DALC.Client_fees> oList_DBEntries = _AppContext.Get_Client_fees_By_Where(i_Params_Get_Client_fees_By_Where.CLIENT_FEES_DESCRIPTION,i_Params_Get_Client_fees_By_Where.OWNER_ID,i_Params_Get_Client_fees_By_Where.START_ROW,i_Params_Get_Client_fees_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oClient_fees = new Client_fees();
oTools.CopyPropValues(oDBEntry, oClient_fees);
oList.Add(oClient_fees);
}
}
i_Params_Get_Client_fees_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_fees_By_Where");}
return oList;
}
public List<Contact> Get_Contact_By_Criteria(Params_Get_Contact_By_Criteria i_Params_Get_Contact_By_Criteria)
{
List<Contact> oList = new List<Contact>();
Contact oContact = new Contact();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_Criteria");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Contact_By_Criteria",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Contact_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Contact_By_Criteria.OWNER_ID == null) || (i_Params_Get_Contact_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Contact_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Contact_By_Criteria.START_ROW == null) { i_Params_Get_Contact_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Contact_By_Criteria.END_ROW == null) || (i_Params_Get_Contact_By_Criteria.END_ROW == 0)) { i_Params_Get_Contact_By_Criteria.END_ROW = 1000000; }
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_Criteria(i_Params_Get_Contact_By_Criteria.CONTACT_TYPE_CODE,i_Params_Get_Contact_By_Criteria.CONTACT,i_Params_Get_Contact_By_Criteria.DESCRIPTION,i_Params_Get_Contact_By_Criteria.OWNER_ID,i_Params_Get_Contact_By_Criteria.START_ROW,i_Params_Get_Contact_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oList.Add(oContact);
}
}
i_Params_Get_Contact_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_Criteria");}
return oList;
}
public List<Contact> Get_Contact_By_Where(Params_Get_Contact_By_Where i_Params_Get_Contact_By_Where)
{
List<Contact> oList = new List<Contact>();
Contact oContact = new Contact();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_Where");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Contact_By_Where",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Contact_By_Where));}
#region Body Section.
if ((i_Params_Get_Contact_By_Where.OWNER_ID == null) || (i_Params_Get_Contact_By_Where.OWNER_ID == 0)) { i_Params_Get_Contact_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Contact_By_Where.START_ROW == null) { i_Params_Get_Contact_By_Where.START_ROW = 0; }
if ((i_Params_Get_Contact_By_Where.END_ROW == null) || (i_Params_Get_Contact_By_Where.END_ROW == 0)) { i_Params_Get_Contact_By_Where.END_ROW = 1000000; }
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_Where(i_Params_Get_Contact_By_Where.CONTACT_TYPE_CODE,i_Params_Get_Contact_By_Where.CONTACT,i_Params_Get_Contact_By_Where.DESCRIPTION,i_Params_Get_Contact_By_Where.OWNER_ID,i_Params_Get_Contact_By_Where.START_ROW,i_Params_Get_Contact_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oList.Add(oContact);
}
}
i_Params_Get_Contact_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_Where");}
return oList;
}
public List<Currency> Get_Currency_By_Criteria(Params_Get_Currency_By_Criteria i_Params_Get_Currency_By_Criteria)
{
List<Currency> oList = new List<Currency>();
Currency oCurrency = new Currency();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Currency_By_Criteria");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Currency_By_Criteria",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Currency_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Currency_By_Criteria.OWNER_ID == null) || (i_Params_Get_Currency_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Currency_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Currency_By_Criteria.START_ROW == null) { i_Params_Get_Currency_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Currency_By_Criteria.END_ROW == null) || (i_Params_Get_Currency_By_Criteria.END_ROW == 0)) { i_Params_Get_Currency_By_Criteria.END_ROW = 1000000; }
List<DALC.Currency> oList_DBEntries = _AppContext.Get_Currency_By_Criteria(i_Params_Get_Currency_By_Criteria.CURRENCY_TYPE,i_Params_Get_Currency_By_Criteria.CURRENCY_SYMBOL,i_Params_Get_Currency_By_Criteria.OWNER_ID,i_Params_Get_Currency_By_Criteria.START_ROW,i_Params_Get_Currency_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCurrency = new Currency();
oTools.CopyPropValues(oDBEntry, oCurrency);
oList.Add(oCurrency);
}
}
i_Params_Get_Currency_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Currency_By_Criteria");}
return oList;
}
public List<Currency> Get_Currency_By_Where(Params_Get_Currency_By_Where i_Params_Get_Currency_By_Where)
{
List<Currency> oList = new List<Currency>();
Currency oCurrency = new Currency();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Currency_By_Where");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Currency_By_Where",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Currency_By_Where));}
#region Body Section.
if ((i_Params_Get_Currency_By_Where.OWNER_ID == null) || (i_Params_Get_Currency_By_Where.OWNER_ID == 0)) { i_Params_Get_Currency_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Currency_By_Where.START_ROW == null) { i_Params_Get_Currency_By_Where.START_ROW = 0; }
if ((i_Params_Get_Currency_By_Where.END_ROW == null) || (i_Params_Get_Currency_By_Where.END_ROW == 0)) { i_Params_Get_Currency_By_Where.END_ROW = 1000000; }
List<DALC.Currency> oList_DBEntries = _AppContext.Get_Currency_By_Where(i_Params_Get_Currency_By_Where.CURRENCY_TYPE,i_Params_Get_Currency_By_Where.CURRENCY_SYMBOL,i_Params_Get_Currency_By_Where.OWNER_ID,i_Params_Get_Currency_By_Where.START_ROW,i_Params_Get_Currency_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oCurrency = new Currency();
oTools.CopyPropValues(oDBEntry, oCurrency);
oList.Add(oCurrency);
}
}
i_Params_Get_Currency_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Currency_By_Where");}
return oList;
}
public List<Fees> Get_Fees_By_Criteria(Params_Get_Fees_By_Criteria i_Params_Get_Fees_By_Criteria)
{
List<Fees> oList = new List<Fees>();
Fees oFees = new Fees();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Fees_By_Criteria");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Fees_By_Criteria",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Fees_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Fees_By_Criteria.OWNER_ID == null) || (i_Params_Get_Fees_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Fees_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Fees_By_Criteria.START_ROW == null) { i_Params_Get_Fees_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Fees_By_Criteria.END_ROW == null) || (i_Params_Get_Fees_By_Criteria.END_ROW == 0)) { i_Params_Get_Fees_By_Criteria.END_ROW = 1000000; }
List<DALC.Fees> oList_DBEntries = _AppContext.Get_Fees_By_Criteria(i_Params_Get_Fees_By_Criteria.FEES_DESCRIPTION,i_Params_Get_Fees_By_Criteria.OWNER_ID,i_Params_Get_Fees_By_Criteria.START_ROW,i_Params_Get_Fees_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFees = new Fees();
oTools.CopyPropValues(oDBEntry, oFees);
oList.Add(oFees);
}
}
i_Params_Get_Fees_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Fees_By_Criteria");}
return oList;
}
public List<Fees> Get_Fees_By_Where(Params_Get_Fees_By_Where i_Params_Get_Fees_By_Where)
{
List<Fees> oList = new List<Fees>();
Fees oFees = new Fees();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Fees_By_Where");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Fees_By_Where",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Fees_By_Where));}
#region Body Section.
if ((i_Params_Get_Fees_By_Where.OWNER_ID == null) || (i_Params_Get_Fees_By_Where.OWNER_ID == 0)) { i_Params_Get_Fees_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Fees_By_Where.START_ROW == null) { i_Params_Get_Fees_By_Where.START_ROW = 0; }
if ((i_Params_Get_Fees_By_Where.END_ROW == null) || (i_Params_Get_Fees_By_Where.END_ROW == 0)) { i_Params_Get_Fees_By_Where.END_ROW = 1000000; }
List<DALC.Fees> oList_DBEntries = _AppContext.Get_Fees_By_Where(i_Params_Get_Fees_By_Where.FEES_DESCRIPTION,i_Params_Get_Fees_By_Where.OWNER_ID,i_Params_Get_Fees_By_Where.START_ROW,i_Params_Get_Fees_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFees = new Fees();
oTools.CopyPropValues(oDBEntry, oFees);
oList.Add(oFees);
}
}
i_Params_Get_Fees_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Fees_By_Where");}
return oList;
}
public List<Fees> Get_Fees_By_Criteria_V2(Params_Get_Fees_By_Criteria_V2 i_Params_Get_Fees_By_Criteria_V2)
{
List<Fees> oList = new List<Fees>();
Fees oFees = new Fees();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Fees_By_Criteria_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Fees_By_Criteria_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Fees_By_Criteria_V2));}
#region Body Section.
if ((i_Params_Get_Fees_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_Fees_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_Fees_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Fees_By_Criteria_V2.START_ROW == null) { i_Params_Get_Fees_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_Fees_By_Criteria_V2.END_ROW == null) || (i_Params_Get_Fees_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_Fees_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.Fees> oList_DBEntries = _AppContext.Get_Fees_By_Criteria_V2(i_Params_Get_Fees_By_Criteria_V2.FEES_DESCRIPTION,i_Params_Get_Fees_By_Criteria_V2.FEES_ORIGIN_DATE,i_Params_Get_Fees_By_Criteria_V2.OWNER_ID,i_Params_Get_Fees_By_Criteria_V2.START_ROW,i_Params_Get_Fees_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFees = new Fees();
oTools.CopyPropValues(oDBEntry, oFees);
oList.Add(oFees);
}
}
i_Params_Get_Fees_By_Criteria_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Fees_By_Criteria_V2");}
return oList;
}
public List<Fees> Get_Fees_By_Where_V2(Params_Get_Fees_By_Where_V2 i_Params_Get_Fees_By_Where_V2)
{
List<Fees> oList = new List<Fees>();
Fees oFees = new Fees();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Fees_By_Where_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Fees_By_Where_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Fees_By_Where_V2));}
#region Body Section.
if ((i_Params_Get_Fees_By_Where_V2.OWNER_ID == null) || (i_Params_Get_Fees_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_Fees_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Fees_By_Where_V2.START_ROW == null) { i_Params_Get_Fees_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_Fees_By_Where_V2.END_ROW == null) || (i_Params_Get_Fees_By_Where_V2.END_ROW == 0)) { i_Params_Get_Fees_By_Where_V2.END_ROW = 1000000; }
List<DALC.Fees> oList_DBEntries = _AppContext.Get_Fees_By_Where_V2(i_Params_Get_Fees_By_Where_V2.FEES_DESCRIPTION,i_Params_Get_Fees_By_Where_V2.FEES_ORIGIN_DATE,i_Params_Get_Fees_By_Where_V2.OWNER_ID,i_Params_Get_Fees_By_Where_V2.START_ROW,i_Params_Get_Fees_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFees = new Fees();
oTools.CopyPropValues(oDBEntry, oFees);
oList.Add(oFees);
}
}
i_Params_Get_Fees_By_Where_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Fees_By_Where_V2");}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_Criteria(Params_Get_Loc_l1_By_Criteria i_Params_Get_Loc_l1_By_Criteria)
{
List<Loc_l1> oList = new List<Loc_l1>();
Loc_l1 oLoc_l1 = new Loc_l1();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l1_By_Criteria");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l1_By_Criteria",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l1_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Loc_l1_By_Criteria.OWNER_ID == null) || (i_Params_Get_Loc_l1_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Loc_l1_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l1_By_Criteria.START_ROW == null) { i_Params_Get_Loc_l1_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Loc_l1_By_Criteria.END_ROW == null) || (i_Params_Get_Loc_l1_By_Criteria.END_ROW == 0)) { i_Params_Get_Loc_l1_By_Criteria.END_ROW = 1000000; }
List<DALC.Loc_l1> oList_DBEntries = _AppContext.Get_Loc_l1_By_Criteria(i_Params_Get_Loc_l1_By_Criteria.CODE,i_Params_Get_Loc_l1_By_Criteria.DESCRIPTION,i_Params_Get_Loc_l1_By_Criteria.OWNER_ID,i_Params_Get_Loc_l1_By_Criteria.START_ROW,i_Params_Get_Loc_l1_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry, oLoc_l1);
oList.Add(oLoc_l1);
}
}
i_Params_Get_Loc_l1_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l1_By_Criteria");}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_Where(Params_Get_Loc_l1_By_Where i_Params_Get_Loc_l1_By_Where)
{
List<Loc_l1> oList = new List<Loc_l1>();
Loc_l1 oLoc_l1 = new Loc_l1();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l1_By_Where");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l1_By_Where",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l1_By_Where));}
#region Body Section.
if ((i_Params_Get_Loc_l1_By_Where.OWNER_ID == null) || (i_Params_Get_Loc_l1_By_Where.OWNER_ID == 0)) { i_Params_Get_Loc_l1_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l1_By_Where.START_ROW == null) { i_Params_Get_Loc_l1_By_Where.START_ROW = 0; }
if ((i_Params_Get_Loc_l1_By_Where.END_ROW == null) || (i_Params_Get_Loc_l1_By_Where.END_ROW == 0)) { i_Params_Get_Loc_l1_By_Where.END_ROW = 1000000; }
List<DALC.Loc_l1> oList_DBEntries = _AppContext.Get_Loc_l1_By_Where(i_Params_Get_Loc_l1_By_Where.CODE,i_Params_Get_Loc_l1_By_Where.DESCRIPTION,i_Params_Get_Loc_l1_By_Where.OWNER_ID,i_Params_Get_Loc_l1_By_Where.START_ROW,i_Params_Get_Loc_l1_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry, oLoc_l1);
oList.Add(oLoc_l1);
}
}
i_Params_Get_Loc_l1_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l1_By_Where");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Criteria(Params_Get_Loc_l2_By_Criteria i_Params_Get_Loc_l2_By_Criteria)
{
List<Loc_l2> oList = new List<Loc_l2>();
Loc_l2 oLoc_l2 = new Loc_l2();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_Criteria");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l2_By_Criteria",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l2_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Loc_l2_By_Criteria.OWNER_ID == null) || (i_Params_Get_Loc_l2_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Loc_l2_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l2_By_Criteria.START_ROW == null) { i_Params_Get_Loc_l2_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Loc_l2_By_Criteria.END_ROW == null) || (i_Params_Get_Loc_l2_By_Criteria.END_ROW == 0)) { i_Params_Get_Loc_l2_By_Criteria.END_ROW = 1000000; }
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_Criteria(i_Params_Get_Loc_l2_By_Criteria.CODE,i_Params_Get_Loc_l2_By_Criteria.DESCRIPTION,i_Params_Get_Loc_l2_By_Criteria.OWNER_ID,i_Params_Get_Loc_l2_By_Criteria.START_ROW,i_Params_Get_Loc_l2_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oList.Add(oLoc_l2);
}
}
i_Params_Get_Loc_l2_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_Criteria");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Where(Params_Get_Loc_l2_By_Where i_Params_Get_Loc_l2_By_Where)
{
List<Loc_l2> oList = new List<Loc_l2>();
Loc_l2 oLoc_l2 = new Loc_l2();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_Where");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l2_By_Where",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l2_By_Where));}
#region Body Section.
if ((i_Params_Get_Loc_l2_By_Where.OWNER_ID == null) || (i_Params_Get_Loc_l2_By_Where.OWNER_ID == 0)) { i_Params_Get_Loc_l2_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l2_By_Where.START_ROW == null) { i_Params_Get_Loc_l2_By_Where.START_ROW = 0; }
if ((i_Params_Get_Loc_l2_By_Where.END_ROW == null) || (i_Params_Get_Loc_l2_By_Where.END_ROW == 0)) { i_Params_Get_Loc_l2_By_Where.END_ROW = 1000000; }
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_Where(i_Params_Get_Loc_l2_By_Where.CODE,i_Params_Get_Loc_l2_By_Where.DESCRIPTION,i_Params_Get_Loc_l2_By_Where.OWNER_ID,i_Params_Get_Loc_l2_By_Where.START_ROW,i_Params_Get_Loc_l2_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oList.Add(oLoc_l2);
}
}
i_Params_Get_Loc_l2_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_Where");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Criteria(Params_Get_Loc_l3_By_Criteria i_Params_Get_Loc_l3_By_Criteria)
{
List<Loc_l3> oList = new List<Loc_l3>();
Loc_l3 oLoc_l3 = new Loc_l3();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_Criteria");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l3_By_Criteria",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l3_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Loc_l3_By_Criteria.OWNER_ID == null) || (i_Params_Get_Loc_l3_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Loc_l3_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l3_By_Criteria.START_ROW == null) { i_Params_Get_Loc_l3_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Loc_l3_By_Criteria.END_ROW == null) || (i_Params_Get_Loc_l3_By_Criteria.END_ROW == 0)) { i_Params_Get_Loc_l3_By_Criteria.END_ROW = 1000000; }
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_Criteria(i_Params_Get_Loc_l3_By_Criteria.CODE,i_Params_Get_Loc_l3_By_Criteria.DESCRIPTION,i_Params_Get_Loc_l3_By_Criteria.OWNER_ID,i_Params_Get_Loc_l3_By_Criteria.START_ROW,i_Params_Get_Loc_l3_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oList.Add(oLoc_l3);
}
}
i_Params_Get_Loc_l3_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_Criteria");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Where(Params_Get_Loc_l3_By_Where i_Params_Get_Loc_l3_By_Where)
{
List<Loc_l3> oList = new List<Loc_l3>();
Loc_l3 oLoc_l3 = new Loc_l3();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_Where");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l3_By_Where",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l3_By_Where));}
#region Body Section.
if ((i_Params_Get_Loc_l3_By_Where.OWNER_ID == null) || (i_Params_Get_Loc_l3_By_Where.OWNER_ID == 0)) { i_Params_Get_Loc_l3_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l3_By_Where.START_ROW == null) { i_Params_Get_Loc_l3_By_Where.START_ROW = 0; }
if ((i_Params_Get_Loc_l3_By_Where.END_ROW == null) || (i_Params_Get_Loc_l3_By_Where.END_ROW == 0)) { i_Params_Get_Loc_l3_By_Where.END_ROW = 1000000; }
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_Where(i_Params_Get_Loc_l3_By_Where.CODE,i_Params_Get_Loc_l3_By_Where.DESCRIPTION,i_Params_Get_Loc_l3_By_Where.OWNER_ID,i_Params_Get_Loc_l3_By_Where.START_ROW,i_Params_Get_Loc_l3_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oList.Add(oLoc_l3);
}
}
i_Params_Get_Loc_l3_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_Where");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Criteria(Params_Get_Loc_l4_By_Criteria i_Params_Get_Loc_l4_By_Criteria)
{
List<Loc_l4> oList = new List<Loc_l4>();
Loc_l4 oLoc_l4 = new Loc_l4();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_Criteria");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l4_By_Criteria",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l4_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Loc_l4_By_Criteria.OWNER_ID == null) || (i_Params_Get_Loc_l4_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Loc_l4_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l4_By_Criteria.START_ROW == null) { i_Params_Get_Loc_l4_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Loc_l4_By_Criteria.END_ROW == null) || (i_Params_Get_Loc_l4_By_Criteria.END_ROW == 0)) { i_Params_Get_Loc_l4_By_Criteria.END_ROW = 1000000; }
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_Criteria(i_Params_Get_Loc_l4_By_Criteria.CODE,i_Params_Get_Loc_l4_By_Criteria.DESCRIPTION,i_Params_Get_Loc_l4_By_Criteria.OWNER_ID,i_Params_Get_Loc_l4_By_Criteria.START_ROW,i_Params_Get_Loc_l4_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oList.Add(oLoc_l4);
}
}
i_Params_Get_Loc_l4_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_Criteria");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Where(Params_Get_Loc_l4_By_Where i_Params_Get_Loc_l4_By_Where)
{
List<Loc_l4> oList = new List<Loc_l4>();
Loc_l4 oLoc_l4 = new Loc_l4();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_Where");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l4_By_Where",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l4_By_Where));}
#region Body Section.
if ((i_Params_Get_Loc_l4_By_Where.OWNER_ID == null) || (i_Params_Get_Loc_l4_By_Where.OWNER_ID == 0)) { i_Params_Get_Loc_l4_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l4_By_Where.START_ROW == null) { i_Params_Get_Loc_l4_By_Where.START_ROW = 0; }
if ((i_Params_Get_Loc_l4_By_Where.END_ROW == null) || (i_Params_Get_Loc_l4_By_Where.END_ROW == 0)) { i_Params_Get_Loc_l4_By_Where.END_ROW = 1000000; }
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_Where(i_Params_Get_Loc_l4_By_Where.CODE,i_Params_Get_Loc_l4_By_Where.DESCRIPTION,i_Params_Get_Loc_l4_By_Where.OWNER_ID,i_Params_Get_Loc_l4_By_Where.START_ROW,i_Params_Get_Loc_l4_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oList.Add(oLoc_l4);
}
}
i_Params_Get_Loc_l4_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_Where");}
return oList;
}
public List<Method_run> Get_Method_run_By_Criteria(Params_Get_Method_run_By_Criteria i_Params_Get_Method_run_By_Criteria)
{
List<Method_run> oList = new List<Method_run>();
Method_run oMethod_run = new Method_run();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Method_run_By_Criteria");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Method_run_By_Criteria",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Method_run_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Method_run_By_Criteria.OWNER_ID == null) || (i_Params_Get_Method_run_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Method_run_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Method_run_By_Criteria.START_ROW == null) { i_Params_Get_Method_run_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Method_run_By_Criteria.END_ROW == null) || (i_Params_Get_Method_run_By_Criteria.END_ROW == 0)) { i_Params_Get_Method_run_By_Criteria.END_ROW = 1000000; }
List<DALC.Method_run> oList_DBEntries = _AppContext.Get_Method_run_By_Criteria(i_Params_Get_Method_run_By_Criteria.METHOD_NAME,i_Params_Get_Method_run_By_Criteria.INPUT_PARAM,i_Params_Get_Method_run_By_Criteria.OWNER_ID,i_Params_Get_Method_run_By_Criteria.START_ROW,i_Params_Get_Method_run_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oMethod_run = new Method_run();
oTools.CopyPropValues(oDBEntry, oMethod_run);
oList.Add(oMethod_run);
}
}
i_Params_Get_Method_run_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Method_run_By_Criteria");}
return oList;
}
public List<Method_run> Get_Method_run_By_Where(Params_Get_Method_run_By_Where i_Params_Get_Method_run_By_Where)
{
List<Method_run> oList = new List<Method_run>();
Method_run oMethod_run = new Method_run();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Method_run_By_Where");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Method_run_By_Where",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Method_run_By_Where));}
#region Body Section.
if ((i_Params_Get_Method_run_By_Where.OWNER_ID == null) || (i_Params_Get_Method_run_By_Where.OWNER_ID == 0)) { i_Params_Get_Method_run_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Method_run_By_Where.START_ROW == null) { i_Params_Get_Method_run_By_Where.START_ROW = 0; }
if ((i_Params_Get_Method_run_By_Where.END_ROW == null) || (i_Params_Get_Method_run_By_Where.END_ROW == 0)) { i_Params_Get_Method_run_By_Where.END_ROW = 1000000; }
List<DALC.Method_run> oList_DBEntries = _AppContext.Get_Method_run_By_Where(i_Params_Get_Method_run_By_Where.METHOD_NAME,i_Params_Get_Method_run_By_Where.INPUT_PARAM,i_Params_Get_Method_run_By_Where.OWNER_ID,i_Params_Get_Method_run_By_Where.START_ROW,i_Params_Get_Method_run_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oMethod_run = new Method_run();
oTools.CopyPropValues(oDBEntry, oMethod_run);
oList.Add(oMethod_run);
}
}
i_Params_Get_Method_run_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Method_run_By_Where");}
return oList;
}
public List<Method_run> Get_Method_run_By_Criteria_V2(Params_Get_Method_run_By_Criteria_V2 i_Params_Get_Method_run_By_Criteria_V2)
{
List<Method_run> oList = new List<Method_run>();
Method_run oMethod_run = new Method_run();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Method_run_By_Criteria_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Method_run_By_Criteria_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Method_run_By_Criteria_V2));}
#region Body Section.
if ((i_Params_Get_Method_run_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_Method_run_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_Method_run_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Method_run_By_Criteria_V2.START_ROW == null) { i_Params_Get_Method_run_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_Method_run_By_Criteria_V2.END_ROW == null) || (i_Params_Get_Method_run_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_Method_run_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.Method_run> oList_DBEntries = _AppContext.Get_Method_run_By_Criteria_V2(i_Params_Get_Method_run_By_Criteria_V2.METHOD_NAME,i_Params_Get_Method_run_By_Criteria_V2.RUN_DATE,i_Params_Get_Method_run_By_Criteria_V2.INPUT_PARAM,i_Params_Get_Method_run_By_Criteria_V2.OWNER_ID,i_Params_Get_Method_run_By_Criteria_V2.START_ROW,i_Params_Get_Method_run_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oMethod_run = new Method_run();
oTools.CopyPropValues(oDBEntry, oMethod_run);
oList.Add(oMethod_run);
}
}
i_Params_Get_Method_run_By_Criteria_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Method_run_By_Criteria_V2");}
return oList;
}
public List<Method_run> Get_Method_run_By_Where_V2(Params_Get_Method_run_By_Where_V2 i_Params_Get_Method_run_By_Where_V2)
{
List<Method_run> oList = new List<Method_run>();
Method_run oMethod_run = new Method_run();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Method_run_By_Where_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Method_run_By_Where_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Method_run_By_Where_V2));}
#region Body Section.
if ((i_Params_Get_Method_run_By_Where_V2.OWNER_ID == null) || (i_Params_Get_Method_run_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_Method_run_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Method_run_By_Where_V2.START_ROW == null) { i_Params_Get_Method_run_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_Method_run_By_Where_V2.END_ROW == null) || (i_Params_Get_Method_run_By_Where_V2.END_ROW == 0)) { i_Params_Get_Method_run_By_Where_V2.END_ROW = 1000000; }
List<DALC.Method_run> oList_DBEntries = _AppContext.Get_Method_run_By_Where_V2(i_Params_Get_Method_run_By_Where_V2.METHOD_NAME,i_Params_Get_Method_run_By_Where_V2.RUN_DATE,i_Params_Get_Method_run_By_Where_V2.INPUT_PARAM,i_Params_Get_Method_run_By_Where_V2.OWNER_ID,i_Params_Get_Method_run_By_Where_V2.START_ROW,i_Params_Get_Method_run_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oMethod_run = new Method_run();
oTools.CopyPropValues(oDBEntry, oMethod_run);
oList.Add(oMethod_run);
}
}
i_Params_Get_Method_run_By_Where_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Method_run_By_Where_V2");}
return oList;
}
public List<Owner> Get_Owner_By_Criteria(Params_Get_Owner_By_Criteria i_Params_Get_Owner_By_Criteria)
{
List<Owner> oList = new List<Owner>();
Owner oOwner = new Owner();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Owner_By_Criteria");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Owner_By_Criteria",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Owner_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Owner_By_Criteria.OWNER_ID == null) || (i_Params_Get_Owner_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Owner_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Owner_By_Criteria.START_ROW == null) { i_Params_Get_Owner_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Owner_By_Criteria.END_ROW == null) || (i_Params_Get_Owner_By_Criteria.END_ROW == 0)) { i_Params_Get_Owner_By_Criteria.END_ROW = 1000000; }
List<DALC.Owner> oList_DBEntries = _AppContext.Get_Owner_By_Criteria(i_Params_Get_Owner_By_Criteria.CODE,i_Params_Get_Owner_By_Criteria.DESCRIPTION,i_Params_Get_Owner_By_Criteria.OWNER_ID,i_Params_Get_Owner_By_Criteria.START_ROW,i_Params_Get_Owner_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOwner = new Owner();
oTools.CopyPropValues(oDBEntry, oOwner);
oList.Add(oOwner);
}
}
i_Params_Get_Owner_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Owner_By_Criteria");}
return oList;
}
public List<Owner> Get_Owner_By_Where(Params_Get_Owner_By_Where i_Params_Get_Owner_By_Where)
{
List<Owner> oList = new List<Owner>();
Owner oOwner = new Owner();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Owner_By_Where");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Owner_By_Where",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Owner_By_Where));}
#region Body Section.
if ((i_Params_Get_Owner_By_Where.OWNER_ID == null) || (i_Params_Get_Owner_By_Where.OWNER_ID == 0)) { i_Params_Get_Owner_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Owner_By_Where.START_ROW == null) { i_Params_Get_Owner_By_Where.START_ROW = 0; }
if ((i_Params_Get_Owner_By_Where.END_ROW == null) || (i_Params_Get_Owner_By_Where.END_ROW == 0)) { i_Params_Get_Owner_By_Where.END_ROW = 1000000; }
List<DALC.Owner> oList_DBEntries = _AppContext.Get_Owner_By_Where(i_Params_Get_Owner_By_Where.CODE,i_Params_Get_Owner_By_Where.DESCRIPTION,i_Params_Get_Owner_By_Where.OWNER_ID,i_Params_Get_Owner_By_Where.START_ROW,i_Params_Get_Owner_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOwner = new Owner();
oTools.CopyPropValues(oDBEntry, oOwner);
oList.Add(oOwner);
}
}
i_Params_Get_Owner_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Owner_By_Where");}
return oList;
}
public List<Owner> Get_Owner_By_Criteria_V2(Params_Get_Owner_By_Criteria_V2 i_Params_Get_Owner_By_Criteria_V2)
{
List<Owner> oList = new List<Owner>();
Owner oOwner = new Owner();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Owner_By_Criteria_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Owner_By_Criteria_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Owner_By_Criteria_V2));}
#region Body Section.
if ((i_Params_Get_Owner_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_Owner_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_Owner_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Owner_By_Criteria_V2.START_ROW == null) { i_Params_Get_Owner_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_Owner_By_Criteria_V2.END_ROW == null) || (i_Params_Get_Owner_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_Owner_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.Owner> oList_DBEntries = _AppContext.Get_Owner_By_Criteria_V2(i_Params_Get_Owner_By_Criteria_V2.CODE,i_Params_Get_Owner_By_Criteria_V2.MAINTENANCE_DUE_DATE,i_Params_Get_Owner_By_Criteria_V2.DESCRIPTION,i_Params_Get_Owner_By_Criteria_V2.OWNER_ID,i_Params_Get_Owner_By_Criteria_V2.START_ROW,i_Params_Get_Owner_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOwner = new Owner();
oTools.CopyPropValues(oDBEntry, oOwner);
oList.Add(oOwner);
}
}
i_Params_Get_Owner_By_Criteria_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Owner_By_Criteria_V2");}
return oList;
}
public List<Owner> Get_Owner_By_Where_V2(Params_Get_Owner_By_Where_V2 i_Params_Get_Owner_By_Where_V2)
{
List<Owner> oList = new List<Owner>();
Owner oOwner = new Owner();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Owner_By_Where_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Owner_By_Where_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Owner_By_Where_V2));}
#region Body Section.
if ((i_Params_Get_Owner_By_Where_V2.OWNER_ID == null) || (i_Params_Get_Owner_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_Owner_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Owner_By_Where_V2.START_ROW == null) { i_Params_Get_Owner_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_Owner_By_Where_V2.END_ROW == null) || (i_Params_Get_Owner_By_Where_V2.END_ROW == 0)) { i_Params_Get_Owner_By_Where_V2.END_ROW = 1000000; }
List<DALC.Owner> oList_DBEntries = _AppContext.Get_Owner_By_Where_V2(i_Params_Get_Owner_By_Where_V2.CODE,i_Params_Get_Owner_By_Where_V2.MAINTENANCE_DUE_DATE,i_Params_Get_Owner_By_Where_V2.DESCRIPTION,i_Params_Get_Owner_By_Where_V2.OWNER_ID,i_Params_Get_Owner_By_Where_V2.START_ROW,i_Params_Get_Owner_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oOwner = new Owner();
oTools.CopyPropValues(oDBEntry, oOwner);
oList.Add(oOwner);
}
}
i_Params_Get_Owner_By_Where_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Owner_By_Where_V2");}
return oList;
}
public List<Package> Get_Package_By_Criteria(Params_Get_Package_By_Criteria i_Params_Get_Package_By_Criteria)
{
List<Package> oList = new List<Package>();
Package oPackage = new Package();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Package_By_Criteria");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Package_By_Criteria",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Package_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Package_By_Criteria.OWNER_ID == null) || (i_Params_Get_Package_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Package_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Package_By_Criteria.START_ROW == null) { i_Params_Get_Package_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Package_By_Criteria.END_ROW == null) || (i_Params_Get_Package_By_Criteria.END_ROW == 0)) { i_Params_Get_Package_By_Criteria.END_ROW = 1000000; }
List<DALC.Package> oList_DBEntries = _AppContext.Get_Package_By_Criteria(i_Params_Get_Package_By_Criteria.PACKAGE_NAME,i_Params_Get_Package_By_Criteria.PACKAGE_TYPE,i_Params_Get_Package_By_Criteria.PACKAGE_TIMELINE,i_Params_Get_Package_By_Criteria.OWNER_ID,i_Params_Get_Package_By_Criteria.START_ROW,i_Params_Get_Package_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oPackage = new Package();
oTools.CopyPropValues(oDBEntry, oPackage);
oList.Add(oPackage);
}
}
i_Params_Get_Package_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Package_By_Criteria");}
return oList;
}
public List<Package> Get_Package_By_Where(Params_Get_Package_By_Where i_Params_Get_Package_By_Where)
{
List<Package> oList = new List<Package>();
Package oPackage = new Package();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Package_By_Where");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Package_By_Where",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Package_By_Where));}
#region Body Section.
if ((i_Params_Get_Package_By_Where.OWNER_ID == null) || (i_Params_Get_Package_By_Where.OWNER_ID == 0)) { i_Params_Get_Package_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Package_By_Where.START_ROW == null) { i_Params_Get_Package_By_Where.START_ROW = 0; }
if ((i_Params_Get_Package_By_Where.END_ROW == null) || (i_Params_Get_Package_By_Where.END_ROW == 0)) { i_Params_Get_Package_By_Where.END_ROW = 1000000; }
List<DALC.Package> oList_DBEntries = _AppContext.Get_Package_By_Where(i_Params_Get_Package_By_Where.PACKAGE_NAME,i_Params_Get_Package_By_Where.PACKAGE_TYPE,i_Params_Get_Package_By_Where.PACKAGE_TIMELINE,i_Params_Get_Package_By_Where.OWNER_ID,i_Params_Get_Package_By_Where.START_ROW,i_Params_Get_Package_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oPackage = new Package();
oTools.CopyPropValues(oDBEntry, oPackage);
oList.Add(oPackage);
}
}
i_Params_Get_Package_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Package_By_Where");}
return oList;
}
public List<Package> Get_Package_By_Criteria_V2(Params_Get_Package_By_Criteria_V2 i_Params_Get_Package_By_Criteria_V2)
{
List<Package> oList = new List<Package>();
Package oPackage = new Package();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Package_By_Criteria_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Package_By_Criteria_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Package_By_Criteria_V2));}
#region Body Section.
if ((i_Params_Get_Package_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_Package_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_Package_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Package_By_Criteria_V2.START_ROW == null) { i_Params_Get_Package_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_Package_By_Criteria_V2.END_ROW == null) || (i_Params_Get_Package_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_Package_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.Package> oList_DBEntries = _AppContext.Get_Package_By_Criteria_V2(i_Params_Get_Package_By_Criteria_V2.PACKAGE_NAME,i_Params_Get_Package_By_Criteria_V2.PACKAGE_TYPE,i_Params_Get_Package_By_Criteria_V2.PACKAGE_ENDING_DATE,i_Params_Get_Package_By_Criteria_V2.PACKAGE_TIMELINE,i_Params_Get_Package_By_Criteria_V2.PACKAGE_STARTING_DATE,i_Params_Get_Package_By_Criteria_V2.OWNER_ID,i_Params_Get_Package_By_Criteria_V2.START_ROW,i_Params_Get_Package_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oPackage = new Package();
oTools.CopyPropValues(oDBEntry, oPackage);
oList.Add(oPackage);
}
}
i_Params_Get_Package_By_Criteria_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Package_By_Criteria_V2");}
return oList;
}
public List<Package> Get_Package_By_Where_V2(Params_Get_Package_By_Where_V2 i_Params_Get_Package_By_Where_V2)
{
List<Package> oList = new List<Package>();
Package oPackage = new Package();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Package_By_Where_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Package_By_Where_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Package_By_Where_V2));}
#region Body Section.
if ((i_Params_Get_Package_By_Where_V2.OWNER_ID == null) || (i_Params_Get_Package_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_Package_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Package_By_Where_V2.START_ROW == null) { i_Params_Get_Package_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_Package_By_Where_V2.END_ROW == null) || (i_Params_Get_Package_By_Where_V2.END_ROW == 0)) { i_Params_Get_Package_By_Where_V2.END_ROW = 1000000; }
List<DALC.Package> oList_DBEntries = _AppContext.Get_Package_By_Where_V2(i_Params_Get_Package_By_Where_V2.PACKAGE_NAME,i_Params_Get_Package_By_Where_V2.PACKAGE_TYPE,i_Params_Get_Package_By_Where_V2.PACKAGE_ENDING_DATE,i_Params_Get_Package_By_Where_V2.PACKAGE_TIMELINE,i_Params_Get_Package_By_Where_V2.PACKAGE_STARTING_DATE,i_Params_Get_Package_By_Where_V2.OWNER_ID,i_Params_Get_Package_By_Where_V2.START_ROW,i_Params_Get_Package_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oPackage = new Package();
oTools.CopyPropValues(oDBEntry, oPackage);
oList.Add(oPackage);
}
}
i_Params_Get_Package_By_Where_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Package_By_Where_V2");}
return oList;
}
public List<Person> Get_Person_By_Criteria(Params_Get_Person_By_Criteria i_Params_Get_Person_By_Criteria)
{
List<Person> oList = new List<Person>();
Person oPerson = new Person();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Person_By_Criteria");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Person_By_Criteria",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Person_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Person_By_Criteria.OWNER_ID == null) || (i_Params_Get_Person_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Person_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Person_By_Criteria.START_ROW == null) { i_Params_Get_Person_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Person_By_Criteria.END_ROW == null) || (i_Params_Get_Person_By_Criteria.END_ROW == 0)) { i_Params_Get_Person_By_Criteria.END_ROW = 1000000; }
List<DALC.Person> oList_DBEntries = _AppContext.Get_Person_By_Criteria(i_Params_Get_Person_By_Criteria.FIRST_NAME,i_Params_Get_Person_By_Criteria.LAST_NAME,i_Params_Get_Person_By_Criteria.FATHER_NAME,i_Params_Get_Person_By_Criteria.MOTHER_NAME,i_Params_Get_Person_By_Criteria.TITLE_CODE,i_Params_Get_Person_By_Criteria.GENDER_CODE,i_Params_Get_Person_By_Criteria.RELIGION_CODE,i_Params_Get_Person_By_Criteria.DESCRIPTION,i_Params_Get_Person_By_Criteria.OWNER_ID,i_Params_Get_Person_By_Criteria.START_ROW,i_Params_Get_Person_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oPerson = new Person();
oTools.CopyPropValues(oDBEntry, oPerson);
oList.Add(oPerson);
}
}
i_Params_Get_Person_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Person_By_Criteria");}
return oList;
}
public List<Person> Get_Person_By_Where(Params_Get_Person_By_Where i_Params_Get_Person_By_Where)
{
List<Person> oList = new List<Person>();
Person oPerson = new Person();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Person_By_Where");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Person_By_Where",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Person_By_Where));}
#region Body Section.
if ((i_Params_Get_Person_By_Where.OWNER_ID == null) || (i_Params_Get_Person_By_Where.OWNER_ID == 0)) { i_Params_Get_Person_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Person_By_Where.START_ROW == null) { i_Params_Get_Person_By_Where.START_ROW = 0; }
if ((i_Params_Get_Person_By_Where.END_ROW == null) || (i_Params_Get_Person_By_Where.END_ROW == 0)) { i_Params_Get_Person_By_Where.END_ROW = 1000000; }
List<DALC.Person> oList_DBEntries = _AppContext.Get_Person_By_Where(i_Params_Get_Person_By_Where.FIRST_NAME,i_Params_Get_Person_By_Where.LAST_NAME,i_Params_Get_Person_By_Where.FATHER_NAME,i_Params_Get_Person_By_Where.MOTHER_NAME,i_Params_Get_Person_By_Where.TITLE_CODE,i_Params_Get_Person_By_Where.GENDER_CODE,i_Params_Get_Person_By_Where.RELIGION_CODE,i_Params_Get_Person_By_Where.DESCRIPTION,i_Params_Get_Person_By_Where.OWNER_ID,i_Params_Get_Person_By_Where.START_ROW,i_Params_Get_Person_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oPerson = new Person();
oTools.CopyPropValues(oDBEntry, oPerson);
oList.Add(oPerson);
}
}
i_Params_Get_Person_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Person_By_Where");}
return oList;
}
public List<Person> Get_Person_By_Criteria_V2(Params_Get_Person_By_Criteria_V2 i_Params_Get_Person_By_Criteria_V2)
{
List<Person> oList = new List<Person>();
Person oPerson = new Person();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Person_By_Criteria_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Person_By_Criteria_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Person_By_Criteria_V2));}
#region Body Section.
if ((i_Params_Get_Person_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_Person_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_Person_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Person_By_Criteria_V2.START_ROW == null) { i_Params_Get_Person_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_Person_By_Criteria_V2.END_ROW == null) || (i_Params_Get_Person_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_Person_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.Person> oList_DBEntries = _AppContext.Get_Person_By_Criteria_V2(i_Params_Get_Person_By_Criteria_V2.FIRST_NAME,i_Params_Get_Person_By_Criteria_V2.LAST_NAME,i_Params_Get_Person_By_Criteria_V2.FATHER_NAME,i_Params_Get_Person_By_Criteria_V2.MOTHER_NAME,i_Params_Get_Person_By_Criteria_V2.TITLE_CODE,i_Params_Get_Person_By_Criteria_V2.GENDER_CODE,i_Params_Get_Person_By_Criteria_V2.RELIGION_CODE,i_Params_Get_Person_By_Criteria_V2.BIRTH_DATE,i_Params_Get_Person_By_Criteria_V2.DESCRIPTION,i_Params_Get_Person_By_Criteria_V2.OWNER_ID,i_Params_Get_Person_By_Criteria_V2.START_ROW,i_Params_Get_Person_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oPerson = new Person();
oTools.CopyPropValues(oDBEntry, oPerson);
oList.Add(oPerson);
}
}
i_Params_Get_Person_By_Criteria_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Person_By_Criteria_V2");}
return oList;
}
public List<Person> Get_Person_By_Where_V2(Params_Get_Person_By_Where_V2 i_Params_Get_Person_By_Where_V2)
{
List<Person> oList = new List<Person>();
Person oPerson = new Person();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Person_By_Where_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Person_By_Where_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Person_By_Where_V2));}
#region Body Section.
if ((i_Params_Get_Person_By_Where_V2.OWNER_ID == null) || (i_Params_Get_Person_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_Person_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Person_By_Where_V2.START_ROW == null) { i_Params_Get_Person_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_Person_By_Where_V2.END_ROW == null) || (i_Params_Get_Person_By_Where_V2.END_ROW == 0)) { i_Params_Get_Person_By_Where_V2.END_ROW = 1000000; }
List<DALC.Person> oList_DBEntries = _AppContext.Get_Person_By_Where_V2(i_Params_Get_Person_By_Where_V2.FIRST_NAME,i_Params_Get_Person_By_Where_V2.LAST_NAME,i_Params_Get_Person_By_Where_V2.FATHER_NAME,i_Params_Get_Person_By_Where_V2.MOTHER_NAME,i_Params_Get_Person_By_Where_V2.TITLE_CODE,i_Params_Get_Person_By_Where_V2.GENDER_CODE,i_Params_Get_Person_By_Where_V2.RELIGION_CODE,i_Params_Get_Person_By_Where_V2.BIRTH_DATE,i_Params_Get_Person_By_Where_V2.DESCRIPTION,i_Params_Get_Person_By_Where_V2.OWNER_ID,i_Params_Get_Person_By_Where_V2.START_ROW,i_Params_Get_Person_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oPerson = new Person();
oTools.CopyPropValues(oDBEntry, oPerson);
oList.Add(oPerson);
}
}
i_Params_Get_Person_By_Where_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Person_By_Where_V2");}
return oList;
}
public List<Registration> Get_Registration_By_Criteria(Params_Get_Registration_By_Criteria i_Params_Get_Registration_By_Criteria)
{
List<Registration> oList = new List<Registration>();
Registration oRegistration = new Registration();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Registration_By_Criteria");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Registration_By_Criteria",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Registration_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Registration_By_Criteria.OWNER_ID == null) || (i_Params_Get_Registration_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Registration_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Registration_By_Criteria.START_ROW == null) { i_Params_Get_Registration_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Registration_By_Criteria.END_ROW == null) || (i_Params_Get_Registration_By_Criteria.END_ROW == 0)) { i_Params_Get_Registration_By_Criteria.END_ROW = 1000000; }
List<DALC.Registration> oList_DBEntries = _AppContext.Get_Registration_By_Criteria(i_Params_Get_Registration_By_Criteria.REGISTRATION_DESCRIPTION,i_Params_Get_Registration_By_Criteria.OWNER_ID,i_Params_Get_Registration_By_Criteria.START_ROW,i_Params_Get_Registration_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oRegistration = new Registration();
oTools.CopyPropValues(oDBEntry, oRegistration);
oList.Add(oRegistration);
}
}
i_Params_Get_Registration_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Registration_By_Criteria");}
return oList;
}
public List<Registration> Get_Registration_By_Where(Params_Get_Registration_By_Where i_Params_Get_Registration_By_Where)
{
List<Registration> oList = new List<Registration>();
Registration oRegistration = new Registration();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Registration_By_Where");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Registration_By_Where",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Registration_By_Where));}
#region Body Section.
if ((i_Params_Get_Registration_By_Where.OWNER_ID == null) || (i_Params_Get_Registration_By_Where.OWNER_ID == 0)) { i_Params_Get_Registration_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Registration_By_Where.START_ROW == null) { i_Params_Get_Registration_By_Where.START_ROW = 0; }
if ((i_Params_Get_Registration_By_Where.END_ROW == null) || (i_Params_Get_Registration_By_Where.END_ROW == 0)) { i_Params_Get_Registration_By_Where.END_ROW = 1000000; }
List<DALC.Registration> oList_DBEntries = _AppContext.Get_Registration_By_Where(i_Params_Get_Registration_By_Where.REGISTRATION_DESCRIPTION,i_Params_Get_Registration_By_Where.OWNER_ID,i_Params_Get_Registration_By_Where.START_ROW,i_Params_Get_Registration_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oRegistration = new Registration();
oTools.CopyPropValues(oDBEntry, oRegistration);
oList.Add(oRegistration);
}
}
i_Params_Get_Registration_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Registration_By_Where");}
return oList;
}
public List<Registration> Get_Registration_By_Criteria_V2(Params_Get_Registration_By_Criteria_V2 i_Params_Get_Registration_By_Criteria_V2)
{
List<Registration> oList = new List<Registration>();
Registration oRegistration = new Registration();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Registration_By_Criteria_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Registration_By_Criteria_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Registration_By_Criteria_V2));}
#region Body Section.
if ((i_Params_Get_Registration_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_Registration_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_Registration_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Registration_By_Criteria_V2.START_ROW == null) { i_Params_Get_Registration_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_Registration_By_Criteria_V2.END_ROW == null) || (i_Params_Get_Registration_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_Registration_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.Registration> oList_DBEntries = _AppContext.Get_Registration_By_Criteria_V2(i_Params_Get_Registration_By_Criteria_V2.REGISTRATION_DATE,i_Params_Get_Registration_By_Criteria_V2.REGISTRATION_DESCRIPTION,i_Params_Get_Registration_By_Criteria_V2.OWNER_ID,i_Params_Get_Registration_By_Criteria_V2.START_ROW,i_Params_Get_Registration_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oRegistration = new Registration();
oTools.CopyPropValues(oDBEntry, oRegistration);
oList.Add(oRegistration);
}
}
i_Params_Get_Registration_By_Criteria_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Registration_By_Criteria_V2");}
return oList;
}
public List<Registration> Get_Registration_By_Where_V2(Params_Get_Registration_By_Where_V2 i_Params_Get_Registration_By_Where_V2)
{
List<Registration> oList = new List<Registration>();
Registration oRegistration = new Registration();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Registration_By_Where_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Registration_By_Where_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Registration_By_Where_V2));}
#region Body Section.
if ((i_Params_Get_Registration_By_Where_V2.OWNER_ID == null) || (i_Params_Get_Registration_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_Registration_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Registration_By_Where_V2.START_ROW == null) { i_Params_Get_Registration_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_Registration_By_Where_V2.END_ROW == null) || (i_Params_Get_Registration_By_Where_V2.END_ROW == 0)) { i_Params_Get_Registration_By_Where_V2.END_ROW = 1000000; }
List<DALC.Registration> oList_DBEntries = _AppContext.Get_Registration_By_Where_V2(i_Params_Get_Registration_By_Where_V2.REGISTRATION_DATE,i_Params_Get_Registration_By_Where_V2.REGISTRATION_DESCRIPTION,i_Params_Get_Registration_By_Where_V2.OWNER_ID,i_Params_Get_Registration_By_Where_V2.START_ROW,i_Params_Get_Registration_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oRegistration = new Registration();
oTools.CopyPropValues(oDBEntry, oRegistration);
oList.Add(oRegistration);
}
}
i_Params_Get_Registration_By_Where_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Registration_By_Where_V2");}
return oList;
}
public List<Session> Get_Session_By_Criteria(Params_Get_Session_By_Criteria i_Params_Get_Session_By_Criteria)
{
List<Session> oList = new List<Session>();
Session oSession = new Session();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Session_By_Criteria");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Session_By_Criteria",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Session_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Session_By_Criteria.OWNER_ID == null) || (i_Params_Get_Session_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Session_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Session_By_Criteria.START_ROW == null) { i_Params_Get_Session_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Session_By_Criteria.END_ROW == null) || (i_Params_Get_Session_By_Criteria.END_ROW == 0)) { i_Params_Get_Session_By_Criteria.END_ROW = 1000000; }
List<DALC.Session> oList_DBEntries = _AppContext.Get_Session_By_Criteria(i_Params_Get_Session_By_Criteria.DESCRIPTION,i_Params_Get_Session_By_Criteria.OWNER_ID,i_Params_Get_Session_By_Criteria.START_ROW,i_Params_Get_Session_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSession = new Session();
oTools.CopyPropValues(oDBEntry, oSession);
oList.Add(oSession);
}
}
i_Params_Get_Session_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Session_By_Criteria");}
return oList;
}
public List<Session> Get_Session_By_Where(Params_Get_Session_By_Where i_Params_Get_Session_By_Where)
{
List<Session> oList = new List<Session>();
Session oSession = new Session();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Session_By_Where");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Session_By_Where",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Session_By_Where));}
#region Body Section.
if ((i_Params_Get_Session_By_Where.OWNER_ID == null) || (i_Params_Get_Session_By_Where.OWNER_ID == 0)) { i_Params_Get_Session_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Session_By_Where.START_ROW == null) { i_Params_Get_Session_By_Where.START_ROW = 0; }
if ((i_Params_Get_Session_By_Where.END_ROW == null) || (i_Params_Get_Session_By_Where.END_ROW == 0)) { i_Params_Get_Session_By_Where.END_ROW = 1000000; }
List<DALC.Session> oList_DBEntries = _AppContext.Get_Session_By_Where(i_Params_Get_Session_By_Where.DESCRIPTION,i_Params_Get_Session_By_Where.OWNER_ID,i_Params_Get_Session_By_Where.START_ROW,i_Params_Get_Session_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSession = new Session();
oTools.CopyPropValues(oDBEntry, oSession);
oList.Add(oSession);
}
}
i_Params_Get_Session_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Session_By_Where");}
return oList;
}
public List<Session> Get_Session_By_Criteria_V2(Params_Get_Session_By_Criteria_V2 i_Params_Get_Session_By_Criteria_V2)
{
List<Session> oList = new List<Session>();
Session oSession = new Session();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Session_By_Criteria_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Session_By_Criteria_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Session_By_Criteria_V2));}
#region Body Section.
if ((i_Params_Get_Session_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_Session_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_Session_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Session_By_Criteria_V2.START_ROW == null) { i_Params_Get_Session_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_Session_By_Criteria_V2.END_ROW == null) || (i_Params_Get_Session_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_Session_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.Session> oList_DBEntries = _AppContext.Get_Session_By_Criteria_V2(i_Params_Get_Session_By_Criteria_V2.SESSION_STARTING_DATE,i_Params_Get_Session_By_Criteria_V2.SESSION_ENDING_DATE,i_Params_Get_Session_By_Criteria_V2.DESCRIPTION,i_Params_Get_Session_By_Criteria_V2.OWNER_ID,i_Params_Get_Session_By_Criteria_V2.START_ROW,i_Params_Get_Session_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSession = new Session();
oTools.CopyPropValues(oDBEntry, oSession);
oList.Add(oSession);
}
}
i_Params_Get_Session_By_Criteria_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Session_By_Criteria_V2");}
return oList;
}
public List<Session> Get_Session_By_Where_V2(Params_Get_Session_By_Where_V2 i_Params_Get_Session_By_Where_V2)
{
List<Session> oList = new List<Session>();
Session oSession = new Session();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Session_By_Where_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Session_By_Where_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Session_By_Where_V2));}
#region Body Section.
if ((i_Params_Get_Session_By_Where_V2.OWNER_ID == null) || (i_Params_Get_Session_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_Session_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Session_By_Where_V2.START_ROW == null) { i_Params_Get_Session_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_Session_By_Where_V2.END_ROW == null) || (i_Params_Get_Session_By_Where_V2.END_ROW == 0)) { i_Params_Get_Session_By_Where_V2.END_ROW = 1000000; }
List<DALC.Session> oList_DBEntries = _AppContext.Get_Session_By_Where_V2(i_Params_Get_Session_By_Where_V2.SESSION_STARTING_DATE,i_Params_Get_Session_By_Where_V2.SESSION_ENDING_DATE,i_Params_Get_Session_By_Where_V2.DESCRIPTION,i_Params_Get_Session_By_Where_V2.OWNER_ID,i_Params_Get_Session_By_Where_V2.START_ROW,i_Params_Get_Session_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSession = new Session();
oTools.CopyPropValues(oDBEntry, oSession);
oList.Add(oSession);
}
}
i_Params_Get_Session_By_Where_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Session_By_Where_V2");}
return oList;
}
public List<Staff> Get_Staff_By_Criteria(Params_Get_Staff_By_Criteria i_Params_Get_Staff_By_Criteria)
{
List<Staff> oList = new List<Staff>();
Staff oStaff = new Staff();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_By_Criteria");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_By_Criteria",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Staff_By_Criteria.OWNER_ID == null) || (i_Params_Get_Staff_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Staff_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Staff_By_Criteria.START_ROW == null) { i_Params_Get_Staff_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Staff_By_Criteria.END_ROW == null) || (i_Params_Get_Staff_By_Criteria.END_ROW == 0)) { i_Params_Get_Staff_By_Criteria.END_ROW = 1000000; }
List<DALC.Staff> oList_DBEntries = _AppContext.Get_Staff_By_Criteria(i_Params_Get_Staff_By_Criteria.STAFF_NAME,i_Params_Get_Staff_By_Criteria.STAFF_PH_NB,i_Params_Get_Staff_By_Criteria.STAFF_MAIL,i_Params_Get_Staff_By_Criteria.STAFF_GENDER,i_Params_Get_Staff_By_Criteria.OWNER_ID,i_Params_Get_Staff_By_Criteria.START_ROW,i_Params_Get_Staff_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStaff = new Staff();
oTools.CopyPropValues(oDBEntry, oStaff);
oList.Add(oStaff);
}
}
i_Params_Get_Staff_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_By_Criteria");}
return oList;
}
public List<Staff> Get_Staff_By_Where(Params_Get_Staff_By_Where i_Params_Get_Staff_By_Where)
{
List<Staff> oList = new List<Staff>();
Staff oStaff = new Staff();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_By_Where");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_By_Where",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_By_Where));}
#region Body Section.
if ((i_Params_Get_Staff_By_Where.OWNER_ID == null) || (i_Params_Get_Staff_By_Where.OWNER_ID == 0)) { i_Params_Get_Staff_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Staff_By_Where.START_ROW == null) { i_Params_Get_Staff_By_Where.START_ROW = 0; }
if ((i_Params_Get_Staff_By_Where.END_ROW == null) || (i_Params_Get_Staff_By_Where.END_ROW == 0)) { i_Params_Get_Staff_By_Where.END_ROW = 1000000; }
List<DALC.Staff> oList_DBEntries = _AppContext.Get_Staff_By_Where(i_Params_Get_Staff_By_Where.STAFF_NAME,i_Params_Get_Staff_By_Where.STAFF_PH_NB,i_Params_Get_Staff_By_Where.STAFF_MAIL,i_Params_Get_Staff_By_Where.STAFF_GENDER,i_Params_Get_Staff_By_Where.OWNER_ID,i_Params_Get_Staff_By_Where.START_ROW,i_Params_Get_Staff_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStaff = new Staff();
oTools.CopyPropValues(oDBEntry, oStaff);
oList.Add(oStaff);
}
}
i_Params_Get_Staff_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_By_Where");}
return oList;
}
public List<Staff> Get_Staff_By_Criteria_V2(Params_Get_Staff_By_Criteria_V2 i_Params_Get_Staff_By_Criteria_V2)
{
List<Staff> oList = new List<Staff>();
Staff oStaff = new Staff();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_By_Criteria_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_By_Criteria_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_By_Criteria_V2));}
#region Body Section.
if ((i_Params_Get_Staff_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_Staff_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_Staff_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Staff_By_Criteria_V2.START_ROW == null) { i_Params_Get_Staff_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_Staff_By_Criteria_V2.END_ROW == null) || (i_Params_Get_Staff_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_Staff_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.Staff> oList_DBEntries = _AppContext.Get_Staff_By_Criteria_V2(i_Params_Get_Staff_By_Criteria_V2.STAFF_NAME,i_Params_Get_Staff_By_Criteria_V2.STAFF_PH_NB,i_Params_Get_Staff_By_Criteria_V2.STAFF_MAIL,i_Params_Get_Staff_By_Criteria_V2.STAFF_DOB,i_Params_Get_Staff_By_Criteria_V2.STAFF_GENDER,i_Params_Get_Staff_By_Criteria_V2.OWNER_ID,i_Params_Get_Staff_By_Criteria_V2.START_ROW,i_Params_Get_Staff_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStaff = new Staff();
oTools.CopyPropValues(oDBEntry, oStaff);
oList.Add(oStaff);
}
}
i_Params_Get_Staff_By_Criteria_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_By_Criteria_V2");}
return oList;
}
public List<Staff> Get_Staff_By_Where_V2(Params_Get_Staff_By_Where_V2 i_Params_Get_Staff_By_Where_V2)
{
List<Staff> oList = new List<Staff>();
Staff oStaff = new Staff();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_By_Where_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_By_Where_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_By_Where_V2));}
#region Body Section.
if ((i_Params_Get_Staff_By_Where_V2.OWNER_ID == null) || (i_Params_Get_Staff_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_Staff_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Staff_By_Where_V2.START_ROW == null) { i_Params_Get_Staff_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_Staff_By_Where_V2.END_ROW == null) || (i_Params_Get_Staff_By_Where_V2.END_ROW == 0)) { i_Params_Get_Staff_By_Where_V2.END_ROW = 1000000; }
List<DALC.Staff> oList_DBEntries = _AppContext.Get_Staff_By_Where_V2(i_Params_Get_Staff_By_Where_V2.STAFF_NAME,i_Params_Get_Staff_By_Where_V2.STAFF_PH_NB,i_Params_Get_Staff_By_Where_V2.STAFF_MAIL,i_Params_Get_Staff_By_Where_V2.STAFF_DOB,i_Params_Get_Staff_By_Where_V2.STAFF_GENDER,i_Params_Get_Staff_By_Where_V2.OWNER_ID,i_Params_Get_Staff_By_Where_V2.START_ROW,i_Params_Get_Staff_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStaff = new Staff();
oTools.CopyPropValues(oDBEntry, oStaff);
oList.Add(oStaff);
}
}
i_Params_Get_Staff_By_Where_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_By_Where_V2");}
return oList;
}
public List<Staff_fees> Get_Staff_fees_By_Criteria(Params_Get_Staff_fees_By_Criteria i_Params_Get_Staff_fees_By_Criteria)
{
List<Staff_fees> oList = new List<Staff_fees>();
Staff_fees oStaff_fees = new Staff_fees();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_fees_By_Criteria");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_fees_By_Criteria",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_fees_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Staff_fees_By_Criteria.OWNER_ID == null) || (i_Params_Get_Staff_fees_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Staff_fees_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Staff_fees_By_Criteria.START_ROW == null) { i_Params_Get_Staff_fees_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Staff_fees_By_Criteria.END_ROW == null) || (i_Params_Get_Staff_fees_By_Criteria.END_ROW == 0)) { i_Params_Get_Staff_fees_By_Criteria.END_ROW = 1000000; }
List<DALC.Staff_fees> oList_DBEntries = _AppContext.Get_Staff_fees_By_Criteria(i_Params_Get_Staff_fees_By_Criteria.STAFF_FEES_DESCRIPTION,i_Params_Get_Staff_fees_By_Criteria.OWNER_ID,i_Params_Get_Staff_fees_By_Criteria.START_ROW,i_Params_Get_Staff_fees_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStaff_fees = new Staff_fees();
oTools.CopyPropValues(oDBEntry, oStaff_fees);
oList.Add(oStaff_fees);
}
}
i_Params_Get_Staff_fees_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_fees_By_Criteria");}
return oList;
}
public List<Staff_fees> Get_Staff_fees_By_Where(Params_Get_Staff_fees_By_Where i_Params_Get_Staff_fees_By_Where)
{
List<Staff_fees> oList = new List<Staff_fees>();
Staff_fees oStaff_fees = new Staff_fees();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_fees_By_Where");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_fees_By_Where",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_fees_By_Where));}
#region Body Section.
if ((i_Params_Get_Staff_fees_By_Where.OWNER_ID == null) || (i_Params_Get_Staff_fees_By_Where.OWNER_ID == 0)) { i_Params_Get_Staff_fees_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Staff_fees_By_Where.START_ROW == null) { i_Params_Get_Staff_fees_By_Where.START_ROW = 0; }
if ((i_Params_Get_Staff_fees_By_Where.END_ROW == null) || (i_Params_Get_Staff_fees_By_Where.END_ROW == 0)) { i_Params_Get_Staff_fees_By_Where.END_ROW = 1000000; }
List<DALC.Staff_fees> oList_DBEntries = _AppContext.Get_Staff_fees_By_Where(i_Params_Get_Staff_fees_By_Where.STAFF_FEES_DESCRIPTION,i_Params_Get_Staff_fees_By_Where.OWNER_ID,i_Params_Get_Staff_fees_By_Where.START_ROW,i_Params_Get_Staff_fees_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStaff_fees = new Staff_fees();
oTools.CopyPropValues(oDBEntry, oStaff_fees);
oList.Add(oStaff_fees);
}
}
i_Params_Get_Staff_fees_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_fees_By_Where");}
return oList;
}
public List<Supplier> Get_Supplier_By_Criteria(Params_Get_Supplier_By_Criteria i_Params_Get_Supplier_By_Criteria)
{
List<Supplier> oList = new List<Supplier>();
Supplier oSupplier = new Supplier();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_By_Criteria");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_By_Criteria",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Supplier_By_Criteria.OWNER_ID == null) || (i_Params_Get_Supplier_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Supplier_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Supplier_By_Criteria.START_ROW == null) { i_Params_Get_Supplier_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Supplier_By_Criteria.END_ROW == null) || (i_Params_Get_Supplier_By_Criteria.END_ROW == 0)) { i_Params_Get_Supplier_By_Criteria.END_ROW = 1000000; }
List<DALC.Supplier> oList_DBEntries = _AppContext.Get_Supplier_By_Criteria(i_Params_Get_Supplier_By_Criteria.SUPPLIER_NAME,i_Params_Get_Supplier_By_Criteria.SUPPLIER_PH_NB,i_Params_Get_Supplier_By_Criteria.SUPPLIER_MAIL,i_Params_Get_Supplier_By_Criteria.SUPPLIER_GENDER,i_Params_Get_Supplier_By_Criteria.OWNER_ID,i_Params_Get_Supplier_By_Criteria.START_ROW,i_Params_Get_Supplier_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier = new Supplier();
oTools.CopyPropValues(oDBEntry, oSupplier);
oList.Add(oSupplier);
}
}
i_Params_Get_Supplier_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_By_Criteria");}
return oList;
}
public List<Supplier> Get_Supplier_By_Where(Params_Get_Supplier_By_Where i_Params_Get_Supplier_By_Where)
{
List<Supplier> oList = new List<Supplier>();
Supplier oSupplier = new Supplier();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_By_Where");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_By_Where",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_By_Where));}
#region Body Section.
if ((i_Params_Get_Supplier_By_Where.OWNER_ID == null) || (i_Params_Get_Supplier_By_Where.OWNER_ID == 0)) { i_Params_Get_Supplier_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Supplier_By_Where.START_ROW == null) { i_Params_Get_Supplier_By_Where.START_ROW = 0; }
if ((i_Params_Get_Supplier_By_Where.END_ROW == null) || (i_Params_Get_Supplier_By_Where.END_ROW == 0)) { i_Params_Get_Supplier_By_Where.END_ROW = 1000000; }
List<DALC.Supplier> oList_DBEntries = _AppContext.Get_Supplier_By_Where(i_Params_Get_Supplier_By_Where.SUPPLIER_NAME,i_Params_Get_Supplier_By_Where.SUPPLIER_PH_NB,i_Params_Get_Supplier_By_Where.SUPPLIER_MAIL,i_Params_Get_Supplier_By_Where.SUPPLIER_GENDER,i_Params_Get_Supplier_By_Where.OWNER_ID,i_Params_Get_Supplier_By_Where.START_ROW,i_Params_Get_Supplier_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier = new Supplier();
oTools.CopyPropValues(oDBEntry, oSupplier);
oList.Add(oSupplier);
}
}
i_Params_Get_Supplier_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_By_Where");}
return oList;
}
public List<Supplier> Get_Supplier_By_Criteria_V2(Params_Get_Supplier_By_Criteria_V2 i_Params_Get_Supplier_By_Criteria_V2)
{
List<Supplier> oList = new List<Supplier>();
Supplier oSupplier = new Supplier();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_By_Criteria_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_By_Criteria_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_By_Criteria_V2));}
#region Body Section.
if ((i_Params_Get_Supplier_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_Supplier_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_Supplier_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Supplier_By_Criteria_V2.START_ROW == null) { i_Params_Get_Supplier_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_Supplier_By_Criteria_V2.END_ROW == null) || (i_Params_Get_Supplier_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_Supplier_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.Supplier> oList_DBEntries = _AppContext.Get_Supplier_By_Criteria_V2(i_Params_Get_Supplier_By_Criteria_V2.SUPPLIER_NAME,i_Params_Get_Supplier_By_Criteria_V2.SUPPLIER_PH_NB,i_Params_Get_Supplier_By_Criteria_V2.SUPPLIER_MAIL,i_Params_Get_Supplier_By_Criteria_V2.SUPPLIER_DOB,i_Params_Get_Supplier_By_Criteria_V2.SUPPLIER_GENDER,i_Params_Get_Supplier_By_Criteria_V2.OWNER_ID,i_Params_Get_Supplier_By_Criteria_V2.START_ROW,i_Params_Get_Supplier_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier = new Supplier();
oTools.CopyPropValues(oDBEntry, oSupplier);
oList.Add(oSupplier);
}
}
i_Params_Get_Supplier_By_Criteria_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_By_Criteria_V2");}
return oList;
}
public List<Supplier> Get_Supplier_By_Where_V2(Params_Get_Supplier_By_Where_V2 i_Params_Get_Supplier_By_Where_V2)
{
List<Supplier> oList = new List<Supplier>();
Supplier oSupplier = new Supplier();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_By_Where_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_By_Where_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_By_Where_V2));}
#region Body Section.
if ((i_Params_Get_Supplier_By_Where_V2.OWNER_ID == null) || (i_Params_Get_Supplier_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_Supplier_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Supplier_By_Where_V2.START_ROW == null) { i_Params_Get_Supplier_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_Supplier_By_Where_V2.END_ROW == null) || (i_Params_Get_Supplier_By_Where_V2.END_ROW == 0)) { i_Params_Get_Supplier_By_Where_V2.END_ROW = 1000000; }
List<DALC.Supplier> oList_DBEntries = _AppContext.Get_Supplier_By_Where_V2(i_Params_Get_Supplier_By_Where_V2.SUPPLIER_NAME,i_Params_Get_Supplier_By_Where_V2.SUPPLIER_PH_NB,i_Params_Get_Supplier_By_Where_V2.SUPPLIER_MAIL,i_Params_Get_Supplier_By_Where_V2.SUPPLIER_DOB,i_Params_Get_Supplier_By_Where_V2.SUPPLIER_GENDER,i_Params_Get_Supplier_By_Where_V2.OWNER_ID,i_Params_Get_Supplier_By_Where_V2.START_ROW,i_Params_Get_Supplier_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier = new Supplier();
oTools.CopyPropValues(oDBEntry, oSupplier);
oList.Add(oSupplier);
}
}
i_Params_Get_Supplier_By_Where_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_By_Where_V2");}
return oList;
}
public List<Supplier_fees> Get_Supplier_fees_By_Criteria(Params_Get_Supplier_fees_By_Criteria i_Params_Get_Supplier_fees_By_Criteria)
{
List<Supplier_fees> oList = new List<Supplier_fees>();
Supplier_fees oSupplier_fees = new Supplier_fees();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_fees_By_Criteria");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_fees_By_Criteria",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_fees_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Supplier_fees_By_Criteria.OWNER_ID == null) || (i_Params_Get_Supplier_fees_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Supplier_fees_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Supplier_fees_By_Criteria.START_ROW == null) { i_Params_Get_Supplier_fees_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Supplier_fees_By_Criteria.END_ROW == null) || (i_Params_Get_Supplier_fees_By_Criteria.END_ROW == 0)) { i_Params_Get_Supplier_fees_By_Criteria.END_ROW = 1000000; }
List<DALC.Supplier_fees> oList_DBEntries = _AppContext.Get_Supplier_fees_By_Criteria(i_Params_Get_Supplier_fees_By_Criteria.SUPPLIER_FEES_DESCRIPTION,i_Params_Get_Supplier_fees_By_Criteria.OWNER_ID,i_Params_Get_Supplier_fees_By_Criteria.START_ROW,i_Params_Get_Supplier_fees_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier_fees = new Supplier_fees();
oTools.CopyPropValues(oDBEntry, oSupplier_fees);
oList.Add(oSupplier_fees);
}
}
i_Params_Get_Supplier_fees_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_fees_By_Criteria");}
return oList;
}
public List<Supplier_fees> Get_Supplier_fees_By_Where(Params_Get_Supplier_fees_By_Where i_Params_Get_Supplier_fees_By_Where)
{
List<Supplier_fees> oList = new List<Supplier_fees>();
Supplier_fees oSupplier_fees = new Supplier_fees();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_fees_By_Where");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_fees_By_Where",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_fees_By_Where));}
#region Body Section.
if ((i_Params_Get_Supplier_fees_By_Where.OWNER_ID == null) || (i_Params_Get_Supplier_fees_By_Where.OWNER_ID == 0)) { i_Params_Get_Supplier_fees_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Supplier_fees_By_Where.START_ROW == null) { i_Params_Get_Supplier_fees_By_Where.START_ROW = 0; }
if ((i_Params_Get_Supplier_fees_By_Where.END_ROW == null) || (i_Params_Get_Supplier_fees_By_Where.END_ROW == 0)) { i_Params_Get_Supplier_fees_By_Where.END_ROW = 1000000; }
List<DALC.Supplier_fees> oList_DBEntries = _AppContext.Get_Supplier_fees_By_Where(i_Params_Get_Supplier_fees_By_Where.SUPPLIER_FEES_DESCRIPTION,i_Params_Get_Supplier_fees_By_Where.OWNER_ID,i_Params_Get_Supplier_fees_By_Where.START_ROW,i_Params_Get_Supplier_fees_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier_fees = new Supplier_fees();
oTools.CopyPropValues(oDBEntry, oSupplier_fees);
oList.Add(oSupplier_fees);
}
}
i_Params_Get_Supplier_fees_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_fees_By_Where");}
return oList;
}
public List<User> Get_User_By_Criteria(Params_Get_User_By_Criteria i_Params_Get_User_By_Criteria)
{
List<User> oList = new List<User>();
User oUser = new User();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_Criteria");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_User_By_Criteria",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_User_By_Criteria));}
#region Body Section.
if ((i_Params_Get_User_By_Criteria.OWNER_ID == null) || (i_Params_Get_User_By_Criteria.OWNER_ID == 0)) { i_Params_Get_User_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_User_By_Criteria.START_ROW == null) { i_Params_Get_User_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_User_By_Criteria.END_ROW == null) || (i_Params_Get_User_By_Criteria.END_ROW == 0)) { i_Params_Get_User_By_Criteria.END_ROW = 1000000; }
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_Criteria(i_Params_Get_User_By_Criteria.USERNAME,i_Params_Get_User_By_Criteria.PASSWORD,i_Params_Get_User_By_Criteria.USER_TYPE_CODE,i_Params_Get_User_By_Criteria.USER_EMAIL,i_Params_Get_User_By_Criteria.OWNER_ID,i_Params_Get_User_By_Criteria.START_ROW,i_Params_Get_User_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
oList.Add(oUser);
}
}
i_Params_Get_User_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_Criteria");}
return oList;
}
public List<User> Get_User_By_Where(Params_Get_User_By_Where i_Params_Get_User_By_Where)
{
List<User> oList = new List<User>();
User oUser = new User();
long? tmp_TOTAL_COUNT = 0;
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_Where");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_User_By_Where",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_User_By_Where));}
#region Body Section.
if ((i_Params_Get_User_By_Where.OWNER_ID == null) || (i_Params_Get_User_By_Where.OWNER_ID == 0)) { i_Params_Get_User_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_User_By_Where.START_ROW == null) { i_Params_Get_User_By_Where.START_ROW = 0; }
if ((i_Params_Get_User_By_Where.END_ROW == null) || (i_Params_Get_User_By_Where.END_ROW == 0)) { i_Params_Get_User_By_Where.END_ROW = 1000000; }
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_Where(i_Params_Get_User_By_Where.USERNAME,i_Params_Get_User_By_Where.PASSWORD,i_Params_Get_User_By_Where.USER_TYPE_CODE,i_Params_Get_User_By_Where.USER_EMAIL,i_Params_Get_User_By_Where.OWNER_ID,i_Params_Get_User_By_Where.START_ROW,i_Params_Get_User_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
oList.Add(oUser);
}
}
i_Params_Get_User_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_Where");}
return oList;
}
public List<Address> Get_Address_By_Criteria_InList(Params_Get_Address_By_Criteria_InList i_Params_Get_Address_By_Criteria_InList)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Address_By_Criteria_InList_SP oParams_Get_Address_By_Criteria_InList_SP = new Params_Get_Address_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Criteria_InList");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_Criteria_InList",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_Criteria_InList));}
#region Body Section.
if ((i_Params_Get_Address_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Address_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Address_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Address_By_Criteria_InList.START_ROW == null) { i_Params_Get_Address_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Address_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Address_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Address_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Address_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Address_By_Criteria_InList.OWNER_ID;
oParams_Get_Address_By_Criteria_InList_SP.ADDRESS_TYPE_CODE = i_Params_Get_Address_By_Criteria_InList.ADDRESS_TYPE_CODE;
oParams_Get_Address_By_Criteria_InList_SP.STREET = i_Params_Get_Address_By_Criteria_InList.STREET;
oParams_Get_Address_By_Criteria_InList_SP.BUILDING = i_Params_Get_Address_By_Criteria_InList.BUILDING;
oParams_Get_Address_By_Criteria_InList_SP.FLOOR = i_Params_Get_Address_By_Criteria_InList.FLOOR;
oParams_Get_Address_By_Criteria_InList_SP.POBOX = i_Params_Get_Address_By_Criteria_InList.POBOX;
if ( i_Params_Get_Address_By_Criteria_InList.PERSON_ID_LIST == null)
{
i_Params_Get_Address_By_Criteria_InList.PERSON_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Criteria_InList_SP.PERSON_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Criteria_InList.PERSON_ID_LIST);
if ( i_Params_Get_Address_By_Criteria_InList.LOC_L1_ID_LIST == null)
{
i_Params_Get_Address_By_Criteria_InList.LOC_L1_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Criteria_InList_SP.LOC_L1_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Criteria_InList.LOC_L1_ID_LIST);
if ( i_Params_Get_Address_By_Criteria_InList.LOC_L2_ID_LIST == null)
{
i_Params_Get_Address_By_Criteria_InList.LOC_L2_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Criteria_InList_SP.LOC_L2_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Criteria_InList.LOC_L2_ID_LIST);
if ( i_Params_Get_Address_By_Criteria_InList.LOC_L3_ID_LIST == null)
{
i_Params_Get_Address_By_Criteria_InList.LOC_L3_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Criteria_InList_SP.LOC_L3_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Criteria_InList.LOC_L3_ID_LIST);
if ( i_Params_Get_Address_By_Criteria_InList.LOC_L4_ID_LIST == null)
{
i_Params_Get_Address_By_Criteria_InList.LOC_L4_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Criteria_InList_SP.LOC_L4_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Criteria_InList.LOC_L4_ID_LIST);
oParams_Get_Address_By_Criteria_InList_SP.START_ROW = i_Params_Get_Address_By_Criteria_InList.START_ROW;
oParams_Get_Address_By_Criteria_InList_SP.END_ROW = i_Params_Get_Address_By_Criteria_InList.END_ROW;
oParams_Get_Address_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Address_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Criteria_InList(i_Params_Get_Address_By_Criteria_InList.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Criteria_InList.STREET,i_Params_Get_Address_By_Criteria_InList.BUILDING,i_Params_Get_Address_By_Criteria_InList.FLOOR,i_Params_Get_Address_By_Criteria_InList.POBOX,i_Params_Get_Address_By_Criteria_InList.PERSON_ID_LIST,i_Params_Get_Address_By_Criteria_InList.LOC_L1_ID_LIST,i_Params_Get_Address_By_Criteria_InList.LOC_L2_ID_LIST,i_Params_Get_Address_By_Criteria_InList.LOC_L3_ID_LIST,i_Params_Get_Address_By_Criteria_InList.LOC_L4_ID_LIST,i_Params_Get_Address_By_Criteria_InList.OWNER_ID,i_Params_Get_Address_By_Criteria_InList.START_ROW,i_Params_Get_Address_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Address_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Address_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Criteria_InList");}
return oList;
}
public List<Address> Get_Address_By_Where_InList(Params_Get_Address_By_Where_InList i_Params_Get_Address_By_Where_InList)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Address_By_Where_InList_SP oParams_Get_Address_By_Where_InList_SP = new Params_Get_Address_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Where_InList");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_Where_InList",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_Where_InList));}
#region Body Section.
if ((i_Params_Get_Address_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Address_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Address_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Address_By_Where_InList.START_ROW == null) { i_Params_Get_Address_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Address_By_Where_InList.END_ROW == null) || (i_Params_Get_Address_By_Where_InList.END_ROW == 0)) { i_Params_Get_Address_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Address_By_Where_InList_SP.OWNER_ID = i_Params_Get_Address_By_Where_InList.OWNER_ID;
oParams_Get_Address_By_Where_InList_SP.ADDRESS_TYPE_CODE = i_Params_Get_Address_By_Where_InList.ADDRESS_TYPE_CODE;
oParams_Get_Address_By_Where_InList_SP.STREET = i_Params_Get_Address_By_Where_InList.STREET;
oParams_Get_Address_By_Where_InList_SP.BUILDING = i_Params_Get_Address_By_Where_InList.BUILDING;
oParams_Get_Address_By_Where_InList_SP.FLOOR = i_Params_Get_Address_By_Where_InList.FLOOR;
oParams_Get_Address_By_Where_InList_SP.POBOX = i_Params_Get_Address_By_Where_InList.POBOX;
if ( i_Params_Get_Address_By_Where_InList.PERSON_ID_LIST == null)
{
i_Params_Get_Address_By_Where_InList.PERSON_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Where_InList_SP.PERSON_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Where_InList.PERSON_ID_LIST);
if ( i_Params_Get_Address_By_Where_InList.LOC_L1_ID_LIST == null)
{
i_Params_Get_Address_By_Where_InList.LOC_L1_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Where_InList_SP.LOC_L1_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Where_InList.LOC_L1_ID_LIST);
if ( i_Params_Get_Address_By_Where_InList.LOC_L2_ID_LIST == null)
{
i_Params_Get_Address_By_Where_InList.LOC_L2_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Where_InList_SP.LOC_L2_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Where_InList.LOC_L2_ID_LIST);
if ( i_Params_Get_Address_By_Where_InList.LOC_L3_ID_LIST == null)
{
i_Params_Get_Address_By_Where_InList.LOC_L3_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Where_InList_SP.LOC_L3_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Where_InList.LOC_L3_ID_LIST);
if ( i_Params_Get_Address_By_Where_InList.LOC_L4_ID_LIST == null)
{
i_Params_Get_Address_By_Where_InList.LOC_L4_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Where_InList_SP.LOC_L4_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Where_InList.LOC_L4_ID_LIST);
oParams_Get_Address_By_Where_InList_SP.START_ROW = i_Params_Get_Address_By_Where_InList.START_ROW;
oParams_Get_Address_By_Where_InList_SP.END_ROW = i_Params_Get_Address_By_Where_InList.END_ROW;
oParams_Get_Address_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Address_By_Where_InList.TOTAL_COUNT;
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Where_InList(i_Params_Get_Address_By_Where_InList.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Where_InList.STREET,i_Params_Get_Address_By_Where_InList.BUILDING,i_Params_Get_Address_By_Where_InList.FLOOR,i_Params_Get_Address_By_Where_InList.POBOX,i_Params_Get_Address_By_Where_InList.PERSON_ID_LIST,i_Params_Get_Address_By_Where_InList.LOC_L1_ID_LIST,i_Params_Get_Address_By_Where_InList.LOC_L2_ID_LIST,i_Params_Get_Address_By_Where_InList.LOC_L3_ID_LIST,i_Params_Get_Address_By_Where_InList.LOC_L4_ID_LIST,i_Params_Get_Address_By_Where_InList.OWNER_ID,i_Params_Get_Address_By_Where_InList.START_ROW,i_Params_Get_Address_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Where_InList.TOTAL_COUNT = oParams_Get_Address_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Address_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Where_InList");}
return oList;
}
public List<Address> Get_Address_By_Criteria_InList_V2(Params_Get_Address_By_Criteria_InList_V2 i_Params_Get_Address_By_Criteria_InList_V2)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Address_By_Criteria_InList_SP_V2 oParams_Get_Address_By_Criteria_InList_SP_V2 = new Params_Get_Address_By_Criteria_InList_SP_V2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Criteria_InList_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_Criteria_InList_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_Criteria_InList_V2));}
#region Body Section.
if ((i_Params_Get_Address_By_Criteria_InList_V2.OWNER_ID == null) || (i_Params_Get_Address_By_Criteria_InList_V2.OWNER_ID == 0)) { i_Params_Get_Address_By_Criteria_InList_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Address_By_Criteria_InList_V2.START_ROW == null) { i_Params_Get_Address_By_Criteria_InList_V2.START_ROW = 0; }
if ((i_Params_Get_Address_By_Criteria_InList_V2.END_ROW == null) || (i_Params_Get_Address_By_Criteria_InList_V2.END_ROW == 0)) { i_Params_Get_Address_By_Criteria_InList_V2.END_ROW = 1000000; }
oParams_Get_Address_By_Criteria_InList_SP_V2.OWNER_ID = i_Params_Get_Address_By_Criteria_InList_V2.OWNER_ID;
oParams_Get_Address_By_Criteria_InList_SP_V2.ADDRESS_TYPE_CODE = i_Params_Get_Address_By_Criteria_InList_V2.ADDRESS_TYPE_CODE;
oParams_Get_Address_By_Criteria_InList_SP_V2.STREET = i_Params_Get_Address_By_Criteria_InList_V2.STREET;
oParams_Get_Address_By_Criteria_InList_SP_V2.BUILDING = i_Params_Get_Address_By_Criteria_InList_V2.BUILDING;
oParams_Get_Address_By_Criteria_InList_SP_V2.FLOOR = i_Params_Get_Address_By_Criteria_InList_V2.FLOOR;
oParams_Get_Address_By_Criteria_InList_SP_V2.POBOX = i_Params_Get_Address_By_Criteria_InList_V2.POBOX;
oParams_Get_Address_By_Criteria_InList_SP_V2.VALID_DATE_START = i_Params_Get_Address_By_Criteria_InList_V2.VALID_DATE_START;
oParams_Get_Address_By_Criteria_InList_SP_V2.VALID_DATE_END = i_Params_Get_Address_By_Criteria_InList_V2.VALID_DATE_END;
if ( i_Params_Get_Address_By_Criteria_InList_V2.PERSON_ID_LIST == null)
{
i_Params_Get_Address_By_Criteria_InList_V2.PERSON_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Criteria_InList_SP_V2.PERSON_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Criteria_InList_V2.PERSON_ID_LIST);
if ( i_Params_Get_Address_By_Criteria_InList_V2.LOC_L1_ID_LIST == null)
{
i_Params_Get_Address_By_Criteria_InList_V2.LOC_L1_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Criteria_InList_SP_V2.LOC_L1_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Criteria_InList_V2.LOC_L1_ID_LIST);
if ( i_Params_Get_Address_By_Criteria_InList_V2.LOC_L2_ID_LIST == null)
{
i_Params_Get_Address_By_Criteria_InList_V2.LOC_L2_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Criteria_InList_SP_V2.LOC_L2_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Criteria_InList_V2.LOC_L2_ID_LIST);
if ( i_Params_Get_Address_By_Criteria_InList_V2.LOC_L3_ID_LIST == null)
{
i_Params_Get_Address_By_Criteria_InList_V2.LOC_L3_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Criteria_InList_SP_V2.LOC_L3_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Criteria_InList_V2.LOC_L3_ID_LIST);
if ( i_Params_Get_Address_By_Criteria_InList_V2.LOC_L4_ID_LIST == null)
{
i_Params_Get_Address_By_Criteria_InList_V2.LOC_L4_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Criteria_InList_SP_V2.LOC_L4_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Criteria_InList_V2.LOC_L4_ID_LIST);
oParams_Get_Address_By_Criteria_InList_SP_V2.START_ROW = i_Params_Get_Address_By_Criteria_InList_V2.START_ROW;
oParams_Get_Address_By_Criteria_InList_SP_V2.END_ROW = i_Params_Get_Address_By_Criteria_InList_V2.END_ROW;
oParams_Get_Address_By_Criteria_InList_SP_V2.TOTAL_COUNT = i_Params_Get_Address_By_Criteria_InList_V2.TOTAL_COUNT;
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Criteria_InList_V2(i_Params_Get_Address_By_Criteria_InList_V2.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Criteria_InList_V2.STREET,i_Params_Get_Address_By_Criteria_InList_V2.BUILDING,i_Params_Get_Address_By_Criteria_InList_V2.FLOOR,i_Params_Get_Address_By_Criteria_InList_V2.POBOX,i_Params_Get_Address_By_Criteria_InList_V2.VALID_DATE_START,i_Params_Get_Address_By_Criteria_InList_V2.VALID_DATE_END,i_Params_Get_Address_By_Criteria_InList_V2.PERSON_ID_LIST,i_Params_Get_Address_By_Criteria_InList_V2.LOC_L1_ID_LIST,i_Params_Get_Address_By_Criteria_InList_V2.LOC_L2_ID_LIST,i_Params_Get_Address_By_Criteria_InList_V2.LOC_L3_ID_LIST,i_Params_Get_Address_By_Criteria_InList_V2.LOC_L4_ID_LIST,i_Params_Get_Address_By_Criteria_InList_V2.OWNER_ID,i_Params_Get_Address_By_Criteria_InList_V2.START_ROW,i_Params_Get_Address_By_Criteria_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Criteria_InList_V2.TOTAL_COUNT = oParams_Get_Address_By_Criteria_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Address_By_Criteria_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Criteria_InList_V2");}
return oList;
}
public List<Address> Get_Address_By_Where_InList_V2(Params_Get_Address_By_Where_InList_V2 i_Params_Get_Address_By_Where_InList_V2)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Address_By_Where_InList_SP_V2 oParams_Get_Address_By_Where_InList_SP_V2 = new Params_Get_Address_By_Where_InList_SP_V2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Where_InList_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_Where_InList_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_Where_InList_V2));}
#region Body Section.
if ((i_Params_Get_Address_By_Where_InList_V2.OWNER_ID == null) || (i_Params_Get_Address_By_Where_InList_V2.OWNER_ID == 0)) { i_Params_Get_Address_By_Where_InList_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Address_By_Where_InList_V2.START_ROW == null) { i_Params_Get_Address_By_Where_InList_V2.START_ROW = 0; }
if ((i_Params_Get_Address_By_Where_InList_V2.END_ROW == null) || (i_Params_Get_Address_By_Where_InList_V2.END_ROW == 0)) { i_Params_Get_Address_By_Where_InList_V2.END_ROW = 1000000; }
oParams_Get_Address_By_Where_InList_SP_V2.OWNER_ID = i_Params_Get_Address_By_Where_InList_V2.OWNER_ID;
oParams_Get_Address_By_Where_InList_SP_V2.ADDRESS_TYPE_CODE = i_Params_Get_Address_By_Where_InList_V2.ADDRESS_TYPE_CODE;
oParams_Get_Address_By_Where_InList_SP_V2.STREET = i_Params_Get_Address_By_Where_InList_V2.STREET;
oParams_Get_Address_By_Where_InList_SP_V2.BUILDING = i_Params_Get_Address_By_Where_InList_V2.BUILDING;
oParams_Get_Address_By_Where_InList_SP_V2.FLOOR = i_Params_Get_Address_By_Where_InList_V2.FLOOR;
oParams_Get_Address_By_Where_InList_SP_V2.POBOX = i_Params_Get_Address_By_Where_InList_V2.POBOX;
oParams_Get_Address_By_Where_InList_SP_V2.VALID_DATE_START = i_Params_Get_Address_By_Where_InList_V2.VALID_DATE_START;
oParams_Get_Address_By_Where_InList_SP_V2.VALID_DATE_END = i_Params_Get_Address_By_Where_InList_V2.VALID_DATE_END;
if ( i_Params_Get_Address_By_Where_InList_V2.PERSON_ID_LIST == null)
{
i_Params_Get_Address_By_Where_InList_V2.PERSON_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Where_InList_SP_V2.PERSON_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Where_InList_V2.PERSON_ID_LIST);
if ( i_Params_Get_Address_By_Where_InList_V2.LOC_L1_ID_LIST == null)
{
i_Params_Get_Address_By_Where_InList_V2.LOC_L1_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Where_InList_SP_V2.LOC_L1_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Where_InList_V2.LOC_L1_ID_LIST);
if ( i_Params_Get_Address_By_Where_InList_V2.LOC_L2_ID_LIST == null)
{
i_Params_Get_Address_By_Where_InList_V2.LOC_L2_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Where_InList_SP_V2.LOC_L2_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Where_InList_V2.LOC_L2_ID_LIST);
if ( i_Params_Get_Address_By_Where_InList_V2.LOC_L3_ID_LIST == null)
{
i_Params_Get_Address_By_Where_InList_V2.LOC_L3_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Where_InList_SP_V2.LOC_L3_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Where_InList_V2.LOC_L3_ID_LIST);
if ( i_Params_Get_Address_By_Where_InList_V2.LOC_L4_ID_LIST == null)
{
i_Params_Get_Address_By_Where_InList_V2.LOC_L4_ID_LIST = new List<long?>();
}
oParams_Get_Address_By_Where_InList_SP_V2.LOC_L4_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Address_By_Where_InList_V2.LOC_L4_ID_LIST);
oParams_Get_Address_By_Where_InList_SP_V2.START_ROW = i_Params_Get_Address_By_Where_InList_V2.START_ROW;
oParams_Get_Address_By_Where_InList_SP_V2.END_ROW = i_Params_Get_Address_By_Where_InList_V2.END_ROW;
oParams_Get_Address_By_Where_InList_SP_V2.TOTAL_COUNT = i_Params_Get_Address_By_Where_InList_V2.TOTAL_COUNT;
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Where_InList_V2(i_Params_Get_Address_By_Where_InList_V2.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Where_InList_V2.STREET,i_Params_Get_Address_By_Where_InList_V2.BUILDING,i_Params_Get_Address_By_Where_InList_V2.FLOOR,i_Params_Get_Address_By_Where_InList_V2.POBOX,i_Params_Get_Address_By_Where_InList_V2.VALID_DATE_START,i_Params_Get_Address_By_Where_InList_V2.VALID_DATE_END,i_Params_Get_Address_By_Where_InList_V2.PERSON_ID_LIST,i_Params_Get_Address_By_Where_InList_V2.LOC_L1_ID_LIST,i_Params_Get_Address_By_Where_InList_V2.LOC_L2_ID_LIST,i_Params_Get_Address_By_Where_InList_V2.LOC_L3_ID_LIST,i_Params_Get_Address_By_Where_InList_V2.LOC_L4_ID_LIST,i_Params_Get_Address_By_Where_InList_V2.OWNER_ID,i_Params_Get_Address_By_Where_InList_V2.START_ROW,i_Params_Get_Address_By_Where_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Where_InList_V2.TOTAL_COUNT = oParams_Get_Address_By_Where_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Address_By_Where_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Where_InList_V2");}
return oList;
}
public List<Client> Get_Client_By_Criteria_InList(Params_Get_Client_By_Criteria_InList i_Params_Get_Client_By_Criteria_InList)
{
List<Client> oList = new List<Client>();
Client oClient = new Client();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Client_By_Criteria_InList_SP oParams_Get_Client_By_Criteria_InList_SP = new Params_Get_Client_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_By_Criteria_InList");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Client_By_Criteria_InList",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Client_By_Criteria_InList));}
#region Body Section.
if ((i_Params_Get_Client_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Client_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Client_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Client_By_Criteria_InList.START_ROW == null) { i_Params_Get_Client_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Client_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Client_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Client_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Client_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Client_By_Criteria_InList.OWNER_ID;
oParams_Get_Client_By_Criteria_InList_SP.CLIENT_NAME = i_Params_Get_Client_By_Criteria_InList.CLIENT_NAME;
oParams_Get_Client_By_Criteria_InList_SP.CLIENT_PH_NB = i_Params_Get_Client_By_Criteria_InList.CLIENT_PH_NB;
oParams_Get_Client_By_Criteria_InList_SP.CLIENT_MAIL = i_Params_Get_Client_By_Criteria_InList.CLIENT_MAIL;
oParams_Get_Client_By_Criteria_InList_SP.CLIENT_GENDER = i_Params_Get_Client_By_Criteria_InList.CLIENT_GENDER;
if ( i_Params_Get_Client_By_Criteria_InList.BLOODTYPE_ID_LIST == null)
{
i_Params_Get_Client_By_Criteria_InList.BLOODTYPE_ID_LIST = new List<Int32?>();
}
oParams_Get_Client_By_Criteria_InList_SP.BLOODTYPE_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Client_By_Criteria_InList.BLOODTYPE_ID_LIST);
oParams_Get_Client_By_Criteria_InList_SP.START_ROW = i_Params_Get_Client_By_Criteria_InList.START_ROW;
oParams_Get_Client_By_Criteria_InList_SP.END_ROW = i_Params_Get_Client_By_Criteria_InList.END_ROW;
oParams_Get_Client_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Client_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Client> oList_DBEntries = _AppContext.Get_Client_By_Criteria_InList(i_Params_Get_Client_By_Criteria_InList.CLIENT_NAME,i_Params_Get_Client_By_Criteria_InList.CLIENT_PH_NB,i_Params_Get_Client_By_Criteria_InList.CLIENT_MAIL,i_Params_Get_Client_By_Criteria_InList.CLIENT_GENDER,i_Params_Get_Client_By_Criteria_InList.BLOODTYPE_ID_LIST,i_Params_Get_Client_By_Criteria_InList.OWNER_ID,i_Params_Get_Client_By_Criteria_InList.START_ROW,i_Params_Get_Client_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oClient = new Client();
oTools.CopyPropValues(oDBEntry, oClient);
oList.Add(oClient);
}
}
i_Params_Get_Client_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Client_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Client_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_By_Criteria_InList");}
return oList;
}
public List<Client> Get_Client_By_Where_InList(Params_Get_Client_By_Where_InList i_Params_Get_Client_By_Where_InList)
{
List<Client> oList = new List<Client>();
Client oClient = new Client();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Client_By_Where_InList_SP oParams_Get_Client_By_Where_InList_SP = new Params_Get_Client_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_By_Where_InList");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Client_By_Where_InList",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Client_By_Where_InList));}
#region Body Section.
if ((i_Params_Get_Client_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Client_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Client_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Client_By_Where_InList.START_ROW == null) { i_Params_Get_Client_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Client_By_Where_InList.END_ROW == null) || (i_Params_Get_Client_By_Where_InList.END_ROW == 0)) { i_Params_Get_Client_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Client_By_Where_InList_SP.OWNER_ID = i_Params_Get_Client_By_Where_InList.OWNER_ID;
oParams_Get_Client_By_Where_InList_SP.CLIENT_NAME = i_Params_Get_Client_By_Where_InList.CLIENT_NAME;
oParams_Get_Client_By_Where_InList_SP.CLIENT_PH_NB = i_Params_Get_Client_By_Where_InList.CLIENT_PH_NB;
oParams_Get_Client_By_Where_InList_SP.CLIENT_MAIL = i_Params_Get_Client_By_Where_InList.CLIENT_MAIL;
oParams_Get_Client_By_Where_InList_SP.CLIENT_GENDER = i_Params_Get_Client_By_Where_InList.CLIENT_GENDER;
if ( i_Params_Get_Client_By_Where_InList.BLOODTYPE_ID_LIST == null)
{
i_Params_Get_Client_By_Where_InList.BLOODTYPE_ID_LIST = new List<Int32?>();
}
oParams_Get_Client_By_Where_InList_SP.BLOODTYPE_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Client_By_Where_InList.BLOODTYPE_ID_LIST);
oParams_Get_Client_By_Where_InList_SP.START_ROW = i_Params_Get_Client_By_Where_InList.START_ROW;
oParams_Get_Client_By_Where_InList_SP.END_ROW = i_Params_Get_Client_By_Where_InList.END_ROW;
oParams_Get_Client_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Client_By_Where_InList.TOTAL_COUNT;
List<DALC.Client> oList_DBEntries = _AppContext.Get_Client_By_Where_InList(i_Params_Get_Client_By_Where_InList.CLIENT_NAME,i_Params_Get_Client_By_Where_InList.CLIENT_PH_NB,i_Params_Get_Client_By_Where_InList.CLIENT_MAIL,i_Params_Get_Client_By_Where_InList.CLIENT_GENDER,i_Params_Get_Client_By_Where_InList.BLOODTYPE_ID_LIST,i_Params_Get_Client_By_Where_InList.OWNER_ID,i_Params_Get_Client_By_Where_InList.START_ROW,i_Params_Get_Client_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oClient = new Client();
oTools.CopyPropValues(oDBEntry, oClient);
oList.Add(oClient);
}
}
i_Params_Get_Client_By_Where_InList.TOTAL_COUNT = oParams_Get_Client_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Client_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_By_Where_InList");}
return oList;
}
public List<Client> Get_Client_By_Criteria_InList_V2(Params_Get_Client_By_Criteria_InList_V2 i_Params_Get_Client_By_Criteria_InList_V2)
{
List<Client> oList = new List<Client>();
Client oClient = new Client();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Client_By_Criteria_InList_SP_V2 oParams_Get_Client_By_Criteria_InList_SP_V2 = new Params_Get_Client_By_Criteria_InList_SP_V2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_By_Criteria_InList_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Client_By_Criteria_InList_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Client_By_Criteria_InList_V2));}
#region Body Section.
if ((i_Params_Get_Client_By_Criteria_InList_V2.OWNER_ID == null) || (i_Params_Get_Client_By_Criteria_InList_V2.OWNER_ID == 0)) { i_Params_Get_Client_By_Criteria_InList_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Client_By_Criteria_InList_V2.START_ROW == null) { i_Params_Get_Client_By_Criteria_InList_V2.START_ROW = 0; }
if ((i_Params_Get_Client_By_Criteria_InList_V2.END_ROW == null) || (i_Params_Get_Client_By_Criteria_InList_V2.END_ROW == 0)) { i_Params_Get_Client_By_Criteria_InList_V2.END_ROW = 1000000; }
oParams_Get_Client_By_Criteria_InList_SP_V2.OWNER_ID = i_Params_Get_Client_By_Criteria_InList_V2.OWNER_ID;
oParams_Get_Client_By_Criteria_InList_SP_V2.CLIENT_NAME = i_Params_Get_Client_By_Criteria_InList_V2.CLIENT_NAME;
oParams_Get_Client_By_Criteria_InList_SP_V2.CLIENT_PH_NB = i_Params_Get_Client_By_Criteria_InList_V2.CLIENT_PH_NB;
oParams_Get_Client_By_Criteria_InList_SP_V2.CLIENT_MAIL = i_Params_Get_Client_By_Criteria_InList_V2.CLIENT_MAIL;
oParams_Get_Client_By_Criteria_InList_SP_V2.CLIENT_DOB = i_Params_Get_Client_By_Criteria_InList_V2.CLIENT_DOB;
oParams_Get_Client_By_Criteria_InList_SP_V2.CLIENT_GENDER = i_Params_Get_Client_By_Criteria_InList_V2.CLIENT_GENDER;
if ( i_Params_Get_Client_By_Criteria_InList_V2.BLOODTYPE_ID_LIST == null)
{
i_Params_Get_Client_By_Criteria_InList_V2.BLOODTYPE_ID_LIST = new List<Int32?>();
}
oParams_Get_Client_By_Criteria_InList_SP_V2.BLOODTYPE_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Client_By_Criteria_InList_V2.BLOODTYPE_ID_LIST);
oParams_Get_Client_By_Criteria_InList_SP_V2.START_ROW = i_Params_Get_Client_By_Criteria_InList_V2.START_ROW;
oParams_Get_Client_By_Criteria_InList_SP_V2.END_ROW = i_Params_Get_Client_By_Criteria_InList_V2.END_ROW;
oParams_Get_Client_By_Criteria_InList_SP_V2.TOTAL_COUNT = i_Params_Get_Client_By_Criteria_InList_V2.TOTAL_COUNT;
List<DALC.Client> oList_DBEntries = _AppContext.Get_Client_By_Criteria_InList_V2(i_Params_Get_Client_By_Criteria_InList_V2.CLIENT_NAME,i_Params_Get_Client_By_Criteria_InList_V2.CLIENT_PH_NB,i_Params_Get_Client_By_Criteria_InList_V2.CLIENT_MAIL,i_Params_Get_Client_By_Criteria_InList_V2.CLIENT_DOB,i_Params_Get_Client_By_Criteria_InList_V2.CLIENT_GENDER,i_Params_Get_Client_By_Criteria_InList_V2.BLOODTYPE_ID_LIST,i_Params_Get_Client_By_Criteria_InList_V2.OWNER_ID,i_Params_Get_Client_By_Criteria_InList_V2.START_ROW,i_Params_Get_Client_By_Criteria_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oClient = new Client();
oTools.CopyPropValues(oDBEntry, oClient);
oList.Add(oClient);
}
}
i_Params_Get_Client_By_Criteria_InList_V2.TOTAL_COUNT = oParams_Get_Client_By_Criteria_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Client_By_Criteria_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_By_Criteria_InList_V2");}
return oList;
}
public List<Client> Get_Client_By_Where_InList_V2(Params_Get_Client_By_Where_InList_V2 i_Params_Get_Client_By_Where_InList_V2)
{
List<Client> oList = new List<Client>();
Client oClient = new Client();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Client_By_Where_InList_SP_V2 oParams_Get_Client_By_Where_InList_SP_V2 = new Params_Get_Client_By_Where_InList_SP_V2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_By_Where_InList_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Client_By_Where_InList_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Client_By_Where_InList_V2));}
#region Body Section.
if ((i_Params_Get_Client_By_Where_InList_V2.OWNER_ID == null) || (i_Params_Get_Client_By_Where_InList_V2.OWNER_ID == 0)) { i_Params_Get_Client_By_Where_InList_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Client_By_Where_InList_V2.START_ROW == null) { i_Params_Get_Client_By_Where_InList_V2.START_ROW = 0; }
if ((i_Params_Get_Client_By_Where_InList_V2.END_ROW == null) || (i_Params_Get_Client_By_Where_InList_V2.END_ROW == 0)) { i_Params_Get_Client_By_Where_InList_V2.END_ROW = 1000000; }
oParams_Get_Client_By_Where_InList_SP_V2.OWNER_ID = i_Params_Get_Client_By_Where_InList_V2.OWNER_ID;
oParams_Get_Client_By_Where_InList_SP_V2.CLIENT_NAME = i_Params_Get_Client_By_Where_InList_V2.CLIENT_NAME;
oParams_Get_Client_By_Where_InList_SP_V2.CLIENT_PH_NB = i_Params_Get_Client_By_Where_InList_V2.CLIENT_PH_NB;
oParams_Get_Client_By_Where_InList_SP_V2.CLIENT_MAIL = i_Params_Get_Client_By_Where_InList_V2.CLIENT_MAIL;
oParams_Get_Client_By_Where_InList_SP_V2.CLIENT_DOB = i_Params_Get_Client_By_Where_InList_V2.CLIENT_DOB;
oParams_Get_Client_By_Where_InList_SP_V2.CLIENT_GENDER = i_Params_Get_Client_By_Where_InList_V2.CLIENT_GENDER;
if ( i_Params_Get_Client_By_Where_InList_V2.BLOODTYPE_ID_LIST == null)
{
i_Params_Get_Client_By_Where_InList_V2.BLOODTYPE_ID_LIST = new List<Int32?>();
}
oParams_Get_Client_By_Where_InList_SP_V2.BLOODTYPE_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Client_By_Where_InList_V2.BLOODTYPE_ID_LIST);
oParams_Get_Client_By_Where_InList_SP_V2.START_ROW = i_Params_Get_Client_By_Where_InList_V2.START_ROW;
oParams_Get_Client_By_Where_InList_SP_V2.END_ROW = i_Params_Get_Client_By_Where_InList_V2.END_ROW;
oParams_Get_Client_By_Where_InList_SP_V2.TOTAL_COUNT = i_Params_Get_Client_By_Where_InList_V2.TOTAL_COUNT;
List<DALC.Client> oList_DBEntries = _AppContext.Get_Client_By_Where_InList_V2(i_Params_Get_Client_By_Where_InList_V2.CLIENT_NAME,i_Params_Get_Client_By_Where_InList_V2.CLIENT_PH_NB,i_Params_Get_Client_By_Where_InList_V2.CLIENT_MAIL,i_Params_Get_Client_By_Where_InList_V2.CLIENT_DOB,i_Params_Get_Client_By_Where_InList_V2.CLIENT_GENDER,i_Params_Get_Client_By_Where_InList_V2.BLOODTYPE_ID_LIST,i_Params_Get_Client_By_Where_InList_V2.OWNER_ID,i_Params_Get_Client_By_Where_InList_V2.START_ROW,i_Params_Get_Client_By_Where_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oClient = new Client();
oTools.CopyPropValues(oDBEntry, oClient);
oList.Add(oClient);
}
}
i_Params_Get_Client_By_Where_InList_V2.TOTAL_COUNT = oParams_Get_Client_By_Where_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Client_By_Where_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_By_Where_InList_V2");}
return oList;
}
public List<Client_fees> Get_Client_fees_By_Criteria_InList(Params_Get_Client_fees_By_Criteria_InList i_Params_Get_Client_fees_By_Criteria_InList)
{
List<Client_fees> oList = new List<Client_fees>();
Client_fees oClient_fees = new Client_fees();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Client_fees_By_Criteria_InList_SP oParams_Get_Client_fees_By_Criteria_InList_SP = new Params_Get_Client_fees_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_fees_By_Criteria_InList");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Client_fees_By_Criteria_InList",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Client_fees_By_Criteria_InList));}
#region Body Section.
if ((i_Params_Get_Client_fees_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Client_fees_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Client_fees_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Client_fees_By_Criteria_InList.START_ROW == null) { i_Params_Get_Client_fees_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Client_fees_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Client_fees_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Client_fees_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Client_fees_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Client_fees_By_Criteria_InList.OWNER_ID;
oParams_Get_Client_fees_By_Criteria_InList_SP.CLIENT_FEES_DESCRIPTION = i_Params_Get_Client_fees_By_Criteria_InList.CLIENT_FEES_DESCRIPTION;
if ( i_Params_Get_Client_fees_By_Criteria_InList.CLIENT_ID_LIST == null)
{
i_Params_Get_Client_fees_By_Criteria_InList.CLIENT_ID_LIST = new List<Int32?>();
}
oParams_Get_Client_fees_By_Criteria_InList_SP.CLIENT_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Client_fees_By_Criteria_InList.CLIENT_ID_LIST);
if ( i_Params_Get_Client_fees_By_Criteria_InList.CURRENCY_ID_LIST == null)
{
i_Params_Get_Client_fees_By_Criteria_InList.CURRENCY_ID_LIST = new List<Int32?>();
}
oParams_Get_Client_fees_By_Criteria_InList_SP.CURRENCY_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Client_fees_By_Criteria_InList.CURRENCY_ID_LIST);
if ( i_Params_Get_Client_fees_By_Criteria_InList.PACKAGE_ID_LIST == null)
{
i_Params_Get_Client_fees_By_Criteria_InList.PACKAGE_ID_LIST = new List<Int32?>();
}
oParams_Get_Client_fees_By_Criteria_InList_SP.PACKAGE_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Client_fees_By_Criteria_InList.PACKAGE_ID_LIST);
if ( i_Params_Get_Client_fees_By_Criteria_InList.REGISTRATION_ID_LIST == null)
{
i_Params_Get_Client_fees_By_Criteria_InList.REGISTRATION_ID_LIST = new List<Int32?>();
}
oParams_Get_Client_fees_By_Criteria_InList_SP.REGISTRATION_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Client_fees_By_Criteria_InList.REGISTRATION_ID_LIST);
oParams_Get_Client_fees_By_Criteria_InList_SP.START_ROW = i_Params_Get_Client_fees_By_Criteria_InList.START_ROW;
oParams_Get_Client_fees_By_Criteria_InList_SP.END_ROW = i_Params_Get_Client_fees_By_Criteria_InList.END_ROW;
oParams_Get_Client_fees_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Client_fees_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Client_fees> oList_DBEntries = _AppContext.Get_Client_fees_By_Criteria_InList(i_Params_Get_Client_fees_By_Criteria_InList.CLIENT_FEES_DESCRIPTION,i_Params_Get_Client_fees_By_Criteria_InList.CLIENT_ID_LIST,i_Params_Get_Client_fees_By_Criteria_InList.CURRENCY_ID_LIST,i_Params_Get_Client_fees_By_Criteria_InList.PACKAGE_ID_LIST,i_Params_Get_Client_fees_By_Criteria_InList.REGISTRATION_ID_LIST,i_Params_Get_Client_fees_By_Criteria_InList.OWNER_ID,i_Params_Get_Client_fees_By_Criteria_InList.START_ROW,i_Params_Get_Client_fees_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oClient_fees = new Client_fees();
oTools.CopyPropValues(oDBEntry, oClient_fees);
oList.Add(oClient_fees);
}
}
i_Params_Get_Client_fees_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Client_fees_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Client_fees_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_fees_By_Criteria_InList");}
return oList;
}
public List<Client_fees> Get_Client_fees_By_Where_InList(Params_Get_Client_fees_By_Where_InList i_Params_Get_Client_fees_By_Where_InList)
{
List<Client_fees> oList = new List<Client_fees>();
Client_fees oClient_fees = new Client_fees();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Client_fees_By_Where_InList_SP oParams_Get_Client_fees_By_Where_InList_SP = new Params_Get_Client_fees_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_fees_By_Where_InList");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Client_fees_By_Where_InList",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Client_fees_By_Where_InList));}
#region Body Section.
if ((i_Params_Get_Client_fees_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Client_fees_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Client_fees_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Client_fees_By_Where_InList.START_ROW == null) { i_Params_Get_Client_fees_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Client_fees_By_Where_InList.END_ROW == null) || (i_Params_Get_Client_fees_By_Where_InList.END_ROW == 0)) { i_Params_Get_Client_fees_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Client_fees_By_Where_InList_SP.OWNER_ID = i_Params_Get_Client_fees_By_Where_InList.OWNER_ID;
oParams_Get_Client_fees_By_Where_InList_SP.CLIENT_FEES_DESCRIPTION = i_Params_Get_Client_fees_By_Where_InList.CLIENT_FEES_DESCRIPTION;
if ( i_Params_Get_Client_fees_By_Where_InList.CLIENT_ID_LIST == null)
{
i_Params_Get_Client_fees_By_Where_InList.CLIENT_ID_LIST = new List<Int32?>();
}
oParams_Get_Client_fees_By_Where_InList_SP.CLIENT_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Client_fees_By_Where_InList.CLIENT_ID_LIST);
if ( i_Params_Get_Client_fees_By_Where_InList.CURRENCY_ID_LIST == null)
{
i_Params_Get_Client_fees_By_Where_InList.CURRENCY_ID_LIST = new List<Int32?>();
}
oParams_Get_Client_fees_By_Where_InList_SP.CURRENCY_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Client_fees_By_Where_InList.CURRENCY_ID_LIST);
if ( i_Params_Get_Client_fees_By_Where_InList.PACKAGE_ID_LIST == null)
{
i_Params_Get_Client_fees_By_Where_InList.PACKAGE_ID_LIST = new List<Int32?>();
}
oParams_Get_Client_fees_By_Where_InList_SP.PACKAGE_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Client_fees_By_Where_InList.PACKAGE_ID_LIST);
if ( i_Params_Get_Client_fees_By_Where_InList.REGISTRATION_ID_LIST == null)
{
i_Params_Get_Client_fees_By_Where_InList.REGISTRATION_ID_LIST = new List<Int32?>();
}
oParams_Get_Client_fees_By_Where_InList_SP.REGISTRATION_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Client_fees_By_Where_InList.REGISTRATION_ID_LIST);
oParams_Get_Client_fees_By_Where_InList_SP.START_ROW = i_Params_Get_Client_fees_By_Where_InList.START_ROW;
oParams_Get_Client_fees_By_Where_InList_SP.END_ROW = i_Params_Get_Client_fees_By_Where_InList.END_ROW;
oParams_Get_Client_fees_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Client_fees_By_Where_InList.TOTAL_COUNT;
List<DALC.Client_fees> oList_DBEntries = _AppContext.Get_Client_fees_By_Where_InList(i_Params_Get_Client_fees_By_Where_InList.CLIENT_FEES_DESCRIPTION,i_Params_Get_Client_fees_By_Where_InList.CLIENT_ID_LIST,i_Params_Get_Client_fees_By_Where_InList.CURRENCY_ID_LIST,i_Params_Get_Client_fees_By_Where_InList.PACKAGE_ID_LIST,i_Params_Get_Client_fees_By_Where_InList.REGISTRATION_ID_LIST,i_Params_Get_Client_fees_By_Where_InList.OWNER_ID,i_Params_Get_Client_fees_By_Where_InList.START_ROW,i_Params_Get_Client_fees_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oClient_fees = new Client_fees();
oTools.CopyPropValues(oDBEntry, oClient_fees);
oList.Add(oClient_fees);
}
}
i_Params_Get_Client_fees_By_Where_InList.TOTAL_COUNT = oParams_Get_Client_fees_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Client_fees_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_fees_By_Where_InList");}
return oList;
}
public List<Contact> Get_Contact_By_Criteria_InList(Params_Get_Contact_By_Criteria_InList i_Params_Get_Contact_By_Criteria_InList)
{
List<Contact> oList = new List<Contact>();
Contact oContact = new Contact();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Contact_By_Criteria_InList_SP oParams_Get_Contact_By_Criteria_InList_SP = new Params_Get_Contact_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_Criteria_InList");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Contact_By_Criteria_InList",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Contact_By_Criteria_InList));}
#region Body Section.
if ((i_Params_Get_Contact_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Contact_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Contact_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Contact_By_Criteria_InList.START_ROW == null) { i_Params_Get_Contact_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Contact_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Contact_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Contact_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Contact_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Contact_By_Criteria_InList.OWNER_ID;
oParams_Get_Contact_By_Criteria_InList_SP.CONTACT_TYPE_CODE = i_Params_Get_Contact_By_Criteria_InList.CONTACT_TYPE_CODE;
oParams_Get_Contact_By_Criteria_InList_SP.CONTACT = i_Params_Get_Contact_By_Criteria_InList.CONTACT;
oParams_Get_Contact_By_Criteria_InList_SP.DESCRIPTION = i_Params_Get_Contact_By_Criteria_InList.DESCRIPTION;
if ( i_Params_Get_Contact_By_Criteria_InList.PERSON_ID_LIST == null)
{
i_Params_Get_Contact_By_Criteria_InList.PERSON_ID_LIST = new List<long?>();
}
oParams_Get_Contact_By_Criteria_InList_SP.PERSON_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Contact_By_Criteria_InList.PERSON_ID_LIST);
oParams_Get_Contact_By_Criteria_InList_SP.START_ROW = i_Params_Get_Contact_By_Criteria_InList.START_ROW;
oParams_Get_Contact_By_Criteria_InList_SP.END_ROW = i_Params_Get_Contact_By_Criteria_InList.END_ROW;
oParams_Get_Contact_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Contact_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_Criteria_InList(i_Params_Get_Contact_By_Criteria_InList.CONTACT_TYPE_CODE,i_Params_Get_Contact_By_Criteria_InList.CONTACT,i_Params_Get_Contact_By_Criteria_InList.DESCRIPTION,i_Params_Get_Contact_By_Criteria_InList.PERSON_ID_LIST,i_Params_Get_Contact_By_Criteria_InList.OWNER_ID,i_Params_Get_Contact_By_Criteria_InList.START_ROW,i_Params_Get_Contact_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oList.Add(oContact);
}
}
i_Params_Get_Contact_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Contact_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Contact_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_Criteria_InList");}
return oList;
}
public List<Contact> Get_Contact_By_Where_InList(Params_Get_Contact_By_Where_InList i_Params_Get_Contact_By_Where_InList)
{
List<Contact> oList = new List<Contact>();
Contact oContact = new Contact();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Contact_By_Where_InList_SP oParams_Get_Contact_By_Where_InList_SP = new Params_Get_Contact_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_Where_InList");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Contact_By_Where_InList",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Contact_By_Where_InList));}
#region Body Section.
if ((i_Params_Get_Contact_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Contact_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Contact_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Contact_By_Where_InList.START_ROW == null) { i_Params_Get_Contact_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Contact_By_Where_InList.END_ROW == null) || (i_Params_Get_Contact_By_Where_InList.END_ROW == 0)) { i_Params_Get_Contact_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Contact_By_Where_InList_SP.OWNER_ID = i_Params_Get_Contact_By_Where_InList.OWNER_ID;
oParams_Get_Contact_By_Where_InList_SP.CONTACT_TYPE_CODE = i_Params_Get_Contact_By_Where_InList.CONTACT_TYPE_CODE;
oParams_Get_Contact_By_Where_InList_SP.CONTACT = i_Params_Get_Contact_By_Where_InList.CONTACT;
oParams_Get_Contact_By_Where_InList_SP.DESCRIPTION = i_Params_Get_Contact_By_Where_InList.DESCRIPTION;
if ( i_Params_Get_Contact_By_Where_InList.PERSON_ID_LIST == null)
{
i_Params_Get_Contact_By_Where_InList.PERSON_ID_LIST = new List<long?>();
}
oParams_Get_Contact_By_Where_InList_SP.PERSON_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Contact_By_Where_InList.PERSON_ID_LIST);
oParams_Get_Contact_By_Where_InList_SP.START_ROW = i_Params_Get_Contact_By_Where_InList.START_ROW;
oParams_Get_Contact_By_Where_InList_SP.END_ROW = i_Params_Get_Contact_By_Where_InList.END_ROW;
oParams_Get_Contact_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Contact_By_Where_InList.TOTAL_COUNT;
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_Where_InList(i_Params_Get_Contact_By_Where_InList.CONTACT_TYPE_CODE,i_Params_Get_Contact_By_Where_InList.CONTACT,i_Params_Get_Contact_By_Where_InList.DESCRIPTION,i_Params_Get_Contact_By_Where_InList.PERSON_ID_LIST,i_Params_Get_Contact_By_Where_InList.OWNER_ID,i_Params_Get_Contact_By_Where_InList.START_ROW,i_Params_Get_Contact_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oList.Add(oContact);
}
}
i_Params_Get_Contact_By_Where_InList.TOTAL_COUNT = oParams_Get_Contact_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Contact_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_Where_InList");}
return oList;
}
public List<Fees> Get_Fees_By_Criteria_InList(Params_Get_Fees_By_Criteria_InList i_Params_Get_Fees_By_Criteria_InList)
{
List<Fees> oList = new List<Fees>();
Fees oFees = new Fees();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Fees_By_Criteria_InList_SP oParams_Get_Fees_By_Criteria_InList_SP = new Params_Get_Fees_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Fees_By_Criteria_InList");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Fees_By_Criteria_InList",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Fees_By_Criteria_InList));}
#region Body Section.
if ((i_Params_Get_Fees_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Fees_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Fees_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Fees_By_Criteria_InList.START_ROW == null) { i_Params_Get_Fees_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Fees_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Fees_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Fees_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Fees_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Fees_By_Criteria_InList.OWNER_ID;
oParams_Get_Fees_By_Criteria_InList_SP.FEES_DESCRIPTION = i_Params_Get_Fees_By_Criteria_InList.FEES_DESCRIPTION;
if ( i_Params_Get_Fees_By_Criteria_InList.CURRENCY_ID_LIST == null)
{
i_Params_Get_Fees_By_Criteria_InList.CURRENCY_ID_LIST = new List<Int32?>();
}
oParams_Get_Fees_By_Criteria_InList_SP.CURRENCY_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Fees_By_Criteria_InList.CURRENCY_ID_LIST);
oParams_Get_Fees_By_Criteria_InList_SP.START_ROW = i_Params_Get_Fees_By_Criteria_InList.START_ROW;
oParams_Get_Fees_By_Criteria_InList_SP.END_ROW = i_Params_Get_Fees_By_Criteria_InList.END_ROW;
oParams_Get_Fees_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Fees_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Fees> oList_DBEntries = _AppContext.Get_Fees_By_Criteria_InList(i_Params_Get_Fees_By_Criteria_InList.FEES_DESCRIPTION,i_Params_Get_Fees_By_Criteria_InList.CURRENCY_ID_LIST,i_Params_Get_Fees_By_Criteria_InList.OWNER_ID,i_Params_Get_Fees_By_Criteria_InList.START_ROW,i_Params_Get_Fees_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFees = new Fees();
oTools.CopyPropValues(oDBEntry, oFees);
oList.Add(oFees);
}
}
i_Params_Get_Fees_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Fees_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Fees_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Fees_By_Criteria_InList");}
return oList;
}
public List<Fees> Get_Fees_By_Where_InList(Params_Get_Fees_By_Where_InList i_Params_Get_Fees_By_Where_InList)
{
List<Fees> oList = new List<Fees>();
Fees oFees = new Fees();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Fees_By_Where_InList_SP oParams_Get_Fees_By_Where_InList_SP = new Params_Get_Fees_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Fees_By_Where_InList");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Fees_By_Where_InList",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Fees_By_Where_InList));}
#region Body Section.
if ((i_Params_Get_Fees_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Fees_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Fees_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Fees_By_Where_InList.START_ROW == null) { i_Params_Get_Fees_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Fees_By_Where_InList.END_ROW == null) || (i_Params_Get_Fees_By_Where_InList.END_ROW == 0)) { i_Params_Get_Fees_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Fees_By_Where_InList_SP.OWNER_ID = i_Params_Get_Fees_By_Where_InList.OWNER_ID;
oParams_Get_Fees_By_Where_InList_SP.FEES_DESCRIPTION = i_Params_Get_Fees_By_Where_InList.FEES_DESCRIPTION;
if ( i_Params_Get_Fees_By_Where_InList.CURRENCY_ID_LIST == null)
{
i_Params_Get_Fees_By_Where_InList.CURRENCY_ID_LIST = new List<Int32?>();
}
oParams_Get_Fees_By_Where_InList_SP.CURRENCY_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Fees_By_Where_InList.CURRENCY_ID_LIST);
oParams_Get_Fees_By_Where_InList_SP.START_ROW = i_Params_Get_Fees_By_Where_InList.START_ROW;
oParams_Get_Fees_By_Where_InList_SP.END_ROW = i_Params_Get_Fees_By_Where_InList.END_ROW;
oParams_Get_Fees_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Fees_By_Where_InList.TOTAL_COUNT;
List<DALC.Fees> oList_DBEntries = _AppContext.Get_Fees_By_Where_InList(i_Params_Get_Fees_By_Where_InList.FEES_DESCRIPTION,i_Params_Get_Fees_By_Where_InList.CURRENCY_ID_LIST,i_Params_Get_Fees_By_Where_InList.OWNER_ID,i_Params_Get_Fees_By_Where_InList.START_ROW,i_Params_Get_Fees_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFees = new Fees();
oTools.CopyPropValues(oDBEntry, oFees);
oList.Add(oFees);
}
}
i_Params_Get_Fees_By_Where_InList.TOTAL_COUNT = oParams_Get_Fees_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Fees_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Fees_By_Where_InList");}
return oList;
}
public List<Fees> Get_Fees_By_Criteria_InList_V2(Params_Get_Fees_By_Criteria_InList_V2 i_Params_Get_Fees_By_Criteria_InList_V2)
{
List<Fees> oList = new List<Fees>();
Fees oFees = new Fees();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Fees_By_Criteria_InList_SP_V2 oParams_Get_Fees_By_Criteria_InList_SP_V2 = new Params_Get_Fees_By_Criteria_InList_SP_V2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Fees_By_Criteria_InList_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Fees_By_Criteria_InList_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Fees_By_Criteria_InList_V2));}
#region Body Section.
if ((i_Params_Get_Fees_By_Criteria_InList_V2.OWNER_ID == null) || (i_Params_Get_Fees_By_Criteria_InList_V2.OWNER_ID == 0)) { i_Params_Get_Fees_By_Criteria_InList_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Fees_By_Criteria_InList_V2.START_ROW == null) { i_Params_Get_Fees_By_Criteria_InList_V2.START_ROW = 0; }
if ((i_Params_Get_Fees_By_Criteria_InList_V2.END_ROW == null) || (i_Params_Get_Fees_By_Criteria_InList_V2.END_ROW == 0)) { i_Params_Get_Fees_By_Criteria_InList_V2.END_ROW = 1000000; }
oParams_Get_Fees_By_Criteria_InList_SP_V2.OWNER_ID = i_Params_Get_Fees_By_Criteria_InList_V2.OWNER_ID;
oParams_Get_Fees_By_Criteria_InList_SP_V2.FEES_DESCRIPTION = i_Params_Get_Fees_By_Criteria_InList_V2.FEES_DESCRIPTION;
oParams_Get_Fees_By_Criteria_InList_SP_V2.FEES_ORIGIN_DATE = i_Params_Get_Fees_By_Criteria_InList_V2.FEES_ORIGIN_DATE;
if ( i_Params_Get_Fees_By_Criteria_InList_V2.CURRENCY_ID_LIST == null)
{
i_Params_Get_Fees_By_Criteria_InList_V2.CURRENCY_ID_LIST = new List<Int32?>();
}
oParams_Get_Fees_By_Criteria_InList_SP_V2.CURRENCY_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Fees_By_Criteria_InList_V2.CURRENCY_ID_LIST);
oParams_Get_Fees_By_Criteria_InList_SP_V2.START_ROW = i_Params_Get_Fees_By_Criteria_InList_V2.START_ROW;
oParams_Get_Fees_By_Criteria_InList_SP_V2.END_ROW = i_Params_Get_Fees_By_Criteria_InList_V2.END_ROW;
oParams_Get_Fees_By_Criteria_InList_SP_V2.TOTAL_COUNT = i_Params_Get_Fees_By_Criteria_InList_V2.TOTAL_COUNT;
List<DALC.Fees> oList_DBEntries = _AppContext.Get_Fees_By_Criteria_InList_V2(i_Params_Get_Fees_By_Criteria_InList_V2.FEES_DESCRIPTION,i_Params_Get_Fees_By_Criteria_InList_V2.FEES_ORIGIN_DATE,i_Params_Get_Fees_By_Criteria_InList_V2.CURRENCY_ID_LIST,i_Params_Get_Fees_By_Criteria_InList_V2.OWNER_ID,i_Params_Get_Fees_By_Criteria_InList_V2.START_ROW,i_Params_Get_Fees_By_Criteria_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFees = new Fees();
oTools.CopyPropValues(oDBEntry, oFees);
oList.Add(oFees);
}
}
i_Params_Get_Fees_By_Criteria_InList_V2.TOTAL_COUNT = oParams_Get_Fees_By_Criteria_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Fees_By_Criteria_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Fees_By_Criteria_InList_V2");}
return oList;
}
public List<Fees> Get_Fees_By_Where_InList_V2(Params_Get_Fees_By_Where_InList_V2 i_Params_Get_Fees_By_Where_InList_V2)
{
List<Fees> oList = new List<Fees>();
Fees oFees = new Fees();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Fees_By_Where_InList_SP_V2 oParams_Get_Fees_By_Where_InList_SP_V2 = new Params_Get_Fees_By_Where_InList_SP_V2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Fees_By_Where_InList_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Fees_By_Where_InList_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Fees_By_Where_InList_V2));}
#region Body Section.
if ((i_Params_Get_Fees_By_Where_InList_V2.OWNER_ID == null) || (i_Params_Get_Fees_By_Where_InList_V2.OWNER_ID == 0)) { i_Params_Get_Fees_By_Where_InList_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Fees_By_Where_InList_V2.START_ROW == null) { i_Params_Get_Fees_By_Where_InList_V2.START_ROW = 0; }
if ((i_Params_Get_Fees_By_Where_InList_V2.END_ROW == null) || (i_Params_Get_Fees_By_Where_InList_V2.END_ROW == 0)) { i_Params_Get_Fees_By_Where_InList_V2.END_ROW = 1000000; }
oParams_Get_Fees_By_Where_InList_SP_V2.OWNER_ID = i_Params_Get_Fees_By_Where_InList_V2.OWNER_ID;
oParams_Get_Fees_By_Where_InList_SP_V2.FEES_DESCRIPTION = i_Params_Get_Fees_By_Where_InList_V2.FEES_DESCRIPTION;
oParams_Get_Fees_By_Where_InList_SP_V2.FEES_ORIGIN_DATE = i_Params_Get_Fees_By_Where_InList_V2.FEES_ORIGIN_DATE;
if ( i_Params_Get_Fees_By_Where_InList_V2.CURRENCY_ID_LIST == null)
{
i_Params_Get_Fees_By_Where_InList_V2.CURRENCY_ID_LIST = new List<Int32?>();
}
oParams_Get_Fees_By_Where_InList_SP_V2.CURRENCY_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Fees_By_Where_InList_V2.CURRENCY_ID_LIST);
oParams_Get_Fees_By_Where_InList_SP_V2.START_ROW = i_Params_Get_Fees_By_Where_InList_V2.START_ROW;
oParams_Get_Fees_By_Where_InList_SP_V2.END_ROW = i_Params_Get_Fees_By_Where_InList_V2.END_ROW;
oParams_Get_Fees_By_Where_InList_SP_V2.TOTAL_COUNT = i_Params_Get_Fees_By_Where_InList_V2.TOTAL_COUNT;
List<DALC.Fees> oList_DBEntries = _AppContext.Get_Fees_By_Where_InList_V2(i_Params_Get_Fees_By_Where_InList_V2.FEES_DESCRIPTION,i_Params_Get_Fees_By_Where_InList_V2.FEES_ORIGIN_DATE,i_Params_Get_Fees_By_Where_InList_V2.CURRENCY_ID_LIST,i_Params_Get_Fees_By_Where_InList_V2.OWNER_ID,i_Params_Get_Fees_By_Where_InList_V2.START_ROW,i_Params_Get_Fees_By_Where_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFees = new Fees();
oTools.CopyPropValues(oDBEntry, oFees);
oList.Add(oFees);
}
}
i_Params_Get_Fees_By_Where_InList_V2.TOTAL_COUNT = oParams_Get_Fees_By_Where_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Fees_By_Where_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Fees_By_Where_InList_V2");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Criteria_InList(Params_Get_Loc_l2_By_Criteria_InList i_Params_Get_Loc_l2_By_Criteria_InList)
{
List<Loc_l2> oList = new List<Loc_l2>();
Loc_l2 oLoc_l2 = new Loc_l2();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Loc_l2_By_Criteria_InList_SP oParams_Get_Loc_l2_By_Criteria_InList_SP = new Params_Get_Loc_l2_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_Criteria_InList");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l2_By_Criteria_InList",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l2_By_Criteria_InList));}
#region Body Section.
if ((i_Params_Get_Loc_l2_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Loc_l2_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Loc_l2_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l2_By_Criteria_InList.START_ROW == null) { i_Params_Get_Loc_l2_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Loc_l2_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Loc_l2_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Loc_l2_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Loc_l2_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Loc_l2_By_Criteria_InList.OWNER_ID;
oParams_Get_Loc_l2_By_Criteria_InList_SP.CODE = i_Params_Get_Loc_l2_By_Criteria_InList.CODE;
oParams_Get_Loc_l2_By_Criteria_InList_SP.DESCRIPTION = i_Params_Get_Loc_l2_By_Criteria_InList.DESCRIPTION;
if ( i_Params_Get_Loc_l2_By_Criteria_InList.LOC_L1_ID_LIST == null)
{
i_Params_Get_Loc_l2_By_Criteria_InList.LOC_L1_ID_LIST = new List<long?>();
}
oParams_Get_Loc_l2_By_Criteria_InList_SP.LOC_L1_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Loc_l2_By_Criteria_InList.LOC_L1_ID_LIST);
oParams_Get_Loc_l2_By_Criteria_InList_SP.START_ROW = i_Params_Get_Loc_l2_By_Criteria_InList.START_ROW;
oParams_Get_Loc_l2_By_Criteria_InList_SP.END_ROW = i_Params_Get_Loc_l2_By_Criteria_InList.END_ROW;
oParams_Get_Loc_l2_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Loc_l2_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_Criteria_InList(i_Params_Get_Loc_l2_By_Criteria_InList.CODE,i_Params_Get_Loc_l2_By_Criteria_InList.DESCRIPTION,i_Params_Get_Loc_l2_By_Criteria_InList.LOC_L1_ID_LIST,i_Params_Get_Loc_l2_By_Criteria_InList.OWNER_ID,i_Params_Get_Loc_l2_By_Criteria_InList.START_ROW,i_Params_Get_Loc_l2_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oList.Add(oLoc_l2);
}
}
i_Params_Get_Loc_l2_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Loc_l2_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Loc_l2_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_Criteria_InList");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Where_InList(Params_Get_Loc_l2_By_Where_InList i_Params_Get_Loc_l2_By_Where_InList)
{
List<Loc_l2> oList = new List<Loc_l2>();
Loc_l2 oLoc_l2 = new Loc_l2();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Loc_l2_By_Where_InList_SP oParams_Get_Loc_l2_By_Where_InList_SP = new Params_Get_Loc_l2_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_Where_InList");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l2_By_Where_InList",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l2_By_Where_InList));}
#region Body Section.
if ((i_Params_Get_Loc_l2_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Loc_l2_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Loc_l2_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l2_By_Where_InList.START_ROW == null) { i_Params_Get_Loc_l2_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Loc_l2_By_Where_InList.END_ROW == null) || (i_Params_Get_Loc_l2_By_Where_InList.END_ROW == 0)) { i_Params_Get_Loc_l2_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Loc_l2_By_Where_InList_SP.OWNER_ID = i_Params_Get_Loc_l2_By_Where_InList.OWNER_ID;
oParams_Get_Loc_l2_By_Where_InList_SP.CODE = i_Params_Get_Loc_l2_By_Where_InList.CODE;
oParams_Get_Loc_l2_By_Where_InList_SP.DESCRIPTION = i_Params_Get_Loc_l2_By_Where_InList.DESCRIPTION;
if ( i_Params_Get_Loc_l2_By_Where_InList.LOC_L1_ID_LIST == null)
{
i_Params_Get_Loc_l2_By_Where_InList.LOC_L1_ID_LIST = new List<long?>();
}
oParams_Get_Loc_l2_By_Where_InList_SP.LOC_L1_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Loc_l2_By_Where_InList.LOC_L1_ID_LIST);
oParams_Get_Loc_l2_By_Where_InList_SP.START_ROW = i_Params_Get_Loc_l2_By_Where_InList.START_ROW;
oParams_Get_Loc_l2_By_Where_InList_SP.END_ROW = i_Params_Get_Loc_l2_By_Where_InList.END_ROW;
oParams_Get_Loc_l2_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Loc_l2_By_Where_InList.TOTAL_COUNT;
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_Where_InList(i_Params_Get_Loc_l2_By_Where_InList.CODE,i_Params_Get_Loc_l2_By_Where_InList.DESCRIPTION,i_Params_Get_Loc_l2_By_Where_InList.LOC_L1_ID_LIST,i_Params_Get_Loc_l2_By_Where_InList.OWNER_ID,i_Params_Get_Loc_l2_By_Where_InList.START_ROW,i_Params_Get_Loc_l2_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oList.Add(oLoc_l2);
}
}
i_Params_Get_Loc_l2_By_Where_InList.TOTAL_COUNT = oParams_Get_Loc_l2_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Loc_l2_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_Where_InList");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Criteria_InList(Params_Get_Loc_l3_By_Criteria_InList i_Params_Get_Loc_l3_By_Criteria_InList)
{
List<Loc_l3> oList = new List<Loc_l3>();
Loc_l3 oLoc_l3 = new Loc_l3();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Loc_l3_By_Criteria_InList_SP oParams_Get_Loc_l3_By_Criteria_InList_SP = new Params_Get_Loc_l3_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_Criteria_InList");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l3_By_Criteria_InList",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l3_By_Criteria_InList));}
#region Body Section.
if ((i_Params_Get_Loc_l3_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Loc_l3_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Loc_l3_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l3_By_Criteria_InList.START_ROW == null) { i_Params_Get_Loc_l3_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Loc_l3_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Loc_l3_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Loc_l3_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Loc_l3_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Loc_l3_By_Criteria_InList.OWNER_ID;
oParams_Get_Loc_l3_By_Criteria_InList_SP.CODE = i_Params_Get_Loc_l3_By_Criteria_InList.CODE;
oParams_Get_Loc_l3_By_Criteria_InList_SP.DESCRIPTION = i_Params_Get_Loc_l3_By_Criteria_InList.DESCRIPTION;
if ( i_Params_Get_Loc_l3_By_Criteria_InList.LOC_L2_ID_LIST == null)
{
i_Params_Get_Loc_l3_By_Criteria_InList.LOC_L2_ID_LIST = new List<long?>();
}
oParams_Get_Loc_l3_By_Criteria_InList_SP.LOC_L2_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Loc_l3_By_Criteria_InList.LOC_L2_ID_LIST);
oParams_Get_Loc_l3_By_Criteria_InList_SP.START_ROW = i_Params_Get_Loc_l3_By_Criteria_InList.START_ROW;
oParams_Get_Loc_l3_By_Criteria_InList_SP.END_ROW = i_Params_Get_Loc_l3_By_Criteria_InList.END_ROW;
oParams_Get_Loc_l3_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Loc_l3_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_Criteria_InList(i_Params_Get_Loc_l3_By_Criteria_InList.CODE,i_Params_Get_Loc_l3_By_Criteria_InList.DESCRIPTION,i_Params_Get_Loc_l3_By_Criteria_InList.LOC_L2_ID_LIST,i_Params_Get_Loc_l3_By_Criteria_InList.OWNER_ID,i_Params_Get_Loc_l3_By_Criteria_InList.START_ROW,i_Params_Get_Loc_l3_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oList.Add(oLoc_l3);
}
}
i_Params_Get_Loc_l3_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Loc_l3_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Loc_l3_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_Criteria_InList");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Where_InList(Params_Get_Loc_l3_By_Where_InList i_Params_Get_Loc_l3_By_Where_InList)
{
List<Loc_l3> oList = new List<Loc_l3>();
Loc_l3 oLoc_l3 = new Loc_l3();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Loc_l3_By_Where_InList_SP oParams_Get_Loc_l3_By_Where_InList_SP = new Params_Get_Loc_l3_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_Where_InList");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l3_By_Where_InList",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l3_By_Where_InList));}
#region Body Section.
if ((i_Params_Get_Loc_l3_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Loc_l3_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Loc_l3_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l3_By_Where_InList.START_ROW == null) { i_Params_Get_Loc_l3_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Loc_l3_By_Where_InList.END_ROW == null) || (i_Params_Get_Loc_l3_By_Where_InList.END_ROW == 0)) { i_Params_Get_Loc_l3_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Loc_l3_By_Where_InList_SP.OWNER_ID = i_Params_Get_Loc_l3_By_Where_InList.OWNER_ID;
oParams_Get_Loc_l3_By_Where_InList_SP.CODE = i_Params_Get_Loc_l3_By_Where_InList.CODE;
oParams_Get_Loc_l3_By_Where_InList_SP.DESCRIPTION = i_Params_Get_Loc_l3_By_Where_InList.DESCRIPTION;
if ( i_Params_Get_Loc_l3_By_Where_InList.LOC_L2_ID_LIST == null)
{
i_Params_Get_Loc_l3_By_Where_InList.LOC_L2_ID_LIST = new List<long?>();
}
oParams_Get_Loc_l3_By_Where_InList_SP.LOC_L2_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Loc_l3_By_Where_InList.LOC_L2_ID_LIST);
oParams_Get_Loc_l3_By_Where_InList_SP.START_ROW = i_Params_Get_Loc_l3_By_Where_InList.START_ROW;
oParams_Get_Loc_l3_By_Where_InList_SP.END_ROW = i_Params_Get_Loc_l3_By_Where_InList.END_ROW;
oParams_Get_Loc_l3_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Loc_l3_By_Where_InList.TOTAL_COUNT;
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_Where_InList(i_Params_Get_Loc_l3_By_Where_InList.CODE,i_Params_Get_Loc_l3_By_Where_InList.DESCRIPTION,i_Params_Get_Loc_l3_By_Where_InList.LOC_L2_ID_LIST,i_Params_Get_Loc_l3_By_Where_InList.OWNER_ID,i_Params_Get_Loc_l3_By_Where_InList.START_ROW,i_Params_Get_Loc_l3_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oList.Add(oLoc_l3);
}
}
i_Params_Get_Loc_l3_By_Where_InList.TOTAL_COUNT = oParams_Get_Loc_l3_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Loc_l3_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_Where_InList");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Criteria_InList(Params_Get_Loc_l4_By_Criteria_InList i_Params_Get_Loc_l4_By_Criteria_InList)
{
List<Loc_l4> oList = new List<Loc_l4>();
Loc_l4 oLoc_l4 = new Loc_l4();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Loc_l4_By_Criteria_InList_SP oParams_Get_Loc_l4_By_Criteria_InList_SP = new Params_Get_Loc_l4_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_Criteria_InList");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l4_By_Criteria_InList",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l4_By_Criteria_InList));}
#region Body Section.
if ((i_Params_Get_Loc_l4_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Loc_l4_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Loc_l4_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l4_By_Criteria_InList.START_ROW == null) { i_Params_Get_Loc_l4_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Loc_l4_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Loc_l4_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Loc_l4_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Loc_l4_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Loc_l4_By_Criteria_InList.OWNER_ID;
oParams_Get_Loc_l4_By_Criteria_InList_SP.CODE = i_Params_Get_Loc_l4_By_Criteria_InList.CODE;
oParams_Get_Loc_l4_By_Criteria_InList_SP.DESCRIPTION = i_Params_Get_Loc_l4_By_Criteria_InList.DESCRIPTION;
if ( i_Params_Get_Loc_l4_By_Criteria_InList.LOC_L3_ID_LIST == null)
{
i_Params_Get_Loc_l4_By_Criteria_InList.LOC_L3_ID_LIST = new List<long?>();
}
oParams_Get_Loc_l4_By_Criteria_InList_SP.LOC_L3_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Loc_l4_By_Criteria_InList.LOC_L3_ID_LIST);
oParams_Get_Loc_l4_By_Criteria_InList_SP.START_ROW = i_Params_Get_Loc_l4_By_Criteria_InList.START_ROW;
oParams_Get_Loc_l4_By_Criteria_InList_SP.END_ROW = i_Params_Get_Loc_l4_By_Criteria_InList.END_ROW;
oParams_Get_Loc_l4_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Loc_l4_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_Criteria_InList(i_Params_Get_Loc_l4_By_Criteria_InList.CODE,i_Params_Get_Loc_l4_By_Criteria_InList.DESCRIPTION,i_Params_Get_Loc_l4_By_Criteria_InList.LOC_L3_ID_LIST,i_Params_Get_Loc_l4_By_Criteria_InList.OWNER_ID,i_Params_Get_Loc_l4_By_Criteria_InList.START_ROW,i_Params_Get_Loc_l4_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oList.Add(oLoc_l4);
}
}
i_Params_Get_Loc_l4_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Loc_l4_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Loc_l4_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_Criteria_InList");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Where_InList(Params_Get_Loc_l4_By_Where_InList i_Params_Get_Loc_l4_By_Where_InList)
{
List<Loc_l4> oList = new List<Loc_l4>();
Loc_l4 oLoc_l4 = new Loc_l4();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Loc_l4_By_Where_InList_SP oParams_Get_Loc_l4_By_Where_InList_SP = new Params_Get_Loc_l4_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_Where_InList");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l4_By_Where_InList",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l4_By_Where_InList));}
#region Body Section.
if ((i_Params_Get_Loc_l4_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Loc_l4_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Loc_l4_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l4_By_Where_InList.START_ROW == null) { i_Params_Get_Loc_l4_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Loc_l4_By_Where_InList.END_ROW == null) || (i_Params_Get_Loc_l4_By_Where_InList.END_ROW == 0)) { i_Params_Get_Loc_l4_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Loc_l4_By_Where_InList_SP.OWNER_ID = i_Params_Get_Loc_l4_By_Where_InList.OWNER_ID;
oParams_Get_Loc_l4_By_Where_InList_SP.CODE = i_Params_Get_Loc_l4_By_Where_InList.CODE;
oParams_Get_Loc_l4_By_Where_InList_SP.DESCRIPTION = i_Params_Get_Loc_l4_By_Where_InList.DESCRIPTION;
if ( i_Params_Get_Loc_l4_By_Where_InList.LOC_L3_ID_LIST == null)
{
i_Params_Get_Loc_l4_By_Where_InList.LOC_L3_ID_LIST = new List<long?>();
}
oParams_Get_Loc_l4_By_Where_InList_SP.LOC_L3_ID_LIST = oTools.Convert_List_To_Comma_Separated<long?>(i_Params_Get_Loc_l4_By_Where_InList.LOC_L3_ID_LIST);
oParams_Get_Loc_l4_By_Where_InList_SP.START_ROW = i_Params_Get_Loc_l4_By_Where_InList.START_ROW;
oParams_Get_Loc_l4_By_Where_InList_SP.END_ROW = i_Params_Get_Loc_l4_By_Where_InList.END_ROW;
oParams_Get_Loc_l4_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Loc_l4_By_Where_InList.TOTAL_COUNT;
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_Where_InList(i_Params_Get_Loc_l4_By_Where_InList.CODE,i_Params_Get_Loc_l4_By_Where_InList.DESCRIPTION,i_Params_Get_Loc_l4_By_Where_InList.LOC_L3_ID_LIST,i_Params_Get_Loc_l4_By_Where_InList.OWNER_ID,i_Params_Get_Loc_l4_By_Where_InList.START_ROW,i_Params_Get_Loc_l4_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oList.Add(oLoc_l4);
}
}
i_Params_Get_Loc_l4_By_Where_InList.TOTAL_COUNT = oParams_Get_Loc_l4_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Loc_l4_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_Where_InList");}
return oList;
}
public List<Package> Get_Package_By_Criteria_InList(Params_Get_Package_By_Criteria_InList i_Params_Get_Package_By_Criteria_InList)
{
List<Package> oList = new List<Package>();
Package oPackage = new Package();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Package_By_Criteria_InList_SP oParams_Get_Package_By_Criteria_InList_SP = new Params_Get_Package_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Package_By_Criteria_InList");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Package_By_Criteria_InList",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Package_By_Criteria_InList));}
#region Body Section.
if ((i_Params_Get_Package_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Package_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Package_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Package_By_Criteria_InList.START_ROW == null) { i_Params_Get_Package_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Package_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Package_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Package_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Package_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Package_By_Criteria_InList.OWNER_ID;
oParams_Get_Package_By_Criteria_InList_SP.PACKAGE_NAME = i_Params_Get_Package_By_Criteria_InList.PACKAGE_NAME;
oParams_Get_Package_By_Criteria_InList_SP.PACKAGE_TYPE = i_Params_Get_Package_By_Criteria_InList.PACKAGE_TYPE;
oParams_Get_Package_By_Criteria_InList_SP.PACKAGE_TIMELINE = i_Params_Get_Package_By_Criteria_InList.PACKAGE_TIMELINE;
if ( i_Params_Get_Package_By_Criteria_InList.CURRENCY_ID_LIST == null)
{
i_Params_Get_Package_By_Criteria_InList.CURRENCY_ID_LIST = new List<Int32?>();
}
oParams_Get_Package_By_Criteria_InList_SP.CURRENCY_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Package_By_Criteria_InList.CURRENCY_ID_LIST);
oParams_Get_Package_By_Criteria_InList_SP.START_ROW = i_Params_Get_Package_By_Criteria_InList.START_ROW;
oParams_Get_Package_By_Criteria_InList_SP.END_ROW = i_Params_Get_Package_By_Criteria_InList.END_ROW;
oParams_Get_Package_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Package_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Package> oList_DBEntries = _AppContext.Get_Package_By_Criteria_InList(i_Params_Get_Package_By_Criteria_InList.PACKAGE_NAME,i_Params_Get_Package_By_Criteria_InList.PACKAGE_TYPE,i_Params_Get_Package_By_Criteria_InList.PACKAGE_TIMELINE,i_Params_Get_Package_By_Criteria_InList.CURRENCY_ID_LIST,i_Params_Get_Package_By_Criteria_InList.OWNER_ID,i_Params_Get_Package_By_Criteria_InList.START_ROW,i_Params_Get_Package_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oPackage = new Package();
oTools.CopyPropValues(oDBEntry, oPackage);
oList.Add(oPackage);
}
}
i_Params_Get_Package_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Package_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Package_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Package_By_Criteria_InList");}
return oList;
}
public List<Package> Get_Package_By_Where_InList(Params_Get_Package_By_Where_InList i_Params_Get_Package_By_Where_InList)
{
List<Package> oList = new List<Package>();
Package oPackage = new Package();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Package_By_Where_InList_SP oParams_Get_Package_By_Where_InList_SP = new Params_Get_Package_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Package_By_Where_InList");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Package_By_Where_InList",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Package_By_Where_InList));}
#region Body Section.
if ((i_Params_Get_Package_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Package_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Package_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Package_By_Where_InList.START_ROW == null) { i_Params_Get_Package_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Package_By_Where_InList.END_ROW == null) || (i_Params_Get_Package_By_Where_InList.END_ROW == 0)) { i_Params_Get_Package_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Package_By_Where_InList_SP.OWNER_ID = i_Params_Get_Package_By_Where_InList.OWNER_ID;
oParams_Get_Package_By_Where_InList_SP.PACKAGE_NAME = i_Params_Get_Package_By_Where_InList.PACKAGE_NAME;
oParams_Get_Package_By_Where_InList_SP.PACKAGE_TYPE = i_Params_Get_Package_By_Where_InList.PACKAGE_TYPE;
oParams_Get_Package_By_Where_InList_SP.PACKAGE_TIMELINE = i_Params_Get_Package_By_Where_InList.PACKAGE_TIMELINE;
if ( i_Params_Get_Package_By_Where_InList.CURRENCY_ID_LIST == null)
{
i_Params_Get_Package_By_Where_InList.CURRENCY_ID_LIST = new List<Int32?>();
}
oParams_Get_Package_By_Where_InList_SP.CURRENCY_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Package_By_Where_InList.CURRENCY_ID_LIST);
oParams_Get_Package_By_Where_InList_SP.START_ROW = i_Params_Get_Package_By_Where_InList.START_ROW;
oParams_Get_Package_By_Where_InList_SP.END_ROW = i_Params_Get_Package_By_Where_InList.END_ROW;
oParams_Get_Package_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Package_By_Where_InList.TOTAL_COUNT;
List<DALC.Package> oList_DBEntries = _AppContext.Get_Package_By_Where_InList(i_Params_Get_Package_By_Where_InList.PACKAGE_NAME,i_Params_Get_Package_By_Where_InList.PACKAGE_TYPE,i_Params_Get_Package_By_Where_InList.PACKAGE_TIMELINE,i_Params_Get_Package_By_Where_InList.CURRENCY_ID_LIST,i_Params_Get_Package_By_Where_InList.OWNER_ID,i_Params_Get_Package_By_Where_InList.START_ROW,i_Params_Get_Package_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oPackage = new Package();
oTools.CopyPropValues(oDBEntry, oPackage);
oList.Add(oPackage);
}
}
i_Params_Get_Package_By_Where_InList.TOTAL_COUNT = oParams_Get_Package_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Package_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Package_By_Where_InList");}
return oList;
}
public List<Package> Get_Package_By_Criteria_InList_V2(Params_Get_Package_By_Criteria_InList_V2 i_Params_Get_Package_By_Criteria_InList_V2)
{
List<Package> oList = new List<Package>();
Package oPackage = new Package();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Package_By_Criteria_InList_SP_V2 oParams_Get_Package_By_Criteria_InList_SP_V2 = new Params_Get_Package_By_Criteria_InList_SP_V2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Package_By_Criteria_InList_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Package_By_Criteria_InList_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Package_By_Criteria_InList_V2));}
#region Body Section.
if ((i_Params_Get_Package_By_Criteria_InList_V2.OWNER_ID == null) || (i_Params_Get_Package_By_Criteria_InList_V2.OWNER_ID == 0)) { i_Params_Get_Package_By_Criteria_InList_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Package_By_Criteria_InList_V2.START_ROW == null) { i_Params_Get_Package_By_Criteria_InList_V2.START_ROW = 0; }
if ((i_Params_Get_Package_By_Criteria_InList_V2.END_ROW == null) || (i_Params_Get_Package_By_Criteria_InList_V2.END_ROW == 0)) { i_Params_Get_Package_By_Criteria_InList_V2.END_ROW = 1000000; }
oParams_Get_Package_By_Criteria_InList_SP_V2.OWNER_ID = i_Params_Get_Package_By_Criteria_InList_V2.OWNER_ID;
oParams_Get_Package_By_Criteria_InList_SP_V2.PACKAGE_NAME = i_Params_Get_Package_By_Criteria_InList_V2.PACKAGE_NAME;
oParams_Get_Package_By_Criteria_InList_SP_V2.PACKAGE_TYPE = i_Params_Get_Package_By_Criteria_InList_V2.PACKAGE_TYPE;
oParams_Get_Package_By_Criteria_InList_SP_V2.PACKAGE_ENDING_DATE = i_Params_Get_Package_By_Criteria_InList_V2.PACKAGE_ENDING_DATE;
oParams_Get_Package_By_Criteria_InList_SP_V2.PACKAGE_TIMELINE = i_Params_Get_Package_By_Criteria_InList_V2.PACKAGE_TIMELINE;
oParams_Get_Package_By_Criteria_InList_SP_V2.PACKAGE_STARTING_DATE = i_Params_Get_Package_By_Criteria_InList_V2.PACKAGE_STARTING_DATE;
if ( i_Params_Get_Package_By_Criteria_InList_V2.CURRENCY_ID_LIST == null)
{
i_Params_Get_Package_By_Criteria_InList_V2.CURRENCY_ID_LIST = new List<Int32?>();
}
oParams_Get_Package_By_Criteria_InList_SP_V2.CURRENCY_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Package_By_Criteria_InList_V2.CURRENCY_ID_LIST);
oParams_Get_Package_By_Criteria_InList_SP_V2.START_ROW = i_Params_Get_Package_By_Criteria_InList_V2.START_ROW;
oParams_Get_Package_By_Criteria_InList_SP_V2.END_ROW = i_Params_Get_Package_By_Criteria_InList_V2.END_ROW;
oParams_Get_Package_By_Criteria_InList_SP_V2.TOTAL_COUNT = i_Params_Get_Package_By_Criteria_InList_V2.TOTAL_COUNT;
List<DALC.Package> oList_DBEntries = _AppContext.Get_Package_By_Criteria_InList_V2(i_Params_Get_Package_By_Criteria_InList_V2.PACKAGE_NAME,i_Params_Get_Package_By_Criteria_InList_V2.PACKAGE_TYPE,i_Params_Get_Package_By_Criteria_InList_V2.PACKAGE_ENDING_DATE,i_Params_Get_Package_By_Criteria_InList_V2.PACKAGE_TIMELINE,i_Params_Get_Package_By_Criteria_InList_V2.PACKAGE_STARTING_DATE,i_Params_Get_Package_By_Criteria_InList_V2.CURRENCY_ID_LIST,i_Params_Get_Package_By_Criteria_InList_V2.OWNER_ID,i_Params_Get_Package_By_Criteria_InList_V2.START_ROW,i_Params_Get_Package_By_Criteria_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oPackage = new Package();
oTools.CopyPropValues(oDBEntry, oPackage);
oList.Add(oPackage);
}
}
i_Params_Get_Package_By_Criteria_InList_V2.TOTAL_COUNT = oParams_Get_Package_By_Criteria_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Package_By_Criteria_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Package_By_Criteria_InList_V2");}
return oList;
}
public List<Package> Get_Package_By_Where_InList_V2(Params_Get_Package_By_Where_InList_V2 i_Params_Get_Package_By_Where_InList_V2)
{
List<Package> oList = new List<Package>();
Package oPackage = new Package();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Package_By_Where_InList_SP_V2 oParams_Get_Package_By_Where_InList_SP_V2 = new Params_Get_Package_By_Where_InList_SP_V2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Package_By_Where_InList_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Package_By_Where_InList_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Package_By_Where_InList_V2));}
#region Body Section.
if ((i_Params_Get_Package_By_Where_InList_V2.OWNER_ID == null) || (i_Params_Get_Package_By_Where_InList_V2.OWNER_ID == 0)) { i_Params_Get_Package_By_Where_InList_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Package_By_Where_InList_V2.START_ROW == null) { i_Params_Get_Package_By_Where_InList_V2.START_ROW = 0; }
if ((i_Params_Get_Package_By_Where_InList_V2.END_ROW == null) || (i_Params_Get_Package_By_Where_InList_V2.END_ROW == 0)) { i_Params_Get_Package_By_Where_InList_V2.END_ROW = 1000000; }
oParams_Get_Package_By_Where_InList_SP_V2.OWNER_ID = i_Params_Get_Package_By_Where_InList_V2.OWNER_ID;
oParams_Get_Package_By_Where_InList_SP_V2.PACKAGE_NAME = i_Params_Get_Package_By_Where_InList_V2.PACKAGE_NAME;
oParams_Get_Package_By_Where_InList_SP_V2.PACKAGE_TYPE = i_Params_Get_Package_By_Where_InList_V2.PACKAGE_TYPE;
oParams_Get_Package_By_Where_InList_SP_V2.PACKAGE_ENDING_DATE = i_Params_Get_Package_By_Where_InList_V2.PACKAGE_ENDING_DATE;
oParams_Get_Package_By_Where_InList_SP_V2.PACKAGE_TIMELINE = i_Params_Get_Package_By_Where_InList_V2.PACKAGE_TIMELINE;
oParams_Get_Package_By_Where_InList_SP_V2.PACKAGE_STARTING_DATE = i_Params_Get_Package_By_Where_InList_V2.PACKAGE_STARTING_DATE;
if ( i_Params_Get_Package_By_Where_InList_V2.CURRENCY_ID_LIST == null)
{
i_Params_Get_Package_By_Where_InList_V2.CURRENCY_ID_LIST = new List<Int32?>();
}
oParams_Get_Package_By_Where_InList_SP_V2.CURRENCY_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Package_By_Where_InList_V2.CURRENCY_ID_LIST);
oParams_Get_Package_By_Where_InList_SP_V2.START_ROW = i_Params_Get_Package_By_Where_InList_V2.START_ROW;
oParams_Get_Package_By_Where_InList_SP_V2.END_ROW = i_Params_Get_Package_By_Where_InList_V2.END_ROW;
oParams_Get_Package_By_Where_InList_SP_V2.TOTAL_COUNT = i_Params_Get_Package_By_Where_InList_V2.TOTAL_COUNT;
List<DALC.Package> oList_DBEntries = _AppContext.Get_Package_By_Where_InList_V2(i_Params_Get_Package_By_Where_InList_V2.PACKAGE_NAME,i_Params_Get_Package_By_Where_InList_V2.PACKAGE_TYPE,i_Params_Get_Package_By_Where_InList_V2.PACKAGE_ENDING_DATE,i_Params_Get_Package_By_Where_InList_V2.PACKAGE_TIMELINE,i_Params_Get_Package_By_Where_InList_V2.PACKAGE_STARTING_DATE,i_Params_Get_Package_By_Where_InList_V2.CURRENCY_ID_LIST,i_Params_Get_Package_By_Where_InList_V2.OWNER_ID,i_Params_Get_Package_By_Where_InList_V2.START_ROW,i_Params_Get_Package_By_Where_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oPackage = new Package();
oTools.CopyPropValues(oDBEntry, oPackage);
oList.Add(oPackage);
}
}
i_Params_Get_Package_By_Where_InList_V2.TOTAL_COUNT = oParams_Get_Package_By_Where_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Package_By_Where_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Package_By_Where_InList_V2");}
return oList;
}
public List<Registration> Get_Registration_By_Criteria_InList(Params_Get_Registration_By_Criteria_InList i_Params_Get_Registration_By_Criteria_InList)
{
List<Registration> oList = new List<Registration>();
Registration oRegistration = new Registration();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Registration_By_Criteria_InList_SP oParams_Get_Registration_By_Criteria_InList_SP = new Params_Get_Registration_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Registration_By_Criteria_InList");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Registration_By_Criteria_InList",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Registration_By_Criteria_InList));}
#region Body Section.
if ((i_Params_Get_Registration_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Registration_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Registration_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Registration_By_Criteria_InList.START_ROW == null) { i_Params_Get_Registration_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Registration_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Registration_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Registration_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Registration_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Registration_By_Criteria_InList.OWNER_ID;
oParams_Get_Registration_By_Criteria_InList_SP.REGISTRATION_DESCRIPTION = i_Params_Get_Registration_By_Criteria_InList.REGISTRATION_DESCRIPTION;
if ( i_Params_Get_Registration_By_Criteria_InList.CLIENT_ID_LIST == null)
{
i_Params_Get_Registration_By_Criteria_InList.CLIENT_ID_LIST = new List<Int32?>();
}
oParams_Get_Registration_By_Criteria_InList_SP.CLIENT_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Registration_By_Criteria_InList.CLIENT_ID_LIST);
if ( i_Params_Get_Registration_By_Criteria_InList.PACKAGE_ID_LIST == null)
{
i_Params_Get_Registration_By_Criteria_InList.PACKAGE_ID_LIST = new List<Int32?>();
}
oParams_Get_Registration_By_Criteria_InList_SP.PACKAGE_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Registration_By_Criteria_InList.PACKAGE_ID_LIST);
if ( i_Params_Get_Registration_By_Criteria_InList.CURRENCY_ID_LIST == null)
{
i_Params_Get_Registration_By_Criteria_InList.CURRENCY_ID_LIST = new List<Int32?>();
}
oParams_Get_Registration_By_Criteria_InList_SP.CURRENCY_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Registration_By_Criteria_InList.CURRENCY_ID_LIST);
oParams_Get_Registration_By_Criteria_InList_SP.START_ROW = i_Params_Get_Registration_By_Criteria_InList.START_ROW;
oParams_Get_Registration_By_Criteria_InList_SP.END_ROW = i_Params_Get_Registration_By_Criteria_InList.END_ROW;
oParams_Get_Registration_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Registration_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Registration> oList_DBEntries = _AppContext.Get_Registration_By_Criteria_InList(i_Params_Get_Registration_By_Criteria_InList.REGISTRATION_DESCRIPTION,i_Params_Get_Registration_By_Criteria_InList.CLIENT_ID_LIST,i_Params_Get_Registration_By_Criteria_InList.PACKAGE_ID_LIST,i_Params_Get_Registration_By_Criteria_InList.CURRENCY_ID_LIST,i_Params_Get_Registration_By_Criteria_InList.OWNER_ID,i_Params_Get_Registration_By_Criteria_InList.START_ROW,i_Params_Get_Registration_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oRegistration = new Registration();
oTools.CopyPropValues(oDBEntry, oRegistration);
oList.Add(oRegistration);
}
}
i_Params_Get_Registration_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Registration_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Registration_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Registration_By_Criteria_InList");}
return oList;
}
public List<Registration> Get_Registration_By_Where_InList(Params_Get_Registration_By_Where_InList i_Params_Get_Registration_By_Where_InList)
{
List<Registration> oList = new List<Registration>();
Registration oRegistration = new Registration();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Registration_By_Where_InList_SP oParams_Get_Registration_By_Where_InList_SP = new Params_Get_Registration_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Registration_By_Where_InList");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Registration_By_Where_InList",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Registration_By_Where_InList));}
#region Body Section.
if ((i_Params_Get_Registration_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Registration_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Registration_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Registration_By_Where_InList.START_ROW == null) { i_Params_Get_Registration_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Registration_By_Where_InList.END_ROW == null) || (i_Params_Get_Registration_By_Where_InList.END_ROW == 0)) { i_Params_Get_Registration_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Registration_By_Where_InList_SP.OWNER_ID = i_Params_Get_Registration_By_Where_InList.OWNER_ID;
oParams_Get_Registration_By_Where_InList_SP.REGISTRATION_DESCRIPTION = i_Params_Get_Registration_By_Where_InList.REGISTRATION_DESCRIPTION;
if ( i_Params_Get_Registration_By_Where_InList.CLIENT_ID_LIST == null)
{
i_Params_Get_Registration_By_Where_InList.CLIENT_ID_LIST = new List<Int32?>();
}
oParams_Get_Registration_By_Where_InList_SP.CLIENT_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Registration_By_Where_InList.CLIENT_ID_LIST);
if ( i_Params_Get_Registration_By_Where_InList.PACKAGE_ID_LIST == null)
{
i_Params_Get_Registration_By_Where_InList.PACKAGE_ID_LIST = new List<Int32?>();
}
oParams_Get_Registration_By_Where_InList_SP.PACKAGE_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Registration_By_Where_InList.PACKAGE_ID_LIST);
if ( i_Params_Get_Registration_By_Where_InList.CURRENCY_ID_LIST == null)
{
i_Params_Get_Registration_By_Where_InList.CURRENCY_ID_LIST = new List<Int32?>();
}
oParams_Get_Registration_By_Where_InList_SP.CURRENCY_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Registration_By_Where_InList.CURRENCY_ID_LIST);
oParams_Get_Registration_By_Where_InList_SP.START_ROW = i_Params_Get_Registration_By_Where_InList.START_ROW;
oParams_Get_Registration_By_Where_InList_SP.END_ROW = i_Params_Get_Registration_By_Where_InList.END_ROW;
oParams_Get_Registration_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Registration_By_Where_InList.TOTAL_COUNT;
List<DALC.Registration> oList_DBEntries = _AppContext.Get_Registration_By_Where_InList(i_Params_Get_Registration_By_Where_InList.REGISTRATION_DESCRIPTION,i_Params_Get_Registration_By_Where_InList.CLIENT_ID_LIST,i_Params_Get_Registration_By_Where_InList.PACKAGE_ID_LIST,i_Params_Get_Registration_By_Where_InList.CURRENCY_ID_LIST,i_Params_Get_Registration_By_Where_InList.OWNER_ID,i_Params_Get_Registration_By_Where_InList.START_ROW,i_Params_Get_Registration_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oRegistration = new Registration();
oTools.CopyPropValues(oDBEntry, oRegistration);
oList.Add(oRegistration);
}
}
i_Params_Get_Registration_By_Where_InList.TOTAL_COUNT = oParams_Get_Registration_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Registration_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Registration_By_Where_InList");}
return oList;
}
public List<Registration> Get_Registration_By_Criteria_InList_V2(Params_Get_Registration_By_Criteria_InList_V2 i_Params_Get_Registration_By_Criteria_InList_V2)
{
List<Registration> oList = new List<Registration>();
Registration oRegistration = new Registration();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Registration_By_Criteria_InList_SP_V2 oParams_Get_Registration_By_Criteria_InList_SP_V2 = new Params_Get_Registration_By_Criteria_InList_SP_V2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Registration_By_Criteria_InList_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Registration_By_Criteria_InList_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Registration_By_Criteria_InList_V2));}
#region Body Section.
if ((i_Params_Get_Registration_By_Criteria_InList_V2.OWNER_ID == null) || (i_Params_Get_Registration_By_Criteria_InList_V2.OWNER_ID == 0)) { i_Params_Get_Registration_By_Criteria_InList_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Registration_By_Criteria_InList_V2.START_ROW == null) { i_Params_Get_Registration_By_Criteria_InList_V2.START_ROW = 0; }
if ((i_Params_Get_Registration_By_Criteria_InList_V2.END_ROW == null) || (i_Params_Get_Registration_By_Criteria_InList_V2.END_ROW == 0)) { i_Params_Get_Registration_By_Criteria_InList_V2.END_ROW = 1000000; }
oParams_Get_Registration_By_Criteria_InList_SP_V2.OWNER_ID = i_Params_Get_Registration_By_Criteria_InList_V2.OWNER_ID;
oParams_Get_Registration_By_Criteria_InList_SP_V2.REGISTRATION_DATE = i_Params_Get_Registration_By_Criteria_InList_V2.REGISTRATION_DATE;
oParams_Get_Registration_By_Criteria_InList_SP_V2.REGISTRATION_DESCRIPTION = i_Params_Get_Registration_By_Criteria_InList_V2.REGISTRATION_DESCRIPTION;
if ( i_Params_Get_Registration_By_Criteria_InList_V2.CLIENT_ID_LIST == null)
{
i_Params_Get_Registration_By_Criteria_InList_V2.CLIENT_ID_LIST = new List<Int32?>();
}
oParams_Get_Registration_By_Criteria_InList_SP_V2.CLIENT_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Registration_By_Criteria_InList_V2.CLIENT_ID_LIST);
if ( i_Params_Get_Registration_By_Criteria_InList_V2.PACKAGE_ID_LIST == null)
{
i_Params_Get_Registration_By_Criteria_InList_V2.PACKAGE_ID_LIST = new List<Int32?>();
}
oParams_Get_Registration_By_Criteria_InList_SP_V2.PACKAGE_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Registration_By_Criteria_InList_V2.PACKAGE_ID_LIST);
if ( i_Params_Get_Registration_By_Criteria_InList_V2.CURRENCY_ID_LIST == null)
{
i_Params_Get_Registration_By_Criteria_InList_V2.CURRENCY_ID_LIST = new List<Int32?>();
}
oParams_Get_Registration_By_Criteria_InList_SP_V2.CURRENCY_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Registration_By_Criteria_InList_V2.CURRENCY_ID_LIST);
oParams_Get_Registration_By_Criteria_InList_SP_V2.START_ROW = i_Params_Get_Registration_By_Criteria_InList_V2.START_ROW;
oParams_Get_Registration_By_Criteria_InList_SP_V2.END_ROW = i_Params_Get_Registration_By_Criteria_InList_V2.END_ROW;
oParams_Get_Registration_By_Criteria_InList_SP_V2.TOTAL_COUNT = i_Params_Get_Registration_By_Criteria_InList_V2.TOTAL_COUNT;
List<DALC.Registration> oList_DBEntries = _AppContext.Get_Registration_By_Criteria_InList_V2(i_Params_Get_Registration_By_Criteria_InList_V2.REGISTRATION_DATE,i_Params_Get_Registration_By_Criteria_InList_V2.REGISTRATION_DESCRIPTION,i_Params_Get_Registration_By_Criteria_InList_V2.CLIENT_ID_LIST,i_Params_Get_Registration_By_Criteria_InList_V2.PACKAGE_ID_LIST,i_Params_Get_Registration_By_Criteria_InList_V2.CURRENCY_ID_LIST,i_Params_Get_Registration_By_Criteria_InList_V2.OWNER_ID,i_Params_Get_Registration_By_Criteria_InList_V2.START_ROW,i_Params_Get_Registration_By_Criteria_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oRegistration = new Registration();
oTools.CopyPropValues(oDBEntry, oRegistration);
oList.Add(oRegistration);
}
}
i_Params_Get_Registration_By_Criteria_InList_V2.TOTAL_COUNT = oParams_Get_Registration_By_Criteria_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Registration_By_Criteria_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Registration_By_Criteria_InList_V2");}
return oList;
}
public List<Registration> Get_Registration_By_Where_InList_V2(Params_Get_Registration_By_Where_InList_V2 i_Params_Get_Registration_By_Where_InList_V2)
{
List<Registration> oList = new List<Registration>();
Registration oRegistration = new Registration();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Registration_By_Where_InList_SP_V2 oParams_Get_Registration_By_Where_InList_SP_V2 = new Params_Get_Registration_By_Where_InList_SP_V2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Registration_By_Where_InList_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Registration_By_Where_InList_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Registration_By_Where_InList_V2));}
#region Body Section.
if ((i_Params_Get_Registration_By_Where_InList_V2.OWNER_ID == null) || (i_Params_Get_Registration_By_Where_InList_V2.OWNER_ID == 0)) { i_Params_Get_Registration_By_Where_InList_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Registration_By_Where_InList_V2.START_ROW == null) { i_Params_Get_Registration_By_Where_InList_V2.START_ROW = 0; }
if ((i_Params_Get_Registration_By_Where_InList_V2.END_ROW == null) || (i_Params_Get_Registration_By_Where_InList_V2.END_ROW == 0)) { i_Params_Get_Registration_By_Where_InList_V2.END_ROW = 1000000; }
oParams_Get_Registration_By_Where_InList_SP_V2.OWNER_ID = i_Params_Get_Registration_By_Where_InList_V2.OWNER_ID;
oParams_Get_Registration_By_Where_InList_SP_V2.REGISTRATION_DATE = i_Params_Get_Registration_By_Where_InList_V2.REGISTRATION_DATE;
oParams_Get_Registration_By_Where_InList_SP_V2.REGISTRATION_DESCRIPTION = i_Params_Get_Registration_By_Where_InList_V2.REGISTRATION_DESCRIPTION;
if ( i_Params_Get_Registration_By_Where_InList_V2.CLIENT_ID_LIST == null)
{
i_Params_Get_Registration_By_Where_InList_V2.CLIENT_ID_LIST = new List<Int32?>();
}
oParams_Get_Registration_By_Where_InList_SP_V2.CLIENT_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Registration_By_Where_InList_V2.CLIENT_ID_LIST);
if ( i_Params_Get_Registration_By_Where_InList_V2.PACKAGE_ID_LIST == null)
{
i_Params_Get_Registration_By_Where_InList_V2.PACKAGE_ID_LIST = new List<Int32?>();
}
oParams_Get_Registration_By_Where_InList_SP_V2.PACKAGE_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Registration_By_Where_InList_V2.PACKAGE_ID_LIST);
if ( i_Params_Get_Registration_By_Where_InList_V2.CURRENCY_ID_LIST == null)
{
i_Params_Get_Registration_By_Where_InList_V2.CURRENCY_ID_LIST = new List<Int32?>();
}
oParams_Get_Registration_By_Where_InList_SP_V2.CURRENCY_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Registration_By_Where_InList_V2.CURRENCY_ID_LIST);
oParams_Get_Registration_By_Where_InList_SP_V2.START_ROW = i_Params_Get_Registration_By_Where_InList_V2.START_ROW;
oParams_Get_Registration_By_Where_InList_SP_V2.END_ROW = i_Params_Get_Registration_By_Where_InList_V2.END_ROW;
oParams_Get_Registration_By_Where_InList_SP_V2.TOTAL_COUNT = i_Params_Get_Registration_By_Where_InList_V2.TOTAL_COUNT;
List<DALC.Registration> oList_DBEntries = _AppContext.Get_Registration_By_Where_InList_V2(i_Params_Get_Registration_By_Where_InList_V2.REGISTRATION_DATE,i_Params_Get_Registration_By_Where_InList_V2.REGISTRATION_DESCRIPTION,i_Params_Get_Registration_By_Where_InList_V2.CLIENT_ID_LIST,i_Params_Get_Registration_By_Where_InList_V2.PACKAGE_ID_LIST,i_Params_Get_Registration_By_Where_InList_V2.CURRENCY_ID_LIST,i_Params_Get_Registration_By_Where_InList_V2.OWNER_ID,i_Params_Get_Registration_By_Where_InList_V2.START_ROW,i_Params_Get_Registration_By_Where_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oRegistration = new Registration();
oTools.CopyPropValues(oDBEntry, oRegistration);
oList.Add(oRegistration);
}
}
i_Params_Get_Registration_By_Where_InList_V2.TOTAL_COUNT = oParams_Get_Registration_By_Where_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Registration_By_Where_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Registration_By_Where_InList_V2");}
return oList;
}
public List<Session> Get_Session_By_Criteria_InList(Params_Get_Session_By_Criteria_InList i_Params_Get_Session_By_Criteria_InList)
{
List<Session> oList = new List<Session>();
Session oSession = new Session();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Session_By_Criteria_InList_SP oParams_Get_Session_By_Criteria_InList_SP = new Params_Get_Session_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Session_By_Criteria_InList");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Session_By_Criteria_InList",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Session_By_Criteria_InList));}
#region Body Section.
if ((i_Params_Get_Session_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Session_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Session_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Session_By_Criteria_InList.START_ROW == null) { i_Params_Get_Session_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Session_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Session_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Session_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Session_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Session_By_Criteria_InList.OWNER_ID;
oParams_Get_Session_By_Criteria_InList_SP.DESCRIPTION = i_Params_Get_Session_By_Criteria_InList.DESCRIPTION;
if ( i_Params_Get_Session_By_Criteria_InList.PACKAGE_ID_LIST == null)
{
i_Params_Get_Session_By_Criteria_InList.PACKAGE_ID_LIST = new List<Int32?>();
}
oParams_Get_Session_By_Criteria_InList_SP.PACKAGE_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Session_By_Criteria_InList.PACKAGE_ID_LIST);
if ( i_Params_Get_Session_By_Criteria_InList.CLIENT_FEES_ID_LIST == null)
{
i_Params_Get_Session_By_Criteria_InList.CLIENT_FEES_ID_LIST = new List<Int32?>();
}
oParams_Get_Session_By_Criteria_InList_SP.CLIENT_FEES_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Session_By_Criteria_InList.CLIENT_FEES_ID_LIST);
oParams_Get_Session_By_Criteria_InList_SP.START_ROW = i_Params_Get_Session_By_Criteria_InList.START_ROW;
oParams_Get_Session_By_Criteria_InList_SP.END_ROW = i_Params_Get_Session_By_Criteria_InList.END_ROW;
oParams_Get_Session_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Session_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Session> oList_DBEntries = _AppContext.Get_Session_By_Criteria_InList(i_Params_Get_Session_By_Criteria_InList.DESCRIPTION,i_Params_Get_Session_By_Criteria_InList.PACKAGE_ID_LIST,i_Params_Get_Session_By_Criteria_InList.CLIENT_FEES_ID_LIST,i_Params_Get_Session_By_Criteria_InList.OWNER_ID,i_Params_Get_Session_By_Criteria_InList.START_ROW,i_Params_Get_Session_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSession = new Session();
oTools.CopyPropValues(oDBEntry, oSession);
oList.Add(oSession);
}
}
i_Params_Get_Session_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Session_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Session_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Session_By_Criteria_InList");}
return oList;
}
public List<Session> Get_Session_By_Where_InList(Params_Get_Session_By_Where_InList i_Params_Get_Session_By_Where_InList)
{
List<Session> oList = new List<Session>();
Session oSession = new Session();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Session_By_Where_InList_SP oParams_Get_Session_By_Where_InList_SP = new Params_Get_Session_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Session_By_Where_InList");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Session_By_Where_InList",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Session_By_Where_InList));}
#region Body Section.
if ((i_Params_Get_Session_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Session_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Session_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Session_By_Where_InList.START_ROW == null) { i_Params_Get_Session_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Session_By_Where_InList.END_ROW == null) || (i_Params_Get_Session_By_Where_InList.END_ROW == 0)) { i_Params_Get_Session_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Session_By_Where_InList_SP.OWNER_ID = i_Params_Get_Session_By_Where_InList.OWNER_ID;
oParams_Get_Session_By_Where_InList_SP.DESCRIPTION = i_Params_Get_Session_By_Where_InList.DESCRIPTION;
if ( i_Params_Get_Session_By_Where_InList.PACKAGE_ID_LIST == null)
{
i_Params_Get_Session_By_Where_InList.PACKAGE_ID_LIST = new List<Int32?>();
}
oParams_Get_Session_By_Where_InList_SP.PACKAGE_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Session_By_Where_InList.PACKAGE_ID_LIST);
if ( i_Params_Get_Session_By_Where_InList.CLIENT_FEES_ID_LIST == null)
{
i_Params_Get_Session_By_Where_InList.CLIENT_FEES_ID_LIST = new List<Int32?>();
}
oParams_Get_Session_By_Where_InList_SP.CLIENT_FEES_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Session_By_Where_InList.CLIENT_FEES_ID_LIST);
oParams_Get_Session_By_Where_InList_SP.START_ROW = i_Params_Get_Session_By_Where_InList.START_ROW;
oParams_Get_Session_By_Where_InList_SP.END_ROW = i_Params_Get_Session_By_Where_InList.END_ROW;
oParams_Get_Session_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Session_By_Where_InList.TOTAL_COUNT;
List<DALC.Session> oList_DBEntries = _AppContext.Get_Session_By_Where_InList(i_Params_Get_Session_By_Where_InList.DESCRIPTION,i_Params_Get_Session_By_Where_InList.PACKAGE_ID_LIST,i_Params_Get_Session_By_Where_InList.CLIENT_FEES_ID_LIST,i_Params_Get_Session_By_Where_InList.OWNER_ID,i_Params_Get_Session_By_Where_InList.START_ROW,i_Params_Get_Session_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSession = new Session();
oTools.CopyPropValues(oDBEntry, oSession);
oList.Add(oSession);
}
}
i_Params_Get_Session_By_Where_InList.TOTAL_COUNT = oParams_Get_Session_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Session_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Session_By_Where_InList");}
return oList;
}
public List<Session> Get_Session_By_Criteria_InList_V2(Params_Get_Session_By_Criteria_InList_V2 i_Params_Get_Session_By_Criteria_InList_V2)
{
List<Session> oList = new List<Session>();
Session oSession = new Session();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Session_By_Criteria_InList_SP_V2 oParams_Get_Session_By_Criteria_InList_SP_V2 = new Params_Get_Session_By_Criteria_InList_SP_V2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Session_By_Criteria_InList_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Session_By_Criteria_InList_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Session_By_Criteria_InList_V2));}
#region Body Section.
if ((i_Params_Get_Session_By_Criteria_InList_V2.OWNER_ID == null) || (i_Params_Get_Session_By_Criteria_InList_V2.OWNER_ID == 0)) { i_Params_Get_Session_By_Criteria_InList_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Session_By_Criteria_InList_V2.START_ROW == null) { i_Params_Get_Session_By_Criteria_InList_V2.START_ROW = 0; }
if ((i_Params_Get_Session_By_Criteria_InList_V2.END_ROW == null) || (i_Params_Get_Session_By_Criteria_InList_V2.END_ROW == 0)) { i_Params_Get_Session_By_Criteria_InList_V2.END_ROW = 1000000; }
oParams_Get_Session_By_Criteria_InList_SP_V2.OWNER_ID = i_Params_Get_Session_By_Criteria_InList_V2.OWNER_ID;
oParams_Get_Session_By_Criteria_InList_SP_V2.SESSION_STARTING_DATE = i_Params_Get_Session_By_Criteria_InList_V2.SESSION_STARTING_DATE;
oParams_Get_Session_By_Criteria_InList_SP_V2.SESSION_ENDING_DATE = i_Params_Get_Session_By_Criteria_InList_V2.SESSION_ENDING_DATE;
oParams_Get_Session_By_Criteria_InList_SP_V2.DESCRIPTION = i_Params_Get_Session_By_Criteria_InList_V2.DESCRIPTION;
if ( i_Params_Get_Session_By_Criteria_InList_V2.PACKAGE_ID_LIST == null)
{
i_Params_Get_Session_By_Criteria_InList_V2.PACKAGE_ID_LIST = new List<Int32?>();
}
oParams_Get_Session_By_Criteria_InList_SP_V2.PACKAGE_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Session_By_Criteria_InList_V2.PACKAGE_ID_LIST);
if ( i_Params_Get_Session_By_Criteria_InList_V2.CLIENT_FEES_ID_LIST == null)
{
i_Params_Get_Session_By_Criteria_InList_V2.CLIENT_FEES_ID_LIST = new List<Int32?>();
}
oParams_Get_Session_By_Criteria_InList_SP_V2.CLIENT_FEES_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Session_By_Criteria_InList_V2.CLIENT_FEES_ID_LIST);
oParams_Get_Session_By_Criteria_InList_SP_V2.START_ROW = i_Params_Get_Session_By_Criteria_InList_V2.START_ROW;
oParams_Get_Session_By_Criteria_InList_SP_V2.END_ROW = i_Params_Get_Session_By_Criteria_InList_V2.END_ROW;
oParams_Get_Session_By_Criteria_InList_SP_V2.TOTAL_COUNT = i_Params_Get_Session_By_Criteria_InList_V2.TOTAL_COUNT;
List<DALC.Session> oList_DBEntries = _AppContext.Get_Session_By_Criteria_InList_V2(i_Params_Get_Session_By_Criteria_InList_V2.SESSION_STARTING_DATE,i_Params_Get_Session_By_Criteria_InList_V2.SESSION_ENDING_DATE,i_Params_Get_Session_By_Criteria_InList_V2.DESCRIPTION,i_Params_Get_Session_By_Criteria_InList_V2.PACKAGE_ID_LIST,i_Params_Get_Session_By_Criteria_InList_V2.CLIENT_FEES_ID_LIST,i_Params_Get_Session_By_Criteria_InList_V2.OWNER_ID,i_Params_Get_Session_By_Criteria_InList_V2.START_ROW,i_Params_Get_Session_By_Criteria_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSession = new Session();
oTools.CopyPropValues(oDBEntry, oSession);
oList.Add(oSession);
}
}
i_Params_Get_Session_By_Criteria_InList_V2.TOTAL_COUNT = oParams_Get_Session_By_Criteria_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Session_By_Criteria_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Session_By_Criteria_InList_V2");}
return oList;
}
public List<Session> Get_Session_By_Where_InList_V2(Params_Get_Session_By_Where_InList_V2 i_Params_Get_Session_By_Where_InList_V2)
{
List<Session> oList = new List<Session>();
Session oSession = new Session();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Session_By_Where_InList_SP_V2 oParams_Get_Session_By_Where_InList_SP_V2 = new Params_Get_Session_By_Where_InList_SP_V2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Session_By_Where_InList_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Session_By_Where_InList_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Session_By_Where_InList_V2));}
#region Body Section.
if ((i_Params_Get_Session_By_Where_InList_V2.OWNER_ID == null) || (i_Params_Get_Session_By_Where_InList_V2.OWNER_ID == 0)) { i_Params_Get_Session_By_Where_InList_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Session_By_Where_InList_V2.START_ROW == null) { i_Params_Get_Session_By_Where_InList_V2.START_ROW = 0; }
if ((i_Params_Get_Session_By_Where_InList_V2.END_ROW == null) || (i_Params_Get_Session_By_Where_InList_V2.END_ROW == 0)) { i_Params_Get_Session_By_Where_InList_V2.END_ROW = 1000000; }
oParams_Get_Session_By_Where_InList_SP_V2.OWNER_ID = i_Params_Get_Session_By_Where_InList_V2.OWNER_ID;
oParams_Get_Session_By_Where_InList_SP_V2.SESSION_STARTING_DATE = i_Params_Get_Session_By_Where_InList_V2.SESSION_STARTING_DATE;
oParams_Get_Session_By_Where_InList_SP_V2.SESSION_ENDING_DATE = i_Params_Get_Session_By_Where_InList_V2.SESSION_ENDING_DATE;
oParams_Get_Session_By_Where_InList_SP_V2.DESCRIPTION = i_Params_Get_Session_By_Where_InList_V2.DESCRIPTION;
if ( i_Params_Get_Session_By_Where_InList_V2.PACKAGE_ID_LIST == null)
{
i_Params_Get_Session_By_Where_InList_V2.PACKAGE_ID_LIST = new List<Int32?>();
}
oParams_Get_Session_By_Where_InList_SP_V2.PACKAGE_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Session_By_Where_InList_V2.PACKAGE_ID_LIST);
if ( i_Params_Get_Session_By_Where_InList_V2.CLIENT_FEES_ID_LIST == null)
{
i_Params_Get_Session_By_Where_InList_V2.CLIENT_FEES_ID_LIST = new List<Int32?>();
}
oParams_Get_Session_By_Where_InList_SP_V2.CLIENT_FEES_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Session_By_Where_InList_V2.CLIENT_FEES_ID_LIST);
oParams_Get_Session_By_Where_InList_SP_V2.START_ROW = i_Params_Get_Session_By_Where_InList_V2.START_ROW;
oParams_Get_Session_By_Where_InList_SP_V2.END_ROW = i_Params_Get_Session_By_Where_InList_V2.END_ROW;
oParams_Get_Session_By_Where_InList_SP_V2.TOTAL_COUNT = i_Params_Get_Session_By_Where_InList_V2.TOTAL_COUNT;
List<DALC.Session> oList_DBEntries = _AppContext.Get_Session_By_Where_InList_V2(i_Params_Get_Session_By_Where_InList_V2.SESSION_STARTING_DATE,i_Params_Get_Session_By_Where_InList_V2.SESSION_ENDING_DATE,i_Params_Get_Session_By_Where_InList_V2.DESCRIPTION,i_Params_Get_Session_By_Where_InList_V2.PACKAGE_ID_LIST,i_Params_Get_Session_By_Where_InList_V2.CLIENT_FEES_ID_LIST,i_Params_Get_Session_By_Where_InList_V2.OWNER_ID,i_Params_Get_Session_By_Where_InList_V2.START_ROW,i_Params_Get_Session_By_Where_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSession = new Session();
oTools.CopyPropValues(oDBEntry, oSession);
oList.Add(oSession);
}
}
i_Params_Get_Session_By_Where_InList_V2.TOTAL_COUNT = oParams_Get_Session_By_Where_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Session_By_Where_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Session_By_Where_InList_V2");}
return oList;
}
public List<Staff> Get_Staff_By_Criteria_InList(Params_Get_Staff_By_Criteria_InList i_Params_Get_Staff_By_Criteria_InList)
{
List<Staff> oList = new List<Staff>();
Staff oStaff = new Staff();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Staff_By_Criteria_InList_SP oParams_Get_Staff_By_Criteria_InList_SP = new Params_Get_Staff_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_By_Criteria_InList");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_By_Criteria_InList",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_By_Criteria_InList));}
#region Body Section.
if ((i_Params_Get_Staff_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Staff_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Staff_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Staff_By_Criteria_InList.START_ROW == null) { i_Params_Get_Staff_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Staff_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Staff_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Staff_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Staff_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Staff_By_Criteria_InList.OWNER_ID;
oParams_Get_Staff_By_Criteria_InList_SP.STAFF_NAME = i_Params_Get_Staff_By_Criteria_InList.STAFF_NAME;
oParams_Get_Staff_By_Criteria_InList_SP.STAFF_PH_NB = i_Params_Get_Staff_By_Criteria_InList.STAFF_PH_NB;
oParams_Get_Staff_By_Criteria_InList_SP.STAFF_MAIL = i_Params_Get_Staff_By_Criteria_InList.STAFF_MAIL;
oParams_Get_Staff_By_Criteria_InList_SP.STAFF_GENDER = i_Params_Get_Staff_By_Criteria_InList.STAFF_GENDER;
if ( i_Params_Get_Staff_By_Criteria_InList.BLOODTYPE_ID_LIST == null)
{
i_Params_Get_Staff_By_Criteria_InList.BLOODTYPE_ID_LIST = new List<Int32?>();
}
oParams_Get_Staff_By_Criteria_InList_SP.BLOODTYPE_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Staff_By_Criteria_InList.BLOODTYPE_ID_LIST);
oParams_Get_Staff_By_Criteria_InList_SP.START_ROW = i_Params_Get_Staff_By_Criteria_InList.START_ROW;
oParams_Get_Staff_By_Criteria_InList_SP.END_ROW = i_Params_Get_Staff_By_Criteria_InList.END_ROW;
oParams_Get_Staff_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Staff_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Staff> oList_DBEntries = _AppContext.Get_Staff_By_Criteria_InList(i_Params_Get_Staff_By_Criteria_InList.STAFF_NAME,i_Params_Get_Staff_By_Criteria_InList.STAFF_PH_NB,i_Params_Get_Staff_By_Criteria_InList.STAFF_MAIL,i_Params_Get_Staff_By_Criteria_InList.STAFF_GENDER,i_Params_Get_Staff_By_Criteria_InList.BLOODTYPE_ID_LIST,i_Params_Get_Staff_By_Criteria_InList.OWNER_ID,i_Params_Get_Staff_By_Criteria_InList.START_ROW,i_Params_Get_Staff_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStaff = new Staff();
oTools.CopyPropValues(oDBEntry, oStaff);
oList.Add(oStaff);
}
}
i_Params_Get_Staff_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Staff_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Staff_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_By_Criteria_InList");}
return oList;
}
public List<Staff> Get_Staff_By_Where_InList(Params_Get_Staff_By_Where_InList i_Params_Get_Staff_By_Where_InList)
{
List<Staff> oList = new List<Staff>();
Staff oStaff = new Staff();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Staff_By_Where_InList_SP oParams_Get_Staff_By_Where_InList_SP = new Params_Get_Staff_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_By_Where_InList");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_By_Where_InList",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_By_Where_InList));}
#region Body Section.
if ((i_Params_Get_Staff_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Staff_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Staff_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Staff_By_Where_InList.START_ROW == null) { i_Params_Get_Staff_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Staff_By_Where_InList.END_ROW == null) || (i_Params_Get_Staff_By_Where_InList.END_ROW == 0)) { i_Params_Get_Staff_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Staff_By_Where_InList_SP.OWNER_ID = i_Params_Get_Staff_By_Where_InList.OWNER_ID;
oParams_Get_Staff_By_Where_InList_SP.STAFF_NAME = i_Params_Get_Staff_By_Where_InList.STAFF_NAME;
oParams_Get_Staff_By_Where_InList_SP.STAFF_PH_NB = i_Params_Get_Staff_By_Where_InList.STAFF_PH_NB;
oParams_Get_Staff_By_Where_InList_SP.STAFF_MAIL = i_Params_Get_Staff_By_Where_InList.STAFF_MAIL;
oParams_Get_Staff_By_Where_InList_SP.STAFF_GENDER = i_Params_Get_Staff_By_Where_InList.STAFF_GENDER;
if ( i_Params_Get_Staff_By_Where_InList.BLOODTYPE_ID_LIST == null)
{
i_Params_Get_Staff_By_Where_InList.BLOODTYPE_ID_LIST = new List<Int32?>();
}
oParams_Get_Staff_By_Where_InList_SP.BLOODTYPE_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Staff_By_Where_InList.BLOODTYPE_ID_LIST);
oParams_Get_Staff_By_Where_InList_SP.START_ROW = i_Params_Get_Staff_By_Where_InList.START_ROW;
oParams_Get_Staff_By_Where_InList_SP.END_ROW = i_Params_Get_Staff_By_Where_InList.END_ROW;
oParams_Get_Staff_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Staff_By_Where_InList.TOTAL_COUNT;
List<DALC.Staff> oList_DBEntries = _AppContext.Get_Staff_By_Where_InList(i_Params_Get_Staff_By_Where_InList.STAFF_NAME,i_Params_Get_Staff_By_Where_InList.STAFF_PH_NB,i_Params_Get_Staff_By_Where_InList.STAFF_MAIL,i_Params_Get_Staff_By_Where_InList.STAFF_GENDER,i_Params_Get_Staff_By_Where_InList.BLOODTYPE_ID_LIST,i_Params_Get_Staff_By_Where_InList.OWNER_ID,i_Params_Get_Staff_By_Where_InList.START_ROW,i_Params_Get_Staff_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStaff = new Staff();
oTools.CopyPropValues(oDBEntry, oStaff);
oList.Add(oStaff);
}
}
i_Params_Get_Staff_By_Where_InList.TOTAL_COUNT = oParams_Get_Staff_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Staff_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_By_Where_InList");}
return oList;
}
public List<Staff> Get_Staff_By_Criteria_InList_V2(Params_Get_Staff_By_Criteria_InList_V2 i_Params_Get_Staff_By_Criteria_InList_V2)
{
List<Staff> oList = new List<Staff>();
Staff oStaff = new Staff();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Staff_By_Criteria_InList_SP_V2 oParams_Get_Staff_By_Criteria_InList_SP_V2 = new Params_Get_Staff_By_Criteria_InList_SP_V2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_By_Criteria_InList_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_By_Criteria_InList_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_By_Criteria_InList_V2));}
#region Body Section.
if ((i_Params_Get_Staff_By_Criteria_InList_V2.OWNER_ID == null) || (i_Params_Get_Staff_By_Criteria_InList_V2.OWNER_ID == 0)) { i_Params_Get_Staff_By_Criteria_InList_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Staff_By_Criteria_InList_V2.START_ROW == null) { i_Params_Get_Staff_By_Criteria_InList_V2.START_ROW = 0; }
if ((i_Params_Get_Staff_By_Criteria_InList_V2.END_ROW == null) || (i_Params_Get_Staff_By_Criteria_InList_V2.END_ROW == 0)) { i_Params_Get_Staff_By_Criteria_InList_V2.END_ROW = 1000000; }
oParams_Get_Staff_By_Criteria_InList_SP_V2.OWNER_ID = i_Params_Get_Staff_By_Criteria_InList_V2.OWNER_ID;
oParams_Get_Staff_By_Criteria_InList_SP_V2.STAFF_NAME = i_Params_Get_Staff_By_Criteria_InList_V2.STAFF_NAME;
oParams_Get_Staff_By_Criteria_InList_SP_V2.STAFF_PH_NB = i_Params_Get_Staff_By_Criteria_InList_V2.STAFF_PH_NB;
oParams_Get_Staff_By_Criteria_InList_SP_V2.STAFF_MAIL = i_Params_Get_Staff_By_Criteria_InList_V2.STAFF_MAIL;
oParams_Get_Staff_By_Criteria_InList_SP_V2.STAFF_DOB = i_Params_Get_Staff_By_Criteria_InList_V2.STAFF_DOB;
oParams_Get_Staff_By_Criteria_InList_SP_V2.STAFF_GENDER = i_Params_Get_Staff_By_Criteria_InList_V2.STAFF_GENDER;
if ( i_Params_Get_Staff_By_Criteria_InList_V2.BLOODTYPE_ID_LIST == null)
{
i_Params_Get_Staff_By_Criteria_InList_V2.BLOODTYPE_ID_LIST = new List<Int32?>();
}
oParams_Get_Staff_By_Criteria_InList_SP_V2.BLOODTYPE_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Staff_By_Criteria_InList_V2.BLOODTYPE_ID_LIST);
oParams_Get_Staff_By_Criteria_InList_SP_V2.START_ROW = i_Params_Get_Staff_By_Criteria_InList_V2.START_ROW;
oParams_Get_Staff_By_Criteria_InList_SP_V2.END_ROW = i_Params_Get_Staff_By_Criteria_InList_V2.END_ROW;
oParams_Get_Staff_By_Criteria_InList_SP_V2.TOTAL_COUNT = i_Params_Get_Staff_By_Criteria_InList_V2.TOTAL_COUNT;
List<DALC.Staff> oList_DBEntries = _AppContext.Get_Staff_By_Criteria_InList_V2(i_Params_Get_Staff_By_Criteria_InList_V2.STAFF_NAME,i_Params_Get_Staff_By_Criteria_InList_V2.STAFF_PH_NB,i_Params_Get_Staff_By_Criteria_InList_V2.STAFF_MAIL,i_Params_Get_Staff_By_Criteria_InList_V2.STAFF_DOB,i_Params_Get_Staff_By_Criteria_InList_V2.STAFF_GENDER,i_Params_Get_Staff_By_Criteria_InList_V2.BLOODTYPE_ID_LIST,i_Params_Get_Staff_By_Criteria_InList_V2.OWNER_ID,i_Params_Get_Staff_By_Criteria_InList_V2.START_ROW,i_Params_Get_Staff_By_Criteria_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStaff = new Staff();
oTools.CopyPropValues(oDBEntry, oStaff);
oList.Add(oStaff);
}
}
i_Params_Get_Staff_By_Criteria_InList_V2.TOTAL_COUNT = oParams_Get_Staff_By_Criteria_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Staff_By_Criteria_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_By_Criteria_InList_V2");}
return oList;
}
public List<Staff> Get_Staff_By_Where_InList_V2(Params_Get_Staff_By_Where_InList_V2 i_Params_Get_Staff_By_Where_InList_V2)
{
List<Staff> oList = new List<Staff>();
Staff oStaff = new Staff();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Staff_By_Where_InList_SP_V2 oParams_Get_Staff_By_Where_InList_SP_V2 = new Params_Get_Staff_By_Where_InList_SP_V2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_By_Where_InList_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_By_Where_InList_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_By_Where_InList_V2));}
#region Body Section.
if ((i_Params_Get_Staff_By_Where_InList_V2.OWNER_ID == null) || (i_Params_Get_Staff_By_Where_InList_V2.OWNER_ID == 0)) { i_Params_Get_Staff_By_Where_InList_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Staff_By_Where_InList_V2.START_ROW == null) { i_Params_Get_Staff_By_Where_InList_V2.START_ROW = 0; }
if ((i_Params_Get_Staff_By_Where_InList_V2.END_ROW == null) || (i_Params_Get_Staff_By_Where_InList_V2.END_ROW == 0)) { i_Params_Get_Staff_By_Where_InList_V2.END_ROW = 1000000; }
oParams_Get_Staff_By_Where_InList_SP_V2.OWNER_ID = i_Params_Get_Staff_By_Where_InList_V2.OWNER_ID;
oParams_Get_Staff_By_Where_InList_SP_V2.STAFF_NAME = i_Params_Get_Staff_By_Where_InList_V2.STAFF_NAME;
oParams_Get_Staff_By_Where_InList_SP_V2.STAFF_PH_NB = i_Params_Get_Staff_By_Where_InList_V2.STAFF_PH_NB;
oParams_Get_Staff_By_Where_InList_SP_V2.STAFF_MAIL = i_Params_Get_Staff_By_Where_InList_V2.STAFF_MAIL;
oParams_Get_Staff_By_Where_InList_SP_V2.STAFF_DOB = i_Params_Get_Staff_By_Where_InList_V2.STAFF_DOB;
oParams_Get_Staff_By_Where_InList_SP_V2.STAFF_GENDER = i_Params_Get_Staff_By_Where_InList_V2.STAFF_GENDER;
if ( i_Params_Get_Staff_By_Where_InList_V2.BLOODTYPE_ID_LIST == null)
{
i_Params_Get_Staff_By_Where_InList_V2.BLOODTYPE_ID_LIST = new List<Int32?>();
}
oParams_Get_Staff_By_Where_InList_SP_V2.BLOODTYPE_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Staff_By_Where_InList_V2.BLOODTYPE_ID_LIST);
oParams_Get_Staff_By_Where_InList_SP_V2.START_ROW = i_Params_Get_Staff_By_Where_InList_V2.START_ROW;
oParams_Get_Staff_By_Where_InList_SP_V2.END_ROW = i_Params_Get_Staff_By_Where_InList_V2.END_ROW;
oParams_Get_Staff_By_Where_InList_SP_V2.TOTAL_COUNT = i_Params_Get_Staff_By_Where_InList_V2.TOTAL_COUNT;
List<DALC.Staff> oList_DBEntries = _AppContext.Get_Staff_By_Where_InList_V2(i_Params_Get_Staff_By_Where_InList_V2.STAFF_NAME,i_Params_Get_Staff_By_Where_InList_V2.STAFF_PH_NB,i_Params_Get_Staff_By_Where_InList_V2.STAFF_MAIL,i_Params_Get_Staff_By_Where_InList_V2.STAFF_DOB,i_Params_Get_Staff_By_Where_InList_V2.STAFF_GENDER,i_Params_Get_Staff_By_Where_InList_V2.BLOODTYPE_ID_LIST,i_Params_Get_Staff_By_Where_InList_V2.OWNER_ID,i_Params_Get_Staff_By_Where_InList_V2.START_ROW,i_Params_Get_Staff_By_Where_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStaff = new Staff();
oTools.CopyPropValues(oDBEntry, oStaff);
oList.Add(oStaff);
}
}
i_Params_Get_Staff_By_Where_InList_V2.TOTAL_COUNT = oParams_Get_Staff_By_Where_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Staff_By_Where_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_By_Where_InList_V2");}
return oList;
}
public List<Staff_fees> Get_Staff_fees_By_Criteria_InList(Params_Get_Staff_fees_By_Criteria_InList i_Params_Get_Staff_fees_By_Criteria_InList)
{
List<Staff_fees> oList = new List<Staff_fees>();
Staff_fees oStaff_fees = new Staff_fees();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Staff_fees_By_Criteria_InList_SP oParams_Get_Staff_fees_By_Criteria_InList_SP = new Params_Get_Staff_fees_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_fees_By_Criteria_InList");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_fees_By_Criteria_InList",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_fees_By_Criteria_InList));}
#region Body Section.
if ((i_Params_Get_Staff_fees_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Staff_fees_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Staff_fees_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Staff_fees_By_Criteria_InList.START_ROW == null) { i_Params_Get_Staff_fees_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Staff_fees_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Staff_fees_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Staff_fees_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Staff_fees_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Staff_fees_By_Criteria_InList.OWNER_ID;
oParams_Get_Staff_fees_By_Criteria_InList_SP.STAFF_FEES_DESCRIPTION = i_Params_Get_Staff_fees_By_Criteria_InList.STAFF_FEES_DESCRIPTION;
if ( i_Params_Get_Staff_fees_By_Criteria_InList.STAFF_ID_LIST == null)
{
i_Params_Get_Staff_fees_By_Criteria_InList.STAFF_ID_LIST = new List<Int32?>();
}
oParams_Get_Staff_fees_By_Criteria_InList_SP.STAFF_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Staff_fees_By_Criteria_InList.STAFF_ID_LIST);
if ( i_Params_Get_Staff_fees_By_Criteria_InList.CURRENCY_ID_LIST == null)
{
i_Params_Get_Staff_fees_By_Criteria_InList.CURRENCY_ID_LIST = new List<Int32?>();
}
oParams_Get_Staff_fees_By_Criteria_InList_SP.CURRENCY_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Staff_fees_By_Criteria_InList.CURRENCY_ID_LIST);
oParams_Get_Staff_fees_By_Criteria_InList_SP.START_ROW = i_Params_Get_Staff_fees_By_Criteria_InList.START_ROW;
oParams_Get_Staff_fees_By_Criteria_InList_SP.END_ROW = i_Params_Get_Staff_fees_By_Criteria_InList.END_ROW;
oParams_Get_Staff_fees_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Staff_fees_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Staff_fees> oList_DBEntries = _AppContext.Get_Staff_fees_By_Criteria_InList(i_Params_Get_Staff_fees_By_Criteria_InList.STAFF_FEES_DESCRIPTION,i_Params_Get_Staff_fees_By_Criteria_InList.STAFF_ID_LIST,i_Params_Get_Staff_fees_By_Criteria_InList.CURRENCY_ID_LIST,i_Params_Get_Staff_fees_By_Criteria_InList.OWNER_ID,i_Params_Get_Staff_fees_By_Criteria_InList.START_ROW,i_Params_Get_Staff_fees_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStaff_fees = new Staff_fees();
oTools.CopyPropValues(oDBEntry, oStaff_fees);
oList.Add(oStaff_fees);
}
}
i_Params_Get_Staff_fees_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Staff_fees_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Staff_fees_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_fees_By_Criteria_InList");}
return oList;
}
public List<Staff_fees> Get_Staff_fees_By_Where_InList(Params_Get_Staff_fees_By_Where_InList i_Params_Get_Staff_fees_By_Where_InList)
{
List<Staff_fees> oList = new List<Staff_fees>();
Staff_fees oStaff_fees = new Staff_fees();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Staff_fees_By_Where_InList_SP oParams_Get_Staff_fees_By_Where_InList_SP = new Params_Get_Staff_fees_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_fees_By_Where_InList");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_fees_By_Where_InList",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_fees_By_Where_InList));}
#region Body Section.
if ((i_Params_Get_Staff_fees_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Staff_fees_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Staff_fees_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Staff_fees_By_Where_InList.START_ROW == null) { i_Params_Get_Staff_fees_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Staff_fees_By_Where_InList.END_ROW == null) || (i_Params_Get_Staff_fees_By_Where_InList.END_ROW == 0)) { i_Params_Get_Staff_fees_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Staff_fees_By_Where_InList_SP.OWNER_ID = i_Params_Get_Staff_fees_By_Where_InList.OWNER_ID;
oParams_Get_Staff_fees_By_Where_InList_SP.STAFF_FEES_DESCRIPTION = i_Params_Get_Staff_fees_By_Where_InList.STAFF_FEES_DESCRIPTION;
if ( i_Params_Get_Staff_fees_By_Where_InList.STAFF_ID_LIST == null)
{
i_Params_Get_Staff_fees_By_Where_InList.STAFF_ID_LIST = new List<Int32?>();
}
oParams_Get_Staff_fees_By_Where_InList_SP.STAFF_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Staff_fees_By_Where_InList.STAFF_ID_LIST);
if ( i_Params_Get_Staff_fees_By_Where_InList.CURRENCY_ID_LIST == null)
{
i_Params_Get_Staff_fees_By_Where_InList.CURRENCY_ID_LIST = new List<Int32?>();
}
oParams_Get_Staff_fees_By_Where_InList_SP.CURRENCY_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Staff_fees_By_Where_InList.CURRENCY_ID_LIST);
oParams_Get_Staff_fees_By_Where_InList_SP.START_ROW = i_Params_Get_Staff_fees_By_Where_InList.START_ROW;
oParams_Get_Staff_fees_By_Where_InList_SP.END_ROW = i_Params_Get_Staff_fees_By_Where_InList.END_ROW;
oParams_Get_Staff_fees_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Staff_fees_By_Where_InList.TOTAL_COUNT;
List<DALC.Staff_fees> oList_DBEntries = _AppContext.Get_Staff_fees_By_Where_InList(i_Params_Get_Staff_fees_By_Where_InList.STAFF_FEES_DESCRIPTION,i_Params_Get_Staff_fees_By_Where_InList.STAFF_ID_LIST,i_Params_Get_Staff_fees_By_Where_InList.CURRENCY_ID_LIST,i_Params_Get_Staff_fees_By_Where_InList.OWNER_ID,i_Params_Get_Staff_fees_By_Where_InList.START_ROW,i_Params_Get_Staff_fees_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStaff_fees = new Staff_fees();
oTools.CopyPropValues(oDBEntry, oStaff_fees);
oList.Add(oStaff_fees);
}
}
i_Params_Get_Staff_fees_By_Where_InList.TOTAL_COUNT = oParams_Get_Staff_fees_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Staff_fees_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_fees_By_Where_InList");}
return oList;
}
public List<Supplier> Get_Supplier_By_Criteria_InList(Params_Get_Supplier_By_Criteria_InList i_Params_Get_Supplier_By_Criteria_InList)
{
List<Supplier> oList = new List<Supplier>();
Supplier oSupplier = new Supplier();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Supplier_By_Criteria_InList_SP oParams_Get_Supplier_By_Criteria_InList_SP = new Params_Get_Supplier_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_By_Criteria_InList");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_By_Criteria_InList",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_By_Criteria_InList));}
#region Body Section.
if ((i_Params_Get_Supplier_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Supplier_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Supplier_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Supplier_By_Criteria_InList.START_ROW == null) { i_Params_Get_Supplier_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Supplier_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Supplier_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Supplier_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Supplier_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Supplier_By_Criteria_InList.OWNER_ID;
oParams_Get_Supplier_By_Criteria_InList_SP.SUPPLIER_NAME = i_Params_Get_Supplier_By_Criteria_InList.SUPPLIER_NAME;
oParams_Get_Supplier_By_Criteria_InList_SP.SUPPLIER_PH_NB = i_Params_Get_Supplier_By_Criteria_InList.SUPPLIER_PH_NB;
oParams_Get_Supplier_By_Criteria_InList_SP.SUPPLIER_MAIL = i_Params_Get_Supplier_By_Criteria_InList.SUPPLIER_MAIL;
oParams_Get_Supplier_By_Criteria_InList_SP.SUPPLIER_GENDER = i_Params_Get_Supplier_By_Criteria_InList.SUPPLIER_GENDER;
if ( i_Params_Get_Supplier_By_Criteria_InList.BLOODTYPE_ID_LIST == null)
{
i_Params_Get_Supplier_By_Criteria_InList.BLOODTYPE_ID_LIST = new List<Int32?>();
}
oParams_Get_Supplier_By_Criteria_InList_SP.BLOODTYPE_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Supplier_By_Criteria_InList.BLOODTYPE_ID_LIST);
oParams_Get_Supplier_By_Criteria_InList_SP.START_ROW = i_Params_Get_Supplier_By_Criteria_InList.START_ROW;
oParams_Get_Supplier_By_Criteria_InList_SP.END_ROW = i_Params_Get_Supplier_By_Criteria_InList.END_ROW;
oParams_Get_Supplier_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Supplier_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Supplier> oList_DBEntries = _AppContext.Get_Supplier_By_Criteria_InList(i_Params_Get_Supplier_By_Criteria_InList.SUPPLIER_NAME,i_Params_Get_Supplier_By_Criteria_InList.SUPPLIER_PH_NB,i_Params_Get_Supplier_By_Criteria_InList.SUPPLIER_MAIL,i_Params_Get_Supplier_By_Criteria_InList.SUPPLIER_GENDER,i_Params_Get_Supplier_By_Criteria_InList.BLOODTYPE_ID_LIST,i_Params_Get_Supplier_By_Criteria_InList.OWNER_ID,i_Params_Get_Supplier_By_Criteria_InList.START_ROW,i_Params_Get_Supplier_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier = new Supplier();
oTools.CopyPropValues(oDBEntry, oSupplier);
oList.Add(oSupplier);
}
}
i_Params_Get_Supplier_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Supplier_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Supplier_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_By_Criteria_InList");}
return oList;
}
public List<Supplier> Get_Supplier_By_Where_InList(Params_Get_Supplier_By_Where_InList i_Params_Get_Supplier_By_Where_InList)
{
List<Supplier> oList = new List<Supplier>();
Supplier oSupplier = new Supplier();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Supplier_By_Where_InList_SP oParams_Get_Supplier_By_Where_InList_SP = new Params_Get_Supplier_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_By_Where_InList");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_By_Where_InList",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_By_Where_InList));}
#region Body Section.
if ((i_Params_Get_Supplier_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Supplier_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Supplier_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Supplier_By_Where_InList.START_ROW == null) { i_Params_Get_Supplier_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Supplier_By_Where_InList.END_ROW == null) || (i_Params_Get_Supplier_By_Where_InList.END_ROW == 0)) { i_Params_Get_Supplier_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Supplier_By_Where_InList_SP.OWNER_ID = i_Params_Get_Supplier_By_Where_InList.OWNER_ID;
oParams_Get_Supplier_By_Where_InList_SP.SUPPLIER_NAME = i_Params_Get_Supplier_By_Where_InList.SUPPLIER_NAME;
oParams_Get_Supplier_By_Where_InList_SP.SUPPLIER_PH_NB = i_Params_Get_Supplier_By_Where_InList.SUPPLIER_PH_NB;
oParams_Get_Supplier_By_Where_InList_SP.SUPPLIER_MAIL = i_Params_Get_Supplier_By_Where_InList.SUPPLIER_MAIL;
oParams_Get_Supplier_By_Where_InList_SP.SUPPLIER_GENDER = i_Params_Get_Supplier_By_Where_InList.SUPPLIER_GENDER;
if ( i_Params_Get_Supplier_By_Where_InList.BLOODTYPE_ID_LIST == null)
{
i_Params_Get_Supplier_By_Where_InList.BLOODTYPE_ID_LIST = new List<Int32?>();
}
oParams_Get_Supplier_By_Where_InList_SP.BLOODTYPE_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Supplier_By_Where_InList.BLOODTYPE_ID_LIST);
oParams_Get_Supplier_By_Where_InList_SP.START_ROW = i_Params_Get_Supplier_By_Where_InList.START_ROW;
oParams_Get_Supplier_By_Where_InList_SP.END_ROW = i_Params_Get_Supplier_By_Where_InList.END_ROW;
oParams_Get_Supplier_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Supplier_By_Where_InList.TOTAL_COUNT;
List<DALC.Supplier> oList_DBEntries = _AppContext.Get_Supplier_By_Where_InList(i_Params_Get_Supplier_By_Where_InList.SUPPLIER_NAME,i_Params_Get_Supplier_By_Where_InList.SUPPLIER_PH_NB,i_Params_Get_Supplier_By_Where_InList.SUPPLIER_MAIL,i_Params_Get_Supplier_By_Where_InList.SUPPLIER_GENDER,i_Params_Get_Supplier_By_Where_InList.BLOODTYPE_ID_LIST,i_Params_Get_Supplier_By_Where_InList.OWNER_ID,i_Params_Get_Supplier_By_Where_InList.START_ROW,i_Params_Get_Supplier_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier = new Supplier();
oTools.CopyPropValues(oDBEntry, oSupplier);
oList.Add(oSupplier);
}
}
i_Params_Get_Supplier_By_Where_InList.TOTAL_COUNT = oParams_Get_Supplier_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Supplier_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_By_Where_InList");}
return oList;
}
public List<Supplier> Get_Supplier_By_Criteria_InList_V2(Params_Get_Supplier_By_Criteria_InList_V2 i_Params_Get_Supplier_By_Criteria_InList_V2)
{
List<Supplier> oList = new List<Supplier>();
Supplier oSupplier = new Supplier();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Supplier_By_Criteria_InList_SP_V2 oParams_Get_Supplier_By_Criteria_InList_SP_V2 = new Params_Get_Supplier_By_Criteria_InList_SP_V2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_By_Criteria_InList_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_By_Criteria_InList_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_By_Criteria_InList_V2));}
#region Body Section.
if ((i_Params_Get_Supplier_By_Criteria_InList_V2.OWNER_ID == null) || (i_Params_Get_Supplier_By_Criteria_InList_V2.OWNER_ID == 0)) { i_Params_Get_Supplier_By_Criteria_InList_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Supplier_By_Criteria_InList_V2.START_ROW == null) { i_Params_Get_Supplier_By_Criteria_InList_V2.START_ROW = 0; }
if ((i_Params_Get_Supplier_By_Criteria_InList_V2.END_ROW == null) || (i_Params_Get_Supplier_By_Criteria_InList_V2.END_ROW == 0)) { i_Params_Get_Supplier_By_Criteria_InList_V2.END_ROW = 1000000; }
oParams_Get_Supplier_By_Criteria_InList_SP_V2.OWNER_ID = i_Params_Get_Supplier_By_Criteria_InList_V2.OWNER_ID;
oParams_Get_Supplier_By_Criteria_InList_SP_V2.SUPPLIER_NAME = i_Params_Get_Supplier_By_Criteria_InList_V2.SUPPLIER_NAME;
oParams_Get_Supplier_By_Criteria_InList_SP_V2.SUPPLIER_PH_NB = i_Params_Get_Supplier_By_Criteria_InList_V2.SUPPLIER_PH_NB;
oParams_Get_Supplier_By_Criteria_InList_SP_V2.SUPPLIER_MAIL = i_Params_Get_Supplier_By_Criteria_InList_V2.SUPPLIER_MAIL;
oParams_Get_Supplier_By_Criteria_InList_SP_V2.SUPPLIER_DOB = i_Params_Get_Supplier_By_Criteria_InList_V2.SUPPLIER_DOB;
oParams_Get_Supplier_By_Criteria_InList_SP_V2.SUPPLIER_GENDER = i_Params_Get_Supplier_By_Criteria_InList_V2.SUPPLIER_GENDER;
if ( i_Params_Get_Supplier_By_Criteria_InList_V2.BLOODTYPE_ID_LIST == null)
{
i_Params_Get_Supplier_By_Criteria_InList_V2.BLOODTYPE_ID_LIST = new List<Int32?>();
}
oParams_Get_Supplier_By_Criteria_InList_SP_V2.BLOODTYPE_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Supplier_By_Criteria_InList_V2.BLOODTYPE_ID_LIST);
oParams_Get_Supplier_By_Criteria_InList_SP_V2.START_ROW = i_Params_Get_Supplier_By_Criteria_InList_V2.START_ROW;
oParams_Get_Supplier_By_Criteria_InList_SP_V2.END_ROW = i_Params_Get_Supplier_By_Criteria_InList_V2.END_ROW;
oParams_Get_Supplier_By_Criteria_InList_SP_V2.TOTAL_COUNT = i_Params_Get_Supplier_By_Criteria_InList_V2.TOTAL_COUNT;
List<DALC.Supplier> oList_DBEntries = _AppContext.Get_Supplier_By_Criteria_InList_V2(i_Params_Get_Supplier_By_Criteria_InList_V2.SUPPLIER_NAME,i_Params_Get_Supplier_By_Criteria_InList_V2.SUPPLIER_PH_NB,i_Params_Get_Supplier_By_Criteria_InList_V2.SUPPLIER_MAIL,i_Params_Get_Supplier_By_Criteria_InList_V2.SUPPLIER_DOB,i_Params_Get_Supplier_By_Criteria_InList_V2.SUPPLIER_GENDER,i_Params_Get_Supplier_By_Criteria_InList_V2.BLOODTYPE_ID_LIST,i_Params_Get_Supplier_By_Criteria_InList_V2.OWNER_ID,i_Params_Get_Supplier_By_Criteria_InList_V2.START_ROW,i_Params_Get_Supplier_By_Criteria_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier = new Supplier();
oTools.CopyPropValues(oDBEntry, oSupplier);
oList.Add(oSupplier);
}
}
i_Params_Get_Supplier_By_Criteria_InList_V2.TOTAL_COUNT = oParams_Get_Supplier_By_Criteria_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Supplier_By_Criteria_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_By_Criteria_InList_V2");}
return oList;
}
public List<Supplier> Get_Supplier_By_Where_InList_V2(Params_Get_Supplier_By_Where_InList_V2 i_Params_Get_Supplier_By_Where_InList_V2)
{
List<Supplier> oList = new List<Supplier>();
Supplier oSupplier = new Supplier();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Supplier_By_Where_InList_SP_V2 oParams_Get_Supplier_By_Where_InList_SP_V2 = new Params_Get_Supplier_By_Where_InList_SP_V2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_By_Where_InList_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_By_Where_InList_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_By_Where_InList_V2));}
#region Body Section.
if ((i_Params_Get_Supplier_By_Where_InList_V2.OWNER_ID == null) || (i_Params_Get_Supplier_By_Where_InList_V2.OWNER_ID == 0)) { i_Params_Get_Supplier_By_Where_InList_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Supplier_By_Where_InList_V2.START_ROW == null) { i_Params_Get_Supplier_By_Where_InList_V2.START_ROW = 0; }
if ((i_Params_Get_Supplier_By_Where_InList_V2.END_ROW == null) || (i_Params_Get_Supplier_By_Where_InList_V2.END_ROW == 0)) { i_Params_Get_Supplier_By_Where_InList_V2.END_ROW = 1000000; }
oParams_Get_Supplier_By_Where_InList_SP_V2.OWNER_ID = i_Params_Get_Supplier_By_Where_InList_V2.OWNER_ID;
oParams_Get_Supplier_By_Where_InList_SP_V2.SUPPLIER_NAME = i_Params_Get_Supplier_By_Where_InList_V2.SUPPLIER_NAME;
oParams_Get_Supplier_By_Where_InList_SP_V2.SUPPLIER_PH_NB = i_Params_Get_Supplier_By_Where_InList_V2.SUPPLIER_PH_NB;
oParams_Get_Supplier_By_Where_InList_SP_V2.SUPPLIER_MAIL = i_Params_Get_Supplier_By_Where_InList_V2.SUPPLIER_MAIL;
oParams_Get_Supplier_By_Where_InList_SP_V2.SUPPLIER_DOB = i_Params_Get_Supplier_By_Where_InList_V2.SUPPLIER_DOB;
oParams_Get_Supplier_By_Where_InList_SP_V2.SUPPLIER_GENDER = i_Params_Get_Supplier_By_Where_InList_V2.SUPPLIER_GENDER;
if ( i_Params_Get_Supplier_By_Where_InList_V2.BLOODTYPE_ID_LIST == null)
{
i_Params_Get_Supplier_By_Where_InList_V2.BLOODTYPE_ID_LIST = new List<Int32?>();
}
oParams_Get_Supplier_By_Where_InList_SP_V2.BLOODTYPE_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Supplier_By_Where_InList_V2.BLOODTYPE_ID_LIST);
oParams_Get_Supplier_By_Where_InList_SP_V2.START_ROW = i_Params_Get_Supplier_By_Where_InList_V2.START_ROW;
oParams_Get_Supplier_By_Where_InList_SP_V2.END_ROW = i_Params_Get_Supplier_By_Where_InList_V2.END_ROW;
oParams_Get_Supplier_By_Where_InList_SP_V2.TOTAL_COUNT = i_Params_Get_Supplier_By_Where_InList_V2.TOTAL_COUNT;
List<DALC.Supplier> oList_DBEntries = _AppContext.Get_Supplier_By_Where_InList_V2(i_Params_Get_Supplier_By_Where_InList_V2.SUPPLIER_NAME,i_Params_Get_Supplier_By_Where_InList_V2.SUPPLIER_PH_NB,i_Params_Get_Supplier_By_Where_InList_V2.SUPPLIER_MAIL,i_Params_Get_Supplier_By_Where_InList_V2.SUPPLIER_DOB,i_Params_Get_Supplier_By_Where_InList_V2.SUPPLIER_GENDER,i_Params_Get_Supplier_By_Where_InList_V2.BLOODTYPE_ID_LIST,i_Params_Get_Supplier_By_Where_InList_V2.OWNER_ID,i_Params_Get_Supplier_By_Where_InList_V2.START_ROW,i_Params_Get_Supplier_By_Where_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier = new Supplier();
oTools.CopyPropValues(oDBEntry, oSupplier);
oList.Add(oSupplier);
}
}
i_Params_Get_Supplier_By_Where_InList_V2.TOTAL_COUNT = oParams_Get_Supplier_By_Where_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Supplier_By_Where_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_By_Where_InList_V2");}
return oList;
}
public List<Supplier_fees> Get_Supplier_fees_By_Criteria_InList(Params_Get_Supplier_fees_By_Criteria_InList i_Params_Get_Supplier_fees_By_Criteria_InList)
{
List<Supplier_fees> oList = new List<Supplier_fees>();
Supplier_fees oSupplier_fees = new Supplier_fees();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Supplier_fees_By_Criteria_InList_SP oParams_Get_Supplier_fees_By_Criteria_InList_SP = new Params_Get_Supplier_fees_By_Criteria_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_fees_By_Criteria_InList");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_fees_By_Criteria_InList",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_fees_By_Criteria_InList));}
#region Body Section.
if ((i_Params_Get_Supplier_fees_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Supplier_fees_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Supplier_fees_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Supplier_fees_By_Criteria_InList.START_ROW == null) { i_Params_Get_Supplier_fees_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Supplier_fees_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Supplier_fees_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Supplier_fees_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Supplier_fees_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Supplier_fees_By_Criteria_InList.OWNER_ID;
oParams_Get_Supplier_fees_By_Criteria_InList_SP.SUPPLIER_FEES_DESCRIPTION = i_Params_Get_Supplier_fees_By_Criteria_InList.SUPPLIER_FEES_DESCRIPTION;
if ( i_Params_Get_Supplier_fees_By_Criteria_InList.SUPPLIER_ID_LIST == null)
{
i_Params_Get_Supplier_fees_By_Criteria_InList.SUPPLIER_ID_LIST = new List<Int32?>();
}
oParams_Get_Supplier_fees_By_Criteria_InList_SP.SUPPLIER_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Supplier_fees_By_Criteria_InList.SUPPLIER_ID_LIST);
if ( i_Params_Get_Supplier_fees_By_Criteria_InList.CURRENCY_ID_LIST == null)
{
i_Params_Get_Supplier_fees_By_Criteria_InList.CURRENCY_ID_LIST = new List<Int32?>();
}
oParams_Get_Supplier_fees_By_Criteria_InList_SP.CURRENCY_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Supplier_fees_By_Criteria_InList.CURRENCY_ID_LIST);
oParams_Get_Supplier_fees_By_Criteria_InList_SP.START_ROW = i_Params_Get_Supplier_fees_By_Criteria_InList.START_ROW;
oParams_Get_Supplier_fees_By_Criteria_InList_SP.END_ROW = i_Params_Get_Supplier_fees_By_Criteria_InList.END_ROW;
oParams_Get_Supplier_fees_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Supplier_fees_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Supplier_fees> oList_DBEntries = _AppContext.Get_Supplier_fees_By_Criteria_InList(i_Params_Get_Supplier_fees_By_Criteria_InList.SUPPLIER_FEES_DESCRIPTION,i_Params_Get_Supplier_fees_By_Criteria_InList.SUPPLIER_ID_LIST,i_Params_Get_Supplier_fees_By_Criteria_InList.CURRENCY_ID_LIST,i_Params_Get_Supplier_fees_By_Criteria_InList.OWNER_ID,i_Params_Get_Supplier_fees_By_Criteria_InList.START_ROW,i_Params_Get_Supplier_fees_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier_fees = new Supplier_fees();
oTools.CopyPropValues(oDBEntry, oSupplier_fees);
oList.Add(oSupplier_fees);
}
}
i_Params_Get_Supplier_fees_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Supplier_fees_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Supplier_fees_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_fees_By_Criteria_InList");}
return oList;
}
public List<Supplier_fees> Get_Supplier_fees_By_Where_InList(Params_Get_Supplier_fees_By_Where_InList i_Params_Get_Supplier_fees_By_Where_InList)
{
List<Supplier_fees> oList = new List<Supplier_fees>();
Supplier_fees oSupplier_fees = new Supplier_fees();
long? tmp_TOTAL_COUNT = 0;
Params_Get_Supplier_fees_By_Where_InList_SP oParams_Get_Supplier_fees_By_Where_InList_SP = new Params_Get_Supplier_fees_By_Where_InList_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_fees_By_Where_InList");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_fees_By_Where_InList",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_fees_By_Where_InList));}
#region Body Section.
if ((i_Params_Get_Supplier_fees_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Supplier_fees_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Supplier_fees_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Supplier_fees_By_Where_InList.START_ROW == null) { i_Params_Get_Supplier_fees_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Supplier_fees_By_Where_InList.END_ROW == null) || (i_Params_Get_Supplier_fees_By_Where_InList.END_ROW == 0)) { i_Params_Get_Supplier_fees_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Supplier_fees_By_Where_InList_SP.OWNER_ID = i_Params_Get_Supplier_fees_By_Where_InList.OWNER_ID;
oParams_Get_Supplier_fees_By_Where_InList_SP.SUPPLIER_FEES_DESCRIPTION = i_Params_Get_Supplier_fees_By_Where_InList.SUPPLIER_FEES_DESCRIPTION;
if ( i_Params_Get_Supplier_fees_By_Where_InList.SUPPLIER_ID_LIST == null)
{
i_Params_Get_Supplier_fees_By_Where_InList.SUPPLIER_ID_LIST = new List<Int32?>();
}
oParams_Get_Supplier_fees_By_Where_InList_SP.SUPPLIER_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Supplier_fees_By_Where_InList.SUPPLIER_ID_LIST);
if ( i_Params_Get_Supplier_fees_By_Where_InList.CURRENCY_ID_LIST == null)
{
i_Params_Get_Supplier_fees_By_Where_InList.CURRENCY_ID_LIST = new List<Int32?>();
}
oParams_Get_Supplier_fees_By_Where_InList_SP.CURRENCY_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Supplier_fees_By_Where_InList.CURRENCY_ID_LIST);
oParams_Get_Supplier_fees_By_Where_InList_SP.START_ROW = i_Params_Get_Supplier_fees_By_Where_InList.START_ROW;
oParams_Get_Supplier_fees_By_Where_InList_SP.END_ROW = i_Params_Get_Supplier_fees_By_Where_InList.END_ROW;
oParams_Get_Supplier_fees_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Supplier_fees_By_Where_InList.TOTAL_COUNT;
List<DALC.Supplier_fees> oList_DBEntries = _AppContext.Get_Supplier_fees_By_Where_InList(i_Params_Get_Supplier_fees_By_Where_InList.SUPPLIER_FEES_DESCRIPTION,i_Params_Get_Supplier_fees_By_Where_InList.SUPPLIER_ID_LIST,i_Params_Get_Supplier_fees_By_Where_InList.CURRENCY_ID_LIST,i_Params_Get_Supplier_fees_By_Where_InList.OWNER_ID,i_Params_Get_Supplier_fees_By_Where_InList.START_ROW,i_Params_Get_Supplier_fees_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier_fees = new Supplier_fees();
oTools.CopyPropValues(oDBEntry, oSupplier_fees);
oList.Add(oSupplier_fees);
}
}
i_Params_Get_Supplier_fees_By_Where_InList.TOTAL_COUNT = oParams_Get_Supplier_fees_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Supplier_fees_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_fees_By_Where_InList");}
return oList;
}
public void Delete_Address(Params_Delete_Address i_Params_Delete_Address)
{
Params_Get_Address_By_ADDRESS_ID oParams_Get_Address_By_ADDRESS_ID = new Params_Get_Address_By_ADDRESS_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Address");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Address",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Address));}
#region Body Section.
try
{
oParams_Get_Address_By_ADDRESS_ID.ADDRESS_ID = i_Params_Delete_Address.ADDRESS_ID;
_Address = Get_Address_By_ADDRESS_ID_Adv(oParams_Get_Address_By_ADDRESS_ID);
if (_Address != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Address_Execution)
{
_Stop_Delete_Address_Execution = false;
return;
}
_AppContext.Delete_Address(i_Params_Delete_Address.ADDRESS_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Address");}
}
public void Delete_Bloodtype(Params_Delete_Bloodtype i_Params_Delete_Bloodtype)
{
Params_Get_Bloodtype_By_BLOODTYPE_ID oParams_Get_Bloodtype_By_BLOODTYPE_ID = new Params_Get_Bloodtype_By_BLOODTYPE_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Bloodtype");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Bloodtype",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Bloodtype));}
#region Body Section.
try
{
oParams_Get_Bloodtype_By_BLOODTYPE_ID.BLOODTYPE_ID = i_Params_Delete_Bloodtype.BLOODTYPE_ID;
_Bloodtype = Get_Bloodtype_By_BLOODTYPE_ID_Adv(oParams_Get_Bloodtype_By_BLOODTYPE_ID);
if (_Bloodtype != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Bloodtype_Execution)
{
_Stop_Delete_Bloodtype_Execution = false;
return;
}
_AppContext.Delete_Bloodtype(i_Params_Delete_Bloodtype.BLOODTYPE_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Bloodtype");}
}
public void Delete_Client(Params_Delete_Client i_Params_Delete_Client)
{
Params_Get_Client_By_CLIENT_ID oParams_Get_Client_By_CLIENT_ID = new Params_Get_Client_By_CLIENT_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Client");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Client",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Client));}
#region Body Section.
try
{
oParams_Get_Client_By_CLIENT_ID.CLIENT_ID = i_Params_Delete_Client.CLIENT_ID;
_Client = Get_Client_By_CLIENT_ID_Adv(oParams_Get_Client_By_CLIENT_ID);
if (_Client != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Client_Execution)
{
_Stop_Delete_Client_Execution = false;
return;
}
_AppContext.Delete_Client(i_Params_Delete_Client.CLIENT_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Client");}
}
public void Delete_Client_fees(Params_Delete_Client_fees i_Params_Delete_Client_fees)
{
Params_Get_Client_fees_By_CLIENT_FEES_ID oParams_Get_Client_fees_By_CLIENT_FEES_ID = new Params_Get_Client_fees_By_CLIENT_FEES_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Client_fees");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Client_fees",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Client_fees));}
#region Body Section.
try
{
oParams_Get_Client_fees_By_CLIENT_FEES_ID.CLIENT_FEES_ID = i_Params_Delete_Client_fees.CLIENT_FEES_ID;
_Client_fees = Get_Client_fees_By_CLIENT_FEES_ID_Adv(oParams_Get_Client_fees_By_CLIENT_FEES_ID);
if (_Client_fees != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Client_fees_Execution)
{
_Stop_Delete_Client_fees_Execution = false;
return;
}
_AppContext.Delete_Client_fees(i_Params_Delete_Client_fees.CLIENT_FEES_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Client_fees");}
}
public void Delete_Contact(Params_Delete_Contact i_Params_Delete_Contact)
{
Params_Get_Contact_By_CONTACT_ID oParams_Get_Contact_By_CONTACT_ID = new Params_Get_Contact_By_CONTACT_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Contact");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Contact",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Contact));}
#region Body Section.
try
{
oParams_Get_Contact_By_CONTACT_ID.CONTACT_ID = i_Params_Delete_Contact.CONTACT_ID;
_Contact = Get_Contact_By_CONTACT_ID_Adv(oParams_Get_Contact_By_CONTACT_ID);
if (_Contact != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Contact_Execution)
{
_Stop_Delete_Contact_Execution = false;
return;
}
_AppContext.Delete_Contact(i_Params_Delete_Contact.CONTACT_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Contact");}
}
public void Delete_Currency(Params_Delete_Currency i_Params_Delete_Currency)
{
Params_Get_Currency_By_CURRENCY_ID oParams_Get_Currency_By_CURRENCY_ID = new Params_Get_Currency_By_CURRENCY_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Currency");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Currency",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Currency));}
#region Body Section.
try
{
oParams_Get_Currency_By_CURRENCY_ID.CURRENCY_ID = i_Params_Delete_Currency.CURRENCY_ID;
_Currency = Get_Currency_By_CURRENCY_ID_Adv(oParams_Get_Currency_By_CURRENCY_ID);
if (_Currency != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Currency_Execution)
{
_Stop_Delete_Currency_Execution = false;
return;
}
_AppContext.Delete_Currency(i_Params_Delete_Currency.CURRENCY_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Currency");}
}
public void Delete_Fees(Params_Delete_Fees i_Params_Delete_Fees)
{
Params_Get_Fees_By_FEES_ID oParams_Get_Fees_By_FEES_ID = new Params_Get_Fees_By_FEES_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Fees");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Fees",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Fees));}
#region Body Section.
try
{
oParams_Get_Fees_By_FEES_ID.FEES_ID = i_Params_Delete_Fees.FEES_ID;
_Fees = Get_Fees_By_FEES_ID_Adv(oParams_Get_Fees_By_FEES_ID);
if (_Fees != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Fees_Execution)
{
_Stop_Delete_Fees_Execution = false;
return;
}
_AppContext.Delete_Fees(i_Params_Delete_Fees.FEES_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Fees");}
}
public void Delete_Loc_l1(Params_Delete_Loc_l1 i_Params_Delete_Loc_l1)
{
Params_Get_Loc_l1_By_LOC_L1_ID oParams_Get_Loc_l1_By_LOC_L1_ID = new Params_Get_Loc_l1_By_LOC_L1_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l1");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Loc_l1",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Loc_l1));}
#region Body Section.
try
{
oParams_Get_Loc_l1_By_LOC_L1_ID.LOC_L1_ID = i_Params_Delete_Loc_l1.LOC_L1_ID;
_Loc_l1 = Get_Loc_l1_By_LOC_L1_ID_Adv(oParams_Get_Loc_l1_By_LOC_L1_ID);
if (_Loc_l1 != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l1_Execution)
{
_Stop_Delete_Loc_l1_Execution = false;
return;
}
_AppContext.Delete_Loc_l1(i_Params_Delete_Loc_l1.LOC_L1_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l1");}
}
public void Delete_Loc_l2(Params_Delete_Loc_l2 i_Params_Delete_Loc_l2)
{
Params_Get_Loc_l2_By_LOC_L2_ID oParams_Get_Loc_l2_By_LOC_L2_ID = new Params_Get_Loc_l2_By_LOC_L2_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Loc_l2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Loc_l2));}
#region Body Section.
try
{
oParams_Get_Loc_l2_By_LOC_L2_ID.LOC_L2_ID = i_Params_Delete_Loc_l2.LOC_L2_ID;
_Loc_l2 = Get_Loc_l2_By_LOC_L2_ID_Adv(oParams_Get_Loc_l2_By_LOC_L2_ID);
if (_Loc_l2 != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l2_Execution)
{
_Stop_Delete_Loc_l2_Execution = false;
return;
}
_AppContext.Delete_Loc_l2(i_Params_Delete_Loc_l2.LOC_L2_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l2");}
}
public void Delete_Loc_l3(Params_Delete_Loc_l3 i_Params_Delete_Loc_l3)
{
Params_Get_Loc_l3_By_LOC_L3_ID oParams_Get_Loc_l3_By_LOC_L3_ID = new Params_Get_Loc_l3_By_LOC_L3_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l3");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Loc_l3",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Loc_l3));}
#region Body Section.
try
{
oParams_Get_Loc_l3_By_LOC_L3_ID.LOC_L3_ID = i_Params_Delete_Loc_l3.LOC_L3_ID;
_Loc_l3 = Get_Loc_l3_By_LOC_L3_ID_Adv(oParams_Get_Loc_l3_By_LOC_L3_ID);
if (_Loc_l3 != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l3_Execution)
{
_Stop_Delete_Loc_l3_Execution = false;
return;
}
_AppContext.Delete_Loc_l3(i_Params_Delete_Loc_l3.LOC_L3_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l3");}
}
public void Delete_Loc_l4(Params_Delete_Loc_l4 i_Params_Delete_Loc_l4)
{
Params_Get_Loc_l4_By_LOC_L4_ID oParams_Get_Loc_l4_By_LOC_L4_ID = new Params_Get_Loc_l4_By_LOC_L4_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l4");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Loc_l4",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Loc_l4));}
#region Body Section.
try
{
oParams_Get_Loc_l4_By_LOC_L4_ID.LOC_L4_ID = i_Params_Delete_Loc_l4.LOC_L4_ID;
_Loc_l4 = Get_Loc_l4_By_LOC_L4_ID_Adv(oParams_Get_Loc_l4_By_LOC_L4_ID);
if (_Loc_l4 != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l4_Execution)
{
_Stop_Delete_Loc_l4_Execution = false;
return;
}
_AppContext.Delete_Loc_l4(i_Params_Delete_Loc_l4.LOC_L4_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l4");}
}
public void Delete_Method_run(Params_Delete_Method_run i_Params_Delete_Method_run)
{
Params_Get_Method_run_By_METHOD_RUN_ID oParams_Get_Method_run_By_METHOD_RUN_ID = new Params_Get_Method_run_By_METHOD_RUN_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Method_run");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Method_run",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Method_run));}
#region Body Section.
try
{
oParams_Get_Method_run_By_METHOD_RUN_ID.METHOD_RUN_ID = i_Params_Delete_Method_run.METHOD_RUN_ID;
_Method_run = Get_Method_run_By_METHOD_RUN_ID_Adv(oParams_Get_Method_run_By_METHOD_RUN_ID);
if (_Method_run != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Method_run_Execution)
{
_Stop_Delete_Method_run_Execution = false;
return;
}
_AppContext.Delete_Method_run(i_Params_Delete_Method_run.METHOD_RUN_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Method_run");}
}
public void Delete_Owner(Params_Delete_Owner i_Params_Delete_Owner)
{
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Owner");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Owner",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Owner));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Owner_Execution)
{
_Stop_Delete_Owner_Execution = false;
return;
}
_AppContext.Delete_Owner(i_Params_Delete_Owner.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Owner");}
}
public void Delete_Package(Params_Delete_Package i_Params_Delete_Package)
{
Params_Get_Package_By_PACKAGE_ID oParams_Get_Package_By_PACKAGE_ID = new Params_Get_Package_By_PACKAGE_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Package");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Package",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Package));}
#region Body Section.
try
{
oParams_Get_Package_By_PACKAGE_ID.PACKAGE_ID = i_Params_Delete_Package.PACKAGE_ID;
_Package = Get_Package_By_PACKAGE_ID_Adv(oParams_Get_Package_By_PACKAGE_ID);
if (_Package != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Package_Execution)
{
_Stop_Delete_Package_Execution = false;
return;
}
_AppContext.Delete_Package(i_Params_Delete_Package.PACKAGE_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Package");}
}
public void Delete_Person(Params_Delete_Person i_Params_Delete_Person)
{
Params_Get_Person_By_PERSON_ID oParams_Get_Person_By_PERSON_ID = new Params_Get_Person_By_PERSON_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Person");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Person",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Person));}
#region Body Section.
try
{
oParams_Get_Person_By_PERSON_ID.PERSON_ID = i_Params_Delete_Person.PERSON_ID;
_Person = Get_Person_By_PERSON_ID_Adv(oParams_Get_Person_By_PERSON_ID);
if (_Person != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Person_Execution)
{
_Stop_Delete_Person_Execution = false;
return;
}
_AppContext.Delete_Person(i_Params_Delete_Person.PERSON_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Person");}
}
public void Delete_Registration(Params_Delete_Registration i_Params_Delete_Registration)
{
Params_Get_Registration_By_REGISTRATION_ID oParams_Get_Registration_By_REGISTRATION_ID = new Params_Get_Registration_By_REGISTRATION_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Registration");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Registration",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Registration));}
#region Body Section.
try
{
oParams_Get_Registration_By_REGISTRATION_ID.REGISTRATION_ID = i_Params_Delete_Registration.REGISTRATION_ID;
_Registration = Get_Registration_By_REGISTRATION_ID_Adv(oParams_Get_Registration_By_REGISTRATION_ID);
if (_Registration != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Registration_Execution)
{
_Stop_Delete_Registration_Execution = false;
return;
}
_AppContext.Delete_Registration(i_Params_Delete_Registration.REGISTRATION_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Registration");}
}
public void Delete_Session(Params_Delete_Session i_Params_Delete_Session)
{
Params_Get_Session_By_SESSION_ID oParams_Get_Session_By_SESSION_ID = new Params_Get_Session_By_SESSION_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Session");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Session",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Session));}
#region Body Section.
try
{
oParams_Get_Session_By_SESSION_ID.SESSION_ID = i_Params_Delete_Session.SESSION_ID;
_Session = Get_Session_By_SESSION_ID_Adv(oParams_Get_Session_By_SESSION_ID);
if (_Session != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Session_Execution)
{
_Stop_Delete_Session_Execution = false;
return;
}
_AppContext.Delete_Session(i_Params_Delete_Session.SESSION_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Session");}
}
public void Delete_Staff(Params_Delete_Staff i_Params_Delete_Staff)
{
Params_Get_Staff_By_STAFF_ID oParams_Get_Staff_By_STAFF_ID = new Params_Get_Staff_By_STAFF_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Staff");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Staff",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Staff));}
#region Body Section.
try
{
oParams_Get_Staff_By_STAFF_ID.STAFF_ID = i_Params_Delete_Staff.STAFF_ID;
_Staff = Get_Staff_By_STAFF_ID_Adv(oParams_Get_Staff_By_STAFF_ID);
if (_Staff != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Staff_Execution)
{
_Stop_Delete_Staff_Execution = false;
return;
}
_AppContext.Delete_Staff(i_Params_Delete_Staff.STAFF_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Staff");}
}
public void Delete_Staff_fees(Params_Delete_Staff_fees i_Params_Delete_Staff_fees)
{
Params_Get_Staff_fees_By_STAFF_FEES_ID oParams_Get_Staff_fees_By_STAFF_FEES_ID = new Params_Get_Staff_fees_By_STAFF_FEES_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Staff_fees");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Staff_fees",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Staff_fees));}
#region Body Section.
try
{
oParams_Get_Staff_fees_By_STAFF_FEES_ID.STAFF_FEES_ID = i_Params_Delete_Staff_fees.STAFF_FEES_ID;
_Staff_fees = Get_Staff_fees_By_STAFF_FEES_ID_Adv(oParams_Get_Staff_fees_By_STAFF_FEES_ID);
if (_Staff_fees != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Staff_fees_Execution)
{
_Stop_Delete_Staff_fees_Execution = false;
return;
}
_AppContext.Delete_Staff_fees(i_Params_Delete_Staff_fees.STAFF_FEES_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Staff_fees");}
}
public void Delete_Supplier(Params_Delete_Supplier i_Params_Delete_Supplier)
{
Params_Get_Supplier_By_SUPPLIER_ID oParams_Get_Supplier_By_SUPPLIER_ID = new Params_Get_Supplier_By_SUPPLIER_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Supplier");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Supplier",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Supplier));}
#region Body Section.
try
{
oParams_Get_Supplier_By_SUPPLIER_ID.SUPPLIER_ID = i_Params_Delete_Supplier.SUPPLIER_ID;
_Supplier = Get_Supplier_By_SUPPLIER_ID_Adv(oParams_Get_Supplier_By_SUPPLIER_ID);
if (_Supplier != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Supplier_Execution)
{
_Stop_Delete_Supplier_Execution = false;
return;
}
_AppContext.Delete_Supplier(i_Params_Delete_Supplier.SUPPLIER_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Supplier");}
}
public void Delete_Supplier_fees(Params_Delete_Supplier_fees i_Params_Delete_Supplier_fees)
{
Params_Get_Supplier_fees_By_SUPPLIER_FEES_ID oParams_Get_Supplier_fees_By_SUPPLIER_FEES_ID = new Params_Get_Supplier_fees_By_SUPPLIER_FEES_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Supplier_fees");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Supplier_fees",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Supplier_fees));}
#region Body Section.
try
{
oParams_Get_Supplier_fees_By_SUPPLIER_FEES_ID.SUPPLIER_FEES_ID = i_Params_Delete_Supplier_fees.SUPPLIER_FEES_ID;
_Supplier_fees = Get_Supplier_fees_By_SUPPLIER_FEES_ID_Adv(oParams_Get_Supplier_fees_By_SUPPLIER_FEES_ID);
if (_Supplier_fees != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Supplier_fees_Execution)
{
_Stop_Delete_Supplier_fees_Execution = false;
return;
}
_AppContext.Delete_Supplier_fees(i_Params_Delete_Supplier_fees.SUPPLIER_FEES_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Supplier_fees");}
}
public void Delete_User(Params_Delete_User i_Params_Delete_User)
{
Params_Get_User_By_USER_ID oParams_Get_User_By_USER_ID = new Params_Get_User_By_USER_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_User");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_User",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_User));}
#region Body Section.
try
{
oParams_Get_User_By_USER_ID.USER_ID = i_Params_Delete_User.USER_ID;
_User = Get_User_By_USER_ID_Adv(oParams_Get_User_By_USER_ID);
if (_User != null)
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_User_Execution)
{
_Stop_Delete_User_Execution = false;
return;
}
_AppContext.Delete_User(i_Params_Delete_User.USER_ID);
oScope.Complete();
}
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_User");}
}
public void Delete_Address_By_PERSON_ID(Params_Delete_Address_By_PERSON_ID i_Params_Delete_Address_By_PERSON_ID)
{
Params_Get_Address_By_PERSON_ID oParams_Get_Address_By_PERSON_ID = new Params_Get_Address_By_PERSON_ID();
List<Address> _List_Address = new List<Address>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Address_By_PERSON_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Address_By_PERSON_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Address_By_PERSON_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Address_Execution)
{
_Stop_Delete_Address_Execution = false;
return;
}
_AppContext.Delete_Address_By_PERSON_ID(i_Params_Delete_Address_By_PERSON_ID.PERSON_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Address_By_PERSON_ID");}
}
public void Delete_Address_By_LOC_L1_ID(Params_Delete_Address_By_LOC_L1_ID i_Params_Delete_Address_By_LOC_L1_ID)
{
Params_Get_Address_By_LOC_L1_ID oParams_Get_Address_By_LOC_L1_ID = new Params_Get_Address_By_LOC_L1_ID();
List<Address> _List_Address = new List<Address>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Address_By_LOC_L1_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Address_By_LOC_L1_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Address_By_LOC_L1_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Address_Execution)
{
_Stop_Delete_Address_Execution = false;
return;
}
_AppContext.Delete_Address_By_LOC_L1_ID(i_Params_Delete_Address_By_LOC_L1_ID.LOC_L1_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Address_By_LOC_L1_ID");}
}
public void Delete_Address_By_LOC_L2_ID(Params_Delete_Address_By_LOC_L2_ID i_Params_Delete_Address_By_LOC_L2_ID)
{
Params_Get_Address_By_LOC_L2_ID oParams_Get_Address_By_LOC_L2_ID = new Params_Get_Address_By_LOC_L2_ID();
List<Address> _List_Address = new List<Address>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Address_By_LOC_L2_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Address_By_LOC_L2_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Address_By_LOC_L2_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Address_Execution)
{
_Stop_Delete_Address_Execution = false;
return;
}
_AppContext.Delete_Address_By_LOC_L2_ID(i_Params_Delete_Address_By_LOC_L2_ID.LOC_L2_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Address_By_LOC_L2_ID");}
}
public void Delete_Address_By_LOC_L3_ID(Params_Delete_Address_By_LOC_L3_ID i_Params_Delete_Address_By_LOC_L3_ID)
{
Params_Get_Address_By_LOC_L3_ID oParams_Get_Address_By_LOC_L3_ID = new Params_Get_Address_By_LOC_L3_ID();
List<Address> _List_Address = new List<Address>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Address_By_LOC_L3_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Address_By_LOC_L3_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Address_By_LOC_L3_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Address_Execution)
{
_Stop_Delete_Address_Execution = false;
return;
}
_AppContext.Delete_Address_By_LOC_L3_ID(i_Params_Delete_Address_By_LOC_L3_ID.LOC_L3_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Address_By_LOC_L3_ID");}
}
public void Delete_Address_By_OWNER_ID(Params_Delete_Address_By_OWNER_ID i_Params_Delete_Address_By_OWNER_ID)
{
Params_Get_Address_By_OWNER_ID oParams_Get_Address_By_OWNER_ID = new Params_Get_Address_By_OWNER_ID();
List<Address> _List_Address = new List<Address>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Address_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Address_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Address_By_OWNER_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Address_Execution)
{
_Stop_Delete_Address_Execution = false;
return;
}
_AppContext.Delete_Address_By_OWNER_ID(i_Params_Delete_Address_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Address_By_OWNER_ID");}
}
public void Delete_Address_By_PERSON_ID_ADDRESS_TYPE_CODE(Params_Delete_Address_By_PERSON_ID_ADDRESS_TYPE_CODE i_Params_Delete_Address_By_PERSON_ID_ADDRESS_TYPE_CODE)
{
Params_Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE oParams_Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE = new Params_Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE();
List<Address> _List_Address = new List<Address>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Address_By_PERSON_ID_ADDRESS_TYPE_CODE");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Address_By_PERSON_ID_ADDRESS_TYPE_CODE",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Address_By_PERSON_ID_ADDRESS_TYPE_CODE));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Address_Execution)
{
_Stop_Delete_Address_Execution = false;
return;
}
_AppContext.Delete_Address_By_PERSON_ID_ADDRESS_TYPE_CODE(i_Params_Delete_Address_By_PERSON_ID_ADDRESS_TYPE_CODE.PERSON_ID,i_Params_Delete_Address_By_PERSON_ID_ADDRESS_TYPE_CODE.ADDRESS_TYPE_CODE);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Address_By_PERSON_ID_ADDRESS_TYPE_CODE");}
}
public void Delete_Address_By_LOC_L4_ID(Params_Delete_Address_By_LOC_L4_ID i_Params_Delete_Address_By_LOC_L4_ID)
{
Params_Get_Address_By_LOC_L4_ID oParams_Get_Address_By_LOC_L4_ID = new Params_Get_Address_By_LOC_L4_ID();
List<Address> _List_Address = new List<Address>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Address_By_LOC_L4_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Address_By_LOC_L4_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Address_By_LOC_L4_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Address_Execution)
{
_Stop_Delete_Address_Execution = false;
return;
}
_AppContext.Delete_Address_By_LOC_L4_ID(i_Params_Delete_Address_By_LOC_L4_ID.LOC_L4_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Address_By_LOC_L4_ID");}
}
public void Delete_Bloodtype_By_OWNER_ID(Params_Delete_Bloodtype_By_OWNER_ID i_Params_Delete_Bloodtype_By_OWNER_ID)
{
Params_Get_Bloodtype_By_OWNER_ID oParams_Get_Bloodtype_By_OWNER_ID = new Params_Get_Bloodtype_By_OWNER_ID();
List<Bloodtype> _List_Bloodtype = new List<Bloodtype>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Bloodtype_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Bloodtype_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Bloodtype_By_OWNER_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Bloodtype_Execution)
{
_Stop_Delete_Bloodtype_Execution = false;
return;
}
_AppContext.Delete_Bloodtype_By_OWNER_ID(i_Params_Delete_Bloodtype_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Bloodtype_By_OWNER_ID");}
}
public void Delete_Client_By_OWNER_ID(Params_Delete_Client_By_OWNER_ID i_Params_Delete_Client_By_OWNER_ID)
{
Params_Get_Client_By_OWNER_ID oParams_Get_Client_By_OWNER_ID = new Params_Get_Client_By_OWNER_ID();
List<Client> _List_Client = new List<Client>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Client_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Client_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Client_By_OWNER_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Client_Execution)
{
_Stop_Delete_Client_Execution = false;
return;
}
_AppContext.Delete_Client_By_OWNER_ID(i_Params_Delete_Client_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Client_By_OWNER_ID");}
}
public void Delete_Client_By_BLOODTYPE_ID(Params_Delete_Client_By_BLOODTYPE_ID i_Params_Delete_Client_By_BLOODTYPE_ID)
{
Params_Get_Client_By_BLOODTYPE_ID oParams_Get_Client_By_BLOODTYPE_ID = new Params_Get_Client_By_BLOODTYPE_ID();
List<Client> _List_Client = new List<Client>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Client_By_BLOODTYPE_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Client_By_BLOODTYPE_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Client_By_BLOODTYPE_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Client_Execution)
{
_Stop_Delete_Client_Execution = false;
return;
}
_AppContext.Delete_Client_By_BLOODTYPE_ID(i_Params_Delete_Client_By_BLOODTYPE_ID.BLOODTYPE_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Client_By_BLOODTYPE_ID");}
}
public void Delete_Client_fees_By_OWNER_ID(Params_Delete_Client_fees_By_OWNER_ID i_Params_Delete_Client_fees_By_OWNER_ID)
{
Params_Get_Client_fees_By_OWNER_ID oParams_Get_Client_fees_By_OWNER_ID = new Params_Get_Client_fees_By_OWNER_ID();
List<Client_fees> _List_Client_fees = new List<Client_fees>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Client_fees_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Client_fees_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Client_fees_By_OWNER_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Client_fees_Execution)
{
_Stop_Delete_Client_fees_Execution = false;
return;
}
_AppContext.Delete_Client_fees_By_OWNER_ID(i_Params_Delete_Client_fees_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Client_fees_By_OWNER_ID");}
}
public void Delete_Client_fees_By_CLIENT_ID(Params_Delete_Client_fees_By_CLIENT_ID i_Params_Delete_Client_fees_By_CLIENT_ID)
{
Params_Get_Client_fees_By_CLIENT_ID oParams_Get_Client_fees_By_CLIENT_ID = new Params_Get_Client_fees_By_CLIENT_ID();
List<Client_fees> _List_Client_fees = new List<Client_fees>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Client_fees_By_CLIENT_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Client_fees_By_CLIENT_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Client_fees_By_CLIENT_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Client_fees_Execution)
{
_Stop_Delete_Client_fees_Execution = false;
return;
}
_AppContext.Delete_Client_fees_By_CLIENT_ID(i_Params_Delete_Client_fees_By_CLIENT_ID.CLIENT_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Client_fees_By_CLIENT_ID");}
}
public void Delete_Client_fees_By_CURRENCY_ID(Params_Delete_Client_fees_By_CURRENCY_ID i_Params_Delete_Client_fees_By_CURRENCY_ID)
{
Params_Get_Client_fees_By_CURRENCY_ID oParams_Get_Client_fees_By_CURRENCY_ID = new Params_Get_Client_fees_By_CURRENCY_ID();
List<Client_fees> _List_Client_fees = new List<Client_fees>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Client_fees_By_CURRENCY_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Client_fees_By_CURRENCY_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Client_fees_By_CURRENCY_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Client_fees_Execution)
{
_Stop_Delete_Client_fees_Execution = false;
return;
}
_AppContext.Delete_Client_fees_By_CURRENCY_ID(i_Params_Delete_Client_fees_By_CURRENCY_ID.CURRENCY_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Client_fees_By_CURRENCY_ID");}
}
public void Delete_Client_fees_By_PACKAGE_ID(Params_Delete_Client_fees_By_PACKAGE_ID i_Params_Delete_Client_fees_By_PACKAGE_ID)
{
Params_Get_Client_fees_By_PACKAGE_ID oParams_Get_Client_fees_By_PACKAGE_ID = new Params_Get_Client_fees_By_PACKAGE_ID();
List<Client_fees> _List_Client_fees = new List<Client_fees>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Client_fees_By_PACKAGE_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Client_fees_By_PACKAGE_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Client_fees_By_PACKAGE_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Client_fees_Execution)
{
_Stop_Delete_Client_fees_Execution = false;
return;
}
_AppContext.Delete_Client_fees_By_PACKAGE_ID(i_Params_Delete_Client_fees_By_PACKAGE_ID.PACKAGE_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Client_fees_By_PACKAGE_ID");}
}
public void Delete_Client_fees_By_REGISTRATION_ID(Params_Delete_Client_fees_By_REGISTRATION_ID i_Params_Delete_Client_fees_By_REGISTRATION_ID)
{
Params_Get_Client_fees_By_REGISTRATION_ID oParams_Get_Client_fees_By_REGISTRATION_ID = new Params_Get_Client_fees_By_REGISTRATION_ID();
List<Client_fees> _List_Client_fees = new List<Client_fees>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Client_fees_By_REGISTRATION_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Client_fees_By_REGISTRATION_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Client_fees_By_REGISTRATION_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Client_fees_Execution)
{
_Stop_Delete_Client_fees_Execution = false;
return;
}
_AppContext.Delete_Client_fees_By_REGISTRATION_ID(i_Params_Delete_Client_fees_By_REGISTRATION_ID.REGISTRATION_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Client_fees_By_REGISTRATION_ID");}
}
public void Delete_Contact_By_PERSON_ID(Params_Delete_Contact_By_PERSON_ID i_Params_Delete_Contact_By_PERSON_ID)
{
Params_Get_Contact_By_PERSON_ID oParams_Get_Contact_By_PERSON_ID = new Params_Get_Contact_By_PERSON_ID();
List<Contact> _List_Contact = new List<Contact>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Contact_By_PERSON_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Contact_By_PERSON_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Contact_By_PERSON_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Contact_Execution)
{
_Stop_Delete_Contact_Execution = false;
return;
}
_AppContext.Delete_Contact_By_PERSON_ID(i_Params_Delete_Contact_By_PERSON_ID.PERSON_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Contact_By_PERSON_ID");}
}
public void Delete_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT(Params_Delete_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT i_Params_Delete_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT)
{
Params_Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT oParams_Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT = new Params_Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT();
List<Contact> _List_Contact = new List<Contact>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Contact_Execution)
{
_Stop_Delete_Contact_Execution = false;
return;
}
_AppContext.Delete_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT(i_Params_Delete_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT.PERSON_ID,i_Params_Delete_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT.CONTACT_TYPE_CODE,i_Params_Delete_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT.CONTACT);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT");}
}
public void Delete_Contact_By_OWNER_ID(Params_Delete_Contact_By_OWNER_ID i_Params_Delete_Contact_By_OWNER_ID)
{
Params_Get_Contact_By_OWNER_ID oParams_Get_Contact_By_OWNER_ID = new Params_Get_Contact_By_OWNER_ID();
List<Contact> _List_Contact = new List<Contact>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Contact_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Contact_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Contact_By_OWNER_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Contact_Execution)
{
_Stop_Delete_Contact_Execution = false;
return;
}
_AppContext.Delete_Contact_By_OWNER_ID(i_Params_Delete_Contact_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Contact_By_OWNER_ID");}
}
public void Delete_Currency_By_OWNER_ID(Params_Delete_Currency_By_OWNER_ID i_Params_Delete_Currency_By_OWNER_ID)
{
Params_Get_Currency_By_OWNER_ID oParams_Get_Currency_By_OWNER_ID = new Params_Get_Currency_By_OWNER_ID();
List<Currency> _List_Currency = new List<Currency>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Currency_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Currency_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Currency_By_OWNER_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Currency_Execution)
{
_Stop_Delete_Currency_Execution = false;
return;
}
_AppContext.Delete_Currency_By_OWNER_ID(i_Params_Delete_Currency_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Currency_By_OWNER_ID");}
}
public void Delete_Fees_By_OWNER_ID(Params_Delete_Fees_By_OWNER_ID i_Params_Delete_Fees_By_OWNER_ID)
{
Params_Get_Fees_By_OWNER_ID oParams_Get_Fees_By_OWNER_ID = new Params_Get_Fees_By_OWNER_ID();
List<Fees> _List_Fees = new List<Fees>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Fees_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Fees_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Fees_By_OWNER_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Fees_Execution)
{
_Stop_Delete_Fees_Execution = false;
return;
}
_AppContext.Delete_Fees_By_OWNER_ID(i_Params_Delete_Fees_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Fees_By_OWNER_ID");}
}
public void Delete_Fees_By_CURRENCY_ID(Params_Delete_Fees_By_CURRENCY_ID i_Params_Delete_Fees_By_CURRENCY_ID)
{
Params_Get_Fees_By_CURRENCY_ID oParams_Get_Fees_By_CURRENCY_ID = new Params_Get_Fees_By_CURRENCY_ID();
List<Fees> _List_Fees = new List<Fees>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Fees_By_CURRENCY_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Fees_By_CURRENCY_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Fees_By_CURRENCY_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Fees_Execution)
{
_Stop_Delete_Fees_Execution = false;
return;
}
_AppContext.Delete_Fees_By_CURRENCY_ID(i_Params_Delete_Fees_By_CURRENCY_ID.CURRENCY_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Fees_By_CURRENCY_ID");}
}
public void Delete_Loc_l1_By_CODE(Params_Delete_Loc_l1_By_CODE i_Params_Delete_Loc_l1_By_CODE)
{
Params_Get_Loc_l1_By_CODE oParams_Get_Loc_l1_By_CODE = new Params_Get_Loc_l1_By_CODE();
List<Loc_l1> _List_Loc_l1 = new List<Loc_l1>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l1_By_CODE");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Loc_l1_By_CODE",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Loc_l1_By_CODE));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l1_Execution)
{
_Stop_Delete_Loc_l1_Execution = false;
return;
}
_AppContext.Delete_Loc_l1_By_CODE(i_Params_Delete_Loc_l1_By_CODE.CODE);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l1_By_CODE");}
}
public void Delete_Loc_l1_By_OWNER_ID(Params_Delete_Loc_l1_By_OWNER_ID i_Params_Delete_Loc_l1_By_OWNER_ID)
{
Params_Get_Loc_l1_By_OWNER_ID oParams_Get_Loc_l1_By_OWNER_ID = new Params_Get_Loc_l1_By_OWNER_ID();
List<Loc_l1> _List_Loc_l1 = new List<Loc_l1>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l1_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Loc_l1_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Loc_l1_By_OWNER_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l1_Execution)
{
_Stop_Delete_Loc_l1_Execution = false;
return;
}
_AppContext.Delete_Loc_l1_By_OWNER_ID(i_Params_Delete_Loc_l1_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l1_By_OWNER_ID");}
}
public void Delete_Loc_l2_By_LOC_L1_ID_CODE(Params_Delete_Loc_l2_By_LOC_L1_ID_CODE i_Params_Delete_Loc_l2_By_LOC_L1_ID_CODE)
{
Params_Get_Loc_l2_By_LOC_L1_ID_CODE oParams_Get_Loc_l2_By_LOC_L1_ID_CODE = new Params_Get_Loc_l2_By_LOC_L1_ID_CODE();
List<Loc_l2> _List_Loc_l2 = new List<Loc_l2>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l2_By_LOC_L1_ID_CODE");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Loc_l2_By_LOC_L1_ID_CODE",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Loc_l2_By_LOC_L1_ID_CODE));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l2_Execution)
{
_Stop_Delete_Loc_l2_Execution = false;
return;
}
_AppContext.Delete_Loc_l2_By_LOC_L1_ID_CODE(i_Params_Delete_Loc_l2_By_LOC_L1_ID_CODE.LOC_L1_ID,i_Params_Delete_Loc_l2_By_LOC_L1_ID_CODE.CODE);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l2_By_LOC_L1_ID_CODE");}
}
public void Delete_Loc_l2_By_LOC_L1_ID(Params_Delete_Loc_l2_By_LOC_L1_ID i_Params_Delete_Loc_l2_By_LOC_L1_ID)
{
Params_Get_Loc_l2_By_LOC_L1_ID oParams_Get_Loc_l2_By_LOC_L1_ID = new Params_Get_Loc_l2_By_LOC_L1_ID();
List<Loc_l2> _List_Loc_l2 = new List<Loc_l2>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l2_By_LOC_L1_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Loc_l2_By_LOC_L1_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Loc_l2_By_LOC_L1_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l2_Execution)
{
_Stop_Delete_Loc_l2_Execution = false;
return;
}
_AppContext.Delete_Loc_l2_By_LOC_L1_ID(i_Params_Delete_Loc_l2_By_LOC_L1_ID.LOC_L1_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l2_By_LOC_L1_ID");}
}
public void Delete_Loc_l2_By_OWNER_ID(Params_Delete_Loc_l2_By_OWNER_ID i_Params_Delete_Loc_l2_By_OWNER_ID)
{
Params_Get_Loc_l2_By_OWNER_ID oParams_Get_Loc_l2_By_OWNER_ID = new Params_Get_Loc_l2_By_OWNER_ID();
List<Loc_l2> _List_Loc_l2 = new List<Loc_l2>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l2_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Loc_l2_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Loc_l2_By_OWNER_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l2_Execution)
{
_Stop_Delete_Loc_l2_Execution = false;
return;
}
_AppContext.Delete_Loc_l2_By_OWNER_ID(i_Params_Delete_Loc_l2_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l2_By_OWNER_ID");}
}
public void Delete_Loc_l3_By_LOC_L2_ID_CODE(Params_Delete_Loc_l3_By_LOC_L2_ID_CODE i_Params_Delete_Loc_l3_By_LOC_L2_ID_CODE)
{
Params_Get_Loc_l3_By_LOC_L2_ID_CODE oParams_Get_Loc_l3_By_LOC_L2_ID_CODE = new Params_Get_Loc_l3_By_LOC_L2_ID_CODE();
List<Loc_l3> _List_Loc_l3 = new List<Loc_l3>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l3_By_LOC_L2_ID_CODE");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Loc_l3_By_LOC_L2_ID_CODE",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Loc_l3_By_LOC_L2_ID_CODE));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l3_Execution)
{
_Stop_Delete_Loc_l3_Execution = false;
return;
}
_AppContext.Delete_Loc_l3_By_LOC_L2_ID_CODE(i_Params_Delete_Loc_l3_By_LOC_L2_ID_CODE.LOC_L2_ID,i_Params_Delete_Loc_l3_By_LOC_L2_ID_CODE.CODE);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l3_By_LOC_L2_ID_CODE");}
}
public void Delete_Loc_l3_By_LOC_L2_ID(Params_Delete_Loc_l3_By_LOC_L2_ID i_Params_Delete_Loc_l3_By_LOC_L2_ID)
{
Params_Get_Loc_l3_By_LOC_L2_ID oParams_Get_Loc_l3_By_LOC_L2_ID = new Params_Get_Loc_l3_By_LOC_L2_ID();
List<Loc_l3> _List_Loc_l3 = new List<Loc_l3>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l3_By_LOC_L2_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Loc_l3_By_LOC_L2_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Loc_l3_By_LOC_L2_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l3_Execution)
{
_Stop_Delete_Loc_l3_Execution = false;
return;
}
_AppContext.Delete_Loc_l3_By_LOC_L2_ID(i_Params_Delete_Loc_l3_By_LOC_L2_ID.LOC_L2_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l3_By_LOC_L2_ID");}
}
public void Delete_Loc_l3_By_OWNER_ID(Params_Delete_Loc_l3_By_OWNER_ID i_Params_Delete_Loc_l3_By_OWNER_ID)
{
Params_Get_Loc_l3_By_OWNER_ID oParams_Get_Loc_l3_By_OWNER_ID = new Params_Get_Loc_l3_By_OWNER_ID();
List<Loc_l3> _List_Loc_l3 = new List<Loc_l3>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l3_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Loc_l3_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Loc_l3_By_OWNER_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l3_Execution)
{
_Stop_Delete_Loc_l3_Execution = false;
return;
}
_AppContext.Delete_Loc_l3_By_OWNER_ID(i_Params_Delete_Loc_l3_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l3_By_OWNER_ID");}
}
public void Delete_Loc_l4_By_LOC_L3_ID_CODE(Params_Delete_Loc_l4_By_LOC_L3_ID_CODE i_Params_Delete_Loc_l4_By_LOC_L3_ID_CODE)
{
Params_Get_Loc_l4_By_LOC_L3_ID_CODE oParams_Get_Loc_l4_By_LOC_L3_ID_CODE = new Params_Get_Loc_l4_By_LOC_L3_ID_CODE();
List<Loc_l4> _List_Loc_l4 = new List<Loc_l4>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l4_By_LOC_L3_ID_CODE");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Loc_l4_By_LOC_L3_ID_CODE",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Loc_l4_By_LOC_L3_ID_CODE));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l4_Execution)
{
_Stop_Delete_Loc_l4_Execution = false;
return;
}
_AppContext.Delete_Loc_l4_By_LOC_L3_ID_CODE(i_Params_Delete_Loc_l4_By_LOC_L3_ID_CODE.LOC_L3_ID,i_Params_Delete_Loc_l4_By_LOC_L3_ID_CODE.CODE);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l4_By_LOC_L3_ID_CODE");}
}
public void Delete_Loc_l4_By_LOC_L3_ID(Params_Delete_Loc_l4_By_LOC_L3_ID i_Params_Delete_Loc_l4_By_LOC_L3_ID)
{
Params_Get_Loc_l4_By_LOC_L3_ID oParams_Get_Loc_l4_By_LOC_L3_ID = new Params_Get_Loc_l4_By_LOC_L3_ID();
List<Loc_l4> _List_Loc_l4 = new List<Loc_l4>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l4_By_LOC_L3_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Loc_l4_By_LOC_L3_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Loc_l4_By_LOC_L3_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l4_Execution)
{
_Stop_Delete_Loc_l4_Execution = false;
return;
}
_AppContext.Delete_Loc_l4_By_LOC_L3_ID(i_Params_Delete_Loc_l4_By_LOC_L3_ID.LOC_L3_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l4_By_LOC_L3_ID");}
}
public void Delete_Loc_l4_By_OWNER_ID(Params_Delete_Loc_l4_By_OWNER_ID i_Params_Delete_Loc_l4_By_OWNER_ID)
{
Params_Get_Loc_l4_By_OWNER_ID oParams_Get_Loc_l4_By_OWNER_ID = new Params_Get_Loc_l4_By_OWNER_ID();
List<Loc_l4> _List_Loc_l4 = new List<Loc_l4>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Loc_l4_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Loc_l4_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Loc_l4_By_OWNER_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Loc_l4_Execution)
{
_Stop_Delete_Loc_l4_Execution = false;
return;
}
_AppContext.Delete_Loc_l4_By_OWNER_ID(i_Params_Delete_Loc_l4_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Loc_l4_By_OWNER_ID");}
}
public void Delete_Method_run_By_OWNER_ID(Params_Delete_Method_run_By_OWNER_ID i_Params_Delete_Method_run_By_OWNER_ID)
{
Params_Get_Method_run_By_OWNER_ID oParams_Get_Method_run_By_OWNER_ID = new Params_Get_Method_run_By_OWNER_ID();
List<Method_run> _List_Method_run = new List<Method_run>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Method_run_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Method_run_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Method_run_By_OWNER_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Method_run_Execution)
{
_Stop_Delete_Method_run_Execution = false;
return;
}
_AppContext.Delete_Method_run_By_OWNER_ID(i_Params_Delete_Method_run_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Method_run_By_OWNER_ID");}
}
public void Delete_Package_By_OWNER_ID(Params_Delete_Package_By_OWNER_ID i_Params_Delete_Package_By_OWNER_ID)
{
Params_Get_Package_By_OWNER_ID oParams_Get_Package_By_OWNER_ID = new Params_Get_Package_By_OWNER_ID();
List<Package> _List_Package = new List<Package>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Package_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Package_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Package_By_OWNER_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Package_Execution)
{
_Stop_Delete_Package_Execution = false;
return;
}
_AppContext.Delete_Package_By_OWNER_ID(i_Params_Delete_Package_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Package_By_OWNER_ID");}
}
public void Delete_Package_By_CURRENCY_ID(Params_Delete_Package_By_CURRENCY_ID i_Params_Delete_Package_By_CURRENCY_ID)
{
Params_Get_Package_By_CURRENCY_ID oParams_Get_Package_By_CURRENCY_ID = new Params_Get_Package_By_CURRENCY_ID();
List<Package> _List_Package = new List<Package>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Package_By_CURRENCY_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Package_By_CURRENCY_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Package_By_CURRENCY_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Package_Execution)
{
_Stop_Delete_Package_Execution = false;
return;
}
_AppContext.Delete_Package_By_CURRENCY_ID(i_Params_Delete_Package_By_CURRENCY_ID.CURRENCY_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Package_By_CURRENCY_ID");}
}
public void Delete_Person_By_OWNER_ID(Params_Delete_Person_By_OWNER_ID i_Params_Delete_Person_By_OWNER_ID)
{
Params_Get_Person_By_OWNER_ID oParams_Get_Person_By_OWNER_ID = new Params_Get_Person_By_OWNER_ID();
List<Person> _List_Person = new List<Person>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Person_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Person_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Person_By_OWNER_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Person_Execution)
{
_Stop_Delete_Person_Execution = false;
return;
}
_AppContext.Delete_Person_By_OWNER_ID(i_Params_Delete_Person_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Person_By_OWNER_ID");}
}
public void Delete_Registration_By_OWNER_ID(Params_Delete_Registration_By_OWNER_ID i_Params_Delete_Registration_By_OWNER_ID)
{
Params_Get_Registration_By_OWNER_ID oParams_Get_Registration_By_OWNER_ID = new Params_Get_Registration_By_OWNER_ID();
List<Registration> _List_Registration = new List<Registration>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Registration_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Registration_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Registration_By_OWNER_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Registration_Execution)
{
_Stop_Delete_Registration_Execution = false;
return;
}
_AppContext.Delete_Registration_By_OWNER_ID(i_Params_Delete_Registration_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Registration_By_OWNER_ID");}
}
public void Delete_Registration_By_CLIENT_ID(Params_Delete_Registration_By_CLIENT_ID i_Params_Delete_Registration_By_CLIENT_ID)
{
Params_Get_Registration_By_CLIENT_ID oParams_Get_Registration_By_CLIENT_ID = new Params_Get_Registration_By_CLIENT_ID();
List<Registration> _List_Registration = new List<Registration>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Registration_By_CLIENT_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Registration_By_CLIENT_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Registration_By_CLIENT_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Registration_Execution)
{
_Stop_Delete_Registration_Execution = false;
return;
}
_AppContext.Delete_Registration_By_CLIENT_ID(i_Params_Delete_Registration_By_CLIENT_ID.CLIENT_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Registration_By_CLIENT_ID");}
}
public void Delete_Registration_By_PACKAGE_ID(Params_Delete_Registration_By_PACKAGE_ID i_Params_Delete_Registration_By_PACKAGE_ID)
{
Params_Get_Registration_By_PACKAGE_ID oParams_Get_Registration_By_PACKAGE_ID = new Params_Get_Registration_By_PACKAGE_ID();
List<Registration> _List_Registration = new List<Registration>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Registration_By_PACKAGE_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Registration_By_PACKAGE_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Registration_By_PACKAGE_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Registration_Execution)
{
_Stop_Delete_Registration_Execution = false;
return;
}
_AppContext.Delete_Registration_By_PACKAGE_ID(i_Params_Delete_Registration_By_PACKAGE_ID.PACKAGE_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Registration_By_PACKAGE_ID");}
}
public void Delete_Registration_By_CURRENCY_ID(Params_Delete_Registration_By_CURRENCY_ID i_Params_Delete_Registration_By_CURRENCY_ID)
{
Params_Get_Registration_By_CURRENCY_ID oParams_Get_Registration_By_CURRENCY_ID = new Params_Get_Registration_By_CURRENCY_ID();
List<Registration> _List_Registration = new List<Registration>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Registration_By_CURRENCY_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Registration_By_CURRENCY_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Registration_By_CURRENCY_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Registration_Execution)
{
_Stop_Delete_Registration_Execution = false;
return;
}
_AppContext.Delete_Registration_By_CURRENCY_ID(i_Params_Delete_Registration_By_CURRENCY_ID.CURRENCY_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Registration_By_CURRENCY_ID");}
}
public void Delete_Session_By_OWNER_ID(Params_Delete_Session_By_OWNER_ID i_Params_Delete_Session_By_OWNER_ID)
{
Params_Get_Session_By_OWNER_ID oParams_Get_Session_By_OWNER_ID = new Params_Get_Session_By_OWNER_ID();
List<Session> _List_Session = new List<Session>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Session_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Session_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Session_By_OWNER_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Session_Execution)
{
_Stop_Delete_Session_Execution = false;
return;
}
_AppContext.Delete_Session_By_OWNER_ID(i_Params_Delete_Session_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Session_By_OWNER_ID");}
}
public void Delete_Session_By_PACKAGE_ID(Params_Delete_Session_By_PACKAGE_ID i_Params_Delete_Session_By_PACKAGE_ID)
{
Params_Get_Session_By_PACKAGE_ID oParams_Get_Session_By_PACKAGE_ID = new Params_Get_Session_By_PACKAGE_ID();
List<Session> _List_Session = new List<Session>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Session_By_PACKAGE_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Session_By_PACKAGE_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Session_By_PACKAGE_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Session_Execution)
{
_Stop_Delete_Session_Execution = false;
return;
}
_AppContext.Delete_Session_By_PACKAGE_ID(i_Params_Delete_Session_By_PACKAGE_ID.PACKAGE_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Session_By_PACKAGE_ID");}
}
public void Delete_Session_By_CLIENT_FEES_ID(Params_Delete_Session_By_CLIENT_FEES_ID i_Params_Delete_Session_By_CLIENT_FEES_ID)
{
Params_Get_Session_By_CLIENT_FEES_ID oParams_Get_Session_By_CLIENT_FEES_ID = new Params_Get_Session_By_CLIENT_FEES_ID();
List<Session> _List_Session = new List<Session>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Session_By_CLIENT_FEES_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Session_By_CLIENT_FEES_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Session_By_CLIENT_FEES_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Session_Execution)
{
_Stop_Delete_Session_Execution = false;
return;
}
_AppContext.Delete_Session_By_CLIENT_FEES_ID(i_Params_Delete_Session_By_CLIENT_FEES_ID.CLIENT_FEES_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Session_By_CLIENT_FEES_ID");}
}
public void Delete_Staff_By_OWNER_ID(Params_Delete_Staff_By_OWNER_ID i_Params_Delete_Staff_By_OWNER_ID)
{
Params_Get_Staff_By_OWNER_ID oParams_Get_Staff_By_OWNER_ID = new Params_Get_Staff_By_OWNER_ID();
List<Staff> _List_Staff = new List<Staff>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Staff_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Staff_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Staff_By_OWNER_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Staff_Execution)
{
_Stop_Delete_Staff_Execution = false;
return;
}
_AppContext.Delete_Staff_By_OWNER_ID(i_Params_Delete_Staff_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Staff_By_OWNER_ID");}
}
public void Delete_Staff_By_BLOODTYPE_ID(Params_Delete_Staff_By_BLOODTYPE_ID i_Params_Delete_Staff_By_BLOODTYPE_ID)
{
Params_Get_Staff_By_BLOODTYPE_ID oParams_Get_Staff_By_BLOODTYPE_ID = new Params_Get_Staff_By_BLOODTYPE_ID();
List<Staff> _List_Staff = new List<Staff>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Staff_By_BLOODTYPE_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Staff_By_BLOODTYPE_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Staff_By_BLOODTYPE_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Staff_Execution)
{
_Stop_Delete_Staff_Execution = false;
return;
}
_AppContext.Delete_Staff_By_BLOODTYPE_ID(i_Params_Delete_Staff_By_BLOODTYPE_ID.BLOODTYPE_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Staff_By_BLOODTYPE_ID");}
}
public void Delete_Staff_fees_By_OWNER_ID(Params_Delete_Staff_fees_By_OWNER_ID i_Params_Delete_Staff_fees_By_OWNER_ID)
{
Params_Get_Staff_fees_By_OWNER_ID oParams_Get_Staff_fees_By_OWNER_ID = new Params_Get_Staff_fees_By_OWNER_ID();
List<Staff_fees> _List_Staff_fees = new List<Staff_fees>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Staff_fees_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Staff_fees_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Staff_fees_By_OWNER_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Staff_fees_Execution)
{
_Stop_Delete_Staff_fees_Execution = false;
return;
}
_AppContext.Delete_Staff_fees_By_OWNER_ID(i_Params_Delete_Staff_fees_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Staff_fees_By_OWNER_ID");}
}
public void Delete_Staff_fees_By_STAFF_ID(Params_Delete_Staff_fees_By_STAFF_ID i_Params_Delete_Staff_fees_By_STAFF_ID)
{
Params_Get_Staff_fees_By_STAFF_ID oParams_Get_Staff_fees_By_STAFF_ID = new Params_Get_Staff_fees_By_STAFF_ID();
List<Staff_fees> _List_Staff_fees = new List<Staff_fees>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Staff_fees_By_STAFF_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Staff_fees_By_STAFF_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Staff_fees_By_STAFF_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Staff_fees_Execution)
{
_Stop_Delete_Staff_fees_Execution = false;
return;
}
_AppContext.Delete_Staff_fees_By_STAFF_ID(i_Params_Delete_Staff_fees_By_STAFF_ID.STAFF_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Staff_fees_By_STAFF_ID");}
}
public void Delete_Staff_fees_By_CURRENCY_ID(Params_Delete_Staff_fees_By_CURRENCY_ID i_Params_Delete_Staff_fees_By_CURRENCY_ID)
{
Params_Get_Staff_fees_By_CURRENCY_ID oParams_Get_Staff_fees_By_CURRENCY_ID = new Params_Get_Staff_fees_By_CURRENCY_ID();
List<Staff_fees> _List_Staff_fees = new List<Staff_fees>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Staff_fees_By_CURRENCY_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Staff_fees_By_CURRENCY_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Staff_fees_By_CURRENCY_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Staff_fees_Execution)
{
_Stop_Delete_Staff_fees_Execution = false;
return;
}
_AppContext.Delete_Staff_fees_By_CURRENCY_ID(i_Params_Delete_Staff_fees_By_CURRENCY_ID.CURRENCY_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Staff_fees_By_CURRENCY_ID");}
}
public void Delete_Supplier_By_OWNER_ID(Params_Delete_Supplier_By_OWNER_ID i_Params_Delete_Supplier_By_OWNER_ID)
{
Params_Get_Supplier_By_OWNER_ID oParams_Get_Supplier_By_OWNER_ID = new Params_Get_Supplier_By_OWNER_ID();
List<Supplier> _List_Supplier = new List<Supplier>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Supplier_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Supplier_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Supplier_By_OWNER_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Supplier_Execution)
{
_Stop_Delete_Supplier_Execution = false;
return;
}
_AppContext.Delete_Supplier_By_OWNER_ID(i_Params_Delete_Supplier_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Supplier_By_OWNER_ID");}
}
public void Delete_Supplier_By_BLOODTYPE_ID(Params_Delete_Supplier_By_BLOODTYPE_ID i_Params_Delete_Supplier_By_BLOODTYPE_ID)
{
Params_Get_Supplier_By_BLOODTYPE_ID oParams_Get_Supplier_By_BLOODTYPE_ID = new Params_Get_Supplier_By_BLOODTYPE_ID();
List<Supplier> _List_Supplier = new List<Supplier>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Supplier_By_BLOODTYPE_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Supplier_By_BLOODTYPE_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Supplier_By_BLOODTYPE_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Supplier_Execution)
{
_Stop_Delete_Supplier_Execution = false;
return;
}
_AppContext.Delete_Supplier_By_BLOODTYPE_ID(i_Params_Delete_Supplier_By_BLOODTYPE_ID.BLOODTYPE_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Supplier_By_BLOODTYPE_ID");}
}
public void Delete_Supplier_fees_By_OWNER_ID(Params_Delete_Supplier_fees_By_OWNER_ID i_Params_Delete_Supplier_fees_By_OWNER_ID)
{
Params_Get_Supplier_fees_By_OWNER_ID oParams_Get_Supplier_fees_By_OWNER_ID = new Params_Get_Supplier_fees_By_OWNER_ID();
List<Supplier_fees> _List_Supplier_fees = new List<Supplier_fees>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Supplier_fees_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Supplier_fees_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Supplier_fees_By_OWNER_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Supplier_fees_Execution)
{
_Stop_Delete_Supplier_fees_Execution = false;
return;
}
_AppContext.Delete_Supplier_fees_By_OWNER_ID(i_Params_Delete_Supplier_fees_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Supplier_fees_By_OWNER_ID");}
}
public void Delete_Supplier_fees_By_SUPPLIER_ID(Params_Delete_Supplier_fees_By_SUPPLIER_ID i_Params_Delete_Supplier_fees_By_SUPPLIER_ID)
{
Params_Get_Supplier_fees_By_SUPPLIER_ID oParams_Get_Supplier_fees_By_SUPPLIER_ID = new Params_Get_Supplier_fees_By_SUPPLIER_ID();
List<Supplier_fees> _List_Supplier_fees = new List<Supplier_fees>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Supplier_fees_By_SUPPLIER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Supplier_fees_By_SUPPLIER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Supplier_fees_By_SUPPLIER_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Supplier_fees_Execution)
{
_Stop_Delete_Supplier_fees_Execution = false;
return;
}
_AppContext.Delete_Supplier_fees_By_SUPPLIER_ID(i_Params_Delete_Supplier_fees_By_SUPPLIER_ID.SUPPLIER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Supplier_fees_By_SUPPLIER_ID");}
}
public void Delete_Supplier_fees_By_CURRENCY_ID(Params_Delete_Supplier_fees_By_CURRENCY_ID i_Params_Delete_Supplier_fees_By_CURRENCY_ID)
{
Params_Get_Supplier_fees_By_CURRENCY_ID oParams_Get_Supplier_fees_By_CURRENCY_ID = new Params_Get_Supplier_fees_By_CURRENCY_ID();
List<Supplier_fees> _List_Supplier_fees = new List<Supplier_fees>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_Supplier_fees_By_CURRENCY_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_Supplier_fees_By_CURRENCY_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_Supplier_fees_By_CURRENCY_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_Supplier_fees_Execution)
{
_Stop_Delete_Supplier_fees_Execution = false;
return;
}
_AppContext.Delete_Supplier_fees_By_CURRENCY_ID(i_Params_Delete_Supplier_fees_By_CURRENCY_ID.CURRENCY_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_Supplier_fees_By_CURRENCY_ID");}
}
public void Delete_User_By_OWNER_ID(Params_Delete_User_By_OWNER_ID i_Params_Delete_User_By_OWNER_ID)
{
Params_Get_User_By_OWNER_ID oParams_Get_User_By_OWNER_ID = new Params_Get_User_By_OWNER_ID();
List<User> _List_User = new List<User>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_User_By_OWNER_ID");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_User_By_OWNER_ID",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_User_By_OWNER_ID));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_User_Execution)
{
_Stop_Delete_User_Execution = false;
return;
}
_AppContext.Delete_User_By_OWNER_ID(i_Params_Delete_User_By_OWNER_ID.OWNER_ID);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_User_By_OWNER_ID");}
}
public void Delete_User_By_USERNAME(Params_Delete_User_By_USERNAME i_Params_Delete_User_By_USERNAME)
{
Params_Get_User_By_USERNAME oParams_Get_User_By_USERNAME = new Params_Get_User_By_USERNAME();
List<User> _List_User = new List<User>();
if (OnPreEvent_General != null){OnPreEvent_General("Delete_User_By_USERNAME");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Delete_User_By_USERNAME",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Delete_User_By_USERNAME));}
#region Body Section.
try
{
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Delete_User_Execution)
{
_Stop_Delete_User_Execution = false;
return;
}
_AppContext.Delete_User_By_USERNAME(i_Params_Delete_User_By_USERNAME.USERNAME);
oScope.Complete();
}
}
catch (BLCException blcex)
{
throw new BLCException(blcex.Message);
}
catch (Exception ex)
{
if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
{
throw new BLCException("Cannot be deleted because of related records in other tables");
}
else
{
throw new Exception(ex.Message);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Delete_User_By_USERNAME");}
}
public void Edit_Address(Address i_Address) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Address.ADDRESS_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Address");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Edit_Address",Newtonsoft.Json.JsonConvert.SerializeObject(i_Address));}
#region Body Section.
if ((i_Address.ADDRESS_ID == null) || (i_Address.ADDRESS_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Address"); }
i_Address.ENTRY_USER_ID = this.UserID;
i_Address.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Address.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Address_Execution)
{
_Stop_Edit_Address_Execution = false;
return;
}
i_Address.ADDRESS_ID = _AppContext.Edit_Address
(
i_Address.ADDRESS_ID
,i_Address.PERSON_ID
,i_Address.ADDRESS_TYPE_CODE
,i_Address.LOC_L1_ID
,i_Address.LOC_L2_ID
,i_Address.LOC_L3_ID
,i_Address.LOC_L4_ID
,i_Address.STREET
,i_Address.BUILDING
,i_Address.FLOOR
,i_Address.POBOX
,i_Address.VALID_DATE_START
,i_Address.VALID_DATE_END
,i_Address.NOTES
,i_Address.ENTRY_DATE
,i_Address.ENTRY_USER_ID
,i_Address.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Address");}
}
public void Edit_Bloodtype(Bloodtype i_Bloodtype) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Bloodtype.BLOODTYPE_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Bloodtype");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Edit_Bloodtype",Newtonsoft.Json.JsonConvert.SerializeObject(i_Bloodtype));}
#region Body Section.
if ((i_Bloodtype.BLOODTYPE_ID == null) || (i_Bloodtype.BLOODTYPE_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Bloodtype"); }
i_Bloodtype.ENTRY_USER_ID = this.UserID;
i_Bloodtype.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Bloodtype.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Bloodtype_Execution)
{
_Stop_Edit_Bloodtype_Execution = false;
return;
}
i_Bloodtype.BLOODTYPE_ID = _AppContext.Edit_Bloodtype
(
i_Bloodtype.BLOODTYPE_ID
,i_Bloodtype.BLOODTYPE_SYMBOL
,i_Bloodtype.ENTRY_USER_ID
,i_Bloodtype.ENTRY_DATE
,i_Bloodtype.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Bloodtype");}
}
public void Edit_Client(Client i_Client) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Client.CLIENT_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Client");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Edit_Client",Newtonsoft.Json.JsonConvert.SerializeObject(i_Client));}
#region Body Section.
if ((i_Client.CLIENT_ID == null) || (i_Client.CLIENT_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Client"); }
i_Client.ENTRY_USER_ID = this.UserID;
i_Client.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Client.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Client_Execution)
{
_Stop_Edit_Client_Execution = false;
return;
}
i_Client.CLIENT_ID = _AppContext.Edit_Client
(
i_Client.CLIENT_ID
,i_Client.CLIENT_NAME
,i_Client.CLIENT_PH_NB
,i_Client.CLIENT_MAIL
,i_Client.CLIENT_DOB
,i_Client.BLOODTYPE_ID
,i_Client.ENTRY_USER_ID
,i_Client.ENTRY_DATE
,i_Client.OWNER_ID
,i_Client.CLIENT_GENDER
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Client");}
}
public void Edit_Client_fees(Client_fees i_Client_fees) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Client_fees.CLIENT_FEES_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Client_fees");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Edit_Client_fees",Newtonsoft.Json.JsonConvert.SerializeObject(i_Client_fees));}
#region Body Section.
if ((i_Client_fees.CLIENT_FEES_ID == null) || (i_Client_fees.CLIENT_FEES_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Client_fees"); }
i_Client_fees.ENTRY_USER_ID = this.UserID;
i_Client_fees.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Client_fees.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Client_fees_Execution)
{
_Stop_Edit_Client_fees_Execution = false;
return;
}
i_Client_fees.CLIENT_FEES_ID = _AppContext.Edit_Client_fees
(
i_Client_fees.CLIENT_FEES_ID
,i_Client_fees.CLIENT_ID
,i_Client_fees.CLIENT_FEES_DESCRIPTION
,i_Client_fees.ENTRY_USER_ID
,i_Client_fees.ENTRY_DATE
,i_Client_fees.OWNER_ID
,i_Client_fees.CURRENCY_ID
,i_Client_fees.PACKAGE_ID
,i_Client_fees.CLIENT_FEES_AMOUNT
,i_Client_fees.REGISTRATION_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Client_fees");}
}
public void Edit_Contact(Contact i_Contact) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Contact.CONTACT_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Contact");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Edit_Contact",Newtonsoft.Json.JsonConvert.SerializeObject(i_Contact));}
#region Body Section.
if ((i_Contact.CONTACT_ID == null) || (i_Contact.CONTACT_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Contact"); }
i_Contact.ENTRY_USER_ID = this.UserID;
i_Contact.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Contact.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Contact_Execution)
{
_Stop_Edit_Contact_Execution = false;
return;
}
i_Contact.CONTACT_ID = _AppContext.Edit_Contact
(
i_Contact.CONTACT_ID
,i_Contact.PERSON_ID
,i_Contact.CONTACT_TYPE_CODE
,i_Contact.CONTACT
,i_Contact.DESCRIPTION
,i_Contact.ENTRY_USER_ID
,i_Contact.ENTRY_DATE
,i_Contact.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Contact");}
}
public void Edit_Currency(Currency i_Currency) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Currency.CURRENCY_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Currency");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Edit_Currency",Newtonsoft.Json.JsonConvert.SerializeObject(i_Currency));}
#region Body Section.
if ((i_Currency.CURRENCY_ID == null) || (i_Currency.CURRENCY_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Currency"); }
i_Currency.ENTRY_USER_ID = this.UserID;
i_Currency.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Currency.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Currency_Execution)
{
_Stop_Edit_Currency_Execution = false;
return;
}
i_Currency.CURRENCY_ID = _AppContext.Edit_Currency
(
i_Currency.CURRENCY_ID
,i_Currency.CURRENCY_TYPE
,i_Currency.CURRENCY_SYMBOL
,i_Currency.ENTRY_USER_ID
,i_Currency.ENTRY_DATE
,i_Currency.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Currency");}
}
public void Edit_Fees(Fees i_Fees) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Fees.FEES_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Fees");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Edit_Fees",Newtonsoft.Json.JsonConvert.SerializeObject(i_Fees));}
#region Body Section.
if ((i_Fees.FEES_ID == null) || (i_Fees.FEES_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Fees"); }
i_Fees.ENTRY_USER_ID = this.UserID;
i_Fees.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Fees.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Fees_Execution)
{
_Stop_Edit_Fees_Execution = false;
return;
}
i_Fees.FEES_ID = _AppContext.Edit_Fees
(
i_Fees.FEES_ID
,i_Fees.FEES_DESCRIPTION
,i_Fees.FEES_AMOUNT
,i_Fees.CURRENCY_ID
,i_Fees.ENTRY_USER_ID
,i_Fees.ENTRY_DATE
,i_Fees.OWNER_ID
,i_Fees.FEES_ORIGIN_DATE
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Fees");}
}
public void Edit_Loc_l1(Loc_l1 i_Loc_l1) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Loc_l1.LOC_L1_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l1");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Edit_Loc_l1",Newtonsoft.Json.JsonConvert.SerializeObject(i_Loc_l1));}
#region Body Section.
if ((i_Loc_l1.LOC_L1_ID == null) || (i_Loc_l1.LOC_L1_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Loc_l1"); }
i_Loc_l1.ENTRY_USER_ID = this.UserID;
i_Loc_l1.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Loc_l1.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Loc_l1_Execution)
{
_Stop_Edit_Loc_l1_Execution = false;
return;
}
i_Loc_l1.LOC_L1_ID = _AppContext.Edit_Loc_l1
(
i_Loc_l1.LOC_L1_ID
,i_Loc_l1.CODE
,i_Loc_l1.DESCRIPTION
,i_Loc_l1.NOTES
,i_Loc_l1.ENTRY_DATE
,i_Loc_l1.ENTRY_USER_ID
,i_Loc_l1.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l1");}
}
public void Edit_Loc_l2(Loc_l2 i_Loc_l2) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Loc_l2.LOC_L2_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Edit_Loc_l2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Loc_l2));}
#region Body Section.
if ((i_Loc_l2.LOC_L2_ID == null) || (i_Loc_l2.LOC_L2_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Loc_l2"); }
i_Loc_l2.ENTRY_USER_ID = this.UserID;
i_Loc_l2.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Loc_l2.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Loc_l2_Execution)
{
_Stop_Edit_Loc_l2_Execution = false;
return;
}
i_Loc_l2.LOC_L2_ID = _AppContext.Edit_Loc_l2
(
i_Loc_l2.LOC_L2_ID
,i_Loc_l2.CODE
,i_Loc_l2.DESCRIPTION
,i_Loc_l2.LOC_L1_ID
,i_Loc_l2.NOTES
,i_Loc_l2.ENTRY_DATE
,i_Loc_l2.ENTRY_USER_ID
,i_Loc_l2.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l2");}
}
public void Edit_Loc_l3(Loc_l3 i_Loc_l3) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Loc_l3.LOC_L3_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l3");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Edit_Loc_l3",Newtonsoft.Json.JsonConvert.SerializeObject(i_Loc_l3));}
#region Body Section.
if ((i_Loc_l3.LOC_L3_ID == null) || (i_Loc_l3.LOC_L3_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Loc_l3"); }
i_Loc_l3.ENTRY_USER_ID = this.UserID;
i_Loc_l3.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Loc_l3.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Loc_l3_Execution)
{
_Stop_Edit_Loc_l3_Execution = false;
return;
}
i_Loc_l3.LOC_L3_ID = _AppContext.Edit_Loc_l3
(
i_Loc_l3.LOC_L3_ID
,i_Loc_l3.CODE
,i_Loc_l3.DESCRIPTION
,i_Loc_l3.LOC_L2_ID
,i_Loc_l3.NOTES
,i_Loc_l3.ENTRY_DATE
,i_Loc_l3.ENTRY_USER_ID
,i_Loc_l3.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l3");}
}
public void Edit_Loc_l4(Loc_l4 i_Loc_l4) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Loc_l4.LOC_L4_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l4");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Edit_Loc_l4",Newtonsoft.Json.JsonConvert.SerializeObject(i_Loc_l4));}
#region Body Section.
if ((i_Loc_l4.LOC_L4_ID == null) || (i_Loc_l4.LOC_L4_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Loc_l4"); }
i_Loc_l4.ENTRY_USER_ID = this.UserID;
i_Loc_l4.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Loc_l4.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Loc_l4_Execution)
{
_Stop_Edit_Loc_l4_Execution = false;
return;
}
i_Loc_l4.LOC_L4_ID = _AppContext.Edit_Loc_l4
(
i_Loc_l4.LOC_L4_ID
,i_Loc_l4.CODE
,i_Loc_l4.DESCRIPTION
,i_Loc_l4.LOC_L3_ID
,i_Loc_l4.NOTES
,i_Loc_l4.ENTRY_DATE
,i_Loc_l4.ENTRY_USER_ID
,i_Loc_l4.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l4");}
}
public void Edit_Method_run(Method_run i_Method_run) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Method_run.METHOD_RUN_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
#region Body Section.
if ((i_Method_run.METHOD_RUN_ID == null) || (i_Method_run.METHOD_RUN_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Method_run"); }
i_Method_run.ENTRY_USER_ID = this.UserID;
i_Method_run.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Method_run.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
#region PreEvent_Edit_Method_run
if (OnPreEvent_Edit_Method_run != null)
{
OnPreEvent_Edit_Method_run(i_Method_run,oEditMode_Flag);
}
#endregion
if (_Stop_Edit_Method_run_Execution)
{
_Stop_Edit_Method_run_Execution = false;
return;
}
i_Method_run.METHOD_RUN_ID = _AppContext.Edit_Method_run
(
i_Method_run.METHOD_RUN_ID
,i_Method_run.METHOD_NAME
,i_Method_run.RUN_DATE
,i_Method_run.RUN_HOUR
,i_Method_run.RUN_MINUTE
,i_Method_run.RUN_SECOND
,i_Method_run.IS_CACHED
,i_Method_run.EXECUTION_TIME
,i_Method_run.INPUT_PARAM
,i_Method_run.ENTRY_USER_ID
,i_Method_run.ENTRY_DATE
,i_Method_run.OWNER_ID
);
#region PostEvent_Edit_Method_run
if (OnPostEvent_Edit_Method_run != null)
{
OnPostEvent_Edit_Method_run(i_Method_run,oEditMode_Flag);
}
#endregion
oScope.Complete();
}
#endregion
}
public void Edit_Owner(Owner i_Owner) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Owner.OWNER_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Owner");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Edit_Owner",Newtonsoft.Json.JsonConvert.SerializeObject(i_Owner));}
#region Body Section.
if ((i_Owner.OWNER_ID == null) || (i_Owner.OWNER_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Owner"); }
i_Owner.ENTRY_DATE    = oTools.GetDateTimeString(DateTime.Now);
i_Owner.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Owner_Execution)
{
_Stop_Edit_Owner_Execution = false;
return;
}
i_Owner.OWNER_ID = _AppContext.Edit_Owner
(
i_Owner.OWNER_ID
,i_Owner.CODE
,i_Owner.MAINTENANCE_DUE_DATE
,i_Owner.DESCRIPTION
,i_Owner.ENTRY_DATE
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Owner");}
}
public void Edit_Package(Package i_Package) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Package.PACKAGE_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Package");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Edit_Package",Newtonsoft.Json.JsonConvert.SerializeObject(i_Package));}
#region Body Section.
if ((i_Package.PACKAGE_ID == null) || (i_Package.PACKAGE_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Package"); }
i_Package.ENTRY_USER_ID = this.UserID;
i_Package.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Package.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Package_Execution)
{
_Stop_Edit_Package_Execution = false;
return;
}
i_Package.PACKAGE_ID = _AppContext.Edit_Package
(
i_Package.PACKAGE_ID
,i_Package.PACKAGE_NAME
,i_Package.PACKAGE_PRICE
,i_Package.CURRENCY_ID
,i_Package.ENTRY_USER_ID
,i_Package.ENTRY_DATE
,i_Package.OWNER_ID
,i_Package.PACKAGE_SESSIONS_NB
,i_Package.PACKAGE_TYPE
,i_Package.PACKAGE_ENDING_DATE
,i_Package.PACKAGE_TIMELINE
,i_Package.PACKAGE_STARTING_DATE
,i_Package.PACKAGE_NB_OF_MONTH
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Package");}
}
public void Edit_Person(Person i_Person) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Person.PERSON_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Person");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Edit_Person",Newtonsoft.Json.JsonConvert.SerializeObject(i_Person));}
#region Body Section.
if ((i_Person.PERSON_ID == null) || (i_Person.PERSON_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Person"); }
i_Person.ENTRY_USER_ID = this.UserID;
i_Person.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Person.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Person_Execution)
{
_Stop_Edit_Person_Execution = false;
return;
}
i_Person.PERSON_ID = _AppContext.Edit_Person
(
i_Person.PERSON_ID
,i_Person.FIRST_NAME
,i_Person.LAST_NAME
,i_Person.FATHER_NAME
,i_Person.MOTHER_NAME
,i_Person.TITLE_CODE
,i_Person.GENDER_CODE
,i_Person.RELIGION_CODE
,i_Person.BIRTH_DATE
,i_Person.IS_BLOCKED
,i_Person.DESCRIPTION
,i_Person.OWNER_ID
,i_Person.ENTRY_USER_ID
,i_Person.ENTRY_DATE
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Person");}
}
public void Edit_Registration(Registration i_Registration) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Registration.REGISTRATION_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Registration");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Edit_Registration",Newtonsoft.Json.JsonConvert.SerializeObject(i_Registration));}
#region Body Section.
if ((i_Registration.REGISTRATION_ID == null) || (i_Registration.REGISTRATION_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Registration"); }
i_Registration.ENTRY_USER_ID = this.UserID;
i_Registration.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Registration.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Registration_Execution)
{
_Stop_Edit_Registration_Execution = false;
return;
}
i_Registration.REGISTRATION_ID = _AppContext.Edit_Registration
(
i_Registration.REGISTRATION_ID
,i_Registration.CLIENT_ID
,i_Registration.REGISTRATION_DATE
,i_Registration.PACKAGE_ID
,i_Registration.REGISTRATION_DISCOUNT
,i_Registration.REGISTRATION_TOTAL_PRICE
,i_Registration.CURRENCY_ID
,i_Registration.REGISTRATION_DESCRIPTION
,i_Registration.ENTRY_USER_ID
,i_Registration.ENTRY_DATE
,i_Registration.OWNER_ID
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Registration");}
}
public void Edit_Session(Session i_Session) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Session.SESSION_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Session");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Edit_Session",Newtonsoft.Json.JsonConvert.SerializeObject(i_Session));}
#region Body Section.
if ((i_Session.SESSION_ID == null) || (i_Session.SESSION_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Session"); }
i_Session.ENTRY_USER_ID = this.UserID;
i_Session.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Session.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Session_Execution)
{
_Stop_Edit_Session_Execution = false;
return;
}
i_Session.SESSION_ID = _AppContext.Edit_Session
(
i_Session.SESSION_ID
,i_Session.SESSION_STARTING_DATE
,i_Session.SESSION_ENDING_DATE
,i_Session.SESSION_ATTENDED
,i_Session.PACKAGE_ID
,i_Session.CLIENT_FEES_ID
,i_Session.ENTRY_USER_ID
,i_Session.ENTRY_DATE
,i_Session.OWNER_ID
,i_Session.DESCRIPTION
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Session");}
}
public void Edit_Staff(Staff i_Staff) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Staff.STAFF_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Staff");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Edit_Staff",Newtonsoft.Json.JsonConvert.SerializeObject(i_Staff));}
#region Body Section.
if ((i_Staff.STAFF_ID == null) || (i_Staff.STAFF_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Staff"); }
i_Staff.ENTRY_USER_ID = this.UserID;
i_Staff.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Staff.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Staff_Execution)
{
_Stop_Edit_Staff_Execution = false;
return;
}
i_Staff.STAFF_ID = _AppContext.Edit_Staff
(
i_Staff.STAFF_ID
,i_Staff.STAFF_NAME
,i_Staff.STAFF_PH_NB
,i_Staff.STAFF_MAIL
,i_Staff.STAFF_DOB
,i_Staff.BLOODTYPE_ID
,i_Staff.ENTRY_USER_ID
,i_Staff.ENTRY_DATE
,i_Staff.OWNER_ID
,i_Staff.STAFF_GENDER
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Staff");}
}
public void Edit_Staff_fees(Staff_fees i_Staff_fees) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Staff_fees.STAFF_FEES_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Staff_fees");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Edit_Staff_fees",Newtonsoft.Json.JsonConvert.SerializeObject(i_Staff_fees));}
#region Body Section.
if ((i_Staff_fees.STAFF_FEES_ID == null) || (i_Staff_fees.STAFF_FEES_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Staff_fees"); }
i_Staff_fees.ENTRY_USER_ID = this.UserID;
i_Staff_fees.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Staff_fees.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Staff_fees_Execution)
{
_Stop_Edit_Staff_fees_Execution = false;
return;
}
i_Staff_fees.STAFF_FEES_ID = _AppContext.Edit_Staff_fees
(
i_Staff_fees.STAFF_FEES_ID
,i_Staff_fees.STAFF_ID
,i_Staff_fees.STAFF_FEES_DESCRIPTION
,i_Staff_fees.ENTRY_USER_ID
,i_Staff_fees.ENTRY_DATE
,i_Staff_fees.OWNER_ID
,i_Staff_fees.CURRENCY_ID
,i_Staff_fees.STAFF_FEES_AMOUNT
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Staff_fees");}
}
public void Edit_Supplier(Supplier i_Supplier) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Supplier.SUPPLIER_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Supplier");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Edit_Supplier",Newtonsoft.Json.JsonConvert.SerializeObject(i_Supplier));}
#region Body Section.
if ((i_Supplier.SUPPLIER_ID == null) || (i_Supplier.SUPPLIER_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Supplier"); }
i_Supplier.ENTRY_USER_ID = this.UserID;
i_Supplier.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Supplier.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Supplier_Execution)
{
_Stop_Edit_Supplier_Execution = false;
return;
}
i_Supplier.SUPPLIER_ID = _AppContext.Edit_Supplier
(
i_Supplier.SUPPLIER_ID
,i_Supplier.SUPPLIER_NAME
,i_Supplier.SUPPLIER_PH_NB
,i_Supplier.SUPPLIER_MAIL
,i_Supplier.ENTRY_USER_ID
,i_Supplier.ENTRY_DATE
,i_Supplier.OWNER_ID
,i_Supplier.SUPPLIER_DOB
,i_Supplier.BLOODTYPE_ID
,i_Supplier.SUPPLIER_GENDER
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Supplier");}
}
public void Edit_Supplier_fees(Supplier_fees i_Supplier_fees) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_Supplier_fees.SUPPLIER_FEES_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Supplier_fees");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Edit_Supplier_fees",Newtonsoft.Json.JsonConvert.SerializeObject(i_Supplier_fees));}
#region Body Section.
if ((i_Supplier_fees.SUPPLIER_FEES_ID == null) || (i_Supplier_fees.SUPPLIER_FEES_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_Supplier_fees"); }
i_Supplier_fees.ENTRY_USER_ID = this.UserID;
i_Supplier_fees.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_Supplier_fees.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_Supplier_fees_Execution)
{
_Stop_Edit_Supplier_fees_Execution = false;
return;
}
i_Supplier_fees.SUPPLIER_FEES_ID = _AppContext.Edit_Supplier_fees
(
i_Supplier_fees.SUPPLIER_FEES_ID
,i_Supplier_fees.SUPPLIER_ID
,i_Supplier_fees.SUPPLIER_FEES_DESCRIPTION
,i_Supplier_fees.ENTRY_USER_ID
,i_Supplier_fees.ENTRY_DATE
,i_Supplier_fees.OWNER_ID
,i_Supplier_fees.CURRENCY_ID
,i_Supplier_fees.SUPPLIER_FEES_AMOUNT
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Supplier_fees");}
}
public void Edit_User(User i_User) 
{
Enum_EditMode oEditMode_Flag = Enum_EditMode.Update;
if (i_User.USER_ID == -1)
{
oEditMode_Flag = Enum_EditMode.Add;
}
if (OnPreEvent_General != null){OnPreEvent_General("Edit_User");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Edit_User",Newtonsoft.Json.JsonConvert.SerializeObject(i_User));}
#region Body Section.
if ((i_User.USER_ID == null) || (i_User.USER_ID == 0)) { throw new BLCException("Missing primary key while calling Edit_User"); }
i_User.ENTRY_DATE    = oTools.GetDateString(DateTime.Today);
i_User.OWNER_ID      = this.OwnerID;
using (TransactionScope oScope = new TransactionScope())
{
if (_Stop_Edit_User_Execution)
{
_Stop_Edit_User_Execution = false;
return;
}
i_User.USER_ID = _AppContext.Edit_User
(
i_User.USER_ID
,i_User.OWNER_ID
,i_User.USERNAME
,i_User.PASSWORD
,i_User.USER_TYPE_CODE
,i_User.IS_ACTIVE
,i_User.ENTRY_DATE
,i_User.USER_EMAIL
);
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_User");}
}
public void Edit_Address_List(List<Address> i_List_Address)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Address_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Address != null)
{
foreach (var oRow in i_List_Address)
{
Edit_Address(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Address_List");}
}
public void Edit_Address_List(Params_Edit_Address_List i_Params_Edit_Address_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Address_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Address_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Address_List.My_List_To_Delete)
{
Delete_Address(new Params_Delete_Address() { ADDRESS_ID = oRow.ADDRESS_ID });
}
}
if (i_Params_Edit_Address_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Address_List.My_List_To_Edit)
{
Edit_Address(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Address_List");}
}
public void Edit_Bloodtype_List(List<Bloodtype> i_List_Bloodtype)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Bloodtype_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Bloodtype != null)
{
foreach (var oRow in i_List_Bloodtype)
{
Edit_Bloodtype(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Bloodtype_List");}
}
public void Edit_Bloodtype_List(Params_Edit_Bloodtype_List i_Params_Edit_Bloodtype_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Bloodtype_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Bloodtype_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Bloodtype_List.My_List_To_Delete)
{
Delete_Bloodtype(new Params_Delete_Bloodtype() { BLOODTYPE_ID = oRow.BLOODTYPE_ID });
}
}
if (i_Params_Edit_Bloodtype_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Bloodtype_List.My_List_To_Edit)
{
Edit_Bloodtype(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Bloodtype_List");}
}
public void Edit_Client_List(List<Client> i_List_Client)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Client_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Client != null)
{
foreach (var oRow in i_List_Client)
{
Edit_Client(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Client_List");}
}
public void Edit_Client_List(Params_Edit_Client_List i_Params_Edit_Client_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Client_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Client_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Client_List.My_List_To_Delete)
{
Delete_Client(new Params_Delete_Client() { CLIENT_ID = oRow.CLIENT_ID });
}
}
if (i_Params_Edit_Client_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Client_List.My_List_To_Edit)
{
Edit_Client(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Client_List");}
}
public void Edit_Client_fees_List(List<Client_fees> i_List_Client_fees)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Client_fees_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Client_fees != null)
{
foreach (var oRow in i_List_Client_fees)
{
Edit_Client_fees(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Client_fees_List");}
}
public void Edit_Client_fees_List(Params_Edit_Client_fees_List i_Params_Edit_Client_fees_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Client_fees_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Client_fees_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Client_fees_List.My_List_To_Delete)
{
Delete_Client_fees(new Params_Delete_Client_fees() { CLIENT_FEES_ID = oRow.CLIENT_FEES_ID });
}
}
if (i_Params_Edit_Client_fees_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Client_fees_List.My_List_To_Edit)
{
Edit_Client_fees(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Client_fees_List");}
}
public void Edit_Contact_List(List<Contact> i_List_Contact)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Contact_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Contact != null)
{
foreach (var oRow in i_List_Contact)
{
Edit_Contact(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Contact_List");}
}
public void Edit_Contact_List(Params_Edit_Contact_List i_Params_Edit_Contact_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Contact_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Contact_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Contact_List.My_List_To_Delete)
{
Delete_Contact(new Params_Delete_Contact() { CONTACT_ID = oRow.CONTACT_ID });
}
}
if (i_Params_Edit_Contact_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Contact_List.My_List_To_Edit)
{
Edit_Contact(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Contact_List");}
}
public void Edit_Currency_List(List<Currency> i_List_Currency)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Currency_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Currency != null)
{
foreach (var oRow in i_List_Currency)
{
Edit_Currency(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Currency_List");}
}
public void Edit_Currency_List(Params_Edit_Currency_List i_Params_Edit_Currency_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Currency_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Currency_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Currency_List.My_List_To_Delete)
{
Delete_Currency(new Params_Delete_Currency() { CURRENCY_ID = oRow.CURRENCY_ID });
}
}
if (i_Params_Edit_Currency_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Currency_List.My_List_To_Edit)
{
Edit_Currency(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Currency_List");}
}
public void Edit_Fees_List(List<Fees> i_List_Fees)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Fees_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Fees != null)
{
foreach (var oRow in i_List_Fees)
{
Edit_Fees(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Fees_List");}
}
public void Edit_Fees_List(Params_Edit_Fees_List i_Params_Edit_Fees_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Fees_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Fees_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Fees_List.My_List_To_Delete)
{
Delete_Fees(new Params_Delete_Fees() { FEES_ID = oRow.FEES_ID });
}
}
if (i_Params_Edit_Fees_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Fees_List.My_List_To_Edit)
{
Edit_Fees(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Fees_List");}
}
public void Edit_Loc_l1_List(List<Loc_l1> i_List_Loc_l1)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l1_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Loc_l1 != null)
{
foreach (var oRow in i_List_Loc_l1)
{
Edit_Loc_l1(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l1_List");}
}
public void Edit_Loc_l1_List(Params_Edit_Loc_l1_List i_Params_Edit_Loc_l1_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l1_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Loc_l1_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Loc_l1_List.My_List_To_Delete)
{
Delete_Loc_l1(new Params_Delete_Loc_l1() { LOC_L1_ID = oRow.LOC_L1_ID });
}
}
if (i_Params_Edit_Loc_l1_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Loc_l1_List.My_List_To_Edit)
{
Edit_Loc_l1(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l1_List");}
}
public void Edit_Loc_l2_List(List<Loc_l2> i_List_Loc_l2)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l2_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Loc_l2 != null)
{
foreach (var oRow in i_List_Loc_l2)
{
Edit_Loc_l2(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l2_List");}
}
public void Edit_Loc_l2_List(Params_Edit_Loc_l2_List i_Params_Edit_Loc_l2_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l2_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Loc_l2_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Loc_l2_List.My_List_To_Delete)
{
Delete_Loc_l2(new Params_Delete_Loc_l2() { LOC_L2_ID = oRow.LOC_L2_ID });
}
}
if (i_Params_Edit_Loc_l2_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Loc_l2_List.My_List_To_Edit)
{
Edit_Loc_l2(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l2_List");}
}
public void Edit_Loc_l3_List(List<Loc_l3> i_List_Loc_l3)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l3_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Loc_l3 != null)
{
foreach (var oRow in i_List_Loc_l3)
{
Edit_Loc_l3(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l3_List");}
}
public void Edit_Loc_l3_List(Params_Edit_Loc_l3_List i_Params_Edit_Loc_l3_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l3_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Loc_l3_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Loc_l3_List.My_List_To_Delete)
{
Delete_Loc_l3(new Params_Delete_Loc_l3() { LOC_L3_ID = oRow.LOC_L3_ID });
}
}
if (i_Params_Edit_Loc_l3_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Loc_l3_List.My_List_To_Edit)
{
Edit_Loc_l3(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l3_List");}
}
public void Edit_Loc_l4_List(List<Loc_l4> i_List_Loc_l4)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l4_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Loc_l4 != null)
{
foreach (var oRow in i_List_Loc_l4)
{
Edit_Loc_l4(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l4_List");}
}
public void Edit_Loc_l4_List(Params_Edit_Loc_l4_List i_Params_Edit_Loc_l4_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Loc_l4_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Loc_l4_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Loc_l4_List.My_List_To_Delete)
{
Delete_Loc_l4(new Params_Delete_Loc_l4() { LOC_L4_ID = oRow.LOC_L4_ID });
}
}
if (i_Params_Edit_Loc_l4_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Loc_l4_List.My_List_To_Edit)
{
Edit_Loc_l4(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Loc_l4_List");}
}
public void Edit_Method_run_List(List<Method_run> i_List_Method_run)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Method_run_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Method_run != null)
{
foreach (var oRow in i_List_Method_run)
{
Edit_Method_run(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Method_run_List");}
}
public void Edit_Method_run_List(Params_Edit_Method_run_List i_Params_Edit_Method_run_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Method_run_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Method_run_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Method_run_List.My_List_To_Delete)
{
Delete_Method_run(new Params_Delete_Method_run() { METHOD_RUN_ID = oRow.METHOD_RUN_ID });
}
}
if (i_Params_Edit_Method_run_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Method_run_List.My_List_To_Edit)
{
Edit_Method_run(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Method_run_List");}
}
public void Edit_Owner_List(List<Owner> i_List_Owner)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Owner_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Owner != null)
{
foreach (var oRow in i_List_Owner)
{
Edit_Owner(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Owner_List");}
}
public void Edit_Owner_List(Params_Edit_Owner_List i_Params_Edit_Owner_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Owner_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Owner_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Owner_List.My_List_To_Delete)
{
Delete_Owner(new Params_Delete_Owner() { OWNER_ID = oRow.OWNER_ID });
}
}
if (i_Params_Edit_Owner_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Owner_List.My_List_To_Edit)
{
Edit_Owner(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Owner_List");}
}
public void Edit_Package_List(List<Package> i_List_Package)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Package_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Package != null)
{
foreach (var oRow in i_List_Package)
{
Edit_Package(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Package_List");}
}
public void Edit_Package_List(Params_Edit_Package_List i_Params_Edit_Package_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Package_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Package_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Package_List.My_List_To_Delete)
{
Delete_Package(new Params_Delete_Package() { PACKAGE_ID = oRow.PACKAGE_ID });
}
}
if (i_Params_Edit_Package_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Package_List.My_List_To_Edit)
{
Edit_Package(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Package_List");}
}
public void Edit_Person_List(List<Person> i_List_Person)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Person_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Person != null)
{
foreach (var oRow in i_List_Person)
{
Edit_Person(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Person_List");}
}
public void Edit_Person_List(Params_Edit_Person_List i_Params_Edit_Person_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Person_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Person_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Person_List.My_List_To_Delete)
{
Delete_Person(new Params_Delete_Person() { PERSON_ID = oRow.PERSON_ID });
}
}
if (i_Params_Edit_Person_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Person_List.My_List_To_Edit)
{
Edit_Person(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Person_List");}
}
public void Edit_Registration_List(List<Registration> i_List_Registration)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Registration_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Registration != null)
{
foreach (var oRow in i_List_Registration)
{
Edit_Registration(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Registration_List");}
}
public void Edit_Registration_List(Params_Edit_Registration_List i_Params_Edit_Registration_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Registration_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Registration_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Registration_List.My_List_To_Delete)
{
Delete_Registration(new Params_Delete_Registration() { REGISTRATION_ID = oRow.REGISTRATION_ID });
}
}
if (i_Params_Edit_Registration_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Registration_List.My_List_To_Edit)
{
Edit_Registration(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Registration_List");}
}
public void Edit_Session_List(List<Session> i_List_Session)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Session_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Session != null)
{
foreach (var oRow in i_List_Session)
{
Edit_Session(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Session_List");}
}
public void Edit_Session_List(Params_Edit_Session_List i_Params_Edit_Session_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Session_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Session_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Session_List.My_List_To_Delete)
{
Delete_Session(new Params_Delete_Session() { SESSION_ID = oRow.SESSION_ID });
}
}
if (i_Params_Edit_Session_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Session_List.My_List_To_Edit)
{
Edit_Session(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Session_List");}
}
public void Edit_Staff_List(List<Staff> i_List_Staff)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Staff_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Staff != null)
{
foreach (var oRow in i_List_Staff)
{
Edit_Staff(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Staff_List");}
}
public void Edit_Staff_List(Params_Edit_Staff_List i_Params_Edit_Staff_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Staff_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Staff_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Staff_List.My_List_To_Delete)
{
Delete_Staff(new Params_Delete_Staff() { STAFF_ID = oRow.STAFF_ID });
}
}
if (i_Params_Edit_Staff_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Staff_List.My_List_To_Edit)
{
Edit_Staff(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Staff_List");}
}
public void Edit_Staff_fees_List(List<Staff_fees> i_List_Staff_fees)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Staff_fees_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Staff_fees != null)
{
foreach (var oRow in i_List_Staff_fees)
{
Edit_Staff_fees(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Staff_fees_List");}
}
public void Edit_Staff_fees_List(Params_Edit_Staff_fees_List i_Params_Edit_Staff_fees_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Staff_fees_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Staff_fees_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Staff_fees_List.My_List_To_Delete)
{
Delete_Staff_fees(new Params_Delete_Staff_fees() { STAFF_FEES_ID = oRow.STAFF_FEES_ID });
}
}
if (i_Params_Edit_Staff_fees_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Staff_fees_List.My_List_To_Edit)
{
Edit_Staff_fees(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Staff_fees_List");}
}
public void Edit_Supplier_List(List<Supplier> i_List_Supplier)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Supplier_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Supplier != null)
{
foreach (var oRow in i_List_Supplier)
{
Edit_Supplier(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Supplier_List");}
}
public void Edit_Supplier_List(Params_Edit_Supplier_List i_Params_Edit_Supplier_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Supplier_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Supplier_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Supplier_List.My_List_To_Delete)
{
Delete_Supplier(new Params_Delete_Supplier() { SUPPLIER_ID = oRow.SUPPLIER_ID });
}
}
if (i_Params_Edit_Supplier_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Supplier_List.My_List_To_Edit)
{
Edit_Supplier(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Supplier_List");}
}
public void Edit_Supplier_fees_List(List<Supplier_fees> i_List_Supplier_fees)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Supplier_fees_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_Supplier_fees != null)
{
foreach (var oRow in i_List_Supplier_fees)
{
Edit_Supplier_fees(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Supplier_fees_List");}
}
public void Edit_Supplier_fees_List(Params_Edit_Supplier_fees_List i_Params_Edit_Supplier_fees_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_Supplier_fees_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_Supplier_fees_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_Supplier_fees_List.My_List_To_Delete)
{
Delete_Supplier_fees(new Params_Delete_Supplier_fees() { SUPPLIER_FEES_ID = oRow.SUPPLIER_FEES_ID });
}
}
if (i_Params_Edit_Supplier_fees_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_Supplier_fees_List.My_List_To_Edit)
{
Edit_Supplier_fees(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_Supplier_fees_List");}
}
public void Edit_User_List(List<User> i_List_User)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_User_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_List_User != null)
{
foreach (var oRow in i_List_User)
{
Edit_User(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_User_List");}
}
public void Edit_User_List(Params_Edit_User_List i_Params_Edit_User_List)
{
if (OnPreEvent_General != null){OnPreEvent_General("Edit_User_List");}
#region Body Section.
using (TransactionScope oScope = new TransactionScope())
{
if (i_Params_Edit_User_List.My_List_To_Delete != null)
{
foreach (var oRow in i_Params_Edit_User_List.My_List_To_Delete)
{
Delete_User(new Params_Delete_User() { USER_ID = oRow.USER_ID });
}
}
if (i_Params_Edit_User_List.My_List_To_Edit != null)
{
foreach (var oRow in i_Params_Edit_User_List.My_List_To_Edit)
{
Edit_User(oRow);
}
}
oScope.Complete();
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Edit_User_List");}
}
}
}
