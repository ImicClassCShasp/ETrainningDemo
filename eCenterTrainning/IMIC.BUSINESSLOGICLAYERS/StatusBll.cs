using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.VALUEOBJECTS;
using IMIC.DATAACCESSLAYERS;

namespace IMIC.BUSINESSLOGICLAYERS
{
    public class StatusBll : BaseBll<Status>
    {
        StatusDAL mStatusDAL;
        public StatusBll(Account oAccount) : base(oAccount){
            mStatusDAL = new StatusDAL(oAccount);
        }

        public override List<Status> getElements()
        {
            return mStatusDAL.getElements();
        }
    }
}
