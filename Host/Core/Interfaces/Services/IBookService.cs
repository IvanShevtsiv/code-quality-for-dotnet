using Host.Core.Entities;

namespace Host.Core.Interfaces.Services
{
    /// <summary>
    /// Methods for manipulating with book objects
    /// </summary>
    public interface IBookService
    {
        /// <summary>
        /// check if a book exists
        /// </summary>
        /// <param name="id">book id</param>
        /// <returns>book exists: yes/no</returns>
        public bool BookExists(Guid id);

        /// <summary>
        /// get a book
        /// </summary>
        /// <param name="id">book id</param>
        /// <returns>book object</returns>
        Task<Book> GetBookAsync(Guid id);
        
        /// <summary>
        /// get all books
        /// </summary>
        /// <returns>list(?) of all books</returns>
        Task<IEnumerable<Book>> GetAllBooksAsync();
        
        /// <summary>
        /// add new book
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        Task AddNewBookAsync(Book book);
        
        /// <summary>
        /// update existing book
        /// </summary>
        /// <param name="book"></param>
        void UpdateBookAsync(Book book);
        
        /// <summary>
        /// delete existing book
        /// </summary>
        /// <param name="id">book id</param>
        /// <returns></returns>
        Task DeleteBookAsync(Guid id);
    }
}
