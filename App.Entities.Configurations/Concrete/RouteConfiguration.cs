namespace App.Entities.Configurations.Concrete
{
    public class RouteConfiguration : AuditableBaseEntityConfiguration<Route>
    {
        public override void Configure(EntityTypeBuilder<Route> builder)
        {
            base.Configure(builder);

            builder.HasIndex(route => route.DepartureArrivalAirportCode).IsUnique();
            builder.Property(route => route.DepartureArrivalAirportCode).HasColumnType("nvarchar").HasMaxLength(10).IsRequired();
            builder.ToTable(route => route.HasCheckConstraint("DepartureArrivalAirportCode_MinLength_Control", "Len(DepartureArrivalAirportCode) >= 4"));

            builder.HasOne(route => route.DepartureAirport).WithMany(airport => airport.DepartureRoutes).HasForeignKey(route => route.DepartureAirportId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(route => route.ArrivalAirport).WithMany(airport => airport.ArrivalRoutes).HasForeignKey(route => route.ArrivalAirportId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}