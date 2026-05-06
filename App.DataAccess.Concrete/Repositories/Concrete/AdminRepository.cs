namespace App.DataAccess.Concrete.Repositories.Concrete
{
    public class AdminRepository : GenericRepository<Admin>, IAdminRepository
    {
        public AdminRepository(BookAFlightAppDbContext db) : base(db) { }

        public async Task<Admin> GetByIdentityIdAsync(string identityId) =>
            await dbEntity.FirstOrDefaultAsync(admin => admin.IdentityId == identityId);
    }
}