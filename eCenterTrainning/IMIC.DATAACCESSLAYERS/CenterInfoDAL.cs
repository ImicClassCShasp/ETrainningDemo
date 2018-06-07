using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.VALUEOBJECTS;

namespace IMIC.DATAACCESSLAYERS
{
    public class CenterInfoDAL:BaseDAL<CenterInfo>
    {
        public CenterInfoDAL(Account oAcc) : base(oAcc) { }

        public override List<CenterInfo> getElements()
        {
            List<CenterInfo> lstCenter = new List<CenterInfo>();

            TrainingCenterEntities oEntity = ConnectionEntities.getTrainingCenter(mAcount);
            var lst = oEntity.SP_GetAll_TrungTam();

            foreach (var item in lst)
            {
                CenterInfo Center = new CenterInfo();
                Center.Id = item.Id;
                Center.CenterName = item.CenterName;

                lstCenter.Add(Center);
            }
            return lstCenter;
        }
        public override bool InsertElement(CenterInfo oT)
        {
            TrainingCenterEntities oEntity = ConnectionEntities.getTrainingCenter(mAcount);

            return oEntity.SP_Creat_CenterInfo(oT.CenterName, null, oT.Phone, oT.Fax, oT.Address, oT.Website,
                oT.Email, oT.Description) > 0 ? true : false;
        }
    }
}
