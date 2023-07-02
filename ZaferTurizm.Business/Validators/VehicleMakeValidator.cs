using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZaferTurizm.Domain;

namespace ZaferTurizm.Business.Validators
{
    public class VehicleMakeValidator : IValidator<VehicleMake>
    {
        public ValidationResult Validate(VehicleMake entity)
        {
           var result = new ValidationResult();
            if (entity.Id <= 0)
            {
                result.Messages.Add("Marka adı boş geçilemez");
            }
            return result;
        }
    }
}
