namespace App.Dtos.SeatDtos
{
    public class SeatListDto 
    {
        public Guid Id { get; set; }
        public string AircraftIdSeatNumberColumn { get; set; }
        public int Number { get; set; }
        public SeatColumn SeatColumn { get; set; }
        public bool IsReserved { get; set; }
        public DateTime CreatedDate { get; set; }

        // Relations
        public Guid AircraftId { get; set; }
        public AircraftDto AircraftDto { get; set; }
    }
}