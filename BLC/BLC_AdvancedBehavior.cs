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
public Address Get_Address_By_ADDRESS_ID_Adv(Params_Get_Address_By_ADDRESS_ID i_Params_Get_Address_By_ADDRESS_ID)
{
Address oAddress = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_ADDRESS_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_ADDRESS_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_ADDRESS_ID));}
#region Body Section.
DALC.Address oDBEntry = _AppContext.Get_Address_By_ADDRESS_ID_Adv(i_Params_Get_Address_By_ADDRESS_ID.ADDRESS_ID);
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_ADDRESS_ID_Adv");}
return oAddress;
}
public Bloodtype Get_Bloodtype_By_BLOODTYPE_ID_Adv(Params_Get_Bloodtype_By_BLOODTYPE_ID i_Params_Get_Bloodtype_By_BLOODTYPE_ID)
{
Bloodtype oBloodtype = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Bloodtype_By_BLOODTYPE_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Bloodtype_By_BLOODTYPE_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Bloodtype_By_BLOODTYPE_ID));}
#region Body Section.
DALC.Bloodtype oDBEntry = _AppContext.Get_Bloodtype_By_BLOODTYPE_ID_Adv(i_Params_Get_Bloodtype_By_BLOODTYPE_ID.BLOODTYPE_ID);
oBloodtype = new Bloodtype();
oTools.CopyPropValues(oDBEntry, oBloodtype);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Bloodtype_By_BLOODTYPE_ID_Adv");}
return oBloodtype;
}
public Client Get_Client_By_CLIENT_ID_Adv(Params_Get_Client_By_CLIENT_ID i_Params_Get_Client_By_CLIENT_ID)
{
Client oClient = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_By_CLIENT_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Client_By_CLIENT_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Client_By_CLIENT_ID));}
#region Body Section.
DALC.Client oDBEntry = _AppContext.Get_Client_By_CLIENT_ID_Adv(i_Params_Get_Client_By_CLIENT_ID.CLIENT_ID);
oClient = new Client();
oTools.CopyPropValues(oDBEntry, oClient);
oClient.My_Bloodtype = new Bloodtype();
oTools.CopyPropValues(oDBEntry.My_Bloodtype, oClient.My_Bloodtype);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_By_CLIENT_ID_Adv");}
return oClient;
}
public Client_fees Get_Client_fees_By_CLIENT_FEES_ID_Adv(Params_Get_Client_fees_By_CLIENT_FEES_ID i_Params_Get_Client_fees_By_CLIENT_FEES_ID)
{
Client_fees oClient_fees = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_fees_By_CLIENT_FEES_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Client_fees_By_CLIENT_FEES_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Client_fees_By_CLIENT_FEES_ID));}
#region Body Section.
DALC.Client_fees oDBEntry = _AppContext.Get_Client_fees_By_CLIENT_FEES_ID_Adv(i_Params_Get_Client_fees_By_CLIENT_FEES_ID.CLIENT_FEES_ID);
oClient_fees = new Client_fees();
oTools.CopyPropValues(oDBEntry, oClient_fees);
oClient_fees.My_Client = new Client();
oTools.CopyPropValues(oDBEntry.My_Client, oClient_fees.My_Client);
oClient_fees.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oClient_fees.My_Currency);
oClient_fees.My_Package = new Package();
oTools.CopyPropValues(oDBEntry.My_Package, oClient_fees.My_Package);
oClient_fees.My_Registration = new Registration();
oTools.CopyPropValues(oDBEntry.My_Registration, oClient_fees.My_Registration);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_fees_By_CLIENT_FEES_ID_Adv");}
return oClient_fees;
}
public Contact Get_Contact_By_CONTACT_ID_Adv(Params_Get_Contact_By_CONTACT_ID i_Params_Get_Contact_By_CONTACT_ID)
{
Contact oContact = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_CONTACT_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Contact_By_CONTACT_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Contact_By_CONTACT_ID));}
#region Body Section.
DALC.Contact oDBEntry = _AppContext.Get_Contact_By_CONTACT_ID_Adv(i_Params_Get_Contact_By_CONTACT_ID.CONTACT_ID);
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oContact.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oContact.My_Person);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_CONTACT_ID_Adv");}
return oContact;
}
public Currency Get_Currency_By_CURRENCY_ID_Adv(Params_Get_Currency_By_CURRENCY_ID i_Params_Get_Currency_By_CURRENCY_ID)
{
Currency oCurrency = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Currency_By_CURRENCY_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Currency_By_CURRENCY_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Currency_By_CURRENCY_ID));}
#region Body Section.
DALC.Currency oDBEntry = _AppContext.Get_Currency_By_CURRENCY_ID_Adv(i_Params_Get_Currency_By_CURRENCY_ID.CURRENCY_ID);
oCurrency = new Currency();
oTools.CopyPropValues(oDBEntry, oCurrency);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Currency_By_CURRENCY_ID_Adv");}
return oCurrency;
}
public Fees Get_Fees_By_FEES_ID_Adv(Params_Get_Fees_By_FEES_ID i_Params_Get_Fees_By_FEES_ID)
{
Fees oFees = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Fees_By_FEES_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Fees_By_FEES_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Fees_By_FEES_ID));}
#region Body Section.
DALC.Fees oDBEntry = _AppContext.Get_Fees_By_FEES_ID_Adv(i_Params_Get_Fees_By_FEES_ID.FEES_ID);
oFees = new Fees();
oTools.CopyPropValues(oDBEntry, oFees);
oFees.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oFees.My_Currency);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Fees_By_FEES_ID_Adv");}
return oFees;
}
public Loc_l1 Get_Loc_l1_By_LOC_L1_ID_Adv(Params_Get_Loc_l1_By_LOC_L1_ID i_Params_Get_Loc_l1_By_LOC_L1_ID)
{
Loc_l1 oLoc_l1 = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l1_By_LOC_L1_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l1_By_LOC_L1_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l1_By_LOC_L1_ID));}
#region Body Section.
DALC.Loc_l1 oDBEntry = _AppContext.Get_Loc_l1_By_LOC_L1_ID_Adv(i_Params_Get_Loc_l1_By_LOC_L1_ID.LOC_L1_ID);
oLoc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry, oLoc_l1);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l1_By_LOC_L1_ID_Adv");}
return oLoc_l1;
}
public Loc_l2 Get_Loc_l2_By_LOC_L2_ID_Adv(Params_Get_Loc_l2_By_LOC_L2_ID i_Params_Get_Loc_l2_By_LOC_L2_ID)
{
Loc_l2 oLoc_l2 = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_LOC_L2_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l2_By_LOC_L2_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l2_By_LOC_L2_ID));}
#region Body Section.
DALC.Loc_l2 oDBEntry = _AppContext.Get_Loc_l2_By_LOC_L2_ID_Adv(i_Params_Get_Loc_l2_By_LOC_L2_ID.LOC_L2_ID);
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oLoc_l2.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oLoc_l2.My_Loc_l1);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_LOC_L2_ID_Adv");}
return oLoc_l2;
}
public Loc_l3 Get_Loc_l3_By_LOC_L3_ID_Adv(Params_Get_Loc_l3_By_LOC_L3_ID i_Params_Get_Loc_l3_By_LOC_L3_ID)
{
Loc_l3 oLoc_l3 = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_LOC_L3_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l3_By_LOC_L3_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l3_By_LOC_L3_ID));}
#region Body Section.
DALC.Loc_l3 oDBEntry = _AppContext.Get_Loc_l3_By_LOC_L3_ID_Adv(i_Params_Get_Loc_l3_By_LOC_L3_ID.LOC_L3_ID);
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oLoc_l3.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oLoc_l3.My_Loc_l2);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_LOC_L3_ID_Adv");}
return oLoc_l3;
}
public Loc_l4 Get_Loc_l4_By_LOC_L4_ID_Adv(Params_Get_Loc_l4_By_LOC_L4_ID i_Params_Get_Loc_l4_By_LOC_L4_ID)
{
Loc_l4 oLoc_l4 = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_LOC_L4_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l4_By_LOC_L4_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l4_By_LOC_L4_ID));}
#region Body Section.
DALC.Loc_l4 oDBEntry = _AppContext.Get_Loc_l4_By_LOC_L4_ID_Adv(i_Params_Get_Loc_l4_By_LOC_L4_ID.LOC_L4_ID);
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oLoc_l4.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oLoc_l4.My_Loc_l3);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_LOC_L4_ID_Adv");}
return oLoc_l4;
}
public Method_run Get_Method_run_By_METHOD_RUN_ID_Adv(Params_Get_Method_run_By_METHOD_RUN_ID i_Params_Get_Method_run_By_METHOD_RUN_ID)
{
Method_run oMethod_run = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Method_run_By_METHOD_RUN_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Method_run_By_METHOD_RUN_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Method_run_By_METHOD_RUN_ID));}
#region Body Section.
DALC.Method_run oDBEntry = _AppContext.Get_Method_run_By_METHOD_RUN_ID_Adv(i_Params_Get_Method_run_By_METHOD_RUN_ID.METHOD_RUN_ID);
oMethod_run = new Method_run();
oTools.CopyPropValues(oDBEntry, oMethod_run);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Method_run_By_METHOD_RUN_ID_Adv");}
return oMethod_run;
}
public Package Get_Package_By_PACKAGE_ID_Adv(Params_Get_Package_By_PACKAGE_ID i_Params_Get_Package_By_PACKAGE_ID)
{
Package oPackage = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Package_By_PACKAGE_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Package_By_PACKAGE_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Package_By_PACKAGE_ID));}
#region Body Section.
DALC.Package oDBEntry = _AppContext.Get_Package_By_PACKAGE_ID_Adv(i_Params_Get_Package_By_PACKAGE_ID.PACKAGE_ID);
oPackage = new Package();
oTools.CopyPropValues(oDBEntry, oPackage);
oPackage.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oPackage.My_Currency);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Package_By_PACKAGE_ID_Adv");}
return oPackage;
}
public Person Get_Person_By_PERSON_ID_Adv(Params_Get_Person_By_PERSON_ID i_Params_Get_Person_By_PERSON_ID)
{
Person oPerson = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Person_By_PERSON_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Person_By_PERSON_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Person_By_PERSON_ID));}
#region Body Section.
DALC.Person oDBEntry = _AppContext.Get_Person_By_PERSON_ID_Adv(i_Params_Get_Person_By_PERSON_ID.PERSON_ID);
oPerson = new Person();
oTools.CopyPropValues(oDBEntry, oPerson);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Person_By_PERSON_ID_Adv");}
return oPerson;
}
public Registration Get_Registration_By_REGISTRATION_ID_Adv(Params_Get_Registration_By_REGISTRATION_ID i_Params_Get_Registration_By_REGISTRATION_ID)
{
Registration oRegistration = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Registration_By_REGISTRATION_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Registration_By_REGISTRATION_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Registration_By_REGISTRATION_ID));}
#region Body Section.
DALC.Registration oDBEntry = _AppContext.Get_Registration_By_REGISTRATION_ID_Adv(i_Params_Get_Registration_By_REGISTRATION_ID.REGISTRATION_ID);
oRegistration = new Registration();
oTools.CopyPropValues(oDBEntry, oRegistration);
oRegistration.My_Client = new Client();
oTools.CopyPropValues(oDBEntry.My_Client, oRegistration.My_Client);
oRegistration.My_Package = new Package();
oTools.CopyPropValues(oDBEntry.My_Package, oRegistration.My_Package);
oRegistration.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oRegistration.My_Currency);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Registration_By_REGISTRATION_ID_Adv");}
return oRegistration;
}
public Session Get_Session_By_SESSION_ID_Adv(Params_Get_Session_By_SESSION_ID i_Params_Get_Session_By_SESSION_ID)
{
Session oSession = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Session_By_SESSION_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Session_By_SESSION_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Session_By_SESSION_ID));}
#region Body Section.
DALC.Session oDBEntry = _AppContext.Get_Session_By_SESSION_ID_Adv(i_Params_Get_Session_By_SESSION_ID.SESSION_ID);
oSession = new Session();
oTools.CopyPropValues(oDBEntry, oSession);
oSession.My_Package = new Package();
oTools.CopyPropValues(oDBEntry.My_Package, oSession.My_Package);
oSession.My_Client_fees = new Client_fees();
oTools.CopyPropValues(oDBEntry.My_Client_fees, oSession.My_Client_fees);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Session_By_SESSION_ID_Adv");}
return oSession;
}
public Staff Get_Staff_By_STAFF_ID_Adv(Params_Get_Staff_By_STAFF_ID i_Params_Get_Staff_By_STAFF_ID)
{
Staff oStaff = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_By_STAFF_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_By_STAFF_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_By_STAFF_ID));}
#region Body Section.
DALC.Staff oDBEntry = _AppContext.Get_Staff_By_STAFF_ID_Adv(i_Params_Get_Staff_By_STAFF_ID.STAFF_ID);
oStaff = new Staff();
oTools.CopyPropValues(oDBEntry, oStaff);
oStaff.My_Bloodtype = new Bloodtype();
oTools.CopyPropValues(oDBEntry.My_Bloodtype, oStaff.My_Bloodtype);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_By_STAFF_ID_Adv");}
return oStaff;
}
public Staff_fees Get_Staff_fees_By_STAFF_FEES_ID_Adv(Params_Get_Staff_fees_By_STAFF_FEES_ID i_Params_Get_Staff_fees_By_STAFF_FEES_ID)
{
Staff_fees oStaff_fees = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_fees_By_STAFF_FEES_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_fees_By_STAFF_FEES_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_fees_By_STAFF_FEES_ID));}
#region Body Section.
DALC.Staff_fees oDBEntry = _AppContext.Get_Staff_fees_By_STAFF_FEES_ID_Adv(i_Params_Get_Staff_fees_By_STAFF_FEES_ID.STAFF_FEES_ID);
oStaff_fees = new Staff_fees();
oTools.CopyPropValues(oDBEntry, oStaff_fees);
oStaff_fees.My_Staff = new Staff();
oTools.CopyPropValues(oDBEntry.My_Staff, oStaff_fees.My_Staff);
oStaff_fees.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oStaff_fees.My_Currency);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_fees_By_STAFF_FEES_ID_Adv");}
return oStaff_fees;
}
public Supplier Get_Supplier_By_SUPPLIER_ID_Adv(Params_Get_Supplier_By_SUPPLIER_ID i_Params_Get_Supplier_By_SUPPLIER_ID)
{
Supplier oSupplier = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_By_SUPPLIER_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_By_SUPPLIER_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_By_SUPPLIER_ID));}
#region Body Section.
DALC.Supplier oDBEntry = _AppContext.Get_Supplier_By_SUPPLIER_ID_Adv(i_Params_Get_Supplier_By_SUPPLIER_ID.SUPPLIER_ID);
oSupplier = new Supplier();
oTools.CopyPropValues(oDBEntry, oSupplier);
oSupplier.My_Bloodtype = new Bloodtype();
oTools.CopyPropValues(oDBEntry.My_Bloodtype, oSupplier.My_Bloodtype);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_By_SUPPLIER_ID_Adv");}
return oSupplier;
}
public Supplier_fees Get_Supplier_fees_By_SUPPLIER_FEES_ID_Adv(Params_Get_Supplier_fees_By_SUPPLIER_FEES_ID i_Params_Get_Supplier_fees_By_SUPPLIER_FEES_ID)
{
Supplier_fees oSupplier_fees = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_fees_By_SUPPLIER_FEES_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_fees_By_SUPPLIER_FEES_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_fees_By_SUPPLIER_FEES_ID));}
#region Body Section.
DALC.Supplier_fees oDBEntry = _AppContext.Get_Supplier_fees_By_SUPPLIER_FEES_ID_Adv(i_Params_Get_Supplier_fees_By_SUPPLIER_FEES_ID.SUPPLIER_FEES_ID);
oSupplier_fees = new Supplier_fees();
oTools.CopyPropValues(oDBEntry, oSupplier_fees);
oSupplier_fees.My_Supplier = new Supplier();
oTools.CopyPropValues(oDBEntry.My_Supplier, oSupplier_fees.My_Supplier);
oSupplier_fees.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oSupplier_fees.My_Currency);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_fees_By_SUPPLIER_FEES_ID_Adv");}
return oSupplier_fees;
}
public User Get_User_By_USER_ID_Adv(Params_Get_User_By_USER_ID i_Params_Get_User_By_USER_ID)
{
User oUser = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_USER_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_User_By_USER_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_User_By_USER_ID));}
#region Body Section.
DALC.User oDBEntry = _AppContext.Get_User_By_USER_ID_Adv(i_Params_Get_User_By_USER_ID.USER_ID);
oUser = new User();
oTools.CopyPropValues(oDBEntry, oUser);
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_USER_ID_Adv");}
return oUser;
}
public List<Address> Get_Address_By_ADDRESS_ID_List_Adv(Params_Get_Address_By_ADDRESS_ID_List i_Params_Get_Address_By_ADDRESS_ID_List)
{
Address oAddress = null;
List<Address> oList = new List<Address>();
Params_Get_Address_By_ADDRESS_ID_List_SP oParams_Get_Address_By_ADDRESS_ID_List_SP = new Params_Get_Address_By_ADDRESS_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_ADDRESS_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_ADDRESS_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_ADDRESS_ID_List));}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_ADDRESS_ID_List_Adv(i_Params_Get_Address_By_ADDRESS_ID_List.ADDRESS_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_ADDRESS_ID_List_Adv");}
return oList;
}
public List<Bloodtype> Get_Bloodtype_By_BLOODTYPE_ID_List_Adv(Params_Get_Bloodtype_By_BLOODTYPE_ID_List i_Params_Get_Bloodtype_By_BLOODTYPE_ID_List)
{
Bloodtype oBloodtype = null;
List<Bloodtype> oList = new List<Bloodtype>();
Params_Get_Bloodtype_By_BLOODTYPE_ID_List_SP oParams_Get_Bloodtype_By_BLOODTYPE_ID_List_SP = new Params_Get_Bloodtype_By_BLOODTYPE_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Bloodtype_By_BLOODTYPE_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Bloodtype_By_BLOODTYPE_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Bloodtype_By_BLOODTYPE_ID_List));}
#region Body Section.
List<DALC.Bloodtype> oList_DBEntries = _AppContext.Get_Bloodtype_By_BLOODTYPE_ID_List_Adv(i_Params_Get_Bloodtype_By_BLOODTYPE_ID_List.BLOODTYPE_ID_LIST);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Bloodtype_By_BLOODTYPE_ID_List_Adv");}
return oList;
}
public List<Client> Get_Client_By_CLIENT_ID_List_Adv(Params_Get_Client_By_CLIENT_ID_List i_Params_Get_Client_By_CLIENT_ID_List)
{
Client oClient = null;
List<Client> oList = new List<Client>();
Params_Get_Client_By_CLIENT_ID_List_SP oParams_Get_Client_By_CLIENT_ID_List_SP = new Params_Get_Client_By_CLIENT_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_By_CLIENT_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Client_By_CLIENT_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Client_By_CLIENT_ID_List));}
#region Body Section.
List<DALC.Client> oList_DBEntries = _AppContext.Get_Client_By_CLIENT_ID_List_Adv(i_Params_Get_Client_By_CLIENT_ID_List.CLIENT_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oClient = new Client();
oTools.CopyPropValues(oDBEntry, oClient);
oClient.My_Bloodtype = new Bloodtype();
oTools.CopyPropValues(oDBEntry.My_Bloodtype, oClient.My_Bloodtype);
oList.Add(oClient);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_By_CLIENT_ID_List_Adv");}
return oList;
}
public List<Client_fees> Get_Client_fees_By_CLIENT_FEES_ID_List_Adv(Params_Get_Client_fees_By_CLIENT_FEES_ID_List i_Params_Get_Client_fees_By_CLIENT_FEES_ID_List)
{
Client_fees oClient_fees = null;
List<Client_fees> oList = new List<Client_fees>();
Params_Get_Client_fees_By_CLIENT_FEES_ID_List_SP oParams_Get_Client_fees_By_CLIENT_FEES_ID_List_SP = new Params_Get_Client_fees_By_CLIENT_FEES_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_fees_By_CLIENT_FEES_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Client_fees_By_CLIENT_FEES_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Client_fees_By_CLIENT_FEES_ID_List));}
#region Body Section.
List<DALC.Client_fees> oList_DBEntries = _AppContext.Get_Client_fees_By_CLIENT_FEES_ID_List_Adv(i_Params_Get_Client_fees_By_CLIENT_FEES_ID_List.CLIENT_FEES_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oClient_fees = new Client_fees();
oTools.CopyPropValues(oDBEntry, oClient_fees);
oClient_fees.My_Client = new Client();
oTools.CopyPropValues(oDBEntry.My_Client, oClient_fees.My_Client);
oClient_fees.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oClient_fees.My_Currency);
oClient_fees.My_Package = new Package();
oTools.CopyPropValues(oDBEntry.My_Package, oClient_fees.My_Package);
oClient_fees.My_Registration = new Registration();
oTools.CopyPropValues(oDBEntry.My_Registration, oClient_fees.My_Registration);
oList.Add(oClient_fees);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_fees_By_CLIENT_FEES_ID_List_Adv");}
return oList;
}
public List<Contact> Get_Contact_By_CONTACT_ID_List_Adv(Params_Get_Contact_By_CONTACT_ID_List i_Params_Get_Contact_By_CONTACT_ID_List)
{
Contact oContact = null;
List<Contact> oList = new List<Contact>();
Params_Get_Contact_By_CONTACT_ID_List_SP oParams_Get_Contact_By_CONTACT_ID_List_SP = new Params_Get_Contact_By_CONTACT_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_CONTACT_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Contact_By_CONTACT_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Contact_By_CONTACT_ID_List));}
#region Body Section.
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_CONTACT_ID_List_Adv(i_Params_Get_Contact_By_CONTACT_ID_List.CONTACT_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oContact.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oContact.My_Person);
oList.Add(oContact);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_CONTACT_ID_List_Adv");}
return oList;
}
public List<Currency> Get_Currency_By_CURRENCY_ID_List_Adv(Params_Get_Currency_By_CURRENCY_ID_List i_Params_Get_Currency_By_CURRENCY_ID_List)
{
Currency oCurrency = null;
List<Currency> oList = new List<Currency>();
Params_Get_Currency_By_CURRENCY_ID_List_SP oParams_Get_Currency_By_CURRENCY_ID_List_SP = new Params_Get_Currency_By_CURRENCY_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Currency_By_CURRENCY_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Currency_By_CURRENCY_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Currency_By_CURRENCY_ID_List));}
#region Body Section.
List<DALC.Currency> oList_DBEntries = _AppContext.Get_Currency_By_CURRENCY_ID_List_Adv(i_Params_Get_Currency_By_CURRENCY_ID_List.CURRENCY_ID_LIST);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Currency_By_CURRENCY_ID_List_Adv");}
return oList;
}
public List<Fees> Get_Fees_By_FEES_ID_List_Adv(Params_Get_Fees_By_FEES_ID_List i_Params_Get_Fees_By_FEES_ID_List)
{
Fees oFees = null;
List<Fees> oList = new List<Fees>();
Params_Get_Fees_By_FEES_ID_List_SP oParams_Get_Fees_By_FEES_ID_List_SP = new Params_Get_Fees_By_FEES_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Fees_By_FEES_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Fees_By_FEES_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Fees_By_FEES_ID_List));}
#region Body Section.
List<DALC.Fees> oList_DBEntries = _AppContext.Get_Fees_By_FEES_ID_List_Adv(i_Params_Get_Fees_By_FEES_ID_List.FEES_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFees = new Fees();
oTools.CopyPropValues(oDBEntry, oFees);
oFees.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oFees.My_Currency);
oList.Add(oFees);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Fees_By_FEES_ID_List_Adv");}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_LOC_L1_ID_List_Adv(Params_Get_Loc_l1_By_LOC_L1_ID_List i_Params_Get_Loc_l1_By_LOC_L1_ID_List)
{
Loc_l1 oLoc_l1 = null;
List<Loc_l1> oList = new List<Loc_l1>();
Params_Get_Loc_l1_By_LOC_L1_ID_List_SP oParams_Get_Loc_l1_By_LOC_L1_ID_List_SP = new Params_Get_Loc_l1_By_LOC_L1_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l1_By_LOC_L1_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l1_By_LOC_L1_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l1_By_LOC_L1_ID_List));}
#region Body Section.
List<DALC.Loc_l1> oList_DBEntries = _AppContext.Get_Loc_l1_By_LOC_L1_ID_List_Adv(i_Params_Get_Loc_l1_By_LOC_L1_ID_List.LOC_L1_ID_LIST);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l1_By_LOC_L1_ID_List_Adv");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L2_ID_List_Adv(Params_Get_Loc_l2_By_LOC_L2_ID_List i_Params_Get_Loc_l2_By_LOC_L2_ID_List)
{
Loc_l2 oLoc_l2 = null;
List<Loc_l2> oList = new List<Loc_l2>();
Params_Get_Loc_l2_By_LOC_L2_ID_List_SP oParams_Get_Loc_l2_By_LOC_L2_ID_List_SP = new Params_Get_Loc_l2_By_LOC_L2_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_LOC_L2_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l2_By_LOC_L2_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l2_By_LOC_L2_ID_List));}
#region Body Section.
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_LOC_L2_ID_List_Adv(i_Params_Get_Loc_l2_By_LOC_L2_ID_List.LOC_L2_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oLoc_l2.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oLoc_l2.My_Loc_l1);
oList.Add(oLoc_l2);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_LOC_L2_ID_List_Adv");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L3_ID_List_Adv(Params_Get_Loc_l3_By_LOC_L3_ID_List i_Params_Get_Loc_l3_By_LOC_L3_ID_List)
{
Loc_l3 oLoc_l3 = null;
List<Loc_l3> oList = new List<Loc_l3>();
Params_Get_Loc_l3_By_LOC_L3_ID_List_SP oParams_Get_Loc_l3_By_LOC_L3_ID_List_SP = new Params_Get_Loc_l3_By_LOC_L3_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_LOC_L3_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l3_By_LOC_L3_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l3_By_LOC_L3_ID_List));}
#region Body Section.
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_LOC_L3_ID_List_Adv(i_Params_Get_Loc_l3_By_LOC_L3_ID_List.LOC_L3_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oLoc_l3.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oLoc_l3.My_Loc_l2);
oList.Add(oLoc_l3);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_LOC_L3_ID_List_Adv");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L4_ID_List_Adv(Params_Get_Loc_l4_By_LOC_L4_ID_List i_Params_Get_Loc_l4_By_LOC_L4_ID_List)
{
Loc_l4 oLoc_l4 = null;
List<Loc_l4> oList = new List<Loc_l4>();
Params_Get_Loc_l4_By_LOC_L4_ID_List_SP oParams_Get_Loc_l4_By_LOC_L4_ID_List_SP = new Params_Get_Loc_l4_By_LOC_L4_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_LOC_L4_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l4_By_LOC_L4_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l4_By_LOC_L4_ID_List));}
#region Body Section.
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_LOC_L4_ID_List_Adv(i_Params_Get_Loc_l4_By_LOC_L4_ID_List.LOC_L4_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oLoc_l4.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oLoc_l4.My_Loc_l3);
oList.Add(oLoc_l4);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_LOC_L4_ID_List_Adv");}
return oList;
}
public List<Method_run> Get_Method_run_By_METHOD_RUN_ID_List_Adv(Params_Get_Method_run_By_METHOD_RUN_ID_List i_Params_Get_Method_run_By_METHOD_RUN_ID_List)
{
Method_run oMethod_run = null;
List<Method_run> oList = new List<Method_run>();
Params_Get_Method_run_By_METHOD_RUN_ID_List_SP oParams_Get_Method_run_By_METHOD_RUN_ID_List_SP = new Params_Get_Method_run_By_METHOD_RUN_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Method_run_By_METHOD_RUN_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Method_run_By_METHOD_RUN_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Method_run_By_METHOD_RUN_ID_List));}
#region Body Section.
List<DALC.Method_run> oList_DBEntries = _AppContext.Get_Method_run_By_METHOD_RUN_ID_List_Adv(i_Params_Get_Method_run_By_METHOD_RUN_ID_List.METHOD_RUN_ID_LIST);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Method_run_By_METHOD_RUN_ID_List_Adv");}
return oList;
}
public List<Package> Get_Package_By_PACKAGE_ID_List_Adv(Params_Get_Package_By_PACKAGE_ID_List i_Params_Get_Package_By_PACKAGE_ID_List)
{
Package oPackage = null;
List<Package> oList = new List<Package>();
Params_Get_Package_By_PACKAGE_ID_List_SP oParams_Get_Package_By_PACKAGE_ID_List_SP = new Params_Get_Package_By_PACKAGE_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Package_By_PACKAGE_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Package_By_PACKAGE_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Package_By_PACKAGE_ID_List));}
#region Body Section.
List<DALC.Package> oList_DBEntries = _AppContext.Get_Package_By_PACKAGE_ID_List_Adv(i_Params_Get_Package_By_PACKAGE_ID_List.PACKAGE_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oPackage = new Package();
oTools.CopyPropValues(oDBEntry, oPackage);
oPackage.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oPackage.My_Currency);
oList.Add(oPackage);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Package_By_PACKAGE_ID_List_Adv");}
return oList;
}
public List<Person> Get_Person_By_PERSON_ID_List_Adv(Params_Get_Person_By_PERSON_ID_List i_Params_Get_Person_By_PERSON_ID_List)
{
Person oPerson = null;
List<Person> oList = new List<Person>();
Params_Get_Person_By_PERSON_ID_List_SP oParams_Get_Person_By_PERSON_ID_List_SP = new Params_Get_Person_By_PERSON_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Person_By_PERSON_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Person_By_PERSON_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Person_By_PERSON_ID_List));}
#region Body Section.
List<DALC.Person> oList_DBEntries = _AppContext.Get_Person_By_PERSON_ID_List_Adv(i_Params_Get_Person_By_PERSON_ID_List.PERSON_ID_LIST);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Person_By_PERSON_ID_List_Adv");}
return oList;
}
public List<Registration> Get_Registration_By_REGISTRATION_ID_List_Adv(Params_Get_Registration_By_REGISTRATION_ID_List i_Params_Get_Registration_By_REGISTRATION_ID_List)
{
Registration oRegistration = null;
List<Registration> oList = new List<Registration>();
Params_Get_Registration_By_REGISTRATION_ID_List_SP oParams_Get_Registration_By_REGISTRATION_ID_List_SP = new Params_Get_Registration_By_REGISTRATION_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Registration_By_REGISTRATION_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Registration_By_REGISTRATION_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Registration_By_REGISTRATION_ID_List));}
#region Body Section.
List<DALC.Registration> oList_DBEntries = _AppContext.Get_Registration_By_REGISTRATION_ID_List_Adv(i_Params_Get_Registration_By_REGISTRATION_ID_List.REGISTRATION_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oRegistration = new Registration();
oTools.CopyPropValues(oDBEntry, oRegistration);
oRegistration.My_Client = new Client();
oTools.CopyPropValues(oDBEntry.My_Client, oRegistration.My_Client);
oRegistration.My_Package = new Package();
oTools.CopyPropValues(oDBEntry.My_Package, oRegistration.My_Package);
oRegistration.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oRegistration.My_Currency);
oList.Add(oRegistration);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Registration_By_REGISTRATION_ID_List_Adv");}
return oList;
}
public List<Session> Get_Session_By_SESSION_ID_List_Adv(Params_Get_Session_By_SESSION_ID_List i_Params_Get_Session_By_SESSION_ID_List)
{
Session oSession = null;
List<Session> oList = new List<Session>();
Params_Get_Session_By_SESSION_ID_List_SP oParams_Get_Session_By_SESSION_ID_List_SP = new Params_Get_Session_By_SESSION_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Session_By_SESSION_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Session_By_SESSION_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Session_By_SESSION_ID_List));}
#region Body Section.
List<DALC.Session> oList_DBEntries = _AppContext.Get_Session_By_SESSION_ID_List_Adv(i_Params_Get_Session_By_SESSION_ID_List.SESSION_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSession = new Session();
oTools.CopyPropValues(oDBEntry, oSession);
oSession.My_Package = new Package();
oTools.CopyPropValues(oDBEntry.My_Package, oSession.My_Package);
oSession.My_Client_fees = new Client_fees();
oTools.CopyPropValues(oDBEntry.My_Client_fees, oSession.My_Client_fees);
oList.Add(oSession);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Session_By_SESSION_ID_List_Adv");}
return oList;
}
public List<Staff> Get_Staff_By_STAFF_ID_List_Adv(Params_Get_Staff_By_STAFF_ID_List i_Params_Get_Staff_By_STAFF_ID_List)
{
Staff oStaff = null;
List<Staff> oList = new List<Staff>();
Params_Get_Staff_By_STAFF_ID_List_SP oParams_Get_Staff_By_STAFF_ID_List_SP = new Params_Get_Staff_By_STAFF_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_By_STAFF_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_By_STAFF_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_By_STAFF_ID_List));}
#region Body Section.
List<DALC.Staff> oList_DBEntries = _AppContext.Get_Staff_By_STAFF_ID_List_Adv(i_Params_Get_Staff_By_STAFF_ID_List.STAFF_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStaff = new Staff();
oTools.CopyPropValues(oDBEntry, oStaff);
oStaff.My_Bloodtype = new Bloodtype();
oTools.CopyPropValues(oDBEntry.My_Bloodtype, oStaff.My_Bloodtype);
oList.Add(oStaff);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_By_STAFF_ID_List_Adv");}
return oList;
}
public List<Staff_fees> Get_Staff_fees_By_STAFF_FEES_ID_List_Adv(Params_Get_Staff_fees_By_STAFF_FEES_ID_List i_Params_Get_Staff_fees_By_STAFF_FEES_ID_List)
{
Staff_fees oStaff_fees = null;
List<Staff_fees> oList = new List<Staff_fees>();
Params_Get_Staff_fees_By_STAFF_FEES_ID_List_SP oParams_Get_Staff_fees_By_STAFF_FEES_ID_List_SP = new Params_Get_Staff_fees_By_STAFF_FEES_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_fees_By_STAFF_FEES_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_fees_By_STAFF_FEES_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_fees_By_STAFF_FEES_ID_List));}
#region Body Section.
List<DALC.Staff_fees> oList_DBEntries = _AppContext.Get_Staff_fees_By_STAFF_FEES_ID_List_Adv(i_Params_Get_Staff_fees_By_STAFF_FEES_ID_List.STAFF_FEES_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStaff_fees = new Staff_fees();
oTools.CopyPropValues(oDBEntry, oStaff_fees);
oStaff_fees.My_Staff = new Staff();
oTools.CopyPropValues(oDBEntry.My_Staff, oStaff_fees.My_Staff);
oStaff_fees.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oStaff_fees.My_Currency);
oList.Add(oStaff_fees);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_fees_By_STAFF_FEES_ID_List_Adv");}
return oList;
}
public List<Supplier> Get_Supplier_By_SUPPLIER_ID_List_Adv(Params_Get_Supplier_By_SUPPLIER_ID_List i_Params_Get_Supplier_By_SUPPLIER_ID_List)
{
Supplier oSupplier = null;
List<Supplier> oList = new List<Supplier>();
Params_Get_Supplier_By_SUPPLIER_ID_List_SP oParams_Get_Supplier_By_SUPPLIER_ID_List_SP = new Params_Get_Supplier_By_SUPPLIER_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_By_SUPPLIER_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_By_SUPPLIER_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_By_SUPPLIER_ID_List));}
#region Body Section.
List<DALC.Supplier> oList_DBEntries = _AppContext.Get_Supplier_By_SUPPLIER_ID_List_Adv(i_Params_Get_Supplier_By_SUPPLIER_ID_List.SUPPLIER_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier = new Supplier();
oTools.CopyPropValues(oDBEntry, oSupplier);
oSupplier.My_Bloodtype = new Bloodtype();
oTools.CopyPropValues(oDBEntry.My_Bloodtype, oSupplier.My_Bloodtype);
oList.Add(oSupplier);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_By_SUPPLIER_ID_List_Adv");}
return oList;
}
public List<Supplier_fees> Get_Supplier_fees_By_SUPPLIER_FEES_ID_List_Adv(Params_Get_Supplier_fees_By_SUPPLIER_FEES_ID_List i_Params_Get_Supplier_fees_By_SUPPLIER_FEES_ID_List)
{
Supplier_fees oSupplier_fees = null;
List<Supplier_fees> oList = new List<Supplier_fees>();
Params_Get_Supplier_fees_By_SUPPLIER_FEES_ID_List_SP oParams_Get_Supplier_fees_By_SUPPLIER_FEES_ID_List_SP = new Params_Get_Supplier_fees_By_SUPPLIER_FEES_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_fees_By_SUPPLIER_FEES_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_fees_By_SUPPLIER_FEES_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_fees_By_SUPPLIER_FEES_ID_List));}
#region Body Section.
List<DALC.Supplier_fees> oList_DBEntries = _AppContext.Get_Supplier_fees_By_SUPPLIER_FEES_ID_List_Adv(i_Params_Get_Supplier_fees_By_SUPPLIER_FEES_ID_List.SUPPLIER_FEES_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier_fees = new Supplier_fees();
oTools.CopyPropValues(oDBEntry, oSupplier_fees);
oSupplier_fees.My_Supplier = new Supplier();
oTools.CopyPropValues(oDBEntry.My_Supplier, oSupplier_fees.My_Supplier);
oSupplier_fees.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oSupplier_fees.My_Currency);
oList.Add(oSupplier_fees);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_fees_By_SUPPLIER_FEES_ID_List_Adv");}
return oList;
}
public List<User> Get_User_By_USER_ID_List_Adv(Params_Get_User_By_USER_ID_List i_Params_Get_User_By_USER_ID_List)
{
User oUser = null;
List<User> oList = new List<User>();
Params_Get_User_By_USER_ID_List_SP oParams_Get_User_By_USER_ID_List_SP = new Params_Get_User_By_USER_ID_List_SP();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_USER_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_User_By_USER_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_User_By_USER_ID_List));}
#region Body Section.
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_USER_ID_List_Adv(i_Params_Get_User_By_USER_ID_List.USER_ID_LIST);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_USER_ID_List_Adv");}
return oList;
}
public List<Address> Get_Address_By_PERSON_ID_Adv(Params_Get_Address_By_PERSON_ID i_Params_Get_Address_By_PERSON_ID)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_PERSON_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_PERSON_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_PERSON_ID));}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_PERSON_ID_Adv(i_Params_Get_Address_By_PERSON_ID.PERSON_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_PERSON_ID_Adv");}
return oList;
}
public List<Address> Get_Address_By_LOC_L1_ID_Adv(Params_Get_Address_By_LOC_L1_ID i_Params_Get_Address_By_LOC_L1_ID)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L1_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_LOC_L1_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_LOC_L1_ID));}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L1_ID_Adv(i_Params_Get_Address_By_LOC_L1_ID.LOC_L1_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L1_ID_Adv");}
return oList;
}
public List<Address> Get_Address_By_LOC_L2_ID_Adv(Params_Get_Address_By_LOC_L2_ID i_Params_Get_Address_By_LOC_L2_ID)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L2_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_LOC_L2_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_LOC_L2_ID));}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L2_ID_Adv(i_Params_Get_Address_By_LOC_L2_ID.LOC_L2_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L2_ID_Adv");}
return oList;
}
public List<Address> Get_Address_By_LOC_L3_ID_Adv(Params_Get_Address_By_LOC_L3_ID i_Params_Get_Address_By_LOC_L3_ID)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L3_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_LOC_L3_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_LOC_L3_ID));}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L3_ID_Adv(i_Params_Get_Address_By_LOC_L3_ID.LOC_L3_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L3_ID_Adv");}
return oList;
}
public List<Address> Get_Address_By_OWNER_ID_Adv(Params_Get_Address_By_OWNER_ID i_Params_Get_Address_By_OWNER_ID)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_OWNER_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_OWNER_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_OWNER_ID));}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_OWNER_ID_Adv(i_Params_Get_Address_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_OWNER_ID_Adv");}
return oList;
}
public List<Address> Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE_Adv(Params_Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE i_Params_Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE));}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE_Adv(i_Params_Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE.PERSON_ID,i_Params_Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE.ADDRESS_TYPE_CODE);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE_Adv");}
return oList;
}
public List<Address> Get_Address_By_LOC_L4_ID_Adv(Params_Get_Address_By_LOC_L4_ID i_Params_Get_Address_By_LOC_L4_ID)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L4_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_LOC_L4_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_LOC_L4_ID));}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L4_ID_Adv(i_Params_Get_Address_By_LOC_L4_ID.LOC_L4_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L4_ID_Adv");}
return oList;
}
public List<Bloodtype> Get_Bloodtype_By_OWNER_ID_Adv(Params_Get_Bloodtype_By_OWNER_ID i_Params_Get_Bloodtype_By_OWNER_ID)
{
List<Bloodtype> oList = new List<Bloodtype>();
Bloodtype oBloodtype = new Bloodtype();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Bloodtype_By_OWNER_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Bloodtype_By_OWNER_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Bloodtype_By_OWNER_ID));}
#region Body Section.
List<DALC.Bloodtype> oList_DBEntries = _AppContext.Get_Bloodtype_By_OWNER_ID_Adv(i_Params_Get_Bloodtype_By_OWNER_ID.OWNER_ID);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Bloodtype_By_OWNER_ID_Adv");}
return oList;
}
public List<Client> Get_Client_By_OWNER_ID_Adv(Params_Get_Client_By_OWNER_ID i_Params_Get_Client_By_OWNER_ID)
{
List<Client> oList = new List<Client>();
Client oClient = new Client();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_By_OWNER_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Client_By_OWNER_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Client_By_OWNER_ID));}
#region Body Section.
List<DALC.Client> oList_DBEntries = _AppContext.Get_Client_By_OWNER_ID_Adv(i_Params_Get_Client_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oClient = new Client();
oTools.CopyPropValues(oDBEntry, oClient);
oClient.My_Bloodtype = new Bloodtype();
oTools.CopyPropValues(oDBEntry.My_Bloodtype, oClient.My_Bloodtype);
oList.Add(oClient);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_By_OWNER_ID_Adv");}
return oList;
}
public List<Client> Get_Client_By_BLOODTYPE_ID_Adv(Params_Get_Client_By_BLOODTYPE_ID i_Params_Get_Client_By_BLOODTYPE_ID)
{
List<Client> oList = new List<Client>();
Client oClient = new Client();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_By_BLOODTYPE_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Client_By_BLOODTYPE_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Client_By_BLOODTYPE_ID));}
#region Body Section.
List<DALC.Client> oList_DBEntries = _AppContext.Get_Client_By_BLOODTYPE_ID_Adv(i_Params_Get_Client_By_BLOODTYPE_ID.BLOODTYPE_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oClient = new Client();
oTools.CopyPropValues(oDBEntry, oClient);
oClient.My_Bloodtype = new Bloodtype();
oTools.CopyPropValues(oDBEntry.My_Bloodtype, oClient.My_Bloodtype);
oList.Add(oClient);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_By_BLOODTYPE_ID_Adv");}
return oList;
}
public List<Client_fees> Get_Client_fees_By_OWNER_ID_Adv(Params_Get_Client_fees_By_OWNER_ID i_Params_Get_Client_fees_By_OWNER_ID)
{
List<Client_fees> oList = new List<Client_fees>();
Client_fees oClient_fees = new Client_fees();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_fees_By_OWNER_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Client_fees_By_OWNER_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Client_fees_By_OWNER_ID));}
#region Body Section.
List<DALC.Client_fees> oList_DBEntries = _AppContext.Get_Client_fees_By_OWNER_ID_Adv(i_Params_Get_Client_fees_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oClient_fees = new Client_fees();
oTools.CopyPropValues(oDBEntry, oClient_fees);
oClient_fees.My_Client = new Client();
oTools.CopyPropValues(oDBEntry.My_Client, oClient_fees.My_Client);
oClient_fees.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oClient_fees.My_Currency);
oClient_fees.My_Package = new Package();
oTools.CopyPropValues(oDBEntry.My_Package, oClient_fees.My_Package);
oClient_fees.My_Registration = new Registration();
oTools.CopyPropValues(oDBEntry.My_Registration, oClient_fees.My_Registration);
oList.Add(oClient_fees);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_fees_By_OWNER_ID_Adv");}
return oList;
}
public List<Client_fees> Get_Client_fees_By_CLIENT_ID_Adv(Params_Get_Client_fees_By_CLIENT_ID i_Params_Get_Client_fees_By_CLIENT_ID)
{
List<Client_fees> oList = new List<Client_fees>();
Client_fees oClient_fees = new Client_fees();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_fees_By_CLIENT_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Client_fees_By_CLIENT_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Client_fees_By_CLIENT_ID));}
#region Body Section.
List<DALC.Client_fees> oList_DBEntries = _AppContext.Get_Client_fees_By_CLIENT_ID_Adv(i_Params_Get_Client_fees_By_CLIENT_ID.CLIENT_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oClient_fees = new Client_fees();
oTools.CopyPropValues(oDBEntry, oClient_fees);
oClient_fees.My_Client = new Client();
oTools.CopyPropValues(oDBEntry.My_Client, oClient_fees.My_Client);
oClient_fees.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oClient_fees.My_Currency);
oClient_fees.My_Package = new Package();
oTools.CopyPropValues(oDBEntry.My_Package, oClient_fees.My_Package);
oClient_fees.My_Registration = new Registration();
oTools.CopyPropValues(oDBEntry.My_Registration, oClient_fees.My_Registration);
oList.Add(oClient_fees);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_fees_By_CLIENT_ID_Adv");}
return oList;
}
public List<Client_fees> Get_Client_fees_By_CURRENCY_ID_Adv(Params_Get_Client_fees_By_CURRENCY_ID i_Params_Get_Client_fees_By_CURRENCY_ID)
{
List<Client_fees> oList = new List<Client_fees>();
Client_fees oClient_fees = new Client_fees();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_fees_By_CURRENCY_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Client_fees_By_CURRENCY_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Client_fees_By_CURRENCY_ID));}
#region Body Section.
List<DALC.Client_fees> oList_DBEntries = _AppContext.Get_Client_fees_By_CURRENCY_ID_Adv(i_Params_Get_Client_fees_By_CURRENCY_ID.CURRENCY_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oClient_fees = new Client_fees();
oTools.CopyPropValues(oDBEntry, oClient_fees);
oClient_fees.My_Client = new Client();
oTools.CopyPropValues(oDBEntry.My_Client, oClient_fees.My_Client);
oClient_fees.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oClient_fees.My_Currency);
oClient_fees.My_Package = new Package();
oTools.CopyPropValues(oDBEntry.My_Package, oClient_fees.My_Package);
oClient_fees.My_Registration = new Registration();
oTools.CopyPropValues(oDBEntry.My_Registration, oClient_fees.My_Registration);
oList.Add(oClient_fees);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_fees_By_CURRENCY_ID_Adv");}
return oList;
}
public List<Client_fees> Get_Client_fees_By_PACKAGE_ID_Adv(Params_Get_Client_fees_By_PACKAGE_ID i_Params_Get_Client_fees_By_PACKAGE_ID)
{
List<Client_fees> oList = new List<Client_fees>();
Client_fees oClient_fees = new Client_fees();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_fees_By_PACKAGE_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Client_fees_By_PACKAGE_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Client_fees_By_PACKAGE_ID));}
#region Body Section.
List<DALC.Client_fees> oList_DBEntries = _AppContext.Get_Client_fees_By_PACKAGE_ID_Adv(i_Params_Get_Client_fees_By_PACKAGE_ID.PACKAGE_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oClient_fees = new Client_fees();
oTools.CopyPropValues(oDBEntry, oClient_fees);
oClient_fees.My_Client = new Client();
oTools.CopyPropValues(oDBEntry.My_Client, oClient_fees.My_Client);
oClient_fees.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oClient_fees.My_Currency);
oClient_fees.My_Package = new Package();
oTools.CopyPropValues(oDBEntry.My_Package, oClient_fees.My_Package);
oClient_fees.My_Registration = new Registration();
oTools.CopyPropValues(oDBEntry.My_Registration, oClient_fees.My_Registration);
oList.Add(oClient_fees);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_fees_By_PACKAGE_ID_Adv");}
return oList;
}
public List<Client_fees> Get_Client_fees_By_REGISTRATION_ID_Adv(Params_Get_Client_fees_By_REGISTRATION_ID i_Params_Get_Client_fees_By_REGISTRATION_ID)
{
List<Client_fees> oList = new List<Client_fees>();
Client_fees oClient_fees = new Client_fees();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_fees_By_REGISTRATION_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Client_fees_By_REGISTRATION_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Client_fees_By_REGISTRATION_ID));}
#region Body Section.
List<DALC.Client_fees> oList_DBEntries = _AppContext.Get_Client_fees_By_REGISTRATION_ID_Adv(i_Params_Get_Client_fees_By_REGISTRATION_ID.REGISTRATION_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oClient_fees = new Client_fees();
oTools.CopyPropValues(oDBEntry, oClient_fees);
oClient_fees.My_Client = new Client();
oTools.CopyPropValues(oDBEntry.My_Client, oClient_fees.My_Client);
oClient_fees.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oClient_fees.My_Currency);
oClient_fees.My_Package = new Package();
oTools.CopyPropValues(oDBEntry.My_Package, oClient_fees.My_Package);
oClient_fees.My_Registration = new Registration();
oTools.CopyPropValues(oDBEntry.My_Registration, oClient_fees.My_Registration);
oList.Add(oClient_fees);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_fees_By_REGISTRATION_ID_Adv");}
return oList;
}
public List<Contact> Get_Contact_By_PERSON_ID_Adv(Params_Get_Contact_By_PERSON_ID i_Params_Get_Contact_By_PERSON_ID)
{
List<Contact> oList = new List<Contact>();
Contact oContact = new Contact();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_PERSON_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Contact_By_PERSON_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Contact_By_PERSON_ID));}
#region Body Section.
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_PERSON_ID_Adv(i_Params_Get_Contact_By_PERSON_ID.PERSON_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oContact.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oContact.My_Person);
oList.Add(oContact);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_PERSON_ID_Adv");}
return oList;
}
public List<Contact> Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT_Adv(Params_Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT i_Params_Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT)
{
List<Contact> oList = new List<Contact>();
Contact oContact = new Contact();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT));}
#region Body Section.
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT_Adv(i_Params_Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT.PERSON_ID,i_Params_Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT.CONTACT_TYPE_CODE,i_Params_Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT.CONTACT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oContact.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oContact.My_Person);
oList.Add(oContact);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT_Adv");}
return oList;
}
public List<Contact> Get_Contact_By_OWNER_ID_Adv(Params_Get_Contact_By_OWNER_ID i_Params_Get_Contact_By_OWNER_ID)
{
List<Contact> oList = new List<Contact>();
Contact oContact = new Contact();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_OWNER_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Contact_By_OWNER_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Contact_By_OWNER_ID));}
#region Body Section.
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_OWNER_ID_Adv(i_Params_Get_Contact_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oContact.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oContact.My_Person);
oList.Add(oContact);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_OWNER_ID_Adv");}
return oList;
}
public List<Currency> Get_Currency_By_OWNER_ID_Adv(Params_Get_Currency_By_OWNER_ID i_Params_Get_Currency_By_OWNER_ID)
{
List<Currency> oList = new List<Currency>();
Currency oCurrency = new Currency();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Currency_By_OWNER_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Currency_By_OWNER_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Currency_By_OWNER_ID));}
#region Body Section.
List<DALC.Currency> oList_DBEntries = _AppContext.Get_Currency_By_OWNER_ID_Adv(i_Params_Get_Currency_By_OWNER_ID.OWNER_ID);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Currency_By_OWNER_ID_Adv");}
return oList;
}
public List<Fees> Get_Fees_By_OWNER_ID_Adv(Params_Get_Fees_By_OWNER_ID i_Params_Get_Fees_By_OWNER_ID)
{
List<Fees> oList = new List<Fees>();
Fees oFees = new Fees();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Fees_By_OWNER_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Fees_By_OWNER_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Fees_By_OWNER_ID));}
#region Body Section.
List<DALC.Fees> oList_DBEntries = _AppContext.Get_Fees_By_OWNER_ID_Adv(i_Params_Get_Fees_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFees = new Fees();
oTools.CopyPropValues(oDBEntry, oFees);
oFees.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oFees.My_Currency);
oList.Add(oFees);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Fees_By_OWNER_ID_Adv");}
return oList;
}
public List<Fees> Get_Fees_By_CURRENCY_ID_Adv(Params_Get_Fees_By_CURRENCY_ID i_Params_Get_Fees_By_CURRENCY_ID)
{
List<Fees> oList = new List<Fees>();
Fees oFees = new Fees();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Fees_By_CURRENCY_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Fees_By_CURRENCY_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Fees_By_CURRENCY_ID));}
#region Body Section.
List<DALC.Fees> oList_DBEntries = _AppContext.Get_Fees_By_CURRENCY_ID_Adv(i_Params_Get_Fees_By_CURRENCY_ID.CURRENCY_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFees = new Fees();
oTools.CopyPropValues(oDBEntry, oFees);
oFees.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oFees.My_Currency);
oList.Add(oFees);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Fees_By_CURRENCY_ID_Adv");}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_CODE_Adv(Params_Get_Loc_l1_By_CODE i_Params_Get_Loc_l1_By_CODE)
{
List<Loc_l1> oList = new List<Loc_l1>();
Loc_l1 oLoc_l1 = new Loc_l1();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l1_By_CODE_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l1_By_CODE_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l1_By_CODE));}
#region Body Section.
List<DALC.Loc_l1> oList_DBEntries = _AppContext.Get_Loc_l1_By_CODE_Adv(i_Params_Get_Loc_l1_By_CODE.CODE);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l1_By_CODE_Adv");}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_OWNER_ID_Adv(Params_Get_Loc_l1_By_OWNER_ID i_Params_Get_Loc_l1_By_OWNER_ID)
{
List<Loc_l1> oList = new List<Loc_l1>();
Loc_l1 oLoc_l1 = new Loc_l1();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l1_By_OWNER_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l1_By_OWNER_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l1_By_OWNER_ID));}
#region Body Section.
List<DALC.Loc_l1> oList_DBEntries = _AppContext.Get_Loc_l1_By_OWNER_ID_Adv(i_Params_Get_Loc_l1_By_OWNER_ID.OWNER_ID);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l1_By_OWNER_ID_Adv");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_CODE_Adv(Params_Get_Loc_l2_By_LOC_L1_ID_CODE i_Params_Get_Loc_l2_By_LOC_L1_ID_CODE)
{
List<Loc_l2> oList = new List<Loc_l2>();
Loc_l2 oLoc_l2 = new Loc_l2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_LOC_L1_ID_CODE_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l2_By_LOC_L1_ID_CODE_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l2_By_LOC_L1_ID_CODE));}
#region Body Section.
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_LOC_L1_ID_CODE_Adv(i_Params_Get_Loc_l2_By_LOC_L1_ID_CODE.LOC_L1_ID,i_Params_Get_Loc_l2_By_LOC_L1_ID_CODE.CODE);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oLoc_l2.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oLoc_l2.My_Loc_l1);
oList.Add(oLoc_l2);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_LOC_L1_ID_CODE_Adv");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_Adv(Params_Get_Loc_l2_By_LOC_L1_ID i_Params_Get_Loc_l2_By_LOC_L1_ID)
{
List<Loc_l2> oList = new List<Loc_l2>();
Loc_l2 oLoc_l2 = new Loc_l2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_LOC_L1_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l2_By_LOC_L1_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l2_By_LOC_L1_ID));}
#region Body Section.
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_LOC_L1_ID_Adv(i_Params_Get_Loc_l2_By_LOC_L1_ID.LOC_L1_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oLoc_l2.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oLoc_l2.My_Loc_l1);
oList.Add(oLoc_l2);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_LOC_L1_ID_Adv");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_OWNER_ID_Adv(Params_Get_Loc_l2_By_OWNER_ID i_Params_Get_Loc_l2_By_OWNER_ID)
{
List<Loc_l2> oList = new List<Loc_l2>();
Loc_l2 oLoc_l2 = new Loc_l2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_OWNER_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l2_By_OWNER_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l2_By_OWNER_ID));}
#region Body Section.
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_OWNER_ID_Adv(i_Params_Get_Loc_l2_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oLoc_l2.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oLoc_l2.My_Loc_l1);
oList.Add(oLoc_l2);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_OWNER_ID_Adv");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_CODE_Adv(Params_Get_Loc_l3_By_LOC_L2_ID_CODE i_Params_Get_Loc_l3_By_LOC_L2_ID_CODE)
{
List<Loc_l3> oList = new List<Loc_l3>();
Loc_l3 oLoc_l3 = new Loc_l3();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_LOC_L2_ID_CODE_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l3_By_LOC_L2_ID_CODE_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l3_By_LOC_L2_ID_CODE));}
#region Body Section.
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_LOC_L2_ID_CODE_Adv(i_Params_Get_Loc_l3_By_LOC_L2_ID_CODE.LOC_L2_ID,i_Params_Get_Loc_l3_By_LOC_L2_ID_CODE.CODE);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oLoc_l3.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oLoc_l3.My_Loc_l2);
oList.Add(oLoc_l3);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_LOC_L2_ID_CODE_Adv");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_Adv(Params_Get_Loc_l3_By_LOC_L2_ID i_Params_Get_Loc_l3_By_LOC_L2_ID)
{
List<Loc_l3> oList = new List<Loc_l3>();
Loc_l3 oLoc_l3 = new Loc_l3();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_LOC_L2_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l3_By_LOC_L2_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l3_By_LOC_L2_ID));}
#region Body Section.
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_LOC_L2_ID_Adv(i_Params_Get_Loc_l3_By_LOC_L2_ID.LOC_L2_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oLoc_l3.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oLoc_l3.My_Loc_l2);
oList.Add(oLoc_l3);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_LOC_L2_ID_Adv");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_OWNER_ID_Adv(Params_Get_Loc_l3_By_OWNER_ID i_Params_Get_Loc_l3_By_OWNER_ID)
{
List<Loc_l3> oList = new List<Loc_l3>();
Loc_l3 oLoc_l3 = new Loc_l3();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_OWNER_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l3_By_OWNER_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l3_By_OWNER_ID));}
#region Body Section.
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_OWNER_ID_Adv(i_Params_Get_Loc_l3_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oLoc_l3.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oLoc_l3.My_Loc_l2);
oList.Add(oLoc_l3);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_OWNER_ID_Adv");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_CODE_Adv(Params_Get_Loc_l4_By_LOC_L3_ID_CODE i_Params_Get_Loc_l4_By_LOC_L3_ID_CODE)
{
List<Loc_l4> oList = new List<Loc_l4>();
Loc_l4 oLoc_l4 = new Loc_l4();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_LOC_L3_ID_CODE_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l4_By_LOC_L3_ID_CODE_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l4_By_LOC_L3_ID_CODE));}
#region Body Section.
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_LOC_L3_ID_CODE_Adv(i_Params_Get_Loc_l4_By_LOC_L3_ID_CODE.LOC_L3_ID,i_Params_Get_Loc_l4_By_LOC_L3_ID_CODE.CODE);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oLoc_l4.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oLoc_l4.My_Loc_l3);
oList.Add(oLoc_l4);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_LOC_L3_ID_CODE_Adv");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_Adv(Params_Get_Loc_l4_By_LOC_L3_ID i_Params_Get_Loc_l4_By_LOC_L3_ID)
{
List<Loc_l4> oList = new List<Loc_l4>();
Loc_l4 oLoc_l4 = new Loc_l4();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_LOC_L3_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l4_By_LOC_L3_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l4_By_LOC_L3_ID));}
#region Body Section.
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_LOC_L3_ID_Adv(i_Params_Get_Loc_l4_By_LOC_L3_ID.LOC_L3_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oLoc_l4.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oLoc_l4.My_Loc_l3);
oList.Add(oLoc_l4);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_LOC_L3_ID_Adv");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_OWNER_ID_Adv(Params_Get_Loc_l4_By_OWNER_ID i_Params_Get_Loc_l4_By_OWNER_ID)
{
List<Loc_l4> oList = new List<Loc_l4>();
Loc_l4 oLoc_l4 = new Loc_l4();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_OWNER_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l4_By_OWNER_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l4_By_OWNER_ID));}
#region Body Section.
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_OWNER_ID_Adv(i_Params_Get_Loc_l4_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oLoc_l4.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oLoc_l4.My_Loc_l3);
oList.Add(oLoc_l4);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_OWNER_ID_Adv");}
return oList;
}
public List<Method_run> Get_Method_run_By_OWNER_ID_Adv(Params_Get_Method_run_By_OWNER_ID i_Params_Get_Method_run_By_OWNER_ID)
{
List<Method_run> oList = new List<Method_run>();
Method_run oMethod_run = new Method_run();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Method_run_By_OWNER_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Method_run_By_OWNER_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Method_run_By_OWNER_ID));}
#region Body Section.
List<DALC.Method_run> oList_DBEntries = _AppContext.Get_Method_run_By_OWNER_ID_Adv(i_Params_Get_Method_run_By_OWNER_ID.OWNER_ID);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Method_run_By_OWNER_ID_Adv");}
return oList;
}
public List<Package> Get_Package_By_OWNER_ID_Adv(Params_Get_Package_By_OWNER_ID i_Params_Get_Package_By_OWNER_ID)
{
List<Package> oList = new List<Package>();
Package oPackage = new Package();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Package_By_OWNER_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Package_By_OWNER_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Package_By_OWNER_ID));}
#region Body Section.
List<DALC.Package> oList_DBEntries = _AppContext.Get_Package_By_OWNER_ID_Adv(i_Params_Get_Package_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oPackage = new Package();
oTools.CopyPropValues(oDBEntry, oPackage);
oPackage.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oPackage.My_Currency);
oList.Add(oPackage);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Package_By_OWNER_ID_Adv");}
return oList;
}
public List<Package> Get_Package_By_CURRENCY_ID_Adv(Params_Get_Package_By_CURRENCY_ID i_Params_Get_Package_By_CURRENCY_ID)
{
List<Package> oList = new List<Package>();
Package oPackage = new Package();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Package_By_CURRENCY_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Package_By_CURRENCY_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Package_By_CURRENCY_ID));}
#region Body Section.
List<DALC.Package> oList_DBEntries = _AppContext.Get_Package_By_CURRENCY_ID_Adv(i_Params_Get_Package_By_CURRENCY_ID.CURRENCY_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oPackage = new Package();
oTools.CopyPropValues(oDBEntry, oPackage);
oPackage.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oPackage.My_Currency);
oList.Add(oPackage);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Package_By_CURRENCY_ID_Adv");}
return oList;
}
public List<Person> Get_Person_By_OWNER_ID_Adv(Params_Get_Person_By_OWNER_ID i_Params_Get_Person_By_OWNER_ID)
{
List<Person> oList = new List<Person>();
Person oPerson = new Person();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Person_By_OWNER_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Person_By_OWNER_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Person_By_OWNER_ID));}
#region Body Section.
List<DALC.Person> oList_DBEntries = _AppContext.Get_Person_By_OWNER_ID_Adv(i_Params_Get_Person_By_OWNER_ID.OWNER_ID);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Person_By_OWNER_ID_Adv");}
return oList;
}
public List<Registration> Get_Registration_By_OWNER_ID_Adv(Params_Get_Registration_By_OWNER_ID i_Params_Get_Registration_By_OWNER_ID)
{
List<Registration> oList = new List<Registration>();
Registration oRegistration = new Registration();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Registration_By_OWNER_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Registration_By_OWNER_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Registration_By_OWNER_ID));}
#region Body Section.
List<DALC.Registration> oList_DBEntries = _AppContext.Get_Registration_By_OWNER_ID_Adv(i_Params_Get_Registration_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oRegistration = new Registration();
oTools.CopyPropValues(oDBEntry, oRegistration);
oRegistration.My_Client = new Client();
oTools.CopyPropValues(oDBEntry.My_Client, oRegistration.My_Client);
oRegistration.My_Package = new Package();
oTools.CopyPropValues(oDBEntry.My_Package, oRegistration.My_Package);
oRegistration.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oRegistration.My_Currency);
oList.Add(oRegistration);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Registration_By_OWNER_ID_Adv");}
return oList;
}
public List<Registration> Get_Registration_By_CLIENT_ID_Adv(Params_Get_Registration_By_CLIENT_ID i_Params_Get_Registration_By_CLIENT_ID)
{
List<Registration> oList = new List<Registration>();
Registration oRegistration = new Registration();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Registration_By_CLIENT_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Registration_By_CLIENT_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Registration_By_CLIENT_ID));}
#region Body Section.
List<DALC.Registration> oList_DBEntries = _AppContext.Get_Registration_By_CLIENT_ID_Adv(i_Params_Get_Registration_By_CLIENT_ID.CLIENT_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oRegistration = new Registration();
oTools.CopyPropValues(oDBEntry, oRegistration);
oRegistration.My_Client = new Client();
oTools.CopyPropValues(oDBEntry.My_Client, oRegistration.My_Client);
oRegistration.My_Package = new Package();
oTools.CopyPropValues(oDBEntry.My_Package, oRegistration.My_Package);
oRegistration.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oRegistration.My_Currency);
oList.Add(oRegistration);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Registration_By_CLIENT_ID_Adv");}
return oList;
}
public List<Registration> Get_Registration_By_PACKAGE_ID_Adv(Params_Get_Registration_By_PACKAGE_ID i_Params_Get_Registration_By_PACKAGE_ID)
{
List<Registration> oList = new List<Registration>();
Registration oRegistration = new Registration();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Registration_By_PACKAGE_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Registration_By_PACKAGE_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Registration_By_PACKAGE_ID));}
#region Body Section.
List<DALC.Registration> oList_DBEntries = _AppContext.Get_Registration_By_PACKAGE_ID_Adv(i_Params_Get_Registration_By_PACKAGE_ID.PACKAGE_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oRegistration = new Registration();
oTools.CopyPropValues(oDBEntry, oRegistration);
oRegistration.My_Client = new Client();
oTools.CopyPropValues(oDBEntry.My_Client, oRegistration.My_Client);
oRegistration.My_Package = new Package();
oTools.CopyPropValues(oDBEntry.My_Package, oRegistration.My_Package);
oRegistration.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oRegistration.My_Currency);
oList.Add(oRegistration);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Registration_By_PACKAGE_ID_Adv");}
return oList;
}
public List<Registration> Get_Registration_By_CURRENCY_ID_Adv(Params_Get_Registration_By_CURRENCY_ID i_Params_Get_Registration_By_CURRENCY_ID)
{
List<Registration> oList = new List<Registration>();
Registration oRegistration = new Registration();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Registration_By_CURRENCY_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Registration_By_CURRENCY_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Registration_By_CURRENCY_ID));}
#region Body Section.
List<DALC.Registration> oList_DBEntries = _AppContext.Get_Registration_By_CURRENCY_ID_Adv(i_Params_Get_Registration_By_CURRENCY_ID.CURRENCY_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oRegistration = new Registration();
oTools.CopyPropValues(oDBEntry, oRegistration);
oRegistration.My_Client = new Client();
oTools.CopyPropValues(oDBEntry.My_Client, oRegistration.My_Client);
oRegistration.My_Package = new Package();
oTools.CopyPropValues(oDBEntry.My_Package, oRegistration.My_Package);
oRegistration.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oRegistration.My_Currency);
oList.Add(oRegistration);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Registration_By_CURRENCY_ID_Adv");}
return oList;
}
public List<Session> Get_Session_By_OWNER_ID_Adv(Params_Get_Session_By_OWNER_ID i_Params_Get_Session_By_OWNER_ID)
{
List<Session> oList = new List<Session>();
Session oSession = new Session();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Session_By_OWNER_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Session_By_OWNER_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Session_By_OWNER_ID));}
#region Body Section.
List<DALC.Session> oList_DBEntries = _AppContext.Get_Session_By_OWNER_ID_Adv(i_Params_Get_Session_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSession = new Session();
oTools.CopyPropValues(oDBEntry, oSession);
oSession.My_Package = new Package();
oTools.CopyPropValues(oDBEntry.My_Package, oSession.My_Package);
oSession.My_Client_fees = new Client_fees();
oTools.CopyPropValues(oDBEntry.My_Client_fees, oSession.My_Client_fees);
oList.Add(oSession);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Session_By_OWNER_ID_Adv");}
return oList;
}
public List<Session> Get_Session_By_PACKAGE_ID_Adv(Params_Get_Session_By_PACKAGE_ID i_Params_Get_Session_By_PACKAGE_ID)
{
List<Session> oList = new List<Session>();
Session oSession = new Session();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Session_By_PACKAGE_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Session_By_PACKAGE_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Session_By_PACKAGE_ID));}
#region Body Section.
List<DALC.Session> oList_DBEntries = _AppContext.Get_Session_By_PACKAGE_ID_Adv(i_Params_Get_Session_By_PACKAGE_ID.PACKAGE_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSession = new Session();
oTools.CopyPropValues(oDBEntry, oSession);
oSession.My_Package = new Package();
oTools.CopyPropValues(oDBEntry.My_Package, oSession.My_Package);
oSession.My_Client_fees = new Client_fees();
oTools.CopyPropValues(oDBEntry.My_Client_fees, oSession.My_Client_fees);
oList.Add(oSession);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Session_By_PACKAGE_ID_Adv");}
return oList;
}
public List<Session> Get_Session_By_CLIENT_FEES_ID_Adv(Params_Get_Session_By_CLIENT_FEES_ID i_Params_Get_Session_By_CLIENT_FEES_ID)
{
List<Session> oList = new List<Session>();
Session oSession = new Session();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Session_By_CLIENT_FEES_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Session_By_CLIENT_FEES_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Session_By_CLIENT_FEES_ID));}
#region Body Section.
List<DALC.Session> oList_DBEntries = _AppContext.Get_Session_By_CLIENT_FEES_ID_Adv(i_Params_Get_Session_By_CLIENT_FEES_ID.CLIENT_FEES_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSession = new Session();
oTools.CopyPropValues(oDBEntry, oSession);
oSession.My_Package = new Package();
oTools.CopyPropValues(oDBEntry.My_Package, oSession.My_Package);
oSession.My_Client_fees = new Client_fees();
oTools.CopyPropValues(oDBEntry.My_Client_fees, oSession.My_Client_fees);
oList.Add(oSession);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Session_By_CLIENT_FEES_ID_Adv");}
return oList;
}
public List<Staff> Get_Staff_By_OWNER_ID_Adv(Params_Get_Staff_By_OWNER_ID i_Params_Get_Staff_By_OWNER_ID)
{
List<Staff> oList = new List<Staff>();
Staff oStaff = new Staff();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_By_OWNER_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_By_OWNER_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_By_OWNER_ID));}
#region Body Section.
List<DALC.Staff> oList_DBEntries = _AppContext.Get_Staff_By_OWNER_ID_Adv(i_Params_Get_Staff_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStaff = new Staff();
oTools.CopyPropValues(oDBEntry, oStaff);
oStaff.My_Bloodtype = new Bloodtype();
oTools.CopyPropValues(oDBEntry.My_Bloodtype, oStaff.My_Bloodtype);
oList.Add(oStaff);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_By_OWNER_ID_Adv");}
return oList;
}
public List<Staff> Get_Staff_By_BLOODTYPE_ID_Adv(Params_Get_Staff_By_BLOODTYPE_ID i_Params_Get_Staff_By_BLOODTYPE_ID)
{
List<Staff> oList = new List<Staff>();
Staff oStaff = new Staff();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_By_BLOODTYPE_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_By_BLOODTYPE_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_By_BLOODTYPE_ID));}
#region Body Section.
List<DALC.Staff> oList_DBEntries = _AppContext.Get_Staff_By_BLOODTYPE_ID_Adv(i_Params_Get_Staff_By_BLOODTYPE_ID.BLOODTYPE_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStaff = new Staff();
oTools.CopyPropValues(oDBEntry, oStaff);
oStaff.My_Bloodtype = new Bloodtype();
oTools.CopyPropValues(oDBEntry.My_Bloodtype, oStaff.My_Bloodtype);
oList.Add(oStaff);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_By_BLOODTYPE_ID_Adv");}
return oList;
}
public List<Staff_fees> Get_Staff_fees_By_OWNER_ID_Adv(Params_Get_Staff_fees_By_OWNER_ID i_Params_Get_Staff_fees_By_OWNER_ID)
{
List<Staff_fees> oList = new List<Staff_fees>();
Staff_fees oStaff_fees = new Staff_fees();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_fees_By_OWNER_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_fees_By_OWNER_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_fees_By_OWNER_ID));}
#region Body Section.
List<DALC.Staff_fees> oList_DBEntries = _AppContext.Get_Staff_fees_By_OWNER_ID_Adv(i_Params_Get_Staff_fees_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStaff_fees = new Staff_fees();
oTools.CopyPropValues(oDBEntry, oStaff_fees);
oStaff_fees.My_Staff = new Staff();
oTools.CopyPropValues(oDBEntry.My_Staff, oStaff_fees.My_Staff);
oStaff_fees.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oStaff_fees.My_Currency);
oList.Add(oStaff_fees);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_fees_By_OWNER_ID_Adv");}
return oList;
}
public List<Staff_fees> Get_Staff_fees_By_STAFF_ID_Adv(Params_Get_Staff_fees_By_STAFF_ID i_Params_Get_Staff_fees_By_STAFF_ID)
{
List<Staff_fees> oList = new List<Staff_fees>();
Staff_fees oStaff_fees = new Staff_fees();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_fees_By_STAFF_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_fees_By_STAFF_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_fees_By_STAFF_ID));}
#region Body Section.
List<DALC.Staff_fees> oList_DBEntries = _AppContext.Get_Staff_fees_By_STAFF_ID_Adv(i_Params_Get_Staff_fees_By_STAFF_ID.STAFF_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStaff_fees = new Staff_fees();
oTools.CopyPropValues(oDBEntry, oStaff_fees);
oStaff_fees.My_Staff = new Staff();
oTools.CopyPropValues(oDBEntry.My_Staff, oStaff_fees.My_Staff);
oStaff_fees.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oStaff_fees.My_Currency);
oList.Add(oStaff_fees);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_fees_By_STAFF_ID_Adv");}
return oList;
}
public List<Staff_fees> Get_Staff_fees_By_CURRENCY_ID_Adv(Params_Get_Staff_fees_By_CURRENCY_ID i_Params_Get_Staff_fees_By_CURRENCY_ID)
{
List<Staff_fees> oList = new List<Staff_fees>();
Staff_fees oStaff_fees = new Staff_fees();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_fees_By_CURRENCY_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_fees_By_CURRENCY_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_fees_By_CURRENCY_ID));}
#region Body Section.
List<DALC.Staff_fees> oList_DBEntries = _AppContext.Get_Staff_fees_By_CURRENCY_ID_Adv(i_Params_Get_Staff_fees_By_CURRENCY_ID.CURRENCY_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStaff_fees = new Staff_fees();
oTools.CopyPropValues(oDBEntry, oStaff_fees);
oStaff_fees.My_Staff = new Staff();
oTools.CopyPropValues(oDBEntry.My_Staff, oStaff_fees.My_Staff);
oStaff_fees.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oStaff_fees.My_Currency);
oList.Add(oStaff_fees);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_fees_By_CURRENCY_ID_Adv");}
return oList;
}
public List<Supplier> Get_Supplier_By_OWNER_ID_Adv(Params_Get_Supplier_By_OWNER_ID i_Params_Get_Supplier_By_OWNER_ID)
{
List<Supplier> oList = new List<Supplier>();
Supplier oSupplier = new Supplier();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_By_OWNER_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_By_OWNER_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_By_OWNER_ID));}
#region Body Section.
List<DALC.Supplier> oList_DBEntries = _AppContext.Get_Supplier_By_OWNER_ID_Adv(i_Params_Get_Supplier_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier = new Supplier();
oTools.CopyPropValues(oDBEntry, oSupplier);
oSupplier.My_Bloodtype = new Bloodtype();
oTools.CopyPropValues(oDBEntry.My_Bloodtype, oSupplier.My_Bloodtype);
oList.Add(oSupplier);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_By_OWNER_ID_Adv");}
return oList;
}
public List<Supplier> Get_Supplier_By_BLOODTYPE_ID_Adv(Params_Get_Supplier_By_BLOODTYPE_ID i_Params_Get_Supplier_By_BLOODTYPE_ID)
{
List<Supplier> oList = new List<Supplier>();
Supplier oSupplier = new Supplier();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_By_BLOODTYPE_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_By_BLOODTYPE_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_By_BLOODTYPE_ID));}
#region Body Section.
List<DALC.Supplier> oList_DBEntries = _AppContext.Get_Supplier_By_BLOODTYPE_ID_Adv(i_Params_Get_Supplier_By_BLOODTYPE_ID.BLOODTYPE_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier = new Supplier();
oTools.CopyPropValues(oDBEntry, oSupplier);
oSupplier.My_Bloodtype = new Bloodtype();
oTools.CopyPropValues(oDBEntry.My_Bloodtype, oSupplier.My_Bloodtype);
oList.Add(oSupplier);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_By_BLOODTYPE_ID_Adv");}
return oList;
}
public List<Supplier_fees> Get_Supplier_fees_By_OWNER_ID_Adv(Params_Get_Supplier_fees_By_OWNER_ID i_Params_Get_Supplier_fees_By_OWNER_ID)
{
List<Supplier_fees> oList = new List<Supplier_fees>();
Supplier_fees oSupplier_fees = new Supplier_fees();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_fees_By_OWNER_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_fees_By_OWNER_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_fees_By_OWNER_ID));}
#region Body Section.
List<DALC.Supplier_fees> oList_DBEntries = _AppContext.Get_Supplier_fees_By_OWNER_ID_Adv(i_Params_Get_Supplier_fees_By_OWNER_ID.OWNER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier_fees = new Supplier_fees();
oTools.CopyPropValues(oDBEntry, oSupplier_fees);
oSupplier_fees.My_Supplier = new Supplier();
oTools.CopyPropValues(oDBEntry.My_Supplier, oSupplier_fees.My_Supplier);
oSupplier_fees.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oSupplier_fees.My_Currency);
oList.Add(oSupplier_fees);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_fees_By_OWNER_ID_Adv");}
return oList;
}
public List<Supplier_fees> Get_Supplier_fees_By_SUPPLIER_ID_Adv(Params_Get_Supplier_fees_By_SUPPLIER_ID i_Params_Get_Supplier_fees_By_SUPPLIER_ID)
{
List<Supplier_fees> oList = new List<Supplier_fees>();
Supplier_fees oSupplier_fees = new Supplier_fees();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_fees_By_SUPPLIER_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_fees_By_SUPPLIER_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_fees_By_SUPPLIER_ID));}
#region Body Section.
List<DALC.Supplier_fees> oList_DBEntries = _AppContext.Get_Supplier_fees_By_SUPPLIER_ID_Adv(i_Params_Get_Supplier_fees_By_SUPPLIER_ID.SUPPLIER_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier_fees = new Supplier_fees();
oTools.CopyPropValues(oDBEntry, oSupplier_fees);
oSupplier_fees.My_Supplier = new Supplier();
oTools.CopyPropValues(oDBEntry.My_Supplier, oSupplier_fees.My_Supplier);
oSupplier_fees.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oSupplier_fees.My_Currency);
oList.Add(oSupplier_fees);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_fees_By_SUPPLIER_ID_Adv");}
return oList;
}
public List<Supplier_fees> Get_Supplier_fees_By_CURRENCY_ID_Adv(Params_Get_Supplier_fees_By_CURRENCY_ID i_Params_Get_Supplier_fees_By_CURRENCY_ID)
{
List<Supplier_fees> oList = new List<Supplier_fees>();
Supplier_fees oSupplier_fees = new Supplier_fees();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_fees_By_CURRENCY_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_fees_By_CURRENCY_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_fees_By_CURRENCY_ID));}
#region Body Section.
List<DALC.Supplier_fees> oList_DBEntries = _AppContext.Get_Supplier_fees_By_CURRENCY_ID_Adv(i_Params_Get_Supplier_fees_By_CURRENCY_ID.CURRENCY_ID);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier_fees = new Supplier_fees();
oTools.CopyPropValues(oDBEntry, oSupplier_fees);
oSupplier_fees.My_Supplier = new Supplier();
oTools.CopyPropValues(oDBEntry.My_Supplier, oSupplier_fees.My_Supplier);
oSupplier_fees.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oSupplier_fees.My_Currency);
oList.Add(oSupplier_fees);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_fees_By_CURRENCY_ID_Adv");}
return oList;
}
public List<User> Get_User_By_OWNER_ID_Adv(Params_Get_User_By_OWNER_ID i_Params_Get_User_By_OWNER_ID)
{
List<User> oList = new List<User>();
User oUser = new User();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_OWNER_ID_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_User_By_OWNER_ID_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_User_By_OWNER_ID));}
#region Body Section.
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_OWNER_ID_Adv(i_Params_Get_User_By_OWNER_ID.OWNER_ID);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_OWNER_ID_Adv");}
return oList;
}
public List<User> Get_User_By_USERNAME_Adv(Params_Get_User_By_USERNAME i_Params_Get_User_By_USERNAME)
{
List<User> oList = new List<User>();
User oUser = new User();
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_USERNAME_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_User_By_USERNAME_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_User_By_USERNAME));}
#region Body Section.
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_USERNAME_Adv(i_Params_Get_User_By_USERNAME.USERNAME);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_USERNAME_Adv");}
return oList;
}
public List<Address> Get_Address_By_PERSON_ID_List_Adv(Params_Get_Address_By_PERSON_ID_List i_Params_Get_Address_By_PERSON_ID_List)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_PERSON_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_PERSON_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_PERSON_ID_List));}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_PERSON_ID_List_Adv(i_Params_Get_Address_By_PERSON_ID_List.PERSON_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_PERSON_ID_List_Adv");}
return oList;
}
public List<Address> Get_Address_By_LOC_L1_ID_List_Adv(Params_Get_Address_By_LOC_L1_ID_List i_Params_Get_Address_By_LOC_L1_ID_List)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L1_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_LOC_L1_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_LOC_L1_ID_List));}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L1_ID_List_Adv(i_Params_Get_Address_By_LOC_L1_ID_List.LOC_L1_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L1_ID_List_Adv");}
return oList;
}
public List<Address> Get_Address_By_LOC_L2_ID_List_Adv(Params_Get_Address_By_LOC_L2_ID_List i_Params_Get_Address_By_LOC_L2_ID_List)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L2_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_LOC_L2_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_LOC_L2_ID_List));}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L2_ID_List_Adv(i_Params_Get_Address_By_LOC_L2_ID_List.LOC_L2_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L2_ID_List_Adv");}
return oList;
}
public List<Address> Get_Address_By_LOC_L3_ID_List_Adv(Params_Get_Address_By_LOC_L3_ID_List i_Params_Get_Address_By_LOC_L3_ID_List)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L3_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_LOC_L3_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_LOC_L3_ID_List));}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L3_ID_List_Adv(i_Params_Get_Address_By_LOC_L3_ID_List.LOC_L3_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L3_ID_List_Adv");}
return oList;
}
public List<Address> Get_Address_By_LOC_L4_ID_List_Adv(Params_Get_Address_By_LOC_L4_ID_List i_Params_Get_Address_By_LOC_L4_ID_List)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_LOC_L4_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_LOC_L4_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_LOC_L4_ID_List));}
#region Body Section.
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_LOC_L4_ID_List_Adv(i_Params_Get_Address_By_LOC_L4_ID_List.LOC_L4_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_LOC_L4_ID_List_Adv");}
return oList;
}
public List<Client> Get_Client_By_BLOODTYPE_ID_List_Adv(Params_Get_Client_By_BLOODTYPE_ID_List i_Params_Get_Client_By_BLOODTYPE_ID_List)
{
List<Client> oList = new List<Client>();
Client oClient = new Client();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_By_BLOODTYPE_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Client_By_BLOODTYPE_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Client_By_BLOODTYPE_ID_List));}
#region Body Section.
List<DALC.Client> oList_DBEntries = _AppContext.Get_Client_By_BLOODTYPE_ID_List_Adv(i_Params_Get_Client_By_BLOODTYPE_ID_List.BLOODTYPE_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oClient = new Client();
oTools.CopyPropValues(oDBEntry, oClient);
oClient.My_Bloodtype = new Bloodtype();
oTools.CopyPropValues(oDBEntry.My_Bloodtype, oClient.My_Bloodtype);
oList.Add(oClient);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_By_BLOODTYPE_ID_List_Adv");}
return oList;
}
public List<Client_fees> Get_Client_fees_By_CLIENT_ID_List_Adv(Params_Get_Client_fees_By_CLIENT_ID_List i_Params_Get_Client_fees_By_CLIENT_ID_List)
{
List<Client_fees> oList = new List<Client_fees>();
Client_fees oClient_fees = new Client_fees();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_fees_By_CLIENT_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Client_fees_By_CLIENT_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Client_fees_By_CLIENT_ID_List));}
#region Body Section.
List<DALC.Client_fees> oList_DBEntries = _AppContext.Get_Client_fees_By_CLIENT_ID_List_Adv(i_Params_Get_Client_fees_By_CLIENT_ID_List.CLIENT_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oClient_fees = new Client_fees();
oTools.CopyPropValues(oDBEntry, oClient_fees);
oClient_fees.My_Client = new Client();
oTools.CopyPropValues(oDBEntry.My_Client, oClient_fees.My_Client);
oClient_fees.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oClient_fees.My_Currency);
oClient_fees.My_Package = new Package();
oTools.CopyPropValues(oDBEntry.My_Package, oClient_fees.My_Package);
oClient_fees.My_Registration = new Registration();
oTools.CopyPropValues(oDBEntry.My_Registration, oClient_fees.My_Registration);
oList.Add(oClient_fees);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_fees_By_CLIENT_ID_List_Adv");}
return oList;
}
public List<Client_fees> Get_Client_fees_By_CURRENCY_ID_List_Adv(Params_Get_Client_fees_By_CURRENCY_ID_List i_Params_Get_Client_fees_By_CURRENCY_ID_List)
{
List<Client_fees> oList = new List<Client_fees>();
Client_fees oClient_fees = new Client_fees();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_fees_By_CURRENCY_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Client_fees_By_CURRENCY_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Client_fees_By_CURRENCY_ID_List));}
#region Body Section.
List<DALC.Client_fees> oList_DBEntries = _AppContext.Get_Client_fees_By_CURRENCY_ID_List_Adv(i_Params_Get_Client_fees_By_CURRENCY_ID_List.CURRENCY_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oClient_fees = new Client_fees();
oTools.CopyPropValues(oDBEntry, oClient_fees);
oClient_fees.My_Client = new Client();
oTools.CopyPropValues(oDBEntry.My_Client, oClient_fees.My_Client);
oClient_fees.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oClient_fees.My_Currency);
oClient_fees.My_Package = new Package();
oTools.CopyPropValues(oDBEntry.My_Package, oClient_fees.My_Package);
oClient_fees.My_Registration = new Registration();
oTools.CopyPropValues(oDBEntry.My_Registration, oClient_fees.My_Registration);
oList.Add(oClient_fees);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_fees_By_CURRENCY_ID_List_Adv");}
return oList;
}
public List<Client_fees> Get_Client_fees_By_PACKAGE_ID_List_Adv(Params_Get_Client_fees_By_PACKAGE_ID_List i_Params_Get_Client_fees_By_PACKAGE_ID_List)
{
List<Client_fees> oList = new List<Client_fees>();
Client_fees oClient_fees = new Client_fees();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_fees_By_PACKAGE_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Client_fees_By_PACKAGE_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Client_fees_By_PACKAGE_ID_List));}
#region Body Section.
List<DALC.Client_fees> oList_DBEntries = _AppContext.Get_Client_fees_By_PACKAGE_ID_List_Adv(i_Params_Get_Client_fees_By_PACKAGE_ID_List.PACKAGE_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oClient_fees = new Client_fees();
oTools.CopyPropValues(oDBEntry, oClient_fees);
oClient_fees.My_Client = new Client();
oTools.CopyPropValues(oDBEntry.My_Client, oClient_fees.My_Client);
oClient_fees.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oClient_fees.My_Currency);
oClient_fees.My_Package = new Package();
oTools.CopyPropValues(oDBEntry.My_Package, oClient_fees.My_Package);
oClient_fees.My_Registration = new Registration();
oTools.CopyPropValues(oDBEntry.My_Registration, oClient_fees.My_Registration);
oList.Add(oClient_fees);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_fees_By_PACKAGE_ID_List_Adv");}
return oList;
}
public List<Client_fees> Get_Client_fees_By_REGISTRATION_ID_List_Adv(Params_Get_Client_fees_By_REGISTRATION_ID_List i_Params_Get_Client_fees_By_REGISTRATION_ID_List)
{
List<Client_fees> oList = new List<Client_fees>();
Client_fees oClient_fees = new Client_fees();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_fees_By_REGISTRATION_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Client_fees_By_REGISTRATION_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Client_fees_By_REGISTRATION_ID_List));}
#region Body Section.
List<DALC.Client_fees> oList_DBEntries = _AppContext.Get_Client_fees_By_REGISTRATION_ID_List_Adv(i_Params_Get_Client_fees_By_REGISTRATION_ID_List.REGISTRATION_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oClient_fees = new Client_fees();
oTools.CopyPropValues(oDBEntry, oClient_fees);
oClient_fees.My_Client = new Client();
oTools.CopyPropValues(oDBEntry.My_Client, oClient_fees.My_Client);
oClient_fees.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oClient_fees.My_Currency);
oClient_fees.My_Package = new Package();
oTools.CopyPropValues(oDBEntry.My_Package, oClient_fees.My_Package);
oClient_fees.My_Registration = new Registration();
oTools.CopyPropValues(oDBEntry.My_Registration, oClient_fees.My_Registration);
oList.Add(oClient_fees);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_fees_By_REGISTRATION_ID_List_Adv");}
return oList;
}
public List<Contact> Get_Contact_By_PERSON_ID_List_Adv(Params_Get_Contact_By_PERSON_ID_List i_Params_Get_Contact_By_PERSON_ID_List)
{
List<Contact> oList = new List<Contact>();
Contact oContact = new Contact();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_PERSON_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Contact_By_PERSON_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Contact_By_PERSON_ID_List));}
#region Body Section.
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_PERSON_ID_List_Adv(i_Params_Get_Contact_By_PERSON_ID_List.PERSON_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oContact.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oContact.My_Person);
oList.Add(oContact);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_PERSON_ID_List_Adv");}
return oList;
}
public List<Fees> Get_Fees_By_CURRENCY_ID_List_Adv(Params_Get_Fees_By_CURRENCY_ID_List i_Params_Get_Fees_By_CURRENCY_ID_List)
{
List<Fees> oList = new List<Fees>();
Fees oFees = new Fees();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Fees_By_CURRENCY_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Fees_By_CURRENCY_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Fees_By_CURRENCY_ID_List));}
#region Body Section.
List<DALC.Fees> oList_DBEntries = _AppContext.Get_Fees_By_CURRENCY_ID_List_Adv(i_Params_Get_Fees_By_CURRENCY_ID_List.CURRENCY_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFees = new Fees();
oTools.CopyPropValues(oDBEntry, oFees);
oFees.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oFees.My_Currency);
oList.Add(oFees);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Fees_By_CURRENCY_ID_List_Adv");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_List_Adv(Params_Get_Loc_l2_By_LOC_L1_ID_List i_Params_Get_Loc_l2_By_LOC_L1_ID_List)
{
List<Loc_l2> oList = new List<Loc_l2>();
Loc_l2 oLoc_l2 = new Loc_l2();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_LOC_L1_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l2_By_LOC_L1_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l2_By_LOC_L1_ID_List));}
#region Body Section.
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_LOC_L1_ID_List_Adv(i_Params_Get_Loc_l2_By_LOC_L1_ID_List.LOC_L1_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oLoc_l2.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oLoc_l2.My_Loc_l1);
oList.Add(oLoc_l2);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_LOC_L1_ID_List_Adv");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_List_Adv(Params_Get_Loc_l3_By_LOC_L2_ID_List i_Params_Get_Loc_l3_By_LOC_L2_ID_List)
{
List<Loc_l3> oList = new List<Loc_l3>();
Loc_l3 oLoc_l3 = new Loc_l3();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_LOC_L2_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l3_By_LOC_L2_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l3_By_LOC_L2_ID_List));}
#region Body Section.
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_LOC_L2_ID_List_Adv(i_Params_Get_Loc_l3_By_LOC_L2_ID_List.LOC_L2_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oLoc_l3.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oLoc_l3.My_Loc_l2);
oList.Add(oLoc_l3);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_LOC_L2_ID_List_Adv");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_List_Adv(Params_Get_Loc_l4_By_LOC_L3_ID_List i_Params_Get_Loc_l4_By_LOC_L3_ID_List)
{
List<Loc_l4> oList = new List<Loc_l4>();
Loc_l4 oLoc_l4 = new Loc_l4();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_LOC_L3_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l4_By_LOC_L3_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l4_By_LOC_L3_ID_List));}
#region Body Section.
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_LOC_L3_ID_List_Adv(i_Params_Get_Loc_l4_By_LOC_L3_ID_List.LOC_L3_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oLoc_l4.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oLoc_l4.My_Loc_l3);
oList.Add(oLoc_l4);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_LOC_L3_ID_List_Adv");}
return oList;
}
public List<Package> Get_Package_By_CURRENCY_ID_List_Adv(Params_Get_Package_By_CURRENCY_ID_List i_Params_Get_Package_By_CURRENCY_ID_List)
{
List<Package> oList = new List<Package>();
Package oPackage = new Package();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Package_By_CURRENCY_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Package_By_CURRENCY_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Package_By_CURRENCY_ID_List));}
#region Body Section.
List<DALC.Package> oList_DBEntries = _AppContext.Get_Package_By_CURRENCY_ID_List_Adv(i_Params_Get_Package_By_CURRENCY_ID_List.CURRENCY_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oPackage = new Package();
oTools.CopyPropValues(oDBEntry, oPackage);
oPackage.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oPackage.My_Currency);
oList.Add(oPackage);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Package_By_CURRENCY_ID_List_Adv");}
return oList;
}
public List<Registration> Get_Registration_By_CLIENT_ID_List_Adv(Params_Get_Registration_By_CLIENT_ID_List i_Params_Get_Registration_By_CLIENT_ID_List)
{
List<Registration> oList = new List<Registration>();
Registration oRegistration = new Registration();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Registration_By_CLIENT_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Registration_By_CLIENT_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Registration_By_CLIENT_ID_List));}
#region Body Section.
List<DALC.Registration> oList_DBEntries = _AppContext.Get_Registration_By_CLIENT_ID_List_Adv(i_Params_Get_Registration_By_CLIENT_ID_List.CLIENT_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oRegistration = new Registration();
oTools.CopyPropValues(oDBEntry, oRegistration);
oRegistration.My_Client = new Client();
oTools.CopyPropValues(oDBEntry.My_Client, oRegistration.My_Client);
oRegistration.My_Package = new Package();
oTools.CopyPropValues(oDBEntry.My_Package, oRegistration.My_Package);
oRegistration.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oRegistration.My_Currency);
oList.Add(oRegistration);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Registration_By_CLIENT_ID_List_Adv");}
return oList;
}
public List<Registration> Get_Registration_By_PACKAGE_ID_List_Adv(Params_Get_Registration_By_PACKAGE_ID_List i_Params_Get_Registration_By_PACKAGE_ID_List)
{
List<Registration> oList = new List<Registration>();
Registration oRegistration = new Registration();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Registration_By_PACKAGE_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Registration_By_PACKAGE_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Registration_By_PACKAGE_ID_List));}
#region Body Section.
List<DALC.Registration> oList_DBEntries = _AppContext.Get_Registration_By_PACKAGE_ID_List_Adv(i_Params_Get_Registration_By_PACKAGE_ID_List.PACKAGE_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oRegistration = new Registration();
oTools.CopyPropValues(oDBEntry, oRegistration);
oRegistration.My_Client = new Client();
oTools.CopyPropValues(oDBEntry.My_Client, oRegistration.My_Client);
oRegistration.My_Package = new Package();
oTools.CopyPropValues(oDBEntry.My_Package, oRegistration.My_Package);
oRegistration.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oRegistration.My_Currency);
oList.Add(oRegistration);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Registration_By_PACKAGE_ID_List_Adv");}
return oList;
}
public List<Registration> Get_Registration_By_CURRENCY_ID_List_Adv(Params_Get_Registration_By_CURRENCY_ID_List i_Params_Get_Registration_By_CURRENCY_ID_List)
{
List<Registration> oList = new List<Registration>();
Registration oRegistration = new Registration();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Registration_By_CURRENCY_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Registration_By_CURRENCY_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Registration_By_CURRENCY_ID_List));}
#region Body Section.
List<DALC.Registration> oList_DBEntries = _AppContext.Get_Registration_By_CURRENCY_ID_List_Adv(i_Params_Get_Registration_By_CURRENCY_ID_List.CURRENCY_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oRegistration = new Registration();
oTools.CopyPropValues(oDBEntry, oRegistration);
oRegistration.My_Client = new Client();
oTools.CopyPropValues(oDBEntry.My_Client, oRegistration.My_Client);
oRegistration.My_Package = new Package();
oTools.CopyPropValues(oDBEntry.My_Package, oRegistration.My_Package);
oRegistration.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oRegistration.My_Currency);
oList.Add(oRegistration);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Registration_By_CURRENCY_ID_List_Adv");}
return oList;
}
public List<Session> Get_Session_By_PACKAGE_ID_List_Adv(Params_Get_Session_By_PACKAGE_ID_List i_Params_Get_Session_By_PACKAGE_ID_List)
{
List<Session> oList = new List<Session>();
Session oSession = new Session();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Session_By_PACKAGE_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Session_By_PACKAGE_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Session_By_PACKAGE_ID_List));}
#region Body Section.
List<DALC.Session> oList_DBEntries = _AppContext.Get_Session_By_PACKAGE_ID_List_Adv(i_Params_Get_Session_By_PACKAGE_ID_List.PACKAGE_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSession = new Session();
oTools.CopyPropValues(oDBEntry, oSession);
oSession.My_Package = new Package();
oTools.CopyPropValues(oDBEntry.My_Package, oSession.My_Package);
oSession.My_Client_fees = new Client_fees();
oTools.CopyPropValues(oDBEntry.My_Client_fees, oSession.My_Client_fees);
oList.Add(oSession);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Session_By_PACKAGE_ID_List_Adv");}
return oList;
}
public List<Session> Get_Session_By_CLIENT_FEES_ID_List_Adv(Params_Get_Session_By_CLIENT_FEES_ID_List i_Params_Get_Session_By_CLIENT_FEES_ID_List)
{
List<Session> oList = new List<Session>();
Session oSession = new Session();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Session_By_CLIENT_FEES_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Session_By_CLIENT_FEES_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Session_By_CLIENT_FEES_ID_List));}
#region Body Section.
List<DALC.Session> oList_DBEntries = _AppContext.Get_Session_By_CLIENT_FEES_ID_List_Adv(i_Params_Get_Session_By_CLIENT_FEES_ID_List.CLIENT_FEES_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSession = new Session();
oTools.CopyPropValues(oDBEntry, oSession);
oSession.My_Package = new Package();
oTools.CopyPropValues(oDBEntry.My_Package, oSession.My_Package);
oSession.My_Client_fees = new Client_fees();
oTools.CopyPropValues(oDBEntry.My_Client_fees, oSession.My_Client_fees);
oList.Add(oSession);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Session_By_CLIENT_FEES_ID_List_Adv");}
return oList;
}
public List<Staff> Get_Staff_By_BLOODTYPE_ID_List_Adv(Params_Get_Staff_By_BLOODTYPE_ID_List i_Params_Get_Staff_By_BLOODTYPE_ID_List)
{
List<Staff> oList = new List<Staff>();
Staff oStaff = new Staff();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_By_BLOODTYPE_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_By_BLOODTYPE_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_By_BLOODTYPE_ID_List));}
#region Body Section.
List<DALC.Staff> oList_DBEntries = _AppContext.Get_Staff_By_BLOODTYPE_ID_List_Adv(i_Params_Get_Staff_By_BLOODTYPE_ID_List.BLOODTYPE_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStaff = new Staff();
oTools.CopyPropValues(oDBEntry, oStaff);
oStaff.My_Bloodtype = new Bloodtype();
oTools.CopyPropValues(oDBEntry.My_Bloodtype, oStaff.My_Bloodtype);
oList.Add(oStaff);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_By_BLOODTYPE_ID_List_Adv");}
return oList;
}
public List<Staff_fees> Get_Staff_fees_By_STAFF_ID_List_Adv(Params_Get_Staff_fees_By_STAFF_ID_List i_Params_Get_Staff_fees_By_STAFF_ID_List)
{
List<Staff_fees> oList = new List<Staff_fees>();
Staff_fees oStaff_fees = new Staff_fees();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_fees_By_STAFF_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_fees_By_STAFF_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_fees_By_STAFF_ID_List));}
#region Body Section.
List<DALC.Staff_fees> oList_DBEntries = _AppContext.Get_Staff_fees_By_STAFF_ID_List_Adv(i_Params_Get_Staff_fees_By_STAFF_ID_List.STAFF_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStaff_fees = new Staff_fees();
oTools.CopyPropValues(oDBEntry, oStaff_fees);
oStaff_fees.My_Staff = new Staff();
oTools.CopyPropValues(oDBEntry.My_Staff, oStaff_fees.My_Staff);
oStaff_fees.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oStaff_fees.My_Currency);
oList.Add(oStaff_fees);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_fees_By_STAFF_ID_List_Adv");}
return oList;
}
public List<Staff_fees> Get_Staff_fees_By_CURRENCY_ID_List_Adv(Params_Get_Staff_fees_By_CURRENCY_ID_List i_Params_Get_Staff_fees_By_CURRENCY_ID_List)
{
List<Staff_fees> oList = new List<Staff_fees>();
Staff_fees oStaff_fees = new Staff_fees();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_fees_By_CURRENCY_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_fees_By_CURRENCY_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_fees_By_CURRENCY_ID_List));}
#region Body Section.
List<DALC.Staff_fees> oList_DBEntries = _AppContext.Get_Staff_fees_By_CURRENCY_ID_List_Adv(i_Params_Get_Staff_fees_By_CURRENCY_ID_List.CURRENCY_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStaff_fees = new Staff_fees();
oTools.CopyPropValues(oDBEntry, oStaff_fees);
oStaff_fees.My_Staff = new Staff();
oTools.CopyPropValues(oDBEntry.My_Staff, oStaff_fees.My_Staff);
oStaff_fees.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oStaff_fees.My_Currency);
oList.Add(oStaff_fees);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_fees_By_CURRENCY_ID_List_Adv");}
return oList;
}
public List<Supplier> Get_Supplier_By_BLOODTYPE_ID_List_Adv(Params_Get_Supplier_By_BLOODTYPE_ID_List i_Params_Get_Supplier_By_BLOODTYPE_ID_List)
{
List<Supplier> oList = new List<Supplier>();
Supplier oSupplier = new Supplier();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_By_BLOODTYPE_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_By_BLOODTYPE_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_By_BLOODTYPE_ID_List));}
#region Body Section.
List<DALC.Supplier> oList_DBEntries = _AppContext.Get_Supplier_By_BLOODTYPE_ID_List_Adv(i_Params_Get_Supplier_By_BLOODTYPE_ID_List.BLOODTYPE_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier = new Supplier();
oTools.CopyPropValues(oDBEntry, oSupplier);
oSupplier.My_Bloodtype = new Bloodtype();
oTools.CopyPropValues(oDBEntry.My_Bloodtype, oSupplier.My_Bloodtype);
oList.Add(oSupplier);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_By_BLOODTYPE_ID_List_Adv");}
return oList;
}
public List<Supplier_fees> Get_Supplier_fees_By_SUPPLIER_ID_List_Adv(Params_Get_Supplier_fees_By_SUPPLIER_ID_List i_Params_Get_Supplier_fees_By_SUPPLIER_ID_List)
{
List<Supplier_fees> oList = new List<Supplier_fees>();
Supplier_fees oSupplier_fees = new Supplier_fees();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_fees_By_SUPPLIER_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_fees_By_SUPPLIER_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_fees_By_SUPPLIER_ID_List));}
#region Body Section.
List<DALC.Supplier_fees> oList_DBEntries = _AppContext.Get_Supplier_fees_By_SUPPLIER_ID_List_Adv(i_Params_Get_Supplier_fees_By_SUPPLIER_ID_List.SUPPLIER_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier_fees = new Supplier_fees();
oTools.CopyPropValues(oDBEntry, oSupplier_fees);
oSupplier_fees.My_Supplier = new Supplier();
oTools.CopyPropValues(oDBEntry.My_Supplier, oSupplier_fees.My_Supplier);
oSupplier_fees.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oSupplier_fees.My_Currency);
oList.Add(oSupplier_fees);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_fees_By_SUPPLIER_ID_List_Adv");}
return oList;
}
public List<Supplier_fees> Get_Supplier_fees_By_CURRENCY_ID_List_Adv(Params_Get_Supplier_fees_By_CURRENCY_ID_List i_Params_Get_Supplier_fees_By_CURRENCY_ID_List)
{
List<Supplier_fees> oList = new List<Supplier_fees>();
Supplier_fees oSupplier_fees = new Supplier_fees();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_fees_By_CURRENCY_ID_List_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_fees_By_CURRENCY_ID_List_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_fees_By_CURRENCY_ID_List));}
#region Body Section.
List<DALC.Supplier_fees> oList_DBEntries = _AppContext.Get_Supplier_fees_By_CURRENCY_ID_List_Adv(i_Params_Get_Supplier_fees_By_CURRENCY_ID_List.CURRENCY_ID_LIST);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier_fees = new Supplier_fees();
oTools.CopyPropValues(oDBEntry, oSupplier_fees);
oSupplier_fees.My_Supplier = new Supplier();
oTools.CopyPropValues(oDBEntry.My_Supplier, oSupplier_fees.My_Supplier);
oSupplier_fees.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oSupplier_fees.My_Currency);
oList.Add(oSupplier_fees);
}
}
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_fees_By_CURRENCY_ID_List_Adv");}
return oList;
}
public List<Address> Get_Address_By_Criteria_Adv(Params_Get_Address_By_Criteria i_Params_Get_Address_By_Criteria)
{
List<Address> oList = new List<Address>();
long? tmp_TOTAL_COUNT = 0;
Address oAddress = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Criteria_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_Criteria_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Address_By_Criteria.OWNER_ID == null) || (i_Params_Get_Address_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Address_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Address_By_Criteria.START_ROW == null) { i_Params_Get_Address_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Address_By_Criteria.END_ROW == null) || (i_Params_Get_Address_By_Criteria.END_ROW == 0)) { i_Params_Get_Address_By_Criteria.END_ROW = 1000000; }
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Criteria_Adv(i_Params_Get_Address_By_Criteria.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Criteria.STREET,i_Params_Get_Address_By_Criteria.BUILDING,i_Params_Get_Address_By_Criteria.FLOOR,i_Params_Get_Address_By_Criteria.POBOX,i_Params_Get_Address_By_Criteria.OWNER_ID,i_Params_Get_Address_By_Criteria.START_ROW,i_Params_Get_Address_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Criteria_Adv");}
return oList;
}
public List<Address> Get_Address_By_Where_Adv(Params_Get_Address_By_Where i_Params_Get_Address_By_Where)
{
List<Address> oList = new List<Address>();
long? tmp_TOTAL_COUNT = 0;
Address oAddress = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Where_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_Where_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_Where));}
#region Body Section.
if ((i_Params_Get_Address_By_Where.OWNER_ID == null) || (i_Params_Get_Address_By_Where.OWNER_ID == 0)) { i_Params_Get_Address_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Address_By_Where.START_ROW == null) { i_Params_Get_Address_By_Where.START_ROW = 0; }
if ((i_Params_Get_Address_By_Where.END_ROW == null) || (i_Params_Get_Address_By_Where.END_ROW == 0)) { i_Params_Get_Address_By_Where.END_ROW = 1000000; }
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Where_Adv(i_Params_Get_Address_By_Where.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Where.STREET,i_Params_Get_Address_By_Where.BUILDING,i_Params_Get_Address_By_Where.FLOOR,i_Params_Get_Address_By_Where.POBOX,i_Params_Get_Address_By_Where.OWNER_ID,i_Params_Get_Address_By_Where.START_ROW,i_Params_Get_Address_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Where_Adv");}
return oList;
}
public List<Address> Get_Address_By_Criteria_Adv_V2(Params_Get_Address_By_Criteria_V2 i_Params_Get_Address_By_Criteria_V2)
{
List<Address> oList = new List<Address>();
long? tmp_TOTAL_COUNT = 0;
Address oAddress = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Criteria_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_Criteria_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_Criteria_V2));}
#region Body Section.
if ((i_Params_Get_Address_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_Address_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_Address_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Address_By_Criteria_V2.START_ROW == null) { i_Params_Get_Address_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_Address_By_Criteria_V2.END_ROW == null) || (i_Params_Get_Address_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_Address_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Criteria_Adv_V2(i_Params_Get_Address_By_Criteria_V2.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Criteria_V2.STREET,i_Params_Get_Address_By_Criteria_V2.BUILDING,i_Params_Get_Address_By_Criteria_V2.FLOOR,i_Params_Get_Address_By_Criteria_V2.POBOX,i_Params_Get_Address_By_Criteria_V2.VALID_DATE_START,i_Params_Get_Address_By_Criteria_V2.VALID_DATE_END,i_Params_Get_Address_By_Criteria_V2.OWNER_ID,i_Params_Get_Address_By_Criteria_V2.START_ROW,i_Params_Get_Address_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Criteria_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Criteria_Adv_V2");}
return oList;
}
public List<Address> Get_Address_By_Where_Adv_V2(Params_Get_Address_By_Where_V2 i_Params_Get_Address_By_Where_V2)
{
List<Address> oList = new List<Address>();
long? tmp_TOTAL_COUNT = 0;
Address oAddress = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Where_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_Where_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_Where_V2));}
#region Body Section.
if ((i_Params_Get_Address_By_Where_V2.OWNER_ID == null) || (i_Params_Get_Address_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_Address_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Address_By_Where_V2.START_ROW == null) { i_Params_Get_Address_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_Address_By_Where_V2.END_ROW == null) || (i_Params_Get_Address_By_Where_V2.END_ROW == 0)) { i_Params_Get_Address_By_Where_V2.END_ROW = 1000000; }
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Where_Adv_V2(i_Params_Get_Address_By_Where_V2.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Where_V2.STREET,i_Params_Get_Address_By_Where_V2.BUILDING,i_Params_Get_Address_By_Where_V2.FLOOR,i_Params_Get_Address_By_Where_V2.POBOX,i_Params_Get_Address_By_Where_V2.VALID_DATE_START,i_Params_Get_Address_By_Where_V2.VALID_DATE_END,i_Params_Get_Address_By_Where_V2.OWNER_ID,i_Params_Get_Address_By_Where_V2.START_ROW,i_Params_Get_Address_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Where_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Where_Adv_V2");}
return oList;
}
public List<Bloodtype> Get_Bloodtype_By_Criteria_Adv(Params_Get_Bloodtype_By_Criteria i_Params_Get_Bloodtype_By_Criteria)
{
List<Bloodtype> oList = new List<Bloodtype>();
long? tmp_TOTAL_COUNT = 0;
Bloodtype oBloodtype = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Bloodtype_By_Criteria_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Bloodtype_By_Criteria_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Bloodtype_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Bloodtype_By_Criteria.OWNER_ID == null) || (i_Params_Get_Bloodtype_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Bloodtype_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Bloodtype_By_Criteria.START_ROW == null) { i_Params_Get_Bloodtype_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Bloodtype_By_Criteria.END_ROW == null) || (i_Params_Get_Bloodtype_By_Criteria.END_ROW == 0)) { i_Params_Get_Bloodtype_By_Criteria.END_ROW = 1000000; }
List<DALC.Bloodtype> oList_DBEntries = _AppContext.Get_Bloodtype_By_Criteria_Adv(i_Params_Get_Bloodtype_By_Criteria.BLOODTYPE_SYMBOL,i_Params_Get_Bloodtype_By_Criteria.OWNER_ID,i_Params_Get_Bloodtype_By_Criteria.START_ROW,i_Params_Get_Bloodtype_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Bloodtype_By_Criteria_Adv");}
return oList;
}
public List<Bloodtype> Get_Bloodtype_By_Where_Adv(Params_Get_Bloodtype_By_Where i_Params_Get_Bloodtype_By_Where)
{
List<Bloodtype> oList = new List<Bloodtype>();
long? tmp_TOTAL_COUNT = 0;
Bloodtype oBloodtype = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Bloodtype_By_Where_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Bloodtype_By_Where_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Bloodtype_By_Where));}
#region Body Section.
if ((i_Params_Get_Bloodtype_By_Where.OWNER_ID == null) || (i_Params_Get_Bloodtype_By_Where.OWNER_ID == 0)) { i_Params_Get_Bloodtype_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Bloodtype_By_Where.START_ROW == null) { i_Params_Get_Bloodtype_By_Where.START_ROW = 0; }
if ((i_Params_Get_Bloodtype_By_Where.END_ROW == null) || (i_Params_Get_Bloodtype_By_Where.END_ROW == 0)) { i_Params_Get_Bloodtype_By_Where.END_ROW = 1000000; }
List<DALC.Bloodtype> oList_DBEntries = _AppContext.Get_Bloodtype_By_Where_Adv(i_Params_Get_Bloodtype_By_Where.BLOODTYPE_SYMBOL,i_Params_Get_Bloodtype_By_Where.OWNER_ID,i_Params_Get_Bloodtype_By_Where.START_ROW,i_Params_Get_Bloodtype_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Bloodtype_By_Where_Adv");}
return oList;
}
public List<Client> Get_Client_By_Criteria_Adv(Params_Get_Client_By_Criteria i_Params_Get_Client_By_Criteria)
{
List<Client> oList = new List<Client>();
long? tmp_TOTAL_COUNT = 0;
Client oClient = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_By_Criteria_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Client_By_Criteria_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Client_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Client_By_Criteria.OWNER_ID == null) || (i_Params_Get_Client_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Client_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Client_By_Criteria.START_ROW == null) { i_Params_Get_Client_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Client_By_Criteria.END_ROW == null) || (i_Params_Get_Client_By_Criteria.END_ROW == 0)) { i_Params_Get_Client_By_Criteria.END_ROW = 1000000; }
List<DALC.Client> oList_DBEntries = _AppContext.Get_Client_By_Criteria_Adv(i_Params_Get_Client_By_Criteria.CLIENT_NAME,i_Params_Get_Client_By_Criteria.CLIENT_PH_NB,i_Params_Get_Client_By_Criteria.CLIENT_MAIL,i_Params_Get_Client_By_Criteria.OWNER_ID,i_Params_Get_Client_By_Criteria.START_ROW,i_Params_Get_Client_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oClient = new Client();
oTools.CopyPropValues(oDBEntry, oClient);
oClient.My_Bloodtype = new Bloodtype();
oTools.CopyPropValues(oDBEntry.My_Bloodtype, oClient.My_Bloodtype);
oList.Add(oClient);
}
}
i_Params_Get_Client_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_By_Criteria_Adv");}
return oList;
}
public List<Client> Get_Client_By_Where_Adv(Params_Get_Client_By_Where i_Params_Get_Client_By_Where)
{
List<Client> oList = new List<Client>();
long? tmp_TOTAL_COUNT = 0;
Client oClient = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_By_Where_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Client_By_Where_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Client_By_Where));}
#region Body Section.
if ((i_Params_Get_Client_By_Where.OWNER_ID == null) || (i_Params_Get_Client_By_Where.OWNER_ID == 0)) { i_Params_Get_Client_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Client_By_Where.START_ROW == null) { i_Params_Get_Client_By_Where.START_ROW = 0; }
if ((i_Params_Get_Client_By_Where.END_ROW == null) || (i_Params_Get_Client_By_Where.END_ROW == 0)) { i_Params_Get_Client_By_Where.END_ROW = 1000000; }
List<DALC.Client> oList_DBEntries = _AppContext.Get_Client_By_Where_Adv(i_Params_Get_Client_By_Where.CLIENT_NAME,i_Params_Get_Client_By_Where.CLIENT_PH_NB,i_Params_Get_Client_By_Where.CLIENT_MAIL,i_Params_Get_Client_By_Where.OWNER_ID,i_Params_Get_Client_By_Where.START_ROW,i_Params_Get_Client_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oClient = new Client();
oTools.CopyPropValues(oDBEntry, oClient);
oClient.My_Bloodtype = new Bloodtype();
oTools.CopyPropValues(oDBEntry.My_Bloodtype, oClient.My_Bloodtype);
oList.Add(oClient);
}
}
i_Params_Get_Client_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_By_Where_Adv");}
return oList;
}
public List<Client> Get_Client_By_Criteria_Adv_V2(Params_Get_Client_By_Criteria_V2 i_Params_Get_Client_By_Criteria_V2)
{
List<Client> oList = new List<Client>();
long? tmp_TOTAL_COUNT = 0;
Client oClient = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_By_Criteria_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Client_By_Criteria_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Client_By_Criteria_V2));}
#region Body Section.
if ((i_Params_Get_Client_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_Client_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_Client_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Client_By_Criteria_V2.START_ROW == null) { i_Params_Get_Client_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_Client_By_Criteria_V2.END_ROW == null) || (i_Params_Get_Client_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_Client_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.Client> oList_DBEntries = _AppContext.Get_Client_By_Criteria_Adv_V2(i_Params_Get_Client_By_Criteria_V2.CLIENT_NAME,i_Params_Get_Client_By_Criteria_V2.CLIENT_PH_NB,i_Params_Get_Client_By_Criteria_V2.CLIENT_MAIL,i_Params_Get_Client_By_Criteria_V2.CLIENT_DOB,i_Params_Get_Client_By_Criteria_V2.OWNER_ID,i_Params_Get_Client_By_Criteria_V2.START_ROW,i_Params_Get_Client_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oClient = new Client();
oTools.CopyPropValues(oDBEntry, oClient);
oClient.My_Bloodtype = new Bloodtype();
oTools.CopyPropValues(oDBEntry.My_Bloodtype, oClient.My_Bloodtype);
oList.Add(oClient);
}
}
i_Params_Get_Client_By_Criteria_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_By_Criteria_Adv_V2");}
return oList;
}
public List<Client> Get_Client_By_Where_Adv_V2(Params_Get_Client_By_Where_V2 i_Params_Get_Client_By_Where_V2)
{
List<Client> oList = new List<Client>();
long? tmp_TOTAL_COUNT = 0;
Client oClient = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_By_Where_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Client_By_Where_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Client_By_Where_V2));}
#region Body Section.
if ((i_Params_Get_Client_By_Where_V2.OWNER_ID == null) || (i_Params_Get_Client_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_Client_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Client_By_Where_V2.START_ROW == null) { i_Params_Get_Client_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_Client_By_Where_V2.END_ROW == null) || (i_Params_Get_Client_By_Where_V2.END_ROW == 0)) { i_Params_Get_Client_By_Where_V2.END_ROW = 1000000; }
List<DALC.Client> oList_DBEntries = _AppContext.Get_Client_By_Where_Adv_V2(i_Params_Get_Client_By_Where_V2.CLIENT_NAME,i_Params_Get_Client_By_Where_V2.CLIENT_PH_NB,i_Params_Get_Client_By_Where_V2.CLIENT_MAIL,i_Params_Get_Client_By_Where_V2.CLIENT_DOB,i_Params_Get_Client_By_Where_V2.OWNER_ID,i_Params_Get_Client_By_Where_V2.START_ROW,i_Params_Get_Client_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oClient = new Client();
oTools.CopyPropValues(oDBEntry, oClient);
oClient.My_Bloodtype = new Bloodtype();
oTools.CopyPropValues(oDBEntry.My_Bloodtype, oClient.My_Bloodtype);
oList.Add(oClient);
}
}
i_Params_Get_Client_By_Where_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_By_Where_Adv_V2");}
return oList;
}
public List<Client_fees> Get_Client_fees_By_Criteria_Adv(Params_Get_Client_fees_By_Criteria i_Params_Get_Client_fees_By_Criteria)
{
List<Client_fees> oList = new List<Client_fees>();
long? tmp_TOTAL_COUNT = 0;
Client_fees oClient_fees = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_fees_By_Criteria_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Client_fees_By_Criteria_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Client_fees_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Client_fees_By_Criteria.OWNER_ID == null) || (i_Params_Get_Client_fees_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Client_fees_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Client_fees_By_Criteria.START_ROW == null) { i_Params_Get_Client_fees_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Client_fees_By_Criteria.END_ROW == null) || (i_Params_Get_Client_fees_By_Criteria.END_ROW == 0)) { i_Params_Get_Client_fees_By_Criteria.END_ROW = 1000000; }
List<DALC.Client_fees> oList_DBEntries = _AppContext.Get_Client_fees_By_Criteria_Adv(i_Params_Get_Client_fees_By_Criteria.CLIENT_FEES_DESCRIPTION,i_Params_Get_Client_fees_By_Criteria.OWNER_ID,i_Params_Get_Client_fees_By_Criteria.START_ROW,i_Params_Get_Client_fees_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oClient_fees = new Client_fees();
oTools.CopyPropValues(oDBEntry, oClient_fees);
oClient_fees.My_Client = new Client();
oTools.CopyPropValues(oDBEntry.My_Client, oClient_fees.My_Client);
oClient_fees.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oClient_fees.My_Currency);
oClient_fees.My_Package = new Package();
oTools.CopyPropValues(oDBEntry.My_Package, oClient_fees.My_Package);
oClient_fees.My_Registration = new Registration();
oTools.CopyPropValues(oDBEntry.My_Registration, oClient_fees.My_Registration);
oList.Add(oClient_fees);
}
}
i_Params_Get_Client_fees_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_fees_By_Criteria_Adv");}
return oList;
}
public List<Client_fees> Get_Client_fees_By_Where_Adv(Params_Get_Client_fees_By_Where i_Params_Get_Client_fees_By_Where)
{
List<Client_fees> oList = new List<Client_fees>();
long? tmp_TOTAL_COUNT = 0;
Client_fees oClient_fees = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_fees_By_Where_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Client_fees_By_Where_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Client_fees_By_Where));}
#region Body Section.
if ((i_Params_Get_Client_fees_By_Where.OWNER_ID == null) || (i_Params_Get_Client_fees_By_Where.OWNER_ID == 0)) { i_Params_Get_Client_fees_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Client_fees_By_Where.START_ROW == null) { i_Params_Get_Client_fees_By_Where.START_ROW = 0; }
if ((i_Params_Get_Client_fees_By_Where.END_ROW == null) || (i_Params_Get_Client_fees_By_Where.END_ROW == 0)) { i_Params_Get_Client_fees_By_Where.END_ROW = 1000000; }
List<DALC.Client_fees> oList_DBEntries = _AppContext.Get_Client_fees_By_Where_Adv(i_Params_Get_Client_fees_By_Where.CLIENT_FEES_DESCRIPTION,i_Params_Get_Client_fees_By_Where.OWNER_ID,i_Params_Get_Client_fees_By_Where.START_ROW,i_Params_Get_Client_fees_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oClient_fees = new Client_fees();
oTools.CopyPropValues(oDBEntry, oClient_fees);
oClient_fees.My_Client = new Client();
oTools.CopyPropValues(oDBEntry.My_Client, oClient_fees.My_Client);
oClient_fees.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oClient_fees.My_Currency);
oClient_fees.My_Package = new Package();
oTools.CopyPropValues(oDBEntry.My_Package, oClient_fees.My_Package);
oClient_fees.My_Registration = new Registration();
oTools.CopyPropValues(oDBEntry.My_Registration, oClient_fees.My_Registration);
oList.Add(oClient_fees);
}
}
i_Params_Get_Client_fees_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_fees_By_Where_Adv");}
return oList;
}
public List<Contact> Get_Contact_By_Criteria_Adv(Params_Get_Contact_By_Criteria i_Params_Get_Contact_By_Criteria)
{
List<Contact> oList = new List<Contact>();
long? tmp_TOTAL_COUNT = 0;
Contact oContact = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_Criteria_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Contact_By_Criteria_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Contact_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Contact_By_Criteria.OWNER_ID == null) || (i_Params_Get_Contact_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Contact_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Contact_By_Criteria.START_ROW == null) { i_Params_Get_Contact_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Contact_By_Criteria.END_ROW == null) || (i_Params_Get_Contact_By_Criteria.END_ROW == 0)) { i_Params_Get_Contact_By_Criteria.END_ROW = 1000000; }
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_Criteria_Adv(i_Params_Get_Contact_By_Criteria.CONTACT_TYPE_CODE,i_Params_Get_Contact_By_Criteria.CONTACT,i_Params_Get_Contact_By_Criteria.DESCRIPTION,i_Params_Get_Contact_By_Criteria.OWNER_ID,i_Params_Get_Contact_By_Criteria.START_ROW,i_Params_Get_Contact_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oContact.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oContact.My_Person);
oList.Add(oContact);
}
}
i_Params_Get_Contact_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_Criteria_Adv");}
return oList;
}
public List<Contact> Get_Contact_By_Where_Adv(Params_Get_Contact_By_Where i_Params_Get_Contact_By_Where)
{
List<Contact> oList = new List<Contact>();
long? tmp_TOTAL_COUNT = 0;
Contact oContact = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_Where_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Contact_By_Where_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Contact_By_Where));}
#region Body Section.
if ((i_Params_Get_Contact_By_Where.OWNER_ID == null) || (i_Params_Get_Contact_By_Where.OWNER_ID == 0)) { i_Params_Get_Contact_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Contact_By_Where.START_ROW == null) { i_Params_Get_Contact_By_Where.START_ROW = 0; }
if ((i_Params_Get_Contact_By_Where.END_ROW == null) || (i_Params_Get_Contact_By_Where.END_ROW == 0)) { i_Params_Get_Contact_By_Where.END_ROW = 1000000; }
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_Where_Adv(i_Params_Get_Contact_By_Where.CONTACT_TYPE_CODE,i_Params_Get_Contact_By_Where.CONTACT,i_Params_Get_Contact_By_Where.DESCRIPTION,i_Params_Get_Contact_By_Where.OWNER_ID,i_Params_Get_Contact_By_Where.START_ROW,i_Params_Get_Contact_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oContact.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oContact.My_Person);
oList.Add(oContact);
}
}
i_Params_Get_Contact_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_Where_Adv");}
return oList;
}
public List<Currency> Get_Currency_By_Criteria_Adv(Params_Get_Currency_By_Criteria i_Params_Get_Currency_By_Criteria)
{
List<Currency> oList = new List<Currency>();
long? tmp_TOTAL_COUNT = 0;
Currency oCurrency = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Currency_By_Criteria_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Currency_By_Criteria_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Currency_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Currency_By_Criteria.OWNER_ID == null) || (i_Params_Get_Currency_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Currency_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Currency_By_Criteria.START_ROW == null) { i_Params_Get_Currency_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Currency_By_Criteria.END_ROW == null) || (i_Params_Get_Currency_By_Criteria.END_ROW == 0)) { i_Params_Get_Currency_By_Criteria.END_ROW = 1000000; }
List<DALC.Currency> oList_DBEntries = _AppContext.Get_Currency_By_Criteria_Adv(i_Params_Get_Currency_By_Criteria.CURRENCY_TYPE,i_Params_Get_Currency_By_Criteria.CURRENCY_SYMBOL,i_Params_Get_Currency_By_Criteria.OWNER_ID,i_Params_Get_Currency_By_Criteria.START_ROW,i_Params_Get_Currency_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Currency_By_Criteria_Adv");}
return oList;
}
public List<Currency> Get_Currency_By_Where_Adv(Params_Get_Currency_By_Where i_Params_Get_Currency_By_Where)
{
List<Currency> oList = new List<Currency>();
long? tmp_TOTAL_COUNT = 0;
Currency oCurrency = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Currency_By_Where_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Currency_By_Where_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Currency_By_Where));}
#region Body Section.
if ((i_Params_Get_Currency_By_Where.OWNER_ID == null) || (i_Params_Get_Currency_By_Where.OWNER_ID == 0)) { i_Params_Get_Currency_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Currency_By_Where.START_ROW == null) { i_Params_Get_Currency_By_Where.START_ROW = 0; }
if ((i_Params_Get_Currency_By_Where.END_ROW == null) || (i_Params_Get_Currency_By_Where.END_ROW == 0)) { i_Params_Get_Currency_By_Where.END_ROW = 1000000; }
List<DALC.Currency> oList_DBEntries = _AppContext.Get_Currency_By_Where_Adv(i_Params_Get_Currency_By_Where.CURRENCY_TYPE,i_Params_Get_Currency_By_Where.CURRENCY_SYMBOL,i_Params_Get_Currency_By_Where.OWNER_ID,i_Params_Get_Currency_By_Where.START_ROW,i_Params_Get_Currency_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Currency_By_Where_Adv");}
return oList;
}
public List<Fees> Get_Fees_By_Criteria_Adv(Params_Get_Fees_By_Criteria i_Params_Get_Fees_By_Criteria)
{
List<Fees> oList = new List<Fees>();
long? tmp_TOTAL_COUNT = 0;
Fees oFees = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Fees_By_Criteria_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Fees_By_Criteria_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Fees_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Fees_By_Criteria.OWNER_ID == null) || (i_Params_Get_Fees_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Fees_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Fees_By_Criteria.START_ROW == null) { i_Params_Get_Fees_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Fees_By_Criteria.END_ROW == null) || (i_Params_Get_Fees_By_Criteria.END_ROW == 0)) { i_Params_Get_Fees_By_Criteria.END_ROW = 1000000; }
List<DALC.Fees> oList_DBEntries = _AppContext.Get_Fees_By_Criteria_Adv(i_Params_Get_Fees_By_Criteria.FEES_DESCRIPTION,i_Params_Get_Fees_By_Criteria.OWNER_ID,i_Params_Get_Fees_By_Criteria.START_ROW,i_Params_Get_Fees_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFees = new Fees();
oTools.CopyPropValues(oDBEntry, oFees);
oFees.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oFees.My_Currency);
oList.Add(oFees);
}
}
i_Params_Get_Fees_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Fees_By_Criteria_Adv");}
return oList;
}
public List<Fees> Get_Fees_By_Where_Adv(Params_Get_Fees_By_Where i_Params_Get_Fees_By_Where)
{
List<Fees> oList = new List<Fees>();
long? tmp_TOTAL_COUNT = 0;
Fees oFees = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Fees_By_Where_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Fees_By_Where_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Fees_By_Where));}
#region Body Section.
if ((i_Params_Get_Fees_By_Where.OWNER_ID == null) || (i_Params_Get_Fees_By_Where.OWNER_ID == 0)) { i_Params_Get_Fees_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Fees_By_Where.START_ROW == null) { i_Params_Get_Fees_By_Where.START_ROW = 0; }
if ((i_Params_Get_Fees_By_Where.END_ROW == null) || (i_Params_Get_Fees_By_Where.END_ROW == 0)) { i_Params_Get_Fees_By_Where.END_ROW = 1000000; }
List<DALC.Fees> oList_DBEntries = _AppContext.Get_Fees_By_Where_Adv(i_Params_Get_Fees_By_Where.FEES_DESCRIPTION,i_Params_Get_Fees_By_Where.OWNER_ID,i_Params_Get_Fees_By_Where.START_ROW,i_Params_Get_Fees_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFees = new Fees();
oTools.CopyPropValues(oDBEntry, oFees);
oFees.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oFees.My_Currency);
oList.Add(oFees);
}
}
i_Params_Get_Fees_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Fees_By_Where_Adv");}
return oList;
}
public List<Fees> Get_Fees_By_Criteria_Adv_V2(Params_Get_Fees_By_Criteria_V2 i_Params_Get_Fees_By_Criteria_V2)
{
List<Fees> oList = new List<Fees>();
long? tmp_TOTAL_COUNT = 0;
Fees oFees = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Fees_By_Criteria_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Fees_By_Criteria_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Fees_By_Criteria_V2));}
#region Body Section.
if ((i_Params_Get_Fees_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_Fees_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_Fees_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Fees_By_Criteria_V2.START_ROW == null) { i_Params_Get_Fees_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_Fees_By_Criteria_V2.END_ROW == null) || (i_Params_Get_Fees_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_Fees_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.Fees> oList_DBEntries = _AppContext.Get_Fees_By_Criteria_Adv_V2(i_Params_Get_Fees_By_Criteria_V2.FEES_DESCRIPTION,i_Params_Get_Fees_By_Criteria_V2.FEES_ORIGIN_DATE,i_Params_Get_Fees_By_Criteria_V2.OWNER_ID,i_Params_Get_Fees_By_Criteria_V2.START_ROW,i_Params_Get_Fees_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFees = new Fees();
oTools.CopyPropValues(oDBEntry, oFees);
oFees.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oFees.My_Currency);
oList.Add(oFees);
}
}
i_Params_Get_Fees_By_Criteria_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Fees_By_Criteria_Adv_V2");}
return oList;
}
public List<Fees> Get_Fees_By_Where_Adv_V2(Params_Get_Fees_By_Where_V2 i_Params_Get_Fees_By_Where_V2)
{
List<Fees> oList = new List<Fees>();
long? tmp_TOTAL_COUNT = 0;
Fees oFees = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Fees_By_Where_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Fees_By_Where_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Fees_By_Where_V2));}
#region Body Section.
if ((i_Params_Get_Fees_By_Where_V2.OWNER_ID == null) || (i_Params_Get_Fees_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_Fees_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Fees_By_Where_V2.START_ROW == null) { i_Params_Get_Fees_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_Fees_By_Where_V2.END_ROW == null) || (i_Params_Get_Fees_By_Where_V2.END_ROW == 0)) { i_Params_Get_Fees_By_Where_V2.END_ROW = 1000000; }
List<DALC.Fees> oList_DBEntries = _AppContext.Get_Fees_By_Where_Adv_V2(i_Params_Get_Fees_By_Where_V2.FEES_DESCRIPTION,i_Params_Get_Fees_By_Where_V2.FEES_ORIGIN_DATE,i_Params_Get_Fees_By_Where_V2.OWNER_ID,i_Params_Get_Fees_By_Where_V2.START_ROW,i_Params_Get_Fees_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFees = new Fees();
oTools.CopyPropValues(oDBEntry, oFees);
oFees.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oFees.My_Currency);
oList.Add(oFees);
}
}
i_Params_Get_Fees_By_Where_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Fees_By_Where_Adv_V2");}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_Criteria_Adv(Params_Get_Loc_l1_By_Criteria i_Params_Get_Loc_l1_By_Criteria)
{
List<Loc_l1> oList = new List<Loc_l1>();
long? tmp_TOTAL_COUNT = 0;
Loc_l1 oLoc_l1 = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l1_By_Criteria_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l1_By_Criteria_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l1_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Loc_l1_By_Criteria.OWNER_ID == null) || (i_Params_Get_Loc_l1_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Loc_l1_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l1_By_Criteria.START_ROW == null) { i_Params_Get_Loc_l1_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Loc_l1_By_Criteria.END_ROW == null) || (i_Params_Get_Loc_l1_By_Criteria.END_ROW == 0)) { i_Params_Get_Loc_l1_By_Criteria.END_ROW = 1000000; }
List<DALC.Loc_l1> oList_DBEntries = _AppContext.Get_Loc_l1_By_Criteria_Adv(i_Params_Get_Loc_l1_By_Criteria.CODE,i_Params_Get_Loc_l1_By_Criteria.DESCRIPTION,i_Params_Get_Loc_l1_By_Criteria.OWNER_ID,i_Params_Get_Loc_l1_By_Criteria.START_ROW,i_Params_Get_Loc_l1_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l1_By_Criteria_Adv");}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_Where_Adv(Params_Get_Loc_l1_By_Where i_Params_Get_Loc_l1_By_Where)
{
List<Loc_l1> oList = new List<Loc_l1>();
long? tmp_TOTAL_COUNT = 0;
Loc_l1 oLoc_l1 = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l1_By_Where_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l1_By_Where_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l1_By_Where));}
#region Body Section.
if ((i_Params_Get_Loc_l1_By_Where.OWNER_ID == null) || (i_Params_Get_Loc_l1_By_Where.OWNER_ID == 0)) { i_Params_Get_Loc_l1_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l1_By_Where.START_ROW == null) { i_Params_Get_Loc_l1_By_Where.START_ROW = 0; }
if ((i_Params_Get_Loc_l1_By_Where.END_ROW == null) || (i_Params_Get_Loc_l1_By_Where.END_ROW == 0)) { i_Params_Get_Loc_l1_By_Where.END_ROW = 1000000; }
List<DALC.Loc_l1> oList_DBEntries = _AppContext.Get_Loc_l1_By_Where_Adv(i_Params_Get_Loc_l1_By_Where.CODE,i_Params_Get_Loc_l1_By_Where.DESCRIPTION,i_Params_Get_Loc_l1_By_Where.OWNER_ID,i_Params_Get_Loc_l1_By_Where.START_ROW,i_Params_Get_Loc_l1_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l1_By_Where_Adv");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Criteria_Adv(Params_Get_Loc_l2_By_Criteria i_Params_Get_Loc_l2_By_Criteria)
{
List<Loc_l2> oList = new List<Loc_l2>();
long? tmp_TOTAL_COUNT = 0;
Loc_l2 oLoc_l2 = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_Criteria_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l2_By_Criteria_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l2_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Loc_l2_By_Criteria.OWNER_ID == null) || (i_Params_Get_Loc_l2_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Loc_l2_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l2_By_Criteria.START_ROW == null) { i_Params_Get_Loc_l2_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Loc_l2_By_Criteria.END_ROW == null) || (i_Params_Get_Loc_l2_By_Criteria.END_ROW == 0)) { i_Params_Get_Loc_l2_By_Criteria.END_ROW = 1000000; }
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_Criteria_Adv(i_Params_Get_Loc_l2_By_Criteria.CODE,i_Params_Get_Loc_l2_By_Criteria.DESCRIPTION,i_Params_Get_Loc_l2_By_Criteria.OWNER_ID,i_Params_Get_Loc_l2_By_Criteria.START_ROW,i_Params_Get_Loc_l2_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oLoc_l2.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oLoc_l2.My_Loc_l1);
oList.Add(oLoc_l2);
}
}
i_Params_Get_Loc_l2_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_Criteria_Adv");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Where_Adv(Params_Get_Loc_l2_By_Where i_Params_Get_Loc_l2_By_Where)
{
List<Loc_l2> oList = new List<Loc_l2>();
long? tmp_TOTAL_COUNT = 0;
Loc_l2 oLoc_l2 = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_Where_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l2_By_Where_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l2_By_Where));}
#region Body Section.
if ((i_Params_Get_Loc_l2_By_Where.OWNER_ID == null) || (i_Params_Get_Loc_l2_By_Where.OWNER_ID == 0)) { i_Params_Get_Loc_l2_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l2_By_Where.START_ROW == null) { i_Params_Get_Loc_l2_By_Where.START_ROW = 0; }
if ((i_Params_Get_Loc_l2_By_Where.END_ROW == null) || (i_Params_Get_Loc_l2_By_Where.END_ROW == 0)) { i_Params_Get_Loc_l2_By_Where.END_ROW = 1000000; }
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_Where_Adv(i_Params_Get_Loc_l2_By_Where.CODE,i_Params_Get_Loc_l2_By_Where.DESCRIPTION,i_Params_Get_Loc_l2_By_Where.OWNER_ID,i_Params_Get_Loc_l2_By_Where.START_ROW,i_Params_Get_Loc_l2_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oLoc_l2.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oLoc_l2.My_Loc_l1);
oList.Add(oLoc_l2);
}
}
i_Params_Get_Loc_l2_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_Where_Adv");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Criteria_Adv(Params_Get_Loc_l3_By_Criteria i_Params_Get_Loc_l3_By_Criteria)
{
List<Loc_l3> oList = new List<Loc_l3>();
long? tmp_TOTAL_COUNT = 0;
Loc_l3 oLoc_l3 = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_Criteria_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l3_By_Criteria_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l3_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Loc_l3_By_Criteria.OWNER_ID == null) || (i_Params_Get_Loc_l3_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Loc_l3_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l3_By_Criteria.START_ROW == null) { i_Params_Get_Loc_l3_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Loc_l3_By_Criteria.END_ROW == null) || (i_Params_Get_Loc_l3_By_Criteria.END_ROW == 0)) { i_Params_Get_Loc_l3_By_Criteria.END_ROW = 1000000; }
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_Criteria_Adv(i_Params_Get_Loc_l3_By_Criteria.CODE,i_Params_Get_Loc_l3_By_Criteria.DESCRIPTION,i_Params_Get_Loc_l3_By_Criteria.OWNER_ID,i_Params_Get_Loc_l3_By_Criteria.START_ROW,i_Params_Get_Loc_l3_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oLoc_l3.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oLoc_l3.My_Loc_l2);
oList.Add(oLoc_l3);
}
}
i_Params_Get_Loc_l3_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_Criteria_Adv");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Where_Adv(Params_Get_Loc_l3_By_Where i_Params_Get_Loc_l3_By_Where)
{
List<Loc_l3> oList = new List<Loc_l3>();
long? tmp_TOTAL_COUNT = 0;
Loc_l3 oLoc_l3 = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_Where_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l3_By_Where_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l3_By_Where));}
#region Body Section.
if ((i_Params_Get_Loc_l3_By_Where.OWNER_ID == null) || (i_Params_Get_Loc_l3_By_Where.OWNER_ID == 0)) { i_Params_Get_Loc_l3_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l3_By_Where.START_ROW == null) { i_Params_Get_Loc_l3_By_Where.START_ROW = 0; }
if ((i_Params_Get_Loc_l3_By_Where.END_ROW == null) || (i_Params_Get_Loc_l3_By_Where.END_ROW == 0)) { i_Params_Get_Loc_l3_By_Where.END_ROW = 1000000; }
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_Where_Adv(i_Params_Get_Loc_l3_By_Where.CODE,i_Params_Get_Loc_l3_By_Where.DESCRIPTION,i_Params_Get_Loc_l3_By_Where.OWNER_ID,i_Params_Get_Loc_l3_By_Where.START_ROW,i_Params_Get_Loc_l3_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oLoc_l3.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oLoc_l3.My_Loc_l2);
oList.Add(oLoc_l3);
}
}
i_Params_Get_Loc_l3_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_Where_Adv");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Criteria_Adv(Params_Get_Loc_l4_By_Criteria i_Params_Get_Loc_l4_By_Criteria)
{
List<Loc_l4> oList = new List<Loc_l4>();
long? tmp_TOTAL_COUNT = 0;
Loc_l4 oLoc_l4 = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_Criteria_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l4_By_Criteria_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l4_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Loc_l4_By_Criteria.OWNER_ID == null) || (i_Params_Get_Loc_l4_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Loc_l4_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l4_By_Criteria.START_ROW == null) { i_Params_Get_Loc_l4_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Loc_l4_By_Criteria.END_ROW == null) || (i_Params_Get_Loc_l4_By_Criteria.END_ROW == 0)) { i_Params_Get_Loc_l4_By_Criteria.END_ROW = 1000000; }
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_Criteria_Adv(i_Params_Get_Loc_l4_By_Criteria.CODE,i_Params_Get_Loc_l4_By_Criteria.DESCRIPTION,i_Params_Get_Loc_l4_By_Criteria.OWNER_ID,i_Params_Get_Loc_l4_By_Criteria.START_ROW,i_Params_Get_Loc_l4_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oLoc_l4.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oLoc_l4.My_Loc_l3);
oList.Add(oLoc_l4);
}
}
i_Params_Get_Loc_l4_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_Criteria_Adv");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Where_Adv(Params_Get_Loc_l4_By_Where i_Params_Get_Loc_l4_By_Where)
{
List<Loc_l4> oList = new List<Loc_l4>();
long? tmp_TOTAL_COUNT = 0;
Loc_l4 oLoc_l4 = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_Where_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l4_By_Where_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l4_By_Where));}
#region Body Section.
if ((i_Params_Get_Loc_l4_By_Where.OWNER_ID == null) || (i_Params_Get_Loc_l4_By_Where.OWNER_ID == 0)) { i_Params_Get_Loc_l4_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Loc_l4_By_Where.START_ROW == null) { i_Params_Get_Loc_l4_By_Where.START_ROW = 0; }
if ((i_Params_Get_Loc_l4_By_Where.END_ROW == null) || (i_Params_Get_Loc_l4_By_Where.END_ROW == 0)) { i_Params_Get_Loc_l4_By_Where.END_ROW = 1000000; }
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_Where_Adv(i_Params_Get_Loc_l4_By_Where.CODE,i_Params_Get_Loc_l4_By_Where.DESCRIPTION,i_Params_Get_Loc_l4_By_Where.OWNER_ID,i_Params_Get_Loc_l4_By_Where.START_ROW,i_Params_Get_Loc_l4_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oLoc_l4.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oLoc_l4.My_Loc_l3);
oList.Add(oLoc_l4);
}
}
i_Params_Get_Loc_l4_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_Where_Adv");}
return oList;
}
public List<Method_run> Get_Method_run_By_Criteria_Adv(Params_Get_Method_run_By_Criteria i_Params_Get_Method_run_By_Criteria)
{
List<Method_run> oList = new List<Method_run>();
long? tmp_TOTAL_COUNT = 0;
Method_run oMethod_run = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Method_run_By_Criteria_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Method_run_By_Criteria_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Method_run_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Method_run_By_Criteria.OWNER_ID == null) || (i_Params_Get_Method_run_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Method_run_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Method_run_By_Criteria.START_ROW == null) { i_Params_Get_Method_run_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Method_run_By_Criteria.END_ROW == null) || (i_Params_Get_Method_run_By_Criteria.END_ROW == 0)) { i_Params_Get_Method_run_By_Criteria.END_ROW = 1000000; }
List<DALC.Method_run> oList_DBEntries = _AppContext.Get_Method_run_By_Criteria_Adv(i_Params_Get_Method_run_By_Criteria.METHOD_NAME,i_Params_Get_Method_run_By_Criteria.INPUT_PARAM,i_Params_Get_Method_run_By_Criteria.OWNER_ID,i_Params_Get_Method_run_By_Criteria.START_ROW,i_Params_Get_Method_run_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Method_run_By_Criteria_Adv");}
return oList;
}
public List<Method_run> Get_Method_run_By_Where_Adv(Params_Get_Method_run_By_Where i_Params_Get_Method_run_By_Where)
{
List<Method_run> oList = new List<Method_run>();
long? tmp_TOTAL_COUNT = 0;
Method_run oMethod_run = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Method_run_By_Where_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Method_run_By_Where_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Method_run_By_Where));}
#region Body Section.
if ((i_Params_Get_Method_run_By_Where.OWNER_ID == null) || (i_Params_Get_Method_run_By_Where.OWNER_ID == 0)) { i_Params_Get_Method_run_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Method_run_By_Where.START_ROW == null) { i_Params_Get_Method_run_By_Where.START_ROW = 0; }
if ((i_Params_Get_Method_run_By_Where.END_ROW == null) || (i_Params_Get_Method_run_By_Where.END_ROW == 0)) { i_Params_Get_Method_run_By_Where.END_ROW = 1000000; }
List<DALC.Method_run> oList_DBEntries = _AppContext.Get_Method_run_By_Where_Adv(i_Params_Get_Method_run_By_Where.METHOD_NAME,i_Params_Get_Method_run_By_Where.INPUT_PARAM,i_Params_Get_Method_run_By_Where.OWNER_ID,i_Params_Get_Method_run_By_Where.START_ROW,i_Params_Get_Method_run_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Method_run_By_Where_Adv");}
return oList;
}
public List<Method_run> Get_Method_run_By_Criteria_Adv_V2(Params_Get_Method_run_By_Criteria_V2 i_Params_Get_Method_run_By_Criteria_V2)
{
List<Method_run> oList = new List<Method_run>();
long? tmp_TOTAL_COUNT = 0;
Method_run oMethod_run = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Method_run_By_Criteria_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Method_run_By_Criteria_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Method_run_By_Criteria_V2));}
#region Body Section.
if ((i_Params_Get_Method_run_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_Method_run_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_Method_run_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Method_run_By_Criteria_V2.START_ROW == null) { i_Params_Get_Method_run_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_Method_run_By_Criteria_V2.END_ROW == null) || (i_Params_Get_Method_run_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_Method_run_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.Method_run> oList_DBEntries = _AppContext.Get_Method_run_By_Criteria_Adv_V2(i_Params_Get_Method_run_By_Criteria_V2.METHOD_NAME,i_Params_Get_Method_run_By_Criteria_V2.RUN_DATE,i_Params_Get_Method_run_By_Criteria_V2.INPUT_PARAM,i_Params_Get_Method_run_By_Criteria_V2.OWNER_ID,i_Params_Get_Method_run_By_Criteria_V2.START_ROW,i_Params_Get_Method_run_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Method_run_By_Criteria_Adv_V2");}
return oList;
}
public List<Method_run> Get_Method_run_By_Where_Adv_V2(Params_Get_Method_run_By_Where_V2 i_Params_Get_Method_run_By_Where_V2)
{
List<Method_run> oList = new List<Method_run>();
long? tmp_TOTAL_COUNT = 0;
Method_run oMethod_run = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Method_run_By_Where_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Method_run_By_Where_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Method_run_By_Where_V2));}
#region Body Section.
if ((i_Params_Get_Method_run_By_Where_V2.OWNER_ID == null) || (i_Params_Get_Method_run_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_Method_run_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Method_run_By_Where_V2.START_ROW == null) { i_Params_Get_Method_run_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_Method_run_By_Where_V2.END_ROW == null) || (i_Params_Get_Method_run_By_Where_V2.END_ROW == 0)) { i_Params_Get_Method_run_By_Where_V2.END_ROW = 1000000; }
List<DALC.Method_run> oList_DBEntries = _AppContext.Get_Method_run_By_Where_Adv_V2(i_Params_Get_Method_run_By_Where_V2.METHOD_NAME,i_Params_Get_Method_run_By_Where_V2.RUN_DATE,i_Params_Get_Method_run_By_Where_V2.INPUT_PARAM,i_Params_Get_Method_run_By_Where_V2.OWNER_ID,i_Params_Get_Method_run_By_Where_V2.START_ROW,i_Params_Get_Method_run_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Method_run_By_Where_Adv_V2");}
return oList;
}
public List<Package> Get_Package_By_Criteria_Adv(Params_Get_Package_By_Criteria i_Params_Get_Package_By_Criteria)
{
List<Package> oList = new List<Package>();
long? tmp_TOTAL_COUNT = 0;
Package oPackage = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Package_By_Criteria_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Package_By_Criteria_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Package_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Package_By_Criteria.OWNER_ID == null) || (i_Params_Get_Package_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Package_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Package_By_Criteria.START_ROW == null) { i_Params_Get_Package_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Package_By_Criteria.END_ROW == null) || (i_Params_Get_Package_By_Criteria.END_ROW == 0)) { i_Params_Get_Package_By_Criteria.END_ROW = 1000000; }
List<DALC.Package> oList_DBEntries = _AppContext.Get_Package_By_Criteria_Adv(i_Params_Get_Package_By_Criteria.PACKAGE_NAME,i_Params_Get_Package_By_Criteria.PACKAGE_TYPE,i_Params_Get_Package_By_Criteria.PACKAGE_TIMELINE,i_Params_Get_Package_By_Criteria.OWNER_ID,i_Params_Get_Package_By_Criteria.START_ROW,i_Params_Get_Package_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oPackage = new Package();
oTools.CopyPropValues(oDBEntry, oPackage);
oPackage.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oPackage.My_Currency);
oList.Add(oPackage);
}
}
i_Params_Get_Package_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Package_By_Criteria_Adv");}
return oList;
}
public List<Package> Get_Package_By_Where_Adv(Params_Get_Package_By_Where i_Params_Get_Package_By_Where)
{
List<Package> oList = new List<Package>();
long? tmp_TOTAL_COUNT = 0;
Package oPackage = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Package_By_Where_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Package_By_Where_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Package_By_Where));}
#region Body Section.
if ((i_Params_Get_Package_By_Where.OWNER_ID == null) || (i_Params_Get_Package_By_Where.OWNER_ID == 0)) { i_Params_Get_Package_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Package_By_Where.START_ROW == null) { i_Params_Get_Package_By_Where.START_ROW = 0; }
if ((i_Params_Get_Package_By_Where.END_ROW == null) || (i_Params_Get_Package_By_Where.END_ROW == 0)) { i_Params_Get_Package_By_Where.END_ROW = 1000000; }
List<DALC.Package> oList_DBEntries = _AppContext.Get_Package_By_Where_Adv(i_Params_Get_Package_By_Where.PACKAGE_NAME,i_Params_Get_Package_By_Where.PACKAGE_TYPE,i_Params_Get_Package_By_Where.PACKAGE_TIMELINE,i_Params_Get_Package_By_Where.OWNER_ID,i_Params_Get_Package_By_Where.START_ROW,i_Params_Get_Package_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oPackage = new Package();
oTools.CopyPropValues(oDBEntry, oPackage);
oPackage.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oPackage.My_Currency);
oList.Add(oPackage);
}
}
i_Params_Get_Package_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Package_By_Where_Adv");}
return oList;
}
public List<Package> Get_Package_By_Criteria_Adv_V2(Params_Get_Package_By_Criteria_V2 i_Params_Get_Package_By_Criteria_V2)
{
List<Package> oList = new List<Package>();
long? tmp_TOTAL_COUNT = 0;
Package oPackage = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Package_By_Criteria_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Package_By_Criteria_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Package_By_Criteria_V2));}
#region Body Section.
if ((i_Params_Get_Package_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_Package_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_Package_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Package_By_Criteria_V2.START_ROW == null) { i_Params_Get_Package_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_Package_By_Criteria_V2.END_ROW == null) || (i_Params_Get_Package_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_Package_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.Package> oList_DBEntries = _AppContext.Get_Package_By_Criteria_Adv_V2(i_Params_Get_Package_By_Criteria_V2.PACKAGE_NAME,i_Params_Get_Package_By_Criteria_V2.PACKAGE_TYPE,i_Params_Get_Package_By_Criteria_V2.PACKAGE_ENDING_DATE,i_Params_Get_Package_By_Criteria_V2.PACKAGE_TIMELINE,i_Params_Get_Package_By_Criteria_V2.PACKAGE_STARTING_DATE,i_Params_Get_Package_By_Criteria_V2.OWNER_ID,i_Params_Get_Package_By_Criteria_V2.START_ROW,i_Params_Get_Package_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oPackage = new Package();
oTools.CopyPropValues(oDBEntry, oPackage);
oPackage.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oPackage.My_Currency);
oList.Add(oPackage);
}
}
i_Params_Get_Package_By_Criteria_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Package_By_Criteria_Adv_V2");}
return oList;
}
public List<Package> Get_Package_By_Where_Adv_V2(Params_Get_Package_By_Where_V2 i_Params_Get_Package_By_Where_V2)
{
List<Package> oList = new List<Package>();
long? tmp_TOTAL_COUNT = 0;
Package oPackage = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Package_By_Where_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Package_By_Where_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Package_By_Where_V2));}
#region Body Section.
if ((i_Params_Get_Package_By_Where_V2.OWNER_ID == null) || (i_Params_Get_Package_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_Package_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Package_By_Where_V2.START_ROW == null) { i_Params_Get_Package_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_Package_By_Where_V2.END_ROW == null) || (i_Params_Get_Package_By_Where_V2.END_ROW == 0)) { i_Params_Get_Package_By_Where_V2.END_ROW = 1000000; }
List<DALC.Package> oList_DBEntries = _AppContext.Get_Package_By_Where_Adv_V2(i_Params_Get_Package_By_Where_V2.PACKAGE_NAME,i_Params_Get_Package_By_Where_V2.PACKAGE_TYPE,i_Params_Get_Package_By_Where_V2.PACKAGE_ENDING_DATE,i_Params_Get_Package_By_Where_V2.PACKAGE_TIMELINE,i_Params_Get_Package_By_Where_V2.PACKAGE_STARTING_DATE,i_Params_Get_Package_By_Where_V2.OWNER_ID,i_Params_Get_Package_By_Where_V2.START_ROW,i_Params_Get_Package_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oPackage = new Package();
oTools.CopyPropValues(oDBEntry, oPackage);
oPackage.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oPackage.My_Currency);
oList.Add(oPackage);
}
}
i_Params_Get_Package_By_Where_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Package_By_Where_Adv_V2");}
return oList;
}
public List<Person> Get_Person_By_Criteria_Adv(Params_Get_Person_By_Criteria i_Params_Get_Person_By_Criteria)
{
List<Person> oList = new List<Person>();
long? tmp_TOTAL_COUNT = 0;
Person oPerson = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Person_By_Criteria_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Person_By_Criteria_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Person_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Person_By_Criteria.OWNER_ID == null) || (i_Params_Get_Person_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Person_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Person_By_Criteria.START_ROW == null) { i_Params_Get_Person_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Person_By_Criteria.END_ROW == null) || (i_Params_Get_Person_By_Criteria.END_ROW == 0)) { i_Params_Get_Person_By_Criteria.END_ROW = 1000000; }
List<DALC.Person> oList_DBEntries = _AppContext.Get_Person_By_Criteria_Adv(i_Params_Get_Person_By_Criteria.FIRST_NAME,i_Params_Get_Person_By_Criteria.LAST_NAME,i_Params_Get_Person_By_Criteria.FATHER_NAME,i_Params_Get_Person_By_Criteria.MOTHER_NAME,i_Params_Get_Person_By_Criteria.TITLE_CODE,i_Params_Get_Person_By_Criteria.GENDER_CODE,i_Params_Get_Person_By_Criteria.RELIGION_CODE,i_Params_Get_Person_By_Criteria.DESCRIPTION,i_Params_Get_Person_By_Criteria.OWNER_ID,i_Params_Get_Person_By_Criteria.START_ROW,i_Params_Get_Person_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Person_By_Criteria_Adv");}
return oList;
}
public List<Person> Get_Person_By_Where_Adv(Params_Get_Person_By_Where i_Params_Get_Person_By_Where)
{
List<Person> oList = new List<Person>();
long? tmp_TOTAL_COUNT = 0;
Person oPerson = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Person_By_Where_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Person_By_Where_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Person_By_Where));}
#region Body Section.
if ((i_Params_Get_Person_By_Where.OWNER_ID == null) || (i_Params_Get_Person_By_Where.OWNER_ID == 0)) { i_Params_Get_Person_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Person_By_Where.START_ROW == null) { i_Params_Get_Person_By_Where.START_ROW = 0; }
if ((i_Params_Get_Person_By_Where.END_ROW == null) || (i_Params_Get_Person_By_Where.END_ROW == 0)) { i_Params_Get_Person_By_Where.END_ROW = 1000000; }
List<DALC.Person> oList_DBEntries = _AppContext.Get_Person_By_Where_Adv(i_Params_Get_Person_By_Where.FIRST_NAME,i_Params_Get_Person_By_Where.LAST_NAME,i_Params_Get_Person_By_Where.FATHER_NAME,i_Params_Get_Person_By_Where.MOTHER_NAME,i_Params_Get_Person_By_Where.TITLE_CODE,i_Params_Get_Person_By_Where.GENDER_CODE,i_Params_Get_Person_By_Where.RELIGION_CODE,i_Params_Get_Person_By_Where.DESCRIPTION,i_Params_Get_Person_By_Where.OWNER_ID,i_Params_Get_Person_By_Where.START_ROW,i_Params_Get_Person_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Person_By_Where_Adv");}
return oList;
}
public List<Person> Get_Person_By_Criteria_Adv_V2(Params_Get_Person_By_Criteria_V2 i_Params_Get_Person_By_Criteria_V2)
{
List<Person> oList = new List<Person>();
long? tmp_TOTAL_COUNT = 0;
Person oPerson = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Person_By_Criteria_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Person_By_Criteria_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Person_By_Criteria_V2));}
#region Body Section.
if ((i_Params_Get_Person_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_Person_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_Person_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Person_By_Criteria_V2.START_ROW == null) { i_Params_Get_Person_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_Person_By_Criteria_V2.END_ROW == null) || (i_Params_Get_Person_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_Person_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.Person> oList_DBEntries = _AppContext.Get_Person_By_Criteria_Adv_V2(i_Params_Get_Person_By_Criteria_V2.FIRST_NAME,i_Params_Get_Person_By_Criteria_V2.LAST_NAME,i_Params_Get_Person_By_Criteria_V2.FATHER_NAME,i_Params_Get_Person_By_Criteria_V2.MOTHER_NAME,i_Params_Get_Person_By_Criteria_V2.TITLE_CODE,i_Params_Get_Person_By_Criteria_V2.GENDER_CODE,i_Params_Get_Person_By_Criteria_V2.RELIGION_CODE,i_Params_Get_Person_By_Criteria_V2.BIRTH_DATE,i_Params_Get_Person_By_Criteria_V2.DESCRIPTION,i_Params_Get_Person_By_Criteria_V2.OWNER_ID,i_Params_Get_Person_By_Criteria_V2.START_ROW,i_Params_Get_Person_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Person_By_Criteria_Adv_V2");}
return oList;
}
public List<Person> Get_Person_By_Where_Adv_V2(Params_Get_Person_By_Where_V2 i_Params_Get_Person_By_Where_V2)
{
List<Person> oList = new List<Person>();
long? tmp_TOTAL_COUNT = 0;
Person oPerson = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Person_By_Where_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Person_By_Where_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Person_By_Where_V2));}
#region Body Section.
if ((i_Params_Get_Person_By_Where_V2.OWNER_ID == null) || (i_Params_Get_Person_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_Person_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Person_By_Where_V2.START_ROW == null) { i_Params_Get_Person_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_Person_By_Where_V2.END_ROW == null) || (i_Params_Get_Person_By_Where_V2.END_ROW == 0)) { i_Params_Get_Person_By_Where_V2.END_ROW = 1000000; }
List<DALC.Person> oList_DBEntries = _AppContext.Get_Person_By_Where_Adv_V2(i_Params_Get_Person_By_Where_V2.FIRST_NAME,i_Params_Get_Person_By_Where_V2.LAST_NAME,i_Params_Get_Person_By_Where_V2.FATHER_NAME,i_Params_Get_Person_By_Where_V2.MOTHER_NAME,i_Params_Get_Person_By_Where_V2.TITLE_CODE,i_Params_Get_Person_By_Where_V2.GENDER_CODE,i_Params_Get_Person_By_Where_V2.RELIGION_CODE,i_Params_Get_Person_By_Where_V2.BIRTH_DATE,i_Params_Get_Person_By_Where_V2.DESCRIPTION,i_Params_Get_Person_By_Where_V2.OWNER_ID,i_Params_Get_Person_By_Where_V2.START_ROW,i_Params_Get_Person_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_Person_By_Where_Adv_V2");}
return oList;
}
public List<Registration> Get_Registration_By_Criteria_Adv(Params_Get_Registration_By_Criteria i_Params_Get_Registration_By_Criteria)
{
List<Registration> oList = new List<Registration>();
long? tmp_TOTAL_COUNT = 0;
Registration oRegistration = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Registration_By_Criteria_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Registration_By_Criteria_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Registration_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Registration_By_Criteria.OWNER_ID == null) || (i_Params_Get_Registration_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Registration_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Registration_By_Criteria.START_ROW == null) { i_Params_Get_Registration_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Registration_By_Criteria.END_ROW == null) || (i_Params_Get_Registration_By_Criteria.END_ROW == 0)) { i_Params_Get_Registration_By_Criteria.END_ROW = 1000000; }
List<DALC.Registration> oList_DBEntries = _AppContext.Get_Registration_By_Criteria_Adv(i_Params_Get_Registration_By_Criteria.REGISTRATION_DESCRIPTION,i_Params_Get_Registration_By_Criteria.OWNER_ID,i_Params_Get_Registration_By_Criteria.START_ROW,i_Params_Get_Registration_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oRegistration = new Registration();
oTools.CopyPropValues(oDBEntry, oRegistration);
oRegistration.My_Client = new Client();
oTools.CopyPropValues(oDBEntry.My_Client, oRegistration.My_Client);
oRegistration.My_Package = new Package();
oTools.CopyPropValues(oDBEntry.My_Package, oRegistration.My_Package);
oRegistration.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oRegistration.My_Currency);
oList.Add(oRegistration);
}
}
i_Params_Get_Registration_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Registration_By_Criteria_Adv");}
return oList;
}
public List<Registration> Get_Registration_By_Where_Adv(Params_Get_Registration_By_Where i_Params_Get_Registration_By_Where)
{
List<Registration> oList = new List<Registration>();
long? tmp_TOTAL_COUNT = 0;
Registration oRegistration = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Registration_By_Where_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Registration_By_Where_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Registration_By_Where));}
#region Body Section.
if ((i_Params_Get_Registration_By_Where.OWNER_ID == null) || (i_Params_Get_Registration_By_Where.OWNER_ID == 0)) { i_Params_Get_Registration_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Registration_By_Where.START_ROW == null) { i_Params_Get_Registration_By_Where.START_ROW = 0; }
if ((i_Params_Get_Registration_By_Where.END_ROW == null) || (i_Params_Get_Registration_By_Where.END_ROW == 0)) { i_Params_Get_Registration_By_Where.END_ROW = 1000000; }
List<DALC.Registration> oList_DBEntries = _AppContext.Get_Registration_By_Where_Adv(i_Params_Get_Registration_By_Where.REGISTRATION_DESCRIPTION,i_Params_Get_Registration_By_Where.OWNER_ID,i_Params_Get_Registration_By_Where.START_ROW,i_Params_Get_Registration_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oRegistration = new Registration();
oTools.CopyPropValues(oDBEntry, oRegistration);
oRegistration.My_Client = new Client();
oTools.CopyPropValues(oDBEntry.My_Client, oRegistration.My_Client);
oRegistration.My_Package = new Package();
oTools.CopyPropValues(oDBEntry.My_Package, oRegistration.My_Package);
oRegistration.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oRegistration.My_Currency);
oList.Add(oRegistration);
}
}
i_Params_Get_Registration_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Registration_By_Where_Adv");}
return oList;
}
public List<Registration> Get_Registration_By_Criteria_Adv_V2(Params_Get_Registration_By_Criteria_V2 i_Params_Get_Registration_By_Criteria_V2)
{
List<Registration> oList = new List<Registration>();
long? tmp_TOTAL_COUNT = 0;
Registration oRegistration = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Registration_By_Criteria_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Registration_By_Criteria_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Registration_By_Criteria_V2));}
#region Body Section.
if ((i_Params_Get_Registration_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_Registration_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_Registration_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Registration_By_Criteria_V2.START_ROW == null) { i_Params_Get_Registration_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_Registration_By_Criteria_V2.END_ROW == null) || (i_Params_Get_Registration_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_Registration_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.Registration> oList_DBEntries = _AppContext.Get_Registration_By_Criteria_Adv_V2(i_Params_Get_Registration_By_Criteria_V2.REGISTRATION_DATE,i_Params_Get_Registration_By_Criteria_V2.REGISTRATION_DESCRIPTION,i_Params_Get_Registration_By_Criteria_V2.OWNER_ID,i_Params_Get_Registration_By_Criteria_V2.START_ROW,i_Params_Get_Registration_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oRegistration = new Registration();
oTools.CopyPropValues(oDBEntry, oRegistration);
oRegistration.My_Client = new Client();
oTools.CopyPropValues(oDBEntry.My_Client, oRegistration.My_Client);
oRegistration.My_Package = new Package();
oTools.CopyPropValues(oDBEntry.My_Package, oRegistration.My_Package);
oRegistration.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oRegistration.My_Currency);
oList.Add(oRegistration);
}
}
i_Params_Get_Registration_By_Criteria_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Registration_By_Criteria_Adv_V2");}
return oList;
}
public List<Registration> Get_Registration_By_Where_Adv_V2(Params_Get_Registration_By_Where_V2 i_Params_Get_Registration_By_Where_V2)
{
List<Registration> oList = new List<Registration>();
long? tmp_TOTAL_COUNT = 0;
Registration oRegistration = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Registration_By_Where_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Registration_By_Where_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Registration_By_Where_V2));}
#region Body Section.
if ((i_Params_Get_Registration_By_Where_V2.OWNER_ID == null) || (i_Params_Get_Registration_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_Registration_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Registration_By_Where_V2.START_ROW == null) { i_Params_Get_Registration_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_Registration_By_Where_V2.END_ROW == null) || (i_Params_Get_Registration_By_Where_V2.END_ROW == 0)) { i_Params_Get_Registration_By_Where_V2.END_ROW = 1000000; }
List<DALC.Registration> oList_DBEntries = _AppContext.Get_Registration_By_Where_Adv_V2(i_Params_Get_Registration_By_Where_V2.REGISTRATION_DATE,i_Params_Get_Registration_By_Where_V2.REGISTRATION_DESCRIPTION,i_Params_Get_Registration_By_Where_V2.OWNER_ID,i_Params_Get_Registration_By_Where_V2.START_ROW,i_Params_Get_Registration_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oRegistration = new Registration();
oTools.CopyPropValues(oDBEntry, oRegistration);
oRegistration.My_Client = new Client();
oTools.CopyPropValues(oDBEntry.My_Client, oRegistration.My_Client);
oRegistration.My_Package = new Package();
oTools.CopyPropValues(oDBEntry.My_Package, oRegistration.My_Package);
oRegistration.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oRegistration.My_Currency);
oList.Add(oRegistration);
}
}
i_Params_Get_Registration_By_Where_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Registration_By_Where_Adv_V2");}
return oList;
}
public List<Session> Get_Session_By_Criteria_Adv(Params_Get_Session_By_Criteria i_Params_Get_Session_By_Criteria)
{
List<Session> oList = new List<Session>();
long? tmp_TOTAL_COUNT = 0;
Session oSession = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Session_By_Criteria_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Session_By_Criteria_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Session_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Session_By_Criteria.OWNER_ID == null) || (i_Params_Get_Session_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Session_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Session_By_Criteria.START_ROW == null) { i_Params_Get_Session_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Session_By_Criteria.END_ROW == null) || (i_Params_Get_Session_By_Criteria.END_ROW == 0)) { i_Params_Get_Session_By_Criteria.END_ROW = 1000000; }
List<DALC.Session> oList_DBEntries = _AppContext.Get_Session_By_Criteria_Adv(i_Params_Get_Session_By_Criteria.DESCRIPTION,i_Params_Get_Session_By_Criteria.OWNER_ID,i_Params_Get_Session_By_Criteria.START_ROW,i_Params_Get_Session_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSession = new Session();
oTools.CopyPropValues(oDBEntry, oSession);
oSession.My_Package = new Package();
oTools.CopyPropValues(oDBEntry.My_Package, oSession.My_Package);
oSession.My_Client_fees = new Client_fees();
oTools.CopyPropValues(oDBEntry.My_Client_fees, oSession.My_Client_fees);
oList.Add(oSession);
}
}
i_Params_Get_Session_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Session_By_Criteria_Adv");}
return oList;
}
public List<Session> Get_Session_By_Where_Adv(Params_Get_Session_By_Where i_Params_Get_Session_By_Where)
{
List<Session> oList = new List<Session>();
long? tmp_TOTAL_COUNT = 0;
Session oSession = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Session_By_Where_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Session_By_Where_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Session_By_Where));}
#region Body Section.
if ((i_Params_Get_Session_By_Where.OWNER_ID == null) || (i_Params_Get_Session_By_Where.OWNER_ID == 0)) { i_Params_Get_Session_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Session_By_Where.START_ROW == null) { i_Params_Get_Session_By_Where.START_ROW = 0; }
if ((i_Params_Get_Session_By_Where.END_ROW == null) || (i_Params_Get_Session_By_Where.END_ROW == 0)) { i_Params_Get_Session_By_Where.END_ROW = 1000000; }
List<DALC.Session> oList_DBEntries = _AppContext.Get_Session_By_Where_Adv(i_Params_Get_Session_By_Where.DESCRIPTION,i_Params_Get_Session_By_Where.OWNER_ID,i_Params_Get_Session_By_Where.START_ROW,i_Params_Get_Session_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSession = new Session();
oTools.CopyPropValues(oDBEntry, oSession);
oSession.My_Package = new Package();
oTools.CopyPropValues(oDBEntry.My_Package, oSession.My_Package);
oSession.My_Client_fees = new Client_fees();
oTools.CopyPropValues(oDBEntry.My_Client_fees, oSession.My_Client_fees);
oList.Add(oSession);
}
}
i_Params_Get_Session_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Session_By_Where_Adv");}
return oList;
}
public List<Session> Get_Session_By_Criteria_Adv_V2(Params_Get_Session_By_Criteria_V2 i_Params_Get_Session_By_Criteria_V2)
{
List<Session> oList = new List<Session>();
long? tmp_TOTAL_COUNT = 0;
Session oSession = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Session_By_Criteria_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Session_By_Criteria_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Session_By_Criteria_V2));}
#region Body Section.
if ((i_Params_Get_Session_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_Session_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_Session_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Session_By_Criteria_V2.START_ROW == null) { i_Params_Get_Session_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_Session_By_Criteria_V2.END_ROW == null) || (i_Params_Get_Session_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_Session_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.Session> oList_DBEntries = _AppContext.Get_Session_By_Criteria_Adv_V2(i_Params_Get_Session_By_Criteria_V2.SESSION_STARTING_DATE,i_Params_Get_Session_By_Criteria_V2.SESSION_ENDING_DATE,i_Params_Get_Session_By_Criteria_V2.DESCRIPTION,i_Params_Get_Session_By_Criteria_V2.OWNER_ID,i_Params_Get_Session_By_Criteria_V2.START_ROW,i_Params_Get_Session_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSession = new Session();
oTools.CopyPropValues(oDBEntry, oSession);
oSession.My_Package = new Package();
oTools.CopyPropValues(oDBEntry.My_Package, oSession.My_Package);
oSession.My_Client_fees = new Client_fees();
oTools.CopyPropValues(oDBEntry.My_Client_fees, oSession.My_Client_fees);
oList.Add(oSession);
}
}
i_Params_Get_Session_By_Criteria_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Session_By_Criteria_Adv_V2");}
return oList;
}
public List<Session> Get_Session_By_Where_Adv_V2(Params_Get_Session_By_Where_V2 i_Params_Get_Session_By_Where_V2)
{
List<Session> oList = new List<Session>();
long? tmp_TOTAL_COUNT = 0;
Session oSession = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Session_By_Where_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Session_By_Where_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Session_By_Where_V2));}
#region Body Section.
if ((i_Params_Get_Session_By_Where_V2.OWNER_ID == null) || (i_Params_Get_Session_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_Session_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Session_By_Where_V2.START_ROW == null) { i_Params_Get_Session_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_Session_By_Where_V2.END_ROW == null) || (i_Params_Get_Session_By_Where_V2.END_ROW == 0)) { i_Params_Get_Session_By_Where_V2.END_ROW = 1000000; }
List<DALC.Session> oList_DBEntries = _AppContext.Get_Session_By_Where_Adv_V2(i_Params_Get_Session_By_Where_V2.SESSION_STARTING_DATE,i_Params_Get_Session_By_Where_V2.SESSION_ENDING_DATE,i_Params_Get_Session_By_Where_V2.DESCRIPTION,i_Params_Get_Session_By_Where_V2.OWNER_ID,i_Params_Get_Session_By_Where_V2.START_ROW,i_Params_Get_Session_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSession = new Session();
oTools.CopyPropValues(oDBEntry, oSession);
oSession.My_Package = new Package();
oTools.CopyPropValues(oDBEntry.My_Package, oSession.My_Package);
oSession.My_Client_fees = new Client_fees();
oTools.CopyPropValues(oDBEntry.My_Client_fees, oSession.My_Client_fees);
oList.Add(oSession);
}
}
i_Params_Get_Session_By_Where_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Session_By_Where_Adv_V2");}
return oList;
}
public List<Staff> Get_Staff_By_Criteria_Adv(Params_Get_Staff_By_Criteria i_Params_Get_Staff_By_Criteria)
{
List<Staff> oList = new List<Staff>();
long? tmp_TOTAL_COUNT = 0;
Staff oStaff = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_By_Criteria_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_By_Criteria_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Staff_By_Criteria.OWNER_ID == null) || (i_Params_Get_Staff_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Staff_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Staff_By_Criteria.START_ROW == null) { i_Params_Get_Staff_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Staff_By_Criteria.END_ROW == null) || (i_Params_Get_Staff_By_Criteria.END_ROW == 0)) { i_Params_Get_Staff_By_Criteria.END_ROW = 1000000; }
List<DALC.Staff> oList_DBEntries = _AppContext.Get_Staff_By_Criteria_Adv(i_Params_Get_Staff_By_Criteria.STAFF_NAME,i_Params_Get_Staff_By_Criteria.STAFF_PH_NB,i_Params_Get_Staff_By_Criteria.STAFF_MAIL,i_Params_Get_Staff_By_Criteria.OWNER_ID,i_Params_Get_Staff_By_Criteria.START_ROW,i_Params_Get_Staff_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStaff = new Staff();
oTools.CopyPropValues(oDBEntry, oStaff);
oStaff.My_Bloodtype = new Bloodtype();
oTools.CopyPropValues(oDBEntry.My_Bloodtype, oStaff.My_Bloodtype);
oList.Add(oStaff);
}
}
i_Params_Get_Staff_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_By_Criteria_Adv");}
return oList;
}
public List<Staff> Get_Staff_By_Where_Adv(Params_Get_Staff_By_Where i_Params_Get_Staff_By_Where)
{
List<Staff> oList = new List<Staff>();
long? tmp_TOTAL_COUNT = 0;
Staff oStaff = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_By_Where_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_By_Where_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_By_Where));}
#region Body Section.
if ((i_Params_Get_Staff_By_Where.OWNER_ID == null) || (i_Params_Get_Staff_By_Where.OWNER_ID == 0)) { i_Params_Get_Staff_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Staff_By_Where.START_ROW == null) { i_Params_Get_Staff_By_Where.START_ROW = 0; }
if ((i_Params_Get_Staff_By_Where.END_ROW == null) || (i_Params_Get_Staff_By_Where.END_ROW == 0)) { i_Params_Get_Staff_By_Where.END_ROW = 1000000; }
List<DALC.Staff> oList_DBEntries = _AppContext.Get_Staff_By_Where_Adv(i_Params_Get_Staff_By_Where.STAFF_NAME,i_Params_Get_Staff_By_Where.STAFF_PH_NB,i_Params_Get_Staff_By_Where.STAFF_MAIL,i_Params_Get_Staff_By_Where.OWNER_ID,i_Params_Get_Staff_By_Where.START_ROW,i_Params_Get_Staff_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStaff = new Staff();
oTools.CopyPropValues(oDBEntry, oStaff);
oStaff.My_Bloodtype = new Bloodtype();
oTools.CopyPropValues(oDBEntry.My_Bloodtype, oStaff.My_Bloodtype);
oList.Add(oStaff);
}
}
i_Params_Get_Staff_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_By_Where_Adv");}
return oList;
}
public List<Staff> Get_Staff_By_Criteria_Adv_V2(Params_Get_Staff_By_Criteria_V2 i_Params_Get_Staff_By_Criteria_V2)
{
List<Staff> oList = new List<Staff>();
long? tmp_TOTAL_COUNT = 0;
Staff oStaff = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_By_Criteria_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_By_Criteria_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_By_Criteria_V2));}
#region Body Section.
if ((i_Params_Get_Staff_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_Staff_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_Staff_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Staff_By_Criteria_V2.START_ROW == null) { i_Params_Get_Staff_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_Staff_By_Criteria_V2.END_ROW == null) || (i_Params_Get_Staff_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_Staff_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.Staff> oList_DBEntries = _AppContext.Get_Staff_By_Criteria_Adv_V2(i_Params_Get_Staff_By_Criteria_V2.STAFF_NAME,i_Params_Get_Staff_By_Criteria_V2.STAFF_PH_NB,i_Params_Get_Staff_By_Criteria_V2.STAFF_MAIL,i_Params_Get_Staff_By_Criteria_V2.STAFF_DOB,i_Params_Get_Staff_By_Criteria_V2.OWNER_ID,i_Params_Get_Staff_By_Criteria_V2.START_ROW,i_Params_Get_Staff_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStaff = new Staff();
oTools.CopyPropValues(oDBEntry, oStaff);
oStaff.My_Bloodtype = new Bloodtype();
oTools.CopyPropValues(oDBEntry.My_Bloodtype, oStaff.My_Bloodtype);
oList.Add(oStaff);
}
}
i_Params_Get_Staff_By_Criteria_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_By_Criteria_Adv_V2");}
return oList;
}
public List<Staff> Get_Staff_By_Where_Adv_V2(Params_Get_Staff_By_Where_V2 i_Params_Get_Staff_By_Where_V2)
{
List<Staff> oList = new List<Staff>();
long? tmp_TOTAL_COUNT = 0;
Staff oStaff = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_By_Where_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_By_Where_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_By_Where_V2));}
#region Body Section.
if ((i_Params_Get_Staff_By_Where_V2.OWNER_ID == null) || (i_Params_Get_Staff_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_Staff_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Staff_By_Where_V2.START_ROW == null) { i_Params_Get_Staff_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_Staff_By_Where_V2.END_ROW == null) || (i_Params_Get_Staff_By_Where_V2.END_ROW == 0)) { i_Params_Get_Staff_By_Where_V2.END_ROW = 1000000; }
List<DALC.Staff> oList_DBEntries = _AppContext.Get_Staff_By_Where_Adv_V2(i_Params_Get_Staff_By_Where_V2.STAFF_NAME,i_Params_Get_Staff_By_Where_V2.STAFF_PH_NB,i_Params_Get_Staff_By_Where_V2.STAFF_MAIL,i_Params_Get_Staff_By_Where_V2.STAFF_DOB,i_Params_Get_Staff_By_Where_V2.OWNER_ID,i_Params_Get_Staff_By_Where_V2.START_ROW,i_Params_Get_Staff_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStaff = new Staff();
oTools.CopyPropValues(oDBEntry, oStaff);
oStaff.My_Bloodtype = new Bloodtype();
oTools.CopyPropValues(oDBEntry.My_Bloodtype, oStaff.My_Bloodtype);
oList.Add(oStaff);
}
}
i_Params_Get_Staff_By_Where_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_By_Where_Adv_V2");}
return oList;
}
public List<Staff_fees> Get_Staff_fees_By_Criteria_Adv(Params_Get_Staff_fees_By_Criteria i_Params_Get_Staff_fees_By_Criteria)
{
List<Staff_fees> oList = new List<Staff_fees>();
long? tmp_TOTAL_COUNT = 0;
Staff_fees oStaff_fees = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_fees_By_Criteria_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_fees_By_Criteria_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_fees_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Staff_fees_By_Criteria.OWNER_ID == null) || (i_Params_Get_Staff_fees_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Staff_fees_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Staff_fees_By_Criteria.START_ROW == null) { i_Params_Get_Staff_fees_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Staff_fees_By_Criteria.END_ROW == null) || (i_Params_Get_Staff_fees_By_Criteria.END_ROW == 0)) { i_Params_Get_Staff_fees_By_Criteria.END_ROW = 1000000; }
List<DALC.Staff_fees> oList_DBEntries = _AppContext.Get_Staff_fees_By_Criteria_Adv(i_Params_Get_Staff_fees_By_Criteria.STAFF_FEES_DESCRIPTION,i_Params_Get_Staff_fees_By_Criteria.OWNER_ID,i_Params_Get_Staff_fees_By_Criteria.START_ROW,i_Params_Get_Staff_fees_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStaff_fees = new Staff_fees();
oTools.CopyPropValues(oDBEntry, oStaff_fees);
oStaff_fees.My_Staff = new Staff();
oTools.CopyPropValues(oDBEntry.My_Staff, oStaff_fees.My_Staff);
oStaff_fees.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oStaff_fees.My_Currency);
oList.Add(oStaff_fees);
}
}
i_Params_Get_Staff_fees_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_fees_By_Criteria_Adv");}
return oList;
}
public List<Staff_fees> Get_Staff_fees_By_Where_Adv(Params_Get_Staff_fees_By_Where i_Params_Get_Staff_fees_By_Where)
{
List<Staff_fees> oList = new List<Staff_fees>();
long? tmp_TOTAL_COUNT = 0;
Staff_fees oStaff_fees = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_fees_By_Where_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_fees_By_Where_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_fees_By_Where));}
#region Body Section.
if ((i_Params_Get_Staff_fees_By_Where.OWNER_ID == null) || (i_Params_Get_Staff_fees_By_Where.OWNER_ID == 0)) { i_Params_Get_Staff_fees_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Staff_fees_By_Where.START_ROW == null) { i_Params_Get_Staff_fees_By_Where.START_ROW = 0; }
if ((i_Params_Get_Staff_fees_By_Where.END_ROW == null) || (i_Params_Get_Staff_fees_By_Where.END_ROW == 0)) { i_Params_Get_Staff_fees_By_Where.END_ROW = 1000000; }
List<DALC.Staff_fees> oList_DBEntries = _AppContext.Get_Staff_fees_By_Where_Adv(i_Params_Get_Staff_fees_By_Where.STAFF_FEES_DESCRIPTION,i_Params_Get_Staff_fees_By_Where.OWNER_ID,i_Params_Get_Staff_fees_By_Where.START_ROW,i_Params_Get_Staff_fees_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStaff_fees = new Staff_fees();
oTools.CopyPropValues(oDBEntry, oStaff_fees);
oStaff_fees.My_Staff = new Staff();
oTools.CopyPropValues(oDBEntry.My_Staff, oStaff_fees.My_Staff);
oStaff_fees.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oStaff_fees.My_Currency);
oList.Add(oStaff_fees);
}
}
i_Params_Get_Staff_fees_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_fees_By_Where_Adv");}
return oList;
}
public List<Supplier> Get_Supplier_By_Criteria_Adv(Params_Get_Supplier_By_Criteria i_Params_Get_Supplier_By_Criteria)
{
List<Supplier> oList = new List<Supplier>();
long? tmp_TOTAL_COUNT = 0;
Supplier oSupplier = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_By_Criteria_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_By_Criteria_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Supplier_By_Criteria.OWNER_ID == null) || (i_Params_Get_Supplier_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Supplier_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Supplier_By_Criteria.START_ROW == null) { i_Params_Get_Supplier_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Supplier_By_Criteria.END_ROW == null) || (i_Params_Get_Supplier_By_Criteria.END_ROW == 0)) { i_Params_Get_Supplier_By_Criteria.END_ROW = 1000000; }
List<DALC.Supplier> oList_DBEntries = _AppContext.Get_Supplier_By_Criteria_Adv(i_Params_Get_Supplier_By_Criteria.SUPPLIER_NAME,i_Params_Get_Supplier_By_Criteria.SUPPLIER_PH_NB,i_Params_Get_Supplier_By_Criteria.SUPPLIER_MAIL,i_Params_Get_Supplier_By_Criteria.OWNER_ID,i_Params_Get_Supplier_By_Criteria.START_ROW,i_Params_Get_Supplier_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier = new Supplier();
oTools.CopyPropValues(oDBEntry, oSupplier);
oSupplier.My_Bloodtype = new Bloodtype();
oTools.CopyPropValues(oDBEntry.My_Bloodtype, oSupplier.My_Bloodtype);
oList.Add(oSupplier);
}
}
i_Params_Get_Supplier_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_By_Criteria_Adv");}
return oList;
}
public List<Supplier> Get_Supplier_By_Where_Adv(Params_Get_Supplier_By_Where i_Params_Get_Supplier_By_Where)
{
List<Supplier> oList = new List<Supplier>();
long? tmp_TOTAL_COUNT = 0;
Supplier oSupplier = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_By_Where_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_By_Where_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_By_Where));}
#region Body Section.
if ((i_Params_Get_Supplier_By_Where.OWNER_ID == null) || (i_Params_Get_Supplier_By_Where.OWNER_ID == 0)) { i_Params_Get_Supplier_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Supplier_By_Where.START_ROW == null) { i_Params_Get_Supplier_By_Where.START_ROW = 0; }
if ((i_Params_Get_Supplier_By_Where.END_ROW == null) || (i_Params_Get_Supplier_By_Where.END_ROW == 0)) { i_Params_Get_Supplier_By_Where.END_ROW = 1000000; }
List<DALC.Supplier> oList_DBEntries = _AppContext.Get_Supplier_By_Where_Adv(i_Params_Get_Supplier_By_Where.SUPPLIER_NAME,i_Params_Get_Supplier_By_Where.SUPPLIER_PH_NB,i_Params_Get_Supplier_By_Where.SUPPLIER_MAIL,i_Params_Get_Supplier_By_Where.OWNER_ID,i_Params_Get_Supplier_By_Where.START_ROW,i_Params_Get_Supplier_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier = new Supplier();
oTools.CopyPropValues(oDBEntry, oSupplier);
oSupplier.My_Bloodtype = new Bloodtype();
oTools.CopyPropValues(oDBEntry.My_Bloodtype, oSupplier.My_Bloodtype);
oList.Add(oSupplier);
}
}
i_Params_Get_Supplier_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_By_Where_Adv");}
return oList;
}
public List<Supplier> Get_Supplier_By_Criteria_Adv_V2(Params_Get_Supplier_By_Criteria_V2 i_Params_Get_Supplier_By_Criteria_V2)
{
List<Supplier> oList = new List<Supplier>();
long? tmp_TOTAL_COUNT = 0;
Supplier oSupplier = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_By_Criteria_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_By_Criteria_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_By_Criteria_V2));}
#region Body Section.
if ((i_Params_Get_Supplier_By_Criteria_V2.OWNER_ID == null) || (i_Params_Get_Supplier_By_Criteria_V2.OWNER_ID == 0)) { i_Params_Get_Supplier_By_Criteria_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Supplier_By_Criteria_V2.START_ROW == null) { i_Params_Get_Supplier_By_Criteria_V2.START_ROW = 0; }
if ((i_Params_Get_Supplier_By_Criteria_V2.END_ROW == null) || (i_Params_Get_Supplier_By_Criteria_V2.END_ROW == 0)) { i_Params_Get_Supplier_By_Criteria_V2.END_ROW = 1000000; }
List<DALC.Supplier> oList_DBEntries = _AppContext.Get_Supplier_By_Criteria_Adv_V2(i_Params_Get_Supplier_By_Criteria_V2.SUPPLIER_NAME,i_Params_Get_Supplier_By_Criteria_V2.SUPPLIER_PH_NB,i_Params_Get_Supplier_By_Criteria_V2.SUPPLIER_MAIL,i_Params_Get_Supplier_By_Criteria_V2.SUPPLIER_DOB,i_Params_Get_Supplier_By_Criteria_V2.OWNER_ID,i_Params_Get_Supplier_By_Criteria_V2.START_ROW,i_Params_Get_Supplier_By_Criteria_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier = new Supplier();
oTools.CopyPropValues(oDBEntry, oSupplier);
oSupplier.My_Bloodtype = new Bloodtype();
oTools.CopyPropValues(oDBEntry.My_Bloodtype, oSupplier.My_Bloodtype);
oList.Add(oSupplier);
}
}
i_Params_Get_Supplier_By_Criteria_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_By_Criteria_Adv_V2");}
return oList;
}
public List<Supplier> Get_Supplier_By_Where_Adv_V2(Params_Get_Supplier_By_Where_V2 i_Params_Get_Supplier_By_Where_V2)
{
List<Supplier> oList = new List<Supplier>();
long? tmp_TOTAL_COUNT = 0;
Supplier oSupplier = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_By_Where_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_By_Where_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_By_Where_V2));}
#region Body Section.
if ((i_Params_Get_Supplier_By_Where_V2.OWNER_ID == null) || (i_Params_Get_Supplier_By_Where_V2.OWNER_ID == 0)) { i_Params_Get_Supplier_By_Where_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Supplier_By_Where_V2.START_ROW == null) { i_Params_Get_Supplier_By_Where_V2.START_ROW = 0; }
if ((i_Params_Get_Supplier_By_Where_V2.END_ROW == null) || (i_Params_Get_Supplier_By_Where_V2.END_ROW == 0)) { i_Params_Get_Supplier_By_Where_V2.END_ROW = 1000000; }
List<DALC.Supplier> oList_DBEntries = _AppContext.Get_Supplier_By_Where_Adv_V2(i_Params_Get_Supplier_By_Where_V2.SUPPLIER_NAME,i_Params_Get_Supplier_By_Where_V2.SUPPLIER_PH_NB,i_Params_Get_Supplier_By_Where_V2.SUPPLIER_MAIL,i_Params_Get_Supplier_By_Where_V2.SUPPLIER_DOB,i_Params_Get_Supplier_By_Where_V2.OWNER_ID,i_Params_Get_Supplier_By_Where_V2.START_ROW,i_Params_Get_Supplier_By_Where_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier = new Supplier();
oTools.CopyPropValues(oDBEntry, oSupplier);
oSupplier.My_Bloodtype = new Bloodtype();
oTools.CopyPropValues(oDBEntry.My_Bloodtype, oSupplier.My_Bloodtype);
oList.Add(oSupplier);
}
}
i_Params_Get_Supplier_By_Where_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_By_Where_Adv_V2");}
return oList;
}
public List<Supplier_fees> Get_Supplier_fees_By_Criteria_Adv(Params_Get_Supplier_fees_By_Criteria i_Params_Get_Supplier_fees_By_Criteria)
{
List<Supplier_fees> oList = new List<Supplier_fees>();
long? tmp_TOTAL_COUNT = 0;
Supplier_fees oSupplier_fees = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_fees_By_Criteria_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_fees_By_Criteria_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_fees_By_Criteria));}
#region Body Section.
if ((i_Params_Get_Supplier_fees_By_Criteria.OWNER_ID == null) || (i_Params_Get_Supplier_fees_By_Criteria.OWNER_ID == 0)) { i_Params_Get_Supplier_fees_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Supplier_fees_By_Criteria.START_ROW == null) { i_Params_Get_Supplier_fees_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_Supplier_fees_By_Criteria.END_ROW == null) || (i_Params_Get_Supplier_fees_By_Criteria.END_ROW == 0)) { i_Params_Get_Supplier_fees_By_Criteria.END_ROW = 1000000; }
List<DALC.Supplier_fees> oList_DBEntries = _AppContext.Get_Supplier_fees_By_Criteria_Adv(i_Params_Get_Supplier_fees_By_Criteria.SUPPLIER_FEES_DESCRIPTION,i_Params_Get_Supplier_fees_By_Criteria.OWNER_ID,i_Params_Get_Supplier_fees_By_Criteria.START_ROW,i_Params_Get_Supplier_fees_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier_fees = new Supplier_fees();
oTools.CopyPropValues(oDBEntry, oSupplier_fees);
oSupplier_fees.My_Supplier = new Supplier();
oTools.CopyPropValues(oDBEntry.My_Supplier, oSupplier_fees.My_Supplier);
oSupplier_fees.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oSupplier_fees.My_Currency);
oList.Add(oSupplier_fees);
}
}
i_Params_Get_Supplier_fees_By_Criteria.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_fees_By_Criteria_Adv");}
return oList;
}
public List<Supplier_fees> Get_Supplier_fees_By_Where_Adv(Params_Get_Supplier_fees_By_Where i_Params_Get_Supplier_fees_By_Where)
{
List<Supplier_fees> oList = new List<Supplier_fees>();
long? tmp_TOTAL_COUNT = 0;
Supplier_fees oSupplier_fees = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_fees_By_Where_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_fees_By_Where_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_fees_By_Where));}
#region Body Section.
if ((i_Params_Get_Supplier_fees_By_Where.OWNER_ID == null) || (i_Params_Get_Supplier_fees_By_Where.OWNER_ID == 0)) { i_Params_Get_Supplier_fees_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Supplier_fees_By_Where.START_ROW == null) { i_Params_Get_Supplier_fees_By_Where.START_ROW = 0; }
if ((i_Params_Get_Supplier_fees_By_Where.END_ROW == null) || (i_Params_Get_Supplier_fees_By_Where.END_ROW == 0)) { i_Params_Get_Supplier_fees_By_Where.END_ROW = 1000000; }
List<DALC.Supplier_fees> oList_DBEntries = _AppContext.Get_Supplier_fees_By_Where_Adv(i_Params_Get_Supplier_fees_By_Where.SUPPLIER_FEES_DESCRIPTION,i_Params_Get_Supplier_fees_By_Where.OWNER_ID,i_Params_Get_Supplier_fees_By_Where.START_ROW,i_Params_Get_Supplier_fees_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier_fees = new Supplier_fees();
oTools.CopyPropValues(oDBEntry, oSupplier_fees);
oSupplier_fees.My_Supplier = new Supplier();
oTools.CopyPropValues(oDBEntry.My_Supplier, oSupplier_fees.My_Supplier);
oSupplier_fees.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oSupplier_fees.My_Currency);
oList.Add(oSupplier_fees);
}
}
i_Params_Get_Supplier_fees_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_fees_By_Where_Adv");}
return oList;
}
public List<User> Get_User_By_Criteria_Adv(Params_Get_User_By_Criteria i_Params_Get_User_By_Criteria)
{
List<User> oList = new List<User>();
long? tmp_TOTAL_COUNT = 0;
User oUser = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_Criteria_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_User_By_Criteria_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_User_By_Criteria));}
#region Body Section.
if ((i_Params_Get_User_By_Criteria.OWNER_ID == null) || (i_Params_Get_User_By_Criteria.OWNER_ID == 0)) { i_Params_Get_User_By_Criteria.OWNER_ID = this.OwnerID; }
if (i_Params_Get_User_By_Criteria.START_ROW == null) { i_Params_Get_User_By_Criteria.START_ROW = 0; }
if ((i_Params_Get_User_By_Criteria.END_ROW == null) || (i_Params_Get_User_By_Criteria.END_ROW == 0)) { i_Params_Get_User_By_Criteria.END_ROW = 1000000; }
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_Criteria_Adv(i_Params_Get_User_By_Criteria.USERNAME,i_Params_Get_User_By_Criteria.PASSWORD,i_Params_Get_User_By_Criteria.USER_TYPE_CODE,i_Params_Get_User_By_Criteria.USER_EMAIL,i_Params_Get_User_By_Criteria.OWNER_ID,i_Params_Get_User_By_Criteria.START_ROW,i_Params_Get_User_By_Criteria.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_Criteria_Adv");}
return oList;
}
public List<User> Get_User_By_Where_Adv(Params_Get_User_By_Where i_Params_Get_User_By_Where)
{
List<User> oList = new List<User>();
long? tmp_TOTAL_COUNT = 0;
User oUser = null;
if (OnPreEvent_General != null){OnPreEvent_General("Get_User_By_Where_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_User_By_Where_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_User_By_Where));}
#region Body Section.
if ((i_Params_Get_User_By_Where.OWNER_ID == null) || (i_Params_Get_User_By_Where.OWNER_ID == 0)) { i_Params_Get_User_By_Where.OWNER_ID = this.OwnerID; }
if (i_Params_Get_User_By_Where.START_ROW == null) { i_Params_Get_User_By_Where.START_ROW = 0; }
if ((i_Params_Get_User_By_Where.END_ROW == null) || (i_Params_Get_User_By_Where.END_ROW == 0)) { i_Params_Get_User_By_Where.END_ROW = 1000000; }
List<DALC.User> oList_DBEntries = _AppContext.Get_User_By_Where_Adv(i_Params_Get_User_By_Where.USERNAME,i_Params_Get_User_By_Where.PASSWORD,i_Params_Get_User_By_Where.USER_TYPE_CODE,i_Params_Get_User_By_Where.USER_EMAIL,i_Params_Get_User_By_Where.OWNER_ID,i_Params_Get_User_By_Where.START_ROW,i_Params_Get_User_By_Where.END_ROW,ref tmp_TOTAL_COUNT);
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
if (OnPostEvent_General != null){OnPostEvent_General("Get_User_By_Where_Adv");}
return oList;
}
public List<Address> Get_Address_By_Criteria_InList_Adv(Params_Get_Address_By_Criteria_InList i_Params_Get_Address_By_Criteria_InList)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Address_By_Criteria_InList_SP oParams_Get_Address_By_Criteria_InList_SP = new Params_Get_Address_By_Criteria_InList_SP();
Params_Get_Person_By_PERSON_ID oParams_Get_Person_By_PERSON_ID = new Params_Get_Person_By_PERSON_ID();
Params_Get_Loc_l1_By_LOC_L1_ID oParams_Get_Loc_l1_By_LOC_L1_ID = new Params_Get_Loc_l1_By_LOC_L1_ID();
Params_Get_Loc_l2_By_LOC_L2_ID oParams_Get_Loc_l2_By_LOC_L2_ID = new Params_Get_Loc_l2_By_LOC_L2_ID();
Params_Get_Loc_l3_By_LOC_L3_ID oParams_Get_Loc_l3_By_LOC_L3_ID = new Params_Get_Loc_l3_By_LOC_L3_ID();
Params_Get_Loc_l4_By_LOC_L4_ID oParams_Get_Loc_l4_By_LOC_L4_ID = new Params_Get_Loc_l4_By_LOC_L4_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Criteria_InList_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_Criteria_InList_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_Criteria_InList));}
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
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Criteria_InList_Adv(i_Params_Get_Address_By_Criteria_InList.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Criteria_InList.STREET,i_Params_Get_Address_By_Criteria_InList.BUILDING,i_Params_Get_Address_By_Criteria_InList.FLOOR,i_Params_Get_Address_By_Criteria_InList.POBOX,i_Params_Get_Address_By_Criteria_InList.PERSON_ID_LIST,i_Params_Get_Address_By_Criteria_InList.LOC_L1_ID_LIST,i_Params_Get_Address_By_Criteria_InList.LOC_L2_ID_LIST,i_Params_Get_Address_By_Criteria_InList.LOC_L3_ID_LIST,i_Params_Get_Address_By_Criteria_InList.LOC_L4_ID_LIST,i_Params_Get_Address_By_Criteria_InList.OWNER_ID,i_Params_Get_Address_By_Criteria_InList.START_ROW,i_Params_Get_Address_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Address_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Address_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Criteria_InList_Adv");}
return oList;
}
public List<Address> Get_Address_By_Where_InList_Adv(Params_Get_Address_By_Where_InList i_Params_Get_Address_By_Where_InList)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Address_By_Where_InList_SP oParams_Get_Address_By_Where_InList_SP = new Params_Get_Address_By_Where_InList_SP();
Params_Get_Person_By_PERSON_ID oParams_Get_Person_By_PERSON_ID = new Params_Get_Person_By_PERSON_ID();
Params_Get_Loc_l1_By_LOC_L1_ID oParams_Get_Loc_l1_By_LOC_L1_ID = new Params_Get_Loc_l1_By_LOC_L1_ID();
Params_Get_Loc_l2_By_LOC_L2_ID oParams_Get_Loc_l2_By_LOC_L2_ID = new Params_Get_Loc_l2_By_LOC_L2_ID();
Params_Get_Loc_l3_By_LOC_L3_ID oParams_Get_Loc_l3_By_LOC_L3_ID = new Params_Get_Loc_l3_By_LOC_L3_ID();
Params_Get_Loc_l4_By_LOC_L4_ID oParams_Get_Loc_l4_By_LOC_L4_ID = new Params_Get_Loc_l4_By_LOC_L4_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Where_InList_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_Where_InList_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_Where_InList));}
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
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Where_InList_Adv(i_Params_Get_Address_By_Where_InList.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Where_InList.STREET,i_Params_Get_Address_By_Where_InList.BUILDING,i_Params_Get_Address_By_Where_InList.FLOOR,i_Params_Get_Address_By_Where_InList.POBOX,i_Params_Get_Address_By_Where_InList.PERSON_ID_LIST,i_Params_Get_Address_By_Where_InList.LOC_L1_ID_LIST,i_Params_Get_Address_By_Where_InList.LOC_L2_ID_LIST,i_Params_Get_Address_By_Where_InList.LOC_L3_ID_LIST,i_Params_Get_Address_By_Where_InList.LOC_L4_ID_LIST,i_Params_Get_Address_By_Where_InList.OWNER_ID,i_Params_Get_Address_By_Where_InList.START_ROW,i_Params_Get_Address_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Where_InList.TOTAL_COUNT = oParams_Get_Address_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Address_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Where_InList_Adv");}
return oList;
}
public List<Address> Get_Address_By_Criteria_InList_Adv_V2(Params_Get_Address_By_Criteria_InList_V2 i_Params_Get_Address_By_Criteria_InList_V2)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Address_By_Criteria_InList_SP_V2 oParams_Get_Address_By_Criteria_InList_SP_V2 = new Params_Get_Address_By_Criteria_InList_SP_V2();
Params_Get_Person_By_PERSON_ID oParams_Get_Person_By_PERSON_ID = new Params_Get_Person_By_PERSON_ID();
Params_Get_Loc_l1_By_LOC_L1_ID oParams_Get_Loc_l1_By_LOC_L1_ID = new Params_Get_Loc_l1_By_LOC_L1_ID();
Params_Get_Loc_l2_By_LOC_L2_ID oParams_Get_Loc_l2_By_LOC_L2_ID = new Params_Get_Loc_l2_By_LOC_L2_ID();
Params_Get_Loc_l3_By_LOC_L3_ID oParams_Get_Loc_l3_By_LOC_L3_ID = new Params_Get_Loc_l3_By_LOC_L3_ID();
Params_Get_Loc_l4_By_LOC_L4_ID oParams_Get_Loc_l4_By_LOC_L4_ID = new Params_Get_Loc_l4_By_LOC_L4_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Criteria_InList_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_Criteria_InList_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_Criteria_InList_V2));}
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
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Criteria_InList_Adv_V2(i_Params_Get_Address_By_Criteria_InList_V2.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Criteria_InList_V2.STREET,i_Params_Get_Address_By_Criteria_InList_V2.BUILDING,i_Params_Get_Address_By_Criteria_InList_V2.FLOOR,i_Params_Get_Address_By_Criteria_InList_V2.POBOX,i_Params_Get_Address_By_Criteria_InList_V2.VALID_DATE_START,i_Params_Get_Address_By_Criteria_InList_V2.VALID_DATE_END,i_Params_Get_Address_By_Criteria_InList_V2.PERSON_ID_LIST,i_Params_Get_Address_By_Criteria_InList_V2.LOC_L1_ID_LIST,i_Params_Get_Address_By_Criteria_InList_V2.LOC_L2_ID_LIST,i_Params_Get_Address_By_Criteria_InList_V2.LOC_L3_ID_LIST,i_Params_Get_Address_By_Criteria_InList_V2.LOC_L4_ID_LIST,i_Params_Get_Address_By_Criteria_InList_V2.OWNER_ID,i_Params_Get_Address_By_Criteria_InList_V2.START_ROW,i_Params_Get_Address_By_Criteria_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Criteria_InList_V2.TOTAL_COUNT = oParams_Get_Address_By_Criteria_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Address_By_Criteria_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Criteria_InList_Adv_V2");}
return oList;
}
public List<Address> Get_Address_By_Where_InList_Adv_V2(Params_Get_Address_By_Where_InList_V2 i_Params_Get_Address_By_Where_InList_V2)
{
List<Address> oList = new List<Address>();
Address oAddress = new Address();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Address_By_Where_InList_SP_V2 oParams_Get_Address_By_Where_InList_SP_V2 = new Params_Get_Address_By_Where_InList_SP_V2();
Params_Get_Person_By_PERSON_ID oParams_Get_Person_By_PERSON_ID = new Params_Get_Person_By_PERSON_ID();
Params_Get_Loc_l1_By_LOC_L1_ID oParams_Get_Loc_l1_By_LOC_L1_ID = new Params_Get_Loc_l1_By_LOC_L1_ID();
Params_Get_Loc_l2_By_LOC_L2_ID oParams_Get_Loc_l2_By_LOC_L2_ID = new Params_Get_Loc_l2_By_LOC_L2_ID();
Params_Get_Loc_l3_By_LOC_L3_ID oParams_Get_Loc_l3_By_LOC_L3_ID = new Params_Get_Loc_l3_By_LOC_L3_ID();
Params_Get_Loc_l4_By_LOC_L4_ID oParams_Get_Loc_l4_By_LOC_L4_ID = new Params_Get_Loc_l4_By_LOC_L4_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Address_By_Where_InList_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Address_By_Where_InList_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Address_By_Where_InList_V2));}
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
List<DALC.Address> oList_DBEntries = _AppContext.Get_Address_By_Where_InList_Adv_V2(i_Params_Get_Address_By_Where_InList_V2.ADDRESS_TYPE_CODE,i_Params_Get_Address_By_Where_InList_V2.STREET,i_Params_Get_Address_By_Where_InList_V2.BUILDING,i_Params_Get_Address_By_Where_InList_V2.FLOOR,i_Params_Get_Address_By_Where_InList_V2.POBOX,i_Params_Get_Address_By_Where_InList_V2.VALID_DATE_START,i_Params_Get_Address_By_Where_InList_V2.VALID_DATE_END,i_Params_Get_Address_By_Where_InList_V2.PERSON_ID_LIST,i_Params_Get_Address_By_Where_InList_V2.LOC_L1_ID_LIST,i_Params_Get_Address_By_Where_InList_V2.LOC_L2_ID_LIST,i_Params_Get_Address_By_Where_InList_V2.LOC_L3_ID_LIST,i_Params_Get_Address_By_Where_InList_V2.LOC_L4_ID_LIST,i_Params_Get_Address_By_Where_InList_V2.OWNER_ID,i_Params_Get_Address_By_Where_InList_V2.START_ROW,i_Params_Get_Address_By_Where_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oAddress = new Address();
oTools.CopyPropValues(oDBEntry, oAddress);
oAddress.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oAddress.My_Person);
oAddress.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oAddress.My_Loc_l1);
oAddress.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oAddress.My_Loc_l2);
oAddress.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oAddress.My_Loc_l3);
oAddress.My_Loc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry.My_Loc_l4, oAddress.My_Loc_l4);
oList.Add(oAddress);
}
}
i_Params_Get_Address_By_Where_InList_V2.TOTAL_COUNT = oParams_Get_Address_By_Where_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Address_By_Where_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Address_By_Where_InList_Adv_V2");}
return oList;
}
public List<Client> Get_Client_By_Criteria_InList_Adv(Params_Get_Client_By_Criteria_InList i_Params_Get_Client_By_Criteria_InList)
{
List<Client> oList = new List<Client>();
Client oClient = new Client();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Client_By_Criteria_InList_SP oParams_Get_Client_By_Criteria_InList_SP = new Params_Get_Client_By_Criteria_InList_SP();
Params_Get_Bloodtype_By_BLOODTYPE_ID oParams_Get_Bloodtype_By_BLOODTYPE_ID = new Params_Get_Bloodtype_By_BLOODTYPE_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_By_Criteria_InList_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Client_By_Criteria_InList_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Client_By_Criteria_InList));}
#region Body Section.
if ((i_Params_Get_Client_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Client_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Client_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Client_By_Criteria_InList.START_ROW == null) { i_Params_Get_Client_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Client_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Client_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Client_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Client_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Client_By_Criteria_InList.OWNER_ID;
oParams_Get_Client_By_Criteria_InList_SP.CLIENT_NAME = i_Params_Get_Client_By_Criteria_InList.CLIENT_NAME;
oParams_Get_Client_By_Criteria_InList_SP.CLIENT_PH_NB = i_Params_Get_Client_By_Criteria_InList.CLIENT_PH_NB;
oParams_Get_Client_By_Criteria_InList_SP.CLIENT_MAIL = i_Params_Get_Client_By_Criteria_InList.CLIENT_MAIL;
if ( i_Params_Get_Client_By_Criteria_InList.BLOODTYPE_ID_LIST == null)
{
i_Params_Get_Client_By_Criteria_InList.BLOODTYPE_ID_LIST = new List<Int32?>();
}
oParams_Get_Client_By_Criteria_InList_SP.BLOODTYPE_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Client_By_Criteria_InList.BLOODTYPE_ID_LIST);
oParams_Get_Client_By_Criteria_InList_SP.START_ROW = i_Params_Get_Client_By_Criteria_InList.START_ROW;
oParams_Get_Client_By_Criteria_InList_SP.END_ROW = i_Params_Get_Client_By_Criteria_InList.END_ROW;
oParams_Get_Client_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Client_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Client> oList_DBEntries = _AppContext.Get_Client_By_Criteria_InList_Adv(i_Params_Get_Client_By_Criteria_InList.CLIENT_NAME,i_Params_Get_Client_By_Criteria_InList.CLIENT_PH_NB,i_Params_Get_Client_By_Criteria_InList.CLIENT_MAIL,i_Params_Get_Client_By_Criteria_InList.BLOODTYPE_ID_LIST,i_Params_Get_Client_By_Criteria_InList.OWNER_ID,i_Params_Get_Client_By_Criteria_InList.START_ROW,i_Params_Get_Client_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oClient = new Client();
oTools.CopyPropValues(oDBEntry, oClient);
oClient.My_Bloodtype = new Bloodtype();
oTools.CopyPropValues(oDBEntry.My_Bloodtype, oClient.My_Bloodtype);
oList.Add(oClient);
}
}
i_Params_Get_Client_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Client_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Client_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_By_Criteria_InList_Adv");}
return oList;
}
public List<Client> Get_Client_By_Where_InList_Adv(Params_Get_Client_By_Where_InList i_Params_Get_Client_By_Where_InList)
{
List<Client> oList = new List<Client>();
Client oClient = new Client();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Client_By_Where_InList_SP oParams_Get_Client_By_Where_InList_SP = new Params_Get_Client_By_Where_InList_SP();
Params_Get_Bloodtype_By_BLOODTYPE_ID oParams_Get_Bloodtype_By_BLOODTYPE_ID = new Params_Get_Bloodtype_By_BLOODTYPE_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_By_Where_InList_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Client_By_Where_InList_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Client_By_Where_InList));}
#region Body Section.
if ((i_Params_Get_Client_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Client_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Client_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Client_By_Where_InList.START_ROW == null) { i_Params_Get_Client_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Client_By_Where_InList.END_ROW == null) || (i_Params_Get_Client_By_Where_InList.END_ROW == 0)) { i_Params_Get_Client_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Client_By_Where_InList_SP.OWNER_ID = i_Params_Get_Client_By_Where_InList.OWNER_ID;
oParams_Get_Client_By_Where_InList_SP.CLIENT_NAME = i_Params_Get_Client_By_Where_InList.CLIENT_NAME;
oParams_Get_Client_By_Where_InList_SP.CLIENT_PH_NB = i_Params_Get_Client_By_Where_InList.CLIENT_PH_NB;
oParams_Get_Client_By_Where_InList_SP.CLIENT_MAIL = i_Params_Get_Client_By_Where_InList.CLIENT_MAIL;
if ( i_Params_Get_Client_By_Where_InList.BLOODTYPE_ID_LIST == null)
{
i_Params_Get_Client_By_Where_InList.BLOODTYPE_ID_LIST = new List<Int32?>();
}
oParams_Get_Client_By_Where_InList_SP.BLOODTYPE_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Client_By_Where_InList.BLOODTYPE_ID_LIST);
oParams_Get_Client_By_Where_InList_SP.START_ROW = i_Params_Get_Client_By_Where_InList.START_ROW;
oParams_Get_Client_By_Where_InList_SP.END_ROW = i_Params_Get_Client_By_Where_InList.END_ROW;
oParams_Get_Client_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Client_By_Where_InList.TOTAL_COUNT;
List<DALC.Client> oList_DBEntries = _AppContext.Get_Client_By_Where_InList_Adv(i_Params_Get_Client_By_Where_InList.CLIENT_NAME,i_Params_Get_Client_By_Where_InList.CLIENT_PH_NB,i_Params_Get_Client_By_Where_InList.CLIENT_MAIL,i_Params_Get_Client_By_Where_InList.BLOODTYPE_ID_LIST,i_Params_Get_Client_By_Where_InList.OWNER_ID,i_Params_Get_Client_By_Where_InList.START_ROW,i_Params_Get_Client_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oClient = new Client();
oTools.CopyPropValues(oDBEntry, oClient);
oClient.My_Bloodtype = new Bloodtype();
oTools.CopyPropValues(oDBEntry.My_Bloodtype, oClient.My_Bloodtype);
oList.Add(oClient);
}
}
i_Params_Get_Client_By_Where_InList.TOTAL_COUNT = oParams_Get_Client_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Client_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_By_Where_InList_Adv");}
return oList;
}
public List<Client> Get_Client_By_Criteria_InList_Adv_V2(Params_Get_Client_By_Criteria_InList_V2 i_Params_Get_Client_By_Criteria_InList_V2)
{
List<Client> oList = new List<Client>();
Client oClient = new Client();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Client_By_Criteria_InList_SP_V2 oParams_Get_Client_By_Criteria_InList_SP_V2 = new Params_Get_Client_By_Criteria_InList_SP_V2();
Params_Get_Bloodtype_By_BLOODTYPE_ID oParams_Get_Bloodtype_By_BLOODTYPE_ID = new Params_Get_Bloodtype_By_BLOODTYPE_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_By_Criteria_InList_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Client_By_Criteria_InList_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Client_By_Criteria_InList_V2));}
#region Body Section.
if ((i_Params_Get_Client_By_Criteria_InList_V2.OWNER_ID == null) || (i_Params_Get_Client_By_Criteria_InList_V2.OWNER_ID == 0)) { i_Params_Get_Client_By_Criteria_InList_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Client_By_Criteria_InList_V2.START_ROW == null) { i_Params_Get_Client_By_Criteria_InList_V2.START_ROW = 0; }
if ((i_Params_Get_Client_By_Criteria_InList_V2.END_ROW == null) || (i_Params_Get_Client_By_Criteria_InList_V2.END_ROW == 0)) { i_Params_Get_Client_By_Criteria_InList_V2.END_ROW = 1000000; }
oParams_Get_Client_By_Criteria_InList_SP_V2.OWNER_ID = i_Params_Get_Client_By_Criteria_InList_V2.OWNER_ID;
oParams_Get_Client_By_Criteria_InList_SP_V2.CLIENT_NAME = i_Params_Get_Client_By_Criteria_InList_V2.CLIENT_NAME;
oParams_Get_Client_By_Criteria_InList_SP_V2.CLIENT_PH_NB = i_Params_Get_Client_By_Criteria_InList_V2.CLIENT_PH_NB;
oParams_Get_Client_By_Criteria_InList_SP_V2.CLIENT_MAIL = i_Params_Get_Client_By_Criteria_InList_V2.CLIENT_MAIL;
oParams_Get_Client_By_Criteria_InList_SP_V2.CLIENT_DOB = i_Params_Get_Client_By_Criteria_InList_V2.CLIENT_DOB;
if ( i_Params_Get_Client_By_Criteria_InList_V2.BLOODTYPE_ID_LIST == null)
{
i_Params_Get_Client_By_Criteria_InList_V2.BLOODTYPE_ID_LIST = new List<Int32?>();
}
oParams_Get_Client_By_Criteria_InList_SP_V2.BLOODTYPE_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Client_By_Criteria_InList_V2.BLOODTYPE_ID_LIST);
oParams_Get_Client_By_Criteria_InList_SP_V2.START_ROW = i_Params_Get_Client_By_Criteria_InList_V2.START_ROW;
oParams_Get_Client_By_Criteria_InList_SP_V2.END_ROW = i_Params_Get_Client_By_Criteria_InList_V2.END_ROW;
oParams_Get_Client_By_Criteria_InList_SP_V2.TOTAL_COUNT = i_Params_Get_Client_By_Criteria_InList_V2.TOTAL_COUNT;
List<DALC.Client> oList_DBEntries = _AppContext.Get_Client_By_Criteria_InList_Adv_V2(i_Params_Get_Client_By_Criteria_InList_V2.CLIENT_NAME,i_Params_Get_Client_By_Criteria_InList_V2.CLIENT_PH_NB,i_Params_Get_Client_By_Criteria_InList_V2.CLIENT_MAIL,i_Params_Get_Client_By_Criteria_InList_V2.CLIENT_DOB,i_Params_Get_Client_By_Criteria_InList_V2.BLOODTYPE_ID_LIST,i_Params_Get_Client_By_Criteria_InList_V2.OWNER_ID,i_Params_Get_Client_By_Criteria_InList_V2.START_ROW,i_Params_Get_Client_By_Criteria_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oClient = new Client();
oTools.CopyPropValues(oDBEntry, oClient);
oClient.My_Bloodtype = new Bloodtype();
oTools.CopyPropValues(oDBEntry.My_Bloodtype, oClient.My_Bloodtype);
oList.Add(oClient);
}
}
i_Params_Get_Client_By_Criteria_InList_V2.TOTAL_COUNT = oParams_Get_Client_By_Criteria_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Client_By_Criteria_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_By_Criteria_InList_Adv_V2");}
return oList;
}
public List<Client> Get_Client_By_Where_InList_Adv_V2(Params_Get_Client_By_Where_InList_V2 i_Params_Get_Client_By_Where_InList_V2)
{
List<Client> oList = new List<Client>();
Client oClient = new Client();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Client_By_Where_InList_SP_V2 oParams_Get_Client_By_Where_InList_SP_V2 = new Params_Get_Client_By_Where_InList_SP_V2();
Params_Get_Bloodtype_By_BLOODTYPE_ID oParams_Get_Bloodtype_By_BLOODTYPE_ID = new Params_Get_Bloodtype_By_BLOODTYPE_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_By_Where_InList_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Client_By_Where_InList_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Client_By_Where_InList_V2));}
#region Body Section.
if ((i_Params_Get_Client_By_Where_InList_V2.OWNER_ID == null) || (i_Params_Get_Client_By_Where_InList_V2.OWNER_ID == 0)) { i_Params_Get_Client_By_Where_InList_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Client_By_Where_InList_V2.START_ROW == null) { i_Params_Get_Client_By_Where_InList_V2.START_ROW = 0; }
if ((i_Params_Get_Client_By_Where_InList_V2.END_ROW == null) || (i_Params_Get_Client_By_Where_InList_V2.END_ROW == 0)) { i_Params_Get_Client_By_Where_InList_V2.END_ROW = 1000000; }
oParams_Get_Client_By_Where_InList_SP_V2.OWNER_ID = i_Params_Get_Client_By_Where_InList_V2.OWNER_ID;
oParams_Get_Client_By_Where_InList_SP_V2.CLIENT_NAME = i_Params_Get_Client_By_Where_InList_V2.CLIENT_NAME;
oParams_Get_Client_By_Where_InList_SP_V2.CLIENT_PH_NB = i_Params_Get_Client_By_Where_InList_V2.CLIENT_PH_NB;
oParams_Get_Client_By_Where_InList_SP_V2.CLIENT_MAIL = i_Params_Get_Client_By_Where_InList_V2.CLIENT_MAIL;
oParams_Get_Client_By_Where_InList_SP_V2.CLIENT_DOB = i_Params_Get_Client_By_Where_InList_V2.CLIENT_DOB;
if ( i_Params_Get_Client_By_Where_InList_V2.BLOODTYPE_ID_LIST == null)
{
i_Params_Get_Client_By_Where_InList_V2.BLOODTYPE_ID_LIST = new List<Int32?>();
}
oParams_Get_Client_By_Where_InList_SP_V2.BLOODTYPE_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Client_By_Where_InList_V2.BLOODTYPE_ID_LIST);
oParams_Get_Client_By_Where_InList_SP_V2.START_ROW = i_Params_Get_Client_By_Where_InList_V2.START_ROW;
oParams_Get_Client_By_Where_InList_SP_V2.END_ROW = i_Params_Get_Client_By_Where_InList_V2.END_ROW;
oParams_Get_Client_By_Where_InList_SP_V2.TOTAL_COUNT = i_Params_Get_Client_By_Where_InList_V2.TOTAL_COUNT;
List<DALC.Client> oList_DBEntries = _AppContext.Get_Client_By_Where_InList_Adv_V2(i_Params_Get_Client_By_Where_InList_V2.CLIENT_NAME,i_Params_Get_Client_By_Where_InList_V2.CLIENT_PH_NB,i_Params_Get_Client_By_Where_InList_V2.CLIENT_MAIL,i_Params_Get_Client_By_Where_InList_V2.CLIENT_DOB,i_Params_Get_Client_By_Where_InList_V2.BLOODTYPE_ID_LIST,i_Params_Get_Client_By_Where_InList_V2.OWNER_ID,i_Params_Get_Client_By_Where_InList_V2.START_ROW,i_Params_Get_Client_By_Where_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oClient = new Client();
oTools.CopyPropValues(oDBEntry, oClient);
oClient.My_Bloodtype = new Bloodtype();
oTools.CopyPropValues(oDBEntry.My_Bloodtype, oClient.My_Bloodtype);
oList.Add(oClient);
}
}
i_Params_Get_Client_By_Where_InList_V2.TOTAL_COUNT = oParams_Get_Client_By_Where_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Client_By_Where_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_By_Where_InList_Adv_V2");}
return oList;
}
public List<Client_fees> Get_Client_fees_By_Criteria_InList_Adv(Params_Get_Client_fees_By_Criteria_InList i_Params_Get_Client_fees_By_Criteria_InList)
{
List<Client_fees> oList = new List<Client_fees>();
Client_fees oClient_fees = new Client_fees();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Client_fees_By_Criteria_InList_SP oParams_Get_Client_fees_By_Criteria_InList_SP = new Params_Get_Client_fees_By_Criteria_InList_SP();
Params_Get_Client_By_CLIENT_ID oParams_Get_Client_By_CLIENT_ID = new Params_Get_Client_By_CLIENT_ID();
Params_Get_Currency_By_CURRENCY_ID oParams_Get_Currency_By_CURRENCY_ID = new Params_Get_Currency_By_CURRENCY_ID();
Params_Get_Package_By_PACKAGE_ID oParams_Get_Package_By_PACKAGE_ID = new Params_Get_Package_By_PACKAGE_ID();
Params_Get_Registration_By_REGISTRATION_ID oParams_Get_Registration_By_REGISTRATION_ID = new Params_Get_Registration_By_REGISTRATION_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_fees_By_Criteria_InList_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Client_fees_By_Criteria_InList_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Client_fees_By_Criteria_InList));}
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
List<DALC.Client_fees> oList_DBEntries = _AppContext.Get_Client_fees_By_Criteria_InList_Adv(i_Params_Get_Client_fees_By_Criteria_InList.CLIENT_FEES_DESCRIPTION,i_Params_Get_Client_fees_By_Criteria_InList.CLIENT_ID_LIST,i_Params_Get_Client_fees_By_Criteria_InList.CURRENCY_ID_LIST,i_Params_Get_Client_fees_By_Criteria_InList.PACKAGE_ID_LIST,i_Params_Get_Client_fees_By_Criteria_InList.REGISTRATION_ID_LIST,i_Params_Get_Client_fees_By_Criteria_InList.OWNER_ID,i_Params_Get_Client_fees_By_Criteria_InList.START_ROW,i_Params_Get_Client_fees_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oClient_fees = new Client_fees();
oTools.CopyPropValues(oDBEntry, oClient_fees);
oClient_fees.My_Client = new Client();
oTools.CopyPropValues(oDBEntry.My_Client, oClient_fees.My_Client);
oClient_fees.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oClient_fees.My_Currency);
oClient_fees.My_Package = new Package();
oTools.CopyPropValues(oDBEntry.My_Package, oClient_fees.My_Package);
oClient_fees.My_Registration = new Registration();
oTools.CopyPropValues(oDBEntry.My_Registration, oClient_fees.My_Registration);
oList.Add(oClient_fees);
}
}
i_Params_Get_Client_fees_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Client_fees_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Client_fees_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_fees_By_Criteria_InList_Adv");}
return oList;
}
public List<Client_fees> Get_Client_fees_By_Where_InList_Adv(Params_Get_Client_fees_By_Where_InList i_Params_Get_Client_fees_By_Where_InList)
{
List<Client_fees> oList = new List<Client_fees>();
Client_fees oClient_fees = new Client_fees();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Client_fees_By_Where_InList_SP oParams_Get_Client_fees_By_Where_InList_SP = new Params_Get_Client_fees_By_Where_InList_SP();
Params_Get_Client_By_CLIENT_ID oParams_Get_Client_By_CLIENT_ID = new Params_Get_Client_By_CLIENT_ID();
Params_Get_Currency_By_CURRENCY_ID oParams_Get_Currency_By_CURRENCY_ID = new Params_Get_Currency_By_CURRENCY_ID();
Params_Get_Package_By_PACKAGE_ID oParams_Get_Package_By_PACKAGE_ID = new Params_Get_Package_By_PACKAGE_ID();
Params_Get_Registration_By_REGISTRATION_ID oParams_Get_Registration_By_REGISTRATION_ID = new Params_Get_Registration_By_REGISTRATION_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Client_fees_By_Where_InList_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Client_fees_By_Where_InList_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Client_fees_By_Where_InList));}
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
List<DALC.Client_fees> oList_DBEntries = _AppContext.Get_Client_fees_By_Where_InList_Adv(i_Params_Get_Client_fees_By_Where_InList.CLIENT_FEES_DESCRIPTION,i_Params_Get_Client_fees_By_Where_InList.CLIENT_ID_LIST,i_Params_Get_Client_fees_By_Where_InList.CURRENCY_ID_LIST,i_Params_Get_Client_fees_By_Where_InList.PACKAGE_ID_LIST,i_Params_Get_Client_fees_By_Where_InList.REGISTRATION_ID_LIST,i_Params_Get_Client_fees_By_Where_InList.OWNER_ID,i_Params_Get_Client_fees_By_Where_InList.START_ROW,i_Params_Get_Client_fees_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oClient_fees = new Client_fees();
oTools.CopyPropValues(oDBEntry, oClient_fees);
oClient_fees.My_Client = new Client();
oTools.CopyPropValues(oDBEntry.My_Client, oClient_fees.My_Client);
oClient_fees.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oClient_fees.My_Currency);
oClient_fees.My_Package = new Package();
oTools.CopyPropValues(oDBEntry.My_Package, oClient_fees.My_Package);
oClient_fees.My_Registration = new Registration();
oTools.CopyPropValues(oDBEntry.My_Registration, oClient_fees.My_Registration);
oList.Add(oClient_fees);
}
}
i_Params_Get_Client_fees_By_Where_InList.TOTAL_COUNT = oParams_Get_Client_fees_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Client_fees_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Client_fees_By_Where_InList_Adv");}
return oList;
}
public List<Contact> Get_Contact_By_Criteria_InList_Adv(Params_Get_Contact_By_Criteria_InList i_Params_Get_Contact_By_Criteria_InList)
{
List<Contact> oList = new List<Contact>();
Contact oContact = new Contact();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Contact_By_Criteria_InList_SP oParams_Get_Contact_By_Criteria_InList_SP = new Params_Get_Contact_By_Criteria_InList_SP();
Params_Get_Person_By_PERSON_ID oParams_Get_Person_By_PERSON_ID = new Params_Get_Person_By_PERSON_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_Criteria_InList_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Contact_By_Criteria_InList_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Contact_By_Criteria_InList));}
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
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_Criteria_InList_Adv(i_Params_Get_Contact_By_Criteria_InList.CONTACT_TYPE_CODE,i_Params_Get_Contact_By_Criteria_InList.CONTACT,i_Params_Get_Contact_By_Criteria_InList.DESCRIPTION,i_Params_Get_Contact_By_Criteria_InList.PERSON_ID_LIST,i_Params_Get_Contact_By_Criteria_InList.OWNER_ID,i_Params_Get_Contact_By_Criteria_InList.START_ROW,i_Params_Get_Contact_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oContact.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oContact.My_Person);
oList.Add(oContact);
}
}
i_Params_Get_Contact_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Contact_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Contact_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_Criteria_InList_Adv");}
return oList;
}
public List<Contact> Get_Contact_By_Where_InList_Adv(Params_Get_Contact_By_Where_InList i_Params_Get_Contact_By_Where_InList)
{
List<Contact> oList = new List<Contact>();
Contact oContact = new Contact();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Contact_By_Where_InList_SP oParams_Get_Contact_By_Where_InList_SP = new Params_Get_Contact_By_Where_InList_SP();
Params_Get_Person_By_PERSON_ID oParams_Get_Person_By_PERSON_ID = new Params_Get_Person_By_PERSON_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Contact_By_Where_InList_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Contact_By_Where_InList_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Contact_By_Where_InList));}
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
List<DALC.Contact> oList_DBEntries = _AppContext.Get_Contact_By_Where_InList_Adv(i_Params_Get_Contact_By_Where_InList.CONTACT_TYPE_CODE,i_Params_Get_Contact_By_Where_InList.CONTACT,i_Params_Get_Contact_By_Where_InList.DESCRIPTION,i_Params_Get_Contact_By_Where_InList.PERSON_ID_LIST,i_Params_Get_Contact_By_Where_InList.OWNER_ID,i_Params_Get_Contact_By_Where_InList.START_ROW,i_Params_Get_Contact_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oContact = new Contact();
oTools.CopyPropValues(oDBEntry, oContact);
oContact.My_Person = new Person();
oTools.CopyPropValues(oDBEntry.My_Person, oContact.My_Person);
oList.Add(oContact);
}
}
i_Params_Get_Contact_By_Where_InList.TOTAL_COUNT = oParams_Get_Contact_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Contact_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Contact_By_Where_InList_Adv");}
return oList;
}
public List<Fees> Get_Fees_By_Criteria_InList_Adv(Params_Get_Fees_By_Criteria_InList i_Params_Get_Fees_By_Criteria_InList)
{
List<Fees> oList = new List<Fees>();
Fees oFees = new Fees();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Fees_By_Criteria_InList_SP oParams_Get_Fees_By_Criteria_InList_SP = new Params_Get_Fees_By_Criteria_InList_SP();
Params_Get_Currency_By_CURRENCY_ID oParams_Get_Currency_By_CURRENCY_ID = new Params_Get_Currency_By_CURRENCY_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Fees_By_Criteria_InList_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Fees_By_Criteria_InList_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Fees_By_Criteria_InList));}
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
List<DALC.Fees> oList_DBEntries = _AppContext.Get_Fees_By_Criteria_InList_Adv(i_Params_Get_Fees_By_Criteria_InList.FEES_DESCRIPTION,i_Params_Get_Fees_By_Criteria_InList.CURRENCY_ID_LIST,i_Params_Get_Fees_By_Criteria_InList.OWNER_ID,i_Params_Get_Fees_By_Criteria_InList.START_ROW,i_Params_Get_Fees_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFees = new Fees();
oTools.CopyPropValues(oDBEntry, oFees);
oFees.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oFees.My_Currency);
oList.Add(oFees);
}
}
i_Params_Get_Fees_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Fees_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Fees_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Fees_By_Criteria_InList_Adv");}
return oList;
}
public List<Fees> Get_Fees_By_Where_InList_Adv(Params_Get_Fees_By_Where_InList i_Params_Get_Fees_By_Where_InList)
{
List<Fees> oList = new List<Fees>();
Fees oFees = new Fees();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Fees_By_Where_InList_SP oParams_Get_Fees_By_Where_InList_SP = new Params_Get_Fees_By_Where_InList_SP();
Params_Get_Currency_By_CURRENCY_ID oParams_Get_Currency_By_CURRENCY_ID = new Params_Get_Currency_By_CURRENCY_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Fees_By_Where_InList_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Fees_By_Where_InList_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Fees_By_Where_InList));}
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
List<DALC.Fees> oList_DBEntries = _AppContext.Get_Fees_By_Where_InList_Adv(i_Params_Get_Fees_By_Where_InList.FEES_DESCRIPTION,i_Params_Get_Fees_By_Where_InList.CURRENCY_ID_LIST,i_Params_Get_Fees_By_Where_InList.OWNER_ID,i_Params_Get_Fees_By_Where_InList.START_ROW,i_Params_Get_Fees_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFees = new Fees();
oTools.CopyPropValues(oDBEntry, oFees);
oFees.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oFees.My_Currency);
oList.Add(oFees);
}
}
i_Params_Get_Fees_By_Where_InList.TOTAL_COUNT = oParams_Get_Fees_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Fees_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Fees_By_Where_InList_Adv");}
return oList;
}
public List<Fees> Get_Fees_By_Criteria_InList_Adv_V2(Params_Get_Fees_By_Criteria_InList_V2 i_Params_Get_Fees_By_Criteria_InList_V2)
{
List<Fees> oList = new List<Fees>();
Fees oFees = new Fees();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Fees_By_Criteria_InList_SP_V2 oParams_Get_Fees_By_Criteria_InList_SP_V2 = new Params_Get_Fees_By_Criteria_InList_SP_V2();
Params_Get_Currency_By_CURRENCY_ID oParams_Get_Currency_By_CURRENCY_ID = new Params_Get_Currency_By_CURRENCY_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Fees_By_Criteria_InList_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Fees_By_Criteria_InList_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Fees_By_Criteria_InList_V2));}
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
List<DALC.Fees> oList_DBEntries = _AppContext.Get_Fees_By_Criteria_InList_Adv_V2(i_Params_Get_Fees_By_Criteria_InList_V2.FEES_DESCRIPTION,i_Params_Get_Fees_By_Criteria_InList_V2.FEES_ORIGIN_DATE,i_Params_Get_Fees_By_Criteria_InList_V2.CURRENCY_ID_LIST,i_Params_Get_Fees_By_Criteria_InList_V2.OWNER_ID,i_Params_Get_Fees_By_Criteria_InList_V2.START_ROW,i_Params_Get_Fees_By_Criteria_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFees = new Fees();
oTools.CopyPropValues(oDBEntry, oFees);
oFees.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oFees.My_Currency);
oList.Add(oFees);
}
}
i_Params_Get_Fees_By_Criteria_InList_V2.TOTAL_COUNT = oParams_Get_Fees_By_Criteria_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Fees_By_Criteria_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Fees_By_Criteria_InList_Adv_V2");}
return oList;
}
public List<Fees> Get_Fees_By_Where_InList_Adv_V2(Params_Get_Fees_By_Where_InList_V2 i_Params_Get_Fees_By_Where_InList_V2)
{
List<Fees> oList = new List<Fees>();
Fees oFees = new Fees();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Fees_By_Where_InList_SP_V2 oParams_Get_Fees_By_Where_InList_SP_V2 = new Params_Get_Fees_By_Where_InList_SP_V2();
Params_Get_Currency_By_CURRENCY_ID oParams_Get_Currency_By_CURRENCY_ID = new Params_Get_Currency_By_CURRENCY_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Fees_By_Where_InList_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Fees_By_Where_InList_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Fees_By_Where_InList_V2));}
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
List<DALC.Fees> oList_DBEntries = _AppContext.Get_Fees_By_Where_InList_Adv_V2(i_Params_Get_Fees_By_Where_InList_V2.FEES_DESCRIPTION,i_Params_Get_Fees_By_Where_InList_V2.FEES_ORIGIN_DATE,i_Params_Get_Fees_By_Where_InList_V2.CURRENCY_ID_LIST,i_Params_Get_Fees_By_Where_InList_V2.OWNER_ID,i_Params_Get_Fees_By_Where_InList_V2.START_ROW,i_Params_Get_Fees_By_Where_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oFees = new Fees();
oTools.CopyPropValues(oDBEntry, oFees);
oFees.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oFees.My_Currency);
oList.Add(oFees);
}
}
i_Params_Get_Fees_By_Where_InList_V2.TOTAL_COUNT = oParams_Get_Fees_By_Where_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Fees_By_Where_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Fees_By_Where_InList_Adv_V2");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Criteria_InList_Adv(Params_Get_Loc_l2_By_Criteria_InList i_Params_Get_Loc_l2_By_Criteria_InList)
{
List<Loc_l2> oList = new List<Loc_l2>();
Loc_l2 oLoc_l2 = new Loc_l2();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Loc_l2_By_Criteria_InList_SP oParams_Get_Loc_l2_By_Criteria_InList_SP = new Params_Get_Loc_l2_By_Criteria_InList_SP();
Params_Get_Loc_l1_By_LOC_L1_ID oParams_Get_Loc_l1_By_LOC_L1_ID = new Params_Get_Loc_l1_By_LOC_L1_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_Criteria_InList_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l2_By_Criteria_InList_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l2_By_Criteria_InList));}
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
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_Criteria_InList_Adv(i_Params_Get_Loc_l2_By_Criteria_InList.CODE,i_Params_Get_Loc_l2_By_Criteria_InList.DESCRIPTION,i_Params_Get_Loc_l2_By_Criteria_InList.LOC_L1_ID_LIST,i_Params_Get_Loc_l2_By_Criteria_InList.OWNER_ID,i_Params_Get_Loc_l2_By_Criteria_InList.START_ROW,i_Params_Get_Loc_l2_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oLoc_l2.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oLoc_l2.My_Loc_l1);
oList.Add(oLoc_l2);
}
}
i_Params_Get_Loc_l2_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Loc_l2_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Loc_l2_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_Criteria_InList_Adv");}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Where_InList_Adv(Params_Get_Loc_l2_By_Where_InList i_Params_Get_Loc_l2_By_Where_InList)
{
List<Loc_l2> oList = new List<Loc_l2>();
Loc_l2 oLoc_l2 = new Loc_l2();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Loc_l2_By_Where_InList_SP oParams_Get_Loc_l2_By_Where_InList_SP = new Params_Get_Loc_l2_By_Where_InList_SP();
Params_Get_Loc_l1_By_LOC_L1_ID oParams_Get_Loc_l1_By_LOC_L1_ID = new Params_Get_Loc_l1_By_LOC_L1_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l2_By_Where_InList_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l2_By_Where_InList_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l2_By_Where_InList));}
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
List<DALC.Loc_l2> oList_DBEntries = _AppContext.Get_Loc_l2_By_Where_InList_Adv(i_Params_Get_Loc_l2_By_Where_InList.CODE,i_Params_Get_Loc_l2_By_Where_InList.DESCRIPTION,i_Params_Get_Loc_l2_By_Where_InList.LOC_L1_ID_LIST,i_Params_Get_Loc_l2_By_Where_InList.OWNER_ID,i_Params_Get_Loc_l2_By_Where_InList.START_ROW,i_Params_Get_Loc_l2_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry, oLoc_l2);
oLoc_l2.My_Loc_l1 = new Loc_l1();
oTools.CopyPropValues(oDBEntry.My_Loc_l1, oLoc_l2.My_Loc_l1);
oList.Add(oLoc_l2);
}
}
i_Params_Get_Loc_l2_By_Where_InList.TOTAL_COUNT = oParams_Get_Loc_l2_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Loc_l2_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l2_By_Where_InList_Adv");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Criteria_InList_Adv(Params_Get_Loc_l3_By_Criteria_InList i_Params_Get_Loc_l3_By_Criteria_InList)
{
List<Loc_l3> oList = new List<Loc_l3>();
Loc_l3 oLoc_l3 = new Loc_l3();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Loc_l3_By_Criteria_InList_SP oParams_Get_Loc_l3_By_Criteria_InList_SP = new Params_Get_Loc_l3_By_Criteria_InList_SP();
Params_Get_Loc_l2_By_LOC_L2_ID oParams_Get_Loc_l2_By_LOC_L2_ID = new Params_Get_Loc_l2_By_LOC_L2_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_Criteria_InList_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l3_By_Criteria_InList_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l3_By_Criteria_InList));}
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
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_Criteria_InList_Adv(i_Params_Get_Loc_l3_By_Criteria_InList.CODE,i_Params_Get_Loc_l3_By_Criteria_InList.DESCRIPTION,i_Params_Get_Loc_l3_By_Criteria_InList.LOC_L2_ID_LIST,i_Params_Get_Loc_l3_By_Criteria_InList.OWNER_ID,i_Params_Get_Loc_l3_By_Criteria_InList.START_ROW,i_Params_Get_Loc_l3_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oLoc_l3.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oLoc_l3.My_Loc_l2);
oList.Add(oLoc_l3);
}
}
i_Params_Get_Loc_l3_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Loc_l3_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Loc_l3_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_Criteria_InList_Adv");}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Where_InList_Adv(Params_Get_Loc_l3_By_Where_InList i_Params_Get_Loc_l3_By_Where_InList)
{
List<Loc_l3> oList = new List<Loc_l3>();
Loc_l3 oLoc_l3 = new Loc_l3();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Loc_l3_By_Where_InList_SP oParams_Get_Loc_l3_By_Where_InList_SP = new Params_Get_Loc_l3_By_Where_InList_SP();
Params_Get_Loc_l2_By_LOC_L2_ID oParams_Get_Loc_l2_By_LOC_L2_ID = new Params_Get_Loc_l2_By_LOC_L2_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l3_By_Where_InList_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l3_By_Where_InList_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l3_By_Where_InList));}
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
List<DALC.Loc_l3> oList_DBEntries = _AppContext.Get_Loc_l3_By_Where_InList_Adv(i_Params_Get_Loc_l3_By_Where_InList.CODE,i_Params_Get_Loc_l3_By_Where_InList.DESCRIPTION,i_Params_Get_Loc_l3_By_Where_InList.LOC_L2_ID_LIST,i_Params_Get_Loc_l3_By_Where_InList.OWNER_ID,i_Params_Get_Loc_l3_By_Where_InList.START_ROW,i_Params_Get_Loc_l3_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry, oLoc_l3);
oLoc_l3.My_Loc_l2 = new Loc_l2();
oTools.CopyPropValues(oDBEntry.My_Loc_l2, oLoc_l3.My_Loc_l2);
oList.Add(oLoc_l3);
}
}
i_Params_Get_Loc_l3_By_Where_InList.TOTAL_COUNT = oParams_Get_Loc_l3_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Loc_l3_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l3_By_Where_InList_Adv");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Criteria_InList_Adv(Params_Get_Loc_l4_By_Criteria_InList i_Params_Get_Loc_l4_By_Criteria_InList)
{
List<Loc_l4> oList = new List<Loc_l4>();
Loc_l4 oLoc_l4 = new Loc_l4();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Loc_l4_By_Criteria_InList_SP oParams_Get_Loc_l4_By_Criteria_InList_SP = new Params_Get_Loc_l4_By_Criteria_InList_SP();
Params_Get_Loc_l3_By_LOC_L3_ID oParams_Get_Loc_l3_By_LOC_L3_ID = new Params_Get_Loc_l3_By_LOC_L3_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_Criteria_InList_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l4_By_Criteria_InList_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l4_By_Criteria_InList));}
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
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_Criteria_InList_Adv(i_Params_Get_Loc_l4_By_Criteria_InList.CODE,i_Params_Get_Loc_l4_By_Criteria_InList.DESCRIPTION,i_Params_Get_Loc_l4_By_Criteria_InList.LOC_L3_ID_LIST,i_Params_Get_Loc_l4_By_Criteria_InList.OWNER_ID,i_Params_Get_Loc_l4_By_Criteria_InList.START_ROW,i_Params_Get_Loc_l4_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oLoc_l4.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oLoc_l4.My_Loc_l3);
oList.Add(oLoc_l4);
}
}
i_Params_Get_Loc_l4_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Loc_l4_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Loc_l4_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_Criteria_InList_Adv");}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Where_InList_Adv(Params_Get_Loc_l4_By_Where_InList i_Params_Get_Loc_l4_By_Where_InList)
{
List<Loc_l4> oList = new List<Loc_l4>();
Loc_l4 oLoc_l4 = new Loc_l4();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Loc_l4_By_Where_InList_SP oParams_Get_Loc_l4_By_Where_InList_SP = new Params_Get_Loc_l4_By_Where_InList_SP();
Params_Get_Loc_l3_By_LOC_L3_ID oParams_Get_Loc_l3_By_LOC_L3_ID = new Params_Get_Loc_l3_By_LOC_L3_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Loc_l4_By_Where_InList_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Loc_l4_By_Where_InList_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Loc_l4_By_Where_InList));}
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
List<DALC.Loc_l4> oList_DBEntries = _AppContext.Get_Loc_l4_By_Where_InList_Adv(i_Params_Get_Loc_l4_By_Where_InList.CODE,i_Params_Get_Loc_l4_By_Where_InList.DESCRIPTION,i_Params_Get_Loc_l4_By_Where_InList.LOC_L3_ID_LIST,i_Params_Get_Loc_l4_By_Where_InList.OWNER_ID,i_Params_Get_Loc_l4_By_Where_InList.START_ROW,i_Params_Get_Loc_l4_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oLoc_l4 = new Loc_l4();
oTools.CopyPropValues(oDBEntry, oLoc_l4);
oLoc_l4.My_Loc_l3 = new Loc_l3();
oTools.CopyPropValues(oDBEntry.My_Loc_l3, oLoc_l4.My_Loc_l3);
oList.Add(oLoc_l4);
}
}
i_Params_Get_Loc_l4_By_Where_InList.TOTAL_COUNT = oParams_Get_Loc_l4_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Loc_l4_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Loc_l4_By_Where_InList_Adv");}
return oList;
}
public List<Package> Get_Package_By_Criteria_InList_Adv(Params_Get_Package_By_Criteria_InList i_Params_Get_Package_By_Criteria_InList)
{
List<Package> oList = new List<Package>();
Package oPackage = new Package();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Package_By_Criteria_InList_SP oParams_Get_Package_By_Criteria_InList_SP = new Params_Get_Package_By_Criteria_InList_SP();
Params_Get_Currency_By_CURRENCY_ID oParams_Get_Currency_By_CURRENCY_ID = new Params_Get_Currency_By_CURRENCY_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Package_By_Criteria_InList_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Package_By_Criteria_InList_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Package_By_Criteria_InList));}
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
List<DALC.Package> oList_DBEntries = _AppContext.Get_Package_By_Criteria_InList_Adv(i_Params_Get_Package_By_Criteria_InList.PACKAGE_NAME,i_Params_Get_Package_By_Criteria_InList.PACKAGE_TYPE,i_Params_Get_Package_By_Criteria_InList.PACKAGE_TIMELINE,i_Params_Get_Package_By_Criteria_InList.CURRENCY_ID_LIST,i_Params_Get_Package_By_Criteria_InList.OWNER_ID,i_Params_Get_Package_By_Criteria_InList.START_ROW,i_Params_Get_Package_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oPackage = new Package();
oTools.CopyPropValues(oDBEntry, oPackage);
oPackage.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oPackage.My_Currency);
oList.Add(oPackage);
}
}
i_Params_Get_Package_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Package_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Package_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Package_By_Criteria_InList_Adv");}
return oList;
}
public List<Package> Get_Package_By_Where_InList_Adv(Params_Get_Package_By_Where_InList i_Params_Get_Package_By_Where_InList)
{
List<Package> oList = new List<Package>();
Package oPackage = new Package();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Package_By_Where_InList_SP oParams_Get_Package_By_Where_InList_SP = new Params_Get_Package_By_Where_InList_SP();
Params_Get_Currency_By_CURRENCY_ID oParams_Get_Currency_By_CURRENCY_ID = new Params_Get_Currency_By_CURRENCY_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Package_By_Where_InList_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Package_By_Where_InList_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Package_By_Where_InList));}
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
List<DALC.Package> oList_DBEntries = _AppContext.Get_Package_By_Where_InList_Adv(i_Params_Get_Package_By_Where_InList.PACKAGE_NAME,i_Params_Get_Package_By_Where_InList.PACKAGE_TYPE,i_Params_Get_Package_By_Where_InList.PACKAGE_TIMELINE,i_Params_Get_Package_By_Where_InList.CURRENCY_ID_LIST,i_Params_Get_Package_By_Where_InList.OWNER_ID,i_Params_Get_Package_By_Where_InList.START_ROW,i_Params_Get_Package_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oPackage = new Package();
oTools.CopyPropValues(oDBEntry, oPackage);
oPackage.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oPackage.My_Currency);
oList.Add(oPackage);
}
}
i_Params_Get_Package_By_Where_InList.TOTAL_COUNT = oParams_Get_Package_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Package_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Package_By_Where_InList_Adv");}
return oList;
}
public List<Package> Get_Package_By_Criteria_InList_Adv_V2(Params_Get_Package_By_Criteria_InList_V2 i_Params_Get_Package_By_Criteria_InList_V2)
{
List<Package> oList = new List<Package>();
Package oPackage = new Package();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Package_By_Criteria_InList_SP_V2 oParams_Get_Package_By_Criteria_InList_SP_V2 = new Params_Get_Package_By_Criteria_InList_SP_V2();
Params_Get_Currency_By_CURRENCY_ID oParams_Get_Currency_By_CURRENCY_ID = new Params_Get_Currency_By_CURRENCY_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Package_By_Criteria_InList_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Package_By_Criteria_InList_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Package_By_Criteria_InList_V2));}
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
List<DALC.Package> oList_DBEntries = _AppContext.Get_Package_By_Criteria_InList_Adv_V2(i_Params_Get_Package_By_Criteria_InList_V2.PACKAGE_NAME,i_Params_Get_Package_By_Criteria_InList_V2.PACKAGE_TYPE,i_Params_Get_Package_By_Criteria_InList_V2.PACKAGE_ENDING_DATE,i_Params_Get_Package_By_Criteria_InList_V2.PACKAGE_TIMELINE,i_Params_Get_Package_By_Criteria_InList_V2.PACKAGE_STARTING_DATE,i_Params_Get_Package_By_Criteria_InList_V2.CURRENCY_ID_LIST,i_Params_Get_Package_By_Criteria_InList_V2.OWNER_ID,i_Params_Get_Package_By_Criteria_InList_V2.START_ROW,i_Params_Get_Package_By_Criteria_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oPackage = new Package();
oTools.CopyPropValues(oDBEntry, oPackage);
oPackage.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oPackage.My_Currency);
oList.Add(oPackage);
}
}
i_Params_Get_Package_By_Criteria_InList_V2.TOTAL_COUNT = oParams_Get_Package_By_Criteria_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Package_By_Criteria_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Package_By_Criteria_InList_Adv_V2");}
return oList;
}
public List<Package> Get_Package_By_Where_InList_Adv_V2(Params_Get_Package_By_Where_InList_V2 i_Params_Get_Package_By_Where_InList_V2)
{
List<Package> oList = new List<Package>();
Package oPackage = new Package();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Package_By_Where_InList_SP_V2 oParams_Get_Package_By_Where_InList_SP_V2 = new Params_Get_Package_By_Where_InList_SP_V2();
Params_Get_Currency_By_CURRENCY_ID oParams_Get_Currency_By_CURRENCY_ID = new Params_Get_Currency_By_CURRENCY_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Package_By_Where_InList_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Package_By_Where_InList_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Package_By_Where_InList_V2));}
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
List<DALC.Package> oList_DBEntries = _AppContext.Get_Package_By_Where_InList_Adv_V2(i_Params_Get_Package_By_Where_InList_V2.PACKAGE_NAME,i_Params_Get_Package_By_Where_InList_V2.PACKAGE_TYPE,i_Params_Get_Package_By_Where_InList_V2.PACKAGE_ENDING_DATE,i_Params_Get_Package_By_Where_InList_V2.PACKAGE_TIMELINE,i_Params_Get_Package_By_Where_InList_V2.PACKAGE_STARTING_DATE,i_Params_Get_Package_By_Where_InList_V2.CURRENCY_ID_LIST,i_Params_Get_Package_By_Where_InList_V2.OWNER_ID,i_Params_Get_Package_By_Where_InList_V2.START_ROW,i_Params_Get_Package_By_Where_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oPackage = new Package();
oTools.CopyPropValues(oDBEntry, oPackage);
oPackage.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oPackage.My_Currency);
oList.Add(oPackage);
}
}
i_Params_Get_Package_By_Where_InList_V2.TOTAL_COUNT = oParams_Get_Package_By_Where_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Package_By_Where_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Package_By_Where_InList_Adv_V2");}
return oList;
}
public List<Registration> Get_Registration_By_Criteria_InList_Adv(Params_Get_Registration_By_Criteria_InList i_Params_Get_Registration_By_Criteria_InList)
{
List<Registration> oList = new List<Registration>();
Registration oRegistration = new Registration();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Registration_By_Criteria_InList_SP oParams_Get_Registration_By_Criteria_InList_SP = new Params_Get_Registration_By_Criteria_InList_SP();
Params_Get_Client_By_CLIENT_ID oParams_Get_Client_By_CLIENT_ID = new Params_Get_Client_By_CLIENT_ID();
Params_Get_Package_By_PACKAGE_ID oParams_Get_Package_By_PACKAGE_ID = new Params_Get_Package_By_PACKAGE_ID();
Params_Get_Currency_By_CURRENCY_ID oParams_Get_Currency_By_CURRENCY_ID = new Params_Get_Currency_By_CURRENCY_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Registration_By_Criteria_InList_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Registration_By_Criteria_InList_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Registration_By_Criteria_InList));}
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
List<DALC.Registration> oList_DBEntries = _AppContext.Get_Registration_By_Criteria_InList_Adv(i_Params_Get_Registration_By_Criteria_InList.REGISTRATION_DESCRIPTION,i_Params_Get_Registration_By_Criteria_InList.CLIENT_ID_LIST,i_Params_Get_Registration_By_Criteria_InList.PACKAGE_ID_LIST,i_Params_Get_Registration_By_Criteria_InList.CURRENCY_ID_LIST,i_Params_Get_Registration_By_Criteria_InList.OWNER_ID,i_Params_Get_Registration_By_Criteria_InList.START_ROW,i_Params_Get_Registration_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oRegistration = new Registration();
oTools.CopyPropValues(oDBEntry, oRegistration);
oRegistration.My_Client = new Client();
oTools.CopyPropValues(oDBEntry.My_Client, oRegistration.My_Client);
oRegistration.My_Package = new Package();
oTools.CopyPropValues(oDBEntry.My_Package, oRegistration.My_Package);
oRegistration.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oRegistration.My_Currency);
oList.Add(oRegistration);
}
}
i_Params_Get_Registration_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Registration_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Registration_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Registration_By_Criteria_InList_Adv");}
return oList;
}
public List<Registration> Get_Registration_By_Where_InList_Adv(Params_Get_Registration_By_Where_InList i_Params_Get_Registration_By_Where_InList)
{
List<Registration> oList = new List<Registration>();
Registration oRegistration = new Registration();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Registration_By_Where_InList_SP oParams_Get_Registration_By_Where_InList_SP = new Params_Get_Registration_By_Where_InList_SP();
Params_Get_Client_By_CLIENT_ID oParams_Get_Client_By_CLIENT_ID = new Params_Get_Client_By_CLIENT_ID();
Params_Get_Package_By_PACKAGE_ID oParams_Get_Package_By_PACKAGE_ID = new Params_Get_Package_By_PACKAGE_ID();
Params_Get_Currency_By_CURRENCY_ID oParams_Get_Currency_By_CURRENCY_ID = new Params_Get_Currency_By_CURRENCY_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Registration_By_Where_InList_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Registration_By_Where_InList_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Registration_By_Where_InList));}
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
List<DALC.Registration> oList_DBEntries = _AppContext.Get_Registration_By_Where_InList_Adv(i_Params_Get_Registration_By_Where_InList.REGISTRATION_DESCRIPTION,i_Params_Get_Registration_By_Where_InList.CLIENT_ID_LIST,i_Params_Get_Registration_By_Where_InList.PACKAGE_ID_LIST,i_Params_Get_Registration_By_Where_InList.CURRENCY_ID_LIST,i_Params_Get_Registration_By_Where_InList.OWNER_ID,i_Params_Get_Registration_By_Where_InList.START_ROW,i_Params_Get_Registration_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oRegistration = new Registration();
oTools.CopyPropValues(oDBEntry, oRegistration);
oRegistration.My_Client = new Client();
oTools.CopyPropValues(oDBEntry.My_Client, oRegistration.My_Client);
oRegistration.My_Package = new Package();
oTools.CopyPropValues(oDBEntry.My_Package, oRegistration.My_Package);
oRegistration.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oRegistration.My_Currency);
oList.Add(oRegistration);
}
}
i_Params_Get_Registration_By_Where_InList.TOTAL_COUNT = oParams_Get_Registration_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Registration_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Registration_By_Where_InList_Adv");}
return oList;
}
public List<Registration> Get_Registration_By_Criteria_InList_Adv_V2(Params_Get_Registration_By_Criteria_InList_V2 i_Params_Get_Registration_By_Criteria_InList_V2)
{
List<Registration> oList = new List<Registration>();
Registration oRegistration = new Registration();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Registration_By_Criteria_InList_SP_V2 oParams_Get_Registration_By_Criteria_InList_SP_V2 = new Params_Get_Registration_By_Criteria_InList_SP_V2();
Params_Get_Client_By_CLIENT_ID oParams_Get_Client_By_CLIENT_ID = new Params_Get_Client_By_CLIENT_ID();
Params_Get_Package_By_PACKAGE_ID oParams_Get_Package_By_PACKAGE_ID = new Params_Get_Package_By_PACKAGE_ID();
Params_Get_Currency_By_CURRENCY_ID oParams_Get_Currency_By_CURRENCY_ID = new Params_Get_Currency_By_CURRENCY_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Registration_By_Criteria_InList_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Registration_By_Criteria_InList_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Registration_By_Criteria_InList_V2));}
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
List<DALC.Registration> oList_DBEntries = _AppContext.Get_Registration_By_Criteria_InList_Adv_V2(i_Params_Get_Registration_By_Criteria_InList_V2.REGISTRATION_DATE,i_Params_Get_Registration_By_Criteria_InList_V2.REGISTRATION_DESCRIPTION,i_Params_Get_Registration_By_Criteria_InList_V2.CLIENT_ID_LIST,i_Params_Get_Registration_By_Criteria_InList_V2.PACKAGE_ID_LIST,i_Params_Get_Registration_By_Criteria_InList_V2.CURRENCY_ID_LIST,i_Params_Get_Registration_By_Criteria_InList_V2.OWNER_ID,i_Params_Get_Registration_By_Criteria_InList_V2.START_ROW,i_Params_Get_Registration_By_Criteria_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oRegistration = new Registration();
oTools.CopyPropValues(oDBEntry, oRegistration);
oRegistration.My_Client = new Client();
oTools.CopyPropValues(oDBEntry.My_Client, oRegistration.My_Client);
oRegistration.My_Package = new Package();
oTools.CopyPropValues(oDBEntry.My_Package, oRegistration.My_Package);
oRegistration.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oRegistration.My_Currency);
oList.Add(oRegistration);
}
}
i_Params_Get_Registration_By_Criteria_InList_V2.TOTAL_COUNT = oParams_Get_Registration_By_Criteria_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Registration_By_Criteria_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Registration_By_Criteria_InList_Adv_V2");}
return oList;
}
public List<Registration> Get_Registration_By_Where_InList_Adv_V2(Params_Get_Registration_By_Where_InList_V2 i_Params_Get_Registration_By_Where_InList_V2)
{
List<Registration> oList = new List<Registration>();
Registration oRegistration = new Registration();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Registration_By_Where_InList_SP_V2 oParams_Get_Registration_By_Where_InList_SP_V2 = new Params_Get_Registration_By_Where_InList_SP_V2();
Params_Get_Client_By_CLIENT_ID oParams_Get_Client_By_CLIENT_ID = new Params_Get_Client_By_CLIENT_ID();
Params_Get_Package_By_PACKAGE_ID oParams_Get_Package_By_PACKAGE_ID = new Params_Get_Package_By_PACKAGE_ID();
Params_Get_Currency_By_CURRENCY_ID oParams_Get_Currency_By_CURRENCY_ID = new Params_Get_Currency_By_CURRENCY_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Registration_By_Where_InList_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Registration_By_Where_InList_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Registration_By_Where_InList_V2));}
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
List<DALC.Registration> oList_DBEntries = _AppContext.Get_Registration_By_Where_InList_Adv_V2(i_Params_Get_Registration_By_Where_InList_V2.REGISTRATION_DATE,i_Params_Get_Registration_By_Where_InList_V2.REGISTRATION_DESCRIPTION,i_Params_Get_Registration_By_Where_InList_V2.CLIENT_ID_LIST,i_Params_Get_Registration_By_Where_InList_V2.PACKAGE_ID_LIST,i_Params_Get_Registration_By_Where_InList_V2.CURRENCY_ID_LIST,i_Params_Get_Registration_By_Where_InList_V2.OWNER_ID,i_Params_Get_Registration_By_Where_InList_V2.START_ROW,i_Params_Get_Registration_By_Where_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oRegistration = new Registration();
oTools.CopyPropValues(oDBEntry, oRegistration);
oRegistration.My_Client = new Client();
oTools.CopyPropValues(oDBEntry.My_Client, oRegistration.My_Client);
oRegistration.My_Package = new Package();
oTools.CopyPropValues(oDBEntry.My_Package, oRegistration.My_Package);
oRegistration.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oRegistration.My_Currency);
oList.Add(oRegistration);
}
}
i_Params_Get_Registration_By_Where_InList_V2.TOTAL_COUNT = oParams_Get_Registration_By_Where_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Registration_By_Where_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Registration_By_Where_InList_Adv_V2");}
return oList;
}
public List<Session> Get_Session_By_Criteria_InList_Adv(Params_Get_Session_By_Criteria_InList i_Params_Get_Session_By_Criteria_InList)
{
List<Session> oList = new List<Session>();
Session oSession = new Session();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Session_By_Criteria_InList_SP oParams_Get_Session_By_Criteria_InList_SP = new Params_Get_Session_By_Criteria_InList_SP();
Params_Get_Package_By_PACKAGE_ID oParams_Get_Package_By_PACKAGE_ID = new Params_Get_Package_By_PACKAGE_ID();
Params_Get_Client_fees_By_CLIENT_FEES_ID oParams_Get_Client_fees_By_CLIENT_FEES_ID = new Params_Get_Client_fees_By_CLIENT_FEES_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Session_By_Criteria_InList_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Session_By_Criteria_InList_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Session_By_Criteria_InList));}
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
List<DALC.Session> oList_DBEntries = _AppContext.Get_Session_By_Criteria_InList_Adv(i_Params_Get_Session_By_Criteria_InList.DESCRIPTION,i_Params_Get_Session_By_Criteria_InList.PACKAGE_ID_LIST,i_Params_Get_Session_By_Criteria_InList.CLIENT_FEES_ID_LIST,i_Params_Get_Session_By_Criteria_InList.OWNER_ID,i_Params_Get_Session_By_Criteria_InList.START_ROW,i_Params_Get_Session_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSession = new Session();
oTools.CopyPropValues(oDBEntry, oSession);
oSession.My_Package = new Package();
oTools.CopyPropValues(oDBEntry.My_Package, oSession.My_Package);
oSession.My_Client_fees = new Client_fees();
oTools.CopyPropValues(oDBEntry.My_Client_fees, oSession.My_Client_fees);
oList.Add(oSession);
}
}
i_Params_Get_Session_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Session_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Session_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Session_By_Criteria_InList_Adv");}
return oList;
}
public List<Session> Get_Session_By_Where_InList_Adv(Params_Get_Session_By_Where_InList i_Params_Get_Session_By_Where_InList)
{
List<Session> oList = new List<Session>();
Session oSession = new Session();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Session_By_Where_InList_SP oParams_Get_Session_By_Where_InList_SP = new Params_Get_Session_By_Where_InList_SP();
Params_Get_Package_By_PACKAGE_ID oParams_Get_Package_By_PACKAGE_ID = new Params_Get_Package_By_PACKAGE_ID();
Params_Get_Client_fees_By_CLIENT_FEES_ID oParams_Get_Client_fees_By_CLIENT_FEES_ID = new Params_Get_Client_fees_By_CLIENT_FEES_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Session_By_Where_InList_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Session_By_Where_InList_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Session_By_Where_InList));}
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
List<DALC.Session> oList_DBEntries = _AppContext.Get_Session_By_Where_InList_Adv(i_Params_Get_Session_By_Where_InList.DESCRIPTION,i_Params_Get_Session_By_Where_InList.PACKAGE_ID_LIST,i_Params_Get_Session_By_Where_InList.CLIENT_FEES_ID_LIST,i_Params_Get_Session_By_Where_InList.OWNER_ID,i_Params_Get_Session_By_Where_InList.START_ROW,i_Params_Get_Session_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSession = new Session();
oTools.CopyPropValues(oDBEntry, oSession);
oSession.My_Package = new Package();
oTools.CopyPropValues(oDBEntry.My_Package, oSession.My_Package);
oSession.My_Client_fees = new Client_fees();
oTools.CopyPropValues(oDBEntry.My_Client_fees, oSession.My_Client_fees);
oList.Add(oSession);
}
}
i_Params_Get_Session_By_Where_InList.TOTAL_COUNT = oParams_Get_Session_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Session_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Session_By_Where_InList_Adv");}
return oList;
}
public List<Session> Get_Session_By_Criteria_InList_Adv_V2(Params_Get_Session_By_Criteria_InList_V2 i_Params_Get_Session_By_Criteria_InList_V2)
{
List<Session> oList = new List<Session>();
Session oSession = new Session();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Session_By_Criteria_InList_SP_V2 oParams_Get_Session_By_Criteria_InList_SP_V2 = new Params_Get_Session_By_Criteria_InList_SP_V2();
Params_Get_Package_By_PACKAGE_ID oParams_Get_Package_By_PACKAGE_ID = new Params_Get_Package_By_PACKAGE_ID();
Params_Get_Client_fees_By_CLIENT_FEES_ID oParams_Get_Client_fees_By_CLIENT_FEES_ID = new Params_Get_Client_fees_By_CLIENT_FEES_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Session_By_Criteria_InList_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Session_By_Criteria_InList_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Session_By_Criteria_InList_V2));}
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
List<DALC.Session> oList_DBEntries = _AppContext.Get_Session_By_Criteria_InList_Adv_V2(i_Params_Get_Session_By_Criteria_InList_V2.SESSION_STARTING_DATE,i_Params_Get_Session_By_Criteria_InList_V2.SESSION_ENDING_DATE,i_Params_Get_Session_By_Criteria_InList_V2.DESCRIPTION,i_Params_Get_Session_By_Criteria_InList_V2.PACKAGE_ID_LIST,i_Params_Get_Session_By_Criteria_InList_V2.CLIENT_FEES_ID_LIST,i_Params_Get_Session_By_Criteria_InList_V2.OWNER_ID,i_Params_Get_Session_By_Criteria_InList_V2.START_ROW,i_Params_Get_Session_By_Criteria_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSession = new Session();
oTools.CopyPropValues(oDBEntry, oSession);
oSession.My_Package = new Package();
oTools.CopyPropValues(oDBEntry.My_Package, oSession.My_Package);
oSession.My_Client_fees = new Client_fees();
oTools.CopyPropValues(oDBEntry.My_Client_fees, oSession.My_Client_fees);
oList.Add(oSession);
}
}
i_Params_Get_Session_By_Criteria_InList_V2.TOTAL_COUNT = oParams_Get_Session_By_Criteria_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Session_By_Criteria_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Session_By_Criteria_InList_Adv_V2");}
return oList;
}
public List<Session> Get_Session_By_Where_InList_Adv_V2(Params_Get_Session_By_Where_InList_V2 i_Params_Get_Session_By_Where_InList_V2)
{
List<Session> oList = new List<Session>();
Session oSession = new Session();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Session_By_Where_InList_SP_V2 oParams_Get_Session_By_Where_InList_SP_V2 = new Params_Get_Session_By_Where_InList_SP_V2();
Params_Get_Package_By_PACKAGE_ID oParams_Get_Package_By_PACKAGE_ID = new Params_Get_Package_By_PACKAGE_ID();
Params_Get_Client_fees_By_CLIENT_FEES_ID oParams_Get_Client_fees_By_CLIENT_FEES_ID = new Params_Get_Client_fees_By_CLIENT_FEES_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Session_By_Where_InList_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Session_By_Where_InList_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Session_By_Where_InList_V2));}
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
List<DALC.Session> oList_DBEntries = _AppContext.Get_Session_By_Where_InList_Adv_V2(i_Params_Get_Session_By_Where_InList_V2.SESSION_STARTING_DATE,i_Params_Get_Session_By_Where_InList_V2.SESSION_ENDING_DATE,i_Params_Get_Session_By_Where_InList_V2.DESCRIPTION,i_Params_Get_Session_By_Where_InList_V2.PACKAGE_ID_LIST,i_Params_Get_Session_By_Where_InList_V2.CLIENT_FEES_ID_LIST,i_Params_Get_Session_By_Where_InList_V2.OWNER_ID,i_Params_Get_Session_By_Where_InList_V2.START_ROW,i_Params_Get_Session_By_Where_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSession = new Session();
oTools.CopyPropValues(oDBEntry, oSession);
oSession.My_Package = new Package();
oTools.CopyPropValues(oDBEntry.My_Package, oSession.My_Package);
oSession.My_Client_fees = new Client_fees();
oTools.CopyPropValues(oDBEntry.My_Client_fees, oSession.My_Client_fees);
oList.Add(oSession);
}
}
i_Params_Get_Session_By_Where_InList_V2.TOTAL_COUNT = oParams_Get_Session_By_Where_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Session_By_Where_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Session_By_Where_InList_Adv_V2");}
return oList;
}
public List<Staff> Get_Staff_By_Criteria_InList_Adv(Params_Get_Staff_By_Criteria_InList i_Params_Get_Staff_By_Criteria_InList)
{
List<Staff> oList = new List<Staff>();
Staff oStaff = new Staff();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Staff_By_Criteria_InList_SP oParams_Get_Staff_By_Criteria_InList_SP = new Params_Get_Staff_By_Criteria_InList_SP();
Params_Get_Bloodtype_By_BLOODTYPE_ID oParams_Get_Bloodtype_By_BLOODTYPE_ID = new Params_Get_Bloodtype_By_BLOODTYPE_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_By_Criteria_InList_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_By_Criteria_InList_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_By_Criteria_InList));}
#region Body Section.
if ((i_Params_Get_Staff_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Staff_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Staff_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Staff_By_Criteria_InList.START_ROW == null) { i_Params_Get_Staff_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Staff_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Staff_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Staff_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Staff_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Staff_By_Criteria_InList.OWNER_ID;
oParams_Get_Staff_By_Criteria_InList_SP.STAFF_NAME = i_Params_Get_Staff_By_Criteria_InList.STAFF_NAME;
oParams_Get_Staff_By_Criteria_InList_SP.STAFF_PH_NB = i_Params_Get_Staff_By_Criteria_InList.STAFF_PH_NB;
oParams_Get_Staff_By_Criteria_InList_SP.STAFF_MAIL = i_Params_Get_Staff_By_Criteria_InList.STAFF_MAIL;
if ( i_Params_Get_Staff_By_Criteria_InList.BLOODTYPE_ID_LIST == null)
{
i_Params_Get_Staff_By_Criteria_InList.BLOODTYPE_ID_LIST = new List<Int32?>();
}
oParams_Get_Staff_By_Criteria_InList_SP.BLOODTYPE_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Staff_By_Criteria_InList.BLOODTYPE_ID_LIST);
oParams_Get_Staff_By_Criteria_InList_SP.START_ROW = i_Params_Get_Staff_By_Criteria_InList.START_ROW;
oParams_Get_Staff_By_Criteria_InList_SP.END_ROW = i_Params_Get_Staff_By_Criteria_InList.END_ROW;
oParams_Get_Staff_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Staff_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Staff> oList_DBEntries = _AppContext.Get_Staff_By_Criteria_InList_Adv(i_Params_Get_Staff_By_Criteria_InList.STAFF_NAME,i_Params_Get_Staff_By_Criteria_InList.STAFF_PH_NB,i_Params_Get_Staff_By_Criteria_InList.STAFF_MAIL,i_Params_Get_Staff_By_Criteria_InList.BLOODTYPE_ID_LIST,i_Params_Get_Staff_By_Criteria_InList.OWNER_ID,i_Params_Get_Staff_By_Criteria_InList.START_ROW,i_Params_Get_Staff_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStaff = new Staff();
oTools.CopyPropValues(oDBEntry, oStaff);
oStaff.My_Bloodtype = new Bloodtype();
oTools.CopyPropValues(oDBEntry.My_Bloodtype, oStaff.My_Bloodtype);
oList.Add(oStaff);
}
}
i_Params_Get_Staff_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Staff_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Staff_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_By_Criteria_InList_Adv");}
return oList;
}
public List<Staff> Get_Staff_By_Where_InList_Adv(Params_Get_Staff_By_Where_InList i_Params_Get_Staff_By_Where_InList)
{
List<Staff> oList = new List<Staff>();
Staff oStaff = new Staff();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Staff_By_Where_InList_SP oParams_Get_Staff_By_Where_InList_SP = new Params_Get_Staff_By_Where_InList_SP();
Params_Get_Bloodtype_By_BLOODTYPE_ID oParams_Get_Bloodtype_By_BLOODTYPE_ID = new Params_Get_Bloodtype_By_BLOODTYPE_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_By_Where_InList_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_By_Where_InList_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_By_Where_InList));}
#region Body Section.
if ((i_Params_Get_Staff_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Staff_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Staff_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Staff_By_Where_InList.START_ROW == null) { i_Params_Get_Staff_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Staff_By_Where_InList.END_ROW == null) || (i_Params_Get_Staff_By_Where_InList.END_ROW == 0)) { i_Params_Get_Staff_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Staff_By_Where_InList_SP.OWNER_ID = i_Params_Get_Staff_By_Where_InList.OWNER_ID;
oParams_Get_Staff_By_Where_InList_SP.STAFF_NAME = i_Params_Get_Staff_By_Where_InList.STAFF_NAME;
oParams_Get_Staff_By_Where_InList_SP.STAFF_PH_NB = i_Params_Get_Staff_By_Where_InList.STAFF_PH_NB;
oParams_Get_Staff_By_Where_InList_SP.STAFF_MAIL = i_Params_Get_Staff_By_Where_InList.STAFF_MAIL;
if ( i_Params_Get_Staff_By_Where_InList.BLOODTYPE_ID_LIST == null)
{
i_Params_Get_Staff_By_Where_InList.BLOODTYPE_ID_LIST = new List<Int32?>();
}
oParams_Get_Staff_By_Where_InList_SP.BLOODTYPE_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Staff_By_Where_InList.BLOODTYPE_ID_LIST);
oParams_Get_Staff_By_Where_InList_SP.START_ROW = i_Params_Get_Staff_By_Where_InList.START_ROW;
oParams_Get_Staff_By_Where_InList_SP.END_ROW = i_Params_Get_Staff_By_Where_InList.END_ROW;
oParams_Get_Staff_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Staff_By_Where_InList.TOTAL_COUNT;
List<DALC.Staff> oList_DBEntries = _AppContext.Get_Staff_By_Where_InList_Adv(i_Params_Get_Staff_By_Where_InList.STAFF_NAME,i_Params_Get_Staff_By_Where_InList.STAFF_PH_NB,i_Params_Get_Staff_By_Where_InList.STAFF_MAIL,i_Params_Get_Staff_By_Where_InList.BLOODTYPE_ID_LIST,i_Params_Get_Staff_By_Where_InList.OWNER_ID,i_Params_Get_Staff_By_Where_InList.START_ROW,i_Params_Get_Staff_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStaff = new Staff();
oTools.CopyPropValues(oDBEntry, oStaff);
oStaff.My_Bloodtype = new Bloodtype();
oTools.CopyPropValues(oDBEntry.My_Bloodtype, oStaff.My_Bloodtype);
oList.Add(oStaff);
}
}
i_Params_Get_Staff_By_Where_InList.TOTAL_COUNT = oParams_Get_Staff_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Staff_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_By_Where_InList_Adv");}
return oList;
}
public List<Staff> Get_Staff_By_Criteria_InList_Adv_V2(Params_Get_Staff_By_Criteria_InList_V2 i_Params_Get_Staff_By_Criteria_InList_V2)
{
List<Staff> oList = new List<Staff>();
Staff oStaff = new Staff();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Staff_By_Criteria_InList_SP_V2 oParams_Get_Staff_By_Criteria_InList_SP_V2 = new Params_Get_Staff_By_Criteria_InList_SP_V2();
Params_Get_Bloodtype_By_BLOODTYPE_ID oParams_Get_Bloodtype_By_BLOODTYPE_ID = new Params_Get_Bloodtype_By_BLOODTYPE_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_By_Criteria_InList_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_By_Criteria_InList_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_By_Criteria_InList_V2));}
#region Body Section.
if ((i_Params_Get_Staff_By_Criteria_InList_V2.OWNER_ID == null) || (i_Params_Get_Staff_By_Criteria_InList_V2.OWNER_ID == 0)) { i_Params_Get_Staff_By_Criteria_InList_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Staff_By_Criteria_InList_V2.START_ROW == null) { i_Params_Get_Staff_By_Criteria_InList_V2.START_ROW = 0; }
if ((i_Params_Get_Staff_By_Criteria_InList_V2.END_ROW == null) || (i_Params_Get_Staff_By_Criteria_InList_V2.END_ROW == 0)) { i_Params_Get_Staff_By_Criteria_InList_V2.END_ROW = 1000000; }
oParams_Get_Staff_By_Criteria_InList_SP_V2.OWNER_ID = i_Params_Get_Staff_By_Criteria_InList_V2.OWNER_ID;
oParams_Get_Staff_By_Criteria_InList_SP_V2.STAFF_NAME = i_Params_Get_Staff_By_Criteria_InList_V2.STAFF_NAME;
oParams_Get_Staff_By_Criteria_InList_SP_V2.STAFF_PH_NB = i_Params_Get_Staff_By_Criteria_InList_V2.STAFF_PH_NB;
oParams_Get_Staff_By_Criteria_InList_SP_V2.STAFF_MAIL = i_Params_Get_Staff_By_Criteria_InList_V2.STAFF_MAIL;
oParams_Get_Staff_By_Criteria_InList_SP_V2.STAFF_DOB = i_Params_Get_Staff_By_Criteria_InList_V2.STAFF_DOB;
if ( i_Params_Get_Staff_By_Criteria_InList_V2.BLOODTYPE_ID_LIST == null)
{
i_Params_Get_Staff_By_Criteria_InList_V2.BLOODTYPE_ID_LIST = new List<Int32?>();
}
oParams_Get_Staff_By_Criteria_InList_SP_V2.BLOODTYPE_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Staff_By_Criteria_InList_V2.BLOODTYPE_ID_LIST);
oParams_Get_Staff_By_Criteria_InList_SP_V2.START_ROW = i_Params_Get_Staff_By_Criteria_InList_V2.START_ROW;
oParams_Get_Staff_By_Criteria_InList_SP_V2.END_ROW = i_Params_Get_Staff_By_Criteria_InList_V2.END_ROW;
oParams_Get_Staff_By_Criteria_InList_SP_V2.TOTAL_COUNT = i_Params_Get_Staff_By_Criteria_InList_V2.TOTAL_COUNT;
List<DALC.Staff> oList_DBEntries = _AppContext.Get_Staff_By_Criteria_InList_Adv_V2(i_Params_Get_Staff_By_Criteria_InList_V2.STAFF_NAME,i_Params_Get_Staff_By_Criteria_InList_V2.STAFF_PH_NB,i_Params_Get_Staff_By_Criteria_InList_V2.STAFF_MAIL,i_Params_Get_Staff_By_Criteria_InList_V2.STAFF_DOB,i_Params_Get_Staff_By_Criteria_InList_V2.BLOODTYPE_ID_LIST,i_Params_Get_Staff_By_Criteria_InList_V2.OWNER_ID,i_Params_Get_Staff_By_Criteria_InList_V2.START_ROW,i_Params_Get_Staff_By_Criteria_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStaff = new Staff();
oTools.CopyPropValues(oDBEntry, oStaff);
oStaff.My_Bloodtype = new Bloodtype();
oTools.CopyPropValues(oDBEntry.My_Bloodtype, oStaff.My_Bloodtype);
oList.Add(oStaff);
}
}
i_Params_Get_Staff_By_Criteria_InList_V2.TOTAL_COUNT = oParams_Get_Staff_By_Criteria_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Staff_By_Criteria_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_By_Criteria_InList_Adv_V2");}
return oList;
}
public List<Staff> Get_Staff_By_Where_InList_Adv_V2(Params_Get_Staff_By_Where_InList_V2 i_Params_Get_Staff_By_Where_InList_V2)
{
List<Staff> oList = new List<Staff>();
Staff oStaff = new Staff();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Staff_By_Where_InList_SP_V2 oParams_Get_Staff_By_Where_InList_SP_V2 = new Params_Get_Staff_By_Where_InList_SP_V2();
Params_Get_Bloodtype_By_BLOODTYPE_ID oParams_Get_Bloodtype_By_BLOODTYPE_ID = new Params_Get_Bloodtype_By_BLOODTYPE_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_By_Where_InList_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_By_Where_InList_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_By_Where_InList_V2));}
#region Body Section.
if ((i_Params_Get_Staff_By_Where_InList_V2.OWNER_ID == null) || (i_Params_Get_Staff_By_Where_InList_V2.OWNER_ID == 0)) { i_Params_Get_Staff_By_Where_InList_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Staff_By_Where_InList_V2.START_ROW == null) { i_Params_Get_Staff_By_Where_InList_V2.START_ROW = 0; }
if ((i_Params_Get_Staff_By_Where_InList_V2.END_ROW == null) || (i_Params_Get_Staff_By_Where_InList_V2.END_ROW == 0)) { i_Params_Get_Staff_By_Where_InList_V2.END_ROW = 1000000; }
oParams_Get_Staff_By_Where_InList_SP_V2.OWNER_ID = i_Params_Get_Staff_By_Where_InList_V2.OWNER_ID;
oParams_Get_Staff_By_Where_InList_SP_V2.STAFF_NAME = i_Params_Get_Staff_By_Where_InList_V2.STAFF_NAME;
oParams_Get_Staff_By_Where_InList_SP_V2.STAFF_PH_NB = i_Params_Get_Staff_By_Where_InList_V2.STAFF_PH_NB;
oParams_Get_Staff_By_Where_InList_SP_V2.STAFF_MAIL = i_Params_Get_Staff_By_Where_InList_V2.STAFF_MAIL;
oParams_Get_Staff_By_Where_InList_SP_V2.STAFF_DOB = i_Params_Get_Staff_By_Where_InList_V2.STAFF_DOB;
if ( i_Params_Get_Staff_By_Where_InList_V2.BLOODTYPE_ID_LIST == null)
{
i_Params_Get_Staff_By_Where_InList_V2.BLOODTYPE_ID_LIST = new List<Int32?>();
}
oParams_Get_Staff_By_Where_InList_SP_V2.BLOODTYPE_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Staff_By_Where_InList_V2.BLOODTYPE_ID_LIST);
oParams_Get_Staff_By_Where_InList_SP_V2.START_ROW = i_Params_Get_Staff_By_Where_InList_V2.START_ROW;
oParams_Get_Staff_By_Where_InList_SP_V2.END_ROW = i_Params_Get_Staff_By_Where_InList_V2.END_ROW;
oParams_Get_Staff_By_Where_InList_SP_V2.TOTAL_COUNT = i_Params_Get_Staff_By_Where_InList_V2.TOTAL_COUNT;
List<DALC.Staff> oList_DBEntries = _AppContext.Get_Staff_By_Where_InList_Adv_V2(i_Params_Get_Staff_By_Where_InList_V2.STAFF_NAME,i_Params_Get_Staff_By_Where_InList_V2.STAFF_PH_NB,i_Params_Get_Staff_By_Where_InList_V2.STAFF_MAIL,i_Params_Get_Staff_By_Where_InList_V2.STAFF_DOB,i_Params_Get_Staff_By_Where_InList_V2.BLOODTYPE_ID_LIST,i_Params_Get_Staff_By_Where_InList_V2.OWNER_ID,i_Params_Get_Staff_By_Where_InList_V2.START_ROW,i_Params_Get_Staff_By_Where_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStaff = new Staff();
oTools.CopyPropValues(oDBEntry, oStaff);
oStaff.My_Bloodtype = new Bloodtype();
oTools.CopyPropValues(oDBEntry.My_Bloodtype, oStaff.My_Bloodtype);
oList.Add(oStaff);
}
}
i_Params_Get_Staff_By_Where_InList_V2.TOTAL_COUNT = oParams_Get_Staff_By_Where_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Staff_By_Where_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_By_Where_InList_Adv_V2");}
return oList;
}
public List<Staff_fees> Get_Staff_fees_By_Criteria_InList_Adv(Params_Get_Staff_fees_By_Criteria_InList i_Params_Get_Staff_fees_By_Criteria_InList)
{
List<Staff_fees> oList = new List<Staff_fees>();
Staff_fees oStaff_fees = new Staff_fees();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Staff_fees_By_Criteria_InList_SP oParams_Get_Staff_fees_By_Criteria_InList_SP = new Params_Get_Staff_fees_By_Criteria_InList_SP();
Params_Get_Staff_By_STAFF_ID oParams_Get_Staff_By_STAFF_ID = new Params_Get_Staff_By_STAFF_ID();
Params_Get_Currency_By_CURRENCY_ID oParams_Get_Currency_By_CURRENCY_ID = new Params_Get_Currency_By_CURRENCY_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_fees_By_Criteria_InList_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_fees_By_Criteria_InList_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_fees_By_Criteria_InList));}
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
List<DALC.Staff_fees> oList_DBEntries = _AppContext.Get_Staff_fees_By_Criteria_InList_Adv(i_Params_Get_Staff_fees_By_Criteria_InList.STAFF_FEES_DESCRIPTION,i_Params_Get_Staff_fees_By_Criteria_InList.STAFF_ID_LIST,i_Params_Get_Staff_fees_By_Criteria_InList.CURRENCY_ID_LIST,i_Params_Get_Staff_fees_By_Criteria_InList.OWNER_ID,i_Params_Get_Staff_fees_By_Criteria_InList.START_ROW,i_Params_Get_Staff_fees_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStaff_fees = new Staff_fees();
oTools.CopyPropValues(oDBEntry, oStaff_fees);
oStaff_fees.My_Staff = new Staff();
oTools.CopyPropValues(oDBEntry.My_Staff, oStaff_fees.My_Staff);
oStaff_fees.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oStaff_fees.My_Currency);
oList.Add(oStaff_fees);
}
}
i_Params_Get_Staff_fees_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Staff_fees_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Staff_fees_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_fees_By_Criteria_InList_Adv");}
return oList;
}
public List<Staff_fees> Get_Staff_fees_By_Where_InList_Adv(Params_Get_Staff_fees_By_Where_InList i_Params_Get_Staff_fees_By_Where_InList)
{
List<Staff_fees> oList = new List<Staff_fees>();
Staff_fees oStaff_fees = new Staff_fees();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Staff_fees_By_Where_InList_SP oParams_Get_Staff_fees_By_Where_InList_SP = new Params_Get_Staff_fees_By_Where_InList_SP();
Params_Get_Staff_By_STAFF_ID oParams_Get_Staff_By_STAFF_ID = new Params_Get_Staff_By_STAFF_ID();
Params_Get_Currency_By_CURRENCY_ID oParams_Get_Currency_By_CURRENCY_ID = new Params_Get_Currency_By_CURRENCY_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Staff_fees_By_Where_InList_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Staff_fees_By_Where_InList_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Staff_fees_By_Where_InList));}
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
List<DALC.Staff_fees> oList_DBEntries = _AppContext.Get_Staff_fees_By_Where_InList_Adv(i_Params_Get_Staff_fees_By_Where_InList.STAFF_FEES_DESCRIPTION,i_Params_Get_Staff_fees_By_Where_InList.STAFF_ID_LIST,i_Params_Get_Staff_fees_By_Where_InList.CURRENCY_ID_LIST,i_Params_Get_Staff_fees_By_Where_InList.OWNER_ID,i_Params_Get_Staff_fees_By_Where_InList.START_ROW,i_Params_Get_Staff_fees_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oStaff_fees = new Staff_fees();
oTools.CopyPropValues(oDBEntry, oStaff_fees);
oStaff_fees.My_Staff = new Staff();
oTools.CopyPropValues(oDBEntry.My_Staff, oStaff_fees.My_Staff);
oStaff_fees.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oStaff_fees.My_Currency);
oList.Add(oStaff_fees);
}
}
i_Params_Get_Staff_fees_By_Where_InList.TOTAL_COUNT = oParams_Get_Staff_fees_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Staff_fees_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Staff_fees_By_Where_InList_Adv");}
return oList;
}
public List<Supplier> Get_Supplier_By_Criteria_InList_Adv(Params_Get_Supplier_By_Criteria_InList i_Params_Get_Supplier_By_Criteria_InList)
{
List<Supplier> oList = new List<Supplier>();
Supplier oSupplier = new Supplier();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Supplier_By_Criteria_InList_SP oParams_Get_Supplier_By_Criteria_InList_SP = new Params_Get_Supplier_By_Criteria_InList_SP();
Params_Get_Bloodtype_By_BLOODTYPE_ID oParams_Get_Bloodtype_By_BLOODTYPE_ID = new Params_Get_Bloodtype_By_BLOODTYPE_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_By_Criteria_InList_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_By_Criteria_InList_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_By_Criteria_InList));}
#region Body Section.
if ((i_Params_Get_Supplier_By_Criteria_InList.OWNER_ID == null) || (i_Params_Get_Supplier_By_Criteria_InList.OWNER_ID == 0)) { i_Params_Get_Supplier_By_Criteria_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Supplier_By_Criteria_InList.START_ROW == null) { i_Params_Get_Supplier_By_Criteria_InList.START_ROW = 0; }
if ((i_Params_Get_Supplier_By_Criteria_InList.END_ROW == null) || (i_Params_Get_Supplier_By_Criteria_InList.END_ROW == 0)) { i_Params_Get_Supplier_By_Criteria_InList.END_ROW = 1000000; }
oParams_Get_Supplier_By_Criteria_InList_SP.OWNER_ID = i_Params_Get_Supplier_By_Criteria_InList.OWNER_ID;
oParams_Get_Supplier_By_Criteria_InList_SP.SUPPLIER_NAME = i_Params_Get_Supplier_By_Criteria_InList.SUPPLIER_NAME;
oParams_Get_Supplier_By_Criteria_InList_SP.SUPPLIER_PH_NB = i_Params_Get_Supplier_By_Criteria_InList.SUPPLIER_PH_NB;
oParams_Get_Supplier_By_Criteria_InList_SP.SUPPLIER_MAIL = i_Params_Get_Supplier_By_Criteria_InList.SUPPLIER_MAIL;
if ( i_Params_Get_Supplier_By_Criteria_InList.BLOODTYPE_ID_LIST == null)
{
i_Params_Get_Supplier_By_Criteria_InList.BLOODTYPE_ID_LIST = new List<Int32?>();
}
oParams_Get_Supplier_By_Criteria_InList_SP.BLOODTYPE_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Supplier_By_Criteria_InList.BLOODTYPE_ID_LIST);
oParams_Get_Supplier_By_Criteria_InList_SP.START_ROW = i_Params_Get_Supplier_By_Criteria_InList.START_ROW;
oParams_Get_Supplier_By_Criteria_InList_SP.END_ROW = i_Params_Get_Supplier_By_Criteria_InList.END_ROW;
oParams_Get_Supplier_By_Criteria_InList_SP.TOTAL_COUNT = i_Params_Get_Supplier_By_Criteria_InList.TOTAL_COUNT;
List<DALC.Supplier> oList_DBEntries = _AppContext.Get_Supplier_By_Criteria_InList_Adv(i_Params_Get_Supplier_By_Criteria_InList.SUPPLIER_NAME,i_Params_Get_Supplier_By_Criteria_InList.SUPPLIER_PH_NB,i_Params_Get_Supplier_By_Criteria_InList.SUPPLIER_MAIL,i_Params_Get_Supplier_By_Criteria_InList.BLOODTYPE_ID_LIST,i_Params_Get_Supplier_By_Criteria_InList.OWNER_ID,i_Params_Get_Supplier_By_Criteria_InList.START_ROW,i_Params_Get_Supplier_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier = new Supplier();
oTools.CopyPropValues(oDBEntry, oSupplier);
oSupplier.My_Bloodtype = new Bloodtype();
oTools.CopyPropValues(oDBEntry.My_Bloodtype, oSupplier.My_Bloodtype);
oList.Add(oSupplier);
}
}
i_Params_Get_Supplier_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Supplier_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Supplier_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_By_Criteria_InList_Adv");}
return oList;
}
public List<Supplier> Get_Supplier_By_Where_InList_Adv(Params_Get_Supplier_By_Where_InList i_Params_Get_Supplier_By_Where_InList)
{
List<Supplier> oList = new List<Supplier>();
Supplier oSupplier = new Supplier();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Supplier_By_Where_InList_SP oParams_Get_Supplier_By_Where_InList_SP = new Params_Get_Supplier_By_Where_InList_SP();
Params_Get_Bloodtype_By_BLOODTYPE_ID oParams_Get_Bloodtype_By_BLOODTYPE_ID = new Params_Get_Bloodtype_By_BLOODTYPE_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_By_Where_InList_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_By_Where_InList_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_By_Where_InList));}
#region Body Section.
if ((i_Params_Get_Supplier_By_Where_InList.OWNER_ID == null) || (i_Params_Get_Supplier_By_Where_InList.OWNER_ID == 0)) { i_Params_Get_Supplier_By_Where_InList.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Supplier_By_Where_InList.START_ROW == null) { i_Params_Get_Supplier_By_Where_InList.START_ROW = 0; }
if ((i_Params_Get_Supplier_By_Where_InList.END_ROW == null) || (i_Params_Get_Supplier_By_Where_InList.END_ROW == 0)) { i_Params_Get_Supplier_By_Where_InList.END_ROW = 1000000; }
oParams_Get_Supplier_By_Where_InList_SP.OWNER_ID = i_Params_Get_Supplier_By_Where_InList.OWNER_ID;
oParams_Get_Supplier_By_Where_InList_SP.SUPPLIER_NAME = i_Params_Get_Supplier_By_Where_InList.SUPPLIER_NAME;
oParams_Get_Supplier_By_Where_InList_SP.SUPPLIER_PH_NB = i_Params_Get_Supplier_By_Where_InList.SUPPLIER_PH_NB;
oParams_Get_Supplier_By_Where_InList_SP.SUPPLIER_MAIL = i_Params_Get_Supplier_By_Where_InList.SUPPLIER_MAIL;
if ( i_Params_Get_Supplier_By_Where_InList.BLOODTYPE_ID_LIST == null)
{
i_Params_Get_Supplier_By_Where_InList.BLOODTYPE_ID_LIST = new List<Int32?>();
}
oParams_Get_Supplier_By_Where_InList_SP.BLOODTYPE_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Supplier_By_Where_InList.BLOODTYPE_ID_LIST);
oParams_Get_Supplier_By_Where_InList_SP.START_ROW = i_Params_Get_Supplier_By_Where_InList.START_ROW;
oParams_Get_Supplier_By_Where_InList_SP.END_ROW = i_Params_Get_Supplier_By_Where_InList.END_ROW;
oParams_Get_Supplier_By_Where_InList_SP.TOTAL_COUNT = i_Params_Get_Supplier_By_Where_InList.TOTAL_COUNT;
List<DALC.Supplier> oList_DBEntries = _AppContext.Get_Supplier_By_Where_InList_Adv(i_Params_Get_Supplier_By_Where_InList.SUPPLIER_NAME,i_Params_Get_Supplier_By_Where_InList.SUPPLIER_PH_NB,i_Params_Get_Supplier_By_Where_InList.SUPPLIER_MAIL,i_Params_Get_Supplier_By_Where_InList.BLOODTYPE_ID_LIST,i_Params_Get_Supplier_By_Where_InList.OWNER_ID,i_Params_Get_Supplier_By_Where_InList.START_ROW,i_Params_Get_Supplier_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier = new Supplier();
oTools.CopyPropValues(oDBEntry, oSupplier);
oSupplier.My_Bloodtype = new Bloodtype();
oTools.CopyPropValues(oDBEntry.My_Bloodtype, oSupplier.My_Bloodtype);
oList.Add(oSupplier);
}
}
i_Params_Get_Supplier_By_Where_InList.TOTAL_COUNT = oParams_Get_Supplier_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Supplier_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_By_Where_InList_Adv");}
return oList;
}
public List<Supplier> Get_Supplier_By_Criteria_InList_Adv_V2(Params_Get_Supplier_By_Criteria_InList_V2 i_Params_Get_Supplier_By_Criteria_InList_V2)
{
List<Supplier> oList = new List<Supplier>();
Supplier oSupplier = new Supplier();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Supplier_By_Criteria_InList_SP_V2 oParams_Get_Supplier_By_Criteria_InList_SP_V2 = new Params_Get_Supplier_By_Criteria_InList_SP_V2();
Params_Get_Bloodtype_By_BLOODTYPE_ID oParams_Get_Bloodtype_By_BLOODTYPE_ID = new Params_Get_Bloodtype_By_BLOODTYPE_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_By_Criteria_InList_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_By_Criteria_InList_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_By_Criteria_InList_V2));}
#region Body Section.
if ((i_Params_Get_Supplier_By_Criteria_InList_V2.OWNER_ID == null) || (i_Params_Get_Supplier_By_Criteria_InList_V2.OWNER_ID == 0)) { i_Params_Get_Supplier_By_Criteria_InList_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Supplier_By_Criteria_InList_V2.START_ROW == null) { i_Params_Get_Supplier_By_Criteria_InList_V2.START_ROW = 0; }
if ((i_Params_Get_Supplier_By_Criteria_InList_V2.END_ROW == null) || (i_Params_Get_Supplier_By_Criteria_InList_V2.END_ROW == 0)) { i_Params_Get_Supplier_By_Criteria_InList_V2.END_ROW = 1000000; }
oParams_Get_Supplier_By_Criteria_InList_SP_V2.OWNER_ID = i_Params_Get_Supplier_By_Criteria_InList_V2.OWNER_ID;
oParams_Get_Supplier_By_Criteria_InList_SP_V2.SUPPLIER_NAME = i_Params_Get_Supplier_By_Criteria_InList_V2.SUPPLIER_NAME;
oParams_Get_Supplier_By_Criteria_InList_SP_V2.SUPPLIER_PH_NB = i_Params_Get_Supplier_By_Criteria_InList_V2.SUPPLIER_PH_NB;
oParams_Get_Supplier_By_Criteria_InList_SP_V2.SUPPLIER_MAIL = i_Params_Get_Supplier_By_Criteria_InList_V2.SUPPLIER_MAIL;
oParams_Get_Supplier_By_Criteria_InList_SP_V2.SUPPLIER_DOB = i_Params_Get_Supplier_By_Criteria_InList_V2.SUPPLIER_DOB;
if ( i_Params_Get_Supplier_By_Criteria_InList_V2.BLOODTYPE_ID_LIST == null)
{
i_Params_Get_Supplier_By_Criteria_InList_V2.BLOODTYPE_ID_LIST = new List<Int32?>();
}
oParams_Get_Supplier_By_Criteria_InList_SP_V2.BLOODTYPE_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Supplier_By_Criteria_InList_V2.BLOODTYPE_ID_LIST);
oParams_Get_Supplier_By_Criteria_InList_SP_V2.START_ROW = i_Params_Get_Supplier_By_Criteria_InList_V2.START_ROW;
oParams_Get_Supplier_By_Criteria_InList_SP_V2.END_ROW = i_Params_Get_Supplier_By_Criteria_InList_V2.END_ROW;
oParams_Get_Supplier_By_Criteria_InList_SP_V2.TOTAL_COUNT = i_Params_Get_Supplier_By_Criteria_InList_V2.TOTAL_COUNT;
List<DALC.Supplier> oList_DBEntries = _AppContext.Get_Supplier_By_Criteria_InList_Adv_V2(i_Params_Get_Supplier_By_Criteria_InList_V2.SUPPLIER_NAME,i_Params_Get_Supplier_By_Criteria_InList_V2.SUPPLIER_PH_NB,i_Params_Get_Supplier_By_Criteria_InList_V2.SUPPLIER_MAIL,i_Params_Get_Supplier_By_Criteria_InList_V2.SUPPLIER_DOB,i_Params_Get_Supplier_By_Criteria_InList_V2.BLOODTYPE_ID_LIST,i_Params_Get_Supplier_By_Criteria_InList_V2.OWNER_ID,i_Params_Get_Supplier_By_Criteria_InList_V2.START_ROW,i_Params_Get_Supplier_By_Criteria_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier = new Supplier();
oTools.CopyPropValues(oDBEntry, oSupplier);
oSupplier.My_Bloodtype = new Bloodtype();
oTools.CopyPropValues(oDBEntry.My_Bloodtype, oSupplier.My_Bloodtype);
oList.Add(oSupplier);
}
}
i_Params_Get_Supplier_By_Criteria_InList_V2.TOTAL_COUNT = oParams_Get_Supplier_By_Criteria_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Supplier_By_Criteria_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_By_Criteria_InList_Adv_V2");}
return oList;
}
public List<Supplier> Get_Supplier_By_Where_InList_Adv_V2(Params_Get_Supplier_By_Where_InList_V2 i_Params_Get_Supplier_By_Where_InList_V2)
{
List<Supplier> oList = new List<Supplier>();
Supplier oSupplier = new Supplier();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Supplier_By_Where_InList_SP_V2 oParams_Get_Supplier_By_Where_InList_SP_V2 = new Params_Get_Supplier_By_Where_InList_SP_V2();
Params_Get_Bloodtype_By_BLOODTYPE_ID oParams_Get_Bloodtype_By_BLOODTYPE_ID = new Params_Get_Bloodtype_By_BLOODTYPE_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_By_Where_InList_Adv_V2");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_By_Where_InList_Adv_V2",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_By_Where_InList_V2));}
#region Body Section.
if ((i_Params_Get_Supplier_By_Where_InList_V2.OWNER_ID == null) || (i_Params_Get_Supplier_By_Where_InList_V2.OWNER_ID == 0)) { i_Params_Get_Supplier_By_Where_InList_V2.OWNER_ID = this.OwnerID; }
if (i_Params_Get_Supplier_By_Where_InList_V2.START_ROW == null) { i_Params_Get_Supplier_By_Where_InList_V2.START_ROW = 0; }
if ((i_Params_Get_Supplier_By_Where_InList_V2.END_ROW == null) || (i_Params_Get_Supplier_By_Where_InList_V2.END_ROW == 0)) { i_Params_Get_Supplier_By_Where_InList_V2.END_ROW = 1000000; }
oParams_Get_Supplier_By_Where_InList_SP_V2.OWNER_ID = i_Params_Get_Supplier_By_Where_InList_V2.OWNER_ID;
oParams_Get_Supplier_By_Where_InList_SP_V2.SUPPLIER_NAME = i_Params_Get_Supplier_By_Where_InList_V2.SUPPLIER_NAME;
oParams_Get_Supplier_By_Where_InList_SP_V2.SUPPLIER_PH_NB = i_Params_Get_Supplier_By_Where_InList_V2.SUPPLIER_PH_NB;
oParams_Get_Supplier_By_Where_InList_SP_V2.SUPPLIER_MAIL = i_Params_Get_Supplier_By_Where_InList_V2.SUPPLIER_MAIL;
oParams_Get_Supplier_By_Where_InList_SP_V2.SUPPLIER_DOB = i_Params_Get_Supplier_By_Where_InList_V2.SUPPLIER_DOB;
if ( i_Params_Get_Supplier_By_Where_InList_V2.BLOODTYPE_ID_LIST == null)
{
i_Params_Get_Supplier_By_Where_InList_V2.BLOODTYPE_ID_LIST = new List<Int32?>();
}
oParams_Get_Supplier_By_Where_InList_SP_V2.BLOODTYPE_ID_LIST = oTools.Convert_List_To_Comma_Separated<Int32?>(i_Params_Get_Supplier_By_Where_InList_V2.BLOODTYPE_ID_LIST);
oParams_Get_Supplier_By_Where_InList_SP_V2.START_ROW = i_Params_Get_Supplier_By_Where_InList_V2.START_ROW;
oParams_Get_Supplier_By_Where_InList_SP_V2.END_ROW = i_Params_Get_Supplier_By_Where_InList_V2.END_ROW;
oParams_Get_Supplier_By_Where_InList_SP_V2.TOTAL_COUNT = i_Params_Get_Supplier_By_Where_InList_V2.TOTAL_COUNT;
List<DALC.Supplier> oList_DBEntries = _AppContext.Get_Supplier_By_Where_InList_Adv_V2(i_Params_Get_Supplier_By_Where_InList_V2.SUPPLIER_NAME,i_Params_Get_Supplier_By_Where_InList_V2.SUPPLIER_PH_NB,i_Params_Get_Supplier_By_Where_InList_V2.SUPPLIER_MAIL,i_Params_Get_Supplier_By_Where_InList_V2.SUPPLIER_DOB,i_Params_Get_Supplier_By_Where_InList_V2.BLOODTYPE_ID_LIST,i_Params_Get_Supplier_By_Where_InList_V2.OWNER_ID,i_Params_Get_Supplier_By_Where_InList_V2.START_ROW,i_Params_Get_Supplier_By_Where_InList_V2.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier = new Supplier();
oTools.CopyPropValues(oDBEntry, oSupplier);
oSupplier.My_Bloodtype = new Bloodtype();
oTools.CopyPropValues(oDBEntry.My_Bloodtype, oSupplier.My_Bloodtype);
oList.Add(oSupplier);
}
}
i_Params_Get_Supplier_By_Where_InList_V2.TOTAL_COUNT = oParams_Get_Supplier_By_Where_InList_SP_V2.TOTAL_COUNT;
i_Params_Get_Supplier_By_Where_InList_V2.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_By_Where_InList_Adv_V2");}
return oList;
}
public List<Supplier_fees> Get_Supplier_fees_By_Criteria_InList_Adv(Params_Get_Supplier_fees_By_Criteria_InList i_Params_Get_Supplier_fees_By_Criteria_InList)
{
List<Supplier_fees> oList = new List<Supplier_fees>();
Supplier_fees oSupplier_fees = new Supplier_fees();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Supplier_fees_By_Criteria_InList_SP oParams_Get_Supplier_fees_By_Criteria_InList_SP = new Params_Get_Supplier_fees_By_Criteria_InList_SP();
Params_Get_Supplier_By_SUPPLIER_ID oParams_Get_Supplier_By_SUPPLIER_ID = new Params_Get_Supplier_By_SUPPLIER_ID();
Params_Get_Currency_By_CURRENCY_ID oParams_Get_Currency_By_CURRENCY_ID = new Params_Get_Currency_By_CURRENCY_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_fees_By_Criteria_InList_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_fees_By_Criteria_InList_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_fees_By_Criteria_InList));}
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
List<DALC.Supplier_fees> oList_DBEntries = _AppContext.Get_Supplier_fees_By_Criteria_InList_Adv(i_Params_Get_Supplier_fees_By_Criteria_InList.SUPPLIER_FEES_DESCRIPTION,i_Params_Get_Supplier_fees_By_Criteria_InList.SUPPLIER_ID_LIST,i_Params_Get_Supplier_fees_By_Criteria_InList.CURRENCY_ID_LIST,i_Params_Get_Supplier_fees_By_Criteria_InList.OWNER_ID,i_Params_Get_Supplier_fees_By_Criteria_InList.START_ROW,i_Params_Get_Supplier_fees_By_Criteria_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier_fees = new Supplier_fees();
oTools.CopyPropValues(oDBEntry, oSupplier_fees);
oSupplier_fees.My_Supplier = new Supplier();
oTools.CopyPropValues(oDBEntry.My_Supplier, oSupplier_fees.My_Supplier);
oSupplier_fees.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oSupplier_fees.My_Currency);
oList.Add(oSupplier_fees);
}
}
i_Params_Get_Supplier_fees_By_Criteria_InList.TOTAL_COUNT = oParams_Get_Supplier_fees_By_Criteria_InList_SP.TOTAL_COUNT;
i_Params_Get_Supplier_fees_By_Criteria_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_fees_By_Criteria_InList_Adv");}
return oList;
}
public List<Supplier_fees> Get_Supplier_fees_By_Where_InList_Adv(Params_Get_Supplier_fees_By_Where_InList i_Params_Get_Supplier_fees_By_Where_InList)
{
List<Supplier_fees> oList = new List<Supplier_fees>();
Supplier_fees oSupplier_fees = new Supplier_fees();
long? tmp_TOTAL_COUNT = 0; 
Params_Get_Supplier_fees_By_Where_InList_SP oParams_Get_Supplier_fees_By_Where_InList_SP = new Params_Get_Supplier_fees_By_Where_InList_SP();
Params_Get_Supplier_By_SUPPLIER_ID oParams_Get_Supplier_By_SUPPLIER_ID = new Params_Get_Supplier_By_SUPPLIER_ID();
Params_Get_Currency_By_CURRENCY_ID oParams_Get_Currency_By_CURRENCY_ID = new Params_Get_Currency_By_CURRENCY_ID();
if (OnPreEvent_General != null){OnPreEvent_General("Get_Supplier_fees_By_Where_InList_Adv");}
if (OnPreEvent_General_Adv != null){OnPreEvent_General_Adv("Get_Supplier_fees_By_Where_InList_Adv",Newtonsoft.Json.JsonConvert.SerializeObject(i_Params_Get_Supplier_fees_By_Where_InList));}
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
List<DALC.Supplier_fees> oList_DBEntries = _AppContext.Get_Supplier_fees_By_Where_InList_Adv(i_Params_Get_Supplier_fees_By_Where_InList.SUPPLIER_FEES_DESCRIPTION,i_Params_Get_Supplier_fees_By_Where_InList.SUPPLIER_ID_LIST,i_Params_Get_Supplier_fees_By_Where_InList.CURRENCY_ID_LIST,i_Params_Get_Supplier_fees_By_Where_InList.OWNER_ID,i_Params_Get_Supplier_fees_By_Where_InList.START_ROW,i_Params_Get_Supplier_fees_By_Where_InList.END_ROW,ref tmp_TOTAL_COUNT);
if (oList_DBEntries != null)
{
foreach (var oDBEntry in oList_DBEntries)
{
oSupplier_fees = new Supplier_fees();
oTools.CopyPropValues(oDBEntry, oSupplier_fees);
oSupplier_fees.My_Supplier = new Supplier();
oTools.CopyPropValues(oDBEntry.My_Supplier, oSupplier_fees.My_Supplier);
oSupplier_fees.My_Currency = new Currency();
oTools.CopyPropValues(oDBEntry.My_Currency, oSupplier_fees.My_Currency);
oList.Add(oSupplier_fees);
}
}
i_Params_Get_Supplier_fees_By_Where_InList.TOTAL_COUNT = oParams_Get_Supplier_fees_By_Where_InList_SP.TOTAL_COUNT;
i_Params_Get_Supplier_fees_By_Where_InList.TOTAL_COUNT = tmp_TOTAL_COUNT;
#endregion
if (OnPostEvent_General != null){OnPostEvent_General("Get_Supplier_fees_By_Where_InList_Adv");}
return oList;
}
}
}
