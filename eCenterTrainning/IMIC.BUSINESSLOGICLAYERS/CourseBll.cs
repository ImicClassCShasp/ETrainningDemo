using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.VALUEOBJECTS;
using IMIC.DATAACCESSLAYERS;

namespace IMIC.BUSINESSLOGICLAYERS
{
    public class CourseBll : BaseBll<Cours>
    {
        CourseDAL mCourseDAL;
        public CourseBll(Account oAccount) : base(oAccount){
            mCourseDAL = new CourseDAL(oAccount);
        }
        public override List<Cours> getElements()
        {
            return mCourseDAL.getElements();
            //123
        }
    }
}
