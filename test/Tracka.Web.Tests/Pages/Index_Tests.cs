using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Tracka.Pages;

[Collection(TrackaTestConsts.CollectionDefinitionName)]
public class Index_Tests : TrackaWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
