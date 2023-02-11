namespace Controllers;

using System;
using Design.DTOs;
using Design.Models;
using Design.Services;
using System.ComponentModel.DataAnnotations;

public class CategoryController
{
    private readonly ICategoryService _categoryService;
    public User Admin { get; }

    //  dependency injection
    public CategoryController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    // POST /api/categories
    public async Task<Category> CreateCategoryAsync(CategoryRequest request)
    {
        var category = await _categoryService.CreateCategoryAsync(request, Admin);
        return category;
    }

    // GET /api/categories
    public async Task<IEnumerable<Category>> GetAllCategoryAsync()
    {
        var category= await _categoryService.GetAllCategoryAsync(Admin);
        return category;
    }

    // GET /api/categories/{:id}
    public async Task<Category> GetCategoryAsync(int id)
    {
        return await _categoryService.GetCategoryAsync(id, Admin);
    }

    // PUT /api/categories/{:id}
    public async Task<Category> UpdateCategoryAsync(int id, CategoryRequest request)
    {
        throw new NotImplementedException();
    }

    // DELETE /api/categories/{:id}
    public async Task<Category> DeleteCategoryAsync(int id, User admin)
    {
        throw new NotImplementedException();
    }

    // GET /api/categories/{:id}/products
    public async Task<IEnumerable<Category>> GetProductByCategoryAsync(int id, User admin)
    {
        throw new NotImplementedException();
    }
}