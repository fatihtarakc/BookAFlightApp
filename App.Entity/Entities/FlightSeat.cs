namespace App.Entity.Entities
{
    public class FlightSeat
    {
        public FlightSeat()
        {
            Bookings = new HashSet<Booking>();
        }

        // Relations
        public Guid FlightId { get; set; }
        public virtual Flight Flight { get; set; }
        public Guid SeatId { get; set; }
        public virtual Seat Seat { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}