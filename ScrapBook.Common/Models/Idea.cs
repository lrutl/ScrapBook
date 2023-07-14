namespace ScrapBook.Common.Models
{
    public class Idea
    {
        public Relationship? Relationship { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime? Posted { get; set; }
        public List<Note>? Notes { get; set; }
    }
}