using System;
using Design.DTO;
using Design.Models;

public interface IUserService
{
    User GetUser(int id);
    void DeleteUser(int id);
    void UpdateUser(int id, UserRequest dto);

}