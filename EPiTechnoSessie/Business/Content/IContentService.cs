using EPiServer.Core;
using EPiTechnoSessie.Models.Pages;
using System.Collections.Generic;

namespace EPiTechnoSessie.Business.Content
{
    public interface IContentService
    {
        IEnumerable<BasePage> GetChildren<T>(ContentReference contentReference) where T : BasePage;
    }
}
