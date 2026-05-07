namespace App.Business.Extensions
{
    public static class ServiceRegistiration
    {
        public static IServiceCollection AddBusinessConcreteServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IAdminService, AdminService>();
            services.AddScoped<IAircraftService, AircraftService>();
            services.AddScoped<IAirportService, AirportService>();
            services.AddScoped<IAppUserService, AppUserService>();
            services.AddScoped<IBookingService, BookingService>();
            services.AddScoped<IEmailService, EmailService>();
            services.AddScoped<IFlightService, FlightService>();
            services.AddScoped<IRouteService, RouteService>();
            services.AddScoped<ISeatService, SeatService>();

            services.Configure<EmailOptions>
                (configuration.GetSection(EmailOptions.EmailConfiguraiton));

            return services;
        }
    }
}