using DALC;
using JWT;
using JWT.Algorithms;
using JWT.Builder;
using JWT.Serializers;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;

namespace BLC
{
    #region Enumerations
    public enum Enum_EntityNameFormat
    {
        FML,
        FLM,
        MFL,
        MLF,
        LFM,
        LMF
    }
    #endregion
    public partial class BLC
    {
        #region Members
        const string _JWT_SECRET = "cBoDstcKww4457ry8uTHjPOuXOYg5MbeJ1XT0uFiwDVkzIr";
        #endregion
        public void Monitor_API_Calls() { }

        #region Setup
        #region EditSetup
        #region EditSetup



        public void EditSetup(SetupEntry i_SetupEntry)
        {
            #region Declaration And Initialization Section.
            Tools.Tools oTools = new Tools.Tools();
            #endregion
            #region Environment Related Code Handling
            Params_GetEnvCode oParams_GetEnvCode = new Params_GetEnvCode();
            oParams_GetEnvCode.My_Environment = this.Environment;
            oParams_GetEnvCode.My_MethodName = "EditSetup";
            oParams_GetEnvCode.My_Type = typeof(BLC);
            MethodInfo oMethodInfo = EnvCode.GetEnvCode(oParams_GetEnvCode);
            if (oMethodInfo != null)
            {
                oMethodInfo.Invoke(this, new object[] { i_SetupEntry });
                return;
            }
            #endregion
            #region PreEvent_General
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("EditSetup");
            }
            #endregion
            #region Body Section.
            i_SetupEntry.ENTRY_USER_ID = this.UserID;
            i_SetupEntry.OWNER_ID = this.OwnerID;
            i_SetupEntry.ENTRY_DATE = oTools.GetDateString(DateTime.Today);
            oTools.InvokeMethod(_AppContext, "UP_EDIT_SETUP", i_SetupEntry);
            #endregion
            #region PostEvent_General
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("EditSetup");
            }
            #endregion
        }
        #endregion
        #endregion
        #endregion        
        #region JWT
        #region ResolveTicket_JWT
        public Dictionary<string, string> ResolveTicket_JWT(string i_Input)
        {
            #region Declaration And Initialization Section.
            Dictionary<string, string> oList = new Dictionary<string, string>();
            Crypto.MiniCryptoHelper oMiniCryptoHelper = new Crypto.MiniCryptoHelper();
            #endregion
            #region PreEvent_General
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("ResolveTicket_JWT");
            }
            #endregion
            #region Body Section.
            if (!string.IsNullOrEmpty(i_Input))
            {

                IJsonSerializer serializer = new JsonNetSerializer();
                var provider = new UtcDateTimeProvider();
                IJwtValidator validator = new JwtValidator(serializer, provider);
                IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
                IJwtAlgorithm algorithm = new HMACSHA256Algorithm(); // symmetric
                IJwtDecoder decoder = new JwtDecoder(serializer, validator, urlEncoder, algorithm);

                try
                {
                    // var json = decoder.Decode(i_Input, _JWT_SECRET, verify: true);
                    var payload = JwtBuilder.Create()
                             .WithAlgorithm(new HMACSHA256Algorithm()) // symmetric
                             .WithSecret(_JWT_SECRET)
                             .MustVerifySignature()
                             .Decode<IDictionary<string, object>>(i_Input);
                    oList.Add("USER_ID", oMiniCryptoHelper.Decrypt(payload["CLAIM-01"].ToString()));
                    oList.Add("OWNER_ID", oMiniCryptoHelper.Decrypt(payload["CLAIM-02"].ToString()));
                }
                catch (Exception ex)
                {
                    throw new BLCException("Your session has timed out.Please click here to relogin.");
                }
            }
            else
            {
                oList.Add("USER_ID", "1");
                oList.Add("OWNER_ID", "1");
            }
            #endregion
            #region PostEvent_General
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("ResolveTicket_JWT");
            }
            #endregion
            #region Return Section.
            return oList;
            #endregion
        }
        #endregion
        #region Prepare_Ticket_JWT
        public string Prepare_Ticket_JWT(UserInfo i_UserInfo)
        {
            #region Declaration And Initialization Section.
            string str_Return_Value = string.Empty;
            Crypto.MiniCryptoHelper oMiniCryptoHelper = new Crypto.MiniCryptoHelper();
            #endregion
            #region Body Section.

            str_Return_Value = JwtBuilder.Create()
                                  .WithAlgorithm(new HMACSHA256Algorithm()) // symmetric
                                  .WithSecret(_JWT_SECRET)
                                  .AddClaim("exp", DateTimeOffset.UtcNow.AddDays(7).ToUnixTimeSeconds())
                                  .AddClaim("CLAIM-01", oMiniCryptoHelper.Encrypt(i_UserInfo.UserID.ToString()))
                                  .AddClaim("CLAIM-02", oMiniCryptoHelper.Encrypt(i_UserInfo.OwnerID.ToString()))
                                  .Encode();

            #endregion
            #region Return Section.
            return str_Return_Value;
            #endregion
        }
        #endregion
        #region IsValidTicket_JWT
        public bool IsValidTicket_JWT(string i_Input)
        {
            #region Declaration And Initialization Section.
            bool Is_ValidTicket = false;
            #endregion
            #region Environment Related Code Handling
            return true;
            #endregion           
            #region Return Section.
            return Is_ValidTicket;
            #endregion
        }
        #endregion
        #endregion
        #region Authentication        
        #region Authenticate
        public UserInfo Authenticate(Params_Authenticate i_Params_Authenticate)
        {
            #region Declaration And Initialization Section.
            UserInfo oUserInfo = null;
            Crypto.MiniCryptoHelper oMiniCryptoHelper = new Crypto.MiniCryptoHelper();

            Tools.Tools oTools = new Tools.Tools();
            #endregion            
            #region Body Section.

            var oQuery =
                        (
                        from oItem in _AppContext.UP_GET_USER_BY_CREDENTIALS
                                    (
                                        1,
                                        i_Params_Authenticate.USER_NAME,
                                        oMiniCryptoHelper.Encrypt(i_Params_Authenticate.PASSWORD)
                                    )
                        select oItem
                        ).ToList();

            if (oQuery.Count() == 1)
            {

                var oResult = oQuery.First();
                #region Check if this User is Active [Even if provided valid credentials]
                if (oResult.IS_ACTIVE == false)
                {
                    throw new BLCException("Not Active User");
                }
                #endregion
                #region Prepare Returned Object

                oUserInfo = new UserInfo();
                oUserInfo.IsAuthenticated = true;
                oUserInfo.UserID = oResult.USER_ID;
                oUserInfo.OwnerID = oResult.OWNER_ID;

                // Preparing ticket
                // ------------------------------               
                oUserInfo.Ticket = Prepare_Ticket(oUserInfo);
                // ------------------------------
            }
            else
            {
                throw new BLCException("Invalid UserName and/or Password!!");
            }
            #endregion            
            #region Return Section.
            return oUserInfo;
            #endregion
        }
        #endregion
        #region ResolveTicket
        public Dictionary<string, string> ResolveTicket(string i_Input)
        {
            return ResolveTicket_JWT(i_Input);
            #region Declaration And Initialization Section.
            Dictionary<string, string> oList = new Dictionary<string, string>();
            string str_Ticket_PlainText = string.Empty;
            Crypto.Crypto oCrypto = new Crypto.Crypto();
            string[] oMainTempList = null;
            string[] oSubTempList = null;
            #endregion
            #region PreEvent_General
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("ResolveTicket");
            }
            #endregion
            #region Body Section.
            if (!string.IsNullOrEmpty(i_Input))
            {
                //str_Ticket_PlainText = oCrypto.Decrypt(i_Input, _KeySet);
                str_Ticket_PlainText = i_Input;

                if (!string.IsNullOrEmpty(str_Ticket_PlainText))
                {
                    oMainTempList = str_Ticket_PlainText.Split(new string[] { "[~!@]" }, StringSplitOptions.RemoveEmptyEntries);

                    var oQuery = from oItem in oMainTempList
                                 select oItem;

                    foreach (var oRow in oQuery)
                    {
                        oSubTempList = oRow.Split(new string[] { ":" }, StringSplitOptions.None);
                        oList.Add(oSubTempList[0], oSubTempList[1]);
                    }
                }
            }
            else
            {
                oList.Add("USER_ID", "1");
                oList.Add("OWNER_ID", "1");
            }
            #endregion
            #region PostEvent_General
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("ResolveTicket");
            }
            #endregion
            #region Return Section.
            return oList;
            #endregion
        }
        #endregion        
        #region IsValidTicket
        public bool IsValidTicket(string i_Input)
        {
            return IsValidTicket(i_Input);
            #region Declaration And Initialization Section.
            bool Is_ValidTicket = false;
            long? i_MinutesElapsedSinceMidnight = 0;
            string str_CurrentDate = string.Empty;
            Tools.Tools oTools = new Tools.Tools();
            Dictionary<string, string> oTicketParts = new Dictionary<string, string>();
            #endregion
            #region Environment Related Code Handling
            Params_GetEnvCode oParams_GetEnvCode = new Params_GetEnvCode();
            oParams_GetEnvCode.My_Environment = this.Environment;
            oParams_GetEnvCode.My_MethodName = "IsValidTicket";
            oParams_GetEnvCode.My_Type = typeof(BLC);
            MethodInfo oMethodInfo = EnvCode.GetEnvCode(oParams_GetEnvCode);
            if (oMethodInfo != null)
            {
                return Convert.ToBoolean(oMethodInfo.Invoke(this, new object[] { i_Input }));
                // Intentially Left Empty.
            }
            #endregion
            #region PreEvent_General
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("IsValidTicket");
            }
            #endregion
            #region Body Section.
            try
            {
                oTicketParts = ResolveTicket(i_Input);
                str_CurrentDate = oTools.GetDateString(DateTime.Today);

                if (oTicketParts["START_DATE"] == str_CurrentDate) // Session Started In Different Day.
                {
                    i_MinutesElapsedSinceMidnight = (long?)(DateTime.Now - DateTime.Today).TotalMinutes;

                    if (i_MinutesElapsedSinceMidnight <= Convert.ToInt32(oTicketParts["START_MINUTE"]) + Convert.ToInt32(oTicketParts["SESSION_PERIOD"]))
                    {
                        Is_ValidTicket = true;
                    }
                }

            }
            catch (Exception ex)
            {
                Is_ValidTicket = false;
            }
            #endregion
            #region PostEvent_General
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("IsValidTicket");
            }
            #endregion
            #region Return Section.
            return Is_ValidTicket;
            #endregion
        }
        #endregion
        #region Prepare_Ticket
        public string Prepare_Ticket(UserInfo i_UserInfo)
        {
            return Prepare_Ticket_JWT(i_UserInfo);
            #region Declaration And Initialization Section.
            string str_Return_Value = string.Empty;

            Int64? i_MinutesElapsedSinceMidnight = 0;
            Int32? i_ExpiryPeriod = 240; // In Minutes
            Tools.Tools oTools = new Tools.Tools();
            #endregion
            #region Body Section.

            // ------------------------------
            if (ConfigurationManager.AppSettings["SESSION_PERIOD"] != null)
            {
                i_ExpiryPeriod = Convert.ToInt32(ConfigurationManager.AppSettings["SESSION_PERIOD"].ToString());
            }
            // ------------------------------

            // Prepare ticket
            // ------------------------------
            i_MinutesElapsedSinceMidnight = (long?)(DateTime.Now - DateTime.Today).TotalMinutes;
            str_Return_Value = string.Format
                        (
                            "USER_ID:{0}[~!@]OWNER_ID:{1}[~!@]START_DATE:{2}[~!@]START_MINUTE:{3}[~!@]SESSION_PERIOD:{4}",
                            i_UserInfo.UserID.ToString(),
                            i_UserInfo.OwnerID.ToString(),
                            oTools.GetDateString(DateTime.Today),
                            i_MinutesElapsedSinceMidnight.ToString(),
                            i_ExpiryPeriod.ToString()
                        );
            //str_Return_Value = oCrypto.Encrypt(str_Return_Value, _KeyPublic);         
            // ------------------------------

            #endregion
            #region Return Section.
            return str_Return_Value;
            #endregion
        }
        #endregion
        #endregion
        #endregion

        #region salesSum
        public int Sales_Sum(Params_Sales_Sum i_Params_Sales_Sum)
        {
            int? SUM = 0;
            _AppContext.SALES_SUM(i_Params_Sales_Sum.OWNER_ID, i_Params_Sales_Sum.CURRENCY_ID, ref SUM);
            if (SUM == null)
                throw new ArgumentOutOfRangeException("Parameter index is out of range.");
            return SUM ?? 0;
        }
        #endregion


        #region EXENSES_SUM
        public int Expenses_Sum(Params_Expenses_Sum i_Params_Expenses_Sum)
        {
            int? SUM = 0;
            _AppContext.EXPENSES_SUM(i_Params_Expenses_Sum.OWNER_ID, i_Params_Expenses_Sum.CURRENCY_ID, ref SUM);
            if (SUM == null)
                throw new ArgumentOutOfRangeException("Parameter index is out of range.");
            return SUM ?? 0;
        }


        #endregion

        #region GETGRANDPROFIT
        public int GetGrandProfit(Params_GetGrandProfit i_Params_GetGrandProfit)
        {
            int? SUM = 0;
            _AppContext.GETGRANDPROFIT(i_Params_GetGrandProfit.OWNER_ID, i_Params_GetGrandProfit.CURRENCY_ID,
                i_Params_GetGrandProfit.SUM_POS, i_Params_GetGrandProfit.SUM_NEG, ref SUM);
            if (SUM == null)
                throw new ArgumentOutOfRangeException("Parameter index is out of range.");
            return SUM ?? 0;
        }

        #endregion




        #region CheckClientPaymentStatus
        public int CheckClientPaymentStatus(Params_CheckClientPaymentStatus i_Params_CheckClientPaymentStatus)
        {
            int? remainingAmount = 0;

            _AppContext.CheckClientPaymentStatus(
                i_Params_CheckClientPaymentStatus.ClientID,
                ref remainingAmount,
                 i_Params_CheckClientPaymentStatus.OwnerID,
                i_Params_CheckClientPaymentStatus.CurrencyID
            ); 

            if (remainingAmount == null)
                throw new ArgumentOutOfRangeException("Parameter index is out of range.");

            return remainingAmount ?? 0;
        }



        #endregion

        #region CalculateStaffBalance
        public int CalculateStaffBalance(Params_CalculateStaffBalance i_Params_CalculateStaffBalance)
        {
            int? BALANCE = 0;

            _AppContext.CalculateStaffBalance(
                i_Params_CalculateStaffBalance.StaffID,
                ref BALANCE,
                i_Params_CalculateStaffBalance.OwnerID,
                 i_Params_CalculateStaffBalance.CurrencyID
            );


            if (BALANCE == null)
                throw new ArgumentOutOfRangeException("Parameter index is out of range.");

            return BALANCE ?? 0;
        }



        #endregion


        #region CheckUserExists
        public bool UP_CHECK_USER_EXISTENCE(Params_UP_CHECK_USER_EXISTENCE i_Params_UP_CHECK_USER_EXISTENCE)
        {
            bool? exists=true;

            _AppContext.UP_CHECK_USER_EXISTENCE(
               (int?)i_Params_UP_CHECK_USER_EXISTENCE.OwnerID,
               i_Params_UP_CHECK_USER_EXISTENCE.Username,
               ref exists

            );


            return (bool)exists;
        }
        //Int32? OWNER_ID, string USERNAME,ref bool? EXISTS



        #endregion
        #region UpdatePassword

        public void UpdatePassword(Params_UpdatePassword i_Params_UpdatePassword)
        {
            bool? exists = true;
            /// UpdatePassword
            _AppContext.UpdatePassword(
              i_Params_UpdatePassword.OwnerID,
               i_Params_UpdatePassword.Username,
               i_Params_UpdatePassword.updatedpassword
            );
        }



        #endregion

        #region login

        public int LoginFct(Params_LoginFct i_Params_LoginFct)
        {
            int? res = 0;

            _AppContext.LoginFct(
               i_Params_LoginFct.OwnerID,
               i_Params_LoginFct.Username,
               i_Params_LoginFct.password,

               ref res

            );


            if (res == null)
                throw new ArgumentOutOfRangeException("Parameter index is out of range.");

            return res ?? 0;
        }



        #endregion


    }


    #region Business Entities
    #region Setup
    #region SetupEntry
    public class SetupEntry
    {
        #region Properties
        public Int32? OWNER_ID { get; set; }
        public string TBL_NAME { get; set; }
        public string CODE_NAME { get; set; }
        public bool? ISSYSTEM { get; set; }
        public bool? ISDELETEABLE { get; set; }
        public bool? ISUPDATEABLE { get; set; }
        public bool? ISVISIBLE { get; set; }
        public bool? ISDELETED { get; set; }
        public Int32? DISPLAY_ORDER { get; set; }
        public string CODE_VALUE_EN { get; set; }
        public string CODE_VALUE_FR { get; set; }
        public string CODE_VALUE_AR { get; set; }
        public string ENTRY_DATE { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string NOTES { get; set; }

        public string INVARIANT_VALUE { get; set; }
        #endregion
    }
    #endregion    
    #endregion
    #region Uploaded_file
    public partial class Uploaded_file
    {
        public string My_URL { get; set; }
    }
    #endregion
    #region UserInfo
    public class UserInfo
    {
        #region Properties
        public long? UserID { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsAuthenticated { get; set; }
        public BLC.Enum_Language Language { get; set; }
        public Int32? OwnerID { get; set; }
        public string Ticket { get; set; }
        public string USER_TYPE_CODE { get; set; }
        #endregion
    }

    public partial class Params_Auto_Prepare_Ticket
    {
        #region Properties.
        public string input { get; set; }
        #endregion
    }
    #endregion
    #region salesSum


    #endregion
    #region Authentication
    public partial class Params_Authenticate
    {
        #region Properties.
        public string USER_NAME { get; set; }
        public string PASSWORD { get; set; }
        #endregion
    }
    #endregion
    #endregion

    public partial class Params_Sales_Sum
    {
        #region Properties
        public long? OWNER_ID { get; set; }
        public Int32? CURRENCY_ID { get; set; }

        #endregion
    }

    public partial class Params_Expenses_Sum
    {
        #region Properties
        public long? OWNER_ID { get; set; }
        public Int32? CURRENCY_ID { get; set; }



        #endregion
    }
    public partial class Params_GetGrandProfit
    {
        #region Properties
        public long? OWNER_ID { get; set; }
        public Int32? CURRENCY_ID { get; set; }

        public Int32? SUM_POS { get; set; }

        public Int32? SUM_NEG { get; set; }


        #endregion
    }

    public partial class Params_CheckClientPaymentStatus
    {
        public long? OwnerID { get; set; }
        public Int32? ClientID { get; set; }


        public Int32? CurrencyID { get; set; }



    }

    public partial class Params_CalculateStaffBalance
    {
        public long? OwnerID { get; set; }
        public Int32? StaffID { get; set; }


        public Int32? CurrencyID { get; set; }
    }
    public partial class Params_UP_CHECK_USER_EXISTENCE
    {
        public long? OwnerID { get; set; }
        public string Username { get; set; }
     

    }
    public partial class Params_UpdatePassword
    {
        public long? OwnerID { get; set; }
        public string Username { get; set; }

        public string updatedpassword { get; set; }


    }

    public partial class Params_LoginFct
    {
        public int? OwnerID { get; set; }
        public string Username { get; set; }

        public string password { get; set; }
    }
}