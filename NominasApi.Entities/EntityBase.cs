using NominasApi.Abstractions;

namespace NominasApi.Entities
{
    public abstract class EntityBase : IEntityBase
    {
        public int Id { get; set; }
    }
}
