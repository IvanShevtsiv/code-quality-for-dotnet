namespace Host.Core.Entities
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public String Description { get; set; }
        public Author Author { get; set; }
    }
}
