using Host.Core.Entities;

namespace Host.Core.Interfaces.Repositories
{
    public interface IBookRepository
    {
        Book Get(Guid id);
        IEnumerable<Book> Get();
        void Create(Book book);
        void Update(Book book);
        void DeleteById(Guid id);
    }
}
