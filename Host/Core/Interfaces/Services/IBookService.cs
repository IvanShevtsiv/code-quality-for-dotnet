using Host.Core.Entities;

namespace Host.Core.Interfaces.Services
{
    public interface IBookService
    {
        Task<Book> GetBookByIdAsync(Guid bookId);
        IEnumerable<Book> GetBooks();
        void CreateBook(Book book);
        void UpdateBook(Book book);
        void DeleteBook(Guid bookId);
    }
}
