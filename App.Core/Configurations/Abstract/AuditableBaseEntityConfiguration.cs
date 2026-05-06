namespace App.Core.Configurations.Abstract
{
    public abstract class AuditableBaseEntityConfiguration<T> : BaseEntityConfiguration<T> where T : AuditableBaseEntity
    {
        public override void Configure(EntityTypeBuilder<T> builder)
        {
            base.Configure(builder);

            builder.Property(auditableBaseEntity => auditableBaseEntity.CreatedBy).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            builder.ToTable(auditableBaseEntity => auditableBaseEntity.HasCheckConstraint("CreatedBy_MinLength_Control", "Len(CreatedBy) >= 5"));

            builder.Property(auditableBaseEntity => auditableBaseEntity.CreatedDate).HasDefaultValue(DateTime.Now);

            builder.Property(auditableBaseEntity => auditableBaseEntity.DeletedBy).HasMaxLength(50).HasColumnType("nvarchar").HasMaxLength(50);

            builder.Property(auditableBaseEntity => auditableBaseEntity.ModifiedBy).HasMaxLength(50).HasColumnType("nvarchar").HasMaxLength(50);
        }
    }
}