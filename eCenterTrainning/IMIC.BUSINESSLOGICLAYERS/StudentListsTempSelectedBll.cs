using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.VALUEOBJECTS;
using IMIC.DATAACCESSLAYERS;

namespace IMIC.BUSINESSLOGICLAYERS
{
    public class StudentListsTempSelectedBll : BaseBll<StudentListsTempSelected>
    {
        StudentListsTempSelectedDAL mStudentListsTempSelectedDAL;
        public StudentListsTempSelectedBll(Account oAccount) : base(oAccount)
        {
            mStudentListsTempSelectedDAL = new StudentListsTempSelectedDAL(mAccount);
        }
        public override bool InsertElement(StudentListsTempSelected oT)
        {
            return mStudentListsTempSelectedDAL.InsertElement(oT);
        }

    }
}
