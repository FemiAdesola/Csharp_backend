namespace Design.Services;

using Design.DTOs;
using Design.Models;

public interface ICategoryService
{
    Task<Category> CreateCategoryAsync(CategoryRequest request);
    Task<Category?> UpdateCategoryAsync(int id, CategoryRequest request);
    Task<bool> DeleteCategoryAsync(int id);
    Task<Category> GetCategoryAsync(int id);
    Task<IEnumerable<Category>> GetAllCategoryAsync();

    Task<IEnumerable<Category>> GetProductByCategoryAsync(int id, User admin);
}