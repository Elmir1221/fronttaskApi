using fronttaskApi.DTOs.Category;
using fronttaskApi.Models;

namespace fronttaskApi.Services.Interfaces
{
    public interface ICategoryService
    {
        Task CreateAsync(CategoryCreateDto data);
        Task EditAsync(Category category, CategoryEditDto data);
        Task DeleteAsync(Category category);
        Task SetToArchiveAsync(Category category);
        Task RestoreAsync(Category category);
        Task<IEnumerable<Category>> GetAllAsync();
        Task<IEnumerable<Category>> GetAllArchivedAsync();
        Task<IEnumerable<Category>> GetAllWithProductsAsync();
        Task<Category> GetByIdAsync(int id);
        Task<Category> GetByIdWithProductsAsync(int id);
        Task<bool> ExistAsync(string name);
    }
}
