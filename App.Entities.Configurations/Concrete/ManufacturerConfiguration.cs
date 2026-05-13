namespace App.Entities.Configurations.Concrete
{
    public class ManufacturerConfiguration : AuditableBaseEntityConfiguration<Manufacturer>
    {
        public override void Configure(EntityTypeBuilder<Manufacturer> builder)
        {
            base.Configure(builder);

            builder.HasIndex(manufacturer => manufacturer.Name).IsUnique();
            builder.Property(manufacturer => manufacturer.Name).HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
            builder.ToTable(manufacturer => manufacturer.HasCheckConstraint("CK_Manufacturer_Name_Pattern_Control", "Name not like '%[^A-Za-z0-9ğüşıöçĞÜŞİÖÇ .&-]%' and Len(Name) >= 2"));

            builder.Property(manufacturer => manufacturer.Country).HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
            builder.ToTable(manufacturer => manufacturer.HasCheckConstraint("CK_Manufacturer_Country_Pattern_Control", "Country not like '%[^A-Za-zğüşıöçĞÜŞİÖÇ -]%' and Len(Country) >= 4"));
        }
    }
}