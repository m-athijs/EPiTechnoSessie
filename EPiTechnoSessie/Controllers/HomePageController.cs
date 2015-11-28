using System.Web.Mvc;
using EPiServer.Web.Mvc;
using EPiTechnoSessie.Models.Pages;
using EPiTechnoSessie.Models.ViewModels;
using EPiServer.ServiceLocation;
using EPiTechnoSessie.Business.Content;

namespace EPiTechnoSessie.Controllers
{
    public class HomePageController : PageController<HomePage>
    {
        internal IContentService _contentService;

        public HomePageController(IContentService contentService)
        {
            _contentService = contentService;
        }

        public ActionResult Index(HomePage currentPage)
        {
            var children = _contentService.GetChildren<BasePage>(currentPage.ContentLink);
            var model = new HomeViewModel { CurrentPage = currentPage, ChildPages = children };

            return View(model);
        }
    }
}