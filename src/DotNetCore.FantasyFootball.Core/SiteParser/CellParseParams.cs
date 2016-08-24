using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore.FantasyFootball.Core.SiteParser
{
    public class CellParseParams
    {
        public string CellXPath { get; set; }
        public string SplitOnValue { get; set; }
        public int IndexPosition { get; set; }
    }
}
