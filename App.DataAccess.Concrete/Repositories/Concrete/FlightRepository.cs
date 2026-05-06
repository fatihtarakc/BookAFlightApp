namespace App.DataAccess.Concrete.Repositories.Concrete
{
    public class FlightRepository : GenericRepository<Flight>, IFlightRepository
    {
        public FlightRepository(BookAFlightAppDbContext db) : base(db) { }

        public async Task<Flight> IncludeGetFirstOrDefaultAsync(Expression<Func<Flight, bool>> expression, Expression<Func<Flight, object>> include, bool tracking = true) =>
            await GetAllByStatusIsNotDeletedByTracking(tracking).Include(include).FirstOrDefaultAsync(expression);

        public async Task<IEnumerable<Flight>> IncludeGetAllWhereAsync(Expression<Func<Flight, bool>> expression, Expression<Func<Flight, object>> include, Expression<Func<Flight, object>> orderby, bool tracking = true) =>
            await GetAllByStatusIsNotDeletedByTracking(tracking).Include(include).Where(expression).OrderBy(orderby).ToListAsync();
    }
}