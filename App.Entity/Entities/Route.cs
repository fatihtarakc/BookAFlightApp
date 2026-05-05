namespace App.Entity.Entities
{
    public class Route : AuditableBaseEntity
    {
        public Route()
        {
            Flights = new HashSet<Flight>();
        }

        public string DepartureArrivalAirportCode { get; set; }

        // Relations
        public Guid DepartureAirportId { get; set; }
        public Airport DepartureAirport { get; set; }
        public Guid ArrivalAirportId { get; set; }
        public Airport ArrivalAirport { get; set; }
        public virtual ICollection<Flight> Flights { get; set; }
    }
}