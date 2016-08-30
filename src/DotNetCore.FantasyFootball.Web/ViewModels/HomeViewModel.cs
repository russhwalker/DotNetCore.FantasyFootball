﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore.FantasyFootball.Web.ViewModels
{
    public class HomeViewModel
    {
        public HomeViewModel()
        {
            this.SiteUrl1 = "http://fantasy.nfl.com/research/rankings?leagueId=0&statType=draftStats";
            this.TableXPath1 = "//table[1]";
            this.NameCellXPath1 = "//td[2]";
            this.RankCellXPath1 = "//td[1]";
            this.PositionCellXPath1 = "//td[2]";

            this.SiteUrl2 = "http://www.espn.com/fantasy/football/story/_/id/16287927/2016-fantasy-football-rankings-top-300";
            this.TableXPath2 = "//table[1]";
            this.NameCellXPath2 = "//td[1]";
            this.RankCellXPath2 = "//td[1]";
            this.PositionCellXPath2 = "//td[2]";
        }


        public string SiteUrl1 { get; set; }
        public string TableXPath1 { get; set; }

        public string NameCellXPath1 { get; set; }
        public string NameSplitOnValue1 { get; set; }
        public int NameIndexPosition1 { get; set; }

        public string RankCellXPath1 { get; set; }
        public string RankSplitOnValue1 { get; set; }
        public int RankIndexPosition1 { get; set; }

        public string PositionCellXPath1 { get; set; }
        public string PositionSplitOnValue1 { get; set; }
        public int PositionIndexPosition1 { get; set; }

        public string SiteUrl2 { get; set; }
        public string TableXPath2 { get; set; }

        public string NameCellXPath2 { get; set; }
        public string NameSplitOnValue2 { get; set; }
        public int NameIndexPosition2 { get; set; }

        public string RankCellXPath2 { get; set; }
        public string RankSplitOnValue2 { get; set; }
        public int RankIndexPosition2 { get; set; }

        public string PositionCellXPath2 { get; set; }
        public string PositionSplitOnValue2 { get; set; }
        public int PositionIndexPosition2 { get; set; }

    }
}
