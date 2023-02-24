namespace Design.Models;

using System;
using System.Collections.Generic;
using System.Linq;

public class Order
{
    public int ID { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdateddAt { get; set; }
    public User UserID { get; set; }
    public bool IsDispached { get; set; }
    public ShippingAddress AddressId{get; set; }
    public ICollection<Cart>? Items { get; set; }

    public Order(int id, User userId , ShippingAddress address, ICollection<Cart>? items)
    {
        ID = id;
        CreatedAt = DateTime.Now;
        UpdateddAt = DateTime.Now;
        IsDispached = false;
        UserID = userId;
        Items = items;
        AddressId = address;
    }

    public override string ToString() => $"(orderId: {ID}, CreatedAt: {CreatedAt}, isDispached: {IsDispached}, UserId: {UserID.ID}, items: {Items})";
}
