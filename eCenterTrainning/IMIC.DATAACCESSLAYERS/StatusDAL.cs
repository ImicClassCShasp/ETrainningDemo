using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.VALUEOBJECTS;

namespace IMIC.DATAACCESSLAYERS
{
    public class StatusDAL : BaseDAL<Status>
    {
        public StatusDAL(Account oAccount) : base(oAccount){}

        public override List<Status> getElements()
        {
            TrainingCenterEntities oEntities = ConnectionEntities.getTrainingCenter(mAcount);
            var oData = oEntities.SP_IMIC_Get_Status().ToList();
            List<Status> lisStatus = new List<Status>();
            foreach (var o in oData)
            {
                Status oStatus = new Status
                {
                    Id = o.Id,
                    StatusName = o.StatusName
                };
                lisStatus.Add(oStatus);
            }
            return lisStatus.Count <= 0 ? null : lisStatus;
        }
    }
}
