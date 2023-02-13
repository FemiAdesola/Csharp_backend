using System;
namespace Design.Models;

public class Cart
{
    public int ID { get; set; } 
    public Product[] Product { get; set; }
    public User User { get; set; }
    public int Quantity {get; set; }
    public double Price { get; set; }
    public float TotalPrice { get; set; }
   
    public Cart(int id, Product[] product, int quantity, double price, float totalPrice, User user)
    {
        ID = id;
        Product = product;
        Quantity = quantity;
        Price = price;
        TotalPrice = totalPrice;
        User = user;
    }
    public override string ToString() => $"(productTitle: {Product}, Quantity: {Quantity}, Totalprice: {TotalPrice}, userId: {User.ID})";
}