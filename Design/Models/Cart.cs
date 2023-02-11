using System;
namespace Design.Models;

public class Cart
{
    public int ID { get; set; } 
    public Product? ProductTitle { get; set; }
    public int Quantity {get; set; }
    public double Price { get; set; }
    public float TotalPrice { get; set; }
   

    public Cart(int id, Product productTitle, int quantity, double price, float totalPrice)
    {
        ID = id;
        ProductTitle = productTitle;
        Quantity = quantity;
        Price = price;
        TotalPrice = totalPrice;
      
    }
    public override string ToString() => $"(productTitle: {ProductTitle?.Title}, Quantity: {Quantity}, Totalprice: {TotalPrice})";
}