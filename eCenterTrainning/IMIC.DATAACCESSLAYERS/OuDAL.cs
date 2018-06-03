using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.VALUEOBJECTS;

namespace IMIC.DATAACCESSLAYERS
{
    public class OuDAL:BaseDAL<Ou>
    {
        public OuDAL(Account oAcc) : base(oAcc) { }
        
        public override List<Ou> getElements()
        {
            List<Ou> lstOu = new List<Ou>();

            TrainingCenterEntities oEntity = ConnectionEntities.getTrainingCenter(mAcount);
            var lst = oEntity.SP_GetAll_PhongBan();

            foreach (var item in lst)
            {
                Ou ou = new Ou();
                ou.Id = item.Id;
                ou.OuName = item.OuName;

                lstOu.Add(ou);
            }
            return lstOu;
        }
    }
}
