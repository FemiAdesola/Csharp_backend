namespace Design.Services;

using System.Collections.Generic;
using Design.DTOs;
using Design.Models;
using System.Collections.Concurrent;
using System.Threading.Tasks;

public class FakeCategorySerivce : ICategoryService
{
    private ConcurrentDictionary<int, Category> _categories = new();
    private int _categoryId;
    public async Task<Category> CreateCategoryAsync(CategoryRequest request)
    {
        var category =  new Category
        {
            ID = Interlocked.Increment(ref _categoryId), // Atomic operation
            Name = request.Name,
            Image = request.Image,
        };
        _categories[category.ID] = category;
        return (category);
    }

    public async Task<bool> DeleteCategoryAsync(int id)
    {
        if (!_categories.ContainsKey(id))
        {
            return false;
        }
        return _categories.Remove(id, out var _);
    }

    public async Task<Category> GetCategoryAsync(int id)
    {
        // return _categories[id];

        if (_categories.TryGetValue(id, out var category))
        {
            return category;
        }
        return null;

    }

    public async Task<IEnumerable<Category>> GetAllCategoryAsync()
    {
        return _categories.Values;
    }

    public async Task<Category?> UpdateCategoryAsync(int id, CategoryRequest request)
    {
        // throw new NotSupportedException();
        var category = await GetCategoryAsync(id);
        if (category is null)
        {
            return null;
        }
     
        category.Name = request.Name;
        category.Image = request.Image;
        return category;
    }


    public async Task<IEnumerable<Category>>GetProductByCategoryAsync(int id, User admin)
    {
        throw new NotSupportedException();
    }

}