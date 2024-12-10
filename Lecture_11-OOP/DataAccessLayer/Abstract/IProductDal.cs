using EntityLayer;
using EntityLayer.DTOs;
using System.Collections.Generic; 

namespace DataAccessLayer.Abstract
{
    public interface IProductDal : IGenericDal<Product>
    {
        List<ProductWithCategoryDTO> GetProductsWithCategory();
    }
}
