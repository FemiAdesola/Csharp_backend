namespace Design.Models;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Product

{
    public int? ID { get; set; }
    public string Title { get; set; }
    public float Price { get; set; }
    public string Description { get; set; }
    public string[] Image { get; set; }
    public Category Category { get; set; }
    public Review? Review { get; set; }
    
    public Product(int id, string title, float price, string description, string[] image, Category category, Review review)
    {
        ID = id;
        Title = title;
        Price = price;
        Description = description;
        Image = image;
        Category = category;
        Review = review;
    }

    public override string ToString() => $"produtId: {ID}, title: {Title}, price: {Price}€, description: {Description}, image: {Image}, Category: {Category.ID}, review: {Review?.Comment}";
}
