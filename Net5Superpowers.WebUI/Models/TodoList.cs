using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net5Superpowers.WebUI.Models
{
    public class TodoList
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Colour { get; set; }

        public ICollection<TodoItem> Items { get; set; } = new List<TodoItem>();
    }
}
