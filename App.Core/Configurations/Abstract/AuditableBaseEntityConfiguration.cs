namespace App.Core.Configurations.Abstract
{
    public abstract class AuditableBaseEntityConfiguration<T> : BaseEntityConfiguration<T> where T : AuditableBaseEntity
    {
        public override void Configure(EntityTypeBuilder<T> builder)
        {
            base.Configure(builder);

            builder.Property(auditableBaseEntity => auditableBaseEntity.CreatedBy).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            builder.ToTable(auditableBaseEntity => auditableBaseEntity.HasCheckConstraint("CK_AuditableBaseEntity_CreatedBy_MinLength_Control", "Len(CreatedBy) >= 5"));

            builder.Property(auditableBaseEntity => auditableBaseEntity.CreatedDate).HasDefaultValue(DateTime.Now);

            builder.Property(auditableBaseEntity => auditableBaseEntity.DeletedBy).HasColumnType("nvarchar").HasMaxLength(50);

            builder.Property(auditableBaseEntity => auditableBaseEntity.ModifiedBy).HasColumnType("nvarchar").HasMaxLength(50);
        }
    }
}