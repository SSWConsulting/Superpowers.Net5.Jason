using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Net5Superpowers.WebUI.Models;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Net5Superpowers.WebUI.Data
{
    public class TimestampSaveChangesInterceptor : SaveChangesInterceptor
    {
        public override InterceptionResult<int> SavingChanges(
            DbContextEventData eventData,
            InterceptionResult<int> result)
        {
            ApplyTimestamps(eventData.Context);

            return result;
        }

        public override ValueTask<InterceptionResult<int>> SavingChangesAsync(
            DbContextEventData eventData,
            InterceptionResult<int> result,
            CancellationToken cancellationToken = default)
        {
            ApplyTimestamps(eventData.Context);

            return new ValueTask<InterceptionResult<int>>(result);
        }

        private void ApplyTimestamps(DbContext context)
        {
            foreach (var entry in context.ChangeTracker.Entries<TodoItem>())
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Entity.Created = DateTime.UtcNow;
                }

                if (entry.State == EntityState.Added ||
                    entry.State == EntityState.Modified)
                {
                    entry.Entity.Modified = DateTime.UtcNow;
                }
            }
        }
    }
}
