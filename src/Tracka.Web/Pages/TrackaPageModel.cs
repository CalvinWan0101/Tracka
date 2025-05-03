using Tracka.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Tracka.Web.Pages;

public abstract class TrackaPageModel : AbpPageModel
{
    protected TrackaPageModel()
    {
        LocalizationResourceType = typeof(TrackaResource);
    }
}
