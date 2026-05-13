namespace App.DataAccess.Concrete.Repositories.Concrete
{
    public class ModelRepository : GenericRepository<Model>, IModelRepository
    {
        public ModelRepository(BookAFlightAppDbContext db) : base(db) { }

        public async Task<Model> IncludeGetFirstOrDefaultAsync(Expression<Func<Model, bool>> expression, Expression<Func<Model, object>> include, bool tracking = true) =>
            await GetAllByStatusIsNotDeletedByTracking(tracking).Include(include).FirstOrDefaultAsync(expression);

        public async Task<IEnumerable<Model>> IncludeGetAllWhereAsync(Expression<Func<Model, bool>> expression, Expression<Func<Model, object>> include, Expression<Func<Model, object>> orderby, bool tracking = true) =>
            await GetAllByStatusIsNotDeletedByTracking(tracking).Include(include).Where(expression).OrderBy(orderby).ToListAsync();
    }
}