using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCore.FantasyFootball.Core.Models;

namespace DotNetCore.FantasyFootball.Core
{
    public class SiteCollectionProcessor : ISiteCollectionProcessor
    {

        public SiteCollection SiteCollection { get; private set; }
        private readonly IHtmlLoader htmlLoader;

        public SiteCollectionProcessor(SiteCollection siteCollection, IHtmlLoader htmlLoader)
        {
            this.SiteCollection = siteCollection;
            this.htmlLoader = htmlLoader;
        }

        public void Process()
        {
            var players = new List<Player>();
            foreach (var fantasySite in this.SiteCollection.FantasySites)
            {
                fantasySite.PageHtml = this.htmlLoader.GetHtml(fantasySite.PageUrl);
                var parser = new PageParser.Parser(fantasySite);
                parser.Parse();
                players.AddRange(fantasySite.Players);
            }

            this.SiteCollection.PlayerAggregates =
                (from p in players
                 group p by p.Name into g
                 select new PlayerAggregate
                 {
                     Name = g.Key,
                     Rank = g.Sum(x => x.Rank) / g.Count(),
                     Position = g.Select(x => x.Position).Distinct().FirstOrDefault()
                 }).ToList();
        }

    }
}