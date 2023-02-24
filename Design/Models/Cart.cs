using System;
namespace Design.Models;

public class Cart
{
    public int ID { get; set; } 
    public Product ProductId { get; set; }
    public User UserId { get; set; }
    public int Quantity {get; set; }
    public double Price { get; set; }
    public float TotalPrice { get; set; }
   
    public Cart(int id, Product productId, int quantity, double price, float totalPrice, User userId)
    {
        ID = id;
        ProductId = productId;
        Quantity = quantity;
        Price = price;
        TotalPrice = totalPrice;
        UserId = userId;
    }
    
    public override string ToString() => $"(productId: {ProductId.ID}, Quantity: {Quantity}, Totalprice: {TotalPrice}, userId: {UserId.ID})";
}