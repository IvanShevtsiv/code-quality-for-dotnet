using BookLibrary.Models;

namespace BookLibrary.Services
{
    public interface IBookService
    {
        Task<Book> GetBookByIdAsync(Guid id);
        IEnumerable<Book> GetBooks();
        void CreateBook(Book book);
        void UpdateBook(Book book);
        Task DeleteBookAsync(Guid id);
    }
}
