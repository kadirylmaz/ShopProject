using System;
using System.Collections.Generic;
using System.Text;

namespace ShopProject.Entities.Concrete.Entities
{
    public class Shipper:BaseEntity
    {
        public string CompanyName { get; set; }

        public string Phone { get; set; }

        public List<Order> Orders { get; set; }
    }
}
