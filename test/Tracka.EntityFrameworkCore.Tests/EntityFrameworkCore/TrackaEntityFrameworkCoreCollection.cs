using Xunit;

namespace Tracka.EntityFrameworkCore;

[CollectionDefinition(TrackaTestConsts.CollectionDefinitionName)]
public class TrackaEntityFrameworkCoreCollection : ICollectionFixture<TrackaEntityFrameworkCoreFixture>
{

}
