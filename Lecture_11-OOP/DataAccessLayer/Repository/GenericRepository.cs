using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly CampContext _database;
        private readonly DbSet<T> _object;

        public GenericRepository(CampContext database)
        {
            _database = database;
            _object = database.Set<T>();
        }

        public void Add(T entity)
        {
            _object.Add(entity);
            _database.SaveChanges();
        }

        public void Delete(T entity)
        {
            _object.Remove(entity);
            _database.SaveChanges();
        }

        public T GetById(int id)
        {
            return _object.Find(id);
        }

        public List<T> GetListAll()
        {
            return _object.ToList();
        }

        public void Update(T entity)
        {
            _database.Entry(entity).State = EntityState.Modified;
            _database.SaveChanges();
        }
    }
}
