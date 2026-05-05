namespace App.Entity.Entities
{
    public class AppUser : AuditablePersonBaseEntity
    {
        public AppUser()
        {
            Bookings = new HashSet<Booking>();
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string VerificationCode { get; set; }

        // Relations
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}