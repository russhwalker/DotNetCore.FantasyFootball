using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using DotNetCore.FantasyFootball.Core.SiteParser;

namespace DotNetCore.FantasyFootball.Tests
{
    public class PageParserTests
    {
        
        [Fact]
        public void PageParser_CheckTableRowCount()
        {
            const string TestHtml = @"
            <html>
            <body>
            <table>
            <tbody>
            <tr>
                <td></td>
            </tr>
            <tr>
                <td></td>
            </tr>
            <tr>
                <td></td>
            </tr>
            </tbody>
            </table>
            </body>
            </html>";
            var fantasySite = new Core.Models.FantasySite
            {
                SiteHtml = TestHtml,
                SiteParseParams = new SiteParseParams
                {
                    TableXPath = "//table[1]"
                }
            };

            var parser = new Parser(fantasySite);
            Assert.Equal(3, parser.TableRows.Count);
        }

    }
}
