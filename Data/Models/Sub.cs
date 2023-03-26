namespace Data.Models;

#nullable disable

public class Sub : BaseEntity
{
    public string Name { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string ImageUrn { get; set; }
    public string BannerUrn { get; set; }
    public User User { get; set; }
    public List<Post> Posts { get; set; }
}
