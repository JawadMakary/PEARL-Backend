using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Dynamic;
namespace DALC
{
public partial class MSSQL_DALC : IDALC
{
public Address Get_Address_By_ADDRESS_ID ( long? ADDRESS_ID)
{
Address o = new Address();
dynamic p = new ExpandoObject();
p.ADDRESS_ID = ADDRESS_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_ADDRESS_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Bloodtype Get_Bloodtype_By_BLOODTYPE_ID ( Int32? BLOODTYPE_ID)
{
Bloodtype o = new Bloodtype();
dynamic p = new ExpandoObject();
p.BLOODTYPE_ID = BLOODTYPE_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_BLOODTYPE_BY_BLOODTYPE_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Client Get_Client_By_CLIENT_ID ( Int32? CLIENT_ID)
{
Client o = new Client();
dynamic p = new ExpandoObject();
p.CLIENT_ID = CLIENT_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_CLIENT_BY_CLIENT_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Client_fees Get_Client_fees_By_CLIENT_FEES_ID ( Int32? CLIENT_FEES_ID)
{
Client_fees o = new Client_fees();
dynamic p = new ExpandoObject();
p.CLIENT_FEES_ID = CLIENT_FEES_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_CLIENT_FEES_BY_CLIENT_FEES_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Contact Get_Contact_By_CONTACT_ID ( Int32? CONTACT_ID)
{
Contact o = new Contact();
dynamic p = new ExpandoObject();
p.CONTACT_ID = CONTACT_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_CONTACT_BY_CONTACT_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Currency Get_Currency_By_CURRENCY_ID ( Int32? CURRENCY_ID)
{
Currency o = new Currency();
dynamic p = new ExpandoObject();
p.CURRENCY_ID = CURRENCY_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_CURRENCY_BY_CURRENCY_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Fees Get_Fees_By_FEES_ID ( Int32? FEES_ID)
{
Fees o = new Fees();
dynamic p = new ExpandoObject();
p.FEES_ID = FEES_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_FEES_BY_FEES_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Loc_l1 Get_Loc_l1_By_LOC_L1_ID ( long? LOC_L1_ID)
{
Loc_l1 o = new Loc_l1();
dynamic p = new ExpandoObject();
p.LOC_L1_ID = LOC_L1_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_LOC_L1_BY_LOC_L1_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Loc_l2 Get_Loc_l2_By_LOC_L2_ID ( long? LOC_L2_ID)
{
Loc_l2 o = new Loc_l2();
dynamic p = new ExpandoObject();
p.LOC_L2_ID = LOC_L2_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_LOC_L2_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Loc_l3 Get_Loc_l3_By_LOC_L3_ID ( long? LOC_L3_ID)
{
Loc_l3 o = new Loc_l3();
dynamic p = new ExpandoObject();
p.LOC_L3_ID = LOC_L3_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_LOC_L3_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Loc_l4 Get_Loc_l4_By_LOC_L4_ID ( long? LOC_L4_ID)
{
Loc_l4 o = new Loc_l4();
dynamic p = new ExpandoObject();
p.LOC_L4_ID = LOC_L4_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_LOC_L4_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Method_run Get_Method_run_By_METHOD_RUN_ID ( long? METHOD_RUN_ID)
{
Method_run o = new Method_run();
dynamic p = new ExpandoObject();
p.METHOD_RUN_ID = METHOD_RUN_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_METHOD_RUN_BY_METHOD_RUN_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Owner Get_Owner_By_OWNER_ID ( Int32? OWNER_ID)
{
Owner o = new Owner();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_OWNER_BY_OWNER_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Package Get_Package_By_PACKAGE_ID ( Int32? PACKAGE_ID)
{
Package o = new Package();
dynamic p = new ExpandoObject();
p.PACKAGE_ID = PACKAGE_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_PACKAGE_BY_PACKAGE_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Person Get_Person_By_PERSON_ID ( long? PERSON_ID)
{
Person o = new Person();
dynamic p = new ExpandoObject();
p.PERSON_ID = PERSON_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_PERSON_BY_PERSON_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Registered_staff_expense Get_Registered_staff_expense_By_REGISTERED_STAFF_EXPENSE_ID ( Int32? REGISTERED_STAFF_EXPENSE_ID)
{
Registered_staff_expense o = new Registered_staff_expense();
dynamic p = new ExpandoObject();
p.REGISTERED_STAFF_EXPENSE_ID = REGISTERED_STAFF_EXPENSE_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_REGISTERED_STAFF_EXPENSE_BY_REGISTERED_STAFF_EXPENSE_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Registered_supplier_expense Get_Registered_supplier_expense_By_REGISTERED_SUPPLIER_EXPENSE_ID ( Int32? REGISTERED_SUPPLIER_EXPENSE_ID)
{
Registered_supplier_expense o = new Registered_supplier_expense();
dynamic p = new ExpandoObject();
p.REGISTERED_SUPPLIER_EXPENSE_ID = REGISTERED_SUPPLIER_EXPENSE_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_REGISTERED_SUPPLIER_EXPENSE_BY_REGISTERED_SUPPLIER_EXPENSE_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Registration Get_Registration_By_REGISTRATION_ID ( Int32? REGISTRATION_ID)
{
Registration o = new Registration();
dynamic p = new ExpandoObject();
p.REGISTRATION_ID = REGISTRATION_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_REGISTRATION_BY_REGISTRATION_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Session Get_Session_By_SESSION_ID ( Int32? SESSION_ID)
{
Session o = new Session();
dynamic p = new ExpandoObject();
p.SESSION_ID = SESSION_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_SESSION_BY_SESSION_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Staff Get_Staff_By_STAFF_ID ( Int32? STAFF_ID)
{
Staff o = new Staff();
dynamic p = new ExpandoObject();
p.STAFF_ID = STAFF_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_STAFF_BY_STAFF_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Staff_fees Get_Staff_fees_By_STAFF_FEES_ID ( Int32? STAFF_FEES_ID)
{
Staff_fees o = new Staff_fees();
dynamic p = new ExpandoObject();
p.STAFF_FEES_ID = STAFF_FEES_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_STAFF_FEES_BY_STAFF_FEES_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Supplier Get_Supplier_By_SUPPLIER_ID ( Int32? SUPPLIER_ID)
{
Supplier o = new Supplier();
dynamic p = new ExpandoObject();
p.SUPPLIER_ID = SUPPLIER_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_SUPPLIER_BY_SUPPLIER_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Supplier_fees Get_Supplier_fees_By_SUPPLIER_FEES_ID ( Int32? SUPPLIER_FEES_ID)
{
Supplier_fees o = new Supplier_fees();
dynamic p = new ExpandoObject();
p.SUPPLIER_FEES_ID = SUPPLIER_FEES_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_SUPPLIER_FEES_BY_SUPPLIER_FEES_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public User Get_User_By_USER_ID ( long? USER_ID)
{
User o = new User();
dynamic p = new ExpandoObject();
p.USER_ID = USER_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_USER_BY_USER_ID", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Address Get_Address_By_ADDRESS_ID_Adv ( long? ADDRESS_ID)
{
Address o = new Address();
dynamic p = new ExpandoObject();
p.ADDRESS_ID = ADDRESS_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_ADDRESS_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(R["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(R["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(R["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(R["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(R["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(R["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(R["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(R["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(R["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(R["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(R["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(R["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(R["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(R["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(R["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(R["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(R["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(R["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(R["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(R["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(R["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(R["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(R["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(R["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(R["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(R["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(R["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(R["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(R["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(R["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(R["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(R["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(R["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(R["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(R["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(R["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(R["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(R["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(R["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(R["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(R["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(R["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(R["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(R["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(R["T_LOC_L4_OWNER_ID"]);
}
return o;
}
public Bloodtype Get_Bloodtype_By_BLOODTYPE_ID_Adv ( Int32? BLOODTYPE_ID)
{
Bloodtype o = new Bloodtype();
dynamic p = new ExpandoObject();
p.BLOODTYPE_ID = BLOODTYPE_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_BLOODTYPE_BY_BLOODTYPE_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Client Get_Client_By_CLIENT_ID_Adv ( Int32? CLIENT_ID)
{
Client o = new Client();
dynamic p = new ExpandoObject();
p.CLIENT_ID = CLIENT_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_CLIENT_BY_CLIENT_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Bloodtype = new Bloodtype();
o.My_Bloodtype.BLOODTYPE_ID = GV<Int32>(R["T_BLOODTYPE_BLOODTYPE_ID"]);o.My_Bloodtype.BLOODTYPE_SYMBOL = GV<String>(R["T_BLOODTYPE_BLOODTYPE_SYMBOL"]);o.My_Bloodtype.ENTRY_USER_ID = GV<Int64>(R["T_BLOODTYPE_ENTRY_USER_ID"]);o.My_Bloodtype.ENTRY_DATE = GV<String>(R["T_BLOODTYPE_ENTRY_DATE"]);o.My_Bloodtype.OWNER_ID = GV<Int32>(R["T_BLOODTYPE_OWNER_ID"]);
}
return o;
}
public Client_fees Get_Client_fees_By_CLIENT_FEES_ID_Adv ( Int32? CLIENT_FEES_ID)
{
Client_fees o = new Client_fees();
dynamic p = new ExpandoObject();
p.CLIENT_FEES_ID = CLIENT_FEES_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_CLIENT_FEES_BY_CLIENT_FEES_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Client = new Client();
o.My_Client.CLIENT_ID = GV<Int32>(R["T_CLIENT_CLIENT_ID"]);o.My_Client.CLIENT_NAME = GV<String>(R["T_CLIENT_CLIENT_NAME"]);o.My_Client.CLIENT_PH_NB = GV<String>(R["T_CLIENT_CLIENT_PH_NB"]);o.My_Client.CLIENT_MAIL = GV<String>(R["T_CLIENT_CLIENT_MAIL"]);o.My_Client.CLIENT_DOB = GV<String>(R["T_CLIENT_CLIENT_DOB"]);o.My_Client.BLOODTYPE_ID = GV<Int32>(R["T_CLIENT_BLOODTYPE_ID"]);o.My_Client.ENTRY_USER_ID = GV<Int64>(R["T_CLIENT_ENTRY_USER_ID"]);o.My_Client.ENTRY_DATE = GV<String>(R["T_CLIENT_ENTRY_DATE"]);o.My_Client.OWNER_ID = GV<Int32>(R["T_CLIENT_OWNER_ID"]);o.My_Client.CLIENT_GENDER = GV<String>(R["T_CLIENT_CLIENT_GENDER"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(R["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(R["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(R["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(R["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(R["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(R["T_CURRENCY_OWNER_ID"]);
o.My_Package = new Package();
o.My_Package.PACKAGE_ID = GV<Int32>(R["T_PACKAGE_PACKAGE_ID"]);o.My_Package.PACKAGE_NAME = GV<String>(R["T_PACKAGE_PACKAGE_NAME"]);o.My_Package.PACKAGE_PRICE = GV<Int32>(R["T_PACKAGE_PACKAGE_PRICE"]);o.My_Package.CURRENCY_ID = GV<Int32>(R["T_PACKAGE_CURRENCY_ID"]);o.My_Package.ENTRY_USER_ID = GV<Int64>(R["T_PACKAGE_ENTRY_USER_ID"]);o.My_Package.ENTRY_DATE = GV<String>(R["T_PACKAGE_ENTRY_DATE"]);o.My_Package.OWNER_ID = GV<Int32>(R["T_PACKAGE_OWNER_ID"]);o.My_Package.PACKAGE_SESSIONS_NB = GV<Int32>(R["T_PACKAGE_PACKAGE_SESSIONS_NB"]);o.My_Package.PACKAGE_TYPE = GV<String>(R["T_PACKAGE_PACKAGE_TYPE"]);o.My_Package.PACKAGE_ENDING_DATE = GV<String>(R["T_PACKAGE_PACKAGE_ENDING_DATE"]);o.My_Package.PACKAGE_TIMELINE = GV<String>(R["T_PACKAGE_PACKAGE_TIMELINE"]);o.My_Package.PACKAGE_STARTING_DATE = GV<String>(R["T_PACKAGE_PACKAGE_STARTING_DATE"]);o.My_Package.PACKAGE_NB_OF_MONTH = GV<Int32>(R["T_PACKAGE_PACKAGE_NB_OF_MONTH"]);
o.My_Registration = new Registration();
o.My_Registration.REGISTRATION_ID = GV<Int32>(R["T_REGISTRATION_REGISTRATION_ID"]);o.My_Registration.CLIENT_ID = GV<Int32>(R["T_REGISTRATION_CLIENT_ID"]);o.My_Registration.REGISTRATION_DATE = GV<String>(R["T_REGISTRATION_REGISTRATION_DATE"]);o.My_Registration.PACKAGE_ID = GV<Int32>(R["T_REGISTRATION_PACKAGE_ID"]);o.My_Registration.REGISTRATION_DISCOUNT = GV<Int32>(R["T_REGISTRATION_REGISTRATION_DISCOUNT"]);o.My_Registration.REGISTRATION_TOTAL_PRICE = GV<Int32>(R["T_REGISTRATION_REGISTRATION_TOTAL_PRICE"]);o.My_Registration.CURRENCY_ID = GV<Int32>(R["T_REGISTRATION_CURRENCY_ID"]);o.My_Registration.REGISTRATION_DESCRIPTION = GV<String>(R["T_REGISTRATION_REGISTRATION_DESCRIPTION"]);o.My_Registration.ENTRY_USER_ID = GV<Int64>(R["T_REGISTRATION_ENTRY_USER_ID"]);o.My_Registration.ENTRY_DATE = GV<String>(R["T_REGISTRATION_ENTRY_DATE"]);o.My_Registration.OWNER_ID = GV<Int32>(R["T_REGISTRATION_OWNER_ID"]);
}
return o;
}
public Contact Get_Contact_By_CONTACT_ID_Adv ( Int32? CONTACT_ID)
{
Contact o = new Contact();
dynamic p = new ExpandoObject();
p.CONTACT_ID = CONTACT_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_CONTACT_BY_CONTACT_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(R["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(R["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(R["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(R["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(R["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(R["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(R["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(R["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(R["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(R["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(R["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(R["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(R["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(R["T_PERSON_ENTRY_DATE"]);
}
return o;
}
public Currency Get_Currency_By_CURRENCY_ID_Adv ( Int32? CURRENCY_ID)
{
Currency o = new Currency();
dynamic p = new ExpandoObject();
p.CURRENCY_ID = CURRENCY_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_CURRENCY_BY_CURRENCY_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Fees Get_Fees_By_FEES_ID_Adv ( Int32? FEES_ID)
{
Fees o = new Fees();
dynamic p = new ExpandoObject();
p.FEES_ID = FEES_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_FEES_BY_FEES_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(R["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(R["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(R["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(R["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(R["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(R["T_CURRENCY_OWNER_ID"]);
}
return o;
}
public Loc_l1 Get_Loc_l1_By_LOC_L1_ID_Adv ( long? LOC_L1_ID)
{
Loc_l1 o = new Loc_l1();
dynamic p = new ExpandoObject();
p.LOC_L1_ID = LOC_L1_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_LOC_L1_BY_LOC_L1_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Loc_l2 Get_Loc_l2_By_LOC_L2_ID_Adv ( long? LOC_L2_ID)
{
Loc_l2 o = new Loc_l2();
dynamic p = new ExpandoObject();
p.LOC_L2_ID = LOC_L2_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_LOC_L2_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(R["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(R["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(R["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(R["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(R["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(R["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(R["T_LOC_L1_OWNER_ID"]);
}
return o;
}
public Loc_l3 Get_Loc_l3_By_LOC_L3_ID_Adv ( long? LOC_L3_ID)
{
Loc_l3 o = new Loc_l3();
dynamic p = new ExpandoObject();
p.LOC_L3_ID = LOC_L3_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_LOC_L3_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(R["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(R["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(R["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(R["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(R["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(R["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(R["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(R["T_LOC_L2_OWNER_ID"]);
}
return o;
}
public Loc_l4 Get_Loc_l4_By_LOC_L4_ID_Adv ( long? LOC_L4_ID)
{
Loc_l4 o = new Loc_l4();
dynamic p = new ExpandoObject();
p.LOC_L4_ID = LOC_L4_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_LOC_L4_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(R["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(R["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(R["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(R["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(R["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(R["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(R["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(R["T_LOC_L3_OWNER_ID"]);
}
return o;
}
public Method_run Get_Method_run_By_METHOD_RUN_ID_Adv ( long? METHOD_RUN_ID)
{
Method_run o = new Method_run();
dynamic p = new ExpandoObject();
p.METHOD_RUN_ID = METHOD_RUN_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_METHOD_RUN_BY_METHOD_RUN_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Package Get_Package_By_PACKAGE_ID_Adv ( Int32? PACKAGE_ID)
{
Package o = new Package();
dynamic p = new ExpandoObject();
p.PACKAGE_ID = PACKAGE_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_PACKAGE_BY_PACKAGE_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(R["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(R["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(R["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(R["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(R["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(R["T_CURRENCY_OWNER_ID"]);
}
return o;
}
public Person Get_Person_By_PERSON_ID_Adv ( long? PERSON_ID)
{
Person o = new Person();
dynamic p = new ExpandoObject();
p.PERSON_ID = PERSON_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_PERSON_BY_PERSON_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public Registered_staff_expense Get_Registered_staff_expense_By_REGISTERED_STAFF_EXPENSE_ID_Adv ( Int32? REGISTERED_STAFF_EXPENSE_ID)
{
Registered_staff_expense o = new Registered_staff_expense();
dynamic p = new ExpandoObject();
p.REGISTERED_STAFF_EXPENSE_ID = REGISTERED_STAFF_EXPENSE_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_REGISTERED_STAFF_EXPENSE_BY_REGISTERED_STAFF_EXPENSE_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Staff = new Staff();
o.My_Staff.STAFF_ID = GV<Int32>(R["T_STAFF_STAFF_ID"]);o.My_Staff.STAFF_NAME = GV<String>(R["T_STAFF_STAFF_NAME"]);o.My_Staff.STAFF_PH_NB = GV<String>(R["T_STAFF_STAFF_PH_NB"]);o.My_Staff.STAFF_MAIL = GV<String>(R["T_STAFF_STAFF_MAIL"]);o.My_Staff.STAFF_DOB = GV<String>(R["T_STAFF_STAFF_DOB"]);o.My_Staff.BLOODTYPE_ID = GV<Int32>(R["T_STAFF_BLOODTYPE_ID"]);o.My_Staff.ENTRY_USER_ID = GV<Int64>(R["T_STAFF_ENTRY_USER_ID"]);o.My_Staff.ENTRY_DATE = GV<String>(R["T_STAFF_ENTRY_DATE"]);o.My_Staff.OWNER_ID = GV<Int32>(R["T_STAFF_OWNER_ID"]);o.My_Staff.STAFF_GENDER = GV<String>(R["T_STAFF_STAFF_GENDER"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(R["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(R["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(R["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(R["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(R["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(R["T_CURRENCY_OWNER_ID"]);
}
return o;
}
public Registered_supplier_expense Get_Registered_supplier_expense_By_REGISTERED_SUPPLIER_EXPENSE_ID_Adv ( Int32? REGISTERED_SUPPLIER_EXPENSE_ID)
{
Registered_supplier_expense o = new Registered_supplier_expense();
dynamic p = new ExpandoObject();
p.REGISTERED_SUPPLIER_EXPENSE_ID = REGISTERED_SUPPLIER_EXPENSE_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_REGISTERED_SUPPLIER_EXPENSE_BY_REGISTERED_SUPPLIER_EXPENSE_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Supplier = new Supplier();
o.My_Supplier.SUPPLIER_ID = GV<Int32>(R["T_SUPPLIER_SUPPLIER_ID"]);o.My_Supplier.SUPPLIER_NAME = GV<String>(R["T_SUPPLIER_SUPPLIER_NAME"]);o.My_Supplier.SUPPLIER_PH_NB = GV<String>(R["T_SUPPLIER_SUPPLIER_PH_NB"]);o.My_Supplier.SUPPLIER_MAIL = GV<String>(R["T_SUPPLIER_SUPPLIER_MAIL"]);o.My_Supplier.ENTRY_USER_ID = GV<Int64>(R["T_SUPPLIER_ENTRY_USER_ID"]);o.My_Supplier.ENTRY_DATE = GV<String>(R["T_SUPPLIER_ENTRY_DATE"]);o.My_Supplier.OWNER_ID = GV<Int32>(R["T_SUPPLIER_OWNER_ID"]);o.My_Supplier.SUPPLIER_DOB = GV<String>(R["T_SUPPLIER_SUPPLIER_DOB"]);o.My_Supplier.BLOODTYPE_ID = GV<Int32>(R["T_SUPPLIER_BLOODTYPE_ID"]);o.My_Supplier.SUPPLIER_GENDER = GV<String>(R["T_SUPPLIER_SUPPLIER_GENDER"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(R["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(R["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(R["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(R["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(R["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(R["T_CURRENCY_OWNER_ID"]);
}
return o;
}
public Registration Get_Registration_By_REGISTRATION_ID_Adv ( Int32? REGISTRATION_ID)
{
Registration o = new Registration();
dynamic p = new ExpandoObject();
p.REGISTRATION_ID = REGISTRATION_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_REGISTRATION_BY_REGISTRATION_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Client = new Client();
o.My_Client.CLIENT_ID = GV<Int32>(R["T_CLIENT_CLIENT_ID"]);o.My_Client.CLIENT_NAME = GV<String>(R["T_CLIENT_CLIENT_NAME"]);o.My_Client.CLIENT_PH_NB = GV<String>(R["T_CLIENT_CLIENT_PH_NB"]);o.My_Client.CLIENT_MAIL = GV<String>(R["T_CLIENT_CLIENT_MAIL"]);o.My_Client.CLIENT_DOB = GV<String>(R["T_CLIENT_CLIENT_DOB"]);o.My_Client.BLOODTYPE_ID = GV<Int32>(R["T_CLIENT_BLOODTYPE_ID"]);o.My_Client.ENTRY_USER_ID = GV<Int64>(R["T_CLIENT_ENTRY_USER_ID"]);o.My_Client.ENTRY_DATE = GV<String>(R["T_CLIENT_ENTRY_DATE"]);o.My_Client.OWNER_ID = GV<Int32>(R["T_CLIENT_OWNER_ID"]);o.My_Client.CLIENT_GENDER = GV<String>(R["T_CLIENT_CLIENT_GENDER"]);
o.My_Package = new Package();
o.My_Package.PACKAGE_ID = GV<Int32>(R["T_PACKAGE_PACKAGE_ID"]);o.My_Package.PACKAGE_NAME = GV<String>(R["T_PACKAGE_PACKAGE_NAME"]);o.My_Package.PACKAGE_PRICE = GV<Int32>(R["T_PACKAGE_PACKAGE_PRICE"]);o.My_Package.CURRENCY_ID = GV<Int32>(R["T_PACKAGE_CURRENCY_ID"]);o.My_Package.ENTRY_USER_ID = GV<Int64>(R["T_PACKAGE_ENTRY_USER_ID"]);o.My_Package.ENTRY_DATE = GV<String>(R["T_PACKAGE_ENTRY_DATE"]);o.My_Package.OWNER_ID = GV<Int32>(R["T_PACKAGE_OWNER_ID"]);o.My_Package.PACKAGE_SESSIONS_NB = GV<Int32>(R["T_PACKAGE_PACKAGE_SESSIONS_NB"]);o.My_Package.PACKAGE_TYPE = GV<String>(R["T_PACKAGE_PACKAGE_TYPE"]);o.My_Package.PACKAGE_ENDING_DATE = GV<String>(R["T_PACKAGE_PACKAGE_ENDING_DATE"]);o.My_Package.PACKAGE_TIMELINE = GV<String>(R["T_PACKAGE_PACKAGE_TIMELINE"]);o.My_Package.PACKAGE_STARTING_DATE = GV<String>(R["T_PACKAGE_PACKAGE_STARTING_DATE"]);o.My_Package.PACKAGE_NB_OF_MONTH = GV<Int32>(R["T_PACKAGE_PACKAGE_NB_OF_MONTH"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(R["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(R["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(R["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(R["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(R["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(R["T_CURRENCY_OWNER_ID"]);
}
return o;
}
public Session Get_Session_By_SESSION_ID_Adv ( Int32? SESSION_ID)
{
Session o = new Session();
dynamic p = new ExpandoObject();
p.SESSION_ID = SESSION_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_SESSION_BY_SESSION_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Package = new Package();
o.My_Package.PACKAGE_ID = GV<Int32>(R["T_PACKAGE_PACKAGE_ID"]);o.My_Package.PACKAGE_NAME = GV<String>(R["T_PACKAGE_PACKAGE_NAME"]);o.My_Package.PACKAGE_PRICE = GV<Int32>(R["T_PACKAGE_PACKAGE_PRICE"]);o.My_Package.CURRENCY_ID = GV<Int32>(R["T_PACKAGE_CURRENCY_ID"]);o.My_Package.ENTRY_USER_ID = GV<Int64>(R["T_PACKAGE_ENTRY_USER_ID"]);o.My_Package.ENTRY_DATE = GV<String>(R["T_PACKAGE_ENTRY_DATE"]);o.My_Package.OWNER_ID = GV<Int32>(R["T_PACKAGE_OWNER_ID"]);o.My_Package.PACKAGE_SESSIONS_NB = GV<Int32>(R["T_PACKAGE_PACKAGE_SESSIONS_NB"]);o.My_Package.PACKAGE_TYPE = GV<String>(R["T_PACKAGE_PACKAGE_TYPE"]);o.My_Package.PACKAGE_ENDING_DATE = GV<String>(R["T_PACKAGE_PACKAGE_ENDING_DATE"]);o.My_Package.PACKAGE_TIMELINE = GV<String>(R["T_PACKAGE_PACKAGE_TIMELINE"]);o.My_Package.PACKAGE_STARTING_DATE = GV<String>(R["T_PACKAGE_PACKAGE_STARTING_DATE"]);o.My_Package.PACKAGE_NB_OF_MONTH = GV<Int32>(R["T_PACKAGE_PACKAGE_NB_OF_MONTH"]);
o.My_Client_fees = new Client_fees();
o.My_Client_fees.CLIENT_FEES_ID = GV<Int32>(R["T_CLIENT_FEES_CLIENT_FEES_ID"]);o.My_Client_fees.CLIENT_ID = GV<Int32>(R["T_CLIENT_FEES_CLIENT_ID"]);o.My_Client_fees.CLIENT_FEES_DESCRIPTION = GV<String>(R["T_CLIENT_FEES_CLIENT_FEES_DESCRIPTION"]);o.My_Client_fees.ENTRY_USER_ID = GV<Int64>(R["T_CLIENT_FEES_ENTRY_USER_ID"]);o.My_Client_fees.ENTRY_DATE = GV<String>(R["T_CLIENT_FEES_ENTRY_DATE"]);o.My_Client_fees.OWNER_ID = GV<Int32>(R["T_CLIENT_FEES_OWNER_ID"]);o.My_Client_fees.CURRENCY_ID = GV<Int32>(R["T_CLIENT_FEES_CURRENCY_ID"]);o.My_Client_fees.PACKAGE_ID = GV<Int32>(R["T_CLIENT_FEES_PACKAGE_ID"]);o.My_Client_fees.CLIENT_FEES_AMOUNT = GV<Int32>(R["T_CLIENT_FEES_CLIENT_FEES_AMOUNT"]);o.My_Client_fees.REGISTRATION_ID = GV<Int32>(R["T_CLIENT_FEES_REGISTRATION_ID"]);
}
return o;
}
public Staff Get_Staff_By_STAFF_ID_Adv ( Int32? STAFF_ID)
{
Staff o = new Staff();
dynamic p = new ExpandoObject();
p.STAFF_ID = STAFF_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_STAFF_BY_STAFF_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Bloodtype = new Bloodtype();
o.My_Bloodtype.BLOODTYPE_ID = GV<Int32>(R["T_BLOODTYPE_BLOODTYPE_ID"]);o.My_Bloodtype.BLOODTYPE_SYMBOL = GV<String>(R["T_BLOODTYPE_BLOODTYPE_SYMBOL"]);o.My_Bloodtype.ENTRY_USER_ID = GV<Int64>(R["T_BLOODTYPE_ENTRY_USER_ID"]);o.My_Bloodtype.ENTRY_DATE = GV<String>(R["T_BLOODTYPE_ENTRY_DATE"]);o.My_Bloodtype.OWNER_ID = GV<Int32>(R["T_BLOODTYPE_OWNER_ID"]);
}
return o;
}
public Staff_fees Get_Staff_fees_By_STAFF_FEES_ID_Adv ( Int32? STAFF_FEES_ID)
{
Staff_fees o = new Staff_fees();
dynamic p = new ExpandoObject();
p.STAFF_FEES_ID = STAFF_FEES_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_STAFF_FEES_BY_STAFF_FEES_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Staff = new Staff();
o.My_Staff.STAFF_ID = GV<Int32>(R["T_STAFF_STAFF_ID"]);o.My_Staff.STAFF_NAME = GV<String>(R["T_STAFF_STAFF_NAME"]);o.My_Staff.STAFF_PH_NB = GV<String>(R["T_STAFF_STAFF_PH_NB"]);o.My_Staff.STAFF_MAIL = GV<String>(R["T_STAFF_STAFF_MAIL"]);o.My_Staff.STAFF_DOB = GV<String>(R["T_STAFF_STAFF_DOB"]);o.My_Staff.BLOODTYPE_ID = GV<Int32>(R["T_STAFF_BLOODTYPE_ID"]);o.My_Staff.ENTRY_USER_ID = GV<Int64>(R["T_STAFF_ENTRY_USER_ID"]);o.My_Staff.ENTRY_DATE = GV<String>(R["T_STAFF_ENTRY_DATE"]);o.My_Staff.OWNER_ID = GV<Int32>(R["T_STAFF_OWNER_ID"]);o.My_Staff.STAFF_GENDER = GV<String>(R["T_STAFF_STAFF_GENDER"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(R["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(R["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(R["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(R["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(R["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(R["T_CURRENCY_OWNER_ID"]);
o.My_Registered_staff_expense = new Registered_staff_expense();
o.My_Registered_staff_expense.REGISTERED_STAFF_EXPENSE_ID = GV<Int32>(R["T_REGISTERED_STAFF_EXPENSE_REGISTERED_STAFF_EXPENSE_ID"]);o.My_Registered_staff_expense.REGISTERED_STAFF_EXPENSE_DISCOUNT = GV<Int32>(R["T_REGISTERED_STAFF_EXPENSE_REGISTERED_STAFF_EXPENSE_DISCOUNT"]);o.My_Registered_staff_expense.REGISTERED_STAFF_EXPENSE_TOTAL_AMOUNT = GV<Int32>(R["T_REGISTERED_STAFF_EXPENSE_REGISTERED_STAFF_EXPENSE_TOTAL_AMOUNT"]);o.My_Registered_staff_expense.REGISTERED_STAFF_EXPENSE_DESCRIPTION = GV<String>(R["T_REGISTERED_STAFF_EXPENSE_REGISTERED_STAFF_EXPENSE_DESCRIPTION"]);o.My_Registered_staff_expense.STAFF_ID = GV<Int32>(R["T_REGISTERED_STAFF_EXPENSE_STAFF_ID"]);o.My_Registered_staff_expense.CURRENCY_ID = GV<Int32>(R["T_REGISTERED_STAFF_EXPENSE_CURRENCY_ID"]);o.My_Registered_staff_expense.ENTRY_USER_ID = GV<Int64>(R["T_REGISTERED_STAFF_EXPENSE_ENTRY_USER_ID"]);o.My_Registered_staff_expense.ENTRY_DATE = GV<String>(R["T_REGISTERED_STAFF_EXPENSE_ENTRY_DATE"]);o.My_Registered_staff_expense.OWNER_ID = GV<Int32>(R["T_REGISTERED_STAFF_EXPENSE_OWNER_ID"]);
}
return o;
}
public Supplier Get_Supplier_By_SUPPLIER_ID_Adv ( Int32? SUPPLIER_ID)
{
Supplier o = new Supplier();
dynamic p = new ExpandoObject();
p.SUPPLIER_ID = SUPPLIER_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_SUPPLIER_BY_SUPPLIER_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Bloodtype = new Bloodtype();
o.My_Bloodtype.BLOODTYPE_ID = GV<Int32>(R["T_BLOODTYPE_BLOODTYPE_ID"]);o.My_Bloodtype.BLOODTYPE_SYMBOL = GV<String>(R["T_BLOODTYPE_BLOODTYPE_SYMBOL"]);o.My_Bloodtype.ENTRY_USER_ID = GV<Int64>(R["T_BLOODTYPE_ENTRY_USER_ID"]);o.My_Bloodtype.ENTRY_DATE = GV<String>(R["T_BLOODTYPE_ENTRY_DATE"]);o.My_Bloodtype.OWNER_ID = GV<Int32>(R["T_BLOODTYPE_OWNER_ID"]);
}
return o;
}
public Supplier_fees Get_Supplier_fees_By_SUPPLIER_FEES_ID_Adv ( Int32? SUPPLIER_FEES_ID)
{
Supplier_fees o = new Supplier_fees();
dynamic p = new ExpandoObject();
p.SUPPLIER_FEES_ID = SUPPLIER_FEES_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_SUPPLIER_FEES_BY_SUPPLIER_FEES_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
o.My_Supplier = new Supplier();
o.My_Supplier.SUPPLIER_ID = GV<Int32>(R["T_SUPPLIER_SUPPLIER_ID"]);o.My_Supplier.SUPPLIER_NAME = GV<String>(R["T_SUPPLIER_SUPPLIER_NAME"]);o.My_Supplier.SUPPLIER_PH_NB = GV<String>(R["T_SUPPLIER_SUPPLIER_PH_NB"]);o.My_Supplier.SUPPLIER_MAIL = GV<String>(R["T_SUPPLIER_SUPPLIER_MAIL"]);o.My_Supplier.ENTRY_USER_ID = GV<Int64>(R["T_SUPPLIER_ENTRY_USER_ID"]);o.My_Supplier.ENTRY_DATE = GV<String>(R["T_SUPPLIER_ENTRY_DATE"]);o.My_Supplier.OWNER_ID = GV<Int32>(R["T_SUPPLIER_OWNER_ID"]);o.My_Supplier.SUPPLIER_DOB = GV<String>(R["T_SUPPLIER_SUPPLIER_DOB"]);o.My_Supplier.BLOODTYPE_ID = GV<Int32>(R["T_SUPPLIER_BLOODTYPE_ID"]);o.My_Supplier.SUPPLIER_GENDER = GV<String>(R["T_SUPPLIER_SUPPLIER_GENDER"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(R["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(R["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(R["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(R["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(R["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(R["T_CURRENCY_OWNER_ID"]);
o.My_Registered_supplier_expense = new Registered_supplier_expense();
o.My_Registered_supplier_expense.REGISTERED_SUPPLIER_EXPENSE_ID = GV<Int32>(R["T_REGISTERED_SUPPLIER_EXPENSE_REGISTERED_SUPPLIER_EXPENSE_ID"]);o.My_Registered_supplier_expense.REGISTERED_SUPPLIER_EXPENSE_DISCOUNT = GV<Int32>(R["T_REGISTERED_SUPPLIER_EXPENSE_REGISTERED_SUPPLIER_EXPENSE_DISCOUNT"]);o.My_Registered_supplier_expense.REGISTERED_SUPPLIER_EXPENSE_TOTAL_AMOUNT = GV<Int32>(R["T_REGISTERED_SUPPLIER_EXPENSE_REGISTERED_SUPPLIER_EXPENSE_TOTAL_AMOUNT"]);o.My_Registered_supplier_expense.REGISTERED_SUPPLIER_EXPENSE_DESCRIPTION = GV<String>(R["T_REGISTERED_SUPPLIER_EXPENSE_REGISTERED_SUPPLIER_EXPENSE_DESCRIPTION"]);o.My_Registered_supplier_expense.SUPPLIER_ID = GV<Int32>(R["T_REGISTERED_SUPPLIER_EXPENSE_SUPPLIER_ID"]);o.My_Registered_supplier_expense.CURRENCY_ID = GV<Int32>(R["T_REGISTERED_SUPPLIER_EXPENSE_CURRENCY_ID"]);o.My_Registered_supplier_expense.ENTRY_USER_ID = GV<Int64>(R["T_REGISTERED_SUPPLIER_EXPENSE_ENTRY_USER_ID"]);o.My_Registered_supplier_expense.ENTRY_DATE = GV<String>(R["T_REGISTERED_SUPPLIER_EXPENSE_ENTRY_DATE"]);o.My_Registered_supplier_expense.OWNER_ID = GV<Int32>(R["T_REGISTERED_SUPPLIER_EXPENSE_OWNER_ID"]);
}
return o;
}
public User Get_User_By_USER_ID_Adv ( long? USER_ID)
{
User o = new User();
dynamic p = new ExpandoObject();
p.USER_ID = USER_ID;
IEnumerable<IDataRecord> Q = ExecuteSelectQuery("UPG_GET_USER_BY_USER_ID_ADV", p);
var R = Q.FirstOrDefault();
if (R != null){
oTools.CopyPropValues_FromDataRecord(R, o);
}
return o;
}
public List<Address> Get_Address_By_ADDRESS_ID_List ( List<long?> ADDRESS_ID_LIST)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_ID_LIST = string.Join(",", ADDRESS_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_ADDRESS_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Bloodtype> Get_Bloodtype_By_BLOODTYPE_ID_List ( List<Int32?> BLOODTYPE_ID_LIST)
{
List<Bloodtype> oList = new List<Bloodtype>();
dynamic p = new ExpandoObject();
p.BLOODTYPE_ID_LIST = string.Join(",", BLOODTYPE_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BLOODTYPE_BY_BLOODTYPE_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Bloodtype o = new Bloodtype();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Client> Get_Client_By_CLIENT_ID_List ( List<Int32?> CLIENT_ID_LIST)
{
List<Client> oList = new List<Client>();
dynamic p = new ExpandoObject();
p.CLIENT_ID_LIST = string.Join(",", CLIENT_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CLIENT_BY_CLIENT_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Client o = new Client();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Client_fees> Get_Client_fees_By_CLIENT_FEES_ID_List ( List<Int32?> CLIENT_FEES_ID_LIST)
{
List<Client_fees> oList = new List<Client_fees>();
dynamic p = new ExpandoObject();
p.CLIENT_FEES_ID_LIST = string.Join(",", CLIENT_FEES_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CLIENT_FEES_BY_CLIENT_FEES_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Client_fees o = new Client_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Contact> Get_Contact_By_CONTACT_ID_List ( List<Int32?> CONTACT_ID_LIST)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.CONTACT_ID_LIST = string.Join(",", CONTACT_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_CONTACT_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Currency> Get_Currency_By_CURRENCY_ID_List ( List<Int32?> CURRENCY_ID_LIST)
{
List<Currency> oList = new List<Currency>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CURRENCY_BY_CURRENCY_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Currency o = new Currency();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Fees> Get_Fees_By_FEES_ID_List ( List<Int32?> FEES_ID_LIST)
{
List<Fees> oList = new List<Fees>();
dynamic p = new ExpandoObject();
p.FEES_ID_LIST = string.Join(",", FEES_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEES_BY_FEES_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Fees o = new Fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_LOC_L1_ID_List ( List<long?> LOC_L1_ID_LIST)
{
List<Loc_l1> oList = new List<Loc_l1>();
dynamic p = new ExpandoObject();
p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L1_BY_LOC_L1_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Loc_l1 o = new Loc_l1();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L2_ID_List ( List<long?> LOC_L2_ID_LIST)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_LOC_L2_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L3_ID_List ( List<long?> LOC_L3_ID_LIST)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_LOC_L3_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L4_ID_List ( List<long?> LOC_L4_ID_LIST)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.LOC_L4_ID_LIST = string.Join(",", LOC_L4_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_LOC_L4_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Method_run> Get_Method_run_By_METHOD_RUN_ID_List ( List<long?> METHOD_RUN_ID_LIST)
{
List<Method_run> oList = new List<Method_run>();
dynamic p = new ExpandoObject();
p.METHOD_RUN_ID_LIST = string.Join(",", METHOD_RUN_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_METHOD_RUN_BY_METHOD_RUN_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Method_run o = new Method_run();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Owner> Get_Owner_By_OWNER_ID_List ( List<Int32?> OWNER_ID_LIST)
{
List<Owner> oList = new List<Owner>();
dynamic p = new ExpandoObject();
p.OWNER_ID_LIST = string.Join(",", OWNER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OWNER_BY_OWNER_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Owner o = new Owner();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Package> Get_Package_By_PACKAGE_ID_List ( List<Int32?> PACKAGE_ID_LIST)
{
List<Package> oList = new List<Package>();
dynamic p = new ExpandoObject();
p.PACKAGE_ID_LIST = string.Join(",", PACKAGE_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PACKAGE_BY_PACKAGE_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Package o = new Package();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Person> Get_Person_By_PERSON_ID_List ( List<long?> PERSON_ID_LIST)
{
List<Person> oList = new List<Person>();
dynamic p = new ExpandoObject();
p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PERSON_BY_PERSON_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Person o = new Person();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Registered_staff_expense> Get_Registered_staff_expense_By_REGISTERED_STAFF_EXPENSE_ID_List ( List<Int32?> REGISTERED_STAFF_EXPENSE_ID_LIST)
{
List<Registered_staff_expense> oList = new List<Registered_staff_expense>();
dynamic p = new ExpandoObject();
p.REGISTERED_STAFF_EXPENSE_ID_LIST = string.Join(",", REGISTERED_STAFF_EXPENSE_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_REGISTERED_STAFF_EXPENSE_BY_REGISTERED_STAFF_EXPENSE_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Registered_staff_expense o = new Registered_staff_expense();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Registered_supplier_expense> Get_Registered_supplier_expense_By_REGISTERED_SUPPLIER_EXPENSE_ID_List ( List<Int32?> REGISTERED_SUPPLIER_EXPENSE_ID_LIST)
{
List<Registered_supplier_expense> oList = new List<Registered_supplier_expense>();
dynamic p = new ExpandoObject();
p.REGISTERED_SUPPLIER_EXPENSE_ID_LIST = string.Join(",", REGISTERED_SUPPLIER_EXPENSE_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_REGISTERED_SUPPLIER_EXPENSE_BY_REGISTERED_SUPPLIER_EXPENSE_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Registered_supplier_expense o = new Registered_supplier_expense();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Registration> Get_Registration_By_REGISTRATION_ID_List ( List<Int32?> REGISTRATION_ID_LIST)
{
List<Registration> oList = new List<Registration>();
dynamic p = new ExpandoObject();
p.REGISTRATION_ID_LIST = string.Join(",", REGISTRATION_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_REGISTRATION_BY_REGISTRATION_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Registration o = new Registration();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Session> Get_Session_By_SESSION_ID_List ( List<Int32?> SESSION_ID_LIST)
{
List<Session> oList = new List<Session>();
dynamic p = new ExpandoObject();
p.SESSION_ID_LIST = string.Join(",", SESSION_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SESSION_BY_SESSION_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Session o = new Session();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Staff> Get_Staff_By_STAFF_ID_List ( List<Int32?> STAFF_ID_LIST)
{
List<Staff> oList = new List<Staff>();
dynamic p = new ExpandoObject();
p.STAFF_ID_LIST = string.Join(",", STAFF_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_BY_STAFF_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Staff o = new Staff();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Staff_fees> Get_Staff_fees_By_STAFF_FEES_ID_List ( List<Int32?> STAFF_FEES_ID_LIST)
{
List<Staff_fees> oList = new List<Staff_fees>();
dynamic p = new ExpandoObject();
p.STAFF_FEES_ID_LIST = string.Join(",", STAFF_FEES_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_FEES_BY_STAFF_FEES_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Staff_fees o = new Staff_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Supplier> Get_Supplier_By_SUPPLIER_ID_List ( List<Int32?> SUPPLIER_ID_LIST)
{
List<Supplier> oList = new List<Supplier>();
dynamic p = new ExpandoObject();
p.SUPPLIER_ID_LIST = string.Join(",", SUPPLIER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_BY_SUPPLIER_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Supplier o = new Supplier();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Supplier_fees> Get_Supplier_fees_By_SUPPLIER_FEES_ID_List ( List<Int32?> SUPPLIER_FEES_ID_LIST)
{
List<Supplier_fees> oList = new List<Supplier_fees>();
dynamic p = new ExpandoObject();
p.SUPPLIER_FEES_ID_LIST = string.Join(",", SUPPLIER_FEES_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_FEES_BY_SUPPLIER_FEES_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Supplier_fees o = new Supplier_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<User> Get_User_By_USER_ID_List ( List<long?> USER_ID_LIST)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USER_ID_LIST = string.Join(",", USER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_USER_ID_LIST", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_ADDRESS_ID_List_Adv ( List<long?> ADDRESS_ID_LIST)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_ID_LIST = string.Join(",", ADDRESS_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_ADDRESS_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Bloodtype> Get_Bloodtype_By_BLOODTYPE_ID_List_Adv ( List<Int32?> BLOODTYPE_ID_LIST)
{
List<Bloodtype> oList = new List<Bloodtype>();
dynamic p = new ExpandoObject();
p.BLOODTYPE_ID_LIST = string.Join(",", BLOODTYPE_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BLOODTYPE_BY_BLOODTYPE_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Bloodtype o = new Bloodtype();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Client> Get_Client_By_CLIENT_ID_List_Adv ( List<Int32?> CLIENT_ID_LIST)
{
List<Client> oList = new List<Client>();
dynamic p = new ExpandoObject();
p.CLIENT_ID_LIST = string.Join(",", CLIENT_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CLIENT_BY_CLIENT_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Client o = new Client();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Bloodtype = new Bloodtype();
o.My_Bloodtype.BLOODTYPE_ID = GV<Int32>(X["T_BLOODTYPE_BLOODTYPE_ID"]);o.My_Bloodtype.BLOODTYPE_SYMBOL = GV<String>(X["T_BLOODTYPE_BLOODTYPE_SYMBOL"]);o.My_Bloodtype.ENTRY_USER_ID = GV<Int64>(X["T_BLOODTYPE_ENTRY_USER_ID"]);o.My_Bloodtype.ENTRY_DATE = GV<String>(X["T_BLOODTYPE_ENTRY_DATE"]);o.My_Bloodtype.OWNER_ID = GV<Int32>(X["T_BLOODTYPE_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Client_fees> Get_Client_fees_By_CLIENT_FEES_ID_List_Adv ( List<Int32?> CLIENT_FEES_ID_LIST)
{
List<Client_fees> oList = new List<Client_fees>();
dynamic p = new ExpandoObject();
p.CLIENT_FEES_ID_LIST = string.Join(",", CLIENT_FEES_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CLIENT_FEES_BY_CLIENT_FEES_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Client_fees o = new Client_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Client = new Client();
o.My_Client.CLIENT_ID = GV<Int32>(X["T_CLIENT_CLIENT_ID"]);o.My_Client.CLIENT_NAME = GV<String>(X["T_CLIENT_CLIENT_NAME"]);o.My_Client.CLIENT_PH_NB = GV<String>(X["T_CLIENT_CLIENT_PH_NB"]);o.My_Client.CLIENT_MAIL = GV<String>(X["T_CLIENT_CLIENT_MAIL"]);o.My_Client.CLIENT_DOB = GV<String>(X["T_CLIENT_CLIENT_DOB"]);o.My_Client.BLOODTYPE_ID = GV<Int32>(X["T_CLIENT_BLOODTYPE_ID"]);o.My_Client.ENTRY_USER_ID = GV<Int64>(X["T_CLIENT_ENTRY_USER_ID"]);o.My_Client.ENTRY_DATE = GV<String>(X["T_CLIENT_ENTRY_DATE"]);o.My_Client.OWNER_ID = GV<Int32>(X["T_CLIENT_OWNER_ID"]);o.My_Client.CLIENT_GENDER = GV<String>(X["T_CLIENT_CLIENT_GENDER"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Package = new Package();
o.My_Package.PACKAGE_ID = GV<Int32>(X["T_PACKAGE_PACKAGE_ID"]);o.My_Package.PACKAGE_NAME = GV<String>(X["T_PACKAGE_PACKAGE_NAME"]);o.My_Package.PACKAGE_PRICE = GV<Int32>(X["T_PACKAGE_PACKAGE_PRICE"]);o.My_Package.CURRENCY_ID = GV<Int32>(X["T_PACKAGE_CURRENCY_ID"]);o.My_Package.ENTRY_USER_ID = GV<Int64>(X["T_PACKAGE_ENTRY_USER_ID"]);o.My_Package.ENTRY_DATE = GV<String>(X["T_PACKAGE_ENTRY_DATE"]);o.My_Package.OWNER_ID = GV<Int32>(X["T_PACKAGE_OWNER_ID"]);o.My_Package.PACKAGE_SESSIONS_NB = GV<Int32>(X["T_PACKAGE_PACKAGE_SESSIONS_NB"]);o.My_Package.PACKAGE_TYPE = GV<String>(X["T_PACKAGE_PACKAGE_TYPE"]);o.My_Package.PACKAGE_ENDING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_ENDING_DATE"]);o.My_Package.PACKAGE_TIMELINE = GV<String>(X["T_PACKAGE_PACKAGE_TIMELINE"]);o.My_Package.PACKAGE_STARTING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_STARTING_DATE"]);o.My_Package.PACKAGE_NB_OF_MONTH = GV<Int32>(X["T_PACKAGE_PACKAGE_NB_OF_MONTH"]);
o.My_Registration = new Registration();
o.My_Registration.REGISTRATION_ID = GV<Int32>(X["T_REGISTRATION_REGISTRATION_ID"]);o.My_Registration.CLIENT_ID = GV<Int32>(X["T_REGISTRATION_CLIENT_ID"]);o.My_Registration.REGISTRATION_DATE = GV<String>(X["T_REGISTRATION_REGISTRATION_DATE"]);o.My_Registration.PACKAGE_ID = GV<Int32>(X["T_REGISTRATION_PACKAGE_ID"]);o.My_Registration.REGISTRATION_DISCOUNT = GV<Int32>(X["T_REGISTRATION_REGISTRATION_DISCOUNT"]);o.My_Registration.REGISTRATION_TOTAL_PRICE = GV<Int32>(X["T_REGISTRATION_REGISTRATION_TOTAL_PRICE"]);o.My_Registration.CURRENCY_ID = GV<Int32>(X["T_REGISTRATION_CURRENCY_ID"]);o.My_Registration.REGISTRATION_DESCRIPTION = GV<String>(X["T_REGISTRATION_REGISTRATION_DESCRIPTION"]);o.My_Registration.ENTRY_USER_ID = GV<Int64>(X["T_REGISTRATION_ENTRY_USER_ID"]);o.My_Registration.ENTRY_DATE = GV<String>(X["T_REGISTRATION_ENTRY_DATE"]);o.My_Registration.OWNER_ID = GV<Int32>(X["T_REGISTRATION_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Contact> Get_Contact_By_CONTACT_ID_List_Adv ( List<Int32?> CONTACT_ID_LIST)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.CONTACT_ID_LIST = string.Join(",", CONTACT_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_CONTACT_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
oList.Add(o);
}
}
return oList;
}
public List<Currency> Get_Currency_By_CURRENCY_ID_List_Adv ( List<Int32?> CURRENCY_ID_LIST)
{
List<Currency> oList = new List<Currency>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CURRENCY_BY_CURRENCY_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Currency o = new Currency();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Fees> Get_Fees_By_FEES_ID_List_Adv ( List<Int32?> FEES_ID_LIST)
{
List<Fees> oList = new List<Fees>();
dynamic p = new ExpandoObject();
p.FEES_ID_LIST = string.Join(",", FEES_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEES_BY_FEES_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Fees o = new Fees();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_LOC_L1_ID_List_Adv ( List<long?> LOC_L1_ID_LIST)
{
List<Loc_l1> oList = new List<Loc_l1>();
dynamic p = new ExpandoObject();
p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L1_BY_LOC_L1_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l1 o = new Loc_l1();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L2_ID_List_Adv ( List<long?> LOC_L2_ID_LIST)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_LOC_L2_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L3_ID_List_Adv ( List<long?> LOC_L3_ID_LIST)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_LOC_L3_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L4_ID_List_Adv ( List<long?> LOC_L4_ID_LIST)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.LOC_L4_ID_LIST = string.Join(",", LOC_L4_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_LOC_L4_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Method_run> Get_Method_run_By_METHOD_RUN_ID_List_Adv ( List<long?> METHOD_RUN_ID_LIST)
{
List<Method_run> oList = new List<Method_run>();
dynamic p = new ExpandoObject();
p.METHOD_RUN_ID_LIST = string.Join(",", METHOD_RUN_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_METHOD_RUN_BY_METHOD_RUN_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Method_run o = new Method_run();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Package> Get_Package_By_PACKAGE_ID_List_Adv ( List<Int32?> PACKAGE_ID_LIST)
{
List<Package> oList = new List<Package>();
dynamic p = new ExpandoObject();
p.PACKAGE_ID_LIST = string.Join(",", PACKAGE_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PACKAGE_BY_PACKAGE_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Package o = new Package();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Person> Get_Person_By_PERSON_ID_List_Adv ( List<long?> PERSON_ID_LIST)
{
List<Person> oList = new List<Person>();
dynamic p = new ExpandoObject();
p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PERSON_BY_PERSON_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Person o = new Person();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Registered_staff_expense> Get_Registered_staff_expense_By_REGISTERED_STAFF_EXPENSE_ID_List_Adv ( List<Int32?> REGISTERED_STAFF_EXPENSE_ID_LIST)
{
List<Registered_staff_expense> oList = new List<Registered_staff_expense>();
dynamic p = new ExpandoObject();
p.REGISTERED_STAFF_EXPENSE_ID_LIST = string.Join(",", REGISTERED_STAFF_EXPENSE_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_REGISTERED_STAFF_EXPENSE_BY_REGISTERED_STAFF_EXPENSE_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Registered_staff_expense o = new Registered_staff_expense();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Staff = new Staff();
o.My_Staff.STAFF_ID = GV<Int32>(X["T_STAFF_STAFF_ID"]);o.My_Staff.STAFF_NAME = GV<String>(X["T_STAFF_STAFF_NAME"]);o.My_Staff.STAFF_PH_NB = GV<String>(X["T_STAFF_STAFF_PH_NB"]);o.My_Staff.STAFF_MAIL = GV<String>(X["T_STAFF_STAFF_MAIL"]);o.My_Staff.STAFF_DOB = GV<String>(X["T_STAFF_STAFF_DOB"]);o.My_Staff.BLOODTYPE_ID = GV<Int32>(X["T_STAFF_BLOODTYPE_ID"]);o.My_Staff.ENTRY_USER_ID = GV<Int64>(X["T_STAFF_ENTRY_USER_ID"]);o.My_Staff.ENTRY_DATE = GV<String>(X["T_STAFF_ENTRY_DATE"]);o.My_Staff.OWNER_ID = GV<Int32>(X["T_STAFF_OWNER_ID"]);o.My_Staff.STAFF_GENDER = GV<String>(X["T_STAFF_STAFF_GENDER"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Registered_supplier_expense> Get_Registered_supplier_expense_By_REGISTERED_SUPPLIER_EXPENSE_ID_List_Adv ( List<Int32?> REGISTERED_SUPPLIER_EXPENSE_ID_LIST)
{
List<Registered_supplier_expense> oList = new List<Registered_supplier_expense>();
dynamic p = new ExpandoObject();
p.REGISTERED_SUPPLIER_EXPENSE_ID_LIST = string.Join(",", REGISTERED_SUPPLIER_EXPENSE_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_REGISTERED_SUPPLIER_EXPENSE_BY_REGISTERED_SUPPLIER_EXPENSE_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Registered_supplier_expense o = new Registered_supplier_expense();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Supplier = new Supplier();
o.My_Supplier.SUPPLIER_ID = GV<Int32>(X["T_SUPPLIER_SUPPLIER_ID"]);o.My_Supplier.SUPPLIER_NAME = GV<String>(X["T_SUPPLIER_SUPPLIER_NAME"]);o.My_Supplier.SUPPLIER_PH_NB = GV<String>(X["T_SUPPLIER_SUPPLIER_PH_NB"]);o.My_Supplier.SUPPLIER_MAIL = GV<String>(X["T_SUPPLIER_SUPPLIER_MAIL"]);o.My_Supplier.ENTRY_USER_ID = GV<Int64>(X["T_SUPPLIER_ENTRY_USER_ID"]);o.My_Supplier.ENTRY_DATE = GV<String>(X["T_SUPPLIER_ENTRY_DATE"]);o.My_Supplier.OWNER_ID = GV<Int32>(X["T_SUPPLIER_OWNER_ID"]);o.My_Supplier.SUPPLIER_DOB = GV<String>(X["T_SUPPLIER_SUPPLIER_DOB"]);o.My_Supplier.BLOODTYPE_ID = GV<Int32>(X["T_SUPPLIER_BLOODTYPE_ID"]);o.My_Supplier.SUPPLIER_GENDER = GV<String>(X["T_SUPPLIER_SUPPLIER_GENDER"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Registration> Get_Registration_By_REGISTRATION_ID_List_Adv ( List<Int32?> REGISTRATION_ID_LIST)
{
List<Registration> oList = new List<Registration>();
dynamic p = new ExpandoObject();
p.REGISTRATION_ID_LIST = string.Join(",", REGISTRATION_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_REGISTRATION_BY_REGISTRATION_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Registration o = new Registration();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Client = new Client();
o.My_Client.CLIENT_ID = GV<Int32>(X["T_CLIENT_CLIENT_ID"]);o.My_Client.CLIENT_NAME = GV<String>(X["T_CLIENT_CLIENT_NAME"]);o.My_Client.CLIENT_PH_NB = GV<String>(X["T_CLIENT_CLIENT_PH_NB"]);o.My_Client.CLIENT_MAIL = GV<String>(X["T_CLIENT_CLIENT_MAIL"]);o.My_Client.CLIENT_DOB = GV<String>(X["T_CLIENT_CLIENT_DOB"]);o.My_Client.BLOODTYPE_ID = GV<Int32>(X["T_CLIENT_BLOODTYPE_ID"]);o.My_Client.ENTRY_USER_ID = GV<Int64>(X["T_CLIENT_ENTRY_USER_ID"]);o.My_Client.ENTRY_DATE = GV<String>(X["T_CLIENT_ENTRY_DATE"]);o.My_Client.OWNER_ID = GV<Int32>(X["T_CLIENT_OWNER_ID"]);o.My_Client.CLIENT_GENDER = GV<String>(X["T_CLIENT_CLIENT_GENDER"]);
o.My_Package = new Package();
o.My_Package.PACKAGE_ID = GV<Int32>(X["T_PACKAGE_PACKAGE_ID"]);o.My_Package.PACKAGE_NAME = GV<String>(X["T_PACKAGE_PACKAGE_NAME"]);o.My_Package.PACKAGE_PRICE = GV<Int32>(X["T_PACKAGE_PACKAGE_PRICE"]);o.My_Package.CURRENCY_ID = GV<Int32>(X["T_PACKAGE_CURRENCY_ID"]);o.My_Package.ENTRY_USER_ID = GV<Int64>(X["T_PACKAGE_ENTRY_USER_ID"]);o.My_Package.ENTRY_DATE = GV<String>(X["T_PACKAGE_ENTRY_DATE"]);o.My_Package.OWNER_ID = GV<Int32>(X["T_PACKAGE_OWNER_ID"]);o.My_Package.PACKAGE_SESSIONS_NB = GV<Int32>(X["T_PACKAGE_PACKAGE_SESSIONS_NB"]);o.My_Package.PACKAGE_TYPE = GV<String>(X["T_PACKAGE_PACKAGE_TYPE"]);o.My_Package.PACKAGE_ENDING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_ENDING_DATE"]);o.My_Package.PACKAGE_TIMELINE = GV<String>(X["T_PACKAGE_PACKAGE_TIMELINE"]);o.My_Package.PACKAGE_STARTING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_STARTING_DATE"]);o.My_Package.PACKAGE_NB_OF_MONTH = GV<Int32>(X["T_PACKAGE_PACKAGE_NB_OF_MONTH"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Session> Get_Session_By_SESSION_ID_List_Adv ( List<Int32?> SESSION_ID_LIST)
{
List<Session> oList = new List<Session>();
dynamic p = new ExpandoObject();
p.SESSION_ID_LIST = string.Join(",", SESSION_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SESSION_BY_SESSION_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Session o = new Session();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Package = new Package();
o.My_Package.PACKAGE_ID = GV<Int32>(X["T_PACKAGE_PACKAGE_ID"]);o.My_Package.PACKAGE_NAME = GV<String>(X["T_PACKAGE_PACKAGE_NAME"]);o.My_Package.PACKAGE_PRICE = GV<Int32>(X["T_PACKAGE_PACKAGE_PRICE"]);o.My_Package.CURRENCY_ID = GV<Int32>(X["T_PACKAGE_CURRENCY_ID"]);o.My_Package.ENTRY_USER_ID = GV<Int64>(X["T_PACKAGE_ENTRY_USER_ID"]);o.My_Package.ENTRY_DATE = GV<String>(X["T_PACKAGE_ENTRY_DATE"]);o.My_Package.OWNER_ID = GV<Int32>(X["T_PACKAGE_OWNER_ID"]);o.My_Package.PACKAGE_SESSIONS_NB = GV<Int32>(X["T_PACKAGE_PACKAGE_SESSIONS_NB"]);o.My_Package.PACKAGE_TYPE = GV<String>(X["T_PACKAGE_PACKAGE_TYPE"]);o.My_Package.PACKAGE_ENDING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_ENDING_DATE"]);o.My_Package.PACKAGE_TIMELINE = GV<String>(X["T_PACKAGE_PACKAGE_TIMELINE"]);o.My_Package.PACKAGE_STARTING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_STARTING_DATE"]);o.My_Package.PACKAGE_NB_OF_MONTH = GV<Int32>(X["T_PACKAGE_PACKAGE_NB_OF_MONTH"]);
o.My_Client_fees = new Client_fees();
o.My_Client_fees.CLIENT_FEES_ID = GV<Int32>(X["T_CLIENT_FEES_CLIENT_FEES_ID"]);o.My_Client_fees.CLIENT_ID = GV<Int32>(X["T_CLIENT_FEES_CLIENT_ID"]);o.My_Client_fees.CLIENT_FEES_DESCRIPTION = GV<String>(X["T_CLIENT_FEES_CLIENT_FEES_DESCRIPTION"]);o.My_Client_fees.ENTRY_USER_ID = GV<Int64>(X["T_CLIENT_FEES_ENTRY_USER_ID"]);o.My_Client_fees.ENTRY_DATE = GV<String>(X["T_CLIENT_FEES_ENTRY_DATE"]);o.My_Client_fees.OWNER_ID = GV<Int32>(X["T_CLIENT_FEES_OWNER_ID"]);o.My_Client_fees.CURRENCY_ID = GV<Int32>(X["T_CLIENT_FEES_CURRENCY_ID"]);o.My_Client_fees.PACKAGE_ID = GV<Int32>(X["T_CLIENT_FEES_PACKAGE_ID"]);o.My_Client_fees.CLIENT_FEES_AMOUNT = GV<Int32>(X["T_CLIENT_FEES_CLIENT_FEES_AMOUNT"]);o.My_Client_fees.REGISTRATION_ID = GV<Int32>(X["T_CLIENT_FEES_REGISTRATION_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Staff> Get_Staff_By_STAFF_ID_List_Adv ( List<Int32?> STAFF_ID_LIST)
{
List<Staff> oList = new List<Staff>();
dynamic p = new ExpandoObject();
p.STAFF_ID_LIST = string.Join(",", STAFF_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_BY_STAFF_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Staff o = new Staff();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Bloodtype = new Bloodtype();
o.My_Bloodtype.BLOODTYPE_ID = GV<Int32>(X["T_BLOODTYPE_BLOODTYPE_ID"]);o.My_Bloodtype.BLOODTYPE_SYMBOL = GV<String>(X["T_BLOODTYPE_BLOODTYPE_SYMBOL"]);o.My_Bloodtype.ENTRY_USER_ID = GV<Int64>(X["T_BLOODTYPE_ENTRY_USER_ID"]);o.My_Bloodtype.ENTRY_DATE = GV<String>(X["T_BLOODTYPE_ENTRY_DATE"]);o.My_Bloodtype.OWNER_ID = GV<Int32>(X["T_BLOODTYPE_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Staff_fees> Get_Staff_fees_By_STAFF_FEES_ID_List_Adv ( List<Int32?> STAFF_FEES_ID_LIST)
{
List<Staff_fees> oList = new List<Staff_fees>();
dynamic p = new ExpandoObject();
p.STAFF_FEES_ID_LIST = string.Join(",", STAFF_FEES_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_FEES_BY_STAFF_FEES_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Staff_fees o = new Staff_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Staff = new Staff();
o.My_Staff.STAFF_ID = GV<Int32>(X["T_STAFF_STAFF_ID"]);o.My_Staff.STAFF_NAME = GV<String>(X["T_STAFF_STAFF_NAME"]);o.My_Staff.STAFF_PH_NB = GV<String>(X["T_STAFF_STAFF_PH_NB"]);o.My_Staff.STAFF_MAIL = GV<String>(X["T_STAFF_STAFF_MAIL"]);o.My_Staff.STAFF_DOB = GV<String>(X["T_STAFF_STAFF_DOB"]);o.My_Staff.BLOODTYPE_ID = GV<Int32>(X["T_STAFF_BLOODTYPE_ID"]);o.My_Staff.ENTRY_USER_ID = GV<Int64>(X["T_STAFF_ENTRY_USER_ID"]);o.My_Staff.ENTRY_DATE = GV<String>(X["T_STAFF_ENTRY_DATE"]);o.My_Staff.OWNER_ID = GV<Int32>(X["T_STAFF_OWNER_ID"]);o.My_Staff.STAFF_GENDER = GV<String>(X["T_STAFF_STAFF_GENDER"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Registered_staff_expense = new Registered_staff_expense();
o.My_Registered_staff_expense.REGISTERED_STAFF_EXPENSE_ID = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_REGISTERED_STAFF_EXPENSE_ID"]);o.My_Registered_staff_expense.REGISTERED_STAFF_EXPENSE_DISCOUNT = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_REGISTERED_STAFF_EXPENSE_DISCOUNT"]);o.My_Registered_staff_expense.REGISTERED_STAFF_EXPENSE_TOTAL_AMOUNT = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_REGISTERED_STAFF_EXPENSE_TOTAL_AMOUNT"]);o.My_Registered_staff_expense.REGISTERED_STAFF_EXPENSE_DESCRIPTION = GV<String>(X["T_REGISTERED_STAFF_EXPENSE_REGISTERED_STAFF_EXPENSE_DESCRIPTION"]);o.My_Registered_staff_expense.STAFF_ID = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_STAFF_ID"]);o.My_Registered_staff_expense.CURRENCY_ID = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_CURRENCY_ID"]);o.My_Registered_staff_expense.ENTRY_USER_ID = GV<Int64>(X["T_REGISTERED_STAFF_EXPENSE_ENTRY_USER_ID"]);o.My_Registered_staff_expense.ENTRY_DATE = GV<String>(X["T_REGISTERED_STAFF_EXPENSE_ENTRY_DATE"]);o.My_Registered_staff_expense.OWNER_ID = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Supplier> Get_Supplier_By_SUPPLIER_ID_List_Adv ( List<Int32?> SUPPLIER_ID_LIST)
{
List<Supplier> oList = new List<Supplier>();
dynamic p = new ExpandoObject();
p.SUPPLIER_ID_LIST = string.Join(",", SUPPLIER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_BY_SUPPLIER_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Supplier o = new Supplier();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Bloodtype = new Bloodtype();
o.My_Bloodtype.BLOODTYPE_ID = GV<Int32>(X["T_BLOODTYPE_BLOODTYPE_ID"]);o.My_Bloodtype.BLOODTYPE_SYMBOL = GV<String>(X["T_BLOODTYPE_BLOODTYPE_SYMBOL"]);o.My_Bloodtype.ENTRY_USER_ID = GV<Int64>(X["T_BLOODTYPE_ENTRY_USER_ID"]);o.My_Bloodtype.ENTRY_DATE = GV<String>(X["T_BLOODTYPE_ENTRY_DATE"]);o.My_Bloodtype.OWNER_ID = GV<Int32>(X["T_BLOODTYPE_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Supplier_fees> Get_Supplier_fees_By_SUPPLIER_FEES_ID_List_Adv ( List<Int32?> SUPPLIER_FEES_ID_LIST)
{
List<Supplier_fees> oList = new List<Supplier_fees>();
dynamic p = new ExpandoObject();
p.SUPPLIER_FEES_ID_LIST = string.Join(",", SUPPLIER_FEES_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_FEES_BY_SUPPLIER_FEES_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Supplier_fees o = new Supplier_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Supplier = new Supplier();
o.My_Supplier.SUPPLIER_ID = GV<Int32>(X["T_SUPPLIER_SUPPLIER_ID"]);o.My_Supplier.SUPPLIER_NAME = GV<String>(X["T_SUPPLIER_SUPPLIER_NAME"]);o.My_Supplier.SUPPLIER_PH_NB = GV<String>(X["T_SUPPLIER_SUPPLIER_PH_NB"]);o.My_Supplier.SUPPLIER_MAIL = GV<String>(X["T_SUPPLIER_SUPPLIER_MAIL"]);o.My_Supplier.ENTRY_USER_ID = GV<Int64>(X["T_SUPPLIER_ENTRY_USER_ID"]);o.My_Supplier.ENTRY_DATE = GV<String>(X["T_SUPPLIER_ENTRY_DATE"]);o.My_Supplier.OWNER_ID = GV<Int32>(X["T_SUPPLIER_OWNER_ID"]);o.My_Supplier.SUPPLIER_DOB = GV<String>(X["T_SUPPLIER_SUPPLIER_DOB"]);o.My_Supplier.BLOODTYPE_ID = GV<Int32>(X["T_SUPPLIER_BLOODTYPE_ID"]);o.My_Supplier.SUPPLIER_GENDER = GV<String>(X["T_SUPPLIER_SUPPLIER_GENDER"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Registered_supplier_expense = new Registered_supplier_expense();
o.My_Registered_supplier_expense.REGISTERED_SUPPLIER_EXPENSE_ID = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_REGISTERED_SUPPLIER_EXPENSE_ID"]);o.My_Registered_supplier_expense.REGISTERED_SUPPLIER_EXPENSE_DISCOUNT = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_REGISTERED_SUPPLIER_EXPENSE_DISCOUNT"]);o.My_Registered_supplier_expense.REGISTERED_SUPPLIER_EXPENSE_TOTAL_AMOUNT = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_REGISTERED_SUPPLIER_EXPENSE_TOTAL_AMOUNT"]);o.My_Registered_supplier_expense.REGISTERED_SUPPLIER_EXPENSE_DESCRIPTION = GV<String>(X["T_REGISTERED_SUPPLIER_EXPENSE_REGISTERED_SUPPLIER_EXPENSE_DESCRIPTION"]);o.My_Registered_supplier_expense.SUPPLIER_ID = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_SUPPLIER_ID"]);o.My_Registered_supplier_expense.CURRENCY_ID = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_CURRENCY_ID"]);o.My_Registered_supplier_expense.ENTRY_USER_ID = GV<Int64>(X["T_REGISTERED_SUPPLIER_EXPENSE_ENTRY_USER_ID"]);o.My_Registered_supplier_expense.ENTRY_DATE = GV<String>(X["T_REGISTERED_SUPPLIER_EXPENSE_ENTRY_DATE"]);o.My_Registered_supplier_expense.OWNER_ID = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<User> Get_User_By_USER_ID_List_Adv ( List<long?> USER_ID_LIST)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USER_ID_LIST = string.Join(",", USER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_USER_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_PERSON_ID ( long? PERSON_ID)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.PERSON_ID = PERSON_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_PERSON_ID", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L1_ID ( long? LOC_L1_ID)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L1_ID = LOC_L1_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L1_ID", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L2_ID ( long? LOC_L2_ID)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L2_ID = LOC_L2_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L2_ID", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L3_ID ( long? LOC_L3_ID)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L3_ID = LOC_L3_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L3_ID", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE ( long? PERSON_ID, string ADDRESS_TYPE_CODE)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.PERSON_ID = PERSON_ID; p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_PERSON_ID_ADDRESS_TYPE_CODE", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L4_ID ( long? LOC_L4_ID)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L4_ID = LOC_L4_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L4_ID", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Bloodtype> Get_Bloodtype_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Bloodtype> oList = new List<Bloodtype>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BLOODTYPE_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Bloodtype o = new Bloodtype();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Client> Get_Client_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Client> oList = new List<Client>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CLIENT_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Client o = new Client();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Client> Get_Client_By_BLOODTYPE_ID ( Int32? BLOODTYPE_ID)
{
List<Client> oList = new List<Client>();
dynamic p = new ExpandoObject();
p.BLOODTYPE_ID = BLOODTYPE_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CLIENT_BY_BLOODTYPE_ID", p);
if (R != null) {foreach (var X in R) {
Client o = new Client();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Client_fees> Get_Client_fees_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Client_fees> oList = new List<Client_fees>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CLIENT_FEES_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Client_fees o = new Client_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Client_fees> Get_Client_fees_By_CLIENT_ID ( Int32? CLIENT_ID)
{
List<Client_fees> oList = new List<Client_fees>();
dynamic p = new ExpandoObject();
p.CLIENT_ID = CLIENT_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CLIENT_FEES_BY_CLIENT_ID", p);
if (R != null) {foreach (var X in R) {
Client_fees o = new Client_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Client_fees> Get_Client_fees_By_CURRENCY_ID ( Int32? CURRENCY_ID)
{
List<Client_fees> oList = new List<Client_fees>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID = CURRENCY_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CLIENT_FEES_BY_CURRENCY_ID", p);
if (R != null) {foreach (var X in R) {
Client_fees o = new Client_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Client_fees> Get_Client_fees_By_PACKAGE_ID ( Int32? PACKAGE_ID)
{
List<Client_fees> oList = new List<Client_fees>();
dynamic p = new ExpandoObject();
p.PACKAGE_ID = PACKAGE_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CLIENT_FEES_BY_PACKAGE_ID", p);
if (R != null) {foreach (var X in R) {
Client_fees o = new Client_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Client_fees> Get_Client_fees_By_REGISTRATION_ID ( Int32? REGISTRATION_ID)
{
List<Client_fees> oList = new List<Client_fees>();
dynamic p = new ExpandoObject();
p.REGISTRATION_ID = REGISTRATION_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CLIENT_FEES_BY_REGISTRATION_ID", p);
if (R != null) {foreach (var X in R) {
Client_fees o = new Client_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Contact> Get_Contact_By_PERSON_ID ( long? PERSON_ID)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.PERSON_ID = PERSON_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_PERSON_ID", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Contact> Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT ( long? PERSON_ID, string CONTACT_TYPE_CODE, string CONTACT)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.PERSON_ID = PERSON_ID; p.CONTACT_TYPE_CODE = CONTACT_TYPE_CODE; p.CONTACT = CONTACT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_PERSON_ID_CONTACT_TYPE_CODE_CONTACT", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Contact> Get_Contact_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Currency> Get_Currency_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Currency> oList = new List<Currency>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CURRENCY_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Currency o = new Currency();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Fees> Get_Fees_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Fees> oList = new List<Fees>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEES_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Fees o = new Fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Fees> Get_Fees_By_CURRENCY_ID ( Int32? CURRENCY_ID)
{
List<Fees> oList = new List<Fees>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID = CURRENCY_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEES_BY_CURRENCY_ID", p);
if (R != null) {foreach (var X in R) {
Fees o = new Fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_CODE ( string CODE)
{
List<Loc_l1> oList = new List<Loc_l1>();
dynamic p = new ExpandoObject();
p.CODE = CODE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L1_BY_CODE", p);
if (R != null) {foreach (var X in R) {
Loc_l1 o = new Loc_l1();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Loc_l1> oList = new List<Loc_l1>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L1_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Loc_l1 o = new Loc_l1();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_CODE ( long? LOC_L1_ID, string CODE)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.LOC_L1_ID = LOC_L1_ID; p.CODE = CODE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_LOC_L1_ID_CODE", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID ( long? LOC_L1_ID)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.LOC_L1_ID = LOC_L1_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_LOC_L1_ID", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_CODE ( long? LOC_L2_ID, string CODE)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.LOC_L2_ID = LOC_L2_ID; p.CODE = CODE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_LOC_L2_ID_CODE", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID ( long? LOC_L2_ID)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.LOC_L2_ID = LOC_L2_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_LOC_L2_ID", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_CODE ( long? LOC_L3_ID, string CODE)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.LOC_L3_ID = LOC_L3_ID; p.CODE = CODE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_LOC_L3_ID_CODE", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID ( long? LOC_L3_ID)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.LOC_L3_ID = LOC_L3_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_LOC_L3_ID", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Method_run> Get_Method_run_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Method_run> oList = new List<Method_run>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_METHOD_RUN_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Method_run o = new Method_run();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Package> Get_Package_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Package> oList = new List<Package>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PACKAGE_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Package o = new Package();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Package> Get_Package_By_CURRENCY_ID ( Int32? CURRENCY_ID)
{
List<Package> oList = new List<Package>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID = CURRENCY_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PACKAGE_BY_CURRENCY_ID", p);
if (R != null) {foreach (var X in R) {
Package o = new Package();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Person> Get_Person_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Person> oList = new List<Person>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PERSON_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Person o = new Person();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Registered_staff_expense> Get_Registered_staff_expense_By_STAFF_ID ( Int32? STAFF_ID)
{
List<Registered_staff_expense> oList = new List<Registered_staff_expense>();
dynamic p = new ExpandoObject();
p.STAFF_ID = STAFF_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_REGISTERED_STAFF_EXPENSE_BY_STAFF_ID", p);
if (R != null) {foreach (var X in R) {
Registered_staff_expense o = new Registered_staff_expense();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Registered_staff_expense> Get_Registered_staff_expense_By_CURRENCY_ID ( Int32? CURRENCY_ID)
{
List<Registered_staff_expense> oList = new List<Registered_staff_expense>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID = CURRENCY_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_REGISTERED_STAFF_EXPENSE_BY_CURRENCY_ID", p);
if (R != null) {foreach (var X in R) {
Registered_staff_expense o = new Registered_staff_expense();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Registered_staff_expense> Get_Registered_staff_expense_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Registered_staff_expense> oList = new List<Registered_staff_expense>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_REGISTERED_STAFF_EXPENSE_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Registered_staff_expense o = new Registered_staff_expense();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Registered_supplier_expense> Get_Registered_supplier_expense_By_SUPPLIER_ID ( Int32? SUPPLIER_ID)
{
List<Registered_supplier_expense> oList = new List<Registered_supplier_expense>();
dynamic p = new ExpandoObject();
p.SUPPLIER_ID = SUPPLIER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_REGISTERED_SUPPLIER_EXPENSE_BY_SUPPLIER_ID", p);
if (R != null) {foreach (var X in R) {
Registered_supplier_expense o = new Registered_supplier_expense();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Registered_supplier_expense> Get_Registered_supplier_expense_By_CURRENCY_ID ( Int32? CURRENCY_ID)
{
List<Registered_supplier_expense> oList = new List<Registered_supplier_expense>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID = CURRENCY_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_REGISTERED_SUPPLIER_EXPENSE_BY_CURRENCY_ID", p);
if (R != null) {foreach (var X in R) {
Registered_supplier_expense o = new Registered_supplier_expense();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Registered_supplier_expense> Get_Registered_supplier_expense_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Registered_supplier_expense> oList = new List<Registered_supplier_expense>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_REGISTERED_SUPPLIER_EXPENSE_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Registered_supplier_expense o = new Registered_supplier_expense();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Registration> Get_Registration_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Registration> oList = new List<Registration>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_REGISTRATION_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Registration o = new Registration();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Registration> Get_Registration_By_CLIENT_ID ( Int32? CLIENT_ID)
{
List<Registration> oList = new List<Registration>();
dynamic p = new ExpandoObject();
p.CLIENT_ID = CLIENT_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_REGISTRATION_BY_CLIENT_ID", p);
if (R != null) {foreach (var X in R) {
Registration o = new Registration();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Registration> Get_Registration_By_PACKAGE_ID ( Int32? PACKAGE_ID)
{
List<Registration> oList = new List<Registration>();
dynamic p = new ExpandoObject();
p.PACKAGE_ID = PACKAGE_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_REGISTRATION_BY_PACKAGE_ID", p);
if (R != null) {foreach (var X in R) {
Registration o = new Registration();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Registration> Get_Registration_By_CURRENCY_ID ( Int32? CURRENCY_ID)
{
List<Registration> oList = new List<Registration>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID = CURRENCY_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_REGISTRATION_BY_CURRENCY_ID", p);
if (R != null) {foreach (var X in R) {
Registration o = new Registration();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Session> Get_Session_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Session> oList = new List<Session>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SESSION_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Session o = new Session();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Session> Get_Session_By_PACKAGE_ID ( Int32? PACKAGE_ID)
{
List<Session> oList = new List<Session>();
dynamic p = new ExpandoObject();
p.PACKAGE_ID = PACKAGE_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SESSION_BY_PACKAGE_ID", p);
if (R != null) {foreach (var X in R) {
Session o = new Session();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Session> Get_Session_By_CLIENT_FEES_ID ( Int32? CLIENT_FEES_ID)
{
List<Session> oList = new List<Session>();
dynamic p = new ExpandoObject();
p.CLIENT_FEES_ID = CLIENT_FEES_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SESSION_BY_CLIENT_FEES_ID", p);
if (R != null) {foreach (var X in R) {
Session o = new Session();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Staff> Get_Staff_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Staff> oList = new List<Staff>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Staff o = new Staff();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Staff> Get_Staff_By_BLOODTYPE_ID ( Int32? BLOODTYPE_ID)
{
List<Staff> oList = new List<Staff>();
dynamic p = new ExpandoObject();
p.BLOODTYPE_ID = BLOODTYPE_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_BY_BLOODTYPE_ID", p);
if (R != null) {foreach (var X in R) {
Staff o = new Staff();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Staff_fees> Get_Staff_fees_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Staff_fees> oList = new List<Staff_fees>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_FEES_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Staff_fees o = new Staff_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Staff_fees> Get_Staff_fees_By_STAFF_ID ( Int32? STAFF_ID)
{
List<Staff_fees> oList = new List<Staff_fees>();
dynamic p = new ExpandoObject();
p.STAFF_ID = STAFF_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_FEES_BY_STAFF_ID", p);
if (R != null) {foreach (var X in R) {
Staff_fees o = new Staff_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Staff_fees> Get_Staff_fees_By_CURRENCY_ID ( Int32? CURRENCY_ID)
{
List<Staff_fees> oList = new List<Staff_fees>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID = CURRENCY_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_FEES_BY_CURRENCY_ID", p);
if (R != null) {foreach (var X in R) {
Staff_fees o = new Staff_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Staff_fees> Get_Staff_fees_By_REGISTERED_STAFF_EXPENSE_ID ( Int32? REGISTERED_STAFF_EXPENSE_ID)
{
List<Staff_fees> oList = new List<Staff_fees>();
dynamic p = new ExpandoObject();
p.REGISTERED_STAFF_EXPENSE_ID = REGISTERED_STAFF_EXPENSE_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_FEES_BY_REGISTERED_STAFF_EXPENSE_ID", p);
if (R != null) {foreach (var X in R) {
Staff_fees o = new Staff_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Supplier> Get_Supplier_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Supplier> oList = new List<Supplier>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Supplier o = new Supplier();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Supplier> Get_Supplier_By_BLOODTYPE_ID ( Int32? BLOODTYPE_ID)
{
List<Supplier> oList = new List<Supplier>();
dynamic p = new ExpandoObject();
p.BLOODTYPE_ID = BLOODTYPE_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_BY_BLOODTYPE_ID", p);
if (R != null) {foreach (var X in R) {
Supplier o = new Supplier();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Supplier_fees> Get_Supplier_fees_By_OWNER_ID ( Int32? OWNER_ID)
{
List<Supplier_fees> oList = new List<Supplier_fees>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_FEES_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
Supplier_fees o = new Supplier_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Supplier_fees> Get_Supplier_fees_By_SUPPLIER_ID ( Int32? SUPPLIER_ID)
{
List<Supplier_fees> oList = new List<Supplier_fees>();
dynamic p = new ExpandoObject();
p.SUPPLIER_ID = SUPPLIER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_FEES_BY_SUPPLIER_ID", p);
if (R != null) {foreach (var X in R) {
Supplier_fees o = new Supplier_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Supplier_fees> Get_Supplier_fees_By_CURRENCY_ID ( Int32? CURRENCY_ID)
{
List<Supplier_fees> oList = new List<Supplier_fees>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID = CURRENCY_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_FEES_BY_CURRENCY_ID", p);
if (R != null) {foreach (var X in R) {
Supplier_fees o = new Supplier_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Supplier_fees> Get_Supplier_fees_By_REGISTERED_SUPPLIER_EXPENSE_ID ( Int32? REGISTERED_SUPPLIER_EXPENSE_ID)
{
List<Supplier_fees> oList = new List<Supplier_fees>();
dynamic p = new ExpandoObject();
p.REGISTERED_SUPPLIER_EXPENSE_ID = REGISTERED_SUPPLIER_EXPENSE_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_FEES_BY_REGISTERED_SUPPLIER_EXPENSE_ID", p);
if (R != null) {foreach (var X in R) {
Supplier_fees o = new Supplier_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<User> Get_User_By_OWNER_ID ( Int32? OWNER_ID)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_OWNER_ID", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<User> Get_User_By_USERNAME ( string USERNAME)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_USERNAME", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_PERSON_ID_Adv ( long? PERSON_ID)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.PERSON_ID = PERSON_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_PERSON_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L1_ID_Adv ( long? LOC_L1_ID)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L1_ID = LOC_L1_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L1_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L2_ID_Adv ( long? LOC_L2_ID)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L2_ID = LOC_L2_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L2_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L3_ID_Adv ( long? LOC_L3_ID)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L3_ID = LOC_L3_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L3_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE_Adv ( long? PERSON_ID, string ADDRESS_TYPE_CODE)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.PERSON_ID = PERSON_ID; p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_PERSON_ID_ADDRESS_TYPE_CODE_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L4_ID_Adv ( long? LOC_L4_ID)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L4_ID = LOC_L4_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L4_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Bloodtype> Get_Bloodtype_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Bloodtype> oList = new List<Bloodtype>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BLOODTYPE_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Bloodtype o = new Bloodtype();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Client> Get_Client_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Client> oList = new List<Client>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CLIENT_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Client o = new Client();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Bloodtype = new Bloodtype();
o.My_Bloodtype.BLOODTYPE_ID = GV<Int32>(X["T_BLOODTYPE_BLOODTYPE_ID"]);o.My_Bloodtype.BLOODTYPE_SYMBOL = GV<String>(X["T_BLOODTYPE_BLOODTYPE_SYMBOL"]);o.My_Bloodtype.ENTRY_USER_ID = GV<Int64>(X["T_BLOODTYPE_ENTRY_USER_ID"]);o.My_Bloodtype.ENTRY_DATE = GV<String>(X["T_BLOODTYPE_ENTRY_DATE"]);o.My_Bloodtype.OWNER_ID = GV<Int32>(X["T_BLOODTYPE_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Client> Get_Client_By_BLOODTYPE_ID_Adv ( Int32? BLOODTYPE_ID)
{
List<Client> oList = new List<Client>();
dynamic p = new ExpandoObject();
p.BLOODTYPE_ID = BLOODTYPE_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CLIENT_BY_BLOODTYPE_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Client o = new Client();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Bloodtype = new Bloodtype();
o.My_Bloodtype.BLOODTYPE_ID = GV<Int32>(X["T_BLOODTYPE_BLOODTYPE_ID"]);o.My_Bloodtype.BLOODTYPE_SYMBOL = GV<String>(X["T_BLOODTYPE_BLOODTYPE_SYMBOL"]);o.My_Bloodtype.ENTRY_USER_ID = GV<Int64>(X["T_BLOODTYPE_ENTRY_USER_ID"]);o.My_Bloodtype.ENTRY_DATE = GV<String>(X["T_BLOODTYPE_ENTRY_DATE"]);o.My_Bloodtype.OWNER_ID = GV<Int32>(X["T_BLOODTYPE_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Client_fees> Get_Client_fees_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Client_fees> oList = new List<Client_fees>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CLIENT_FEES_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Client_fees o = new Client_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Client = new Client();
o.My_Client.CLIENT_ID = GV<Int32>(X["T_CLIENT_CLIENT_ID"]);o.My_Client.CLIENT_NAME = GV<String>(X["T_CLIENT_CLIENT_NAME"]);o.My_Client.CLIENT_PH_NB = GV<String>(X["T_CLIENT_CLIENT_PH_NB"]);o.My_Client.CLIENT_MAIL = GV<String>(X["T_CLIENT_CLIENT_MAIL"]);o.My_Client.CLIENT_DOB = GV<String>(X["T_CLIENT_CLIENT_DOB"]);o.My_Client.BLOODTYPE_ID = GV<Int32>(X["T_CLIENT_BLOODTYPE_ID"]);o.My_Client.ENTRY_USER_ID = GV<Int64>(X["T_CLIENT_ENTRY_USER_ID"]);o.My_Client.ENTRY_DATE = GV<String>(X["T_CLIENT_ENTRY_DATE"]);o.My_Client.OWNER_ID = GV<Int32>(X["T_CLIENT_OWNER_ID"]);o.My_Client.CLIENT_GENDER = GV<String>(X["T_CLIENT_CLIENT_GENDER"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Package = new Package();
o.My_Package.PACKAGE_ID = GV<Int32>(X["T_PACKAGE_PACKAGE_ID"]);o.My_Package.PACKAGE_NAME = GV<String>(X["T_PACKAGE_PACKAGE_NAME"]);o.My_Package.PACKAGE_PRICE = GV<Int32>(X["T_PACKAGE_PACKAGE_PRICE"]);o.My_Package.CURRENCY_ID = GV<Int32>(X["T_PACKAGE_CURRENCY_ID"]);o.My_Package.ENTRY_USER_ID = GV<Int64>(X["T_PACKAGE_ENTRY_USER_ID"]);o.My_Package.ENTRY_DATE = GV<String>(X["T_PACKAGE_ENTRY_DATE"]);o.My_Package.OWNER_ID = GV<Int32>(X["T_PACKAGE_OWNER_ID"]);o.My_Package.PACKAGE_SESSIONS_NB = GV<Int32>(X["T_PACKAGE_PACKAGE_SESSIONS_NB"]);o.My_Package.PACKAGE_TYPE = GV<String>(X["T_PACKAGE_PACKAGE_TYPE"]);o.My_Package.PACKAGE_ENDING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_ENDING_DATE"]);o.My_Package.PACKAGE_TIMELINE = GV<String>(X["T_PACKAGE_PACKAGE_TIMELINE"]);o.My_Package.PACKAGE_STARTING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_STARTING_DATE"]);o.My_Package.PACKAGE_NB_OF_MONTH = GV<Int32>(X["T_PACKAGE_PACKAGE_NB_OF_MONTH"]);
o.My_Registration = new Registration();
o.My_Registration.REGISTRATION_ID = GV<Int32>(X["T_REGISTRATION_REGISTRATION_ID"]);o.My_Registration.CLIENT_ID = GV<Int32>(X["T_REGISTRATION_CLIENT_ID"]);o.My_Registration.REGISTRATION_DATE = GV<String>(X["T_REGISTRATION_REGISTRATION_DATE"]);o.My_Registration.PACKAGE_ID = GV<Int32>(X["T_REGISTRATION_PACKAGE_ID"]);o.My_Registration.REGISTRATION_DISCOUNT = GV<Int32>(X["T_REGISTRATION_REGISTRATION_DISCOUNT"]);o.My_Registration.REGISTRATION_TOTAL_PRICE = GV<Int32>(X["T_REGISTRATION_REGISTRATION_TOTAL_PRICE"]);o.My_Registration.CURRENCY_ID = GV<Int32>(X["T_REGISTRATION_CURRENCY_ID"]);o.My_Registration.REGISTRATION_DESCRIPTION = GV<String>(X["T_REGISTRATION_REGISTRATION_DESCRIPTION"]);o.My_Registration.ENTRY_USER_ID = GV<Int64>(X["T_REGISTRATION_ENTRY_USER_ID"]);o.My_Registration.ENTRY_DATE = GV<String>(X["T_REGISTRATION_ENTRY_DATE"]);o.My_Registration.OWNER_ID = GV<Int32>(X["T_REGISTRATION_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Client_fees> Get_Client_fees_By_CLIENT_ID_Adv ( Int32? CLIENT_ID)
{
List<Client_fees> oList = new List<Client_fees>();
dynamic p = new ExpandoObject();
p.CLIENT_ID = CLIENT_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CLIENT_FEES_BY_CLIENT_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Client_fees o = new Client_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Client = new Client();
o.My_Client.CLIENT_ID = GV<Int32>(X["T_CLIENT_CLIENT_ID"]);o.My_Client.CLIENT_NAME = GV<String>(X["T_CLIENT_CLIENT_NAME"]);o.My_Client.CLIENT_PH_NB = GV<String>(X["T_CLIENT_CLIENT_PH_NB"]);o.My_Client.CLIENT_MAIL = GV<String>(X["T_CLIENT_CLIENT_MAIL"]);o.My_Client.CLIENT_DOB = GV<String>(X["T_CLIENT_CLIENT_DOB"]);o.My_Client.BLOODTYPE_ID = GV<Int32>(X["T_CLIENT_BLOODTYPE_ID"]);o.My_Client.ENTRY_USER_ID = GV<Int64>(X["T_CLIENT_ENTRY_USER_ID"]);o.My_Client.ENTRY_DATE = GV<String>(X["T_CLIENT_ENTRY_DATE"]);o.My_Client.OWNER_ID = GV<Int32>(X["T_CLIENT_OWNER_ID"]);o.My_Client.CLIENT_GENDER = GV<String>(X["T_CLIENT_CLIENT_GENDER"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Package = new Package();
o.My_Package.PACKAGE_ID = GV<Int32>(X["T_PACKAGE_PACKAGE_ID"]);o.My_Package.PACKAGE_NAME = GV<String>(X["T_PACKAGE_PACKAGE_NAME"]);o.My_Package.PACKAGE_PRICE = GV<Int32>(X["T_PACKAGE_PACKAGE_PRICE"]);o.My_Package.CURRENCY_ID = GV<Int32>(X["T_PACKAGE_CURRENCY_ID"]);o.My_Package.ENTRY_USER_ID = GV<Int64>(X["T_PACKAGE_ENTRY_USER_ID"]);o.My_Package.ENTRY_DATE = GV<String>(X["T_PACKAGE_ENTRY_DATE"]);o.My_Package.OWNER_ID = GV<Int32>(X["T_PACKAGE_OWNER_ID"]);o.My_Package.PACKAGE_SESSIONS_NB = GV<Int32>(X["T_PACKAGE_PACKAGE_SESSIONS_NB"]);o.My_Package.PACKAGE_TYPE = GV<String>(X["T_PACKAGE_PACKAGE_TYPE"]);o.My_Package.PACKAGE_ENDING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_ENDING_DATE"]);o.My_Package.PACKAGE_TIMELINE = GV<String>(X["T_PACKAGE_PACKAGE_TIMELINE"]);o.My_Package.PACKAGE_STARTING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_STARTING_DATE"]);o.My_Package.PACKAGE_NB_OF_MONTH = GV<Int32>(X["T_PACKAGE_PACKAGE_NB_OF_MONTH"]);
o.My_Registration = new Registration();
o.My_Registration.REGISTRATION_ID = GV<Int32>(X["T_REGISTRATION_REGISTRATION_ID"]);o.My_Registration.CLIENT_ID = GV<Int32>(X["T_REGISTRATION_CLIENT_ID"]);o.My_Registration.REGISTRATION_DATE = GV<String>(X["T_REGISTRATION_REGISTRATION_DATE"]);o.My_Registration.PACKAGE_ID = GV<Int32>(X["T_REGISTRATION_PACKAGE_ID"]);o.My_Registration.REGISTRATION_DISCOUNT = GV<Int32>(X["T_REGISTRATION_REGISTRATION_DISCOUNT"]);o.My_Registration.REGISTRATION_TOTAL_PRICE = GV<Int32>(X["T_REGISTRATION_REGISTRATION_TOTAL_PRICE"]);o.My_Registration.CURRENCY_ID = GV<Int32>(X["T_REGISTRATION_CURRENCY_ID"]);o.My_Registration.REGISTRATION_DESCRIPTION = GV<String>(X["T_REGISTRATION_REGISTRATION_DESCRIPTION"]);o.My_Registration.ENTRY_USER_ID = GV<Int64>(X["T_REGISTRATION_ENTRY_USER_ID"]);o.My_Registration.ENTRY_DATE = GV<String>(X["T_REGISTRATION_ENTRY_DATE"]);o.My_Registration.OWNER_ID = GV<Int32>(X["T_REGISTRATION_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Client_fees> Get_Client_fees_By_CURRENCY_ID_Adv ( Int32? CURRENCY_ID)
{
List<Client_fees> oList = new List<Client_fees>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID = CURRENCY_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CLIENT_FEES_BY_CURRENCY_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Client_fees o = new Client_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Client = new Client();
o.My_Client.CLIENT_ID = GV<Int32>(X["T_CLIENT_CLIENT_ID"]);o.My_Client.CLIENT_NAME = GV<String>(X["T_CLIENT_CLIENT_NAME"]);o.My_Client.CLIENT_PH_NB = GV<String>(X["T_CLIENT_CLIENT_PH_NB"]);o.My_Client.CLIENT_MAIL = GV<String>(X["T_CLIENT_CLIENT_MAIL"]);o.My_Client.CLIENT_DOB = GV<String>(X["T_CLIENT_CLIENT_DOB"]);o.My_Client.BLOODTYPE_ID = GV<Int32>(X["T_CLIENT_BLOODTYPE_ID"]);o.My_Client.ENTRY_USER_ID = GV<Int64>(X["T_CLIENT_ENTRY_USER_ID"]);o.My_Client.ENTRY_DATE = GV<String>(X["T_CLIENT_ENTRY_DATE"]);o.My_Client.OWNER_ID = GV<Int32>(X["T_CLIENT_OWNER_ID"]);o.My_Client.CLIENT_GENDER = GV<String>(X["T_CLIENT_CLIENT_GENDER"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Package = new Package();
o.My_Package.PACKAGE_ID = GV<Int32>(X["T_PACKAGE_PACKAGE_ID"]);o.My_Package.PACKAGE_NAME = GV<String>(X["T_PACKAGE_PACKAGE_NAME"]);o.My_Package.PACKAGE_PRICE = GV<Int32>(X["T_PACKAGE_PACKAGE_PRICE"]);o.My_Package.CURRENCY_ID = GV<Int32>(X["T_PACKAGE_CURRENCY_ID"]);o.My_Package.ENTRY_USER_ID = GV<Int64>(X["T_PACKAGE_ENTRY_USER_ID"]);o.My_Package.ENTRY_DATE = GV<String>(X["T_PACKAGE_ENTRY_DATE"]);o.My_Package.OWNER_ID = GV<Int32>(X["T_PACKAGE_OWNER_ID"]);o.My_Package.PACKAGE_SESSIONS_NB = GV<Int32>(X["T_PACKAGE_PACKAGE_SESSIONS_NB"]);o.My_Package.PACKAGE_TYPE = GV<String>(X["T_PACKAGE_PACKAGE_TYPE"]);o.My_Package.PACKAGE_ENDING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_ENDING_DATE"]);o.My_Package.PACKAGE_TIMELINE = GV<String>(X["T_PACKAGE_PACKAGE_TIMELINE"]);o.My_Package.PACKAGE_STARTING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_STARTING_DATE"]);o.My_Package.PACKAGE_NB_OF_MONTH = GV<Int32>(X["T_PACKAGE_PACKAGE_NB_OF_MONTH"]);
o.My_Registration = new Registration();
o.My_Registration.REGISTRATION_ID = GV<Int32>(X["T_REGISTRATION_REGISTRATION_ID"]);o.My_Registration.CLIENT_ID = GV<Int32>(X["T_REGISTRATION_CLIENT_ID"]);o.My_Registration.REGISTRATION_DATE = GV<String>(X["T_REGISTRATION_REGISTRATION_DATE"]);o.My_Registration.PACKAGE_ID = GV<Int32>(X["T_REGISTRATION_PACKAGE_ID"]);o.My_Registration.REGISTRATION_DISCOUNT = GV<Int32>(X["T_REGISTRATION_REGISTRATION_DISCOUNT"]);o.My_Registration.REGISTRATION_TOTAL_PRICE = GV<Int32>(X["T_REGISTRATION_REGISTRATION_TOTAL_PRICE"]);o.My_Registration.CURRENCY_ID = GV<Int32>(X["T_REGISTRATION_CURRENCY_ID"]);o.My_Registration.REGISTRATION_DESCRIPTION = GV<String>(X["T_REGISTRATION_REGISTRATION_DESCRIPTION"]);o.My_Registration.ENTRY_USER_ID = GV<Int64>(X["T_REGISTRATION_ENTRY_USER_ID"]);o.My_Registration.ENTRY_DATE = GV<String>(X["T_REGISTRATION_ENTRY_DATE"]);o.My_Registration.OWNER_ID = GV<Int32>(X["T_REGISTRATION_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Client_fees> Get_Client_fees_By_PACKAGE_ID_Adv ( Int32? PACKAGE_ID)
{
List<Client_fees> oList = new List<Client_fees>();
dynamic p = new ExpandoObject();
p.PACKAGE_ID = PACKAGE_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CLIENT_FEES_BY_PACKAGE_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Client_fees o = new Client_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Client = new Client();
o.My_Client.CLIENT_ID = GV<Int32>(X["T_CLIENT_CLIENT_ID"]);o.My_Client.CLIENT_NAME = GV<String>(X["T_CLIENT_CLIENT_NAME"]);o.My_Client.CLIENT_PH_NB = GV<String>(X["T_CLIENT_CLIENT_PH_NB"]);o.My_Client.CLIENT_MAIL = GV<String>(X["T_CLIENT_CLIENT_MAIL"]);o.My_Client.CLIENT_DOB = GV<String>(X["T_CLIENT_CLIENT_DOB"]);o.My_Client.BLOODTYPE_ID = GV<Int32>(X["T_CLIENT_BLOODTYPE_ID"]);o.My_Client.ENTRY_USER_ID = GV<Int64>(X["T_CLIENT_ENTRY_USER_ID"]);o.My_Client.ENTRY_DATE = GV<String>(X["T_CLIENT_ENTRY_DATE"]);o.My_Client.OWNER_ID = GV<Int32>(X["T_CLIENT_OWNER_ID"]);o.My_Client.CLIENT_GENDER = GV<String>(X["T_CLIENT_CLIENT_GENDER"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Package = new Package();
o.My_Package.PACKAGE_ID = GV<Int32>(X["T_PACKAGE_PACKAGE_ID"]);o.My_Package.PACKAGE_NAME = GV<String>(X["T_PACKAGE_PACKAGE_NAME"]);o.My_Package.PACKAGE_PRICE = GV<Int32>(X["T_PACKAGE_PACKAGE_PRICE"]);o.My_Package.CURRENCY_ID = GV<Int32>(X["T_PACKAGE_CURRENCY_ID"]);o.My_Package.ENTRY_USER_ID = GV<Int64>(X["T_PACKAGE_ENTRY_USER_ID"]);o.My_Package.ENTRY_DATE = GV<String>(X["T_PACKAGE_ENTRY_DATE"]);o.My_Package.OWNER_ID = GV<Int32>(X["T_PACKAGE_OWNER_ID"]);o.My_Package.PACKAGE_SESSIONS_NB = GV<Int32>(X["T_PACKAGE_PACKAGE_SESSIONS_NB"]);o.My_Package.PACKAGE_TYPE = GV<String>(X["T_PACKAGE_PACKAGE_TYPE"]);o.My_Package.PACKAGE_ENDING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_ENDING_DATE"]);o.My_Package.PACKAGE_TIMELINE = GV<String>(X["T_PACKAGE_PACKAGE_TIMELINE"]);o.My_Package.PACKAGE_STARTING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_STARTING_DATE"]);o.My_Package.PACKAGE_NB_OF_MONTH = GV<Int32>(X["T_PACKAGE_PACKAGE_NB_OF_MONTH"]);
o.My_Registration = new Registration();
o.My_Registration.REGISTRATION_ID = GV<Int32>(X["T_REGISTRATION_REGISTRATION_ID"]);o.My_Registration.CLIENT_ID = GV<Int32>(X["T_REGISTRATION_CLIENT_ID"]);o.My_Registration.REGISTRATION_DATE = GV<String>(X["T_REGISTRATION_REGISTRATION_DATE"]);o.My_Registration.PACKAGE_ID = GV<Int32>(X["T_REGISTRATION_PACKAGE_ID"]);o.My_Registration.REGISTRATION_DISCOUNT = GV<Int32>(X["T_REGISTRATION_REGISTRATION_DISCOUNT"]);o.My_Registration.REGISTRATION_TOTAL_PRICE = GV<Int32>(X["T_REGISTRATION_REGISTRATION_TOTAL_PRICE"]);o.My_Registration.CURRENCY_ID = GV<Int32>(X["T_REGISTRATION_CURRENCY_ID"]);o.My_Registration.REGISTRATION_DESCRIPTION = GV<String>(X["T_REGISTRATION_REGISTRATION_DESCRIPTION"]);o.My_Registration.ENTRY_USER_ID = GV<Int64>(X["T_REGISTRATION_ENTRY_USER_ID"]);o.My_Registration.ENTRY_DATE = GV<String>(X["T_REGISTRATION_ENTRY_DATE"]);o.My_Registration.OWNER_ID = GV<Int32>(X["T_REGISTRATION_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Client_fees> Get_Client_fees_By_REGISTRATION_ID_Adv ( Int32? REGISTRATION_ID)
{
List<Client_fees> oList = new List<Client_fees>();
dynamic p = new ExpandoObject();
p.REGISTRATION_ID = REGISTRATION_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CLIENT_FEES_BY_REGISTRATION_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Client_fees o = new Client_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Client = new Client();
o.My_Client.CLIENT_ID = GV<Int32>(X["T_CLIENT_CLIENT_ID"]);o.My_Client.CLIENT_NAME = GV<String>(X["T_CLIENT_CLIENT_NAME"]);o.My_Client.CLIENT_PH_NB = GV<String>(X["T_CLIENT_CLIENT_PH_NB"]);o.My_Client.CLIENT_MAIL = GV<String>(X["T_CLIENT_CLIENT_MAIL"]);o.My_Client.CLIENT_DOB = GV<String>(X["T_CLIENT_CLIENT_DOB"]);o.My_Client.BLOODTYPE_ID = GV<Int32>(X["T_CLIENT_BLOODTYPE_ID"]);o.My_Client.ENTRY_USER_ID = GV<Int64>(X["T_CLIENT_ENTRY_USER_ID"]);o.My_Client.ENTRY_DATE = GV<String>(X["T_CLIENT_ENTRY_DATE"]);o.My_Client.OWNER_ID = GV<Int32>(X["T_CLIENT_OWNER_ID"]);o.My_Client.CLIENT_GENDER = GV<String>(X["T_CLIENT_CLIENT_GENDER"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Package = new Package();
o.My_Package.PACKAGE_ID = GV<Int32>(X["T_PACKAGE_PACKAGE_ID"]);o.My_Package.PACKAGE_NAME = GV<String>(X["T_PACKAGE_PACKAGE_NAME"]);o.My_Package.PACKAGE_PRICE = GV<Int32>(X["T_PACKAGE_PACKAGE_PRICE"]);o.My_Package.CURRENCY_ID = GV<Int32>(X["T_PACKAGE_CURRENCY_ID"]);o.My_Package.ENTRY_USER_ID = GV<Int64>(X["T_PACKAGE_ENTRY_USER_ID"]);o.My_Package.ENTRY_DATE = GV<String>(X["T_PACKAGE_ENTRY_DATE"]);o.My_Package.OWNER_ID = GV<Int32>(X["T_PACKAGE_OWNER_ID"]);o.My_Package.PACKAGE_SESSIONS_NB = GV<Int32>(X["T_PACKAGE_PACKAGE_SESSIONS_NB"]);o.My_Package.PACKAGE_TYPE = GV<String>(X["T_PACKAGE_PACKAGE_TYPE"]);o.My_Package.PACKAGE_ENDING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_ENDING_DATE"]);o.My_Package.PACKAGE_TIMELINE = GV<String>(X["T_PACKAGE_PACKAGE_TIMELINE"]);o.My_Package.PACKAGE_STARTING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_STARTING_DATE"]);o.My_Package.PACKAGE_NB_OF_MONTH = GV<Int32>(X["T_PACKAGE_PACKAGE_NB_OF_MONTH"]);
o.My_Registration = new Registration();
o.My_Registration.REGISTRATION_ID = GV<Int32>(X["T_REGISTRATION_REGISTRATION_ID"]);o.My_Registration.CLIENT_ID = GV<Int32>(X["T_REGISTRATION_CLIENT_ID"]);o.My_Registration.REGISTRATION_DATE = GV<String>(X["T_REGISTRATION_REGISTRATION_DATE"]);o.My_Registration.PACKAGE_ID = GV<Int32>(X["T_REGISTRATION_PACKAGE_ID"]);o.My_Registration.REGISTRATION_DISCOUNT = GV<Int32>(X["T_REGISTRATION_REGISTRATION_DISCOUNT"]);o.My_Registration.REGISTRATION_TOTAL_PRICE = GV<Int32>(X["T_REGISTRATION_REGISTRATION_TOTAL_PRICE"]);o.My_Registration.CURRENCY_ID = GV<Int32>(X["T_REGISTRATION_CURRENCY_ID"]);o.My_Registration.REGISTRATION_DESCRIPTION = GV<String>(X["T_REGISTRATION_REGISTRATION_DESCRIPTION"]);o.My_Registration.ENTRY_USER_ID = GV<Int64>(X["T_REGISTRATION_ENTRY_USER_ID"]);o.My_Registration.ENTRY_DATE = GV<String>(X["T_REGISTRATION_ENTRY_DATE"]);o.My_Registration.OWNER_ID = GV<Int32>(X["T_REGISTRATION_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Contact> Get_Contact_By_PERSON_ID_Adv ( long? PERSON_ID)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.PERSON_ID = PERSON_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_PERSON_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
oList.Add(o);
}
}
return oList;
}
public List<Contact> Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT_Adv ( long? PERSON_ID, string CONTACT_TYPE_CODE, string CONTACT)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.PERSON_ID = PERSON_ID; p.CONTACT_TYPE_CODE = CONTACT_TYPE_CODE; p.CONTACT = CONTACT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_PERSON_ID_CONTACT_TYPE_CODE_CONTACT_ADV", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
oList.Add(o);
}
}
return oList;
}
public List<Contact> Get_Contact_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
oList.Add(o);
}
}
return oList;
}
public List<Currency> Get_Currency_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Currency> oList = new List<Currency>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CURRENCY_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Currency o = new Currency();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Fees> Get_Fees_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Fees> oList = new List<Fees>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEES_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Fees o = new Fees();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Fees> Get_Fees_By_CURRENCY_ID_Adv ( Int32? CURRENCY_ID)
{
List<Fees> oList = new List<Fees>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID = CURRENCY_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEES_BY_CURRENCY_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Fees o = new Fees();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_CODE_Adv ( string CODE)
{
List<Loc_l1> oList = new List<Loc_l1>();
dynamic p = new ExpandoObject();
p.CODE = CODE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L1_BY_CODE_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l1 o = new Loc_l1();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Loc_l1> oList = new List<Loc_l1>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L1_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l1 o = new Loc_l1();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_CODE_Adv ( long? LOC_L1_ID, string CODE)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.LOC_L1_ID = LOC_L1_ID; p.CODE = CODE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_LOC_L1_ID_CODE_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_Adv ( long? LOC_L1_ID)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.LOC_L1_ID = LOC_L1_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_LOC_L1_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_CODE_Adv ( long? LOC_L2_ID, string CODE)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.LOC_L2_ID = LOC_L2_ID; p.CODE = CODE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_LOC_L2_ID_CODE_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_Adv ( long? LOC_L2_ID)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.LOC_L2_ID = LOC_L2_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_LOC_L2_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_CODE_Adv ( long? LOC_L3_ID, string CODE)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.LOC_L3_ID = LOC_L3_ID; p.CODE = CODE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_LOC_L3_ID_CODE_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_Adv ( long? LOC_L3_ID)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.LOC_L3_ID = LOC_L3_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_LOC_L3_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Method_run> Get_Method_run_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Method_run> oList = new List<Method_run>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_METHOD_RUN_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Method_run o = new Method_run();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Package> Get_Package_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Package> oList = new List<Package>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PACKAGE_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Package o = new Package();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Package> Get_Package_By_CURRENCY_ID_Adv ( Int32? CURRENCY_ID)
{
List<Package> oList = new List<Package>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID = CURRENCY_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PACKAGE_BY_CURRENCY_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Package o = new Package();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Person> Get_Person_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Person> oList = new List<Person>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PERSON_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Person o = new Person();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Registered_staff_expense> Get_Registered_staff_expense_By_STAFF_ID_Adv ( Int32? STAFF_ID)
{
List<Registered_staff_expense> oList = new List<Registered_staff_expense>();
dynamic p = new ExpandoObject();
p.STAFF_ID = STAFF_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_REGISTERED_STAFF_EXPENSE_BY_STAFF_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Registered_staff_expense o = new Registered_staff_expense();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Staff = new Staff();
o.My_Staff.STAFF_ID = GV<Int32>(X["T_STAFF_STAFF_ID"]);o.My_Staff.STAFF_NAME = GV<String>(X["T_STAFF_STAFF_NAME"]);o.My_Staff.STAFF_PH_NB = GV<String>(X["T_STAFF_STAFF_PH_NB"]);o.My_Staff.STAFF_MAIL = GV<String>(X["T_STAFF_STAFF_MAIL"]);o.My_Staff.STAFF_DOB = GV<String>(X["T_STAFF_STAFF_DOB"]);o.My_Staff.BLOODTYPE_ID = GV<Int32>(X["T_STAFF_BLOODTYPE_ID"]);o.My_Staff.ENTRY_USER_ID = GV<Int64>(X["T_STAFF_ENTRY_USER_ID"]);o.My_Staff.ENTRY_DATE = GV<String>(X["T_STAFF_ENTRY_DATE"]);o.My_Staff.OWNER_ID = GV<Int32>(X["T_STAFF_OWNER_ID"]);o.My_Staff.STAFF_GENDER = GV<String>(X["T_STAFF_STAFF_GENDER"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Registered_staff_expense> Get_Registered_staff_expense_By_CURRENCY_ID_Adv ( Int32? CURRENCY_ID)
{
List<Registered_staff_expense> oList = new List<Registered_staff_expense>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID = CURRENCY_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_REGISTERED_STAFF_EXPENSE_BY_CURRENCY_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Registered_staff_expense o = new Registered_staff_expense();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Staff = new Staff();
o.My_Staff.STAFF_ID = GV<Int32>(X["T_STAFF_STAFF_ID"]);o.My_Staff.STAFF_NAME = GV<String>(X["T_STAFF_STAFF_NAME"]);o.My_Staff.STAFF_PH_NB = GV<String>(X["T_STAFF_STAFF_PH_NB"]);o.My_Staff.STAFF_MAIL = GV<String>(X["T_STAFF_STAFF_MAIL"]);o.My_Staff.STAFF_DOB = GV<String>(X["T_STAFF_STAFF_DOB"]);o.My_Staff.BLOODTYPE_ID = GV<Int32>(X["T_STAFF_BLOODTYPE_ID"]);o.My_Staff.ENTRY_USER_ID = GV<Int64>(X["T_STAFF_ENTRY_USER_ID"]);o.My_Staff.ENTRY_DATE = GV<String>(X["T_STAFF_ENTRY_DATE"]);o.My_Staff.OWNER_ID = GV<Int32>(X["T_STAFF_OWNER_ID"]);o.My_Staff.STAFF_GENDER = GV<String>(X["T_STAFF_STAFF_GENDER"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Registered_staff_expense> Get_Registered_staff_expense_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Registered_staff_expense> oList = new List<Registered_staff_expense>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_REGISTERED_STAFF_EXPENSE_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Registered_staff_expense o = new Registered_staff_expense();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Staff = new Staff();
o.My_Staff.STAFF_ID = GV<Int32>(X["T_STAFF_STAFF_ID"]);o.My_Staff.STAFF_NAME = GV<String>(X["T_STAFF_STAFF_NAME"]);o.My_Staff.STAFF_PH_NB = GV<String>(X["T_STAFF_STAFF_PH_NB"]);o.My_Staff.STAFF_MAIL = GV<String>(X["T_STAFF_STAFF_MAIL"]);o.My_Staff.STAFF_DOB = GV<String>(X["T_STAFF_STAFF_DOB"]);o.My_Staff.BLOODTYPE_ID = GV<Int32>(X["T_STAFF_BLOODTYPE_ID"]);o.My_Staff.ENTRY_USER_ID = GV<Int64>(X["T_STAFF_ENTRY_USER_ID"]);o.My_Staff.ENTRY_DATE = GV<String>(X["T_STAFF_ENTRY_DATE"]);o.My_Staff.OWNER_ID = GV<Int32>(X["T_STAFF_OWNER_ID"]);o.My_Staff.STAFF_GENDER = GV<String>(X["T_STAFF_STAFF_GENDER"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Registered_supplier_expense> Get_Registered_supplier_expense_By_SUPPLIER_ID_Adv ( Int32? SUPPLIER_ID)
{
List<Registered_supplier_expense> oList = new List<Registered_supplier_expense>();
dynamic p = new ExpandoObject();
p.SUPPLIER_ID = SUPPLIER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_REGISTERED_SUPPLIER_EXPENSE_BY_SUPPLIER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Registered_supplier_expense o = new Registered_supplier_expense();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Supplier = new Supplier();
o.My_Supplier.SUPPLIER_ID = GV<Int32>(X["T_SUPPLIER_SUPPLIER_ID"]);o.My_Supplier.SUPPLIER_NAME = GV<String>(X["T_SUPPLIER_SUPPLIER_NAME"]);o.My_Supplier.SUPPLIER_PH_NB = GV<String>(X["T_SUPPLIER_SUPPLIER_PH_NB"]);o.My_Supplier.SUPPLIER_MAIL = GV<String>(X["T_SUPPLIER_SUPPLIER_MAIL"]);o.My_Supplier.ENTRY_USER_ID = GV<Int64>(X["T_SUPPLIER_ENTRY_USER_ID"]);o.My_Supplier.ENTRY_DATE = GV<String>(X["T_SUPPLIER_ENTRY_DATE"]);o.My_Supplier.OWNER_ID = GV<Int32>(X["T_SUPPLIER_OWNER_ID"]);o.My_Supplier.SUPPLIER_DOB = GV<String>(X["T_SUPPLIER_SUPPLIER_DOB"]);o.My_Supplier.BLOODTYPE_ID = GV<Int32>(X["T_SUPPLIER_BLOODTYPE_ID"]);o.My_Supplier.SUPPLIER_GENDER = GV<String>(X["T_SUPPLIER_SUPPLIER_GENDER"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Registered_supplier_expense> Get_Registered_supplier_expense_By_CURRENCY_ID_Adv ( Int32? CURRENCY_ID)
{
List<Registered_supplier_expense> oList = new List<Registered_supplier_expense>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID = CURRENCY_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_REGISTERED_SUPPLIER_EXPENSE_BY_CURRENCY_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Registered_supplier_expense o = new Registered_supplier_expense();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Supplier = new Supplier();
o.My_Supplier.SUPPLIER_ID = GV<Int32>(X["T_SUPPLIER_SUPPLIER_ID"]);o.My_Supplier.SUPPLIER_NAME = GV<String>(X["T_SUPPLIER_SUPPLIER_NAME"]);o.My_Supplier.SUPPLIER_PH_NB = GV<String>(X["T_SUPPLIER_SUPPLIER_PH_NB"]);o.My_Supplier.SUPPLIER_MAIL = GV<String>(X["T_SUPPLIER_SUPPLIER_MAIL"]);o.My_Supplier.ENTRY_USER_ID = GV<Int64>(X["T_SUPPLIER_ENTRY_USER_ID"]);o.My_Supplier.ENTRY_DATE = GV<String>(X["T_SUPPLIER_ENTRY_DATE"]);o.My_Supplier.OWNER_ID = GV<Int32>(X["T_SUPPLIER_OWNER_ID"]);o.My_Supplier.SUPPLIER_DOB = GV<String>(X["T_SUPPLIER_SUPPLIER_DOB"]);o.My_Supplier.BLOODTYPE_ID = GV<Int32>(X["T_SUPPLIER_BLOODTYPE_ID"]);o.My_Supplier.SUPPLIER_GENDER = GV<String>(X["T_SUPPLIER_SUPPLIER_GENDER"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Registered_supplier_expense> Get_Registered_supplier_expense_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Registered_supplier_expense> oList = new List<Registered_supplier_expense>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_REGISTERED_SUPPLIER_EXPENSE_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Registered_supplier_expense o = new Registered_supplier_expense();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Supplier = new Supplier();
o.My_Supplier.SUPPLIER_ID = GV<Int32>(X["T_SUPPLIER_SUPPLIER_ID"]);o.My_Supplier.SUPPLIER_NAME = GV<String>(X["T_SUPPLIER_SUPPLIER_NAME"]);o.My_Supplier.SUPPLIER_PH_NB = GV<String>(X["T_SUPPLIER_SUPPLIER_PH_NB"]);o.My_Supplier.SUPPLIER_MAIL = GV<String>(X["T_SUPPLIER_SUPPLIER_MAIL"]);o.My_Supplier.ENTRY_USER_ID = GV<Int64>(X["T_SUPPLIER_ENTRY_USER_ID"]);o.My_Supplier.ENTRY_DATE = GV<String>(X["T_SUPPLIER_ENTRY_DATE"]);o.My_Supplier.OWNER_ID = GV<Int32>(X["T_SUPPLIER_OWNER_ID"]);o.My_Supplier.SUPPLIER_DOB = GV<String>(X["T_SUPPLIER_SUPPLIER_DOB"]);o.My_Supplier.BLOODTYPE_ID = GV<Int32>(X["T_SUPPLIER_BLOODTYPE_ID"]);o.My_Supplier.SUPPLIER_GENDER = GV<String>(X["T_SUPPLIER_SUPPLIER_GENDER"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Registration> Get_Registration_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Registration> oList = new List<Registration>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_REGISTRATION_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Registration o = new Registration();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Client = new Client();
o.My_Client.CLIENT_ID = GV<Int32>(X["T_CLIENT_CLIENT_ID"]);o.My_Client.CLIENT_NAME = GV<String>(X["T_CLIENT_CLIENT_NAME"]);o.My_Client.CLIENT_PH_NB = GV<String>(X["T_CLIENT_CLIENT_PH_NB"]);o.My_Client.CLIENT_MAIL = GV<String>(X["T_CLIENT_CLIENT_MAIL"]);o.My_Client.CLIENT_DOB = GV<String>(X["T_CLIENT_CLIENT_DOB"]);o.My_Client.BLOODTYPE_ID = GV<Int32>(X["T_CLIENT_BLOODTYPE_ID"]);o.My_Client.ENTRY_USER_ID = GV<Int64>(X["T_CLIENT_ENTRY_USER_ID"]);o.My_Client.ENTRY_DATE = GV<String>(X["T_CLIENT_ENTRY_DATE"]);o.My_Client.OWNER_ID = GV<Int32>(X["T_CLIENT_OWNER_ID"]);o.My_Client.CLIENT_GENDER = GV<String>(X["T_CLIENT_CLIENT_GENDER"]);
o.My_Package = new Package();
o.My_Package.PACKAGE_ID = GV<Int32>(X["T_PACKAGE_PACKAGE_ID"]);o.My_Package.PACKAGE_NAME = GV<String>(X["T_PACKAGE_PACKAGE_NAME"]);o.My_Package.PACKAGE_PRICE = GV<Int32>(X["T_PACKAGE_PACKAGE_PRICE"]);o.My_Package.CURRENCY_ID = GV<Int32>(X["T_PACKAGE_CURRENCY_ID"]);o.My_Package.ENTRY_USER_ID = GV<Int64>(X["T_PACKAGE_ENTRY_USER_ID"]);o.My_Package.ENTRY_DATE = GV<String>(X["T_PACKAGE_ENTRY_DATE"]);o.My_Package.OWNER_ID = GV<Int32>(X["T_PACKAGE_OWNER_ID"]);o.My_Package.PACKAGE_SESSIONS_NB = GV<Int32>(X["T_PACKAGE_PACKAGE_SESSIONS_NB"]);o.My_Package.PACKAGE_TYPE = GV<String>(X["T_PACKAGE_PACKAGE_TYPE"]);o.My_Package.PACKAGE_ENDING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_ENDING_DATE"]);o.My_Package.PACKAGE_TIMELINE = GV<String>(X["T_PACKAGE_PACKAGE_TIMELINE"]);o.My_Package.PACKAGE_STARTING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_STARTING_DATE"]);o.My_Package.PACKAGE_NB_OF_MONTH = GV<Int32>(X["T_PACKAGE_PACKAGE_NB_OF_MONTH"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Registration> Get_Registration_By_CLIENT_ID_Adv ( Int32? CLIENT_ID)
{
List<Registration> oList = new List<Registration>();
dynamic p = new ExpandoObject();
p.CLIENT_ID = CLIENT_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_REGISTRATION_BY_CLIENT_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Registration o = new Registration();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Client = new Client();
o.My_Client.CLIENT_ID = GV<Int32>(X["T_CLIENT_CLIENT_ID"]);o.My_Client.CLIENT_NAME = GV<String>(X["T_CLIENT_CLIENT_NAME"]);o.My_Client.CLIENT_PH_NB = GV<String>(X["T_CLIENT_CLIENT_PH_NB"]);o.My_Client.CLIENT_MAIL = GV<String>(X["T_CLIENT_CLIENT_MAIL"]);o.My_Client.CLIENT_DOB = GV<String>(X["T_CLIENT_CLIENT_DOB"]);o.My_Client.BLOODTYPE_ID = GV<Int32>(X["T_CLIENT_BLOODTYPE_ID"]);o.My_Client.ENTRY_USER_ID = GV<Int64>(X["T_CLIENT_ENTRY_USER_ID"]);o.My_Client.ENTRY_DATE = GV<String>(X["T_CLIENT_ENTRY_DATE"]);o.My_Client.OWNER_ID = GV<Int32>(X["T_CLIENT_OWNER_ID"]);o.My_Client.CLIENT_GENDER = GV<String>(X["T_CLIENT_CLIENT_GENDER"]);
o.My_Package = new Package();
o.My_Package.PACKAGE_ID = GV<Int32>(X["T_PACKAGE_PACKAGE_ID"]);o.My_Package.PACKAGE_NAME = GV<String>(X["T_PACKAGE_PACKAGE_NAME"]);o.My_Package.PACKAGE_PRICE = GV<Int32>(X["T_PACKAGE_PACKAGE_PRICE"]);o.My_Package.CURRENCY_ID = GV<Int32>(X["T_PACKAGE_CURRENCY_ID"]);o.My_Package.ENTRY_USER_ID = GV<Int64>(X["T_PACKAGE_ENTRY_USER_ID"]);o.My_Package.ENTRY_DATE = GV<String>(X["T_PACKAGE_ENTRY_DATE"]);o.My_Package.OWNER_ID = GV<Int32>(X["T_PACKAGE_OWNER_ID"]);o.My_Package.PACKAGE_SESSIONS_NB = GV<Int32>(X["T_PACKAGE_PACKAGE_SESSIONS_NB"]);o.My_Package.PACKAGE_TYPE = GV<String>(X["T_PACKAGE_PACKAGE_TYPE"]);o.My_Package.PACKAGE_ENDING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_ENDING_DATE"]);o.My_Package.PACKAGE_TIMELINE = GV<String>(X["T_PACKAGE_PACKAGE_TIMELINE"]);o.My_Package.PACKAGE_STARTING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_STARTING_DATE"]);o.My_Package.PACKAGE_NB_OF_MONTH = GV<Int32>(X["T_PACKAGE_PACKAGE_NB_OF_MONTH"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Registration> Get_Registration_By_PACKAGE_ID_Adv ( Int32? PACKAGE_ID)
{
List<Registration> oList = new List<Registration>();
dynamic p = new ExpandoObject();
p.PACKAGE_ID = PACKAGE_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_REGISTRATION_BY_PACKAGE_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Registration o = new Registration();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Client = new Client();
o.My_Client.CLIENT_ID = GV<Int32>(X["T_CLIENT_CLIENT_ID"]);o.My_Client.CLIENT_NAME = GV<String>(X["T_CLIENT_CLIENT_NAME"]);o.My_Client.CLIENT_PH_NB = GV<String>(X["T_CLIENT_CLIENT_PH_NB"]);o.My_Client.CLIENT_MAIL = GV<String>(X["T_CLIENT_CLIENT_MAIL"]);o.My_Client.CLIENT_DOB = GV<String>(X["T_CLIENT_CLIENT_DOB"]);o.My_Client.BLOODTYPE_ID = GV<Int32>(X["T_CLIENT_BLOODTYPE_ID"]);o.My_Client.ENTRY_USER_ID = GV<Int64>(X["T_CLIENT_ENTRY_USER_ID"]);o.My_Client.ENTRY_DATE = GV<String>(X["T_CLIENT_ENTRY_DATE"]);o.My_Client.OWNER_ID = GV<Int32>(X["T_CLIENT_OWNER_ID"]);o.My_Client.CLIENT_GENDER = GV<String>(X["T_CLIENT_CLIENT_GENDER"]);
o.My_Package = new Package();
o.My_Package.PACKAGE_ID = GV<Int32>(X["T_PACKAGE_PACKAGE_ID"]);o.My_Package.PACKAGE_NAME = GV<String>(X["T_PACKAGE_PACKAGE_NAME"]);o.My_Package.PACKAGE_PRICE = GV<Int32>(X["T_PACKAGE_PACKAGE_PRICE"]);o.My_Package.CURRENCY_ID = GV<Int32>(X["T_PACKAGE_CURRENCY_ID"]);o.My_Package.ENTRY_USER_ID = GV<Int64>(X["T_PACKAGE_ENTRY_USER_ID"]);o.My_Package.ENTRY_DATE = GV<String>(X["T_PACKAGE_ENTRY_DATE"]);o.My_Package.OWNER_ID = GV<Int32>(X["T_PACKAGE_OWNER_ID"]);o.My_Package.PACKAGE_SESSIONS_NB = GV<Int32>(X["T_PACKAGE_PACKAGE_SESSIONS_NB"]);o.My_Package.PACKAGE_TYPE = GV<String>(X["T_PACKAGE_PACKAGE_TYPE"]);o.My_Package.PACKAGE_ENDING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_ENDING_DATE"]);o.My_Package.PACKAGE_TIMELINE = GV<String>(X["T_PACKAGE_PACKAGE_TIMELINE"]);o.My_Package.PACKAGE_STARTING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_STARTING_DATE"]);o.My_Package.PACKAGE_NB_OF_MONTH = GV<Int32>(X["T_PACKAGE_PACKAGE_NB_OF_MONTH"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Registration> Get_Registration_By_CURRENCY_ID_Adv ( Int32? CURRENCY_ID)
{
List<Registration> oList = new List<Registration>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID = CURRENCY_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_REGISTRATION_BY_CURRENCY_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Registration o = new Registration();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Client = new Client();
o.My_Client.CLIENT_ID = GV<Int32>(X["T_CLIENT_CLIENT_ID"]);o.My_Client.CLIENT_NAME = GV<String>(X["T_CLIENT_CLIENT_NAME"]);o.My_Client.CLIENT_PH_NB = GV<String>(X["T_CLIENT_CLIENT_PH_NB"]);o.My_Client.CLIENT_MAIL = GV<String>(X["T_CLIENT_CLIENT_MAIL"]);o.My_Client.CLIENT_DOB = GV<String>(X["T_CLIENT_CLIENT_DOB"]);o.My_Client.BLOODTYPE_ID = GV<Int32>(X["T_CLIENT_BLOODTYPE_ID"]);o.My_Client.ENTRY_USER_ID = GV<Int64>(X["T_CLIENT_ENTRY_USER_ID"]);o.My_Client.ENTRY_DATE = GV<String>(X["T_CLIENT_ENTRY_DATE"]);o.My_Client.OWNER_ID = GV<Int32>(X["T_CLIENT_OWNER_ID"]);o.My_Client.CLIENT_GENDER = GV<String>(X["T_CLIENT_CLIENT_GENDER"]);
o.My_Package = new Package();
o.My_Package.PACKAGE_ID = GV<Int32>(X["T_PACKAGE_PACKAGE_ID"]);o.My_Package.PACKAGE_NAME = GV<String>(X["T_PACKAGE_PACKAGE_NAME"]);o.My_Package.PACKAGE_PRICE = GV<Int32>(X["T_PACKAGE_PACKAGE_PRICE"]);o.My_Package.CURRENCY_ID = GV<Int32>(X["T_PACKAGE_CURRENCY_ID"]);o.My_Package.ENTRY_USER_ID = GV<Int64>(X["T_PACKAGE_ENTRY_USER_ID"]);o.My_Package.ENTRY_DATE = GV<String>(X["T_PACKAGE_ENTRY_DATE"]);o.My_Package.OWNER_ID = GV<Int32>(X["T_PACKAGE_OWNER_ID"]);o.My_Package.PACKAGE_SESSIONS_NB = GV<Int32>(X["T_PACKAGE_PACKAGE_SESSIONS_NB"]);o.My_Package.PACKAGE_TYPE = GV<String>(X["T_PACKAGE_PACKAGE_TYPE"]);o.My_Package.PACKAGE_ENDING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_ENDING_DATE"]);o.My_Package.PACKAGE_TIMELINE = GV<String>(X["T_PACKAGE_PACKAGE_TIMELINE"]);o.My_Package.PACKAGE_STARTING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_STARTING_DATE"]);o.My_Package.PACKAGE_NB_OF_MONTH = GV<Int32>(X["T_PACKAGE_PACKAGE_NB_OF_MONTH"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Session> Get_Session_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Session> oList = new List<Session>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SESSION_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Session o = new Session();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Package = new Package();
o.My_Package.PACKAGE_ID = GV<Int32>(X["T_PACKAGE_PACKAGE_ID"]);o.My_Package.PACKAGE_NAME = GV<String>(X["T_PACKAGE_PACKAGE_NAME"]);o.My_Package.PACKAGE_PRICE = GV<Int32>(X["T_PACKAGE_PACKAGE_PRICE"]);o.My_Package.CURRENCY_ID = GV<Int32>(X["T_PACKAGE_CURRENCY_ID"]);o.My_Package.ENTRY_USER_ID = GV<Int64>(X["T_PACKAGE_ENTRY_USER_ID"]);o.My_Package.ENTRY_DATE = GV<String>(X["T_PACKAGE_ENTRY_DATE"]);o.My_Package.OWNER_ID = GV<Int32>(X["T_PACKAGE_OWNER_ID"]);o.My_Package.PACKAGE_SESSIONS_NB = GV<Int32>(X["T_PACKAGE_PACKAGE_SESSIONS_NB"]);o.My_Package.PACKAGE_TYPE = GV<String>(X["T_PACKAGE_PACKAGE_TYPE"]);o.My_Package.PACKAGE_ENDING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_ENDING_DATE"]);o.My_Package.PACKAGE_TIMELINE = GV<String>(X["T_PACKAGE_PACKAGE_TIMELINE"]);o.My_Package.PACKAGE_STARTING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_STARTING_DATE"]);o.My_Package.PACKAGE_NB_OF_MONTH = GV<Int32>(X["T_PACKAGE_PACKAGE_NB_OF_MONTH"]);
o.My_Client_fees = new Client_fees();
o.My_Client_fees.CLIENT_FEES_ID = GV<Int32>(X["T_CLIENT_FEES_CLIENT_FEES_ID"]);o.My_Client_fees.CLIENT_ID = GV<Int32>(X["T_CLIENT_FEES_CLIENT_ID"]);o.My_Client_fees.CLIENT_FEES_DESCRIPTION = GV<String>(X["T_CLIENT_FEES_CLIENT_FEES_DESCRIPTION"]);o.My_Client_fees.ENTRY_USER_ID = GV<Int64>(X["T_CLIENT_FEES_ENTRY_USER_ID"]);o.My_Client_fees.ENTRY_DATE = GV<String>(X["T_CLIENT_FEES_ENTRY_DATE"]);o.My_Client_fees.OWNER_ID = GV<Int32>(X["T_CLIENT_FEES_OWNER_ID"]);o.My_Client_fees.CURRENCY_ID = GV<Int32>(X["T_CLIENT_FEES_CURRENCY_ID"]);o.My_Client_fees.PACKAGE_ID = GV<Int32>(X["T_CLIENT_FEES_PACKAGE_ID"]);o.My_Client_fees.CLIENT_FEES_AMOUNT = GV<Int32>(X["T_CLIENT_FEES_CLIENT_FEES_AMOUNT"]);o.My_Client_fees.REGISTRATION_ID = GV<Int32>(X["T_CLIENT_FEES_REGISTRATION_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Session> Get_Session_By_PACKAGE_ID_Adv ( Int32? PACKAGE_ID)
{
List<Session> oList = new List<Session>();
dynamic p = new ExpandoObject();
p.PACKAGE_ID = PACKAGE_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SESSION_BY_PACKAGE_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Session o = new Session();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Package = new Package();
o.My_Package.PACKAGE_ID = GV<Int32>(X["T_PACKAGE_PACKAGE_ID"]);o.My_Package.PACKAGE_NAME = GV<String>(X["T_PACKAGE_PACKAGE_NAME"]);o.My_Package.PACKAGE_PRICE = GV<Int32>(X["T_PACKAGE_PACKAGE_PRICE"]);o.My_Package.CURRENCY_ID = GV<Int32>(X["T_PACKAGE_CURRENCY_ID"]);o.My_Package.ENTRY_USER_ID = GV<Int64>(X["T_PACKAGE_ENTRY_USER_ID"]);o.My_Package.ENTRY_DATE = GV<String>(X["T_PACKAGE_ENTRY_DATE"]);o.My_Package.OWNER_ID = GV<Int32>(X["T_PACKAGE_OWNER_ID"]);o.My_Package.PACKAGE_SESSIONS_NB = GV<Int32>(X["T_PACKAGE_PACKAGE_SESSIONS_NB"]);o.My_Package.PACKAGE_TYPE = GV<String>(X["T_PACKAGE_PACKAGE_TYPE"]);o.My_Package.PACKAGE_ENDING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_ENDING_DATE"]);o.My_Package.PACKAGE_TIMELINE = GV<String>(X["T_PACKAGE_PACKAGE_TIMELINE"]);o.My_Package.PACKAGE_STARTING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_STARTING_DATE"]);o.My_Package.PACKAGE_NB_OF_MONTH = GV<Int32>(X["T_PACKAGE_PACKAGE_NB_OF_MONTH"]);
o.My_Client_fees = new Client_fees();
o.My_Client_fees.CLIENT_FEES_ID = GV<Int32>(X["T_CLIENT_FEES_CLIENT_FEES_ID"]);o.My_Client_fees.CLIENT_ID = GV<Int32>(X["T_CLIENT_FEES_CLIENT_ID"]);o.My_Client_fees.CLIENT_FEES_DESCRIPTION = GV<String>(X["T_CLIENT_FEES_CLIENT_FEES_DESCRIPTION"]);o.My_Client_fees.ENTRY_USER_ID = GV<Int64>(X["T_CLIENT_FEES_ENTRY_USER_ID"]);o.My_Client_fees.ENTRY_DATE = GV<String>(X["T_CLIENT_FEES_ENTRY_DATE"]);o.My_Client_fees.OWNER_ID = GV<Int32>(X["T_CLIENT_FEES_OWNER_ID"]);o.My_Client_fees.CURRENCY_ID = GV<Int32>(X["T_CLIENT_FEES_CURRENCY_ID"]);o.My_Client_fees.PACKAGE_ID = GV<Int32>(X["T_CLIENT_FEES_PACKAGE_ID"]);o.My_Client_fees.CLIENT_FEES_AMOUNT = GV<Int32>(X["T_CLIENT_FEES_CLIENT_FEES_AMOUNT"]);o.My_Client_fees.REGISTRATION_ID = GV<Int32>(X["T_CLIENT_FEES_REGISTRATION_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Session> Get_Session_By_CLIENT_FEES_ID_Adv ( Int32? CLIENT_FEES_ID)
{
List<Session> oList = new List<Session>();
dynamic p = new ExpandoObject();
p.CLIENT_FEES_ID = CLIENT_FEES_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SESSION_BY_CLIENT_FEES_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Session o = new Session();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Package = new Package();
o.My_Package.PACKAGE_ID = GV<Int32>(X["T_PACKAGE_PACKAGE_ID"]);o.My_Package.PACKAGE_NAME = GV<String>(X["T_PACKAGE_PACKAGE_NAME"]);o.My_Package.PACKAGE_PRICE = GV<Int32>(X["T_PACKAGE_PACKAGE_PRICE"]);o.My_Package.CURRENCY_ID = GV<Int32>(X["T_PACKAGE_CURRENCY_ID"]);o.My_Package.ENTRY_USER_ID = GV<Int64>(X["T_PACKAGE_ENTRY_USER_ID"]);o.My_Package.ENTRY_DATE = GV<String>(X["T_PACKAGE_ENTRY_DATE"]);o.My_Package.OWNER_ID = GV<Int32>(X["T_PACKAGE_OWNER_ID"]);o.My_Package.PACKAGE_SESSIONS_NB = GV<Int32>(X["T_PACKAGE_PACKAGE_SESSIONS_NB"]);o.My_Package.PACKAGE_TYPE = GV<String>(X["T_PACKAGE_PACKAGE_TYPE"]);o.My_Package.PACKAGE_ENDING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_ENDING_DATE"]);o.My_Package.PACKAGE_TIMELINE = GV<String>(X["T_PACKAGE_PACKAGE_TIMELINE"]);o.My_Package.PACKAGE_STARTING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_STARTING_DATE"]);o.My_Package.PACKAGE_NB_OF_MONTH = GV<Int32>(X["T_PACKAGE_PACKAGE_NB_OF_MONTH"]);
o.My_Client_fees = new Client_fees();
o.My_Client_fees.CLIENT_FEES_ID = GV<Int32>(X["T_CLIENT_FEES_CLIENT_FEES_ID"]);o.My_Client_fees.CLIENT_ID = GV<Int32>(X["T_CLIENT_FEES_CLIENT_ID"]);o.My_Client_fees.CLIENT_FEES_DESCRIPTION = GV<String>(X["T_CLIENT_FEES_CLIENT_FEES_DESCRIPTION"]);o.My_Client_fees.ENTRY_USER_ID = GV<Int64>(X["T_CLIENT_FEES_ENTRY_USER_ID"]);o.My_Client_fees.ENTRY_DATE = GV<String>(X["T_CLIENT_FEES_ENTRY_DATE"]);o.My_Client_fees.OWNER_ID = GV<Int32>(X["T_CLIENT_FEES_OWNER_ID"]);o.My_Client_fees.CURRENCY_ID = GV<Int32>(X["T_CLIENT_FEES_CURRENCY_ID"]);o.My_Client_fees.PACKAGE_ID = GV<Int32>(X["T_CLIENT_FEES_PACKAGE_ID"]);o.My_Client_fees.CLIENT_FEES_AMOUNT = GV<Int32>(X["T_CLIENT_FEES_CLIENT_FEES_AMOUNT"]);o.My_Client_fees.REGISTRATION_ID = GV<Int32>(X["T_CLIENT_FEES_REGISTRATION_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Staff> Get_Staff_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Staff> oList = new List<Staff>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Staff o = new Staff();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Bloodtype = new Bloodtype();
o.My_Bloodtype.BLOODTYPE_ID = GV<Int32>(X["T_BLOODTYPE_BLOODTYPE_ID"]);o.My_Bloodtype.BLOODTYPE_SYMBOL = GV<String>(X["T_BLOODTYPE_BLOODTYPE_SYMBOL"]);o.My_Bloodtype.ENTRY_USER_ID = GV<Int64>(X["T_BLOODTYPE_ENTRY_USER_ID"]);o.My_Bloodtype.ENTRY_DATE = GV<String>(X["T_BLOODTYPE_ENTRY_DATE"]);o.My_Bloodtype.OWNER_ID = GV<Int32>(X["T_BLOODTYPE_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Staff> Get_Staff_By_BLOODTYPE_ID_Adv ( Int32? BLOODTYPE_ID)
{
List<Staff> oList = new List<Staff>();
dynamic p = new ExpandoObject();
p.BLOODTYPE_ID = BLOODTYPE_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_BY_BLOODTYPE_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Staff o = new Staff();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Bloodtype = new Bloodtype();
o.My_Bloodtype.BLOODTYPE_ID = GV<Int32>(X["T_BLOODTYPE_BLOODTYPE_ID"]);o.My_Bloodtype.BLOODTYPE_SYMBOL = GV<String>(X["T_BLOODTYPE_BLOODTYPE_SYMBOL"]);o.My_Bloodtype.ENTRY_USER_ID = GV<Int64>(X["T_BLOODTYPE_ENTRY_USER_ID"]);o.My_Bloodtype.ENTRY_DATE = GV<String>(X["T_BLOODTYPE_ENTRY_DATE"]);o.My_Bloodtype.OWNER_ID = GV<Int32>(X["T_BLOODTYPE_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Staff_fees> Get_Staff_fees_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Staff_fees> oList = new List<Staff_fees>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_FEES_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Staff_fees o = new Staff_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Staff = new Staff();
o.My_Staff.STAFF_ID = GV<Int32>(X["T_STAFF_STAFF_ID"]);o.My_Staff.STAFF_NAME = GV<String>(X["T_STAFF_STAFF_NAME"]);o.My_Staff.STAFF_PH_NB = GV<String>(X["T_STAFF_STAFF_PH_NB"]);o.My_Staff.STAFF_MAIL = GV<String>(X["T_STAFF_STAFF_MAIL"]);o.My_Staff.STAFF_DOB = GV<String>(X["T_STAFF_STAFF_DOB"]);o.My_Staff.BLOODTYPE_ID = GV<Int32>(X["T_STAFF_BLOODTYPE_ID"]);o.My_Staff.ENTRY_USER_ID = GV<Int64>(X["T_STAFF_ENTRY_USER_ID"]);o.My_Staff.ENTRY_DATE = GV<String>(X["T_STAFF_ENTRY_DATE"]);o.My_Staff.OWNER_ID = GV<Int32>(X["T_STAFF_OWNER_ID"]);o.My_Staff.STAFF_GENDER = GV<String>(X["T_STAFF_STAFF_GENDER"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Registered_staff_expense = new Registered_staff_expense();
o.My_Registered_staff_expense.REGISTERED_STAFF_EXPENSE_ID = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_REGISTERED_STAFF_EXPENSE_ID"]);o.My_Registered_staff_expense.REGISTERED_STAFF_EXPENSE_DISCOUNT = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_REGISTERED_STAFF_EXPENSE_DISCOUNT"]);o.My_Registered_staff_expense.REGISTERED_STAFF_EXPENSE_TOTAL_AMOUNT = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_REGISTERED_STAFF_EXPENSE_TOTAL_AMOUNT"]);o.My_Registered_staff_expense.REGISTERED_STAFF_EXPENSE_DESCRIPTION = GV<String>(X["T_REGISTERED_STAFF_EXPENSE_REGISTERED_STAFF_EXPENSE_DESCRIPTION"]);o.My_Registered_staff_expense.STAFF_ID = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_STAFF_ID"]);o.My_Registered_staff_expense.CURRENCY_ID = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_CURRENCY_ID"]);o.My_Registered_staff_expense.ENTRY_USER_ID = GV<Int64>(X["T_REGISTERED_STAFF_EXPENSE_ENTRY_USER_ID"]);o.My_Registered_staff_expense.ENTRY_DATE = GV<String>(X["T_REGISTERED_STAFF_EXPENSE_ENTRY_DATE"]);o.My_Registered_staff_expense.OWNER_ID = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Staff_fees> Get_Staff_fees_By_STAFF_ID_Adv ( Int32? STAFF_ID)
{
List<Staff_fees> oList = new List<Staff_fees>();
dynamic p = new ExpandoObject();
p.STAFF_ID = STAFF_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_FEES_BY_STAFF_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Staff_fees o = new Staff_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Staff = new Staff();
o.My_Staff.STAFF_ID = GV<Int32>(X["T_STAFF_STAFF_ID"]);o.My_Staff.STAFF_NAME = GV<String>(X["T_STAFF_STAFF_NAME"]);o.My_Staff.STAFF_PH_NB = GV<String>(X["T_STAFF_STAFF_PH_NB"]);o.My_Staff.STAFF_MAIL = GV<String>(X["T_STAFF_STAFF_MAIL"]);o.My_Staff.STAFF_DOB = GV<String>(X["T_STAFF_STAFF_DOB"]);o.My_Staff.BLOODTYPE_ID = GV<Int32>(X["T_STAFF_BLOODTYPE_ID"]);o.My_Staff.ENTRY_USER_ID = GV<Int64>(X["T_STAFF_ENTRY_USER_ID"]);o.My_Staff.ENTRY_DATE = GV<String>(X["T_STAFF_ENTRY_DATE"]);o.My_Staff.OWNER_ID = GV<Int32>(X["T_STAFF_OWNER_ID"]);o.My_Staff.STAFF_GENDER = GV<String>(X["T_STAFF_STAFF_GENDER"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Registered_staff_expense = new Registered_staff_expense();
o.My_Registered_staff_expense.REGISTERED_STAFF_EXPENSE_ID = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_REGISTERED_STAFF_EXPENSE_ID"]);o.My_Registered_staff_expense.REGISTERED_STAFF_EXPENSE_DISCOUNT = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_REGISTERED_STAFF_EXPENSE_DISCOUNT"]);o.My_Registered_staff_expense.REGISTERED_STAFF_EXPENSE_TOTAL_AMOUNT = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_REGISTERED_STAFF_EXPENSE_TOTAL_AMOUNT"]);o.My_Registered_staff_expense.REGISTERED_STAFF_EXPENSE_DESCRIPTION = GV<String>(X["T_REGISTERED_STAFF_EXPENSE_REGISTERED_STAFF_EXPENSE_DESCRIPTION"]);o.My_Registered_staff_expense.STAFF_ID = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_STAFF_ID"]);o.My_Registered_staff_expense.CURRENCY_ID = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_CURRENCY_ID"]);o.My_Registered_staff_expense.ENTRY_USER_ID = GV<Int64>(X["T_REGISTERED_STAFF_EXPENSE_ENTRY_USER_ID"]);o.My_Registered_staff_expense.ENTRY_DATE = GV<String>(X["T_REGISTERED_STAFF_EXPENSE_ENTRY_DATE"]);o.My_Registered_staff_expense.OWNER_ID = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Staff_fees> Get_Staff_fees_By_CURRENCY_ID_Adv ( Int32? CURRENCY_ID)
{
List<Staff_fees> oList = new List<Staff_fees>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID = CURRENCY_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_FEES_BY_CURRENCY_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Staff_fees o = new Staff_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Staff = new Staff();
o.My_Staff.STAFF_ID = GV<Int32>(X["T_STAFF_STAFF_ID"]);o.My_Staff.STAFF_NAME = GV<String>(X["T_STAFF_STAFF_NAME"]);o.My_Staff.STAFF_PH_NB = GV<String>(X["T_STAFF_STAFF_PH_NB"]);o.My_Staff.STAFF_MAIL = GV<String>(X["T_STAFF_STAFF_MAIL"]);o.My_Staff.STAFF_DOB = GV<String>(X["T_STAFF_STAFF_DOB"]);o.My_Staff.BLOODTYPE_ID = GV<Int32>(X["T_STAFF_BLOODTYPE_ID"]);o.My_Staff.ENTRY_USER_ID = GV<Int64>(X["T_STAFF_ENTRY_USER_ID"]);o.My_Staff.ENTRY_DATE = GV<String>(X["T_STAFF_ENTRY_DATE"]);o.My_Staff.OWNER_ID = GV<Int32>(X["T_STAFF_OWNER_ID"]);o.My_Staff.STAFF_GENDER = GV<String>(X["T_STAFF_STAFF_GENDER"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Registered_staff_expense = new Registered_staff_expense();
o.My_Registered_staff_expense.REGISTERED_STAFF_EXPENSE_ID = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_REGISTERED_STAFF_EXPENSE_ID"]);o.My_Registered_staff_expense.REGISTERED_STAFF_EXPENSE_DISCOUNT = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_REGISTERED_STAFF_EXPENSE_DISCOUNT"]);o.My_Registered_staff_expense.REGISTERED_STAFF_EXPENSE_TOTAL_AMOUNT = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_REGISTERED_STAFF_EXPENSE_TOTAL_AMOUNT"]);o.My_Registered_staff_expense.REGISTERED_STAFF_EXPENSE_DESCRIPTION = GV<String>(X["T_REGISTERED_STAFF_EXPENSE_REGISTERED_STAFF_EXPENSE_DESCRIPTION"]);o.My_Registered_staff_expense.STAFF_ID = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_STAFF_ID"]);o.My_Registered_staff_expense.CURRENCY_ID = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_CURRENCY_ID"]);o.My_Registered_staff_expense.ENTRY_USER_ID = GV<Int64>(X["T_REGISTERED_STAFF_EXPENSE_ENTRY_USER_ID"]);o.My_Registered_staff_expense.ENTRY_DATE = GV<String>(X["T_REGISTERED_STAFF_EXPENSE_ENTRY_DATE"]);o.My_Registered_staff_expense.OWNER_ID = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Staff_fees> Get_Staff_fees_By_REGISTERED_STAFF_EXPENSE_ID_Adv ( Int32? REGISTERED_STAFF_EXPENSE_ID)
{
List<Staff_fees> oList = new List<Staff_fees>();
dynamic p = new ExpandoObject();
p.REGISTERED_STAFF_EXPENSE_ID = REGISTERED_STAFF_EXPENSE_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_FEES_BY_REGISTERED_STAFF_EXPENSE_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Staff_fees o = new Staff_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Staff = new Staff();
o.My_Staff.STAFF_ID = GV<Int32>(X["T_STAFF_STAFF_ID"]);o.My_Staff.STAFF_NAME = GV<String>(X["T_STAFF_STAFF_NAME"]);o.My_Staff.STAFF_PH_NB = GV<String>(X["T_STAFF_STAFF_PH_NB"]);o.My_Staff.STAFF_MAIL = GV<String>(X["T_STAFF_STAFF_MAIL"]);o.My_Staff.STAFF_DOB = GV<String>(X["T_STAFF_STAFF_DOB"]);o.My_Staff.BLOODTYPE_ID = GV<Int32>(X["T_STAFF_BLOODTYPE_ID"]);o.My_Staff.ENTRY_USER_ID = GV<Int64>(X["T_STAFF_ENTRY_USER_ID"]);o.My_Staff.ENTRY_DATE = GV<String>(X["T_STAFF_ENTRY_DATE"]);o.My_Staff.OWNER_ID = GV<Int32>(X["T_STAFF_OWNER_ID"]);o.My_Staff.STAFF_GENDER = GV<String>(X["T_STAFF_STAFF_GENDER"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Registered_staff_expense = new Registered_staff_expense();
o.My_Registered_staff_expense.REGISTERED_STAFF_EXPENSE_ID = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_REGISTERED_STAFF_EXPENSE_ID"]);o.My_Registered_staff_expense.REGISTERED_STAFF_EXPENSE_DISCOUNT = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_REGISTERED_STAFF_EXPENSE_DISCOUNT"]);o.My_Registered_staff_expense.REGISTERED_STAFF_EXPENSE_TOTAL_AMOUNT = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_REGISTERED_STAFF_EXPENSE_TOTAL_AMOUNT"]);o.My_Registered_staff_expense.REGISTERED_STAFF_EXPENSE_DESCRIPTION = GV<String>(X["T_REGISTERED_STAFF_EXPENSE_REGISTERED_STAFF_EXPENSE_DESCRIPTION"]);o.My_Registered_staff_expense.STAFF_ID = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_STAFF_ID"]);o.My_Registered_staff_expense.CURRENCY_ID = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_CURRENCY_ID"]);o.My_Registered_staff_expense.ENTRY_USER_ID = GV<Int64>(X["T_REGISTERED_STAFF_EXPENSE_ENTRY_USER_ID"]);o.My_Registered_staff_expense.ENTRY_DATE = GV<String>(X["T_REGISTERED_STAFF_EXPENSE_ENTRY_DATE"]);o.My_Registered_staff_expense.OWNER_ID = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Supplier> Get_Supplier_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Supplier> oList = new List<Supplier>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Supplier o = new Supplier();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Bloodtype = new Bloodtype();
o.My_Bloodtype.BLOODTYPE_ID = GV<Int32>(X["T_BLOODTYPE_BLOODTYPE_ID"]);o.My_Bloodtype.BLOODTYPE_SYMBOL = GV<String>(X["T_BLOODTYPE_BLOODTYPE_SYMBOL"]);o.My_Bloodtype.ENTRY_USER_ID = GV<Int64>(X["T_BLOODTYPE_ENTRY_USER_ID"]);o.My_Bloodtype.ENTRY_DATE = GV<String>(X["T_BLOODTYPE_ENTRY_DATE"]);o.My_Bloodtype.OWNER_ID = GV<Int32>(X["T_BLOODTYPE_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Supplier> Get_Supplier_By_BLOODTYPE_ID_Adv ( Int32? BLOODTYPE_ID)
{
List<Supplier> oList = new List<Supplier>();
dynamic p = new ExpandoObject();
p.BLOODTYPE_ID = BLOODTYPE_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_BY_BLOODTYPE_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Supplier o = new Supplier();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Bloodtype = new Bloodtype();
o.My_Bloodtype.BLOODTYPE_ID = GV<Int32>(X["T_BLOODTYPE_BLOODTYPE_ID"]);o.My_Bloodtype.BLOODTYPE_SYMBOL = GV<String>(X["T_BLOODTYPE_BLOODTYPE_SYMBOL"]);o.My_Bloodtype.ENTRY_USER_ID = GV<Int64>(X["T_BLOODTYPE_ENTRY_USER_ID"]);o.My_Bloodtype.ENTRY_DATE = GV<String>(X["T_BLOODTYPE_ENTRY_DATE"]);o.My_Bloodtype.OWNER_ID = GV<Int32>(X["T_BLOODTYPE_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Supplier_fees> Get_Supplier_fees_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<Supplier_fees> oList = new List<Supplier_fees>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_FEES_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Supplier_fees o = new Supplier_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Supplier = new Supplier();
o.My_Supplier.SUPPLIER_ID = GV<Int32>(X["T_SUPPLIER_SUPPLIER_ID"]);o.My_Supplier.SUPPLIER_NAME = GV<String>(X["T_SUPPLIER_SUPPLIER_NAME"]);o.My_Supplier.SUPPLIER_PH_NB = GV<String>(X["T_SUPPLIER_SUPPLIER_PH_NB"]);o.My_Supplier.SUPPLIER_MAIL = GV<String>(X["T_SUPPLIER_SUPPLIER_MAIL"]);o.My_Supplier.ENTRY_USER_ID = GV<Int64>(X["T_SUPPLIER_ENTRY_USER_ID"]);o.My_Supplier.ENTRY_DATE = GV<String>(X["T_SUPPLIER_ENTRY_DATE"]);o.My_Supplier.OWNER_ID = GV<Int32>(X["T_SUPPLIER_OWNER_ID"]);o.My_Supplier.SUPPLIER_DOB = GV<String>(X["T_SUPPLIER_SUPPLIER_DOB"]);o.My_Supplier.BLOODTYPE_ID = GV<Int32>(X["T_SUPPLIER_BLOODTYPE_ID"]);o.My_Supplier.SUPPLIER_GENDER = GV<String>(X["T_SUPPLIER_SUPPLIER_GENDER"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Registered_supplier_expense = new Registered_supplier_expense();
o.My_Registered_supplier_expense.REGISTERED_SUPPLIER_EXPENSE_ID = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_REGISTERED_SUPPLIER_EXPENSE_ID"]);o.My_Registered_supplier_expense.REGISTERED_SUPPLIER_EXPENSE_DISCOUNT = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_REGISTERED_SUPPLIER_EXPENSE_DISCOUNT"]);o.My_Registered_supplier_expense.REGISTERED_SUPPLIER_EXPENSE_TOTAL_AMOUNT = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_REGISTERED_SUPPLIER_EXPENSE_TOTAL_AMOUNT"]);o.My_Registered_supplier_expense.REGISTERED_SUPPLIER_EXPENSE_DESCRIPTION = GV<String>(X["T_REGISTERED_SUPPLIER_EXPENSE_REGISTERED_SUPPLIER_EXPENSE_DESCRIPTION"]);o.My_Registered_supplier_expense.SUPPLIER_ID = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_SUPPLIER_ID"]);o.My_Registered_supplier_expense.CURRENCY_ID = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_CURRENCY_ID"]);o.My_Registered_supplier_expense.ENTRY_USER_ID = GV<Int64>(X["T_REGISTERED_SUPPLIER_EXPENSE_ENTRY_USER_ID"]);o.My_Registered_supplier_expense.ENTRY_DATE = GV<String>(X["T_REGISTERED_SUPPLIER_EXPENSE_ENTRY_DATE"]);o.My_Registered_supplier_expense.OWNER_ID = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Supplier_fees> Get_Supplier_fees_By_SUPPLIER_ID_Adv ( Int32? SUPPLIER_ID)
{
List<Supplier_fees> oList = new List<Supplier_fees>();
dynamic p = new ExpandoObject();
p.SUPPLIER_ID = SUPPLIER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_FEES_BY_SUPPLIER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Supplier_fees o = new Supplier_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Supplier = new Supplier();
o.My_Supplier.SUPPLIER_ID = GV<Int32>(X["T_SUPPLIER_SUPPLIER_ID"]);o.My_Supplier.SUPPLIER_NAME = GV<String>(X["T_SUPPLIER_SUPPLIER_NAME"]);o.My_Supplier.SUPPLIER_PH_NB = GV<String>(X["T_SUPPLIER_SUPPLIER_PH_NB"]);o.My_Supplier.SUPPLIER_MAIL = GV<String>(X["T_SUPPLIER_SUPPLIER_MAIL"]);o.My_Supplier.ENTRY_USER_ID = GV<Int64>(X["T_SUPPLIER_ENTRY_USER_ID"]);o.My_Supplier.ENTRY_DATE = GV<String>(X["T_SUPPLIER_ENTRY_DATE"]);o.My_Supplier.OWNER_ID = GV<Int32>(X["T_SUPPLIER_OWNER_ID"]);o.My_Supplier.SUPPLIER_DOB = GV<String>(X["T_SUPPLIER_SUPPLIER_DOB"]);o.My_Supplier.BLOODTYPE_ID = GV<Int32>(X["T_SUPPLIER_BLOODTYPE_ID"]);o.My_Supplier.SUPPLIER_GENDER = GV<String>(X["T_SUPPLIER_SUPPLIER_GENDER"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Registered_supplier_expense = new Registered_supplier_expense();
o.My_Registered_supplier_expense.REGISTERED_SUPPLIER_EXPENSE_ID = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_REGISTERED_SUPPLIER_EXPENSE_ID"]);o.My_Registered_supplier_expense.REGISTERED_SUPPLIER_EXPENSE_DISCOUNT = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_REGISTERED_SUPPLIER_EXPENSE_DISCOUNT"]);o.My_Registered_supplier_expense.REGISTERED_SUPPLIER_EXPENSE_TOTAL_AMOUNT = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_REGISTERED_SUPPLIER_EXPENSE_TOTAL_AMOUNT"]);o.My_Registered_supplier_expense.REGISTERED_SUPPLIER_EXPENSE_DESCRIPTION = GV<String>(X["T_REGISTERED_SUPPLIER_EXPENSE_REGISTERED_SUPPLIER_EXPENSE_DESCRIPTION"]);o.My_Registered_supplier_expense.SUPPLIER_ID = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_SUPPLIER_ID"]);o.My_Registered_supplier_expense.CURRENCY_ID = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_CURRENCY_ID"]);o.My_Registered_supplier_expense.ENTRY_USER_ID = GV<Int64>(X["T_REGISTERED_SUPPLIER_EXPENSE_ENTRY_USER_ID"]);o.My_Registered_supplier_expense.ENTRY_DATE = GV<String>(X["T_REGISTERED_SUPPLIER_EXPENSE_ENTRY_DATE"]);o.My_Registered_supplier_expense.OWNER_ID = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Supplier_fees> Get_Supplier_fees_By_CURRENCY_ID_Adv ( Int32? CURRENCY_ID)
{
List<Supplier_fees> oList = new List<Supplier_fees>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID = CURRENCY_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_FEES_BY_CURRENCY_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Supplier_fees o = new Supplier_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Supplier = new Supplier();
o.My_Supplier.SUPPLIER_ID = GV<Int32>(X["T_SUPPLIER_SUPPLIER_ID"]);o.My_Supplier.SUPPLIER_NAME = GV<String>(X["T_SUPPLIER_SUPPLIER_NAME"]);o.My_Supplier.SUPPLIER_PH_NB = GV<String>(X["T_SUPPLIER_SUPPLIER_PH_NB"]);o.My_Supplier.SUPPLIER_MAIL = GV<String>(X["T_SUPPLIER_SUPPLIER_MAIL"]);o.My_Supplier.ENTRY_USER_ID = GV<Int64>(X["T_SUPPLIER_ENTRY_USER_ID"]);o.My_Supplier.ENTRY_DATE = GV<String>(X["T_SUPPLIER_ENTRY_DATE"]);o.My_Supplier.OWNER_ID = GV<Int32>(X["T_SUPPLIER_OWNER_ID"]);o.My_Supplier.SUPPLIER_DOB = GV<String>(X["T_SUPPLIER_SUPPLIER_DOB"]);o.My_Supplier.BLOODTYPE_ID = GV<Int32>(X["T_SUPPLIER_BLOODTYPE_ID"]);o.My_Supplier.SUPPLIER_GENDER = GV<String>(X["T_SUPPLIER_SUPPLIER_GENDER"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Registered_supplier_expense = new Registered_supplier_expense();
o.My_Registered_supplier_expense.REGISTERED_SUPPLIER_EXPENSE_ID = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_REGISTERED_SUPPLIER_EXPENSE_ID"]);o.My_Registered_supplier_expense.REGISTERED_SUPPLIER_EXPENSE_DISCOUNT = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_REGISTERED_SUPPLIER_EXPENSE_DISCOUNT"]);o.My_Registered_supplier_expense.REGISTERED_SUPPLIER_EXPENSE_TOTAL_AMOUNT = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_REGISTERED_SUPPLIER_EXPENSE_TOTAL_AMOUNT"]);o.My_Registered_supplier_expense.REGISTERED_SUPPLIER_EXPENSE_DESCRIPTION = GV<String>(X["T_REGISTERED_SUPPLIER_EXPENSE_REGISTERED_SUPPLIER_EXPENSE_DESCRIPTION"]);o.My_Registered_supplier_expense.SUPPLIER_ID = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_SUPPLIER_ID"]);o.My_Registered_supplier_expense.CURRENCY_ID = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_CURRENCY_ID"]);o.My_Registered_supplier_expense.ENTRY_USER_ID = GV<Int64>(X["T_REGISTERED_SUPPLIER_EXPENSE_ENTRY_USER_ID"]);o.My_Registered_supplier_expense.ENTRY_DATE = GV<String>(X["T_REGISTERED_SUPPLIER_EXPENSE_ENTRY_DATE"]);o.My_Registered_supplier_expense.OWNER_ID = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Supplier_fees> Get_Supplier_fees_By_REGISTERED_SUPPLIER_EXPENSE_ID_Adv ( Int32? REGISTERED_SUPPLIER_EXPENSE_ID)
{
List<Supplier_fees> oList = new List<Supplier_fees>();
dynamic p = new ExpandoObject();
p.REGISTERED_SUPPLIER_EXPENSE_ID = REGISTERED_SUPPLIER_EXPENSE_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_FEES_BY_REGISTERED_SUPPLIER_EXPENSE_ID_ADV", p);
if (R != null) {foreach (var X in R) {
Supplier_fees o = new Supplier_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Supplier = new Supplier();
o.My_Supplier.SUPPLIER_ID = GV<Int32>(X["T_SUPPLIER_SUPPLIER_ID"]);o.My_Supplier.SUPPLIER_NAME = GV<String>(X["T_SUPPLIER_SUPPLIER_NAME"]);o.My_Supplier.SUPPLIER_PH_NB = GV<String>(X["T_SUPPLIER_SUPPLIER_PH_NB"]);o.My_Supplier.SUPPLIER_MAIL = GV<String>(X["T_SUPPLIER_SUPPLIER_MAIL"]);o.My_Supplier.ENTRY_USER_ID = GV<Int64>(X["T_SUPPLIER_ENTRY_USER_ID"]);o.My_Supplier.ENTRY_DATE = GV<String>(X["T_SUPPLIER_ENTRY_DATE"]);o.My_Supplier.OWNER_ID = GV<Int32>(X["T_SUPPLIER_OWNER_ID"]);o.My_Supplier.SUPPLIER_DOB = GV<String>(X["T_SUPPLIER_SUPPLIER_DOB"]);o.My_Supplier.BLOODTYPE_ID = GV<Int32>(X["T_SUPPLIER_BLOODTYPE_ID"]);o.My_Supplier.SUPPLIER_GENDER = GV<String>(X["T_SUPPLIER_SUPPLIER_GENDER"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Registered_supplier_expense = new Registered_supplier_expense();
o.My_Registered_supplier_expense.REGISTERED_SUPPLIER_EXPENSE_ID = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_REGISTERED_SUPPLIER_EXPENSE_ID"]);o.My_Registered_supplier_expense.REGISTERED_SUPPLIER_EXPENSE_DISCOUNT = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_REGISTERED_SUPPLIER_EXPENSE_DISCOUNT"]);o.My_Registered_supplier_expense.REGISTERED_SUPPLIER_EXPENSE_TOTAL_AMOUNT = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_REGISTERED_SUPPLIER_EXPENSE_TOTAL_AMOUNT"]);o.My_Registered_supplier_expense.REGISTERED_SUPPLIER_EXPENSE_DESCRIPTION = GV<String>(X["T_REGISTERED_SUPPLIER_EXPENSE_REGISTERED_SUPPLIER_EXPENSE_DESCRIPTION"]);o.My_Registered_supplier_expense.SUPPLIER_ID = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_SUPPLIER_ID"]);o.My_Registered_supplier_expense.CURRENCY_ID = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_CURRENCY_ID"]);o.My_Registered_supplier_expense.ENTRY_USER_ID = GV<Int64>(X["T_REGISTERED_SUPPLIER_EXPENSE_ENTRY_USER_ID"]);o.My_Registered_supplier_expense.ENTRY_DATE = GV<String>(X["T_REGISTERED_SUPPLIER_EXPENSE_ENTRY_DATE"]);o.My_Registered_supplier_expense.OWNER_ID = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<User> Get_User_By_OWNER_ID_Adv ( Int32? OWNER_ID)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_OWNER_ID_ADV", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<User> Get_User_By_USERNAME_Adv ( string USERNAME)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_USERNAME_ADV", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_PERSON_ID_List ( List<long?> PERSON_ID_LIST)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_PERSON_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L1_ID_List ( List<long?> LOC_L1_ID_LIST)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L1_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L2_ID_List ( List<long?> LOC_L2_ID_LIST)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L2_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L3_ID_List ( List<long?> LOC_L3_ID_LIST)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L3_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L4_ID_List ( List<long?> LOC_L4_ID_LIST)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L4_ID_LIST = string.Join(",", LOC_L4_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L4_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Client> Get_Client_By_BLOODTYPE_ID_List ( List<Int32?> BLOODTYPE_ID_LIST)
{
List<Client> oList = new List<Client>();
dynamic p = new ExpandoObject();
p.BLOODTYPE_ID_LIST = string.Join(",", BLOODTYPE_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CLIENT_BY_BLOODTYPE_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Client o = new Client();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Client_fees> Get_Client_fees_By_CLIENT_ID_List ( List<Int32?> CLIENT_ID_LIST)
{
List<Client_fees> oList = new List<Client_fees>();
dynamic p = new ExpandoObject();
p.CLIENT_ID_LIST = string.Join(",", CLIENT_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CLIENT_FEES_BY_CLIENT_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Client_fees o = new Client_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Client_fees> Get_Client_fees_By_CURRENCY_ID_List ( List<Int32?> CURRENCY_ID_LIST)
{
List<Client_fees> oList = new List<Client_fees>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CLIENT_FEES_BY_CURRENCY_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Client_fees o = new Client_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Client_fees> Get_Client_fees_By_PACKAGE_ID_List ( List<Int32?> PACKAGE_ID_LIST)
{
List<Client_fees> oList = new List<Client_fees>();
dynamic p = new ExpandoObject();
p.PACKAGE_ID_LIST = string.Join(",", PACKAGE_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CLIENT_FEES_BY_PACKAGE_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Client_fees o = new Client_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Client_fees> Get_Client_fees_By_REGISTRATION_ID_List ( List<Int32?> REGISTRATION_ID_LIST)
{
List<Client_fees> oList = new List<Client_fees>();
dynamic p = new ExpandoObject();
p.REGISTRATION_ID_LIST = string.Join(",", REGISTRATION_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CLIENT_FEES_BY_REGISTRATION_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Client_fees o = new Client_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Contact> Get_Contact_By_PERSON_ID_List ( List<long?> PERSON_ID_LIST)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_PERSON_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Fees> Get_Fees_By_CURRENCY_ID_List ( List<Int32?> CURRENCY_ID_LIST)
{
List<Fees> oList = new List<Fees>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEES_BY_CURRENCY_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Fees o = new Fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_List ( List<long?> LOC_L1_ID_LIST)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_LOC_L1_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_List ( List<long?> LOC_L2_ID_LIST)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_LOC_L2_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_List ( List<long?> LOC_L3_ID_LIST)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_LOC_L3_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Package> Get_Package_By_CURRENCY_ID_List ( List<Int32?> CURRENCY_ID_LIST)
{
List<Package> oList = new List<Package>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PACKAGE_BY_CURRENCY_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Package o = new Package();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Registered_staff_expense> Get_Registered_staff_expense_By_STAFF_ID_List ( List<Int32?> STAFF_ID_LIST)
{
List<Registered_staff_expense> oList = new List<Registered_staff_expense>();
dynamic p = new ExpandoObject();
p.STAFF_ID_LIST = string.Join(",", STAFF_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_REGISTERED_STAFF_EXPENSE_BY_STAFF_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Registered_staff_expense o = new Registered_staff_expense();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Registered_staff_expense> Get_Registered_staff_expense_By_CURRENCY_ID_List ( List<Int32?> CURRENCY_ID_LIST)
{
List<Registered_staff_expense> oList = new List<Registered_staff_expense>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_REGISTERED_STAFF_EXPENSE_BY_CURRENCY_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Registered_staff_expense o = new Registered_staff_expense();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Registered_supplier_expense> Get_Registered_supplier_expense_By_SUPPLIER_ID_List ( List<Int32?> SUPPLIER_ID_LIST)
{
List<Registered_supplier_expense> oList = new List<Registered_supplier_expense>();
dynamic p = new ExpandoObject();
p.SUPPLIER_ID_LIST = string.Join(",", SUPPLIER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_REGISTERED_SUPPLIER_EXPENSE_BY_SUPPLIER_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Registered_supplier_expense o = new Registered_supplier_expense();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Registered_supplier_expense> Get_Registered_supplier_expense_By_CURRENCY_ID_List ( List<Int32?> CURRENCY_ID_LIST)
{
List<Registered_supplier_expense> oList = new List<Registered_supplier_expense>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_REGISTERED_SUPPLIER_EXPENSE_BY_CURRENCY_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Registered_supplier_expense o = new Registered_supplier_expense();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Registration> Get_Registration_By_CLIENT_ID_List ( List<Int32?> CLIENT_ID_LIST)
{
List<Registration> oList = new List<Registration>();
dynamic p = new ExpandoObject();
p.CLIENT_ID_LIST = string.Join(",", CLIENT_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_REGISTRATION_BY_CLIENT_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Registration o = new Registration();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Registration> Get_Registration_By_PACKAGE_ID_List ( List<Int32?> PACKAGE_ID_LIST)
{
List<Registration> oList = new List<Registration>();
dynamic p = new ExpandoObject();
p.PACKAGE_ID_LIST = string.Join(",", PACKAGE_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_REGISTRATION_BY_PACKAGE_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Registration o = new Registration();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Registration> Get_Registration_By_CURRENCY_ID_List ( List<Int32?> CURRENCY_ID_LIST)
{
List<Registration> oList = new List<Registration>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_REGISTRATION_BY_CURRENCY_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Registration o = new Registration();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Session> Get_Session_By_PACKAGE_ID_List ( List<Int32?> PACKAGE_ID_LIST)
{
List<Session> oList = new List<Session>();
dynamic p = new ExpandoObject();
p.PACKAGE_ID_LIST = string.Join(",", PACKAGE_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SESSION_BY_PACKAGE_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Session o = new Session();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Session> Get_Session_By_CLIENT_FEES_ID_List ( List<Int32?> CLIENT_FEES_ID_LIST)
{
List<Session> oList = new List<Session>();
dynamic p = new ExpandoObject();
p.CLIENT_FEES_ID_LIST = string.Join(",", CLIENT_FEES_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SESSION_BY_CLIENT_FEES_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Session o = new Session();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Staff> Get_Staff_By_BLOODTYPE_ID_List ( List<Int32?> BLOODTYPE_ID_LIST)
{
List<Staff> oList = new List<Staff>();
dynamic p = new ExpandoObject();
p.BLOODTYPE_ID_LIST = string.Join(",", BLOODTYPE_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_BY_BLOODTYPE_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Staff o = new Staff();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Staff_fees> Get_Staff_fees_By_STAFF_ID_List ( List<Int32?> STAFF_ID_LIST)
{
List<Staff_fees> oList = new List<Staff_fees>();
dynamic p = new ExpandoObject();
p.STAFF_ID_LIST = string.Join(",", STAFF_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_FEES_BY_STAFF_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Staff_fees o = new Staff_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Staff_fees> Get_Staff_fees_By_CURRENCY_ID_List ( List<Int32?> CURRENCY_ID_LIST)
{
List<Staff_fees> oList = new List<Staff_fees>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_FEES_BY_CURRENCY_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Staff_fees o = new Staff_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Staff_fees> Get_Staff_fees_By_REGISTERED_STAFF_EXPENSE_ID_List ( List<Int32?> REGISTERED_STAFF_EXPENSE_ID_LIST)
{
List<Staff_fees> oList = new List<Staff_fees>();
dynamic p = new ExpandoObject();
p.REGISTERED_STAFF_EXPENSE_ID_LIST = string.Join(",", REGISTERED_STAFF_EXPENSE_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_FEES_BY_REGISTERED_STAFF_EXPENSE_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Staff_fees o = new Staff_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Supplier> Get_Supplier_By_BLOODTYPE_ID_List ( List<Int32?> BLOODTYPE_ID_LIST)
{
List<Supplier> oList = new List<Supplier>();
dynamic p = new ExpandoObject();
p.BLOODTYPE_ID_LIST = string.Join(",", BLOODTYPE_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_BY_BLOODTYPE_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Supplier o = new Supplier();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Supplier_fees> Get_Supplier_fees_By_SUPPLIER_ID_List ( List<Int32?> SUPPLIER_ID_LIST)
{
List<Supplier_fees> oList = new List<Supplier_fees>();
dynamic p = new ExpandoObject();
p.SUPPLIER_ID_LIST = string.Join(",", SUPPLIER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_FEES_BY_SUPPLIER_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Supplier_fees o = new Supplier_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Supplier_fees> Get_Supplier_fees_By_CURRENCY_ID_List ( List<Int32?> CURRENCY_ID_LIST)
{
List<Supplier_fees> oList = new List<Supplier_fees>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_FEES_BY_CURRENCY_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Supplier_fees o = new Supplier_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Supplier_fees> Get_Supplier_fees_By_REGISTERED_SUPPLIER_EXPENSE_ID_List ( List<Int32?> REGISTERED_SUPPLIER_EXPENSE_ID_LIST)
{
List<Supplier_fees> oList = new List<Supplier_fees>();
dynamic p = new ExpandoObject();
p.REGISTERED_SUPPLIER_EXPENSE_ID_LIST = string.Join(",", REGISTERED_SUPPLIER_EXPENSE_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_FEES_BY_REGISTERED_SUPPLIER_EXPENSE_ID_LIST", p);
if (R != null) {foreach (var X in R) {
Supplier_fees o = new Supplier_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_PERSON_ID_List_Adv ( List<long?> PERSON_ID_LIST)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_PERSON_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L1_ID_List_Adv ( List<long?> LOC_L1_ID_LIST)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L1_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L2_ID_List_Adv ( List<long?> LOC_L2_ID_LIST)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L2_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L3_ID_List_Adv ( List<long?> LOC_L3_ID_LIST)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L3_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_LOC_L4_ID_List_Adv ( List<long?> LOC_L4_ID_LIST)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.LOC_L4_ID_LIST = string.Join(",", LOC_L4_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_LOC_L4_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Client> Get_Client_By_BLOODTYPE_ID_List_Adv ( List<Int32?> BLOODTYPE_ID_LIST)
{
List<Client> oList = new List<Client>();
dynamic p = new ExpandoObject();
p.BLOODTYPE_ID_LIST = string.Join(",", BLOODTYPE_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CLIENT_BY_BLOODTYPE_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Client o = new Client();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Bloodtype = new Bloodtype();
o.My_Bloodtype.BLOODTYPE_ID = GV<Int32>(X["T_BLOODTYPE_BLOODTYPE_ID"]);o.My_Bloodtype.BLOODTYPE_SYMBOL = GV<String>(X["T_BLOODTYPE_BLOODTYPE_SYMBOL"]);o.My_Bloodtype.ENTRY_USER_ID = GV<Int64>(X["T_BLOODTYPE_ENTRY_USER_ID"]);o.My_Bloodtype.ENTRY_DATE = GV<String>(X["T_BLOODTYPE_ENTRY_DATE"]);o.My_Bloodtype.OWNER_ID = GV<Int32>(X["T_BLOODTYPE_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Client_fees> Get_Client_fees_By_CLIENT_ID_List_Adv ( List<Int32?> CLIENT_ID_LIST)
{
List<Client_fees> oList = new List<Client_fees>();
dynamic p = new ExpandoObject();
p.CLIENT_ID_LIST = string.Join(",", CLIENT_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CLIENT_FEES_BY_CLIENT_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Client_fees o = new Client_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Client = new Client();
o.My_Client.CLIENT_ID = GV<Int32>(X["T_CLIENT_CLIENT_ID"]);o.My_Client.CLIENT_NAME = GV<String>(X["T_CLIENT_CLIENT_NAME"]);o.My_Client.CLIENT_PH_NB = GV<String>(X["T_CLIENT_CLIENT_PH_NB"]);o.My_Client.CLIENT_MAIL = GV<String>(X["T_CLIENT_CLIENT_MAIL"]);o.My_Client.CLIENT_DOB = GV<String>(X["T_CLIENT_CLIENT_DOB"]);o.My_Client.BLOODTYPE_ID = GV<Int32>(X["T_CLIENT_BLOODTYPE_ID"]);o.My_Client.ENTRY_USER_ID = GV<Int64>(X["T_CLIENT_ENTRY_USER_ID"]);o.My_Client.ENTRY_DATE = GV<String>(X["T_CLIENT_ENTRY_DATE"]);o.My_Client.OWNER_ID = GV<Int32>(X["T_CLIENT_OWNER_ID"]);o.My_Client.CLIENT_GENDER = GV<String>(X["T_CLIENT_CLIENT_GENDER"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Package = new Package();
o.My_Package.PACKAGE_ID = GV<Int32>(X["T_PACKAGE_PACKAGE_ID"]);o.My_Package.PACKAGE_NAME = GV<String>(X["T_PACKAGE_PACKAGE_NAME"]);o.My_Package.PACKAGE_PRICE = GV<Int32>(X["T_PACKAGE_PACKAGE_PRICE"]);o.My_Package.CURRENCY_ID = GV<Int32>(X["T_PACKAGE_CURRENCY_ID"]);o.My_Package.ENTRY_USER_ID = GV<Int64>(X["T_PACKAGE_ENTRY_USER_ID"]);o.My_Package.ENTRY_DATE = GV<String>(X["T_PACKAGE_ENTRY_DATE"]);o.My_Package.OWNER_ID = GV<Int32>(X["T_PACKAGE_OWNER_ID"]);o.My_Package.PACKAGE_SESSIONS_NB = GV<Int32>(X["T_PACKAGE_PACKAGE_SESSIONS_NB"]);o.My_Package.PACKAGE_TYPE = GV<String>(X["T_PACKAGE_PACKAGE_TYPE"]);o.My_Package.PACKAGE_ENDING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_ENDING_DATE"]);o.My_Package.PACKAGE_TIMELINE = GV<String>(X["T_PACKAGE_PACKAGE_TIMELINE"]);o.My_Package.PACKAGE_STARTING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_STARTING_DATE"]);o.My_Package.PACKAGE_NB_OF_MONTH = GV<Int32>(X["T_PACKAGE_PACKAGE_NB_OF_MONTH"]);
o.My_Registration = new Registration();
o.My_Registration.REGISTRATION_ID = GV<Int32>(X["T_REGISTRATION_REGISTRATION_ID"]);o.My_Registration.CLIENT_ID = GV<Int32>(X["T_REGISTRATION_CLIENT_ID"]);o.My_Registration.REGISTRATION_DATE = GV<String>(X["T_REGISTRATION_REGISTRATION_DATE"]);o.My_Registration.PACKAGE_ID = GV<Int32>(X["T_REGISTRATION_PACKAGE_ID"]);o.My_Registration.REGISTRATION_DISCOUNT = GV<Int32>(X["T_REGISTRATION_REGISTRATION_DISCOUNT"]);o.My_Registration.REGISTRATION_TOTAL_PRICE = GV<Int32>(X["T_REGISTRATION_REGISTRATION_TOTAL_PRICE"]);o.My_Registration.CURRENCY_ID = GV<Int32>(X["T_REGISTRATION_CURRENCY_ID"]);o.My_Registration.REGISTRATION_DESCRIPTION = GV<String>(X["T_REGISTRATION_REGISTRATION_DESCRIPTION"]);o.My_Registration.ENTRY_USER_ID = GV<Int64>(X["T_REGISTRATION_ENTRY_USER_ID"]);o.My_Registration.ENTRY_DATE = GV<String>(X["T_REGISTRATION_ENTRY_DATE"]);o.My_Registration.OWNER_ID = GV<Int32>(X["T_REGISTRATION_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Client_fees> Get_Client_fees_By_CURRENCY_ID_List_Adv ( List<Int32?> CURRENCY_ID_LIST)
{
List<Client_fees> oList = new List<Client_fees>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CLIENT_FEES_BY_CURRENCY_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Client_fees o = new Client_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Client = new Client();
o.My_Client.CLIENT_ID = GV<Int32>(X["T_CLIENT_CLIENT_ID"]);o.My_Client.CLIENT_NAME = GV<String>(X["T_CLIENT_CLIENT_NAME"]);o.My_Client.CLIENT_PH_NB = GV<String>(X["T_CLIENT_CLIENT_PH_NB"]);o.My_Client.CLIENT_MAIL = GV<String>(X["T_CLIENT_CLIENT_MAIL"]);o.My_Client.CLIENT_DOB = GV<String>(X["T_CLIENT_CLIENT_DOB"]);o.My_Client.BLOODTYPE_ID = GV<Int32>(X["T_CLIENT_BLOODTYPE_ID"]);o.My_Client.ENTRY_USER_ID = GV<Int64>(X["T_CLIENT_ENTRY_USER_ID"]);o.My_Client.ENTRY_DATE = GV<String>(X["T_CLIENT_ENTRY_DATE"]);o.My_Client.OWNER_ID = GV<Int32>(X["T_CLIENT_OWNER_ID"]);o.My_Client.CLIENT_GENDER = GV<String>(X["T_CLIENT_CLIENT_GENDER"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Package = new Package();
o.My_Package.PACKAGE_ID = GV<Int32>(X["T_PACKAGE_PACKAGE_ID"]);o.My_Package.PACKAGE_NAME = GV<String>(X["T_PACKAGE_PACKAGE_NAME"]);o.My_Package.PACKAGE_PRICE = GV<Int32>(X["T_PACKAGE_PACKAGE_PRICE"]);o.My_Package.CURRENCY_ID = GV<Int32>(X["T_PACKAGE_CURRENCY_ID"]);o.My_Package.ENTRY_USER_ID = GV<Int64>(X["T_PACKAGE_ENTRY_USER_ID"]);o.My_Package.ENTRY_DATE = GV<String>(X["T_PACKAGE_ENTRY_DATE"]);o.My_Package.OWNER_ID = GV<Int32>(X["T_PACKAGE_OWNER_ID"]);o.My_Package.PACKAGE_SESSIONS_NB = GV<Int32>(X["T_PACKAGE_PACKAGE_SESSIONS_NB"]);o.My_Package.PACKAGE_TYPE = GV<String>(X["T_PACKAGE_PACKAGE_TYPE"]);o.My_Package.PACKAGE_ENDING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_ENDING_DATE"]);o.My_Package.PACKAGE_TIMELINE = GV<String>(X["T_PACKAGE_PACKAGE_TIMELINE"]);o.My_Package.PACKAGE_STARTING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_STARTING_DATE"]);o.My_Package.PACKAGE_NB_OF_MONTH = GV<Int32>(X["T_PACKAGE_PACKAGE_NB_OF_MONTH"]);
o.My_Registration = new Registration();
o.My_Registration.REGISTRATION_ID = GV<Int32>(X["T_REGISTRATION_REGISTRATION_ID"]);o.My_Registration.CLIENT_ID = GV<Int32>(X["T_REGISTRATION_CLIENT_ID"]);o.My_Registration.REGISTRATION_DATE = GV<String>(X["T_REGISTRATION_REGISTRATION_DATE"]);o.My_Registration.PACKAGE_ID = GV<Int32>(X["T_REGISTRATION_PACKAGE_ID"]);o.My_Registration.REGISTRATION_DISCOUNT = GV<Int32>(X["T_REGISTRATION_REGISTRATION_DISCOUNT"]);o.My_Registration.REGISTRATION_TOTAL_PRICE = GV<Int32>(X["T_REGISTRATION_REGISTRATION_TOTAL_PRICE"]);o.My_Registration.CURRENCY_ID = GV<Int32>(X["T_REGISTRATION_CURRENCY_ID"]);o.My_Registration.REGISTRATION_DESCRIPTION = GV<String>(X["T_REGISTRATION_REGISTRATION_DESCRIPTION"]);o.My_Registration.ENTRY_USER_ID = GV<Int64>(X["T_REGISTRATION_ENTRY_USER_ID"]);o.My_Registration.ENTRY_DATE = GV<String>(X["T_REGISTRATION_ENTRY_DATE"]);o.My_Registration.OWNER_ID = GV<Int32>(X["T_REGISTRATION_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Client_fees> Get_Client_fees_By_PACKAGE_ID_List_Adv ( List<Int32?> PACKAGE_ID_LIST)
{
List<Client_fees> oList = new List<Client_fees>();
dynamic p = new ExpandoObject();
p.PACKAGE_ID_LIST = string.Join(",", PACKAGE_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CLIENT_FEES_BY_PACKAGE_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Client_fees o = new Client_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Client = new Client();
o.My_Client.CLIENT_ID = GV<Int32>(X["T_CLIENT_CLIENT_ID"]);o.My_Client.CLIENT_NAME = GV<String>(X["T_CLIENT_CLIENT_NAME"]);o.My_Client.CLIENT_PH_NB = GV<String>(X["T_CLIENT_CLIENT_PH_NB"]);o.My_Client.CLIENT_MAIL = GV<String>(X["T_CLIENT_CLIENT_MAIL"]);o.My_Client.CLIENT_DOB = GV<String>(X["T_CLIENT_CLIENT_DOB"]);o.My_Client.BLOODTYPE_ID = GV<Int32>(X["T_CLIENT_BLOODTYPE_ID"]);o.My_Client.ENTRY_USER_ID = GV<Int64>(X["T_CLIENT_ENTRY_USER_ID"]);o.My_Client.ENTRY_DATE = GV<String>(X["T_CLIENT_ENTRY_DATE"]);o.My_Client.OWNER_ID = GV<Int32>(X["T_CLIENT_OWNER_ID"]);o.My_Client.CLIENT_GENDER = GV<String>(X["T_CLIENT_CLIENT_GENDER"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Package = new Package();
o.My_Package.PACKAGE_ID = GV<Int32>(X["T_PACKAGE_PACKAGE_ID"]);o.My_Package.PACKAGE_NAME = GV<String>(X["T_PACKAGE_PACKAGE_NAME"]);o.My_Package.PACKAGE_PRICE = GV<Int32>(X["T_PACKAGE_PACKAGE_PRICE"]);o.My_Package.CURRENCY_ID = GV<Int32>(X["T_PACKAGE_CURRENCY_ID"]);o.My_Package.ENTRY_USER_ID = GV<Int64>(X["T_PACKAGE_ENTRY_USER_ID"]);o.My_Package.ENTRY_DATE = GV<String>(X["T_PACKAGE_ENTRY_DATE"]);o.My_Package.OWNER_ID = GV<Int32>(X["T_PACKAGE_OWNER_ID"]);o.My_Package.PACKAGE_SESSIONS_NB = GV<Int32>(X["T_PACKAGE_PACKAGE_SESSIONS_NB"]);o.My_Package.PACKAGE_TYPE = GV<String>(X["T_PACKAGE_PACKAGE_TYPE"]);o.My_Package.PACKAGE_ENDING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_ENDING_DATE"]);o.My_Package.PACKAGE_TIMELINE = GV<String>(X["T_PACKAGE_PACKAGE_TIMELINE"]);o.My_Package.PACKAGE_STARTING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_STARTING_DATE"]);o.My_Package.PACKAGE_NB_OF_MONTH = GV<Int32>(X["T_PACKAGE_PACKAGE_NB_OF_MONTH"]);
o.My_Registration = new Registration();
o.My_Registration.REGISTRATION_ID = GV<Int32>(X["T_REGISTRATION_REGISTRATION_ID"]);o.My_Registration.CLIENT_ID = GV<Int32>(X["T_REGISTRATION_CLIENT_ID"]);o.My_Registration.REGISTRATION_DATE = GV<String>(X["T_REGISTRATION_REGISTRATION_DATE"]);o.My_Registration.PACKAGE_ID = GV<Int32>(X["T_REGISTRATION_PACKAGE_ID"]);o.My_Registration.REGISTRATION_DISCOUNT = GV<Int32>(X["T_REGISTRATION_REGISTRATION_DISCOUNT"]);o.My_Registration.REGISTRATION_TOTAL_PRICE = GV<Int32>(X["T_REGISTRATION_REGISTRATION_TOTAL_PRICE"]);o.My_Registration.CURRENCY_ID = GV<Int32>(X["T_REGISTRATION_CURRENCY_ID"]);o.My_Registration.REGISTRATION_DESCRIPTION = GV<String>(X["T_REGISTRATION_REGISTRATION_DESCRIPTION"]);o.My_Registration.ENTRY_USER_ID = GV<Int64>(X["T_REGISTRATION_ENTRY_USER_ID"]);o.My_Registration.ENTRY_DATE = GV<String>(X["T_REGISTRATION_ENTRY_DATE"]);o.My_Registration.OWNER_ID = GV<Int32>(X["T_REGISTRATION_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Client_fees> Get_Client_fees_By_REGISTRATION_ID_List_Adv ( List<Int32?> REGISTRATION_ID_LIST)
{
List<Client_fees> oList = new List<Client_fees>();
dynamic p = new ExpandoObject();
p.REGISTRATION_ID_LIST = string.Join(",", REGISTRATION_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CLIENT_FEES_BY_REGISTRATION_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Client_fees o = new Client_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Client = new Client();
o.My_Client.CLIENT_ID = GV<Int32>(X["T_CLIENT_CLIENT_ID"]);o.My_Client.CLIENT_NAME = GV<String>(X["T_CLIENT_CLIENT_NAME"]);o.My_Client.CLIENT_PH_NB = GV<String>(X["T_CLIENT_CLIENT_PH_NB"]);o.My_Client.CLIENT_MAIL = GV<String>(X["T_CLIENT_CLIENT_MAIL"]);o.My_Client.CLIENT_DOB = GV<String>(X["T_CLIENT_CLIENT_DOB"]);o.My_Client.BLOODTYPE_ID = GV<Int32>(X["T_CLIENT_BLOODTYPE_ID"]);o.My_Client.ENTRY_USER_ID = GV<Int64>(X["T_CLIENT_ENTRY_USER_ID"]);o.My_Client.ENTRY_DATE = GV<String>(X["T_CLIENT_ENTRY_DATE"]);o.My_Client.OWNER_ID = GV<Int32>(X["T_CLIENT_OWNER_ID"]);o.My_Client.CLIENT_GENDER = GV<String>(X["T_CLIENT_CLIENT_GENDER"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Package = new Package();
o.My_Package.PACKAGE_ID = GV<Int32>(X["T_PACKAGE_PACKAGE_ID"]);o.My_Package.PACKAGE_NAME = GV<String>(X["T_PACKAGE_PACKAGE_NAME"]);o.My_Package.PACKAGE_PRICE = GV<Int32>(X["T_PACKAGE_PACKAGE_PRICE"]);o.My_Package.CURRENCY_ID = GV<Int32>(X["T_PACKAGE_CURRENCY_ID"]);o.My_Package.ENTRY_USER_ID = GV<Int64>(X["T_PACKAGE_ENTRY_USER_ID"]);o.My_Package.ENTRY_DATE = GV<String>(X["T_PACKAGE_ENTRY_DATE"]);o.My_Package.OWNER_ID = GV<Int32>(X["T_PACKAGE_OWNER_ID"]);o.My_Package.PACKAGE_SESSIONS_NB = GV<Int32>(X["T_PACKAGE_PACKAGE_SESSIONS_NB"]);o.My_Package.PACKAGE_TYPE = GV<String>(X["T_PACKAGE_PACKAGE_TYPE"]);o.My_Package.PACKAGE_ENDING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_ENDING_DATE"]);o.My_Package.PACKAGE_TIMELINE = GV<String>(X["T_PACKAGE_PACKAGE_TIMELINE"]);o.My_Package.PACKAGE_STARTING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_STARTING_DATE"]);o.My_Package.PACKAGE_NB_OF_MONTH = GV<Int32>(X["T_PACKAGE_PACKAGE_NB_OF_MONTH"]);
o.My_Registration = new Registration();
o.My_Registration.REGISTRATION_ID = GV<Int32>(X["T_REGISTRATION_REGISTRATION_ID"]);o.My_Registration.CLIENT_ID = GV<Int32>(X["T_REGISTRATION_CLIENT_ID"]);o.My_Registration.REGISTRATION_DATE = GV<String>(X["T_REGISTRATION_REGISTRATION_DATE"]);o.My_Registration.PACKAGE_ID = GV<Int32>(X["T_REGISTRATION_PACKAGE_ID"]);o.My_Registration.REGISTRATION_DISCOUNT = GV<Int32>(X["T_REGISTRATION_REGISTRATION_DISCOUNT"]);o.My_Registration.REGISTRATION_TOTAL_PRICE = GV<Int32>(X["T_REGISTRATION_REGISTRATION_TOTAL_PRICE"]);o.My_Registration.CURRENCY_ID = GV<Int32>(X["T_REGISTRATION_CURRENCY_ID"]);o.My_Registration.REGISTRATION_DESCRIPTION = GV<String>(X["T_REGISTRATION_REGISTRATION_DESCRIPTION"]);o.My_Registration.ENTRY_USER_ID = GV<Int64>(X["T_REGISTRATION_ENTRY_USER_ID"]);o.My_Registration.ENTRY_DATE = GV<String>(X["T_REGISTRATION_ENTRY_DATE"]);o.My_Registration.OWNER_ID = GV<Int32>(X["T_REGISTRATION_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Contact> Get_Contact_By_PERSON_ID_List_Adv ( List<long?> PERSON_ID_LIST)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_PERSON_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
oList.Add(o);
}
}
return oList;
}
public List<Fees> Get_Fees_By_CURRENCY_ID_List_Adv ( List<Int32?> CURRENCY_ID_LIST)
{
List<Fees> oList = new List<Fees>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEES_BY_CURRENCY_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Fees o = new Fees();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_List_Adv ( List<long?> LOC_L1_ID_LIST)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_LOC_L1_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_List_Adv ( List<long?> LOC_L2_ID_LIST)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_LOC_L2_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_List_Adv ( List<long?> LOC_L3_ID_LIST)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_LOC_L3_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Package> Get_Package_By_CURRENCY_ID_List_Adv ( List<Int32?> CURRENCY_ID_LIST)
{
List<Package> oList = new List<Package>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PACKAGE_BY_CURRENCY_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Package o = new Package();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Registered_staff_expense> Get_Registered_staff_expense_By_STAFF_ID_List_Adv ( List<Int32?> STAFF_ID_LIST)
{
List<Registered_staff_expense> oList = new List<Registered_staff_expense>();
dynamic p = new ExpandoObject();
p.STAFF_ID_LIST = string.Join(",", STAFF_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_REGISTERED_STAFF_EXPENSE_BY_STAFF_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Registered_staff_expense o = new Registered_staff_expense();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Staff = new Staff();
o.My_Staff.STAFF_ID = GV<Int32>(X["T_STAFF_STAFF_ID"]);o.My_Staff.STAFF_NAME = GV<String>(X["T_STAFF_STAFF_NAME"]);o.My_Staff.STAFF_PH_NB = GV<String>(X["T_STAFF_STAFF_PH_NB"]);o.My_Staff.STAFF_MAIL = GV<String>(X["T_STAFF_STAFF_MAIL"]);o.My_Staff.STAFF_DOB = GV<String>(X["T_STAFF_STAFF_DOB"]);o.My_Staff.BLOODTYPE_ID = GV<Int32>(X["T_STAFF_BLOODTYPE_ID"]);o.My_Staff.ENTRY_USER_ID = GV<Int64>(X["T_STAFF_ENTRY_USER_ID"]);o.My_Staff.ENTRY_DATE = GV<String>(X["T_STAFF_ENTRY_DATE"]);o.My_Staff.OWNER_ID = GV<Int32>(X["T_STAFF_OWNER_ID"]);o.My_Staff.STAFF_GENDER = GV<String>(X["T_STAFF_STAFF_GENDER"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Registered_staff_expense> Get_Registered_staff_expense_By_CURRENCY_ID_List_Adv ( List<Int32?> CURRENCY_ID_LIST)
{
List<Registered_staff_expense> oList = new List<Registered_staff_expense>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_REGISTERED_STAFF_EXPENSE_BY_CURRENCY_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Registered_staff_expense o = new Registered_staff_expense();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Staff = new Staff();
o.My_Staff.STAFF_ID = GV<Int32>(X["T_STAFF_STAFF_ID"]);o.My_Staff.STAFF_NAME = GV<String>(X["T_STAFF_STAFF_NAME"]);o.My_Staff.STAFF_PH_NB = GV<String>(X["T_STAFF_STAFF_PH_NB"]);o.My_Staff.STAFF_MAIL = GV<String>(X["T_STAFF_STAFF_MAIL"]);o.My_Staff.STAFF_DOB = GV<String>(X["T_STAFF_STAFF_DOB"]);o.My_Staff.BLOODTYPE_ID = GV<Int32>(X["T_STAFF_BLOODTYPE_ID"]);o.My_Staff.ENTRY_USER_ID = GV<Int64>(X["T_STAFF_ENTRY_USER_ID"]);o.My_Staff.ENTRY_DATE = GV<String>(X["T_STAFF_ENTRY_DATE"]);o.My_Staff.OWNER_ID = GV<Int32>(X["T_STAFF_OWNER_ID"]);o.My_Staff.STAFF_GENDER = GV<String>(X["T_STAFF_STAFF_GENDER"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Registered_supplier_expense> Get_Registered_supplier_expense_By_SUPPLIER_ID_List_Adv ( List<Int32?> SUPPLIER_ID_LIST)
{
List<Registered_supplier_expense> oList = new List<Registered_supplier_expense>();
dynamic p = new ExpandoObject();
p.SUPPLIER_ID_LIST = string.Join(",", SUPPLIER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_REGISTERED_SUPPLIER_EXPENSE_BY_SUPPLIER_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Registered_supplier_expense o = new Registered_supplier_expense();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Supplier = new Supplier();
o.My_Supplier.SUPPLIER_ID = GV<Int32>(X["T_SUPPLIER_SUPPLIER_ID"]);o.My_Supplier.SUPPLIER_NAME = GV<String>(X["T_SUPPLIER_SUPPLIER_NAME"]);o.My_Supplier.SUPPLIER_PH_NB = GV<String>(X["T_SUPPLIER_SUPPLIER_PH_NB"]);o.My_Supplier.SUPPLIER_MAIL = GV<String>(X["T_SUPPLIER_SUPPLIER_MAIL"]);o.My_Supplier.ENTRY_USER_ID = GV<Int64>(X["T_SUPPLIER_ENTRY_USER_ID"]);o.My_Supplier.ENTRY_DATE = GV<String>(X["T_SUPPLIER_ENTRY_DATE"]);o.My_Supplier.OWNER_ID = GV<Int32>(X["T_SUPPLIER_OWNER_ID"]);o.My_Supplier.SUPPLIER_DOB = GV<String>(X["T_SUPPLIER_SUPPLIER_DOB"]);o.My_Supplier.BLOODTYPE_ID = GV<Int32>(X["T_SUPPLIER_BLOODTYPE_ID"]);o.My_Supplier.SUPPLIER_GENDER = GV<String>(X["T_SUPPLIER_SUPPLIER_GENDER"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Registered_supplier_expense> Get_Registered_supplier_expense_By_CURRENCY_ID_List_Adv ( List<Int32?> CURRENCY_ID_LIST)
{
List<Registered_supplier_expense> oList = new List<Registered_supplier_expense>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_REGISTERED_SUPPLIER_EXPENSE_BY_CURRENCY_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Registered_supplier_expense o = new Registered_supplier_expense();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Supplier = new Supplier();
o.My_Supplier.SUPPLIER_ID = GV<Int32>(X["T_SUPPLIER_SUPPLIER_ID"]);o.My_Supplier.SUPPLIER_NAME = GV<String>(X["T_SUPPLIER_SUPPLIER_NAME"]);o.My_Supplier.SUPPLIER_PH_NB = GV<String>(X["T_SUPPLIER_SUPPLIER_PH_NB"]);o.My_Supplier.SUPPLIER_MAIL = GV<String>(X["T_SUPPLIER_SUPPLIER_MAIL"]);o.My_Supplier.ENTRY_USER_ID = GV<Int64>(X["T_SUPPLIER_ENTRY_USER_ID"]);o.My_Supplier.ENTRY_DATE = GV<String>(X["T_SUPPLIER_ENTRY_DATE"]);o.My_Supplier.OWNER_ID = GV<Int32>(X["T_SUPPLIER_OWNER_ID"]);o.My_Supplier.SUPPLIER_DOB = GV<String>(X["T_SUPPLIER_SUPPLIER_DOB"]);o.My_Supplier.BLOODTYPE_ID = GV<Int32>(X["T_SUPPLIER_BLOODTYPE_ID"]);o.My_Supplier.SUPPLIER_GENDER = GV<String>(X["T_SUPPLIER_SUPPLIER_GENDER"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Registration> Get_Registration_By_CLIENT_ID_List_Adv ( List<Int32?> CLIENT_ID_LIST)
{
List<Registration> oList = new List<Registration>();
dynamic p = new ExpandoObject();
p.CLIENT_ID_LIST = string.Join(",", CLIENT_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_REGISTRATION_BY_CLIENT_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Registration o = new Registration();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Client = new Client();
o.My_Client.CLIENT_ID = GV<Int32>(X["T_CLIENT_CLIENT_ID"]);o.My_Client.CLIENT_NAME = GV<String>(X["T_CLIENT_CLIENT_NAME"]);o.My_Client.CLIENT_PH_NB = GV<String>(X["T_CLIENT_CLIENT_PH_NB"]);o.My_Client.CLIENT_MAIL = GV<String>(X["T_CLIENT_CLIENT_MAIL"]);o.My_Client.CLIENT_DOB = GV<String>(X["T_CLIENT_CLIENT_DOB"]);o.My_Client.BLOODTYPE_ID = GV<Int32>(X["T_CLIENT_BLOODTYPE_ID"]);o.My_Client.ENTRY_USER_ID = GV<Int64>(X["T_CLIENT_ENTRY_USER_ID"]);o.My_Client.ENTRY_DATE = GV<String>(X["T_CLIENT_ENTRY_DATE"]);o.My_Client.OWNER_ID = GV<Int32>(X["T_CLIENT_OWNER_ID"]);o.My_Client.CLIENT_GENDER = GV<String>(X["T_CLIENT_CLIENT_GENDER"]);
o.My_Package = new Package();
o.My_Package.PACKAGE_ID = GV<Int32>(X["T_PACKAGE_PACKAGE_ID"]);o.My_Package.PACKAGE_NAME = GV<String>(X["T_PACKAGE_PACKAGE_NAME"]);o.My_Package.PACKAGE_PRICE = GV<Int32>(X["T_PACKAGE_PACKAGE_PRICE"]);o.My_Package.CURRENCY_ID = GV<Int32>(X["T_PACKAGE_CURRENCY_ID"]);o.My_Package.ENTRY_USER_ID = GV<Int64>(X["T_PACKAGE_ENTRY_USER_ID"]);o.My_Package.ENTRY_DATE = GV<String>(X["T_PACKAGE_ENTRY_DATE"]);o.My_Package.OWNER_ID = GV<Int32>(X["T_PACKAGE_OWNER_ID"]);o.My_Package.PACKAGE_SESSIONS_NB = GV<Int32>(X["T_PACKAGE_PACKAGE_SESSIONS_NB"]);o.My_Package.PACKAGE_TYPE = GV<String>(X["T_PACKAGE_PACKAGE_TYPE"]);o.My_Package.PACKAGE_ENDING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_ENDING_DATE"]);o.My_Package.PACKAGE_TIMELINE = GV<String>(X["T_PACKAGE_PACKAGE_TIMELINE"]);o.My_Package.PACKAGE_STARTING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_STARTING_DATE"]);o.My_Package.PACKAGE_NB_OF_MONTH = GV<Int32>(X["T_PACKAGE_PACKAGE_NB_OF_MONTH"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Registration> Get_Registration_By_PACKAGE_ID_List_Adv ( List<Int32?> PACKAGE_ID_LIST)
{
List<Registration> oList = new List<Registration>();
dynamic p = new ExpandoObject();
p.PACKAGE_ID_LIST = string.Join(",", PACKAGE_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_REGISTRATION_BY_PACKAGE_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Registration o = new Registration();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Client = new Client();
o.My_Client.CLIENT_ID = GV<Int32>(X["T_CLIENT_CLIENT_ID"]);o.My_Client.CLIENT_NAME = GV<String>(X["T_CLIENT_CLIENT_NAME"]);o.My_Client.CLIENT_PH_NB = GV<String>(X["T_CLIENT_CLIENT_PH_NB"]);o.My_Client.CLIENT_MAIL = GV<String>(X["T_CLIENT_CLIENT_MAIL"]);o.My_Client.CLIENT_DOB = GV<String>(X["T_CLIENT_CLIENT_DOB"]);o.My_Client.BLOODTYPE_ID = GV<Int32>(X["T_CLIENT_BLOODTYPE_ID"]);o.My_Client.ENTRY_USER_ID = GV<Int64>(X["T_CLIENT_ENTRY_USER_ID"]);o.My_Client.ENTRY_DATE = GV<String>(X["T_CLIENT_ENTRY_DATE"]);o.My_Client.OWNER_ID = GV<Int32>(X["T_CLIENT_OWNER_ID"]);o.My_Client.CLIENT_GENDER = GV<String>(X["T_CLIENT_CLIENT_GENDER"]);
o.My_Package = new Package();
o.My_Package.PACKAGE_ID = GV<Int32>(X["T_PACKAGE_PACKAGE_ID"]);o.My_Package.PACKAGE_NAME = GV<String>(X["T_PACKAGE_PACKAGE_NAME"]);o.My_Package.PACKAGE_PRICE = GV<Int32>(X["T_PACKAGE_PACKAGE_PRICE"]);o.My_Package.CURRENCY_ID = GV<Int32>(X["T_PACKAGE_CURRENCY_ID"]);o.My_Package.ENTRY_USER_ID = GV<Int64>(X["T_PACKAGE_ENTRY_USER_ID"]);o.My_Package.ENTRY_DATE = GV<String>(X["T_PACKAGE_ENTRY_DATE"]);o.My_Package.OWNER_ID = GV<Int32>(X["T_PACKAGE_OWNER_ID"]);o.My_Package.PACKAGE_SESSIONS_NB = GV<Int32>(X["T_PACKAGE_PACKAGE_SESSIONS_NB"]);o.My_Package.PACKAGE_TYPE = GV<String>(X["T_PACKAGE_PACKAGE_TYPE"]);o.My_Package.PACKAGE_ENDING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_ENDING_DATE"]);o.My_Package.PACKAGE_TIMELINE = GV<String>(X["T_PACKAGE_PACKAGE_TIMELINE"]);o.My_Package.PACKAGE_STARTING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_STARTING_DATE"]);o.My_Package.PACKAGE_NB_OF_MONTH = GV<Int32>(X["T_PACKAGE_PACKAGE_NB_OF_MONTH"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Registration> Get_Registration_By_CURRENCY_ID_List_Adv ( List<Int32?> CURRENCY_ID_LIST)
{
List<Registration> oList = new List<Registration>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_REGISTRATION_BY_CURRENCY_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Registration o = new Registration();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Client = new Client();
o.My_Client.CLIENT_ID = GV<Int32>(X["T_CLIENT_CLIENT_ID"]);o.My_Client.CLIENT_NAME = GV<String>(X["T_CLIENT_CLIENT_NAME"]);o.My_Client.CLIENT_PH_NB = GV<String>(X["T_CLIENT_CLIENT_PH_NB"]);o.My_Client.CLIENT_MAIL = GV<String>(X["T_CLIENT_CLIENT_MAIL"]);o.My_Client.CLIENT_DOB = GV<String>(X["T_CLIENT_CLIENT_DOB"]);o.My_Client.BLOODTYPE_ID = GV<Int32>(X["T_CLIENT_BLOODTYPE_ID"]);o.My_Client.ENTRY_USER_ID = GV<Int64>(X["T_CLIENT_ENTRY_USER_ID"]);o.My_Client.ENTRY_DATE = GV<String>(X["T_CLIENT_ENTRY_DATE"]);o.My_Client.OWNER_ID = GV<Int32>(X["T_CLIENT_OWNER_ID"]);o.My_Client.CLIENT_GENDER = GV<String>(X["T_CLIENT_CLIENT_GENDER"]);
o.My_Package = new Package();
o.My_Package.PACKAGE_ID = GV<Int32>(X["T_PACKAGE_PACKAGE_ID"]);o.My_Package.PACKAGE_NAME = GV<String>(X["T_PACKAGE_PACKAGE_NAME"]);o.My_Package.PACKAGE_PRICE = GV<Int32>(X["T_PACKAGE_PACKAGE_PRICE"]);o.My_Package.CURRENCY_ID = GV<Int32>(X["T_PACKAGE_CURRENCY_ID"]);o.My_Package.ENTRY_USER_ID = GV<Int64>(X["T_PACKAGE_ENTRY_USER_ID"]);o.My_Package.ENTRY_DATE = GV<String>(X["T_PACKAGE_ENTRY_DATE"]);o.My_Package.OWNER_ID = GV<Int32>(X["T_PACKAGE_OWNER_ID"]);o.My_Package.PACKAGE_SESSIONS_NB = GV<Int32>(X["T_PACKAGE_PACKAGE_SESSIONS_NB"]);o.My_Package.PACKAGE_TYPE = GV<String>(X["T_PACKAGE_PACKAGE_TYPE"]);o.My_Package.PACKAGE_ENDING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_ENDING_DATE"]);o.My_Package.PACKAGE_TIMELINE = GV<String>(X["T_PACKAGE_PACKAGE_TIMELINE"]);o.My_Package.PACKAGE_STARTING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_STARTING_DATE"]);o.My_Package.PACKAGE_NB_OF_MONTH = GV<Int32>(X["T_PACKAGE_PACKAGE_NB_OF_MONTH"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Session> Get_Session_By_PACKAGE_ID_List_Adv ( List<Int32?> PACKAGE_ID_LIST)
{
List<Session> oList = new List<Session>();
dynamic p = new ExpandoObject();
p.PACKAGE_ID_LIST = string.Join(",", PACKAGE_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SESSION_BY_PACKAGE_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Session o = new Session();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Package = new Package();
o.My_Package.PACKAGE_ID = GV<Int32>(X["T_PACKAGE_PACKAGE_ID"]);o.My_Package.PACKAGE_NAME = GV<String>(X["T_PACKAGE_PACKAGE_NAME"]);o.My_Package.PACKAGE_PRICE = GV<Int32>(X["T_PACKAGE_PACKAGE_PRICE"]);o.My_Package.CURRENCY_ID = GV<Int32>(X["T_PACKAGE_CURRENCY_ID"]);o.My_Package.ENTRY_USER_ID = GV<Int64>(X["T_PACKAGE_ENTRY_USER_ID"]);o.My_Package.ENTRY_DATE = GV<String>(X["T_PACKAGE_ENTRY_DATE"]);o.My_Package.OWNER_ID = GV<Int32>(X["T_PACKAGE_OWNER_ID"]);o.My_Package.PACKAGE_SESSIONS_NB = GV<Int32>(X["T_PACKAGE_PACKAGE_SESSIONS_NB"]);o.My_Package.PACKAGE_TYPE = GV<String>(X["T_PACKAGE_PACKAGE_TYPE"]);o.My_Package.PACKAGE_ENDING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_ENDING_DATE"]);o.My_Package.PACKAGE_TIMELINE = GV<String>(X["T_PACKAGE_PACKAGE_TIMELINE"]);o.My_Package.PACKAGE_STARTING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_STARTING_DATE"]);o.My_Package.PACKAGE_NB_OF_MONTH = GV<Int32>(X["T_PACKAGE_PACKAGE_NB_OF_MONTH"]);
o.My_Client_fees = new Client_fees();
o.My_Client_fees.CLIENT_FEES_ID = GV<Int32>(X["T_CLIENT_FEES_CLIENT_FEES_ID"]);o.My_Client_fees.CLIENT_ID = GV<Int32>(X["T_CLIENT_FEES_CLIENT_ID"]);o.My_Client_fees.CLIENT_FEES_DESCRIPTION = GV<String>(X["T_CLIENT_FEES_CLIENT_FEES_DESCRIPTION"]);o.My_Client_fees.ENTRY_USER_ID = GV<Int64>(X["T_CLIENT_FEES_ENTRY_USER_ID"]);o.My_Client_fees.ENTRY_DATE = GV<String>(X["T_CLIENT_FEES_ENTRY_DATE"]);o.My_Client_fees.OWNER_ID = GV<Int32>(X["T_CLIENT_FEES_OWNER_ID"]);o.My_Client_fees.CURRENCY_ID = GV<Int32>(X["T_CLIENT_FEES_CURRENCY_ID"]);o.My_Client_fees.PACKAGE_ID = GV<Int32>(X["T_CLIENT_FEES_PACKAGE_ID"]);o.My_Client_fees.CLIENT_FEES_AMOUNT = GV<Int32>(X["T_CLIENT_FEES_CLIENT_FEES_AMOUNT"]);o.My_Client_fees.REGISTRATION_ID = GV<Int32>(X["T_CLIENT_FEES_REGISTRATION_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Session> Get_Session_By_CLIENT_FEES_ID_List_Adv ( List<Int32?> CLIENT_FEES_ID_LIST)
{
List<Session> oList = new List<Session>();
dynamic p = new ExpandoObject();
p.CLIENT_FEES_ID_LIST = string.Join(",", CLIENT_FEES_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SESSION_BY_CLIENT_FEES_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Session o = new Session();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Package = new Package();
o.My_Package.PACKAGE_ID = GV<Int32>(X["T_PACKAGE_PACKAGE_ID"]);o.My_Package.PACKAGE_NAME = GV<String>(X["T_PACKAGE_PACKAGE_NAME"]);o.My_Package.PACKAGE_PRICE = GV<Int32>(X["T_PACKAGE_PACKAGE_PRICE"]);o.My_Package.CURRENCY_ID = GV<Int32>(X["T_PACKAGE_CURRENCY_ID"]);o.My_Package.ENTRY_USER_ID = GV<Int64>(X["T_PACKAGE_ENTRY_USER_ID"]);o.My_Package.ENTRY_DATE = GV<String>(X["T_PACKAGE_ENTRY_DATE"]);o.My_Package.OWNER_ID = GV<Int32>(X["T_PACKAGE_OWNER_ID"]);o.My_Package.PACKAGE_SESSIONS_NB = GV<Int32>(X["T_PACKAGE_PACKAGE_SESSIONS_NB"]);o.My_Package.PACKAGE_TYPE = GV<String>(X["T_PACKAGE_PACKAGE_TYPE"]);o.My_Package.PACKAGE_ENDING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_ENDING_DATE"]);o.My_Package.PACKAGE_TIMELINE = GV<String>(X["T_PACKAGE_PACKAGE_TIMELINE"]);o.My_Package.PACKAGE_STARTING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_STARTING_DATE"]);o.My_Package.PACKAGE_NB_OF_MONTH = GV<Int32>(X["T_PACKAGE_PACKAGE_NB_OF_MONTH"]);
o.My_Client_fees = new Client_fees();
o.My_Client_fees.CLIENT_FEES_ID = GV<Int32>(X["T_CLIENT_FEES_CLIENT_FEES_ID"]);o.My_Client_fees.CLIENT_ID = GV<Int32>(X["T_CLIENT_FEES_CLIENT_ID"]);o.My_Client_fees.CLIENT_FEES_DESCRIPTION = GV<String>(X["T_CLIENT_FEES_CLIENT_FEES_DESCRIPTION"]);o.My_Client_fees.ENTRY_USER_ID = GV<Int64>(X["T_CLIENT_FEES_ENTRY_USER_ID"]);o.My_Client_fees.ENTRY_DATE = GV<String>(X["T_CLIENT_FEES_ENTRY_DATE"]);o.My_Client_fees.OWNER_ID = GV<Int32>(X["T_CLIENT_FEES_OWNER_ID"]);o.My_Client_fees.CURRENCY_ID = GV<Int32>(X["T_CLIENT_FEES_CURRENCY_ID"]);o.My_Client_fees.PACKAGE_ID = GV<Int32>(X["T_CLIENT_FEES_PACKAGE_ID"]);o.My_Client_fees.CLIENT_FEES_AMOUNT = GV<Int32>(X["T_CLIENT_FEES_CLIENT_FEES_AMOUNT"]);o.My_Client_fees.REGISTRATION_ID = GV<Int32>(X["T_CLIENT_FEES_REGISTRATION_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Staff> Get_Staff_By_BLOODTYPE_ID_List_Adv ( List<Int32?> BLOODTYPE_ID_LIST)
{
List<Staff> oList = new List<Staff>();
dynamic p = new ExpandoObject();
p.BLOODTYPE_ID_LIST = string.Join(",", BLOODTYPE_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_BY_BLOODTYPE_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Staff o = new Staff();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Bloodtype = new Bloodtype();
o.My_Bloodtype.BLOODTYPE_ID = GV<Int32>(X["T_BLOODTYPE_BLOODTYPE_ID"]);o.My_Bloodtype.BLOODTYPE_SYMBOL = GV<String>(X["T_BLOODTYPE_BLOODTYPE_SYMBOL"]);o.My_Bloodtype.ENTRY_USER_ID = GV<Int64>(X["T_BLOODTYPE_ENTRY_USER_ID"]);o.My_Bloodtype.ENTRY_DATE = GV<String>(X["T_BLOODTYPE_ENTRY_DATE"]);o.My_Bloodtype.OWNER_ID = GV<Int32>(X["T_BLOODTYPE_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Staff_fees> Get_Staff_fees_By_STAFF_ID_List_Adv ( List<Int32?> STAFF_ID_LIST)
{
List<Staff_fees> oList = new List<Staff_fees>();
dynamic p = new ExpandoObject();
p.STAFF_ID_LIST = string.Join(",", STAFF_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_FEES_BY_STAFF_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Staff_fees o = new Staff_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Staff = new Staff();
o.My_Staff.STAFF_ID = GV<Int32>(X["T_STAFF_STAFF_ID"]);o.My_Staff.STAFF_NAME = GV<String>(X["T_STAFF_STAFF_NAME"]);o.My_Staff.STAFF_PH_NB = GV<String>(X["T_STAFF_STAFF_PH_NB"]);o.My_Staff.STAFF_MAIL = GV<String>(X["T_STAFF_STAFF_MAIL"]);o.My_Staff.STAFF_DOB = GV<String>(X["T_STAFF_STAFF_DOB"]);o.My_Staff.BLOODTYPE_ID = GV<Int32>(X["T_STAFF_BLOODTYPE_ID"]);o.My_Staff.ENTRY_USER_ID = GV<Int64>(X["T_STAFF_ENTRY_USER_ID"]);o.My_Staff.ENTRY_DATE = GV<String>(X["T_STAFF_ENTRY_DATE"]);o.My_Staff.OWNER_ID = GV<Int32>(X["T_STAFF_OWNER_ID"]);o.My_Staff.STAFF_GENDER = GV<String>(X["T_STAFF_STAFF_GENDER"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Registered_staff_expense = new Registered_staff_expense();
o.My_Registered_staff_expense.REGISTERED_STAFF_EXPENSE_ID = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_REGISTERED_STAFF_EXPENSE_ID"]);o.My_Registered_staff_expense.REGISTERED_STAFF_EXPENSE_DISCOUNT = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_REGISTERED_STAFF_EXPENSE_DISCOUNT"]);o.My_Registered_staff_expense.REGISTERED_STAFF_EXPENSE_TOTAL_AMOUNT = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_REGISTERED_STAFF_EXPENSE_TOTAL_AMOUNT"]);o.My_Registered_staff_expense.REGISTERED_STAFF_EXPENSE_DESCRIPTION = GV<String>(X["T_REGISTERED_STAFF_EXPENSE_REGISTERED_STAFF_EXPENSE_DESCRIPTION"]);o.My_Registered_staff_expense.STAFF_ID = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_STAFF_ID"]);o.My_Registered_staff_expense.CURRENCY_ID = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_CURRENCY_ID"]);o.My_Registered_staff_expense.ENTRY_USER_ID = GV<Int64>(X["T_REGISTERED_STAFF_EXPENSE_ENTRY_USER_ID"]);o.My_Registered_staff_expense.ENTRY_DATE = GV<String>(X["T_REGISTERED_STAFF_EXPENSE_ENTRY_DATE"]);o.My_Registered_staff_expense.OWNER_ID = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Staff_fees> Get_Staff_fees_By_CURRENCY_ID_List_Adv ( List<Int32?> CURRENCY_ID_LIST)
{
List<Staff_fees> oList = new List<Staff_fees>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_FEES_BY_CURRENCY_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Staff_fees o = new Staff_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Staff = new Staff();
o.My_Staff.STAFF_ID = GV<Int32>(X["T_STAFF_STAFF_ID"]);o.My_Staff.STAFF_NAME = GV<String>(X["T_STAFF_STAFF_NAME"]);o.My_Staff.STAFF_PH_NB = GV<String>(X["T_STAFF_STAFF_PH_NB"]);o.My_Staff.STAFF_MAIL = GV<String>(X["T_STAFF_STAFF_MAIL"]);o.My_Staff.STAFF_DOB = GV<String>(X["T_STAFF_STAFF_DOB"]);o.My_Staff.BLOODTYPE_ID = GV<Int32>(X["T_STAFF_BLOODTYPE_ID"]);o.My_Staff.ENTRY_USER_ID = GV<Int64>(X["T_STAFF_ENTRY_USER_ID"]);o.My_Staff.ENTRY_DATE = GV<String>(X["T_STAFF_ENTRY_DATE"]);o.My_Staff.OWNER_ID = GV<Int32>(X["T_STAFF_OWNER_ID"]);o.My_Staff.STAFF_GENDER = GV<String>(X["T_STAFF_STAFF_GENDER"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Registered_staff_expense = new Registered_staff_expense();
o.My_Registered_staff_expense.REGISTERED_STAFF_EXPENSE_ID = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_REGISTERED_STAFF_EXPENSE_ID"]);o.My_Registered_staff_expense.REGISTERED_STAFF_EXPENSE_DISCOUNT = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_REGISTERED_STAFF_EXPENSE_DISCOUNT"]);o.My_Registered_staff_expense.REGISTERED_STAFF_EXPENSE_TOTAL_AMOUNT = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_REGISTERED_STAFF_EXPENSE_TOTAL_AMOUNT"]);o.My_Registered_staff_expense.REGISTERED_STAFF_EXPENSE_DESCRIPTION = GV<String>(X["T_REGISTERED_STAFF_EXPENSE_REGISTERED_STAFF_EXPENSE_DESCRIPTION"]);o.My_Registered_staff_expense.STAFF_ID = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_STAFF_ID"]);o.My_Registered_staff_expense.CURRENCY_ID = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_CURRENCY_ID"]);o.My_Registered_staff_expense.ENTRY_USER_ID = GV<Int64>(X["T_REGISTERED_STAFF_EXPENSE_ENTRY_USER_ID"]);o.My_Registered_staff_expense.ENTRY_DATE = GV<String>(X["T_REGISTERED_STAFF_EXPENSE_ENTRY_DATE"]);o.My_Registered_staff_expense.OWNER_ID = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Staff_fees> Get_Staff_fees_By_REGISTERED_STAFF_EXPENSE_ID_List_Adv ( List<Int32?> REGISTERED_STAFF_EXPENSE_ID_LIST)
{
List<Staff_fees> oList = new List<Staff_fees>();
dynamic p = new ExpandoObject();
p.REGISTERED_STAFF_EXPENSE_ID_LIST = string.Join(",", REGISTERED_STAFF_EXPENSE_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_FEES_BY_REGISTERED_STAFF_EXPENSE_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Staff_fees o = new Staff_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Staff = new Staff();
o.My_Staff.STAFF_ID = GV<Int32>(X["T_STAFF_STAFF_ID"]);o.My_Staff.STAFF_NAME = GV<String>(X["T_STAFF_STAFF_NAME"]);o.My_Staff.STAFF_PH_NB = GV<String>(X["T_STAFF_STAFF_PH_NB"]);o.My_Staff.STAFF_MAIL = GV<String>(X["T_STAFF_STAFF_MAIL"]);o.My_Staff.STAFF_DOB = GV<String>(X["T_STAFF_STAFF_DOB"]);o.My_Staff.BLOODTYPE_ID = GV<Int32>(X["T_STAFF_BLOODTYPE_ID"]);o.My_Staff.ENTRY_USER_ID = GV<Int64>(X["T_STAFF_ENTRY_USER_ID"]);o.My_Staff.ENTRY_DATE = GV<String>(X["T_STAFF_ENTRY_DATE"]);o.My_Staff.OWNER_ID = GV<Int32>(X["T_STAFF_OWNER_ID"]);o.My_Staff.STAFF_GENDER = GV<String>(X["T_STAFF_STAFF_GENDER"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Registered_staff_expense = new Registered_staff_expense();
o.My_Registered_staff_expense.REGISTERED_STAFF_EXPENSE_ID = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_REGISTERED_STAFF_EXPENSE_ID"]);o.My_Registered_staff_expense.REGISTERED_STAFF_EXPENSE_DISCOUNT = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_REGISTERED_STAFF_EXPENSE_DISCOUNT"]);o.My_Registered_staff_expense.REGISTERED_STAFF_EXPENSE_TOTAL_AMOUNT = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_REGISTERED_STAFF_EXPENSE_TOTAL_AMOUNT"]);o.My_Registered_staff_expense.REGISTERED_STAFF_EXPENSE_DESCRIPTION = GV<String>(X["T_REGISTERED_STAFF_EXPENSE_REGISTERED_STAFF_EXPENSE_DESCRIPTION"]);o.My_Registered_staff_expense.STAFF_ID = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_STAFF_ID"]);o.My_Registered_staff_expense.CURRENCY_ID = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_CURRENCY_ID"]);o.My_Registered_staff_expense.ENTRY_USER_ID = GV<Int64>(X["T_REGISTERED_STAFF_EXPENSE_ENTRY_USER_ID"]);o.My_Registered_staff_expense.ENTRY_DATE = GV<String>(X["T_REGISTERED_STAFF_EXPENSE_ENTRY_DATE"]);o.My_Registered_staff_expense.OWNER_ID = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Supplier> Get_Supplier_By_BLOODTYPE_ID_List_Adv ( List<Int32?> BLOODTYPE_ID_LIST)
{
List<Supplier> oList = new List<Supplier>();
dynamic p = new ExpandoObject();
p.BLOODTYPE_ID_LIST = string.Join(",", BLOODTYPE_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_BY_BLOODTYPE_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Supplier o = new Supplier();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Bloodtype = new Bloodtype();
o.My_Bloodtype.BLOODTYPE_ID = GV<Int32>(X["T_BLOODTYPE_BLOODTYPE_ID"]);o.My_Bloodtype.BLOODTYPE_SYMBOL = GV<String>(X["T_BLOODTYPE_BLOODTYPE_SYMBOL"]);o.My_Bloodtype.ENTRY_USER_ID = GV<Int64>(X["T_BLOODTYPE_ENTRY_USER_ID"]);o.My_Bloodtype.ENTRY_DATE = GV<String>(X["T_BLOODTYPE_ENTRY_DATE"]);o.My_Bloodtype.OWNER_ID = GV<Int32>(X["T_BLOODTYPE_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Supplier_fees> Get_Supplier_fees_By_SUPPLIER_ID_List_Adv ( List<Int32?> SUPPLIER_ID_LIST)
{
List<Supplier_fees> oList = new List<Supplier_fees>();
dynamic p = new ExpandoObject();
p.SUPPLIER_ID_LIST = string.Join(",", SUPPLIER_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_FEES_BY_SUPPLIER_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Supplier_fees o = new Supplier_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Supplier = new Supplier();
o.My_Supplier.SUPPLIER_ID = GV<Int32>(X["T_SUPPLIER_SUPPLIER_ID"]);o.My_Supplier.SUPPLIER_NAME = GV<String>(X["T_SUPPLIER_SUPPLIER_NAME"]);o.My_Supplier.SUPPLIER_PH_NB = GV<String>(X["T_SUPPLIER_SUPPLIER_PH_NB"]);o.My_Supplier.SUPPLIER_MAIL = GV<String>(X["T_SUPPLIER_SUPPLIER_MAIL"]);o.My_Supplier.ENTRY_USER_ID = GV<Int64>(X["T_SUPPLIER_ENTRY_USER_ID"]);o.My_Supplier.ENTRY_DATE = GV<String>(X["T_SUPPLIER_ENTRY_DATE"]);o.My_Supplier.OWNER_ID = GV<Int32>(X["T_SUPPLIER_OWNER_ID"]);o.My_Supplier.SUPPLIER_DOB = GV<String>(X["T_SUPPLIER_SUPPLIER_DOB"]);o.My_Supplier.BLOODTYPE_ID = GV<Int32>(X["T_SUPPLIER_BLOODTYPE_ID"]);o.My_Supplier.SUPPLIER_GENDER = GV<String>(X["T_SUPPLIER_SUPPLIER_GENDER"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Registered_supplier_expense = new Registered_supplier_expense();
o.My_Registered_supplier_expense.REGISTERED_SUPPLIER_EXPENSE_ID = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_REGISTERED_SUPPLIER_EXPENSE_ID"]);o.My_Registered_supplier_expense.REGISTERED_SUPPLIER_EXPENSE_DISCOUNT = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_REGISTERED_SUPPLIER_EXPENSE_DISCOUNT"]);o.My_Registered_supplier_expense.REGISTERED_SUPPLIER_EXPENSE_TOTAL_AMOUNT = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_REGISTERED_SUPPLIER_EXPENSE_TOTAL_AMOUNT"]);o.My_Registered_supplier_expense.REGISTERED_SUPPLIER_EXPENSE_DESCRIPTION = GV<String>(X["T_REGISTERED_SUPPLIER_EXPENSE_REGISTERED_SUPPLIER_EXPENSE_DESCRIPTION"]);o.My_Registered_supplier_expense.SUPPLIER_ID = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_SUPPLIER_ID"]);o.My_Registered_supplier_expense.CURRENCY_ID = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_CURRENCY_ID"]);o.My_Registered_supplier_expense.ENTRY_USER_ID = GV<Int64>(X["T_REGISTERED_SUPPLIER_EXPENSE_ENTRY_USER_ID"]);o.My_Registered_supplier_expense.ENTRY_DATE = GV<String>(X["T_REGISTERED_SUPPLIER_EXPENSE_ENTRY_DATE"]);o.My_Registered_supplier_expense.OWNER_ID = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Supplier_fees> Get_Supplier_fees_By_CURRENCY_ID_List_Adv ( List<Int32?> CURRENCY_ID_LIST)
{
List<Supplier_fees> oList = new List<Supplier_fees>();
dynamic p = new ExpandoObject();
p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_FEES_BY_CURRENCY_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Supplier_fees o = new Supplier_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Supplier = new Supplier();
o.My_Supplier.SUPPLIER_ID = GV<Int32>(X["T_SUPPLIER_SUPPLIER_ID"]);o.My_Supplier.SUPPLIER_NAME = GV<String>(X["T_SUPPLIER_SUPPLIER_NAME"]);o.My_Supplier.SUPPLIER_PH_NB = GV<String>(X["T_SUPPLIER_SUPPLIER_PH_NB"]);o.My_Supplier.SUPPLIER_MAIL = GV<String>(X["T_SUPPLIER_SUPPLIER_MAIL"]);o.My_Supplier.ENTRY_USER_ID = GV<Int64>(X["T_SUPPLIER_ENTRY_USER_ID"]);o.My_Supplier.ENTRY_DATE = GV<String>(X["T_SUPPLIER_ENTRY_DATE"]);o.My_Supplier.OWNER_ID = GV<Int32>(X["T_SUPPLIER_OWNER_ID"]);o.My_Supplier.SUPPLIER_DOB = GV<String>(X["T_SUPPLIER_SUPPLIER_DOB"]);o.My_Supplier.BLOODTYPE_ID = GV<Int32>(X["T_SUPPLIER_BLOODTYPE_ID"]);o.My_Supplier.SUPPLIER_GENDER = GV<String>(X["T_SUPPLIER_SUPPLIER_GENDER"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Registered_supplier_expense = new Registered_supplier_expense();
o.My_Registered_supplier_expense.REGISTERED_SUPPLIER_EXPENSE_ID = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_REGISTERED_SUPPLIER_EXPENSE_ID"]);o.My_Registered_supplier_expense.REGISTERED_SUPPLIER_EXPENSE_DISCOUNT = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_REGISTERED_SUPPLIER_EXPENSE_DISCOUNT"]);o.My_Registered_supplier_expense.REGISTERED_SUPPLIER_EXPENSE_TOTAL_AMOUNT = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_REGISTERED_SUPPLIER_EXPENSE_TOTAL_AMOUNT"]);o.My_Registered_supplier_expense.REGISTERED_SUPPLIER_EXPENSE_DESCRIPTION = GV<String>(X["T_REGISTERED_SUPPLIER_EXPENSE_REGISTERED_SUPPLIER_EXPENSE_DESCRIPTION"]);o.My_Registered_supplier_expense.SUPPLIER_ID = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_SUPPLIER_ID"]);o.My_Registered_supplier_expense.CURRENCY_ID = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_CURRENCY_ID"]);o.My_Registered_supplier_expense.ENTRY_USER_ID = GV<Int64>(X["T_REGISTERED_SUPPLIER_EXPENSE_ENTRY_USER_ID"]);o.My_Registered_supplier_expense.ENTRY_DATE = GV<String>(X["T_REGISTERED_SUPPLIER_EXPENSE_ENTRY_DATE"]);o.My_Registered_supplier_expense.OWNER_ID = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Supplier_fees> Get_Supplier_fees_By_REGISTERED_SUPPLIER_EXPENSE_ID_List_Adv ( List<Int32?> REGISTERED_SUPPLIER_EXPENSE_ID_LIST)
{
List<Supplier_fees> oList = new List<Supplier_fees>();
dynamic p = new ExpandoObject();
p.REGISTERED_SUPPLIER_EXPENSE_ID_LIST = string.Join(",", REGISTERED_SUPPLIER_EXPENSE_ID_LIST.ToArray());
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_FEES_BY_REGISTERED_SUPPLIER_EXPENSE_ID_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Supplier_fees o = new Supplier_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Supplier = new Supplier();
o.My_Supplier.SUPPLIER_ID = GV<Int32>(X["T_SUPPLIER_SUPPLIER_ID"]);o.My_Supplier.SUPPLIER_NAME = GV<String>(X["T_SUPPLIER_SUPPLIER_NAME"]);o.My_Supplier.SUPPLIER_PH_NB = GV<String>(X["T_SUPPLIER_SUPPLIER_PH_NB"]);o.My_Supplier.SUPPLIER_MAIL = GV<String>(X["T_SUPPLIER_SUPPLIER_MAIL"]);o.My_Supplier.ENTRY_USER_ID = GV<Int64>(X["T_SUPPLIER_ENTRY_USER_ID"]);o.My_Supplier.ENTRY_DATE = GV<String>(X["T_SUPPLIER_ENTRY_DATE"]);o.My_Supplier.OWNER_ID = GV<Int32>(X["T_SUPPLIER_OWNER_ID"]);o.My_Supplier.SUPPLIER_DOB = GV<String>(X["T_SUPPLIER_SUPPLIER_DOB"]);o.My_Supplier.BLOODTYPE_ID = GV<Int32>(X["T_SUPPLIER_BLOODTYPE_ID"]);o.My_Supplier.SUPPLIER_GENDER = GV<String>(X["T_SUPPLIER_SUPPLIER_GENDER"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Registered_supplier_expense = new Registered_supplier_expense();
o.My_Registered_supplier_expense.REGISTERED_SUPPLIER_EXPENSE_ID = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_REGISTERED_SUPPLIER_EXPENSE_ID"]);o.My_Registered_supplier_expense.REGISTERED_SUPPLIER_EXPENSE_DISCOUNT = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_REGISTERED_SUPPLIER_EXPENSE_DISCOUNT"]);o.My_Registered_supplier_expense.REGISTERED_SUPPLIER_EXPENSE_TOTAL_AMOUNT = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_REGISTERED_SUPPLIER_EXPENSE_TOTAL_AMOUNT"]);o.My_Registered_supplier_expense.REGISTERED_SUPPLIER_EXPENSE_DESCRIPTION = GV<String>(X["T_REGISTERED_SUPPLIER_EXPENSE_REGISTERED_SUPPLIER_EXPENSE_DESCRIPTION"]);o.My_Registered_supplier_expense.SUPPLIER_ID = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_SUPPLIER_ID"]);o.My_Registered_supplier_expense.CURRENCY_ID = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_CURRENCY_ID"]);o.My_Registered_supplier_expense.ENTRY_USER_ID = GV<Int64>(X["T_REGISTERED_SUPPLIER_EXPENSE_ENTRY_USER_ID"]);o.My_Registered_supplier_expense.ENTRY_DATE = GV<String>(X["T_REGISTERED_SUPPLIER_EXPENSE_ENTRY_DATE"]);o.My_Registered_supplier_expense.OWNER_ID = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<Address> Get_Address_By_Criteria ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Where ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Criteria_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.VALID_DATE_START = VALID_DATE_START; p.VALID_DATE_END = VALID_DATE_END; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_CRITERIA_V2", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Where_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.VALID_DATE_START = VALID_DATE_START; p.VALID_DATE_END = VALID_DATE_END; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_WHERE_V2", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Bloodtype> Get_Bloodtype_By_Criteria ( string BLOODTYPE_SYMBOL, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Bloodtype> oList = new List<Bloodtype>();
dynamic p = new ExpandoObject();
p.BLOODTYPE_SYMBOL = BLOODTYPE_SYMBOL; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BLOODTYPE_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Bloodtype o = new Bloodtype();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Bloodtype> Get_Bloodtype_By_Where ( string BLOODTYPE_SYMBOL, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Bloodtype> oList = new List<Bloodtype>();
dynamic p = new ExpandoObject();
p.BLOODTYPE_SYMBOL = BLOODTYPE_SYMBOL; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BLOODTYPE_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Bloodtype o = new Bloodtype();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Client> Get_Client_By_Criteria ( string CLIENT_NAME, string CLIENT_PH_NB, string CLIENT_MAIL, string CLIENT_GENDER, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Client> oList = new List<Client>();
dynamic p = new ExpandoObject();
p.CLIENT_NAME = CLIENT_NAME; p.CLIENT_PH_NB = CLIENT_PH_NB; p.CLIENT_MAIL = CLIENT_MAIL; p.CLIENT_GENDER = CLIENT_GENDER; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CLIENT_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Client o = new Client();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Client> Get_Client_By_Where ( string CLIENT_NAME, string CLIENT_PH_NB, string CLIENT_MAIL, string CLIENT_GENDER, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Client> oList = new List<Client>();
dynamic p = new ExpandoObject();
p.CLIENT_NAME = CLIENT_NAME; p.CLIENT_PH_NB = CLIENT_PH_NB; p.CLIENT_MAIL = CLIENT_MAIL; p.CLIENT_GENDER = CLIENT_GENDER; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CLIENT_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Client o = new Client();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Client> Get_Client_By_Criteria_V2 ( string CLIENT_NAME, string CLIENT_PH_NB, string CLIENT_MAIL, string CLIENT_DOB, string CLIENT_GENDER, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Client> oList = new List<Client>();
dynamic p = new ExpandoObject();
p.CLIENT_NAME = CLIENT_NAME; p.CLIENT_PH_NB = CLIENT_PH_NB; p.CLIENT_MAIL = CLIENT_MAIL; p.CLIENT_DOB = CLIENT_DOB; p.CLIENT_GENDER = CLIENT_GENDER; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CLIENT_BY_CRITERIA_V2", p);
if (R != null) {foreach (var X in R) {
Client o = new Client();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Client> Get_Client_By_Where_V2 ( string CLIENT_NAME, string CLIENT_PH_NB, string CLIENT_MAIL, string CLIENT_DOB, string CLIENT_GENDER, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Client> oList = new List<Client>();
dynamic p = new ExpandoObject();
p.CLIENT_NAME = CLIENT_NAME; p.CLIENT_PH_NB = CLIENT_PH_NB; p.CLIENT_MAIL = CLIENT_MAIL; p.CLIENT_DOB = CLIENT_DOB; p.CLIENT_GENDER = CLIENT_GENDER; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CLIENT_BY_WHERE_V2", p);
if (R != null) {foreach (var X in R) {
Client o = new Client();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Client_fees> Get_Client_fees_By_Criteria ( string CLIENT_FEES_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Client_fees> oList = new List<Client_fees>();
dynamic p = new ExpandoObject();
p.CLIENT_FEES_DESCRIPTION = CLIENT_FEES_DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CLIENT_FEES_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Client_fees o = new Client_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Client_fees> Get_Client_fees_By_Where ( string CLIENT_FEES_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Client_fees> oList = new List<Client_fees>();
dynamic p = new ExpandoObject();
p.CLIENT_FEES_DESCRIPTION = CLIENT_FEES_DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CLIENT_FEES_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Client_fees o = new Client_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Contact> Get_Contact_By_Criteria ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.CONTACT_TYPE_CODE = CONTACT_TYPE_CODE; p.CONTACT = CONTACT; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Contact> Get_Contact_By_Where ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.CONTACT_TYPE_CODE = CONTACT_TYPE_CODE; p.CONTACT = CONTACT; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Currency> Get_Currency_By_Criteria ( string CURRENCY_TYPE, string CURRENCY_SYMBOL, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Currency> oList = new List<Currency>();
dynamic p = new ExpandoObject();
p.CURRENCY_TYPE = CURRENCY_TYPE; p.CURRENCY_SYMBOL = CURRENCY_SYMBOL; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CURRENCY_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Currency o = new Currency();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Currency> Get_Currency_By_Where ( string CURRENCY_TYPE, string CURRENCY_SYMBOL, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Currency> oList = new List<Currency>();
dynamic p = new ExpandoObject();
p.CURRENCY_TYPE = CURRENCY_TYPE; p.CURRENCY_SYMBOL = CURRENCY_SYMBOL; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CURRENCY_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Currency o = new Currency();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Fees> Get_Fees_By_Criteria ( string FEES_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Fees> oList = new List<Fees>();
dynamic p = new ExpandoObject();
p.FEES_DESCRIPTION = FEES_DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEES_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Fees o = new Fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Fees> Get_Fees_By_Where ( string FEES_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Fees> oList = new List<Fees>();
dynamic p = new ExpandoObject();
p.FEES_DESCRIPTION = FEES_DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEES_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Fees o = new Fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Fees> Get_Fees_By_Criteria_V2 ( string FEES_DESCRIPTION, string FEES_ORIGIN_DATE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Fees> oList = new List<Fees>();
dynamic p = new ExpandoObject();
p.FEES_DESCRIPTION = FEES_DESCRIPTION; p.FEES_ORIGIN_DATE = FEES_ORIGIN_DATE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEES_BY_CRITERIA_V2", p);
if (R != null) {foreach (var X in R) {
Fees o = new Fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Fees> Get_Fees_By_Where_V2 ( string FEES_DESCRIPTION, string FEES_ORIGIN_DATE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Fees> oList = new List<Fees>();
dynamic p = new ExpandoObject();
p.FEES_DESCRIPTION = FEES_DESCRIPTION; p.FEES_ORIGIN_DATE = FEES_ORIGIN_DATE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEES_BY_WHERE_V2", p);
if (R != null) {foreach (var X in R) {
Fees o = new Fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_Criteria ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l1> oList = new List<Loc_l1>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L1_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Loc_l1 o = new Loc_l1();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_Where ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l1> oList = new List<Loc_l1>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L1_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Loc_l1 o = new Loc_l1();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Criteria ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Where ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Criteria ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Where ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Criteria ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Where ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Method_run> Get_Method_run_By_Criteria ( string METHOD_NAME, string INPUT_PARAM, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Method_run> oList = new List<Method_run>();
dynamic p = new ExpandoObject();
p.METHOD_NAME = METHOD_NAME; p.INPUT_PARAM = INPUT_PARAM; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_METHOD_RUN_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Method_run o = new Method_run();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Method_run> Get_Method_run_By_Where ( string METHOD_NAME, string INPUT_PARAM, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Method_run> oList = new List<Method_run>();
dynamic p = new ExpandoObject();
p.METHOD_NAME = METHOD_NAME; p.INPUT_PARAM = INPUT_PARAM; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_METHOD_RUN_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Method_run o = new Method_run();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Method_run> Get_Method_run_By_Criteria_V2 ( string METHOD_NAME, string RUN_DATE, string INPUT_PARAM, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Method_run> oList = new List<Method_run>();
dynamic p = new ExpandoObject();
p.METHOD_NAME = METHOD_NAME; p.RUN_DATE = RUN_DATE; p.INPUT_PARAM = INPUT_PARAM; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_METHOD_RUN_BY_CRITERIA_V2", p);
if (R != null) {foreach (var X in R) {
Method_run o = new Method_run();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Method_run> Get_Method_run_By_Where_V2 ( string METHOD_NAME, string RUN_DATE, string INPUT_PARAM, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Method_run> oList = new List<Method_run>();
dynamic p = new ExpandoObject();
p.METHOD_NAME = METHOD_NAME; p.RUN_DATE = RUN_DATE; p.INPUT_PARAM = INPUT_PARAM; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_METHOD_RUN_BY_WHERE_V2", p);
if (R != null) {foreach (var X in R) {
Method_run o = new Method_run();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Owner> Get_Owner_By_Criteria ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Owner> oList = new List<Owner>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OWNER_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Owner o = new Owner();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Owner> Get_Owner_By_Where ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Owner> oList = new List<Owner>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OWNER_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Owner o = new Owner();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Owner> Get_Owner_By_Criteria_V2 ( string CODE, string MAINTENANCE_DUE_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Owner> oList = new List<Owner>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.MAINTENANCE_DUE_DATE = MAINTENANCE_DUE_DATE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OWNER_BY_CRITERIA_V2", p);
if (R != null) {foreach (var X in R) {
Owner o = new Owner();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Owner> Get_Owner_By_Where_V2 ( string CODE, string MAINTENANCE_DUE_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Owner> oList = new List<Owner>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.MAINTENANCE_DUE_DATE = MAINTENANCE_DUE_DATE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_OWNER_BY_WHERE_V2", p);
if (R != null) {foreach (var X in R) {
Owner o = new Owner();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Package> Get_Package_By_Criteria ( string PACKAGE_NAME, string PACKAGE_TYPE, string PACKAGE_TIMELINE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Package> oList = new List<Package>();
dynamic p = new ExpandoObject();
p.PACKAGE_NAME = PACKAGE_NAME; p.PACKAGE_TYPE = PACKAGE_TYPE; p.PACKAGE_TIMELINE = PACKAGE_TIMELINE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PACKAGE_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Package o = new Package();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Package> Get_Package_By_Where ( string PACKAGE_NAME, string PACKAGE_TYPE, string PACKAGE_TIMELINE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Package> oList = new List<Package>();
dynamic p = new ExpandoObject();
p.PACKAGE_NAME = PACKAGE_NAME; p.PACKAGE_TYPE = PACKAGE_TYPE; p.PACKAGE_TIMELINE = PACKAGE_TIMELINE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PACKAGE_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Package o = new Package();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Package> Get_Package_By_Criteria_V2 ( string PACKAGE_NAME, string PACKAGE_TYPE, string PACKAGE_ENDING_DATE, string PACKAGE_TIMELINE, string PACKAGE_STARTING_DATE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Package> oList = new List<Package>();
dynamic p = new ExpandoObject();
p.PACKAGE_NAME = PACKAGE_NAME; p.PACKAGE_TYPE = PACKAGE_TYPE; p.PACKAGE_ENDING_DATE = PACKAGE_ENDING_DATE; p.PACKAGE_TIMELINE = PACKAGE_TIMELINE; p.PACKAGE_STARTING_DATE = PACKAGE_STARTING_DATE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PACKAGE_BY_CRITERIA_V2", p);
if (R != null) {foreach (var X in R) {
Package o = new Package();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Package> Get_Package_By_Where_V2 ( string PACKAGE_NAME, string PACKAGE_TYPE, string PACKAGE_ENDING_DATE, string PACKAGE_TIMELINE, string PACKAGE_STARTING_DATE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Package> oList = new List<Package>();
dynamic p = new ExpandoObject();
p.PACKAGE_NAME = PACKAGE_NAME; p.PACKAGE_TYPE = PACKAGE_TYPE; p.PACKAGE_ENDING_DATE = PACKAGE_ENDING_DATE; p.PACKAGE_TIMELINE = PACKAGE_TIMELINE; p.PACKAGE_STARTING_DATE = PACKAGE_STARTING_DATE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PACKAGE_BY_WHERE_V2", p);
if (R != null) {foreach (var X in R) {
Package o = new Package();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Person> Get_Person_By_Criteria ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Person> oList = new List<Person>();
dynamic p = new ExpandoObject();
p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.FATHER_NAME = FATHER_NAME; p.MOTHER_NAME = MOTHER_NAME; p.TITLE_CODE = TITLE_CODE; p.GENDER_CODE = GENDER_CODE; p.RELIGION_CODE = RELIGION_CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PERSON_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Person o = new Person();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Person> Get_Person_By_Where ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Person> oList = new List<Person>();
dynamic p = new ExpandoObject();
p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.FATHER_NAME = FATHER_NAME; p.MOTHER_NAME = MOTHER_NAME; p.TITLE_CODE = TITLE_CODE; p.GENDER_CODE = GENDER_CODE; p.RELIGION_CODE = RELIGION_CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PERSON_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Person o = new Person();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Person> Get_Person_By_Criteria_V2 ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string BIRTH_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Person> oList = new List<Person>();
dynamic p = new ExpandoObject();
p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.FATHER_NAME = FATHER_NAME; p.MOTHER_NAME = MOTHER_NAME; p.TITLE_CODE = TITLE_CODE; p.GENDER_CODE = GENDER_CODE; p.RELIGION_CODE = RELIGION_CODE; p.BIRTH_DATE = BIRTH_DATE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PERSON_BY_CRITERIA_V2", p);
if (R != null) {foreach (var X in R) {
Person o = new Person();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Person> Get_Person_By_Where_V2 ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string BIRTH_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Person> oList = new List<Person>();
dynamic p = new ExpandoObject();
p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.FATHER_NAME = FATHER_NAME; p.MOTHER_NAME = MOTHER_NAME; p.TITLE_CODE = TITLE_CODE; p.GENDER_CODE = GENDER_CODE; p.RELIGION_CODE = RELIGION_CODE; p.BIRTH_DATE = BIRTH_DATE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PERSON_BY_WHERE_V2", p);
if (R != null) {foreach (var X in R) {
Person o = new Person();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Registration> Get_Registration_By_Criteria ( string REGISTRATION_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Registration> oList = new List<Registration>();
dynamic p = new ExpandoObject();
p.REGISTRATION_DESCRIPTION = REGISTRATION_DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_REGISTRATION_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Registration o = new Registration();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Registration> Get_Registration_By_Where ( string REGISTRATION_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Registration> oList = new List<Registration>();
dynamic p = new ExpandoObject();
p.REGISTRATION_DESCRIPTION = REGISTRATION_DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_REGISTRATION_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Registration o = new Registration();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Registration> Get_Registration_By_Criteria_V2 ( string REGISTRATION_DATE, string REGISTRATION_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Registration> oList = new List<Registration>();
dynamic p = new ExpandoObject();
p.REGISTRATION_DATE = REGISTRATION_DATE; p.REGISTRATION_DESCRIPTION = REGISTRATION_DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_REGISTRATION_BY_CRITERIA_V2", p);
if (R != null) {foreach (var X in R) {
Registration o = new Registration();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Registration> Get_Registration_By_Where_V2 ( string REGISTRATION_DATE, string REGISTRATION_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Registration> oList = new List<Registration>();
dynamic p = new ExpandoObject();
p.REGISTRATION_DATE = REGISTRATION_DATE; p.REGISTRATION_DESCRIPTION = REGISTRATION_DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_REGISTRATION_BY_WHERE_V2", p);
if (R != null) {foreach (var X in R) {
Registration o = new Registration();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Session> Get_Session_By_Criteria ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Session> oList = new List<Session>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SESSION_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Session o = new Session();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Session> Get_Session_By_Where ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Session> oList = new List<Session>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SESSION_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Session o = new Session();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Session> Get_Session_By_Criteria_V2 ( string SESSION_STARTING_DATE, string SESSION_ENDING_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Session> oList = new List<Session>();
dynamic p = new ExpandoObject();
p.SESSION_STARTING_DATE = SESSION_STARTING_DATE; p.SESSION_ENDING_DATE = SESSION_ENDING_DATE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SESSION_BY_CRITERIA_V2", p);
if (R != null) {foreach (var X in R) {
Session o = new Session();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Session> Get_Session_By_Where_V2 ( string SESSION_STARTING_DATE, string SESSION_ENDING_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Session> oList = new List<Session>();
dynamic p = new ExpandoObject();
p.SESSION_STARTING_DATE = SESSION_STARTING_DATE; p.SESSION_ENDING_DATE = SESSION_ENDING_DATE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SESSION_BY_WHERE_V2", p);
if (R != null) {foreach (var X in R) {
Session o = new Session();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Staff> Get_Staff_By_Criteria ( string STAFF_NAME, string STAFF_PH_NB, string STAFF_MAIL, string STAFF_GENDER, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Staff> oList = new List<Staff>();
dynamic p = new ExpandoObject();
p.STAFF_NAME = STAFF_NAME; p.STAFF_PH_NB = STAFF_PH_NB; p.STAFF_MAIL = STAFF_MAIL; p.STAFF_GENDER = STAFF_GENDER; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Staff o = new Staff();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Staff> Get_Staff_By_Where ( string STAFF_NAME, string STAFF_PH_NB, string STAFF_MAIL, string STAFF_GENDER, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Staff> oList = new List<Staff>();
dynamic p = new ExpandoObject();
p.STAFF_NAME = STAFF_NAME; p.STAFF_PH_NB = STAFF_PH_NB; p.STAFF_MAIL = STAFF_MAIL; p.STAFF_GENDER = STAFF_GENDER; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Staff o = new Staff();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Staff> Get_Staff_By_Criteria_V2 ( string STAFF_NAME, string STAFF_PH_NB, string STAFF_MAIL, string STAFF_DOB, string STAFF_GENDER, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Staff> oList = new List<Staff>();
dynamic p = new ExpandoObject();
p.STAFF_NAME = STAFF_NAME; p.STAFF_PH_NB = STAFF_PH_NB; p.STAFF_MAIL = STAFF_MAIL; p.STAFF_DOB = STAFF_DOB; p.STAFF_GENDER = STAFF_GENDER; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_BY_CRITERIA_V2", p);
if (R != null) {foreach (var X in R) {
Staff o = new Staff();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Staff> Get_Staff_By_Where_V2 ( string STAFF_NAME, string STAFF_PH_NB, string STAFF_MAIL, string STAFF_DOB, string STAFF_GENDER, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Staff> oList = new List<Staff>();
dynamic p = new ExpandoObject();
p.STAFF_NAME = STAFF_NAME; p.STAFF_PH_NB = STAFF_PH_NB; p.STAFF_MAIL = STAFF_MAIL; p.STAFF_DOB = STAFF_DOB; p.STAFF_GENDER = STAFF_GENDER; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_BY_WHERE_V2", p);
if (R != null) {foreach (var X in R) {
Staff o = new Staff();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Staff_fees> Get_Staff_fees_By_Criteria ( string STAFF_FEES_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Staff_fees> oList = new List<Staff_fees>();
dynamic p = new ExpandoObject();
p.STAFF_FEES_DESCRIPTION = STAFF_FEES_DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_FEES_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Staff_fees o = new Staff_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Staff_fees> Get_Staff_fees_By_Where ( string STAFF_FEES_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Staff_fees> oList = new List<Staff_fees>();
dynamic p = new ExpandoObject();
p.STAFF_FEES_DESCRIPTION = STAFF_FEES_DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_FEES_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Staff_fees o = new Staff_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Supplier> Get_Supplier_By_Criteria ( string SUPPLIER_NAME, string SUPPLIER_PH_NB, string SUPPLIER_MAIL, string SUPPLIER_GENDER, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Supplier> oList = new List<Supplier>();
dynamic p = new ExpandoObject();
p.SUPPLIER_NAME = SUPPLIER_NAME; p.SUPPLIER_PH_NB = SUPPLIER_PH_NB; p.SUPPLIER_MAIL = SUPPLIER_MAIL; p.SUPPLIER_GENDER = SUPPLIER_GENDER; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Supplier o = new Supplier();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Supplier> Get_Supplier_By_Where ( string SUPPLIER_NAME, string SUPPLIER_PH_NB, string SUPPLIER_MAIL, string SUPPLIER_GENDER, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Supplier> oList = new List<Supplier>();
dynamic p = new ExpandoObject();
p.SUPPLIER_NAME = SUPPLIER_NAME; p.SUPPLIER_PH_NB = SUPPLIER_PH_NB; p.SUPPLIER_MAIL = SUPPLIER_MAIL; p.SUPPLIER_GENDER = SUPPLIER_GENDER; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Supplier o = new Supplier();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Supplier> Get_Supplier_By_Criteria_V2 ( string SUPPLIER_NAME, string SUPPLIER_PH_NB, string SUPPLIER_MAIL, string SUPPLIER_DOB, string SUPPLIER_GENDER, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Supplier> oList = new List<Supplier>();
dynamic p = new ExpandoObject();
p.SUPPLIER_NAME = SUPPLIER_NAME; p.SUPPLIER_PH_NB = SUPPLIER_PH_NB; p.SUPPLIER_MAIL = SUPPLIER_MAIL; p.SUPPLIER_DOB = SUPPLIER_DOB; p.SUPPLIER_GENDER = SUPPLIER_GENDER; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_BY_CRITERIA_V2", p);
if (R != null) {foreach (var X in R) {
Supplier o = new Supplier();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Supplier> Get_Supplier_By_Where_V2 ( string SUPPLIER_NAME, string SUPPLIER_PH_NB, string SUPPLIER_MAIL, string SUPPLIER_DOB, string SUPPLIER_GENDER, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Supplier> oList = new List<Supplier>();
dynamic p = new ExpandoObject();
p.SUPPLIER_NAME = SUPPLIER_NAME; p.SUPPLIER_PH_NB = SUPPLIER_PH_NB; p.SUPPLIER_MAIL = SUPPLIER_MAIL; p.SUPPLIER_DOB = SUPPLIER_DOB; p.SUPPLIER_GENDER = SUPPLIER_GENDER; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_BY_WHERE_V2", p);
if (R != null) {foreach (var X in R) {
Supplier o = new Supplier();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Supplier_fees> Get_Supplier_fees_By_Criteria ( string SUPPLIER_FEES_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Supplier_fees> oList = new List<Supplier_fees>();
dynamic p = new ExpandoObject();
p.SUPPLIER_FEES_DESCRIPTION = SUPPLIER_FEES_DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_FEES_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
Supplier_fees o = new Supplier_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Supplier_fees> Get_Supplier_fees_By_Where ( string SUPPLIER_FEES_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Supplier_fees> oList = new List<Supplier_fees>();
dynamic p = new ExpandoObject();
p.SUPPLIER_FEES_DESCRIPTION = SUPPLIER_FEES_DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_FEES_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
Supplier_fees o = new Supplier_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<User> Get_User_By_Criteria ( string USERNAME, string PASSWORD, string USER_TYPE_CODE, string USER_EMAIL, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME; p.PASSWORD = PASSWORD; p.USER_TYPE_CODE = USER_TYPE_CODE; p.USER_EMAIL = USER_EMAIL; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_CRITERIA", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<User> Get_User_By_Where ( string USERNAME, string PASSWORD, string USER_TYPE_CODE, string USER_EMAIL, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME; p.PASSWORD = PASSWORD; p.USER_TYPE_CODE = USER_TYPE_CODE; p.USER_EMAIL = USER_EMAIL; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_WHERE", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Criteria_Adv ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Where_Adv ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Criteria_Adv_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.VALID_DATE_START = VALID_DATE_START; p.VALID_DATE_END = VALID_DATE_END; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_CRITERIA_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Where_Adv_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.VALID_DATE_START = VALID_DATE_START; p.VALID_DATE_END = VALID_DATE_END; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_WHERE_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Bloodtype> Get_Bloodtype_By_Criteria_Adv ( string BLOODTYPE_SYMBOL, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Bloodtype> oList = new List<Bloodtype>();
dynamic p = new ExpandoObject();
p.BLOODTYPE_SYMBOL = BLOODTYPE_SYMBOL; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BLOODTYPE_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Bloodtype o = new Bloodtype();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Bloodtype> Get_Bloodtype_By_Where_Adv ( string BLOODTYPE_SYMBOL, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Bloodtype> oList = new List<Bloodtype>();
dynamic p = new ExpandoObject();
p.BLOODTYPE_SYMBOL = BLOODTYPE_SYMBOL; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_BLOODTYPE_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Bloodtype o = new Bloodtype();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Client> Get_Client_By_Criteria_Adv ( string CLIENT_NAME, string CLIENT_PH_NB, string CLIENT_MAIL, string CLIENT_GENDER, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Client> oList = new List<Client>();
dynamic p = new ExpandoObject();
p.CLIENT_NAME = CLIENT_NAME; p.CLIENT_PH_NB = CLIENT_PH_NB; p.CLIENT_MAIL = CLIENT_MAIL; p.CLIENT_GENDER = CLIENT_GENDER; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CLIENT_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Client o = new Client();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Bloodtype = new Bloodtype();
o.My_Bloodtype.BLOODTYPE_ID = GV<Int32>(X["T_BLOODTYPE_BLOODTYPE_ID"]);o.My_Bloodtype.BLOODTYPE_SYMBOL = GV<String>(X["T_BLOODTYPE_BLOODTYPE_SYMBOL"]);o.My_Bloodtype.ENTRY_USER_ID = GV<Int64>(X["T_BLOODTYPE_ENTRY_USER_ID"]);o.My_Bloodtype.ENTRY_DATE = GV<String>(X["T_BLOODTYPE_ENTRY_DATE"]);o.My_Bloodtype.OWNER_ID = GV<Int32>(X["T_BLOODTYPE_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Client> Get_Client_By_Where_Adv ( string CLIENT_NAME, string CLIENT_PH_NB, string CLIENT_MAIL, string CLIENT_GENDER, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Client> oList = new List<Client>();
dynamic p = new ExpandoObject();
p.CLIENT_NAME = CLIENT_NAME; p.CLIENT_PH_NB = CLIENT_PH_NB; p.CLIENT_MAIL = CLIENT_MAIL; p.CLIENT_GENDER = CLIENT_GENDER; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CLIENT_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Client o = new Client();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Bloodtype = new Bloodtype();
o.My_Bloodtype.BLOODTYPE_ID = GV<Int32>(X["T_BLOODTYPE_BLOODTYPE_ID"]);o.My_Bloodtype.BLOODTYPE_SYMBOL = GV<String>(X["T_BLOODTYPE_BLOODTYPE_SYMBOL"]);o.My_Bloodtype.ENTRY_USER_ID = GV<Int64>(X["T_BLOODTYPE_ENTRY_USER_ID"]);o.My_Bloodtype.ENTRY_DATE = GV<String>(X["T_BLOODTYPE_ENTRY_DATE"]);o.My_Bloodtype.OWNER_ID = GV<Int32>(X["T_BLOODTYPE_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Client> Get_Client_By_Criteria_Adv_V2 ( string CLIENT_NAME, string CLIENT_PH_NB, string CLIENT_MAIL, string CLIENT_DOB, string CLIENT_GENDER, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Client> oList = new List<Client>();
dynamic p = new ExpandoObject();
p.CLIENT_NAME = CLIENT_NAME; p.CLIENT_PH_NB = CLIENT_PH_NB; p.CLIENT_MAIL = CLIENT_MAIL; p.CLIENT_DOB = CLIENT_DOB; p.CLIENT_GENDER = CLIENT_GENDER; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CLIENT_BY_CRITERIA_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Client o = new Client();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Client> Get_Client_By_Where_Adv_V2 ( string CLIENT_NAME, string CLIENT_PH_NB, string CLIENT_MAIL, string CLIENT_DOB, string CLIENT_GENDER, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Client> oList = new List<Client>();
dynamic p = new ExpandoObject();
p.CLIENT_NAME = CLIENT_NAME; p.CLIENT_PH_NB = CLIENT_PH_NB; p.CLIENT_MAIL = CLIENT_MAIL; p.CLIENT_DOB = CLIENT_DOB; p.CLIENT_GENDER = CLIENT_GENDER; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CLIENT_BY_WHERE_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Client o = new Client();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Client_fees> Get_Client_fees_By_Criteria_Adv ( string CLIENT_FEES_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Client_fees> oList = new List<Client_fees>();
dynamic p = new ExpandoObject();
p.CLIENT_FEES_DESCRIPTION = CLIENT_FEES_DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CLIENT_FEES_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Client_fees o = new Client_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Client = new Client();
o.My_Client.CLIENT_ID = GV<Int32>(X["T_CLIENT_CLIENT_ID"]);o.My_Client.CLIENT_NAME = GV<String>(X["T_CLIENT_CLIENT_NAME"]);o.My_Client.CLIENT_PH_NB = GV<String>(X["T_CLIENT_CLIENT_PH_NB"]);o.My_Client.CLIENT_MAIL = GV<String>(X["T_CLIENT_CLIENT_MAIL"]);o.My_Client.CLIENT_DOB = GV<String>(X["T_CLIENT_CLIENT_DOB"]);o.My_Client.BLOODTYPE_ID = GV<Int32>(X["T_CLIENT_BLOODTYPE_ID"]);o.My_Client.ENTRY_USER_ID = GV<Int64>(X["T_CLIENT_ENTRY_USER_ID"]);o.My_Client.ENTRY_DATE = GV<String>(X["T_CLIENT_ENTRY_DATE"]);o.My_Client.OWNER_ID = GV<Int32>(X["T_CLIENT_OWNER_ID"]);o.My_Client.CLIENT_GENDER = GV<String>(X["T_CLIENT_CLIENT_GENDER"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Package = new Package();
o.My_Package.PACKAGE_ID = GV<Int32>(X["T_PACKAGE_PACKAGE_ID"]);o.My_Package.PACKAGE_NAME = GV<String>(X["T_PACKAGE_PACKAGE_NAME"]);o.My_Package.PACKAGE_PRICE = GV<Int32>(X["T_PACKAGE_PACKAGE_PRICE"]);o.My_Package.CURRENCY_ID = GV<Int32>(X["T_PACKAGE_CURRENCY_ID"]);o.My_Package.ENTRY_USER_ID = GV<Int64>(X["T_PACKAGE_ENTRY_USER_ID"]);o.My_Package.ENTRY_DATE = GV<String>(X["T_PACKAGE_ENTRY_DATE"]);o.My_Package.OWNER_ID = GV<Int32>(X["T_PACKAGE_OWNER_ID"]);o.My_Package.PACKAGE_SESSIONS_NB = GV<Int32>(X["T_PACKAGE_PACKAGE_SESSIONS_NB"]);o.My_Package.PACKAGE_TYPE = GV<String>(X["T_PACKAGE_PACKAGE_TYPE"]);o.My_Package.PACKAGE_ENDING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_ENDING_DATE"]);o.My_Package.PACKAGE_TIMELINE = GV<String>(X["T_PACKAGE_PACKAGE_TIMELINE"]);o.My_Package.PACKAGE_STARTING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_STARTING_DATE"]);o.My_Package.PACKAGE_NB_OF_MONTH = GV<Int32>(X["T_PACKAGE_PACKAGE_NB_OF_MONTH"]);
o.My_Registration = new Registration();
o.My_Registration.REGISTRATION_ID = GV<Int32>(X["T_REGISTRATION_REGISTRATION_ID"]);o.My_Registration.CLIENT_ID = GV<Int32>(X["T_REGISTRATION_CLIENT_ID"]);o.My_Registration.REGISTRATION_DATE = GV<String>(X["T_REGISTRATION_REGISTRATION_DATE"]);o.My_Registration.PACKAGE_ID = GV<Int32>(X["T_REGISTRATION_PACKAGE_ID"]);o.My_Registration.REGISTRATION_DISCOUNT = GV<Int32>(X["T_REGISTRATION_REGISTRATION_DISCOUNT"]);o.My_Registration.REGISTRATION_TOTAL_PRICE = GV<Int32>(X["T_REGISTRATION_REGISTRATION_TOTAL_PRICE"]);o.My_Registration.CURRENCY_ID = GV<Int32>(X["T_REGISTRATION_CURRENCY_ID"]);o.My_Registration.REGISTRATION_DESCRIPTION = GV<String>(X["T_REGISTRATION_REGISTRATION_DESCRIPTION"]);o.My_Registration.ENTRY_USER_ID = GV<Int64>(X["T_REGISTRATION_ENTRY_USER_ID"]);o.My_Registration.ENTRY_DATE = GV<String>(X["T_REGISTRATION_ENTRY_DATE"]);o.My_Registration.OWNER_ID = GV<Int32>(X["T_REGISTRATION_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Client_fees> Get_Client_fees_By_Where_Adv ( string CLIENT_FEES_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Client_fees> oList = new List<Client_fees>();
dynamic p = new ExpandoObject();
p.CLIENT_FEES_DESCRIPTION = CLIENT_FEES_DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CLIENT_FEES_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Client_fees o = new Client_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Client = new Client();
o.My_Client.CLIENT_ID = GV<Int32>(X["T_CLIENT_CLIENT_ID"]);o.My_Client.CLIENT_NAME = GV<String>(X["T_CLIENT_CLIENT_NAME"]);o.My_Client.CLIENT_PH_NB = GV<String>(X["T_CLIENT_CLIENT_PH_NB"]);o.My_Client.CLIENT_MAIL = GV<String>(X["T_CLIENT_CLIENT_MAIL"]);o.My_Client.CLIENT_DOB = GV<String>(X["T_CLIENT_CLIENT_DOB"]);o.My_Client.BLOODTYPE_ID = GV<Int32>(X["T_CLIENT_BLOODTYPE_ID"]);o.My_Client.ENTRY_USER_ID = GV<Int64>(X["T_CLIENT_ENTRY_USER_ID"]);o.My_Client.ENTRY_DATE = GV<String>(X["T_CLIENT_ENTRY_DATE"]);o.My_Client.OWNER_ID = GV<Int32>(X["T_CLIENT_OWNER_ID"]);o.My_Client.CLIENT_GENDER = GV<String>(X["T_CLIENT_CLIENT_GENDER"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Package = new Package();
o.My_Package.PACKAGE_ID = GV<Int32>(X["T_PACKAGE_PACKAGE_ID"]);o.My_Package.PACKAGE_NAME = GV<String>(X["T_PACKAGE_PACKAGE_NAME"]);o.My_Package.PACKAGE_PRICE = GV<Int32>(X["T_PACKAGE_PACKAGE_PRICE"]);o.My_Package.CURRENCY_ID = GV<Int32>(X["T_PACKAGE_CURRENCY_ID"]);o.My_Package.ENTRY_USER_ID = GV<Int64>(X["T_PACKAGE_ENTRY_USER_ID"]);o.My_Package.ENTRY_DATE = GV<String>(X["T_PACKAGE_ENTRY_DATE"]);o.My_Package.OWNER_ID = GV<Int32>(X["T_PACKAGE_OWNER_ID"]);o.My_Package.PACKAGE_SESSIONS_NB = GV<Int32>(X["T_PACKAGE_PACKAGE_SESSIONS_NB"]);o.My_Package.PACKAGE_TYPE = GV<String>(X["T_PACKAGE_PACKAGE_TYPE"]);o.My_Package.PACKAGE_ENDING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_ENDING_DATE"]);o.My_Package.PACKAGE_TIMELINE = GV<String>(X["T_PACKAGE_PACKAGE_TIMELINE"]);o.My_Package.PACKAGE_STARTING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_STARTING_DATE"]);o.My_Package.PACKAGE_NB_OF_MONTH = GV<Int32>(X["T_PACKAGE_PACKAGE_NB_OF_MONTH"]);
o.My_Registration = new Registration();
o.My_Registration.REGISTRATION_ID = GV<Int32>(X["T_REGISTRATION_REGISTRATION_ID"]);o.My_Registration.CLIENT_ID = GV<Int32>(X["T_REGISTRATION_CLIENT_ID"]);o.My_Registration.REGISTRATION_DATE = GV<String>(X["T_REGISTRATION_REGISTRATION_DATE"]);o.My_Registration.PACKAGE_ID = GV<Int32>(X["T_REGISTRATION_PACKAGE_ID"]);o.My_Registration.REGISTRATION_DISCOUNT = GV<Int32>(X["T_REGISTRATION_REGISTRATION_DISCOUNT"]);o.My_Registration.REGISTRATION_TOTAL_PRICE = GV<Int32>(X["T_REGISTRATION_REGISTRATION_TOTAL_PRICE"]);o.My_Registration.CURRENCY_ID = GV<Int32>(X["T_REGISTRATION_CURRENCY_ID"]);o.My_Registration.REGISTRATION_DESCRIPTION = GV<String>(X["T_REGISTRATION_REGISTRATION_DESCRIPTION"]);o.My_Registration.ENTRY_USER_ID = GV<Int64>(X["T_REGISTRATION_ENTRY_USER_ID"]);o.My_Registration.ENTRY_DATE = GV<String>(X["T_REGISTRATION_ENTRY_DATE"]);o.My_Registration.OWNER_ID = GV<Int32>(X["T_REGISTRATION_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Contact> Get_Contact_By_Criteria_Adv ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.CONTACT_TYPE_CODE = CONTACT_TYPE_CODE; p.CONTACT = CONTACT; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Contact> Get_Contact_By_Where_Adv ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.CONTACT_TYPE_CODE = CONTACT_TYPE_CODE; p.CONTACT = CONTACT; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Currency> Get_Currency_By_Criteria_Adv ( string CURRENCY_TYPE, string CURRENCY_SYMBOL, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Currency> oList = new List<Currency>();
dynamic p = new ExpandoObject();
p.CURRENCY_TYPE = CURRENCY_TYPE; p.CURRENCY_SYMBOL = CURRENCY_SYMBOL; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CURRENCY_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Currency o = new Currency();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Currency> Get_Currency_By_Where_Adv ( string CURRENCY_TYPE, string CURRENCY_SYMBOL, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Currency> oList = new List<Currency>();
dynamic p = new ExpandoObject();
p.CURRENCY_TYPE = CURRENCY_TYPE; p.CURRENCY_SYMBOL = CURRENCY_SYMBOL; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CURRENCY_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Currency o = new Currency();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Fees> Get_Fees_By_Criteria_Adv ( string FEES_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Fees> oList = new List<Fees>();
dynamic p = new ExpandoObject();
p.FEES_DESCRIPTION = FEES_DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEES_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Fees o = new Fees();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Fees> Get_Fees_By_Where_Adv ( string FEES_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Fees> oList = new List<Fees>();
dynamic p = new ExpandoObject();
p.FEES_DESCRIPTION = FEES_DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEES_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Fees o = new Fees();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Fees> Get_Fees_By_Criteria_Adv_V2 ( string FEES_DESCRIPTION, string FEES_ORIGIN_DATE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Fees> oList = new List<Fees>();
dynamic p = new ExpandoObject();
p.FEES_DESCRIPTION = FEES_DESCRIPTION; p.FEES_ORIGIN_DATE = FEES_ORIGIN_DATE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEES_BY_CRITERIA_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Fees o = new Fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Fees> Get_Fees_By_Where_Adv_V2 ( string FEES_DESCRIPTION, string FEES_ORIGIN_DATE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Fees> oList = new List<Fees>();
dynamic p = new ExpandoObject();
p.FEES_DESCRIPTION = FEES_DESCRIPTION; p.FEES_ORIGIN_DATE = FEES_ORIGIN_DATE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEES_BY_WHERE_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Fees o = new Fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_Criteria_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l1> oList = new List<Loc_l1>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L1_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l1 o = new Loc_l1();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l1> Get_Loc_l1_By_Where_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l1> oList = new List<Loc_l1>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L1_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l1 o = new Loc_l1();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Criteria_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Where_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Criteria_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Where_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Criteria_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Where_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Method_run> Get_Method_run_By_Criteria_Adv ( string METHOD_NAME, string INPUT_PARAM, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Method_run> oList = new List<Method_run>();
dynamic p = new ExpandoObject();
p.METHOD_NAME = METHOD_NAME; p.INPUT_PARAM = INPUT_PARAM; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_METHOD_RUN_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Method_run o = new Method_run();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Method_run> Get_Method_run_By_Where_Adv ( string METHOD_NAME, string INPUT_PARAM, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Method_run> oList = new List<Method_run>();
dynamic p = new ExpandoObject();
p.METHOD_NAME = METHOD_NAME; p.INPUT_PARAM = INPUT_PARAM; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_METHOD_RUN_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Method_run o = new Method_run();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Method_run> Get_Method_run_By_Criteria_Adv_V2 ( string METHOD_NAME, string RUN_DATE, string INPUT_PARAM, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Method_run> oList = new List<Method_run>();
dynamic p = new ExpandoObject();
p.METHOD_NAME = METHOD_NAME; p.RUN_DATE = RUN_DATE; p.INPUT_PARAM = INPUT_PARAM; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_METHOD_RUN_BY_CRITERIA_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Method_run o = new Method_run();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Method_run> Get_Method_run_By_Where_Adv_V2 ( string METHOD_NAME, string RUN_DATE, string INPUT_PARAM, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Method_run> oList = new List<Method_run>();
dynamic p = new ExpandoObject();
p.METHOD_NAME = METHOD_NAME; p.RUN_DATE = RUN_DATE; p.INPUT_PARAM = INPUT_PARAM; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_METHOD_RUN_BY_WHERE_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Method_run o = new Method_run();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Package> Get_Package_By_Criteria_Adv ( string PACKAGE_NAME, string PACKAGE_TYPE, string PACKAGE_TIMELINE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Package> oList = new List<Package>();
dynamic p = new ExpandoObject();
p.PACKAGE_NAME = PACKAGE_NAME; p.PACKAGE_TYPE = PACKAGE_TYPE; p.PACKAGE_TIMELINE = PACKAGE_TIMELINE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PACKAGE_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Package o = new Package();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Package> Get_Package_By_Where_Adv ( string PACKAGE_NAME, string PACKAGE_TYPE, string PACKAGE_TIMELINE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Package> oList = new List<Package>();
dynamic p = new ExpandoObject();
p.PACKAGE_NAME = PACKAGE_NAME; p.PACKAGE_TYPE = PACKAGE_TYPE; p.PACKAGE_TIMELINE = PACKAGE_TIMELINE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PACKAGE_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Package o = new Package();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Package> Get_Package_By_Criteria_Adv_V2 ( string PACKAGE_NAME, string PACKAGE_TYPE, string PACKAGE_ENDING_DATE, string PACKAGE_TIMELINE, string PACKAGE_STARTING_DATE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Package> oList = new List<Package>();
dynamic p = new ExpandoObject();
p.PACKAGE_NAME = PACKAGE_NAME; p.PACKAGE_TYPE = PACKAGE_TYPE; p.PACKAGE_ENDING_DATE = PACKAGE_ENDING_DATE; p.PACKAGE_TIMELINE = PACKAGE_TIMELINE; p.PACKAGE_STARTING_DATE = PACKAGE_STARTING_DATE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PACKAGE_BY_CRITERIA_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Package o = new Package();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Package> Get_Package_By_Where_Adv_V2 ( string PACKAGE_NAME, string PACKAGE_TYPE, string PACKAGE_ENDING_DATE, string PACKAGE_TIMELINE, string PACKAGE_STARTING_DATE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Package> oList = new List<Package>();
dynamic p = new ExpandoObject();
p.PACKAGE_NAME = PACKAGE_NAME; p.PACKAGE_TYPE = PACKAGE_TYPE; p.PACKAGE_ENDING_DATE = PACKAGE_ENDING_DATE; p.PACKAGE_TIMELINE = PACKAGE_TIMELINE; p.PACKAGE_STARTING_DATE = PACKAGE_STARTING_DATE; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PACKAGE_BY_WHERE_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Package o = new Package();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Person> Get_Person_By_Criteria_Adv ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Person> oList = new List<Person>();
dynamic p = new ExpandoObject();
p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.FATHER_NAME = FATHER_NAME; p.MOTHER_NAME = MOTHER_NAME; p.TITLE_CODE = TITLE_CODE; p.GENDER_CODE = GENDER_CODE; p.RELIGION_CODE = RELIGION_CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PERSON_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Person o = new Person();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Person> Get_Person_By_Where_Adv ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Person> oList = new List<Person>();
dynamic p = new ExpandoObject();
p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.FATHER_NAME = FATHER_NAME; p.MOTHER_NAME = MOTHER_NAME; p.TITLE_CODE = TITLE_CODE; p.GENDER_CODE = GENDER_CODE; p.RELIGION_CODE = RELIGION_CODE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PERSON_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Person o = new Person();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Person> Get_Person_By_Criteria_Adv_V2 ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string BIRTH_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Person> oList = new List<Person>();
dynamic p = new ExpandoObject();
p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.FATHER_NAME = FATHER_NAME; p.MOTHER_NAME = MOTHER_NAME; p.TITLE_CODE = TITLE_CODE; p.GENDER_CODE = GENDER_CODE; p.RELIGION_CODE = RELIGION_CODE; p.BIRTH_DATE = BIRTH_DATE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PERSON_BY_CRITERIA_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Person o = new Person();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Person> Get_Person_By_Where_Adv_V2 ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string BIRTH_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Person> oList = new List<Person>();
dynamic p = new ExpandoObject();
p.FIRST_NAME = FIRST_NAME; p.LAST_NAME = LAST_NAME; p.FATHER_NAME = FATHER_NAME; p.MOTHER_NAME = MOTHER_NAME; p.TITLE_CODE = TITLE_CODE; p.GENDER_CODE = GENDER_CODE; p.RELIGION_CODE = RELIGION_CODE; p.BIRTH_DATE = BIRTH_DATE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PERSON_BY_WHERE_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Person o = new Person();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Registration> Get_Registration_By_Criteria_Adv ( string REGISTRATION_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Registration> oList = new List<Registration>();
dynamic p = new ExpandoObject();
p.REGISTRATION_DESCRIPTION = REGISTRATION_DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_REGISTRATION_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Registration o = new Registration();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Client = new Client();
o.My_Client.CLIENT_ID = GV<Int32>(X["T_CLIENT_CLIENT_ID"]);o.My_Client.CLIENT_NAME = GV<String>(X["T_CLIENT_CLIENT_NAME"]);o.My_Client.CLIENT_PH_NB = GV<String>(X["T_CLIENT_CLIENT_PH_NB"]);o.My_Client.CLIENT_MAIL = GV<String>(X["T_CLIENT_CLIENT_MAIL"]);o.My_Client.CLIENT_DOB = GV<String>(X["T_CLIENT_CLIENT_DOB"]);o.My_Client.BLOODTYPE_ID = GV<Int32>(X["T_CLIENT_BLOODTYPE_ID"]);o.My_Client.ENTRY_USER_ID = GV<Int64>(X["T_CLIENT_ENTRY_USER_ID"]);o.My_Client.ENTRY_DATE = GV<String>(X["T_CLIENT_ENTRY_DATE"]);o.My_Client.OWNER_ID = GV<Int32>(X["T_CLIENT_OWNER_ID"]);o.My_Client.CLIENT_GENDER = GV<String>(X["T_CLIENT_CLIENT_GENDER"]);
o.My_Package = new Package();
o.My_Package.PACKAGE_ID = GV<Int32>(X["T_PACKAGE_PACKAGE_ID"]);o.My_Package.PACKAGE_NAME = GV<String>(X["T_PACKAGE_PACKAGE_NAME"]);o.My_Package.PACKAGE_PRICE = GV<Int32>(X["T_PACKAGE_PACKAGE_PRICE"]);o.My_Package.CURRENCY_ID = GV<Int32>(X["T_PACKAGE_CURRENCY_ID"]);o.My_Package.ENTRY_USER_ID = GV<Int64>(X["T_PACKAGE_ENTRY_USER_ID"]);o.My_Package.ENTRY_DATE = GV<String>(X["T_PACKAGE_ENTRY_DATE"]);o.My_Package.OWNER_ID = GV<Int32>(X["T_PACKAGE_OWNER_ID"]);o.My_Package.PACKAGE_SESSIONS_NB = GV<Int32>(X["T_PACKAGE_PACKAGE_SESSIONS_NB"]);o.My_Package.PACKAGE_TYPE = GV<String>(X["T_PACKAGE_PACKAGE_TYPE"]);o.My_Package.PACKAGE_ENDING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_ENDING_DATE"]);o.My_Package.PACKAGE_TIMELINE = GV<String>(X["T_PACKAGE_PACKAGE_TIMELINE"]);o.My_Package.PACKAGE_STARTING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_STARTING_DATE"]);o.My_Package.PACKAGE_NB_OF_MONTH = GV<Int32>(X["T_PACKAGE_PACKAGE_NB_OF_MONTH"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Registration> Get_Registration_By_Where_Adv ( string REGISTRATION_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Registration> oList = new List<Registration>();
dynamic p = new ExpandoObject();
p.REGISTRATION_DESCRIPTION = REGISTRATION_DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_REGISTRATION_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Registration o = new Registration();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Client = new Client();
o.My_Client.CLIENT_ID = GV<Int32>(X["T_CLIENT_CLIENT_ID"]);o.My_Client.CLIENT_NAME = GV<String>(X["T_CLIENT_CLIENT_NAME"]);o.My_Client.CLIENT_PH_NB = GV<String>(X["T_CLIENT_CLIENT_PH_NB"]);o.My_Client.CLIENT_MAIL = GV<String>(X["T_CLIENT_CLIENT_MAIL"]);o.My_Client.CLIENT_DOB = GV<String>(X["T_CLIENT_CLIENT_DOB"]);o.My_Client.BLOODTYPE_ID = GV<Int32>(X["T_CLIENT_BLOODTYPE_ID"]);o.My_Client.ENTRY_USER_ID = GV<Int64>(X["T_CLIENT_ENTRY_USER_ID"]);o.My_Client.ENTRY_DATE = GV<String>(X["T_CLIENT_ENTRY_DATE"]);o.My_Client.OWNER_ID = GV<Int32>(X["T_CLIENT_OWNER_ID"]);o.My_Client.CLIENT_GENDER = GV<String>(X["T_CLIENT_CLIENT_GENDER"]);
o.My_Package = new Package();
o.My_Package.PACKAGE_ID = GV<Int32>(X["T_PACKAGE_PACKAGE_ID"]);o.My_Package.PACKAGE_NAME = GV<String>(X["T_PACKAGE_PACKAGE_NAME"]);o.My_Package.PACKAGE_PRICE = GV<Int32>(X["T_PACKAGE_PACKAGE_PRICE"]);o.My_Package.CURRENCY_ID = GV<Int32>(X["T_PACKAGE_CURRENCY_ID"]);o.My_Package.ENTRY_USER_ID = GV<Int64>(X["T_PACKAGE_ENTRY_USER_ID"]);o.My_Package.ENTRY_DATE = GV<String>(X["T_PACKAGE_ENTRY_DATE"]);o.My_Package.OWNER_ID = GV<Int32>(X["T_PACKAGE_OWNER_ID"]);o.My_Package.PACKAGE_SESSIONS_NB = GV<Int32>(X["T_PACKAGE_PACKAGE_SESSIONS_NB"]);o.My_Package.PACKAGE_TYPE = GV<String>(X["T_PACKAGE_PACKAGE_TYPE"]);o.My_Package.PACKAGE_ENDING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_ENDING_DATE"]);o.My_Package.PACKAGE_TIMELINE = GV<String>(X["T_PACKAGE_PACKAGE_TIMELINE"]);o.My_Package.PACKAGE_STARTING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_STARTING_DATE"]);o.My_Package.PACKAGE_NB_OF_MONTH = GV<Int32>(X["T_PACKAGE_PACKAGE_NB_OF_MONTH"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Registration> Get_Registration_By_Criteria_Adv_V2 ( string REGISTRATION_DATE, string REGISTRATION_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Registration> oList = new List<Registration>();
dynamic p = new ExpandoObject();
p.REGISTRATION_DATE = REGISTRATION_DATE; p.REGISTRATION_DESCRIPTION = REGISTRATION_DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_REGISTRATION_BY_CRITERIA_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Registration o = new Registration();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Registration> Get_Registration_By_Where_Adv_V2 ( string REGISTRATION_DATE, string REGISTRATION_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Registration> oList = new List<Registration>();
dynamic p = new ExpandoObject();
p.REGISTRATION_DATE = REGISTRATION_DATE; p.REGISTRATION_DESCRIPTION = REGISTRATION_DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_REGISTRATION_BY_WHERE_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Registration o = new Registration();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Session> Get_Session_By_Criteria_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Session> oList = new List<Session>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SESSION_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Session o = new Session();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Package = new Package();
o.My_Package.PACKAGE_ID = GV<Int32>(X["T_PACKAGE_PACKAGE_ID"]);o.My_Package.PACKAGE_NAME = GV<String>(X["T_PACKAGE_PACKAGE_NAME"]);o.My_Package.PACKAGE_PRICE = GV<Int32>(X["T_PACKAGE_PACKAGE_PRICE"]);o.My_Package.CURRENCY_ID = GV<Int32>(X["T_PACKAGE_CURRENCY_ID"]);o.My_Package.ENTRY_USER_ID = GV<Int64>(X["T_PACKAGE_ENTRY_USER_ID"]);o.My_Package.ENTRY_DATE = GV<String>(X["T_PACKAGE_ENTRY_DATE"]);o.My_Package.OWNER_ID = GV<Int32>(X["T_PACKAGE_OWNER_ID"]);o.My_Package.PACKAGE_SESSIONS_NB = GV<Int32>(X["T_PACKAGE_PACKAGE_SESSIONS_NB"]);o.My_Package.PACKAGE_TYPE = GV<String>(X["T_PACKAGE_PACKAGE_TYPE"]);o.My_Package.PACKAGE_ENDING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_ENDING_DATE"]);o.My_Package.PACKAGE_TIMELINE = GV<String>(X["T_PACKAGE_PACKAGE_TIMELINE"]);o.My_Package.PACKAGE_STARTING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_STARTING_DATE"]);o.My_Package.PACKAGE_NB_OF_MONTH = GV<Int32>(X["T_PACKAGE_PACKAGE_NB_OF_MONTH"]);
o.My_Client_fees = new Client_fees();
o.My_Client_fees.CLIENT_FEES_ID = GV<Int32>(X["T_CLIENT_FEES_CLIENT_FEES_ID"]);o.My_Client_fees.CLIENT_ID = GV<Int32>(X["T_CLIENT_FEES_CLIENT_ID"]);o.My_Client_fees.CLIENT_FEES_DESCRIPTION = GV<String>(X["T_CLIENT_FEES_CLIENT_FEES_DESCRIPTION"]);o.My_Client_fees.ENTRY_USER_ID = GV<Int64>(X["T_CLIENT_FEES_ENTRY_USER_ID"]);o.My_Client_fees.ENTRY_DATE = GV<String>(X["T_CLIENT_FEES_ENTRY_DATE"]);o.My_Client_fees.OWNER_ID = GV<Int32>(X["T_CLIENT_FEES_OWNER_ID"]);o.My_Client_fees.CURRENCY_ID = GV<Int32>(X["T_CLIENT_FEES_CURRENCY_ID"]);o.My_Client_fees.PACKAGE_ID = GV<Int32>(X["T_CLIENT_FEES_PACKAGE_ID"]);o.My_Client_fees.CLIENT_FEES_AMOUNT = GV<Int32>(X["T_CLIENT_FEES_CLIENT_FEES_AMOUNT"]);o.My_Client_fees.REGISTRATION_ID = GV<Int32>(X["T_CLIENT_FEES_REGISTRATION_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Session> Get_Session_By_Where_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Session> oList = new List<Session>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SESSION_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Session o = new Session();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Package = new Package();
o.My_Package.PACKAGE_ID = GV<Int32>(X["T_PACKAGE_PACKAGE_ID"]);o.My_Package.PACKAGE_NAME = GV<String>(X["T_PACKAGE_PACKAGE_NAME"]);o.My_Package.PACKAGE_PRICE = GV<Int32>(X["T_PACKAGE_PACKAGE_PRICE"]);o.My_Package.CURRENCY_ID = GV<Int32>(X["T_PACKAGE_CURRENCY_ID"]);o.My_Package.ENTRY_USER_ID = GV<Int64>(X["T_PACKAGE_ENTRY_USER_ID"]);o.My_Package.ENTRY_DATE = GV<String>(X["T_PACKAGE_ENTRY_DATE"]);o.My_Package.OWNER_ID = GV<Int32>(X["T_PACKAGE_OWNER_ID"]);o.My_Package.PACKAGE_SESSIONS_NB = GV<Int32>(X["T_PACKAGE_PACKAGE_SESSIONS_NB"]);o.My_Package.PACKAGE_TYPE = GV<String>(X["T_PACKAGE_PACKAGE_TYPE"]);o.My_Package.PACKAGE_ENDING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_ENDING_DATE"]);o.My_Package.PACKAGE_TIMELINE = GV<String>(X["T_PACKAGE_PACKAGE_TIMELINE"]);o.My_Package.PACKAGE_STARTING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_STARTING_DATE"]);o.My_Package.PACKAGE_NB_OF_MONTH = GV<Int32>(X["T_PACKAGE_PACKAGE_NB_OF_MONTH"]);
o.My_Client_fees = new Client_fees();
o.My_Client_fees.CLIENT_FEES_ID = GV<Int32>(X["T_CLIENT_FEES_CLIENT_FEES_ID"]);o.My_Client_fees.CLIENT_ID = GV<Int32>(X["T_CLIENT_FEES_CLIENT_ID"]);o.My_Client_fees.CLIENT_FEES_DESCRIPTION = GV<String>(X["T_CLIENT_FEES_CLIENT_FEES_DESCRIPTION"]);o.My_Client_fees.ENTRY_USER_ID = GV<Int64>(X["T_CLIENT_FEES_ENTRY_USER_ID"]);o.My_Client_fees.ENTRY_DATE = GV<String>(X["T_CLIENT_FEES_ENTRY_DATE"]);o.My_Client_fees.OWNER_ID = GV<Int32>(X["T_CLIENT_FEES_OWNER_ID"]);o.My_Client_fees.CURRENCY_ID = GV<Int32>(X["T_CLIENT_FEES_CURRENCY_ID"]);o.My_Client_fees.PACKAGE_ID = GV<Int32>(X["T_CLIENT_FEES_PACKAGE_ID"]);o.My_Client_fees.CLIENT_FEES_AMOUNT = GV<Int32>(X["T_CLIENT_FEES_CLIENT_FEES_AMOUNT"]);o.My_Client_fees.REGISTRATION_ID = GV<Int32>(X["T_CLIENT_FEES_REGISTRATION_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Session> Get_Session_By_Criteria_Adv_V2 ( string SESSION_STARTING_DATE, string SESSION_ENDING_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Session> oList = new List<Session>();
dynamic p = new ExpandoObject();
p.SESSION_STARTING_DATE = SESSION_STARTING_DATE; p.SESSION_ENDING_DATE = SESSION_ENDING_DATE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SESSION_BY_CRITERIA_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Session o = new Session();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Session> Get_Session_By_Where_Adv_V2 ( string SESSION_STARTING_DATE, string SESSION_ENDING_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Session> oList = new List<Session>();
dynamic p = new ExpandoObject();
p.SESSION_STARTING_DATE = SESSION_STARTING_DATE; p.SESSION_ENDING_DATE = SESSION_ENDING_DATE; p.DESCRIPTION = DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SESSION_BY_WHERE_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Session o = new Session();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Staff> Get_Staff_By_Criteria_Adv ( string STAFF_NAME, string STAFF_PH_NB, string STAFF_MAIL, string STAFF_GENDER, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Staff> oList = new List<Staff>();
dynamic p = new ExpandoObject();
p.STAFF_NAME = STAFF_NAME; p.STAFF_PH_NB = STAFF_PH_NB; p.STAFF_MAIL = STAFF_MAIL; p.STAFF_GENDER = STAFF_GENDER; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Staff o = new Staff();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Bloodtype = new Bloodtype();
o.My_Bloodtype.BLOODTYPE_ID = GV<Int32>(X["T_BLOODTYPE_BLOODTYPE_ID"]);o.My_Bloodtype.BLOODTYPE_SYMBOL = GV<String>(X["T_BLOODTYPE_BLOODTYPE_SYMBOL"]);o.My_Bloodtype.ENTRY_USER_ID = GV<Int64>(X["T_BLOODTYPE_ENTRY_USER_ID"]);o.My_Bloodtype.ENTRY_DATE = GV<String>(X["T_BLOODTYPE_ENTRY_DATE"]);o.My_Bloodtype.OWNER_ID = GV<Int32>(X["T_BLOODTYPE_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Staff> Get_Staff_By_Where_Adv ( string STAFF_NAME, string STAFF_PH_NB, string STAFF_MAIL, string STAFF_GENDER, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Staff> oList = new List<Staff>();
dynamic p = new ExpandoObject();
p.STAFF_NAME = STAFF_NAME; p.STAFF_PH_NB = STAFF_PH_NB; p.STAFF_MAIL = STAFF_MAIL; p.STAFF_GENDER = STAFF_GENDER; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Staff o = new Staff();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Bloodtype = new Bloodtype();
o.My_Bloodtype.BLOODTYPE_ID = GV<Int32>(X["T_BLOODTYPE_BLOODTYPE_ID"]);o.My_Bloodtype.BLOODTYPE_SYMBOL = GV<String>(X["T_BLOODTYPE_BLOODTYPE_SYMBOL"]);o.My_Bloodtype.ENTRY_USER_ID = GV<Int64>(X["T_BLOODTYPE_ENTRY_USER_ID"]);o.My_Bloodtype.ENTRY_DATE = GV<String>(X["T_BLOODTYPE_ENTRY_DATE"]);o.My_Bloodtype.OWNER_ID = GV<Int32>(X["T_BLOODTYPE_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Staff> Get_Staff_By_Criteria_Adv_V2 ( string STAFF_NAME, string STAFF_PH_NB, string STAFF_MAIL, string STAFF_DOB, string STAFF_GENDER, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Staff> oList = new List<Staff>();
dynamic p = new ExpandoObject();
p.STAFF_NAME = STAFF_NAME; p.STAFF_PH_NB = STAFF_PH_NB; p.STAFF_MAIL = STAFF_MAIL; p.STAFF_DOB = STAFF_DOB; p.STAFF_GENDER = STAFF_GENDER; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_BY_CRITERIA_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Staff o = new Staff();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Staff> Get_Staff_By_Where_Adv_V2 ( string STAFF_NAME, string STAFF_PH_NB, string STAFF_MAIL, string STAFF_DOB, string STAFF_GENDER, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Staff> oList = new List<Staff>();
dynamic p = new ExpandoObject();
p.STAFF_NAME = STAFF_NAME; p.STAFF_PH_NB = STAFF_PH_NB; p.STAFF_MAIL = STAFF_MAIL; p.STAFF_DOB = STAFF_DOB; p.STAFF_GENDER = STAFF_GENDER; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_BY_WHERE_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Staff o = new Staff();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Staff_fees> Get_Staff_fees_By_Criteria_Adv ( string STAFF_FEES_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Staff_fees> oList = new List<Staff_fees>();
dynamic p = new ExpandoObject();
p.STAFF_FEES_DESCRIPTION = STAFF_FEES_DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_FEES_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Staff_fees o = new Staff_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Staff = new Staff();
o.My_Staff.STAFF_ID = GV<Int32>(X["T_STAFF_STAFF_ID"]);o.My_Staff.STAFF_NAME = GV<String>(X["T_STAFF_STAFF_NAME"]);o.My_Staff.STAFF_PH_NB = GV<String>(X["T_STAFF_STAFF_PH_NB"]);o.My_Staff.STAFF_MAIL = GV<String>(X["T_STAFF_STAFF_MAIL"]);o.My_Staff.STAFF_DOB = GV<String>(X["T_STAFF_STAFF_DOB"]);o.My_Staff.BLOODTYPE_ID = GV<Int32>(X["T_STAFF_BLOODTYPE_ID"]);o.My_Staff.ENTRY_USER_ID = GV<Int64>(X["T_STAFF_ENTRY_USER_ID"]);o.My_Staff.ENTRY_DATE = GV<String>(X["T_STAFF_ENTRY_DATE"]);o.My_Staff.OWNER_ID = GV<Int32>(X["T_STAFF_OWNER_ID"]);o.My_Staff.STAFF_GENDER = GV<String>(X["T_STAFF_STAFF_GENDER"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Registered_staff_expense = new Registered_staff_expense();
o.My_Registered_staff_expense.REGISTERED_STAFF_EXPENSE_ID = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_REGISTERED_STAFF_EXPENSE_ID"]);o.My_Registered_staff_expense.REGISTERED_STAFF_EXPENSE_DISCOUNT = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_REGISTERED_STAFF_EXPENSE_DISCOUNT"]);o.My_Registered_staff_expense.REGISTERED_STAFF_EXPENSE_TOTAL_AMOUNT = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_REGISTERED_STAFF_EXPENSE_TOTAL_AMOUNT"]);o.My_Registered_staff_expense.REGISTERED_STAFF_EXPENSE_DESCRIPTION = GV<String>(X["T_REGISTERED_STAFF_EXPENSE_REGISTERED_STAFF_EXPENSE_DESCRIPTION"]);o.My_Registered_staff_expense.STAFF_ID = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_STAFF_ID"]);o.My_Registered_staff_expense.CURRENCY_ID = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_CURRENCY_ID"]);o.My_Registered_staff_expense.ENTRY_USER_ID = GV<Int64>(X["T_REGISTERED_STAFF_EXPENSE_ENTRY_USER_ID"]);o.My_Registered_staff_expense.ENTRY_DATE = GV<String>(X["T_REGISTERED_STAFF_EXPENSE_ENTRY_DATE"]);o.My_Registered_staff_expense.OWNER_ID = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Staff_fees> Get_Staff_fees_By_Where_Adv ( string STAFF_FEES_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Staff_fees> oList = new List<Staff_fees>();
dynamic p = new ExpandoObject();
p.STAFF_FEES_DESCRIPTION = STAFF_FEES_DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_FEES_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Staff_fees o = new Staff_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Staff = new Staff();
o.My_Staff.STAFF_ID = GV<Int32>(X["T_STAFF_STAFF_ID"]);o.My_Staff.STAFF_NAME = GV<String>(X["T_STAFF_STAFF_NAME"]);o.My_Staff.STAFF_PH_NB = GV<String>(X["T_STAFF_STAFF_PH_NB"]);o.My_Staff.STAFF_MAIL = GV<String>(X["T_STAFF_STAFF_MAIL"]);o.My_Staff.STAFF_DOB = GV<String>(X["T_STAFF_STAFF_DOB"]);o.My_Staff.BLOODTYPE_ID = GV<Int32>(X["T_STAFF_BLOODTYPE_ID"]);o.My_Staff.ENTRY_USER_ID = GV<Int64>(X["T_STAFF_ENTRY_USER_ID"]);o.My_Staff.ENTRY_DATE = GV<String>(X["T_STAFF_ENTRY_DATE"]);o.My_Staff.OWNER_ID = GV<Int32>(X["T_STAFF_OWNER_ID"]);o.My_Staff.STAFF_GENDER = GV<String>(X["T_STAFF_STAFF_GENDER"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Registered_staff_expense = new Registered_staff_expense();
o.My_Registered_staff_expense.REGISTERED_STAFF_EXPENSE_ID = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_REGISTERED_STAFF_EXPENSE_ID"]);o.My_Registered_staff_expense.REGISTERED_STAFF_EXPENSE_DISCOUNT = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_REGISTERED_STAFF_EXPENSE_DISCOUNT"]);o.My_Registered_staff_expense.REGISTERED_STAFF_EXPENSE_TOTAL_AMOUNT = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_REGISTERED_STAFF_EXPENSE_TOTAL_AMOUNT"]);o.My_Registered_staff_expense.REGISTERED_STAFF_EXPENSE_DESCRIPTION = GV<String>(X["T_REGISTERED_STAFF_EXPENSE_REGISTERED_STAFF_EXPENSE_DESCRIPTION"]);o.My_Registered_staff_expense.STAFF_ID = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_STAFF_ID"]);o.My_Registered_staff_expense.CURRENCY_ID = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_CURRENCY_ID"]);o.My_Registered_staff_expense.ENTRY_USER_ID = GV<Int64>(X["T_REGISTERED_STAFF_EXPENSE_ENTRY_USER_ID"]);o.My_Registered_staff_expense.ENTRY_DATE = GV<String>(X["T_REGISTERED_STAFF_EXPENSE_ENTRY_DATE"]);o.My_Registered_staff_expense.OWNER_ID = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Supplier> Get_Supplier_By_Criteria_Adv ( string SUPPLIER_NAME, string SUPPLIER_PH_NB, string SUPPLIER_MAIL, string SUPPLIER_GENDER, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Supplier> oList = new List<Supplier>();
dynamic p = new ExpandoObject();
p.SUPPLIER_NAME = SUPPLIER_NAME; p.SUPPLIER_PH_NB = SUPPLIER_PH_NB; p.SUPPLIER_MAIL = SUPPLIER_MAIL; p.SUPPLIER_GENDER = SUPPLIER_GENDER; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Supplier o = new Supplier();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Bloodtype = new Bloodtype();
o.My_Bloodtype.BLOODTYPE_ID = GV<Int32>(X["T_BLOODTYPE_BLOODTYPE_ID"]);o.My_Bloodtype.BLOODTYPE_SYMBOL = GV<String>(X["T_BLOODTYPE_BLOODTYPE_SYMBOL"]);o.My_Bloodtype.ENTRY_USER_ID = GV<Int64>(X["T_BLOODTYPE_ENTRY_USER_ID"]);o.My_Bloodtype.ENTRY_DATE = GV<String>(X["T_BLOODTYPE_ENTRY_DATE"]);o.My_Bloodtype.OWNER_ID = GV<Int32>(X["T_BLOODTYPE_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Supplier> Get_Supplier_By_Where_Adv ( string SUPPLIER_NAME, string SUPPLIER_PH_NB, string SUPPLIER_MAIL, string SUPPLIER_GENDER, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Supplier> oList = new List<Supplier>();
dynamic p = new ExpandoObject();
p.SUPPLIER_NAME = SUPPLIER_NAME; p.SUPPLIER_PH_NB = SUPPLIER_PH_NB; p.SUPPLIER_MAIL = SUPPLIER_MAIL; p.SUPPLIER_GENDER = SUPPLIER_GENDER; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Supplier o = new Supplier();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Bloodtype = new Bloodtype();
o.My_Bloodtype.BLOODTYPE_ID = GV<Int32>(X["T_BLOODTYPE_BLOODTYPE_ID"]);o.My_Bloodtype.BLOODTYPE_SYMBOL = GV<String>(X["T_BLOODTYPE_BLOODTYPE_SYMBOL"]);o.My_Bloodtype.ENTRY_USER_ID = GV<Int64>(X["T_BLOODTYPE_ENTRY_USER_ID"]);o.My_Bloodtype.ENTRY_DATE = GV<String>(X["T_BLOODTYPE_ENTRY_DATE"]);o.My_Bloodtype.OWNER_ID = GV<Int32>(X["T_BLOODTYPE_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Supplier> Get_Supplier_By_Criteria_Adv_V2 ( string SUPPLIER_NAME, string SUPPLIER_PH_NB, string SUPPLIER_MAIL, string SUPPLIER_DOB, string SUPPLIER_GENDER, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Supplier> oList = new List<Supplier>();
dynamic p = new ExpandoObject();
p.SUPPLIER_NAME = SUPPLIER_NAME; p.SUPPLIER_PH_NB = SUPPLIER_PH_NB; p.SUPPLIER_MAIL = SUPPLIER_MAIL; p.SUPPLIER_DOB = SUPPLIER_DOB; p.SUPPLIER_GENDER = SUPPLIER_GENDER; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_BY_CRITERIA_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Supplier o = new Supplier();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Supplier> Get_Supplier_By_Where_Adv_V2 ( string SUPPLIER_NAME, string SUPPLIER_PH_NB, string SUPPLIER_MAIL, string SUPPLIER_DOB, string SUPPLIER_GENDER, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Supplier> oList = new List<Supplier>();
dynamic p = new ExpandoObject();
p.SUPPLIER_NAME = SUPPLIER_NAME; p.SUPPLIER_PH_NB = SUPPLIER_PH_NB; p.SUPPLIER_MAIL = SUPPLIER_MAIL; p.SUPPLIER_DOB = SUPPLIER_DOB; p.SUPPLIER_GENDER = SUPPLIER_GENDER; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_BY_WHERE_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Supplier o = new Supplier();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Supplier_fees> Get_Supplier_fees_By_Criteria_Adv ( string SUPPLIER_FEES_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Supplier_fees> oList = new List<Supplier_fees>();
dynamic p = new ExpandoObject();
p.SUPPLIER_FEES_DESCRIPTION = SUPPLIER_FEES_DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_FEES_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
Supplier_fees o = new Supplier_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Supplier = new Supplier();
o.My_Supplier.SUPPLIER_ID = GV<Int32>(X["T_SUPPLIER_SUPPLIER_ID"]);o.My_Supplier.SUPPLIER_NAME = GV<String>(X["T_SUPPLIER_SUPPLIER_NAME"]);o.My_Supplier.SUPPLIER_PH_NB = GV<String>(X["T_SUPPLIER_SUPPLIER_PH_NB"]);o.My_Supplier.SUPPLIER_MAIL = GV<String>(X["T_SUPPLIER_SUPPLIER_MAIL"]);o.My_Supplier.ENTRY_USER_ID = GV<Int64>(X["T_SUPPLIER_ENTRY_USER_ID"]);o.My_Supplier.ENTRY_DATE = GV<String>(X["T_SUPPLIER_ENTRY_DATE"]);o.My_Supplier.OWNER_ID = GV<Int32>(X["T_SUPPLIER_OWNER_ID"]);o.My_Supplier.SUPPLIER_DOB = GV<String>(X["T_SUPPLIER_SUPPLIER_DOB"]);o.My_Supplier.BLOODTYPE_ID = GV<Int32>(X["T_SUPPLIER_BLOODTYPE_ID"]);o.My_Supplier.SUPPLIER_GENDER = GV<String>(X["T_SUPPLIER_SUPPLIER_GENDER"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Registered_supplier_expense = new Registered_supplier_expense();
o.My_Registered_supplier_expense.REGISTERED_SUPPLIER_EXPENSE_ID = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_REGISTERED_SUPPLIER_EXPENSE_ID"]);o.My_Registered_supplier_expense.REGISTERED_SUPPLIER_EXPENSE_DISCOUNT = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_REGISTERED_SUPPLIER_EXPENSE_DISCOUNT"]);o.My_Registered_supplier_expense.REGISTERED_SUPPLIER_EXPENSE_TOTAL_AMOUNT = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_REGISTERED_SUPPLIER_EXPENSE_TOTAL_AMOUNT"]);o.My_Registered_supplier_expense.REGISTERED_SUPPLIER_EXPENSE_DESCRIPTION = GV<String>(X["T_REGISTERED_SUPPLIER_EXPENSE_REGISTERED_SUPPLIER_EXPENSE_DESCRIPTION"]);o.My_Registered_supplier_expense.SUPPLIER_ID = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_SUPPLIER_ID"]);o.My_Registered_supplier_expense.CURRENCY_ID = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_CURRENCY_ID"]);o.My_Registered_supplier_expense.ENTRY_USER_ID = GV<Int64>(X["T_REGISTERED_SUPPLIER_EXPENSE_ENTRY_USER_ID"]);o.My_Registered_supplier_expense.ENTRY_DATE = GV<String>(X["T_REGISTERED_SUPPLIER_EXPENSE_ENTRY_DATE"]);o.My_Registered_supplier_expense.OWNER_ID = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Supplier_fees> Get_Supplier_fees_By_Where_Adv ( string SUPPLIER_FEES_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Supplier_fees> oList = new List<Supplier_fees>();
dynamic p = new ExpandoObject();
p.SUPPLIER_FEES_DESCRIPTION = SUPPLIER_FEES_DESCRIPTION; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_FEES_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
Supplier_fees o = new Supplier_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Supplier = new Supplier();
o.My_Supplier.SUPPLIER_ID = GV<Int32>(X["T_SUPPLIER_SUPPLIER_ID"]);o.My_Supplier.SUPPLIER_NAME = GV<String>(X["T_SUPPLIER_SUPPLIER_NAME"]);o.My_Supplier.SUPPLIER_PH_NB = GV<String>(X["T_SUPPLIER_SUPPLIER_PH_NB"]);o.My_Supplier.SUPPLIER_MAIL = GV<String>(X["T_SUPPLIER_SUPPLIER_MAIL"]);o.My_Supplier.ENTRY_USER_ID = GV<Int64>(X["T_SUPPLIER_ENTRY_USER_ID"]);o.My_Supplier.ENTRY_DATE = GV<String>(X["T_SUPPLIER_ENTRY_DATE"]);o.My_Supplier.OWNER_ID = GV<Int32>(X["T_SUPPLIER_OWNER_ID"]);o.My_Supplier.SUPPLIER_DOB = GV<String>(X["T_SUPPLIER_SUPPLIER_DOB"]);o.My_Supplier.BLOODTYPE_ID = GV<Int32>(X["T_SUPPLIER_BLOODTYPE_ID"]);o.My_Supplier.SUPPLIER_GENDER = GV<String>(X["T_SUPPLIER_SUPPLIER_GENDER"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Registered_supplier_expense = new Registered_supplier_expense();
o.My_Registered_supplier_expense.REGISTERED_SUPPLIER_EXPENSE_ID = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_REGISTERED_SUPPLIER_EXPENSE_ID"]);o.My_Registered_supplier_expense.REGISTERED_SUPPLIER_EXPENSE_DISCOUNT = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_REGISTERED_SUPPLIER_EXPENSE_DISCOUNT"]);o.My_Registered_supplier_expense.REGISTERED_SUPPLIER_EXPENSE_TOTAL_AMOUNT = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_REGISTERED_SUPPLIER_EXPENSE_TOTAL_AMOUNT"]);o.My_Registered_supplier_expense.REGISTERED_SUPPLIER_EXPENSE_DESCRIPTION = GV<String>(X["T_REGISTERED_SUPPLIER_EXPENSE_REGISTERED_SUPPLIER_EXPENSE_DESCRIPTION"]);o.My_Registered_supplier_expense.SUPPLIER_ID = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_SUPPLIER_ID"]);o.My_Registered_supplier_expense.CURRENCY_ID = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_CURRENCY_ID"]);o.My_Registered_supplier_expense.ENTRY_USER_ID = GV<Int64>(X["T_REGISTERED_SUPPLIER_EXPENSE_ENTRY_USER_ID"]);o.My_Registered_supplier_expense.ENTRY_DATE = GV<String>(X["T_REGISTERED_SUPPLIER_EXPENSE_ENTRY_DATE"]);o.My_Registered_supplier_expense.OWNER_ID = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<User> Get_User_By_Criteria_Adv ( string USERNAME, string PASSWORD, string USER_TYPE_CODE, string USER_EMAIL, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME; p.PASSWORD = PASSWORD; p.USER_TYPE_CODE = USER_TYPE_CODE; p.USER_EMAIL = USER_EMAIL; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_CRITERIA_ADV", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<User> Get_User_By_Where_Adv ( string USERNAME, string PASSWORD, string USER_TYPE_CODE, string USER_EMAIL, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<User> oList = new List<User>();
dynamic p = new ExpandoObject();
p.USERNAME = USERNAME; p.PASSWORD = PASSWORD; p.USER_TYPE_CODE = USER_TYPE_CODE; p.USER_EMAIL = USER_EMAIL; p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_USER_BY_WHERE_ADV", p);
if (R != null) {foreach (var X in R) {
User o = new User();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Criteria_InList ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray()); p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray()); p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray()); p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray()); p.LOC_L4_ID_LIST = string.Join(",", LOC_L4_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Where_InList ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray()); p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray()); p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray()); p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray()); p.LOC_L4_ID_LIST = string.Join(",", LOC_L4_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Criteria_InList_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.VALID_DATE_START = VALID_DATE_START; p.VALID_DATE_END = VALID_DATE_END; p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray()); p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray()); p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray()); p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray()); p.LOC_L4_ID_LIST = string.Join(",", LOC_L4_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_CRITERIA_IN_LIST_V2", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Where_InList_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.VALID_DATE_START = VALID_DATE_START; p.VALID_DATE_END = VALID_DATE_END; p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray()); p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray()); p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray()); p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray()); p.LOC_L4_ID_LIST = string.Join(",", LOC_L4_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_WHERE_IN_LIST_V2", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Client> Get_Client_By_Criteria_InList ( string CLIENT_NAME, string CLIENT_PH_NB, string CLIENT_MAIL, string CLIENT_GENDER, List<Int32?> BLOODTYPE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Client> oList = new List<Client>();
dynamic p = new ExpandoObject();
p.CLIENT_NAME = CLIENT_NAME; p.CLIENT_PH_NB = CLIENT_PH_NB; p.CLIENT_MAIL = CLIENT_MAIL; p.CLIENT_GENDER = CLIENT_GENDER; p.BLOODTYPE_ID_LIST = string.Join(",", BLOODTYPE_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CLIENT_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Client o = new Client();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Client> Get_Client_By_Where_InList ( string CLIENT_NAME, string CLIENT_PH_NB, string CLIENT_MAIL, string CLIENT_GENDER, List<Int32?> BLOODTYPE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Client> oList = new List<Client>();
dynamic p = new ExpandoObject();
p.CLIENT_NAME = CLIENT_NAME; p.CLIENT_PH_NB = CLIENT_PH_NB; p.CLIENT_MAIL = CLIENT_MAIL; p.CLIENT_GENDER = CLIENT_GENDER; p.BLOODTYPE_ID_LIST = string.Join(",", BLOODTYPE_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CLIENT_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Client o = new Client();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Client> Get_Client_By_Criteria_InList_V2 ( string CLIENT_NAME, string CLIENT_PH_NB, string CLIENT_MAIL, string CLIENT_DOB, string CLIENT_GENDER, List<Int32?> BLOODTYPE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Client> oList = new List<Client>();
dynamic p = new ExpandoObject();
p.CLIENT_NAME = CLIENT_NAME; p.CLIENT_PH_NB = CLIENT_PH_NB; p.CLIENT_MAIL = CLIENT_MAIL; p.CLIENT_DOB = CLIENT_DOB; p.CLIENT_GENDER = CLIENT_GENDER; p.BLOODTYPE_ID_LIST = string.Join(",", BLOODTYPE_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CLIENT_BY_CRITERIA_IN_LIST_V2", p);
if (R != null) {foreach (var X in R) {
Client o = new Client();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Client> Get_Client_By_Where_InList_V2 ( string CLIENT_NAME, string CLIENT_PH_NB, string CLIENT_MAIL, string CLIENT_DOB, string CLIENT_GENDER, List<Int32?> BLOODTYPE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Client> oList = new List<Client>();
dynamic p = new ExpandoObject();
p.CLIENT_NAME = CLIENT_NAME; p.CLIENT_PH_NB = CLIENT_PH_NB; p.CLIENT_MAIL = CLIENT_MAIL; p.CLIENT_DOB = CLIENT_DOB; p.CLIENT_GENDER = CLIENT_GENDER; p.BLOODTYPE_ID_LIST = string.Join(",", BLOODTYPE_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CLIENT_BY_WHERE_IN_LIST_V2", p);
if (R != null) {foreach (var X in R) {
Client o = new Client();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Client_fees> Get_Client_fees_By_Criteria_InList ( string CLIENT_FEES_DESCRIPTION, List<Int32?> CLIENT_ID_LIST, List<Int32?> CURRENCY_ID_LIST, List<Int32?> PACKAGE_ID_LIST, List<Int32?> REGISTRATION_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Client_fees> oList = new List<Client_fees>();
dynamic p = new ExpandoObject();
p.CLIENT_FEES_DESCRIPTION = CLIENT_FEES_DESCRIPTION; p.CLIENT_ID_LIST = string.Join(",", CLIENT_ID_LIST.ToArray()); p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.PACKAGE_ID_LIST = string.Join(",", PACKAGE_ID_LIST.ToArray()); p.REGISTRATION_ID_LIST = string.Join(",", REGISTRATION_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CLIENT_FEES_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Client_fees o = new Client_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Client_fees> Get_Client_fees_By_Where_InList ( string CLIENT_FEES_DESCRIPTION, List<Int32?> CLIENT_ID_LIST, List<Int32?> CURRENCY_ID_LIST, List<Int32?> PACKAGE_ID_LIST, List<Int32?> REGISTRATION_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Client_fees> oList = new List<Client_fees>();
dynamic p = new ExpandoObject();
p.CLIENT_FEES_DESCRIPTION = CLIENT_FEES_DESCRIPTION; p.CLIENT_ID_LIST = string.Join(",", CLIENT_ID_LIST.ToArray()); p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.PACKAGE_ID_LIST = string.Join(",", PACKAGE_ID_LIST.ToArray()); p.REGISTRATION_ID_LIST = string.Join(",", REGISTRATION_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CLIENT_FEES_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Client_fees o = new Client_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Contact> Get_Contact_By_Criteria_InList ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, List<long?> PERSON_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.CONTACT_TYPE_CODE = CONTACT_TYPE_CODE; p.CONTACT = CONTACT; p.DESCRIPTION = DESCRIPTION; p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Contact> Get_Contact_By_Where_InList ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, List<long?> PERSON_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.CONTACT_TYPE_CODE = CONTACT_TYPE_CODE; p.CONTACT = CONTACT; p.DESCRIPTION = DESCRIPTION; p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Fees> Get_Fees_By_Criteria_InList ( string FEES_DESCRIPTION, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Fees> oList = new List<Fees>();
dynamic p = new ExpandoObject();
p.FEES_DESCRIPTION = FEES_DESCRIPTION; p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEES_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Fees o = new Fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Fees> Get_Fees_By_Where_InList ( string FEES_DESCRIPTION, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Fees> oList = new List<Fees>();
dynamic p = new ExpandoObject();
p.FEES_DESCRIPTION = FEES_DESCRIPTION; p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEES_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Fees o = new Fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Fees> Get_Fees_By_Criteria_InList_V2 ( string FEES_DESCRIPTION, string FEES_ORIGIN_DATE, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Fees> oList = new List<Fees>();
dynamic p = new ExpandoObject();
p.FEES_DESCRIPTION = FEES_DESCRIPTION; p.FEES_ORIGIN_DATE = FEES_ORIGIN_DATE; p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEES_BY_CRITERIA_IN_LIST_V2", p);
if (R != null) {foreach (var X in R) {
Fees o = new Fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Fees> Get_Fees_By_Where_InList_V2 ( string FEES_DESCRIPTION, string FEES_ORIGIN_DATE, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Fees> oList = new List<Fees>();
dynamic p = new ExpandoObject();
p.FEES_DESCRIPTION = FEES_DESCRIPTION; p.FEES_ORIGIN_DATE = FEES_ORIGIN_DATE; p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEES_BY_WHERE_IN_LIST_V2", p);
if (R != null) {foreach (var X in R) {
Fees o = new Fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Criteria_InList ( string CODE, string DESCRIPTION, List<long?> LOC_L1_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Where_InList ( string CODE, string DESCRIPTION, List<long?> LOC_L1_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Criteria_InList ( string CODE, string DESCRIPTION, List<long?> LOC_L2_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Where_InList ( string CODE, string DESCRIPTION, List<long?> LOC_L2_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Criteria_InList ( string CODE, string DESCRIPTION, List<long?> LOC_L3_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Where_InList ( string CODE, string DESCRIPTION, List<long?> LOC_L3_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Package> Get_Package_By_Criteria_InList ( string PACKAGE_NAME, string PACKAGE_TYPE, string PACKAGE_TIMELINE, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Package> oList = new List<Package>();
dynamic p = new ExpandoObject();
p.PACKAGE_NAME = PACKAGE_NAME; p.PACKAGE_TYPE = PACKAGE_TYPE; p.PACKAGE_TIMELINE = PACKAGE_TIMELINE; p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PACKAGE_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Package o = new Package();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Package> Get_Package_By_Where_InList ( string PACKAGE_NAME, string PACKAGE_TYPE, string PACKAGE_TIMELINE, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Package> oList = new List<Package>();
dynamic p = new ExpandoObject();
p.PACKAGE_NAME = PACKAGE_NAME; p.PACKAGE_TYPE = PACKAGE_TYPE; p.PACKAGE_TIMELINE = PACKAGE_TIMELINE; p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PACKAGE_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Package o = new Package();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Package> Get_Package_By_Criteria_InList_V2 ( string PACKAGE_NAME, string PACKAGE_TYPE, string PACKAGE_ENDING_DATE, string PACKAGE_TIMELINE, string PACKAGE_STARTING_DATE, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Package> oList = new List<Package>();
dynamic p = new ExpandoObject();
p.PACKAGE_NAME = PACKAGE_NAME; p.PACKAGE_TYPE = PACKAGE_TYPE; p.PACKAGE_ENDING_DATE = PACKAGE_ENDING_DATE; p.PACKAGE_TIMELINE = PACKAGE_TIMELINE; p.PACKAGE_STARTING_DATE = PACKAGE_STARTING_DATE; p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PACKAGE_BY_CRITERIA_IN_LIST_V2", p);
if (R != null) {foreach (var X in R) {
Package o = new Package();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Package> Get_Package_By_Where_InList_V2 ( string PACKAGE_NAME, string PACKAGE_TYPE, string PACKAGE_ENDING_DATE, string PACKAGE_TIMELINE, string PACKAGE_STARTING_DATE, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Package> oList = new List<Package>();
dynamic p = new ExpandoObject();
p.PACKAGE_NAME = PACKAGE_NAME; p.PACKAGE_TYPE = PACKAGE_TYPE; p.PACKAGE_ENDING_DATE = PACKAGE_ENDING_DATE; p.PACKAGE_TIMELINE = PACKAGE_TIMELINE; p.PACKAGE_STARTING_DATE = PACKAGE_STARTING_DATE; p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PACKAGE_BY_WHERE_IN_LIST_V2", p);
if (R != null) {foreach (var X in R) {
Package o = new Package();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Registration> Get_Registration_By_Criteria_InList ( string REGISTRATION_DESCRIPTION, List<Int32?> CLIENT_ID_LIST, List<Int32?> PACKAGE_ID_LIST, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Registration> oList = new List<Registration>();
dynamic p = new ExpandoObject();
p.REGISTRATION_DESCRIPTION = REGISTRATION_DESCRIPTION; p.CLIENT_ID_LIST = string.Join(",", CLIENT_ID_LIST.ToArray()); p.PACKAGE_ID_LIST = string.Join(",", PACKAGE_ID_LIST.ToArray()); p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_REGISTRATION_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Registration o = new Registration();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Registration> Get_Registration_By_Where_InList ( string REGISTRATION_DESCRIPTION, List<Int32?> CLIENT_ID_LIST, List<Int32?> PACKAGE_ID_LIST, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Registration> oList = new List<Registration>();
dynamic p = new ExpandoObject();
p.REGISTRATION_DESCRIPTION = REGISTRATION_DESCRIPTION; p.CLIENT_ID_LIST = string.Join(",", CLIENT_ID_LIST.ToArray()); p.PACKAGE_ID_LIST = string.Join(",", PACKAGE_ID_LIST.ToArray()); p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_REGISTRATION_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Registration o = new Registration();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Registration> Get_Registration_By_Criteria_InList_V2 ( string REGISTRATION_DATE, string REGISTRATION_DESCRIPTION, List<Int32?> CLIENT_ID_LIST, List<Int32?> PACKAGE_ID_LIST, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Registration> oList = new List<Registration>();
dynamic p = new ExpandoObject();
p.REGISTRATION_DATE = REGISTRATION_DATE; p.REGISTRATION_DESCRIPTION = REGISTRATION_DESCRIPTION; p.CLIENT_ID_LIST = string.Join(",", CLIENT_ID_LIST.ToArray()); p.PACKAGE_ID_LIST = string.Join(",", PACKAGE_ID_LIST.ToArray()); p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_REGISTRATION_BY_CRITERIA_IN_LIST_V2", p);
if (R != null) {foreach (var X in R) {
Registration o = new Registration();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Registration> Get_Registration_By_Where_InList_V2 ( string REGISTRATION_DATE, string REGISTRATION_DESCRIPTION, List<Int32?> CLIENT_ID_LIST, List<Int32?> PACKAGE_ID_LIST, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Registration> oList = new List<Registration>();
dynamic p = new ExpandoObject();
p.REGISTRATION_DATE = REGISTRATION_DATE; p.REGISTRATION_DESCRIPTION = REGISTRATION_DESCRIPTION; p.CLIENT_ID_LIST = string.Join(",", CLIENT_ID_LIST.ToArray()); p.PACKAGE_ID_LIST = string.Join(",", PACKAGE_ID_LIST.ToArray()); p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_REGISTRATION_BY_WHERE_IN_LIST_V2", p);
if (R != null) {foreach (var X in R) {
Registration o = new Registration();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Session> Get_Session_By_Criteria_InList ( string DESCRIPTION, List<Int32?> PACKAGE_ID_LIST, List<Int32?> CLIENT_FEES_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Session> oList = new List<Session>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.PACKAGE_ID_LIST = string.Join(",", PACKAGE_ID_LIST.ToArray()); p.CLIENT_FEES_ID_LIST = string.Join(",", CLIENT_FEES_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SESSION_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Session o = new Session();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Session> Get_Session_By_Where_InList ( string DESCRIPTION, List<Int32?> PACKAGE_ID_LIST, List<Int32?> CLIENT_FEES_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Session> oList = new List<Session>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.PACKAGE_ID_LIST = string.Join(",", PACKAGE_ID_LIST.ToArray()); p.CLIENT_FEES_ID_LIST = string.Join(",", CLIENT_FEES_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SESSION_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Session o = new Session();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Session> Get_Session_By_Criteria_InList_V2 ( string SESSION_STARTING_DATE, string SESSION_ENDING_DATE, string DESCRIPTION, List<Int32?> PACKAGE_ID_LIST, List<Int32?> CLIENT_FEES_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Session> oList = new List<Session>();
dynamic p = new ExpandoObject();
p.SESSION_STARTING_DATE = SESSION_STARTING_DATE; p.SESSION_ENDING_DATE = SESSION_ENDING_DATE; p.DESCRIPTION = DESCRIPTION; p.PACKAGE_ID_LIST = string.Join(",", PACKAGE_ID_LIST.ToArray()); p.CLIENT_FEES_ID_LIST = string.Join(",", CLIENT_FEES_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SESSION_BY_CRITERIA_IN_LIST_V2", p);
if (R != null) {foreach (var X in R) {
Session o = new Session();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Session> Get_Session_By_Where_InList_V2 ( string SESSION_STARTING_DATE, string SESSION_ENDING_DATE, string DESCRIPTION, List<Int32?> PACKAGE_ID_LIST, List<Int32?> CLIENT_FEES_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Session> oList = new List<Session>();
dynamic p = new ExpandoObject();
p.SESSION_STARTING_DATE = SESSION_STARTING_DATE; p.SESSION_ENDING_DATE = SESSION_ENDING_DATE; p.DESCRIPTION = DESCRIPTION; p.PACKAGE_ID_LIST = string.Join(",", PACKAGE_ID_LIST.ToArray()); p.CLIENT_FEES_ID_LIST = string.Join(",", CLIENT_FEES_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SESSION_BY_WHERE_IN_LIST_V2", p);
if (R != null) {foreach (var X in R) {
Session o = new Session();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Staff> Get_Staff_By_Criteria_InList ( string STAFF_NAME, string STAFF_PH_NB, string STAFF_MAIL, string STAFF_GENDER, List<Int32?> BLOODTYPE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Staff> oList = new List<Staff>();
dynamic p = new ExpandoObject();
p.STAFF_NAME = STAFF_NAME; p.STAFF_PH_NB = STAFF_PH_NB; p.STAFF_MAIL = STAFF_MAIL; p.STAFF_GENDER = STAFF_GENDER; p.BLOODTYPE_ID_LIST = string.Join(",", BLOODTYPE_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Staff o = new Staff();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Staff> Get_Staff_By_Where_InList ( string STAFF_NAME, string STAFF_PH_NB, string STAFF_MAIL, string STAFF_GENDER, List<Int32?> BLOODTYPE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Staff> oList = new List<Staff>();
dynamic p = new ExpandoObject();
p.STAFF_NAME = STAFF_NAME; p.STAFF_PH_NB = STAFF_PH_NB; p.STAFF_MAIL = STAFF_MAIL; p.STAFF_GENDER = STAFF_GENDER; p.BLOODTYPE_ID_LIST = string.Join(",", BLOODTYPE_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Staff o = new Staff();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Staff> Get_Staff_By_Criteria_InList_V2 ( string STAFF_NAME, string STAFF_PH_NB, string STAFF_MAIL, string STAFF_DOB, string STAFF_GENDER, List<Int32?> BLOODTYPE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Staff> oList = new List<Staff>();
dynamic p = new ExpandoObject();
p.STAFF_NAME = STAFF_NAME; p.STAFF_PH_NB = STAFF_PH_NB; p.STAFF_MAIL = STAFF_MAIL; p.STAFF_DOB = STAFF_DOB; p.STAFF_GENDER = STAFF_GENDER; p.BLOODTYPE_ID_LIST = string.Join(",", BLOODTYPE_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_BY_CRITERIA_IN_LIST_V2", p);
if (R != null) {foreach (var X in R) {
Staff o = new Staff();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Staff> Get_Staff_By_Where_InList_V2 ( string STAFF_NAME, string STAFF_PH_NB, string STAFF_MAIL, string STAFF_DOB, string STAFF_GENDER, List<Int32?> BLOODTYPE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Staff> oList = new List<Staff>();
dynamic p = new ExpandoObject();
p.STAFF_NAME = STAFF_NAME; p.STAFF_PH_NB = STAFF_PH_NB; p.STAFF_MAIL = STAFF_MAIL; p.STAFF_DOB = STAFF_DOB; p.STAFF_GENDER = STAFF_GENDER; p.BLOODTYPE_ID_LIST = string.Join(",", BLOODTYPE_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_BY_WHERE_IN_LIST_V2", p);
if (R != null) {foreach (var X in R) {
Staff o = new Staff();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Staff_fees> Get_Staff_fees_By_Criteria_InList ( string STAFF_FEES_DESCRIPTION, List<Int32?> STAFF_ID_LIST, List<Int32?> CURRENCY_ID_LIST, List<Int32?> REGISTERED_STAFF_EXPENSE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Staff_fees> oList = new List<Staff_fees>();
dynamic p = new ExpandoObject();
p.STAFF_FEES_DESCRIPTION = STAFF_FEES_DESCRIPTION; p.STAFF_ID_LIST = string.Join(",", STAFF_ID_LIST.ToArray()); p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.REGISTERED_STAFF_EXPENSE_ID_LIST = string.Join(",", REGISTERED_STAFF_EXPENSE_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_FEES_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Staff_fees o = new Staff_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Staff_fees> Get_Staff_fees_By_Where_InList ( string STAFF_FEES_DESCRIPTION, List<Int32?> STAFF_ID_LIST, List<Int32?> CURRENCY_ID_LIST, List<Int32?> REGISTERED_STAFF_EXPENSE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Staff_fees> oList = new List<Staff_fees>();
dynamic p = new ExpandoObject();
p.STAFF_FEES_DESCRIPTION = STAFF_FEES_DESCRIPTION; p.STAFF_ID_LIST = string.Join(",", STAFF_ID_LIST.ToArray()); p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.REGISTERED_STAFF_EXPENSE_ID_LIST = string.Join(",", REGISTERED_STAFF_EXPENSE_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_FEES_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Staff_fees o = new Staff_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Supplier> Get_Supplier_By_Criteria_InList ( string SUPPLIER_NAME, string SUPPLIER_PH_NB, string SUPPLIER_MAIL, string SUPPLIER_GENDER, List<Int32?> BLOODTYPE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Supplier> oList = new List<Supplier>();
dynamic p = new ExpandoObject();
p.SUPPLIER_NAME = SUPPLIER_NAME; p.SUPPLIER_PH_NB = SUPPLIER_PH_NB; p.SUPPLIER_MAIL = SUPPLIER_MAIL; p.SUPPLIER_GENDER = SUPPLIER_GENDER; p.BLOODTYPE_ID_LIST = string.Join(",", BLOODTYPE_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Supplier o = new Supplier();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Supplier> Get_Supplier_By_Where_InList ( string SUPPLIER_NAME, string SUPPLIER_PH_NB, string SUPPLIER_MAIL, string SUPPLIER_GENDER, List<Int32?> BLOODTYPE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Supplier> oList = new List<Supplier>();
dynamic p = new ExpandoObject();
p.SUPPLIER_NAME = SUPPLIER_NAME; p.SUPPLIER_PH_NB = SUPPLIER_PH_NB; p.SUPPLIER_MAIL = SUPPLIER_MAIL; p.SUPPLIER_GENDER = SUPPLIER_GENDER; p.BLOODTYPE_ID_LIST = string.Join(",", BLOODTYPE_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Supplier o = new Supplier();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Supplier> Get_Supplier_By_Criteria_InList_V2 ( string SUPPLIER_NAME, string SUPPLIER_PH_NB, string SUPPLIER_MAIL, string SUPPLIER_DOB, string SUPPLIER_GENDER, List<Int32?> BLOODTYPE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Supplier> oList = new List<Supplier>();
dynamic p = new ExpandoObject();
p.SUPPLIER_NAME = SUPPLIER_NAME; p.SUPPLIER_PH_NB = SUPPLIER_PH_NB; p.SUPPLIER_MAIL = SUPPLIER_MAIL; p.SUPPLIER_DOB = SUPPLIER_DOB; p.SUPPLIER_GENDER = SUPPLIER_GENDER; p.BLOODTYPE_ID_LIST = string.Join(",", BLOODTYPE_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_BY_CRITERIA_IN_LIST_V2", p);
if (R != null) {foreach (var X in R) {
Supplier o = new Supplier();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Supplier> Get_Supplier_By_Where_InList_V2 ( string SUPPLIER_NAME, string SUPPLIER_PH_NB, string SUPPLIER_MAIL, string SUPPLIER_DOB, string SUPPLIER_GENDER, List<Int32?> BLOODTYPE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Supplier> oList = new List<Supplier>();
dynamic p = new ExpandoObject();
p.SUPPLIER_NAME = SUPPLIER_NAME; p.SUPPLIER_PH_NB = SUPPLIER_PH_NB; p.SUPPLIER_MAIL = SUPPLIER_MAIL; p.SUPPLIER_DOB = SUPPLIER_DOB; p.SUPPLIER_GENDER = SUPPLIER_GENDER; p.BLOODTYPE_ID_LIST = string.Join(",", BLOODTYPE_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_BY_WHERE_IN_LIST_V2", p);
if (R != null) {foreach (var X in R) {
Supplier o = new Supplier();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Supplier_fees> Get_Supplier_fees_By_Criteria_InList ( string SUPPLIER_FEES_DESCRIPTION, List<Int32?> SUPPLIER_ID_LIST, List<Int32?> CURRENCY_ID_LIST, List<Int32?> REGISTERED_SUPPLIER_EXPENSE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Supplier_fees> oList = new List<Supplier_fees>();
dynamic p = new ExpandoObject();
p.SUPPLIER_FEES_DESCRIPTION = SUPPLIER_FEES_DESCRIPTION; p.SUPPLIER_ID_LIST = string.Join(",", SUPPLIER_ID_LIST.ToArray()); p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.REGISTERED_SUPPLIER_EXPENSE_ID_LIST = string.Join(",", REGISTERED_SUPPLIER_EXPENSE_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_FEES_BY_CRITERIA_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Supplier_fees o = new Supplier_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Supplier_fees> Get_Supplier_fees_By_Where_InList ( string SUPPLIER_FEES_DESCRIPTION, List<Int32?> SUPPLIER_ID_LIST, List<Int32?> CURRENCY_ID_LIST, List<Int32?> REGISTERED_SUPPLIER_EXPENSE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Supplier_fees> oList = new List<Supplier_fees>();
dynamic p = new ExpandoObject();
p.SUPPLIER_FEES_DESCRIPTION = SUPPLIER_FEES_DESCRIPTION; p.SUPPLIER_ID_LIST = string.Join(",", SUPPLIER_ID_LIST.ToArray()); p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.REGISTERED_SUPPLIER_EXPENSE_ID_LIST = string.Join(",", REGISTERED_SUPPLIER_EXPENSE_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_FEES_BY_WHERE_IN_LIST", p);
if (R != null) {foreach (var X in R) {
Supplier_fees o = new Supplier_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Criteria_InList_Adv ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray()); p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray()); p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray()); p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray()); p.LOC_L4_ID_LIST = string.Join(",", LOC_L4_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Where_InList_Adv ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray()); p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray()); p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray()); p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray()); p.LOC_L4_ID_LIST = string.Join(",", LOC_L4_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
o.My_Loc_l4 = new Loc_l4();
o.My_Loc_l4.LOC_L4_ID = GV<Int64>(X["T_LOC_L4_LOC_L4_ID"]);o.My_Loc_l4.CODE = GV<String>(X["T_LOC_L4_CODE"]);o.My_Loc_l4.DESCRIPTION = GV<String>(X["T_LOC_L4_DESCRIPTION"]);o.My_Loc_l4.LOC_L3_ID = GV<Int64>(X["T_LOC_L4_LOC_L3_ID"]);o.My_Loc_l4.NOTES = GV<String>(X["T_LOC_L4_NOTES"]);o.My_Loc_l4.ENTRY_DATE = GV<String>(X["T_LOC_L4_ENTRY_DATE"]);o.My_Loc_l4.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L4_ENTRY_USER_ID"]);o.My_Loc_l4.OWNER_ID = GV<Int32>(X["T_LOC_L4_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Criteria_InList_Adv_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.VALID_DATE_START = VALID_DATE_START; p.VALID_DATE_END = VALID_DATE_END; p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray()); p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray()); p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray()); p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray()); p.LOC_L4_ID_LIST = string.Join(",", LOC_L4_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_CRITERIA_IN_LIST_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Address> Get_Address_By_Where_InList_Adv_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Address> oList = new List<Address>();
dynamic p = new ExpandoObject();
p.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE; p.STREET = STREET; p.BUILDING = BUILDING; p.FLOOR = FLOOR; p.POBOX = POBOX; p.VALID_DATE_START = VALID_DATE_START; p.VALID_DATE_END = VALID_DATE_END; p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray()); p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray()); p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray()); p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray()); p.LOC_L4_ID_LIST = string.Join(",", LOC_L4_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_ADDRESS_BY_WHERE_IN_LIST_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Address o = new Address();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Client> Get_Client_By_Criteria_InList_Adv ( string CLIENT_NAME, string CLIENT_PH_NB, string CLIENT_MAIL, string CLIENT_GENDER, List<Int32?> BLOODTYPE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Client> oList = new List<Client>();
dynamic p = new ExpandoObject();
p.CLIENT_NAME = CLIENT_NAME; p.CLIENT_PH_NB = CLIENT_PH_NB; p.CLIENT_MAIL = CLIENT_MAIL; p.CLIENT_GENDER = CLIENT_GENDER; p.BLOODTYPE_ID_LIST = string.Join(",", BLOODTYPE_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CLIENT_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Client o = new Client();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Bloodtype = new Bloodtype();
o.My_Bloodtype.BLOODTYPE_ID = GV<Int32>(X["T_BLOODTYPE_BLOODTYPE_ID"]);o.My_Bloodtype.BLOODTYPE_SYMBOL = GV<String>(X["T_BLOODTYPE_BLOODTYPE_SYMBOL"]);o.My_Bloodtype.ENTRY_USER_ID = GV<Int64>(X["T_BLOODTYPE_ENTRY_USER_ID"]);o.My_Bloodtype.ENTRY_DATE = GV<String>(X["T_BLOODTYPE_ENTRY_DATE"]);o.My_Bloodtype.OWNER_ID = GV<Int32>(X["T_BLOODTYPE_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Client> Get_Client_By_Where_InList_Adv ( string CLIENT_NAME, string CLIENT_PH_NB, string CLIENT_MAIL, string CLIENT_GENDER, List<Int32?> BLOODTYPE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Client> oList = new List<Client>();
dynamic p = new ExpandoObject();
p.CLIENT_NAME = CLIENT_NAME; p.CLIENT_PH_NB = CLIENT_PH_NB; p.CLIENT_MAIL = CLIENT_MAIL; p.CLIENT_GENDER = CLIENT_GENDER; p.BLOODTYPE_ID_LIST = string.Join(",", BLOODTYPE_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CLIENT_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Client o = new Client();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Bloodtype = new Bloodtype();
o.My_Bloodtype.BLOODTYPE_ID = GV<Int32>(X["T_BLOODTYPE_BLOODTYPE_ID"]);o.My_Bloodtype.BLOODTYPE_SYMBOL = GV<String>(X["T_BLOODTYPE_BLOODTYPE_SYMBOL"]);o.My_Bloodtype.ENTRY_USER_ID = GV<Int64>(X["T_BLOODTYPE_ENTRY_USER_ID"]);o.My_Bloodtype.ENTRY_DATE = GV<String>(X["T_BLOODTYPE_ENTRY_DATE"]);o.My_Bloodtype.OWNER_ID = GV<Int32>(X["T_BLOODTYPE_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Client> Get_Client_By_Criteria_InList_Adv_V2 ( string CLIENT_NAME, string CLIENT_PH_NB, string CLIENT_MAIL, string CLIENT_DOB, string CLIENT_GENDER, List<Int32?> BLOODTYPE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Client> oList = new List<Client>();
dynamic p = new ExpandoObject();
p.CLIENT_NAME = CLIENT_NAME; p.CLIENT_PH_NB = CLIENT_PH_NB; p.CLIENT_MAIL = CLIENT_MAIL; p.CLIENT_DOB = CLIENT_DOB; p.CLIENT_GENDER = CLIENT_GENDER; p.BLOODTYPE_ID_LIST = string.Join(",", BLOODTYPE_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CLIENT_BY_CRITERIA_IN_LIST_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Client o = new Client();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Client> Get_Client_By_Where_InList_Adv_V2 ( string CLIENT_NAME, string CLIENT_PH_NB, string CLIENT_MAIL, string CLIENT_DOB, string CLIENT_GENDER, List<Int32?> BLOODTYPE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Client> oList = new List<Client>();
dynamic p = new ExpandoObject();
p.CLIENT_NAME = CLIENT_NAME; p.CLIENT_PH_NB = CLIENT_PH_NB; p.CLIENT_MAIL = CLIENT_MAIL; p.CLIENT_DOB = CLIENT_DOB; p.CLIENT_GENDER = CLIENT_GENDER; p.BLOODTYPE_ID_LIST = string.Join(",", BLOODTYPE_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CLIENT_BY_WHERE_IN_LIST_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Client o = new Client();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Client_fees> Get_Client_fees_By_Criteria_InList_Adv ( string CLIENT_FEES_DESCRIPTION, List<Int32?> CLIENT_ID_LIST, List<Int32?> CURRENCY_ID_LIST, List<Int32?> PACKAGE_ID_LIST, List<Int32?> REGISTRATION_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Client_fees> oList = new List<Client_fees>();
dynamic p = new ExpandoObject();
p.CLIENT_FEES_DESCRIPTION = CLIENT_FEES_DESCRIPTION; p.CLIENT_ID_LIST = string.Join(",", CLIENT_ID_LIST.ToArray()); p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.PACKAGE_ID_LIST = string.Join(",", PACKAGE_ID_LIST.ToArray()); p.REGISTRATION_ID_LIST = string.Join(",", REGISTRATION_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CLIENT_FEES_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Client_fees o = new Client_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Client = new Client();
o.My_Client.CLIENT_ID = GV<Int32>(X["T_CLIENT_CLIENT_ID"]);o.My_Client.CLIENT_NAME = GV<String>(X["T_CLIENT_CLIENT_NAME"]);o.My_Client.CLIENT_PH_NB = GV<String>(X["T_CLIENT_CLIENT_PH_NB"]);o.My_Client.CLIENT_MAIL = GV<String>(X["T_CLIENT_CLIENT_MAIL"]);o.My_Client.CLIENT_DOB = GV<String>(X["T_CLIENT_CLIENT_DOB"]);o.My_Client.BLOODTYPE_ID = GV<Int32>(X["T_CLIENT_BLOODTYPE_ID"]);o.My_Client.ENTRY_USER_ID = GV<Int64>(X["T_CLIENT_ENTRY_USER_ID"]);o.My_Client.ENTRY_DATE = GV<String>(X["T_CLIENT_ENTRY_DATE"]);o.My_Client.OWNER_ID = GV<Int32>(X["T_CLIENT_OWNER_ID"]);o.My_Client.CLIENT_GENDER = GV<String>(X["T_CLIENT_CLIENT_GENDER"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Package = new Package();
o.My_Package.PACKAGE_ID = GV<Int32>(X["T_PACKAGE_PACKAGE_ID"]);o.My_Package.PACKAGE_NAME = GV<String>(X["T_PACKAGE_PACKAGE_NAME"]);o.My_Package.PACKAGE_PRICE = GV<Int32>(X["T_PACKAGE_PACKAGE_PRICE"]);o.My_Package.CURRENCY_ID = GV<Int32>(X["T_PACKAGE_CURRENCY_ID"]);o.My_Package.ENTRY_USER_ID = GV<Int64>(X["T_PACKAGE_ENTRY_USER_ID"]);o.My_Package.ENTRY_DATE = GV<String>(X["T_PACKAGE_ENTRY_DATE"]);o.My_Package.OWNER_ID = GV<Int32>(X["T_PACKAGE_OWNER_ID"]);o.My_Package.PACKAGE_SESSIONS_NB = GV<Int32>(X["T_PACKAGE_PACKAGE_SESSIONS_NB"]);o.My_Package.PACKAGE_TYPE = GV<String>(X["T_PACKAGE_PACKAGE_TYPE"]);o.My_Package.PACKAGE_ENDING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_ENDING_DATE"]);o.My_Package.PACKAGE_TIMELINE = GV<String>(X["T_PACKAGE_PACKAGE_TIMELINE"]);o.My_Package.PACKAGE_STARTING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_STARTING_DATE"]);o.My_Package.PACKAGE_NB_OF_MONTH = GV<Int32>(X["T_PACKAGE_PACKAGE_NB_OF_MONTH"]);
o.My_Registration = new Registration();
o.My_Registration.REGISTRATION_ID = GV<Int32>(X["T_REGISTRATION_REGISTRATION_ID"]);o.My_Registration.CLIENT_ID = GV<Int32>(X["T_REGISTRATION_CLIENT_ID"]);o.My_Registration.REGISTRATION_DATE = GV<String>(X["T_REGISTRATION_REGISTRATION_DATE"]);o.My_Registration.PACKAGE_ID = GV<Int32>(X["T_REGISTRATION_PACKAGE_ID"]);o.My_Registration.REGISTRATION_DISCOUNT = GV<Int32>(X["T_REGISTRATION_REGISTRATION_DISCOUNT"]);o.My_Registration.REGISTRATION_TOTAL_PRICE = GV<Int32>(X["T_REGISTRATION_REGISTRATION_TOTAL_PRICE"]);o.My_Registration.CURRENCY_ID = GV<Int32>(X["T_REGISTRATION_CURRENCY_ID"]);o.My_Registration.REGISTRATION_DESCRIPTION = GV<String>(X["T_REGISTRATION_REGISTRATION_DESCRIPTION"]);o.My_Registration.ENTRY_USER_ID = GV<Int64>(X["T_REGISTRATION_ENTRY_USER_ID"]);o.My_Registration.ENTRY_DATE = GV<String>(X["T_REGISTRATION_ENTRY_DATE"]);o.My_Registration.OWNER_ID = GV<Int32>(X["T_REGISTRATION_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Client_fees> Get_Client_fees_By_Where_InList_Adv ( string CLIENT_FEES_DESCRIPTION, List<Int32?> CLIENT_ID_LIST, List<Int32?> CURRENCY_ID_LIST, List<Int32?> PACKAGE_ID_LIST, List<Int32?> REGISTRATION_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Client_fees> oList = new List<Client_fees>();
dynamic p = new ExpandoObject();
p.CLIENT_FEES_DESCRIPTION = CLIENT_FEES_DESCRIPTION; p.CLIENT_ID_LIST = string.Join(",", CLIENT_ID_LIST.ToArray()); p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.PACKAGE_ID_LIST = string.Join(",", PACKAGE_ID_LIST.ToArray()); p.REGISTRATION_ID_LIST = string.Join(",", REGISTRATION_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CLIENT_FEES_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Client_fees o = new Client_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Client = new Client();
o.My_Client.CLIENT_ID = GV<Int32>(X["T_CLIENT_CLIENT_ID"]);o.My_Client.CLIENT_NAME = GV<String>(X["T_CLIENT_CLIENT_NAME"]);o.My_Client.CLIENT_PH_NB = GV<String>(X["T_CLIENT_CLIENT_PH_NB"]);o.My_Client.CLIENT_MAIL = GV<String>(X["T_CLIENT_CLIENT_MAIL"]);o.My_Client.CLIENT_DOB = GV<String>(X["T_CLIENT_CLIENT_DOB"]);o.My_Client.BLOODTYPE_ID = GV<Int32>(X["T_CLIENT_BLOODTYPE_ID"]);o.My_Client.ENTRY_USER_ID = GV<Int64>(X["T_CLIENT_ENTRY_USER_ID"]);o.My_Client.ENTRY_DATE = GV<String>(X["T_CLIENT_ENTRY_DATE"]);o.My_Client.OWNER_ID = GV<Int32>(X["T_CLIENT_OWNER_ID"]);o.My_Client.CLIENT_GENDER = GV<String>(X["T_CLIENT_CLIENT_GENDER"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Package = new Package();
o.My_Package.PACKAGE_ID = GV<Int32>(X["T_PACKAGE_PACKAGE_ID"]);o.My_Package.PACKAGE_NAME = GV<String>(X["T_PACKAGE_PACKAGE_NAME"]);o.My_Package.PACKAGE_PRICE = GV<Int32>(X["T_PACKAGE_PACKAGE_PRICE"]);o.My_Package.CURRENCY_ID = GV<Int32>(X["T_PACKAGE_CURRENCY_ID"]);o.My_Package.ENTRY_USER_ID = GV<Int64>(X["T_PACKAGE_ENTRY_USER_ID"]);o.My_Package.ENTRY_DATE = GV<String>(X["T_PACKAGE_ENTRY_DATE"]);o.My_Package.OWNER_ID = GV<Int32>(X["T_PACKAGE_OWNER_ID"]);o.My_Package.PACKAGE_SESSIONS_NB = GV<Int32>(X["T_PACKAGE_PACKAGE_SESSIONS_NB"]);o.My_Package.PACKAGE_TYPE = GV<String>(X["T_PACKAGE_PACKAGE_TYPE"]);o.My_Package.PACKAGE_ENDING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_ENDING_DATE"]);o.My_Package.PACKAGE_TIMELINE = GV<String>(X["T_PACKAGE_PACKAGE_TIMELINE"]);o.My_Package.PACKAGE_STARTING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_STARTING_DATE"]);o.My_Package.PACKAGE_NB_OF_MONTH = GV<Int32>(X["T_PACKAGE_PACKAGE_NB_OF_MONTH"]);
o.My_Registration = new Registration();
o.My_Registration.REGISTRATION_ID = GV<Int32>(X["T_REGISTRATION_REGISTRATION_ID"]);o.My_Registration.CLIENT_ID = GV<Int32>(X["T_REGISTRATION_CLIENT_ID"]);o.My_Registration.REGISTRATION_DATE = GV<String>(X["T_REGISTRATION_REGISTRATION_DATE"]);o.My_Registration.PACKAGE_ID = GV<Int32>(X["T_REGISTRATION_PACKAGE_ID"]);o.My_Registration.REGISTRATION_DISCOUNT = GV<Int32>(X["T_REGISTRATION_REGISTRATION_DISCOUNT"]);o.My_Registration.REGISTRATION_TOTAL_PRICE = GV<Int32>(X["T_REGISTRATION_REGISTRATION_TOTAL_PRICE"]);o.My_Registration.CURRENCY_ID = GV<Int32>(X["T_REGISTRATION_CURRENCY_ID"]);o.My_Registration.REGISTRATION_DESCRIPTION = GV<String>(X["T_REGISTRATION_REGISTRATION_DESCRIPTION"]);o.My_Registration.ENTRY_USER_ID = GV<Int64>(X["T_REGISTRATION_ENTRY_USER_ID"]);o.My_Registration.ENTRY_DATE = GV<String>(X["T_REGISTRATION_ENTRY_DATE"]);o.My_Registration.OWNER_ID = GV<Int32>(X["T_REGISTRATION_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Contact> Get_Contact_By_Criteria_InList_Adv ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, List<long?> PERSON_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.CONTACT_TYPE_CODE = CONTACT_TYPE_CODE; p.CONTACT = CONTACT; p.DESCRIPTION = DESCRIPTION; p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Contact> Get_Contact_By_Where_InList_Adv ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, List<long?> PERSON_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Contact> oList = new List<Contact>();
dynamic p = new ExpandoObject();
p.CONTACT_TYPE_CODE = CONTACT_TYPE_CODE; p.CONTACT = CONTACT; p.DESCRIPTION = DESCRIPTION; p.PERSON_ID_LIST = string.Join(",", PERSON_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_CONTACT_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Contact o = new Contact();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Person = new Person();
o.My_Person.PERSON_ID = GV<Int64>(X["T_PERSON_PERSON_ID"]);o.My_Person.FIRST_NAME = GV<String>(X["T_PERSON_FIRST_NAME"]);o.My_Person.LAST_NAME = GV<String>(X["T_PERSON_LAST_NAME"]);o.My_Person.FATHER_NAME = GV<String>(X["T_PERSON_FATHER_NAME"]);o.My_Person.MOTHER_NAME = GV<String>(X["T_PERSON_MOTHER_NAME"]);o.My_Person.TITLE_CODE = GV<String>(X["T_PERSON_TITLE_CODE"]);o.My_Person.GENDER_CODE = GV<String>(X["T_PERSON_GENDER_CODE"]);o.My_Person.RELIGION_CODE = GV<String>(X["T_PERSON_RELIGION_CODE"]);o.My_Person.BIRTH_DATE = GV<String>(X["T_PERSON_BIRTH_DATE"]);o.My_Person.IS_BLOCKED = GV<Boolean>(X["T_PERSON_IS_BLOCKED"]);o.My_Person.DESCRIPTION = GV<String>(X["T_PERSON_DESCRIPTION"]);o.My_Person.OWNER_ID = GV<Int32>(X["T_PERSON_OWNER_ID"]);o.My_Person.ENTRY_USER_ID = GV<Int64>(X["T_PERSON_ENTRY_USER_ID"]);o.My_Person.ENTRY_DATE = GV<String>(X["T_PERSON_ENTRY_DATE"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Fees> Get_Fees_By_Criteria_InList_Adv ( string FEES_DESCRIPTION, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Fees> oList = new List<Fees>();
dynamic p = new ExpandoObject();
p.FEES_DESCRIPTION = FEES_DESCRIPTION; p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEES_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Fees o = new Fees();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Fees> Get_Fees_By_Where_InList_Adv ( string FEES_DESCRIPTION, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Fees> oList = new List<Fees>();
dynamic p = new ExpandoObject();
p.FEES_DESCRIPTION = FEES_DESCRIPTION; p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEES_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Fees o = new Fees();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Fees> Get_Fees_By_Criteria_InList_Adv_V2 ( string FEES_DESCRIPTION, string FEES_ORIGIN_DATE, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Fees> oList = new List<Fees>();
dynamic p = new ExpandoObject();
p.FEES_DESCRIPTION = FEES_DESCRIPTION; p.FEES_ORIGIN_DATE = FEES_ORIGIN_DATE; p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEES_BY_CRITERIA_IN_LIST_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Fees o = new Fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Fees> Get_Fees_By_Where_InList_Adv_V2 ( string FEES_DESCRIPTION, string FEES_ORIGIN_DATE, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Fees> oList = new List<Fees>();
dynamic p = new ExpandoObject();
p.FEES_DESCRIPTION = FEES_DESCRIPTION; p.FEES_ORIGIN_DATE = FEES_ORIGIN_DATE; p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_FEES_BY_WHERE_IN_LIST_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Fees o = new Fees();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Criteria_InList_Adv ( string CODE, string DESCRIPTION, List<long?> LOC_L1_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l2> Get_Loc_l2_By_Where_InList_Adv ( string CODE, string DESCRIPTION, List<long?> LOC_L1_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l2> oList = new List<Loc_l2>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.LOC_L1_ID_LIST = string.Join(",", LOC_L1_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L2_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l2 o = new Loc_l2();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l1 = new Loc_l1();
o.My_Loc_l1.LOC_L1_ID = GV<Int64>(X["T_LOC_L1_LOC_L1_ID"]);o.My_Loc_l1.CODE = GV<String>(X["T_LOC_L1_CODE"]);o.My_Loc_l1.DESCRIPTION = GV<String>(X["T_LOC_L1_DESCRIPTION"]);o.My_Loc_l1.NOTES = GV<String>(X["T_LOC_L1_NOTES"]);o.My_Loc_l1.ENTRY_DATE = GV<String>(X["T_LOC_L1_ENTRY_DATE"]);o.My_Loc_l1.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L1_ENTRY_USER_ID"]);o.My_Loc_l1.OWNER_ID = GV<Int32>(X["T_LOC_L1_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Criteria_InList_Adv ( string CODE, string DESCRIPTION, List<long?> LOC_L2_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l3> Get_Loc_l3_By_Where_InList_Adv ( string CODE, string DESCRIPTION, List<long?> LOC_L2_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l3> oList = new List<Loc_l3>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.LOC_L2_ID_LIST = string.Join(",", LOC_L2_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L3_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l3 o = new Loc_l3();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l2 = new Loc_l2();
o.My_Loc_l2.LOC_L2_ID = GV<Int64>(X["T_LOC_L2_LOC_L2_ID"]);o.My_Loc_l2.CODE = GV<String>(X["T_LOC_L2_CODE"]);o.My_Loc_l2.DESCRIPTION = GV<String>(X["T_LOC_L2_DESCRIPTION"]);o.My_Loc_l2.LOC_L1_ID = GV<Int64>(X["T_LOC_L2_LOC_L1_ID"]);o.My_Loc_l2.NOTES = GV<String>(X["T_LOC_L2_NOTES"]);o.My_Loc_l2.ENTRY_DATE = GV<String>(X["T_LOC_L2_ENTRY_DATE"]);o.My_Loc_l2.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L2_ENTRY_USER_ID"]);o.My_Loc_l2.OWNER_ID = GV<Int32>(X["T_LOC_L2_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Criteria_InList_Adv ( string CODE, string DESCRIPTION, List<long?> LOC_L3_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Loc_l4> Get_Loc_l4_By_Where_InList_Adv ( string CODE, string DESCRIPTION, List<long?> LOC_L3_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Loc_l4> oList = new List<Loc_l4>();
dynamic p = new ExpandoObject();
p.CODE = CODE; p.DESCRIPTION = DESCRIPTION; p.LOC_L3_ID_LIST = string.Join(",", LOC_L3_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_LOC_L4_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Loc_l4 o = new Loc_l4();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Loc_l3 = new Loc_l3();
o.My_Loc_l3.LOC_L3_ID = GV<Int64>(X["T_LOC_L3_LOC_L3_ID"]);o.My_Loc_l3.CODE = GV<String>(X["T_LOC_L3_CODE"]);o.My_Loc_l3.DESCRIPTION = GV<String>(X["T_LOC_L3_DESCRIPTION"]);o.My_Loc_l3.LOC_L2_ID = GV<Int64>(X["T_LOC_L3_LOC_L2_ID"]);o.My_Loc_l3.NOTES = GV<String>(X["T_LOC_L3_NOTES"]);o.My_Loc_l3.ENTRY_DATE = GV<String>(X["T_LOC_L3_ENTRY_DATE"]);o.My_Loc_l3.ENTRY_USER_ID = GV<Int64>(X["T_LOC_L3_ENTRY_USER_ID"]);o.My_Loc_l3.OWNER_ID = GV<Int32>(X["T_LOC_L3_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Package> Get_Package_By_Criteria_InList_Adv ( string PACKAGE_NAME, string PACKAGE_TYPE, string PACKAGE_TIMELINE, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Package> oList = new List<Package>();
dynamic p = new ExpandoObject();
p.PACKAGE_NAME = PACKAGE_NAME; p.PACKAGE_TYPE = PACKAGE_TYPE; p.PACKAGE_TIMELINE = PACKAGE_TIMELINE; p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PACKAGE_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Package o = new Package();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Package> Get_Package_By_Where_InList_Adv ( string PACKAGE_NAME, string PACKAGE_TYPE, string PACKAGE_TIMELINE, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Package> oList = new List<Package>();
dynamic p = new ExpandoObject();
p.PACKAGE_NAME = PACKAGE_NAME; p.PACKAGE_TYPE = PACKAGE_TYPE; p.PACKAGE_TIMELINE = PACKAGE_TIMELINE; p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PACKAGE_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Package o = new Package();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Package> Get_Package_By_Criteria_InList_Adv_V2 ( string PACKAGE_NAME, string PACKAGE_TYPE, string PACKAGE_ENDING_DATE, string PACKAGE_TIMELINE, string PACKAGE_STARTING_DATE, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Package> oList = new List<Package>();
dynamic p = new ExpandoObject();
p.PACKAGE_NAME = PACKAGE_NAME; p.PACKAGE_TYPE = PACKAGE_TYPE; p.PACKAGE_ENDING_DATE = PACKAGE_ENDING_DATE; p.PACKAGE_TIMELINE = PACKAGE_TIMELINE; p.PACKAGE_STARTING_DATE = PACKAGE_STARTING_DATE; p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PACKAGE_BY_CRITERIA_IN_LIST_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Package o = new Package();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Package> Get_Package_By_Where_InList_Adv_V2 ( string PACKAGE_NAME, string PACKAGE_TYPE, string PACKAGE_ENDING_DATE, string PACKAGE_TIMELINE, string PACKAGE_STARTING_DATE, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Package> oList = new List<Package>();
dynamic p = new ExpandoObject();
p.PACKAGE_NAME = PACKAGE_NAME; p.PACKAGE_TYPE = PACKAGE_TYPE; p.PACKAGE_ENDING_DATE = PACKAGE_ENDING_DATE; p.PACKAGE_TIMELINE = PACKAGE_TIMELINE; p.PACKAGE_STARTING_DATE = PACKAGE_STARTING_DATE; p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_PACKAGE_BY_WHERE_IN_LIST_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Package o = new Package();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Registration> Get_Registration_By_Criteria_InList_Adv ( string REGISTRATION_DESCRIPTION, List<Int32?> CLIENT_ID_LIST, List<Int32?> PACKAGE_ID_LIST, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Registration> oList = new List<Registration>();
dynamic p = new ExpandoObject();
p.REGISTRATION_DESCRIPTION = REGISTRATION_DESCRIPTION; p.CLIENT_ID_LIST = string.Join(",", CLIENT_ID_LIST.ToArray()); p.PACKAGE_ID_LIST = string.Join(",", PACKAGE_ID_LIST.ToArray()); p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_REGISTRATION_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Registration o = new Registration();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Client = new Client();
o.My_Client.CLIENT_ID = GV<Int32>(X["T_CLIENT_CLIENT_ID"]);o.My_Client.CLIENT_NAME = GV<String>(X["T_CLIENT_CLIENT_NAME"]);o.My_Client.CLIENT_PH_NB = GV<String>(X["T_CLIENT_CLIENT_PH_NB"]);o.My_Client.CLIENT_MAIL = GV<String>(X["T_CLIENT_CLIENT_MAIL"]);o.My_Client.CLIENT_DOB = GV<String>(X["T_CLIENT_CLIENT_DOB"]);o.My_Client.BLOODTYPE_ID = GV<Int32>(X["T_CLIENT_BLOODTYPE_ID"]);o.My_Client.ENTRY_USER_ID = GV<Int64>(X["T_CLIENT_ENTRY_USER_ID"]);o.My_Client.ENTRY_DATE = GV<String>(X["T_CLIENT_ENTRY_DATE"]);o.My_Client.OWNER_ID = GV<Int32>(X["T_CLIENT_OWNER_ID"]);o.My_Client.CLIENT_GENDER = GV<String>(X["T_CLIENT_CLIENT_GENDER"]);
o.My_Package = new Package();
o.My_Package.PACKAGE_ID = GV<Int32>(X["T_PACKAGE_PACKAGE_ID"]);o.My_Package.PACKAGE_NAME = GV<String>(X["T_PACKAGE_PACKAGE_NAME"]);o.My_Package.PACKAGE_PRICE = GV<Int32>(X["T_PACKAGE_PACKAGE_PRICE"]);o.My_Package.CURRENCY_ID = GV<Int32>(X["T_PACKAGE_CURRENCY_ID"]);o.My_Package.ENTRY_USER_ID = GV<Int64>(X["T_PACKAGE_ENTRY_USER_ID"]);o.My_Package.ENTRY_DATE = GV<String>(X["T_PACKAGE_ENTRY_DATE"]);o.My_Package.OWNER_ID = GV<Int32>(X["T_PACKAGE_OWNER_ID"]);o.My_Package.PACKAGE_SESSIONS_NB = GV<Int32>(X["T_PACKAGE_PACKAGE_SESSIONS_NB"]);o.My_Package.PACKAGE_TYPE = GV<String>(X["T_PACKAGE_PACKAGE_TYPE"]);o.My_Package.PACKAGE_ENDING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_ENDING_DATE"]);o.My_Package.PACKAGE_TIMELINE = GV<String>(X["T_PACKAGE_PACKAGE_TIMELINE"]);o.My_Package.PACKAGE_STARTING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_STARTING_DATE"]);o.My_Package.PACKAGE_NB_OF_MONTH = GV<Int32>(X["T_PACKAGE_PACKAGE_NB_OF_MONTH"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Registration> Get_Registration_By_Where_InList_Adv ( string REGISTRATION_DESCRIPTION, List<Int32?> CLIENT_ID_LIST, List<Int32?> PACKAGE_ID_LIST, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Registration> oList = new List<Registration>();
dynamic p = new ExpandoObject();
p.REGISTRATION_DESCRIPTION = REGISTRATION_DESCRIPTION; p.CLIENT_ID_LIST = string.Join(",", CLIENT_ID_LIST.ToArray()); p.PACKAGE_ID_LIST = string.Join(",", PACKAGE_ID_LIST.ToArray()); p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_REGISTRATION_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Registration o = new Registration();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Client = new Client();
o.My_Client.CLIENT_ID = GV<Int32>(X["T_CLIENT_CLIENT_ID"]);o.My_Client.CLIENT_NAME = GV<String>(X["T_CLIENT_CLIENT_NAME"]);o.My_Client.CLIENT_PH_NB = GV<String>(X["T_CLIENT_CLIENT_PH_NB"]);o.My_Client.CLIENT_MAIL = GV<String>(X["T_CLIENT_CLIENT_MAIL"]);o.My_Client.CLIENT_DOB = GV<String>(X["T_CLIENT_CLIENT_DOB"]);o.My_Client.BLOODTYPE_ID = GV<Int32>(X["T_CLIENT_BLOODTYPE_ID"]);o.My_Client.ENTRY_USER_ID = GV<Int64>(X["T_CLIENT_ENTRY_USER_ID"]);o.My_Client.ENTRY_DATE = GV<String>(X["T_CLIENT_ENTRY_DATE"]);o.My_Client.OWNER_ID = GV<Int32>(X["T_CLIENT_OWNER_ID"]);o.My_Client.CLIENT_GENDER = GV<String>(X["T_CLIENT_CLIENT_GENDER"]);
o.My_Package = new Package();
o.My_Package.PACKAGE_ID = GV<Int32>(X["T_PACKAGE_PACKAGE_ID"]);o.My_Package.PACKAGE_NAME = GV<String>(X["T_PACKAGE_PACKAGE_NAME"]);o.My_Package.PACKAGE_PRICE = GV<Int32>(X["T_PACKAGE_PACKAGE_PRICE"]);o.My_Package.CURRENCY_ID = GV<Int32>(X["T_PACKAGE_CURRENCY_ID"]);o.My_Package.ENTRY_USER_ID = GV<Int64>(X["T_PACKAGE_ENTRY_USER_ID"]);o.My_Package.ENTRY_DATE = GV<String>(X["T_PACKAGE_ENTRY_DATE"]);o.My_Package.OWNER_ID = GV<Int32>(X["T_PACKAGE_OWNER_ID"]);o.My_Package.PACKAGE_SESSIONS_NB = GV<Int32>(X["T_PACKAGE_PACKAGE_SESSIONS_NB"]);o.My_Package.PACKAGE_TYPE = GV<String>(X["T_PACKAGE_PACKAGE_TYPE"]);o.My_Package.PACKAGE_ENDING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_ENDING_DATE"]);o.My_Package.PACKAGE_TIMELINE = GV<String>(X["T_PACKAGE_PACKAGE_TIMELINE"]);o.My_Package.PACKAGE_STARTING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_STARTING_DATE"]);o.My_Package.PACKAGE_NB_OF_MONTH = GV<Int32>(X["T_PACKAGE_PACKAGE_NB_OF_MONTH"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Registration> Get_Registration_By_Criteria_InList_Adv_V2 ( string REGISTRATION_DATE, string REGISTRATION_DESCRIPTION, List<Int32?> CLIENT_ID_LIST, List<Int32?> PACKAGE_ID_LIST, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Registration> oList = new List<Registration>();
dynamic p = new ExpandoObject();
p.REGISTRATION_DATE = REGISTRATION_DATE; p.REGISTRATION_DESCRIPTION = REGISTRATION_DESCRIPTION; p.CLIENT_ID_LIST = string.Join(",", CLIENT_ID_LIST.ToArray()); p.PACKAGE_ID_LIST = string.Join(",", PACKAGE_ID_LIST.ToArray()); p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_REGISTRATION_BY_CRITERIA_IN_LIST_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Registration o = new Registration();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Registration> Get_Registration_By_Where_InList_Adv_V2 ( string REGISTRATION_DATE, string REGISTRATION_DESCRIPTION, List<Int32?> CLIENT_ID_LIST, List<Int32?> PACKAGE_ID_LIST, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Registration> oList = new List<Registration>();
dynamic p = new ExpandoObject();
p.REGISTRATION_DATE = REGISTRATION_DATE; p.REGISTRATION_DESCRIPTION = REGISTRATION_DESCRIPTION; p.CLIENT_ID_LIST = string.Join(",", CLIENT_ID_LIST.ToArray()); p.PACKAGE_ID_LIST = string.Join(",", PACKAGE_ID_LIST.ToArray()); p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_REGISTRATION_BY_WHERE_IN_LIST_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Registration o = new Registration();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Session> Get_Session_By_Criteria_InList_Adv ( string DESCRIPTION, List<Int32?> PACKAGE_ID_LIST, List<Int32?> CLIENT_FEES_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Session> oList = new List<Session>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.PACKAGE_ID_LIST = string.Join(",", PACKAGE_ID_LIST.ToArray()); p.CLIENT_FEES_ID_LIST = string.Join(",", CLIENT_FEES_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SESSION_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Session o = new Session();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Package = new Package();
o.My_Package.PACKAGE_ID = GV<Int32>(X["T_PACKAGE_PACKAGE_ID"]);o.My_Package.PACKAGE_NAME = GV<String>(X["T_PACKAGE_PACKAGE_NAME"]);o.My_Package.PACKAGE_PRICE = GV<Int32>(X["T_PACKAGE_PACKAGE_PRICE"]);o.My_Package.CURRENCY_ID = GV<Int32>(X["T_PACKAGE_CURRENCY_ID"]);o.My_Package.ENTRY_USER_ID = GV<Int64>(X["T_PACKAGE_ENTRY_USER_ID"]);o.My_Package.ENTRY_DATE = GV<String>(X["T_PACKAGE_ENTRY_DATE"]);o.My_Package.OWNER_ID = GV<Int32>(X["T_PACKAGE_OWNER_ID"]);o.My_Package.PACKAGE_SESSIONS_NB = GV<Int32>(X["T_PACKAGE_PACKAGE_SESSIONS_NB"]);o.My_Package.PACKAGE_TYPE = GV<String>(X["T_PACKAGE_PACKAGE_TYPE"]);o.My_Package.PACKAGE_ENDING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_ENDING_DATE"]);o.My_Package.PACKAGE_TIMELINE = GV<String>(X["T_PACKAGE_PACKAGE_TIMELINE"]);o.My_Package.PACKAGE_STARTING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_STARTING_DATE"]);o.My_Package.PACKAGE_NB_OF_MONTH = GV<Int32>(X["T_PACKAGE_PACKAGE_NB_OF_MONTH"]);
o.My_Client_fees = new Client_fees();
o.My_Client_fees.CLIENT_FEES_ID = GV<Int32>(X["T_CLIENT_FEES_CLIENT_FEES_ID"]);o.My_Client_fees.CLIENT_ID = GV<Int32>(X["T_CLIENT_FEES_CLIENT_ID"]);o.My_Client_fees.CLIENT_FEES_DESCRIPTION = GV<String>(X["T_CLIENT_FEES_CLIENT_FEES_DESCRIPTION"]);o.My_Client_fees.ENTRY_USER_ID = GV<Int64>(X["T_CLIENT_FEES_ENTRY_USER_ID"]);o.My_Client_fees.ENTRY_DATE = GV<String>(X["T_CLIENT_FEES_ENTRY_DATE"]);o.My_Client_fees.OWNER_ID = GV<Int32>(X["T_CLIENT_FEES_OWNER_ID"]);o.My_Client_fees.CURRENCY_ID = GV<Int32>(X["T_CLIENT_FEES_CURRENCY_ID"]);o.My_Client_fees.PACKAGE_ID = GV<Int32>(X["T_CLIENT_FEES_PACKAGE_ID"]);o.My_Client_fees.CLIENT_FEES_AMOUNT = GV<Int32>(X["T_CLIENT_FEES_CLIENT_FEES_AMOUNT"]);o.My_Client_fees.REGISTRATION_ID = GV<Int32>(X["T_CLIENT_FEES_REGISTRATION_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Session> Get_Session_By_Where_InList_Adv ( string DESCRIPTION, List<Int32?> PACKAGE_ID_LIST, List<Int32?> CLIENT_FEES_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Session> oList = new List<Session>();
dynamic p = new ExpandoObject();
p.DESCRIPTION = DESCRIPTION; p.PACKAGE_ID_LIST = string.Join(",", PACKAGE_ID_LIST.ToArray()); p.CLIENT_FEES_ID_LIST = string.Join(",", CLIENT_FEES_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SESSION_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Session o = new Session();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Package = new Package();
o.My_Package.PACKAGE_ID = GV<Int32>(X["T_PACKAGE_PACKAGE_ID"]);o.My_Package.PACKAGE_NAME = GV<String>(X["T_PACKAGE_PACKAGE_NAME"]);o.My_Package.PACKAGE_PRICE = GV<Int32>(X["T_PACKAGE_PACKAGE_PRICE"]);o.My_Package.CURRENCY_ID = GV<Int32>(X["T_PACKAGE_CURRENCY_ID"]);o.My_Package.ENTRY_USER_ID = GV<Int64>(X["T_PACKAGE_ENTRY_USER_ID"]);o.My_Package.ENTRY_DATE = GV<String>(X["T_PACKAGE_ENTRY_DATE"]);o.My_Package.OWNER_ID = GV<Int32>(X["T_PACKAGE_OWNER_ID"]);o.My_Package.PACKAGE_SESSIONS_NB = GV<Int32>(X["T_PACKAGE_PACKAGE_SESSIONS_NB"]);o.My_Package.PACKAGE_TYPE = GV<String>(X["T_PACKAGE_PACKAGE_TYPE"]);o.My_Package.PACKAGE_ENDING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_ENDING_DATE"]);o.My_Package.PACKAGE_TIMELINE = GV<String>(X["T_PACKAGE_PACKAGE_TIMELINE"]);o.My_Package.PACKAGE_STARTING_DATE = GV<String>(X["T_PACKAGE_PACKAGE_STARTING_DATE"]);o.My_Package.PACKAGE_NB_OF_MONTH = GV<Int32>(X["T_PACKAGE_PACKAGE_NB_OF_MONTH"]);
o.My_Client_fees = new Client_fees();
o.My_Client_fees.CLIENT_FEES_ID = GV<Int32>(X["T_CLIENT_FEES_CLIENT_FEES_ID"]);o.My_Client_fees.CLIENT_ID = GV<Int32>(X["T_CLIENT_FEES_CLIENT_ID"]);o.My_Client_fees.CLIENT_FEES_DESCRIPTION = GV<String>(X["T_CLIENT_FEES_CLIENT_FEES_DESCRIPTION"]);o.My_Client_fees.ENTRY_USER_ID = GV<Int64>(X["T_CLIENT_FEES_ENTRY_USER_ID"]);o.My_Client_fees.ENTRY_DATE = GV<String>(X["T_CLIENT_FEES_ENTRY_DATE"]);o.My_Client_fees.OWNER_ID = GV<Int32>(X["T_CLIENT_FEES_OWNER_ID"]);o.My_Client_fees.CURRENCY_ID = GV<Int32>(X["T_CLIENT_FEES_CURRENCY_ID"]);o.My_Client_fees.PACKAGE_ID = GV<Int32>(X["T_CLIENT_FEES_PACKAGE_ID"]);o.My_Client_fees.CLIENT_FEES_AMOUNT = GV<Int32>(X["T_CLIENT_FEES_CLIENT_FEES_AMOUNT"]);o.My_Client_fees.REGISTRATION_ID = GV<Int32>(X["T_CLIENT_FEES_REGISTRATION_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Session> Get_Session_By_Criteria_InList_Adv_V2 ( string SESSION_STARTING_DATE, string SESSION_ENDING_DATE, string DESCRIPTION, List<Int32?> PACKAGE_ID_LIST, List<Int32?> CLIENT_FEES_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Session> oList = new List<Session>();
dynamic p = new ExpandoObject();
p.SESSION_STARTING_DATE = SESSION_STARTING_DATE; p.SESSION_ENDING_DATE = SESSION_ENDING_DATE; p.DESCRIPTION = DESCRIPTION; p.PACKAGE_ID_LIST = string.Join(",", PACKAGE_ID_LIST.ToArray()); p.CLIENT_FEES_ID_LIST = string.Join(",", CLIENT_FEES_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SESSION_BY_CRITERIA_IN_LIST_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Session o = new Session();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Session> Get_Session_By_Where_InList_Adv_V2 ( string SESSION_STARTING_DATE, string SESSION_ENDING_DATE, string DESCRIPTION, List<Int32?> PACKAGE_ID_LIST, List<Int32?> CLIENT_FEES_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Session> oList = new List<Session>();
dynamic p = new ExpandoObject();
p.SESSION_STARTING_DATE = SESSION_STARTING_DATE; p.SESSION_ENDING_DATE = SESSION_ENDING_DATE; p.DESCRIPTION = DESCRIPTION; p.PACKAGE_ID_LIST = string.Join(",", PACKAGE_ID_LIST.ToArray()); p.CLIENT_FEES_ID_LIST = string.Join(",", CLIENT_FEES_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SESSION_BY_WHERE_IN_LIST_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Session o = new Session();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Staff> Get_Staff_By_Criteria_InList_Adv ( string STAFF_NAME, string STAFF_PH_NB, string STAFF_MAIL, string STAFF_GENDER, List<Int32?> BLOODTYPE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Staff> oList = new List<Staff>();
dynamic p = new ExpandoObject();
p.STAFF_NAME = STAFF_NAME; p.STAFF_PH_NB = STAFF_PH_NB; p.STAFF_MAIL = STAFF_MAIL; p.STAFF_GENDER = STAFF_GENDER; p.BLOODTYPE_ID_LIST = string.Join(",", BLOODTYPE_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Staff o = new Staff();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Bloodtype = new Bloodtype();
o.My_Bloodtype.BLOODTYPE_ID = GV<Int32>(X["T_BLOODTYPE_BLOODTYPE_ID"]);o.My_Bloodtype.BLOODTYPE_SYMBOL = GV<String>(X["T_BLOODTYPE_BLOODTYPE_SYMBOL"]);o.My_Bloodtype.ENTRY_USER_ID = GV<Int64>(X["T_BLOODTYPE_ENTRY_USER_ID"]);o.My_Bloodtype.ENTRY_DATE = GV<String>(X["T_BLOODTYPE_ENTRY_DATE"]);o.My_Bloodtype.OWNER_ID = GV<Int32>(X["T_BLOODTYPE_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Staff> Get_Staff_By_Where_InList_Adv ( string STAFF_NAME, string STAFF_PH_NB, string STAFF_MAIL, string STAFF_GENDER, List<Int32?> BLOODTYPE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Staff> oList = new List<Staff>();
dynamic p = new ExpandoObject();
p.STAFF_NAME = STAFF_NAME; p.STAFF_PH_NB = STAFF_PH_NB; p.STAFF_MAIL = STAFF_MAIL; p.STAFF_GENDER = STAFF_GENDER; p.BLOODTYPE_ID_LIST = string.Join(",", BLOODTYPE_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Staff o = new Staff();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Bloodtype = new Bloodtype();
o.My_Bloodtype.BLOODTYPE_ID = GV<Int32>(X["T_BLOODTYPE_BLOODTYPE_ID"]);o.My_Bloodtype.BLOODTYPE_SYMBOL = GV<String>(X["T_BLOODTYPE_BLOODTYPE_SYMBOL"]);o.My_Bloodtype.ENTRY_USER_ID = GV<Int64>(X["T_BLOODTYPE_ENTRY_USER_ID"]);o.My_Bloodtype.ENTRY_DATE = GV<String>(X["T_BLOODTYPE_ENTRY_DATE"]);o.My_Bloodtype.OWNER_ID = GV<Int32>(X["T_BLOODTYPE_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Staff> Get_Staff_By_Criteria_InList_Adv_V2 ( string STAFF_NAME, string STAFF_PH_NB, string STAFF_MAIL, string STAFF_DOB, string STAFF_GENDER, List<Int32?> BLOODTYPE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Staff> oList = new List<Staff>();
dynamic p = new ExpandoObject();
p.STAFF_NAME = STAFF_NAME; p.STAFF_PH_NB = STAFF_PH_NB; p.STAFF_MAIL = STAFF_MAIL; p.STAFF_DOB = STAFF_DOB; p.STAFF_GENDER = STAFF_GENDER; p.BLOODTYPE_ID_LIST = string.Join(",", BLOODTYPE_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_BY_CRITERIA_IN_LIST_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Staff o = new Staff();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Staff> Get_Staff_By_Where_InList_Adv_V2 ( string STAFF_NAME, string STAFF_PH_NB, string STAFF_MAIL, string STAFF_DOB, string STAFF_GENDER, List<Int32?> BLOODTYPE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Staff> oList = new List<Staff>();
dynamic p = new ExpandoObject();
p.STAFF_NAME = STAFF_NAME; p.STAFF_PH_NB = STAFF_PH_NB; p.STAFF_MAIL = STAFF_MAIL; p.STAFF_DOB = STAFF_DOB; p.STAFF_GENDER = STAFF_GENDER; p.BLOODTYPE_ID_LIST = string.Join(",", BLOODTYPE_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_BY_WHERE_IN_LIST_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Staff o = new Staff();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Staff_fees> Get_Staff_fees_By_Criteria_InList_Adv ( string STAFF_FEES_DESCRIPTION, List<Int32?> STAFF_ID_LIST, List<Int32?> CURRENCY_ID_LIST, List<Int32?> REGISTERED_STAFF_EXPENSE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Staff_fees> oList = new List<Staff_fees>();
dynamic p = new ExpandoObject();
p.STAFF_FEES_DESCRIPTION = STAFF_FEES_DESCRIPTION; p.STAFF_ID_LIST = string.Join(",", STAFF_ID_LIST.ToArray()); p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.REGISTERED_STAFF_EXPENSE_ID_LIST = string.Join(",", REGISTERED_STAFF_EXPENSE_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_FEES_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Staff_fees o = new Staff_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Staff = new Staff();
o.My_Staff.STAFF_ID = GV<Int32>(X["T_STAFF_STAFF_ID"]);o.My_Staff.STAFF_NAME = GV<String>(X["T_STAFF_STAFF_NAME"]);o.My_Staff.STAFF_PH_NB = GV<String>(X["T_STAFF_STAFF_PH_NB"]);o.My_Staff.STAFF_MAIL = GV<String>(X["T_STAFF_STAFF_MAIL"]);o.My_Staff.STAFF_DOB = GV<String>(X["T_STAFF_STAFF_DOB"]);o.My_Staff.BLOODTYPE_ID = GV<Int32>(X["T_STAFF_BLOODTYPE_ID"]);o.My_Staff.ENTRY_USER_ID = GV<Int64>(X["T_STAFF_ENTRY_USER_ID"]);o.My_Staff.ENTRY_DATE = GV<String>(X["T_STAFF_ENTRY_DATE"]);o.My_Staff.OWNER_ID = GV<Int32>(X["T_STAFF_OWNER_ID"]);o.My_Staff.STAFF_GENDER = GV<String>(X["T_STAFF_STAFF_GENDER"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Registered_staff_expense = new Registered_staff_expense();
o.My_Registered_staff_expense.REGISTERED_STAFF_EXPENSE_ID = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_REGISTERED_STAFF_EXPENSE_ID"]);o.My_Registered_staff_expense.REGISTERED_STAFF_EXPENSE_DISCOUNT = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_REGISTERED_STAFF_EXPENSE_DISCOUNT"]);o.My_Registered_staff_expense.REGISTERED_STAFF_EXPENSE_TOTAL_AMOUNT = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_REGISTERED_STAFF_EXPENSE_TOTAL_AMOUNT"]);o.My_Registered_staff_expense.REGISTERED_STAFF_EXPENSE_DESCRIPTION = GV<String>(X["T_REGISTERED_STAFF_EXPENSE_REGISTERED_STAFF_EXPENSE_DESCRIPTION"]);o.My_Registered_staff_expense.STAFF_ID = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_STAFF_ID"]);o.My_Registered_staff_expense.CURRENCY_ID = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_CURRENCY_ID"]);o.My_Registered_staff_expense.ENTRY_USER_ID = GV<Int64>(X["T_REGISTERED_STAFF_EXPENSE_ENTRY_USER_ID"]);o.My_Registered_staff_expense.ENTRY_DATE = GV<String>(X["T_REGISTERED_STAFF_EXPENSE_ENTRY_DATE"]);o.My_Registered_staff_expense.OWNER_ID = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Staff_fees> Get_Staff_fees_By_Where_InList_Adv ( string STAFF_FEES_DESCRIPTION, List<Int32?> STAFF_ID_LIST, List<Int32?> CURRENCY_ID_LIST, List<Int32?> REGISTERED_STAFF_EXPENSE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Staff_fees> oList = new List<Staff_fees>();
dynamic p = new ExpandoObject();
p.STAFF_FEES_DESCRIPTION = STAFF_FEES_DESCRIPTION; p.STAFF_ID_LIST = string.Join(",", STAFF_ID_LIST.ToArray()); p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.REGISTERED_STAFF_EXPENSE_ID_LIST = string.Join(",", REGISTERED_STAFF_EXPENSE_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_STAFF_FEES_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Staff_fees o = new Staff_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Staff = new Staff();
o.My_Staff.STAFF_ID = GV<Int32>(X["T_STAFF_STAFF_ID"]);o.My_Staff.STAFF_NAME = GV<String>(X["T_STAFF_STAFF_NAME"]);o.My_Staff.STAFF_PH_NB = GV<String>(X["T_STAFF_STAFF_PH_NB"]);o.My_Staff.STAFF_MAIL = GV<String>(X["T_STAFF_STAFF_MAIL"]);o.My_Staff.STAFF_DOB = GV<String>(X["T_STAFF_STAFF_DOB"]);o.My_Staff.BLOODTYPE_ID = GV<Int32>(X["T_STAFF_BLOODTYPE_ID"]);o.My_Staff.ENTRY_USER_ID = GV<Int64>(X["T_STAFF_ENTRY_USER_ID"]);o.My_Staff.ENTRY_DATE = GV<String>(X["T_STAFF_ENTRY_DATE"]);o.My_Staff.OWNER_ID = GV<Int32>(X["T_STAFF_OWNER_ID"]);o.My_Staff.STAFF_GENDER = GV<String>(X["T_STAFF_STAFF_GENDER"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Registered_staff_expense = new Registered_staff_expense();
o.My_Registered_staff_expense.REGISTERED_STAFF_EXPENSE_ID = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_REGISTERED_STAFF_EXPENSE_ID"]);o.My_Registered_staff_expense.REGISTERED_STAFF_EXPENSE_DISCOUNT = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_REGISTERED_STAFF_EXPENSE_DISCOUNT"]);o.My_Registered_staff_expense.REGISTERED_STAFF_EXPENSE_TOTAL_AMOUNT = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_REGISTERED_STAFF_EXPENSE_TOTAL_AMOUNT"]);o.My_Registered_staff_expense.REGISTERED_STAFF_EXPENSE_DESCRIPTION = GV<String>(X["T_REGISTERED_STAFF_EXPENSE_REGISTERED_STAFF_EXPENSE_DESCRIPTION"]);o.My_Registered_staff_expense.STAFF_ID = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_STAFF_ID"]);o.My_Registered_staff_expense.CURRENCY_ID = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_CURRENCY_ID"]);o.My_Registered_staff_expense.ENTRY_USER_ID = GV<Int64>(X["T_REGISTERED_STAFF_EXPENSE_ENTRY_USER_ID"]);o.My_Registered_staff_expense.ENTRY_DATE = GV<String>(X["T_REGISTERED_STAFF_EXPENSE_ENTRY_DATE"]);o.My_Registered_staff_expense.OWNER_ID = GV<Int32>(X["T_REGISTERED_STAFF_EXPENSE_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Supplier> Get_Supplier_By_Criteria_InList_Adv ( string SUPPLIER_NAME, string SUPPLIER_PH_NB, string SUPPLIER_MAIL, string SUPPLIER_GENDER, List<Int32?> BLOODTYPE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Supplier> oList = new List<Supplier>();
dynamic p = new ExpandoObject();
p.SUPPLIER_NAME = SUPPLIER_NAME; p.SUPPLIER_PH_NB = SUPPLIER_PH_NB; p.SUPPLIER_MAIL = SUPPLIER_MAIL; p.SUPPLIER_GENDER = SUPPLIER_GENDER; p.BLOODTYPE_ID_LIST = string.Join(",", BLOODTYPE_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Supplier o = new Supplier();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Bloodtype = new Bloodtype();
o.My_Bloodtype.BLOODTYPE_ID = GV<Int32>(X["T_BLOODTYPE_BLOODTYPE_ID"]);o.My_Bloodtype.BLOODTYPE_SYMBOL = GV<String>(X["T_BLOODTYPE_BLOODTYPE_SYMBOL"]);o.My_Bloodtype.ENTRY_USER_ID = GV<Int64>(X["T_BLOODTYPE_ENTRY_USER_ID"]);o.My_Bloodtype.ENTRY_DATE = GV<String>(X["T_BLOODTYPE_ENTRY_DATE"]);o.My_Bloodtype.OWNER_ID = GV<Int32>(X["T_BLOODTYPE_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Supplier> Get_Supplier_By_Where_InList_Adv ( string SUPPLIER_NAME, string SUPPLIER_PH_NB, string SUPPLIER_MAIL, string SUPPLIER_GENDER, List<Int32?> BLOODTYPE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Supplier> oList = new List<Supplier>();
dynamic p = new ExpandoObject();
p.SUPPLIER_NAME = SUPPLIER_NAME; p.SUPPLIER_PH_NB = SUPPLIER_PH_NB; p.SUPPLIER_MAIL = SUPPLIER_MAIL; p.SUPPLIER_GENDER = SUPPLIER_GENDER; p.BLOODTYPE_ID_LIST = string.Join(",", BLOODTYPE_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Supplier o = new Supplier();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Bloodtype = new Bloodtype();
o.My_Bloodtype.BLOODTYPE_ID = GV<Int32>(X["T_BLOODTYPE_BLOODTYPE_ID"]);o.My_Bloodtype.BLOODTYPE_SYMBOL = GV<String>(X["T_BLOODTYPE_BLOODTYPE_SYMBOL"]);o.My_Bloodtype.ENTRY_USER_ID = GV<Int64>(X["T_BLOODTYPE_ENTRY_USER_ID"]);o.My_Bloodtype.ENTRY_DATE = GV<String>(X["T_BLOODTYPE_ENTRY_DATE"]);o.My_Bloodtype.OWNER_ID = GV<Int32>(X["T_BLOODTYPE_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Supplier> Get_Supplier_By_Criteria_InList_Adv_V2 ( string SUPPLIER_NAME, string SUPPLIER_PH_NB, string SUPPLIER_MAIL, string SUPPLIER_DOB, string SUPPLIER_GENDER, List<Int32?> BLOODTYPE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Supplier> oList = new List<Supplier>();
dynamic p = new ExpandoObject();
p.SUPPLIER_NAME = SUPPLIER_NAME; p.SUPPLIER_PH_NB = SUPPLIER_PH_NB; p.SUPPLIER_MAIL = SUPPLIER_MAIL; p.SUPPLIER_DOB = SUPPLIER_DOB; p.SUPPLIER_GENDER = SUPPLIER_GENDER; p.BLOODTYPE_ID_LIST = string.Join(",", BLOODTYPE_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_BY_CRITERIA_IN_LIST_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Supplier o = new Supplier();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Supplier> Get_Supplier_By_Where_InList_Adv_V2 ( string SUPPLIER_NAME, string SUPPLIER_PH_NB, string SUPPLIER_MAIL, string SUPPLIER_DOB, string SUPPLIER_GENDER, List<Int32?> BLOODTYPE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Supplier> oList = new List<Supplier>();
dynamic p = new ExpandoObject();
p.SUPPLIER_NAME = SUPPLIER_NAME; p.SUPPLIER_PH_NB = SUPPLIER_PH_NB; p.SUPPLIER_MAIL = SUPPLIER_MAIL; p.SUPPLIER_DOB = SUPPLIER_DOB; p.SUPPLIER_GENDER = SUPPLIER_GENDER; p.BLOODTYPE_ID_LIST = string.Join(",", BLOODTYPE_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_BY_WHERE_IN_LIST_ADV_V2", p);
if (R != null) {foreach (var X in R) {
Supplier o = new Supplier();
oTools.CopyPropValues_FromDataRecord(X, o);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Supplier_fees> Get_Supplier_fees_By_Criteria_InList_Adv ( string SUPPLIER_FEES_DESCRIPTION, List<Int32?> SUPPLIER_ID_LIST, List<Int32?> CURRENCY_ID_LIST, List<Int32?> REGISTERED_SUPPLIER_EXPENSE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Supplier_fees> oList = new List<Supplier_fees>();
dynamic p = new ExpandoObject();
p.SUPPLIER_FEES_DESCRIPTION = SUPPLIER_FEES_DESCRIPTION; p.SUPPLIER_ID_LIST = string.Join(",", SUPPLIER_ID_LIST.ToArray()); p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.REGISTERED_SUPPLIER_EXPENSE_ID_LIST = string.Join(",", REGISTERED_SUPPLIER_EXPENSE_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_FEES_BY_CRITERIA_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Supplier_fees o = new Supplier_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Supplier = new Supplier();
o.My_Supplier.SUPPLIER_ID = GV<Int32>(X["T_SUPPLIER_SUPPLIER_ID"]);o.My_Supplier.SUPPLIER_NAME = GV<String>(X["T_SUPPLIER_SUPPLIER_NAME"]);o.My_Supplier.SUPPLIER_PH_NB = GV<String>(X["T_SUPPLIER_SUPPLIER_PH_NB"]);o.My_Supplier.SUPPLIER_MAIL = GV<String>(X["T_SUPPLIER_SUPPLIER_MAIL"]);o.My_Supplier.ENTRY_USER_ID = GV<Int64>(X["T_SUPPLIER_ENTRY_USER_ID"]);o.My_Supplier.ENTRY_DATE = GV<String>(X["T_SUPPLIER_ENTRY_DATE"]);o.My_Supplier.OWNER_ID = GV<Int32>(X["T_SUPPLIER_OWNER_ID"]);o.My_Supplier.SUPPLIER_DOB = GV<String>(X["T_SUPPLIER_SUPPLIER_DOB"]);o.My_Supplier.BLOODTYPE_ID = GV<Int32>(X["T_SUPPLIER_BLOODTYPE_ID"]);o.My_Supplier.SUPPLIER_GENDER = GV<String>(X["T_SUPPLIER_SUPPLIER_GENDER"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Registered_supplier_expense = new Registered_supplier_expense();
o.My_Registered_supplier_expense.REGISTERED_SUPPLIER_EXPENSE_ID = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_REGISTERED_SUPPLIER_EXPENSE_ID"]);o.My_Registered_supplier_expense.REGISTERED_SUPPLIER_EXPENSE_DISCOUNT = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_REGISTERED_SUPPLIER_EXPENSE_DISCOUNT"]);o.My_Registered_supplier_expense.REGISTERED_SUPPLIER_EXPENSE_TOTAL_AMOUNT = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_REGISTERED_SUPPLIER_EXPENSE_TOTAL_AMOUNT"]);o.My_Registered_supplier_expense.REGISTERED_SUPPLIER_EXPENSE_DESCRIPTION = GV<String>(X["T_REGISTERED_SUPPLIER_EXPENSE_REGISTERED_SUPPLIER_EXPENSE_DESCRIPTION"]);o.My_Registered_supplier_expense.SUPPLIER_ID = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_SUPPLIER_ID"]);o.My_Registered_supplier_expense.CURRENCY_ID = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_CURRENCY_ID"]);o.My_Registered_supplier_expense.ENTRY_USER_ID = GV<Int64>(X["T_REGISTERED_SUPPLIER_EXPENSE_ENTRY_USER_ID"]);o.My_Registered_supplier_expense.ENTRY_DATE = GV<String>(X["T_REGISTERED_SUPPLIER_EXPENSE_ENTRY_DATE"]);o.My_Registered_supplier_expense.OWNER_ID = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public List<Supplier_fees> Get_Supplier_fees_By_Where_InList_Adv ( string SUPPLIER_FEES_DESCRIPTION, List<Int32?> SUPPLIER_ID_LIST, List<Int32?> CURRENCY_ID_LIST, List<Int32?> REGISTERED_SUPPLIER_EXPENSE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT)
{
List<Supplier_fees> oList = new List<Supplier_fees>();
dynamic p = new ExpandoObject();
p.SUPPLIER_FEES_DESCRIPTION = SUPPLIER_FEES_DESCRIPTION; p.SUPPLIER_ID_LIST = string.Join(",", SUPPLIER_ID_LIST.ToArray()); p.CURRENCY_ID_LIST = string.Join(",", CURRENCY_ID_LIST.ToArray()); p.REGISTERED_SUPPLIER_EXPENSE_ID_LIST = string.Join(",", REGISTERED_SUPPLIER_EXPENSE_ID_LIST.ToArray()); p.OWNER_ID = OWNER_ID; p.START_ROW = START_ROW; p.END_ROW = END_ROW; p.TOTAL_COUNT = TOTAL_COUNT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UPG_GET_SUPPLIER_FEES_BY_WHERE_IN_LIST_ADV", p);
if (R != null) {foreach (var X in R) {
Supplier_fees o = new Supplier_fees();
oTools.CopyPropValues_FromDataRecord(X, o);
o.My_Supplier = new Supplier();
o.My_Supplier.SUPPLIER_ID = GV<Int32>(X["T_SUPPLIER_SUPPLIER_ID"]);o.My_Supplier.SUPPLIER_NAME = GV<String>(X["T_SUPPLIER_SUPPLIER_NAME"]);o.My_Supplier.SUPPLIER_PH_NB = GV<String>(X["T_SUPPLIER_SUPPLIER_PH_NB"]);o.My_Supplier.SUPPLIER_MAIL = GV<String>(X["T_SUPPLIER_SUPPLIER_MAIL"]);o.My_Supplier.ENTRY_USER_ID = GV<Int64>(X["T_SUPPLIER_ENTRY_USER_ID"]);o.My_Supplier.ENTRY_DATE = GV<String>(X["T_SUPPLIER_ENTRY_DATE"]);o.My_Supplier.OWNER_ID = GV<Int32>(X["T_SUPPLIER_OWNER_ID"]);o.My_Supplier.SUPPLIER_DOB = GV<String>(X["T_SUPPLIER_SUPPLIER_DOB"]);o.My_Supplier.BLOODTYPE_ID = GV<Int32>(X["T_SUPPLIER_BLOODTYPE_ID"]);o.My_Supplier.SUPPLIER_GENDER = GV<String>(X["T_SUPPLIER_SUPPLIER_GENDER"]);
o.My_Currency = new Currency();
o.My_Currency.CURRENCY_ID = GV<Int32>(X["T_CURRENCY_CURRENCY_ID"]);o.My_Currency.CURRENCY_TYPE = GV<String>(X["T_CURRENCY_CURRENCY_TYPE"]);o.My_Currency.CURRENCY_SYMBOL = GV<String>(X["T_CURRENCY_CURRENCY_SYMBOL"]);o.My_Currency.ENTRY_USER_ID = GV<Int64>(X["T_CURRENCY_ENTRY_USER_ID"]);o.My_Currency.ENTRY_DATE = GV<String>(X["T_CURRENCY_ENTRY_DATE"]);o.My_Currency.OWNER_ID = GV<Int32>(X["T_CURRENCY_OWNER_ID"]);
o.My_Registered_supplier_expense = new Registered_supplier_expense();
o.My_Registered_supplier_expense.REGISTERED_SUPPLIER_EXPENSE_ID = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_REGISTERED_SUPPLIER_EXPENSE_ID"]);o.My_Registered_supplier_expense.REGISTERED_SUPPLIER_EXPENSE_DISCOUNT = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_REGISTERED_SUPPLIER_EXPENSE_DISCOUNT"]);o.My_Registered_supplier_expense.REGISTERED_SUPPLIER_EXPENSE_TOTAL_AMOUNT = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_REGISTERED_SUPPLIER_EXPENSE_TOTAL_AMOUNT"]);o.My_Registered_supplier_expense.REGISTERED_SUPPLIER_EXPENSE_DESCRIPTION = GV<String>(X["T_REGISTERED_SUPPLIER_EXPENSE_REGISTERED_SUPPLIER_EXPENSE_DESCRIPTION"]);o.My_Registered_supplier_expense.SUPPLIER_ID = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_SUPPLIER_ID"]);o.My_Registered_supplier_expense.CURRENCY_ID = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_CURRENCY_ID"]);o.My_Registered_supplier_expense.ENTRY_USER_ID = GV<Int64>(X["T_REGISTERED_SUPPLIER_EXPENSE_ENTRY_USER_ID"]);o.My_Registered_supplier_expense.ENTRY_DATE = GV<String>(X["T_REGISTERED_SUPPLIER_EXPENSE_ENTRY_DATE"]);o.My_Registered_supplier_expense.OWNER_ID = GV<Int32>(X["T_REGISTERED_SUPPLIER_EXPENSE_OWNER_ID"]);
oList.Add(o);
}
}
TOTAL_COUNT = p.TOTAL_COUNT;
return oList;
}
public void Delete_Address ( long? ADDRESS_ID)
{
var p = new { ADDRESS_ID = ADDRESS_ID };
ExecuteDelete("UPG_DELETE_ADDRESS", p);
}
public void Delete_Bloodtype ( Int32? BLOODTYPE_ID)
{
var p = new { BLOODTYPE_ID = BLOODTYPE_ID };
ExecuteDelete("UPG_DELETE_BLOODTYPE", p);
}
public void Delete_Client ( Int32? CLIENT_ID)
{
var p = new { CLIENT_ID = CLIENT_ID };
ExecuteDelete("UPG_DELETE_CLIENT", p);
}
public void Delete_Client_fees ( Int32? CLIENT_FEES_ID)
{
var p = new { CLIENT_FEES_ID = CLIENT_FEES_ID };
ExecuteDelete("UPG_DELETE_CLIENT_FEES", p);
}
public void Delete_Contact ( Int32? CONTACT_ID)
{
var p = new { CONTACT_ID = CONTACT_ID };
ExecuteDelete("UPG_DELETE_CONTACT", p);
}
public void Delete_Currency ( Int32? CURRENCY_ID)
{
var p = new { CURRENCY_ID = CURRENCY_ID };
ExecuteDelete("UPG_DELETE_CURRENCY", p);
}
public void Delete_Fees ( Int32? FEES_ID)
{
var p = new { FEES_ID = FEES_ID };
ExecuteDelete("UPG_DELETE_FEES", p);
}
public void Delete_Loc_l1 ( long? LOC_L1_ID)
{
var p = new { LOC_L1_ID = LOC_L1_ID };
ExecuteDelete("UPG_DELETE_LOC_L1", p);
}
public void Delete_Loc_l2 ( long? LOC_L2_ID)
{
var p = new { LOC_L2_ID = LOC_L2_ID };
ExecuteDelete("UPG_DELETE_LOC_L2", p);
}
public void Delete_Loc_l3 ( long? LOC_L3_ID)
{
var p = new { LOC_L3_ID = LOC_L3_ID };
ExecuteDelete("UPG_DELETE_LOC_L3", p);
}
public void Delete_Loc_l4 ( long? LOC_L4_ID)
{
var p = new { LOC_L4_ID = LOC_L4_ID };
ExecuteDelete("UPG_DELETE_LOC_L4", p);
}
public void Delete_Method_run ( long? METHOD_RUN_ID)
{
var p = new { METHOD_RUN_ID = METHOD_RUN_ID };
ExecuteDelete("UPG_DELETE_METHOD_RUN", p);
}
public void Delete_Owner ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_OWNER", p);
}
public void Delete_Package ( Int32? PACKAGE_ID)
{
var p = new { PACKAGE_ID = PACKAGE_ID };
ExecuteDelete("UPG_DELETE_PACKAGE", p);
}
public void Delete_Person ( long? PERSON_ID)
{
var p = new { PERSON_ID = PERSON_ID };
ExecuteDelete("UPG_DELETE_PERSON", p);
}
public void Delete_Registered_staff_expense ( Int32? REGISTERED_STAFF_EXPENSE_ID)
{
var p = new { REGISTERED_STAFF_EXPENSE_ID = REGISTERED_STAFF_EXPENSE_ID };
ExecuteDelete("UPG_DELETE_REGISTERED_STAFF_EXPENSE", p);
}
public void Delete_Registered_supplier_expense ( Int32? REGISTERED_SUPPLIER_EXPENSE_ID)
{
var p = new { REGISTERED_SUPPLIER_EXPENSE_ID = REGISTERED_SUPPLIER_EXPENSE_ID };
ExecuteDelete("UPG_DELETE_REGISTERED_SUPPLIER_EXPENSE", p);
}
public void Delete_Registration ( Int32? REGISTRATION_ID)
{
var p = new { REGISTRATION_ID = REGISTRATION_ID };
ExecuteDelete("UPG_DELETE_REGISTRATION", p);
}
public void Delete_Session ( Int32? SESSION_ID)
{
var p = new { SESSION_ID = SESSION_ID };
ExecuteDelete("UPG_DELETE_SESSION", p);
}
public void Delete_Staff ( Int32? STAFF_ID)
{
var p = new { STAFF_ID = STAFF_ID };
ExecuteDelete("UPG_DELETE_STAFF", p);
}
public void Delete_Staff_fees ( Int32? STAFF_FEES_ID)
{
var p = new { STAFF_FEES_ID = STAFF_FEES_ID };
ExecuteDelete("UPG_DELETE_STAFF_FEES", p);
}
public void Delete_Supplier ( Int32? SUPPLIER_ID)
{
var p = new { SUPPLIER_ID = SUPPLIER_ID };
ExecuteDelete("UPG_DELETE_SUPPLIER", p);
}
public void Delete_Supplier_fees ( Int32? SUPPLIER_FEES_ID)
{
var p = new { SUPPLIER_FEES_ID = SUPPLIER_FEES_ID };
ExecuteDelete("UPG_DELETE_SUPPLIER_FEES", p);
}
public void Delete_User ( long? USER_ID)
{
var p = new { USER_ID = USER_ID };
ExecuteDelete("UPG_DELETE_USER", p);
}
public void Delete_Address_By_PERSON_ID ( long? PERSON_ID)
{
var p = new { PERSON_ID = PERSON_ID };
ExecuteDelete("UPG_DELETE_ADDRESS_BY_PERSON_ID", p);
}
public void Delete_Address_By_LOC_L1_ID ( long? LOC_L1_ID)
{
var p = new { LOC_L1_ID = LOC_L1_ID };
ExecuteDelete("UPG_DELETE_ADDRESS_BY_LOC_L1_ID", p);
}
public void Delete_Address_By_LOC_L2_ID ( long? LOC_L2_ID)
{
var p = new { LOC_L2_ID = LOC_L2_ID };
ExecuteDelete("UPG_DELETE_ADDRESS_BY_LOC_L2_ID", p);
}
public void Delete_Address_By_LOC_L3_ID ( long? LOC_L3_ID)
{
var p = new { LOC_L3_ID = LOC_L3_ID };
ExecuteDelete("UPG_DELETE_ADDRESS_BY_LOC_L3_ID", p);
}
public void Delete_Address_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_ADDRESS_BY_OWNER_ID", p);
}
public void Delete_Address_By_PERSON_ID_ADDRESS_TYPE_CODE ( long? PERSON_ID, string ADDRESS_TYPE_CODE)
{
var p = new { PERSON_ID = PERSON_ID,ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE };
ExecuteDelete("UPG_DELETE_ADDRESS_BY_PERSON_ID_ADDRESS_TYPE_CODE", p);
}
public void Delete_Address_By_LOC_L4_ID ( long? LOC_L4_ID)
{
var p = new { LOC_L4_ID = LOC_L4_ID };
ExecuteDelete("UPG_DELETE_ADDRESS_BY_LOC_L4_ID", p);
}
public void Delete_Bloodtype_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_BLOODTYPE_BY_OWNER_ID", p);
}
public void Delete_Client_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_CLIENT_BY_OWNER_ID", p);
}
public void Delete_Client_By_BLOODTYPE_ID ( Int32? BLOODTYPE_ID)
{
var p = new { BLOODTYPE_ID = BLOODTYPE_ID };
ExecuteDelete("UPG_DELETE_CLIENT_BY_BLOODTYPE_ID", p);
}
public void Delete_Client_fees_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_CLIENT_FEES_BY_OWNER_ID", p);
}
public void Delete_Client_fees_By_CLIENT_ID ( Int32? CLIENT_ID)
{
var p = new { CLIENT_ID = CLIENT_ID };
ExecuteDelete("UPG_DELETE_CLIENT_FEES_BY_CLIENT_ID", p);
}
public void Delete_Client_fees_By_CURRENCY_ID ( Int32? CURRENCY_ID)
{
var p = new { CURRENCY_ID = CURRENCY_ID };
ExecuteDelete("UPG_DELETE_CLIENT_FEES_BY_CURRENCY_ID", p);
}
public void Delete_Client_fees_By_PACKAGE_ID ( Int32? PACKAGE_ID)
{
var p = new { PACKAGE_ID = PACKAGE_ID };
ExecuteDelete("UPG_DELETE_CLIENT_FEES_BY_PACKAGE_ID", p);
}
public void Delete_Client_fees_By_REGISTRATION_ID ( Int32? REGISTRATION_ID)
{
var p = new { REGISTRATION_ID = REGISTRATION_ID };
ExecuteDelete("UPG_DELETE_CLIENT_FEES_BY_REGISTRATION_ID", p);
}
public void Delete_Contact_By_PERSON_ID ( long? PERSON_ID)
{
var p = new { PERSON_ID = PERSON_ID };
ExecuteDelete("UPG_DELETE_CONTACT_BY_PERSON_ID", p);
}
public void Delete_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT ( long? PERSON_ID, string CONTACT_TYPE_CODE, string CONTACT)
{
var p = new { PERSON_ID = PERSON_ID,CONTACT_TYPE_CODE = CONTACT_TYPE_CODE,CONTACT = CONTACT };
ExecuteDelete("UPG_DELETE_CONTACT_BY_PERSON_ID_CONTACT_TYPE_CODE_CONTACT", p);
}
public void Delete_Contact_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_CONTACT_BY_OWNER_ID", p);
}
public void Delete_Currency_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_CURRENCY_BY_OWNER_ID", p);
}
public void Delete_Fees_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_FEES_BY_OWNER_ID", p);
}
public void Delete_Fees_By_CURRENCY_ID ( Int32? CURRENCY_ID)
{
var p = new { CURRENCY_ID = CURRENCY_ID };
ExecuteDelete("UPG_DELETE_FEES_BY_CURRENCY_ID", p);
}
public void Delete_Loc_l1_By_CODE ( string CODE)
{
var p = new { CODE = CODE };
ExecuteDelete("UPG_DELETE_LOC_L1_BY_CODE", p);
}
public void Delete_Loc_l1_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_LOC_L1_BY_OWNER_ID", p);
}
public void Delete_Loc_l2_By_LOC_L1_ID_CODE ( long? LOC_L1_ID, string CODE)
{
var p = new { LOC_L1_ID = LOC_L1_ID,CODE = CODE };
ExecuteDelete("UPG_DELETE_LOC_L2_BY_LOC_L1_ID_CODE", p);
}
public void Delete_Loc_l2_By_LOC_L1_ID ( long? LOC_L1_ID)
{
var p = new { LOC_L1_ID = LOC_L1_ID };
ExecuteDelete("UPG_DELETE_LOC_L2_BY_LOC_L1_ID", p);
}
public void Delete_Loc_l2_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_LOC_L2_BY_OWNER_ID", p);
}
public void Delete_Loc_l3_By_LOC_L2_ID_CODE ( long? LOC_L2_ID, string CODE)
{
var p = new { LOC_L2_ID = LOC_L2_ID,CODE = CODE };
ExecuteDelete("UPG_DELETE_LOC_L3_BY_LOC_L2_ID_CODE", p);
}
public void Delete_Loc_l3_By_LOC_L2_ID ( long? LOC_L2_ID)
{
var p = new { LOC_L2_ID = LOC_L2_ID };
ExecuteDelete("UPG_DELETE_LOC_L3_BY_LOC_L2_ID", p);
}
public void Delete_Loc_l3_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_LOC_L3_BY_OWNER_ID", p);
}
public void Delete_Loc_l4_By_LOC_L3_ID_CODE ( long? LOC_L3_ID, string CODE)
{
var p = new { LOC_L3_ID = LOC_L3_ID,CODE = CODE };
ExecuteDelete("UPG_DELETE_LOC_L4_BY_LOC_L3_ID_CODE", p);
}
public void Delete_Loc_l4_By_LOC_L3_ID ( long? LOC_L3_ID)
{
var p = new { LOC_L3_ID = LOC_L3_ID };
ExecuteDelete("UPG_DELETE_LOC_L4_BY_LOC_L3_ID", p);
}
public void Delete_Loc_l4_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_LOC_L4_BY_OWNER_ID", p);
}
public void Delete_Method_run_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_METHOD_RUN_BY_OWNER_ID", p);
}
public void Delete_Package_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_PACKAGE_BY_OWNER_ID", p);
}
public void Delete_Package_By_CURRENCY_ID ( Int32? CURRENCY_ID)
{
var p = new { CURRENCY_ID = CURRENCY_ID };
ExecuteDelete("UPG_DELETE_PACKAGE_BY_CURRENCY_ID", p);
}
public void Delete_Person_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_PERSON_BY_OWNER_ID", p);
}
public void Delete_Registered_staff_expense_By_STAFF_ID ( Int32? STAFF_ID)
{
var p = new { STAFF_ID = STAFF_ID };
ExecuteDelete("UPG_DELETE_REGISTERED_STAFF_EXPENSE_BY_STAFF_ID", p);
}
public void Delete_Registered_staff_expense_By_CURRENCY_ID ( Int32? CURRENCY_ID)
{
var p = new { CURRENCY_ID = CURRENCY_ID };
ExecuteDelete("UPG_DELETE_REGISTERED_STAFF_EXPENSE_BY_CURRENCY_ID", p);
}
public void Delete_Registered_staff_expense_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_REGISTERED_STAFF_EXPENSE_BY_OWNER_ID", p);
}
public void Delete_Registered_supplier_expense_By_SUPPLIER_ID ( Int32? SUPPLIER_ID)
{
var p = new { SUPPLIER_ID = SUPPLIER_ID };
ExecuteDelete("UPG_DELETE_REGISTERED_SUPPLIER_EXPENSE_BY_SUPPLIER_ID", p);
}
public void Delete_Registered_supplier_expense_By_CURRENCY_ID ( Int32? CURRENCY_ID)
{
var p = new { CURRENCY_ID = CURRENCY_ID };
ExecuteDelete("UPG_DELETE_REGISTERED_SUPPLIER_EXPENSE_BY_CURRENCY_ID", p);
}
public void Delete_Registered_supplier_expense_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_REGISTERED_SUPPLIER_EXPENSE_BY_OWNER_ID", p);
}
public void Delete_Registration_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_REGISTRATION_BY_OWNER_ID", p);
}
public void Delete_Registration_By_CLIENT_ID ( Int32? CLIENT_ID)
{
var p = new { CLIENT_ID = CLIENT_ID };
ExecuteDelete("UPG_DELETE_REGISTRATION_BY_CLIENT_ID", p);
}
public void Delete_Registration_By_PACKAGE_ID ( Int32? PACKAGE_ID)
{
var p = new { PACKAGE_ID = PACKAGE_ID };
ExecuteDelete("UPG_DELETE_REGISTRATION_BY_PACKAGE_ID", p);
}
public void Delete_Registration_By_CURRENCY_ID ( Int32? CURRENCY_ID)
{
var p = new { CURRENCY_ID = CURRENCY_ID };
ExecuteDelete("UPG_DELETE_REGISTRATION_BY_CURRENCY_ID", p);
}
public void Delete_Session_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_SESSION_BY_OWNER_ID", p);
}
public void Delete_Session_By_PACKAGE_ID ( Int32? PACKAGE_ID)
{
var p = new { PACKAGE_ID = PACKAGE_ID };
ExecuteDelete("UPG_DELETE_SESSION_BY_PACKAGE_ID", p);
}
public void Delete_Session_By_CLIENT_FEES_ID ( Int32? CLIENT_FEES_ID)
{
var p = new { CLIENT_FEES_ID = CLIENT_FEES_ID };
ExecuteDelete("UPG_DELETE_SESSION_BY_CLIENT_FEES_ID", p);
}
public void Delete_Staff_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_STAFF_BY_OWNER_ID", p);
}
public void Delete_Staff_By_BLOODTYPE_ID ( Int32? BLOODTYPE_ID)
{
var p = new { BLOODTYPE_ID = BLOODTYPE_ID };
ExecuteDelete("UPG_DELETE_STAFF_BY_BLOODTYPE_ID", p);
}
public void Delete_Staff_fees_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_STAFF_FEES_BY_OWNER_ID", p);
}
public void Delete_Staff_fees_By_STAFF_ID ( Int32? STAFF_ID)
{
var p = new { STAFF_ID = STAFF_ID };
ExecuteDelete("UPG_DELETE_STAFF_FEES_BY_STAFF_ID", p);
}
public void Delete_Staff_fees_By_CURRENCY_ID ( Int32? CURRENCY_ID)
{
var p = new { CURRENCY_ID = CURRENCY_ID };
ExecuteDelete("UPG_DELETE_STAFF_FEES_BY_CURRENCY_ID", p);
}
public void Delete_Staff_fees_By_REGISTERED_STAFF_EXPENSE_ID ( Int32? REGISTERED_STAFF_EXPENSE_ID)
{
var p = new { REGISTERED_STAFF_EXPENSE_ID = REGISTERED_STAFF_EXPENSE_ID };
ExecuteDelete("UPG_DELETE_STAFF_FEES_BY_REGISTERED_STAFF_EXPENSE_ID", p);
}
public void Delete_Supplier_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_SUPPLIER_BY_OWNER_ID", p);
}
public void Delete_Supplier_By_BLOODTYPE_ID ( Int32? BLOODTYPE_ID)
{
var p = new { BLOODTYPE_ID = BLOODTYPE_ID };
ExecuteDelete("UPG_DELETE_SUPPLIER_BY_BLOODTYPE_ID", p);
}
public void Delete_Supplier_fees_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_SUPPLIER_FEES_BY_OWNER_ID", p);
}
public void Delete_Supplier_fees_By_SUPPLIER_ID ( Int32? SUPPLIER_ID)
{
var p = new { SUPPLIER_ID = SUPPLIER_ID };
ExecuteDelete("UPG_DELETE_SUPPLIER_FEES_BY_SUPPLIER_ID", p);
}
public void Delete_Supplier_fees_By_CURRENCY_ID ( Int32? CURRENCY_ID)
{
var p = new { CURRENCY_ID = CURRENCY_ID };
ExecuteDelete("UPG_DELETE_SUPPLIER_FEES_BY_CURRENCY_ID", p);
}
public void Delete_Supplier_fees_By_REGISTERED_SUPPLIER_EXPENSE_ID ( Int32? REGISTERED_SUPPLIER_EXPENSE_ID)
{
var p = new { REGISTERED_SUPPLIER_EXPENSE_ID = REGISTERED_SUPPLIER_EXPENSE_ID };
ExecuteDelete("UPG_DELETE_SUPPLIER_FEES_BY_REGISTERED_SUPPLIER_EXPENSE_ID", p);
}
public void Delete_User_By_OWNER_ID ( Int32? OWNER_ID)
{
var p = new { OWNER_ID = OWNER_ID };
ExecuteDelete("UPG_DELETE_USER_BY_OWNER_ID", p);
}
public void Delete_User_By_USERNAME ( string USERNAME)
{
var p = new { USERNAME = USERNAME };
ExecuteDelete("UPG_DELETE_USER_BY_USERNAME", p);
}
public long? Edit_Address ( long? ADDRESS_ID, long? PERSON_ID, string ADDRESS_TYPE_CODE, long? LOC_L1_ID, long? LOC_L2_ID, long? LOC_L3_ID, long? LOC_L4_ID, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, string NOTES, string ENTRY_DATE, long? ENTRY_USER_ID, Int32? OWNER_ID)
{
Address oAddress = new Address();
oAddress.ADDRESS_ID = ADDRESS_ID;oAddress.PERSON_ID = PERSON_ID;oAddress.ADDRESS_TYPE_CODE = ADDRESS_TYPE_CODE;oAddress.LOC_L1_ID = LOC_L1_ID;oAddress.LOC_L2_ID = LOC_L2_ID;oAddress.LOC_L3_ID = LOC_L3_ID;oAddress.LOC_L4_ID = LOC_L4_ID;oAddress.STREET = STREET;oAddress.BUILDING = BUILDING;oAddress.FLOOR = FLOOR;oAddress.POBOX = POBOX;oAddress.VALID_DATE_START = VALID_DATE_START;oAddress.VALID_DATE_END = VALID_DATE_END;oAddress.NOTES = NOTES;oAddress.ENTRY_DATE = ENTRY_DATE;oAddress.ENTRY_USER_ID = ENTRY_USER_ID;oAddress.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_ADDRESS", oAddress, "ADDRESS_ID");
return oAddress.ADDRESS_ID;
}
public Int32? Edit_Bloodtype ( Int32? BLOODTYPE_ID, string BLOODTYPE_SYMBOL, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Bloodtype oBloodtype = new Bloodtype();
oBloodtype.BLOODTYPE_ID = BLOODTYPE_ID;oBloodtype.BLOODTYPE_SYMBOL = BLOODTYPE_SYMBOL;oBloodtype.ENTRY_USER_ID = ENTRY_USER_ID;oBloodtype.ENTRY_DATE = ENTRY_DATE;oBloodtype.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_BLOODTYPE", oBloodtype, "BLOODTYPE_ID");
return oBloodtype.BLOODTYPE_ID;
}
public Int32? Edit_Client ( Int32? CLIENT_ID, string CLIENT_NAME, string CLIENT_PH_NB, string CLIENT_MAIL, string CLIENT_DOB, Int32? BLOODTYPE_ID, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID, string CLIENT_GENDER)
{
Client oClient = new Client();
oClient.CLIENT_ID = CLIENT_ID;oClient.CLIENT_NAME = CLIENT_NAME;oClient.CLIENT_PH_NB = CLIENT_PH_NB;oClient.CLIENT_MAIL = CLIENT_MAIL;oClient.CLIENT_DOB = CLIENT_DOB;oClient.BLOODTYPE_ID = BLOODTYPE_ID;oClient.ENTRY_USER_ID = ENTRY_USER_ID;oClient.ENTRY_DATE = ENTRY_DATE;oClient.OWNER_ID = OWNER_ID;oClient.CLIENT_GENDER = CLIENT_GENDER;
ExecuteEdit("UPG_EDIT_CLIENT", oClient, "CLIENT_ID");
return oClient.CLIENT_ID;
}
public Int32? Edit_Client_fees ( Int32? CLIENT_FEES_ID, Int32? CLIENT_ID, string CLIENT_FEES_DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID, Int32? CURRENCY_ID, Int32? PACKAGE_ID, Int32? CLIENT_FEES_AMOUNT, Int32? REGISTRATION_ID)
{
Client_fees oClient_fees = new Client_fees();
oClient_fees.CLIENT_FEES_ID = CLIENT_FEES_ID;oClient_fees.CLIENT_ID = CLIENT_ID;oClient_fees.CLIENT_FEES_DESCRIPTION = CLIENT_FEES_DESCRIPTION;oClient_fees.ENTRY_USER_ID = ENTRY_USER_ID;oClient_fees.ENTRY_DATE = ENTRY_DATE;oClient_fees.OWNER_ID = OWNER_ID;oClient_fees.CURRENCY_ID = CURRENCY_ID;oClient_fees.PACKAGE_ID = PACKAGE_ID;oClient_fees.CLIENT_FEES_AMOUNT = CLIENT_FEES_AMOUNT;oClient_fees.REGISTRATION_ID = REGISTRATION_ID;
ExecuteEdit("UPG_EDIT_CLIENT_FEES", oClient_fees, "CLIENT_FEES_ID");
return oClient_fees.CLIENT_FEES_ID;
}
public Int32? Edit_Contact ( Int32? CONTACT_ID, long? PERSON_ID, string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Contact oContact = new Contact();
oContact.CONTACT_ID = CONTACT_ID;oContact.PERSON_ID = PERSON_ID;oContact.CONTACT_TYPE_CODE = CONTACT_TYPE_CODE;oContact.CONTACT = CONTACT;oContact.DESCRIPTION = DESCRIPTION;oContact.ENTRY_USER_ID = ENTRY_USER_ID;oContact.ENTRY_DATE = ENTRY_DATE;oContact.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_CONTACT", oContact, "CONTACT_ID");
return oContact.CONTACT_ID;
}
public Int32? Edit_Currency ( Int32? CURRENCY_ID, string CURRENCY_TYPE, string CURRENCY_SYMBOL, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Currency oCurrency = new Currency();
oCurrency.CURRENCY_ID = CURRENCY_ID;oCurrency.CURRENCY_TYPE = CURRENCY_TYPE;oCurrency.CURRENCY_SYMBOL = CURRENCY_SYMBOL;oCurrency.ENTRY_USER_ID = ENTRY_USER_ID;oCurrency.ENTRY_DATE = ENTRY_DATE;oCurrency.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_CURRENCY", oCurrency, "CURRENCY_ID");
return oCurrency.CURRENCY_ID;
}
public Int32? Edit_Fees ( Int32? FEES_ID, string FEES_DESCRIPTION, Int32? FEES_AMOUNT, Int32? CURRENCY_ID, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID, string FEES_ORIGIN_DATE)
{
Fees oFees = new Fees();
oFees.FEES_ID = FEES_ID;oFees.FEES_DESCRIPTION = FEES_DESCRIPTION;oFees.FEES_AMOUNT = FEES_AMOUNT;oFees.CURRENCY_ID = CURRENCY_ID;oFees.ENTRY_USER_ID = ENTRY_USER_ID;oFees.ENTRY_DATE = ENTRY_DATE;oFees.OWNER_ID = OWNER_ID;oFees.FEES_ORIGIN_DATE = FEES_ORIGIN_DATE;
ExecuteEdit("UPG_EDIT_FEES", oFees, "FEES_ID");
return oFees.FEES_ID;
}
public long? Edit_Loc_l1 ( long? LOC_L1_ID, string CODE, string DESCRIPTION, string NOTES, string ENTRY_DATE, long? ENTRY_USER_ID, Int32? OWNER_ID)
{
Loc_l1 oLoc_l1 = new Loc_l1();
oLoc_l1.LOC_L1_ID = LOC_L1_ID;oLoc_l1.CODE = CODE;oLoc_l1.DESCRIPTION = DESCRIPTION;oLoc_l1.NOTES = NOTES;oLoc_l1.ENTRY_DATE = ENTRY_DATE;oLoc_l1.ENTRY_USER_ID = ENTRY_USER_ID;oLoc_l1.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_LOC_L1", oLoc_l1, "LOC_L1_ID");
return oLoc_l1.LOC_L1_ID;
}
public long? Edit_Loc_l2 ( long? LOC_L2_ID, string CODE, string DESCRIPTION, long? LOC_L1_ID, string NOTES, string ENTRY_DATE, long? ENTRY_USER_ID, Int32? OWNER_ID)
{
Loc_l2 oLoc_l2 = new Loc_l2();
oLoc_l2.LOC_L2_ID = LOC_L2_ID;oLoc_l2.CODE = CODE;oLoc_l2.DESCRIPTION = DESCRIPTION;oLoc_l2.LOC_L1_ID = LOC_L1_ID;oLoc_l2.NOTES = NOTES;oLoc_l2.ENTRY_DATE = ENTRY_DATE;oLoc_l2.ENTRY_USER_ID = ENTRY_USER_ID;oLoc_l2.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_LOC_L2", oLoc_l2, "LOC_L2_ID");
return oLoc_l2.LOC_L2_ID;
}
public long? Edit_Loc_l3 ( long? LOC_L3_ID, string CODE, string DESCRIPTION, long? LOC_L2_ID, string NOTES, string ENTRY_DATE, long? ENTRY_USER_ID, Int32? OWNER_ID)
{
Loc_l3 oLoc_l3 = new Loc_l3();
oLoc_l3.LOC_L3_ID = LOC_L3_ID;oLoc_l3.CODE = CODE;oLoc_l3.DESCRIPTION = DESCRIPTION;oLoc_l3.LOC_L2_ID = LOC_L2_ID;oLoc_l3.NOTES = NOTES;oLoc_l3.ENTRY_DATE = ENTRY_DATE;oLoc_l3.ENTRY_USER_ID = ENTRY_USER_ID;oLoc_l3.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_LOC_L3", oLoc_l3, "LOC_L3_ID");
return oLoc_l3.LOC_L3_ID;
}
public long? Edit_Loc_l4 ( long? LOC_L4_ID, string CODE, string DESCRIPTION, long? LOC_L3_ID, string NOTES, string ENTRY_DATE, long? ENTRY_USER_ID, Int32? OWNER_ID)
{
Loc_l4 oLoc_l4 = new Loc_l4();
oLoc_l4.LOC_L4_ID = LOC_L4_ID;oLoc_l4.CODE = CODE;oLoc_l4.DESCRIPTION = DESCRIPTION;oLoc_l4.LOC_L3_ID = LOC_L3_ID;oLoc_l4.NOTES = NOTES;oLoc_l4.ENTRY_DATE = ENTRY_DATE;oLoc_l4.ENTRY_USER_ID = ENTRY_USER_ID;oLoc_l4.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_LOC_L4", oLoc_l4, "LOC_L4_ID");
return oLoc_l4.LOC_L4_ID;
}
public long? Edit_Method_run ( long? METHOD_RUN_ID, string METHOD_NAME, string RUN_DATE, Int32? RUN_HOUR, Int32? RUN_MINUTE, Int32? RUN_SECOND, bool? IS_CACHED, Int32? EXECUTION_TIME, string INPUT_PARAM, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Method_run oMethod_run = new Method_run();
oMethod_run.METHOD_RUN_ID = METHOD_RUN_ID;oMethod_run.METHOD_NAME = METHOD_NAME;oMethod_run.RUN_DATE = RUN_DATE;oMethod_run.RUN_HOUR = RUN_HOUR;oMethod_run.RUN_MINUTE = RUN_MINUTE;oMethod_run.RUN_SECOND = RUN_SECOND;oMethod_run.IS_CACHED = IS_CACHED;oMethod_run.EXECUTION_TIME = EXECUTION_TIME;oMethod_run.INPUT_PARAM = INPUT_PARAM;oMethod_run.ENTRY_USER_ID = ENTRY_USER_ID;oMethod_run.ENTRY_DATE = ENTRY_DATE;oMethod_run.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_METHOD_RUN", oMethod_run, "METHOD_RUN_ID");
return oMethod_run.METHOD_RUN_ID;
}
public Int32? Edit_Owner ( Int32? OWNER_ID, string CODE, string MAINTENANCE_DUE_DATE, string DESCRIPTION, string ENTRY_DATE)
{
Owner oOwner = new Owner();
oOwner.OWNER_ID = OWNER_ID;oOwner.CODE = CODE;oOwner.MAINTENANCE_DUE_DATE = MAINTENANCE_DUE_DATE;oOwner.DESCRIPTION = DESCRIPTION;oOwner.ENTRY_DATE = ENTRY_DATE;
ExecuteEdit("UPG_EDIT_OWNER", oOwner, "OWNER_ID");
return oOwner.OWNER_ID;
}
public Int32? Edit_Package ( Int32? PACKAGE_ID, string PACKAGE_NAME, Int32? PACKAGE_PRICE, Int32? CURRENCY_ID, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID, Int32? PACKAGE_SESSIONS_NB, string PACKAGE_TYPE, string PACKAGE_ENDING_DATE, string PACKAGE_TIMELINE, string PACKAGE_STARTING_DATE, Int32? PACKAGE_NB_OF_MONTH)
{
Package oPackage = new Package();
oPackage.PACKAGE_ID = PACKAGE_ID;oPackage.PACKAGE_NAME = PACKAGE_NAME;oPackage.PACKAGE_PRICE = PACKAGE_PRICE;oPackage.CURRENCY_ID = CURRENCY_ID;oPackage.ENTRY_USER_ID = ENTRY_USER_ID;oPackage.ENTRY_DATE = ENTRY_DATE;oPackage.OWNER_ID = OWNER_ID;oPackage.PACKAGE_SESSIONS_NB = PACKAGE_SESSIONS_NB;oPackage.PACKAGE_TYPE = PACKAGE_TYPE;oPackage.PACKAGE_ENDING_DATE = PACKAGE_ENDING_DATE;oPackage.PACKAGE_TIMELINE = PACKAGE_TIMELINE;oPackage.PACKAGE_STARTING_DATE = PACKAGE_STARTING_DATE;oPackage.PACKAGE_NB_OF_MONTH = PACKAGE_NB_OF_MONTH;
ExecuteEdit("UPG_EDIT_PACKAGE", oPackage, "PACKAGE_ID");
return oPackage.PACKAGE_ID;
}
public long? Edit_Person ( long? PERSON_ID, string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string BIRTH_DATE, bool? IS_BLOCKED, string DESCRIPTION, Int32? OWNER_ID, long? ENTRY_USER_ID, string ENTRY_DATE)
{
Person oPerson = new Person();
oPerson.PERSON_ID = PERSON_ID;oPerson.FIRST_NAME = FIRST_NAME;oPerson.LAST_NAME = LAST_NAME;oPerson.FATHER_NAME = FATHER_NAME;oPerson.MOTHER_NAME = MOTHER_NAME;oPerson.TITLE_CODE = TITLE_CODE;oPerson.GENDER_CODE = GENDER_CODE;oPerson.RELIGION_CODE = RELIGION_CODE;oPerson.BIRTH_DATE = BIRTH_DATE;oPerson.IS_BLOCKED = IS_BLOCKED;oPerson.DESCRIPTION = DESCRIPTION;oPerson.OWNER_ID = OWNER_ID;oPerson.ENTRY_USER_ID = ENTRY_USER_ID;oPerson.ENTRY_DATE = ENTRY_DATE;
ExecuteEdit("UPG_EDIT_PERSON", oPerson, "PERSON_ID");
return oPerson.PERSON_ID;
}
public Int32? Edit_Registered_staff_expense ( Int32? REGISTERED_STAFF_EXPENSE_ID, Int32? REGISTERED_STAFF_EXPENSE_DISCOUNT, Int32? REGISTERED_STAFF_EXPENSE_TOTAL_AMOUNT, string REGISTERED_STAFF_EXPENSE_DESCRIPTION, Int32? STAFF_ID, Int32? CURRENCY_ID, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Registered_staff_expense oRegistered_staff_expense = new Registered_staff_expense();
oRegistered_staff_expense.REGISTERED_STAFF_EXPENSE_ID = REGISTERED_STAFF_EXPENSE_ID;oRegistered_staff_expense.REGISTERED_STAFF_EXPENSE_DISCOUNT = REGISTERED_STAFF_EXPENSE_DISCOUNT;oRegistered_staff_expense.REGISTERED_STAFF_EXPENSE_TOTAL_AMOUNT = REGISTERED_STAFF_EXPENSE_TOTAL_AMOUNT;oRegistered_staff_expense.REGISTERED_STAFF_EXPENSE_DESCRIPTION = REGISTERED_STAFF_EXPENSE_DESCRIPTION;oRegistered_staff_expense.STAFF_ID = STAFF_ID;oRegistered_staff_expense.CURRENCY_ID = CURRENCY_ID;oRegistered_staff_expense.ENTRY_USER_ID = ENTRY_USER_ID;oRegistered_staff_expense.ENTRY_DATE = ENTRY_DATE;oRegistered_staff_expense.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_REGISTERED_STAFF_EXPENSE", oRegistered_staff_expense, "REGISTERED_STAFF_EXPENSE_ID");
return oRegistered_staff_expense.REGISTERED_STAFF_EXPENSE_ID;
}
public Int32? Edit_Registered_supplier_expense ( Int32? REGISTERED_SUPPLIER_EXPENSE_ID, Int32? REGISTERED_SUPPLIER_EXPENSE_DISCOUNT, Int32? REGISTERED_SUPPLIER_EXPENSE_TOTAL_AMOUNT, string REGISTERED_SUPPLIER_EXPENSE_DESCRIPTION, Int32? SUPPLIER_ID, Int32? CURRENCY_ID, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Registered_supplier_expense oRegistered_supplier_expense = new Registered_supplier_expense();
oRegistered_supplier_expense.REGISTERED_SUPPLIER_EXPENSE_ID = REGISTERED_SUPPLIER_EXPENSE_ID;oRegistered_supplier_expense.REGISTERED_SUPPLIER_EXPENSE_DISCOUNT = REGISTERED_SUPPLIER_EXPENSE_DISCOUNT;oRegistered_supplier_expense.REGISTERED_SUPPLIER_EXPENSE_TOTAL_AMOUNT = REGISTERED_SUPPLIER_EXPENSE_TOTAL_AMOUNT;oRegistered_supplier_expense.REGISTERED_SUPPLIER_EXPENSE_DESCRIPTION = REGISTERED_SUPPLIER_EXPENSE_DESCRIPTION;oRegistered_supplier_expense.SUPPLIER_ID = SUPPLIER_ID;oRegistered_supplier_expense.CURRENCY_ID = CURRENCY_ID;oRegistered_supplier_expense.ENTRY_USER_ID = ENTRY_USER_ID;oRegistered_supplier_expense.ENTRY_DATE = ENTRY_DATE;oRegistered_supplier_expense.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_REGISTERED_SUPPLIER_EXPENSE", oRegistered_supplier_expense, "REGISTERED_SUPPLIER_EXPENSE_ID");
return oRegistered_supplier_expense.REGISTERED_SUPPLIER_EXPENSE_ID;
}
public Int32? Edit_Registration ( Int32? REGISTRATION_ID, Int32? CLIENT_ID, string REGISTRATION_DATE, Int32? PACKAGE_ID, Int32? REGISTRATION_DISCOUNT, Int32? REGISTRATION_TOTAL_PRICE, Int32? CURRENCY_ID, string REGISTRATION_DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID)
{
Registration oRegistration = new Registration();
oRegistration.REGISTRATION_ID = REGISTRATION_ID;oRegistration.CLIENT_ID = CLIENT_ID;oRegistration.REGISTRATION_DATE = REGISTRATION_DATE;oRegistration.PACKAGE_ID = PACKAGE_ID;oRegistration.REGISTRATION_DISCOUNT = REGISTRATION_DISCOUNT;oRegistration.REGISTRATION_TOTAL_PRICE = REGISTRATION_TOTAL_PRICE;oRegistration.CURRENCY_ID = CURRENCY_ID;oRegistration.REGISTRATION_DESCRIPTION = REGISTRATION_DESCRIPTION;oRegistration.ENTRY_USER_ID = ENTRY_USER_ID;oRegistration.ENTRY_DATE = ENTRY_DATE;oRegistration.OWNER_ID = OWNER_ID;
ExecuteEdit("UPG_EDIT_REGISTRATION", oRegistration, "REGISTRATION_ID");
return oRegistration.REGISTRATION_ID;
}
public Int32? Edit_Session ( Int32? SESSION_ID, string SESSION_STARTING_DATE, string SESSION_ENDING_DATE, Int32? SESSION_ATTENDED, Int32? PACKAGE_ID, Int32? CLIENT_FEES_ID, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID, string DESCRIPTION)
{
Session oSession = new Session();
oSession.SESSION_ID = SESSION_ID;oSession.SESSION_STARTING_DATE = SESSION_STARTING_DATE;oSession.SESSION_ENDING_DATE = SESSION_ENDING_DATE;oSession.SESSION_ATTENDED = SESSION_ATTENDED;oSession.PACKAGE_ID = PACKAGE_ID;oSession.CLIENT_FEES_ID = CLIENT_FEES_ID;oSession.ENTRY_USER_ID = ENTRY_USER_ID;oSession.ENTRY_DATE = ENTRY_DATE;oSession.OWNER_ID = OWNER_ID;oSession.DESCRIPTION = DESCRIPTION;
ExecuteEdit("UPG_EDIT_SESSION", oSession, "SESSION_ID");
return oSession.SESSION_ID;
}
public Int32? Edit_Staff ( Int32? STAFF_ID, string STAFF_NAME, string STAFF_PH_NB, string STAFF_MAIL, string STAFF_DOB, Int32? BLOODTYPE_ID, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID, string STAFF_GENDER)
{
Staff oStaff = new Staff();
oStaff.STAFF_ID = STAFF_ID;oStaff.STAFF_NAME = STAFF_NAME;oStaff.STAFF_PH_NB = STAFF_PH_NB;oStaff.STAFF_MAIL = STAFF_MAIL;oStaff.STAFF_DOB = STAFF_DOB;oStaff.BLOODTYPE_ID = BLOODTYPE_ID;oStaff.ENTRY_USER_ID = ENTRY_USER_ID;oStaff.ENTRY_DATE = ENTRY_DATE;oStaff.OWNER_ID = OWNER_ID;oStaff.STAFF_GENDER = STAFF_GENDER;
ExecuteEdit("UPG_EDIT_STAFF", oStaff, "STAFF_ID");
return oStaff.STAFF_ID;
}
public Int32? Edit_Staff_fees ( Int32? STAFF_FEES_ID, Int32? STAFF_ID, string STAFF_FEES_DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID, Int32? CURRENCY_ID, Int32? STAFF_FEES_AMOUNT, Int32? REGISTERED_STAFF_EXPENSE_ID)
{
Staff_fees oStaff_fees = new Staff_fees();
oStaff_fees.STAFF_FEES_ID = STAFF_FEES_ID;oStaff_fees.STAFF_ID = STAFF_ID;oStaff_fees.STAFF_FEES_DESCRIPTION = STAFF_FEES_DESCRIPTION;oStaff_fees.ENTRY_USER_ID = ENTRY_USER_ID;oStaff_fees.ENTRY_DATE = ENTRY_DATE;oStaff_fees.OWNER_ID = OWNER_ID;oStaff_fees.CURRENCY_ID = CURRENCY_ID;oStaff_fees.STAFF_FEES_AMOUNT = STAFF_FEES_AMOUNT;oStaff_fees.REGISTERED_STAFF_EXPENSE_ID = REGISTERED_STAFF_EXPENSE_ID;
ExecuteEdit("UPG_EDIT_STAFF_FEES", oStaff_fees, "STAFF_FEES_ID");
return oStaff_fees.STAFF_FEES_ID;
}
public Int32? Edit_Supplier ( Int32? SUPPLIER_ID, string SUPPLIER_NAME, string SUPPLIER_PH_NB, string SUPPLIER_MAIL, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID, string SUPPLIER_DOB, Int32? BLOODTYPE_ID, string SUPPLIER_GENDER)
{
Supplier oSupplier = new Supplier();
oSupplier.SUPPLIER_ID = SUPPLIER_ID;oSupplier.SUPPLIER_NAME = SUPPLIER_NAME;oSupplier.SUPPLIER_PH_NB = SUPPLIER_PH_NB;oSupplier.SUPPLIER_MAIL = SUPPLIER_MAIL;oSupplier.ENTRY_USER_ID = ENTRY_USER_ID;oSupplier.ENTRY_DATE = ENTRY_DATE;oSupplier.OWNER_ID = OWNER_ID;oSupplier.SUPPLIER_DOB = SUPPLIER_DOB;oSupplier.BLOODTYPE_ID = BLOODTYPE_ID;oSupplier.SUPPLIER_GENDER = SUPPLIER_GENDER;
ExecuteEdit("UPG_EDIT_SUPPLIER", oSupplier, "SUPPLIER_ID");
return oSupplier.SUPPLIER_ID;
}
public Int32? Edit_Supplier_fees ( Int32? SUPPLIER_FEES_ID, Int32? SUPPLIER_ID, string SUPPLIER_FEES_DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID, Int32? CURRENCY_ID, Int32? SUPPLIER_FEES_AMOUNT, Int32? REGISTERED_SUPPLIER_EXPENSE_ID)
{
Supplier_fees oSupplier_fees = new Supplier_fees();
oSupplier_fees.SUPPLIER_FEES_ID = SUPPLIER_FEES_ID;oSupplier_fees.SUPPLIER_ID = SUPPLIER_ID;oSupplier_fees.SUPPLIER_FEES_DESCRIPTION = SUPPLIER_FEES_DESCRIPTION;oSupplier_fees.ENTRY_USER_ID = ENTRY_USER_ID;oSupplier_fees.ENTRY_DATE = ENTRY_DATE;oSupplier_fees.OWNER_ID = OWNER_ID;oSupplier_fees.CURRENCY_ID = CURRENCY_ID;oSupplier_fees.SUPPLIER_FEES_AMOUNT = SUPPLIER_FEES_AMOUNT;oSupplier_fees.REGISTERED_SUPPLIER_EXPENSE_ID = REGISTERED_SUPPLIER_EXPENSE_ID;
ExecuteEdit("UPG_EDIT_SUPPLIER_FEES", oSupplier_fees, "SUPPLIER_FEES_ID");
return oSupplier_fees.SUPPLIER_FEES_ID;
}
public long? Edit_User ( long? USER_ID, Int32? OWNER_ID, string USERNAME, string PASSWORD, string USER_TYPE_CODE, bool? IS_ACTIVE, string ENTRY_DATE, string USER_EMAIL)
{
User oUser = new User();
oUser.USER_ID = USER_ID;oUser.OWNER_ID = OWNER_ID;oUser.USERNAME = USERNAME;oUser.PASSWORD = PASSWORD;oUser.USER_TYPE_CODE = USER_TYPE_CODE;oUser.IS_ACTIVE = IS_ACTIVE;oUser.ENTRY_DATE = ENTRY_DATE;oUser.USER_EMAIL = USER_EMAIL;
ExecuteEdit("UPG_EDIT_USER", oUser, "USER_ID");
return oUser.USER_ID;
}
public List<dynamic> CalculateStaffBalance ( Int32? STAFF_ID,ref  Int32? BALANCE, long? OWNER_ID, Int32? CURRENCY_ID)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.STAFF_ID = STAFF_ID; p.BALANCE = BALANCE; p.OWNER_ID = OWNER_ID; p.CURRENCY_ID = CURRENCY_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("CalculateStaffBalance", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
oList.Add(o);
}
}
BALANCE = p.BALANCE;
return oList;
}
public List<dynamic> CalculateSupplierBalance ( Int32? SUPPLIER_ID,ref  Int32? BALANCE, long? OWNER_ID, Int32? CURRENCY_ID)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.SUPPLIER_ID = SUPPLIER_ID; p.BALANCE = BALANCE; p.OWNER_ID = OWNER_ID; p.CURRENCY_ID = CURRENCY_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("CalculateSupplierBalance", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
oList.Add(o);
}
}
BALANCE = p.BALANCE;
return oList;
}
public List<dynamic> CheckClientPaymentStatus ( Int32? CLIENT_ID,ref  Int32? BALANCE, long? OWNER_ID, Int32? CURRENCY_ID)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.CLIENT_ID = CLIENT_ID; p.BALANCE = BALANCE; p.OWNER_ID = OWNER_ID; p.CURRENCY_ID = CURRENCY_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("CheckClientPaymentStatus", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
oList.Add(o);
}
}
BALANCE = p.BALANCE;
return oList;
}
public List<dynamic> CheckIfUserExists ( string Username, string UserEmail)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.Username = Username; p.UserEmail = UserEmail;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("CheckIfUserExists", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.Message = GV<String>(X["Message"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> EXPENSES_SUM ( long? OWNER_ID, Int32? CURRENCY_ID,ref  Int32? SUM)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID; p.CURRENCY_ID = CURRENCY_ID; p.SUM = SUM;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("EXPENSES_SUM", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
oList.Add(o);
}
}
SUM = p.SUM;
return oList;
}
public List<dynamic> GET_DISTINCT_SETUP_TBL ( Int32? OWNER_ID)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("GET_DISTINCT_SETUP_TBL", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.TBL_NAME = GV<String>(X["TBL_NAME"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> GET_NEXT_VALUE ( string STARTER_CODE)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.STARTER_CODE = STARTER_CODE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("GET_NEXT_VALUE", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.LAST_VALUE = GV<Int64>(X["LAST_VALUE"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> GET_TBL_SETUP ()
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
IEnumerable<IDataRecord> R = ExecuteSelectQuery("GET_TBL_SETUP", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.TBL_NAME = GV<String>(X["TBL_NAME"]);o.CODE_NAME = GV<String>(X["CODE_NAME"]);o.ISSYSTEM = GV<Boolean>(X["ISSYSTEM"]);o.ISDELETEABLE = GV<Boolean>(X["ISDELETEABLE"]);o.ISUPDATEABLE = GV<Boolean>(X["ISUPDATEABLE"]);o.ISDELETED = GV<Boolean>(X["ISDELETED"]);o.ISVISIBLE = GV<Boolean>(X["ISVISIBLE"]);o.DISPLAY_ORDER = GV<Int32>(X["DISPLAY_ORDER"]);o.CODE_VALUE_EN = GV<String>(X["CODE_VALUE_EN"]);o.CODE_VALUE_FR = GV<String>(X["CODE_VALUE_FR"]);o.CODE_VALUE_AR = GV<String>(X["CODE_VALUE_AR"]);o.NOTES = GV<String>(X["NOTES"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> GETGRANDPROFIT ( long? OWNER_ID, Int32? CURRENCY_ID, Int32? SUM__POS, Int32? SUM__NEG,ref  Int32? SUM)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID; p.CURRENCY_ID = CURRENCY_ID; p.SUM__POS = SUM__POS; p.SUM__NEG = SUM__NEG; p.SUM = SUM;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("GETGRANDPROFIT", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
oList.Add(o);
}
}
SUM = p.SUM;
return oList;
}
public List<dynamic> LoginFct ( Int32? OWNER_ID, string USERNAME, string PASSWORD,ref  Int32? RESULT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID; p.USERNAME = USERNAME; p.PASSWORD = PASSWORD; p.RESULT = RESULT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("LoginFct", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
oList.Add(o);
}
}
RESULT = p.RESULT;
return oList;
}
public List<dynamic> SALES_SUM ( long? OWNER_ID, Int32? CURRENCY_ID,ref  Int32? SUM)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID; p.CURRENCY_ID = CURRENCY_ID; p.SUM = SUM;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("SALES_SUM", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
oList.Add(o);
}
}
SUM = p.SUM;
return oList;
}
public List<dynamic> UP_BULK_UPSERT_ADDRESS ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_ADDRESS", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.ADDRESS_ID = GV<Int64>(X["ADDRESS_ID"]);o.PERSON_ID = GV<Int64>(X["PERSON_ID"]);o.ADDRESS_TYPE_CODE = GV<String>(X["ADDRESS_TYPE_CODE"]);o.LOC_L1_ID = GV<Int64>(X["LOC_L1_ID"]);o.LOC_L2_ID = GV<Int64>(X["LOC_L2_ID"]);o.LOC_L3_ID = GV<Int64>(X["LOC_L3_ID"]);o.LOC_L4_ID = GV<Int64>(X["LOC_L4_ID"]);o.STREET = GV<String>(X["STREET"]);o.BUILDING = GV<String>(X["BUILDING"]);o.FLOOR = GV<String>(X["FLOOR"]);o.POBOX = GV<String>(X["POBOX"]);o.VALID_DATE_START = GV<String>(X["VALID_DATE_START"]);o.VALID_DATE_END = GV<String>(X["VALID_DATE_END"]);o.NOTES = GV<String>(X["NOTES"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_BLOODTYPE ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_BLOODTYPE", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.BLOODTYPE_ID = GV<Int32>(X["BLOODTYPE_ID"]);o.BLOODTYPE_SYMBOL = GV<String>(X["BLOODTYPE_SYMBOL"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_CLIENT ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_CLIENT", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.CLIENT_ID = GV<Int32>(X["CLIENT_ID"]);o.CLIENT_NAME = GV<String>(X["CLIENT_NAME"]);o.CLIENT_PH_NB = GV<String>(X["CLIENT_PH_NB"]);o.CLIENT_MAIL = GV<String>(X["CLIENT_MAIL"]);o.CLIENT_DOB = GV<String>(X["CLIENT_DOB"]);o.BLOODTYPE_ID = GV<Int32>(X["BLOODTYPE_ID"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.CLIENT_GENDER = GV<String>(X["CLIENT_GENDER"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_CLIENT_FEES ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_CLIENT_FEES", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.CLIENT_FEES_ID = GV<Int32>(X["CLIENT_FEES_ID"]);o.CLIENT_ID = GV<Int32>(X["CLIENT_ID"]);o.CLIENT_FEES_DESCRIPTION = GV<String>(X["CLIENT_FEES_DESCRIPTION"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.CURRENCY_ID = GV<Int32>(X["CURRENCY_ID"]);o.PACKAGE_ID = GV<Int32>(X["PACKAGE_ID"]);o.CLIENT_FEES_AMOUNT = GV<Int32>(X["CLIENT_FEES_AMOUNT"]);o.REGISTRATION_ID = GV<Int32>(X["REGISTRATION_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_CONTACT ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_CONTACT", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.CONTACT_ID = GV<Int32>(X["CONTACT_ID"]);o.PERSON_ID = GV<Int64>(X["PERSON_ID"]);o.CONTACT_TYPE_CODE = GV<String>(X["CONTACT_TYPE_CODE"]);o.CONTACT = GV<String>(X["CONTACT"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_CURRENCY ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_CURRENCY", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.CURRENCY_ID = GV<Int32>(X["CURRENCY_ID"]);o.CURRENCY_TYPE = GV<String>(X["CURRENCY_TYPE"]);o.CURRENCY_SYMBOL = GV<String>(X["CURRENCY_SYMBOL"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_FEES ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_FEES", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.FEES_ID = GV<Int32>(X["FEES_ID"]);o.FEES_DESCRIPTION = GV<String>(X["FEES_DESCRIPTION"]);o.FEES_AMOUNT = GV<Int32>(X["FEES_AMOUNT"]);o.CURRENCY_ID = GV<Int32>(X["CURRENCY_ID"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.FEES_ORIGIN_DATE = GV<String>(X["FEES_ORIGIN_DATE"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_LOC_L1 ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_LOC_L1", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.LOC_L1_ID = GV<Int64>(X["LOC_L1_ID"]);o.CODE = GV<String>(X["CODE"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.NOTES = GV<String>(X["NOTES"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_LOC_L2 ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_LOC_L2", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.LOC_L2_ID = GV<Int64>(X["LOC_L2_ID"]);o.CODE = GV<String>(X["CODE"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.LOC_L1_ID = GV<Int64>(X["LOC_L1_ID"]);o.NOTES = GV<String>(X["NOTES"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_LOC_L3 ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_LOC_L3", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.LOC_L3_ID = GV<Int64>(X["LOC_L3_ID"]);o.CODE = GV<String>(X["CODE"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.LOC_L2_ID = GV<Int64>(X["LOC_L2_ID"]);o.NOTES = GV<String>(X["NOTES"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_LOC_L4 ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_LOC_L4", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.LOC_L4_ID = GV<Int64>(X["LOC_L4_ID"]);o.CODE = GV<String>(X["CODE"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.LOC_L3_ID = GV<Int64>(X["LOC_L3_ID"]);o.NOTES = GV<String>(X["NOTES"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_METHOD_RUN ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_METHOD_RUN", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.METHOD_RUN_ID = GV<Int64>(X["METHOD_RUN_ID"]);o.METHOD_NAME = GV<String>(X["METHOD_NAME"]);o.RUN_DATE = GV<String>(X["RUN_DATE"]);o.RUN_HOUR = GV<Int32>(X["RUN_HOUR"]);o.RUN_MINUTE = GV<Int32>(X["RUN_MINUTE"]);o.RUN_SECOND = GV<Int32>(X["RUN_SECOND"]);o.IS_CACHED = GV<Boolean>(X["IS_CACHED"]);o.EXECUTION_TIME = GV<Int32>(X["EXECUTION_TIME"]);o.INPUT_PARAM = GV<String>(X["INPUT_PARAM"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_OWNER ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_OWNER", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.CODE = GV<String>(X["CODE"]);o.MAINTENANCE_DUE_DATE = GV<String>(X["MAINTENANCE_DUE_DATE"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_PACKAGE ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_PACKAGE", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.PACKAGE_ID = GV<Int32>(X["PACKAGE_ID"]);o.PACKAGE_NAME = GV<String>(X["PACKAGE_NAME"]);o.PACKAGE_PRICE = GV<Int32>(X["PACKAGE_PRICE"]);o.CURRENCY_ID = GV<Int32>(X["CURRENCY_ID"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.PACKAGE_SESSIONS_NB = GV<Int32>(X["PACKAGE_SESSIONS_NB"]);o.PACKAGE_TYPE = GV<String>(X["PACKAGE_TYPE"]);o.PACKAGE_ENDING_DATE = GV<String>(X["PACKAGE_ENDING_DATE"]);o.PACKAGE_TIMELINE = GV<String>(X["PACKAGE_TIMELINE"]);o.PACKAGE_STARTING_DATE = GV<String>(X["PACKAGE_STARTING_DATE"]);o.PACKAGE_NB_OF_MONTH = GV<Int32>(X["PACKAGE_NB_OF_MONTH"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_PERSON ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_PERSON", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.PERSON_ID = GV<Int64>(X["PERSON_ID"]);o.FIRST_NAME = GV<String>(X["FIRST_NAME"]);o.LAST_NAME = GV<String>(X["LAST_NAME"]);o.FATHER_NAME = GV<String>(X["FATHER_NAME"]);o.MOTHER_NAME = GV<String>(X["MOTHER_NAME"]);o.TITLE_CODE = GV<String>(X["TITLE_CODE"]);o.GENDER_CODE = GV<String>(X["GENDER_CODE"]);o.RELIGION_CODE = GV<String>(X["RELIGION_CODE"]);o.BIRTH_DATE = GV<String>(X["BIRTH_DATE"]);o.IS_BLOCKED = GV<Boolean>(X["IS_BLOCKED"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_REGISTERED_EXPENSE ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_REGISTERED_EXPENSE", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.REGISTERED_EXPENSE_ID = GV<Int32>(X["REGISTERED_EXPENSE_ID"]);o.SUPPLIER_ID = GV<Int32>(X["SUPPLIER_ID"]);o.STAFF_ID = GV<Int32>(X["STAFF_ID"]);o.REGISTERED_EXPENSE_DISCOUNT = GV<Int32>(X["REGISTERED_EXPENSE_DISCOUNT"]);o.REGISTERED_EXPENSE_TOTALPRICE = GV<Int32>(X["REGISTERED_EXPENSE_TOTALPRICE"]);o.CURRENCY_ID = GV<Int32>(X["CURRENCY_ID"]);o.REGISTERED_EXPENSE_DESCRIPTION = GV<String>(X["REGISTERED_EXPENSE_DESCRIPTION"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_REGISTRATION ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_REGISTRATION", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.REGISTRATION_ID = GV<Int32>(X["REGISTRATION_ID"]);o.CLIENT_ID = GV<Int32>(X["CLIENT_ID"]);o.REGISTRATION_DATE = GV<String>(X["REGISTRATION_DATE"]);o.PACKAGE_ID = GV<Int32>(X["PACKAGE_ID"]);o.REGISTRATION_DISCOUNT = GV<Int32>(X["REGISTRATION_DISCOUNT"]);o.REGISTRATION_TOTAL_PRICE = GV<Int32>(X["REGISTRATION_TOTAL_PRICE"]);o.CURRENCY_ID = GV<Int32>(X["CURRENCY_ID"]);o.REGISTRATION_DESCRIPTION = GV<String>(X["REGISTRATION_DESCRIPTION"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_SESSION ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_SESSION", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.SESSION_ID = GV<Int32>(X["SESSION_ID"]);o.SESSION_STARTING_DATE = GV<String>(X["SESSION_STARTING_DATE"]);o.SESSION_ENDING_DATE = GV<String>(X["SESSION_ENDING_DATE"]);o.SESSION_ATTENDED = GV<Int32>(X["SESSION_ATTENDED"]);o.PACKAGE_ID = GV<Int32>(X["PACKAGE_ID"]);o.CLIENT_FEES_ID = GV<Int32>(X["CLIENT_FEES_ID"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.DESCRIPTION = GV<String>(X["DESCRIPTION"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_STAFF ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_STAFF", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.STAFF_ID = GV<Int32>(X["STAFF_ID"]);o.STAFF_NAME = GV<String>(X["STAFF_NAME"]);o.STAFF_PH_NB = GV<String>(X["STAFF_PH_NB"]);o.STAFF_MAIL = GV<String>(X["STAFF_MAIL"]);o.STAFF_DOB = GV<String>(X["STAFF_DOB"]);o.BLOODTYPE_ID = GV<Int32>(X["BLOODTYPE_ID"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.STAFF_GENDER = GV<String>(X["STAFF_GENDER"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_STAFF_FEES ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_STAFF_FEES", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.STAFF_FEES_ID = GV<Int32>(X["STAFF_FEES_ID"]);o.STAFF_ID = GV<Int32>(X["STAFF_ID"]);o.STAFF_FEES_DESCRIPTION = GV<String>(X["STAFF_FEES_DESCRIPTION"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.CURRENCY_ID = GV<Int32>(X["CURRENCY_ID"]);o.STAFF_FEES_AMOUNT = GV<Int32>(X["STAFF_FEES_AMOUNT"]);o.REGISTERED_EXPENSE = GV<Int32>(X["REGISTERED_EXPENSE"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_SUPPLIER ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_SUPPLIER", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.SUPPLIER_ID = GV<Int32>(X["SUPPLIER_ID"]);o.SUPPLIER_NAME = GV<String>(X["SUPPLIER_NAME"]);o.SUPPLIER_PH_NB = GV<String>(X["SUPPLIER_PH_NB"]);o.SUPPLIER_MAIL = GV<String>(X["SUPPLIER_MAIL"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.SUPPLIER_DOB = GV<String>(X["SUPPLIER_DOB"]);o.BLOODTYPE_ID = GV<Int32>(X["BLOODTYPE_ID"]);o.SUPPLIER_GENDER = GV<String>(X["SUPPLIER_GENDER"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_SUPPLIER_FEES ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_SUPPLIER_FEES", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.SUPPLIER_FEES_ID = GV<Int32>(X["SUPPLIER_FEES_ID"]);o.SUPPLIER_ID = GV<Int32>(X["SUPPLIER_ID"]);o.SUPPLIER_FEES_DESCRIPTION = GV<String>(X["SUPPLIER_FEES_DESCRIPTION"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.CURRENCY_ID = GV<Int32>(X["CURRENCY_ID"]);o.SUPPLIER_FEES_AMOUNT = GV<Int32>(X["SUPPLIER_FEES_AMOUNT"]);o.REGISTERED_EXPENSE = GV<Int32>(X["REGISTERED_EXPENSE"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_BULK_UPSERT_USER ( string JSON_CONTENT)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.JSON_CONTENT = JSON_CONTENT;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_BULK_UPSERT_USER", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.USER_ID = GV<Int64>(X["USER_ID"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.USERNAME = GV<String>(X["USERNAME"]);o.PASSWORD = GV<String>(X["PASSWORD"]);o.USER_TYPE_CODE = GV<String>(X["USER_TYPE_CODE"]);o.IS_ACTIVE = GV<Boolean>(X["IS_ACTIVE"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.USER_EMAIL = GV<String>(X["USER_EMAIL"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_CHECK_USER_EXISTENCE ( Int32? OWNER_ID, string USERNAME,ref  bool? EXISTS)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID; p.USERNAME = USERNAME; p.EXISTS = EXISTS;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_CHECK_USER_EXISTENCE", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
oList.Add(o);
}
}
EXISTS = p.EXISTS;
return oList;
}
public List<dynamic> UP_EDIT_SETUP ( Int32? OWNER_ID, string TBL_NAME, string CODE_NAME, bool? ISSYSTEM, bool? ISDELETEABLE, bool? ISUPDATEABLE, bool? ISVISIBLE, bool? ISDELETED, Int32? DISPLAY_ORDER, string CODE_VALUE_EN, string CODE_VALUE_FR, string CODE_VALUE_AR, string ENTRY_DATE, long? ENTRY_USER_ID, string NOTES)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID; p.TBL_NAME = TBL_NAME; p.CODE_NAME = CODE_NAME; p.ISSYSTEM = ISSYSTEM; p.ISDELETEABLE = ISDELETEABLE; p.ISUPDATEABLE = ISUPDATEABLE; p.ISVISIBLE = ISVISIBLE; p.ISDELETED = ISDELETED; p.DISPLAY_ORDER = DISPLAY_ORDER; p.CODE_VALUE_EN = CODE_VALUE_EN; p.CODE_VALUE_FR = CODE_VALUE_FR; p.CODE_VALUE_AR = CODE_VALUE_AR; p.ENTRY_DATE = ENTRY_DATE; p.ENTRY_USER_ID = ENTRY_USER_ID; p.NOTES = NOTES;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_EDIT_SETUP", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_EXTRACT_ROUTINE_PARAMETERS ( string ROUTINE_NAME)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.ROUTINE_NAME = ROUTINE_NAME;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_EXTRACT_ROUTINE_PARAMETERS", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.ROUTINE_NAME = GV<String>(X["ROUTINE_NAME"]);o.PARAM_NAME = GV<String>(X["PARAM_NAME"]);o.PARAM_TYPE = GV<String>(X["PARAM_TYPE"]);o.IS_OUTPUT = GV<Boolean>(X["IS_OUTPUT"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_EXTRACT_ROUTINE_RESULT_SCHEMA ( string ROUTINE_NAME)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.ROUTINE_NAME = ROUTINE_NAME;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_EXTRACT_ROUTINE_RESULT_SCHEMA", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.ROUTINE_NAME = GV<String>(X["ROUTINE_NAME"]);o.COLUMN_NAME = GV<String>(X["COLUMN_NAME"]);o.COLUMN_TYPE = GV<String>(X["COLUMN_TYPE"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_GENERATE_INSERT_STATEMENTS ( string @tableName)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.@tableName = @tableName;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GENERATE_INSERT_STATEMENTS", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_GET_NEXT_VALUE ( string STARTER_CODE,ref  long? VALUE)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.STARTER_CODE = STARTER_CODE; p.VALUE = VALUE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GET_NEXT_VALUE", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
oList.Add(o);
}
}
VALUE = p.VALUE;
return oList;
}
public List<dynamic> UP_GET_SETUP_ENTRIES ( Int32? OWNER_ID, string TBL_NAME, bool? ISDELETED, bool? ISVISIBLE)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID; p.TBL_NAME = TBL_NAME; p.ISDELETED = ISDELETED; p.ISVISIBLE = ISVISIBLE;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GET_SETUP_ENTRIES", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.TBL_NAME = GV<String>(X["TBL_NAME"]);o.CODE_NAME = GV<String>(X["CODE_NAME"]);o.ISSYSTEM = GV<Boolean>(X["ISSYSTEM"]);o.ISDELETEABLE = GV<Boolean>(X["ISDELETEABLE"]);o.ISUPDATEABLE = GV<Boolean>(X["ISUPDATEABLE"]);o.DISPLAY_ORDER = GV<Int32>(X["DISPLAY_ORDER"]);o.ISVISIBLE = GV<Boolean>(X["ISVISIBLE"]);o.ISDELETED = GV<Boolean>(X["ISDELETED"]);o.CODE_VALUE_EN = GV<String>(X["CODE_VALUE_EN"]);o.CODE_VALUE_FR = GV<String>(X["CODE_VALUE_FR"]);o.CODE_VALUE_AR = GV<String>(X["CODE_VALUE_AR"]);o.NOTES = GV<String>(X["NOTES"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_GET_SETUP_ENTRY ( Int32? OWNER_ID, string TBL_NAME, string CODE_NAME)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID; p.TBL_NAME = TBL_NAME; p.CODE_NAME = CODE_NAME;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GET_SETUP_ENTRY", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.TBL_NAME = GV<String>(X["TBL_NAME"]);o.CODE_NAME = GV<String>(X["CODE_NAME"]);o.ISSYSTEM = GV<Boolean>(X["ISSYSTEM"]);o.ISDELETEABLE = GV<Boolean>(X["ISDELETEABLE"]);o.ISUPDATEABLE = GV<Boolean>(X["ISUPDATEABLE"]);o.DISPLAY_ORDER = GV<Int32>(X["DISPLAY_ORDER"]);o.ISVISIBLE = GV<Boolean>(X["ISVISIBLE"]);o.ISDELETED = GV<Boolean>(X["ISDELETED"]);o.CODE_VALUE_EN = GV<String>(X["CODE_VALUE_EN"]);o.CODE_VALUE_FR = GV<String>(X["CODE_VALUE_FR"]);o.CODE_VALUE_AR = GV<String>(X["CODE_VALUE_AR"]);o.NOTES = GV<String>(X["NOTES"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);o.ENTRY_USER_ID = GV<Int64>(X["ENTRY_USER_ID"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UP_GET_USER_BY_CREDENTIALS ( Int32? OWNER_ID, string USERNAME, string PASSWORD)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.OWNER_ID = OWNER_ID; p.USERNAME = USERNAME; p.PASSWORD = PASSWORD;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UP_GET_USER_BY_CREDENTIALS", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.USER_ID = GV<Int64>(X["USER_ID"]);o.OWNER_ID = GV<Int32>(X["OWNER_ID"]);o.USERNAME = GV<String>(X["USERNAME"]);o.PASSWORD = GV<String>(X["PASSWORD"]);o.ENTRY_DATE = GV<String>(X["ENTRY_DATE"]);
oList.Add(o);
}
}
return oList;
}
public List<dynamic> UpdatePassword ( long? owner_id, string username, string updated_password)
{
List<dynamic> oList = new List<dynamic>();
dynamic p = new ExpandoObject();
p.owner_id = owner_id; p.username = username; p.updated_password = updated_password;
IEnumerable<IDataRecord> R = ExecuteSelectQuery("UpdatePassword", p);
if (R != null) {foreach (var X in R) {
dynamic o = new ExpandoObject();
o.Result = GV<String>(X["Result"]);
oList.Add(o);
}
}
return oList;
}
}
}
