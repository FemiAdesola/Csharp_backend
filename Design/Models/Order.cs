namespace Design.Models;

using System;
using System.Collections.Generic;
using System.Linq;

public class Order
{
    public int ID { get; set; }
    public DateTime CreatedAt { get; set; }
    public Cart[] Cart { get; set; }
    public User User { get; set; }
    public bool IsDispached { get; set; }
    public ShippingAddress Address{get; set; }

public Order(int id, User user , Cart[] cart, ShippingAddress address)
    {
        ID = id;
        CreatedAt = DateTime.Now;
        IsDispached = false;
        User = user;
        Cart = cart;
        Address = address;
    }

    public override string ToString() => $"(orderId: {ID}, CreatedAt: {CreatedAt}, isDispached: {IsDispached}, UserId: {User.ID}, cart: {Cart})";
}
