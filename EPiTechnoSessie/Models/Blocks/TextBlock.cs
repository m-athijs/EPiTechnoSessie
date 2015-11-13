using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace EPiTechnoSessie.Models.Blocks
{
    [ContentType(DisplayName = "TextBlock", GUID = "2481adbb-eb27-44a3-8570-2b78d7dcedb2", Description = "")]
    public class TextBlock : BlockData
    {
        [CultureSpecific]
        [Display(
            Name = "Content",
            Description = "Text Block Content",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString Content { get; set; }
    }
}