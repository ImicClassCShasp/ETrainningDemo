using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.DATAACCESSLAYERS;

namespace IMIC.BUSINESSLOGICLAYERS
{
    public class SecurityBll
    {
        private SecurityDAL mSecurityDAL = null;
        public SecurityBll()
        {
            mSecurityDAL = new SecurityDAL();
        }
        public string EncryptionMD5(string input)
        {
            return mSecurityDAL.EncryptionMD5(input);
        }
        public string DecryptionMD5(string input)
        {
            return mSecurityDAL.DecryptionMD5(input);
        }
    }
}
