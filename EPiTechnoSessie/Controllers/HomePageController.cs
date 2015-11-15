using System.Web.Mvc;
using EPiServer.Web.Mvc;
using EPiTechnoSessie.Models.Pages;
using EPiTechnoSessie.Models.ViewModels;
using EPiServer;

namespace EPiTechnoSessie.Controllers
{
    public class HomePageController : PageController<HomePage>
    {
        public ActionResult Index(HomePage currentPage)
        {
            var repository = EPiServer.ServiceLocation.ServiceLocator.Current.GetInstance<IContentRepository>();
            var children = repository.GetChildren<StandardPage>(currentPage.ContentLink);
            var model = new HomeViewModel { CurrentPage = currentPage, ChildPages = children };

            return View(model);
        }
    }
}