namespace App.Entities.Configurations.Concrete
{
    public class AirportConfiguration : AuditableBaseEntityConfiguration<Airport>
    {
        public override void Configure(EntityTypeBuilder<Airport> builder)
        {
            base.Configure(builder);

            builder.HasIndex(airport => airport.Name).IsUnique();
            builder.Property(airport => airport.Name).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            builder.ToTable(airport => airport.HasCheckConstraint("CK_Airport_Name_Pattern_Control", "Name not like '%[^A-Za-z0-9ğüşıöçĞÜŞİÖÇ &-]%' and Len(Name) >= 3"));

            builder.HasIndex(airport => airport.IataCode).IsUnique();
            builder.Property(airport => airport.IataCode).HasColumnType("nvarchar").HasMaxLength(3).IsRequired();
            builder.ToTable(airport => airport.HasCheckConstraint("CK_Airport_IataCode_Pattern_Control", "IataCode not like '%[^A-Z]%' and Len(IataCode) = 3"));

            builder.HasIndex(airport => airport.IcaoCode).IsUnique();
            builder.Property(airport => airport.IcaoCode).HasColumnType("nvarchar").HasMaxLength(4).IsRequired();
            builder.ToTable(airport => airport.HasCheckConstraint("CK_Airport_IcaoCode_Pattern_Control", "IcaoCode not like '%[^A-Z]%' and Len(IcaoCode) = 4"));

            builder.Property(airport => airport.City).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            builder.ToTable(airport => airport.HasCheckConstraint("CK_Airport_City_Pattern_Control", "City not like '%[^A-Za-z0-9ğüşıöçĞÜŞİÖÇ &-]%' and Len(City) >= 2"));

            builder.Property(airport => airport.Country).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            builder.ToTable(airport => airport.HasCheckConstraint("CK_Airport_Country_Pattern_Control", "Country not like '%[^A-Za-z0-9ğüşıöçĞÜŞİÖÇ &-]%' and Len(Country) >= 2"));
        }
    }
}