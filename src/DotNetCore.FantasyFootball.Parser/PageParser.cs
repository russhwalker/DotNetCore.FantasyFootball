using System;
using System.Collections.Generic;
using DotNetCore.FantasyFootball.Core;
using DotNetCore.FantasyFootball.Core.Models;
using DotNetCore.FantasyFootball.Core.PageParser;

namespace DotNetCore.FantasyFootball.Parser
{
    public class PageParser : IPageParser
    {

        public List<Player> ParsedPlayers { get; private set; }
        private readonly PageParseParams pageParseParams;

        public PageParser(PageParseParams pageParseParams)
        {
            this.pageParseParams = pageParseParams;
            this.ParsedPlayers = new List<Player>();
        }

        public void Parse()
        {
            var htmlDoc = new HtmlAgilityPack.HtmlDocument();
            htmlDoc.LoadHtml(pageParseParams.Html);

            var table = htmlDoc.DocumentNode.SelectSingleNode(pageParseParams.TableXPath);
            var tableRows = table.SelectNodes("//tr");

            foreach (var record in tableRows)
            {
                try
                {
                    ParseRow(record);
                }
                catch (Exception ex)
                {
                    //Todo..?
                }
            }
        }

        private void ParseRow(HtmlAgilityPack.HtmlNode rowNode)
        {
            var player = new Player
            {
                Name = ParseCell(rowNode, this.pageParseParams.NameCellParams),
                Rank = ParseCell(rowNode, this.pageParseParams.RankCellParams),
                Position = ParseCell(rowNode, this.pageParseParams.PositionCellParams)
            };
            this.ParsedPlayers.Add(player);
        }

        private string ParseCell(HtmlAgilityPack.HtmlNode rowNode, CellParseParams cellParseParams)
        {
            var cellNode = rowNode.SelectSingleNode(cellParseParams.CellXPath);
            if (string.IsNullOrWhiteSpace(cellParseParams.SplitOnValue))
            {
                return cellNode.InnerText;
            }
            var values = cellNode.InnerText.Split(new[] { cellParseParams.SplitOnValue }, StringSplitOptions.RemoveEmptyEntries);
            return values[cellParseParams.IndexPosition].Trim();
        }

    }
}
