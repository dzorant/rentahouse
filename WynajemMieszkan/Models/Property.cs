﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WynajemMieszkan.Models
{
    public class Property
    {
        public int Id { get; set; }
        public PropertyType Type { get; set; }
        public string Description { get; set; }
        public int Rooms { get; set; }
        public int Area { get; set; }
        public bool Washer { get; set; }
        public bool Refrigerator { get; set; }
        public bool Iron { get; set; }

        public virtual int AddressIs { get; set; }
        public virtual Address MyProperty { get; set; }

        public virtual int OwnerId { get; set; }
        public virtual Owner Owner { get; set; }

    }
    public enum PropertyType
    {
        House = 0,
        Flat = 1
    }

}
