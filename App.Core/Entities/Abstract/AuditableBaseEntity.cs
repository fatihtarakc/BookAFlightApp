namespace App.Core.Entities.Abstract
{
    public abstract class AuditableBaseEntity : BaseEntity, ICreatableEntity, IDeletableEntity, IUpdatableEntity
    {
        #region ICreatableEntity
        public string CreatedBy { get; init; }
        public DateTime CreatedDate { get; init; }
        #endregion

        #region IDeletableEntity
        public string? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        #endregion

        #region IUpdatableEntity
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        #endregion
    }
}