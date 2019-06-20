﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ShopProject.Entities.Concrete.Entities
{
    public class Customer:BaseEntity
    {
        public Customer()
        {
            Orders = new List<Order>();
        }
        public string CompanyName { get; set; }

        public string ContactName { get; set; }

        public string ContactTitle { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Region { get; set; }

        public string Country { get; set; }

        public virtual List<Order> Orders { get; set; }
    }
}
