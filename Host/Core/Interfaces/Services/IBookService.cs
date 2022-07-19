using Host.Core.Entities;

namespace Host.Core.Interfaces.Services
{
    public interface IBookService
    {
        Task<Book> Get(Guid id);
        Task<IEnumerable<Book>> Get();
        Task CreateAsync(Book book);
        void UpdateAsync(Book book);
        Task DeleteAsync(Guid id);
    }
}
