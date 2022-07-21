using Host.Core.Entities;
using Host.Core.Exceptions;
using Host.Core.Interfaces.Repositories;

namespace Host.DAL
{
  public class BookRepository : IBookRepository
  {
    public Book Get(Guid id)
    {
      var book = DataBase.books.FirstOrDefault(x => x.Id == id);
      if (book == null)
        throw new EntityDoesntExistInDatabaseException(book.Id);
      
      return book;
    }

    public IEnumerable<Book> Get()
    {
      var books = DataBase.books;
      return books;
    }

    public void Create(Book book)
    {
      DataBase.books.Add(book);
    }

    public void Update(Book book)
    {
      var existingBook = Get(book.Id);

      if (existingBook == null)
        throw new EntityDoesntExistInDatabaseException(book.Id);

      existingBook.Author = book.Author;
      existingBook.Description = book.Description;
      existingBook.Name = book.Name;
      
      var index = DataBase.books.FindIndex(b => b.Id == book.Id);
      DataBase.books[index] = existingBook;
    }

    public void DeleteById(Guid bookId)
    {
      var existingBook = DataBase.books.FirstOrDefault(b => b.Id == bookId);
      if(existingBook == null)
        throw new EntityDoesntExistInDatabaseException(bookId);
      
      DataBase.books.Remove(existingBook);
    }
  }

  public static class DataBase
  {
    static Author TShevcheko = new Author
    {
      id = 1,
      FullName = "Taras Shevchenko"
    };

    static Author LUkrainka = new Author
    {
      id = 2,
      FullName = "Lesya Ukrainka"
    };

    static Author IFranko = new Author
    {
      id = 3,
      FullName = "Ivan Franko"
    };

    public static List<Book> books = new List<Book>
    {
      new Book
      {
        Id = Guid.NewGuid(),
        Name = "Kobzar",
        Description = "The collection contains the most famous works and the writer's diary.",
        Author = TShevcheko
      },
      new Book
      {
        Id = Guid.NewGuid(),
        Name = "Prophet",
        Description = "A collection of the most famous Poems of Taras Hryhorovych Shevchenko.",
        Author = TShevcheko
      },
      new Book
      {
        Id = Guid.NewGuid(),
        Name = "Forest Song",
        Description = "Lesya Ukrainka's poetry and plays became our whole planet of hopes, because the creator's imperishable word reached the top of the human spirit.",
        Author = LUkrainka
      },
      new Book
      {
        Id = Guid.NewGuid(),
        Name = "Contra spem spero",
        Description = "a life-affirming poem, in which the main motive is tempering the spirit, nurturing inner indomitability.",
        Author = LUkrainka
      },
      new Book
      {
        Id = Guid.NewGuid(),
        Name = "Obsessed",
        Description = "a psychological-philosophical drama based on the plot of the arrest and crucifixion of Jesus Christ.",
        Author = LUkrainka
      },
      new Book
      {
        Id = Guid.NewGuid(),
        Name = "Fireplace master",
        Description = "the first play in Ukrainian literature that depicts a man-seducer. The plot is based on a traditional world theme, the author presents her own interpretation.",
        Author = LUkrainka
      },
      new Book
      {
        Id = Guid.NewGuid(),
        Name = "Zakhar Berkut",
        Description = "In ancient times, when people were different and the earth was more powerful. And there lived at that time a famous leader of the free Tukhol people.",
        Author = IFranko
      },
      new Book
      {
        Id = Guid.NewGuid(),
        Name = "Cross paths",
        Description = "One of the first modernist works in Ukrainian literature. Against the background of the social and political life of Galicia at the end of the 19th century.",
        Author = IFranko
      },
      new Book
      {
        Id = Guid.NewGuid(),
        Name = "Ukraine is independent",
        Description = "Ivan Franko was one of the first to set the goal of gaining independence for Ukraine, he wittily and thoroughly breaks all Marxist myths, proves the second nature and plagiarism of Marxist theories..",
        Author = IFranko
      },
    };
  }
}