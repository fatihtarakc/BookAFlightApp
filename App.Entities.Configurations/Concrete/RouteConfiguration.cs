namespace App.Entities.Configurations.Concrete
{
    public class RouteConfiguration : AuditableBaseEntityConfiguration<Route>
    {
        public override void Configure(EntityTypeBuilder<Route> builder)
        {
            base.Configure(builder);

            builder.HasIndex(route => route.DepartureArrivalIataCode).IsUnique();
            builder.Property(route => route.DepartureArrivalIataCode).HasColumnType("nvarchar").HasMaxLength(7).IsRequired();
            builder.ToTable(route => route.HasCheckConstraint("CK_Route_DepartureArrivalIataCode_Pattern_Control", "DepartureArrivalIataCode not like '%[^A-Z-]%' and Len(DepartureArrivalIataCode) = 7 and Substring(DepartureArrivalIataCode, 4, 1) = '-'"));

            builder.Property(route => route.DistanceNauticalMiles).HasColumnType("decimal(18,2)").IsRequired();
            builder.ToTable(route => route.HasCheckConstraint("CK_Route_DistanceNauticalMiles_Min_Control", "DistanceNauticalMiles > 0"));

            builder.ToTable(route => route.HasCheckConstraint("CK_Route_EstimatedDuration_Control", "EstimatedDuration > Cast('00:00:00' as time)"));

            builder.HasIndex(route => new { route.DepartureAirportId, route.ArrivalAirportId }).IsUnique();
            builder.HasOne(route => route.DepartureAirport).WithMany(airport => airport.DepartureRoutes).HasForeignKey(route => route.DepartureAirportId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(route => route.ArrivalAirport).WithMany(airport => airport.ArrivalRoutes).HasForeignKey(route => route.ArrivalAirportId).OnDelete(DeleteBehavior.Restrict);
            builder.ToTable(route => route.HasCheckConstraint("CK_Route_DifferentRoute_Control", "DepartureAirportId <> ArrivalAirportId"));
        }
    }
}