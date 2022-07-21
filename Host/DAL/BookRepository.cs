using Host.Core.Entities;
using Host.Core.Interfaces.Repositories;

namespace Host.DAL
{
    public class BookRepository : IBookRepository
    {
        public Book? GetById(Guid id)
        {
            var book = DataBase.Books.FirstOrDefault(x => x.Id == id);

            return book;
        }

        public IEnumerable<Book> GetAll()
        {
            return DataBase.Books;
        }

        public Book Create(Book book)
        {
            DataBase.Books.Add(book);

            return book;
        }

        public void Update(Book book)
        {
            var bookInDB = GetById(book.Id);

            if (bookInDB == null)
            {
                throw new Exception($"Can not update the book with provided id: {book.Id}");
            }

            // TODO! Add mechanism for update. TASK #number
        }

        public void Delete(Book book)
        {
            DataBase.Books.Remove(book);
        }
    }
}
