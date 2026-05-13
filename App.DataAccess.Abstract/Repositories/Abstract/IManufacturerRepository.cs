namespace App.DataAccess.Abstract.Repositories.Abstract
{
    public interface IManufacturerRepository :
        IAsyncAddableRepository<Manufacturer>, IAsyncDeletableRepository<Manufacturer>, IAsyncUpdatableRepository<Manufacturer>,
        IAsyncQueryableRepository<Manufacturer>, IAsyncOrderableRepository<Manufacturer>
    {
        Task<Manufacturer> IncludeGetFirstOrDefaultAsync(Expression<Func<Manufacturer, bool>> expression, Expression<Func<Manufacturer, object>> include, bool tracking = true);

        Task<IEnumerable<Manufacturer>> IncludeGetAllWhereAsync(Expression<Func<Manufacturer, bool>> expression, Expression<Func<Manufacturer, object>> include, Expression<Func<Manufacturer, object>> orderby, bool tracking = true);
    }
}