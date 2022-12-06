using System;
using System.Collections.Generic;
using System.Text;
using Abp.OnlineStore.Localization;
using Volo.Abp.Application.Services;

namespace Abp.OnlineStore.Admin;

/* Inherit your application services from this class.
 */
public abstract class OnlineStoreAdminAppService : ApplicationService
{
    protected OnlineStoreAdminAppService()
    {
        LocalizationResource = typeof(OnlineStoreResource);
    }
}
