using AutoMapper;
using PetShop.Aggregates;
using PetShop.Entities.Animals;
using PetShop.Services.Dtos;
using PetShop.Services.Dtos.Client;

namespace PetShop.ObjectMapping;

public class PetShopAutoMapperProfile : Profile
{
    public PetShopAutoMapperProfile()
    {
        /* Create your AutoMapper object mappings here */
        CreateMap<Cat, AnimalDto>()
            .ForMember(x => x.AnimalType, y => y.MapFrom(z => z.AnimalType.ToString()));
        CreateMap<Dog, AnimalDto>()
            .ForMember(x => x.AnimalType, y => y.MapFrom(z => z.AnimalType.ToString()));
        CreateMap<Bird, AnimalDto>()
            .ForMember(x => x.AnimalType, y => y.MapFrom(z => z.AnimalType.ToString()));
        CreateMap<Chicken, AnimalDto>()
            .ForMember(x => x.AnimalType, y => y.MapFrom(z => z.AnimalType.ToString()));
        CreateMap<Client, ClientDto>();
    }
}
