namespace App.DataAccess.Abstract.Repositories.Abstract
{
    public interface IScheduleRepository :
        IAsyncAddableRepository<Schedule>, IAsyncDeletableRepository<Schedule>, IAsyncUpdatableRepository<Schedule>,
        IAsyncQueryableRepository<Schedule>, IAsyncOrderableRepository<Schedule>
    {
        Task<Schedule> IncludeGetFirstOrDefaultAsync(Expression<Func<Schedule, bool>> expression, Expression<Func<Schedule, object>> include, bool tracking = true);

        Task<IEnumerable<Schedule>> IncludeGetAllWhereAsync(Expression<Func<Schedule, bool>> expression, Expression<Func<Schedule, object>> include, Expression<Func<Schedule, object>> orderby, bool tracking = true);
    }
}