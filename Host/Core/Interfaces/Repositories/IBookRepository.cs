using Host.Core.Entities;

namespace Host.Core.Interfaces.Repositories
{
    public interface IBookRepository
    {
        Book? GetById(Guid id);

        IEnumerable<Book> GetAll();

        Book Create(Book book);

        void Update(Book book);

        void Delete(Book obj);
    }
}
