using Microsoft.EntityFrameworkCore;
using Volo.Abp.DependencyInjection;

namespace PetShop.Data;

public class PetShopEFCoreDbSchemaMigrator : ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public PetShopEFCoreDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the PetShopDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<PetShopDbContext>()
            .Database
            .MigrateAsync();
    }
}
