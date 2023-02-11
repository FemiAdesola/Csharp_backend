namespace Controllers;

using System;
using Design.DTOs;
using Design.Models;
using Design.Services;
using System.ComponentModel.DataAnnotations;

public class ProductController
{
    private readonly IProductService _productService;
    public User Admin { get; }

    //  dependency injection
    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    // POST /api/products
    public async Task<Product> CreateProductAsync(ProductRequest request)
    {
        var product = await _productService.CreateProductAsync(request, Admin);
        return product;
    }

    // GET /api/products
    public async Task<IEnumerable<Product>> GetAllProductAsync()
    {
        var product = await _productService.GetAllProductAsync(Admin);
        return product;
    }

    // GET /api/products/{:id}
    public async Task<Product> GetProductAsync(int id)
    {
        return await _productService.GetProductAsync(id, Admin);
    }

    // PUT /api/products/{:id}
    public async Task<Product> UpdateProductAsync(int id, ProductRequest request)
    {
        throw new NotImplementedException();
    }

    // DELETE /api/products/{:id}
    public async Task<Product> DeleteProductAsync(int id, User admin)
    {
        throw new NotImplementedException();
    }

    // GET /api/products/topproduct
    public async Task<IEnumerable<Product>> GetTopDemandAsync(int count, User admin)
    {
        throw new NotImplementedException();
    }
}
