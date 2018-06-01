using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.VALUEOBJECTS;
using IMIC.DATAACCESSLAYERS;

namespace IMIC.BUSINESSLOGICLAYERS
{
    public class RecruitmentBLL : BaseBll<RecruitmentInfo>
    {
        public RecruitmentBLL(Account oAccount) : base(oAccount)
        {
        }
        public override List<RecruitmentInfo> getElements()
        {
            return new RecruitmentDAL(mAccount).getElements();
        }
    }
}
