using BookLibrary.Models;

namespace BookLibrary.Repositories
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetBooks();
        Book GetBookById(Guid id);
        void CreateBook(Book book);
        void UpdateBook(Book book);
        void DeleteBook(Book obj);
    }
}
