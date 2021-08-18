using HopestoneApp.Models;
using Microsoft.EntityFrameworkCore;

namespace HopestoneApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id);
                entity.Property(e => e.Title).HasMaxLength(150);
                entity.Property(e => e.Icon).HasMaxLength(150);
                entity.Property(e => e.Image).HasMaxLength(150);
                entity.Property(e => e.Description).HasMaxLength(250);
                entity.Property(e => e.Created);
                entity.Property(e => e.Updated);
                entity.Property(e => e.IsActive);
            });
        }
    }
}