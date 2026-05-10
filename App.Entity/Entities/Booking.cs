namespace App.Entity.Entities
{
    public class Booking : AuditableBaseEntity
    {
        public string PnrNumber { get; set; }
        public decimal Price { get; set; }

        // Relations
        public Guid AppUserId { get; set; }
        public virtual AppUser AppUser { get; set; }
        public Guid FlightSeatId { get; set; }
        public virtual FlightSeat FlightSeat { get; set; }
    }
}