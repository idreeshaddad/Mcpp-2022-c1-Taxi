using Abp.Taxi.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Abp.Taxi;

[DependsOn(
    typeof(TaxiEntityFrameworkCoreTestModule)
    )]
public class TaxiDomainTestModule : AbpModule
{

}
