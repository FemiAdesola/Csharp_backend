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
    public string Image { get; set; }
    public Category Category { get; set; }

    public Product(int id, string title, float price, string description, string image, Category category)
    {
        ID = id;
        Title = title;
        Price = price;
        Description = description;
        Image = image;
        Category = category;
    }

    // public static List<Product> Products = new List<Product>();
    public static List<Product> Products = new List<Product>
    {
        new Product(1, "Shoe", 30.00f, "Andy shoes are designed to keeping in...", "https://google.com.png", new Category(1, "Addidas", "https://google.com.png"))
    };

    public static Product CreateProduct(int id, string title, float price, string description, string image, Category category)
    {
        var product = new Product(id, title, price, description, image, category);
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

    public override string ToString() => $"produtId: {ID}, title: {Title}, price: {Price}€, description: {Description}, image: {Image}, Category: {Category}";

}
