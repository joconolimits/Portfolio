using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Core.Entities
{
    public class Tag
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<PortfolioItem> PortfolioItems { get; set; }
    }
}
