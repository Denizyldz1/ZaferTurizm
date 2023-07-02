﻿namespace ZaferTurizm.Dtos
{
    public class RouteSummary
    {
        public int Id { get; set; }
        public int DepartureId { get; set; }
        public int ArrivalId { get; set; }
        public string DepartureName { get; set; }
        public string ArrivalName { get; set; }

        // Computed Property
        public string RouteName { get { return DepartureName + "->" + ArrivalName; } }
    }
}
