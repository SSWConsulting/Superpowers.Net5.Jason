using System;
using System.Collections.Generic;

namespace Net5Superpowers.WebUI.Models
{
    public class TodoItem
    {
        public int Id { get; set; }

        public int ListId { get; set; }

        public string Title { get; set; }

        public string Note { get; set; }

        public PriorityLevel Priority { get; set; }

        public DateTime? Reminder { get; set; }

        public bool Done { get; set; }

        public DateTime Created { get; set; }

        public DateTime Modified { get; set; }

        public TodoList List { get; set; }

        public ICollection<Tag> Tags { get; set; } = new List<Tag>();
    }
}
