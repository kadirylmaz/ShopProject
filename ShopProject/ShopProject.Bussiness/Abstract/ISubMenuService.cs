using ShopProject.Entities.Concrete.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopProject.Bussiness.Abstract
{
    public interface ISubMenuService
    {
        List<SubMenu> GetList();

        SubMenu Get(int id);

        void Add(SubMenu subMenu);

        void Update(SubMenu subMenu);

        void Delete(SubMenu subMenu);
    }
}
