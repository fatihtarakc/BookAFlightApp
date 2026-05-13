namespace App.Dtos.AuditablePersonBaseEntityDtos
{
    public class AuditablePersonBaseEntityDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; init; }
        public Guid IdentityId { get; init; }
    }
}