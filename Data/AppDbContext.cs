using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Data;

#nullable disable
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {}

    public DbSet<User> Users { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<Sub> Subs { get; set; }
    public DbSet<Comment> Comments { get; set; }
}
