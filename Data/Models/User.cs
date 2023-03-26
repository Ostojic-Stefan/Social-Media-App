namespace Data.Models;

#nullable disable

public class User : BaseEntity
{
    public string Email { get; set; }
    public string Username { get; set; }
    public string PasswordHash { get; set; }
    public byte[] Salt { get; set; }
    public List<Post> Posts { get; set; }
    public List<Sub> Sub { get; set; }    
}
