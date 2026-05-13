namespace App.Entities.Configurations.Concrete
{
    public class ScheduleConfiguration : AuditableBaseEntityConfiguration<Schedule>
    {
        public override void Configure(EntityTypeBuilder<Schedule> builder)
        {
            base.Configure(builder);

            builder.HasIndex(schedule => schedule.Code).IsUnique();
            builder.Property(schedule => schedule.Code).HasColumnType("nvarchar").HasMaxLength(20).IsRequired();
            builder.ToTable(schedule => schedule.HasCheckConstraint("CK_Schedule_Code_Pattern_Control", "Code not like '%[^A-Za-z0-9ğüşıöçĞÜŞİÖÇ .&-]%' and Len(Code) >= 3"));

            builder.ToTable(schedule => schedule.HasCheckConstraint("CK_Schedule_ValidFromValidTo_Control", "ValidTo is null or ValidTo > ValidFrom"));
            
            builder.ToTable(schedule => schedule.HasCheckConstraint("CK_Schedule_DepartureTime_Control", "DepartureTime >= '00:00:00' and DepartureTime <= '23:59:59'"));
            
            builder.Property(schedule => schedule.TimeZone).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();

            builder.HasOne(schedule => schedule.Route).WithMany(route => route.Schedules).HasForeignKey(schedule => schedule.RouteId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}