namespace App.Entities.Configurations.Concrete
{
    public class BookingConfiguration : AuditableBaseEntityConfiguration<Booking>
    {
        public override void Configure(EntityTypeBuilder<Booking> builder)
        {
            base.Configure(builder);

            builder.HasIndex(booking => booking.PnrNumber).IsUnique();
            builder.Property(booking => booking.PnrNumber).HasColumnType("nvarchar").HasMaxLength(6).IsRequired();
            builder.ToTable(booking => booking.HasCheckConstraint("PnrNumber_Length_Control", "Len(PnrNumber) = 6"));

            builder.ToTable(booking => booking.HasCheckConstraint("PriceCheckConstraint", "Price > 0"));

            builder.HasOne(booking => booking.AppUser).WithMany(appUser => appUser.Bookings).HasForeignKey(booking => booking.AppUserId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(booking => booking.Flight).WithMany(flight => flight.Bookings).HasForeignKey(booking => booking.FlightId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(booking => booking.Seat).WithMany(seat => seat.Bookings).HasForeignKey(booking => booking.SeatId).OnDelete(DeleteBehavior.Restrict);

        }
    }
}