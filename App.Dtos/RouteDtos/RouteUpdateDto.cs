namespace App.Dtos.RouteDtos
{
    public class RouteUpdateDto 
    {
        public Guid Id { get; set; }
        public string DepartureArrivalAirportCode { get; set; }

        // Relations
        public Guid DepartureAirportId { get; set; }
        public AirportDto DepartureAirportDto { get; set; }
        public Guid ArrivalAirportId { get; set; }
        public AirportDto ArrivalAirportDto { get; set; }
    }
}