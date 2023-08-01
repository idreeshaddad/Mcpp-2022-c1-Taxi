using Abp.Taxi.Permissions;
using Microsoft.Extensions.FileProviders;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
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
        private readonly IRepository<Passenger, int> _passengerRepository;

        public PassengerAppService(IRepository<Passenger, int> passengerRepository)
            : base(passengerRepository)
        {
            GetListPolicyName = TaxiPermissions.Passengers.Default;
            GetPolicyName = TaxiPermissions.Passengers.Default;
            CreatePolicyName = TaxiPermissions.Passengers.Create;
            UpdatePolicyName = TaxiPermissions.Passengers.Edit;
            DeletePolicyName = TaxiPermissions.Passengers.Delete;
            _passengerRepository = passengerRepository;
        }


        public override async Task<PassengerDetailsDto> GetAsync(int id)
        {
            await CheckGetPolicyAsync();

            var passenger = _passengerRepository
                                    .WithDetails(p => p.Bookings)
                                    .Where(p => p.Id == id)
                                    .SingleOrDefault();

          return MapToGetOutputDto(passenger);
        }
    }
}
