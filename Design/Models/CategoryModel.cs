using System;
namespace Design.Models;

public abstract class CategoryModel
{
    public int? Id { get; set; }
    public string Name { get; set; }
    public string Image{ get; set; }

}
