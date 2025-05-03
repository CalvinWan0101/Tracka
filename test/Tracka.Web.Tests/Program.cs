using Microsoft.AspNetCore.Builder;
using Tracka;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
builder.Environment.ContentRootPath = GetWebProjectContentRootPathHelper.Get("Tracka.Web.csproj"); 
await builder.RunAbpModuleAsync<TrackaWebTestModule>(applicationName: "Tracka.Web");

public partial class Program
{
}
