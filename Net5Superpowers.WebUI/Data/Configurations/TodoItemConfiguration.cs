using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Net5Superpowers.WebUI.Models;

namespace Net5Superpowers.WebUI.Data.Configurations
{
    public class TodoItemConfiguration : IEntityTypeConfiguration<TodoItem>
    {
        public void Configure(EntityTypeBuilder<TodoItem> builder)
        {
            builder.Property(e => e.Title)
                .HasMaxLength(200)
                .IsRequired();
        }
    }
}
