using Microsoft.AspNetCore.Mvc;
using ShopProject.WebUI.Areas.Admin.Controllers.Base;

namespace ShopProject.WebUI.Areas.Admin.Controllers
{
    [Route("Admin/Home/")]
    public class HomeController : BaseController
    {
        [Route("Index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
