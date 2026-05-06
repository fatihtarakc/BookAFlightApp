namespace App.DataAccess.Abstract.Repositories.Abstract
{
    public interface ISeatRepository :
        IAsyncAddableRepository<Seat>, IAsyncDeletableRepository<Seat>, IAsyncUpdatableRepository<Seat>,
        IAsyncQueryableRepository<Seat>, IAsyncOrderableRepository<Seat>
    {
        Task<Seat> IncludeGetFirstOrDefaultAsync(Expression<Func<Seat, bool>> expression, Expression<Func<Seat, object>> include, bool tracking = true);

        Task<IEnumerable<Seat>> IncludeGetAllWhereAsync(Expression<Func<Seat, bool>> expression, Expression<Func<Seat, object>> include, Expression<Func<Seat, object>> orderby, bool tracking = true);
    }
}