namespace App.Dtos.RouteDtos
{
    public class RouteListDto 
    {
        public Guid Id { get; set; }
        public string DepartureArrivalAirportCode { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}