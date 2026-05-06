namespace App.Core.Configurations.Abstract
{
    public abstract class AuditablePersonBaseEntityConfiguration<T> : AuditableBaseEntityConfiguration<T> where T : AuditablePersonBaseEntity
    {
        public override void Configure(EntityTypeBuilder<T> builder)
        {
            base.Configure(builder);

            builder.HasIndex(auditablePersonBaseEntity => auditablePersonBaseEntity.Email).IsUnique();
            builder.Property(auditablePersonBaseEntity => auditablePersonBaseEntity.Email).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            builder.ToTable(auditablePersonBaseEntity => auditablePersonBaseEntity.HasCheckConstraint("Email_MinLength_Control", "Len(Email) >= 5"));

            builder.HasIndex(auditablePersonBaseEntity => auditablePersonBaseEntity.IdentityId).IsUnique();
            builder.Property(auditablePersonBaseEntity => auditablePersonBaseEntity.IdentityId).HasColumnType("nvarchar").HasMaxLength(36).IsRequired();
            builder.ToTable(auditablePersonBaseEntity => auditablePersonBaseEntity.HasCheckConstraint("IdentityId_Length_Control", "Len(IdentityId) = 36"));
        }
    }
}