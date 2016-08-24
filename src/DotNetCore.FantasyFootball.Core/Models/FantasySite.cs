using DotNetCore.FantasyFootball.Core.PageParser;
using System;
using System.Collections.Generic;

namespace DotNetCore.FantasyFootball.Core.Models
{
    public class FantasySite
    {
        public string SiteName { get; set; }
        public string SiteUrl { get; set; }
        public PageParseParams PageParseParams { get; set; }
        public List<Player> Players { get; set; }
    }
}
