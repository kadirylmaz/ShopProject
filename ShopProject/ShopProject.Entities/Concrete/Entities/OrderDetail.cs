using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShopProject.Entities.Concrete.Entities
{
    public class OrderDetail:BaseEntity
    {

        public int OrderID { get; set; }

        public virtual Order Order { get; set; }

        public int ProductID { get; set; }

        public virtual Product Product { get; set; }

        public decimal Quantity { get; set; }

        public decimal Discount { get; set; }



    }
}
