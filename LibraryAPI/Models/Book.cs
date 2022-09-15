namespace LibraryAPI.Models
{
    public class Book
    {
        public Guid ID { get; set; }
        public IEnumerable<object> Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }

    }
}
