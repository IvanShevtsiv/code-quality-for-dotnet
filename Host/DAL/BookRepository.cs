using Host.Core.Entities;
using Host.Core.Interfaces.Repositories;

namespace Host.DAL
{
    public class BookRepository : IBookRepository
    {
        public Book GetBookById(Guid id)
        {
            return BooksStorage.Books.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Book> GetBooks()
        {
            return BooksStorage.Books;
        }

        public void CreateBook(Book book)
        {
            BooksStorage.Books.Add(book);
        }

        public void UpdateBook(Book book)
        {
            var bookInDB = GetBookById(book.Id);

            if (bookInDB == null)
            {
                throw new Exception($"Can not update the book.");
            }

            // TODO! Add mechanism for update.
        }

        public void DeleteBook(Book book)
        {
            BooksStorage.Books.Remove(book);
        }
    }
}
