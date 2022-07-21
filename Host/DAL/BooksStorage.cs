using Host.Core.Entities;

namespace Host.DAL
{
    public static class BooksStorage
    {
        private static readonly Author[] authors = new[]
        {
            new Author
            {
                Id = 1,
                FullName = "Taras Shevchenko"
            },
            new Author
            {
                Id = 2,
                FullName = "Lesya Ukrainka"
            },
            new Author
            {
                Id = 3,
                FullName = "Ivan Franko"
            }
        };

        public static List<Book> Books = new List<Book>
        {
            new Book
            {
                Id = Guid.NewGuid(),
                Name = "Kobzar",
                Description = "The collection contains the most famous works and the writer's diary.",
                Author = authors[0]
            },
            new Book
            {
                Id = Guid.NewGuid(),
                Name = "Prophet",
                Description = "A collection of the most famous Poems of Taras Hryhorovych Shevchenko.",
                Author = authors[0]
            },
            new Book
            {
                Id = Guid.NewGuid(),
                Name = "Forest Song",
                Description = "Lesya Ukrainka's poetry and plays became our whole planet of hopes, because the creator's imperishable word reached the top of the human spirit.",
                Author = authors[1]
            },
            new Book
            {
                Id = Guid.NewGuid(),
                Name = "Forest Song",
                Description = "Lesya Ukrainka's poetry and plays became our whole planet of hopes, because the creator's imperishable word reached the top of the human spirit.",
                Author = authors[1]
            },
            new Book
            {
                Id = Guid.NewGuid(),
                Name = "Contra spem spero",
                Description = "a life-affirming poem, in which the main motive is tempering the spirit, nurturing inner indomitability.",
                Author = authors[2]
            },
            new Book
            {
                Id = Guid.NewGuid(),
                Name = "Obsessed",
                Description = "a psychological-philosophical drama based on the plot of the arrest and crucifixion of Jesus Christ.",
                Author = authors[2]
            },
            new Book
            {
                Id = Guid.NewGuid(),
                Name = "Fireplace master",
                Description = "the first play in Ukrainian literature that depicts a man-seducer. The plot is based on a traditional world theme, the author presents her own interpretation.",
                Author = authors[2]
            },
            new Book
            {
                Id = Guid.NewGuid(),
                Name = "Zakhar Berkut",
                Description = "In ancient times, when people were different and the earth was more powerful. And there lived at that time a famous leader of the free Tukhol people.",
                Author = authors[2]
            },
            new Book
            {
                Id = Guid.NewGuid(),
                Name = "Cross paths",
                Description = "One of the first modernist works in Ukrainian literature. Against the background of the social and political life of Galicia at the end of the 19th century.",
                Author = authors[2]
            },
            new Book
            {
                Id = Guid.NewGuid(),
                Name = "Ukraine is independent",
                Description = "Ivan Franko was one of the first to set the goal of gaining independence for Ukraine, he wittily and thoroughly breaks all Marxist myths, proves the second nature and plagiarism of Marxist theories..",
                Author = authors[2]
            }
        };
    }
}
