namespace App.DataAccess.Abstract.Repositories.Abstract
{
    public interface IAdminRepository :
        IAsyncAddableRepository<Admin>, IAsyncDeletableRepository<Admin>, IAsyncUpdatableRepository<Admin>,
        IAsyncQueryableRepository<Admin>, IAsyncOrderableRepository<Admin>
    {
        Task<Admin> GetByIdentityIdAsync(string identityId);
    }
}