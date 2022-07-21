using Host.Core.Entities;
using Host.Core.Interfaces.Repositories;

namespace Host.DAL
{
    public class BookRepository : IBookRepository
    {
        public async Task<Book> GetAsync(Guid id)
        {
            await Task.CompletedTask;

            return DataBase.books
                   .Where(x => x.Id == id)
                   .FirstOrDefault();
        }

        public async Task<IEnumerable<Book>> GetAsync()
        {
            await Task.CompletedTask;

            return DataBase.books;
        }

        public async Task CreateAsync(Book book)
        {
            await Task.CompletedTask;

            DataBase.books.Add(book);
        }

        public async Task UpdateAsync(Book book)
        {
            var bookInDB = await GetAsync(book.Id);

            if (bookInDB == null)
            {
                throw new Exception($"Can not update the book.");
            }
        }

        public async Task DeleteAsync(Book book)
        {
            await Task.CompletedTask;
            
            DataBase.books.Remove(book);
        }
    }
}
