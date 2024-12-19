using Lecture_22_Dapper.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lecture_22_Dapper.Repositories
{
    public interface IProductRepository
    {
        Task<List<ProductResultDTO>> GetAllProductAsync();
        Task<ProductResultDTO> GetProductByIdAsync(int id);
        Task AddProductAsync(ProductAddDTO product);
        Task UpdateProductAsync(ProductUpdateDTO product);
        Task DeleteProductAsync(int id);
    }
}
