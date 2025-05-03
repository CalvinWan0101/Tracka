using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Tracka.Data;

/* This is used if database provider does't define
 * ITrackaDbSchemaMigrator implementation.
 */
public class NullTrackaDbSchemaMigrator : ITrackaDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
