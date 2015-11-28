using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace EPiTechnoSessie.Models.Pages
{
    [ContentType(DisplayName = "StandardPage", GUID = "16026e24-f6f4-4bbb-8fae-c30153440821", Description = "Just a standard content page")]
    public class StandardPage : BasePage
    {
        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString MainBody { get; set; }
    }
}