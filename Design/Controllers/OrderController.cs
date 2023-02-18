namespace Design.Controllers;

using System;
using Design.DTOs;
using Design.Models;
using Design.Services;
using System.ComponentModel.DataAnnotations;

public class OrderController
{
    private readonly IOrderService _orderService;
    public User Admin { get; }

    //  dependency injection
    public OrderController(IOrderService orderService)
    {
        _orderService = orderService;
    }

    // GET /api/v1/orders
    public async Task<IEnumerable<Order>> GetAllOrderAsync()
    {
        var orders = await _orderService.GetAllOrderAsync(Admin);
        return orders;
    }

    // GET /api/v1/orders/{:id}
    public async Task<Order> GetOrderAsync(int id)
    {
        var order = await _orderService.GetOrderAsync(id, Admin);
        return order;
    }

    // PUT /api/v1/orders/{:id}
    public async Task<Order> UpdateOrderAsync(int id, OrderRequest request, User admin)
    {
        throw new NotImplementedException();
    }

    // DELETE /api/v1/orders/{:id}
    public async Task<Order> DeleteOrderAsync(int id, User admin)
    {
        throw new NotImplementedException();
    }
}