using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void TAdd(Customer entity)
        {
            if (entity != null && entity.Name != "" && entity.Name.Length >= 3 && entity.City != null && entity.Surname != "" && entity.Name.Length <= 30)
            {
                _customerDal.Add(entity);
            }
            else
            {
                //Hata Mesajı Ver
            }

        }

        public void TDelete(Customer entity)
        {
            _customerDal.Delete(entity);
        }

        public Customer TGetById(int id)
        {
            return _customerDal.GetById(id);
        }

        public List<Customer> TGetListAll()
        {
            return _customerDal.GetListAll();
        }

        public void TUpdate(Customer entity)
        {
            if (entity.Id != 0 && entity.City.Length >= 3)
            {
                _customerDal.Update(entity);
            }
            else
            {
                //Hata Mesajı Ver
            }
        }
    }
}
