using MedicalExpress.CORE.Entity;
using MedicalExpress.CORE.Interfaces;
using MedicalExpress.INFRASTRUCTURE.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MedicalExpress.INFRASTRUCTURE.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly MedicalExpressDBContext _context;

        public ProductRepository(MedicalExpressDBContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Product>> GetProducts()

        {
            var products = await _context.Products.ToListAsync();
            return products;
        }

        public async Task<Product> GetProduct(int id)

        {
            var product = await _context.Products.FirstOrDefaultAsync(x => x.ProductoId == id);
            return product;
        }


        public async Task<IEnumerable<Product>> GetProductById(int id)

        {
            var products = await _context.Products.Where(x => x.ProductoId == id).ToListAsync();
            return products;
        }

        public async Task<IEnumerable<Product>> GetProductbyCat(int id)

        {
            var products = await _context.Products.Where(x => x.CategoryPrId == id).ToListAsync();
            return products;
        }

        public async Task InsertProduct(Product product)

        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> UpdateProduct(Product product)
        {
            var currentproduct = await GetProduct(product.ProductoId);
            currentproduct.Name = product.Name;
            currentproduct.ProductImage = product.ProductImage;
            currentproduct.Stock = product.Stock;
            currentproduct.UPrice = product.UPrice;
            currentproduct.Description = product.Description;
            currentproduct.Price_stripe = product.Price_stripe;
            currentproduct.Product_stripe = product.Product_stripe;
            currentproduct.CategoryPrId = product.CategoryPrId;
            currentproduct.StatusPrId = product.StatusPrId;
            currentproduct.PharmacyPrId = product.PharmacyPrId;

            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }

        public async Task<bool> UpdateStock(Product product)
        {
            var currentproduct = await GetProduct(product.ProductoId);
            currentproduct.Stock = product.Stock;          

            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }

        public async Task<bool> DeleteProduct(int id)
        {
            var currentproduct = await GetProduct(id);
            _context.Products.Remove(currentproduct);

            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }
    }
}
