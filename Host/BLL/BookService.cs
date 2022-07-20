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

        public bool BookExists(Guid id)
        {
            var book = _bookRepository.Get(id);

            return book != null;
        }

        public async Task<Book> GetBookAsync(Guid id)
        {
            var book  = _bookRepository.Get(id);

            await Task.CompletedTask;

            return book;
        }

        public async Task<IEnumerable<Book>> GetAllBooksAsync()
        {
            var books = _bookRepository.Get();
            return books;
        }

        public async Task AddNewBookAsync(Book book)
        {
            book.Id = Guid.NewGuid();
            _bookRepository.CreateAsync(book);
        }

        public void UpdateBookAsync(Book book)
        {
            _bookRepository.UpdateAsync(book);
        }

        public async Task DeleteBookAsync(Guid id)
        {
            var book = _bookRepository.Get(id);

            _bookRepository.DeleteAsync(book);
        }
    }
}
