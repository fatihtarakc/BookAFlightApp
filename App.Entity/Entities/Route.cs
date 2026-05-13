namespace App.Entity.Entities
{
    public class Route : AuditableBaseEntity
    {
        public Route()
        {
            Schedules = new HashSet<Schedule>();
        }

        public string DepartureArrivalIataCode { get; set; }
        public decimal DistanceNauticalMiles { get; set; }
        public TimeSpan EstimatedDuration { get; set; }

        // Relations
        public Guid DepartureAirportId { get; set; }
        public virtual Airport DepartureAirport { get; set; }
        public Guid ArrivalAirportId { get; set; }
        public virtual Airport ArrivalAirport { get; set; }
        //public virtual ICollection<Flight> Flights { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}