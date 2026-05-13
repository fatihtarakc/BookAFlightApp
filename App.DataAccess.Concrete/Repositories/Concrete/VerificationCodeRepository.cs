namespace App.DataAccess.Concrete.Repositories.Concrete
{
    public class VerificationCodeRepository : GenericRepository<VerificationCode>, IVerificationCodeRepository
    {
        public VerificationCodeRepository(BookAFlightAppDbContext db) : base(db) { }

        public async Task<VerificationCode> IncludeGetFirstOrDefaultAsync(Expression<Func<VerificationCode, bool>> expression, Expression<Func<VerificationCode, object>> include, bool tracking = true) =>
            await GetAllByStatusIsNotDeletedByTracking(tracking).Include(include).FirstOrDefaultAsync(expression);

        public async Task<IEnumerable<VerificationCode>> IncludeGetAllWhereAsync(Expression<Func<VerificationCode, bool>> expression, Expression<Func<VerificationCode, object>> include, Expression<Func<VerificationCode, object>> orderby, bool tracking = true) =>
            await GetAllByStatusIsNotDeletedByTracking(tracking).Include(include).Where(expression).OrderBy(orderby).ToListAsync();
    }
}