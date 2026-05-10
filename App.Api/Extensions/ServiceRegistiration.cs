namespace App.Api.Extensions
{
    public static class ServiceRegistiration
    {
        public static IServiceCollection AddApiServices(this IServiceCollection services)
        {
            services.AddFluentValidationAutoValidation().AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddLocalization();

            services.AddCors(opt => opt.AddPolicy("BookAFlightAppCors", options => { options.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod(); }));

            services.AddControllers().AddNewtonsoftJson(options =>
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

            return services;
        }

        public static IApplicationBuilder AddUseRequestLocalizationApplicationBuilder(this IApplicationBuilder applicationBuilder)
        {
            var supportedCultures = new[]
            {
                new CultureInfo("en-US"), new CultureInfo("tr-TR")
            };

            var requestLocalizationOptions = new RequestLocalizationOptions
            {
                ApplyCurrentCultureToResponseHeaders = true,
                DefaultRequestCulture = new RequestCulture("tr-TR"),
                SupportedCultures = supportedCultures,
                SupportedUICultures = supportedCultures
            };

            applicationBuilder.UseRequestLocalization(requestLocalizationOptions);

            return applicationBuilder;
        }
    }
}