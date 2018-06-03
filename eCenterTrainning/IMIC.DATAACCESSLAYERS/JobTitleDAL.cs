using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.VALUEOBJECTS;

namespace IMIC.DATAACCESSLAYERS
{
    public class JobTitleDAL:BaseDAL<JobTitle>
    {
        public JobTitleDAL(Account oAcc) : base(oAcc) { }

        public override List<JobTitle> getElements()
        {
            List<JobTitle> lstJob = new List<JobTitle>();

            TrainingCenterEntities oEntity = ConnectionEntities.getTrainingCenter(mAcount);

            var lst = oEntity.SP_GetAll_ChucVu();

            foreach (var item in lst)
            {
                JobTitle Job = new JobTitle();
                Job.Id = item.Id;
                Job.JobTitle1 = item.JobTitle;
                Job.ImageName = item.ImageName;
                Job.ImagePath = item.ImagePath;
                Job.OrderNumber = item.OrderNumber;

                lstJob.Add(Job);
            }
            return lstJob;
        }
    }
}
