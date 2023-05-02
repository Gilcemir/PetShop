using PetShop.Enums;

namespace PetShop.Entities.Animals;

public class Cat : Animal
{
    public string CatProperty { get; internal set; }
    
    internal Cat(Guid id, string catProperty, Guid clientId) : base(id, clientId)
    {
        SetType();
        CatProperty = catProperty;
    }

    protected sealed override void SetType()
    => AnimalType = AnimalType.Cat;
    
}