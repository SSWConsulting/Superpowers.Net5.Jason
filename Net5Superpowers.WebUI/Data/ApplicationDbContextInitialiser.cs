using Microsoft.EntityFrameworkCore;
using Net5Superpowers.WebUI.Models;
using System.Linq;

namespace Net5Superpowers.WebUI.Data
{
    public static class ApplicationDbContextInitialiser
    {
        public static void Initialise(ApplicationDbContext context)
        {
            // Ensures that the database for the context does not exist. 
            // If it does not exist, no action is taken.
            // If it does exist then the database is deleted.
            //context.Database.EnsureDeleted();

            // Ensures that the database for the context exists.
            // If it exists, no action is taken. 
            // If it does not exist then the database and all its schema are created. 
            // If the database exists, then no effort is made to ensure it is compatible with the model for this context.
            //context.Database.EnsureCreated();

            // Applies any pending migrations for the context to the database. Will create the database if it does not already exist.
            context.Database.Migrate();

            if (context.TodoLists.Any())
            {
                return;
            }

            var list = new TodoList
            {
                Title = "Todo List",
                Items =
                {
                    new TodoItem { Title = "Make a todo list" },
                    new TodoItem { Title = "Check off the first item" },
                    new TodoItem { Title = "Realise you've already done two things on the list!"},
                    new TodoItem { Title = "Reward yourself with a nice, long nap" },
                }
            };

            context.TodoLists.Add(list);
            context.SaveChanges();
        }
    }
}
