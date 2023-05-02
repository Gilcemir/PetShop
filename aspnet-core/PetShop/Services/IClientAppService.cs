using PetShop.Services.Dtos.Animals;
using PetShop.Services.Dtos.Client;

namespace PetShop.Services;

public interface IClientAppService
{
    Task<ClientDto> CreateClientAsync(ClientCreateDto input);
    Task<List<AnimalDto>> CreateAnimalsByClientAsync(Guid clientId, CreateAnimalsByClientListDto input);

    Task<List<AnimalDto>> GetAnimalsByClientAsync(Guid clientId);
}