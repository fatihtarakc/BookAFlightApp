namespace App.Entity.Entities
{
    public class Seat : AuditableBaseEntity
    {
        public Seat()
        {
            Bookings = new HashSet<Booking>();
        }

        public int Number { get; set; }
        public SeatColumn SeatColumn { get; set; }
        public SeatClass SeatClass { get; set; }

        // Relations
        public Guid AircraftId { get; set; }
        public virtual Aircraft Aircraft { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}