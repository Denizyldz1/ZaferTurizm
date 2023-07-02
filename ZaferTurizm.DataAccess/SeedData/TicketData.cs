using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZaferTurizm.Domain;

namespace ZaferTurizm.DataAccess.SeedData
{
    internal class TicketData
    {
        public static readonly Ticket Data01 = new Ticket() { Id = 1, BusTripId = 1 , PassengerId = 1 , SeatNumber = 10 , Price = 500};
        public static readonly Ticket Data02 = new Ticket() { Id = 2, BusTripId = 2 , PassengerId = 2 , SeatNumber = 10 , Price = 550};
        public static readonly Ticket Data03 = new Ticket() { Id = 3, BusTripId = 3 , PassengerId = 3 , SeatNumber = 10 , Price = 650};
    }
}
