using Abp.Taxi.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Abp.Taxi.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class TaxiController : AbpControllerBase
{
    protected TaxiController()
    {
        LocalizationResource = typeof(TaxiResource);
    }
}
