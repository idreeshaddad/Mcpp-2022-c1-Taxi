using Abp.Taxi.Permissions;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Abp.Taxi.Manufacturers
{
    public class ManufacturerAppService :
        CrudAppService<Manufacturer, ManufacturerDto, int, PagedAndSortedResultRequestDto>,
        IManufacturerAppService
    {
        private readonly IRepository<Manufacturer, int> _manufacturerRepository;

        public ManufacturerAppService(IRepository<Manufacturer, int> manufacturerRepository)
            : base(manufacturerRepository)
        {
            GetListPolicyName = TaxiPermissions.Manufacturers.Default;
            GetPolicyName = TaxiPermissions.Manufacturers.Default;
            CreatePolicyName = TaxiPermissions.Manufacturers.Create;
            UpdatePolicyName = TaxiPermissions.Manufacturers.Edit;
            DeletePolicyName = TaxiPermissions.Manufacturers.Delete;
            _manufacturerRepository = manufacturerRepository;
        }
    }
}
