namespace Design.Models;

public class ImageFile : BaseModel
{
    public string Image { get; set; }


    public ImageFile(int id, string image)
    {
        ID = id;
        Image = image;
    }
}
