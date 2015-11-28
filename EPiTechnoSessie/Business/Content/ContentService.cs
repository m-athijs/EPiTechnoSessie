using EPiServer;
using EPiServer.Core;
using EPiServer.ServiceLocation;
using EPiTechnoSessie.Models.Pages;
using System.Collections.Generic;

namespace EPiTechnoSessie.Business.Content
{
    public class ContentService : IContentService
    {
        internal Injected<IContentRepository> _contentRepository;
        
        public IEnumerable<BasePage> GetChildren<T>(ContentReference contentReference) where T : BasePage
        {
            return _contentRepository.Service.GetChildren<BasePage>(contentReference);
        }
    }
}