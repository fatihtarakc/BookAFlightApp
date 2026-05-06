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

        }
    }
}