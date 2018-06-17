using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.VALUEOBJECTS;
namespace IMIC.DATAACCESSLAYERS
{
    public class RolesDAL : BaseDAL<stanfRole>
    {
        public RolesDAL(Account oAccount) : base(oAccount)
        {
        }
        public override List<stanfRole> getElements()
        {
            TrainingCenterEntities oEntities = ConnectionEntities.getTrainingCenter(mAcount);
            List<stanfRole> lstRole = new List<stanfRole>();
            var data = oEntities.SP_GETALL_ROLES().ToList();
            foreach (var o in data)
            {
                stanfRole obj = new stanfRole
                {
                    CreatedByOnDate = o.CreatedByOnDate,
                    CreatedByUserId = o.CreatedByUserId,
                    Description = o.Description,
                    IconFile = o.IconFile,
                    LastModifiedByUserId = o.LastModifiedByUserId,
                    LastModifiedOnDate = o.LastModifiedOnDate,
                    OrderNumber = o.OrderNumber,
                    RoleGroupId = o.RoleGroupId,
                    RoleId = o.RoleId,
                    RoleName = o.RoleName
                };
                lstRole.Add(obj);
            }
            return lstRole;
        }
    }
}
