using Host.BLL;
using Host.Core.Interfaces.Repositories;
using Host.Core.Interfaces.Services;
using Host.DAL;

namespace Host.Extensions
{
  public static class IServiceCollectionExtensions
  {
    public static void AddApplicationServices(this IServiceCollection services)
    {
      services.AddScoped<IBookService, BookService>();
    }

    public static void AddApplicationRepositories(this IServiceCollection services)
    {
      services.AddScoped<IBookRepository, BookRepository>();
    }
  }
}