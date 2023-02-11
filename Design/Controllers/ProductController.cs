using System;
using Design.DTO;
using Design.Models;
public class ProductController
{
    private readonly IProductService _productService;

    //  dependency injection
    public ProductController(IProductService productService)
    {
        _productService = productService;
    }
    public void GetAllProducts()
    {

    }
    public void GetProduct(int id)
    {
        var product = _productService.GetProduct(id);
     
    }
    public void CreateProduct()
    {

    }
    public void UpdateProduct(int id, ProductRequest dto)
    {
        _productService.UpdateProduct(id, dto);
    }
    public void DeleteProduct(int id)
    {
        _productService.DeleteProduct(id);
        // if (id == null || id == 0)
        // {
        //     return "Not found";
        // }
        // var obj = _productService.Find(id);
        // if (obj == null)
        // {
        //     return " Not found";
        // }
        // return ((string)obj);
    }
}
