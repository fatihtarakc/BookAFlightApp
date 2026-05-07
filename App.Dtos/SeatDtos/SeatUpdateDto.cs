namespace App.Dtos.SeatDtos
{
    public class SeatUpdateDto 
    {
        public Guid Id { get; set; }
        public string AircraftIdSeatNumberColumn { get; set; }
        public int Number { get; set; }
        public SeatColumn SeatColumn { get; set; }
        public bool IsReserved { get; set; }

        // Relations
        public Guid AircraftId { get; set; }
        public AircraftDto AircraftDto { get; set; }
    }
}