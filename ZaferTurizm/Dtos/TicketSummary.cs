﻿namespace ZaferTurizm.Dtos
{
    public class TicketSummary
    {
        public int BusTripId { get; set; }
        public int SeatNumber { get; set; }
        public decimal Price { get; set; }
        public string BusTripName { get; set; }
        public string PassengerFirstName { get; set; }
        public string PassengerLastName { get; set; }
        public string PassengerIdentityNumber { get; set; }
    }
}
