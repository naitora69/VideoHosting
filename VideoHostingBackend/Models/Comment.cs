namespace VideoHostingBackend.Models;

public class Comment
{
    public int Id { get; set; }
    public string Text { get; set; }
    public DateTime CreatedAt { get; set; }
    public int VideoId { get; set; }
    public Video Video { get; set; }

}