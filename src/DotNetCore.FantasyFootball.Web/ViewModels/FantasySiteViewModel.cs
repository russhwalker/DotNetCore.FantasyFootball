using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore.FantasyFootball.Web.ViewModels
{
    public class FantasySiteViewModel
    {

        public string SiteUrl { get; set; }
        public string TableXPath { get; set; }

        public string NameCellXPath { get; set; }
        public string NameSplitOnValue { get; set; }
        public int NameIndexPosition { get; set; }

        public string RankCellXPath { get; set; }
        public string RankSplitOnValue { get; set; }
        public int RankIndexPosition { get; set; }

        public string PositionCellXPath { get; set; }
        public string PositionSplitOnValue { get; set; }
        public int IndexPosition { get; set; }

    }
}
