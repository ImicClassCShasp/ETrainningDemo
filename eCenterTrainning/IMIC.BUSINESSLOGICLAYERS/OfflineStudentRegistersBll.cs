using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.VALUEOBJECTS;
using IMIC.DATAACCESSLAYERS;

namespace IMIC.BUSINESSLOGICLAYERS
{
    public class OfflineStudentRegistersBll : BaseBll<OfflineStudentRegisters>
    {
        OfflineStudentRegistersDAL mOfflineStudentRegistersDAL;
        public OfflineStudentRegistersBll(Account oAccount) : base(oAccount)
        {
            mOfflineStudentRegistersDAL = new OfflineStudentRegistersDAL(mAccount);
        }
        public override List<OfflineStudentRegisters> getElementByTime(DateTime dtStartTime, DateTime dtEndTime)
        {
            return mOfflineStudentRegistersDAL.getElementByTime(dtStartTime, dtEndTime);
        }
        public override bool InsertElement(OfflineStudentRegisters oT)
        {
            return mOfflineStudentRegistersDAL.InsertElement(oT);
        }
    }
}
