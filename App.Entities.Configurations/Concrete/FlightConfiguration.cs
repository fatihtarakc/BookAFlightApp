namespace App.Entities.Configurations.Concrete
{
    public class FlightConfiguration : AuditableBaseEntityConfiguration<Flight>
    {
        public override void Configure(EntityTypeBuilder<Flight> builder)
        {
            base.Configure(builder);

            builder.HasIndex(flight => flight.Number).IsUnique();
            builder.Property(flight => flight.Number).HasColumnType("nvarchar").HasMaxLength(6).IsRequired();
            builder.ToTable(flight => flight.HasCheckConstraint("CK_Flight_Number_Pattern_Control", "Number not like '%[^A-Z0-9]%' and Len(Number) >= 3"));
            
            builder.ToTable(flight => flight.HasCheckConstraint("CK_Flight_Duration_Control", "ArrivalDateTime > DepartureDateTime"));

            builder.Property(flight => flight.BasePrice).HasColumnType("decimal(18,2)").IsRequired();
            builder.ToTable(flight => flight.HasCheckConstraint("CK_Flight_BasePrice_Min_Control", "BasePrice > 0"));

            builder.Property(flight => flight.Currency).HasDefaultValue(Currency.TL);

            builder.Property(flight => flight.FlightStatus).HasDefaultValue(FlightStatus.Scheduled);

            builder.HasOne(flight => flight.Aircraft).WithMany(aircraft => aircraft.Flights).HasForeignKey(flight => flight.AircraftId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(flight => flight.Airline).WithMany(airline => airline.Flights).HasForeignKey(flight => flight.AirlineId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(flight => flight.Schedule).WithMany(schedule => schedule.Flights).HasForeignKey(flight => flight.ScheduleId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}