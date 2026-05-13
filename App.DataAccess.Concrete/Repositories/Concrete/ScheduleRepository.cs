namespace App.DataAccess.Concrete.Repositories.Concrete
{
    public class ScheduleRepository : GenericRepository<Schedule>, IScheduleRepository
    {
        public ScheduleRepository(BookAFlightAppDbContext db) : base(db) { }

        public async Task<Schedule> IncludeGetFirstOrDefaultAsync(Expression<Func<Schedule, bool>> expression, Expression<Func<Schedule, object>> include, bool tracking = true) =>
            await GetAllByStatusIsNotDeletedByTracking(tracking).Include(include).FirstOrDefaultAsync(expression);

        public async Task<IEnumerable<Schedule>> IncludeGetAllWhereAsync(Expression<Func<Schedule, bool>> expression, Expression<Func<Schedule, object>> include, Expression<Func<Schedule, object>> orderby, bool tracking = true) =>
            await GetAllByStatusIsNotDeletedByTracking(tracking).Include(include).Where(expression).OrderBy(orderby).ToListAsync();
    }
}