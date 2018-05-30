using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.VALUEOBJECTS;

namespace IMIC.DATAACCESSLAYERS
{
    public class BaseDAL<T>
    {
        protected Account mAcount;
        public BaseDAL(Account oAccount)
        {
            mAcount = oAccount;
        }
        public virtual List<T> getElements() { return null; }
        public virtual List<T> getElementByTime(DateTime dtStartTime, DateTime dtEndTime) { return null; }
        public virtual T getElementById(object id) { return default(T); }
        public virtual bool InsertElement(T oT) { return true; }
        public virtual bool UpdateElement(T oT) { return true; }
        public virtual bool DeleteElement(T oT) { return true; }
        public virtual List<T> CheckElementById(object Id) { return null; }
        public virtual List<T> CheckElementByObject(T oT) { return null; }
        public virtual bool InsertAndUpdate(T oT) { return true; }
    }
}
