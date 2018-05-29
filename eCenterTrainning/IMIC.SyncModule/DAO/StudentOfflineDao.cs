using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IMIC.OfflineDB;
using IMIC.SyncModule.EntityObject;


namespace IMIC.SyncModule.DAO
{
    public class StudentOfflineDao
    {
        public void Student_InsertIntoOfflineServerSync(StudentObject objStuTemp)
        {
            eTrainingOfflineEntities db = new Common().getTrainingOfflineCenterInfo();
            db.SP_Student_InsertIntoOfflineServerSync(objStuTemp.Id, objStuTemp.FirstName,
                objStuTemp.LastName, objStuTemp.FullName, objStuTemp.Sex, objStuTemp.DateBirthday,
                objStuTemp.Mobile, objStuTemp.Email, objStuTemp.Address, objStuTemp.DateCreate,
                objStuTemp.DateLastUpdate, objStuTemp.Description, objStuTemp.CourseId,
                objStuTemp.StatusId, objStuTemp.UserId);
        }
    }
}
