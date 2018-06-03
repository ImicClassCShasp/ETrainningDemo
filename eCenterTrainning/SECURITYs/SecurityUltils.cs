using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace SECURITYs
{
    class SecurityUltils
    {
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
    }
}
