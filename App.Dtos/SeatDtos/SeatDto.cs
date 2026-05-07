namespace App.Dtos.SeatDtos
{
    public class SeatDto
    {
        public SeatDto()
        {
            BookingDtos = new HashSet<BookingDto>();
        }

        public Guid Id { get; set; }
        public string AircraftIdSeatNumberColumn { get; set; }
        public int Number { get; set; }
        public SeatColumn SeatColumn { get; set; }
        public bool IsReserved { get; set; }
        public DateTime CreatedDate { get; set; }

        // Relations
        public Guid AircraftId { get; set; }
        public AircraftDto AircraftDto { get; set; }
        public virtual ICollection<BookingDto> BookingDtos { get; set; }
    }
}