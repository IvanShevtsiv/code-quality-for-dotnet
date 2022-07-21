using BookLibrary.Repositories;

namespace BookLibrary.Configurations
{
    public static class RepositoryConfiguration
    {
        public static void AddApplicationRepository(this IServiceCollection services)
        {
            services.AddSingleton(new DataContext());
            services.AddScoped<IBookRepository, BookRepository>();
        }
    }
}
