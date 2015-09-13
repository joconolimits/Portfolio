using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Core.Entities
{
    public class User : BaseEntity
    {

        public int Name { get; set; }
        public int LastName { get; set; }
        public int Address { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNum { get; set; }
        

    }
}
