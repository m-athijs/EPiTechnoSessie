using EPiServer;
using EPiServer.Core;
using EPiServer.ServiceLocation;
using EPiServer.Web.Routing;
using EPiTechnoSessie.Models.Pages;
using System.Collections.Generic;

namespace EPiTechnoSessie.Business.Content
{
    public class ContentService : IContentService
    {
        private IContentRepository _contentRepository;
        private PageRouteHelper _pageRouteHelper;
        
        public ContentService(IContentRepository contentRepository, PageRouteHelper pageRouteHelper)
        {
            _contentRepository = contentRepository;
            _pageRouteHelper = pageRouteHelper;
        }

        public T Get<T>(ContentReference contentReference) where T : IContentData
        {
            return _contentRepository.Get<T>(contentReference);
        }

        public IEnumerable<BasePage> GetChildren<T>(ContentReference contentReference) where T : BasePage
        {
            return _contentRepository.GetChildren<BasePage>(contentReference);
        }

        public PageData GetCurrentPage()
        {
            return _pageRouteHelper.Page;
        }
    }
}