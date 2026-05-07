namespace App.Dtos.AirportDtos
{
    public class AirportDto
    {
        public AirportDto()
        {
            DepartureRouteDtos = new HashSet<RouteDto>();
            ArrivalRouteDtos = new HashSet<RouteDto>();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public DateTime CreatedDate { get; set; }

        // Relations
        public ICollection<RouteDto> DepartureRouteDtos { get; set; }
        public ICollection<RouteDto> ArrivalRouteDtos { get; set; }
    }
}