using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.VALUEOBJECTS;

namespace IMIC.BUSINESSLOGICLAYERS
{
    public class BaseBll<T>
    {
        protected Account mAccount;
        public BaseBll(Account oAccount)
        {
            mAccount = oAccount;
        }
        public virtual List<T> getElements() { return null; }
        public virtual List<T> getElementByTime(DateTime dtStartTime, DateTime dtEndTime) { return null; }
        public virtual T getElementById(object id) { return default(T); }
        public virtual bool InsertElement(T oT) { return true; }
        public virtual bool UpdateElement(T oT) { return true; }
        public virtual bool DeleteElement(T oT) { return true; }
        public virtual List<T> CheckElementById(object Id) { return null; }
        public virtual List<T> CheckElementByObject(T oT) { return null; }
        public virtual bool InsertAndUpdateElement(T oT) { return true; }
    }
}
