namespace Host.Core.Entities
{
    public class Author
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public Author(int id, string fullName) 
        { 
            Id = id; 
            FullName = fullName;
        }
    }
}
