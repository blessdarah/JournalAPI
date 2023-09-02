using Journal.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Journal.Persistence.Data;

public class AppDbContext : DbContext
{
    public virtual DbSet<Category> Categories { get; set; }
    public virtual DbSet<Post> Posts { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    // On model creating function will provide us with the ability to manage the tables properties
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // specify relationships between the entities
        modelBuilder.Entity<Post>(entity =>
        {
            entity
                .HasOne(e => e.Category)
                .WithMany(e => e.Posts)
                .HasForeignKey(e => e.CategoryId)
                .OnDelete(DeleteBehavior.NoAction)
                .HasConstraintName("FK_Categories_Post");
        });
    }
}
