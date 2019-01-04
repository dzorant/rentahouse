using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WynajemMieszkan.Models
{
    public class Owner
    {
        public virtual Owner Name { get; set; }
        public virtual Owner Surname { get; set; }

        public bool Male { get; set; }
        public bool Female { get; set; }

    }


}
