using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace PetShop.Aggregates;

public class Client : FullAuditedAggregateRoot<Guid>
{
    public string Name { get; internal set; }

    public string Phone { get; internal set; }

    public Client(Guid id, string name, string phone) : base(id)
    {
        Name = Check.NotNullOrWhiteSpace(name, nameof(name));
        Phone = Check.NotNullOrWhiteSpace(phone, nameof(phone));
    }
}