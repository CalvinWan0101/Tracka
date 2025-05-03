using Tracka.Localization;
using Volo.Abp.Application.Services;

namespace Tracka;

/* Inherit your application services from this class.
 */
public abstract class TrackaAppService : ApplicationService
{
    protected TrackaAppService()
    {
        LocalizationResource = typeof(TrackaResource);
    }
}
