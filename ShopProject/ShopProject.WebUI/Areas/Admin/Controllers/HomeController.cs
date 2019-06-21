using Microsoft.AspNetCore.Mvc;
using ShopProject.WebUI.Areas.Admin.Controllers.Base;

namespace ShopProject.WebUI.Areas.Admin.Controllers
{
    public class HomeController : BaseController
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
