using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.VALUEOBJECTS;
using IMIC.DATAACCESSLAYERS;
namespace IMIC.BUSINESSLOGICLAYERS
{
    public class TabPermissionBLL : BaseBll<stanfTabPermission>
    {
        TabPermissionDAL mTabPermissionDAL;
        public TabPermissionBLL(Account oAccount) : base(oAccount)
        {
            mTabPermissionDAL = new TabPermissionDAL(mAccount);
        }

        public override List<stanfTabPermission> CheckElementById(object Id)
        {
            return mTabPermissionDAL.CheckElementById(Id);
        }
        public override bool InsertElement(stanfTabPermission oT)
        {
            return mTabPermissionDAL.InsertElement(oT);
        }
        public override bool UpdateElement(stanfTabPermission oT)
        {
            return mTabPermissionDAL.UpdateElement(oT);
        }
    }
}
