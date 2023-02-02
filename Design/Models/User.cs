using System;
namespace Design.Models;

public class User
{
    public string? FirstName { get; init; }
    public string? LastName { get; init; }
    public string? Email { get; set; }
    public string? Password { get; set; }
    public int ID { get; set; }

    // public string Image { get; set; }
    public Role Status { get; set; } = Role.Admin;

    public User(int id, string firstName, string lastName, string email, string password, Role status)
    {
        ID = id;
        FirstName= firstName;
        LastName= lastName;
        Email = email;
        Password = password;
        status = Role.Admin;

    }

    public User(int v)
    {
        this.v = v;
    }

    public static List<User> Users = new List<User>();
    private int v;

    public static User CreateUser(int id, string firstName, string lastName, string email, string password, Role status)
    {
        var newUser = new User(id, firstName, lastName, email, password, Role.Admin);
        Users.Add(newUser);
        return newUser;
    }
    public override string ToString() => $"ID: {ID}, firstName: {FirstName}, lastName: {LastName}, email: {Email}, password: {Password}, status: {Status}";
}