using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore.FantasyFootball.Core.Models
{
    public class PlayerAggregate
    {
        public string Name { get; set; }
        public decimal Rank { get; set; }
        public string Position { get; set; }
    }
}
