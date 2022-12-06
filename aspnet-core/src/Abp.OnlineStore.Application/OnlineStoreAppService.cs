using System;
using System.Collections.Generic;
using System.Text;
using Abp.OnlineStore.Localization;
using Volo.Abp.Application.Services;

namespace Abp.OnlineStore;

/* Inherit your application services from this class.
 */
public abstract class OnlineStoreAppService : ApplicationService
{
    protected OnlineStoreAppService()
    {
        LocalizationResource = typeof(OnlineStoreResource);
    }
}
