using Volo.Abp.Modularity;

namespace Abp.OnlineStore.Admin;

[DependsOn(
    typeof(OnlineStoreAdminApplicationModule),
    typeof(OnlineStoreDomainTestModule)
    )]
public class OnlineStoreApplicationTestModule : AbpModule
{

}
