namespace Design.Models;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Design.DTOs;

public class Product : BaseModel
{
    public string? Title { get; set; }
    public float Price { get; set; }
    public string? Description { get; set; }
    public ImageFile[]? Images { get; set; } = new ImageFile[3];
    public Category? Category { get; set; }
    public Review? Review { get; set; }

    public Product ()
    {
        
    }
    
    public Product(int id, string title, float price, string description, ImageFile[] images, Category category, Review review)
    {
        ID = id;
        Title = title;
        Price = price;
        Description = description;
        Category = category;
        Review = review;
    }

    public static Product GetProductRequest(ProductRequest request)
    {
        var product = new Product
        {
            Title = request.Title,
            Description = request.Description,
            Price = request.Price,
            Images = request.Images,
            Category = request.Category,
        };
        if (request.Review is not null)
        {
            product.Review = request.Review;
        }
        return product;
    }

    public override string ToString() => $"produtId: {ID}, title: {Title}, price: {Price}€, description: {Description}, images: {Images?[3]}, Category: {Category?.ID}, review: {Review?.Comment}";
}
