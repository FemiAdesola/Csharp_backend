namespace Design.Models;

public class Review
{
    public int ID { get; set; }
    public Product ProductId{ get; set; }
    public int Rating { get; set; }
    public string Comment { get; set; }
    public DateTime CreatedAt { get; set; }
    public User UserId { get; set; }

    public Review(int id, int rating, string comment, DateTime createdAt, Product productId, User userId)
    {
        ID = id;
        ProductId= productId;
        Rating = rating;;
        Comment = comment;
        CreatedAt = createdAt;
        UserId = userId;
    }
    
    public override string ToString() => 
        $"(id: {ID}, Rating: {Rating}, Comment: {Comment}, date: {CreatedAt}, productId: {ProductId.ID} Customer: {UserId.ID})";
}