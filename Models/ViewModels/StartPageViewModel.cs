using Umbraco.Cms.Core;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Web.Common.PublishedModels;

namespace UmbracoProject.Models.ViewModels;

public class StartPageViewModel : BasePageModel<Start>
{
    public StartPageViewModel(Start content, IUmbracoContextAccessor umbracoContextAccessor, IPublishedContentQuery contentQuery) : base(content, umbracoContextAccessor, contentQuery)
    {
    }
}
