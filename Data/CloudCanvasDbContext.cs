using Microsoft.EntityFrameworkCore;
using MyFirstAzureWebAppNet8.Models;
namespace MyFirstAzureWebAppNet8.Data;

public class CloudCanvasDbContext: DbContext
{
    public CloudCanvasDbContext(DbContextOptions<CloudCanvasDbContext> options) : base(options)
    {
    }

    public DbSet<LearningEntry> LearningEntries { get; set; }
    public DbSet<Project> Projects { get; set; }
}