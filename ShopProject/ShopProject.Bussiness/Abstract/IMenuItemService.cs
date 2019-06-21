using ShopProject.Entities.Concrete.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopProject.Bussiness.Abstract
{
    public interface IMenuItemService
    {
        List<MenuItem> GetList();

        MenuItem Get(int id);

        void Remove(MenuItem menuItem);

        void Add(MenuItem menuItem);

        void Update(MenuItem menuItem);

        void Delete(MenuItem menuItem);

    }
}
