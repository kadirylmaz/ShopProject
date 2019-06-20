using System;
using System.Collections.Generic;
using System.Text;

namespace ShopProject.Entities.Concrete.Entities
{
    public class Supplier:BaseEntity
    {
        public Supplier()
        {
            Products = new List<Product>();
        }

        public string CompanyName { get; set; }

        public string ContactName { get; set; }

        public string ContactTitle { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Region { get; set; }

        public string Country { get; set; }

        public string Phone { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}
