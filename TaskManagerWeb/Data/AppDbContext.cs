using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TaskManagerWeb.Models;
namespace TaskManagerWeb.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<TaskItem> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(u => u.TaskItems)
                .WithOne(t => t.User)
                .HasForeignKey(t => t.UserId);
        }
    }
}