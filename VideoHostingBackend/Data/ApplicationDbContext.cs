using Microsoft.EntityFrameworkCore;
using VideoHostingBackend.Models;

namespace VideoHostingBackend.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<Video> Videos { get; set; }
    public DbSet<Comment> Comments { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
}