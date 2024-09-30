﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Umbraco.Cms.Core;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Web.Common.Controllers;
using Umbraco.Cms.Web.Common.PublishedModels;
using UmbracoProject.Models.ViewModels;

namespace UmbracoProject.Controllers;

public class StartController : RenderController
{
    private readonly IUmbracoContextAccessor _umbracoContextAccessor;

	public StartController(ILogger<RenderController> logger, ICompositeViewEngine compositeViewEngine, IUmbracoContextAccessor umbracoContextAccessor) : base(logger, compositeViewEngine, umbracoContextAccessor)
    {
        _umbracoContextAccessor = umbracoContextAccessor;
     
    }

    public override IActionResult Index()
    {
        var startPage = CurrentPage as Start;
        if (startPage != null)
        {
            var model = new StartPageViewModel(startPage, _umbracoContextAccessor);
          
            return View(nameof(Start).ToLower(), model);
        }
       
        return null!;
    }
}
