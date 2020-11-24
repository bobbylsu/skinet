using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Entities.Interfaces
{
    public interface IProductRepository
    {
        Task<Product> GetProductByIdAsync(int id);
        Task<IReadOnlyList<Product>> GetProductsAsync();
        
    }
}