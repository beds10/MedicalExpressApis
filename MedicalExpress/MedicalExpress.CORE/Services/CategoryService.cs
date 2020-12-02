using MedicalExpress.CORE.Entity;
using MedicalExpress.CORE.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MedicalExpress.CORE.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<IEnumerable<Category>> GetCategories()
        {
            return await _categoryRepository.GetCategories();
        }

        public async Task<Category> GetCategory(int id)
        {
            return await _categoryRepository.GetCategory(id);
        }

        public async Task InsertCategory(Category category)
        {
            await _categoryRepository.InsertCategory(category);
        }

        public async Task<bool> UpdateCategory(Category category)
        {
            return await _categoryRepository.UpdateCategory(category);
        }

        public async Task<bool> DeleteCategory(int id)
        {
            return await _categoryRepository.DeleteCategory(id);
        }
    }
}
