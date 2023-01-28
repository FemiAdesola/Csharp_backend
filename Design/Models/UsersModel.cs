using System;
namespace Design.Models;

public abstract class UsersModel
{
    public int Id { get; set; }
    public string? FirstName { get; init; }
    public string? LastName { get; init; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Image { get; set; }
    public UserRole Status { get; set; } = UserRole.Admin;
}