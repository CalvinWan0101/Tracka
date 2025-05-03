using System.Threading.Tasks;

namespace Tracka.Data;

public interface ITrackaDbSchemaMigrator
{
    Task MigrateAsync();
}
