using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZaferTurizm.Domain;

namespace ZaferTurizm.Business.Validators
{
    public class VehicleModelValidator : IValidator<VehicleModel>
    {
        public ValidationResult Validate(VehicleModel entity)
        {
            var result = new ValidationResult();
            if (entity.Id <= 0)
            {
                result.Messages.Add("Model Id boş geçilemez");
            }
            if (entity.Name == null)
            {
                result.Messages.Add("Model adı boş geçilemez");
            }
            if (entity.VehicleMakeId <=0)
            {
                result.Messages.Add("Marka adı boş geçilemez");
            }
            return result;
        }
    }
}
