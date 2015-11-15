using System.Web.Mvc;
using EPiServer.Web.Mvc;
using EPiTechnoSessie.Models.Pages;

namespace EPiTechnoSessie.Controllers
{
    public class StandardPageController : PageController<StandardPage>
    {
        public ActionResult Index(StandardPage currentPage)
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */

            return View(currentPage);
        }
    }
}