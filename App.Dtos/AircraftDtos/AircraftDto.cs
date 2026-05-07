namespace App.Dtos.AircraftDtos
{
    public class AircraftDto
    {
        public AircraftDto()
        {
            FlightDtos = new HashSet<FlightDto>();
            SeatDtos = new HashSet<SeatDto>();
        }

        public Guid Id { get; set; }
        public string Type { get; set; }
        public bool IsReserved { get; set; }
        public DateTime CreatedDate { get; set; }

        // Relations
        public virtual ICollection<FlightDto> FlightDtos { get; set; }
        public virtual ICollection<SeatDto> SeatDtos { get; set; }
    }
}