using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.VALUEOBJECTS;
using IMIC.DATAACCESSLAYERS;

namespace IMIC.BUSINESSLOGICLAYERS
{
    public class StudentRegisterOnlineBll : BaseBll<Student_Register_Online>
    {
        StudentRegisterOnlineDAL mStudentRegisterOnlineDAL;
        public StudentRegisterOnlineBll(Account oAccount) : base(oAccount)
        {
            mStudentRegisterOnlineDAL = new StudentRegisterOnlineDAL(oAccount);
        }
        public override Student_Register_Online getElementById(object id)
        {
            return mStudentRegisterOnlineDAL.getElementById(id);
        }
    }
}
