namespace App.DataAccess.Concrete.Repositories.Concrete
{
    public class RouteRepository : GenericRepository<Route>, IRouteRepository
    {
        public RouteRepository(BookAFlightAppDbContext db) : base(db) { }

        public async Task<Route> IncludeGetFirstOrDefaultAsync(Expression<Func<Route, bool>> expression, Expression<Func<Route, object>> include, bool tracking = true) =>
            await GetAllByStatusIsNotDeletedByTracking(tracking).Include(include).FirstOrDefaultAsync(expression);

        public async Task<IEnumerable<Route>> IncludeGetAllWhereAsync(Expression<Func<Route, bool>> expression, Expression<Func<Route, object>> include, Expression<Func<Route, object>> orderby, bool tracking = true) =>
            await GetAllByStatusIsNotDeletedByTracking(tracking).Include(include).Where(expression).OrderBy(orderby).ToListAsync();
    }
}