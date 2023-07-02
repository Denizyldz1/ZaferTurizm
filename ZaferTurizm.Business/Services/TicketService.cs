using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ZaferTurizm.Business.Validators;
using ZaferTurizm.DataAccess;
using ZaferTurizm.Domain;
using ZaferTurizm.Dtos;

namespace ZaferTurizm.Business.Services
{
    public class TicketService : CrudService<TicketDto, TicketSummary, Ticket>, ITicketService
    {
        public TicketService(TourDbContext context, GenericValidator<Ticket> validator)
            : base(context, validator)
        {
        }

        protected override Expression<Func<Ticket, TicketDto>> DtoMapper =>
            entity => new TicketDto()
            {
                BusTripId = entity.BusTripId,
                Price = entity.Price,
                Id = entity.Id,
                PassengerFirstName = entity.Passenger.FirstName,
                PassengerLastName = entity.Passenger.LastName,
                PassengerIdentityNumber = entity.Passenger.IdentityNumber,
                SeatNumber = entity.SeatNumber,
                BusTripName = entity.BusTrip.Route.DepartureCity.Name +" -> "+ entity.BusTrip.Route.ArrivalCity.Name
            };

        protected override Expression<Func<Ticket, TicketSummary>> SummaryMapper =>
            entity => new TicketSummary()
            {
                
            };

        protected override Ticket MapToEntity(TicketDto entity)
        {
            return new Ticket()
            {
                
            };
        }

        public override CommandResult Create(TicketDto model)
        {
            try
            {
                var passenger = _dbContext.Passengers
                    .FirstOrDefault(pass => pass.FirstName == model.PassengerFirstName &&
                                            pass.LastName == model.PassengerLastName &&
                                            pass.IdentityNumber == model.PassengerIdentityNumber);

                if (passenger == null)
                {
                    passenger = new Domain.Passenger()
                    {
                        FirstName = model.PassengerFirstName,
                        LastName = model.PassengerLastName,
                        IdentityNumber = model.PassengerIdentityNumber,
                        Gender = Gender.None
                    };

                    _dbContext.Passengers.Add(passenger);
                    _dbContext.SaveChanges();
                }

                var ticket = new Ticket()
                {
                    BusTripId = model.BusTripId,
                    PassengerId = passenger.Id,
                    Price = model.Price,
                    SeatNumber = model.SeatNumber
                };

                _dbContext.Tickets.Add(ticket);
                _dbContext.SaveChanges();

                return CommandResult.Success("Bilet başarıyla kaydedildi");
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.ToString());
                return CommandResult.Failure();
            }
        }
    }
}
