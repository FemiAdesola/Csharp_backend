namespace Design.Models;

public class Review
{
    public Product ProductID{ get; set; }
    public int Rating { get; set; }
    public string Comment { get; set; }
    public DateTime CreatedAt { get; set; }
    public User User { get; set; }

    public Review(int rating, string comment, DateTime createdAt, Product productId, User user)
    {
        ProductID= productId;
        Rating = rating;;
        Comment = comment;
        CreatedAt = createdAt;
        User = user;
    }
    public override string ToString() => 
        $"(Rating: {Rating}, Comment: {Comment}, date: {CreatedAt}, productId: {ProductID.ID} Customer: {User.FirstName})";
}