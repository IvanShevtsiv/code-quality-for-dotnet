using BookLibrary.Models;
using BookLibrary.Repositories;

namespace BookLibrary.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<Book> GetBookByIdAsync(Guid id)
        {
            var book  = _bookRepository.GetBookById(id);

            if (book is null)
            {
                throw new Exception($"Book with Id {id} could not be found");
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

        public async Task DeleteBookAsync(Guid id)
        {
            var book = await GetBookByIdAsync(id);

            _bookRepository.DeleteBook(book);
        }
    }
}
