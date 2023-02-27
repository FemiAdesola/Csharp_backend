namespace Design.Models;

public class Review : BaseModel
{
    public Product ProductId{ get; set; }
    public int Rating { get; set; }
    public string Comment { get; set; }
    public User UserId { get; set; }

    public Review(int id, int rating, string comment,Product productId, User userId)
    {
        ID = id;
        ProductId= productId;
        Rating = rating;;
        Comment = comment;
        UserId = userId;
    }
    
    public override string ToString() => 
        $"(id: {ID}, Rating: {Rating}, Comment: {Comment}, productId: {ProductId.ID} Customer: {UserId.ID})";
}