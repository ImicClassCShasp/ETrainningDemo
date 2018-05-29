using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.VALUEOBJECTS;

namespace IMIC.DATAACCESSLAYERS
{
    public class StudentRegisterOnlineDAL : BaseDAL<Student_Register_Online>
    {
        public StudentRegisterOnlineDAL(Account oAccount) : base(oAccount){}
        public override Student_Register_Online getElementById(object id)
        {
            TrainingCenterEntities oEntities = ConnectionEntities.getTrainingCenter(mAcount);
            var oData = oEntities.SP_IMIC_Check_RegisterByTime().FirstOrDefault();
            Student_Register_Online oRegister = new Student_Register_Online
            {
                CreatedTime = (DateTime)oData.CreatedTime,
                UpdateDateTime = (DateTime)oData.UpdateDateTime,
                UserName = oData.UserName
            };
            return oRegister;
        }
    }
}
