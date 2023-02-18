namespace Design.Models;

public class ImageFile
{
    public int ID { get; set; }
    public string Image { get; set; }


    public ImageFile(int id, string image)
    {
        ID = id;
        Image = image;
    }
}
