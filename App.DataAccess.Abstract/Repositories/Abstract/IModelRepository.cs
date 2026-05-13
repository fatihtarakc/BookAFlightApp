namespace App.DataAccess.Abstract.Repositories.Abstract
{
    public interface IModelRepository :
        IAsyncAddableRepository<Model>, IAsyncDeletableRepository<Model>, IAsyncUpdatableRepository<Model>,
        IAsyncQueryableRepository<Model>, IAsyncOrderableRepository<Model>
    {
        Task<Model> IncludeGetFirstOrDefaultAsync(Expression<Func<Model, bool>> expression, Expression<Func<Model, object>> include, bool tracking = true);

        Task<IEnumerable<Model>> IncludeGetAllWhereAsync(Expression<Func<Model, bool>> expression, Expression<Func<Model, object>> include, Expression<Func<Model, object>> orderby, bool tracking = true);
    }
}