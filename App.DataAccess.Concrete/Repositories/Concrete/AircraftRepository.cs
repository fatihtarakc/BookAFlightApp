namespace App.DataAccess.Concrete.Repositories.Concrete
{
    public class AircraftRepository : GenericRepository<Aircraft>, IAircraftRepository
    {
        public AircraftRepository(BookAFlightAppDbContext db) : base(db) { }

        public async Task<Aircraft> IncludeGetFirstOrDefaultAsync(Expression<Func<Aircraft, bool>> expression, Expression<Func<Aircraft, object>> include, bool tracking = true) =>
            await GetAllByStatusIsNotDeletedByTracking(tracking).Include(include).FirstOrDefaultAsync(expression);

        public async Task<IEnumerable<Aircraft>> IncludeGetAllWhereAsync(Expression<Func<Aircraft, bool>> expression, Expression<Func<Aircraft, object>> include, Expression<Func<Aircraft, object>> orderby, bool tracking = true) =>
            await GetAllByStatusIsNotDeletedByTracking(tracking).Include(include).Where(expression).OrderBy(orderby).ToListAsync();
    }
}