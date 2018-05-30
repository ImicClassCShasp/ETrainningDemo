using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.VALUEOBJECTS;
using IMIC.DATAACCESSLAYERS;

namespace IMIC.BUSINESSLOGICLAYERS
{
    public class StudentBll : BaseBll<Student>
    {
        StudentDAL mStudentDAL;
        public StudentBll(Account oAccount) : base(oAccount){
            mStudentDAL = new StudentDAL(oAccount);
        }
        public override bool DeleteElement(Student oT)
        {
            return mStudentDAL.DeleteElement(oT);
        }
    }
}
