namespace App.Entities.Configurations.Concrete
{
    public class ModelConfiguration : AuditableBaseEntityConfiguration<Model>
    {
        public override void Configure(EntityTypeBuilder<Model> builder)
        {
            base.Configure(builder);

            builder.HasIndex(model => new { model.ManufacturerId, model.Name }).IsUnique();
            builder.Property(model => model.Name).HasColumnType("nvarchar").HasMaxLength(100).IsRequired();
            builder.ToTable(model => model.HasCheckConstraint("CK_Model_Name_Pattern_Control", "Name not like '%[^A-Za-z0-9ğüşıöçĞÜŞİÖÇ .&-]%' and Len(Name) >= 2"));

            builder.HasIndex(m => new { m.ManufacturerId, m.IataCode }).IsUnique();
            builder.Property(model => model.IataCode).HasColumnType("nvarchar").HasMaxLength(3).IsRequired();
            builder.ToTable(model => model.HasCheckConstraint("CK_Model_IataCode_Pattern_Control", "IataCode not like '%[^A-Z0-9]%' and Len(IataCode) = 3"));

            builder.HasIndex(model => model.IcaoCode).IsUnique();
            builder.Property(model => model.IcaoCode).HasColumnType("nvarchar").HasMaxLength(4).IsRequired();
            builder.ToTable(model => model.HasCheckConstraint("CK_Model_IcaoCode_Pattern_Control", "IcaoCode not like '%[^A-Z0-9]%' and Len(IcaoCode) >= 2"));

            builder.ToTable(model => model.HasCheckConstraint("CK_Model_SeatCapacity_Range_Control", "SeatCapacity between 1 and 1000"));

            builder.HasOne(model => model.Manufacturer).WithMany(manufacturer => manufacturer.Models).HasForeignKey(model => model.ManufacturerId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}