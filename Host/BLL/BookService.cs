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

        public Book GetById(Guid id)
        {
            var book  = _bookRepository.GetById(id);

            if (book == null)
            {
                throw new Exception($"Book with Id {id} could not be found");
            }

            return book;
        }

        public IEnumerable<Book> GetAll()
        {
            var books = _bookRepository.GetAll();
            return books;
        }

        public Book Create(Book book)
        {
            book.Id = Guid.NewGuid();
            var newBook = _bookRepository.Create(book);
            
            return newBook;
        }

        public void Update(Book book)
        {
            _bookRepository.Update(book);
        }

        public void Delete(Guid id)
        {
            var book = _bookRepository.GetById(id);

            if (book == null)
            {
                throw new Exception($"Book with Id {id} could not be found");
            }

            _bookRepository.Delete(book);
        }
    }
}
