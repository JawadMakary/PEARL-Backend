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
#region StopWatch properties
public Stopwatch _Execution_Time_Prepare_BLCInitializer {get;set;}
public Stopwatch _Execution_Time_Get_Address_By_ADDRESS_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Bloodtype_By_BLOODTYPE_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Client_By_CLIENT_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Client_fees_By_CLIENT_FEES_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Contact_By_CONTACT_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Currency_By_CURRENCY_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Fees_By_FEES_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l1_By_LOC_L1_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l2_By_LOC_L2_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l3_By_LOC_L3_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l4_By_LOC_L4_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Method_run_By_METHOD_RUN_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Package_By_PACKAGE_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Person_By_PERSON_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Registration_By_REGISTRATION_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Session_By_SESSION_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Staff_By_STAFF_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Staff_fees_By_STAFF_FEES_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Supplier_By_SUPPLIER_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Supplier_fees_By_SUPPLIER_FEES_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_User_By_USER_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Address_By_ADDRESS_ID_List_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Bloodtype_By_BLOODTYPE_ID_List_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Client_By_CLIENT_ID_List_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Client_fees_By_CLIENT_FEES_ID_List_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Contact_By_CONTACT_ID_List_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Currency_By_CURRENCY_ID_List_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Fees_By_FEES_ID_List_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l1_By_LOC_L1_ID_List_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l2_By_LOC_L2_ID_List_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l3_By_LOC_L3_ID_List_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l4_By_LOC_L4_ID_List_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Method_run_By_METHOD_RUN_ID_List_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Package_By_PACKAGE_ID_List_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Person_By_PERSON_ID_List_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Registration_By_REGISTRATION_ID_List_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Session_By_SESSION_ID_List_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Staff_By_STAFF_ID_List_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Staff_fees_By_STAFF_FEES_ID_List_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Supplier_By_SUPPLIER_ID_List_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Supplier_fees_By_SUPPLIER_FEES_ID_List_Adv {get;set;}
public Stopwatch _Execution_Time_Get_User_By_USER_ID_List_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Address_By_PERSON_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Address_By_LOC_L1_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Address_By_LOC_L2_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Address_By_LOC_L3_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Address_By_OWNER_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Address_By_LOC_L4_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Bloodtype_By_OWNER_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Client_By_OWNER_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Client_By_BLOODTYPE_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Client_fees_By_OWNER_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Client_fees_By_CLIENT_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Client_fees_By_CURRENCY_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Client_fees_By_PACKAGE_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Client_fees_By_REGISTRATION_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Contact_By_PERSON_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Contact_By_OWNER_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Currency_By_OWNER_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Fees_By_OWNER_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Fees_By_CURRENCY_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l1_By_CODE_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l1_By_OWNER_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l2_By_LOC_L1_ID_CODE_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l2_By_LOC_L1_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l2_By_OWNER_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l3_By_LOC_L2_ID_CODE_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l3_By_LOC_L2_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l3_By_OWNER_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l4_By_LOC_L3_ID_CODE_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l4_By_LOC_L3_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l4_By_OWNER_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Method_run_By_OWNER_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Package_By_OWNER_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Package_By_CURRENCY_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Person_By_OWNER_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Registration_By_OWNER_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Registration_By_CLIENT_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Registration_By_PACKAGE_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Registration_By_CURRENCY_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Session_By_OWNER_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Session_By_PACKAGE_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Session_By_CLIENT_FEES_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Staff_By_OWNER_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Staff_By_BLOODTYPE_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Staff_fees_By_OWNER_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Staff_fees_By_STAFF_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Staff_fees_By_CURRENCY_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Supplier_By_OWNER_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Supplier_By_BLOODTYPE_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Supplier_fees_By_OWNER_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Supplier_fees_By_SUPPLIER_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Supplier_fees_By_CURRENCY_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_User_By_OWNER_ID_Adv {get;set;}
public Stopwatch _Execution_Time_Get_User_By_USERNAME_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Address_By_PERSON_ID_List_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Address_By_LOC_L1_ID_List_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Address_By_LOC_L2_ID_List_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Address_By_LOC_L3_ID_List_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Address_By_LOC_L4_ID_List_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Client_By_BLOODTYPE_ID_List_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Client_fees_By_CLIENT_ID_List_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Client_fees_By_CURRENCY_ID_List_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Client_fees_By_PACKAGE_ID_List_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Client_fees_By_REGISTRATION_ID_List_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Contact_By_PERSON_ID_List_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Fees_By_CURRENCY_ID_List_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l2_By_LOC_L1_ID_List_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l3_By_LOC_L2_ID_List_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l4_By_LOC_L3_ID_List_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Package_By_CURRENCY_ID_List_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Registration_By_CLIENT_ID_List_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Registration_By_PACKAGE_ID_List_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Registration_By_CURRENCY_ID_List_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Session_By_PACKAGE_ID_List_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Session_By_CLIENT_FEES_ID_List_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Staff_By_BLOODTYPE_ID_List_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Staff_fees_By_STAFF_ID_List_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Staff_fees_By_CURRENCY_ID_List_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Supplier_By_BLOODTYPE_ID_List_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Supplier_fees_By_SUPPLIER_ID_List_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Supplier_fees_By_CURRENCY_ID_List_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Address_By_Criteria_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Address_By_Where_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Address_By_Criteria_Adv_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Address_By_Where_Adv_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Bloodtype_By_Criteria_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Bloodtype_By_Where_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Client_By_Criteria_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Client_By_Where_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Client_By_Criteria_Adv_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Client_By_Where_Adv_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Client_fees_By_Criteria_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Client_fees_By_Where_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Contact_By_Criteria_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Contact_By_Where_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Currency_By_Criteria_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Currency_By_Where_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Fees_By_Criteria_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Fees_By_Where_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Fees_By_Criteria_Adv_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Fees_By_Where_Adv_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l1_By_Criteria_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l1_By_Where_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l2_By_Criteria_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l2_By_Where_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l3_By_Criteria_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l3_By_Where_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l4_By_Criteria_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l4_By_Where_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Method_run_By_Criteria_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Method_run_By_Where_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Method_run_By_Criteria_Adv_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Method_run_By_Where_Adv_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Package_By_Criteria_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Package_By_Where_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Package_By_Criteria_Adv_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Package_By_Where_Adv_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Person_By_Criteria_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Person_By_Where_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Person_By_Criteria_Adv_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Person_By_Where_Adv_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Registration_By_Criteria_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Registration_By_Where_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Registration_By_Criteria_Adv_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Registration_By_Where_Adv_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Session_By_Criteria_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Session_By_Where_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Session_By_Criteria_Adv_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Session_By_Where_Adv_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Staff_By_Criteria_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Staff_By_Where_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Staff_By_Criteria_Adv_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Staff_By_Where_Adv_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Staff_fees_By_Criteria_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Staff_fees_By_Where_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Supplier_By_Criteria_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Supplier_By_Where_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Supplier_By_Criteria_Adv_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Supplier_By_Where_Adv_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Supplier_fees_By_Criteria_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Supplier_fees_By_Where_Adv {get;set;}
public Stopwatch _Execution_Time_Get_User_By_Criteria_Adv {get;set;}
public Stopwatch _Execution_Time_Get_User_By_Where_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Address_By_Criteria_InList_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Address_By_Where_InList_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Address_By_Criteria_InList_Adv_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Address_By_Where_InList_Adv_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Client_By_Criteria_InList_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Client_By_Where_InList_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Client_By_Criteria_InList_Adv_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Client_By_Where_InList_Adv_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Client_fees_By_Criteria_InList_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Client_fees_By_Where_InList_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Contact_By_Criteria_InList_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Contact_By_Where_InList_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Fees_By_Criteria_InList_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Fees_By_Where_InList_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Fees_By_Criteria_InList_Adv_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Fees_By_Where_InList_Adv_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l2_By_Criteria_InList_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l2_By_Where_InList_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l3_By_Criteria_InList_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l3_By_Where_InList_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l4_By_Criteria_InList_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l4_By_Where_InList_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Package_By_Criteria_InList_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Package_By_Where_InList_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Package_By_Criteria_InList_Adv_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Package_By_Where_InList_Adv_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Registration_By_Criteria_InList_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Registration_By_Where_InList_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Registration_By_Criteria_InList_Adv_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Registration_By_Where_InList_Adv_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Session_By_Criteria_InList_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Session_By_Where_InList_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Session_By_Criteria_InList_Adv_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Session_By_Where_InList_Adv_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Staff_By_Criteria_InList_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Staff_By_Where_InList_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Staff_By_Criteria_InList_Adv_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Staff_By_Where_InList_Adv_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Staff_fees_By_Criteria_InList_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Staff_fees_By_Where_InList_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Supplier_By_Criteria_InList_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Supplier_By_Where_InList_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Supplier_By_Criteria_InList_Adv_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Supplier_By_Where_InList_Adv_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Supplier_fees_By_Criteria_InList_Adv {get;set;}
public Stopwatch _Execution_Time_Get_Supplier_fees_By_Where_InList_Adv {get;set;}
public Stopwatch _Execution_Time_Reset_Client_By_Bloodtype {get;set;}
public Stopwatch _Execution_Time_Edit_Bloodtype_WithClient {get;set;}
public Stopwatch _Execution_Time_Reset_Staff_By_Bloodtype {get;set;}
public Stopwatch _Execution_Time_Edit_Bloodtype_WithStaff {get;set;}
public Stopwatch _Execution_Time_Reset_Supplier_By_Bloodtype {get;set;}
public Stopwatch _Execution_Time_Edit_Bloodtype_WithSupplier {get;set;}
public Stopwatch _Execution_Time_Edit_Bloodtype_WithRelatedData {get;set;}
public Stopwatch _Execution_Time_Delete_Bloodtype_With_Children {get;set;}
public Stopwatch _Execution_Time_Reset_Client_fees_By_Client {get;set;}
public Stopwatch _Execution_Time_Edit_Client_WithClient_fees {get;set;}
public Stopwatch _Execution_Time_Reset_Registration_By_Client {get;set;}
public Stopwatch _Execution_Time_Edit_Client_WithRegistration {get;set;}
public Stopwatch _Execution_Time_Edit_Client_WithRelatedData {get;set;}
public Stopwatch _Execution_Time_Delete_Client_With_Children {get;set;}
public Stopwatch _Execution_Time_Reset_Session_By_Client_fees {get;set;}
public Stopwatch _Execution_Time_Edit_Client_fees_WithSession {get;set;}
public Stopwatch _Execution_Time_Edit_Client_fees_WithRelatedData {get;set;}
public Stopwatch _Execution_Time_Delete_Client_fees_With_Children {get;set;}
public Stopwatch _Execution_Time_Reset_Client_fees_By_Currency {get;set;}
public Stopwatch _Execution_Time_Edit_Currency_WithClient_fees {get;set;}
public Stopwatch _Execution_Time_Reset_Fees_By_Currency {get;set;}
public Stopwatch _Execution_Time_Edit_Currency_WithFees {get;set;}
public Stopwatch _Execution_Time_Reset_Package_By_Currency {get;set;}
public Stopwatch _Execution_Time_Edit_Currency_WithPackage {get;set;}
public Stopwatch _Execution_Time_Reset_Registration_By_Currency {get;set;}
public Stopwatch _Execution_Time_Edit_Currency_WithRegistration {get;set;}
public Stopwatch _Execution_Time_Reset_Staff_fees_By_Currency {get;set;}
public Stopwatch _Execution_Time_Edit_Currency_WithStaff_fees {get;set;}
public Stopwatch _Execution_Time_Reset_Supplier_fees_By_Currency {get;set;}
public Stopwatch _Execution_Time_Edit_Currency_WithSupplier_fees {get;set;}
public Stopwatch _Execution_Time_Edit_Currency_WithRelatedData {get;set;}
public Stopwatch _Execution_Time_Delete_Currency_With_Children {get;set;}
public Stopwatch _Execution_Time_Reset_Address_By_Loc_l1 {get;set;}
public Stopwatch _Execution_Time_Edit_Loc_l1_WithAddress {get;set;}
public Stopwatch _Execution_Time_Reset_Loc_l2_By_Loc_l1 {get;set;}
public Stopwatch _Execution_Time_Edit_Loc_l1_WithLoc_l2 {get;set;}
public Stopwatch _Execution_Time_Edit_Loc_l1_WithRelatedData {get;set;}
public Stopwatch _Execution_Time_Delete_Loc_l1_With_Children {get;set;}
public Stopwatch _Execution_Time_Reset_Address_By_Loc_l2 {get;set;}
public Stopwatch _Execution_Time_Edit_Loc_l2_WithAddress {get;set;}
public Stopwatch _Execution_Time_Reset_Loc_l3_By_Loc_l2 {get;set;}
public Stopwatch _Execution_Time_Edit_Loc_l2_WithLoc_l3 {get;set;}
public Stopwatch _Execution_Time_Edit_Loc_l2_WithRelatedData {get;set;}
public Stopwatch _Execution_Time_Delete_Loc_l2_With_Children {get;set;}
public Stopwatch _Execution_Time_Reset_Address_By_Loc_l3 {get;set;}
public Stopwatch _Execution_Time_Edit_Loc_l3_WithAddress {get;set;}
public Stopwatch _Execution_Time_Reset_Loc_l4_By_Loc_l3 {get;set;}
public Stopwatch _Execution_Time_Edit_Loc_l3_WithLoc_l4 {get;set;}
public Stopwatch _Execution_Time_Edit_Loc_l3_WithRelatedData {get;set;}
public Stopwatch _Execution_Time_Delete_Loc_l3_With_Children {get;set;}
public Stopwatch _Execution_Time_Reset_Address_By_Loc_l4 {get;set;}
public Stopwatch _Execution_Time_Edit_Loc_l4_WithAddress {get;set;}
public Stopwatch _Execution_Time_Edit_Loc_l4_WithRelatedData {get;set;}
public Stopwatch _Execution_Time_Delete_Loc_l4_With_Children {get;set;}
public Stopwatch _Execution_Time_Reset_Client_fees_By_Package {get;set;}
public Stopwatch _Execution_Time_Edit_Package_WithClient_fees {get;set;}
public Stopwatch _Execution_Time_Reset_Registration_By_Package {get;set;}
public Stopwatch _Execution_Time_Edit_Package_WithRegistration {get;set;}
public Stopwatch _Execution_Time_Reset_Session_By_Package {get;set;}
public Stopwatch _Execution_Time_Edit_Package_WithSession {get;set;}
public Stopwatch _Execution_Time_Edit_Package_WithRelatedData {get;set;}
public Stopwatch _Execution_Time_Delete_Package_With_Children {get;set;}
public Stopwatch _Execution_Time_Reset_Address_By_Person {get;set;}
public Stopwatch _Execution_Time_Edit_Person_WithAddress {get;set;}
public Stopwatch _Execution_Time_Reset_Contact_By_Person {get;set;}
public Stopwatch _Execution_Time_Edit_Person_WithContact {get;set;}
public Stopwatch _Execution_Time_Edit_Person_WithRelatedData {get;set;}
public Stopwatch _Execution_Time_Delete_Person_With_Children {get;set;}
public Stopwatch _Execution_Time_Reset_Client_fees_By_Registration {get;set;}
public Stopwatch _Execution_Time_Edit_Registration_WithClient_fees {get;set;}
public Stopwatch _Execution_Time_Edit_Registration_WithRelatedData {get;set;}
public Stopwatch _Execution_Time_Delete_Registration_With_Children {get;set;}
public Stopwatch _Execution_Time_Reset_Staff_fees_By_Staff {get;set;}
public Stopwatch _Execution_Time_Edit_Staff_WithStaff_fees {get;set;}
public Stopwatch _Execution_Time_Edit_Staff_WithRelatedData {get;set;}
public Stopwatch _Execution_Time_Delete_Staff_With_Children {get;set;}
public Stopwatch _Execution_Time_Reset_Supplier_fees_By_Supplier {get;set;}
public Stopwatch _Execution_Time_Edit_Supplier_WithSupplier_fees {get;set;}
public Stopwatch _Execution_Time_Edit_Supplier_WithRelatedData {get;set;}
public Stopwatch _Execution_Time_Delete_Supplier_With_Children {get;set;}
public Stopwatch _Execution_Time_Check_Address_Uniqueness_Violation {get;set;}
public Stopwatch _Execution_Time_Check_Contact_Uniqueness_Violation {get;set;}
public Stopwatch _Execution_Time_Check_Loc_l1_Uniqueness_Violation {get;set;}
public Stopwatch _Execution_Time_Check_Loc_l2_Uniqueness_Violation {get;set;}
public Stopwatch _Execution_Time_Check_Loc_l3_Uniqueness_Violation {get;set;}
public Stopwatch _Execution_Time_Check_Loc_l4_Uniqueness_Violation {get;set;}
public Stopwatch _Execution_Time_Monitor_API_Calls {get;set;}
public Stopwatch _Execution_Time_EditSetup {get;set;}
public Stopwatch _Execution_Time_ResolveTicket_JWT {get;set;}
public Stopwatch _Execution_Time_Prepare_Ticket_JWT {get;set;}
public Stopwatch _Execution_Time_IsValidTicket_JWT {get;set;}
public Stopwatch _Execution_Time_Authenticate {get;set;}
public Stopwatch _Execution_Time_ResolveTicket {get;set;}
public Stopwatch _Execution_Time_IsValidTicket {get;set;}
public Stopwatch _Execution_Time_Prepare_Ticket {get;set;}
public Stopwatch _Execution_Time_Sales_Sum {get;set;}
public Stopwatch _Execution_Time_Expenses_Sum {get;set;}
public Stopwatch _Execution_Time_GetGrandProfit {get;set;}
public Stopwatch _Execution_Time_CheckClientPaymentStatus {get;set;}
public Stopwatch _Execution_Time_CalculateSupplierBalance {get;set;}
public Stopwatch _Execution_Time_CalculateStaffBalance {get;set;}
public Stopwatch _Execution_Time_UP_CHECK_USER_EXISTENCE {get;set;}
public Stopwatch _Execution_Time_UpdatePassword {get;set;}
public Stopwatch _Execution_Time_LoginFct {get;set;}
public Stopwatch _Execution_Time_get_oTools {get;set;}
public Stopwatch _Execution_Time_set_oTools {get;set;}
public Stopwatch _Execution_Time_get_ConnectionString {get;set;}
public Stopwatch _Execution_Time_set_ConnectionString {get;set;}
public Stopwatch _Execution_Time_get_UserID {get;set;}
public Stopwatch _Execution_Time_set_UserID {get;set;}
public Stopwatch _Execution_Time_get_OwnerID {get;set;}
public Stopwatch _Execution_Time_set_OwnerID {get;set;}
public Stopwatch _Execution_Time_get_Language {get;set;}
public Stopwatch _Execution_Time_set_Language {get;set;}
public Stopwatch _Execution_Time_get_Messages_FilePath {get;set;}
public Stopwatch _Execution_Time_set_Messages_FilePath {get;set;}
public Stopwatch _Execution_Time_get_Messages {get;set;}
public Stopwatch _Execution_Time_set_Messages {get;set;}
public Stopwatch _Execution_Time_get_Environment {get;set;}
public Stopwatch _Execution_Time_set_Environment {get;set;}
public Stopwatch _Execution_Time_SubscribeToEvents {get;set;}
public Stopwatch _Execution_Time_Dispose {get;set;}
public Stopwatch _Execution_Time_LoadMessages {get;set;}
public Stopwatch _Execution_Time_GetMessageContent {get;set;}
public Stopwatch _Execution_Time_Initialize_Monitoring_Mechanism {get;set;}
public Stopwatch _Execution_Time_Check_Method_Usage {get;set;}
public Stopwatch _Execution_Time_Get_Address_By_ADDRESS_ID {get;set;}
public Stopwatch _Execution_Time_Get_Bloodtype_By_BLOODTYPE_ID {get;set;}
public Stopwatch _Execution_Time_Get_Client_By_CLIENT_ID {get;set;}
public Stopwatch _Execution_Time_Get_Client_fees_By_CLIENT_FEES_ID {get;set;}
public Stopwatch _Execution_Time_Get_Contact_By_CONTACT_ID {get;set;}
public Stopwatch _Execution_Time_Get_Currency_By_CURRENCY_ID {get;set;}
public Stopwatch _Execution_Time_Get_Fees_By_FEES_ID {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l1_By_LOC_L1_ID {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l2_By_LOC_L2_ID {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l3_By_LOC_L3_ID {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l4_By_LOC_L4_ID {get;set;}
public Stopwatch _Execution_Time_Get_Method_run_By_METHOD_RUN_ID {get;set;}
public Stopwatch _Execution_Time_Get_Owner_By_OWNER_ID {get;set;}
public Stopwatch _Execution_Time_Get_Package_By_PACKAGE_ID {get;set;}
public Stopwatch _Execution_Time_Get_Person_By_PERSON_ID {get;set;}
public Stopwatch _Execution_Time_Get_Registration_By_REGISTRATION_ID {get;set;}
public Stopwatch _Execution_Time_Get_Session_By_SESSION_ID {get;set;}
public Stopwatch _Execution_Time_Get_Staff_By_STAFF_ID {get;set;}
public Stopwatch _Execution_Time_Get_Staff_fees_By_STAFF_FEES_ID {get;set;}
public Stopwatch _Execution_Time_Get_Supplier_By_SUPPLIER_ID {get;set;}
public Stopwatch _Execution_Time_Get_Supplier_fees_By_SUPPLIER_FEES_ID {get;set;}
public Stopwatch _Execution_Time_Get_User_By_USER_ID {get;set;}
public Stopwatch _Execution_Time_Get_Address_By_ADDRESS_ID_List {get;set;}
public Stopwatch _Execution_Time_Get_Bloodtype_By_BLOODTYPE_ID_List {get;set;}
public Stopwatch _Execution_Time_Get_Client_By_CLIENT_ID_List {get;set;}
public Stopwatch _Execution_Time_Get_Client_fees_By_CLIENT_FEES_ID_List {get;set;}
public Stopwatch _Execution_Time_Get_Contact_By_CONTACT_ID_List {get;set;}
public Stopwatch _Execution_Time_Get_Currency_By_CURRENCY_ID_List {get;set;}
public Stopwatch _Execution_Time_Get_Fees_By_FEES_ID_List {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l1_By_LOC_L1_ID_List {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l2_By_LOC_L2_ID_List {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l3_By_LOC_L3_ID_List {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l4_By_LOC_L4_ID_List {get;set;}
public Stopwatch _Execution_Time_Get_Method_run_By_METHOD_RUN_ID_List {get;set;}
public Stopwatch _Execution_Time_Get_Owner_By_OWNER_ID_List {get;set;}
public Stopwatch _Execution_Time_Get_Package_By_PACKAGE_ID_List {get;set;}
public Stopwatch _Execution_Time_Get_Person_By_PERSON_ID_List {get;set;}
public Stopwatch _Execution_Time_Get_Registration_By_REGISTRATION_ID_List {get;set;}
public Stopwatch _Execution_Time_Get_Session_By_SESSION_ID_List {get;set;}
public Stopwatch _Execution_Time_Get_Staff_By_STAFF_ID_List {get;set;}
public Stopwatch _Execution_Time_Get_Staff_fees_By_STAFF_FEES_ID_List {get;set;}
public Stopwatch _Execution_Time_Get_Supplier_By_SUPPLIER_ID_List {get;set;}
public Stopwatch _Execution_Time_Get_Supplier_fees_By_SUPPLIER_FEES_ID_List {get;set;}
public Stopwatch _Execution_Time_Get_User_By_USER_ID_List {get;set;}
public Stopwatch _Execution_Time_Get_Address_By_PERSON_ID {get;set;}
public Stopwatch _Execution_Time_Get_Address_By_LOC_L1_ID {get;set;}
public Stopwatch _Execution_Time_Get_Address_By_LOC_L2_ID {get;set;}
public Stopwatch _Execution_Time_Get_Address_By_LOC_L3_ID {get;set;}
public Stopwatch _Execution_Time_Get_Address_By_OWNER_ID {get;set;}
public Stopwatch _Execution_Time_Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE {get;set;}
public Stopwatch _Execution_Time_Get_Address_By_LOC_L4_ID {get;set;}
public Stopwatch _Execution_Time_Get_Bloodtype_By_OWNER_ID {get;set;}
public Stopwatch _Execution_Time_Get_Client_By_OWNER_ID {get;set;}
public Stopwatch _Execution_Time_Get_Client_By_BLOODTYPE_ID {get;set;}
public Stopwatch _Execution_Time_Get_Client_fees_By_OWNER_ID {get;set;}
public Stopwatch _Execution_Time_Get_Client_fees_By_CLIENT_ID {get;set;}
public Stopwatch _Execution_Time_Get_Client_fees_By_CURRENCY_ID {get;set;}
public Stopwatch _Execution_Time_Get_Client_fees_By_PACKAGE_ID {get;set;}
public Stopwatch _Execution_Time_Get_Client_fees_By_REGISTRATION_ID {get;set;}
public Stopwatch _Execution_Time_Get_Contact_By_PERSON_ID {get;set;}
public Stopwatch _Execution_Time_Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT {get;set;}
public Stopwatch _Execution_Time_Get_Contact_By_OWNER_ID {get;set;}
public Stopwatch _Execution_Time_Get_Currency_By_OWNER_ID {get;set;}
public Stopwatch _Execution_Time_Get_Fees_By_OWNER_ID {get;set;}
public Stopwatch _Execution_Time_Get_Fees_By_CURRENCY_ID {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l1_By_CODE {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l1_By_OWNER_ID {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l2_By_LOC_L1_ID_CODE {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l2_By_LOC_L1_ID {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l2_By_OWNER_ID {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l3_By_LOC_L2_ID_CODE {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l3_By_LOC_L2_ID {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l3_By_OWNER_ID {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l4_By_LOC_L3_ID_CODE {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l4_By_LOC_L3_ID {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l4_By_OWNER_ID {get;set;}
public Stopwatch _Execution_Time_Get_Method_run_By_OWNER_ID {get;set;}
public Stopwatch _Execution_Time_Get_Package_By_OWNER_ID {get;set;}
public Stopwatch _Execution_Time_Get_Package_By_CURRENCY_ID {get;set;}
public Stopwatch _Execution_Time_Get_Person_By_OWNER_ID {get;set;}
public Stopwatch _Execution_Time_Get_Registration_By_OWNER_ID {get;set;}
public Stopwatch _Execution_Time_Get_Registration_By_CLIENT_ID {get;set;}
public Stopwatch _Execution_Time_Get_Registration_By_PACKAGE_ID {get;set;}
public Stopwatch _Execution_Time_Get_Registration_By_CURRENCY_ID {get;set;}
public Stopwatch _Execution_Time_Get_Session_By_OWNER_ID {get;set;}
public Stopwatch _Execution_Time_Get_Session_By_PACKAGE_ID {get;set;}
public Stopwatch _Execution_Time_Get_Session_By_CLIENT_FEES_ID {get;set;}
public Stopwatch _Execution_Time_Get_Staff_By_OWNER_ID {get;set;}
public Stopwatch _Execution_Time_Get_Staff_By_BLOODTYPE_ID {get;set;}
public Stopwatch _Execution_Time_Get_Staff_fees_By_OWNER_ID {get;set;}
public Stopwatch _Execution_Time_Get_Staff_fees_By_STAFF_ID {get;set;}
public Stopwatch _Execution_Time_Get_Staff_fees_By_CURRENCY_ID {get;set;}
public Stopwatch _Execution_Time_Get_Supplier_By_OWNER_ID {get;set;}
public Stopwatch _Execution_Time_Get_Supplier_By_BLOODTYPE_ID {get;set;}
public Stopwatch _Execution_Time_Get_Supplier_fees_By_OWNER_ID {get;set;}
public Stopwatch _Execution_Time_Get_Supplier_fees_By_SUPPLIER_ID {get;set;}
public Stopwatch _Execution_Time_Get_Supplier_fees_By_CURRENCY_ID {get;set;}
public Stopwatch _Execution_Time_Get_User_By_OWNER_ID {get;set;}
public Stopwatch _Execution_Time_Get_User_By_USERNAME {get;set;}
public Stopwatch _Execution_Time_Get_Address_By_PERSON_ID_List {get;set;}
public Stopwatch _Execution_Time_Get_Address_By_LOC_L1_ID_List {get;set;}
public Stopwatch _Execution_Time_Get_Address_By_LOC_L2_ID_List {get;set;}
public Stopwatch _Execution_Time_Get_Address_By_LOC_L3_ID_List {get;set;}
public Stopwatch _Execution_Time_Get_Address_By_LOC_L4_ID_List {get;set;}
public Stopwatch _Execution_Time_Get_Client_By_BLOODTYPE_ID_List {get;set;}
public Stopwatch _Execution_Time_Get_Client_fees_By_CLIENT_ID_List {get;set;}
public Stopwatch _Execution_Time_Get_Client_fees_By_CURRENCY_ID_List {get;set;}
public Stopwatch _Execution_Time_Get_Client_fees_By_PACKAGE_ID_List {get;set;}
public Stopwatch _Execution_Time_Get_Client_fees_By_REGISTRATION_ID_List {get;set;}
public Stopwatch _Execution_Time_Get_Contact_By_PERSON_ID_List {get;set;}
public Stopwatch _Execution_Time_Get_Fees_By_CURRENCY_ID_List {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l2_By_LOC_L1_ID_List {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l3_By_LOC_L2_ID_List {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l4_By_LOC_L3_ID_List {get;set;}
public Stopwatch _Execution_Time_Get_Package_By_CURRENCY_ID_List {get;set;}
public Stopwatch _Execution_Time_Get_Registration_By_CLIENT_ID_List {get;set;}
public Stopwatch _Execution_Time_Get_Registration_By_PACKAGE_ID_List {get;set;}
public Stopwatch _Execution_Time_Get_Registration_By_CURRENCY_ID_List {get;set;}
public Stopwatch _Execution_Time_Get_Session_By_PACKAGE_ID_List {get;set;}
public Stopwatch _Execution_Time_Get_Session_By_CLIENT_FEES_ID_List {get;set;}
public Stopwatch _Execution_Time_Get_Staff_By_BLOODTYPE_ID_List {get;set;}
public Stopwatch _Execution_Time_Get_Staff_fees_By_STAFF_ID_List {get;set;}
public Stopwatch _Execution_Time_Get_Staff_fees_By_CURRENCY_ID_List {get;set;}
public Stopwatch _Execution_Time_Get_Supplier_By_BLOODTYPE_ID_List {get;set;}
public Stopwatch _Execution_Time_Get_Supplier_fees_By_SUPPLIER_ID_List {get;set;}
public Stopwatch _Execution_Time_Get_Supplier_fees_By_CURRENCY_ID_List {get;set;}
public Stopwatch _Execution_Time_Get_Address_By_Criteria {get;set;}
public Stopwatch _Execution_Time_Get_Address_By_Where {get;set;}
public Stopwatch _Execution_Time_Get_Address_By_Criteria_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Address_By_Where_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Bloodtype_By_Criteria {get;set;}
public Stopwatch _Execution_Time_Get_Bloodtype_By_Where {get;set;}
public Stopwatch _Execution_Time_Get_Client_By_Criteria {get;set;}
public Stopwatch _Execution_Time_Get_Client_By_Where {get;set;}
public Stopwatch _Execution_Time_Get_Client_By_Criteria_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Client_By_Where_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Client_fees_By_Criteria {get;set;}
public Stopwatch _Execution_Time_Get_Client_fees_By_Where {get;set;}
public Stopwatch _Execution_Time_Get_Contact_By_Criteria {get;set;}
public Stopwatch _Execution_Time_Get_Contact_By_Where {get;set;}
public Stopwatch _Execution_Time_Get_Currency_By_Criteria {get;set;}
public Stopwatch _Execution_Time_Get_Currency_By_Where {get;set;}
public Stopwatch _Execution_Time_Get_Fees_By_Criteria {get;set;}
public Stopwatch _Execution_Time_Get_Fees_By_Where {get;set;}
public Stopwatch _Execution_Time_Get_Fees_By_Criteria_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Fees_By_Where_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l1_By_Criteria {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l1_By_Where {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l2_By_Criteria {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l2_By_Where {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l3_By_Criteria {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l3_By_Where {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l4_By_Criteria {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l4_By_Where {get;set;}
public Stopwatch _Execution_Time_Get_Method_run_By_Criteria {get;set;}
public Stopwatch _Execution_Time_Get_Method_run_By_Where {get;set;}
public Stopwatch _Execution_Time_Get_Method_run_By_Criteria_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Method_run_By_Where_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Owner_By_Criteria {get;set;}
public Stopwatch _Execution_Time_Get_Owner_By_Where {get;set;}
public Stopwatch _Execution_Time_Get_Owner_By_Criteria_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Owner_By_Where_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Package_By_Criteria {get;set;}
public Stopwatch _Execution_Time_Get_Package_By_Where {get;set;}
public Stopwatch _Execution_Time_Get_Package_By_Criteria_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Package_By_Where_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Person_By_Criteria {get;set;}
public Stopwatch _Execution_Time_Get_Person_By_Where {get;set;}
public Stopwatch _Execution_Time_Get_Person_By_Criteria_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Person_By_Where_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Registration_By_Criteria {get;set;}
public Stopwatch _Execution_Time_Get_Registration_By_Where {get;set;}
public Stopwatch _Execution_Time_Get_Registration_By_Criteria_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Registration_By_Where_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Session_By_Criteria {get;set;}
public Stopwatch _Execution_Time_Get_Session_By_Where {get;set;}
public Stopwatch _Execution_Time_Get_Session_By_Criteria_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Session_By_Where_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Staff_By_Criteria {get;set;}
public Stopwatch _Execution_Time_Get_Staff_By_Where {get;set;}
public Stopwatch _Execution_Time_Get_Staff_By_Criteria_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Staff_By_Where_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Staff_fees_By_Criteria {get;set;}
public Stopwatch _Execution_Time_Get_Staff_fees_By_Where {get;set;}
public Stopwatch _Execution_Time_Get_Supplier_By_Criteria {get;set;}
public Stopwatch _Execution_Time_Get_Supplier_By_Where {get;set;}
public Stopwatch _Execution_Time_Get_Supplier_By_Criteria_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Supplier_By_Where_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Supplier_fees_By_Criteria {get;set;}
public Stopwatch _Execution_Time_Get_Supplier_fees_By_Where {get;set;}
public Stopwatch _Execution_Time_Get_User_By_Criteria {get;set;}
public Stopwatch _Execution_Time_Get_User_By_Where {get;set;}
public Stopwatch _Execution_Time_Get_Address_By_Criteria_InList {get;set;}
public Stopwatch _Execution_Time_Get_Address_By_Where_InList {get;set;}
public Stopwatch _Execution_Time_Get_Address_By_Criteria_InList_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Address_By_Where_InList_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Client_By_Criteria_InList {get;set;}
public Stopwatch _Execution_Time_Get_Client_By_Where_InList {get;set;}
public Stopwatch _Execution_Time_Get_Client_By_Criteria_InList_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Client_By_Where_InList_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Client_fees_By_Criteria_InList {get;set;}
public Stopwatch _Execution_Time_Get_Client_fees_By_Where_InList {get;set;}
public Stopwatch _Execution_Time_Get_Contact_By_Criteria_InList {get;set;}
public Stopwatch _Execution_Time_Get_Contact_By_Where_InList {get;set;}
public Stopwatch _Execution_Time_Get_Fees_By_Criteria_InList {get;set;}
public Stopwatch _Execution_Time_Get_Fees_By_Where_InList {get;set;}
public Stopwatch _Execution_Time_Get_Fees_By_Criteria_InList_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Fees_By_Where_InList_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l2_By_Criteria_InList {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l2_By_Where_InList {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l3_By_Criteria_InList {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l3_By_Where_InList {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l4_By_Criteria_InList {get;set;}
public Stopwatch _Execution_Time_Get_Loc_l4_By_Where_InList {get;set;}
public Stopwatch _Execution_Time_Get_Package_By_Criteria_InList {get;set;}
public Stopwatch _Execution_Time_Get_Package_By_Where_InList {get;set;}
public Stopwatch _Execution_Time_Get_Package_By_Criteria_InList_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Package_By_Where_InList_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Registration_By_Criteria_InList {get;set;}
public Stopwatch _Execution_Time_Get_Registration_By_Where_InList {get;set;}
public Stopwatch _Execution_Time_Get_Registration_By_Criteria_InList_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Registration_By_Where_InList_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Session_By_Criteria_InList {get;set;}
public Stopwatch _Execution_Time_Get_Session_By_Where_InList {get;set;}
public Stopwatch _Execution_Time_Get_Session_By_Criteria_InList_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Session_By_Where_InList_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Staff_By_Criteria_InList {get;set;}
public Stopwatch _Execution_Time_Get_Staff_By_Where_InList {get;set;}
public Stopwatch _Execution_Time_Get_Staff_By_Criteria_InList_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Staff_By_Where_InList_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Staff_fees_By_Criteria_InList {get;set;}
public Stopwatch _Execution_Time_Get_Staff_fees_By_Where_InList {get;set;}
public Stopwatch _Execution_Time_Get_Supplier_By_Criteria_InList {get;set;}
public Stopwatch _Execution_Time_Get_Supplier_By_Where_InList {get;set;}
public Stopwatch _Execution_Time_Get_Supplier_By_Criteria_InList_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Supplier_By_Where_InList_V2 {get;set;}
public Stopwatch _Execution_Time_Get_Supplier_fees_By_Criteria_InList {get;set;}
public Stopwatch _Execution_Time_Get_Supplier_fees_By_Where_InList {get;set;}
public Stopwatch _Execution_Time_Delete_Address {get;set;}
public Stopwatch _Execution_Time_Delete_Bloodtype {get;set;}
public Stopwatch _Execution_Time_Delete_Client {get;set;}
public Stopwatch _Execution_Time_Delete_Client_fees {get;set;}
public Stopwatch _Execution_Time_Delete_Contact {get;set;}
public Stopwatch _Execution_Time_Delete_Currency {get;set;}
public Stopwatch _Execution_Time_Delete_Fees {get;set;}
public Stopwatch _Execution_Time_Delete_Loc_l1 {get;set;}
public Stopwatch _Execution_Time_Delete_Loc_l2 {get;set;}
public Stopwatch _Execution_Time_Delete_Loc_l3 {get;set;}
public Stopwatch _Execution_Time_Delete_Loc_l4 {get;set;}
public Stopwatch _Execution_Time_Delete_Method_run {get;set;}
public Stopwatch _Execution_Time_Delete_Owner {get;set;}
public Stopwatch _Execution_Time_Delete_Package {get;set;}
public Stopwatch _Execution_Time_Delete_Person {get;set;}
public Stopwatch _Execution_Time_Delete_Registration {get;set;}
public Stopwatch _Execution_Time_Delete_Session {get;set;}
public Stopwatch _Execution_Time_Delete_Staff {get;set;}
public Stopwatch _Execution_Time_Delete_Staff_fees {get;set;}
public Stopwatch _Execution_Time_Delete_Supplier {get;set;}
public Stopwatch _Execution_Time_Delete_Supplier_fees {get;set;}
public Stopwatch _Execution_Time_Delete_User {get;set;}
public Stopwatch _Execution_Time_Delete_Address_By_PERSON_ID {get;set;}
public Stopwatch _Execution_Time_Delete_Address_By_LOC_L1_ID {get;set;}
public Stopwatch _Execution_Time_Delete_Address_By_LOC_L2_ID {get;set;}
public Stopwatch _Execution_Time_Delete_Address_By_LOC_L3_ID {get;set;}
public Stopwatch _Execution_Time_Delete_Address_By_OWNER_ID {get;set;}
public Stopwatch _Execution_Time_Delete_Address_By_PERSON_ID_ADDRESS_TYPE_CODE {get;set;}
public Stopwatch _Execution_Time_Delete_Address_By_LOC_L4_ID {get;set;}
public Stopwatch _Execution_Time_Delete_Bloodtype_By_OWNER_ID {get;set;}
public Stopwatch _Execution_Time_Delete_Client_By_OWNER_ID {get;set;}
public Stopwatch _Execution_Time_Delete_Client_By_BLOODTYPE_ID {get;set;}
public Stopwatch _Execution_Time_Delete_Client_fees_By_OWNER_ID {get;set;}
public Stopwatch _Execution_Time_Delete_Client_fees_By_CLIENT_ID {get;set;}
public Stopwatch _Execution_Time_Delete_Client_fees_By_CURRENCY_ID {get;set;}
public Stopwatch _Execution_Time_Delete_Client_fees_By_PACKAGE_ID {get;set;}
public Stopwatch _Execution_Time_Delete_Client_fees_By_REGISTRATION_ID {get;set;}
public Stopwatch _Execution_Time_Delete_Contact_By_PERSON_ID {get;set;}
public Stopwatch _Execution_Time_Delete_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT {get;set;}
public Stopwatch _Execution_Time_Delete_Contact_By_OWNER_ID {get;set;}
public Stopwatch _Execution_Time_Delete_Currency_By_OWNER_ID {get;set;}
public Stopwatch _Execution_Time_Delete_Fees_By_OWNER_ID {get;set;}
public Stopwatch _Execution_Time_Delete_Fees_By_CURRENCY_ID {get;set;}
public Stopwatch _Execution_Time_Delete_Loc_l1_By_CODE {get;set;}
public Stopwatch _Execution_Time_Delete_Loc_l1_By_OWNER_ID {get;set;}
public Stopwatch _Execution_Time_Delete_Loc_l2_By_LOC_L1_ID_CODE {get;set;}
public Stopwatch _Execution_Time_Delete_Loc_l2_By_LOC_L1_ID {get;set;}
public Stopwatch _Execution_Time_Delete_Loc_l2_By_OWNER_ID {get;set;}
public Stopwatch _Execution_Time_Delete_Loc_l3_By_LOC_L2_ID_CODE {get;set;}
public Stopwatch _Execution_Time_Delete_Loc_l3_By_LOC_L2_ID {get;set;}
public Stopwatch _Execution_Time_Delete_Loc_l3_By_OWNER_ID {get;set;}
public Stopwatch _Execution_Time_Delete_Loc_l4_By_LOC_L3_ID_CODE {get;set;}
public Stopwatch _Execution_Time_Delete_Loc_l4_By_LOC_L3_ID {get;set;}
public Stopwatch _Execution_Time_Delete_Loc_l4_By_OWNER_ID {get;set;}
public Stopwatch _Execution_Time_Delete_Method_run_By_OWNER_ID {get;set;}
public Stopwatch _Execution_Time_Delete_Package_By_OWNER_ID {get;set;}
public Stopwatch _Execution_Time_Delete_Package_By_CURRENCY_ID {get;set;}
public Stopwatch _Execution_Time_Delete_Person_By_OWNER_ID {get;set;}
public Stopwatch _Execution_Time_Delete_Registration_By_OWNER_ID {get;set;}
public Stopwatch _Execution_Time_Delete_Registration_By_CLIENT_ID {get;set;}
public Stopwatch _Execution_Time_Delete_Registration_By_PACKAGE_ID {get;set;}
public Stopwatch _Execution_Time_Delete_Registration_By_CURRENCY_ID {get;set;}
public Stopwatch _Execution_Time_Delete_Session_By_OWNER_ID {get;set;}
public Stopwatch _Execution_Time_Delete_Session_By_PACKAGE_ID {get;set;}
public Stopwatch _Execution_Time_Delete_Session_By_CLIENT_FEES_ID {get;set;}
public Stopwatch _Execution_Time_Delete_Staff_By_OWNER_ID {get;set;}
public Stopwatch _Execution_Time_Delete_Staff_By_BLOODTYPE_ID {get;set;}
public Stopwatch _Execution_Time_Delete_Staff_fees_By_OWNER_ID {get;set;}
public Stopwatch _Execution_Time_Delete_Staff_fees_By_STAFF_ID {get;set;}
public Stopwatch _Execution_Time_Delete_Staff_fees_By_CURRENCY_ID {get;set;}
public Stopwatch _Execution_Time_Delete_Supplier_By_OWNER_ID {get;set;}
public Stopwatch _Execution_Time_Delete_Supplier_By_BLOODTYPE_ID {get;set;}
public Stopwatch _Execution_Time_Delete_Supplier_fees_By_OWNER_ID {get;set;}
public Stopwatch _Execution_Time_Delete_Supplier_fees_By_SUPPLIER_ID {get;set;}
public Stopwatch _Execution_Time_Delete_Supplier_fees_By_CURRENCY_ID {get;set;}
public Stopwatch _Execution_Time_Delete_User_By_OWNER_ID {get;set;}
public Stopwatch _Execution_Time_Delete_User_By_USERNAME {get;set;}
public Stopwatch _Execution_Time_Edit_Address {get;set;}
public Stopwatch _Execution_Time_Edit_Bloodtype {get;set;}
public Stopwatch _Execution_Time_Edit_Client {get;set;}
public Stopwatch _Execution_Time_Edit_Client_fees {get;set;}
public Stopwatch _Execution_Time_Edit_Contact {get;set;}
public Stopwatch _Execution_Time_Edit_Currency {get;set;}
public Stopwatch _Execution_Time_Edit_Fees {get;set;}
public Stopwatch _Execution_Time_Edit_Loc_l1 {get;set;}
public Stopwatch _Execution_Time_Edit_Loc_l2 {get;set;}
public Stopwatch _Execution_Time_Edit_Loc_l3 {get;set;}
public Stopwatch _Execution_Time_Edit_Loc_l4 {get;set;}
public Stopwatch _Execution_Time_Edit_Method_run {get;set;}
public Stopwatch _Execution_Time_Edit_Owner {get;set;}
public Stopwatch _Execution_Time_Edit_Package {get;set;}
public Stopwatch _Execution_Time_Edit_Person {get;set;}
public Stopwatch _Execution_Time_Edit_Registration {get;set;}
public Stopwatch _Execution_Time_Edit_Session {get;set;}
public Stopwatch _Execution_Time_Edit_Staff {get;set;}
public Stopwatch _Execution_Time_Edit_Staff_fees {get;set;}
public Stopwatch _Execution_Time_Edit_Supplier {get;set;}
public Stopwatch _Execution_Time_Edit_Supplier_fees {get;set;}
public Stopwatch _Execution_Time_Edit_User {get;set;}
public Stopwatch _Execution_Time_Edit_Address_List {get;set;}
public Stopwatch _Execution_Time_Edit_Bloodtype_List {get;set;}
public Stopwatch _Execution_Time_Edit_Client_List {get;set;}
public Stopwatch _Execution_Time_Edit_Client_fees_List {get;set;}
public Stopwatch _Execution_Time_Edit_Contact_List {get;set;}
public Stopwatch _Execution_Time_Edit_Currency_List {get;set;}
public Stopwatch _Execution_Time_Edit_Fees_List {get;set;}
public Stopwatch _Execution_Time_Edit_Loc_l1_List {get;set;}
public Stopwatch _Execution_Time_Edit_Loc_l2_List {get;set;}
public Stopwatch _Execution_Time_Edit_Loc_l3_List {get;set;}
public Stopwatch _Execution_Time_Edit_Loc_l4_List {get;set;}
public Stopwatch _Execution_Time_Edit_Method_run_List {get;set;}
public Stopwatch _Execution_Time_Edit_Owner_List {get;set;}
public Stopwatch _Execution_Time_Edit_Package_List {get;set;}
public Stopwatch _Execution_Time_Edit_Person_List {get;set;}
public Stopwatch _Execution_Time_Edit_Registration_List {get;set;}
public Stopwatch _Execution_Time_Edit_Session_List {get;set;}
public Stopwatch _Execution_Time_Edit_Staff_List {get;set;}
public Stopwatch _Execution_Time_Edit_Staff_fees_List {get;set;}
public Stopwatch _Execution_Time_Edit_Supplier_List {get;set;}
public Stopwatch _Execution_Time_Edit_Supplier_fees_List {get;set;}
public Stopwatch _Execution_Time_Edit_User_List {get;set;}
public Stopwatch _Execution_Time_GetType {get;set;}
public Stopwatch _Execution_Time_ToString {get;set;}
public Stopwatch _Execution_Time_Equals {get;set;}
public Stopwatch _Execution_Time_GetHashCode {get;set;}
#endregion
#region Initialize_Monitoring_Mechanism
public void Initialize_Monitoring_Mechanism()
{
#region Declaration And Initialization Section.
#endregion
#region Body Section.
if
(
(ConfigurationManager.AppSettings["DISABLE_MONITORING"] == null) ||
(ConfigurationManager.AppSettings["DISABLE_MONITORING"] == "0")
)
{
this.OnPreEvent_General += new PreEvent_Handler_General(BLC_OnPreEvent_General_Monitoring);
this.OnPostEvent_General += new PostEvent_Handler_General(BLC_OnPostEvent_General_Monitoring);
}

#endregion
}
#endregion
#region BLC_OnPreEvent_General_Monitoring
void BLC_OnPreEvent_General_Monitoring(string i_MethodName)
{
#region Declaration And Initialization Section.
#endregion
#region Body Section.
var oStopWatch = (Stopwatch)oTools.GetPropValue(this, string.Format("_Execution_Time_{0}", i_MethodName));
oTools.SetPropValue(this, string.Format("_Execution_Time_{0}", i_MethodName), Stopwatch.StartNew());
#endregion
}
#endregion
#region BLC_OnPostEvent_General_Monitoring
void BLC_OnPostEvent_General_Monitoring(string i_MethodName)
{
#region Declaration And Initialization Section.
Method_run oMethod_run = new Method_run();
#endregion
#region Body Section.
oTools.SetPropertiesDefaultValue(oMethod_run);
oMethod_run.METHOD_RUN_ID = -1;
oMethod_run.METHOD_NAME = i_MethodName;
oMethod_run.RUN_DATE   = oTools.GetDateString(DateTime.Today);
oMethod_run.RUN_HOUR   = DateTime.Now.Hour;
oMethod_run.RUN_MINUTE = DateTime.Now.Minute;
oMethod_run.RUN_SECOND = DateTime.Now.Second;
// Calculate Execution time
if (oTools.GetPropValue(this, string.Format("_Execution_Time_{0}", i_MethodName)) != null)
{
var oStopWatch = (Stopwatch)oTools.GetPropValue(this, string.Format("_Execution_Time_{0}", i_MethodName));
oStopWatch.Stop();
var elapsedMs = oStopWatch.ElapsedMilliseconds;
oMethod_run.EXECUTION_TIME = (Int32)elapsedMs;
}
Edit_Method_run(oMethod_run);
#endregion
}
#endregion
 #region Check_Method_Usage
public List<Method_usage> Check_Method_Usage()
        {
            #region Declaration And Initialization Section.
            Type oType = null;
            Assembly oAssembly = null;

            string str_BaseDirectory = string.Empty;
            string str_AssemblyPath = string.Empty;            
            
            MethodInfo[] oMethodInfos = null;
            List<MethodInfo> oList_MethodInfo = new List<MethodInfo>();

            List<Method_run> oList_Method_run = new List<Method_run>();
            Params_Get_Method_run_By_OWNER_ID oParams_Get_Method_run_By_OWNER_ID = new Params_Get_Method_run_By_OWNER_ID();

            Method_usage oMethod_usage = new Method_usage();
            List<Method_usage> oList_Method_usage = new List<Method_usage>();

            Int32 i_Count= 0;
            Tools.Tools oTools = new Tools.Tools();
            #endregion
            #region Body Section.

            // Prepare assembly path
            // -------------
            str_BaseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            str_AssemblyPath = string.Format(@"{0}{1}.dll", str_BaseDirectory,"BLC");
            // -------------
            
            if (oTools.Is_FileExists(str_AssemblyPath) == true)
            {
                // Load corresponding type
                // -------------
                oAssembly = System.Reflection.Assembly.Load(System.IO.File.ReadAllBytes(str_AssemblyPath));
                oType = oAssembly.GetType(string.Format("{0}.BLC","BLC"), true);
                // -------------

                // -------------
                if (oType != null)
                {
                    oMethodInfos = oType.GetMethods();
                    if (oMethodInfos != null)
                    {                        
                        oList_MethodInfo = oMethodInfos.ToList();
                        if (oList_MethodInfo != null)
                        {
                            // Remove events
                            // ----------
                            oList_MethodInfo.RemoveAll(x => x.Name.StartsWith("add_") || x.Name.StartsWith("remove_"));
                            // ----------

                            // Get all entries in TBL_METHOD_RUN
                            // ----------
                            oParams_Get_Method_run_By_OWNER_ID = new Params_Get_Method_run_By_OWNER_ID();
                            oParams_Get_Method_run_By_OWNER_ID.OWNER_ID = this.OwnerID;
                            oList_Method_run = Get_Method_run_By_OWNER_ID(oParams_Get_Method_run_By_OWNER_ID);
                            // ----------

                            // Collection Method usage
                            // ----------
                            foreach(var oRow_MethodInfo in oList_MethodInfo)
                            {
                                i_Count = (from oItem in oList_Method_run where (oItem.METHOD_NAME == oRow_MethodInfo.Name) select oItem).Count();
                                oMethod_usage = new Method_usage();
                                oMethod_usage.Method_Name = oRow_MethodInfo.Name;
                                oMethod_usage.Usage = i_Count;
                                oList_Method_usage.Add(oMethod_usage);                                
                            }
                            // ----------

                            // ----------
                            if (oList_Method_usage != null)
                            {
                                oList_Method_usage = oList_Method_usage.OrderByDescending(x => x.Usage).ToList();                                
                            }
                            // ----------
                        }
                    }
                }
                // -------------
            }
            #endregion
            #region Return Section.
            return oList_Method_usage;
            #endregion
        }
		#endregion
}
public partial class Method_usage
{
#region Properties.
public string Method_Name { get; set; }
public Int32 Usage { get; set; }
#endregion
}
}
