using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.DATAACCESSLAYERS;
using IMIC.VALUEOBJECTS;

namespace IMIC.BUSINESSLOGICLAYERS
{
    public class CandidatesBLL : BaseBll<Candidate>
    {
        public CandidatesBLL(Account oAccount) : base(oAccount)
        {
        }
        public override List<Candidate> getElements()
        {
            return new CandidatesDAL(mAccount).getElements();
        }
        public List<Candidate> GetElementByIDRecruitment(int id)
        {
            return new CandidatesDAL(mAccount).GetElementByIDRecruitment(id);
        }
        public override bool DeleteElement(object id)
        {
            return new CandidatesDAL(mAccount).DeleteElement(id);
        }
        public override bool InsertElement(Candidate oT)
        {
            return new CandidatesDAL(mAccount).InsertElement(oT);
        }
        public override bool InsertAndUpdateElement(Candidate oT)
        {
            return new CandidatesDAL(mAccount).InsertAndUpdate(oT);
        }
        public override Candidate getElementById(object id)
        {
            return new CandidatesDAL(mAccount).getElementById(id);
        }
    }
}
