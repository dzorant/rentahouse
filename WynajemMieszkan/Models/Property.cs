using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WynajemMieszkan.Models
{
    public class Property
    {
        public int Pierwsze { get; set; }
        public int Drugie { get; set; }
        public int Trzecie { get; set; }
        public string JakisString { get; set; }

        public enum Type
        {
            House = 0,
            Flat = 1,
        }
    }
}
