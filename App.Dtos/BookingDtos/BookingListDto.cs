namespace App.Dtos.BookingDtos
{
    public class BookingListDto 
    {
        public Guid Id { get; set; }
        public string PnrNumber { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedDate { get; set; }

        // Relations
        public Guid AppUserId { get; set; }
        public AppUserDto AppUserDto { get; set; }
        public Guid FlightId { get; set; }
        public FlightDto FlightDto { get; set; }
        public Guid SeatId { get; set; }
        public SeatDto SeatDto { get; set; }
    }
}