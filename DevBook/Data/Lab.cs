namespace DevBook.Data
{
    public class Lab
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Objective { get; set; }
        public string? Content { get; set; }
        public List<Task> Tasks { get; set; } = [];
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
