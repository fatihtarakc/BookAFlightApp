namespace App.Entities.Configurations.Concrete
{
    public class VerificationCodeConfiguration : AuditableBaseEntityConfiguration<VerificationCode>
    {
        public override void Configure(EntityTypeBuilder<VerificationCode> builder)
        {
            base.Configure(builder);

            builder.HasIndex(verificationCode => new { verificationCode.AppUserId, verificationCode.Code, verificationCode.VerificationCodeStatus, verificationCode.CreatedDate }).IsUnique();

            builder.Property(verificationCode => verificationCode.Code).HasColumnType("nvarchar").HasMaxLength(6).IsRequired();
            builder.ToTable(verificationCode => verificationCode.HasCheckConstraint("CK_VerificationCode_Code_Pattern_Control", "Code not like '%[^0-9]%' and Len(Code) = 6"));

            builder.ToTable(verificationCode => verificationCode.HasCheckConstraint("CK_VerificationCode_ExpirationDate_Control", "ExpirationDate > CreatedDate"));

            builder.Property(verificationCode => verificationCode.AttemptCount).HasDefaultValue(0);

            builder.ToTable(verificationCode => verificationCode.HasCheckConstraint("CK_VerificationCode_AttemptCount_Control", "AttemptCount >= 0 and AttemptCount <= 3"));

            builder.Property(verificationCode => verificationCode.VerificationCodeChannel).HasDefaultValue(VerificationCodeChannel.Email);

            builder.Property(verificationCode => verificationCode.VerificationCodeStatus).HasDefaultValue(VerificationCodeStatus.Active);

            builder.HasOne(verificationCode => verificationCode.AppUser).WithMany(appUser => appUser.VerificationCodes).HasForeignKey(verificationCode => verificationCode.AppUserId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}