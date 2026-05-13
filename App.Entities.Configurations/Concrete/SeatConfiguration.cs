namespace App.Entities.Configurations.Concrete
{
    public class SeatConfiguration : AuditableBaseEntityConfiguration<Seat>
    {
        public override void Configure(EntityTypeBuilder<Seat> builder)
        {
            base.Configure(builder);

            builder.HasIndex(seat => new { seat.AircraftId, seat.Number, seat.SeatColumn }).IsUnique();

            builder.ToTable(seat => seat.HasCheckConstraint("CK_Seat_Number_Control", "Number >= 1 And Number <= 150"));

            builder.Property(seat => seat.SeatClass).HasDefaultValue(SeatClass.Economy);

            builder.HasOne(seat => seat.Aircraft).WithMany(aircraft => aircraft.Seats).HasForeignKey(seat => seat.AircraftId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}