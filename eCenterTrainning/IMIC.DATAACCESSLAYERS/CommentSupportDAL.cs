using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.VALUEOBJECTS;

namespace IMIC.DATAACCESSLAYERS
{
    public class CommentSupportDAL : BaseDAL<CommentSupport>
    {
        public CommentSupportDAL(Account oAccount) : base(oAccount)
        { }
        public override bool InsertAndUpdate(CommentSupport oT)
        {
            TrainingCenterEntities oEntities = ConnectionEntities.getTrainingCenter(mAcount);
            oEntities.SP_INSERTUPDATE_COMMENTSUPPORT(oT.Flag,oT.Id,oT.CommentName,oT.Desription,oT.UserId,oT.UserName,oT.StudentId,oT.DateCreate);
            return true;
        }
        public override List<CommentSupport> CheckElementById(object Id)
        {
            TrainingCenterEntities oEntities = ConnectionEntities.getTrainingCenter(mAcount);
            var oData = oEntities.SP_GETELEMENTSBYIDSTUDENT_COMMONTSUPPORT((int)Id).ToList();
            List<CommentSupport> lisComment = new List<CommentSupport>();
            foreach (var o in oData)
            {
                CommentSupport oComment = new CommentSupport
                {
                    Id = o.Id,
                    CommentName = o.CommentName,
                    Desription = o.Desription,
                    UserId =o.UserId,
                    
                   
                    UserName = o.UserName,
                 
                    DateLastUpdate = o.DateLastUpdate
                };
                lisComment.Add(oComment);
            }
            return lisComment.Count <= 0 ? null : lisComment;
        }
        public override bool DeleteElement(CommentSupport oT)
        {
            TrainingCenterEntities oEntities = ConnectionEntities.getTrainingCenter(mAcount);
            oEntities.SP_DELETE_COMMENT_SUPPORT(oT.Id);
            return true;
        }
    }
}
