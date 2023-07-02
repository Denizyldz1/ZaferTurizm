using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZaferTurizm.Domain;

namespace ZaferTurizm.DataAccess.SeedData
{
    internal class BusTripData
    {
        public static readonly BusTrip Data01 = new BusTrip() { Id = 1, RouteId = 1, VehicleId = 1 , Date = Convert.ToDateTime("30.08.2023"), Price = 500 };
        public static readonly BusTrip Data02 = new BusTrip() { Id = 2, RouteId = 2, VehicleId = 2 , Date = Convert.ToDateTime("23.09.2023"), Price = 550 };
        public static readonly BusTrip Data03 = new BusTrip() { Id = 3, RouteId = 3, VehicleId = 3 , Date = Convert.ToDateTime("23.10.2023"), Price = 650 };
        public static readonly BusTrip Data04 = new BusTrip() { Id = 4, RouteId = 4, VehicleId = 4 , Date = Convert.ToDateTime("23.11.2023"), Price = 750 };
    }
}
