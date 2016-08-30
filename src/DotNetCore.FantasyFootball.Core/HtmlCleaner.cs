using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore.FantasyFootball.Core
{
    public static class HtmlCleaner
    {

        public static string CleanHtml(this string html)
        {
            //Hacky html cleaner for html agility pack
            return (html ?? string.Empty).
                Replace("< a", "<a").
                Replace("< div", "<div").
                Replace("< em", "<em").
                Replace("< strong", "<strong").
                Replace("< table", "<table").
                Replace("< tbody", "<tbody").
                Replace("< tr", "<tr").
                Replace("< td", "<td");
        }

    }
}
