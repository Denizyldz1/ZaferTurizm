using ZaferTurizm.Dtos;

namespace ZaferTurizm.Business.Services
{
    public interface IRouteService : ICrudService<RouteDto, RouteSummary>
    {
        public IEnumerable<CityDto> GetCityAll();
    }
}
