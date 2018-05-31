using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.VALUEOBJECTS;

namespace IMIC.DATAACCESSLAYERS
{
    public class StudentListsDAL : BaseDAL<StudentLists>
    {
        Classes mClasses =null;
        public StudentListsDAL(Account oAccount)
                : base(oAccount) { }
        public StudentListsDAL(Account oAccount, Classes oClasses)
                : base(oAccount)
        {
            mClasses = oClasses;
        }
        public override List<StudentLists> getElements()
        {
            TrainingCenterEntities oEntities = ConnectionEntities.getTrainingCenter(mAcount);
            var oData = oEntities.SP_HienThi_DanhSach_HocVien_By03Month().ToList();
            List<StudentLists> lisStudent = new List<StudentLists>();
            Commons oCommons = new Commons();
            foreach (var o in oData)
            {
                StudentLists oStudentLists = new StudentLists();
                oStudentLists.Id = o.Id;
                oStudentLists.FullName = o.FullName;
                oStudentLists.SexString = o.SexString;
                oStudentLists.Sex = o.sex;
                oStudentLists.Mobile = string.IsNullOrEmpty(o.Mobile) ? "" : o.Mobile /*oCommons.DecryptInfo(o.Mobile)*/;
                oStudentLists.DateBirthday = o.DateBirthday;
                oStudentLists.Email = string.IsNullOrEmpty(o.Email) ? "" : o.Email/*oCommons.DecryptInfo(o.Email)*/;
                oStudentLists.Address = o.Address;
                oStudentLists.DateBirthday = o.DateBirthday;
                oStudentLists.UserId = o.UserId;
                oStudentLists.UserName = o.UserName;
                oStudentLists.CourseId = o.courseid;
                oStudentLists.CourseName = o.CourseName;
                oStudentLists.StatusId = o.StatusId;
                oStudentLists.StatusName = o.StatusName;
                oStudentLists.Description = o.Description;
                oStudentLists.DateCreate = (DateTime)o.DateCreate;
                lisStudent.Add(oStudentLists);
            }
            return lisStudent.Count <= 0 ? null : lisStudent;
        }
        public override List<StudentLists> getElementByTime(DateTime dtStartTime, DateTime dtEndTime)
        {
            TrainingCenterEntities oEntities = ConnectionEntities.getTrainingCenter(mAcount);
            
            if (mClasses != null)
            {
                var oData = oEntities.SP_GETLISTSTUDENT_NOTINCLASS_BYCLASSID_STUDENTS(dtStartTime.ToShortDateString(),mClasses.Id, dtEndTime.ToShortDateString()).ToList();
                List<StudentLists> lisStudent = new List<StudentLists>();
                Commons oCommons = new Commons();
                foreach (var o in oData)
                {
                    StudentLists oStudentLists = new StudentLists();
                    oStudentLists.Id = o.Id;
                    oStudentLists.FullName = o.FullName;
                    if (o.Sex == 0)
                        oStudentLists.SexString = "Nam";
                    else
                        oStudentLists.SexString = "Nữ";
                    oStudentLists.Sex = o.Sex;
                    oStudentLists.Mobile = string.IsNullOrEmpty(o.Mobile) ? "" : /*o.Mobile*/ oCommons.DecryptInfo(o.Mobile);
                    oStudentLists.DateBirthday = o.DateBirthday;
                    oStudentLists.Email = string.IsNullOrEmpty(o.Email) ? "" : /*o.Email*/oCommons.DecryptInfo(o.Email);
                    oStudentLists.Address = o.Address;
                    oStudentLists.DateBirthday = o.DateBirthday;
                    oStudentLists.UserId = o.UserId;
                    oStudentLists.UserName = o.UserName;
                    oStudentLists.CourseId = o.CourseId;
                    oStudentLists.CourseName = o.CourseName;
                    oStudentLists.StatusId = o.StatusId;
                    oStudentLists.StatusName = o.StatusName;
                    oStudentLists.Description = o.Description;
                    oStudentLists.DateCreate = (DateTime)o.DateCreate;
                    lisStudent.Add(oStudentLists);
                }

                return lisStudent.Count <= 0 ? null : lisStudent;
            }
            else
            {
                var oData = oEntities.SP_GETELEMENTS_BYDATE_STUDENTS(dtStartTime.ToShortDateString(), dtEndTime.ToShortDateString()).ToList();
                List<StudentLists> lisStudent = new List<StudentLists>();
                Commons oCommons = new Commons();
                foreach (var o in oData)
                {
                    StudentLists oStudentLists = new StudentLists();
                    oStudentLists.Id = o.Id;
                    oStudentLists.FullName = o.FullName;
                    if (o.Sex == 0)
                        oStudentLists.SexString = "Nam";
                    else
                        oStudentLists.SexString = "Nữ";
                    oStudentLists.Sex = o.Sex;
                    oStudentLists.Mobile = string.IsNullOrEmpty(o.Mobile) ? "" : /*o.Mobile*/ oCommons.DecryptInfo(o.Mobile);
                    oStudentLists.DateBirthday = o.DateBirthday;
                    oStudentLists.Email = string.IsNullOrEmpty(o.Email) ? "" : /*o.Email*/oCommons.DecryptInfo(o.Email);
                    oStudentLists.Address = o.Address;
                    oStudentLists.DateBirthday = o.DateBirthday;
                    oStudentLists.UserId = o.UserId;
                    oStudentLists.UserName = o.UserName;
                    oStudentLists.CourseId = o.CourseId;
                    oStudentLists.CourseName = o.CourseName;
                    oStudentLists.StatusId = o.StatusId;
                    oStudentLists.StatusName = o.StatusName;
                    oStudentLists.Description = o.Description;
                    oStudentLists.DateCreate = (DateTime)o.DateCreate;
                    lisStudent.Add(oStudentLists);
                }

                return lisStudent.Count <= 0 ? null : lisStudent;
            }
            

        }
        public override StudentLists getElementById(object id)
        {
            TrainingCenterEntities oEntities = ConnectionEntities.getTrainingCenter(mAcount);
            var oData = oEntities.SP_GETSTUDENT_BYID_STUDENTS(int.Parse(""+id)).FirstOrDefault();
            StudentLists oStudentLists = null;
            if (oData != null || oData.Id > 0)
            {
                oStudentLists = new StudentLists
                {
                    Id = oData.Id,
                    FullName = oData.FullName,
                    
                    Sex = oData.Sex,

                    Mobile = oData.Mobile,
                    DateBirthday = oData.DateBirthday,
                    Email = oData.Email,
                    Address = oData.Address,
                    DateCreate = (DateTime)oData.DateCreate,
                    UserId = oData.UserId,
                    UserName = oData.UserName,
                    CourseId = oData.CourseId,
                    CourseName = oData.CourseName,
                    StatusId = oData.StatusId,
                    StatusName = oData.StatusName,
                    Description = oData.Description
                };
                if (oStudentLists.Sex == 0)
                    oStudentLists.SexString = "Nam";
                else
                    oStudentLists.SexString = "Nữ";
            }            
            return oStudentLists;
        }
        public override bool InsertAndUpdate(StudentLists oT)
        {
            TrainingCenterEntities oEntities = ConnectionEntities.getTrainingCenter(mAcount);
            byte bOption = 0;
            if (oT.Id == 0)
                bOption = 1;  //Insert
            else
                bOption = 0;  //Update
            Commons oCommons = new Commons();
            oEntities.SP_Insert_Update_Student(bOption, oT.Id,oT.FirstName, oT.LastName, oT.FullName, oT.Sex,
                                string.IsNullOrEmpty(oT.Mobile) ? "" 
                                    : oCommons.EncryptInfo(oT.Mobile), oT.DateBirthday,
                                string.IsNullOrEmpty(oT.Email) ? ""
                                    : oCommons.EncryptInfo(oT.Email), oT.Address,
                                oT.DateCreate, oT.UserId, oT.CourseId, oT.StatusId,
                                oT.Description);            
            return true;
        }

        public bool InsertAndUpdateNoEncrypt(StudentLists oT)
        {
            TrainingCenterEntities oEntities = ConnectionEntities.getTrainingCenter(mAcount);
            byte bOption = 0;
            if (oT.Id == 0)
                bOption = 1;  //Insert
            else
                bOption = 0;  //Update
            Commons oCommons = new Commons();
            oEntities.SP_Insert_Update_Student(bOption, oT.Id, oT.FirstName, oT.LastName, oT.FullName, oT.Sex,
                                string.IsNullOrEmpty(oT.Mobile) ? ""
                                    : oT.Mobile, oT.DateBirthday,
                                string.IsNullOrEmpty(oT.Email) ? ""
                                    : oT.Email, oT.Address,
                                oT.DateCreate, oT.UserId, oT.CourseId, oT.StatusId,
                                oT.Description);
            return true;
        }
    }
}
