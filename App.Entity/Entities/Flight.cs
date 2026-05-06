namespace App.Entity.Entities
{
    public class Flight : AuditableBaseEntity
    {
        public Flight() 
        {
            Bookings = new HashSet<Booking>();
        }

        public string Number { get; set; }
        public string AirlineCode { get; set; }
        public string Airline { get; set; }
        public DateTime DepartureDateTime { get; set; }
        public DateTime ArrivalDateTime { get; set; }
        public int DurationMinutes { get; set; }
        public decimal BasePrice { get; set; }
        public Currency Currency { get; set; }
        public FlightStatus FlightStatus { get; set; }

        // Relations
        public Guid AircraftId { get; set; }
        public Aircraft Aircraft { get; set; }
        public Guid RouteId { get; set; }
        public Route Route { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}