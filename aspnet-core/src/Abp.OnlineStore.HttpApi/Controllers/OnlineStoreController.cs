using Abp.OnlineStore.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Abp.OnlineStore.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class OnlineStoreController : AbpControllerBase
{
    protected OnlineStoreController()
    {
        LocalizationResource = typeof(OnlineStoreResource);
    }
}
