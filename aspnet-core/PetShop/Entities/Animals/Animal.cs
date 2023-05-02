using MongoDB.Bson.Serialization.Attributes;
using PetShop.Enums;
using Volo.Abp.Domain.Entities.Auditing;

namespace PetShop.Entities.Animals;

[BsonKnownTypes(typeof(Cat), typeof(Dog), typeof(Chicken), typeof(Bird))]
public abstract class Animal : FullAuditedEntity<Guid>
{
    public long Weight { get; internal set; }
    public AnimalType AnimalType { get; internal set; }
    
    public Guid ClientId { get; set; }
    protected Animal(Guid id, Guid clientId) : base(id)
    {
        ClientId = clientId;
    }

    protected abstract void SetType();
}