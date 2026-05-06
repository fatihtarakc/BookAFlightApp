namespace App.DataAccess.Concrete.Repositories.Concrete
{
    public class AppUserRepository : GenericRepository<AppUser>, IAppUserRepository
    {
        public AppUserRepository(BookAFlightAppDbContext db) : base(db) { }

        public async Task<AppUser> GetByIdentityIdAsync(string identityId) =>
            await dbEntity.FirstOrDefaultAsync(appUser => appUser.IdentityId == identityId);

        public async Task<AppUser> IncludeGetFirstOrDefaultAsync(Expression<Func<AppUser, bool>> expression, Expression<Func<AppUser, object>> include, bool tracking = true) =>
            await GetAllByStatusIsNotDeletedByTracking(tracking).Include(include).FirstOrDefaultAsync(expression);

        public async Task<IEnumerable<AppUser>> IncludeGetAllWhereAsync(Expression<Func<AppUser, bool>> expression, Expression<Func<AppUser, object>> include, Expression<Func<AppUser, object>> orderby, bool tracking = true) =>
            await GetAllByStatusIsNotDeletedByTracking(tracking).Include(include).Where(expression).OrderBy(orderby).ToListAsync();
    }
}