using System.Threading.Tasks;

namespace Abp.Taxi.Data;

public interface ITaxiDbSchemaMigrator
{
    Task MigrateAsync();
}
