using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DotNetCore.FantasyFootball.Core;
using DotNetCore.FantasyFootball.Web.ViewModels;

namespace DotNetCore.FantasyFootball.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISiteCollectionProcessor siteCollectionProcessor;

        public HomeController(ISiteCollectionProcessor siteCollectionProcessor)
        {
            this.siteCollectionProcessor = siteCollectionProcessor;
        }

        public IActionResult Index()
        {
            var viewModel = new HomeViewModel();
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Index(HomeViewModel viewModel)
        {

            return null;
        }

    }
}
