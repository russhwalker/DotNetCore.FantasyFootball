using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore.FantasyFootball.Web.ViewModels
{
    public class HomeViewModel
    {
        public HomeViewModel()
        {
            //Setup some defaults
            this.FantasySiteViewModel = new FantasySiteViewModel
            {

            };
        }

        public FantasySiteViewModel FantasySiteViewModel { get; set; }

    }
}
