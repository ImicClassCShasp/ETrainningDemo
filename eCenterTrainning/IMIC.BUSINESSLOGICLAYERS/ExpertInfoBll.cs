using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.VALUEOBJECTS;
using IMIC.DATAACCESSLAYERS;

namespace IMIC.BUSINESSLOGICLAYERS
{
    public class ExpertInfoBll : BaseBll<ExpertInfo>
    {
        ExpertInfoDAL mExpertInfoDAL;
        public ExpertInfoBll(Account oAccount) : base(oAccount)
        {
            mExpertInfoDAL = new ExpertInfoDAL(mAccount);
        }
        public override List<ExpertInfo> getElements()
        {
            return mExpertInfoDAL.getElements();
        }
        public override ExpertInfo getElementById(object id)
        {
            return mExpertInfoDAL.getElementById(id);
        }
        public override bool InsertAndUpdateElement(ExpertInfo oT)
        {
            return mExpertInfoDAL.InsertAndUpdate(oT);
        }
        public override bool DeleteElement(object id)
        {
            return mExpertInfoDAL.DeleteElement(id);
        }
    }
}
