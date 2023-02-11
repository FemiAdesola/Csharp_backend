using System;
namespace Design.Models;

public class Review
{
    public Product ProductTitle { get; set; }
    public int Rating { get; set; }
    public string Comment { get; set; }
    public DateTime CreatedAt { get; set; }
    public User UserName { get; set; }

    public Review(int rating, string comment, DateTime createdAt, Product productTitle, User userName)
    {
        ProductTitle= productTitle;
        Rating = rating;;
        Comment = comment;
        CreatedAt = createdAt;
        UserName = userName;
    }
    public override string ToString() => 
        $"(Rating: {Rating}, Comment: {Comment}, date: {CreatedAt}, productTitle: {ProductTitle.Title} Customer: {UserName.FirstName + " " + UserName.LastName})";
}