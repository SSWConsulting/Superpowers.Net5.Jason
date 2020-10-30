using Microsoft.EntityFrameworkCore;
using Net5Superpowers.WebUI.Models;
using System;
using System.Reflection;

namespace Net5Superpowers.WebUI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<TodoList> TodoLists { get; set; }

        public DbSet<TodoItem> TodoItems { get; set; }

        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .EnableDetailedErrors()
                .LogTo(Console.WriteLine)
                .AddInterceptors(new TimestampSaveChangesInterceptor());
        }
    }
}
