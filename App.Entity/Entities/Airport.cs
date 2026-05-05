namespace App.Entity.Entities
{
    public class Airport : AuditableBaseEntity
    {
        public Airport() 
        {
            DepartureRoutes = new HashSet<Route>();
            ArrivalRoutes = new HashSet<Route>();
        }

        public string Name { get; set; }
        public string Code { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        // Relations
        public ICollection<Route> DepartureRoutes { get; set; }
        public ICollection<Route> ArrivalRoutes { get; set; }
    }
}