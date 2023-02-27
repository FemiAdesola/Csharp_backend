namespace Design.DTOs;

using System.ComponentModel.DataAnnotations;
using Design.Models;

public class CategoryRequest : BaseRequest<Category>
{
    [Required]
    public string? Name { get; set; }
    public string? Image { get; set; }

    public override void UpdateModel(Category model)
    {
        model.Name = Name;
        model.Image = Image;
    }
}