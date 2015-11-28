using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace EPiTechnoSessie.Models.Pages
{
    [ContentType(DisplayName = "HomePage", GUID = "0860b0e9-d9a4-46f8-a714-20eef476c195", Description = "The home page of the website")]
    public class HomePage : BasePage
    {
        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString MainBody { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Homepage Blocks",
            Description = "Leef je uit met content blocks",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        public virtual ContentArea HomePageBlocks { get; set; }
    }
}