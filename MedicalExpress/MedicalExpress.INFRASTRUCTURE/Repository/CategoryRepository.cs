using MedicalExpress.CORE.Entity;
using MedicalExpress.CORE.Interfaces;
using MedicalExpress.INFRASTRUCTURE.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MedicalExpress.INFRASTRUCTURE.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly MedicalExpressDBContext _context;

        public CategoryRepository(MedicalExpressDBContext context)
        {
            _context = context;
        }


        public async Task<IEnumerable<Category>> GetCategories()

        {
            var categories = await _context.Categories.ToListAsync();
            return categories;
        }

        public async Task<Category> GetCategory(int id)

        {
            var category = await _context.Categories.FirstOrDefaultAsync(x => x.CategoryId == id);
            return category;
        }

        public async Task InsertCategory(Category category)
        {
            _context.Categories.Add(category);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> UpdateCategory(Category category)
        {

            var currentcategorie = await GetCategory(category.CategoryId);
            currentcategorie.Name = category.Name;


            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }

        public async Task<bool> DeleteCategory(int id)
        {
            var currentcategorie = await GetCategory(id);
            _context.Categories.Remove(currentcategorie);

            int rows = await _context.SaveChangesAsync();
            return rows > 0;
        }
    }
}
