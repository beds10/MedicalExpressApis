using MedicalExpress.CORE.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MedicalExpress.CORE.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetProducts();

        Task<Product> GetProduct(int id);
        Task<IEnumerable<Product>> GetProductbyCat(int id);
        Task<IEnumerable<Product>> GetProductById(int id);
        Task InsertProduct(Product product);
        Task<bool> UpdateProduct(Product product);

        Task<bool> UpdateStock(Product product);
        Task<bool> DeleteProduct(int id);
    }
}