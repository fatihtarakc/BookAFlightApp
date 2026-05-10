namespace App.Entity.Entities
{
    public class Flight : AuditableBaseEntity
    {
        public Flight() 
        {
            FlightSeats = new HashSet<FlightSeat>();
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
        public virtual Aircraft Aircraft { get; set; }
        public Guid RouteId { get; set; }
        public virtual Route Route { get; set; }
        public virtual ICollection<FlightSeat> FlightSeats { get; set; }
    }
}