using System;
using System.Collections.Generic;
using System.Linq;
namespace Design.Models;

public class Product
{
    public int? ID { get; set; }
    public string Title { get; set; }
    public float Price { get; set; }
    public string Description { get; set; }
    public Category Category { get; set; }


    public Product(int id, string title, float price, string description){
        ID = id;
        Title = title;
        Price = price;
        Description = description;
        // Category.CategoryID = id;
    }

    // public static List<Product> Products = new List<Product>();
    public static List<Product> Products = new List<Product>
    {
        new Product(1, "Shoe", 30.00f, "new shoe from addidas"),
    };

    public static Product CreateProduct(int id, string title, float price, string description)
    {
        var product = new Product(id, title, price, description);
        Products.Add(product);
        return product;
    }

    public void UpdateProduct(int id, string title, float price, string description)
    {
        ID = id;
        Title = title;
        Price = price;
        Description = description;
    }

    public override string ToString() => $"ProdutId: {ID}, Title: {Title}, Price: {Price}€, Description: {Description}";

}
