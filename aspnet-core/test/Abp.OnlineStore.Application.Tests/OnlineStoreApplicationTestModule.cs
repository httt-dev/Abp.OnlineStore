using Volo.Abp.Modularity;

namespace Abp.OnlineStore;

[DependsOn(
    typeof(OnlineStoreApplicationModule),
    typeof(OnlineStoreDomainTestModule)
    )]
public class OnlineStoreApplicationTestModule : AbpModule
{

}
