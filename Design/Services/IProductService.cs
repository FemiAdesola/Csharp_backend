namespace Design.Services;

using System;
using Design.DTOs;
using Design.Models;

public interface IProductService
{
    Task<Product> CreateProductAsync(ProductRequest request, User admin);
    Task<Product> UpdateProductAsync(int id, ProductRequest request, User admin);
    Task<bool> DeleteProductAsync(int id, User admin);
    Task<Product> GetProductAsync(int id, User admin);
    Task<IEnumerable<Product>> GetAllProductAsync(User admin);

    Task<IEnumerable<Product>> GetTopDemandAsync(int count, User admin);
}