using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DotNetCore.FantasyFootball.Core;

namespace DotNetCore.FantasyFootball.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISiteCollectionProcessor siteCollectionProcessor;

        public HomeController(ISiteCollectionProcessor siteCollectionProcessor)
        {
            this.siteCollectionProcessor = siteCollectionProcessor;
        }

        public IActionResult Index(ISiteCollectionProcessor siteCollectionProcessor)
        {
            return View();
        }
        
    }
}
