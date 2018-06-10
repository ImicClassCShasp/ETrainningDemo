using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.VALUEOBJECTS;

namespace IMIC.DATAACCESSLAYERS
{
    public class RecruitmantDAL : BaseDAL<RecruitmentInfo>
    {
        public RecruitmantDAL(Account oAccount) : base(oAccount)
        {
        }
        public override List<RecruitmentInfo> getElements()
        {
            List<RecruitmentInfo> lstRec = new List<RecruitmentInfo>();

            TrainingCenterEntities oEntity = ConnectionEntities.getTrainingCenter(mAcount);
            var lst = oEntity.SP_GetAll_RecruitmentV2();
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
                oRec.OrderNumber = item.OrderNumber;
                oRec.Request = item.Request;
                oRec.Status = item.Status;
                oRec.Number = item.Number;
                oRec.CenterName = item.CenterName;

                if (DateTime.Compare(item.DateEnd.Value, DateTime.Now) < 0) oRec.strTrangThai = "Đã hết hạn";
                else oRec.strTrangThai = "Đang diễn ra";

                lstRec.Add(oRec);
            }

            return lstRec;
        }
        public override bool DeleteElement(object id)
        {
            TrainingCenterEntities oEntity = ConnectionEntities.getTrainingCenter(mAcount);

            return oEntity.SP_Delete_Recruitment(int.Parse(""+id))>0?true:false;
        }
        public override bool InsertElement(RecruitmentInfo oT)
        {
            TrainingCenterEntities oEntity = ConnectionEntities.getTrainingCenter(mAcount);

            return oEntity.SP_Creat_Recruitment(oT.Name,oT.Description,oT.Contents,DateTime.Now,oT.DateStart,
                oT.DateEnd,oT.Number,oT.Request,oT.CenterId,oT.OrderNumber,oT.Avatar,oT.ImagePath,oT.Status)>0?
                true:false;
        }
        public override bool InsertAndUpdate(RecruitmentInfo oT)
        {
            TrainingCenterEntities oEntity = ConnectionEntities.getTrainingCenter(mAcount);

            return oEntity.SP_Update_Recruitment(oT.Id, oT.Name, oT.Description, oT.Contents, DateTime.Now, oT.DateStart,
                oT.DateEnd, oT.Number, oT.Request, oT.CenterId, oT.OrderNumber, oT.Avatar, oT.ImagePath, oT.Status) > 0 ?
                true : false;
        }
        public RecruitmentInfo GetByID_Rec(int id)
        {
            RecruitmentInfo oRec = new RecruitmentInfo();

            TrainingCenterEntities oEntity = ConnectionEntities.getTrainingCenter(mAcount);

            var data = oEntity.SP_GetByID_RecruitmentInfo(id);
            foreach (var item in data)
            {
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
                oRec.OrderNumber = item.OrderNumber;
                oRec.Request = item.Request;
                oRec.Status = item.Status;
            }
            return oRec;
        }
    }
}
