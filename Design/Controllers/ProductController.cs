namespace Design.Controllers;

using System;
using Design.DTOs;
using Design.Models;
using Design.Services;
using System.ComponentModel.DataAnnotations;
using System.Net.Http;

public class ProductController
{
    private readonly IProductService _productService;
    public User Admin { get; }
    
    static List<Product> _products = new List<Product>();
    static int _productId = 0;

    //  dependency injection
    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    // POST /api/products
    // [HttpPost("")]
    public async Task<Product> CreateProductAsync(ProductRequest request)
    {
        var product = await _productService.CreateProductAsync(request, Admin);
        return product;
        // var product = Product.GetProductRequest(request);
        // product.ID = ++_productId;
        // _products.Add(product);
        // return product;
    }

    // GET /api/products
    public async Task<IEnumerable<Product>> GetAllProductAsync()
    {
        var products = await _productService.GetAllProductAsync(Admin);
        return products;
    }

    // GET /api/v1/products/{:id}
    public async Task<Product> GetProductAsync(int id, User admin)
    {
        return await _productService.GetProductAsync(id, admin);
    }

    // PUT /api/v1/products/{:id}
    public async Task<Product> UpdateProductAsync(int id, ProductRequest request, User admin)
    {
        var produt = await GetProductAsync(id, admin);
        if (produt.ID != id)
        {
            throw new ArgumentException("Someone is trying to update this product");
        }
        return produt;
    }

    // DELETE /api/v1/products/{:id}
    public async Task<Product> DeleteProductAsync(int id, User admin)
    {
        throw new NotImplementedException();
    }

    // GET /api/v1/products/topproduct
    public async Task<IEnumerable<Product>> GetTopDemandAsync(int count, User admin)
    {
        throw new NotImplementedException();
    }
}
