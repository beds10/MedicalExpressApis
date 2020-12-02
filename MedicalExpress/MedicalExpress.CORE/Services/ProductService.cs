using MedicalExpress.CORE.Entity;
using MedicalExpress.CORE.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MedicalExpress.CORE.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Product> GetProduct(int id)
        {
            return await _productRepository.GetProduct(id);
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await _productRepository.GetProducts();
        }

        public async Task InsertProduct(Product product)
        {
            await _productRepository.InsertProduct(product);
        }

        public async Task<bool> UpdateProduct(Product product)
        {
            return await _productRepository.UpdateProduct(product);
        }
        public async Task<bool> UpdateStock(Product product)
        {
            return await _productRepository.UpdateStock(product);
        }
        public async Task<bool> DeleteProduct(int id)
        {
            return await _productRepository.DeleteProduct(id);
        }

        public async Task<IEnumerable<Product>> GetProductbyCat(int id)
        {
            return await _productRepository.GetProductbyCat(id);
        }

        public async Task<IEnumerable<Product>> GetProductById(int id)
        {
            return await _productRepository.GetProductById(id);
        }
    }
}
