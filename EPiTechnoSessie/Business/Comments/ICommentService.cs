using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPiTechnoSessie.Business.Comments
{
    public interface ICommentService
    {
        IEnumerable<CommentItem> GetByPageId(int pageId);
        void Save(CommentItem commentItem);
    }
}
