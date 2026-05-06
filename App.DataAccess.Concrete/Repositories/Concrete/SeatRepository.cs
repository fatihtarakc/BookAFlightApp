namespace App.DataAccess.Concrete.Repositories.Concrete
{
    public class SeatRepository : GenericRepository<Seat>, ISeatRepository
    {
        public SeatRepository(BookAFlightAppDbContext db) : base(db) { }

        public async Task<Seat> IncludeGetFirstOrDefaultAsync(Expression<Func<Seat, bool>> expression, Expression<Func<Seat, object>> include, bool tracking = true) =>
            await GetAllByStatusIsNotDeletedByTracking(tracking).Include(include).FirstOrDefaultAsync(expression);

        public async Task<IEnumerable<Seat>> IncludeGetAllWhereAsync(Expression<Func<Seat, bool>> expression, Expression<Func<Seat, object>> include, Expression<Func<Seat, object>> orderby, bool tracking = true) =>
            await GetAllByStatusIsNotDeletedByTracking(tracking).Include(include).Where(expression).OrderBy(orderby).ToListAsync();
    }
}