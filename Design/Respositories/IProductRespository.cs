namespace Repositories;

using Design.Models;
using Design.DTOs;

public interface IProductRepository
{
    Task<Product> CreateProductAsync(ProductRequest request, User admin);
    Task<Product> UpdateProductAsync(int id, ProductRequest request, User admin);
    Task<bool> DeleteProductAsync(int id, User admin);
    Task<Product> GetProductAsync(int id, User admin);
    Task<IEnumerable<Product>> GetAllProductAsync(User admin);
}