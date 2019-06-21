using Microsoft.AspNetCore.Mvc;
using ShopProject.Bussiness.Abstract;
using ShopProject.Entities.Concrete.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuItemController : Controller
    {
        private IMenuItemService _menuItemService;
        public MenuItemController(IMenuItemService menuItemService)
        {
            _menuItemService = menuItemService;
        }

        [Route("GetList")]
        public List<MenuItem> GetList()
        {
            return _menuItemService.GetList();
        }

     
        [HttpGet("{id}")]
        public MenuItem Get(int ID)
        {
            return _menuItemService.Get(ID);
        }

        [HttpPost]
        [Route("Add")]
        public void Add([FromBody] MenuItem menuItem)
        {
            _menuItemService.Add(menuItem);
        }

       
        public void Update(int menuID)
        {
            
        }

        [HttpPut("{id}")]
        [Route("Update")]
        public void Update([FromBody] MenuItem model)
        {
            _menuItemService.Update(model);
        }

        [HttpDelete("{id}")]
        [Route("Remove")]
        public void Remove([FromBody] MenuItem model)
        {
            _menuItemService.Remove(model);
        }

       
    }
}
