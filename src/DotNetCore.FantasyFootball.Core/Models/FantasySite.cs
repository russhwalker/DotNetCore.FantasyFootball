using DotNetCore.FantasyFootball.Core.SiteParser;
using System;
using System.Collections.Generic;

namespace DotNetCore.FantasyFootball.Core.Models
{
    public class FantasySite
    {
        public string SiteName { get; set; }
        public string SiteUrl { get; set; }
        public SiteParseParams SiteParseParams { get; set; }
        public List<Player> Players { get; set; }
    }
}
