using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.VALUEOBJECTS;

namespace IMIC.DATAACCESSLAYERS
{
    public class EmployeeDAL : BaseDAL<Employee>
    {
        public EmployeeDAL(Account oAccout) : base(oAccout) { }

        public override List<Employee> getElements()
        {
            List<Employee> listEmployee = new List<Employee>();

            TrainingCenterEntities oEntities = ConnectionEntities.getTrainingCenter(mAcount);

            var list = oEntities.SP_GetAll_Employees();
            foreach (var item in list)
            {
                Employee employee = new Employee();
                employee.Id = item.Id;
                employee.Sex = item.Sex;
                if (item.Sex == 0) employee.SexString = "Nữ";
                else employee.SexString = "Nam";
                employee.Mobile = item.Mobile;
                employee.Address = item.Address;
                employee.CenterId = item.CenterId;
                employee.DateBirhday = item.DateBirhday;
                employee.DateCreate = item.DateCreate;
                employee.DateLastUpdate = item.DateLastUpdate;
                employee.DateOfIssue = item.DateOfIssue;
                employee.DateRegister = item.DateRegister;
                employee.Description = item.Description;
                employee.Email = item.Email;
                employee.EmployeeCV = item.EmployeeCV;
                employee.EmployeeName = item.EmployeeName;

                employee.CenterName = item.CenterName;
                employee.OuName = item.OuName;

                listEmployee.Add(employee);
            }

            return listEmployee;
        }

        public Employee getElementById(int id)
        {
            Employee oEmp = new Employee()
            {
                Id = id
            };

            TrainingCenterEntities oEntity = ConnectionEntities.getTrainingCenter(mAcount);

            var data = oEntity.SP_GetByID_Employee(oEmp.Id);

            foreach (var item in data)
            {
                oEmp.EmployeeName = item.EmployeeName;
                oEmp.Email = item.Email;
                oEmp.Address = item.Address;
                oEmp.Mobile = item.Mobile;
                oEmp.Phone = item.Phone;
                oEmp.IdentityNumber = item.IdentityNumber;
                oEmp.PersonalTaxCode = item.PersonalTaxCode;
                oEmp.Description = item.Description;
                oEmp.PlaceOfIssue = item.PlaceOfIssue;
                oEmp.PlaceBirthday = item.PlaceBirthday;
                oEmp.EmployeeCV = item.EmployeeCV;
                oEmp.UniversityName = item.UniversityName;
                oEmp.Sex = item.Sex;

                if (item.Sex == 0) oEmp.SexString = "Nữ";
                else oEmp.SexString = "Nam";

                oEmp.DateBirhday = item.DateBirhday;
                oEmp.DateOfIssue = item.DateOfIssue;
                oEmp.OuId = item.OuId;
                oEmp.CenterId = item.CenterId;
                oEmp.JobTitleId = item.JobTitleId;
                return oEmp;
            }

            return null;
        }

        public override bool InsertElement(Employee oT)
        {
            TrainingCenterEntities oEntity = ConnectionEntities.getTrainingCenter(mAcount);

            return oEntity.SP_Creat_Employees(oT.EmployeeName, oT.Sex, oT.DateBirhday, oT.Mobile, oT.Phone, oT.Email
                    ,oT.UniversityName, oT.Address,oT.IdentityNumber,oT.DateOfIssue, oT.PlaceOfIssue,oT.PlaceBirthday,oT.PersonalTaxCode,
                    oT.Description, null, oT.DateCreate, oT.DateLastUpdate, oT.DateRegister, oT.JobTitleId, oT.CenterId,
                    oT.OuId, null)> 0 ? true : false;
        }

        public override bool InsertAndUpdate(Employee oT)
        {
            TrainingCenterEntities oEntity = ConnectionEntities.getTrainingCenter(mAcount);

            return oEntity.SP_Update_Employee(oT.Id,oT.EmployeeName,oT.Sex,oT.DateBirhday,oT.Mobile,oT.Phone,oT.Email,oT.UniversityName,oT.Address
                ,oT.IdentityNumber,oT.DateOfIssue,oT.PlaceOfIssue,oT.PlaceBirthday,oT.PersonalTaxCode,oT.Description,null,oT.DateCreate,oT.DateRegister,oT.JobTitleId,
                oT.CenterId,oT.OuId,oT.EmployeeCV)>0?true:false;
        }

        public override bool DeleteElement(Employee oT)
        {
            TrainingCenterEntities oEntity = ConnectionEntities.getTrainingCenter(mAcount);

            return oEntity.SP_Delete_Employee(oT.Id)>0?true:false;
        }
    }
}
