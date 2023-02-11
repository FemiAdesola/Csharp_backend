namespace Controllers;

using System;
using Design.DTOs;
using Design.Models;

public class UserController
{
    private readonly IUserService _userService;
    public User Admin

    //  dependency injection
    public UserController(IUserService userService)
    {
        _userService = userService;
    }
    
}