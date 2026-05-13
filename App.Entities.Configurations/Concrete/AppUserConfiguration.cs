namespace App.Entities.Configurations.Concrete
{
    public class AppUserConfiguration : AuditablePersonBaseEntityConfiguration<AppUser>
    {
        public override void Configure(EntityTypeBuilder<AppUser> builder)
        {
            base.Configure(builder);

            builder.Property(appUser => appUser.Name).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            builder.ToTable(appUser => appUser.HasCheckConstraint("CK_AppUser_Name_Pattern_Control", "Name not like '%[^A-Za-zğüşıöçĞÜŞİÖÇ -]%' and Len(Name) >= 2"));

            builder.Property(appUser => appUser.Surname).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            builder.ToTable(appUser => appUser.HasCheckConstraint("CK_AppUser_Surname_Pattern_Control", "Surname not like '%[^A-Za-zğüşıöçĞÜŞİÖÇ -]%' and Len(Surname) >= 2"));

            builder.HasIndex(appUser => appUser.PhoneNumber).IsUnique();
            builder.Property(appUser => appUser.PhoneNumber).HasColumnType("nvarchar").HasMaxLength(16).IsRequired();
            builder.ToTable(appUser => appUser.HasCheckConstraint("CK_AppUser_PhoneNumber_Pattern_Control", "PhoneNumber like '+%' and PhoneNumber not like '%[^0-9+]%' and Len(PhoneNumber) >= 8"));

            builder.ToTable(appUser => appUser.HasCheckConstraint("CK_AppUser_BirthDate_Control", "BirthDate <= Dateadd(Year, -18, GetDate())"));

            builder.Property(appUser => appUser.UserStatus).HasDefaultValue(UserStatus.Active);
        }
    }
}