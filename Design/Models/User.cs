namespace Design.Models;

public class User
{
    public int ID { get; set; }
    public string? FirstName { get; init; }
    public string? LastName { get; init; }
    public string? Email { get; set; }
    public string? Password { get; set; }
    public string? Image { get; set; }
    public UserRole Status { get; set; }

    public User()
    {

    }

    public User(int id, string firstName, string lastName, string email, string password)
    {
        ID = id;
        FirstName= firstName;
        LastName= lastName;
        Email = email;
        Password = password;
        Status = UserRole.LoginUser;
    }

    public override string ToString() => $"ID: {ID}, firstName: {FirstName}, lastName: {LastName}, email: {Email}, password: {Password}, status: {Status}";
}

public enum UserRole
{
    Admin,
    LoginUser,
}