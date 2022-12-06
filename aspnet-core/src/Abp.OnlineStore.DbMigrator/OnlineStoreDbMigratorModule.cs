using Abp.OnlineStore.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Abp.OnlineStore.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(OnlineStoreEntityFrameworkCoreModule),
    typeof(OnlineStoreApplicationContractsModule)
    )]
public class OnlineStoreDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
