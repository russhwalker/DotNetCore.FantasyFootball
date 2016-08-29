using System.Collections.Generic;
using DotNetCore.FantasyFootball.Core;
using DotNetCore.FantasyFootball.Core.Models;
using Xunit;
using DotNetCore.FantasyFootball.Core.PageParser;

namespace DotNetCore.FantasyFootball.Tests
{
    public class SiteCollectionProcessorTests
    {

        private class FakeHtmlLoader : IHtmlLoader
        {
            public string GetHtml(string pageUri)
            {
                return @"<html><body>
                    <table><tr><td>John Doe</td><td>3</td><td>WR</td></table>
                    </body></html>";
            }
        }

        [Fact]
        public void SiteCollectionProcessor()
        {
            //Got nesting?
            var siteCollection = new SiteCollection
            {
                FantasySites = new List<FantasySite>
                {
                    new FantasySite
                    {
                        PageUrl = string.Empty,
                        SiteName = "Site 1",
                        PageParseParams = new PageParseParams
                        {
                            TableXPath = "//table[1]",
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
                        }
                    },
                    new FantasySite
                    {
                        PageUrl = string.Empty,
                        SiteName = "Site 2",
                        PageParseParams = new PageParseParams
                        {
                            TableXPath = "//table[1]",
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
                        }
                    }
                }
            };

            var siteCollectionProcessor = new SiteCollectionProcessor(new FakeHtmlLoader());
            var playerAggregates = siteCollectionProcessor.Process(siteCollection);

            Assert.Equal(1, playerAggregates.Count);
        }

    }
}
