using System.Diagnostics;
using System.Linq.Expressions;
using ZaferTurizm.Business.Validators;
using ZaferTurizm.DataAccess;
using ZaferTurizm.Domain;
using ZaferTurizm.Dtos;

namespace ZaferTurizm.Business.Services
{
    public class BusTripService : CrudService<BusTripDto, BusTripInfo, BusTrip>, IBusTripService
    {
        public BusTripService(TourDbContext context, BusTripValidator validator) : base(context, validator)
        { }

        protected override Expression<Func<BusTrip, BusTripDto>> DtoMapper =>
            entity => new BusTripDto()
            {
                Id = entity.Id,
                RouteId = entity.RouteId,
                VehicleId = entity.VehicleId,
                Date = entity.Date,
                Price = entity.Price,
            };

        protected override Expression<Func<BusTrip, BusTripInfo>> SummaryMapper =>
            entity => new BusTripInfo()
            {
                Id = entity.Id,
                Date = entity.Date,
                Price = entity.Price,
                DepartureName = entity.Route.DepartureCity.Name,
                ArrivalName = entity.Route.ArrivalCity.Name,
                VehicleMakeName = entity.Vehicle.VehicleDefinition.VehicleModel.VehicleMake.Name,
                VehicleModelName = entity.Vehicle.VehicleDefinition.VehicleModel.Name,
                PlateNumber = entity.Vehicle.PlateNumber,
                SeatCount = entity.Vehicle.VehicleDefinition.SeatCount,
                DepartureId = entity.Route.DepartureCityId,
                ArrivalId = entity.Route.ArrivalCityId,
                RouteId = entity.RouteId
                


            };

        public BusTripDetails? GetBusTripDetails(int id)
        {
            try
            {
                return _dbContext.BusTrips
                    .Where(busTrip => busTrip.Id == id)
                    .Select(busTrip => new BusTripDetails()
                    {
                        BusTripId = busTrip.Id,
                        Date = busTrip.Date,
                        TicketPrice = busTrip.Price,
                        SeatCount = busTrip.Vehicle.VehicleDefinition.SeatCount,
                        VehicleMakeName = busTrip.Vehicle.VehicleDefinition.VehicleModel.VehicleMake.Name,
                        VehicleModelName = busTrip.Vehicle.VehicleDefinition.VehicleModel.Name,
                        PlateNumber = busTrip.Vehicle.PlateNumber,
                        DepartureName = busTrip.Route.DepartureCity.Name,
                        ArrivalName = busTrip.Route.ArrivalCity.Name
                    })
                    .SingleOrDefault();
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());
                return default;
            }
        }

        public IEnumerable<BusTripInfo> GetTripsWithRouteId(int id)
        {
            try
            {
                return _dbContext.BusTrips
                    .Where(x => x.RouteId == id)
                    .Select(SummaryMapper).ToList();
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());
                return Enumerable.Empty<BusTripInfo>();

            }
        }

        protected override BusTrip MapToEntity(BusTripDto entity)
        {
            return new BusTrip()
            {
                Id = entity.Id,
                Date = entity.Date,
                Price = entity.Price,
                RouteId = entity.RouteId,
                VehicleId = entity.VehicleId,
            };
        }
    }
}
