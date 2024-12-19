using Lecture_22_Dapper.DTOs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lecture_22_Dapper.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public Task AddProductAsync(ProductAddDTO product)
        {
            throw new NotImplementedException();
        }

        public Task DeleteProductAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductResultDTO>> GetAllProductAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ProductResultDTO> GetProductByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateProductAsync(ProductUpdateDTO product)
        {
            throw new NotImplementedException();
        }
    }
}
