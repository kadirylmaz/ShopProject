using System;
using System.Collections.Generic;
using System.Text;

namespace ShopProject.Entities.Concrete.Entities
{
    public class Order:BaseEntity
    {
        public Order()
        {
            OrderDetails = new List<OrderDetail>();
        }
        public int CustomerID { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime RequiredDate { get; set; }

        public DateTime ShippedDate { get; set; }

        public int ShipperID { get; set; }

        public decimal Freight { get; set; }

        public string ShipName { get; set; }

        public string ShipAddress { get; set; }

        public string ShipCity { get; set; }

        public string ShipRegion { get; set; }

        public string ShipCountry { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Shipper Shipper { get; set; }

        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}
