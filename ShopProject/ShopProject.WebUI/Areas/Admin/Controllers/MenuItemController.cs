using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShopProject.WebUI.Areas.Admin.Controllers.Base;
using ShopProject.WebUI.Areas.Admin.Models.MenuItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ShopProject.WebUI.Areas.Admin.Controllers
{
    [Route("Admin/MenuItem/")]
    public class MenuItemController:BaseController
    {
        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            using (HttpClient client = new HttpClient())
            {
             
                var data = await client.GetAsync("https://localhost:44380/api/MenuItem/GetList/");
                var model = JsonConvert.DeserializeObject<List<MenuItemListModel>>(data.Content.ReadAsStringAsync().Result);
                return View(model);

            }
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(MenuItemListModel model)
        {
            using (HttpClient client = new HttpClient())
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                else
                {
                    var data = JsonConvert.SerializeObject(model);
                    HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
                    await client.PostAsync("https://localhost:44380/api/MenuItem/Add/", content);
                    return RedirectToAction("Index");
                }

            }
        }
        [Route("Detail")]
        public async Task<IActionResult> Detail(int ID)
        {
            using (HttpClient client = new HttpClient())
            {
                var data = await client.GetAsync($"https://localhost:44380/api/MenuItem/{ID}");
                var model = JsonConvert.DeserializeObject<MenuItemListModel>(data.Content.ReadAsStringAsync().Result);
                return View(model);
            }
        }
        [Route("Update")]
        [HttpPost]
        public async Task<IActionResult> Update(MenuItemListModel model)
        {
            using (HttpClient client = new HttpClient())
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                else
                {
                    var data = JsonConvert.SerializeObject(model);
                    HttpContent content = new StringContent(data, System.Text.Encoding.UTF8, "application/json");
                    await client.PostAsync("https://localhost:44380/api/MenuItem/Update", content);
                    return RedirectToAction("Index");
                }
            }
        }
    }
}
