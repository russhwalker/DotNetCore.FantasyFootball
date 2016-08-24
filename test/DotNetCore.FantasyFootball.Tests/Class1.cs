using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace DotNetCore.FantasyFootball.Tests
{
    public class Class1
    {
        public Class1()
        {
        }

        [Fact]
        public void TestIt()
        {
            var tableParseParams = new Core.PageParser.PageParseParams
            {
                Html = TestHtml,
                TableXPath = "//table[1]",
                NameCellParams = new Core.PageParser.CellParseParams
                {
                    CellXPath = "td[2]//a"
                },
                RankCellParams = new Core.PageParser.CellParseParams
                {
                    CellXPath = "td[1]"
                },
                PositionCellParams = new Core.PageParser.CellParseParams
                {
                    CellXPath = "td[2]//em",
                    SplitOnValue = "-",
                    IndexPosition = 0
                }
            };

            var parser = new Parser.PageParser(tableParseParams);
            parser.Parse();


            Assert.Equal("test", "nope");
        }

        const string TestHtml = @"<html>
<body>
<table>
<tbody>
<tr class='player-2508061 odd first' id='yui_3_15_0_1_1471734142357_292'>
    <td class='editorDraftRankRank first'>1</td>
    <td class='playerNameAndInfo' id='yui_3_15_0_1_1471734142357_291'>
        <div class='c c-pit' id='yui_3_15_0_1_1471734142357_295'><b id='yui_3_15_0_1_1471734142357_297'></b><a class='playerCard playerName playerNameFull playerNameId-2508061 what-playerCard' id='yui_3_15_0_1_1471734142357_294' onclick='s_objectID=' http://fantasy.nfl.com/players/card?leagueId=0&amp;playerId=2508061_1
            ';return this.s_oc?this.s_oc(e):true' href='/players/card?leagueId=0&amp;playerId=2508061'>Antonio Brown</a>  <em id='yui_3_15_0_1_1471734142357_296'>WR - PIT</em> 
        </div>
    </td>
    <td class='playerBye' id='yui_3_15_0_1_1471734142357_309'>8</td>
    <td class='editorDraftRankStock'>even</td>
    <td class='editorDraftRankAuction last'>62</td>
</tr>
</tbody>
</table>
</body>
</html>";


    }
}
