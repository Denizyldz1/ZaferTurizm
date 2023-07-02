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

namespace ZaferTurizm.Business.Services.Passenger
{
    public class PassengerService : CrudService<PassengerDto, PassengerDto, Domain.Passenger>, IPassengerService
    {
        public PassengerService(TourDbContext dbContext, GenericValidator<Domain.Passenger> validator) : base(dbContext, validator)
        {
        }

        protected override Expression<Func<Domain.Passenger, PassengerDto>> DtoMapper =>
            entity => new PassengerDto
            {
                Id = entity.Id,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                IdentityNumber = entity.IdentityNumber,
                Gender = entity.Gender
            };

        protected override Expression<Func<Domain.Passenger, PassengerDto>> SummaryMapper => throw new NotImplementedException();

        public PassengerDto GetByIdentityNumber(string identityNumber)
        {
            try
            {
               var value=  _dbContext.Set<ZaferTurizm.Domain.Passenger>()
                    .Where(p => p.IdentityNumber == identityNumber.ToString())
                    .Select(DtoMapper).FirstOrDefault();
                if(value == null)
                {
                    return null;
                }
                return value;
            }
            catch (Exception ex)
            {

                Trace.TraceError(ex.ToString());
                return default;
            }
        }

        protected override Domain.Passenger MapToEntity(PassengerDto dto)
        {
            return new Domain.Passenger()
            {
                Id = dto.Id,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                IdentityNumber = dto.IdentityNumber,
                Gender = dto.Gender
            };
        }
    }
}
