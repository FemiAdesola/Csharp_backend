using System;
namespace Design.Models;

public abstract class ProductModel
{
    public int? Id { get; set; }
    public string Name { get; set; }
    public int Price { get; set; }
    public string Description { get; set; }
    public abstract CategoryModel CategoryModel { get; set; }
    public ReviewModel ReviewModel { get; set; } = new ReviewModel();


}
