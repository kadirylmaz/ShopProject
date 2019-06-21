using ShopProject.Core.DataAccess;
using ShopProject.Entities.Concrete.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopProject.DataAccess.Abstract
{
    public interface ISupplierDAL:IEntityRepository<Supplier>
    {
    }
}
