using Host.Core.Entities;

namespace Host.DAL;

public static class DataBase
{
    private static readonly Author author1 = new(1, "Taras Shevchenko");

    private static readonly Author author2 = new(2, "Lesya Ukrainka");

    private static readonly Author author3 = new(3, "Ivan Franko");

    public static List<Book> Books = new()
    {
        new Book("Kobzar", author1)
        {
            Description = "The collection contains the most famous works and the writer's diary.",
        },
        new Book("Prophet", author1)
        {
            Description = "A collection of the most famous Poems of Taras Hryhorovych Shevchenko.",
        },
        new Book("Forest song", author2)
        {
            Description = "Lesya Ukrainka's poetry and plays became our whole planet of hopes, because the creator's imperishable word reached the top of the human spirit.",
        },
        new Book("Ukraine is independent", author3)
        {
            Description = "Ivan Franko was one of the first to set the goal of gaining independence for Ukraine, he wittily and thoroughly breaks all Marxist myths, proves the second nature and plagiarism of Marxist theories..",
        }
    };
}