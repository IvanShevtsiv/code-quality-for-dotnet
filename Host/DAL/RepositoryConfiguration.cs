using Host.Core.Interfaces.Repositories;

namespace Host.DAL
{
    public static class RepositoryConfiguration
    {
        public static void AddApplicationRepository(this IServiceCollection services)
        {
            services.AddScoped<IBookRepository, BookRepository>();
        }
    }
}
