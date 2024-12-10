using EntityLayer;
using EntityLayer.DTOs;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
    public interface IProductService : IGenericServive<Product>
    {
        List<ProductWithCategoryDTO> TGetProductsByCategory();
    }
}
