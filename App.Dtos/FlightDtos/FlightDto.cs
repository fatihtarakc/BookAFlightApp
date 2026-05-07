namespace App.Dtos.FlightDtos
{
    public class FlightDto
    {
        public FlightDto()
        {
            BookingDtos = new HashSet<BookingDto>();
        }

        public Guid Id { get; set; }
        public string Number { get; set; }
        public string AirlineCode { get; set; }
        public string Airline { get; set; }
        public DateTime DepartureDateTime { get; set; }
        public DateTime ArrivalDateTime { get; set; }
        public int DurationMinutes { get; set; }
        public decimal BasePrice { get; set; }
        public Currency Currency { get; set; }
        public FlightStatus FlightStatus { get; set; }
        public DateTime CreatedDate { get; set; }

        // Relations
        public Guid AircraftId { get; set; }
        public AircraftDto AircraftDto { get; set; }
        public Guid RouteId { get; set; }
        public RouteDto RouteDto { get; set; }
        public virtual ICollection<BookingDto> BookingDtos { get; set; }
    }
}