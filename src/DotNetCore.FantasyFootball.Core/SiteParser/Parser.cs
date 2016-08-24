using System;
using System.Collections.Generic;
using DotNetCore.FantasyFootball.Core.Models;

namespace DotNetCore.FantasyFootball.Core.SiteParser
{
    public class Parser : ISiteParser
    {

        private readonly FantasySite fantasySite;
        public HtmlAgilityPack.HtmlNodeCollection TableRows { get; private set; }
        public bool ParseSuccessful { get; private set; }

        public Parser(FantasySite fantasySite)
        {
            this.fantasySite = fantasySite;
            this.fantasySite.Players = new List<Player>();
            Load();
        }

        private void Load()
        {
            var htmlDoc = new HtmlAgilityPack.HtmlDocument();
            htmlDoc.LoadHtml(this.fantasySite.SiteHtml);
            var table = htmlDoc.DocumentNode.SelectSingleNode(this.fantasySite.SiteParseParams.TableXPath);
            this.TableRows = table.SelectNodes("//tr");
        }

        public void Parse()
        {
            foreach (var record in this.TableRows)
            {
                try
                {
                    var player = record.ParseRow(this.fantasySite.SiteParseParams);
                    this.fantasySite.Players.Add(player);
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
