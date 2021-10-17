﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleProject.Data.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Addresss { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public ICollection<Order> Orders { get; set; }
      
    }
}
