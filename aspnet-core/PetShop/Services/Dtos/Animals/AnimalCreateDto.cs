using PetShop.Enums;

namespace PetShop.Services.Dtos.Animals;

public class AnimalCreateDto
{
    public AnimalType AnimalType { get; set; }
    
    public long Weight { get; internal set; }
    
}