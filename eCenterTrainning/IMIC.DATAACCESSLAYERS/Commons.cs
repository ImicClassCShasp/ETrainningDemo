using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.Entity.Core.EntityClient;
using System.Security.Cryptography;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections;
using System.Net;
using IMIC.VALUEOBJECTS;


namespace IMIC.DATAACCESSLAYERS
{
    internal class Commons
    {
        Account mAccount;        
        public ConnectionEntity getConnEntityInfo()
        {
            if (mAccount.isOnline == false)
            {
                ConnectionEntity obj = new ConnectionEntity();
                obj.serverName = DecryptInfo("" + ConfigurationManager.AppSettings["iMICServerOffline"]);
                obj.databaseName = DecryptInfo("" + ConfigurationManager.AppSettings["iMICDatabaseOffline"]);
                obj.userName = DecryptInfo("" + ConfigurationManager.AppSettings["iMICUserOffline"]);
                obj.password = DecryptInfo("" + ConfigurationManager.AppSettings["iMICPassOffline"]);
                return obj;
            }
            else
            {
                ConnectionEntity obj = new ConnectionEntity();
                if (mAccount.sLocation.Equals("HaNoi"))
                    obj.serverName = DecryptInfo("" + ConfigurationManager.AppSettings["IMICHN"]);
                else
                    obj.serverName = DecryptInfo("" + ConfigurationManager.AppSettings["IMICHCM"]);
                obj.databaseName = DecryptInfo("" + ConfigurationManager.AppSettings["IMICDatabaseName"]);
                obj.userName = DecryptInfo("" + ConfigurationManager.AppSettings["IMICUserName"]);
                obj.password = DecryptInfo("" + ConfigurationManager.AppSettings["IMICPassWord"]);
                return obj;
            }
        }
        public ConnectionEntity getConnEntityOfflineInfo()
        {
            ConnectionEntity obj = new ConnectionEntity();
            obj.serverName = DecryptInfo("" + ConfigurationManager.AppSettings["iMICServerOffline"]);
            obj.databaseName = DecryptInfo("" + ConfigurationManager.AppSettings["iMICDatabaseOffline"]);
            obj.userName = DecryptInfo("" + ConfigurationManager.AppSettings["iMICUserOffline"]);
            obj.password = DecryptInfo("" + ConfigurationManager.AppSettings["iMICPassOffline"]);
            return obj;
        }

        public ConnectionEntity getConnEntityOnlineInfo()
        {
            ConnectionEntity obj = new ConnectionEntity();
            obj.serverName = DecryptInfo("" + ConfigurationManager.AppSettings["iMICServer"]);
            obj.databaseName = DecryptInfo("" + ConfigurationManager.AppSettings["iMICDatabase"]);
            obj.userName = DecryptInfo("" + ConfigurationManager.AppSettings["iMICUser"]);
            obj.password = DecryptInfo("" + ConfigurationManager.AppSettings["iMICPass"]);
            return obj;
        }

        public ConnectionEntity getConnEntityWebIMICInfo()
        {
            ConnectionEntity obj = new ConnectionEntity();
            obj.serverName = DecryptInfo("" + ConfigurationManager.AppSettings["WebIMIC_Server"]);
            obj.databaseName = DecryptInfo("" + ConfigurationManager.AppSettings["WebIMIC_DBName"]);
            obj.userName = DecryptInfo("" + ConfigurationManager.AppSettings["WebIMIC_UserName"]);
            obj.password = DecryptInfo("" + ConfigurationManager.AppSettings["WebIMIC_PassWord"]);
            return obj;
        }

        /// <summary>
        /// Thiết lập thông tin cho Entity FrameWorks
        /// </summary>
        /// <returns></returns>
        public TrainingCenterEntities getTrainingCenterInfo()
        {
            string providerName = "System.Data.SqlClient";
            ConnectionEntity objEntity = getConnEntityInfo();
            SqlConnectionStringBuilder sqlBuilder = new SqlConnectionStringBuilder();

            sqlBuilder.DataSource = objEntity.serverName;
            sqlBuilder.InitialCatalog = objEntity.databaseName;
            sqlBuilder.UserID = objEntity.userName;
            sqlBuilder.Password = objEntity.password;
            sqlBuilder.MultipleActiveResultSets = true;

            string providerString = sqlBuilder.ToString();

            EntityConnectionStringBuilder objEcsb = new EntityConnectionStringBuilder();
            objEcsb.Provider = providerName;
            objEcsb.ProviderConnectionString = providerString;
            objEcsb.Metadata = @"res://*/CMSModels.csdl|res://*/CMSModels.ssdl|res://*/CMSModels.msl";
            EntityConnection objConnection = new EntityConnection(objEcsb.ToString());

            TrainingCenterEntities objTraining = new TrainingCenterEntities(objEcsb.ToString());

            return objTraining;
        }

        public WebIMICEntities getWebIMICEntitiesInfo()
        {
            string providerName = "System.Data.SqlClient";
            ConnectionEntity objEntity = getConnEntityWebIMICInfo();
            SqlConnectionStringBuilder sqlBuilder = new SqlConnectionStringBuilder();

            sqlBuilder.DataSource = objEntity.serverName;
            sqlBuilder.InitialCatalog = objEntity.databaseName;
            sqlBuilder.UserID = objEntity.userName;
            sqlBuilder.Password = objEntity.password;
            sqlBuilder.MultipleActiveResultSets = true;

            string providerString = sqlBuilder.ToString();

            EntityConnectionStringBuilder objEcsb = new EntityConnectionStringBuilder();
            objEcsb.Provider = providerName;
            objEcsb.ProviderConnectionString = providerString;
            objEcsb.Metadata = @"res://*/WebIMICModels.csdl|res://*/WebIMICModels.ssdl|res://*/WebIMICModels.msl";
            EntityConnection objConnection = new EntityConnection(objEcsb.ToString());

            WebIMICEntities objWebIMIC = new WebIMICEntities(objEcsb.ToString());

            return objWebIMIC;
        }

        #region "Encrypt And Decrypt Information"
        private const string KEY = "imic.edu.vn, key provided by Administrator";
        private const string IV = "imiC+EDIFsA=";

        //Mã hóa thông tin
        public string EncryptInfo(string Input)
        {
            if (Input.Length == 0)
                return Input;
            byte[] Code = ASCIIEncoding.ASCII.GetBytes(Input);
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] Key = md5.ComputeHash(Encoding.Unicode.GetBytes(KEY));
            TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider();
            tripleDES.Key = Key;
            tripleDES.IV = Convert.FromBase64String(IV);
            return Convert.ToBase64String(tripleDES.CreateEncryptor().TransformFinalBlock(Code, 0, Code.Length));
        }

        //Giải mã thông tin
        public string DecryptInfo(string Input)
        {
            if (Input.Length == 0)
                return Input;
            byte[] Code = Convert.FromBase64String(Input);
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] Key = md5.ComputeHash(Encoding.Unicode.GetBytes(KEY));
            TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider();
            tripleDES.Key = Key;
            tripleDES.IV = Convert.FromBase64String(IV);
            return ASCIIEncoding.ASCII.GetString(tripleDES.CreateDecryptor().TransformFinalBlock(Code, 0, Code.Length));
        }
        #endregion

        public Commons(){}
        public Commons(Account oAccount)
        {
            mAccount = oAccount;
        }

        public enum TrangThaiHocVien
        {
            ChonTrangThai = 0,
            ChuaDangKy = 1,
            DaDangKy = 2
        }
        public static void ErrorLog(string Message)
        {
            StreamWriter sw = null;

            try
            {
                //WriteStatusBar(Message);

                string sLogFormat = DateTime.Now.ToShortDateString().ToString() + " " + DateTime.Now.ToLongTimeString().ToString() + " ==> ";
                //string sPathName = @"E:\";
                string sPathName = @"eCenterTrainning_ErrorLog_";

                string sYear = DateTime.Now.Year.ToString();
                string sMonth = DateTime.Now.Month.ToString();
                string sDay = DateTime.Now.Day.ToString();

                string sErrorTime = sDay + "-" + sMonth + "-" + sYear;

                sw = new StreamWriter(sPathName + sErrorTime + ".txt", true);

                sw.WriteLine(sLogFormat + Message);
                sw.Flush();

            }
            catch //(Exception ex)
            {
                //ErrorLog(ex.ToString());
            }
            finally
            {
                if (sw != null)
                {
                    sw.Dispose();
                    sw.Close();
                }
            }

        }
        public static int validateName(String name)
        {
            Regex r = new Regex("^[a-zA-Z0-9]*$");
            if (r.IsMatch(name))
            {
                return 1;
            }
            return 0;
        }
        public static int validateExp(String exp)
        {
            Regex r = new Regex("^[0-9]*$");
            if (r.IsMatch(exp))
            {
                return 1;
            }
            return 0;
        }
        public static int validatePhoneNumber(String phone)
        {
            Regex r = new Regex("(\\(\\d{2}\\)\\d{3}-\\d{4})|(\\d{9})");
            if (r.IsMatch(phone))
            {
                return 1;
            }
            return 0;
        }
        public static int validateMobileNumber(String mobile)
        {
            Regex r = new Regex("(\\d{10})|(\\d{11})");
            if (r.IsMatch(mobile))
            {
                return 1;
            }
            return 0;
        }
        public static ArrayList getFnameAndLname(String fullName)
        {
            ArrayList list = new ArrayList();
            string[] arr = fullName.Split(' ');
            String temp = "";
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == arr.Length - 1)
                {
                    list.Add(arr[i]);
                    break;
                }
                temp += arr[i] + " "; ;
            }
            list.Add(temp);
            return list;
        }
        /// <summary>
        /// Biểu thức chính quy bắt Email
        /// Author                   Date                Create
        /// hungld                   24/02/2013          Tạo mới
        /// </summary>
        /// <param name="Email"></param>
        /// <returns></returns>
        public static int validateEmail(String Email)
        {
            Regex r = new Regex(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
            Match mat = r.Match(Email);
            if (mat.Success)
            {
                return 1;
            }
            return 0;
        }

        /// <summary>
        /// Author          Date            Comments
        /// hunghv          02/03/2013      Tạo mới
        /// </summary>
        /// <param name="originalPassword"></param>
        /// <returns></returns>
        public static string EncodePassword(string originalPassword)
        {
            //Declarations
            Byte[] originalBytes;
            Byte[] encodedBytes;
            MD5 md5;

            //Instantiate MD5CryptoServiceProvider, get bytes for original password and compute hash (encoded password)
            md5 = new MD5CryptoServiceProvider();
            originalBytes = ASCIIEncoding.Default.GetBytes(originalPassword);
            encodedBytes = md5.ComputeHash(originalBytes);

            //Convert encoded bytes back to a 'readable' string
            return BitConverter.ToString(encodedBytes);
        }

    }
}
