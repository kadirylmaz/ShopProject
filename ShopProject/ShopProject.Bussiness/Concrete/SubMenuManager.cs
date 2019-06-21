using ShopProject.Bussiness.Abstract;
using ShopProject.DataAccess.Abstract;
using ShopProject.Entities.Concrete.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopProject.Bussiness.Concrete
{
    public class SubMenuManager : ISubMenuService
    {
        private ISubMenuDAL _subMenuDAL;
        public SubMenuManager(ISubMenuDAL subMenuDAL)
        {
            _subMenuDAL = subMenuDAL;
        }

        public void Add(SubMenu subMenu)
        {
            _subMenuDAL.Add(subMenu);
        }

        public void Delete(SubMenu subMenu)
        {
            _subMenuDAL.Delete(subMenu);
        }

        public SubMenu Get(int id)
        {
            return _subMenuDAL.Get(x => x.ID == id);
        }

        public List<SubMenu> GetList()
        {
            return _subMenuDAL.GetList();
        }

        public void Update(SubMenu subMenu)
        {
            _subMenuDAL.Update(subMenu);
        }
    }
}
