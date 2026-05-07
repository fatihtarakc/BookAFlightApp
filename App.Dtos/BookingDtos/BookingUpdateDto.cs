namespace App.Dtos.BookingDtos
{
    public class BookingUpdateDto 
    {
        public Guid Id { get; set; }
        public string PnrNumber { get; set; }
        public decimal Price { get; set; }
    }
}