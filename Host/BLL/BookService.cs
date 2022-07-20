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

        public Task<Book> GetByIdAsync(Guid bookId)
        {
            var book  = _bookRepository.Get(bookId);

            if (book == null)
            {
                throw new Exception($"Book with Id {bookId} could not be found");
            }
            
            return Task.FromResult(book);
        }

        public Task<IEnumerable<Book?>> GetAllAsync()
        {
            return Task.FromResult(_bookRepository.GetAll());
        }

        public Task CreateAsync(Book? book)
        {
            book.Id = Guid.NewGuid();
            _bookRepository.Create(book);
            
            return  Task.CompletedTask;
        }

        public void Update(Book book)
        {
            _bookRepository.Update(book);
        }

        public Task DeleteAsync(Guid bookId)
        {
            var book = _bookRepository.Get(bookId);

            if (book == null)
            {
                throw new Exception($"Book with Id {bookId} could not be found");
            }
            
            _bookRepository.Delete(book);
            
            return  Task.CompletedTask;
        }
    }
}
