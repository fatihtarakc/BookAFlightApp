namespace App.DataAccess.Abstract.Repositories.Abstract
{
    public interface IAircraftRepository :
        IAsyncAddableRepository<Aircraft>, IAsyncDeletableRepository<Aircraft>, IAsyncUpdatableRepository<Aircraft>,
        IAsyncQueryableRepository<Aircraft>, IAsyncOrderableRepository<Aircraft>
    {
        Task<Aircraft> IncludeGetFirstOrDefaultAsync(Expression<Func<Aircraft, bool>> expression, Expression<Func<Aircraft, object>> include, bool tracking = true);

        Task<IEnumerable<Aircraft>> IncludeGetAllWhereAsync(Expression<Func<Aircraft, bool>> expression, Expression<Func<Aircraft, object>> include, Expression<Func<Aircraft, object>> orderby, bool tracking = true);
    }
}