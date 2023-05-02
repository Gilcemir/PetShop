using MongoDB.Bson.Serialization.IdGenerators;
using Volo.Abp.Domain.Services;

namespace PetShop.Aggregates;

public class ClientManager : DomainService
{
    public Client CreateClient(string name, string phone)
        => new(GuidGenerator.Create(), name, phone);
}