using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class AdminManager : IAdminService
    {
        private readonly IAdminDal _adminDal;

        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }

        public void TAdd(Admin entity)
        {
            _adminDal.Add(entity);
        }

        public void TDelete(Admin entity)
        {
            _adminDal.Delete(entity);
        }

        public Admin TGetById(int id)
        {
            return _adminDal.GetById(id);
        }

        public List<Admin> TGetListAll()
        {
            return _adminDal.GetListAll();
        }

        public void TUpdate(Admin entity)
        {
            _adminDal.Update(entity);
        }
    }
}
