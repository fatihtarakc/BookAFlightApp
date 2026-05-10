namespace App.Entity.Entities
{
    public class Seat : AuditableBaseEntity
    {
        public Seat()
        {
            FlightSeats = new HashSet<FlightSeat>();
        }

        public string AircraftIdSeatNumberColumn { get; set; }
        public int Number { get; set; }
        public SeatColumn SeatColumn { get; set; }
        public bool IsReserved { get; set; }

        // Relations
        public Guid AircraftId { get; set; }
        public virtual Aircraft Aircraft { get; set; }
        public virtual ICollection<FlightSeat> FlightSeats { get; set; }
    }
}