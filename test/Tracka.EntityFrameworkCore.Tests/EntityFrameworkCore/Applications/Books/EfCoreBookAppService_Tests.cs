using Tracka.Books;
using Xunit;

namespace Tracka.EntityFrameworkCore.Applications.Books;

[Collection(TrackaTestConsts.CollectionDefinitionName)]
public class EfCoreBookAppService_Tests : BookAppService_Tests<TrackaEntityFrameworkCoreTestModule>
{

}