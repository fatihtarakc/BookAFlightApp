namespace App.DataAccess.Abstract.Repositories.Abstract
{
    public interface IVerificationCodeRepository :
        IAsyncAddableRepository<VerificationCode>, IAsyncDeletableRepository<VerificationCode>, IAsyncUpdatableRepository<VerificationCode>,
        IAsyncQueryableRepository<VerificationCode>, IAsyncOrderableRepository<VerificationCode>
    {
        Task<VerificationCode> IncludeGetFirstOrDefaultAsync(Expression<Func<VerificationCode, bool>> expression, Expression<Func<VerificationCode, object>> include, bool tracking = true);

        Task<IEnumerable<VerificationCode>> IncludeGetAllWhereAsync(Expression<Func<VerificationCode, bool>> expression, Expression<Func<VerificationCode, object>> include, Expression<Func<VerificationCode, object>> orderby, bool tracking = true);
    }
}