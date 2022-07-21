using Host.Core.Entities;

namespace Host.Core.Interfaces.Services
{
    public interface IBookService
    {
        Task<Book> GetAsync(Guid id);
        Task<IEnumerable<Book>> GetAsync();
        Task CreateAsync(Book book);
        Task UpdateAsync(Book book);
        Task DeleteAsync(Guid id);
    }
}
