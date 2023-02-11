namespace Design.DTOs;

using System.ComponentModel.DataAnnotations;
using Design.Models;

public class UserRequest
{
    [Required]
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
}