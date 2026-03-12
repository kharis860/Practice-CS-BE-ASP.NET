using Microsoft.EntityFrameworkCore;

namespace initApi.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Seed initial data
        modelBuilder.Entity<User>().HasData(
            new User { Id = 8, Username = "user8", Password = "user8" },
            new User { Id = 9, Username = "user9", Password = "user9" }
        );
    }
}