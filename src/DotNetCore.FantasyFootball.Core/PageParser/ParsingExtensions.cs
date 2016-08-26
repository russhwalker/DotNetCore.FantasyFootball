
using HtmlAgilityPack;
using DotNetCore.FantasyFootball.Core.Models;
using System;

namespace DotNetCore.FantasyFootball.Core.PageParser
{

    public static class ParsingExtensions
    {

        public static Player ParseRow(this HtmlNode rowNode, PageParseParams pageParseParams)
        {
            var player = new Player();

            if (!string.IsNullOrWhiteSpace(pageParseParams.NameCellParams?.CellXPath))
            {
                player.Name = rowNode.ParseCell(pageParseParams.NameCellParams);
            }
            if (!string.IsNullOrWhiteSpace(pageParseParams.RankCellParams?.CellXPath))
            {
                player.Rank = Convert.ToInt32(rowNode.ParseCell(pageParseParams.RankCellParams));
            }
            if (!string.IsNullOrWhiteSpace(pageParseParams.PositionCellParams?.CellXPath))
            {
                player.Position = rowNode.ParseCell(pageParseParams.PositionCellParams);
            }

            return player;
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