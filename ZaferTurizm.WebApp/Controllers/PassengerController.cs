using Microsoft.AspNetCore.Mvc;
using ZaferTurizm.Business.Services.Passenger;
using ZaferTurizm.Dtos;

namespace ZaferTurizm.WebApp.Controllers
{
    public class PassengerController : Controller
    {
        private readonly IPassengerService _passengerService;

        public PassengerController(IPassengerService passengerService)
        {
            _passengerService = passengerService;
        }

        public IActionResult Index()
        {
            var values = _passengerService.GetAll();
            return View(values);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(PassengerDto passengerDto)
        {
           if(passengerDto == null)
            {
                return View(passengerDto);
            }
           else
            {
                var result = _passengerService.Create(passengerDto);
                if(!result.IsSuccess)
                {
                    return View(passengerDto);
                }
                else
                {
                    return RedirectToAction(nameof(Index));
                }

            }
        }
        public IActionResult Update(int id)
        {
            var value = _passengerService.GetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult Update(PassengerDto passengerDto) 
        {
            if(passengerDto == null)
            {
                return View(passengerDto);
            }
            var result = _passengerService.Update(passengerDto);
            if(!result.IsSuccess)
            {
                return View(passengerDto);
            }
            return RedirectToAction(nameof(Index));
        }
        public IActionResult GetByIdentityNumber (string identityNumber)
        {
            var values = _passengerService.GetByIdentityNumber(identityNumber);
            if(values == null)
            {
                ViewBag.IdentityNumber = "Aktif kullanıcı bulunamadı";
                return View();
            }
            ViewBag.IdentityNumber = values.IdentityNumber;
            ViewBag.Name = values.FirstName;
            ViewBag.Surname = values.LastName;
            return View();
        }
    }
}
