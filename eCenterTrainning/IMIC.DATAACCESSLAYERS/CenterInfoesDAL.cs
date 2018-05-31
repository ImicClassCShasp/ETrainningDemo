using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.VALUEOBJECTS;
namespace IMIC.DATAACCESSLAYERS
{
    public class CenterInfoesDAL : BaseDAL<CenterInfo>
    {
        public CenterInfoesDAL(Account oAccount) : base(oAccount) { }
        public override List<CenterInfo> getElements()
        {
            TrainingCenterEntities oEntities = ConnectionEntities.getTrainingCenter(mAcount);
            var oData = oEntities.SP_GetAll_TrungTam().ToList();
            List<CenterInfo> lstCen = new List<CenterInfo>();
            foreach (var item in oData)
            {
                CenterInfo oCen = new CenterInfo();
                oCen.Id = item.Id;
                oCen.CenterName = item.CenterName;
                oCen.Email = item.Email;
                oCen.Description = item.Description;
                oCen.Address = item.Address;
                oCen.Fax = item.Fax;
                oCen.Phone = item.Phone;
                oCen.Mobile = item.Mobile;
                oCen.Website = item.Website;
                lstCen.Add(oCen);
            }
            return lstCen;
        }
    }
}
