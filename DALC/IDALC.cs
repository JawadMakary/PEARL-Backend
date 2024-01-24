using System;
using System.Collections.Generic;
namespace DALC
{
#region Entities
public partial class Address
{
public long? ADDRESS_ID {get;set;}
public long? PERSON_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
public long? LOC_L1_ID {get;set;}
public long? LOC_L2_ID {get;set;}
public long? LOC_L3_ID {get;set;}
public long? LOC_L4_ID {get;set;}
public string STREET {get;set;}
public string BUILDING {get;set;}
public string FLOOR {get;set;}
public string POBOX {get;set;}
public string VALID_DATE_START {get;set;}
public string VALID_DATE_END {get;set;}
public string NOTES {get;set;}
public string ENTRY_DATE {get;set;}
public long? ENTRY_USER_ID {get;set;}
public Int32? OWNER_ID {get;set;}
public Person My_Person {get;set;}
public Loc_l1 My_Loc_l1 {get;set;}
public Loc_l2 My_Loc_l2 {get;set;}
public Loc_l3 My_Loc_l3 {get;set;}
public Loc_l4 My_Loc_l4 {get;set;}
}
public partial class Bloodtype
{
public Int32? BLOODTYPE_ID {get;set;}
public string BLOODTYPE_SYMBOL {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
}
public partial class Client
{
public Int32? CLIENT_ID {get;set;}
public string CLIENT_NAME {get;set;}
public string CLIENT_PH_NB {get;set;}
public string CLIENT_MAIL {get;set;}
public string CLIENT_DOB {get;set;}
public Int32? BLOODTYPE_ID {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
public string CLIENT_GENDER {get;set;}
public Bloodtype My_Bloodtype {get;set;}
}
public partial class Client_fees
{
public Int32? CLIENT_FEES_ID {get;set;}
public Int32? CLIENT_ID {get;set;}
public string CLIENT_FEES_DESCRIPTION {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
public Int32? CURRENCY_ID {get;set;}
public Int32? PACKAGE_ID {get;set;}
public Int32? CLIENT_FEES_AMOUNT {get;set;}
public Int32? REGISTRATION_ID {get;set;}
public Client My_Client {get;set;}
public Currency My_Currency {get;set;}
public Package My_Package {get;set;}
public Registration My_Registration {get;set;}
}
public partial class Contact
{
public Int32? CONTACT_ID {get;set;}
public long? PERSON_ID {get;set;}
public string CONTACT_TYPE_CODE {get;set;}
public string CONTACT {get;set;}
public string DESCRIPTION {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
public Person My_Person {get;set;}
}
public partial class Currency
{
public Int32? CURRENCY_ID {get;set;}
public string CURRENCY_TYPE {get;set;}
public string CURRENCY_SYMBOL {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
}
public partial class Fees
{
public Int32? FEES_ID {get;set;}
public string FEES_DESCRIPTION {get;set;}
public Int32? FEES_AMOUNT {get;set;}
public Int32? CURRENCY_ID {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
public string FEES_ORIGIN_DATE {get;set;}
public Currency My_Currency {get;set;}
}
public partial class Loc_l1
{
public long? LOC_L1_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public string NOTES {get;set;}
public string ENTRY_DATE {get;set;}
public long? ENTRY_USER_ID {get;set;}
public Int32? OWNER_ID {get;set;}
}
public partial class Loc_l2
{
public long? LOC_L2_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? LOC_L1_ID {get;set;}
public string NOTES {get;set;}
public string ENTRY_DATE {get;set;}
public long? ENTRY_USER_ID {get;set;}
public Int32? OWNER_ID {get;set;}
public Loc_l1 My_Loc_l1 {get;set;}
}
public partial class Loc_l3
{
public long? LOC_L3_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? LOC_L2_ID {get;set;}
public string NOTES {get;set;}
public string ENTRY_DATE {get;set;}
public long? ENTRY_USER_ID {get;set;}
public Int32? OWNER_ID {get;set;}
public Loc_l2 My_Loc_l2 {get;set;}
}
public partial class Loc_l4
{
public long? LOC_L4_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? LOC_L3_ID {get;set;}
public string NOTES {get;set;}
public string ENTRY_DATE {get;set;}
public long? ENTRY_USER_ID {get;set;}
public Int32? OWNER_ID {get;set;}
public Loc_l3 My_Loc_l3 {get;set;}
}
public partial class Method_run
{
public long? METHOD_RUN_ID {get;set;}
public string METHOD_NAME {get;set;}
public string RUN_DATE {get;set;}
public Int32? RUN_HOUR {get;set;}
public Int32? RUN_MINUTE {get;set;}
public Int32? RUN_SECOND {get;set;}
public bool? IS_CACHED {get;set;}
public Int32? EXECUTION_TIME {get;set;}
public string INPUT_PARAM {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
}
public partial class Owner
{
public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string MAINTENANCE_DUE_DATE {get;set;}
public string DESCRIPTION {get;set;}
public string ENTRY_DATE {get;set;}
}
public partial class Package
{
public Int32? PACKAGE_ID {get;set;}
public string PACKAGE_NAME {get;set;}
public Int32? PACKAGE_PRICE {get;set;}
public Int32? CURRENCY_ID {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
public Int32? PACKAGE_SESSIONS_NB {get;set;}
public string PACKAGE_TYPE {get;set;}
public string PACKAGE_ENDING_DATE {get;set;}
public string PACKAGE_TIMELINE {get;set;}
public string PACKAGE_STARTING_DATE {get;set;}
public Currency My_Currency {get;set;}
}
public partial class Person
{
public long? PERSON_ID {get;set;}
public string FIRST_NAME {get;set;}
public string LAST_NAME {get;set;}
public string FATHER_NAME {get;set;}
public string MOTHER_NAME {get;set;}
public string TITLE_CODE {get;set;}
public string GENDER_CODE {get;set;}
public string RELIGION_CODE {get;set;}
public string BIRTH_DATE {get;set;}
public bool? IS_BLOCKED {get;set;}
public string DESCRIPTION {get;set;}
public Int32? OWNER_ID {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
}
public partial class Registration
{
public Int32? REGISTRATION_ID {get;set;}
public Int32? CLIENT_ID {get;set;}
public string REGISTRATION_DATE {get;set;}
public Int32? PACKAGE_ID {get;set;}
public Int32? REGISTRATION_DISCOUNT {get;set;}
public Int32? REGISTRATION_TOTAL_PRICE {get;set;}
public Int32? CURRENCY_ID {get;set;}
public string REGISTRATION_DESCRIPTION {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
public Client My_Client {get;set;}
public Package My_Package {get;set;}
public Currency My_Currency {get;set;}
}
public partial class Session
{
public Int32? SESSION_ID {get;set;}
public string SESSION_STARTING_DATE {get;set;}
public string SESSION_ENDING_DATE {get;set;}
public Int32? SESSION_ATTENDED {get;set;}
public Int32? PACKAGE_ID {get;set;}
public Int32? CLIENT_FEES_ID {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
public string DESCRIPTION {get;set;}
public Package My_Package {get;set;}
public Client_fees My_Client_fees {get;set;}
}
public partial class Staff
{
public Int32? STAFF_ID {get;set;}
public string STAFF_NAME {get;set;}
public string STAFF_PH_NB {get;set;}
public string STAFF_MAIL {get;set;}
public string STAFF_DOB {get;set;}
public Int32? BLOODTYPE_ID {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
public string STAFF_GENDER {get;set;}
public Bloodtype My_Bloodtype {get;set;}
}
public partial class Staff_fees
{
public Int32? STAFF_FEES_ID {get;set;}
public Int32? STAFF_ID {get;set;}
public string STAFF_FEES_DESCRIPTION {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
public Int32? CURRENCY_ID {get;set;}
public Int32? STAFF_FEES_AMOUNT {get;set;}
public Staff My_Staff {get;set;}
public Currency My_Currency {get;set;}
}
public partial class Supplier
{
public Int32? SUPPLIER_ID {get;set;}
public string SUPPLIER_NAME {get;set;}
public string SUPPLIER_PH_NB {get;set;}
public string SUPPLIER_MAIL {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
public string SUPPLIER_DOB {get;set;}
public Int32? BLOODTYPE_ID {get;set;}
public string SUPPLIER_GENDER {get;set;}
public Bloodtype My_Bloodtype {get;set;}
}
public partial class Supplier_fees
{
public Int32? SUPPLIER_FEES_ID {get;set;}
public Int32? SUPPLIER_ID {get;set;}
public string SUPPLIER_FEES_DESCRIPTION {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
public Int32? CURRENCY_ID {get;set;}
public Int32? SUPPLIER_FEES_AMOUNT {get;set;}
public Supplier My_Supplier {get;set;}
public Currency My_Currency {get;set;}
}
public partial class User
{
public long? USER_ID {get;set;}
public Int32? OWNER_ID {get;set;}
public string USERNAME {get;set;}
public string PASSWORD {get;set;}
public string USER_TYPE_CODE {get;set;}
public bool? IS_ACTIVE {get;set;}
public string ENTRY_DATE {get;set;}
public string USER_EMAIL {get;set;}
}
#endregion 
public partial interface IDALC
{
Address Get_Address_By_ADDRESS_ID ( long? ADDRESS_ID);
Bloodtype Get_Bloodtype_By_BLOODTYPE_ID ( Int32? BLOODTYPE_ID);
Client Get_Client_By_CLIENT_ID ( Int32? CLIENT_ID);
Client_fees Get_Client_fees_By_CLIENT_FEES_ID ( Int32? CLIENT_FEES_ID);
Contact Get_Contact_By_CONTACT_ID ( Int32? CONTACT_ID);
Currency Get_Currency_By_CURRENCY_ID ( Int32? CURRENCY_ID);
Fees Get_Fees_By_FEES_ID ( Int32? FEES_ID);
Loc_l1 Get_Loc_l1_By_LOC_L1_ID ( long? LOC_L1_ID);
Loc_l2 Get_Loc_l2_By_LOC_L2_ID ( long? LOC_L2_ID);
Loc_l3 Get_Loc_l3_By_LOC_L3_ID ( long? LOC_L3_ID);
Loc_l4 Get_Loc_l4_By_LOC_L4_ID ( long? LOC_L4_ID);
Method_run Get_Method_run_By_METHOD_RUN_ID ( long? METHOD_RUN_ID);
Owner Get_Owner_By_OWNER_ID ( Int32? OWNER_ID);
Package Get_Package_By_PACKAGE_ID ( Int32? PACKAGE_ID);
Person Get_Person_By_PERSON_ID ( long? PERSON_ID);
Registration Get_Registration_By_REGISTRATION_ID ( Int32? REGISTRATION_ID);
Session Get_Session_By_SESSION_ID ( Int32? SESSION_ID);
Staff Get_Staff_By_STAFF_ID ( Int32? STAFF_ID);
Staff_fees Get_Staff_fees_By_STAFF_FEES_ID ( Int32? STAFF_FEES_ID);
Supplier Get_Supplier_By_SUPPLIER_ID ( Int32? SUPPLIER_ID);
Supplier_fees Get_Supplier_fees_By_SUPPLIER_FEES_ID ( Int32? SUPPLIER_FEES_ID);
User Get_User_By_USER_ID ( long? USER_ID);
Address Get_Address_By_ADDRESS_ID_Adv ( long? ADDRESS_ID);
Bloodtype Get_Bloodtype_By_BLOODTYPE_ID_Adv ( Int32? BLOODTYPE_ID);
Client Get_Client_By_CLIENT_ID_Adv ( Int32? CLIENT_ID);
Client_fees Get_Client_fees_By_CLIENT_FEES_ID_Adv ( Int32? CLIENT_FEES_ID);
Contact Get_Contact_By_CONTACT_ID_Adv ( Int32? CONTACT_ID);
Currency Get_Currency_By_CURRENCY_ID_Adv ( Int32? CURRENCY_ID);
Fees Get_Fees_By_FEES_ID_Adv ( Int32? FEES_ID);
Loc_l1 Get_Loc_l1_By_LOC_L1_ID_Adv ( long? LOC_L1_ID);
Loc_l2 Get_Loc_l2_By_LOC_L2_ID_Adv ( long? LOC_L2_ID);
Loc_l3 Get_Loc_l3_By_LOC_L3_ID_Adv ( long? LOC_L3_ID);
Loc_l4 Get_Loc_l4_By_LOC_L4_ID_Adv ( long? LOC_L4_ID);
Method_run Get_Method_run_By_METHOD_RUN_ID_Adv ( long? METHOD_RUN_ID);
Package Get_Package_By_PACKAGE_ID_Adv ( Int32? PACKAGE_ID);
Person Get_Person_By_PERSON_ID_Adv ( long? PERSON_ID);
Registration Get_Registration_By_REGISTRATION_ID_Adv ( Int32? REGISTRATION_ID);
Session Get_Session_By_SESSION_ID_Adv ( Int32? SESSION_ID);
Staff Get_Staff_By_STAFF_ID_Adv ( Int32? STAFF_ID);
Staff_fees Get_Staff_fees_By_STAFF_FEES_ID_Adv ( Int32? STAFF_FEES_ID);
Supplier Get_Supplier_By_SUPPLIER_ID_Adv ( Int32? SUPPLIER_ID);
Supplier_fees Get_Supplier_fees_By_SUPPLIER_FEES_ID_Adv ( Int32? SUPPLIER_FEES_ID);
User Get_User_By_USER_ID_Adv ( long? USER_ID);
List<Address> Get_Address_By_ADDRESS_ID_List ( List<long?> ADDRESS_ID_LIST);
List<Bloodtype> Get_Bloodtype_By_BLOODTYPE_ID_List ( List<Int32?> BLOODTYPE_ID_LIST);
List<Client> Get_Client_By_CLIENT_ID_List ( List<Int32?> CLIENT_ID_LIST);
List<Client_fees> Get_Client_fees_By_CLIENT_FEES_ID_List ( List<Int32?> CLIENT_FEES_ID_LIST);
List<Contact> Get_Contact_By_CONTACT_ID_List ( List<Int32?> CONTACT_ID_LIST);
List<Currency> Get_Currency_By_CURRENCY_ID_List ( List<Int32?> CURRENCY_ID_LIST);
List<Fees> Get_Fees_By_FEES_ID_List ( List<Int32?> FEES_ID_LIST);
List<Loc_l1> Get_Loc_l1_By_LOC_L1_ID_List ( List<long?> LOC_L1_ID_LIST);
List<Loc_l2> Get_Loc_l2_By_LOC_L2_ID_List ( List<long?> LOC_L2_ID_LIST);
List<Loc_l3> Get_Loc_l3_By_LOC_L3_ID_List ( List<long?> LOC_L3_ID_LIST);
List<Loc_l4> Get_Loc_l4_By_LOC_L4_ID_List ( List<long?> LOC_L4_ID_LIST);
List<Method_run> Get_Method_run_By_METHOD_RUN_ID_List ( List<long?> METHOD_RUN_ID_LIST);
List<Owner> Get_Owner_By_OWNER_ID_List ( List<Int32?> OWNER_ID_LIST);
List<Package> Get_Package_By_PACKAGE_ID_List ( List<Int32?> PACKAGE_ID_LIST);
List<Person> Get_Person_By_PERSON_ID_List ( List<long?> PERSON_ID_LIST);
List<Registration> Get_Registration_By_REGISTRATION_ID_List ( List<Int32?> REGISTRATION_ID_LIST);
List<Session> Get_Session_By_SESSION_ID_List ( List<Int32?> SESSION_ID_LIST);
List<Staff> Get_Staff_By_STAFF_ID_List ( List<Int32?> STAFF_ID_LIST);
List<Staff_fees> Get_Staff_fees_By_STAFF_FEES_ID_List ( List<Int32?> STAFF_FEES_ID_LIST);
List<Supplier> Get_Supplier_By_SUPPLIER_ID_List ( List<Int32?> SUPPLIER_ID_LIST);
List<Supplier_fees> Get_Supplier_fees_By_SUPPLIER_FEES_ID_List ( List<Int32?> SUPPLIER_FEES_ID_LIST);
List<User> Get_User_By_USER_ID_List ( List<long?> USER_ID_LIST);
List<Address> Get_Address_By_ADDRESS_ID_List_Adv ( List<long?> ADDRESS_ID_LIST);
List<Bloodtype> Get_Bloodtype_By_BLOODTYPE_ID_List_Adv ( List<Int32?> BLOODTYPE_ID_LIST);
List<Client> Get_Client_By_CLIENT_ID_List_Adv ( List<Int32?> CLIENT_ID_LIST);
List<Client_fees> Get_Client_fees_By_CLIENT_FEES_ID_List_Adv ( List<Int32?> CLIENT_FEES_ID_LIST);
List<Contact> Get_Contact_By_CONTACT_ID_List_Adv ( List<Int32?> CONTACT_ID_LIST);
List<Currency> Get_Currency_By_CURRENCY_ID_List_Adv ( List<Int32?> CURRENCY_ID_LIST);
List<Fees> Get_Fees_By_FEES_ID_List_Adv ( List<Int32?> FEES_ID_LIST);
List<Loc_l1> Get_Loc_l1_By_LOC_L1_ID_List_Adv ( List<long?> LOC_L1_ID_LIST);
List<Loc_l2> Get_Loc_l2_By_LOC_L2_ID_List_Adv ( List<long?> LOC_L2_ID_LIST);
List<Loc_l3> Get_Loc_l3_By_LOC_L3_ID_List_Adv ( List<long?> LOC_L3_ID_LIST);
List<Loc_l4> Get_Loc_l4_By_LOC_L4_ID_List_Adv ( List<long?> LOC_L4_ID_LIST);
List<Method_run> Get_Method_run_By_METHOD_RUN_ID_List_Adv ( List<long?> METHOD_RUN_ID_LIST);
List<Package> Get_Package_By_PACKAGE_ID_List_Adv ( List<Int32?> PACKAGE_ID_LIST);
List<Person> Get_Person_By_PERSON_ID_List_Adv ( List<long?> PERSON_ID_LIST);
List<Registration> Get_Registration_By_REGISTRATION_ID_List_Adv ( List<Int32?> REGISTRATION_ID_LIST);
List<Session> Get_Session_By_SESSION_ID_List_Adv ( List<Int32?> SESSION_ID_LIST);
List<Staff> Get_Staff_By_STAFF_ID_List_Adv ( List<Int32?> STAFF_ID_LIST);
List<Staff_fees> Get_Staff_fees_By_STAFF_FEES_ID_List_Adv ( List<Int32?> STAFF_FEES_ID_LIST);
List<Supplier> Get_Supplier_By_SUPPLIER_ID_List_Adv ( List<Int32?> SUPPLIER_ID_LIST);
List<Supplier_fees> Get_Supplier_fees_By_SUPPLIER_FEES_ID_List_Adv ( List<Int32?> SUPPLIER_FEES_ID_LIST);
List<User> Get_User_By_USER_ID_List_Adv ( List<long?> USER_ID_LIST);
List<Address> Get_Address_By_PERSON_ID ( long? PERSON_ID);
List<Address> Get_Address_By_LOC_L1_ID ( long? LOC_L1_ID);
List<Address> Get_Address_By_LOC_L2_ID ( long? LOC_L2_ID);
List<Address> Get_Address_By_LOC_L3_ID ( long? LOC_L3_ID);
List<Address> Get_Address_By_OWNER_ID ( Int32? OWNER_ID);
List<Address> Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE ( long? PERSON_ID, string ADDRESS_TYPE_CODE);
List<Address> Get_Address_By_LOC_L4_ID ( long? LOC_L4_ID);
List<Bloodtype> Get_Bloodtype_By_OWNER_ID ( Int32? OWNER_ID);
List<Client> Get_Client_By_OWNER_ID ( Int32? OWNER_ID);
List<Client> Get_Client_By_BLOODTYPE_ID ( Int32? BLOODTYPE_ID);
List<Client_fees> Get_Client_fees_By_OWNER_ID ( Int32? OWNER_ID);
List<Client_fees> Get_Client_fees_By_CLIENT_ID ( Int32? CLIENT_ID);
List<Client_fees> Get_Client_fees_By_CURRENCY_ID ( Int32? CURRENCY_ID);
List<Client_fees> Get_Client_fees_By_PACKAGE_ID ( Int32? PACKAGE_ID);
List<Client_fees> Get_Client_fees_By_REGISTRATION_ID ( Int32? REGISTRATION_ID);
List<Contact> Get_Contact_By_PERSON_ID ( long? PERSON_ID);
List<Contact> Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT ( long? PERSON_ID, string CONTACT_TYPE_CODE, string CONTACT);
List<Contact> Get_Contact_By_OWNER_ID ( Int32? OWNER_ID);
List<Currency> Get_Currency_By_OWNER_ID ( Int32? OWNER_ID);
List<Fees> Get_Fees_By_OWNER_ID ( Int32? OWNER_ID);
List<Fees> Get_Fees_By_CURRENCY_ID ( Int32? CURRENCY_ID);
List<Loc_l1> Get_Loc_l1_By_CODE ( string CODE);
List<Loc_l1> Get_Loc_l1_By_OWNER_ID ( Int32? OWNER_ID);
List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_CODE ( long? LOC_L1_ID, string CODE);
List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID ( long? LOC_L1_ID);
List<Loc_l2> Get_Loc_l2_By_OWNER_ID ( Int32? OWNER_ID);
List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_CODE ( long? LOC_L2_ID, string CODE);
List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID ( long? LOC_L2_ID);
List<Loc_l3> Get_Loc_l3_By_OWNER_ID ( Int32? OWNER_ID);
List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_CODE ( long? LOC_L3_ID, string CODE);
List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID ( long? LOC_L3_ID);
List<Loc_l4> Get_Loc_l4_By_OWNER_ID ( Int32? OWNER_ID);
List<Method_run> Get_Method_run_By_OWNER_ID ( Int32? OWNER_ID);
List<Package> Get_Package_By_OWNER_ID ( Int32? OWNER_ID);
List<Package> Get_Package_By_CURRENCY_ID ( Int32? CURRENCY_ID);
List<Person> Get_Person_By_OWNER_ID ( Int32? OWNER_ID);
List<Registration> Get_Registration_By_OWNER_ID ( Int32? OWNER_ID);
List<Registration> Get_Registration_By_CLIENT_ID ( Int32? CLIENT_ID);
List<Registration> Get_Registration_By_PACKAGE_ID ( Int32? PACKAGE_ID);
List<Registration> Get_Registration_By_CURRENCY_ID ( Int32? CURRENCY_ID);
List<Session> Get_Session_By_OWNER_ID ( Int32? OWNER_ID);
List<Session> Get_Session_By_PACKAGE_ID ( Int32? PACKAGE_ID);
List<Session> Get_Session_By_CLIENT_FEES_ID ( Int32? CLIENT_FEES_ID);
List<Staff> Get_Staff_By_OWNER_ID ( Int32? OWNER_ID);
List<Staff> Get_Staff_By_BLOODTYPE_ID ( Int32? BLOODTYPE_ID);
List<Staff_fees> Get_Staff_fees_By_OWNER_ID ( Int32? OWNER_ID);
List<Staff_fees> Get_Staff_fees_By_STAFF_ID ( Int32? STAFF_ID);
List<Staff_fees> Get_Staff_fees_By_CURRENCY_ID ( Int32? CURRENCY_ID);
List<Supplier> Get_Supplier_By_OWNER_ID ( Int32? OWNER_ID);
List<Supplier> Get_Supplier_By_BLOODTYPE_ID ( Int32? BLOODTYPE_ID);
List<Supplier_fees> Get_Supplier_fees_By_OWNER_ID ( Int32? OWNER_ID);
List<Supplier_fees> Get_Supplier_fees_By_SUPPLIER_ID ( Int32? SUPPLIER_ID);
List<Supplier_fees> Get_Supplier_fees_By_CURRENCY_ID ( Int32? CURRENCY_ID);
List<User> Get_User_By_OWNER_ID ( Int32? OWNER_ID);
List<User> Get_User_By_USERNAME ( string USERNAME);
List<Address> Get_Address_By_PERSON_ID_Adv ( long? PERSON_ID);
List<Address> Get_Address_By_LOC_L1_ID_Adv ( long? LOC_L1_ID);
List<Address> Get_Address_By_LOC_L2_ID_Adv ( long? LOC_L2_ID);
List<Address> Get_Address_By_LOC_L3_ID_Adv ( long? LOC_L3_ID);
List<Address> Get_Address_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Address> Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE_Adv ( long? PERSON_ID, string ADDRESS_TYPE_CODE);
List<Address> Get_Address_By_LOC_L4_ID_Adv ( long? LOC_L4_ID);
List<Bloodtype> Get_Bloodtype_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Client> Get_Client_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Client> Get_Client_By_BLOODTYPE_ID_Adv ( Int32? BLOODTYPE_ID);
List<Client_fees> Get_Client_fees_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Client_fees> Get_Client_fees_By_CLIENT_ID_Adv ( Int32? CLIENT_ID);
List<Client_fees> Get_Client_fees_By_CURRENCY_ID_Adv ( Int32? CURRENCY_ID);
List<Client_fees> Get_Client_fees_By_PACKAGE_ID_Adv ( Int32? PACKAGE_ID);
List<Client_fees> Get_Client_fees_By_REGISTRATION_ID_Adv ( Int32? REGISTRATION_ID);
List<Contact> Get_Contact_By_PERSON_ID_Adv ( long? PERSON_ID);
List<Contact> Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT_Adv ( long? PERSON_ID, string CONTACT_TYPE_CODE, string CONTACT);
List<Contact> Get_Contact_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Currency> Get_Currency_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Fees> Get_Fees_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Fees> Get_Fees_By_CURRENCY_ID_Adv ( Int32? CURRENCY_ID);
List<Loc_l1> Get_Loc_l1_By_CODE_Adv ( string CODE);
List<Loc_l1> Get_Loc_l1_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_CODE_Adv ( long? LOC_L1_ID, string CODE);
List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_Adv ( long? LOC_L1_ID);
List<Loc_l2> Get_Loc_l2_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_CODE_Adv ( long? LOC_L2_ID, string CODE);
List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_Adv ( long? LOC_L2_ID);
List<Loc_l3> Get_Loc_l3_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_CODE_Adv ( long? LOC_L3_ID, string CODE);
List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_Adv ( long? LOC_L3_ID);
List<Loc_l4> Get_Loc_l4_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Method_run> Get_Method_run_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Package> Get_Package_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Package> Get_Package_By_CURRENCY_ID_Adv ( Int32? CURRENCY_ID);
List<Person> Get_Person_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Registration> Get_Registration_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Registration> Get_Registration_By_CLIENT_ID_Adv ( Int32? CLIENT_ID);
List<Registration> Get_Registration_By_PACKAGE_ID_Adv ( Int32? PACKAGE_ID);
List<Registration> Get_Registration_By_CURRENCY_ID_Adv ( Int32? CURRENCY_ID);
List<Session> Get_Session_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Session> Get_Session_By_PACKAGE_ID_Adv ( Int32? PACKAGE_ID);
List<Session> Get_Session_By_CLIENT_FEES_ID_Adv ( Int32? CLIENT_FEES_ID);
List<Staff> Get_Staff_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Staff> Get_Staff_By_BLOODTYPE_ID_Adv ( Int32? BLOODTYPE_ID);
List<Staff_fees> Get_Staff_fees_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Staff_fees> Get_Staff_fees_By_STAFF_ID_Adv ( Int32? STAFF_ID);
List<Staff_fees> Get_Staff_fees_By_CURRENCY_ID_Adv ( Int32? CURRENCY_ID);
List<Supplier> Get_Supplier_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Supplier> Get_Supplier_By_BLOODTYPE_ID_Adv ( Int32? BLOODTYPE_ID);
List<Supplier_fees> Get_Supplier_fees_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<Supplier_fees> Get_Supplier_fees_By_SUPPLIER_ID_Adv ( Int32? SUPPLIER_ID);
List<Supplier_fees> Get_Supplier_fees_By_CURRENCY_ID_Adv ( Int32? CURRENCY_ID);
List<User> Get_User_By_OWNER_ID_Adv ( Int32? OWNER_ID);
List<User> Get_User_By_USERNAME_Adv ( string USERNAME);
List<Address> Get_Address_By_PERSON_ID_List ( List<long?> PERSON_ID_LIST);
List<Address> Get_Address_By_LOC_L1_ID_List ( List<long?> LOC_L1_ID_LIST);
List<Address> Get_Address_By_LOC_L2_ID_List ( List<long?> LOC_L2_ID_LIST);
List<Address> Get_Address_By_LOC_L3_ID_List ( List<long?> LOC_L3_ID_LIST);
List<Address> Get_Address_By_LOC_L4_ID_List ( List<long?> LOC_L4_ID_LIST);
List<Client> Get_Client_By_BLOODTYPE_ID_List ( List<Int32?> BLOODTYPE_ID_LIST);
List<Client_fees> Get_Client_fees_By_CLIENT_ID_List ( List<Int32?> CLIENT_ID_LIST);
List<Client_fees> Get_Client_fees_By_CURRENCY_ID_List ( List<Int32?> CURRENCY_ID_LIST);
List<Client_fees> Get_Client_fees_By_PACKAGE_ID_List ( List<Int32?> PACKAGE_ID_LIST);
List<Client_fees> Get_Client_fees_By_REGISTRATION_ID_List ( List<Int32?> REGISTRATION_ID_LIST);
List<Contact> Get_Contact_By_PERSON_ID_List ( List<long?> PERSON_ID_LIST);
List<Fees> Get_Fees_By_CURRENCY_ID_List ( List<Int32?> CURRENCY_ID_LIST);
List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_List ( List<long?> LOC_L1_ID_LIST);
List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_List ( List<long?> LOC_L2_ID_LIST);
List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_List ( List<long?> LOC_L3_ID_LIST);
List<Package> Get_Package_By_CURRENCY_ID_List ( List<Int32?> CURRENCY_ID_LIST);
List<Registration> Get_Registration_By_CLIENT_ID_List ( List<Int32?> CLIENT_ID_LIST);
List<Registration> Get_Registration_By_PACKAGE_ID_List ( List<Int32?> PACKAGE_ID_LIST);
List<Registration> Get_Registration_By_CURRENCY_ID_List ( List<Int32?> CURRENCY_ID_LIST);
List<Session> Get_Session_By_PACKAGE_ID_List ( List<Int32?> PACKAGE_ID_LIST);
List<Session> Get_Session_By_CLIENT_FEES_ID_List ( List<Int32?> CLIENT_FEES_ID_LIST);
List<Staff> Get_Staff_By_BLOODTYPE_ID_List ( List<Int32?> BLOODTYPE_ID_LIST);
List<Staff_fees> Get_Staff_fees_By_STAFF_ID_List ( List<Int32?> STAFF_ID_LIST);
List<Staff_fees> Get_Staff_fees_By_CURRENCY_ID_List ( List<Int32?> CURRENCY_ID_LIST);
List<Supplier> Get_Supplier_By_BLOODTYPE_ID_List ( List<Int32?> BLOODTYPE_ID_LIST);
List<Supplier_fees> Get_Supplier_fees_By_SUPPLIER_ID_List ( List<Int32?> SUPPLIER_ID_LIST);
List<Supplier_fees> Get_Supplier_fees_By_CURRENCY_ID_List ( List<Int32?> CURRENCY_ID_LIST);
List<Address> Get_Address_By_PERSON_ID_List_Adv ( List<long?> PERSON_ID_LIST);
List<Address> Get_Address_By_LOC_L1_ID_List_Adv ( List<long?> LOC_L1_ID_LIST);
List<Address> Get_Address_By_LOC_L2_ID_List_Adv ( List<long?> LOC_L2_ID_LIST);
List<Address> Get_Address_By_LOC_L3_ID_List_Adv ( List<long?> LOC_L3_ID_LIST);
List<Address> Get_Address_By_LOC_L4_ID_List_Adv ( List<long?> LOC_L4_ID_LIST);
List<Client> Get_Client_By_BLOODTYPE_ID_List_Adv ( List<Int32?> BLOODTYPE_ID_LIST);
List<Client_fees> Get_Client_fees_By_CLIENT_ID_List_Adv ( List<Int32?> CLIENT_ID_LIST);
List<Client_fees> Get_Client_fees_By_CURRENCY_ID_List_Adv ( List<Int32?> CURRENCY_ID_LIST);
List<Client_fees> Get_Client_fees_By_PACKAGE_ID_List_Adv ( List<Int32?> PACKAGE_ID_LIST);
List<Client_fees> Get_Client_fees_By_REGISTRATION_ID_List_Adv ( List<Int32?> REGISTRATION_ID_LIST);
List<Contact> Get_Contact_By_PERSON_ID_List_Adv ( List<long?> PERSON_ID_LIST);
List<Fees> Get_Fees_By_CURRENCY_ID_List_Adv ( List<Int32?> CURRENCY_ID_LIST);
List<Loc_l2> Get_Loc_l2_By_LOC_L1_ID_List_Adv ( List<long?> LOC_L1_ID_LIST);
List<Loc_l3> Get_Loc_l3_By_LOC_L2_ID_List_Adv ( List<long?> LOC_L2_ID_LIST);
List<Loc_l4> Get_Loc_l4_By_LOC_L3_ID_List_Adv ( List<long?> LOC_L3_ID_LIST);
List<Package> Get_Package_By_CURRENCY_ID_List_Adv ( List<Int32?> CURRENCY_ID_LIST);
List<Registration> Get_Registration_By_CLIENT_ID_List_Adv ( List<Int32?> CLIENT_ID_LIST);
List<Registration> Get_Registration_By_PACKAGE_ID_List_Adv ( List<Int32?> PACKAGE_ID_LIST);
List<Registration> Get_Registration_By_CURRENCY_ID_List_Adv ( List<Int32?> CURRENCY_ID_LIST);
List<Session> Get_Session_By_PACKAGE_ID_List_Adv ( List<Int32?> PACKAGE_ID_LIST);
List<Session> Get_Session_By_CLIENT_FEES_ID_List_Adv ( List<Int32?> CLIENT_FEES_ID_LIST);
List<Staff> Get_Staff_By_BLOODTYPE_ID_List_Adv ( List<Int32?> BLOODTYPE_ID_LIST);
List<Staff_fees> Get_Staff_fees_By_STAFF_ID_List_Adv ( List<Int32?> STAFF_ID_LIST);
List<Staff_fees> Get_Staff_fees_By_CURRENCY_ID_List_Adv ( List<Int32?> CURRENCY_ID_LIST);
List<Supplier> Get_Supplier_By_BLOODTYPE_ID_List_Adv ( List<Int32?> BLOODTYPE_ID_LIST);
List<Supplier_fees> Get_Supplier_fees_By_SUPPLIER_ID_List_Adv ( List<Int32?> SUPPLIER_ID_LIST);
List<Supplier_fees> Get_Supplier_fees_By_CURRENCY_ID_List_Adv ( List<Int32?> CURRENCY_ID_LIST);
List<Address> Get_Address_By_Criteria ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Where ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Criteria_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Where_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Bloodtype> Get_Bloodtype_By_Criteria ( string BLOODTYPE_SYMBOL, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Bloodtype> Get_Bloodtype_By_Where ( string BLOODTYPE_SYMBOL, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Client> Get_Client_By_Criteria ( string CLIENT_NAME, string CLIENT_PH_NB, string CLIENT_MAIL, string CLIENT_GENDER, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Client> Get_Client_By_Where ( string CLIENT_NAME, string CLIENT_PH_NB, string CLIENT_MAIL, string CLIENT_GENDER, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Client> Get_Client_By_Criteria_V2 ( string CLIENT_NAME, string CLIENT_PH_NB, string CLIENT_MAIL, string CLIENT_DOB, string CLIENT_GENDER, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Client> Get_Client_By_Where_V2 ( string CLIENT_NAME, string CLIENT_PH_NB, string CLIENT_MAIL, string CLIENT_DOB, string CLIENT_GENDER, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Client_fees> Get_Client_fees_By_Criteria ( string CLIENT_FEES_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Client_fees> Get_Client_fees_By_Where ( string CLIENT_FEES_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Contact> Get_Contact_By_Criteria ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Contact> Get_Contact_By_Where ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Currency> Get_Currency_By_Criteria ( string CURRENCY_TYPE, string CURRENCY_SYMBOL, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Currency> Get_Currency_By_Where ( string CURRENCY_TYPE, string CURRENCY_SYMBOL, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Fees> Get_Fees_By_Criteria ( string FEES_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Fees> Get_Fees_By_Where ( string FEES_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Fees> Get_Fees_By_Criteria_V2 ( string FEES_DESCRIPTION, string FEES_ORIGIN_DATE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Fees> Get_Fees_By_Where_V2 ( string FEES_DESCRIPTION, string FEES_ORIGIN_DATE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l1> Get_Loc_l1_By_Criteria ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l1> Get_Loc_l1_By_Where ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l2> Get_Loc_l2_By_Criteria ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l2> Get_Loc_l2_By_Where ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l3> Get_Loc_l3_By_Criteria ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l3> Get_Loc_l3_By_Where ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l4> Get_Loc_l4_By_Criteria ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l4> Get_Loc_l4_By_Where ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Method_run> Get_Method_run_By_Criteria ( string METHOD_NAME, string INPUT_PARAM, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Method_run> Get_Method_run_By_Where ( string METHOD_NAME, string INPUT_PARAM, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Method_run> Get_Method_run_By_Criteria_V2 ( string METHOD_NAME, string RUN_DATE, string INPUT_PARAM, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Method_run> Get_Method_run_By_Where_V2 ( string METHOD_NAME, string RUN_DATE, string INPUT_PARAM, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Owner> Get_Owner_By_Criteria ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Owner> Get_Owner_By_Where ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Owner> Get_Owner_By_Criteria_V2 ( string CODE, string MAINTENANCE_DUE_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Owner> Get_Owner_By_Where_V2 ( string CODE, string MAINTENANCE_DUE_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Package> Get_Package_By_Criteria ( string PACKAGE_NAME, string PACKAGE_TYPE, string PACKAGE_TIMELINE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Package> Get_Package_By_Where ( string PACKAGE_NAME, string PACKAGE_TYPE, string PACKAGE_TIMELINE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Package> Get_Package_By_Criteria_V2 ( string PACKAGE_NAME, string PACKAGE_TYPE, string PACKAGE_ENDING_DATE, string PACKAGE_TIMELINE, string PACKAGE_STARTING_DATE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Package> Get_Package_By_Where_V2 ( string PACKAGE_NAME, string PACKAGE_TYPE, string PACKAGE_ENDING_DATE, string PACKAGE_TIMELINE, string PACKAGE_STARTING_DATE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Person> Get_Person_By_Criteria ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Person> Get_Person_By_Where ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Person> Get_Person_By_Criteria_V2 ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string BIRTH_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Person> Get_Person_By_Where_V2 ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string BIRTH_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Registration> Get_Registration_By_Criteria ( string REGISTRATION_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Registration> Get_Registration_By_Where ( string REGISTRATION_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Registration> Get_Registration_By_Criteria_V2 ( string REGISTRATION_DATE, string REGISTRATION_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Registration> Get_Registration_By_Where_V2 ( string REGISTRATION_DATE, string REGISTRATION_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Session> Get_Session_By_Criteria ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Session> Get_Session_By_Where ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Session> Get_Session_By_Criteria_V2 ( string SESSION_STARTING_DATE, string SESSION_ENDING_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Session> Get_Session_By_Where_V2 ( string SESSION_STARTING_DATE, string SESSION_ENDING_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Staff> Get_Staff_By_Criteria ( string STAFF_NAME, string STAFF_PH_NB, string STAFF_MAIL, string STAFF_GENDER, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Staff> Get_Staff_By_Where ( string STAFF_NAME, string STAFF_PH_NB, string STAFF_MAIL, string STAFF_GENDER, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Staff> Get_Staff_By_Criteria_V2 ( string STAFF_NAME, string STAFF_PH_NB, string STAFF_MAIL, string STAFF_DOB, string STAFF_GENDER, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Staff> Get_Staff_By_Where_V2 ( string STAFF_NAME, string STAFF_PH_NB, string STAFF_MAIL, string STAFF_DOB, string STAFF_GENDER, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Staff_fees> Get_Staff_fees_By_Criteria ( string STAFF_FEES_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Staff_fees> Get_Staff_fees_By_Where ( string STAFF_FEES_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Supplier> Get_Supplier_By_Criteria ( string SUPPLIER_NAME, string SUPPLIER_PH_NB, string SUPPLIER_MAIL, string SUPPLIER_GENDER, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Supplier> Get_Supplier_By_Where ( string SUPPLIER_NAME, string SUPPLIER_PH_NB, string SUPPLIER_MAIL, string SUPPLIER_GENDER, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Supplier> Get_Supplier_By_Criteria_V2 ( string SUPPLIER_NAME, string SUPPLIER_PH_NB, string SUPPLIER_MAIL, string SUPPLIER_DOB, string SUPPLIER_GENDER, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Supplier> Get_Supplier_By_Where_V2 ( string SUPPLIER_NAME, string SUPPLIER_PH_NB, string SUPPLIER_MAIL, string SUPPLIER_DOB, string SUPPLIER_GENDER, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Supplier_fees> Get_Supplier_fees_By_Criteria ( string SUPPLIER_FEES_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Supplier_fees> Get_Supplier_fees_By_Where ( string SUPPLIER_FEES_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<User> Get_User_By_Criteria ( string USERNAME, string PASSWORD, string USER_TYPE_CODE, string USER_EMAIL, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<User> Get_User_By_Where ( string USERNAME, string PASSWORD, string USER_TYPE_CODE, string USER_EMAIL, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Criteria_Adv ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Where_Adv ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Criteria_Adv_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Where_Adv_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Bloodtype> Get_Bloodtype_By_Criteria_Adv ( string BLOODTYPE_SYMBOL, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Bloodtype> Get_Bloodtype_By_Where_Adv ( string BLOODTYPE_SYMBOL, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Client> Get_Client_By_Criteria_Adv ( string CLIENT_NAME, string CLIENT_PH_NB, string CLIENT_MAIL, string CLIENT_GENDER, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Client> Get_Client_By_Where_Adv ( string CLIENT_NAME, string CLIENT_PH_NB, string CLIENT_MAIL, string CLIENT_GENDER, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Client> Get_Client_By_Criteria_Adv_V2 ( string CLIENT_NAME, string CLIENT_PH_NB, string CLIENT_MAIL, string CLIENT_DOB, string CLIENT_GENDER, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Client> Get_Client_By_Where_Adv_V2 ( string CLIENT_NAME, string CLIENT_PH_NB, string CLIENT_MAIL, string CLIENT_DOB, string CLIENT_GENDER, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Client_fees> Get_Client_fees_By_Criteria_Adv ( string CLIENT_FEES_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Client_fees> Get_Client_fees_By_Where_Adv ( string CLIENT_FEES_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Contact> Get_Contact_By_Criteria_Adv ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Contact> Get_Contact_By_Where_Adv ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Currency> Get_Currency_By_Criteria_Adv ( string CURRENCY_TYPE, string CURRENCY_SYMBOL, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Currency> Get_Currency_By_Where_Adv ( string CURRENCY_TYPE, string CURRENCY_SYMBOL, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Fees> Get_Fees_By_Criteria_Adv ( string FEES_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Fees> Get_Fees_By_Where_Adv ( string FEES_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Fees> Get_Fees_By_Criteria_Adv_V2 ( string FEES_DESCRIPTION, string FEES_ORIGIN_DATE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Fees> Get_Fees_By_Where_Adv_V2 ( string FEES_DESCRIPTION, string FEES_ORIGIN_DATE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l1> Get_Loc_l1_By_Criteria_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l1> Get_Loc_l1_By_Where_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l2> Get_Loc_l2_By_Criteria_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l2> Get_Loc_l2_By_Where_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l3> Get_Loc_l3_By_Criteria_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l3> Get_Loc_l3_By_Where_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l4> Get_Loc_l4_By_Criteria_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l4> Get_Loc_l4_By_Where_Adv ( string CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Method_run> Get_Method_run_By_Criteria_Adv ( string METHOD_NAME, string INPUT_PARAM, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Method_run> Get_Method_run_By_Where_Adv ( string METHOD_NAME, string INPUT_PARAM, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Method_run> Get_Method_run_By_Criteria_Adv_V2 ( string METHOD_NAME, string RUN_DATE, string INPUT_PARAM, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Method_run> Get_Method_run_By_Where_Adv_V2 ( string METHOD_NAME, string RUN_DATE, string INPUT_PARAM, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Package> Get_Package_By_Criteria_Adv ( string PACKAGE_NAME, string PACKAGE_TYPE, string PACKAGE_TIMELINE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Package> Get_Package_By_Where_Adv ( string PACKAGE_NAME, string PACKAGE_TYPE, string PACKAGE_TIMELINE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Package> Get_Package_By_Criteria_Adv_V2 ( string PACKAGE_NAME, string PACKAGE_TYPE, string PACKAGE_ENDING_DATE, string PACKAGE_TIMELINE, string PACKAGE_STARTING_DATE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Package> Get_Package_By_Where_Adv_V2 ( string PACKAGE_NAME, string PACKAGE_TYPE, string PACKAGE_ENDING_DATE, string PACKAGE_TIMELINE, string PACKAGE_STARTING_DATE, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Person> Get_Person_By_Criteria_Adv ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Person> Get_Person_By_Where_Adv ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Person> Get_Person_By_Criteria_Adv_V2 ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string BIRTH_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Person> Get_Person_By_Where_Adv_V2 ( string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string BIRTH_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Registration> Get_Registration_By_Criteria_Adv ( string REGISTRATION_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Registration> Get_Registration_By_Where_Adv ( string REGISTRATION_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Registration> Get_Registration_By_Criteria_Adv_V2 ( string REGISTRATION_DATE, string REGISTRATION_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Registration> Get_Registration_By_Where_Adv_V2 ( string REGISTRATION_DATE, string REGISTRATION_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Session> Get_Session_By_Criteria_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Session> Get_Session_By_Where_Adv ( string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Session> Get_Session_By_Criteria_Adv_V2 ( string SESSION_STARTING_DATE, string SESSION_ENDING_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Session> Get_Session_By_Where_Adv_V2 ( string SESSION_STARTING_DATE, string SESSION_ENDING_DATE, string DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Staff> Get_Staff_By_Criteria_Adv ( string STAFF_NAME, string STAFF_PH_NB, string STAFF_MAIL, string STAFF_GENDER, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Staff> Get_Staff_By_Where_Adv ( string STAFF_NAME, string STAFF_PH_NB, string STAFF_MAIL, string STAFF_GENDER, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Staff> Get_Staff_By_Criteria_Adv_V2 ( string STAFF_NAME, string STAFF_PH_NB, string STAFF_MAIL, string STAFF_DOB, string STAFF_GENDER, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Staff> Get_Staff_By_Where_Adv_V2 ( string STAFF_NAME, string STAFF_PH_NB, string STAFF_MAIL, string STAFF_DOB, string STAFF_GENDER, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Staff_fees> Get_Staff_fees_By_Criteria_Adv ( string STAFF_FEES_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Staff_fees> Get_Staff_fees_By_Where_Adv ( string STAFF_FEES_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Supplier> Get_Supplier_By_Criteria_Adv ( string SUPPLIER_NAME, string SUPPLIER_PH_NB, string SUPPLIER_MAIL, string SUPPLIER_GENDER, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Supplier> Get_Supplier_By_Where_Adv ( string SUPPLIER_NAME, string SUPPLIER_PH_NB, string SUPPLIER_MAIL, string SUPPLIER_GENDER, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Supplier> Get_Supplier_By_Criteria_Adv_V2 ( string SUPPLIER_NAME, string SUPPLIER_PH_NB, string SUPPLIER_MAIL, string SUPPLIER_DOB, string SUPPLIER_GENDER, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Supplier> Get_Supplier_By_Where_Adv_V2 ( string SUPPLIER_NAME, string SUPPLIER_PH_NB, string SUPPLIER_MAIL, string SUPPLIER_DOB, string SUPPLIER_GENDER, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Supplier_fees> Get_Supplier_fees_By_Criteria_Adv ( string SUPPLIER_FEES_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Supplier_fees> Get_Supplier_fees_By_Where_Adv ( string SUPPLIER_FEES_DESCRIPTION, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<User> Get_User_By_Criteria_Adv ( string USERNAME, string PASSWORD, string USER_TYPE_CODE, string USER_EMAIL, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<User> Get_User_By_Where_Adv ( string USERNAME, string PASSWORD, string USER_TYPE_CODE, string USER_EMAIL, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Criteria_InList ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Where_InList ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Criteria_InList_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Where_InList_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Client> Get_Client_By_Criteria_InList ( string CLIENT_NAME, string CLIENT_PH_NB, string CLIENT_MAIL, string CLIENT_GENDER, List<Int32?> BLOODTYPE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Client> Get_Client_By_Where_InList ( string CLIENT_NAME, string CLIENT_PH_NB, string CLIENT_MAIL, string CLIENT_GENDER, List<Int32?> BLOODTYPE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Client> Get_Client_By_Criteria_InList_V2 ( string CLIENT_NAME, string CLIENT_PH_NB, string CLIENT_MAIL, string CLIENT_DOB, string CLIENT_GENDER, List<Int32?> BLOODTYPE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Client> Get_Client_By_Where_InList_V2 ( string CLIENT_NAME, string CLIENT_PH_NB, string CLIENT_MAIL, string CLIENT_DOB, string CLIENT_GENDER, List<Int32?> BLOODTYPE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Client_fees> Get_Client_fees_By_Criteria_InList ( string CLIENT_FEES_DESCRIPTION, List<Int32?> CLIENT_ID_LIST, List<Int32?> CURRENCY_ID_LIST, List<Int32?> PACKAGE_ID_LIST, List<Int32?> REGISTRATION_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Client_fees> Get_Client_fees_By_Where_InList ( string CLIENT_FEES_DESCRIPTION, List<Int32?> CLIENT_ID_LIST, List<Int32?> CURRENCY_ID_LIST, List<Int32?> PACKAGE_ID_LIST, List<Int32?> REGISTRATION_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Contact> Get_Contact_By_Criteria_InList ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, List<long?> PERSON_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Contact> Get_Contact_By_Where_InList ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, List<long?> PERSON_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Fees> Get_Fees_By_Criteria_InList ( string FEES_DESCRIPTION, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Fees> Get_Fees_By_Where_InList ( string FEES_DESCRIPTION, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Fees> Get_Fees_By_Criteria_InList_V2 ( string FEES_DESCRIPTION, string FEES_ORIGIN_DATE, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Fees> Get_Fees_By_Where_InList_V2 ( string FEES_DESCRIPTION, string FEES_ORIGIN_DATE, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l2> Get_Loc_l2_By_Criteria_InList ( string CODE, string DESCRIPTION, List<long?> LOC_L1_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l2> Get_Loc_l2_By_Where_InList ( string CODE, string DESCRIPTION, List<long?> LOC_L1_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l3> Get_Loc_l3_By_Criteria_InList ( string CODE, string DESCRIPTION, List<long?> LOC_L2_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l3> Get_Loc_l3_By_Where_InList ( string CODE, string DESCRIPTION, List<long?> LOC_L2_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l4> Get_Loc_l4_By_Criteria_InList ( string CODE, string DESCRIPTION, List<long?> LOC_L3_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l4> Get_Loc_l4_By_Where_InList ( string CODE, string DESCRIPTION, List<long?> LOC_L3_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Package> Get_Package_By_Criteria_InList ( string PACKAGE_NAME, string PACKAGE_TYPE, string PACKAGE_TIMELINE, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Package> Get_Package_By_Where_InList ( string PACKAGE_NAME, string PACKAGE_TYPE, string PACKAGE_TIMELINE, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Package> Get_Package_By_Criteria_InList_V2 ( string PACKAGE_NAME, string PACKAGE_TYPE, string PACKAGE_ENDING_DATE, string PACKAGE_TIMELINE, string PACKAGE_STARTING_DATE, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Package> Get_Package_By_Where_InList_V2 ( string PACKAGE_NAME, string PACKAGE_TYPE, string PACKAGE_ENDING_DATE, string PACKAGE_TIMELINE, string PACKAGE_STARTING_DATE, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Registration> Get_Registration_By_Criteria_InList ( string REGISTRATION_DESCRIPTION, List<Int32?> CLIENT_ID_LIST, List<Int32?> PACKAGE_ID_LIST, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Registration> Get_Registration_By_Where_InList ( string REGISTRATION_DESCRIPTION, List<Int32?> CLIENT_ID_LIST, List<Int32?> PACKAGE_ID_LIST, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Registration> Get_Registration_By_Criteria_InList_V2 ( string REGISTRATION_DATE, string REGISTRATION_DESCRIPTION, List<Int32?> CLIENT_ID_LIST, List<Int32?> PACKAGE_ID_LIST, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Registration> Get_Registration_By_Where_InList_V2 ( string REGISTRATION_DATE, string REGISTRATION_DESCRIPTION, List<Int32?> CLIENT_ID_LIST, List<Int32?> PACKAGE_ID_LIST, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Session> Get_Session_By_Criteria_InList ( string DESCRIPTION, List<Int32?> PACKAGE_ID_LIST, List<Int32?> CLIENT_FEES_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Session> Get_Session_By_Where_InList ( string DESCRIPTION, List<Int32?> PACKAGE_ID_LIST, List<Int32?> CLIENT_FEES_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Session> Get_Session_By_Criteria_InList_V2 ( string SESSION_STARTING_DATE, string SESSION_ENDING_DATE, string DESCRIPTION, List<Int32?> PACKAGE_ID_LIST, List<Int32?> CLIENT_FEES_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Session> Get_Session_By_Where_InList_V2 ( string SESSION_STARTING_DATE, string SESSION_ENDING_DATE, string DESCRIPTION, List<Int32?> PACKAGE_ID_LIST, List<Int32?> CLIENT_FEES_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Staff> Get_Staff_By_Criteria_InList ( string STAFF_NAME, string STAFF_PH_NB, string STAFF_MAIL, string STAFF_GENDER, List<Int32?> BLOODTYPE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Staff> Get_Staff_By_Where_InList ( string STAFF_NAME, string STAFF_PH_NB, string STAFF_MAIL, string STAFF_GENDER, List<Int32?> BLOODTYPE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Staff> Get_Staff_By_Criteria_InList_V2 ( string STAFF_NAME, string STAFF_PH_NB, string STAFF_MAIL, string STAFF_DOB, string STAFF_GENDER, List<Int32?> BLOODTYPE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Staff> Get_Staff_By_Where_InList_V2 ( string STAFF_NAME, string STAFF_PH_NB, string STAFF_MAIL, string STAFF_DOB, string STAFF_GENDER, List<Int32?> BLOODTYPE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Staff_fees> Get_Staff_fees_By_Criteria_InList ( string STAFF_FEES_DESCRIPTION, List<Int32?> STAFF_ID_LIST, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Staff_fees> Get_Staff_fees_By_Where_InList ( string STAFF_FEES_DESCRIPTION, List<Int32?> STAFF_ID_LIST, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Supplier> Get_Supplier_By_Criteria_InList ( string SUPPLIER_NAME, string SUPPLIER_PH_NB, string SUPPLIER_MAIL, string SUPPLIER_GENDER, List<Int32?> BLOODTYPE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Supplier> Get_Supplier_By_Where_InList ( string SUPPLIER_NAME, string SUPPLIER_PH_NB, string SUPPLIER_MAIL, string SUPPLIER_GENDER, List<Int32?> BLOODTYPE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Supplier> Get_Supplier_By_Criteria_InList_V2 ( string SUPPLIER_NAME, string SUPPLIER_PH_NB, string SUPPLIER_MAIL, string SUPPLIER_DOB, string SUPPLIER_GENDER, List<Int32?> BLOODTYPE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Supplier> Get_Supplier_By_Where_InList_V2 ( string SUPPLIER_NAME, string SUPPLIER_PH_NB, string SUPPLIER_MAIL, string SUPPLIER_DOB, string SUPPLIER_GENDER, List<Int32?> BLOODTYPE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Supplier_fees> Get_Supplier_fees_By_Criteria_InList ( string SUPPLIER_FEES_DESCRIPTION, List<Int32?> SUPPLIER_ID_LIST, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Supplier_fees> Get_Supplier_fees_By_Where_InList ( string SUPPLIER_FEES_DESCRIPTION, List<Int32?> SUPPLIER_ID_LIST, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Criteria_InList_Adv ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Where_InList_Adv ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Criteria_InList_Adv_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Address> Get_Address_By_Where_InList_Adv_V2 ( string ADDRESS_TYPE_CODE, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, List<long?> PERSON_ID_LIST, List<long?> LOC_L1_ID_LIST, List<long?> LOC_L2_ID_LIST, List<long?> LOC_L3_ID_LIST, List<long?> LOC_L4_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Client> Get_Client_By_Criteria_InList_Adv ( string CLIENT_NAME, string CLIENT_PH_NB, string CLIENT_MAIL, string CLIENT_GENDER, List<Int32?> BLOODTYPE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Client> Get_Client_By_Where_InList_Adv ( string CLIENT_NAME, string CLIENT_PH_NB, string CLIENT_MAIL, string CLIENT_GENDER, List<Int32?> BLOODTYPE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Client> Get_Client_By_Criteria_InList_Adv_V2 ( string CLIENT_NAME, string CLIENT_PH_NB, string CLIENT_MAIL, string CLIENT_DOB, string CLIENT_GENDER, List<Int32?> BLOODTYPE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Client> Get_Client_By_Where_InList_Adv_V2 ( string CLIENT_NAME, string CLIENT_PH_NB, string CLIENT_MAIL, string CLIENT_DOB, string CLIENT_GENDER, List<Int32?> BLOODTYPE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Client_fees> Get_Client_fees_By_Criteria_InList_Adv ( string CLIENT_FEES_DESCRIPTION, List<Int32?> CLIENT_ID_LIST, List<Int32?> CURRENCY_ID_LIST, List<Int32?> PACKAGE_ID_LIST, List<Int32?> REGISTRATION_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Client_fees> Get_Client_fees_By_Where_InList_Adv ( string CLIENT_FEES_DESCRIPTION, List<Int32?> CLIENT_ID_LIST, List<Int32?> CURRENCY_ID_LIST, List<Int32?> PACKAGE_ID_LIST, List<Int32?> REGISTRATION_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Contact> Get_Contact_By_Criteria_InList_Adv ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, List<long?> PERSON_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Contact> Get_Contact_By_Where_InList_Adv ( string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, List<long?> PERSON_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Fees> Get_Fees_By_Criteria_InList_Adv ( string FEES_DESCRIPTION, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Fees> Get_Fees_By_Where_InList_Adv ( string FEES_DESCRIPTION, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Fees> Get_Fees_By_Criteria_InList_Adv_V2 ( string FEES_DESCRIPTION, string FEES_ORIGIN_DATE, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Fees> Get_Fees_By_Where_InList_Adv_V2 ( string FEES_DESCRIPTION, string FEES_ORIGIN_DATE, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l2> Get_Loc_l2_By_Criteria_InList_Adv ( string CODE, string DESCRIPTION, List<long?> LOC_L1_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l2> Get_Loc_l2_By_Where_InList_Adv ( string CODE, string DESCRIPTION, List<long?> LOC_L1_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l3> Get_Loc_l3_By_Criteria_InList_Adv ( string CODE, string DESCRIPTION, List<long?> LOC_L2_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l3> Get_Loc_l3_By_Where_InList_Adv ( string CODE, string DESCRIPTION, List<long?> LOC_L2_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l4> Get_Loc_l4_By_Criteria_InList_Adv ( string CODE, string DESCRIPTION, List<long?> LOC_L3_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Loc_l4> Get_Loc_l4_By_Where_InList_Adv ( string CODE, string DESCRIPTION, List<long?> LOC_L3_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Package> Get_Package_By_Criteria_InList_Adv ( string PACKAGE_NAME, string PACKAGE_TYPE, string PACKAGE_TIMELINE, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Package> Get_Package_By_Where_InList_Adv ( string PACKAGE_NAME, string PACKAGE_TYPE, string PACKAGE_TIMELINE, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Package> Get_Package_By_Criteria_InList_Adv_V2 ( string PACKAGE_NAME, string PACKAGE_TYPE, string PACKAGE_ENDING_DATE, string PACKAGE_TIMELINE, string PACKAGE_STARTING_DATE, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Package> Get_Package_By_Where_InList_Adv_V2 ( string PACKAGE_NAME, string PACKAGE_TYPE, string PACKAGE_ENDING_DATE, string PACKAGE_TIMELINE, string PACKAGE_STARTING_DATE, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Registration> Get_Registration_By_Criteria_InList_Adv ( string REGISTRATION_DESCRIPTION, List<Int32?> CLIENT_ID_LIST, List<Int32?> PACKAGE_ID_LIST, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Registration> Get_Registration_By_Where_InList_Adv ( string REGISTRATION_DESCRIPTION, List<Int32?> CLIENT_ID_LIST, List<Int32?> PACKAGE_ID_LIST, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Registration> Get_Registration_By_Criteria_InList_Adv_V2 ( string REGISTRATION_DATE, string REGISTRATION_DESCRIPTION, List<Int32?> CLIENT_ID_LIST, List<Int32?> PACKAGE_ID_LIST, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Registration> Get_Registration_By_Where_InList_Adv_V2 ( string REGISTRATION_DATE, string REGISTRATION_DESCRIPTION, List<Int32?> CLIENT_ID_LIST, List<Int32?> PACKAGE_ID_LIST, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Session> Get_Session_By_Criteria_InList_Adv ( string DESCRIPTION, List<Int32?> PACKAGE_ID_LIST, List<Int32?> CLIENT_FEES_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Session> Get_Session_By_Where_InList_Adv ( string DESCRIPTION, List<Int32?> PACKAGE_ID_LIST, List<Int32?> CLIENT_FEES_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Session> Get_Session_By_Criteria_InList_Adv_V2 ( string SESSION_STARTING_DATE, string SESSION_ENDING_DATE, string DESCRIPTION, List<Int32?> PACKAGE_ID_LIST, List<Int32?> CLIENT_FEES_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Session> Get_Session_By_Where_InList_Adv_V2 ( string SESSION_STARTING_DATE, string SESSION_ENDING_DATE, string DESCRIPTION, List<Int32?> PACKAGE_ID_LIST, List<Int32?> CLIENT_FEES_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Staff> Get_Staff_By_Criteria_InList_Adv ( string STAFF_NAME, string STAFF_PH_NB, string STAFF_MAIL, string STAFF_GENDER, List<Int32?> BLOODTYPE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Staff> Get_Staff_By_Where_InList_Adv ( string STAFF_NAME, string STAFF_PH_NB, string STAFF_MAIL, string STAFF_GENDER, List<Int32?> BLOODTYPE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Staff> Get_Staff_By_Criteria_InList_Adv_V2 ( string STAFF_NAME, string STAFF_PH_NB, string STAFF_MAIL, string STAFF_DOB, string STAFF_GENDER, List<Int32?> BLOODTYPE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Staff> Get_Staff_By_Where_InList_Adv_V2 ( string STAFF_NAME, string STAFF_PH_NB, string STAFF_MAIL, string STAFF_DOB, string STAFF_GENDER, List<Int32?> BLOODTYPE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Staff_fees> Get_Staff_fees_By_Criteria_InList_Adv ( string STAFF_FEES_DESCRIPTION, List<Int32?> STAFF_ID_LIST, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Staff_fees> Get_Staff_fees_By_Where_InList_Adv ( string STAFF_FEES_DESCRIPTION, List<Int32?> STAFF_ID_LIST, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Supplier> Get_Supplier_By_Criteria_InList_Adv ( string SUPPLIER_NAME, string SUPPLIER_PH_NB, string SUPPLIER_MAIL, string SUPPLIER_GENDER, List<Int32?> BLOODTYPE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Supplier> Get_Supplier_By_Where_InList_Adv ( string SUPPLIER_NAME, string SUPPLIER_PH_NB, string SUPPLIER_MAIL, string SUPPLIER_GENDER, List<Int32?> BLOODTYPE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Supplier> Get_Supplier_By_Criteria_InList_Adv_V2 ( string SUPPLIER_NAME, string SUPPLIER_PH_NB, string SUPPLIER_MAIL, string SUPPLIER_DOB, string SUPPLIER_GENDER, List<Int32?> BLOODTYPE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Supplier> Get_Supplier_By_Where_InList_Adv_V2 ( string SUPPLIER_NAME, string SUPPLIER_PH_NB, string SUPPLIER_MAIL, string SUPPLIER_DOB, string SUPPLIER_GENDER, List<Int32?> BLOODTYPE_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Supplier_fees> Get_Supplier_fees_By_Criteria_InList_Adv ( string SUPPLIER_FEES_DESCRIPTION, List<Int32?> SUPPLIER_ID_LIST, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
List<Supplier_fees> Get_Supplier_fees_By_Where_InList_Adv ( string SUPPLIER_FEES_DESCRIPTION, List<Int32?> SUPPLIER_ID_LIST, List<Int32?> CURRENCY_ID_LIST, Int32? OWNER_ID, Int64? START_ROW, Int64? END_ROW,ref  Int64? TOTAL_COUNT);
void Delete_Address ( long? ADDRESS_ID);
void Delete_Bloodtype ( Int32? BLOODTYPE_ID);
void Delete_Client ( Int32? CLIENT_ID);
void Delete_Client_fees ( Int32? CLIENT_FEES_ID);
void Delete_Contact ( Int32? CONTACT_ID);
void Delete_Currency ( Int32? CURRENCY_ID);
void Delete_Fees ( Int32? FEES_ID);
void Delete_Loc_l1 ( long? LOC_L1_ID);
void Delete_Loc_l2 ( long? LOC_L2_ID);
void Delete_Loc_l3 ( long? LOC_L3_ID);
void Delete_Loc_l4 ( long? LOC_L4_ID);
void Delete_Method_run ( long? METHOD_RUN_ID);
void Delete_Owner ( Int32? OWNER_ID);
void Delete_Package ( Int32? PACKAGE_ID);
void Delete_Person ( long? PERSON_ID);
void Delete_Registration ( Int32? REGISTRATION_ID);
void Delete_Session ( Int32? SESSION_ID);
void Delete_Staff ( Int32? STAFF_ID);
void Delete_Staff_fees ( Int32? STAFF_FEES_ID);
void Delete_Supplier ( Int32? SUPPLIER_ID);
void Delete_Supplier_fees ( Int32? SUPPLIER_FEES_ID);
void Delete_User ( long? USER_ID);
void Delete_Address_By_PERSON_ID ( long? PERSON_ID);
void Delete_Address_By_LOC_L1_ID ( long? LOC_L1_ID);
void Delete_Address_By_LOC_L2_ID ( long? LOC_L2_ID);
void Delete_Address_By_LOC_L3_ID ( long? LOC_L3_ID);
void Delete_Address_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Address_By_PERSON_ID_ADDRESS_TYPE_CODE ( long? PERSON_ID, string ADDRESS_TYPE_CODE);
void Delete_Address_By_LOC_L4_ID ( long? LOC_L4_ID);
void Delete_Bloodtype_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Client_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Client_By_BLOODTYPE_ID ( Int32? BLOODTYPE_ID);
void Delete_Client_fees_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Client_fees_By_CLIENT_ID ( Int32? CLIENT_ID);
void Delete_Client_fees_By_CURRENCY_ID ( Int32? CURRENCY_ID);
void Delete_Client_fees_By_PACKAGE_ID ( Int32? PACKAGE_ID);
void Delete_Client_fees_By_REGISTRATION_ID ( Int32? REGISTRATION_ID);
void Delete_Contact_By_PERSON_ID ( long? PERSON_ID);
void Delete_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT ( long? PERSON_ID, string CONTACT_TYPE_CODE, string CONTACT);
void Delete_Contact_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Currency_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Fees_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Fees_By_CURRENCY_ID ( Int32? CURRENCY_ID);
void Delete_Loc_l1_By_CODE ( string CODE);
void Delete_Loc_l1_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Loc_l2_By_LOC_L1_ID_CODE ( long? LOC_L1_ID, string CODE);
void Delete_Loc_l2_By_LOC_L1_ID ( long? LOC_L1_ID);
void Delete_Loc_l2_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Loc_l3_By_LOC_L2_ID_CODE ( long? LOC_L2_ID, string CODE);
void Delete_Loc_l3_By_LOC_L2_ID ( long? LOC_L2_ID);
void Delete_Loc_l3_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Loc_l4_By_LOC_L3_ID_CODE ( long? LOC_L3_ID, string CODE);
void Delete_Loc_l4_By_LOC_L3_ID ( long? LOC_L3_ID);
void Delete_Loc_l4_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Method_run_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Package_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Package_By_CURRENCY_ID ( Int32? CURRENCY_ID);
void Delete_Person_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Registration_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Registration_By_CLIENT_ID ( Int32? CLIENT_ID);
void Delete_Registration_By_PACKAGE_ID ( Int32? PACKAGE_ID);
void Delete_Registration_By_CURRENCY_ID ( Int32? CURRENCY_ID);
void Delete_Session_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Session_By_PACKAGE_ID ( Int32? PACKAGE_ID);
void Delete_Session_By_CLIENT_FEES_ID ( Int32? CLIENT_FEES_ID);
void Delete_Staff_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Staff_By_BLOODTYPE_ID ( Int32? BLOODTYPE_ID);
void Delete_Staff_fees_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Staff_fees_By_STAFF_ID ( Int32? STAFF_ID);
void Delete_Staff_fees_By_CURRENCY_ID ( Int32? CURRENCY_ID);
void Delete_Supplier_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Supplier_By_BLOODTYPE_ID ( Int32? BLOODTYPE_ID);
void Delete_Supplier_fees_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_Supplier_fees_By_SUPPLIER_ID ( Int32? SUPPLIER_ID);
void Delete_Supplier_fees_By_CURRENCY_ID ( Int32? CURRENCY_ID);
void Delete_User_By_OWNER_ID ( Int32? OWNER_ID);
void Delete_User_By_USERNAME ( string USERNAME);
long? Edit_Address ( long? ADDRESS_ID, long? PERSON_ID, string ADDRESS_TYPE_CODE, long? LOC_L1_ID, long? LOC_L2_ID, long? LOC_L3_ID, long? LOC_L4_ID, string STREET, string BUILDING, string FLOOR, string POBOX, string VALID_DATE_START, string VALID_DATE_END, string NOTES, string ENTRY_DATE, long? ENTRY_USER_ID, Int32? OWNER_ID);
Int32? Edit_Bloodtype ( Int32? BLOODTYPE_ID, string BLOODTYPE_SYMBOL, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
Int32? Edit_Client ( Int32? CLIENT_ID, string CLIENT_NAME, string CLIENT_PH_NB, string CLIENT_MAIL, string CLIENT_DOB, Int32? BLOODTYPE_ID, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID, string CLIENT_GENDER);
Int32? Edit_Client_fees ( Int32? CLIENT_FEES_ID, Int32? CLIENT_ID, string CLIENT_FEES_DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID, Int32? CURRENCY_ID, Int32? PACKAGE_ID, Int32? CLIENT_FEES_AMOUNT, Int32? REGISTRATION_ID);
Int32? Edit_Contact ( Int32? CONTACT_ID, long? PERSON_ID, string CONTACT_TYPE_CODE, string CONTACT, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
Int32? Edit_Currency ( Int32? CURRENCY_ID, string CURRENCY_TYPE, string CURRENCY_SYMBOL, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
Int32? Edit_Fees ( Int32? FEES_ID, string FEES_DESCRIPTION, Int32? FEES_AMOUNT, Int32? CURRENCY_ID, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID, string FEES_ORIGIN_DATE);
long? Edit_Loc_l1 ( long? LOC_L1_ID, string CODE, string DESCRIPTION, string NOTES, string ENTRY_DATE, long? ENTRY_USER_ID, Int32? OWNER_ID);
long? Edit_Loc_l2 ( long? LOC_L2_ID, string CODE, string DESCRIPTION, long? LOC_L1_ID, string NOTES, string ENTRY_DATE, long? ENTRY_USER_ID, Int32? OWNER_ID);
long? Edit_Loc_l3 ( long? LOC_L3_ID, string CODE, string DESCRIPTION, long? LOC_L2_ID, string NOTES, string ENTRY_DATE, long? ENTRY_USER_ID, Int32? OWNER_ID);
long? Edit_Loc_l4 ( long? LOC_L4_ID, string CODE, string DESCRIPTION, long? LOC_L3_ID, string NOTES, string ENTRY_DATE, long? ENTRY_USER_ID, Int32? OWNER_ID);
long? Edit_Method_run ( long? METHOD_RUN_ID, string METHOD_NAME, string RUN_DATE, Int32? RUN_HOUR, Int32? RUN_MINUTE, Int32? RUN_SECOND, bool? IS_CACHED, Int32? EXECUTION_TIME, string INPUT_PARAM, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
Int32? Edit_Owner ( Int32? OWNER_ID, string CODE, string MAINTENANCE_DUE_DATE, string DESCRIPTION, string ENTRY_DATE);
Int32? Edit_Package ( Int32? PACKAGE_ID, string PACKAGE_NAME, Int32? PACKAGE_PRICE, Int32? CURRENCY_ID, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID, Int32? PACKAGE_SESSIONS_NB, string PACKAGE_TYPE, string PACKAGE_ENDING_DATE, string PACKAGE_TIMELINE, string PACKAGE_STARTING_DATE);
long? Edit_Person ( long? PERSON_ID, string FIRST_NAME, string LAST_NAME, string FATHER_NAME, string MOTHER_NAME, string TITLE_CODE, string GENDER_CODE, string RELIGION_CODE, string BIRTH_DATE, bool? IS_BLOCKED, string DESCRIPTION, Int32? OWNER_ID, long? ENTRY_USER_ID, string ENTRY_DATE);
Int32? Edit_Registration ( Int32? REGISTRATION_ID, Int32? CLIENT_ID, string REGISTRATION_DATE, Int32? PACKAGE_ID, Int32? REGISTRATION_DISCOUNT, Int32? REGISTRATION_TOTAL_PRICE, Int32? CURRENCY_ID, string REGISTRATION_DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID);
Int32? Edit_Session ( Int32? SESSION_ID, string SESSION_STARTING_DATE, string SESSION_ENDING_DATE, Int32? SESSION_ATTENDED, Int32? PACKAGE_ID, Int32? CLIENT_FEES_ID, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID, string DESCRIPTION);
Int32? Edit_Staff ( Int32? STAFF_ID, string STAFF_NAME, string STAFF_PH_NB, string STAFF_MAIL, string STAFF_DOB, Int32? BLOODTYPE_ID, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID, string STAFF_GENDER);
Int32? Edit_Staff_fees ( Int32? STAFF_FEES_ID, Int32? STAFF_ID, string STAFF_FEES_DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID, Int32? CURRENCY_ID, Int32? STAFF_FEES_AMOUNT);
Int32? Edit_Supplier ( Int32? SUPPLIER_ID, string SUPPLIER_NAME, string SUPPLIER_PH_NB, string SUPPLIER_MAIL, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID, string SUPPLIER_DOB, Int32? BLOODTYPE_ID, string SUPPLIER_GENDER);
Int32? Edit_Supplier_fees ( Int32? SUPPLIER_FEES_ID, Int32? SUPPLIER_ID, string SUPPLIER_FEES_DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, Int32? OWNER_ID, Int32? CURRENCY_ID, Int32? SUPPLIER_FEES_AMOUNT);
long? Edit_User ( long? USER_ID, Int32? OWNER_ID, string USERNAME, string PASSWORD, string USER_TYPE_CODE, bool? IS_ACTIVE, string ENTRY_DATE, string USER_EMAIL);
List<dynamic> CalculateStaffBalance ( Int32? STAFF_ID,ref  Int32? BALANCE, long? OWNER_ID, Int32? CURRENCY_ID);
List<dynamic> CalculateSupplierBalance ( Int32? SUPPLIER_ID,ref  Int32? BALANCE, long? OWNER_ID, Int32? CURRENCY_ID);
List<dynamic> CheckClientPaymentStatus ( Int32? CLIENT_ID,ref  Int32? BALANCE, long? OWNER_ID, Int32? CURRENCY_ID);
List<dynamic> CheckIfUserExists ( string Username, string UserEmail);
List<dynamic> EXPENSES_SUM ( long? OWNER_ID, Int32? CURRENCY_ID,ref  Int32? SUM);
List<dynamic> GET_DISTINCT_SETUP_TBL ( Int32? OWNER_ID);
List<dynamic> GET_NEXT_VALUE ( string STARTER_CODE);
List<dynamic> GET_TBL_SETUP ();
List<dynamic> GETGRANDPROFIT ( long? OWNER_ID, Int32? CURRENCY_ID, Int32? SUM__POS, Int32? SUM__NEG,ref  Int32? SUM);
List<dynamic> LoginFct ( Int32? OWNER_ID, string USERNAME, string PASSWORD,ref  Int32? RESULT);
List<dynamic> SALES_SUM ( long? OWNER_ID, Int32? CURRENCY_ID,ref  Int32? SUM);
List<dynamic> UP_BULK_UPSERT_ADDRESS ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_BLOODTYPE ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_CLIENT ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_CLIENT_FEES ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_CONTACT ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_CURRENCY ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_FEES ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_LOC_L1 ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_LOC_L2 ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_LOC_L3 ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_LOC_L4 ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_METHOD_RUN ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_OWNER ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_PACKAGE ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_PERSON ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_REGISTRATION ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_SESSION ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_STAFF ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_STAFF_FEES ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_SUPPLIER ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_SUPPLIER_FEES ( string JSON_CONTENT);
List<dynamic> UP_BULK_UPSERT_USER ( string JSON_CONTENT);
List<dynamic> UP_CHECK_USER_EXISTENCE ( Int32? OWNER_ID, string USERNAME,ref  bool? EXISTS);
List<dynamic> UP_EDIT_SETUP ( Int32? OWNER_ID, string TBL_NAME, string CODE_NAME, bool? ISSYSTEM, bool? ISDELETEABLE, bool? ISUPDATEABLE, bool? ISVISIBLE, bool? ISDELETED, Int32? DISPLAY_ORDER, string CODE_VALUE_EN, string CODE_VALUE_FR, string CODE_VALUE_AR, string ENTRY_DATE, long? ENTRY_USER_ID, string NOTES);
List<dynamic> UP_EXTRACT_ROUTINE_PARAMETERS ( string ROUTINE_NAME);
List<dynamic> UP_EXTRACT_ROUTINE_RESULT_SCHEMA ( string ROUTINE_NAME);
List<dynamic> UP_GENERATE_INSERT_STATEMENTS ( string @tableName);
List<dynamic> UP_GET_NEXT_VALUE ( string STARTER_CODE,ref  long? VALUE);
List<dynamic> UP_GET_SETUP_ENTRIES ( Int32? OWNER_ID, string TBL_NAME, bool? ISDELETED, bool? ISVISIBLE);
List<dynamic> UP_GET_SETUP_ENTRY ( Int32? OWNER_ID, string TBL_NAME, string CODE_NAME);
List<dynamic> UP_GET_USER_BY_CREDENTIALS ( Int32? OWNER_ID, string USERNAME, string PASSWORD);
List<dynamic> UpdatePassword ( long? owner_id, string username, string updated_password);
}
}
