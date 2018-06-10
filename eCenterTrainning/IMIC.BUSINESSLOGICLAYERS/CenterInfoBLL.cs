using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.VALUEOBJECTS;
using IMIC.DATAACCESSLAYERS;

namespace IMIC.BUSINESSLOGICLAYERS
{
    public class CenterInfoBLL : BaseBll<CenterInfo>
    {
        public CenterInfoBLL(Account oAccount) : base(oAccount)
        {
        }
        public override List<CenterInfo> getElements()
        {
            return new CenterInfoDAL(mAccount).getElements();
        }
        public override bool InsertElement(CenterInfo oT)
        {
            return new CenterInfoDAL(mAccount).InsertElement(oT);
        }
    }
}
