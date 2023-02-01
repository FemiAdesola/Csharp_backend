using System;
namespace Design.Models;

public  class Category
{
    public int? CategoryID { get; set; }
    public string Name { get; set; }
    public string Image{ get; set; }
    public Category(int id, string name, string image)
    {
        CategoryID = id;
        Name = name;
        Image = image;
    }
    public override string ToString() => $"(id: {CategoryID}, name: {Name}, image: {Image})";
}
