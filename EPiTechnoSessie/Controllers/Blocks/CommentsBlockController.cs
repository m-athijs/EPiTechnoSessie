using System;
using System.Linq;
using System.Web.Mvc;
using EPiServer.Core;
using EPiServer.Web.Mvc;
using EPiTechnoSessie.Models.Blocks;
using EPiTechnoSessie.Business.Comments;
using EPiTechnoSessie.Business.Content;
using EPiTechnoSessie.Models.ViewModels;

namespace EPiTechnoSessie.Controllers.Blocks
{
    public class CommentsBlockController : BlockController<CommentsBlock>
    {
        private readonly ICommentService _commentService;
        private readonly IContentService _contentService;
        private PageData _currentPage;

        public PageData CurrentPage
        {
            get
            {
                if (_currentPage == null)
                {
                    _currentPage = _contentService.GetCurrentPage();
                }
                return _currentPage;
            }
        }

        public CommentsBlockController(ICommentService commentService, IContentService contentService)
        {
            _commentService = commentService;
            _contentService = contentService;
        }

        public override ActionResult Index(CommentsBlock currentBlock)
        {
            var viewModel = new CommentViewModel(currentBlock);

            var currentPage = CurrentPage;
            if (currentPage != null)
            {
                viewModel.CommentItems = _commentService.GetByPageId(currentPage.ContentLink.ID);
            }
            else
            {
                viewModel.CommentItems = Enumerable.Empty<CommentItem>();
            }
            viewModel.CurrentPageId = currentPage.ContentLink.ID;
            viewModel.CurrentBlockId = ((IContent)currentBlock).ContentLink.ID;

            return View("~/Views/Blocks/CommentsBlock.cshtml", viewModel);

        }

        [HttpPost]
        public ActionResult Create(int pageid, string name, string comment, int blockid)
        {
            if (!string.IsNullOrEmpty(comment))
            {
                var block = _contentService.Get<CommentsBlock>(new ContentReference(blockid));

                var commentItem = new CommentItem
                {
                    Comment = comment,
                    CreatedAt = DateTime.Now,
                    PageId = pageid
                };
                _commentService.Save(commentItem);

            }
            return PartialView("~/Views/Shared/CommentsView.cshtml", _commentService.GetByPageId(pageid));
        }
    }
}
