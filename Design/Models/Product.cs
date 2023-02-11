namespace Design.Models;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Design.DTOs;

public class Product
{
    public int? ID { get; set; }
    public string? Title { get; set; }
    public float Price { get; set; }
    public string? Description { get; set; }
    public string[]? Image { get; set; }
    public Category? Category { get; set; }
    public Review? Review { get; set; }
    public User? User { get; set; }

    public Product ()
    {
        
    }
    
    public Product(int id, string title, float price, string description, string[] image, Category category, Review review, User user)
    {
        ID = id;
        Title = title;
        Price = price;
        Description = description;
        Image = image;
        Category = category;
        Review = review;
        User = user;
    }

    public static Product GetProductRequest(ProductRequest request)
    {
        var product = new Product
        {
            Title = request.Title,
            Description = request.Description,
            Price = request.Price,
            Image = request.Image,
            Category = request.Category,
        };
        if (request.Review is not null)
        {
            product.Review = request.Review;
        }
        return product;
    }

    public override string ToString() => $"produtId: {ID}, title: {Title}, price: {Price}€, description: {Description}, image: {Image}, Category: {Category.ID}, review: {Review?.Comment}";
}
