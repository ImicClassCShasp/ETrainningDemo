using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.VALUEOBJECTS;

namespace IMIC.DATAACCESSLAYERS
{
    public class AccountDAL : BaseDAL<Account>
    {        
        public AccountDAL(Account oAccount)
                : base(oAccount){}

        public override List<Account> CheckElementByObject(Account oT)
        {
            TrainingCenterEntities oEntities = ConnectionEntities.getTrainingCenter(mAcount);
            var oData = oEntities.SP_CHECK_LOGIN(oT.UserName, oT.Password).ToList();
            List<Account> lisUser = new List<Account>();
            foreach (var o in oData)
            {
                Account oUser = new Account
                {
                    UserId = o.UserId,
                    UserName = o.UserName,
                    Password = o.Password,
                    Email = o.Email,
                    DisplayName = o.DisplayName,
                    IsSuperUser = o.IsSuperUser,
                    Sex = o.Sex,
                    Phone = o.Phone,
                    isSuccess = true,
                    isAdmin = o.isAdmin
                };
                if (oUser.Sex == 0)
                    oUser.DisplaySex = "Nam";
                else
                    if(oUser.Sex == 1)
                        oUser.DisplaySex = "Nữ";
                lisUser.Add(oUser);
                break;
            }
            return lisUser.Count <= 0 ? null : lisUser;
        }
        public override List<Account> getElements()
        {
            TrainingCenterEntities oEntities = ConnectionEntities.getTrainingCenter(mAcount);
            List<Account> lstAcc = new List<Account>();
            var Data = oEntities.SP_GETALL_USER().ToList();
            foreach (var o in Data)
            {
                Account oUser = new Account
                {
                    UserId = o.UserId,
                    UserName = o.UserName,
                    Password = o.Password,
                    Email = o.Email,
                    DisplayName = o.DisplayName,
                    IsSuperUser = o.IsSuperUser,
                    Sex = o.Sex,
                    Phone = o.Phone,
                    isAdmin = o.isAdmin
                };
                if (oUser.Sex == 0)
                    oUser.DisplaySex = "Nam";
                else
                    if (oUser.Sex == 1)
                    oUser.DisplaySex = "Nữ";
                lstAcc.Add(oUser);
                
            }

            return lstAcc;
        }
        public override bool InsertElement(Account oT)
        {
            TrainingCenterEntities oEntities = ConnectionEntities.getTrainingCenter(mAcount);
            return oEntities.SP_INSERT_USER(oT.UserName, null, null, oT.IsSuperUser, oT.Phone
                , oT.Email, oT.DisplayName, oT.Password, null, null, false, mAcount.UserId, null
                , null, null, null, null, null, oT.Sex, null, null, oT.isAdmin) > 0; 
        }

        public override bool DeleteElement(Account oT)
        {
            TrainingCenterEntities oEntities = ConnectionEntities.getTrainingCenter(mAcount);
            return oEntities.SP_DELETE_USER(oT.UserId) > 0;
        }
        public override bool UpdateElement(Account oT)
        {
            TrainingCenterEntities oEntities = ConnectionEntities.getTrainingCenter(mAcount);
            return oEntities.SP_UPDATE_USER(oT.UserId, oT.UserName, null, null, oT.IsSuperUser, oT.Phone
                , oT.Email, oT.DisplayName, oT.Password, null, null, false, mAcount.UserId, null
                , null, null, null, null, null, oT.Sex, null, null) > 0;
        }
        public override Account getElementById(object id)
        {
            TrainingCenterEntities oEntities = ConnectionEntities.getTrainingCenter(mAcount);
            var oData = oEntities.SP_GETELEMENTBYID_USER((int)id).ToList();
            
            foreach (var o in oData)
            {
                Account oUser = new Account
                {
                    UserId = o.UserId,
                    UserName = o.UserName,
                    Password = o.Password,
                    Email = o.Email,
                    DisplayName = o.DisplayName,
                    IsSuperUser = o.IsSuperUser,
                    Sex = o.Sex,
                    Phone = o.Phone
                };
                if (oUser.Sex == 0)
                    oUser.DisplaySex = "Nam";
                else
                    if (oUser.Sex == 1)
                    oUser.DisplaySex = "Nữ";
                return oUser;
            }
            return null;
        }
        
    }
}
