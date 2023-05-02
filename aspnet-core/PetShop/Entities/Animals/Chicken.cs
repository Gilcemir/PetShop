using PetShop.Enums;

namespace PetShop.Entities.Animals;

public class Chicken : Animal
{
    public string ChickenProperty { get; internal set; }
    internal Chicken(Guid id, string chickenProperty, Guid clientId) : base(id, clientId)
    {
        SetType();
        ChickenProperty = chickenProperty;
    }

    protected sealed override void SetType()
        => AnimalType = AnimalType.Chicken;
}