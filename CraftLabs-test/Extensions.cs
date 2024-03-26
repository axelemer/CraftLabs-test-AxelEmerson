using CraftLabs.DataAccess.Implementations.Contracts;
using CraftLabs.DataAccess.Implementations.Repositories;
using CraftLabs.Implementations.Contracts.Contracts;
using CraftLabs.Implementations.Implementations;

namespace CraftLabs_test
{
    public static class Extensions
    {
        public static void SetServices(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();

            services.AddScoped<IProductRepository, ProductRepository>();
        }

    }
}
