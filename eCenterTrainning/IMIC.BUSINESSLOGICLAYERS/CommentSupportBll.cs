using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IMIC.VALUEOBJECTS;
using IMIC.DATAACCESSLAYERS;

namespace IMIC.BUSINESSLOGICLAYERS
{
    public class CommentSupportBll : BaseBll<CommentSupport>
    {
        CommentSupportDAL mCommentSupportDAL;
        public CommentSupportBll(Account oAccount) : base(oAccount)
        {
            mCommentSupportDAL = new CommentSupportDAL(oAccount);
        }
        public override List<CommentSupport> CheckElementById(object Id)
        {
            return mCommentSupportDAL.CheckElementById(Id);
        }
        public override bool InsertAndUpdateElement(CommentSupport oT)
        {
            return mCommentSupportDAL.InsertAndUpdate(oT);
        }
        public override bool DeleteElement(CommentSupport oT)
        {
            return mCommentSupportDAL.DeleteElement(oT);
        }
    }
}
