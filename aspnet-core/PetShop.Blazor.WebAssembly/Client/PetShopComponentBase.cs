using PetShop.Localization;
using Volo.Abp.AspNetCore.Components;

namespace PetShop;

public abstract class PetShopComponentBase : AbpComponentBase
{
    protected PetShopComponentBase()
    {
        LocalizationResource = typeof(PetShopResource);
    }
}
