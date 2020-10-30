using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net5Superpowers.WebUI.Models
{
    public class TodoListDto
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public ICollection<TodoItemDto> Items { get; set; } = new List<TodoItemDto>();
    }
}
