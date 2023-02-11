namespace Controllers;

using System;
using Design.DTOs;
using Design.Models;

public class UserController
{
    private readonly IUserService _userService;

    //  dependency injection
    public UserController(IUserService userService)
    {
        _userService = userService;
    }
    public void GetAllUsers()
    {

    }
    public void GetUser(int id)
    {
        var product = _userService.GetUser(id);
    }
    public void CreateUser()
    {

    }
    public void UpdateUser(int id)
    {

    }
    public void DeleteUser(int id)
    {

    }
}