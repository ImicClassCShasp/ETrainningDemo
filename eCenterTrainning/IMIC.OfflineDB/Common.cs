using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.EntityClient;
using System.Data.SqlClient;
using System.Globalization;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;


namespace IMIC.OfflineDB
{
    public class Common
    {                

        
        private const string KEY = "imic.edu.vn, key provided by Admin";
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
       
        public Common()
        {

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
