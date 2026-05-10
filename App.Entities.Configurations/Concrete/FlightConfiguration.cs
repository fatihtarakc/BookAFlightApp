namespace App.Entities.Configurations.Concrete
{
    public class FlightConfiguration : AuditableBaseEntityConfiguration<Flight>
    {
        public override void Configure(EntityTypeBuilder<Flight> builder)
        {
            base.Configure(builder);

            builder.HasIndex(flight => flight.Number).IsUnique();
            builder.Property(flight => flight.Number).HasColumnType("nvarchar").HasMaxLength(6).IsRequired();
            builder.ToTable(flight => flight.HasCheckConstraint("Number_MinLength_Control", "Len(Number) >= 3"));

            builder.Property(flight => flight.AirlineCode).HasColumnType("nvarchar").HasMaxLength(2).IsRequired();
            builder.ToTable(flight => flight.HasCheckConstraint("AirlineCode_Length_Control", "Len(AirlineCode) = 2"));

            builder.Property(flight => flight.Airline).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            builder.ToTable(flight => flight.HasCheckConstraint("Airline_MinLength_Control", "Len(Airline) >= 5"));

            builder.ToTable(flight => flight.HasCheckConstraint("DurationMinutesCheckConstraint", "DurationMinutes > 0"));

            builder.Property(flight => flight.ArrivalDateTime).HasComputedColumnSql("DATEADD(minute, DurationMinutes, DepartureDateTime)", stored: true);

            builder.ToTable(flight => flight.HasCheckConstraint("BasePriceCheckConstraint", "BasePrice > 0"));

            builder.Property(flight => flight.FlightStatus).HasDefaultValue(FlightStatus.Scheduled);

            builder.HasOne(flight => flight.Aircraft).WithMany(aircraft => aircraft.Flights).HasForeignKey(flight => flight.AircraftId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(flight => flight.Route).WithMany(route => route.Flights).HasForeignKey(flight => flight.RouteId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}