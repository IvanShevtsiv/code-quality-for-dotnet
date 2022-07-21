using Host.Core.Entities;

namespace Host.Core.Interfaces.Repositories
{
    public interface IBookRepository
    {
        Book GetBookById(Guid bookId);
        IEnumerable<Book> GetBooks();
        void CreateBook(Book book);
        void UpdateBook(Book book);
        void DeleteBook(Book book);
    }
}
