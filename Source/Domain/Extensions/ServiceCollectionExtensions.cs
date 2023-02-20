using Microsoft.Extensions.DependencyInjection;

namespace TreeDeliveryApp.Domain.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDomain(this IServiceCollection services)
        {
            services.AddSingleton<ITreeDataProvider, TreeDataProvider>();

            return services;
        }
    }
}
