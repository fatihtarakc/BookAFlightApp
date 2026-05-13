namespace App.Entity.Entities
{
    public class Flight : AuditableBaseEntity
    {
        public Flight()
        {
            Bookings = new HashSet<Booking>();
        }

        public string Number { get; set; }
        public DateTime DepartureDateTime { get; set; }
        public DateTime ArrivalDateTime { get; set; }
        public TimeSpan Duration { get; set; }
        public decimal BasePrice { get; set; }
        public Currency Currency { get; set; }
        public FlightStatus FlightStatus { get; set; }

        //public int TotalSeats => Aircraft.Seats.Count;
        //public int BookedSeats => Bookings.Count;
        //public int AvailableSeats => Aircraft.TotalSeats - BookedSeats;
        //public int AvailableEconomySeats => Aircraft.EconomySeats - Bookings.Count(b => b.Seat.SeatClass == SeatClass.Economy);
        //public int AvailableBusinessSeats => Aircraft.BusinessSeats - Bookings.Count(b => b.Seat.SeatClass == SeatClass.Business);

        // Relations
        public Guid AircraftId { get; set; }
        public virtual Aircraft Aircraft { get; set; }
        public Guid AirlineId { get; set; }
        public virtual Airline Airline { get; set; }
        //public Guid RouteId { get; set; }
        //public virtual Route Route { get; set; }
        public Guid ScheduleId { get; set; }
        public virtual Schedule Schedule { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}