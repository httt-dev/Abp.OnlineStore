using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Abp.OnlineStore.Data;
using Volo.Abp.DependencyInjection;

namespace Abp.OnlineStore.EntityFrameworkCore;

public class EntityFrameworkCoreOnlineStoreDbSchemaMigrator
    : IOnlineStoreDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreOnlineStoreDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the OnlineStoreDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<OnlineStoreDbContext>()
            .Database
            .MigrateAsync();
    }
}
