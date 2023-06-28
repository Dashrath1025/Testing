﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Testing.Models
{
    public class Address
    {
        public Guid Id { get; set; }
        public Guid StudentId { get; set; }
        public string PhysicalAddress { get; set; }
        public string PostalAddress { get; set; }
    }
}