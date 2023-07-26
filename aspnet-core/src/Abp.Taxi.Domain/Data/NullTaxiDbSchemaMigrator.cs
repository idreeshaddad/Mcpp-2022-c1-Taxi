using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Abp.Taxi.Data;

/* This is used if database provider does't define
 * ITaxiDbSchemaMigrator implementation.
 */
public class NullTaxiDbSchemaMigrator : ITaxiDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
