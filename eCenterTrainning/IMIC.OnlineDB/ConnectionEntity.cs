using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IMIC.OnlineDB
{
    public class ConnectionEntity
    {
        public string serverName { get; set; }
        public string databaseName { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
    }
}
