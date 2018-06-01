using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.VALUEOBJECTS;

namespace IMIC.DATAACCESSLAYERS
{
    public class StudentListsTempSelectedDAL : BaseDAL<StudentListsTempSelected>
    {
        public StudentListsTempSelectedDAL(Account oAccount) : base(oAccount)
        {
        }
        public override bool InsertElement(StudentListsTempSelected oT)
        {
            TrainingCenterEntities oEntities = ConnectionEntities.getTrainingCenter(mAcount);
            oEntities.SP_IMIC_Insert_Student_Of_Classes(oT.ClassId, oT.StudentId, oT.Description);
            return true;
        }
    }
}
