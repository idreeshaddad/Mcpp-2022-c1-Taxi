using Volo.Abp.Modularity;

namespace Abp.Taxi;

[DependsOn(
    typeof(TaxiApplicationModule),
    typeof(TaxiDomainTestModule)
    )]
public class TaxiApplicationTestModule : AbpModule
{

}
