﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore.FantasyFootball.Core
{
    public interface IHtmlLoader
    {
        string GetHtml(string pageUri);
    }
}
