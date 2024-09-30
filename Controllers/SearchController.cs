using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Web.Common.Controllers;
using Umbraco.Cms.Web.Common.PublishedModels;
using UmbracoProject.Models.ViewModels;

namespace UmbracoProject.Controllers;

public class SearchController : RenderController
{
  private readonly IUmbracoContextAccessor _umbracoContextAccessor;
  private readonly ILogger _logger;

    public SearchController(ILogger<RenderController> logger, ICompositeViewEngine compositeViewEngine, IUmbracoContextAccessor umbracoContextAccessor) : base(logger, compositeViewEngine, umbracoContextAccessor)
    {
        _umbracoContextAccessor = umbracoContextAccessor;
        _logger = logger;
        
    }

    public override IActionResult Index()
    {
        var searchPage = CurrentPage as Search;

        if(searchPage != null)
        {
            var model = new SearchPageViewModel(searchPage, _umbracoContextAccessor);

            _logger.LogInformation($"Rendering view 'search.cshtml' with model type: {model.GetType().Name}");

            return View("search", model);


        }
       
        return NotFound();
    }
}
