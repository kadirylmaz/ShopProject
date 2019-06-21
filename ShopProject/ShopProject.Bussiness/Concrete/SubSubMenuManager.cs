using ShopProject.Bussiness.Abstract;
using ShopProject.DataAccess.Abstract;
using ShopProject.Entities.Concrete.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopProject.Bussiness.Concrete
{
    public class SubSubMenuManager : ISubSubMenuService
    {
        private ISubSubMenuDAL _subSubMenuDAL;
        public SubSubMenuManager(ISubSubMenuDAL subSubMenuDAL)
        {
            _subSubMenuDAL = subSubMenuDAL;
        }

        public void Add(SubSubMenu subSubMenu)
        {
            _subSubMenuDAL.Add(subSubMenu);
        }

        public void Delete(SubSubMenu subSubMenu)
        {
            _subSubMenuDAL.Delete(subSubMenu);
        }

        public SubSubMenu Get(int id)
        {
            return _subSubMenuDAL.Get(x => x.ID == id);
        }

        public List<SubSubMenu> GetList()
        {
            return _subSubMenuDAL.GetList();
        }

        public void Update(SubSubMenu subSubMenu)
        {
            _subSubMenuDAL.Update(subSubMenu);
        }
    }
}
