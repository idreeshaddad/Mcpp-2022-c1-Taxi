using Abp.Taxi.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Abp.Taxi.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(TaxiEntityFrameworkCoreModule),
    typeof(TaxiApplicationContractsModule)
    )]
public class TaxiDbMigratorModule : AbpModule
{
}
