using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
    public interface IGenericServive<T> where T : class
    {
        List<T> TGetListAll();
        T TGetById(int id);
        void TAdd(T entity);
        void TUpdate(T entity);
        void TDelete(T entity);
    }
}
