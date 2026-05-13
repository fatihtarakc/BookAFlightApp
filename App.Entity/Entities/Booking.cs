namespace App.Entity.Entities
{
    public class Booking : AuditableBaseEntity
    {
        public string PnrNumber { get; set; }
        public decimal Price { get; set; }
        public BookingStatus BookingStatus { get; set; }

        // Relations
        public Guid AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }
        public Guid FlightId { get; set; }
        public virtual Flight Flight { get; set; }
        public Guid SeatId { get; set; }
        public virtual Seat Seat { get; set; }
    }
}