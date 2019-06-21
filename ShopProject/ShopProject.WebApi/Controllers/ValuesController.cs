using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShopProject.Bussiness.Abstract;
using ShopProject.Entities.Concrete.Entities;

namespace ShopProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IMenuItemService _menutItemService;
        public ValuesController(IMenuItemService menuItemService)
        {
            _menutItemService = menuItemService;
        }
        // GET api/values
        [HttpGet]
        public List<MenuItem> Get()
        {
            return _menutItemService.GetList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
