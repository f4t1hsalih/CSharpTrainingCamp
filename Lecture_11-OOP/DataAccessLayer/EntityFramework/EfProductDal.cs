using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using DataAccessLayer.Repository;
using EntityLayer;
using EntityLayer.DTOs;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        CampContext _database;
        public EfProductDal(CampContext database) : base(database)
        {
            _database = database;
        }

        public List<ProductWithCategoryDTO> GetProductsWithCategory()
        {
            var values = _database.Products
                .Include(x => x.Category) // Category'yi dahil ediyoruz
                .Select(x => new ProductWithCategoryDTO
                {
                    Id = x.Id,
                    Name = x.Name,
                    Stock = x.Stock,
                    Price = x.Price,
                    Description = x.Description,
                    CategoryName = x.Category.Name // CategoryName'i çekiyoruz
                })
                .ToList();
            return values;
        }
    }
}
