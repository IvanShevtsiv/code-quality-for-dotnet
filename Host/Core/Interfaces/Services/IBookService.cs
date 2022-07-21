using Host.Core.Entities;

namespace Host.Core.Interfaces.Services
{
    public interface IBookService
    {
        Book Get(Guid id);
        IEnumerable<Book> Get();
        void Create(Book book);
        void Update(Book book);
        void Delete(Guid id);
    }
}
