using Volo.Abp.Modularity;

namespace Tracka;

[DependsOn(
    typeof(TrackaDomainModule),
    typeof(TrackaTestBaseModule)
)]
public class TrackaDomainTestModule : AbpModule
{

}
