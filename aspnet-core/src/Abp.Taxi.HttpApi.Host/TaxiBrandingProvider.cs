using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Abp.Taxi;

[Dependency(ReplaceServices = true)]
public class TaxiBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Taxi";
}
