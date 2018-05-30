using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.VALUEOBJECTS;
using IMIC.SyncModule;

namespace IMIC.DATAACCESSLAYERS
{
    public class OfflineStudentRegistersDAL : BaseDAL<OfflineStudentRegisters>
    {
        public OfflineStudentRegistersDAL(Account oAccount) : base(oAccount)
        {
        }
        public override List<OfflineStudentRegisters> getElementByTime(DateTime dtStartTime, DateTime dtEndTime)
        {
            TrainingCenterEntities oEntities = ConnectionEntities.getTrainingCenter(mAcount);
            var oData = oEntities.SP_IMIC_Student_Register_Offline_ByTimes(dtStartTime, dtEndTime).ToList();
            List<OfflineStudentRegisters> lisOffRegister = new List<OfflineStudentRegisters>();
            Commons oCommons = new Commons(mAcount);
            foreach (var o in oData)
            {
                OfflineStudentRegisters oRegister = new OfflineStudentRegisters();
                oRegister.RegisterDetailId = o.RegisterDetailId;
                oRegister.FullName = o.FullName;
                oRegister.Email = oCommons.DecryptInfo(o.Email);
                oRegister.Phone = oCommons.DecryptInfo(o.Phone);
                oRegister.Message = o.Message;
                oRegister.Address = o.Address;
                oRegister.CreatedTime = (DateTime)o.CreatedTime;
                oRegister.UpdateDateTime = (DateTime)o.UpdateDateTime;
                oRegister.UserName = o.UserName;
                
                lisOffRegister.Add(oRegister);
            }
            return lisOffRegister.Count <= 0 ? null : lisOffRegister;
        }
        public override bool InsertElement(OfflineStudentRegisters oT)
        {
            TrainingCenterEntities oEntities = ConnectionEntities.getTrainingCenter(mAcount);
            oEntities.SP_IMIC_Insert_StudentRegisterOnline(""+oT.RegisterDetailId, oT.FullName, 
                            oT.Email, oT.Phone, oT.Address, oT.Message, oT.CreatedTime, oT.UserName, oT.UpdateDateTime);
            return true;
        }
    }
}
