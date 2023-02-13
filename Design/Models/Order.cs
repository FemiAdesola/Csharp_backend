namespace Design.Models;

using System;
using System.Collections.Generic;
using System.Linq;

public class Order
{
    public int ID { get; set; }
    public DateTime CreatedAt { get; set; }
    public Cart[] Cart { get; set; }
    public User UserID { get; set; }
    public bool IsDispached { get; set; }
    public ShippingAddress Address{get; set; }

    public Order(int id, User userId , Cart[] cart, ShippingAddress address)
    {
        ID = id;
        CreatedAt = DateTime.Now;
        IsDispached = false;
        UserID = userId;
        Cart = cart;
        Address = address;
    }

    public override string ToString() => $"(orderId: {ID}, CreatedAt: {CreatedAt}, isDispached: {IsDispached}, UserId: {UserID.ID}, cart: {Cart})";
}
