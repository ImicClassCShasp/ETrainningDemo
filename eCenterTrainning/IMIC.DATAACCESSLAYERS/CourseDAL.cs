using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.VALUEOBJECTS;

namespace IMIC.DATAACCESSLAYERS
{
    public class CourseDAL : BaseDAL<Cours>
    {
        public CourseDAL(Account oAccount) : base(oAccount){}
        public override List<Cours> getElements()
        {
            TrainingCenterEntities oEntities = ConnectionEntities.getTrainingCenter(mAcount);
            var oData = oEntities.SP_GETALL_COURSE().ToList();
            List<Cours> lisCourse = new List<Cours>();
            foreach (var o in oData)
            {
                Cours oCourse = new Cours
                {
                    Id = o.Id,
                    CourseName = o.CourseName
                };
                lisCourse.Add(oCourse);
            }
            return lisCourse.Count <= 0 ? null : lisCourse;
        }
    }
}
