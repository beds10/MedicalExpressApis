using MedicalExpress.CORE.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MedicalExpress.CORE.Interfaces
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetCategories();

        Task<Category> GetCategory(int id);

        Task InsertCategory(Category category);
        Task<bool> UpdateCategory(Category category);
        Task<bool> DeleteCategory(int id);
    }
}
