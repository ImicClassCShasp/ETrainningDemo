using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMIC.DATAACCESSLAYERS
{
    public class SecurityDAL
    {
        Commons oCommons = new Commons();
        public string EncryptionMD5(string input) {
            return oCommons.EncryptInfo(input);
        }
        public string DecryptionMD5(string input)
        {
            return oCommons.DecryptInfo(input);
        }
    }
}
