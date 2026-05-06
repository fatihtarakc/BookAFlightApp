namespace App.DataAccess.Concrete.Repositories.Concrete
{
    public class AirportRepository : GenericRepository<Airport>, IAirportRepository
    {
        public AirportRepository(BookAFlightAppDbContext db) : base(db) { }

        public async Task<Airport> IncludeGetFirstOrDefaultAsync(Expression<Func<Airport, bool>> expression, Expression<Func<Airport, object>> include, bool tracking = true) =>
            await GetAllByStatusIsNotDeletedByTracking(tracking).Include(include).FirstOrDefaultAsync(expression);

        public async Task<IEnumerable<Airport>> IncludeGetAllWhereAsync(Expression<Func<Airport, bool>> expression, Expression<Func<Airport, object>> include, Expression<Func<Airport, object>> orderby, bool tracking = true) =>
            await GetAllByStatusIsNotDeletedByTracking(tracking).Include(include).Where(expression).OrderBy(orderby).ToListAsync();
    }
}