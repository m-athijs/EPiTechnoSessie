using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Data;
using EPiServer.Data.Dynamic;

namespace EPiTechnoSessie.Business.Comments
{
    public class CommentItem : IDynamicData
    {
        public CommentItem()
        {
            Id = Identity.NewIdentity(Guid.NewGuid());
        }

        public string Name { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedAt { get; set; }
        public Identity Id { get; set; }
        public int PageId { get; set; }
    }
}