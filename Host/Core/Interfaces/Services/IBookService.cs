using Host.Core.Entities;

namespace Host.Core.Interfaces.Services
{
    public interface IBookService
    {
        Task<Book> GetByIdAsync(Guid bookId);
        Task<IEnumerable<Book?>> GetAllAsync();
        Task CreateAsync(Book? book);
        void Update(Book book);
        Task DeleteAsync(Guid bookId);
    }
}
