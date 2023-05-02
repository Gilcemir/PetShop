using MongoDB.Driver;
using PetShop.Aggregates;
using PetShop.Entities;
using PetShop.Entities.Animals;
using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace PetShop.Data;

[ConnectionStringName("Default")]
public class PetShopDbContext : AbpMongoDbContext
{
    /* Add mongo collections here. Example:
     * public IMongoCollection<Question> Questions => Collection<Question>();
     */

    public IMongoCollection<Animal> Animals => Collection<Animal>();
    public IMongoCollection<Client> Clients => Collection<Client>();
    
    protected override void CreateModel(IMongoModelBuilder modelBuilder)
    {
        base.CreateModel(modelBuilder);

        //builder.Entity<YourEntity>(b =>
        //{
        //    //...
        //});
    }
}
