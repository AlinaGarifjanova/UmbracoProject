using Umbraco.Cms.Core;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Web.Common.PublishedModels;

namespace UmbracoProject.Models.ViewModels
{
    public class SearchPageViewModel : BasePageModel<Search>
    {
        public SearchPageViewModel(Search content, IUmbracoContextAccessor umbracoContextAccessor) : base(content, umbracoContextAccessor)
        {
        }

        public List<MovieDetails> Movies { get; set; } = [];
    }
}
