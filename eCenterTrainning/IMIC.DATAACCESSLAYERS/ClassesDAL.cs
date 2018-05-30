﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.VALUEOBJECTS;

namespace IMIC.DATAACCESSLAYERS
{
    public class ClassesDAL : BaseDAL<Classes>
    {
        public ClassesDAL(Account oAccount) : base(oAccount)
        {
        }
        public override List<Classes> getElements()
        {
            TrainingCenterEntities oEntities = ConnectionEntities.getTrainingCenter(mAcount);
            var oData = oEntities.SP_IMIC_Get_Class_By_Year().ToList();
            List<Classes> lisClasses = new List<Classes>();
            foreach (var o in oData)
            {
                Classes oClasses = new Classes
                {
                    Id = o.Id,
                    ClassName = o.ClassName,
                    FromDate = o.FromDate,
                    ToDate = o.ToDate,
                    PlaceTraining = o.PlaceTraining,
                    NumberStudents = o.NumberStudents,
                    Description = o.Description,
                    Status = o.Status
                };
                lisClasses.Add(oClasses);
            }
            return lisClasses;
        }
        public override bool InsertAndUpdate(Classes oT)
        {
            TrainingCenterEntities oEntities = ConnectionEntities.getTrainingCenter(mAcount);
            oEntities.SP_Insert_And_Update_Class(oT.Id, oT.ClassName, oT.FromDate, oT.ToDate, oT.PlaceTraining,oT.NumberStudents, oT.Description, oT.Status);
            return true;
        }
        public override bool UpdateElement(Classes oT)
        {
            TrainingCenterEntities oEntities = ConnectionEntities.getTrainingCenter(mAcount);
            oEntities.SP_IMIC_Add_Expert_Into_Classes(oT.Id, oT.ExpertId);
            return true;
        }
    }
}