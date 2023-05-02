using AutoMapper.Internal.Mappers;
using PetShop.Aggregates;
using PetShop.Entities.Animals;
using PetShop.Services.Dtos.Animals;
using PetShop.Services.Dtos.Client;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace PetShop.Services;

public class ClientAppService : ApplicationService, IClientAppService
{
    private readonly AnimalFactory _animalFactory;
    private readonly ClientManager _clientManager;
    private readonly IRepository<Client, Guid> _clientRepository;
    private readonly IRepository<Animal, Guid> _animalRepository;

    public ClientAppService(AnimalFactory animalFactory,
        ClientManager clientManager,
        IRepository<Client, Guid> clientRepository,
        IRepository<Animal, Guid> animalRepository)
    {
        _animalFactory = animalFactory;
        _clientManager = clientManager;
        _clientRepository = clientRepository;
        _animalRepository = animalRepository;
    }
    public async Task<ClientDto> CreateClientAsync(ClientCreateDto input)
    => ObjectMapper.Map<Client, ClientDto>(
        await _clientRepository.InsertAsync(
            _clientManager.CreateClient(input.Name, 
                input.Phone)
            )
        );

    public async Task<List<AnimalDto>> CreateAnimalsByClientAsync(Guid clientId, CreateAnimalsByClientListDto input)
    {
        var client = await _clientRepository.GetAsync(clientId);

        var animalList = new List<Animal>();
        foreach (var animalDto in input.animals)
        {
            var animal = _animalFactory.CreateAnimal(client.Id, animalDto.AnimalType);
            animalList.Add(animal);
        }

        List<AnimalDto> animalsDto = ObjectMapper.Map<List<Animal>, List<AnimalDto>>(animalList);
        await _animalRepository.InsertManyAsync(
            animalList
            );
        return animalsDto;
    }

    public async Task<List<AnimalDto>> GetAnimalsByClientAsync(Guid clientId)
    {
        var animals = await _animalRepository.GetListAsync(x => x.ClientId == clientId);
        return ObjectMapper.Map<List<Animal>, List<AnimalDto>>(animals);
    }
}