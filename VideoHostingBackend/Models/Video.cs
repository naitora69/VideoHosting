namespace VideoHostingBackend.Models;

public class Video
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime CreatedAt { get; set; }
    public int Duration { get; set; }
    public string ThumbnailUrl { get; set; }
    public string VideoUrl { get; set; }
    

    public List<Comment> Comments;
    
}