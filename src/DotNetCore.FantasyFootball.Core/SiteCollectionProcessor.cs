using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCore.FantasyFootball.Core.Models;

namespace DotNetCore.FantasyFootball.Core
{
    public class SiteCollectionProcessor : ISiteCollectionProcessor
    {

        private readonly IHtmlLoader htmlLoader;
        
        public SiteCollectionProcessor(IHtmlLoader htmlLoader)
        {
            this.htmlLoader = htmlLoader;
        }

        public List<PlayerAggregate> Process(SiteCollection siteCollection)
        {
            var players = new List<Player>();
            foreach (var fantasySite in siteCollection.FantasySites)
            {
                fantasySite.PageHtml = this.htmlLoader.GetHtml(fantasySite.PageUrl);
                var parser = new PageParser.Parser(fantasySite);
                parser.Parse();
                players.AddRange(fantasySite.Players);
            }

            return (from p in players
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