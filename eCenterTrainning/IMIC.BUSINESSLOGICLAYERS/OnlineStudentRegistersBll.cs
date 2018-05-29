using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.VALUEOBJECTS;
using IMIC.DATAACCESSLAYERS;

namespace IMIC.BUSINESSLOGICLAYERS
{
    public class OnlineStudentRegistersBll : BaseBll<OnlineStudentRegisters>
    {
        OnlineStudentRegistersDAL mOnlineStudentRegistersDAL;
        public OnlineStudentRegistersBll(Account oAccount) : base(oAccount)
        {
            mOnlineStudentRegistersDAL = new OnlineStudentRegistersDAL(mAccount);
        }
        public override List<OnlineStudentRegisters> getElements()
        {
            return mOnlineStudentRegistersDAL.getElements();
        }
        public override bool UpdateElement(OnlineStudentRegisters oT)
        {
            return mOnlineStudentRegistersDAL.UpdateElement(oT);
        }
    }
}
