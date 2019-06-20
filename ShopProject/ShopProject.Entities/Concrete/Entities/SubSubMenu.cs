using System;
using System.Collections.Generic;
using System.Text;

namespace ShopProject.Entities.Concrete.Entities
{
    public class SubSubMenu:BaseEntity
    {
        public int SubMenuID { get; set; }

        public string SubSubMenuName { get; set; }

        public string ActionName { get; set; }

        public string ControllerName { get; set; }

        public virtual SubMenu SubMenu { get; set; }
    }
}
