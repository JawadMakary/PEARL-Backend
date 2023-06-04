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
#region Params_Get_Person_By_PERSON_ID
public partial class Params_Get_Person_By_PERSON_ID
{
#region Properties
public long? PERSON_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Contact_By_CONTACT_ID
public partial class Params_Get_Contact_By_CONTACT_ID
{
#region Properties
public Int32? CONTACT_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Package_By_PACKAGE_ID
public partial class Params_Get_Package_By_PACKAGE_ID
{
#region Properties
public Int32? PACKAGE_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Loc_l1_By_LOC_L1_ID
public partial class Params_Get_Loc_l1_By_LOC_L1_ID
{
#region Properties
public long? LOC_L1_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Loc_l2_By_LOC_L2_ID
public partial class Params_Get_Loc_l2_By_LOC_L2_ID
{
#region Properties
public long? LOC_L2_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Loc_l3_By_LOC_L3_ID
public partial class Params_Get_Loc_l3_By_LOC_L3_ID
{
#region Properties
public long? LOC_L3_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Method_run_By_METHOD_RUN_ID
public partial class Params_Get_Method_run_By_METHOD_RUN_ID
{
#region Properties
public long? METHOD_RUN_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Bloodtype_By_BLOODTYPE_ID
public partial class Params_Get_Bloodtype_By_BLOODTYPE_ID
{
#region Properties
public Int32? BLOODTYPE_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Currency_By_CURRENCY_ID
public partial class Params_Get_Currency_By_CURRENCY_ID
{
#region Properties
public Int32? CURRENCY_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Staff_By_STAFF_ID
public partial class Params_Get_Staff_By_STAFF_ID
{
#region Properties
public Int32? STAFF_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Supplier_By_SUPPLIER_ID
public partial class Params_Get_Supplier_By_SUPPLIER_ID
{
#region Properties
public Int32? SUPPLIER_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Loc_l4_By_LOC_L4_ID
public partial class Params_Get_Loc_l4_By_LOC_L4_ID
{
#region Properties
public long? LOC_L4_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Client_By_CLIENT_ID
public partial class Params_Get_Client_By_CLIENT_ID
{
#region Properties
public Int32? CLIENT_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Fees_By_FEES_ID
public partial class Params_Get_Fees_By_FEES_ID
{
#region Properties
public Int32? FEES_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Address_By_ADDRESS_ID
public partial class Params_Get_Address_By_ADDRESS_ID
{
#region Properties
public long? ADDRESS_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Owner_By_OWNER_ID
public partial class Params_Get_Owner_By_OWNER_ID
{
#region Properties
public Int32? OWNER_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_User_By_USER_ID
public partial class Params_Get_User_By_USER_ID
{
#region Properties
public long? USER_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Supplier_fees_By_SUPPLIER_FEES_ID
public partial class Params_Get_Supplier_fees_By_SUPPLIER_FEES_ID
{
#region Properties
public Int32? SUPPLIER_FEES_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Client_fees_By_CLIENT_FEES_ID
public partial class Params_Get_Client_fees_By_CLIENT_FEES_ID
{
#region Properties
public Int32? CLIENT_FEES_ID {get;set;}

#endregion
}
#endregion
#region Params_Get_Staff_fees_By_STAFF_FEES_ID
public partial class Params_Get_Staff_fees_By_STAFF_FEES_ID
{
#region Properties
public Int32? STAFF_FEES_ID {get;set;}

#endregion
}
#endregion
public partial class Params_Get_Person_By_PERSON_ID_List
{
public List<long?> PERSON_ID_LIST {get;set;}
}
public partial class Params_Get_Person_By_PERSON_ID_List_SP
{
public string PERSON_ID_LIST {get;set;}

}
public partial class Params_Get_Contact_By_CONTACT_ID_List
{
public List<Int32?> CONTACT_ID_LIST {get;set;}
}
public partial class Params_Get_Contact_By_CONTACT_ID_List_SP
{
public string CONTACT_ID_LIST {get;set;}

}
public partial class Params_Get_Package_By_PACKAGE_ID_List
{
public List<Int32?> PACKAGE_ID_LIST {get;set;}
}
public partial class Params_Get_Package_By_PACKAGE_ID_List_SP
{
public string PACKAGE_ID_LIST {get;set;}

}
public partial class Params_Get_Loc_l1_By_LOC_L1_ID_List
{
public List<long?> LOC_L1_ID_LIST {get;set;}
}
public partial class Params_Get_Loc_l1_By_LOC_L1_ID_List_SP
{
public string LOC_L1_ID_LIST {get;set;}

}
public partial class Params_Get_Loc_l2_By_LOC_L2_ID_List
{
public List<long?> LOC_L2_ID_LIST {get;set;}
}
public partial class Params_Get_Loc_l2_By_LOC_L2_ID_List_SP
{
public string LOC_L2_ID_LIST {get;set;}

}
public partial class Params_Get_Loc_l3_By_LOC_L3_ID_List
{
public List<long?> LOC_L3_ID_LIST {get;set;}
}
public partial class Params_Get_Loc_l3_By_LOC_L3_ID_List_SP
{
public string LOC_L3_ID_LIST {get;set;}

}
public partial class Params_Get_Method_run_By_METHOD_RUN_ID_List
{
public List<long?> METHOD_RUN_ID_LIST {get;set;}
}
public partial class Params_Get_Method_run_By_METHOD_RUN_ID_List_SP
{
public string METHOD_RUN_ID_LIST {get;set;}

}
public partial class Params_Get_Bloodtype_By_BLOODTYPE_ID_List
{
public List<Int32?> BLOODTYPE_ID_LIST {get;set;}
}
public partial class Params_Get_Bloodtype_By_BLOODTYPE_ID_List_SP
{
public string BLOODTYPE_ID_LIST {get;set;}

}
public partial class Params_Get_Currency_By_CURRENCY_ID_List
{
public List<Int32?> CURRENCY_ID_LIST {get;set;}
}
public partial class Params_Get_Currency_By_CURRENCY_ID_List_SP
{
public string CURRENCY_ID_LIST {get;set;}

}
public partial class Params_Get_Staff_By_STAFF_ID_List
{
public List<Int32?> STAFF_ID_LIST {get;set;}
}
public partial class Params_Get_Staff_By_STAFF_ID_List_SP
{
public string STAFF_ID_LIST {get;set;}

}
public partial class Params_Get_Supplier_By_SUPPLIER_ID_List
{
public List<Int32?> SUPPLIER_ID_LIST {get;set;}
}
public partial class Params_Get_Supplier_By_SUPPLIER_ID_List_SP
{
public string SUPPLIER_ID_LIST {get;set;}

}
public partial class Params_Get_Loc_l4_By_LOC_L4_ID_List
{
public List<long?> LOC_L4_ID_LIST {get;set;}
}
public partial class Params_Get_Loc_l4_By_LOC_L4_ID_List_SP
{
public string LOC_L4_ID_LIST {get;set;}

}
public partial class Params_Get_Client_By_CLIENT_ID_List
{
public List<Int32?> CLIENT_ID_LIST {get;set;}
}
public partial class Params_Get_Client_By_CLIENT_ID_List_SP
{
public string CLIENT_ID_LIST {get;set;}

}
public partial class Params_Get_Fees_By_FEES_ID_List
{
public List<Int32?> FEES_ID_LIST {get;set;}
}
public partial class Params_Get_Fees_By_FEES_ID_List_SP
{
public string FEES_ID_LIST {get;set;}

}
public partial class Params_Get_Address_By_ADDRESS_ID_List
{
public List<long?> ADDRESS_ID_LIST {get;set;}
}
public partial class Params_Get_Address_By_ADDRESS_ID_List_SP
{
public string ADDRESS_ID_LIST {get;set;}

}
public partial class Params_Get_Owner_By_OWNER_ID_List
{
public List<Int32?> OWNER_ID_LIST {get;set;}
}
public partial class Params_Get_Owner_By_OWNER_ID_List_SP
{
public string OWNER_ID_LIST {get;set;}

}
public partial class Params_Get_User_By_USER_ID_List
{
public List<long?> USER_ID_LIST {get;set;}
}
public partial class Params_Get_User_By_USER_ID_List_SP
{
public string USER_ID_LIST {get;set;}

}
public partial class Params_Get_Supplier_fees_By_SUPPLIER_FEES_ID_List
{
public List<Int32?> SUPPLIER_FEES_ID_LIST {get;set;}
}
public partial class Params_Get_Supplier_fees_By_SUPPLIER_FEES_ID_List_SP
{
public string SUPPLIER_FEES_ID_LIST {get;set;}

}
public partial class Params_Get_Client_fees_By_CLIENT_FEES_ID_List
{
public List<Int32?> CLIENT_FEES_ID_LIST {get;set;}
}
public partial class Params_Get_Client_fees_By_CLIENT_FEES_ID_List_SP
{
public string CLIENT_FEES_ID_LIST {get;set;}

}
public partial class Params_Get_Staff_fees_By_STAFF_FEES_ID_List
{
public List<Int32?> STAFF_FEES_ID_LIST {get;set;}
}
public partial class Params_Get_Staff_fees_By_STAFF_FEES_ID_List_SP
{
public string STAFF_FEES_ID_LIST {get;set;}

}
public partial class Params_Get_Person_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Contact_By_PERSON_ID
{
public long? PERSON_ID {get;set;}

}
public partial class Params_Get_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT
{
public long? PERSON_ID {get;set;}
public string CONTACT_TYPE_CODE {get;set;}
public string CONTACT {get;set;}

}
public partial class Params_Get_Contact_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Package_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Package_By_CURRENCY_ID
{
public Int32? CURRENCY_ID {get;set;}

}
public partial class Params_Get_Loc_l1_By_CODE
{
public string CODE {get;set;}

}
public partial class Params_Get_Loc_l1_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Loc_l2_By_LOC_L1_ID_CODE
{
public long? LOC_L1_ID {get;set;}
public string CODE {get;set;}

}
public partial class Params_Get_Loc_l2_By_LOC_L1_ID
{
public long? LOC_L1_ID {get;set;}

}
public partial class Params_Get_Loc_l2_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Loc_l3_By_LOC_L2_ID_CODE
{
public long? LOC_L2_ID {get;set;}
public string CODE {get;set;}

}
public partial class Params_Get_Loc_l3_By_LOC_L2_ID
{
public long? LOC_L2_ID {get;set;}

}
public partial class Params_Get_Loc_l3_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Method_run_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Bloodtype_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Currency_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Staff_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Staff_By_BLOODTYPE_ID
{
public Int32? BLOODTYPE_ID {get;set;}

}
public partial class Params_Get_Supplier_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Loc_l4_By_LOC_L3_ID_CODE
{
public long? LOC_L3_ID {get;set;}
public string CODE {get;set;}

}
public partial class Params_Get_Loc_l4_By_LOC_L3_ID
{
public long? LOC_L3_ID {get;set;}

}
public partial class Params_Get_Loc_l4_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Client_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Client_By_BLOODTYPE_ID
{
public Int32? BLOODTYPE_ID {get;set;}

}
public partial class Params_Get_Fees_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Fees_By_CURRENCY_ID
{
public Int32? CURRENCY_ID {get;set;}

}
public partial class Params_Get_Address_By_PERSON_ID
{
public long? PERSON_ID {get;set;}

}
public partial class Params_Get_Address_By_LOC_L1_ID
{
public long? LOC_L1_ID {get;set;}

}
public partial class Params_Get_Address_By_LOC_L2_ID
{
public long? LOC_L2_ID {get;set;}

}
public partial class Params_Get_Address_By_LOC_L3_ID
{
public long? LOC_L3_ID {get;set;}

}
public partial class Params_Get_Address_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Address_By_PERSON_ID_ADDRESS_TYPE_CODE
{
public long? PERSON_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}

}
public partial class Params_Get_Address_By_LOC_L4_ID
{
public long? LOC_L4_ID {get;set;}

}
public partial class Params_Get_User_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_User_By_USERNAME
{
public string USERNAME {get;set;}

}
public partial class Params_Get_Supplier_fees_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Supplier_fees_By_SUPPLIER_ID
{
public Int32? SUPPLIER_ID {get;set;}

}
public partial class Params_Get_Supplier_fees_By_FEES_ID
{
public Int32? FEES_ID {get;set;}

}
public partial class Params_Get_Supplier_fees_By_CURRENCY_ID
{
public Int32? CURRENCY_ID {get;set;}

}
public partial class Params_Get_Client_fees_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Client_fees_By_CLIENT_ID
{
public Int32? CLIENT_ID {get;set;}

}
public partial class Params_Get_Client_fees_By_FEES_ID
{
public Int32? FEES_ID {get;set;}

}
public partial class Params_Get_Client_fees_By_CURRENCY_ID
{
public Int32? CURRENCY_ID {get;set;}

}
public partial class Params_Get_Client_fees_By_PACKAGE_ID
{
public Int32? PACKAGE_ID {get;set;}

}
public partial class Params_Get_Staff_fees_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}

}
public partial class Params_Get_Staff_fees_By_STAFF_ID
{
public Int32? STAFF_ID {get;set;}

}
public partial class Params_Get_Staff_fees_By_FEES_ID
{
public Int32? FEES_ID {get;set;}

}
public partial class Params_Get_Staff_fees_By_CURRENCY_ID
{
public Int32? CURRENCY_ID {get;set;}

}
public partial class Params_Get_Contact_By_PERSON_ID_List
{
public List<long?> PERSON_ID_LIST {get;set;}

}
public partial class Params_Get_Package_By_CURRENCY_ID_List
{
public List<Int32?> CURRENCY_ID_LIST {get;set;}

}
public partial class Params_Get_Loc_l2_By_LOC_L1_ID_List
{
public List<long?> LOC_L1_ID_LIST {get;set;}

}
public partial class Params_Get_Loc_l3_By_LOC_L2_ID_List
{
public List<long?> LOC_L2_ID_LIST {get;set;}

}
public partial class Params_Get_Staff_By_BLOODTYPE_ID_List
{
public List<Int32?> BLOODTYPE_ID_LIST {get;set;}

}
public partial class Params_Get_Loc_l4_By_LOC_L3_ID_List
{
public List<long?> LOC_L3_ID_LIST {get;set;}

}
public partial class Params_Get_Client_By_BLOODTYPE_ID_List
{
public List<Int32?> BLOODTYPE_ID_LIST {get;set;}

}
public partial class Params_Get_Fees_By_CURRENCY_ID_List
{
public List<Int32?> CURRENCY_ID_LIST {get;set;}

}
public partial class Params_Get_Address_By_PERSON_ID_List
{
public List<long?> PERSON_ID_LIST {get;set;}

}
public partial class Params_Get_Address_By_LOC_L1_ID_List
{
public List<long?> LOC_L1_ID_LIST {get;set;}

}
public partial class Params_Get_Address_By_LOC_L2_ID_List
{
public List<long?> LOC_L2_ID_LIST {get;set;}

}
public partial class Params_Get_Address_By_LOC_L3_ID_List
{
public List<long?> LOC_L3_ID_LIST {get;set;}

}
public partial class Params_Get_Address_By_LOC_L4_ID_List
{
public List<long?> LOC_L4_ID_LIST {get;set;}

}
public partial class Params_Get_Supplier_fees_By_SUPPLIER_ID_List
{
public List<Int32?> SUPPLIER_ID_LIST {get;set;}

}
public partial class Params_Get_Supplier_fees_By_FEES_ID_List
{
public List<Int32?> FEES_ID_LIST {get;set;}

}
public partial class Params_Get_Supplier_fees_By_CURRENCY_ID_List
{
public List<Int32?> CURRENCY_ID_LIST {get;set;}

}
public partial class Params_Get_Client_fees_By_CLIENT_ID_List
{
public List<Int32?> CLIENT_ID_LIST {get;set;}

}
public partial class Params_Get_Client_fees_By_FEES_ID_List
{
public List<Int32?> FEES_ID_LIST {get;set;}

}
public partial class Params_Get_Client_fees_By_CURRENCY_ID_List
{
public List<Int32?> CURRENCY_ID_LIST {get;set;}

}
public partial class Params_Get_Client_fees_By_PACKAGE_ID_List
{
public List<Int32?> PACKAGE_ID_LIST {get;set;}

}
public partial class Params_Get_Staff_fees_By_STAFF_ID_List
{
public List<Int32?> STAFF_ID_LIST {get;set;}

}
public partial class Params_Get_Staff_fees_By_FEES_ID_List
{
public List<Int32?> FEES_ID_LIST {get;set;}

}
public partial class Params_Get_Staff_fees_By_CURRENCY_ID_List
{
public List<Int32?> CURRENCY_ID_LIST {get;set;}

}
public partial class Params_Get_Person_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string FIRST_NAME {get;set;}
public string LAST_NAME {get;set;}
public string FATHER_NAME {get;set;}
public string MOTHER_NAME {get;set;}
public string TITLE_CODE {get;set;}
public string GENDER_CODE {get;set;}
public string RELIGION_CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Person_By_Where
{

public Int32? OWNER_ID {get;set;}
public string FIRST_NAME {get;set;}
public string LAST_NAME {get;set;}
public string FATHER_NAME {get;set;}
public string MOTHER_NAME {get;set;}
public string TITLE_CODE {get;set;}
public string GENDER_CODE {get;set;}
public string RELIGION_CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Person_By_Criteria_V2
{

public Int32? OWNER_ID {get;set;}
public string FIRST_NAME {get;set;}
public string LAST_NAME {get;set;}
public string FATHER_NAME {get;set;}
public string MOTHER_NAME {get;set;}
public string TITLE_CODE {get;set;}
public string GENDER_CODE {get;set;}
public string RELIGION_CODE {get;set;}
public string BIRTH_DATE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Person_By_Where_V2
{

public Int32? OWNER_ID {get;set;}
public string FIRST_NAME {get;set;}
public string LAST_NAME {get;set;}
public string FATHER_NAME {get;set;}
public string MOTHER_NAME {get;set;}
public string TITLE_CODE {get;set;}
public string GENDER_CODE {get;set;}
public string RELIGION_CODE {get;set;}
public string BIRTH_DATE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Contact_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string CONTACT_TYPE_CODE {get;set;}
public string CONTACT {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Contact_By_Where
{

public Int32? OWNER_ID {get;set;}
public string CONTACT_TYPE_CODE {get;set;}
public string CONTACT {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Package_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string PACKAGE_NAME {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Package_By_Where
{

public Int32? OWNER_ID {get;set;}
public string PACKAGE_NAME {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Package_By_Criteria_V2
{

public Int32? OWNER_ID {get;set;}
public string PACKAGE_NAME {get;set;}
public string PACKAGE_STARTING_DATE {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Package_By_Where_V2
{

public Int32? OWNER_ID {get;set;}
public string PACKAGE_NAME {get;set;}
public string PACKAGE_STARTING_DATE {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l1_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l1_By_Where
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l2_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l2_By_Where
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l3_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l3_By_Where
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Method_run_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string METHOD_NAME {get;set;}
public string INPUT_PARAM {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Method_run_By_Where
{

public Int32? OWNER_ID {get;set;}
public string METHOD_NAME {get;set;}
public string INPUT_PARAM {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Method_run_By_Criteria_V2
{

public Int32? OWNER_ID {get;set;}
public string METHOD_NAME {get;set;}
public string RUN_DATE {get;set;}
public string INPUT_PARAM {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Method_run_By_Where_V2
{

public Int32? OWNER_ID {get;set;}
public string METHOD_NAME {get;set;}
public string RUN_DATE {get;set;}
public string INPUT_PARAM {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Bloodtype_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string BLOODTYPE_SYMBOL {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Bloodtype_By_Where
{

public Int32? OWNER_ID {get;set;}
public string BLOODTYPE_SYMBOL {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Currency_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string CURRENCY_TYPE {get;set;}
public string CURRENCY_SYMBOL {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Currency_By_Where
{

public Int32? OWNER_ID {get;set;}
public string CURRENCY_TYPE {get;set;}
public string CURRENCY_SYMBOL {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Staff_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string STAFF_NAME {get;set;}
public string STAFF_PH_NB {get;set;}
public string STAFF_MAIL {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Staff_By_Where
{

public Int32? OWNER_ID {get;set;}
public string STAFF_NAME {get;set;}
public string STAFF_PH_NB {get;set;}
public string STAFF_MAIL {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Staff_By_Criteria_V2
{

public Int32? OWNER_ID {get;set;}
public string STAFF_NAME {get;set;}
public string STAFF_PH_NB {get;set;}
public string STAFF_MAIL {get;set;}
public string STAFF_DOB {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Staff_By_Where_V2
{

public Int32? OWNER_ID {get;set;}
public string STAFF_NAME {get;set;}
public string STAFF_PH_NB {get;set;}
public string STAFF_MAIL {get;set;}
public string STAFF_DOB {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Supplier_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string SUPPLIER_NAME {get;set;}
public string SUPPLIER_PH_NB {get;set;}
public string SUPPLIER_MAIL {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Supplier_By_Where
{

public Int32? OWNER_ID {get;set;}
public string SUPPLIER_NAME {get;set;}
public string SUPPLIER_PH_NB {get;set;}
public string SUPPLIER_MAIL {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l4_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l4_By_Where
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Client_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string CLIENT_NAME {get;set;}
public string CLIENT_PH_NB {get;set;}
public string CLIENT_MAIL {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Client_By_Where
{

public Int32? OWNER_ID {get;set;}
public string CLIENT_NAME {get;set;}
public string CLIENT_PH_NB {get;set;}
public string CLIENT_MAIL {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Client_By_Criteria_V2
{

public Int32? OWNER_ID {get;set;}
public string CLIENT_NAME {get;set;}
public string CLIENT_PH_NB {get;set;}
public string CLIENT_MAIL {get;set;}
public string CLIENT_DOB {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Client_By_Where_V2
{

public Int32? OWNER_ID {get;set;}
public string CLIENT_NAME {get;set;}
public string CLIENT_PH_NB {get;set;}
public string CLIENT_MAIL {get;set;}
public string CLIENT_DOB {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Fees_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string FEES_DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Fees_By_Where
{

public Int32? OWNER_ID {get;set;}
public string FEES_DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Address_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
public string STREET {get;set;}
public string BUILDING {get;set;}
public string FLOOR {get;set;}
public string POBOX {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Address_By_Where
{

public Int32? OWNER_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
public string STREET {get;set;}
public string BUILDING {get;set;}
public string FLOOR {get;set;}
public string POBOX {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Address_By_Criteria_V2
{

public Int32? OWNER_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
public string STREET {get;set;}
public string BUILDING {get;set;}
public string FLOOR {get;set;}
public string POBOX {get;set;}
public string VALID_DATE_START {get;set;}
public string VALID_DATE_END {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Address_By_Where_V2
{

public Int32? OWNER_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
public string STREET {get;set;}
public string BUILDING {get;set;}
public string FLOOR {get;set;}
public string POBOX {get;set;}
public string VALID_DATE_START {get;set;}
public string VALID_DATE_END {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Owner_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Owner_By_Where
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Owner_By_Criteria_V2
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string MAINTENANCE_DUE_DATE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Owner_By_Where_V2
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string MAINTENANCE_DUE_DATE {get;set;}
public string DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_User_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string USERNAME {get;set;}
public string PASSWORD {get;set;}
public string USER_TYPE_CODE {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_User_By_Where
{

public Int32? OWNER_ID {get;set;}
public string USERNAME {get;set;}
public string PASSWORD {get;set;}
public string USER_TYPE_CODE {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Supplier_fees_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string SUPPLIER_FEES_DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Supplier_fees_By_Where
{

public Int32? OWNER_ID {get;set;}
public string SUPPLIER_FEES_DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Client_fees_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string CLIENT_FEES_DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Client_fees_By_Where
{

public Int32? OWNER_ID {get;set;}
public string CLIENT_FEES_DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Staff_fees_By_Criteria
{

public Int32? OWNER_ID {get;set;}
public string STAFF_FEES_DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Staff_fees_By_Where
{

public Int32? OWNER_ID {get;set;}
public string STAFF_FEES_DESCRIPTION {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Contact_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string CONTACT_TYPE_CODE {get;set;}
public string CONTACT {get;set;}
public string DESCRIPTION {get;set;}
public List<long?> PERSON_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Contact_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string CONTACT_TYPE_CODE {get;set;}
public string CONTACT {get;set;}
public string DESCRIPTION {get;set;}
public string PERSON_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Contact_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string CONTACT_TYPE_CODE {get;set;}
public string CONTACT {get;set;}
public string DESCRIPTION {get;set;}
public List<long?> PERSON_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Contact_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string CONTACT_TYPE_CODE {get;set;}
public string CONTACT {get;set;}
public string DESCRIPTION {get;set;}
public string PERSON_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Package_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string PACKAGE_NAME {get;set;}
public List<Int32?> CURRENCY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Package_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string PACKAGE_NAME {get;set;}
public string CURRENCY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Package_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string PACKAGE_NAME {get;set;}
public List<Int32?> CURRENCY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Package_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string PACKAGE_NAME {get;set;}
public string CURRENCY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Package_By_Criteria_InList_V2
{

public Int32? OWNER_ID {get;set;}
public string PACKAGE_NAME {get;set;}
public string PACKAGE_STARTING_DATE {get;set;}
public List<Int32?> CURRENCY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Package_By_Criteria_InList_SP_V2
{
public Int32? OWNER_ID {get;set;}
public string PACKAGE_NAME {get;set;}
public string PACKAGE_STARTING_DATE {get;set;}
public string CURRENCY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Package_By_Where_InList_V2
{

public Int32? OWNER_ID {get;set;}
public string PACKAGE_NAME {get;set;}
public string PACKAGE_STARTING_DATE {get;set;}
public List<Int32?> CURRENCY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Package_By_Where_InList_SP_V2
{
public Int32? OWNER_ID {get;set;}
public string PACKAGE_NAME {get;set;}
public string PACKAGE_STARTING_DATE {get;set;}
public string CURRENCY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l2_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public List<long?> LOC_L1_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l2_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public string LOC_L1_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l2_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public List<long?> LOC_L1_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l2_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public string LOC_L1_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l3_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public List<long?> LOC_L2_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l3_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public string LOC_L2_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l3_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public List<long?> LOC_L2_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l3_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public string LOC_L2_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Staff_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string STAFF_NAME {get;set;}
public string STAFF_PH_NB {get;set;}
public string STAFF_MAIL {get;set;}
public List<Int32?> BLOODTYPE_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Staff_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string STAFF_NAME {get;set;}
public string STAFF_PH_NB {get;set;}
public string STAFF_MAIL {get;set;}
public string BLOODTYPE_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Staff_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string STAFF_NAME {get;set;}
public string STAFF_PH_NB {get;set;}
public string STAFF_MAIL {get;set;}
public List<Int32?> BLOODTYPE_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Staff_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string STAFF_NAME {get;set;}
public string STAFF_PH_NB {get;set;}
public string STAFF_MAIL {get;set;}
public string BLOODTYPE_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Staff_By_Criteria_InList_V2
{

public Int32? OWNER_ID {get;set;}
public string STAFF_NAME {get;set;}
public string STAFF_PH_NB {get;set;}
public string STAFF_MAIL {get;set;}
public string STAFF_DOB {get;set;}
public List<Int32?> BLOODTYPE_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Staff_By_Criteria_InList_SP_V2
{
public Int32? OWNER_ID {get;set;}
public string STAFF_NAME {get;set;}
public string STAFF_PH_NB {get;set;}
public string STAFF_MAIL {get;set;}
public string STAFF_DOB {get;set;}
public string BLOODTYPE_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Staff_By_Where_InList_V2
{

public Int32? OWNER_ID {get;set;}
public string STAFF_NAME {get;set;}
public string STAFF_PH_NB {get;set;}
public string STAFF_MAIL {get;set;}
public string STAFF_DOB {get;set;}
public List<Int32?> BLOODTYPE_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Staff_By_Where_InList_SP_V2
{
public Int32? OWNER_ID {get;set;}
public string STAFF_NAME {get;set;}
public string STAFF_PH_NB {get;set;}
public string STAFF_MAIL {get;set;}
public string STAFF_DOB {get;set;}
public string BLOODTYPE_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l4_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public List<long?> LOC_L3_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l4_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public string LOC_L3_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l4_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public List<long?> LOC_L3_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Loc_l4_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string DESCRIPTION {get;set;}
public string LOC_L3_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Client_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string CLIENT_NAME {get;set;}
public string CLIENT_PH_NB {get;set;}
public string CLIENT_MAIL {get;set;}
public List<Int32?> BLOODTYPE_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Client_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string CLIENT_NAME {get;set;}
public string CLIENT_PH_NB {get;set;}
public string CLIENT_MAIL {get;set;}
public string BLOODTYPE_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Client_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string CLIENT_NAME {get;set;}
public string CLIENT_PH_NB {get;set;}
public string CLIENT_MAIL {get;set;}
public List<Int32?> BLOODTYPE_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Client_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string CLIENT_NAME {get;set;}
public string CLIENT_PH_NB {get;set;}
public string CLIENT_MAIL {get;set;}
public string BLOODTYPE_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Client_By_Criteria_InList_V2
{

public Int32? OWNER_ID {get;set;}
public string CLIENT_NAME {get;set;}
public string CLIENT_PH_NB {get;set;}
public string CLIENT_MAIL {get;set;}
public string CLIENT_DOB {get;set;}
public List<Int32?> BLOODTYPE_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Client_By_Criteria_InList_SP_V2
{
public Int32? OWNER_ID {get;set;}
public string CLIENT_NAME {get;set;}
public string CLIENT_PH_NB {get;set;}
public string CLIENT_MAIL {get;set;}
public string CLIENT_DOB {get;set;}
public string BLOODTYPE_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Client_By_Where_InList_V2
{

public Int32? OWNER_ID {get;set;}
public string CLIENT_NAME {get;set;}
public string CLIENT_PH_NB {get;set;}
public string CLIENT_MAIL {get;set;}
public string CLIENT_DOB {get;set;}
public List<Int32?> BLOODTYPE_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Client_By_Where_InList_SP_V2
{
public Int32? OWNER_ID {get;set;}
public string CLIENT_NAME {get;set;}
public string CLIENT_PH_NB {get;set;}
public string CLIENT_MAIL {get;set;}
public string CLIENT_DOB {get;set;}
public string BLOODTYPE_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Fees_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string FEES_DESCRIPTION {get;set;}
public List<Int32?> CURRENCY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Fees_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string FEES_DESCRIPTION {get;set;}
public string CURRENCY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Fees_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string FEES_DESCRIPTION {get;set;}
public List<Int32?> CURRENCY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Fees_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string FEES_DESCRIPTION {get;set;}
public string CURRENCY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Address_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
public string STREET {get;set;}
public string BUILDING {get;set;}
public string FLOOR {get;set;}
public string POBOX {get;set;}
public List<long?> PERSON_ID_LIST {get;set;}
public List<long?> LOC_L1_ID_LIST {get;set;}
public List<long?> LOC_L2_ID_LIST {get;set;}
public List<long?> LOC_L3_ID_LIST {get;set;}
public List<long?> LOC_L4_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Address_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
public string STREET {get;set;}
public string BUILDING {get;set;}
public string FLOOR {get;set;}
public string POBOX {get;set;}
public string PERSON_ID_LIST {get;set;}
public string LOC_L1_ID_LIST {get;set;}
public string LOC_L2_ID_LIST {get;set;}
public string LOC_L3_ID_LIST {get;set;}
public string LOC_L4_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Address_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
public string STREET {get;set;}
public string BUILDING {get;set;}
public string FLOOR {get;set;}
public string POBOX {get;set;}
public List<long?> PERSON_ID_LIST {get;set;}
public List<long?> LOC_L1_ID_LIST {get;set;}
public List<long?> LOC_L2_ID_LIST {get;set;}
public List<long?> LOC_L3_ID_LIST {get;set;}
public List<long?> LOC_L4_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Address_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
public string STREET {get;set;}
public string BUILDING {get;set;}
public string FLOOR {get;set;}
public string POBOX {get;set;}
public string PERSON_ID_LIST {get;set;}
public string LOC_L1_ID_LIST {get;set;}
public string LOC_L2_ID_LIST {get;set;}
public string LOC_L3_ID_LIST {get;set;}
public string LOC_L4_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Address_By_Criteria_InList_V2
{

public Int32? OWNER_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
public string STREET {get;set;}
public string BUILDING {get;set;}
public string FLOOR {get;set;}
public string POBOX {get;set;}
public string VALID_DATE_START {get;set;}
public string VALID_DATE_END {get;set;}
public List<long?> PERSON_ID_LIST {get;set;}
public List<long?> LOC_L1_ID_LIST {get;set;}
public List<long?> LOC_L2_ID_LIST {get;set;}
public List<long?> LOC_L3_ID_LIST {get;set;}
public List<long?> LOC_L4_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Address_By_Criteria_InList_SP_V2
{
public Int32? OWNER_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
public string STREET {get;set;}
public string BUILDING {get;set;}
public string FLOOR {get;set;}
public string POBOX {get;set;}
public string VALID_DATE_START {get;set;}
public string VALID_DATE_END {get;set;}
public string PERSON_ID_LIST {get;set;}
public string LOC_L1_ID_LIST {get;set;}
public string LOC_L2_ID_LIST {get;set;}
public string LOC_L3_ID_LIST {get;set;}
public string LOC_L4_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Address_By_Where_InList_V2
{

public Int32? OWNER_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
public string STREET {get;set;}
public string BUILDING {get;set;}
public string FLOOR {get;set;}
public string POBOX {get;set;}
public string VALID_DATE_START {get;set;}
public string VALID_DATE_END {get;set;}
public List<long?> PERSON_ID_LIST {get;set;}
public List<long?> LOC_L1_ID_LIST {get;set;}
public List<long?> LOC_L2_ID_LIST {get;set;}
public List<long?> LOC_L3_ID_LIST {get;set;}
public List<long?> LOC_L4_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Address_By_Where_InList_SP_V2
{
public Int32? OWNER_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
public string STREET {get;set;}
public string BUILDING {get;set;}
public string FLOOR {get;set;}
public string POBOX {get;set;}
public string VALID_DATE_START {get;set;}
public string VALID_DATE_END {get;set;}
public string PERSON_ID_LIST {get;set;}
public string LOC_L1_ID_LIST {get;set;}
public string LOC_L2_ID_LIST {get;set;}
public string LOC_L3_ID_LIST {get;set;}
public string LOC_L4_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Supplier_fees_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string SUPPLIER_FEES_DESCRIPTION {get;set;}
public List<Int32?> SUPPLIER_ID_LIST {get;set;}
public List<Int32?> FEES_ID_LIST {get;set;}
public List<Int32?> CURRENCY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Supplier_fees_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string SUPPLIER_FEES_DESCRIPTION {get;set;}
public string SUPPLIER_ID_LIST {get;set;}
public string FEES_ID_LIST {get;set;}
public string CURRENCY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Supplier_fees_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string SUPPLIER_FEES_DESCRIPTION {get;set;}
public List<Int32?> SUPPLIER_ID_LIST {get;set;}
public List<Int32?> FEES_ID_LIST {get;set;}
public List<Int32?> CURRENCY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Supplier_fees_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string SUPPLIER_FEES_DESCRIPTION {get;set;}
public string SUPPLIER_ID_LIST {get;set;}
public string FEES_ID_LIST {get;set;}
public string CURRENCY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Client_fees_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string CLIENT_FEES_DESCRIPTION {get;set;}
public List<Int32?> CLIENT_ID_LIST {get;set;}
public List<Int32?> FEES_ID_LIST {get;set;}
public List<Int32?> CURRENCY_ID_LIST {get;set;}
public List<Int32?> PACKAGE_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Client_fees_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string CLIENT_FEES_DESCRIPTION {get;set;}
public string CLIENT_ID_LIST {get;set;}
public string FEES_ID_LIST {get;set;}
public string CURRENCY_ID_LIST {get;set;}
public string PACKAGE_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Client_fees_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string CLIENT_FEES_DESCRIPTION {get;set;}
public List<Int32?> CLIENT_ID_LIST {get;set;}
public List<Int32?> FEES_ID_LIST {get;set;}
public List<Int32?> CURRENCY_ID_LIST {get;set;}
public List<Int32?> PACKAGE_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Client_fees_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string CLIENT_FEES_DESCRIPTION {get;set;}
public string CLIENT_ID_LIST {get;set;}
public string FEES_ID_LIST {get;set;}
public string CURRENCY_ID_LIST {get;set;}
public string PACKAGE_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Staff_fees_By_Criteria_InList
{

public Int32? OWNER_ID {get;set;}
public string STAFF_FEES_DESCRIPTION {get;set;}
public List<Int32?> STAFF_ID_LIST {get;set;}
public List<Int32?> FEES_ID_LIST {get;set;}
public List<Int32?> CURRENCY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Staff_fees_By_Criteria_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string STAFF_FEES_DESCRIPTION {get;set;}
public string STAFF_ID_LIST {get;set;}
public string FEES_ID_LIST {get;set;}
public string CURRENCY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Staff_fees_By_Where_InList
{

public Int32? OWNER_ID {get;set;}
public string STAFF_FEES_DESCRIPTION {get;set;}
public List<Int32?> STAFF_ID_LIST {get;set;}
public List<Int32?> FEES_ID_LIST {get;set;}
public List<Int32?> CURRENCY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
public partial class Params_Get_Staff_fees_By_Where_InList_SP
{
public Int32? OWNER_ID {get;set;}
public string STAFF_FEES_DESCRIPTION {get;set;}
public string STAFF_ID_LIST {get;set;}
public string FEES_ID_LIST {get;set;}
public string CURRENCY_ID_LIST {get;set;}
public long? START_ROW {get;set;}
public long? END_ROW {get;set;}
public long? TOTAL_COUNT {get;set;}
}
#region Params_Delete_Person
public partial class Params_Delete_Person
{
#region Properties
public long? PERSON_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Contact
public partial class Params_Delete_Contact
{
#region Properties
public Int32? CONTACT_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Package
public partial class Params_Delete_Package
{
#region Properties
public Int32? PACKAGE_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Loc_l1
public partial class Params_Delete_Loc_l1
{
#region Properties
public long? LOC_L1_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Loc_l2
public partial class Params_Delete_Loc_l2
{
#region Properties
public long? LOC_L2_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Loc_l3
public partial class Params_Delete_Loc_l3
{
#region Properties
public long? LOC_L3_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Method_run
public partial class Params_Delete_Method_run
{
#region Properties
public long? METHOD_RUN_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Bloodtype
public partial class Params_Delete_Bloodtype
{
#region Properties
public Int32? BLOODTYPE_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Currency
public partial class Params_Delete_Currency
{
#region Properties
public Int32? CURRENCY_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Staff
public partial class Params_Delete_Staff
{
#region Properties
public Int32? STAFF_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Supplier
public partial class Params_Delete_Supplier
{
#region Properties
public Int32? SUPPLIER_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Loc_l4
public partial class Params_Delete_Loc_l4
{
#region Properties
public long? LOC_L4_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Client
public partial class Params_Delete_Client
{
#region Properties
public Int32? CLIENT_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Fees
public partial class Params_Delete_Fees
{
#region Properties
public Int32? FEES_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Address
public partial class Params_Delete_Address
{
#region Properties
public long? ADDRESS_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Owner
public partial class Params_Delete_Owner
{
#region Properties
public Int32? OWNER_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_User
public partial class Params_Delete_User
{
#region Properties
public long? USER_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Supplier_fees
public partial class Params_Delete_Supplier_fees
{
#region Properties
public Int32? SUPPLIER_FEES_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Client_fees
public partial class Params_Delete_Client_fees
{
#region Properties
public Int32? CLIENT_FEES_ID {get;set;}
#endregion
}
#endregion
#region Params_Delete_Staff_fees
public partial class Params_Delete_Staff_fees
{
#region Properties
public Int32? STAFF_FEES_ID {get;set;}
#endregion
}
#endregion
public partial class Params_Delete_Person_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Contact_By_PERSON_ID
{
public long? PERSON_ID {get;set;}
}
public partial class Params_Delete_Contact_By_PERSON_ID_CONTACT_TYPE_CODE_CONTACT
{
public long? PERSON_ID {get;set;}
public string CONTACT_TYPE_CODE {get;set;}
public string CONTACT {get;set;}
}
public partial class Params_Delete_Contact_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Package_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Package_By_CURRENCY_ID
{
public Int32? CURRENCY_ID {get;set;}
}
public partial class Params_Delete_Loc_l1_By_CODE
{
public string CODE {get;set;}
}
public partial class Params_Delete_Loc_l1_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Loc_l2_By_LOC_L1_ID_CODE
{
public long? LOC_L1_ID {get;set;}
public string CODE {get;set;}
}
public partial class Params_Delete_Loc_l2_By_LOC_L1_ID
{
public long? LOC_L1_ID {get;set;}
}
public partial class Params_Delete_Loc_l2_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Loc_l3_By_LOC_L2_ID_CODE
{
public long? LOC_L2_ID {get;set;}
public string CODE {get;set;}
}
public partial class Params_Delete_Loc_l3_By_LOC_L2_ID
{
public long? LOC_L2_ID {get;set;}
}
public partial class Params_Delete_Loc_l3_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Method_run_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Bloodtype_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Currency_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Staff_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Staff_By_BLOODTYPE_ID
{
public Int32? BLOODTYPE_ID {get;set;}
}
public partial class Params_Delete_Supplier_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Loc_l4_By_LOC_L3_ID_CODE
{
public long? LOC_L3_ID {get;set;}
public string CODE {get;set;}
}
public partial class Params_Delete_Loc_l4_By_LOC_L3_ID
{
public long? LOC_L3_ID {get;set;}
}
public partial class Params_Delete_Loc_l4_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Client_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Client_By_BLOODTYPE_ID
{
public Int32? BLOODTYPE_ID {get;set;}
}
public partial class Params_Delete_Fees_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Fees_By_CURRENCY_ID
{
public Int32? CURRENCY_ID {get;set;}
}
public partial class Params_Delete_Address_By_PERSON_ID
{
public long? PERSON_ID {get;set;}
}
public partial class Params_Delete_Address_By_LOC_L1_ID
{
public long? LOC_L1_ID {get;set;}
}
public partial class Params_Delete_Address_By_LOC_L2_ID
{
public long? LOC_L2_ID {get;set;}
}
public partial class Params_Delete_Address_By_LOC_L3_ID
{
public long? LOC_L3_ID {get;set;}
}
public partial class Params_Delete_Address_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Address_By_PERSON_ID_ADDRESS_TYPE_CODE
{
public long? PERSON_ID {get;set;}
public string ADDRESS_TYPE_CODE {get;set;}
}
public partial class Params_Delete_Address_By_LOC_L4_ID
{
public long? LOC_L4_ID {get;set;}
}
public partial class Params_Delete_User_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_User_By_USERNAME
{
public string USERNAME {get;set;}
}
public partial class Params_Delete_Supplier_fees_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Supplier_fees_By_SUPPLIER_ID
{
public Int32? SUPPLIER_ID {get;set;}
}
public partial class Params_Delete_Supplier_fees_By_FEES_ID
{
public Int32? FEES_ID {get;set;}
}
public partial class Params_Delete_Supplier_fees_By_CURRENCY_ID
{
public Int32? CURRENCY_ID {get;set;}
}
public partial class Params_Delete_Client_fees_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Client_fees_By_CLIENT_ID
{
public Int32? CLIENT_ID {get;set;}
}
public partial class Params_Delete_Client_fees_By_FEES_ID
{
public Int32? FEES_ID {get;set;}
}
public partial class Params_Delete_Client_fees_By_CURRENCY_ID
{
public Int32? CURRENCY_ID {get;set;}
}
public partial class Params_Delete_Client_fees_By_PACKAGE_ID
{
public Int32? PACKAGE_ID {get;set;}
}
public partial class Params_Delete_Staff_fees_By_OWNER_ID
{
public Int32? OWNER_ID {get;set;}
}
public partial class Params_Delete_Staff_fees_By_STAFF_ID
{
public Int32? STAFF_ID {get;set;}
}
public partial class Params_Delete_Staff_fees_By_FEES_ID
{
public Int32? FEES_ID {get;set;}
}
public partial class Params_Delete_Staff_fees_By_CURRENCY_ID
{
public Int32? CURRENCY_ID {get;set;}
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
public string PACKAGE_STARTING_DATE {get;set;}
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
public partial class Bloodtype
{
public Int32? BLOODTYPE_ID {get;set;}
public string BLOODTYPE_SYMBOL {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
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
}
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
}
public partial class Owner
{
public Int32? OWNER_ID {get;set;}
public string CODE {get;set;}
public string MAINTENANCE_DUE_DATE {get;set;}
public string DESCRIPTION {get;set;}
public string ENTRY_DATE {get;set;}
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
}
public partial class Supplier_fees
{
public Int32? SUPPLIER_FEES_ID {get;set;}
public Int32? SUPPLIER_ID {get;set;}
public string SUPPLIER_FEES_DESCRIPTION {get;set;}
public Int32? FEES_ID {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
public Int32? CURRENCY_ID {get;set;}
}
public partial class Client_fees
{
public Int32? CLIENT_FEES_ID {get;set;}
public Int32? CLIENT_ID {get;set;}
public string CLIENT_FEES_DESCRIPTION {get;set;}
public Int32? FEES_ID {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
public Int32? CURRENCY_ID {get;set;}
public Int32? PACKAGE_ID {get;set;}
}
public partial class Staff_fees
{
public Int32? STAFF_FEES_ID {get;set;}
public Int32? STAFF_ID {get;set;}
public string STAFF_FEES_DESCRIPTION {get;set;}
public Int32? FEES_ID {get;set;}
public long? ENTRY_USER_ID {get;set;}
public string ENTRY_DATE {get;set;}
public Int32? OWNER_ID {get;set;}
public Int32? CURRENCY_ID {get;set;}
}
#region Params_Edit_Person_List
public partial class Params_Edit_Person_List
{
#region Properties
public List<Person> My_List_To_Edit { get; set; }
public List<Person> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Contact_List
public partial class Params_Edit_Contact_List
{
#region Properties
public List<Contact> My_List_To_Edit { get; set; }
public List<Contact> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Package_List
public partial class Params_Edit_Package_List
{
#region Properties
public List<Package> My_List_To_Edit { get; set; }
public List<Package> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Loc_l1_List
public partial class Params_Edit_Loc_l1_List
{
#region Properties
public List<Loc_l1> My_List_To_Edit { get; set; }
public List<Loc_l1> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Loc_l2_List
public partial class Params_Edit_Loc_l2_List
{
#region Properties
public List<Loc_l2> My_List_To_Edit { get; set; }
public List<Loc_l2> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Loc_l3_List
public partial class Params_Edit_Loc_l3_List
{
#region Properties
public List<Loc_l3> My_List_To_Edit { get; set; }
public List<Loc_l3> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Method_run_List
public partial class Params_Edit_Method_run_List
{
#region Properties
public List<Method_run> My_List_To_Edit { get; set; }
public List<Method_run> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Bloodtype_List
public partial class Params_Edit_Bloodtype_List
{
#region Properties
public List<Bloodtype> My_List_To_Edit { get; set; }
public List<Bloodtype> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Currency_List
public partial class Params_Edit_Currency_List
{
#region Properties
public List<Currency> My_List_To_Edit { get; set; }
public List<Currency> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Staff_List
public partial class Params_Edit_Staff_List
{
#region Properties
public List<Staff> My_List_To_Edit { get; set; }
public List<Staff> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Supplier_List
public partial class Params_Edit_Supplier_List
{
#region Properties
public List<Supplier> My_List_To_Edit { get; set; }
public List<Supplier> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Loc_l4_List
public partial class Params_Edit_Loc_l4_List
{
#region Properties
public List<Loc_l4> My_List_To_Edit { get; set; }
public List<Loc_l4> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Client_List
public partial class Params_Edit_Client_List
{
#region Properties
public List<Client> My_List_To_Edit { get; set; }
public List<Client> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Fees_List
public partial class Params_Edit_Fees_List
{
#region Properties
public List<Fees> My_List_To_Edit { get; set; }
public List<Fees> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Address_List
public partial class Params_Edit_Address_List
{
#region Properties
public List<Address> My_List_To_Edit { get; set; }
public List<Address> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Owner_List
public partial class Params_Edit_Owner_List
{
#region Properties
public List<Owner> My_List_To_Edit { get; set; }
public List<Owner> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_User_List
public partial class Params_Edit_User_List
{
#region Properties
public List<User> My_List_To_Edit { get; set; }
public List<User> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Supplier_fees_List
public partial class Params_Edit_Supplier_fees_List
{
#region Properties
public List<Supplier_fees> My_List_To_Edit { get; set; }
public List<Supplier_fees> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Client_fees_List
public partial class Params_Edit_Client_fees_List
{
#region Properties
public List<Client_fees> My_List_To_Edit { get; set; }
public List<Client_fees> My_List_To_Delete { get; set; }
#endregion
}
#endregion
#region Params_Edit_Staff_fees_List
public partial class Params_Edit_Staff_fees_List
{
#region Properties
public List<Staff_fees> My_List_To_Edit { get; set; }
public List<Staff_fees> My_List_To_Delete { get; set; }
#endregion
}
#endregion
}
