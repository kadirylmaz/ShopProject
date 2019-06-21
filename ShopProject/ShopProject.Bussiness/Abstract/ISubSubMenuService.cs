using ShopProject.Entities.Concrete.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopProject.Bussiness.Abstract
{
    public interface ISubSubMenuService
    {
        List<SubSubMenu> GetList();

        SubSubMenu Get(int id);

        void Add(SubSubMenu subSubMenu);

        void Update(SubSubMenu subSubMenu);

        void Delete(SubSubMenu subSubMenu);
    }
}
