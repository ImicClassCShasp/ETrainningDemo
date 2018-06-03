using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.VALUEOBJECTS;
using IMIC.DATAACCESSLAYERS;

namespace IMIC.BUSINESSLOGICLAYERS
{
    public class CandidateBLL : BaseBll<Candidate>
    {
        public CandidateBLL(Account oAccount) : base(oAccount)
        {
        }
        public override List<Candidate> getElements()
        {
            return new CandidateDAL(mAccount).getElements();
        }
        public List<Candidate> getElementById(int Id)
        {
            return new CandidateDAL(mAccount).getElementById(Id);
        }
    }
}
