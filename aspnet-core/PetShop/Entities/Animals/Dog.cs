using PetShop.Enums;

namespace PetShop.Entities.Animals;

public class Dog : Animal
{
    public int DogProperty { get; internal set; }
    internal Dog(Guid id, int dogProperty, Guid clientId) : base(id, clientId)
    {
        SetType();
        DogProperty = dogProperty;
    }

    protected sealed override void SetType()
        => AnimalType = AnimalType.Dog;
}