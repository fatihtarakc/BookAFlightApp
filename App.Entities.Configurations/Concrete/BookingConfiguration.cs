namespace App.Entities.Configurations.Concrete
{
    public class BookingConfiguration : AuditableBaseEntityConfiguration<Booking>
    {
        public override void Configure(EntityTypeBuilder<Booking> builder)
        {
            base.Configure(builder);

            builder.HasIndex(booking => booking.PnrNumber).IsUnique();
            builder.Property(booking => booking.PnrNumber).HasColumnType("nvarchar").HasMaxLength(6).IsRequired();
            builder.ToTable(booking => booking.HasCheckConstraint("CK_Booking_PnrNumber_Pattern_Control", "PnrNumber not like '%[^A-Z0-9]%' and Len(PnrNumber) = 6"));

            builder.ToTable(booking => booking.HasCheckConstraint("CK_Booking_Price_Min_Control", "Price > 0"));

            builder.Property(booking => booking.BookingStatus).HasDefaultValue(BookingStatus.Reserved);

            builder.HasIndex(booking => new { booking.FlightId, booking.SeatId }).IsUnique();

            builder.HasOne(booking => booking.AppUser).WithMany(appUser => appUser.Bookings).HasForeignKey(booking => booking.AppUserId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(booking => booking.Flight).WithMany(flight => flight.Bookings).HasForeignKey(booking => booking.FlightId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(booking => booking.Seat).WithMany(seat => seat.Bookings).HasForeignKey(booking => booking.SeatId).OnDelete(DeleteBehavior.Restrict);

        }
    }
}