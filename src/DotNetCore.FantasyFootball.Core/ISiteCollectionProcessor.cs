﻿using DotNetCore.FantasyFootball.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore.FantasyFootball.Core
{
    public interface ISiteCollectionProcessor
    {
        List<PlayerAggregate> Process(SiteCollection siteCollection);
    }
}
