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
            var oData = oEntities.SP_GETALL_EXPERT_INFO().ToList();
            List<ExpertInfo> oLisExpertInfo = new List<ExpertInfo>();
            if (oData != null)
            {
                foreach (var o in oData)
                {
                    string sTemp;
                    if (o.Sex == 1) sTemp = "Nam"; else sTemp = "Nữ";
                    ExpertInfo oExpertInfo = new ExpertInfo
                    {
                        Id = o.Id,
                        ExpertName = o.ExpertName,
                        DateBirthday = o.DateBirthday,
                        Email = o.Email,
                        Mobile = o.Mobile,
                        Address = o.Address,
                        CenterName = o.CenterName,
                        YearsExperience = o.YearsExperience,
                        UniversityDegree = o.UniversityDegree,
                        sSex = sTemp
                    };
                    oLisExpertInfo.Add(oExpertInfo);
                }
            }
            return oLisExpertInfo;
        }
        public override bool InsertAndUpdate(ExpertInfo oT)
        {
            TrainingCenterEntities oEntities = ConnectionEntities.getTrainingCenter(mAcount);
            Commons oCommons = new Commons();
            if (oT.sSex == "Nam") oT.Sex = 1; else oT.Sex = 0;
            oT.Email = oCommons.EncryptInfo(oT.Email);
            oT.Mobile = oCommons.EncryptInfo(oT.Mobile);
            return oEntities.SP_INSERTUPDATE_EXPERT_INFO(oT.iFlag, oT.Id, oT.ExpertName, oT.DateBirthday, oT.Sex, oT.Address, oT.Description, oT.YearsExperience, oT.UniversityDegree, oT.CenterId, oT.Email, oT.Mobile, oT.ExpertCV) > 0 ? true : false;
        }
        public override ExpertInfo getElementById(object id)
        {
            TrainingCenterEntities oEntities = ConnectionEntities.getTrainingCenter(mAcount);
            var oData = oEntities.SP_GETELEMENT_BYID_EXPERT_INFO((int)id).ToList();
            ExpertInfo oExpertInfo = new ExpertInfo();
            Commons oCommons = new Commons();
            if (oData != null)
            {
                foreach (var o in oData)
                {
                    
                    if (o.Sex == 1) oExpertInfo.sSex = "Nam"; else oExpertInfo.sSex = "Nữ";
                    oExpertInfo.Id = o.Id;
                    oExpertInfo.ExpertName = o.ExpertName;
                    oExpertInfo.DateBirthday = o.DateBirthday;
                    oExpertInfo.Email = oCommons.DecryptInfo(o.Email);
                    oExpertInfo.Mobile = oCommons.DecryptInfo(o.Mobile);
                    oExpertInfo.Address = o.Address;
                    oExpertInfo.CenterName = o.CenterName;
                    oExpertInfo.YearsExperience = o.YearsExperience;
                    oExpertInfo.UniversityDegree = o.UniversityDegree;
                    oExpertInfo.CenterId = o.CenterId;
                    return oExpertInfo;
                }
            }
            return oExpertInfo;
        }
        public override bool DeleteElement(object id)
        {
            TrainingCenterEntities oEntities = ConnectionEntities.getTrainingCenter(mAcount);
            return oEntities.SP_DELETE_EXPERTINFO_XOA((int)id) > 0 ? true : false ;
        }
    }
}
