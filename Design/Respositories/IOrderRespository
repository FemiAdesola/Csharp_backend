using System;
using Design.DTOs;
using Design.Models;

public interface IOrderRepository
{
    Task<Order> GetOrderAsync(int id, User admin);
    Task<Order> UpdateOrderAsync(int id, OrderRequest request, User admin);
    Task<bool> DeleteOrderAsync(int id, User admin);
    Task<IEnumerable<Order>> GetAllOrderAsync(User admin);
}