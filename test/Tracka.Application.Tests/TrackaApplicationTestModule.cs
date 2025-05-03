using Volo.Abp.Modularity;

namespace Tracka;

[DependsOn(
    typeof(TrackaApplicationModule),
    typeof(TrackaDomainTestModule)
)]
public class TrackaApplicationTestModule : AbpModule
{

}
