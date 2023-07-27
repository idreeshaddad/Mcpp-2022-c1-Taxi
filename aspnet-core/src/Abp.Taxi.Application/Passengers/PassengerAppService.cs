using Abp.Taxi.Permissions;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Abp.Taxi.Passengers
{
    public class PassengerAppService :
        CrudAppService<
            Passenger,
            PassengerDetailsDto,
            PassengerDto,
            int,
            PagedAndSortedResultRequestDto,
            CreateUpdatePassengerDto,
            CreateUpdatePassengerDto>,
        IPassengerAppService
    {
        public PassengerAppService(IRepository<Passenger, int> passengerRepository)
            : base(passengerRepository)
        {
            GetListPolicyName = TaxiPermissions.Passengers.Default;
            GetPolicyName = TaxiPermissions.Passengers.Default;
            CreatePolicyName = TaxiPermissions.Passengers.Create;
            UpdatePolicyName = TaxiPermissions.Passengers.Edit;
            DeletePolicyName = TaxiPermissions.Passengers.Delete;
        }
    }
}
