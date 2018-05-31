using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.VALUEOBJECTS;
using IMIC.DATAACCESSLAYERS;

namespace IMIC.BUSINESSLOGICLAYERS
{
    public class EmployeeBLL : BaseBll<Employee>
    {
        public EmployeeBLL(Account oAcc) : base(oAcc) { }
        public override List<Employee> getElements()
        {
            return new EmployeeDAL(mAccount).getElements();
        }

        public Employee getElementById(int id)
        {
            return new EmployeeDAL(mAccount).getElementById(id);
        }

        public override bool InsertElement(Employee oT)
        {
            return new EmployeeDAL(mAccount).InsertElement(oT);
        }

        public override bool InsertAndUpdateElement(Employee oT)
        {
            return new EmployeeDAL(mAccount).InsertAndUpdate(oT);
        }

        public override bool DeleteElement(Employee oT)
        {
            return new EmployeeDAL(mAccount).DeleteElement(oT);
        }
    }
}
