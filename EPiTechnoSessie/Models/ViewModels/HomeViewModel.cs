using EPiTechnoSessie.Models.Pages;
using System.Collections.Generic;

namespace EPiTechnoSessie.Models.ViewModels
{
    public class HomeViewModel
    {
        public HomePage CurrentPage { get; set; }
        public IEnumerable<StandardPage> ChildPages { get; set; }
    }
}