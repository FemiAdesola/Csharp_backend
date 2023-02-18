using System;
using Design.DTOs;
using Design.Models;

public interface ICategoryRepository
{
    Task<Category> CreateCategoryAsync(CategoryRequest request, User admin);
    Task<Category> UpdateCategoryAsync(int id, CategoryRequest request, User admin);
    Task<bool> DeleteCategoryAsync(int id, User admin);
    Task<Category> GetCategoryAsync(int id, User admin);
    Task<IEnumerable<Category>> GetAllCategoryAsync(User admin);
}