using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IMIC.OfflineDB;
using IMIC.OnlineDB;
using IMIC.WEBIMIC;

using IMIC.SyncModule.EntityObject;

namespace IMIC.SyncModule.DAO
{
    public class StudentOnlineDao
    {
        cConfigParams mConfigs;
        public StudentOnlineDao(cConfigParams oConfigs)
        {
            mConfigs = oConfigs;
        }

        public List<StudentObject> getDataOnline()
        {
            List<StudentObject> listStudentSycOnline = new List<StudentObject>();
            ConnectionEntities objConEn = new ConnectionEntities();

            eTrainingOnlineEntities objConnEntitiesOn = objConEn.getTrainingCenterOn();

            //ConnectionEntities objConEn = new ConnectionEntities();
            //TrainingCenterEntities objConnEntities = objConEn.getTrainingCenter();
            //IQueryable<Student> lstStudent = objConnEntities.Students;
            //var listTempOnline = objConnEntitiesOn.Students.Where(p => p.DateCreate < DateTime.Now)
            //                    .AsEnumerable()
            //                    .Where(p => p.DateCreate > DateTime.Now.AddDays(-3));
            //var listTempOnline = objConnEntitiesOn.Students.Where(i => i.DateCreate > DateTime.Now.AddDays(-7)).ToList();
            var listTempOnline = objConnEntitiesOn.SP_Student_GetOnlineStudentFromLast3days();
            foreach (var item in listTempOnline)
            {
                StudentObject objS = new StudentObject(item.Id, item.FirstName,
                            item.LastName, item.FullName, item.Sex, item.DateBirthday,
                            item.Mobile, item.Email, item.Address, item.DateCreate,
                            item.DateLastUpdate, item.Description, item.CourseId,
                            item.StatusId, item.UserId);
                listStudentSycOnline.Add(objS);
            }
            return listStudentSycOnline;
        }

        public List<StudentObject> GetOffline()
        {
            List<StudentObject> listStudentOffline = new List<StudentObject>();
            ConnectionEntities objConEn = new ConnectionEntities();
            eTrainingOfflineEntities objConnEntitiesOff = objConEn.getTrainingCenterOff();

            
            var listTempOffline = objConnEntitiesOff.SP_Student_GetOfflineStudentFromLast3days();
            foreach (var item in listTempOffline)
            {
                StudentObject objS = new StudentObject(item.Id, item.FirstName,
                            item.LastName, item.FullName, item.Sex, item.DateBirthday,
                            item.Mobile, item.Email, item.Address, item.DateCreate,
                            item.DateLastUpdate, item.Description, item.CourseId,
                            item.StatusId, item.UserId);
                listStudentOffline.Add(objS);
            }
            return listStudentOffline;
        }

        public void SyncServer()
        {
            List<StudentObject> listStudentSycOnline = getDataOnline();

            List<StudentObject> listStudentOffline = GetOffline();

            //Trừ list online cho list offline = list temp
            List<StudentObject> listSync = getDataOnline();
            foreach (StudentObject obj in listStudentSycOnline)
            {
                foreach (StudentObject objOff in listStudentOffline)
                {
                    if (obj.Id == objOff.Id)
                    {
                        listSync.RemoveAll(x => x.Id == obj.Id);
                    }
                }
            }
           
            eTrainingOfflineEntities dbOfflineEntities = new Common().getTrainingOfflineCenterInfo();
            if (listSync.Count > 0)
            {

                foreach (StudentObject objStuTemp in listSync)
                {
                    dbOfflineEntities.SP_Student_InsertIntoOfflineServerSync(objStuTemp.Id, objStuTemp.FirstName,
                        objStuTemp.LastName, objStuTemp.FullName, objStuTemp.Sex, objStuTemp.DateBirthday,
                        objStuTemp.Mobile, objStuTemp.Email, objStuTemp.Address, objStuTemp.DateCreate,
                        objStuTemp.DateLastUpdate, objStuTemp.Description, objStuTemp.CourseId,
                        objStuTemp.StatusId, objStuTemp.UserId);
                }
                
            }
        }

        public List<StudentObject> GetListFromWebIMIC()
        {
            List<StudentObject> listStudentFromWeb = new List<StudentObject>();
            ConnectionEntities objConEn = new ConnectionEntities();

            WEBIMICDBEntities objStudenWeb = objConEn.getWebImic();
            var listTempOffline = objStudenWeb.WEB_IMIC_SP_RegisterDetail_GetForEtraining();
            foreach (var item in listTempOffline)
            {
                string[] Chuoi_Tach = item.FullName.Split(' ');
                string FirstName = Chuoi_Tach[Chuoi_Tach.Length - 1];
                string LastName = "";
                bool flag = true;
                for (int i = 0; i < Chuoi_Tach.Length - 1; i++)
                {
                    if (flag)
                    {
                        LastName += Chuoi_Tach[i];
                        flag = false;
                    }
                    else
                    {
                        LastName += " " + Chuoi_Tach[i];
                    }
                }
                string Description = "[From Web]" + item.Message;
                int id = 0;
                StudentObject objS = new StudentObject(id, FirstName,
                            LastName, item.FullName, 0, item.CreatedTime,
                            item.Phone, item.Email, item.Address, item.CreatedTime,
                            item.CreatedTime, Description, 41,
                            1, 1);
                listStudentFromWeb.Add(objS);
                objStudenWeb.WEB_IMIC_SP_RegisterDetail_UpdateIsSeen(item.RegisterDetailId);
            }
            return listStudentFromWeb;
        }
        public void InsertIntoOnlineFromWebIMIC()
        {

            List<StudentObject> ListStudent = GetListFromWebIMIC();
            eTrainingOnlineEntities db = new Common().getTrainingOnlineCenterInfo();
            foreach (StudentObject objStuTemp in ListStudent)
            {
                db.SP_Student_InsertIntoOnlineServerfromWebWithoutId(objStuTemp.FirstName,
                objStuTemp.LastName, objStuTemp.FullName, objStuTemp.Sex, objStuTemp.DateBirthday,
                objStuTemp.Mobile, objStuTemp.Email, objStuTemp.Address, objStuTemp.DateCreate,
                objStuTemp.DateLastUpdate, objStuTemp.Description, objStuTemp.CourseId,
                objStuTemp.StatusId, objStuTemp.UserId);
            }
            
        }
        public int InsertIntoOnlineFromWebIMICCount()
        {

            List<StudentObject> ListStudent = GetListFromWebIMIC();
            eTrainingOnlineEntities db = new Common(mConfigs).getTrainingOnlineCenterInfo();
            foreach (StudentObject objStuTemp in ListStudent)
            {
                db.SP_Student_InsertIntoOnlineServerfromWebWithoutId(objStuTemp.FirstName,
                objStuTemp.LastName, objStuTemp.FullName, objStuTemp.Sex, objStuTemp.DateBirthday,
                objStuTemp.Mobile, objStuTemp.Email, objStuTemp.Address, objStuTemp.DateCreate,
                objStuTemp.DateLastUpdate, objStuTemp.Description, objStuTemp.CourseId,
                objStuTemp.StatusId, objStuTemp.UserId);
            }
            return ListStudent.Count();

        }
    }
}
