namespace App.DataAccess.Context
{
    public class BookAFlightAppDbContext : IdentityDbContext<IdentityUser, IdentityRole, string>
    {
        private readonly IHttpContextAccessor? httpContextAccessor;
        public BookAFlightAppDbContext(DbContextOptions<BookAFlightAppDbContext> options, IHttpContextAccessor httpContextAccessor = null) : base(options)
        {
            this.httpContextAccessor = httpContextAccessor;
        }

        public virtual DbSet<Admin>? Admins { get; set; }
        public virtual DbSet<Aircraft>? Aircrafts { get; set; }
        public virtual DbSet<Airport>? Airports { get; set; }
        public virtual DbSet<AppUser>? AppUsers { get; set; }
        public virtual DbSet<Booking>? Bookings { get; set; }
        public virtual DbSet<Flight>? Flights { get; set; }
        public virtual DbSet<Route>? Routes { get; set; }
        public virtual DbSet<Seat>? Seats { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(IEntityConfiguration).Assembly);
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            SetBaseProperties();
            return base.SaveChangesAsync(cancellationToken);
        }

        private void SetBaseProperties()
        {
            var entityEntries = ChangeTracker.Entries<AuditableBaseEntity>();
            var userId = httpContextAccessor?.HttpContext?.User?.FindFirstValue(ClaimTypes.NameIdentifier) ?? "User do not found !";

            foreach (var entityEntry in entityEntries)
            {
                SetIfAdded(entityEntry, userId);
                SetIfModified(entityEntry, userId);
                SetIfDeleted(entityEntry, userId);
            }
        }

        private void SetIfAdded(EntityEntry<AuditableBaseEntity> entityEntry, string userId)
        {
            if (entityEntry.State is not EntityState.Added) return;

            entityEntry.Entity.Status = Status.Added;
            entityEntry.Entity.CreatedDate = DateTime.Now;

            if (entityEntry.Entity is Admin) entityEntry.Entity.CreatedBy = "super admin";
            else entityEntry.Entity.CreatedBy = userId;
        }

        private void SetIfModified(EntityEntry<AuditableBaseEntity> entityEntry, string userId)
        {
            if (entityEntry.State is not EntityState.Modified) return;

            entityEntry.Entity.Status = Status.Updated;
            entityEntry.Entity.ModifiedDate = DateTime.Now;

            if (entityEntry.Entity is Admin) entityEntry.Entity.ModifiedBy = "super admin";
            else entityEntry.Entity.ModifiedBy = userId;
        }

        private void SetIfDeleted(EntityEntry<AuditableBaseEntity> entityEntry, string userId)
        {
            if (entityEntry.State is not EntityState.Deleted) return;

            entityEntry.State = EntityState.Modified;

            entityEntry.Entity.Status = Status.Deleted;
            entityEntry.Entity.DeletedDate = DateTime.Now;

            if (entityEntry.Entity is Admin) entityEntry.Entity.DeletedBy = "super admin";
            else entityEntry.Entity.DeletedBy = userId;
        }
    }
}