using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WynajemMieszkan.Models
{
    public class Address
    {
        public virtual Address City { get; set; }
        public virtual Address Street { get; set; }

        public bool Alone { get; set; }
    }
}
