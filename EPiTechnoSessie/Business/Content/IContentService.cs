using EPiServer.Core;
using EPiTechnoSessie.Models.Pages;
using System.Collections.Generic;

namespace EPiTechnoSessie.Business.Content
{
    public interface IContentService
    {
        T Get<T>(ContentReference contentReference) where T : IContentData;
        IEnumerable<BasePage> GetChildren<T>(ContentReference contentReference) where T : BasePage;
        PageData GetCurrentPage();
    }
}
