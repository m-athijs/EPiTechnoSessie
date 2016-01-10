using EPiTechnoSessie.Business.Comments;
using EPiTechnoSessie.Models.Blocks;
using System.Collections.Generic;

namespace EPiTechnoSessie.Models.ViewModels
{
    public class CommentViewModel
    {
        public CommentViewModel(CommentsBlock block)
        {
            CurrentBlock = block;
        }

        public int CurrentBlockId { get; set; }
        public int CurrentPageId { get; set; }

        public CommentsBlock CurrentBlock { get; set; }
        public IEnumerable<CommentItem> CommentItems { get; set; }
    }
}