namespace Design.DTO;

using Models;


public class OrderRequest
{
    public DateTime CreatedAt { get; set; }
    public Cart? Cart { get; set; }
    public User? User { get; set; }
}