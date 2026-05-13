namespace App.DataAccess.Concrete.Repositories.Concrete
{
    public class ManufacturerRepository : GenericRepository<Manufacturer>, IManufacturerRepository
    {
        public ManufacturerRepository(BookAFlightAppDbContext db) : base(db) { }

        public async Task<Manufacturer> IncludeGetFirstOrDefaultAsync(Expression<Func<Manufacturer, bool>> expression, Expression<Func<Manufacturer, object>> include, bool tracking = true) =>
            await GetAllByStatusIsNotDeletedByTracking(tracking).Include(include).FirstOrDefaultAsync(expression);

        public async Task<IEnumerable<Manufacturer>> IncludeGetAllWhereAsync(Expression<Func<Manufacturer, bool>> expression, Expression<Func<Manufacturer, object>> include, Expression<Func<Manufacturer, object>> orderby, bool tracking = true) =>
            await GetAllByStatusIsNotDeletedByTracking(tracking).Include(include).Where(expression).OrderBy(orderby).ToListAsync();
    }
}