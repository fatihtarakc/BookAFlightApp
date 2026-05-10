namespace App.Entities.Configurations.Concrete
{
    public class SeatConfiguration : AuditableBaseEntityConfiguration<Seat>
    {
        public override void Configure(EntityTypeBuilder<Seat> builder)
        {
            base.Configure(builder);

            builder.HasIndex(seat => seat.AircraftIdSeatNumberColumn).IsUnique();
            builder.Property(seat => seat.AircraftIdSeatNumberColumn).HasColumnType("nvarchar").HasMaxLength(40).IsRequired();
            builder.ToTable(seat => seat.HasCheckConstraint("AircraftIdSeatNumberColumn_MinLength_Control", "Len(AircraftIdSeatNumberColumn) >= 38"));

            builder.ToTable(seat => seat.HasCheckConstraint("NumberCheckConstraint", "Number >= 1 And Number <= 150"));

            builder.Property(seat => seat.IsReserved).HasDefaultValue(false);

            builder.HasOne(seat => seat.Aircraft).WithMany(aircraft => aircraft.Seats).HasForeignKey(seat => seat.AircraftId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}