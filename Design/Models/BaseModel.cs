namespace Design.Models;
public abstract class BaseModel
{
    public int ID { get; set; }
    public DateTime CreatedAt { get; } = DateTime.Now;
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}