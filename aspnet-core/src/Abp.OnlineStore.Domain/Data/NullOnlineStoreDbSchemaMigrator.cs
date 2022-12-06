using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Abp.OnlineStore.Data;

/* This is used if database provider does't define
 * IOnlineStoreDbSchemaMigrator implementation.
 */
public class NullOnlineStoreDbSchemaMigrator : IOnlineStoreDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
