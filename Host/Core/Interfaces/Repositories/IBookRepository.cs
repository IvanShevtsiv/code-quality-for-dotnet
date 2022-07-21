using Host.Core.Entities;

namespace Host.Core.Interfaces.Repositories
{
    public interface IBookRepository
    {
        Task<Book> GetAsync(Guid id);
        Task<IEnumerable<Book>> GetAsync();
        Task CreateAsync(Book book);
        Task UpdateAsync(Book book);
        Task DeleteAsync(Book obj);
    }
}
