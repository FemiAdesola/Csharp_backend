namespace Design.Models;

public  class Category
{
    public int? ID { get; set; }
    public string Name { get; set; }
    public string Image{ get; set; }

    public Category(int id, string name, string image)
    {
        ID = id;
        Name = name;
        Image = image;
    }
    public override string ToString() => $"(id: {ID}, name: {Name}, image: {Image})";
}
