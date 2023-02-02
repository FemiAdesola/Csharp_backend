using System;
namespace Design.Models;

public class Review
{
    public int Rating { get; set; }
    public string Comment { get; set; }
    public DateTime CreatedAt { get; set; }

    public Review(int rating, string comment, DateTime createdAt)
    {
        Rating = rating;;
        Comment = comment;
        CreatedAt = createdAt;
    }
    public override string ToString() => $"(Rating: {Rating}, Comment: {Comment}, date: {CreatedAt}))";
}