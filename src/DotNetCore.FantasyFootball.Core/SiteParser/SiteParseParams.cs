
namespace DotNetCore.FantasyFootball.Core.SiteParser
{
    public class SiteParseParams
    {
        public string Html { get; set; }
        public string TableXPath { get; set; }
        public CellParseParams NameCellParams { get; set; }
        public CellParseParams RankCellParams { get; set; }
        public CellParseParams PositionCellParams { get; set; }
    }
}
