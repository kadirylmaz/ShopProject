using System;
using System.Collections.Generic;
using System.Text;

namespace ShopProject.Entities.Concrete.Entities
{
    public class SubMenu:BaseEntity
    {
        public SubMenu()
        {
            SubSubMenus = new List<SubSubMenu>();
        }
        public int MenuID { get; set; }

        public string SubMenuName { get; set; }

        public string ActionName { get; set; }

        public string ControllerName { get; set; }

        public virtual MenuItem MenuItem { get; set; }

        public virtual List<SubSubMenu> SubSubMenus { get; set; }
    }
}
