namespace Data.Models;

#nullable disable

public class Comment : BaseEntity
{
    public string Body { get; set; } = string.Empty;
    public User User { get; set; }
    public Post Post { get; set; }
}
