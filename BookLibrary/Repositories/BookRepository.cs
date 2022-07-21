using BookLibrary.Models;

namespace BookLibrary.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly DataContext _dataContext;

        public BookRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IEnumerable<Book> GetBooks()
        {
            return _dataContext.Books;
        }

        public Book GetBookById(Guid id)
        {
            return _dataContext.Books.FirstOrDefault(x => x.Id == id);
        }

        public void CreateBook(Book book)
        {
            _dataContext.Books.Add(book);
        }

        public void UpdateBook(Book book)
        {
            var bookInDb = GetBookById(book.Id);

            if (bookInDb is null)
            {
                throw new Exception($"Can not update the book because it could not be found");
            }

            // TODO: Add mechanism for update.
        }

        public void DeleteBook(Book book)
        {
            _dataContext.Books.Remove(book);
        }
    }
}
