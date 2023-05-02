using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace PetShop.Data;

public class PetShopDbContextFactory : IDesignTimeDbContextFactory<PetShopDbContext>
{
    public PetShopDbContext CreateDbContext(string[] args)
    {

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<PetShopDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new PetShopDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
