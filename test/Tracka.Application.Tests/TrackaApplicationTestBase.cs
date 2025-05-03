using Volo.Abp.Modularity;

namespace Tracka;

public abstract class TrackaApplicationTestBase<TStartupModule> : TrackaTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
