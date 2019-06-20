using System;
using System.Collections.Generic;
using System.Text;

namespace ShopProject.Entities.Concrete.Entities
{
    public class Product:BaseEntity
    {
        public Product()
        {
            OrderDetails = new List<OrderDetail>();
        }
        public string ProductName { get; set; }

        public int SupplierID { get; set; }

        public int CategoryID { get; set; }

        public string QuantityPerUnit { get; set; }

        public decimal UnitPrice { get; set; }

        public bool Discounted { get; set; }

        public virtual Supplier Supplier { get; set; }

        public virtual Category Category { get; set; }

        public virtual List<OrderDetail> OrderDetails { get; set; } 
    }
}
