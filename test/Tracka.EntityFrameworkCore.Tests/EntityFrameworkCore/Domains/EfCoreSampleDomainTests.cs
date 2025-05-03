using Tracka.Samples;
using Xunit;

namespace Tracka.EntityFrameworkCore.Domains;

[Collection(TrackaTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<TrackaEntityFrameworkCoreTestModule>
{

}
