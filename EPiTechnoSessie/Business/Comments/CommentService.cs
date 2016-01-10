using EPiServer.Data.Dynamic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EPiTechnoSessie.Business.Comments
{
    public class CommentService : ICommentService
    {
        private readonly DynamicDataStore _store;

        public CommentService()
        {
            _store = DynamicDataStoreFactory.Instance.CreateStore(typeof(CommentItem));
        }

        public IEnumerable<CommentItem> GetByPageId(int pageId)
        {
            return _store.Find<CommentItem>("PageId", pageId).OrderByDescending(c => c.CreatedAt);
        }

        public void Save(CommentItem commentItem)
        {
            _store.Save(commentItem);
        }
    }
}