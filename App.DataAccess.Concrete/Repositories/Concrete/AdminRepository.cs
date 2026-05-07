namespace App.DataAccess.Concrete.Repositories.Concrete
{
    public class AdminRepository : GenericRepository<Admin>, IAdminRepository
    {
        public AdminRepository(BookAFlightAppDbContext db) : base(db) { }
    }
}