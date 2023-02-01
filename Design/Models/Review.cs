using System;
namespace Design.Models;

public class Review
{
    public int Rating { get; set; }
    public string Comment { get; set; }

    public Review(int rating, string comment)
    {
        Rating = rating;;
        Comment = comment;
    }
    public override string ToString() => $"(Rating: {Rating}, Comment: {Comment})";
}