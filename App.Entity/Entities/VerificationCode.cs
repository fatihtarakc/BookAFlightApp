namespace App.Entity.Entities
{
    public class VerificationCode : AuditableBaseEntity
    {
        public string Code { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int AttemptCount { get; set; }
        public VerificationCodeChannel VerificationCodeChannel { get; set; }
        public VerificationCodePurpose VerificationCodePurpose { get; set; }
        public VerificationCodeStatus VerificationCodeStatus { get; set; }

        // Relations
        public Guid AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }
    }
}
