using PetShop.Enums;
using Volo.Abp.DependencyInjection;

namespace PetShop.Entities.Animals;

public class AnimalFactory : ITransientDependency
{
    private readonly AnimalManager _animalManager;
    public AnimalFactory(AnimalManager animalManager)
    {
        _animalManager = animalManager;
    }
    public Animal CreateAnimal(Guid clientId, AnimalType animalType)
        => animalType switch
        {
            AnimalType.Bird => _animalManager.CreateBird(clientId, true),
            AnimalType.Cat => _animalManager.CreateCat(clientId, ""),
            AnimalType.Chicken => _animalManager.CreateChicken(clientId, ""),
            AnimalType.Dog => _animalManager.CreateDog(clientId, 10),
            _ => throw new ArgumentException("type not found", nameof(animalType))
        };
}