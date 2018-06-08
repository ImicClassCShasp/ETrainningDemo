using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.VALUEOBJECTS;
using IMIC.DATAACCESSLAYERS;

namespace IMIC.BUSINESSLOGICLAYERS
{
    public class JobTitleBLL : BaseBll<JobTitle>
    {
        public JobTitleBLL(Account oAccount) : base(oAccount)
        {
        }
        public override List<JobTitle> getElements()
        {
            return new JobTitleDAL(mAccount).getElements();
        }
        public override bool InsertElement(JobTitle oT)
        {
            return new JobTitleDAL(mAccount).InsertElement(oT);
        }
    }
}
