using Abp.OnlineStore.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Abp.OnlineStore;

[DependsOn(
    typeof(OnlineStoreEntityFrameworkCoreTestModule)
    )]
public class OnlineStoreDomainTestModule : AbpModule
{

}
