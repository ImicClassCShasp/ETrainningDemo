using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.VALUEOBJECTS;
namespace IMIC.DATAACCESSLAYERS
{
    public class TabPermissionDAL : BaseDAL<stanfTabPermission>
    {
        public TabPermissionDAL(Account oAccount) : base(oAccount)
        {
        }
        public override List<stanfTabPermission> CheckElementById(object Id)
        {
            TrainingCenterEntities oEntity = ConnectionEntities.getTrainingCenter(mAcount);
            List<stanfTabPermission> lstTabPermission = new List<stanfTabPermission>();
            var data = oEntity.SP_GETELEMENT_BYUSERID_TABPERMISSION((int)Id).ToList();
            foreach (var o in data)
            {
                stanfTabPermission objTabPermission = new stanfTabPermission
                {
                    CreatedByUserId = o.CreatedByUserId,
                    PermissionId = o.PermissionId,
                    CreatedOnDate = o.CreatedOnDate,
                    DisplayRoleName = o.RoleName,
                    IsAdd = o.IsAdd,
                    IsDelete = o.IsDelete,
                    IsEdit = o.IsEdit,
                    IsList = o.IsList,
                    IsReport = o.IsReport,
                    LastModifiedByUserId = o.LastModifiedByUserId,
                    LastModifiedOnDate = o.LastModifiedOnDate,
                    PermissionList = o.PermissionList,
                    RoleId = o.RoleId,
                    TabPermissionId = o.TabPermissionId,
                    UserId = o.UserId
                    

                };
                lstTabPermission.Add(objTabPermission);
            }

            return lstTabPermission;
        }
        public override bool InsertElement(stanfTabPermission o)
        {
            TrainingCenterEntities oEntity = ConnectionEntities.getTrainingCenter(mAcount);
            return oEntity.SP_INSERT_TABPERMISSION( o.PermissionId, o.RoleId, o.UserId, o.CreatedByUserId, o.LastModifiedByUserId, o.PermissionList) > 0;
        }
        public override bool UpdateElement(stanfTabPermission o)
        {
            TrainingCenterEntities oEntity = ConnectionEntities.getTrainingCenter(mAcount);
            return oEntity.SP_UPDATE_TABPERMISSION(o.TabPermissionId, o.LastModifiedByUserId, o.IsList, o.IsAdd, o.IsEdit, o.IsDelete, o.IsReport) > 0;
        }
    }
}
