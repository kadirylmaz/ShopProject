
using ShopProject.Bussiness.Abstract;
using ShopProject.DataAccess.Abstract;
using ShopProject.Entities.Concrete.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopProject.Bussiness.Concrete
{
    public class MenuItemManager : IMenuItemService
    {
        private IMenuItemDAL _menuItemDAL;
        public MenuItemManager(IMenuItemDAL menuItemDAL)
        {
            _menuItemDAL = menuItemDAL;
        }

        public void Add(MenuItem menuItem)
        {
            _menuItemDAL.Add(menuItem);
        }

        public void Delete(MenuItem menuItem)
        {
            _menuItemDAL.Delete(menuItem);
        }

        public MenuItem Get(int id)
        {
            return _menuItemDAL.Get(x => x.ID == id);
        }

        public List<MenuItem> GetList()
        {
            return _menuItemDAL.GetList();
        }

        public void Update(MenuItem menuItem)
        {
            _menuItemDAL.Update(menuItem);
        }
    }
}
