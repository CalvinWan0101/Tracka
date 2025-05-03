using Tracka.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Tracka.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(TrackaEntityFrameworkCoreModule),
    typeof(TrackaApplicationContractsModule)
)]
public class TrackaDbMigratorModule : AbpModule
{
}
