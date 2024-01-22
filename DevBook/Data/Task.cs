namespace DevBook.Data
{
    public enum Level
    { 
        Easy,
        Medium,
        Hard
    }

    public class Task
    {
        public int Id { get; set; }
        public required string NanoId { get; set; }
        public required string Content { get; set; }
        public Level Level { get; set; }
        public List<Lab> Labs { get; set; } = [];
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
