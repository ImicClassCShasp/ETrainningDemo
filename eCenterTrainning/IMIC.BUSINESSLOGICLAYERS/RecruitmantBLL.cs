using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.DATAACCESSLAYERS;
using IMIC.VALUEOBJECTS;

namespace IMIC.BUSINESSLOGICLAYERS
{
    public class RecruitmantBLL : BaseBll<RecruitmentInfo>
    {
        public RecruitmantBLL(Account oAccount) : base(oAccount)
        {
        }
        public override List<RecruitmentInfo> getElements()
        {
            return new RecruitmantDAL(mAccount).getElements();
        }
        public override bool DeleteElement(object id)
        {
            return new RecruitmantDAL(mAccount).DeleteElement(id);
        }
        public RecruitmentInfo GetByID_Recruitment(int id)
        {
            return new RecruitmantDAL(mAccount).GetByID_Rec(id);
        }
        public override bool InsertElement(RecruitmentInfo oT)
        {
            return new RecruitmantDAL(mAccount).InsertElement(oT);
        }
        public override bool InsertAndUpdateElement(RecruitmentInfo oT)
        {
            return new RecruitmantDAL(mAccount).InsertAndUpdate(oT);
        }
    }
}
