using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaferTurizm.Dtos
{
    public class BusTripInfo
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }
        public decimal Price { get; set; }
        public string RouteName
        {
            get
            {
                return DepartureName + "->" + ArrivalName;
            }
        }
        public int RouteId { get; set; }
        public string DepartureName { get; set; }
        public int DepartureId { get; set; }
        public string ArrivalName { get; set; }
        public int ArrivalId { get; set; }


        public string VehicleName
        {
            get
            {
                return VehicleMakeName + " " + VehicleModelName + " " + PlateNumber;
            }
        }
        public string VehicleMakeName { get; set; }
        public string VehicleModelName { get; set; }
        public string PlateNumber { get; set; }
        public int SeatCount { get; set; }
    }
}
