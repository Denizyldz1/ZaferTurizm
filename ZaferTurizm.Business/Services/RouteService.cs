using System.Diagnostics;
using System.Linq.Expressions;
using ZaferTurizm.Business.Validators;
using ZaferTurizm.DataAccess;
using ZaferTurizm.Domain;
using ZaferTurizm.Dtos;

namespace ZaferTurizm.Business.Services
{
    public class RouteService : CrudService<RouteDto, RouteSummary, Route>, IRouteService
    {
        public RouteService(TourDbContext context, GenericValidator<Route> validator)
            : base(context, validator)
        { }

        protected override Expression<Func<Route, RouteDto>> DtoMapper =>
            entity => new RouteDto
            {
                Id = entity.Id,
                ArrivalId = entity.ArrivalCityId,
                DepartureId = entity.DepartureCityId
            };

        protected override Expression<Func<Route, RouteSummary>> SummaryMapper =>
            entity => new RouteSummary()
            {
                Id = entity.Id,
                ArrivalName = entity.ArrivalCity.Name,
                DepartureName = entity.DepartureCity.Name,
                DepartureId = entity.DepartureCityId,
                ArrivalId = entity.ArrivalCityId
            };

        public IEnumerable<CityDto> GetCityAll()
        {
            try
            {
                var dtoValues = new List<CityDto>();
                var values = _dbContext.Set<City>().ToList();
                foreach ( var value in values )
                {
                    var dto = new CityDto()
                    {
                        Id = value.Id,
                        Name = value.Name,
                    };
                    dtoValues.Add( dto );
                }
                return dtoValues;
            }
            catch (Exception ex)
            {

                Trace.TraceError(ex.ToString());
                return Enumerable.Empty<CityDto>();
            }
        }

        protected override Route MapToEntity(RouteDto entity)
        {
            return new Route()
            {
                Id = entity.Id,
                ArrivalCityId = entity.ArrivalId,
                DepartureCityId = entity.DepartureId
            };
        }
    }
}
