namespace App.Entities.Configurations.Concrete
{
    public class AircraftConfiguration : AuditableBaseEntityConfiguration<Aircraft>
    {
        public override void Configure(EntityTypeBuilder<Aircraft> builder)
        {
            base.Configure(builder);

            builder.HasIndex(aircraft => aircraft.TailNumber).IsUnique();
            builder.Property(aircraft => aircraft.TailNumber).HasColumnType("nvarchar").HasMaxLength(10).IsRequired();
            builder.ToTable(aircraft => aircraft.HasCheckConstraint("CK_Aircraft_TailNumber_Pattern_Control", "TailNumber not like '%[^A-Z0-9-]%' and Len(TailNumber) >= 2"));

            builder.Property(aircraft => aircraft.AircraftStatus).HasDefaultValue(AircraftStatus.Active);

            builder.HasOne(aircraft => aircraft.Airline).WithMany(airline => airline.Aircrafts).HasForeignKey(aircraft => aircraft.AirlineId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(aircraft => aircraft.Model).WithMany(model => model.Aircrafts).HasForeignKey(aircraft => aircraft.ModelId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}