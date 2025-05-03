using Tracka.Samples;
using Xunit;

namespace Tracka.EntityFrameworkCore.Applications;

[Collection(TrackaTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<TrackaEntityFrameworkCoreTestModule>
{

}
