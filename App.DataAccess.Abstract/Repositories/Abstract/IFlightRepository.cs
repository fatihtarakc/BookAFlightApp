namespace App.DataAccess.Abstract.Repositories.Abstract
{
    public interface IFlightRepository :
        IAsyncAddableRepository<Flight>, IAsyncDeletableRepository<Flight>, IAsyncUpdatableRepository<Flight>,
        IAsyncQueryableRepository<Flight>, IAsyncOrderableRepository<Flight>
    {
        Task<Flight> IncludeGetFirstOrDefaultAsync(Expression<Func<Flight, bool>> expression, Expression<Func<Flight, object>> include, bool tracking = true);

        Task<IEnumerable<Flight>> IncludeGetAllWhereAsync(Expression<Func<Flight, bool>> expression, Expression<Func<Flight, object>> include, Expression<Func<Flight, object>> orderby, bool tracking = true);
    }
}