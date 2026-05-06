namespace App.DataAccess.Abstract.Repositories.Abstract
{
    public interface IBookingRepository :
        IAsyncAddableRepository<Booking>, IAsyncDeletableRepository<Booking>, IAsyncUpdatableRepository<Booking>,
        IAsyncQueryableRepository<Booking>, IAsyncOrderableRepository<Booking>
    {
        Task<Booking> IncludeGetFirstOrDefaultAsync(Expression<Func<Booking, bool>> expression, Expression<Func<Booking, object>> include, bool tracking = true);

        Task<IEnumerable<Booking>> IncludeGetAllWhereAsync(Expression<Func<Booking, bool>> expression, Expression<Func<Booking, object>> include, Expression<Func<Booking, object>> orderby, bool tracking = true);
    }
}