using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.VALUEOBJECTS;
using IMIC.DATAACCESSLAYERS;

namespace IMIC.BUSINESSLOGICLAYERS
{
    public class StudentClassesBll : BaseBll<StudentClasses>
    {
        StudentClassesDAL mStudentClassesDAL;
        public StudentClassesBll(Account oAccount) : base(oAccount)
        {
            mStudentClassesDAL = new StudentClassesDAL(mAccount);
        }
        public override List<StudentClasses> CheckElementById(object Id)
        {
            return mStudentClassesDAL.CheckElementById(Id);
        }
        public override bool DeleteElement(StudentClasses oT)
        {
            return mStudentClassesDAL.DeleteElement(oT);
        }
        public override List<StudentClasses> CheckElementByObject(StudentClasses oT)
        {
            return mStudentClassesDAL.CheckElementByObject(oT);
        }
        public override bool InsertElement(StudentClasses oT)
        {
            return mStudentClassesDAL.InsertElement(oT);
        }
    }
}
