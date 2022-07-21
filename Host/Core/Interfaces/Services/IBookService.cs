using Host.Core.Entities;

namespace Host.Core.Interfaces.Services
{
    public interface IBookService
    {
        Book? GetById(Guid id);

        IEnumerable<Book> GetAll();

        Book Create(Book book);

        void Update(Book book);

        void Delete(Guid id);
    }
}
