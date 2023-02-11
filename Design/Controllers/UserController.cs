namespace Controllers;

using System;
using Design.DTOs;
using Design.Models;
using Design.Services;
using System.ComponentModel.DataAnnotations;

public class UserController
{
    private readonly IUserService _userService;
    public User CurrentUser { get; }

    //  dependency injection
    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    // POST /api/users
    public async Task<User> SignUpAsync(UserRequest request)
    {
        var user = await _userService.SignUpAsync(request, CurrentUser);
        return user;
    }

    // GET /api/users
    public async Task<IEnumerable<User>> GetAllUserAsync(User admin)
    {
        var users = await _userService.GetAllUserAsync(admin);
        return users;
    }

    // GET /api/Users/{:id}
    public async Task<User> GetUserAsync(int id, User admin)
    {
        var user = await _userService.GetUserAsync(id, admin);
        return user;
    }

    // PUT /api/Users/{:id}
    public async Task<User> UpdateUserAsync(int id, UserRequest request, User currentUser)
    {
        throw new NotImplementedException();
    }

    //DELETE /api/Users/{:id}
    public async Task<User> DeleteUserAsync(int id, User currentUser)
    {
        throw new NotImplementedException();
    }

    //GET /api/auth/login
    public async Task<User> LoginAsync(string email, string password)
    {
        throw new NotImplementedException();
    }
}