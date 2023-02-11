namespace Design.DTO;

using System.ComponentModel.DataAnnotations;
using Models;

public class UserRequest
{
    [Required]
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
}