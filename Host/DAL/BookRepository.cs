using Host.Core.Entities;
using Host.Core.Interfaces.Repositories;

namespace Host.DAL
{
    public class BookRepository : IBookRepository
    {
        public Book Get(Guid id)
        {
            return DataBase.books
                   .Where(x => x.Id == id)
                   .FirstOrDefault();
        }

        public IEnumerable<Book> Get()
        {
            return DataBase.books;
        }

        public void CreateAsync(Book book)
        {
            DataBase.books.Add(book);
        }

        public void UpdateAsync(Book book)
        {
            var bookInDB = Get(book.Id);

            if (bookInDB == null)
            {
                throw new Exception($"Can not update the book.");
            }
        }

        public void DeleteAsync(Book book)
        {
            DataBase.books.Remove(book);
        }
    }
}
