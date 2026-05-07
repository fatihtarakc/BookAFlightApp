namespace App.Dtos.RouteDtos
{
    public class RouteAddDto
    {
        public string DepartureArrivalAirportCode { get; set; }

        // Relations
        public Guid DepartureAirportId { get; set; }
        public AirportDto DepartureAirportDto { get; set; }
        public Guid ArrivalAirportId { get; set; }
        public AirportDto ArrivalAirportDto { get; set; }
    }
}