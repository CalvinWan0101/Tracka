using Tracka.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Tracka.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class TrackaController : AbpControllerBase
{
    protected TrackaController()
    {
        LocalizationResource = typeof(TrackaResource);
    }
}
