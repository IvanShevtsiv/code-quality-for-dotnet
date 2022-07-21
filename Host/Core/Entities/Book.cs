namespace Host.Core.Entities
{
    public class Book
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string? Description { get; set; }

        public Author Author { get; set; }

        public Book(string title, Author author) 
        { 
            Id = Guid.NewGuid(); 
            Title = title; 
            Author = author;
        }
    }
}
