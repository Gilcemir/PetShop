using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace PetShop;

[Dependency(ReplaceServices = true)]
public class PetShopBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "PetShop";
}
