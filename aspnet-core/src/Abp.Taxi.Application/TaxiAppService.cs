using System;
using System.Collections.Generic;
using System.Text;
using Abp.Taxi.Localization;
using Volo.Abp.Application.Services;

namespace Abp.Taxi;

/* Inherit your application services from this class.
 */
public abstract class TaxiAppService : ApplicationService
{
    protected TaxiAppService()
    {
        LocalizationResource = typeof(TaxiResource);
    }
}
