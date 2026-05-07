namespace App.Entities.Configurations.Concrete
{
    public class RouteConfiguration : AuditableBaseEntityConfiguration<Route>
    {
        public override void Configure(EntityTypeBuilder<Route> builder)
        {
            base.Configure(builder);

            builder.HasIndex(route => route.DepartureArrivalAirportCode).IsUnique();
            builder.Property(route => route.DepartureArrivalAirportCode).HasColumnType("nvarchar").HasMaxLength(10).IsRequired();
            builder.ToTable(route => route.HasCheckConstraint("DepartureArrivalAirportCode_MinLength_Control", "Len(DepartureArrivalAirportCode) >= 4"));
        }
    }
}