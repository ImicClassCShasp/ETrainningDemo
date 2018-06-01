using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.VALUEOBJECTS;

namespace IMIC.DATAACCESSLAYERS
{
    public class OnlineStudentRegistersDAL : BaseDAL<OnlineStudentRegisters>
    {
        public OnlineStudentRegistersDAL(Account oAccount) : base(oAccount)
        {
        }
        public override List<OnlineStudentRegisters> getElements()
        {
            WebIMICEntities oEntities = ConnectionEntities.getWebIMICOnline(mAcount);
            var oData = oEntities.WEB_IMIC_SP_RegisterDetail_GetForEtraining().ToList();
            List<OnlineStudentRegisters> oLisOnlineStudentRegisters;
            if (oData != null)
            {
                oLisOnlineStudentRegisters = new List<OnlineStudentRegisters>();
                Commons oCommons = new Commons(mAcount);
                foreach (var o in oData)
                {
                    OnlineStudentRegisters oOnlineRegister = new OnlineStudentRegisters();
                    oOnlineRegister.FullName = o.FullName;
                    oOnlineRegister.Phone = o.Phone;
                    oOnlineRegister.Email = o.Email;
                    oOnlineRegister.Message = o.Message;
                    oOnlineRegister.Address = o.Address;
                    oOnlineRegister.CreatedTime = (DateTime)o.CreatedTime;
                    oOnlineRegister.RegisterDetailId = o.RegisterDetailId;

                    oLisOnlineStudentRegisters.Add(oOnlineRegister);
                }
            }
            else
            {
                return null;
            }
            return oLisOnlineStudentRegisters == null ? null : oLisOnlineStudentRegisters;
        }
        public override List<OnlineStudentRegisters> getElementByTime(DateTime dtStartTime, DateTime dtEndTime)
        {
            return base.getElementByTime(dtStartTime, dtEndTime);
        }
        public override bool UpdateElement(OnlineStudentRegisters oT)
        {
            WebIMICEntities oEntities = ConnectionEntities.getWebIMICOnline(mAcount);
            oEntities.SP_IMIC_RegisterDetail_Update_IsSeen();
            return true;
        }
    }
}
