using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCore.FantasyFootball.Core.Models;

namespace DotNetCore.FantasyFootball.Core
{
    public class SiteCollectionProcessor : ISiteCollectionParser
    {

        private readonly SiteCollection siteCollection;
        private readonly IHtmlLoader htmlLoader;

        public SiteCollectionProcessor(SiteCollection siteCollection, IHtmlLoader htmlLoader)
        {
            this.siteCollection = siteCollection;
            this.siteCollection.Players = new List<Player>();
            this.htmlLoader = htmlLoader;
        }

        public void Process()
        {
            var players = new List<Player>();
            foreach (var fantasySite in this.siteCollection.FantasySites)
            {
                fantasySite.PageHtml = this.htmlLoader.GetHtml(fantasySite.PageUrl);
                var parser = new PageParser.Parser(fantasySite);
                parser.Parse();
                players.AddRange(fantasySite.Players);
            }

            var groups = from p in players
                group p by p.Name
                into g
                select new
                {
                    Name = g.Key,
                    Count = g.Count(),
                    Positions = g.Select(x => x.Position).Distinct()
                };

             

        }

    }
}