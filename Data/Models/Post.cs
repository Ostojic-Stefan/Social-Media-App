namespace Data.Models;

#nullable disable

public class Post : BaseEntity
{
    public string Title { get; set; }
    public string Body { get; set; }
    public string Slug { get; set; }
    public User User { get; set; }
    public List<Comment> Comments { get; set; }
    public Sub Sub { get; set; }
}
