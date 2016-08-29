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
            this.FantasySiteViewModel1 = new FantasySiteViewModel
            {

            };
            this.FantasySiteViewModel2 = new FantasySiteViewModel
            {

            };
            this.FantasySiteViewModel3 = new FantasySiteViewModel
            {

            };
        }

        public FantasySiteViewModel FantasySiteViewModel1 { get; set; }
        public FantasySiteViewModel FantasySiteViewModel2 { get; set; }
        public FantasySiteViewModel FantasySiteViewModel3 { get; set; }

    }
}
