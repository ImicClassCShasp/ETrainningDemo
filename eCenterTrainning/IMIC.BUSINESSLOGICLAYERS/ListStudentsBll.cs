using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.VALUEOBJECTS;
using IMIC.DATAACCESSLAYERS;

namespace IMIC.BUSINESSLOGICLAYERS
{
    public class ListStudentsBll : BaseBll<ListStudents>
    {
        ListStudentsDAL mListStudentsDAL;
        public ListStudentsBll(Account oAccount) : base(oAccount)
        {
            mListStudentsDAL = new ListStudentsDAL(mAccount);
        }
        public override List<ListStudents> CheckElementById(object Id)
        {
            return mListStudentsDAL.CheckElementById(Id);
        }
    }
}
