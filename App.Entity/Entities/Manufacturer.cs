namespace App.Entity.Entities
{
    public class Manufacturer : AuditableBaseEntity
    {
        public Manufacturer()
        {
            Models = new HashSet<Model>();
        }

        public string Name { get; set; }
        public string Country { get; set; }

        // Relations
        public virtual ICollection<Model> Models { get; set; }
    }
}