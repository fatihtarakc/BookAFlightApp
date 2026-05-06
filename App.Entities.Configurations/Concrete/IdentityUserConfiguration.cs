namespace App.Entities.Configurations.Concrete
{
    public class IdentityUserConfiguration : IEntityTypeConfiguration<IdentityUser>
    {
        public void Configure(EntityTypeBuilder<IdentityUser> builder)
        {
            builder.HasIndex(identityUser => identityUser.Email).IsUnique();
            builder.Property(identityUser => identityUser.Email).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            builder.ToTable(identityUser => identityUser.HasCheckConstraint("Email_MinLength_Control", "Len(Email) >= 5"));

            builder.HasIndex(identityUser => identityUser.UserName).IsUnique();
            builder.Property(identityUser => identityUser.UserName).HasColumnType("nvarchar").HasMaxLength(11).IsRequired();
            builder.ToTable(identityUser => identityUser.HasCheckConstraint("UserName_Length_Control", "Len(UserName) = 11"));

            builder.HasIndex(identityUser => identityUser.NormalizedEmail).IsUnique();
            builder.Property(identityUser => identityUser.NormalizedEmail).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            builder.ToTable(identityUser => identityUser.HasCheckConstraint("NormalizedEmail_MinLength_Control", "Len(NormalizedEmail) >= 5"));

            builder.HasIndex(identityUser => identityUser.NormalizedUserName).IsUnique();
            builder.Property(identityUser => identityUser.NormalizedUserName).HasColumnType("nvarchar").HasMaxLength(11).IsRequired();
            builder.ToTable(identityUser => identityUser.HasCheckConstraint("NormalizedUserName_Length_Control", "Len(NormalizedUserName) = 11"));
        }
    }
}