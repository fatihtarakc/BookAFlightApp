namespace App.DataAccess.Concrete.Extensions
{
    public static class ServiceRegistiration
    {
        public static IServiceCollection AddDataAccessConcreteServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IAdminRepository, AdminRepository>();
            services.AddScoped<IAircraftRepository, AircraftRepository>();
            services.AddScoped<IAirportRepository, AirportRepository>();
            services.AddScoped<IAppUserRepository, AppUserRepository>();
            services.AddScoped<IBookingRepository, BookingRepository>();
            services.AddScoped<IFlightRepository, FlightRepository>();
            services.AddScoped<IRouteRepository, RouteRepository>();
            services.AddScoped<ISeatRepository, SeatRepository>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            var serviceProvider = services.BuildServiceProvider();
            var userManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();
            var iOptionsConnectionOptions = serviceProvider.GetRequiredService<IOptions<ConnectionOptions>>();
            AdminSeedData.AddAsync(configuration, iOptionsConnectionOptions, userManager).GetAwaiter().GetResult();

            return services;
        }
    }
}