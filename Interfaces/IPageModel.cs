using Umbraco.Cms.Core.Models.PublishedContent;

namespace UmbracoProject.Interfaces
{
	public interface IPageModel : IPublishedContent
	{
		IPublishedContent Content { get; }
	}
}
