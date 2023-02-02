using System;
using System.Collections.Generic;
using System.Linq;
namespace Design.Models;

public class Order
{
    public int OrderId { get; set; }
    public DateTime Date { get; set; }
    public bool IsDispached { get; set; }
    public User User { get; set; }
    public Cart Cart { get; set; }
    // public string[] OrderItem = { "ProductID", "Quantity" }; // I would like to know how to get the order item with the product ID and quantity.

    public Order(int orderId, DateTime date, User user , Cart cart)
    {
        OrderId = orderId;
        Date = date;
        IsDispached = true;
        User = user;
        // OrderItem = orderItem;
        Cart = cart;
    }

    public static List<Order> Orders = new List<Order>();
    // public static List<Order> Orders = new List<Order>
    // {
    //     new Order(1, DateTime.Now.ToLocalTime(), 30.00f, new Cart("shoes", 20, 20.00, 50.00f))
    // };

    public static Order CreateOrder(int orderId, DateTime date, bool IsDispached, User user, Cart cart)
    {
        var order = new Order(orderId,date, user, cart);
        Orders.Add(order);
        return order;
    }
    public override string ToString() => $"(orderId: {OrderId}, date: {Date}, isDispached: {IsDispached}, UserId: {User.ID}, cart: {Cart})";
}
