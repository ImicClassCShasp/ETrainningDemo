using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.VALUEOBJECTS;

namespace IMIC.DATAACCESSLAYERS
{
    public class StudentDAL : BaseDAL<Student>
    {
        public StudentDAL(Account oAccount)
                : base(oAccount) { }
        public override bool DeleteElement(Student oT)
        {
            TrainingCenterEntities oEntities = ConnectionEntities.getTrainingCenter(mAcount);
            oEntities.SP_IMIC_Delete_Student(oT.Id);
            return true;
        }
       
    }
}
