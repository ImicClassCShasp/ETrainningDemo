using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.VALUEOBJECTS;

namespace IMIC.DATAACCESSLAYERS
{
    public class ListStudentsDAL : BaseDAL<ListStudents>
    {
        public ListStudentsDAL(Account oAccount) : base(oAccount)
        {
        }
        public override List<ListStudents> getElements()
        {            
            return base.getElements();
        }
        public override List<ListStudents> CheckElementById(object Id)
        {
            TrainingCenterEntities oEntities = ConnectionEntities.getTrainingCenter(mAcount);
            var oData = oEntities.SP_GETLITSTUDENT_BYID_CLASS(int.Parse(""+Id)).ToList();
            List<ListStudents> lisTemp = new List<ListStudents>();
            if (oData != null)
            {                
                Commons oComs = new Commons();
                foreach (var o in oData)
                {
                    ListStudents oListStudents = new ListStudents
                    {
                        Id = o.Id,
                        Email = o.Email,
                        Mobile = o.Phone,
                        //ClassName = o.ClassName,
                        FullName = o.FullName,
                        //ExpertName = 
                    };
                    lisTemp.Add(oListStudents);
                }
            }
            return lisTemp;
        }
    }
}
