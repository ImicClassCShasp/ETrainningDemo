using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.VALUEOBJECTS;

namespace IMIC.DATAACCESSLAYERS
{
    public class CandidatesDAL : BaseDAL<Candidate>
    {
        public CandidatesDAL(Account oAccount) : base(oAccount)
        {
        }
        public override List<Candidate> getElements()
        {
            List<Candidate> lstCan = new List<Candidate>();
            TrainingCenterEntities oEntity = ConnectionEntities.getTrainingCenter(mAcount);
            var lst = oEntity.SP_GetAll_CandidateV2();
            foreach (var item in lst)
            {
                Candidate oCan = new Candidate();
                oCan.Id = item.Id;
                oCan.FirstName = item.FirstName;
                oCan.LastName = item.LastName;
                oCan.FullName = item.FullName;
                oCan.DateBirthday = item.DateBirthday;
                oCan.Sex = item.Sex;
                oCan.Address = item.Address;
                oCan.Description = item.Description;
                oCan.YearsExperience = item.YearsExperience;
                oCan.UniversityDegree = item.UniversityDegree;
                oCan.CenterId = item.CenterId;
                oCan.Avatar = item.Avatar;
                oCan.ImagePath = item.ImagePath;
                oCan.Contents = item.Contents;
                oCan.DocumentPath = item.DocumentPath;
                oCan.DateCreate = item.DateCreate;
                oCan.DateLastUpdate = item.DateLastUpdate;
                oCan.DateInterview = item.DateInterview;
                oCan.DateSent = item.DateSent;
                oCan.Notes = item.Notes;
                oCan.RecruitmentId = item.RecruitmentId;
                oCan.OrderNumber = item.OrderNumber;
                oCan.JobTitleId = item.JobTitleId;
                oCan.Status = item.Status;
                oCan.JobTitle = item.JobTitle;
                oCan.Name = item.Name;
                if (item.Sex == 0) oCan.SexString = "Nữ";
                else if (item.Sex == 1) oCan.SexString = "Nam";
                
                lstCan.Add(oCan);
            }
            return lstCan;
        }
        
        public List<Candidate> GetElementByIDRecruitment(int id)
        {
            List<Candidate> lstCan = new List<Candidate>();
            TrainingCenterEntities oEntity = ConnectionEntities.getTrainingCenter(mAcount);
            var lst = oEntity.SP_GetCandidate_ByIdRecruitmentV2(id);
            foreach (var item in lst)
            {
                Candidate oCan = new Candidate();
                oCan.Id = item.Id;
                oCan.FirstName = item.FirstName;
                oCan.LastName = item.LastName;
                oCan.FullName = item.FullName;
                oCan.DateBirthday = item.DateBirthday;
                oCan.Sex = item.Sex;
                oCan.Address = item.Address;
                oCan.Description = item.Description;
                oCan.YearsExperience = item.YearsExperience;
                oCan.UniversityDegree = item.UniversityDegree;
                oCan.CenterId = item.CenterId;
                oCan.Avatar = item.Avatar;
                oCan.ImagePath = item.ImagePath;
                oCan.Contents = item.Contents;
                oCan.DocumentPath = item.DocumentPath;
                oCan.DateCreate = item.DateCreate;
                oCan.DateLastUpdate = item.DateLastUpdate;
                oCan.DateInterview = item.DateInterview;
                oCan.DateSent = item.DateSent;
                oCan.Notes = item.Notes;
                oCan.RecruitmentId = item.RecruitmentId;
                oCan.OrderNumber = item.OrderNumber;
                oCan.JobTitleId = item.JobTitleId;
                oCan.Status = item.Status;
                oCan.JobTitle = item.JobTitle;
                oCan.Name = item.Name;
                if (item.Sex == 0) oCan.SexString = "Nữ";
                else if (item.Sex == 1) oCan.SexString = "Nam";

                lstCan.Add(oCan);
            }
            return lstCan;
        }
        public override bool DeleteElement(object id)
        {
            TrainingCenterEntities oEntity = ConnectionEntities.getTrainingCenter(mAcount);
            return oEntity.SP_Delete_Candidate(int.Parse(""+ id))>0?true:false;
        }
        public override bool InsertElement(Candidate oT)
        {
            TrainingCenterEntities oEntity = ConnectionEntities.getTrainingCenter(mAcount);

            return oEntity.SP_Creat_Candidate(null,null,oT.FullName,oT.DateBirthday,oT.Sex,oT.Address,oT.Description,
                oT.YearsExperience,oT.UniversityDegree,oT.CenterId,null,oT.ImagePath,oT.Contents,oT.DocumentPath,
                DateTime.Now,DateTime.Now,null,oT.DateSent,oT.Notes,oT.RecruitmentId,null,oT.JobTitleId,null)
                >0?true:false;
        }
        public override bool InsertAndUpdate(Candidate oT)
        {
            TrainingCenterEntities oEntity = ConnectionEntities.getTrainingCenter(mAcount);

            return oEntity.SP_Update_Candidate(oT.Id, null, null, oT.FullName, oT.DateBirthday, oT.Sex, oT.Address, oT.Description,
                oT.YearsExperience, oT.UniversityDegree, oT.CenterId, null, oT.ImagePath, oT.Contents, oT.DocumentPath,
                DateTime.Now, DateTime.Now, null, oT.DateSent, oT.Notes, oT.RecruitmentId, null, oT.JobTitleId, null)
                > 0 ? true : false;
        }

        public override Candidate getElementById(object id)
        {
            Candidate oCan = new Candidate();

            TrainingCenterEntities oEntity = ConnectionEntities.getTrainingCenter(mAcount);
            var data = oEntity.SP_GetByID_CandidateV2(int.Parse("" + id));
            foreach (var item in data)
            {
                oCan.Id = item.Id;
                oCan.FirstName = item.FirstName;
                oCan.LastName = item.LastName;
                oCan.FullName = item.FullName;
                oCan.DateBirthday = item.DateBirthday;
                oCan.Sex = item.Sex;
                oCan.Address = item.Address;
                oCan.Description = item.Description;
                oCan.YearsExperience = item.YearsExperience;
                oCan.UniversityDegree = item.UniversityDegree;
                oCan.CenterId = item.CenterId;
                oCan.Avatar = item.Avatar;
                oCan.ImagePath = item.ImagePath;
                oCan.Contents = item.Contents;
                oCan.DocumentPath = item.DocumentPath;
                oCan.DateCreate = item.DateCreate;
                oCan.DateLastUpdate = item.DateLastUpdate;
                oCan.DateInterview = item.DateInterview;
                oCan.DateSent = item.DateSent;
                oCan.Notes = item.Notes;
                oCan.RecruitmentId = item.RecruitmentId;
                oCan.OrderNumber = item.OrderNumber;
                oCan.JobTitleId = item.JobTitleId;
                oCan.Status = item.Status;
                oCan.JobTitle = item.JobTitle;
            }

            return oCan;
        }
    }
}
