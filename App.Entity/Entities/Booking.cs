namespace App.Entity.Entities
{
    public class Booking : AuditableBaseEntity
    {
        public string PnrNumber { get; set; }
        public decimal Price { get; set; }

        // Relations
        public Guid AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public Guid FlightId { get; set; }
        public Flight Flight { get; set; }
        public Guid SeatId { get; set; }
        public Seat Seat { get; set; }
    }
}