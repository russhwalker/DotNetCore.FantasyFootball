using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using DotNetCore.FantasyFootball.Core.PageParser;

namespace DotNetCore.FantasyFootball.Tests
{
    public class ParseRowTests
    {

        [Fact]
        public void ParseRow_TextOnly()
        {
            var pageParseParams = new PageParseParams
            {
                NameCellParams = new CellParseParams
                {
                    CellXPath = "td[1]"
                },
                RankCellParams = new CellParseParams
                {
                    CellXPath = "td[2]"
                },
                PositionCellParams = new CellParseParams
                {
                    CellXPath = "td[3]"
                }
            };
            var tableRowNode = HtmlAgilityPack.HtmlNode.CreateNode("<tr><td>a</td><td>1</td><td>c</td></tr>");
            var player = tableRowNode.ParseRow(pageParseParams);
            Assert.NotNull(player);
        }

        [Fact]
        public void ParseRow_()
        {
            var pageParseParams = new PageParseParams
            {
                NameCellParams = new CellParseParams
                {
                    CellXPath = "td[2]"
                },
                RankCellParams = new CellParseParams
                {
                    CellXPath = "td[1]"
                },
                PositionCellParams = new CellParseParams
                {
                    CellXPath = "td[3]"
                }
            };
            var tableRowNode = HtmlAgilityPack.HtmlNode.CreateNode("<tr><td>3</td><td>John Doe</td><td>WR</td></tr>");
            var player = tableRowNode.ParseRow(pageParseParams);
            Assert.Equal("John Doe", player.Name);
            Assert.Equal(3, player.Rank);
            Assert.Equal("WR", player.Position);
        }

    }
}
