namespace App.DataAccess.Concrete.Repositories.Concrete
{
    public class AirlineRepository : GenericRepository<Airline>, IAirlineRepository
    {
        public AirlineRepository(BookAFlightAppDbContext db) : base(db) { }

        public async Task<Airline> IncludeGetFirstOrDefaultAsync(Expression<Func<Airline, bool>> expression, Expression<Func<Airline, object>> include, bool tracking = true) =>
            await GetAllByStatusIsNotDeletedByTracking(tracking).Include(include).FirstOrDefaultAsync(expression);

        public async Task<IEnumerable<Airline>> IncludeGetAllWhereAsync(Expression<Func<Airline, bool>> expression, Expression<Func<Airline, object>> include, Expression<Func<Airline, object>> orderby, bool tracking = true) =>
            await GetAllByStatusIsNotDeletedByTracking(tracking).Include(include).Where(expression).OrderBy(orderby).ToListAsync();
    }
}