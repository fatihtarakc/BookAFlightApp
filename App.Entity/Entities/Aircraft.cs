namespace App.Entity.Entities
{
    public class Aircraft : AuditableBaseEntity
    {
        public Aircraft()
        {
            Flights = new HashSet<Flight>();
            Seats = new HashSet<Seat>();
        }

        public string TailNumber { get; set; }
        public bool IsReserved { get; set; }

        // Relations
        public virtual ICollection<Flight> Flights { get; set; }
        public virtual ICollection<Seat> Seats { get; set; }
    }
}