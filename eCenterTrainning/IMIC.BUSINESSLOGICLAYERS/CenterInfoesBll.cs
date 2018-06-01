using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.VALUEOBJECTS;
using IMIC.DATAACCESSLAYERS;
namespace IMIC.BUSINESSLOGICLAYERS
{
    public class CenterInfoesBll : BaseBll<CenterInfo>
    {
        CenterInfoesDAL mCenterInfoes;
        public CenterInfoesBll(Account oAccount) : base(oAccount)
        {
            mCenterInfoes = new CenterInfoesDAL(mAccount);
        }
        public override List<CenterInfo> getElements()
        {
            return mCenterInfoes.getElements();
        }
    }
}
