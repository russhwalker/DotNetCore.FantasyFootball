
using HtmlAgilityPack;
using DotNetCore.FantasyFootball.Core.Models;
using System;

namespace DotNetCore.FantasyFootball.Core.SiteParser
{

    public static class ParsingExtensions
    {

        public static Player ParseRow(this HtmlNode rowNode, SiteParseParams siteParseParams)
        {
            return new Player
            {
                Name = rowNode.ParseCell(siteParseParams.NameCellParams),
                Rank = Convert.ToInt32(rowNode.ParseCell(siteParseParams.RankCellParams)),
                Position = rowNode.ParseCell(siteParseParams.PositionCellParams)
            };
        }

        public static string ParseCell(this HtmlNode rowNode, CellParseParams cellParseParams)
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