namespace App.DataAccess.Concrete.Repositories.Concrete
{
    public class BookingRepository : GenericRepository<Booking>, IBookingRepository
    {
        public BookingRepository(BookAFlightAppDbContext db) : base(db) { }

        public async Task<Booking> IncludeGetFirstOrDefaultAsync(Expression<Func<Booking, bool>> expression, Expression<Func<Booking, object>> include, bool tracking = true) =>
            await GetAllByStatusIsNotDeletedByTracking(tracking).Include(include).FirstOrDefaultAsync(expression);

        public async Task<IEnumerable<Booking>> IncludeGetAllWhereAsync(Expression<Func<Booking, bool>> expression, Expression<Func<Booking, object>> include, Expression<Func<Booking, object>> orderby, bool tracking = true) =>
            await GetAllByStatusIsNotDeletedByTracking(tracking).Include(include).Where(expression).OrderBy(orderby).ToListAsync();
    }
}