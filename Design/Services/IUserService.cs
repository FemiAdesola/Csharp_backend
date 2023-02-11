namespace Design.Services;

using System;
using Design.DTOs;
using Design.Models;

public interface IUserService
{
    Task<User> SignUpAsync(UserRequest request, User currentUser);
    Task<User> LoginAsync(string email, string password);
    Task<User> UpdateUserAsync(int id, UserRequest request, User currentUser);
    Task<bool> DeleteUserAsync(int id, User currentUser);
    Task<User> GetUserAsync(int id, User admin);
    Task<IEnumerable<User>> GetAllUserAsync(User admin);
}