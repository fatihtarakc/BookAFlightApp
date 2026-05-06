namespace App.DataAccess.Abstract.Repositories.Abstract
{
    public interface IRouteRepository :
        IAsyncAddableRepository<Route>, IAsyncDeletableRepository<Route>, IAsyncUpdatableRepository<Route>,
        IAsyncQueryableRepository<Route>, IAsyncOrderableRepository<Route>
    {
        Task<Route> IncludeGetFirstOrDefaultAsync(Expression<Func<Route, bool>> expression, Expression<Func<Route, object>> include, bool tracking = true);

        Task<IEnumerable<Route>> IncludeGetAllWhereAsync(Expression<Func<Route, bool>> expression, Expression<Func<Route, object>> include, Expression<Func<Route, object>> orderby, bool tracking = true);
    }
}