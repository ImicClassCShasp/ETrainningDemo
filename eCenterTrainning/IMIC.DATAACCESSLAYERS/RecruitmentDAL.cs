using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.VALUEOBJECTS;

namespace IMIC.DATAACCESSLAYERS
{
    public class RecruitmentDAL : BaseDAL<RecruitmentInfo>
    {
        public RecruitmentDAL(Account oAccount) : base(oAccount)
        {
        }
        public override List<RecruitmentInfo> getElements()
        {
            List<RecruitmentInfo> lstRec = new List<RecruitmentInfo>();

            TrainingCenterEntities oEntity = ConnectionEntities.getTrainingCenter(mAcount);
            var lst = oEntity.SP_GetAll_Recruitment();
            foreach (var item in lst)
            {
                RecruitmentInfo oRec = new RecruitmentInfo();
                oRec.Avatar = item.Avatar;
                oRec.CenterId = item.CenterId;
                oRec.Contents = item.Contents;
                oRec.DateCreate = item.DateCreate;
                oRec.DateEnd = item.DateEnd;
                oRec.DateStart = item.DateStart;
                oRec.Description = item.Description;
                oRec.Id = item.Id;
                oRec.ImagePath = item.ImagePath;
                oRec.Name = item.Name;
                oRec.Number = item.Number;
                oRec.OrderNumber = item.OrderNumber;
                oRec.Request = item.Request;
                oRec.Status = item.Status;

                lstRec.Add(oRec);
            }

            return lstRec;
        }
    }
}
