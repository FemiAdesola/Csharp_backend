using System;
using Design.DTOs;
using Design.Models;

public interface IUserRepository
{
    Task<User> SignUpAsync(UserRequest request);
    Task<User> UpdateUserAsync(int id, UserRequest request, User currentUser);
    Task<bool> DeleteUserAsync(int id, User admin);
    Task<User> GetUserAsync(int id, User currentUser);
    Task<IEnumerable<User>> GetAllUserAsync(User currentUser);
}