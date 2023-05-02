using Volo.Abp.Application.Dtos;

namespace PetShop.Services.Dtos.Client;

public class ClientDto : EntityDto<Guid>
{
    public string Name { get; set; }

    public string Phone { get; set; }   
}