using DotNetCore.FantasyFootball.Core;
using DotNetCore.FantasyFootball.Core.Models;
using DotNetCore.FantasyFootball.Core.PageParser;
using System;
using System.Collections.Generic;

namespace DotNetCore.FantasyFootball.ConsoleRunner
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var siteCollection = new SiteCollection
            {
                FantasySites = new List<FantasySite>
                {
                    new FantasySite
                    {
                        PageUrl = "https://www.fantasypros.com/nfl/rankings/consensus-cheatsheets.php",
                        PageParseParams = new PageParseParams
                        {
                            TableXPath = "//table[1]",
                            NameCellParams = new CellParseParams
                            {
                                CellXPath = "td[2]/a"
                            },
                            RankCellParams = new CellParseParams
                            {
                                CellXPath = "td[1]"
                            },
                            PositionCellParams = new CellParseParams
                            {
                                CellXPath = "td[2]"
                            }
                        }
                    },
                    new FantasySite
                    {
                        PageUrl = "http://fantasy.nfl.com/research/rankings?leagueId=0&statType=draftStats",
                        PageParseParams = new PageParseParams
                        {
                            TableXPath = "//table[1]",
                            NameCellParams = new CellParseParams
                            {
                                CellXPath = "td[2]/div/a"
                            },
                            RankCellParams = new CellParseParams
                            {
                                CellXPath = "td[1]"
                            },
                            PositionCellParams = new CellParseParams
                            {
                                CellXPath = "td[2]/div/em",
                                IndexPosition = 0,
                                SplitOnValue = "-"
                            }
                        }
                    },
                    new FantasySite
                    {
                        PageUrl = "http://www.fantasyfootballnerd.com/fantasy-football-draft-rankings",
                        PageParseParams = new PageParseParams
                        {
                            TableXPath = "//table[1]",
                            NameCellParams = new CellParseParams
                            {
                                CellXPath = "td[4]/a"
                            },
                            RankCellParams = new CellParseParams
                            {
                                CellXPath = "td[1]"
                            },
                            PositionCellParams = new CellParseParams
                            {
                                CellXPath = "td[3]"
                            }
                        }
                    }
                }
            };
            var siteCollectionProcessor = new SiteCollectionProcessor(new CachedHtmlLoader());
            var playerAggregates = siteCollectionProcessor.Process(siteCollection);

            foreach(var player in playerAggregates)
            {
                Console.WriteLine($"{player.Rank} {player.Name} {player.Position}");
            }



            Console.ReadKey();
        }
    }
}
