namespace App.Dtos.RouteDtos
{
    public class RouteDto
    {
        public RouteDto()
        {
            FlightDtos = new HashSet<FlightDto>();
        }

        public Guid Id { get; set; }
        public string DepartureArrivalAirportCode { get; set; }
        public DateTime CreatedDate { get; set; }

        // Relations
        public Guid DepartureAirportId { get; set; }
        public AirportDto DepartureAirportDto { get; set; }
        public Guid ArrivalAirportId { get; set; }
        public AirportDto ArrivalAirportDto { get; set; }
        public virtual ICollection<FlightDto> FlightDtos { get; set; }
    }
}