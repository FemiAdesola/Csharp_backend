using System;
namespace Design.Models;

public class CartModel : UsersModel
{
    public string ProductName { get; set; }
    public int Quantity {get; set; }
    public int Price { get; set; }
    public float FinalPrice { get; set; }
}