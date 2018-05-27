using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IMIC.VALUEOBJECTS;
using IMIC.DATAACCESSLAYERS;

namespace IMIC.BUSINESSLOGICLAYERS
{
    //Comment check Github 01:28 28-05-2018 TungVP
    public class AccountBill : BaseBll<Account>
    {        
        AccountDAL mAccountDAL;       
        public AccountBill(Account oAccount) : base(oAccount)
        {            
            mAccountDAL = new AccountDAL(oAccount);
        }
        public override List<Account> CheckElementByObject(Account oT)
        {
            return mAccountDAL.CheckElementByObject(oT);
        }
        public override List<Account> getElements()
        {
            return mAccountDAL.getElements();
        }
        public override bool InsertElement(Account oT)
        {
            return mAccountDAL.InsertElement(oT);
        }
        public override bool DeleteElement(Account oT)
        {
            return mAccountDAL.DeleteElement(oT);
        }
        public override bool UpdateElement(Account oT)
        {
            return mAccountDAL.UpdateElement(oT);
        }
        public override Account getElementById(object id)
        {
            return mAccountDAL.getElementById(id);
        }
       
    }
}
