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
<<<<<<< HEAD
                        Mobile = o.Phone,
                        //ClassName = o.ClassName,
=======
                        //Email = oComs.DecryptInfo(o.Email),
                        Mobile = o.Mobile,
                        ClassName = o.ClassName,
>>>>>>> 35e462a75fa5c5729d84cde2ea0c8405e1a0b849
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
