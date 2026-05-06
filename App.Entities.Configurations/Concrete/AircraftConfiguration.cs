namespace App.Entities.Configurations.Concrete
{
    public class AircraftConfiguration : AuditableBaseEntityConfiguration<Aircraft>
    {
        public override void Configure(EntityTypeBuilder<Aircraft> builder)
        {
            base.Configure(builder);

            builder.Property(aircraft => aircraft.Type).HasColumnType("nvarchar").HasMaxLength(20).IsRequired();
            builder.ToTable(aircraft => aircraft.HasCheckConstraint("Type_MinLength_Control", "Len(Type) >= 2"));

            builder.Property(aircraft => aircraft.IsReserved).HasDefaultValue(false);
        }
    }
}