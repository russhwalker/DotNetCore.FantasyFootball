using DotNetCore.FantasyFootball.Core.PageParser;
using System;
using System.Collections.Generic;

namespace DotNetCore.FantasyFootball.Core.Models
{
    public class SiteCollection
    {
        public List<FantasySite> FantasySites { get; set; }
        public List<PlayerAggregate> PlayerAggregates { get; set; }
    }
}
