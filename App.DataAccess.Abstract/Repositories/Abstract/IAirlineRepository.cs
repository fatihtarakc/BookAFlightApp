namespace App.DataAccess.Abstract.Repositories.Abstract
{
    public interface IAirlineRepository :
        IAsyncAddableRepository<Airline>, IAsyncDeletableRepository<Airline>, IAsyncUpdatableRepository<Airline>,
        IAsyncQueryableRepository<Airline>, IAsyncOrderableRepository<Airline>
    {
        Task<Airline> IncludeGetFirstOrDefaultAsync(Expression<Func<Airline, bool>> expression, Expression<Func<Airline, object>> include, bool tracking = true);

        Task<IEnumerable<Airline>> IncludeGetAllWhereAsync(Expression<Func<Airline, bool>> expression, Expression<Func<Airline, object>> include, Expression<Func<Airline, object>> orderby, bool tracking = true);
    }
}