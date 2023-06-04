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
#region Person
public partial class Person
{
#region Advanced Properties
#endregion
}
#endregion
#region Contact
public partial class Contact
{
#region Advanced Properties
public Person My_Person {get;set;}
#endregion
}
#endregion
#region Package
public partial class Package
{
#region Advanced Properties
public Currency My_Currency {get;set;}
#endregion
}
#endregion
#region Loc_l1
public partial class Loc_l1
{
#region Advanced Properties
#endregion
}
#endregion
#region Loc_l2
public partial class Loc_l2
{
#region Advanced Properties
public Loc_l1 My_Loc_l1 {get;set;}
#endregion
}
#endregion
#region Loc_l3
public partial class Loc_l3
{
#region Advanced Properties
public Loc_l2 My_Loc_l2 {get;set;}
#endregion
}
#endregion
#region Method_run
public partial class Method_run
{
#region Advanced Properties
#endregion
}
#endregion
#region Bloodtype
public partial class Bloodtype
{
#region Advanced Properties
#endregion
}
#endregion
#region Currency
public partial class Currency
{
#region Advanced Properties
#endregion
}
#endregion
#region Staff
public partial class Staff
{
#region Advanced Properties
public Bloodtype My_Bloodtype {get;set;}
#endregion
}
#endregion
#region Supplier
public partial class Supplier
{
#region Advanced Properties
#endregion
}
#endregion
#region Loc_l4
public partial class Loc_l4
{
#region Advanced Properties
public Loc_l3 My_Loc_l3 {get;set;}
#endregion
}
#endregion
#region Client
public partial class Client
{
#region Advanced Properties
public Bloodtype My_Bloodtype {get;set;}
#endregion
}
#endregion
#region Fees
public partial class Fees
{
#region Advanced Properties
public Currency My_Currency {get;set;}
#endregion
}
#endregion
#region Address
public partial class Address
{
#region Advanced Properties
public Person My_Person {get;set;}
public Loc_l1 My_Loc_l1 {get;set;}
public Loc_l2 My_Loc_l2 {get;set;}
public Loc_l3 My_Loc_l3 {get;set;}
public Loc_l4 My_Loc_l4 {get;set;}
#endregion
}
#endregion
#region Owner
public partial class Owner
{
#region Advanced Properties
#endregion
}
#endregion
#region User
public partial class User
{
#region Advanced Properties
#endregion
}
#endregion
#region Supplier_fees
public partial class Supplier_fees
{
#region Advanced Properties
public Supplier My_Supplier {get;set;}
public Fees My_Fees {get;set;}
public Currency My_Currency {get;set;}
#endregion
}
#endregion
#region Client_fees
public partial class Client_fees
{
#region Advanced Properties
public Client My_Client {get;set;}
public Fees My_Fees {get;set;}
public Currency My_Currency {get;set;}
public Package My_Package {get;set;}
#endregion
}
#endregion
#region Staff_fees
public partial class Staff_fees
{
#region Advanced Properties
public Staff My_Staff {get;set;}
public Fees My_Fees {get;set;}
public Currency My_Currency {get;set;}
#endregion
}
#endregion
}
