using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.VALUEOBJECTS;

namespace IMIC.DATAACCESSLAYERS
{
    public class CandidateDAL : BaseDAL<Candidate>
    {
        public CandidateDAL(Account oAccount) : base(oAccount)
        {
        }
        public override List<Candidate> getElements()
        {
            List<Candidate> lstCandidate = new List<Candidate>();

            TrainingCenterEntities oEntity = ConnectionEntities.getTrainingCenter(mAcount);
            var lst = oEntity.SP_GetAll_Candidates();
            foreach (var item in lst)
            {
                Candidate oCan = new Candidate();
                oCan.Address = item.Address;
                oCan.Avatar = item.Avatar;
                oCan.CenterId = item.CenterId;
                oCan.Contents = item.Contents;
                oCan.DateBirthday = item.DateBirthday;
                oCan.DateCreate = item.DateCreate;
                oCan.DateInterview = item.DateInterview;
                oCan.DateLastUpdate = item.DateLastUpdate;
                oCan.DateSent = item.DateSent;
                oCan.Description = item.Description;
                oCan.DocumentPath = item.DocumentPath;
                oCan.FirstName = item.FirstName;
                oCan.FullName = item.FullName;
                oCan.Id = item.Id;
                oCan.ImagePath = item.ImagePath;
                oCan.JobTitleId = item.JobTitleId;
                oCan.LastName = item.LastName;
                oCan.Notes = item.Notes;
                oCan.OrderNumber = item.OrderNumber;
                oCan.RecruitmentId = item.RecruitmentId;
                oCan.Sex = item.Sex;
                oCan.UniversityDegree = item.UniversityDegree;
                oCan.YearsExperience = item.YearsExperience;

                lstCandidate.Add(oCan);
            }
            return lstCandidate;
        }

        public List<Candidate> getElementById(int Id)
        {
            List<Candidate> listCan = new List<Candidate>();

            TrainingCenterEntities oEntity = ConnectionEntities.getTrainingCenter(mAcount);
            var lst = oEntity.SP_GetCandidate_ByIdRecruitment(Id);
            foreach (var item in lst)
            {
                Candidate oCan = new Candidate();
                oCan.Address = item.Address;
                oCan.Avatar = item.Avatar;
                oCan.CenterId = item.CenterId;
                oCan.Contents = item.Contents;
                oCan.DateBirthday = item.DateBirthday;
                oCan.DateCreate = item.DateCreate;
                oCan.DateInterview = item.DateInterview;
                oCan.DateLastUpdate = item.DateLastUpdate;
                oCan.DateSent = item.DateSent;
                oCan.Description = item.Description;
                oCan.DocumentPath = item.DocumentPath;
                oCan.FirstName = item.FirstName;
                oCan.FullName = item.FullName;
                oCan.Id = item.Id;
                oCan.ImagePath = item.ImagePath;
                oCan.JobTitleId = item.JobTitleId;
                oCan.LastName = item.LastName;
                oCan.Notes = item.Notes;
                oCan.OrderNumber = item.OrderNumber;
                oCan.RecruitmentId = item.RecruitmentId;
                oCan.Sex = item.Sex;
                oCan.UniversityDegree = item.UniversityDegree;
                oCan.YearsExperience = item.YearsExperience;

                listCan.Add(oCan);
            }

            return listCan;
        }
    }
}
