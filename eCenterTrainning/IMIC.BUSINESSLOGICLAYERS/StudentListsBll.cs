using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.VALUEOBJECTS;
using IMIC.DATAACCESSLAYERS;

namespace IMIC.BUSINESSLOGICLAYERS
{
    public class StudentListsBll : BaseBll<StudentLists>
    {
        private StudentListsDAL mStudentListsDAL;
        public StudentListsBll(Account oAccount) : base(oAccount)
        {
            mStudentListsDAL = new StudentListsDAL(mAccount);
        }
        public override List<StudentLists> getElements()
        {
            return mStudentListsDAL.getElements();
        }
        public override List<StudentLists> getElementByTime(DateTime dtStartTime, DateTime dtEndTime)
        {
            return mStudentListsDAL.getElementByTime(dtStartTime, dtEndTime);
        }
        public override StudentLists getElementById(object id)
        {
            return mStudentListsDAL.getElementById(id);
        }       
        public override bool InsertAndUpdateElement(StudentLists oT)
        {
            return mStudentListsDAL.InsertAndUpdate(oT);
        }
        public bool InsertAndUpdateNoEncrypt(StudentLists oT)
        {
            return mStudentListsDAL.InsertAndUpdateNoEncrypt(oT);
        }
    }
}
