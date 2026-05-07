namespace App.Dtos.SeatDtos
{
    public class SeatAddDto 
    {
        public string AircraftIdSeatNumberColumn { get; set; }
        public int Number { get; set; }
        public SeatColumn SeatColumn { get; set; }

        // Relations
        public Guid AircraftId { get; set; }
        public AircraftDto AircraftDto { get; set; }
    }
}