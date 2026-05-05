namespace App.Entity.Entities
{
    public class Seat : AuditableBaseEntity
    {
        public Seat()
        {
            Bookings = new HashSet<Booking>();
        }

        public string AircraftIdSeatNumberColumn { get; set; }
        public int Number { get; set; }
        public SeatColumn SeatColumn { get; set; }
        public bool IsReserved { get; set; }

        // Relations
        public Guid AircraftId { get; set; }
        public Aircraft Aircraft { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}