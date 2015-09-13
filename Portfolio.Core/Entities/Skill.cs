using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Core.Entities
{
    public class Skill : BaseEntity
    {
        public int Name { get; set; }
        public int Percentage { get; set; }
    }
}
