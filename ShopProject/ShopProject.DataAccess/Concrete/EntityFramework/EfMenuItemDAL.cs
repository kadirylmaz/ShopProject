using ShopProject.Core.DataAccess.EntityFramework;
using ShopProject.DataAccess.Abstract;
using ShopProject.Entities.Concrete.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShopProject.DataAccess.Concrete.EntityFramework
{
    public class EfMenuItemDAL : EfEntityRepositoryBase<MenuItem, ShopContext>, IMenuItemDAL
    {
        void IMenuItemDAL.Remove(MenuItem model)
        {
            using (var context = new ShopContext())
            {
                var menuItem = context.MenuItems.FirstOrDefault(x => x.ID == model.ID);
                menuItem.DeletedDate = DateTime.Now;
                menuItem.IsDeleted = true;
                context.SaveChanges();
            }
        }
    }
}
