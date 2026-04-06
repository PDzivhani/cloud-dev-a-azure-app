using Microsoft.EntityFrameworkCore;

public class CloudCanvasDbContextt: DbContext
{
    public CloudCanvasDbContextt(DbContextOptions<CloudCanvasDbContextt> options) : base(options)
    {
    }

    public DbSet<LearningEntry> LearningEntries { get; set; }
}