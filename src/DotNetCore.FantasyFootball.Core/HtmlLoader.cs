using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore.FantasyFootball.Core
{
    public class HtmlLoader : IHtmlLoader
    {
        
        public string GetHtml(string pageUri)
        {
            var client = new System.Net.Http.HttpClient();
            return client.GetStringAsync(pageUri).Result;
        }

    }
}
