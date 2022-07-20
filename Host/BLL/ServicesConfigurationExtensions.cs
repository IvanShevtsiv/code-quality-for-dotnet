using Host.Core.Interfaces.Services;

namespace Host.BLL
{
    public static class ServicesConfigurationExtensions
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IBookService, BookService>();
        }
    }
}
