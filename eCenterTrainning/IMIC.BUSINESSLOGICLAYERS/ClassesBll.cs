using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.VALUEOBJECTS;
using IMIC.DATAACCESSLAYERS;

namespace IMIC.BUSINESSLOGICLAYERS
{
    public class ClassesBll : BaseBll<Classes>
    {
        ClassesDAL mClassesDAL;
        public ClassesBll(Account oAccount) : base(oAccount)
        {
            mClassesDAL = new ClassesDAL(mAccount);
        }
        public override List<Classes> getElements()
        {
            return mClassesDAL.getElements();
        }
        public override bool InsertAndUpdateElement(Classes oT)
        {
            return mClassesDAL.InsertAndUpdate(oT);
        }
        public override bool UpdateElement(Classes oT)
        {
            return mClassesDAL.UpdateElement(oT);
        }
    }
}
