namespace Design.DTOs;

using System.ComponentModel.DataAnnotations;
using Design.Models;

public class ProductRequest
{
    [Required]
    public string Title { get; set; }
    public float Price { get; set; }
    public string? Description { get; set; }
    public ImageFile[]? Images { get; set; } = new ImageFile[3];
    public Category? Category { get; set; }
    public Review? Review { get; set; }
}