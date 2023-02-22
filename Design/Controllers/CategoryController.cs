namespace Design.Controllers;

using Microsoft.AspNetCore.Mvc;
using System;
using Design.DTOs;
using Design.Models;
using Design.Services;
using System.ComponentModel.DataAnnotations;

[ApiController]
[Route("[controller]s")]
public class CategoryController : ControllerBase
{
    private readonly ICategoryService _categoryService;
    public User Admin { get; }

    //  dependency injection
    public CategoryController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    // POST /api/v1/categories
    
    public async Task<Category> CreateCategoryAsync(CategoryRequest request)
    {
        var category = await _categoryService.CreateCategoryAsync(request, Admin);
        return category;
    }

    // GET /api/v1/categories
    [HttpGet("")]
    public async Task<IEnumerable<Category>> GetAllCategoryAsync()
    {
        var categories= await _categoryService.GetAllCategoryAsync(Admin);
        return categories;
    }

    // GET /api/v1/categories/{:id}
    public async Task<Category> GetCategoryAsync(int id)
    {
        return await _categoryService.GetCategoryAsync(id, Admin);
    }

    // PUT /api/v1/categories/{:id}
    public async Task<Category> UpdateCategoryAsync(int id, CategoryRequest request)
    {
        throw new NotImplementedException();
    }

    // DELETE /api/v1/categories/{:id}
    public async Task<Category> DeleteCategoryAsync(int id, User admin)
    {
        throw new NotImplementedException();
    }

    // GET /api/v1/categories/{:id}/products
    public async Task<IEnumerable<Category>> GetProductByCategoryAsync(int id, User admin)
    {
        throw new NotImplementedException();
    }
}