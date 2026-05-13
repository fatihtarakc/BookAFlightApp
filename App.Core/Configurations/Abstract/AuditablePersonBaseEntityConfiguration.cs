namespace App.Core.Configurations.Abstract
{
    public abstract class AuditablePersonBaseEntityConfiguration<T> : AuditableBaseEntityConfiguration<T> where T : AuditablePersonBaseEntity
    {
        public override void Configure(EntityTypeBuilder<T> builder)
        {
            base.Configure(builder);

            builder.HasIndex(auditablePersonBaseEntity => auditablePersonBaseEntity.Email).IsUnique();
            builder.Property(auditablePersonBaseEntity => auditablePersonBaseEntity.Email).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            builder.ToTable(auditablePersonBaseEntity => auditablePersonBaseEntity.HasCheckConstraint($"CK_{typeof(T).Name}_Email_MinLength_Control", "Len(Email) >= 5"));

            builder.HasIndex(auditablePersonBaseEntity => auditablePersonBaseEntity.IdentityId).IsUnique();
            builder.Property(auditablePersonBaseEntity => auditablePersonBaseEntity.IdentityId).HasColumnType("nvarchar").HasMaxLength(11).IsRequired();
            builder.ToTable(auditablePersonBaseEntity => auditablePersonBaseEntity.HasCheckConstraint($"CK_{typeof(T).Name}_IdentityId_Length_Control", "Len(IdentityId) = 11"));

            builder.HasIndex(auditablePersonBaseEntity => auditablePersonBaseEntity.AspNetUsersId).IsUnique();
            builder.Property(auditablePersonBaseEntity => auditablePersonBaseEntity.AspNetUsersId).HasColumnType("nvarchar").HasMaxLength(36).IsRequired();
            builder.ToTable(auditablePersonBaseEntity => auditablePersonBaseEntity.HasCheckConstraint($"CK_{typeof(T).Name}_AspNetUsersId_Length_Control", "Len(AspNetUsersId) = 36"));
        }
    }
}