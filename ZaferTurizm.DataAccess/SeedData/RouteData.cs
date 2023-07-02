using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZaferTurizm.Domain;

namespace ZaferTurizm.DataAccess.SeedData
{
    internal class RouteData
    {
        public static readonly Route Data01_IzmirIstanbul = new Route()
        {
            Id = 1,
            DepartureCityId = CityData.Data35_İzmir.Id,
            ArrivalCityId = CityData.Data34_İstanbul.Id
        };

        public static readonly Route Data02_IstanbulAnkara = new Route()
        {
            Id = 2,
            DepartureCityId = CityData.Data34_İstanbul.Id,
            ArrivalCityId = CityData.Data06_Ankara.Id
        };

        public static readonly Route Data03_IstanbulAntalya = new Route()
        {
            Id = 3,
            DepartureCityId = CityData.Data34_İstanbul.Id,
            ArrivalCityId = CityData.Data07_Antalya.Id
        };

        public static readonly Route Data04_AnkaraIzmir = new Route()
        {
            Id = 4,
            DepartureCityId = CityData.Data06_Ankara.Id,
            ArrivalCityId = CityData.Data35_İzmir.Id
        };
    }
}
