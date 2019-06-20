using System;
using System.Collections.Generic;
using System.Text;

namespace ShopProject.Entities.Concrete.Entities
{
    public class Category:BaseEntity
    {
        public Category()
        {
            Products = new List<Product>();
        }
        public string CategoryName { get; set; }

        public string Description { get; set; }

        public string Picture { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}
