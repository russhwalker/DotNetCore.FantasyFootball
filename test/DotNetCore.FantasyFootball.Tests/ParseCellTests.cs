using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using DotNetCore.FantasyFootball.Core.PageParser;

namespace DotNetCore.FantasyFootball.Tests
{
    public class ParseCellTests
    {

        [Fact]
        public void ParseCell_TextOnly()
        {
            var cellParseParams = new CellParseParams
            {
                CellXPath = "td[2]"
            };
            var tableRowNode = HtmlAgilityPack.HtmlNode.CreateNode("<tr><td></td><td>foo</td></tr>");
            var value = tableRowNode.ParseCell(cellParseParams);
            Assert.Equal("foo", value);
        }

        [Fact]
        public void ParseCell_Empty()
        {
            var cellParseParams = new CellParseParams
            {
                CellXPath = "td[1]"
            };
            var tableRowNode = HtmlAgilityPack.HtmlNode.CreateNode("<tr><td></td></tr>");
            var value = tableRowNode.ParseCell(cellParseParams); 
            Assert.Equal(string.Empty, value);
        }

        [Fact]
        public void ParseCell_ChildElement()
        {
            var cellParseParams = new CellParseParams
            {
                CellXPath = "td[1]/a"
            };
            var tableRowNode = HtmlAgilityPack.HtmlNode.CreateNode("<tr><td><a href='#' class='test bold'>foo</a></td></tr>");
            var value = tableRowNode.ParseCell(cellParseParams);
            Assert.Equal("foo", value);
        }

        [Fact]
        public void ParseCell_SubChildElement()
        {
            var cellParseParams = new CellParseParams
            {
                CellXPath = "td[1]/div/a"
            };
            var tableRowNode = HtmlAgilityPack.HtmlNode.CreateNode("<tr><td class='playerNameAndInfo'><div class='c c-pit'><b></b><a onclick = 'return false' href='/players/card?leagueId=0&playerId=2508061' class='playerCard playerName playerNameFull playerNameId-2508061 what-playerCard'>foo</a> <em>WR - PIT</em>    </div></td></tr>");
            var value = tableRowNode.ParseCell(cellParseParams);
            Assert.Equal("foo", value);
        }

    }
}
