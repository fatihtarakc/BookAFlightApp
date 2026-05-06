namespace App.Entities.Configurations.Concrete
{
    public class AirportConfiguration : AuditableBaseEntityConfiguration<Airport>
    {
        public override void Configure(EntityTypeBuilder<Airport> builder)
        {
            base.Configure(builder);

            builder.HasIndex(airport => airport.Name).IsUnique();
            builder.Property(airport => airport.Name).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            builder.ToTable(airport => airport.HasCheckConstraint("Name_MinLength_Control", "Len(Name) >= 3"));

            builder.HasIndex(airport => airport.Code).IsUnique();
            builder.Property(airport => airport.Code).HasColumnType("nvarchar").HasMaxLength(4).IsRequired();
            builder.ToTable(airport => airport.HasCheckConstraint("Code_MinLength_Control", "Len(Code) >= 2"));

            builder.Property(airport => airport.City).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            builder.ToTable(airport => airport.HasCheckConstraint("City_MinLength_Control", "Len(City) >= 2"));

            builder.Property(airport => airport.Country).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            builder.ToTable(airport => airport.HasCheckConstraint("Country_MinLength_Control", "Len(Country) >= 2"));
        }
    }
}