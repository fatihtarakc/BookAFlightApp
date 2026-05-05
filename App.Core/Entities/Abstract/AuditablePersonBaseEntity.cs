namespace App.Core.Entities.Abstract
{
    public abstract class AuditablePersonBaseEntity : AuditableBaseEntity
    {
        public string Email { get; init; }
        public string IdentityId { get; init; }
    }
}