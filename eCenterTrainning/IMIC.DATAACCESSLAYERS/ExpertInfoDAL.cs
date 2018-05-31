using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.VALUEOBJECTS;

namespace IMIC.DATAACCESSLAYERS
{
    public class ExpertInfoDAL : BaseDAL<ExpertInfo>
    {
        public ExpertInfoDAL(Account oAccount) : base(oAccount)
        {}
        public override List<ExpertInfo> getElements()
        {
            TrainingCenterEntities oEntities = ConnectionEntities.getTrainingCenter(mAcount);
            var oData = oEntities.SP_IMIC_Get_ExpertInfo_All().ToList();
            List<ExpertInfo> oLisExpertInfo = new List<ExpertInfo>();
            if (oData != null)
            {
                foreach (var o in oData)
                {
                    ExpertInfo oExpertInfo = new ExpertInfo
                    {
                        Id = o.Id,
                        ExpertName = o.ExpertName,
                        DateBirthday = o.DateBirthday,
                        Email = o.Email,
                        Mobile = o.Mobile,
                        Address = o.Address
                    };
                    oLisExpertInfo.Add(oExpertInfo);
                }
            }
            return oLisExpertInfo;
        }
        public override bool UpdateElement(ExpertInfo oT)
        {
            TrainingCenterEntities oEntities = ConnectionEntities.getTrainingCenter(mAcount);            
            return true;
        }
    }
}
