namespace Net5Superpowers.WebUI.Models
{
    public class TodoItemDto
    {
        public int Id { get; set; }

        public int ListId { get; set; }

        public string Title { get; set; }

        public int Priority { get; set; }

        public bool Done { get; set; }
    }
}
