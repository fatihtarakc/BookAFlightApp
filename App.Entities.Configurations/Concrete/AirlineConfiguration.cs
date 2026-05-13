namespace App.Entities.Configurations.Concrete
{
    public class AirlineConfiguration : AuditableBaseEntityConfiguration<Airline>
    {
        public override void Configure(EntityTypeBuilder<Airline> builder)
        {
            base.Configure(builder);

            builder.HasIndex(airline => airline.Name).IsUnique();
            builder.Property(airline => airline.Name).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            builder.ToTable(airline => airline.HasCheckConstraint("CK_Airline_Name_Pattern_Control", "Name not like '%[^A-Za-z0-9ğüşıöçĞÜŞİÖÇ &-]%' and Len(Name) >= 2"));

            builder.HasIndex(airline => airline.IataCode).IsUnique();
            builder.Property(airline => airline.IataCode).HasColumnType("nvarchar").HasMaxLength(2).IsRequired();
            builder.ToTable(airline => airline.HasCheckConstraint("CK_Airline_IataCode_Pattern_Control", "IataCode not like '%[^A-Z0-9]%' and Len(IataCode) = 2"));

            builder.HasIndex(airline => airline.IcaoCode).IsUnique();
            builder.Property(airline => airline.IcaoCode).HasColumnType("nvarchar").HasMaxLength(3).IsRequired();
            builder.ToTable(airline => airline.HasCheckConstraint("CK_Airline_IcaoCode_Pattern_Control", "IcaoCode not like '%[^A-Z]%' and Len(IcaoCode) = 3"));
        }
    }
}