namespace Host.Core.Entities
{
    public class Book
    {
        /// <summary>
        /// Null object for the Book class
        /// </summary>
        public static Book NotFound = new Book
        {
            Id = Guid.Empty,
            Description = "No books found"
        };

        /// <summary>
        /// book ID
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// book name
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// description
        /// </summary>
        public String Description { get; set; }
        
        /// <summary>
        /// author
        /// </summary>
        public Author Author { get; set; }
    }
}
