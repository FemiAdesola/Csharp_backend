using System;
namespace Design.Models;

public class Cart
{
    public int ID { get; set; } 
    public Product? Title { get; set; }
    public int Quantity {get; set; }
    public double Price { get; set; }
    public float TotalPrice { get; set; }
   
    public Cart(int id, Product title, int quantity, double price, float totalPrice)
    {
        ID = id;
        Title = title;
        Quantity = quantity;
        Price = price;
        TotalPrice = totalPrice;
    }
    public override string ToString() => $"(productTitle: {Title?.Title}, Quantity: {Quantity}, Totalprice: {TotalPrice})";
}