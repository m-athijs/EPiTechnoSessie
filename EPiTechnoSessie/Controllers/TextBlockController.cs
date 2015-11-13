using System.Web.Mvc;
using EPiServer.Web.Mvc;
using EPiTechnoSessie.Models.Blocks;

namespace EPiTechnoSessie.Controllers
{
    public class TextBlockController : BlockController<TextBlock>
    {
        public override ActionResult Index(TextBlock currentBlock)
        {
            return PartialView(currentBlock);
        }
    }
}
