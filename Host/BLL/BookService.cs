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

    public Book Get(Guid id)
    {
      var book = _bookRepository.Get(id);
      return book;
    }

    public IEnumerable<Book> Get()
    {
      var books = _bookRepository.Get();
      return books;
    }

    public void Create(Book book)
    {
      book.Id = Guid.NewGuid();
      _bookRepository.Create(book);
    }

    public void Update(Book book)
    {
      _bookRepository.Update(book);
    }

    public void Delete(Guid id)
    {
      var book = _bookRepository.Get(id);
      _bookRepository.DeleteById(book.Id);
    }
  }
}