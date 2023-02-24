namespace Design.Models;

public class ShippingAddress
{
    public int ID { get; set; }
    public string? PostalAddress { get; set; }
    public string? PostalCode { get; set; }
    public string? City { get; set; }
    public string? Country { get; set; }
}