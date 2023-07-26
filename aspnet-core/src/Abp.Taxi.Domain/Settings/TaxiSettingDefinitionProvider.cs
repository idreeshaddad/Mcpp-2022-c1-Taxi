using Volo.Abp.Settings;

namespace Abp.Taxi.Settings;

public class TaxiSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(TaxiSettings.MySetting1));
    }
}
