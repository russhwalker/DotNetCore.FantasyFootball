
namespace DotNetCore.FantasyFootball.Core.PageParser
{
    public class PageParseParams
    {
        public string Html { get; set; }

        public string TableXPath { get; set; }

        public CellParseParams NameCellParams { get; set; }
        public CellParseParams RankCellParams { get; set; }
        public CellParseParams PositionCellParams { get; set; }

    }
}
