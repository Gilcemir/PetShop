using Volo.Abp.Application.Dtos;

namespace PetShop.Services.Dtos.Client;

public class AnimalDto : EntityDto<Guid>
{
    public long Weight { get; set; }
    public string AnimalType { get; set; }
    public Guid ClientId { get; set; }
}