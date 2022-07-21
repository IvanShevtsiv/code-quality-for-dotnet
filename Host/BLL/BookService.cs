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

        public async Task<Book> GetAsync(Guid id)
        {
            var book = await _bookRepository.GetAsync(id);

            if (book == null)
            {
                throw new Exception($"Book with Id {id} could not be found");
            }

            return book;
        }

        public async Task<IEnumerable<Book>> GetAsync()
        {
            return await _bookRepository.GetAsync();
        }

        public async Task CreateAsync(Book book)
        {
            book.Id = Guid.NewGuid();
            await _bookRepository.CreateAsync(book);
        }

        public async Task  UpdateAsync(Book book)
        {
            await _bookRepository.UpdateAsync(book);
        }

        public async Task DeleteAsync(Guid id)
        {
            var book = await  _bookRepository.GetAsync(id);

            if (book == null)
            {
                throw new Exception($"Book with Id {id} could not be found");
            }

            await _bookRepository.DeleteAsync(book);
        }
    }
}
