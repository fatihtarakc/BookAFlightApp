namespace App.DataAccess.Abstract.Repositories.Abstract
{
    public interface IAppUserRepository :
        IAsyncAddableRepository<AppUser>, IAsyncDeletableRepository<AppUser>, IAsyncUpdatableRepository<AppUser>,
        IAsyncQueryableRepository<AppUser>, IAsyncOrderableRepository<AppUser>
    {
        Task<AppUser> GetByIdentityIdAsync(string identityId);

        Task<AppUser> IncludeGetFirstOrDefaultAsync(Expression<Func<AppUser, bool>> expression, Expression<Func<AppUser, object>> include, bool tracking = true);

        Task<IEnumerable<AppUser>> IncludeGetAllWhereAsync(Expression<Func<AppUser, bool>> expression, Expression<Func<AppUser, object>> include, Expression<Func<AppUser, object>> orderby, bool tracking = true);
    }
}