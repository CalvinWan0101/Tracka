using Volo.Abp.Modularity;

namespace Tracka;

/* Inherit from this class for your domain layer tests. */
public abstract class TrackaDomainTestBase<TStartupModule> : TrackaTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
