using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopProject.WebUI.Areas.Admin.Models.MenuItem
{
    public class MenuItemListModel
    {
        public int ID { get; set; }

        [Required]
        public string MenuName { get; set; }
        [Required]
        public string ActionName { get; set; }
        [Required]
        public string ControllerName { get; set; }

        public DateTime CreatedDate { get; set; }

        public bool IsDeleted { get; set; }
    }
}
