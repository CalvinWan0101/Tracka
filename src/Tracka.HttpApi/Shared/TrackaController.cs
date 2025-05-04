using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tracka.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Tracka.Shared;

/* Inherit your controllers from this class.
 */
public abstract class TrackaController : AbpControllerBase {
    protected TrackaController() {
        LocalizationResource = typeof(TrackaResource);
    }

    protected JsonResult Json(object obj = null, int statusCode = StatusCodes.Status200OK) {
        return new JsonResult(obj ?? "Work Success") {
            StatusCode = statusCode
        };
    }
}
