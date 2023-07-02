using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZaferTurizm.Dtos;

namespace ZaferTurizm.Business.Services.Passenger
{
    public interface IPassengerService : ICrudService<PassengerDto,PassengerDto>
    {
        PassengerDto GetByIdentityNumber (string identityNumber);
    }
}
