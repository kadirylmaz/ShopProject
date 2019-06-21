using ShopProject.Core.DataAccess.EntityFramework;
using ShopProject.DataAccess.Abstract;
using ShopProject.Entities.Concrete.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopProject.DataAccess.Concrete.EntityFramework
{
    class EfSubMenuDAL:EfEntityRepositoryBase<SubMenu,ShopContext>,ISubMenuDAL
    {
    }
}
