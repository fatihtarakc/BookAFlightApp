namespace App.Entity.Entities
{
    public class Model : AuditableBaseEntity
    {
        public Model()
        {
            Aircrafts = new HashSet<Aircraft>();
        }

        public string Name { get; set; }
        public string IataCode { get; set; }
        public string IcaoCode { get; set; }
        public BodyType BodyType { get; set; }
        public int SeatCapacity { get; set; }

        // Relations
        public Guid ManufacturerId { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }
        public virtual ICollection<Aircraft> Aircrafts { get; set; }
    }
}