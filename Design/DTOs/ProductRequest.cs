namespace Design.DTOs;

using System.ComponentModel.DataAnnotations;
using Design.Models;

public class ProductRequest
{
    [Required]
    public string Title { get; set; }
    public float Price { get; set; }
    public string? Description { get; set; }
    public string[]? Image { get; set; }
    public Category? Category { get; set; }
    public Review? Review { get; set; }
}