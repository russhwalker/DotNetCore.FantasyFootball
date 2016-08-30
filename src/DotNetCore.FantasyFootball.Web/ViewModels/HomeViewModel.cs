using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCore.FantasyFootball.Core.Models;

namespace DotNetCore.FantasyFootball.Web.ViewModels
{
    public class HomeViewModel
    {

        public HomeViewModel()
        {
            this.PlayerAggregates = new List<PlayerAggregate>();
        }

        public List<PlayerAggregate> PlayerAggregates { get; set; }

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
