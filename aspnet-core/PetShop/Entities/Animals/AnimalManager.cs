using Volo.Abp.Domain.Services;

namespace PetShop.Entities.Animals;

public class AnimalManager : DomainService
{
    public Cat CreateCat(Guid clientId, string catProperty)
        => new (GuidGenerator.Create(), catProperty, clientId);

    public Dog CreateDog(Guid clientId, int dogProperty)
        => new (GuidGenerator.Create(), dogProperty, clientId);

    public Chicken CreateChicken(Guid clientId, string chickenProperty)
        => new(GuidGenerator.Create(), chickenProperty, clientId);

    public Bird CreateBird(Guid clientId, bool birdProperty)
        => new(GuidGenerator.Create(), birdProperty, clientId);
}