using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.VALUEOBJECTS;

namespace IMIC.DATAACCESSLAYERS
{
    public class StudentClassesDAL : BaseDAL<StudentClasses>
    {
        public StudentClassesDAL(Account oAccount) : base(oAccount)
        {
        }
        public override List<StudentClasses> CheckElementById(object Id)
        {
            TrainingCenterEntities oEntities = ConnectionEntities.getTrainingCenter(mAcount);
            var oData = oEntities.SP_GETHOCPHI_BYSTUDENTID_STUDENT_CLASS(int.Parse(""+Id)).ToList();
            List<StudentClasses> olisStudentClasses = new List<StudentClasses>();
            Commons oCommons = new Commons();
                foreach (var o in oData)
                {
                    StudentClasses oStudentClasses = new StudentClasses();
                    oStudentClasses.Id = o.Id;
                    oStudentClasses.ClassId = (int)o.ClassId;
                    oStudentClasses.ClassName = o.ClassName;
                    oStudentClasses.DateStart = (DateTime)o.DateStart;
                    //oStudentClasses.Email = string.IsNullOrEmpty(o.Email) ? "" 
                    //                               : oCommons.DecryptInfo(o.Email);
                    //oStudentClasses.FullName = o.FullName;
                    //oStudentClasses.Mobile = string.IsNullOrEmpty(o.Mobile) ? ""
                    //                               : oCommons.DecryptInfo(o.Mobile);
                    //oStudentClasses.Sex = (int)o.Sex;
                    //oStudentClasses.sSex = o.sSex;
                    oStudentClasses.StudentId = (int)o.StudentId;
                    oStudentClasses.TotalPrice = string.IsNullOrEmpty("" + o.TotalPrice) ? 0 : (int)o.TotalPrice;
                    oStudentClasses.Price1 = string.IsNullOrEmpty(""+o.Price1) ? 0 : (int)o.Price1;
                    oStudentClasses.Price2 = string.IsNullOrEmpty(""+o.Price2) ? 0 : (int)o.Price2;
                    oStudentClasses.Price3 = string.IsNullOrEmpty(""+o.Price3) ? 0 : (int)o.Price3;
                    oStudentClasses.MustPay = string.IsNullOrEmpty(""+o.MustPay) ? 0 : (int)o.MustPay;
                    olisStudentClasses.Add(oStudentClasses);
                }                           
            return olisStudentClasses;
        }
        public override bool DeleteElement(StudentClasses oT)
        {
            TrainingCenterEntities oEntities = ConnectionEntities.getTrainingCenter(mAcount);
            oEntities.SP_Delete_Student_Class_By_Id(oT.Id);
            return true;
        }
    }
}
