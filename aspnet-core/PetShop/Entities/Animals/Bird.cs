using PetShop.Enums;

namespace PetShop.Entities.Animals;

public class Bird : Animal
{
    public bool BirdProperty { get; internal set; }
    internal Bird(Guid id, bool birdProperty, Guid clientId) : base(id, clientId)
    {
        SetType();
        BirdProperty = birdProperty;
    }

    protected sealed override void SetType()
        => AnimalType = AnimalType.Bird;
}