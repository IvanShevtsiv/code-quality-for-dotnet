using Host.Core.Entities;

namespace Host.Core.Interfaces.Repositories
{
    public interface IBookRepository
    {
        Book Get(Guid id);
        IEnumerable<Book> Get();
        void CreateAsync(Book book);
        void UpdateAsync(Book book);
        void DeleteAsync(Book obj);
    }
}
