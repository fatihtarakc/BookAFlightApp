namespace App.Dtos.AircraftDtos
{
    public class AircraftUpdateDto 
    {
        public Guid Id { get; set; }
        public string Type { get; set; }
        public bool IsReserved { get; set; }
    }
}