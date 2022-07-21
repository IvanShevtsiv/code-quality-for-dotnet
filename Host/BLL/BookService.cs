using Host.Core.Entities;
using Host.Core.Interfaces.Repositories;
using Host.Core.Interfaces.Services;

namespace Host.BLL
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        
        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<Book> GetBookByIdAsync(Guid bookId)
        {
            var book  = _bookRepository.GetBookById(bookId);

            if (book == null)
            {
                throw new Exception($"Book with Id {bookId} could not be found");
            }

            await Task.CompletedTask;

            return book;
        }

        public IEnumerable<Book> GetBooks()
        {
            return _bookRepository.GetBooks();
        }

        public void CreateBook(Book book)
        {
            book.Id = Guid.NewGuid();
            _bookRepository.CreateBook(book);
        }

        public void UpdateBook(Book book)
        {
            _bookRepository.UpdateBook(book);
        }

        public void DeleteBook(Guid bookId)
        {
            var book = _bookRepository.GetBookById(bookId);

            if (book == null)
            {
                throw new Exception($"Book with Id {bookId} could not be found");
            }

            _bookRepository.DeleteBook(book);
        }
    }
}
