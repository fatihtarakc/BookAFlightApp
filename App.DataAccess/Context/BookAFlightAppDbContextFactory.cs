namespace App.DataAccess.Context
{
    public class BookAFlightAppDbContextFactory : IDesignTimeDbContextFactory<BookAFlightAppDbContext>
    {
        public BookAFlightAppDbContext CreateDbContext(string[] args)
        {
            var host = Host.CreateDefaultBuilder(args).Build();
            var configuration = host.Services.GetRequiredService<IConfiguration>();
            var connectionOptions = configuration.GetSection(ConnectionOptions.Connections).Get<ConnectionOptions>();

            var dbContextOptionsBuilder = new DbContextOptionsBuilder<BookAFlightAppDbContext>();
            dbContextOptionsBuilder.UseSqlServer(connectionOptions?.MssqlServer);

            return new BookAFlightAppDbContext(dbContextOptionsBuilder.Options);
        }
    }
}