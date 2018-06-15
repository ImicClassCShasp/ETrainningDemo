using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.VALUEOBJECTS;
using IMIC.DATAACCESSLAYERS;
namespace IMIC.BUSINESSLOGICLAYERS
{
    public class RolesBLL : BaseBll<stanfRole>
    {
        RolesDAL mRolesDAL;
        public RolesBLL(Account oAccount) : base(oAccount)
        {
            mRolesDAL = new RolesDAL(mAccount);
        }
        public override List<stanfRole> getElements()
        {
            return mRolesDAL.getElements();
        }
    }
}
