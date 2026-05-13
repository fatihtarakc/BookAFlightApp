namespace App.DataAccess.Context
{
    public class BookAFlightAppDbContext : IdentityDbContext<IdentityUser, IdentityRole, string>
    {
        public BookAFlightAppDbContext(DbContextOptions<BookAFlightAppDbContext> options) : base(options) { }

        public virtual DbSet<Admin>? Admins { get; set; }
        public virtual DbSet<Aircraft>? Aircrafts { get; set; }
        public virtual DbSet<Airline>? Airlines { get; set; }
        public virtual DbSet<Airport>? Airports { get; set; }
        public virtual DbSet<AppUser>? AppUsers { get; set; }
        public virtual DbSet<Booking>? Bookings { get; set; }
        public virtual DbSet<Flight>? Flights { get; set; }
        public virtual DbSet<Manufacturer>? Manufacturers { get; set; }
        public virtual DbSet<Model>? Models { get; set; }
        public virtual DbSet<Route>? Routes { get; set; }
        public virtual DbSet<Schedule>? Schedules { get; set; }
        public virtual DbSet<Seat>? Seats { get; set; }
        public virtual DbSet<VerificationCode>? VerificationCodes { get; set; }

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

            foreach (var entityEntry in entityEntries)
            {
                SetIfAdded(entityEntry);
                SetIfModified(entityEntry);
                SetIfDeleted(entityEntry);
            }
        }

        private void SetIfAdded(EntityEntry<AuditableBaseEntity> entityEntry)
        {
            if (entityEntry.State is not EntityState.Added) return;

            entityEntry.Entity.EntityStatus = EntityStatus.Added;
            entityEntry.Entity.CreatedDate = DateTime.Now;

            if (entityEntry.Entity is Admin) entityEntry.Entity.CreatedBy = "super admin";
        }

        private void SetIfModified(EntityEntry<AuditableBaseEntity> entityEntry)
        {
            if (entityEntry.State is not EntityState.Modified) return;

            entityEntry.Entity.EntityStatus = EntityStatus.Updated;
            entityEntry.Entity.ModifiedDate = DateTime.Now;

            if (entityEntry.Entity is Admin) entityEntry.Entity.ModifiedBy = "super admin";
        }

        private void SetIfDeleted(EntityEntry<AuditableBaseEntity> entityEntry)
        {
            if (entityEntry.State is not EntityState.Deleted) return;

            entityEntry.State = EntityState.Modified;

            entityEntry.Entity.EntityStatus = EntityStatus.Deleted;
            entityEntry.Entity.DeletedDate = DateTime.Now;

            if (entityEntry.Entity is Admin) entityEntry.Entity.DeletedBy = "super admin";
        }
    }
}