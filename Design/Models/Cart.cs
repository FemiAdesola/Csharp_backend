using System;
namespace Design.Models;

public class Cart
{
    public string ProductName { get; set; }
    public int Quantity {get; set; }
    public double Price { get; set; }
    public float TotalPrice { get; set; }
    // public Product id { get; set; } 

    public Cart(string productName, int quantity, double price, float totalPrice)
    {
        ProductName = productName; ;
        Quantity = quantity;
        Price = price;
        TotalPrice = totalPrice;
      
    }
    public override string ToString() => $"(ProductName: {ProductName}, Quantity: {Quantity}, Totalprice: {TotalPrice})";
}