namespace App.Cache.Extensions
{
    public static class ServiceRegistiration
    {
        public static IServiceCollection AddCacheServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped((typeof(ICacheService<>)), typeof(CacheService<>));

            var connectionOptions = configuration.GetSection(ConnectionOptions.Connections).Get<ConnectionOptions>();
            services.AddStackExchangeRedisCache(options =>
            {
                options.Configuration = configuration.GetConnectionString(connectionOptions.Redis);
                options.InstanceName = "BookAFlightAppDb-Redis";
            });

            return services;
        }
    }
}