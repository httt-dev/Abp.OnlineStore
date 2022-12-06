using System.Threading.Tasks;

namespace Abp.OnlineStore.Data;

public interface IOnlineStoreDbSchemaMigrator
{
    Task MigrateAsync();
}
