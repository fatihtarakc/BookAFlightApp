namespace App.Entity.Entities
{
    public class Airline : AuditableBaseEntity
    {
        public Airline()
        {
            Aircrafts = new HashSet<Aircraft>();
            Flights = new HashSet<Flight>();
        }

        public string Name { get; set; }
        public string IataCode { get; set; }
        public string IcaoCode { get; set; }

        // Relations
        public virtual ICollection<Aircraft> Aircrafts { get; set; }
        public virtual ICollection<Flight> Flights { get; set; }
    }
}