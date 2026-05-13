namespace App.Entity.Entities
{
    public class AppUser : AuditablePersonBaseEntity
    {
        public AppUser()
        {
            Bookings = new HashSet<Booking>();
            VerificationCodes = new HashSet<VerificationCode>();
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public UserStatus UserStatus { get; set; }

        // Relations
        public virtual ICollection<Booking> Bookings { get; set; }
        public virtual ICollection<VerificationCode> VerificationCodes { get; set; }
    }
}