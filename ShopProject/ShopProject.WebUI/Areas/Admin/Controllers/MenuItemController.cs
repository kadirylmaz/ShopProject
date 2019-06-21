using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ShopProject.WebUI.Areas.Admin.Controllers
{
    public class MenuItemController:Controller
    {
        public async Task<IActionResult> Index()
        {
            using (HttpClient client = new HttpClient())
            {
                var data = await client.GetAsync("http://localhost:53943/api/GetList/");
                var
            }
        }
    }
}
