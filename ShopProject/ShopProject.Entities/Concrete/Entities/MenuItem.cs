using System;
using System.Collections.Generic;
using System.Text;

namespace ShopProject.Entities.Concrete.Entities
{
    public class MenuItem:BaseEntity
    {
        public MenuItem()
        {
            SubMenus = new List<SubMenu>();
        }
        public string MenuName { get; set; }

        public string ActionName { get; set; }

        public string ControllerName { get; set; }

        public virtual List<SubMenu> SubMenus { get; set; }
    }
}
