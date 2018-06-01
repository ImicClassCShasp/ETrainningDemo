using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.VALUEOBJECTS;
using IMIC.DATAACCESSLAYERS;

namespace IMIC.BUSINESSLOGICLAYERS
{
    public class OuBLL : BaseBll<Ou>
    {
        public OuBLL(Account oAccount) : base(oAccount)
        {
        }
        public override List<Ou> getElements()
        {
            return new OuDAL(mAccount).getElements();
        }
    }
}
