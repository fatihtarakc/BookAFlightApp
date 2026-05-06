namespace App.DataAccess.Abstract.Repositories.Abstract
{
    public interface IAirportRepository :
        IAsyncAddableRepository<Airport>, IAsyncDeletableRepository<Airport>, IAsyncUpdatableRepository<Airport>,
        IAsyncQueryableRepository<Airport>, IAsyncOrderableRepository<Airport>
    {
        Task<Airport> IncludeGetFirstOrDefaultAsync(Expression<Func<Airport, bool>> expression, Expression<Func<Airport, object>> include, bool tracking = true);

        Task<IEnumerable<Airport>> IncludeGetAllWhereAsync(Expression<Func<Airport, bool>> expression, Expression<Func<Airport, object>> include, Expression<Func<Airport, object>> orderby, bool tracking = true);
    }
}