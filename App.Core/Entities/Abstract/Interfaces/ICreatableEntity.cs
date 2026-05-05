namespace App.Core.Entities.Abstract.Interfaces
{
    public interface ICreatableEntity
    {
        string CreatedBy { get; init; }
        DateTime CreatedDate { get; init; }
    }
}