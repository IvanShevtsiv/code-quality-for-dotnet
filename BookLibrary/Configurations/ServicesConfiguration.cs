using BookLibrary.Services;

namespace BookLibrary.Configurations
{
    public static class ServicesConfiguration
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IBookService, BookService>();
        }
    }
}
