using System;
using System.Collections.Generic;
using DotNetCore.FantasyFootball.Core.Models;

namespace DotNetCore.FantasyFootball.Core.SiteParser
{
    public class Parser : ISiteParser
    {

        private readonly SiteParseParams siteParseParams;
        public HtmlAgilityPack.HtmlNodeCollection TableRows { get; private set; }
        public bool ParseSuccessful { get; private set; }
        public List<Player> ParsedPlayers { get; private set; }

        public Parser(SiteParseParams siteParseParams)
        {
            this.siteParseParams = siteParseParams;
            this.ParsedPlayers = new List<Player>();
            Load();
        }

        private void Load()
        {
            var htmlDoc = new HtmlAgilityPack.HtmlDocument();
            htmlDoc.LoadHtml(siteParseParams.Html);
            var table = htmlDoc.DocumentNode.SelectSingleNode(siteParseParams.TableXPath);
            this.TableRows = table.SelectNodes("//tr");
        }

        public void Parse()
        {
            foreach (var record in this.TableRows)
            {
                try
                {
                    var player = record.ParseRow(this.siteParseParams);
                    this.ParsedPlayers.Add(player);
                }
                catch (Exception ex)
                {
                    //Todo: handle header rows and other "bad" rows
                }
            }
            this.ParseSuccessful = true;
        }

    }
}
